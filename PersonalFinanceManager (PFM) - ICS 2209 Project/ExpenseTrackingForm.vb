Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.Win32
Imports Mysqlx

Public Class ExpenseTrackingForm
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim mainForm As New Budgeting()
        mainForm.Show()
        Me.Close()
    End Sub

    Private Sub btnAddExpense_Click(sender As Object, e As EventArgs) Handles btnAddExpense.Click

        Dim expenseCategory As String = txtExpenseCategory.Text.Trim()
        Dim expenseAmount As Decimal

        If Decimal.TryParse(txtExpenseAmount.Text, expenseAmount) Then

            Budgeting.totalExpenses += expenseAmount
            Budgeting.UpdateDisplay()

            Dim sqlQuery As String = "INSERT INTO expenses (AccountID, ExpenseType, Amount) VALUES(@AccountID, @ExpenseType, @Amount)"
            Using sqlConn As New MySqlConnection(connectionString),
                sqlCmd As New MySqlCommand(sqlQuery, sqlConn)
                sqlCmd.Parameters.AddWithValue("@AccountID", Id)
                sqlCmd.Parameters.AddWithValue("@ExpenseType", expenseCategory)
                sqlCmd.Parameters.AddWithValue("@Amount", expenseAmount)
                sqlConn.Open()
                sqlCmd.ExecuteNonQuery()

            End Using
        Else
            MessageBox.Show("Please enter a valid expense amount.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        PopulatedgvExpenses()
        PopulatelblExpenses()
    End Sub
    Public Sub PopulatelblExpenses()
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

                lblExpenses.Text = "Total Expenses: " & totalExpenses.ToString("0.00")
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while calculating total expenses: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub PopulatedgvExpenses()
        Dim sqlQuery As String = "SELECT ExpenseType As Category , Amount, ExpenseID As ID  FROM expenses WHERE AccountID = @AccountID"

        Using sqlConn As New MySqlConnection(connectionString), sqlDt As New DataTable, command As New MySqlCommand(sqlQuery, sqlConn)
            command.Parameters.AddWithValue("@AccountID", Id)

            Using DtA As New MySqlDataAdapter(command)
                DtA.Fill(sqlDt)
                dgvExpenses.DataSource = sqlDt
                dgvExpenses.Columns("ID").Visible = False
                dgvExpenses.ForeColor = Color.Black
            End Using
        End Using

    End Sub

    Private Sub btnDeleteExpense_Click(sender As Object, e As EventArgs) Handles btnDeleteExpense.Click

        If dgvExpenses.SelectedRows.Count > 0 Then

            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete the selected expense(s)?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)


            If result = DialogResult.Yes Then

                For Each selectedRow As DataGridViewRow In dgvExpenses.SelectedRows

                    Dim ExpenseID As Integer = Convert.ToInt32(selectedRow.Cells("ID").Value)

                    Try

                        Dim sqlQuery As String = "DELETE FROM expenses WHERE ExpenseID = @ID"

                        Using sqlConn As New MySqlConnection(connectionString),
                          sqlCmd As New MySqlCommand(sqlQuery, sqlConn)

                            sqlCmd.Parameters.AddWithValue("@ID", ExpenseID)
                            sqlConn.Open()
                            sqlCmd.ExecuteNonQuery()
                        End Using
                        dgvExpenses.Rows.Remove(selectedRow)
                    Catch ex As Exception
                        MessageBox.Show("An error occurred while deleting the record: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                Next
            End If
        Else
            MessageBox.Show("No rows selected for deletion.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        PopulatedgvExpenses()
        PopulatelblExpenses()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtExpenseAmount.Clear()
        txtExpenseCategory.Clear()
    End Sub

    Private Sub ExpenseTrackingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulatedgvExpenses()
        PopulatelblExpenses()
    End Sub

End Class