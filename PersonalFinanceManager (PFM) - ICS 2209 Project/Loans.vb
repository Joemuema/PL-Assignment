Imports MySql.Data.MySqlClient
Public Class Loans
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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim objDemo As New Transaction()
        Transaction.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ViewDebts.Click
        Dim NewForm As New LoansDebtsReport()
        NewForm.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles DebtRepayment.Click
        Dim NewForm As New Debt_Repayment()
        NewForm.Show()
    End Sub

    Private Sub RecordDebt_Click(sender As Object, e As EventArgs) Handles RecordDebt.Click
        Dim NewForm As New Record_Debt()
        NewForm.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim objDemo As New Budgeting()
        Budgeting.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Dim objDemo As New Account()
        Account.Show()
        Me.Hide()
    End Sub

    Private Sub TakeLoan_Click(sender As Object, e As EventArgs) Handles TakeLoan.Click
        Dim NewForm As New TakeLoan
        NewForm.Show()
    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click
        Dim NewForm As New LoansDebtsReport
        NewForm.Show()
    End Sub

    Private Sub RepayLoan_Click_1(sender As Object, e As EventArgs) Handles RepayLoan.Click
        Dim NewForm As New RepayLoan
        NewForm.Show()
    End Sub
End Class