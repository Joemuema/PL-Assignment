Imports System.Runtime.Intrinsics
Imports MySql.Data.MySqlClient
Public Class TakeLoan
    Private Sub TLHome_Click(sender As Object, e As EventArgs) Handles TLHome.Click
        Me.Close()
        Loans.Show()
    End Sub

    Public Sub ClearTextBoxes(frm As Form)
        For Each ctrl As Control In frm.Controls
            If TypeOf ctrl Is TextBox Then
                CType(ctrl, TextBox).Text = String.Empty
            End If
        Next
    End Sub

    Private Sub TLSave_Click(sender As Object, e As EventArgs) Handles TLSave.Click
        Try
            Using mySqlConnection As New MySqlConnection(connectionString)
                mySqlConnection.Open()

                ' SQL update command 
                Dim updateQuery As String = "INSERT INTO Loans (AccountID, LoanAmount, LoanerName, InterestRate, DateTaken, PaymentDeadline) 
                                                         VALUES (@AccountID, @amount, @loaner, @interestRate, @dateTaken, @paybackDate)"
                Using mySqlCommand As New MySqlCommand(updateQuery, mySqlConnection)
                    ' Set parameter values 
                    mySqlCommand.Parameters.AddWithValue("@AccountID", Id)
                    mySqlCommand.Parameters.AddWithValue("@amount", Convert.ToDouble(LoanAmt.Text))
                    mySqlCommand.Parameters.AddWithValue("@loaner", LoanerName.Text)
                    mySqlCommand.Parameters.AddWithValue("@interestRate", Convert.ToDouble(IntRate.Text))
                    mySqlCommand.Parameters.AddWithValue("@dateTaken", DateTknPicker.Value)
                    mySqlCommand.Parameters.AddWithValue("@paybackDate", PayDatePicker.Value)

                    mySqlCommand.ExecuteNonQuery()
                End Using
            End Using

            ' Clear all textboxes
            ClearTextBoxes(Me)
        Catch ex As Exception
            MessageBox.Show("Error updating data: " & ex.Message)
        End Try
    End Sub
End Class