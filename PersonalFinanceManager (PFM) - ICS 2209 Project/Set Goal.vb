Imports System.IO
Imports System.Drawing.Text
Imports MySql.Data.MySqlClient

Public Class Form3
    Public Structure Goal
        Dim Description As String
        Dim TargetAmount As Decimal
        Dim StartingAmount As Decimal
        Dim CurrentAmount As Decimal
        Dim StartDate As Date
        Dim TargetDate As Date
        Dim GoalId As Integer
    End Structure

    Dim connection As MySqlConnection
    Dim GoalsList As New List(Of Goal)

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        ' Validate the starting amount, target amount, and target date
        If IsValidInput() Then
            ' Creating a new goal using the data entered by the user
            Dim newGoal As New Goal With {
                .Description = GoalDescriptionTxtBox.Text,
                .TargetAmount = Decimal.Parse(TargetAmtTxtBox.Text),
                .StartingAmount = Decimal.Parse(StartingAmtTxtBox.Text),
                .StartDate = StartDateTimePicker.Value,
                .TargetDate = TargetDateTimePicker.Value
            }

            Try
                Using connection As New MySqlConnection(connectionString)
                    connection.Open()

                    ' Set the current amount equal to the starting amount
                    newGoal.CurrentAmount = newGoal.StartingAmount

                    ' Define the SQL query to insert the goal data into the database
                    Dim query As String = "INSERT INTO goals (AccountID, Description, TargetAmount, StartingAmount, CurrentAmount, StartingDate, TargetDate) VALUES (@AccountID, @Description,@TargetAmount, @StartingAmount, @CurrentAmount, @StartDate, @TargetDate)"

                    ' Create a MySqlCommand object with the query and connection
                    Using cmd As New MySqlCommand(query, connection)
                        ' Add parameters to the query
                        cmd.Parameters.AddWithValue("@AccountID", Id)
                        cmd.Parameters.AddWithValue("@Description", newGoal.Description)
                        cmd.Parameters.AddWithValue("@TargetAmount", newGoal.TargetAmount)
                        cmd.Parameters.AddWithValue("@StartingAmount", newGoal.StartingAmount)
                        cmd.Parameters.AddWithValue("@CurrentAmount", newGoal.CurrentAmount)
                        cmd.Parameters.AddWithValue("@StartDate", newGoal.StartDate)
                        cmd.Parameters.AddWithValue("@TargetDate", newGoal.TargetDate)

                        ' Execute the query
                        cmd.ExecuteNonQuery()
                    End Using

                    Dim fetchGoalID As String = "SELECT GoalID FROM Goals WHERE Description = @descr"
                    Using fetchCommand As New MySqlCommand(fetchGoalID, connection)
                        fetchCommand.Parameters.AddWithValue("@descr", newGoal.Description)

                        Dim reader As MySqlDataReader = fetchCommand.ExecuteReader()
                        If reader.Read() Then
                            newGoal.GoalId = CInt(reader("GoalID"))
                        Else
                            MessageBox.Show("An error occurred while fetching the goal ID from the database")
                        End If
                    End Using

                End Using

                ' Add the new goal to the list of goal
                GoalsList.Add(newGoal)

                ' Clear the text boxes to prepare for entering a new goal
                ClearTextBoxes()
            Catch ex As Exception
                MessageBox.Show("An error occurred while saving goals: " & ex.Message)
            End Try

        End If
    End Sub

    ' Function to validate input before saving a new goal
    Private Function IsValidInput() As Boolean
        ' Check if any text box is empty
        If String.IsNullOrWhiteSpace(GoalDescriptionTxtBox.Text) OrElse String.IsNullOrWhiteSpace(TargetAmtTxtBox.Text) OrElse String.IsNullOrWhiteSpace(StartingAmtTxtBox.Text) Then
            MessageBox.Show("Please ensure that all fields are filled out.")
            Return False
        End If

        ' Check if the target amount is higher than the starting amount
        If Decimal.Parse(TargetAmtTxtBox.Text) <= Decimal.Parse(StartingAmtTxtBox.Text) Then
            MessageBox.Show("Please ensure that the target amount is higher than the starting amount.")
            Return False
        End If

        ' Check if the target month is at least a month more than the starting date
        If TargetDateTimePicker.Value < StartDateTimePicker.Value.AddMonths(1) Then
            MessageBox.Show("Please ensure that the target date is at least one month after the start date.")
            Return False
        End If

        ' If all checks pass, return True
        Return True
    End Function

    ' Function to clear all text boxes
    Private Sub ClearTextBoxes()

        GoalDescriptionTxtBox.Clear()
        TargetAmtTxtBox.Clear()
        StartingAmtTxtBox.Clear()

    End Sub

    Private Sub Backbtn_Click(sender As Object, e As EventArgs) Handles Backbtn.Click
        ' Close the MySQL connection if it's open
        If connection IsNot Nothing AndAlso connection.State = ConnectionState.Open Then
            connection.Close()
        End If

        ' Navigate to the previous form
        Me.Close()
    End Sub

End Class