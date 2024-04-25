Imports MySql.Data.MySqlClient

Public Class RepayLoan
    Private Sub RLHome_Click(sender As Object, e As EventArgs) Handles RLHome.Click
        Me.Close()
        Loans.Show()
    End Sub

    Private Sub CheckDetails_Click(sender As Object, e As EventArgs) Handles CheckDetails.Click
        Dim loanID As Integer
        If Not Integer.TryParse(RLLoanid.Text, loanID) Then
            MessageBox.Show("Please enter a valid Loan ID.")
            Return
        End If

        Dim connection As New MySqlConnection(connectionString)

        Try
            connection.Open()

            Dim amountQuery As String = "SELECT LoanAmount FROM Loans WHERE LoanID = @loanID"
            Dim amountCommand As New MySqlCommand(amountQuery, connection)
            amountCommand.Parameters.AddWithValue("@loanID", loanID)
            Dim amount As Decimal = CType(amountCommand.ExecuteScalar(), Decimal)

            Dim amountpaidQuery As String = "SELECT AmountReturned FROM Loans WHERE LoanID = @loanID"
            Dim amountpaidCommand As New MySqlCommand(amountpaidQuery, connection)
            amountpaidCommand.Parameters.AddWithValue("@loanID", loanID)
            Dim amountpaid As Decimal = CType(amountpaidCommand.ExecuteScalar(), Decimal)

            Dim interestRateQuery As String = "SELECT InterestRate FROM Loans WHERE LoanID = @loanID"
            Dim interestRateCommand As New MySqlCommand(interestRateQuery, connection)
            interestRateCommand.Parameters.AddWithValue("@loanID", loanID)
            Dim interestRate As Decimal = CType(interestRateCommand.ExecuteScalar(), Decimal)

            Dim loanDateQuery As String = "SELECT DateTaken FROM Loans WHERE LoanID = @loanID"
            Dim loanDateCommand As New MySqlCommand(loanDateQuery, connection)
            loanDateCommand.Parameters.AddWithValue("@loanID", loanID)
            Dim loanDate As Date = CType(loanDateCommand.ExecuteScalar(), Date)

            Dim deadlineQuery As String = "SELECT PaymentDeadline FROM Loans WHERE LoanID = @loanID"
            Dim deadlineCommand As New MySqlCommand(deadlineQuery, connection)
            deadlineCommand.Parameters.AddWithValue("@loanID", loanID)
            Dim deadline As Date = CType(deadlineCommand.ExecuteScalar(), Date)

            Dim loanerNameQuery As String = "SELECT LoanerName FROM Loans WHERE LoanID = @loanID"
            Dim loanerNameCommand As New MySqlCommand(loanerNameQuery, connection)
            loanerNameCommand.Parameters.AddWithValue("@loanID", loanID)
            Dim reader As MySqlDataReader = loanerNameCommand.ExecuteReader()

            'Send the Loaner's Name to textbox for display
            If reader.Read() Then
                DspLoanername.Text = reader.GetString(0)
            End If
            reader.Close()

            'Calculating the difference in days between today's date and the LoanDate
            Dim daysBetween As Integer = (Date.Today - loanDate).Days

            'Calculating the total loan amount from the amount and interest
            Dim totalLoan As Decimal = amount + (amount * (interestRate / 100D) * (daysBetween / 365D))

            'Send the calculated total amount to the textbox
            TotalAmt.Text = totalLoan.ToString("F2")

            'Calculate the payment progress to use in the progress bar
            Dim percentagePaid As Integer
            If amount > 0 Then ' To avoid division by zero
                percentagePaid = CInt(amountpaid / totalLoan * 100)
                If percentagePaid > 100 Then
                    MessageBox.Show("Amount repayed exceeded by " & ((percentagePaid - 100) / 100 * totalLoan).ToString("N2") & ". Excess will be refunded.", "Excess repayment")
                    percentagePaid = 100
                End If
            Else
                percentagePaid = 0 ' If totalLoanAmount is 0, set percentage to 0
            End If

            'Update the progress bar
            ProgressBar1.Value = percentagePaid

            'Send the deadline to the MonthCalendar
            Try
                MonthCalendar1.SetDate(deadline)
            Catch ex As Exception
                MessageBox.Show("Error setting deadline date in the calendar: " & ex.Message)
            End Try

        Catch ex As MySqlException
            Console.WriteLine("Error: " & ex.ToString())
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub SaveLoanPayment_Click(sender As Object, e As EventArgs) Handles SaveLoanPayment.Click
        Dim loanID As Integer
        If Not Integer.TryParse(RLLoanid.Text, loanID) Then
            MessageBox.Show("Please enter a valid Loan ID.")
            Return
        End If

        Dim repayAmt As Decimal
        If Not Decimal.TryParse(RepayAmount.Text, repayAmt) Then
            MessageBox.Show("Please enter a valid Amount.")
            Return
        End If


        Using connection As New MySqlConnection(connectionString)
            Dim updateQuery As String = "UPDATE Loans SET AmountReturned = AmountReturned + @repayAmt WHERE LoanID = @loanID"
            Using updateCommand As New MySqlCommand(updateQuery, connection)

                updateCommand.Parameters.AddWithValue("@repayAmt", repayAmt)
                updateCommand.Parameters.AddWithValue("@loanID", loanID)

                Try
                    connection.Open()
                    updateCommand.ExecuteNonQuery()
                Catch ex As MySqlException
                    Console.WriteLine("Error: " & ex.ToString())
                Finally
                    connection.Close()
                End Try
            End Using
        End Using
    End Sub

    Private Sub CheckLoanID_Click(sender As Object, e As EventArgs) Handles CheckLoanID.Click
        LoansDebtsReport.Show()
    End Sub

End Class