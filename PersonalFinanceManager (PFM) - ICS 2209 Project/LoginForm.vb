Imports MySql.Data.MySqlClient
Imports Bcr = BCrypt.Net.BCrypt
Imports System.IO
Imports Mysqlx

'Pre-requisite packages
'- MySqlData
'- MySqlConnector
'- BCrypt

Public Class LoginForm

    Dim TextBoxList As New List(Of TextBox)

    Function CreateDatabase(scriptPath As String) As Boolean
        Dim connection As MySqlConnection = New MySqlConnection(connectionString)
        Try
            connection.Open()
            Dim command As MySqlCommand = New MySqlCommand(File.ReadAllText(scriptPath), connection)
            command.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MessageBox.Show("Error creating database: " & ex.Message)
            Return False
        Finally
            connection.Close()
        End Try
    End Function

    Function DatabaseExists(dbName As String) As Boolean
        Dim connection As MySqlConnection = New MySqlConnection(connectionString)
        Dim exists As Boolean = False

        Try
            connection.Open()
            Dim command As MySqlCommand = New MySqlCommand("SHOW DATABASES LIKE '" & dbName & "'", connection)
            Dim reader As MySqlDataReader = command.ExecuteReader()
            exists = reader.HasRows
            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error checking database existence: " & ex.Message)
        Finally
            connection.Close()
        End Try

        Return exists
    End Function

    Function ConnectionSuccessful() As Boolean
        Dim connection As MySqlConnection
        Try
            connection = New MySqlConnection(connectionString)
            connection.Open()
            connection.Close()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True

        If loginCount = 0 Then
            TextBoxList.Add(UserNameTextBox)
            TextBoxList.Add(PasswordTextBox)
        End If
        loginCount += 1
    End Sub

    Private Sub LoginForm_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        If ConnectionSuccessful() Then
            If Not DatabaseExists("PFM") Then
                CreateDatabase("../../../final_db.sql")
                MessageBox.Show("Database successfully created.")
            End If
            Acc.connectionString += "Database = PFM;"
        Else
            MessageBox.Show("No connection details provided. Add them in the connection string at Acc module file (Acc.vb)", "Connection Failed")
            Me.Close()
        End If
    End Sub

    Private Sub BackPanel_Paint(sender As Object, e As PaintEventArgs) Handles BackPanel.Paint
        BackPanel.BackColor = Color.FromArgb(80, Color.Black)
    End Sub

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        Dim EmptyTextBoxFound As Boolean

        For Each textbox In TextBoxList
            If String.IsNullOrEmpty(textbox.Text) Then
                If textbox Is UserNameTextBox Then
                    UserNameWarningLabel.Text = "*Username cannot be an empty field"
                End If

                If textbox Is PasswordTextBox Then
                    PasswordWarningLabel.Text = "*Password cannot be an empty field"
                End If

                EmptyTextBoxFound = True
            End If
        Next

        If EmptyTextBoxFound Then
            Return
        End If

        Using connection As New MySqlConnection(connectionString)
            connection.Open()

            Dim LoginQuery As String = "SELECT UserID, Password FROM User WHERE Username = @username"
            Using command As New MySqlCommand(LoginQuery, connection)
                command.Parameters.AddWithValue("@username", UserNameTextBox.Text)

                Dim reader As MySqlDataReader = command.ExecuteReader()

                If reader.Read() Then
                    If Bcr.Verify(PasswordTextBox.Text, reader("Password").ToString()) Then

                        Dim fetchIDQuery As String = "SELECT AccountID FROM Account WHERE UserID = @ID"
                        Using IDcommand As New MySqlCommand(fetchIDQuery, connection)
                            IDcommand.Parameters.AddWithValue("@ID", reader("UserID"))
                            reader.Close()

                            Try
                                Id = CInt(IDcommand.ExecuteScalar())
                                Username = UserNameTextBox.Text
                            Catch ex As Exception
                                MessageBox.Show("ID fetch failed.")
                                Return
                            End Try
                        End Using

                        Dim obj As New Account()
                        obj.Show()
                        Me.Hide()
                    Else
                        MessageBox.Show("Wrong password. Retry with a valid one")
                    End If
                Else
                    MessageBox.Show("User not found. Enter valid username")
                End If

            End Using
        End Using

    End Sub

    Private Sub UserNameTextBox_TextChanged(sender As Object, e As EventArgs) Handles UserNameTextBox.TextChanged
        If Not String.IsNullOrEmpty(UserNameWarningLabel.Text) Then
            UserNameWarningLabel.Text = ""
        End If
    End Sub

    Private Sub PasswordTextBox_TextChanged(sender As Object, e As EventArgs) Handles PasswordTextBox.TextChanged
        If Not String.IsNullOrEmpty(PasswordWarningLabel.Text) Then
            PasswordWarningLabel.Text = ""
        End If
    End Sub

    Private Sub SignUpLabel_Click(sender As Object, e As EventArgs) Handles SignUpLabel.Click
        Dim regForm As New Form1
        regForm.Show()
        Me.Hide()
    End Sub

    Private Sub ExitLabel_Click(sender As Object, e As EventArgs) Handles ExitLabel.Click
        Me.Close()
    End Sub

End Class
