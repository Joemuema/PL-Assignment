Imports System.Text.RegularExpressions
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports MySql.Data.MySqlClient
Imports Mysqlx
Imports Bcr = BCrypt.Net.BCrypt

'install bcrypt.net-next, mysql data and mysql connector packages in NuGetPM'

Public Class Form1

    Dim TextBoxList As New List(Of TextBox)
    Dim LabelList As New List(Of Label)
    Dim FullNameRegex As String = "^[A-Za-z\s]+$"
    Dim UserNameRegex As String = "^[A-Za-z0-9_]{6,}$"
    Dim EmailRegex As String = "^[A-Za-z0-9+_.-]+@[A-Za-z0-9.-]+\.[A-Za-z]+$"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True

        TextBoxList.Add(FullNameTextBox)
        TextBoxList.Add(UserNameTextBox)
        TextBoxList.Add(EmailTextBox)
        TextBoxList.Add(PasswordTextBox)
        TextBoxList.Add(ConfirmPasswordTextBox)

        LabelList.Add(FullNameWarningLabel)
        LabelList.Add(UserNameWarningLabel)
        LabelList.Add(EmailWarningLabel)
        LabelList.Add(PasswordWarningLabel)
        LabelList.Add(CPWarningLabel)
    End Sub

    Private Sub BackPanel_Paint(sender As Object, e As PaintEventArgs) Handles BackPanel.Paint
        BackPanel.BackColor = Color.FromArgb(80, Color.Black)
    End Sub

    Private Sub RegisterButton_Click(sender As Object, e As EventArgs) Handles RegisterButton.Click
        Dim EmptyTextBoxFound As Boolean
        For Each textbox In TextBoxList
            If String.IsNullOrEmpty(textbox.Text) Then
                If textbox Is FullNameTextBox Then
                    FullNameWarningLabel.Text = "*Full name cannot be an empty field"
                End If

                If textbox Is UserNameTextBox Then
                    UserNameWarningLabel.Text = "*Username cannot be an empty field"
                End If

                If textbox Is EmailTextBox Then
                    EmailWarningLabel.Text = "*Email cannot be an empty field"
                End If

                If textbox Is PasswordTextBox Then
                    PasswordWarningLabel.Text = "*Password cannot be an empty field"
                End If

                If textbox Is ConfirmPasswordTextBox Then
                    CPWarningLabel.Text = "*Password cannot be an empty field"
                End If

                EmptyTextBoxFound = True
            End If
        Next

        If EmptyTextBoxFound Then
            Return
        End If

        Dim FullName As String = FullNameTextBox.Text.Trim()
        If FullName.Replace(" ", "").Length = FullName.Length Then
            FullNameWarningLabel.Text = "*Give at least 2 names"
        End If

        If Not Regex.IsMatch(FullName, FullNameRegex) Then
            FullNameWarningLabel.Text = "*Should only contain alphabetical letters"
        End If

        If Not Regex.IsMatch(UserNameTextBox.Text.Trim(), UserNameRegex) Then
            If UserNameTextBox.Text.Length < 6 Then
                UserNameWarningLabel.Text = "*Must be at 6 characters long"
            Else
                UserNameWarningLabel.Text = "*Only alphanumeric characters and _ allowed"
            End If
        End If

        If Not Regex.IsMatch(EmailTextBox.Text.Trim(), EmailRegex) Then
            EmailWarningLabel.Text = "*Wrong email format"
        End If

        Dim password As String = PasswordTextBox.Text.Trim()
        If Not password.Any(Function(c) Char.IsDigit(c)) Then
            PasswordWarningLabel.Text = "*Should have at least 1 digit"
        End If

        If Not password.Any(Function(c) Char.IsLower(c)) Then
            PasswordWarningLabel.Text = "*Should have at least 1 lowercase letter"
        End If

        If Not password.Any(Function(c) Char.IsUpper(c)) Then
            PasswordWarningLabel.Text = "*Should have at least 1 uppercase letter"
        End If

        If Not password.Replace(" ", "").Length = password.Length Then
            PasswordWarningLabel.Text = "*Should have no white space characters"
        End If

        If password.Length < 8 Then
            PasswordWarningLabel.Text = "*Should have at least 8 characters"
        End If

        If Not PasswordTextBox.Text = ConfirmPasswordTextBox.Text Then
            CPWarningLabel.Text = "*Does not match original password"
        End If

        For Each WarningLabel In LabelList
            If Not String.IsNullOrEmpty(WarningLabel.Text) Then
                Return
            End If
        Next


        Using connection As New MySqlConnection(connectionString)
            connection.Open()

            Dim registerQuery As String = "INSERT INTO User (OfficialName, Username, Email, Password)
                                           VALUES (@fullname, @username, @email, @encrypt_pass)"

            Using registerCommand As New MySqlCommand(registerQuery, connection)
                registerCommand.Parameters.AddWithValue("@fullname", FullNameTextBox.Text)
                registerCommand.Parameters.AddWithValue("@username", UserNameTextBox.Text)
                registerCommand.Parameters.AddWithValue("@email", EmailTextBox.Text)
                registerCommand.Parameters.AddWithValue("@encrypt_pass", Bcr.HashPassword(PasswordTextBox.Text))

                Try
                    registerCommand.ExecuteNonQuery()
                Catch sqlEx As MySqlException
                    MessageBox.Show("Registration failed: " & sqlEx.Message)
                    Return
                Catch ex As Exception
                    MessageBox.Show("Registration failed: " & ex.Message)
                    Return
                End Try
            End Using

            Dim selectIDQuery As String = "SELECT UserID FROM User WHERE Username = @select_username"
            Dim UserID As Integer

            Using selectIDCommand As New MySqlCommand(selectIDQuery, connection)
                selectIDCommand.Parameters.AddWithValue("@select_username", UserNameTextBox.Text)

                Dim ID_reader As MySqlDataReader = selectIDCommand.ExecuteReader()

                If ID_reader.Read() Then
                    UserID = CInt(ID_reader("UserID"))
                Else
                    MessageBox.Show("Error occurred. User ID not found")
                    Return
                End If

                ID_reader.Close()
            End Using

            Dim createAccountQuery As String = "INSERT INTO Account (UserID, Username, AccountBalance, DateCreated)
                                                VALUES (@userid, @username_copy, @accountbalance, NOW())"

            Using createAccountCommand As New MySqlCommand(createAccountQuery, connection)
                createAccountCommand.Parameters.AddWithValue("@userid", UserID)
                createAccountCommand.Parameters.AddWithValue("@username_copy", UserNameTextBox.Text)
                createAccountCommand.Parameters.AddWithValue("@accountbalance", 0)

                Try
                    createAccountCommand.ExecuteNonQuery()
                Catch sqlEx As MySqlException
                    MessageBox.Show("Account creation failed: " & sqlEx.Message)
                    Return
                Catch ex As Exception
                    MessageBox.Show("Account creation failed: " & ex.Message)
                    Return
                End Try
            End Using

        End Using

        Dim logForm As New LoginForm
        logForm.Show()
        Me.Hide()
    End Sub

    Private Sub FullNameTextBox_TextChanged(sender As Object, e As EventArgs) Handles FullNameTextBox.TextChanged
        If Not String.IsNullOrEmpty(FullNameWarningLabel.Text) Then
            FullNameWarningLabel.Text = ""
        End If
    End Sub

    Private Sub UserNameTextBox_TextChanged(sender As Object, e As EventArgs) Handles UserNameTextBox.TextChanged
        If Not String.IsNullOrEmpty(UserNameWarningLabel.Text) Then
            UserNameWarningLabel.Text = ""
        End If
    End Sub

    Private Sub EmailTextBox_TextChanged(sender As Object, e As EventArgs) Handles EmailTextBox.TextChanged
        If Not String.IsNullOrEmpty(EmailWarningLabel.Text) Then
            EmailWarningLabel.Text = ""
        End If
    End Sub

    Private Sub PasswordTextBox_TextChanged(sender As Object, e As EventArgs) Handles PasswordTextBox.TextChanged
        If Not String.IsNullOrEmpty(PasswordWarningLabel.Text) Then
            PasswordWarningLabel.Text = ""
        End If
    End Sub

    Private Sub ConfirmPasswordTextBox_TextChanged(sender As Object, e As EventArgs) Handles ConfirmPasswordTextBox.TextChanged
        If Not String.IsNullOrEmpty(CPWarningLabel.Text) Then
            CPWarningLabel.Text = ""
        End If
    End Sub

    Private Sub SignUpLabel_Click(sender As Object, e As EventArgs) Handles SignUpLabel.Click
        Dim logForm As New LoginForm
        logForm.Show()
        Me.Hide()
    End Sub

End Class