Imports System.Data.Common
Imports MySql.Data.MySqlClient

Public Class LoansDebtsReport
    Private Sub DLRhome_Click(sender As Object, e As EventArgs) Handles DLRhome.Click
        Me.Close()
        Loans.Show()
    End Sub

    Private Sub LoansDebtsReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Using connection As New MySqlConnection(connectionString)
            Dim loanQuery As String = "SELECT LoanID, LoanerName, LoanAmount, InterestRate, DateTaken, PaymentDeadline, AmountReturned FROM Loans WHERE AccountID = @AccountID"
            Dim debtsQuery As String = "SELECT DebtID, DebtorName, DebtAmount, DateDebtTaken, AmountRefunded, DebtPaymentDeadline FROM Debts WHERE AccountID = @AccountID"

            Using loanCommand As New MySqlCommand(loanQuery, connection), debtCommand As New MySqlCommand(debtsQuery, connection)
                loanCommand.Parameters.AddWithValue("@AccountID", Id)
                debtCommand.Parameters.AddWithValue("@AccountID", Id)

                Dim loansDataAdapter As New MySqlDataAdapter(loanCommand)
                Dim loansDataTable As New DataTable()

                Dim debtsDataAdapter As New MySqlDataAdapter(debtCommand)
                Dim debtsDataTable As New DataTable()

                Try
                    connection.Open()
                    loansDataAdapter.Fill(loansDataTable)
                    debtsDataAdapter.Fill(debtsDataTable)

                    DispLoans.DataSource = loansDataTable
                    DispDebts.DataSource = debtsDataTable

                    ' Set column headers
                    With DispLoans.Columns
                        .Item("LoanID").HeaderText = "Loan ID"
                        .Item("LoanerName").HeaderText = "Loaner Name"
                        .Item("LoanAmount").HeaderText = "Loan Amount"
                        .Item("InterestRate").HeaderText = "Interest Rate"
                        .Item("DateTaken").HeaderText = "Date Taken"
                        .Item("PaymentDeadline").HeaderText = "Payment Deadline"
                        .Item("AmountReturned").HeaderText = "Amount Repaid"
                    End With

                    With DispDebts.Columns
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

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DispLoans.CellContentClick
        ' You can add code here to handle cell clicks if needed
    End Sub

End Class