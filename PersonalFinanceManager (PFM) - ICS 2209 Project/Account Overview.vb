Imports System.Data.SqlTypes
Imports MySql.Data.MySqlClient

Public Class Account
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim objDemo As New Transaction()
        Transaction.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim objDemo As New Loans()
        Loans.Show()
        Me.Hide()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim objDemo As New Budgeting()
        Budgeting.Show()
        Me.Hide()
    End Sub

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

    Private Sub Account_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UsernameLabel.Text = "Welcome, " & Username.ToString

        AddHandler TransactionDataGridView.DataBindingComplete, AddressOf TransactionDataGridView_DataBindingComplete
        AddHandler LoanDataGridView.DataBindingComplete, AddressOf LoanDataGridView_DataBindingComplete
        AddHandler DebtDataGridView.DataBindingComplete, AddressOf DebtDataGridView_DataBindingComplete
        AddHandler GoalDataGridView.DataBindingComplete, AddressOf GoalDataGridView_DataBindingComplete

        FetchTotalIncome()
        FetchTotalExpenses()
        DisplayLatestTransaction()
        DisplayNearestLoan()
        DisplayNearestDebt()
        DisplayClosestGoal()
    End Sub

    Public Sub FetchTotalIncome()
        Try
            Dim totalIncome As Decimal = 0
            Dim recordCount As Integer

            Dim sqlQuery As String = "SELECT SUM(Amount) AS TotalIncome FROM income WHERE AccountID = @AccountID"
            Dim checkQuery As String = "SELECT COUNT(*) AS RecordNumber FROM income WHERE AccountID = @AccountID"

            Using sqlConn As New MySqlConnection(connectionString), sqlCmd As New MySqlCommand(sqlQuery, sqlConn), checkCommand As New MySqlCommand(checkQuery, sqlConn)
                sqlConn.Open()

                checkCommand.Parameters.AddWithValue("@AccountID", Id)
                recordCount = CInt(checkCommand.ExecuteScalar())
                If recordCount > 0 Then
                    sqlCmd.Parameters.AddWithValue("@AccountID", Id)
                    totalIncome = Convert.ToDecimal(sqlCmd.ExecuteScalar())
                End If

                IncomeTextBox.Text = totalIncome.ToString("N2")
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while fetching total income: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub FetchTotalExpenses()
        Try
            Dim totalExpenses As Decimal = 0
            Dim recordCount As Integer

            Dim checkQuery As String = "SELECT COUNT(*) AS RecordNumber FROM expenses WHERE AccountID = @AccountID"
            Dim sqlQuery As String = "SELECT SUM(Amount) AS TotalExpenses FROM expenses WHERE AccountID = @AccountID"

            Using sqlConn As New MySqlConnection(connectionString), sqlCmd As New MySqlCommand(sqlQuery, sqlConn), checkCommand As New MySqlCommand(checkQuery, sqlConn)
                sqlConn.Open()

                checkCommand.Parameters.AddWithValue("@AccountID", Id)
                recordCount = CInt(checkCommand.ExecuteScalar())
                If recordCount > 0 Then
                    sqlCmd.Parameters.AddWithValue("@AccountID", Id)
                    totalExpenses = Convert.ToDecimal(sqlCmd.ExecuteScalar())
                Else
                    totalExpenses = 0
                End If

                ExpensesTextBox.Text = totalExpenses.ToString("N2")
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while fetching total expenses: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub DisplayLatestTransaction()
        Using connection As New MySqlConnection(connectionString)
            Dim recordCount As Integer = 0

            Dim checkQuery As String = "SELECT COUNT(*) AS RecordNumber FROM PFM.Transaction WHERE AccountID = @AccountID"
            Dim transactionQuery As String = "SELECT TransactionID, TransactionType, Amount, Origin, Destination, TransactionDate FROM Transaction 
                                              WHERE AccountID = @AccountID
                                              ORDER BY TransactionID DESC
                                              LIMIT 1;"

            Using transactionCommand As New MySqlCommand(transactionQuery, connection), checkCommand As New MySqlCommand(checkQuery, connection)
                transactionCommand.Parameters.AddWithValue("@AccountID", Id)
                checkCommand.Parameters.AddWithValue("@AccountID", Id)

                Dim transactionDataAdapter As New MySqlDataAdapter(transactionCommand)
                Dim transactionDataTable As New DataTable()

                Try
                    connection.Open()

                    recordCount = CInt(checkCommand.ExecuteScalar())
                    If recordCount > 0 Then
                        Label1.Text = "Last Transaction"
                    Else
                        Label1.Text = "Last Transaction (No transactions to show. Record your transactions in the Transactions section to display.)"
                    End If

                    transactionDataAdapter.Fill(transactionDataTable)
                    TransactionDataGridView.DataSource = transactionDataTable

                    ' Set column headers
                    With TransactionDataGridView.Columns
                        .Item("TransactionID").HeaderText = "Transaction ID"
                        .Item("TransactionType").HeaderText = "Transaction Type"
                        .Item("Amount").HeaderText = "Transaction Amount"
                        .Item("Origin").HeaderText = "Transaction Origin"
                        .Item("Destination").HeaderText = "Transaction Destination"
                        .Item("TransactionDate").HeaderText = "Transaction Date"
                    End With

                Catch sqlEx As MySqlException
                    MessageBox.Show("Error in connecting to the database: " & sqlEx.Message)
                    Return
                Catch ex As Exception
                    MessageBox.Show("Error in connecting to the database: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Public Sub DisplayNearestLoan()
        Using connection As New MySqlConnection(connectionString)
            Dim recordCount As Integer

            Dim checkQuery As String = "SELECT COUNT(*) AS RecordNumber FROM Loans WHERE AccountID = @AccountID"
            Dim loanQuery As String = "SELECT LoanID, LoanerName, LoanAmount, InterestRate, DateTaken, PaymentDeadline, AmountReturned FROM Loans
                                       WHERE AccountID = @AccountID AND PaymentDeadline IN
                                       (SELECT MIN(PaymentDeadline) FROM Loans
                                       WHERE AccountID = @AccountID);"

            Using loanCommand As New MySqlCommand(loanQuery, connection), checkCommand As New MySqlCommand(checkQuery, connection)
                loanCommand.Parameters.AddWithValue("@AccountID", Id)
                checkCommand.Parameters.AddWithValue("@AccountID", Id)

                Dim loansDataAdapter As New MySqlDataAdapter(loanCommand)
                Dim loansDataTable As New DataTable()

                Try
                    connection.Open()

                    recordCount = CInt(checkCommand.ExecuteScalar())
                    If recordCount > 0 Then
                        Label5.Text = "Nearest Loan Deadline"
                    Else
                        Label5.Text = "Nearest Loan Deadline (No loans to show. Record your debts in the Loans&Debts section to display.)"
                    End If

                    loansDataAdapter.Fill(loansDataTable)
                    LoanDataGridView.DataSource = loansDataTable

                    ' Set column headers
                    With LoanDataGridView.Columns
                        .Item("LoanID").HeaderText = "Loan ID"
                        .Item("LoanerName").HeaderText = "Loaner Name"
                        .Item("LoanAmount").HeaderText = "Loan Amount"
                        .Item("InterestRate").HeaderText = "Interest Rate"
                        .Item("DateTaken").HeaderText = "Date Taken"
                        .Item("PaymentDeadline").HeaderText = "Payment Deadline"
                        .Item("AmountReturned").HeaderText = "Amount Repaid"
                    End With

                Catch sqlEx As MySqlException
                    MessageBox.Show("Error in connecting to the database: " & sqlEx.Message)
                    Return
                Catch ex As Exception
                    MessageBox.Show("Error in connecting to the database: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Public Sub DisplayNearestDebt()
        Using connection As New MySqlConnection(connectionString)
            Dim recordCount As Integer

            Dim checkQuery As String = "SELECT COUNT(*) AS RecordNumber FROM Debts WHERE AccountID = @AccountID"
            Dim debtsQuery As String = "SELECT DebtID, DebtorName, DebtAmount, DateDebtTaken, AmountRefunded, DebtPaymentDeadline FROM Debts 
                                        WHERE AccountID = @AccountID AND DebtPaymentDeadline IN
                                        (SELECT MIN(DebtPaymentDeadline) FROM Debts
                                        WHERE AccountID = @AccountID);"

            Using debtCommand As New MySqlCommand(debtsQuery, connection), checkCommand As New MySqlCommand(checkQuery, connection)
                debtCommand.Parameters.AddWithValue("@AccountID", Id)
                checkCommand.Parameters.AddWithValue("@AccountID", Id)

                Dim debtsDataAdapter As New MySqlDataAdapter(debtCommand)
                Dim debtsDataTable As New DataTable()

                Try
                    connection.Open()

                    recordCount = CInt(checkCommand.ExecuteScalar())
                    If recordCount > 0 Then
                        Label6.Text = "Nearest Debt Deadline"
                    Else
                        Label6.Text = "Nearest Debt Deadline (No debts to show. Record your debts in the Loans&Debts section to display.)"
                    End If

                    debtsDataAdapter.Fill(debtsDataTable)
                    DebtDataGridView.DataSource = debtsDataTable

                    With DebtDataGridView.Columns
                        .Item("DebtID").HeaderText = "Debt ID"
                        .Item("DebtorName").HeaderText = "Debtor Name"
                        .Item("DebtAmount").HeaderText = "Debt Amount"
                        .Item("DateDebtTaken").HeaderText = "Date Taken"
                        .Item("AmountRefunded").HeaderText = "Amount Refunded"
                        .Item("DebtPaymentDeadline").HeaderText = "Payment Deadline"
                    End With

                Catch sqlEx As MySqlException
                    MessageBox.Show("Error in connecting to the database: " & sqlEx.Message)
                    Return
                Catch ex As Exception
                    MessageBox.Show("Error in connecting to the database: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Public Sub DisplayClosestGoal()
        Using connection As New MySqlConnection(connectionString)
            Dim recordCount As Integer

            Dim checkQuery As String = "SELECT COUNT(*) AS RecordNumber FROM goals WHERE AccountID = @AccountID"
            Dim goalQuery As String = "SELECT GoalID, Description, TargetAmount, StartingAmount, CurrentAmount, (CurrentAmount / TargetAmount * 100) As CompletionRate, StartingDate, TargetDate FROM goals
                                       WHERE AccountID = @AccountID AND (CurrentAmount / TargetAmount * 100) =
                                       (SELECT MAX(CurrentAmount / TargetAmount * 100) FROM goals
                                       WHERE AccountID = @AccountID);"

            Using goalCommand As New MySqlCommand(goalQuery, connection), checkCommand As New MySqlCommand(checkQuery, connection)
                goalCommand.Parameters.AddWithValue("@AccountID", Id)
                checkCommand.Parameters.AddWithValue("@AccountID", Id)

                Dim goalDataAdapter As New MySqlDataAdapter(goalCommand)
                Dim goalDataTable As New DataTable()

                Try
                    connection.Open()

                    recordCount = CInt(checkCommand.ExecuteScalar())
                    If recordCount > 0 Then
                        Label9.Text = "Closest Goal Target"
                    Else
                        Label9.Text = "Closest Goal Target (No goals to show. Record your goals in the Financial Goals section to display.)"
                    End If

                    goalDataAdapter.Fill(goalDataTable)
                    GoalDataGridView.DataSource = goalDataTable

                    With GoalDataGridView.Columns
                        .Item("GoalID").HeaderText = "Goal ID"
                        .Item("Description").HeaderText = "Description"
                        .Item("StartingAmount").HeaderText = "Starting Amount"
                        .Item("TargetAmount").HeaderText = "Target Amount"
                        .Item("CurrentAmount").HeaderText = "Current Amount"
                        .Item("CompletionRate").HeaderText = "Completion Rate(%)"
                        .Item("StartingDate").HeaderText = "Starting Date"
                        .Item("TargetDate").HeaderText = "Target Date"
                    End With

                Catch sqlEx As MySqlException
                    MessageBox.Show("Error in connecting to the database: " & sqlEx.Message)
                    Return
                Catch ex As Exception
                    MessageBox.Show("Error in connecting to the database: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub TransactionDataGridView_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles TransactionDataGridView.DataBindingComplete
        For Each column As DataGridViewColumn In TransactionDataGridView.Columns
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Next
    End Sub

    Private Sub LoanDataGridView_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles LoanDataGridView.DataBindingComplete
        For Each column As DataGridViewColumn In LoanDataGridView.Columns
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Next
    End Sub

    Private Sub DebtDataGridView_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles DebtDataGridView.DataBindingComplete
        For Each column As DataGridViewColumn In DebtDataGridView.Columns
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Next
    End Sub

    Private Sub GoalDataGridView_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles GoalDataGridView.DataBindingComplete
        For Each column As DataGridViewColumn In GoalDataGridView.Columns
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Next
    End Sub
End Class