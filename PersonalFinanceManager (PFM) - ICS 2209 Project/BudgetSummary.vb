Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.Win32
Imports Mysqlx
Imports System.Globalization


Public Class BudgetSummary
    Public Property IncomeSource As String
    Public Property IncomeAmount As Decimal
    Public Property IncomeFrequency As String
    Public Property ExpenseDetails As New List(Of KeyValuePair(Of String, Decimal))() ' List to store expense categories and amounts
    Public Property SavingsGoal As Decimal


    Private expenseCategory As String
    Private expenseAmount As Decimal

    Private Sub ReportsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplaySummaryTables()
        DisplayIncomes()
        DisplayExpenses()
        DisplayIncomeExpenseComparison()
    End Sub

    Private Sub DisplaySummaryTables()

        Dim totalIncome As Decimal = Budgeting.totalIncome
        Dim totalExpenses As Decimal = Budgeting.totalExpenses
        Dim netIncome As Decimal = totalIncome - totalExpenses

        lblTotalIncome.Text = "Total Income: " & totalIncome.ToString("0.00")
        lblTotalExpenses.Text = "Total Expenses: " & totalExpenses.ToString("0.00")
        lblNetIncome.Text = "Net Income: " & netIncome.ToString("0.00")
    End Sub


    Private Sub DisplayIncomes()
        Dim sqlQuery As String = "SELECT SourceName As Source , Amount FROM income WHERE AccountID = @AccountID"

        Using sqlConn As New MySqlConnection(connectionString), sqlDt As New DataTable, command As New MySqlCommand(sqlQuery, sqlConn)
            command.Parameters.AddWithValue("@AccountID", Id)

            Using DtA As New MySqlDataAdapter(command)
                DtA.Fill(sqlDt)
                dgvIncome.DataSource = sqlDt
                dgvIncome.ForeColor = Color.Black
            End Using
        End Using
    End Sub
    Private Sub DisplayExpenses()
        Dim sqlQuery As String = "SELECT ExpenseType As Category , Amount FROM expenses WHERE AccountID = @AccountID"

        Using sqlConn As New MySqlConnection(connectionString), sqlDt As New DataTable, command As New MySqlCommand(sqlQuery, sqlConn)
            command.Parameters.AddWithValue("@AccountID", Id)

            Using DtA As New MySqlDataAdapter(command)
                DtA.Fill(sqlDt)
                dgvExpenses.DataSource = sqlDt
                dgvExpenses.ForeColor = Color.Black
            End Using
        End Using
    End Sub
    Private Sub DisplayIncomeExpenseComparison()

        Dim totalIncome As Decimal = Budgeting.totalIncome
        Dim totalExpenses As Decimal = Budgeting.totalExpenses
        Dim incomePercentage As Decimal = If(totalIncome + totalExpenses = 0, 0, totalIncome / (totalIncome + totalExpenses) * 100)
        Dim expensePercentage As Decimal = If(totalIncome + totalExpenses = 0, 0, totalExpenses / (totalIncome + totalExpenses) * 100)
        Dim difference As Decimal = Math.Abs(expensePercentage - incomePercentage)
        lblIncomePercentage.Text = "Income: " & incomePercentage.ToString("0.00") & "%"
        lblExpensePercentage.Text = "Expenses: " & expensePercentage.ToString("0.00") & "%"

        If expensePercentage > incomePercentage Then
            lblIncomePercentage.ForeColor = Color.Red
            lblExpensePercentage.ForeColor = Color.Red
        ElseIf difference <= 5 Then
            lblIncomePercentage.ForeColor = Color.Orange
            lblExpensePercentage.ForeColor = Color.Orange
        Else
            lblIncomePercentage.ForeColor = Color.Green
            lblExpensePercentage.ForeColor = Color.Green
        End If
    End Sub
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim budgetingForm As New Budgeting()
        budgetingForm.Show()
        Me.Close()
    End Sub


End Class