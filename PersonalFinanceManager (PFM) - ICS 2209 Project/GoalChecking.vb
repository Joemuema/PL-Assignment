Imports System.Data.SqlTypes
Imports System.IO
Imports MySql.Data.MySqlClient
Imports Transaction_UI.Form3
Public Class GoalChecking
    Dim GoalsList As New List(Of Goal)

    Private Sub CheckGoalsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadGoalsFromDatabase()
        DisplayGoals()
    End Sub

    Private Sub LoadGoalsFromDatabase()

        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' Define the SQL query to retrieve goals from the database
                Dim query As String = "SELECT GoalID, Description, TargetAmount, StartingAmount, CurrentAmount, StartingDate, TargetDate FROM goals WHERE AccountID = @AccountID"

                ' Create a MySqlCommand object with the query and connection
                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@AccountID", Id)

                    ' Execute the query and read the results
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim newGoal As New Goal With {
                                .GoalId = reader("GoalID"),
                                .Description = reader("Description"),
                                .TargetAmount = reader("TargetAmount"),
                                .StartingAmount = reader("StartingAmount"),
                                .CurrentAmount = reader("CurrentAmount"),
                                .StartDate = reader("StartingDate"),
                                .TargetDate = reader("TargetDate")
                             }
                            GoalsList.Add(newGoal)
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while loading goals from the database: " & ex.Message)
        End Try
    End Sub

    Private Sub DisplayGoals()
        DataGridView1.Rows.Clear()

        For Each goal As Goal In GoalsList
            Dim row As String() = {goal.Description, goal.StartingAmount.ToString(), goal.TargetAmount.ToString(), goal.CurrentAmount.ToString(), goal.StartDate.ToShortDateString(), goal.TargetDate.ToShortDateString()}
            DataGridView1.Rows.Add(row)
        Next
    End Sub

    Private Sub CheckBackButton_Click(sender As Object, e As EventArgs) Handles CheckBackButton.Click
        Me.Close()
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim selectedIndex As Integer = DataGridView1.SelectedRows(0).Index

            ' Delete the selected goal from the database
            DeleteGoalFromDatabase(GoalsList(selectedIndex).Description)

            ' Remove the selected goal from the GoalsList
            GoalsList.RemoveAt(selectedIndex)

            ' Update the DataGridView
            DisplayGoals()
        Else
            MessageBox.Show("Please select a goal to delete.")
        End If
    End Sub


    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        ' Check if a goal is selected in the DataGridView
        If DataGridView1.SelectedRows.Count > 0 Then
            ' Get the selected goal
            Dim selectedIndex As Integer = DataGridView1.SelectedRows(0).Index
            Dim selectedGoal As Form3.Goal = GoalsList(selectedIndex)

            ' Show the updateGoalForm and pass the selected goal
            Dim updatedGoalForm As New updateGoalForm(selectedGoal)
            If updatedGoalForm.ShowDialog() = DialogResult.OK Then
                ' Replace the selected goal with the updated goal
                GoalsList(selectedIndex) = updatedGoalForm.UpdatedGoal

                ' Update the DataGridView
                DisplayGoals()
            End If
        Else
            MessageBox.Show("Please select a goal to update.")
        End If
    End Sub

    Private Sub DeleteGoalFromDatabase(description As String)

        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' Define the SQL query to delete the goal from the database
                Dim query As String = "DELETE FROM goals WHERE Description = @Description"

                ' Create a MySqlCommand object with the query and connection
                Using cmd As New MySqlCommand(query, connection)
                    ' Add parameter to the query
                    cmd.Parameters.AddWithValue("@Description", description)

                    ' Execute the query
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while deleting the goal from the database: " & ex.Message)
        End Try
    End Sub


    Private Sub DepositButton_Click(sender As Object, e As EventArgs) Handles DepositButton.Click
        ' Check if a goal is selected in the DataGridView
        If DataGridView1.SelectedRows.Count > 0 Then
            ' Get the selected goal
            Dim selectedIndex As Integer = DataGridView1.SelectedRows(0).Index
            Dim depositedGoal As Goal = GoalsList(selectedIndex)

            ' Prompt the user to input the deposit amount using a message box
            Dim depositAmount As Decimal
            Dim input As String = InputBox("Enter the deposit amount for the goal '" & depositedGoal.Description & "':")

            ' Check if the input is a valid decimal number
            If Decimal.TryParse(input, depositAmount) AndAlso depositAmount > 0 Then
                ' Update the current amount in the database
                UpdateCurrentAmountInDatabase(depositedGoal.Description, depositedGoal.CurrentAmount + depositAmount)

                ' Update the current amount for the selected goal
                depositedGoal.CurrentAmount += depositAmount

                ' Update the DataGridView
                DisplayGoals()
                ' Update the DataGridView
                DataGridView1.Rows(selectedIndex).Cells(3).Value = depositedGoal.CurrentAmount

            Else
                MessageBox.Show("Please enter a valid deposit amount.")
            End If
        Else
            MessageBox.Show("Please select a goal to deposit to.")
        End If
        ' DisplayGoals()
    End Sub

    Private Sub UpdateCurrentAmountInDatabase(description As String, newAmount As Decimal)

        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' Define the SQL query to update the current amount in the database
                Dim query As String = "UPDATE goals SET CurrentAmount = @CurrentAmount WHERE Description = @Description"

                ' Create a MySqlCommand object with the query and connection
                Using cmd As New MySqlCommand(query, connection)
                    ' Add parameters to the query
                    cmd.Parameters.AddWithValue("@CurrentAmount", newAmount)
                    cmd.Parameters.AddWithValue("@Description", description)

                    ' Execute the query
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while updating the current amount in the database: " & ex.Message)
        End Try
    End Sub

End Class