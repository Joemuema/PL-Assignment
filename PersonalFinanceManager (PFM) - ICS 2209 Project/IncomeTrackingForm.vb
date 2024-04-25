Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.Win32
Imports Mysqlx
Imports System.Globalization
Public Class IncomeTrackingForm

    Private Sub btnSaveDetailsIncome_Click(sender As Object, e As EventArgs) Handles btnSaveIncomeDetails.Click

        Dim incomeSource As String = txtIncomeSource.Text.Trim()
        Dim incomeAmount As Decimal

        If Decimal.TryParse(txtIncomeAmount.Text, incomeAmount) Then

            Budgeting.totalIncome += incomeAmount
            Budgeting.UpdateDisplay()

            Dim sqlQuery As String = "INSERT INTO income (AccountID, SourceName, Amount) VALUES(@AccountID, @SourceName, @Amount)"
            Using sqlConn As New MySqlConnection(connectionString),
                      sqlCmd As New MySqlCommand(sqlQuery, sqlConn)
                sqlCmd.Parameters.AddWithValue("@AccountID", Id)
                sqlCmd.Parameters.AddWithValue("@SourceName", incomeSource)
                sqlCmd.Parameters.AddWithValue("@Amount", incomeAmount)
                sqlConn.Open()
                sqlCmd.ExecuteNonQuery()

            End Using
        Else
            MessageBox.Show("Please enter a valid income amount.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        PopulatedgvIncome()
        PopulatelblTotalIncome()
    End Sub

    Private Sub PopulatedgvIncome()
        Dim sqlQuery As String = "SELECT SourceName As Source , Amount, IncomeID As ID  FROM income WHERE AccountID = @AccountID"

        Using sqlConn As New MySqlConnection(connectionString), sqlDt As New DataTable, command As New MySqlCommand(sqlQuery, sqlConn)
            command.Parameters.AddWithValue("@AccountID", Id)

            Using DtA As New MySqlDataAdapter(command)
                DtA.Fill(sqlDt)
                dgvIncome.DataSource = sqlDt
                dgvIncome.Columns("ID").Visible = False
                dgvIncome.ForeColor = Color.Black
            End Using
        End Using
    End Sub

    Public Sub PopulatelblTotalIncome()
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

                lblTotalIncome.Text = "Total Income: " & totalIncome.ToString("0.00")
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while populating income table: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDeleteIncome_Click(sender As Object, e As EventArgs) Handles btnDeleteIncome.Click

        If dgvIncome.SelectedRows.Count > 0 Then

            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete the selected income(s)?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)


            If result = DialogResult.Yes Then

                For Each selectedRow As DataGridViewRow In dgvIncome.SelectedRows

                    Dim IncomeID As Integer = Convert.ToInt32(selectedRow.Cells("ID").Value)

                    Try

                        Dim sqlQuery As String = "DELETE FROM income WHERE IncomeID = @ID"

                        Using sqlConn As New MySqlConnection(connectionString),
                          sqlCmd As New MySqlCommand(sqlQuery, sqlConn)

                            sqlCmd.Parameters.AddWithValue("@ID", IncomeID)
                            sqlConn.Open()
                            sqlCmd.ExecuteNonQuery()
                        End Using
                        dgvIncome.Rows.Remove(selectedRow)
                    Catch ex As Exception
                        MessageBox.Show("An error occurred while deleting the record: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                Next
            End If
        Else
            MessageBox.Show("No rows selected for deletion.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        PopulatedgvIncome()
        PopulatelblTotalIncome()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim mainForm As New Budgeting()
        mainForm.Show()
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtIncomeAmount.Clear()
        txtIncomeSource.Clear()
    End Sub

    Private Sub IncomeTrackingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulatedgvIncome()
        PopulatelblTotalIncome()
    End Sub

End Class