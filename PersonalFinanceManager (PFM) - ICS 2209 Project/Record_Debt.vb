Imports MySql.Data.MySqlClient

Public Class Record_Debt
    Private Sub RDHome_Click(sender As Object, e As EventArgs) Handles RDHome.Click
        Me.Close()
        Loans.Show()
    End Sub
    Private Sub RDSaveDetails_Click(sender As Object, e As EventArgs) Handles RDSaveDetails.Click
        'Create variables and assign them to the values entered in the textboxes
        Dim debtAmount As Decimal
        If Not Decimal.TryParse(RDAmountdata.Text, debtAmount) Then
            MessageBox.Show("Please enter a valid amount.")
            Return
        End If

        Dim debtorName As String = RDDebtorNamedata.Text
        Dim dateDebtTaken As Date
        If Not Date.TryParse(RDDateTakendata.Text, dateDebtTaken) Then
            MessageBox.Show("Please enter a valid date for Date Taken.")
            Return
        End If

        Dim debtDeadline As Date
        If Not Date.TryParse(RDPaybackDatedata.Text, debtDeadline) Then
            MessageBox.Show("Please enter a valid date for Payback Deadline.")
            Return
        End If

        Dim connection As New MySqlConnection(connectionString)

        'Creating the insert query
        Dim query As String = "INSERT INTO Debts(AccountID, DebtorName, DebtAmount, DateDebttaken, DebtPaymentDeadline) 
                                VALUES(@AccountID, @debtorName, @debtAmount, @dateDebtTaken, @debtDeadline)"
        Dim command As New MySqlCommand(query, connection)

        command.Parameters.AddWithValue("@AccountID", Id)
        command.Parameters.AddWithValue("@debtorName", debtorName)
        command.Parameters.AddWithValue("@debtAmount", debtAmount)
        command.Parameters.AddWithValue("@dateDebtTaken", dateDebtTaken)
        command.Parameters.AddWithValue("@debtDeadline", debtDeadline)

        Try
            connection.Open()
            command.ExecuteNonQuery()
        Catch ex As MySqlException
            'Handle exceptions that may be thrown in the process
            MessageBox.Show("Error: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

End Class