Public Class Financial_goals
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim objDemo As New Form3()
        Form3.Show()
    End Sub

    Private Sub Financial_goals_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim objDemo As New Transaction()
        Transaction.Show()
        Me.Hide()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim obj As New LoginForm()
        LoginForm.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim objDemo As New GoalChecking()
        GoalChecking.Show()
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim objDemo As New Account()
        Account.Show()
        Me.Hide()
    End Sub
End Class