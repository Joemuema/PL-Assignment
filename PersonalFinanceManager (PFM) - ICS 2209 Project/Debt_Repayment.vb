Imports MySql.Data.MySqlClient
Public Class Debt_Repayment
    Private Sub RDHome_Click(sender As Object, e As EventArgs) Handles RDHome.Click
        Me.Close()
        Loans.Show()
    End Sub

    Private Sub checkDebtDetails_Click(sender As Object, e As EventArgs) Handles checkDebtDetails.Click
        'Get the value of ID from the textbox
        Dim debtID As Integer
        If Not Integer.TryParse(DRDebtIDdata.Text, debtID) Then
            MessageBox.Show("Please enter a valid Debt ID.")
            Return
        End If

        Dim connection As New MySqlConnection(connectionString)

        Try
            connection.Open()

            'Select queries to get data to be displayed
            Dim debtorQuery As String = "SELECT DebtorName FROM Debts WHERE DebtID = @debtID"
            Dim debtorCommand As New MySqlCommand(debtorQuery, connection)
            debtorCommand.Parameters.AddWithValue("@debtID", debtID)
            Dim debtorName As String = CStr(debtorCommand.ExecuteScalar())

            Dim debtAmountQuery As String = "SELECT DebtAmount FROM Debts WHERE DebtID = @debtID"
            Dim debtAmountCommand As New MySqlCommand(debtAmountQuery, connection)
            debtAmountCommand.Parameters.AddWithValue("@debtID", debtID)
            Dim debtAmount As Decimal = CDec(debtAmountCommand.ExecuteScalar())

            Dim amountRefundedQuery As String = "SELECT AmountRefunded FROM Debts WHERE DebtID = @debtID"
            Dim amountRefundedCommand As New MySqlCommand(amountRefundedQuery, connection)
            amountRefundedCommand.Parameters.AddWithValue("@debtID", debtID)
            Dim amountRefunded As Decimal = CDec(amountRefundedCommand.ExecuteScalar())

            Dim debtDeadlineQuery As String = "SELECT DebtPaymentDeadline FROM Debts WHERE DebtID = @debtID"
            Dim debtDeadlineCommand As New MySqlCommand(debtDeadlineQuery, connection)
            debtDeadlineCommand.Parameters.AddWithValue("@debtID", debtID)
            Dim debtDeadline As Date = CDate(debtDeadlineCommand.ExecuteScalar())

            'Send the Debtor's Name and Amount to textbox for display
            DRDebtorNamedata.Text = debtorName
            DRDebtAmount.Text = debtAmount

            'Calculate the payment progress to use in the progress bar
            Dim percentageRefunded As Integer
            If debtAmount > 0 Then ' To avoid division by zero
                percentageRefunded = CInt((amountRefunded / debtAmount) * 100)
            Else
                percentageRefunded = 0 ' If totalLoanAmount is 0, set percentage to 0
            End If

            'Update the progress bar
            RDRepaymentProgressdata.Value = percentageRefunded

            'Send the deadline to the MonthCalendar
            DRDueDatedata.SelectionStart = debtDeadline
            DRDueDatedata.SelectionEnd = debtDeadline

        Catch ex As MySqlException
            'Handle exceptions that may be thrown in the process
            MessageBox.Show("Error: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub RDSaveDetails_Click(sender As Object, e As EventArgs) Handles RDSaveDetails.Click
        Dim debtID As Integer
        If Not Integer.TryParse(DRDebtIDdata.Text, debtID) Then
            MessageBox.Show("Please enter a valid Debt ID.")
            Return
        End If

        'Get the values from the other texboxes
        Dim depoAmt As Decimal
        If Not Decimal.TryParse(RepayAmt.Text, depoAmt) Then
            MessageBox.Show("Please enter a valid amount.")
            Return
        End If

        Dim connection As New MySqlConnection(connectionString)

        'Creating the appropriate update query
        Dim updateQuery As String = "UPDATE Debts SET AmountRefunded = AmountRefunded + @depoAmt WHERE DebtID = @debtID"
        Dim updateCommand As New MySqlCommand(updateQuery, connection)

        'Using the values from the textboxes as parameters
        updateCommand.Parameters.AddWithValue("@depoAmt", depoAmt)
        updateCommand.Parameters.AddWithValue("@debtID", debtID)

        'Open the connection and execute the update query
        Try
            connection.Open()
            updateCommand.ExecuteNonQuery()

        Catch ex As MySqlException
            'Handle exceptions that may be thrown in the process
            MessageBox.Show("Error: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LoansDebtsReport.Show()
    End Sub
End Class