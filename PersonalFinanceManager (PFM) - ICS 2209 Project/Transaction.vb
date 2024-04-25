Imports System.ComponentModel
Imports System.Drawing.Drawing2D
Imports MySql.Data.MySqlClient
Imports Transaction_UI.Form3
Imports System.Drawing.Text


Public Class Transaction
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
    Dim TransactionList As New List(Of Transaction)

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim objDemo As New Financial_goals()
        Financial_goals.Show()
        Me.Hide()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim obj As New LoginForm()
        LoginForm.Show()
        Me.Close()
    End Sub


    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Dim objDemo As New Form2()
        objDemo.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim objDemo As New Loans
        Loans.Show()
        Hide()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim objDemo As New Budgeting()
        Budgeting.Show()
        Me.Hide()
    End Sub


    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim objDemo As New Account()
        Account.Show()
        Me.Hide()
    End Sub

    Private Sub LoadTransactionsSummaryFromDatabase()

        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' Define the SQL query to retrieve goals from the database
                Dim query As String = "SELECT TransactionID, TransactionType, Amount, Origin, Destination, TransactionDate FROM Transaction WHERE AccountID = @AccountID"
                ' Create a MySqlCommand object with the query and connection
                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@AccountID", Id)
                    ' Execute the query and read the results
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim newTransaction As New Transaction With {
                                .TransactionID = reader("TransactionID"),
                                .TransactionType = reader("TransactionType"),
                                .Amount = reader("Amount"),
                                .Origin = reader("Origin"),
                                .Destination = reader("Destination"),
                                .TransactionDate = reader("TransactionDate")
                             }
                            TransactionList.Add(newTransaction)
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while loading Transactions from the database: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadDepositTransactionsFromDatabase()

        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' Define the SQL query to retrieve goals from the database
                Dim query As String = "SELECT TransactionID, Amount, Origin, Destination, TransactionDate FROM Transaction WHERE AccountID = @AccountID AND TransactionType = 'Deposit'"
                ' Create a MySqlCommand object with the query and connection
                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@AccountID", Id)
                    ' Execute the query and read the results
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim newTransaction As New Transaction With {
                                .TransactionID = reader("TransactionID"),
                                .TransactionType = "Deposit",
                                .Amount = reader("Amount"),
                                .Origin = reader("Origin"),
                                .Destination = reader("Destination"),
                                .TransactionDate = reader("TransactionDate")
                             }
                            TransactionList.Add(newTransaction)
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while loading Deposits from the database: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadWithdrawalTransactionsFromDatabase()

        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' Define the SQL query to retrieve goals from the database
                Dim query As String = "SELECT TransactionID, Amount, Origin, Destination, TransactionDate FROM Transaction WHERE AccountID = @AccountID AND TransactionType = 'Withdrawal'"
                ' Create a MySqlCommand object with the query and connection
                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@AccountID", Id)
                    ' Execute the query and read the results
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim newTransaction As New Transaction With {
                                .TransactionID = reader("TransactionID"),
                                .TransactionType = "Withdrawal",
                                .Amount = reader("Amount"),
                                .Origin = reader("Origin"),
                                .Destination = reader("Destination"),
                                .TransactionDate = reader("TransactionDate")
                             }
                            TransactionList.Add(newTransaction)
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while loading Withdrawals from the database: " & ex.Message)
        End Try
    End Sub

    Private Sub DisplayTransaction()
        DataGridView1.Rows.Clear()

        For Each currentTransaction As Transaction In TransactionList
            Dim row As String() = {currentTransaction.TransactionID, currentTransaction.TransactionType.ToString(), currentTransaction.Amount.ToString(), currentTransaction.Origin.ToString(), currentTransaction.Destination.ToString(), currentTransaction.TransactionDate.ToShortDateString()}
            DataGridView1.Rows.Add(row)
        Next
    End Sub
    'Withdrawal transactions
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        TransactionList.Clear()
        LoadDepositTransactionsFromDatabase()
        DisplayTransaction()
    End Sub

    'Deposit transactions
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TransactionList.Clear()
        LoadWithdrawalTransactionsFromDatabase()
        DisplayTransaction()
    End Sub

    'Display Transaction summary
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        TransactionList.Clear()
        LoadTransactionsSummaryFromDatabase()
        DisplayTransaction()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Dim obj As New LoansDebtsReport()
        LoansDebtsReport.Show()
        Me.Hide()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class
