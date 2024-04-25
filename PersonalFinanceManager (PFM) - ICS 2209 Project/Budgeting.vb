Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.Win32
Public Class Budgeting
    Private Sub btnIncomeTracking_Click(sender As Object, e As EventArgs) Handles btnIncomeTracking.Click
        ' Navigate to Income Tracking Page
        Dim incomeForm As New IncomeTrackingForm()
        incomeForm.Show()
    End Sub

    Private Sub btnExpenseTracking_Click(sender As Object, e As EventArgs) Handles btnExpenseTracking.Click
        ' Navigate to Expense Tracking Page
        Dim expenseForm As New ExpenseTrackingForm()
        expenseForm.Show()
    End Sub

    Dim availableFunds As Decimal = 0
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateTotalIncome()
        UpdateTotalExpenses()
        UpdateDisplay()
    End Sub

    Public Shared totalIncome As Decimal
    Public Shared totalExpenses As Decimal

    Private Sub UpdateTotalIncome()
        Try
            Dim recordCount As Integer
            Dim checkQuery As String = "SELECT COUNT(*) AS RecordNumber FROM income WHERE AccountID = @AccountID"
            Dim sqlQuery As String = "SELECT SUM(Amount) AS TotalIncome FROM income WHERE AccountID = @AccountID"

            Using sqlConn As New MySqlConnection(connectionString), sqlCmd As New MySqlCommand(sqlQuery, sqlConn), checkCommand As New MySqlCommand(checkQuery, sqlConn)
                sqlConn.Open()

                checkCommand.Parameters.AddWithValue("@AccountID", Id)
                recordCount = CInt(checkCommand.ExecuteScalar())
                If recordCount > 0 Then
                    sqlCmd.Parameters.AddWithValue("@AccountID", Id)
                    totalIncome = Convert.ToDecimal(sqlCmd.ExecuteScalar())
                Else
                    totalIncome = 0
                End If

                lblIncome.Text = "Total Income: " & totalIncome.ToString("0.00")
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while calculating total income: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub UpdateTotalExpenses()
        Try
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

                lblExpenses.Text = "Total Expenses: " & totalExpenses.ToString("0.00")
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while calculating total expenses: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Public Sub UpdateDisplay()

        lblIncome.Text = "Total Income: " & totalIncome.ToString("0.00")
        lblExpenses.Text = "Total Expenses: " & totalExpenses.ToString("0.00")
        availableFunds = totalIncome - totalExpenses
        lblAvailableFunds.Text = "Available Funds: " & availableFunds.ToString("0.00")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim objDemo As New Loans()
        Loans.Show()
        Me.Hide()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim obj As New LoginForm()
        LoginForm.Show()
        Me.Close()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim objDemo As New Financial_goals()
        Financial_goals.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim objDemo As New Transaction()
        Transaction.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim objDemo As New Account()
        Account.Show()
        Me.Hide()
    End Sub

    Private Sub btnBudgetSummary_Click(sender As Object, e As EventArgs) Handles btnBudgetSummary.Click
        Dim budgetsummaryForm As New BudgetSummary()
        budgetsummaryForm.Show()
    End Sub
End Class