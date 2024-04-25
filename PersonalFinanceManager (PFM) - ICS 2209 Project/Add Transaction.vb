Imports System.Drawing.Drawing2D
Imports MySql.Data.MySqlClient
Imports Transaction_UI.Form3
Public Class Form2
    Public Structure Transaction
        Dim TransactionID As Integer
        Dim AccountID As Integer
        Dim TransactionType As String
        Dim Amount As Decimal
        Dim Origin As String
        Dim Destination As String
        Dim TransactionDate As Date
    End Structure

    Dim connection As MySqlConnection

    'Input Saving after Validation
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Validate the starting amount, target amount, and target date
        If IsValidInput() Then

            Try
                Using connection As New MySqlConnection(connectionString)
                    connection.Open()

                    ' Define the SQL query to insert the goal data into the database
                    Dim query As String = "INSERT INTO Transaction (AccountID, TransactionDate, Amount, TransactionType, Origin, Destination) VALUES (@AccountID, @TransactionDate, @Amount, @TransactionType, @Origin, @Destination)"

                    ' Create a MySqlCommand object with the query and connection
                    Using cmd As New MySqlCommand(query, connection)
                        ' Add parameters to the query
                        cmd.Parameters.AddWithValue("@AccountID", Id)
                        cmd.Parameters.AddWithValue("@TransactionDate", DateTimePicker1.Value)
                        cmd.Parameters.AddWithValue("@Amount", Decimal.Parse(TextBox3.Text))
                        cmd.Parameters.AddWithValue("@TransactionType", ComboBox2.Text)
                        cmd.Parameters.AddWithValue("@Origin", ComboBox3.Text)
                        cmd.Parameters.AddWithValue("@Destination", ComboBox1.Text)

                        ' Execute the query
                        cmd.ExecuteNonQuery()
                    End Using
                End Using

                ' Clear the text boxes to prepare for entering a new goal
                ClearBoxes()
                MessageBox.Show("Transaction recorded successfully.", "Transaction success")
            Catch ex As Exception
                MessageBox.Show("An error occurred while saving Transactions: " & ex.Message)
            End Try

        End If
    End Sub

    'Input Validation function
    Private Function IsValidInput() As Boolean
        ' Check if any text box is empty
        If String.IsNullOrWhiteSpace(TextBox3.Text) OrElse String.IsNullOrWhiteSpace(ComboBox2.Text) OrElse String.IsNullOrWhiteSpace(ComboBox3.Text) OrElse String.IsNullOrWhiteSpace(ComboBox1.Text) Then
            MessageBox.Show("Please ensure that all fields are filled out.")
            Return False
        End If

        ' If all checks pass, return True
        Return True
    End Function

    Private Sub ClearBoxes()
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""
        TextBox3.Clear()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        ' Close the MySQL connection if it's open
        If connection IsNot Nothing AndAlso connection.State = ConnectionState.Open Then
            connection.Close()
        End If
        Me.Close()
    End Sub

End Class