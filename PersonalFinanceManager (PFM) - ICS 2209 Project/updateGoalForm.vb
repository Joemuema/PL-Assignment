Imports Transaction_UI.Form3
Imports MySql.Data.MySqlClient

Public Class updateGoalForm
    Public Property UpdatedGoal As Form3.Goal
    Dim temp_goalID As Integer

    ' Constructor to initialize the form with the selected goal
    Public Sub New(selectedGoal As Form3.Goal)
        InitializeComponent()

        ' Populate the form fields with the details of the selected goal
        GoalDescriptionTxtBox.Text = selectedGoal.Description
        TargetAmtTxtBox.Text = selectedGoal.TargetAmount.ToString() ' Convert numeric value to string
        StartingAmtTxtBox.Text = selectedGoal.StartingAmount.ToString() ' Convert numeric value to string
        CurrentAmtTxtBox.Text = selectedGoal.CurrentAmount.ToString()
        StartDateTimePicker.Value = selectedGoal.StartDate
        TargetDateTimePicker.Value = selectedGoal.TargetDate
        temp_goalID = selectedGoal.GoalId

        ' Disable editing for starting amount, current amount, and starting date
        StartingAmtTxtBox.Enabled = False
        CurrentAmtTxtBox.Enabled = False
        StartDateTimePicker.Enabled = False
    End Sub

    ' Event handler for the "Update" button
    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        ' Validate input before updating the goal
        If ValidateInput() Then
            Dim newGoal As New Goal With {
                .Description = GoalDescriptionTxtBox.Text,
                .CurrentAmount = Decimal.Parse(CurrentAmtTxtBox.Text),
                .StartingAmount = Decimal.Parse(StartingAmtTxtBox.Text),
                .StartDate = StartDateTimePicker.Value,
                .TargetAmount = Decimal.Parse(TargetAmtTxtBox.Text),
                .TargetDate = TargetDateTimePicker.Value,
                .GoalId = temp_goalID
            }
            UpdatedGoal = newGoal

            ' Create a new MySqlConnection object
            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                ' Define the SQL update query
                Dim query As String = "UPDATE goals SET Description = @Description, TargetAmount = @TargetAmount, TargetDate = @TargetDate WHERE GoalID = @GoalID"

                ' Create a MySqlCommand object with the query and connection
                Using cmd As New MySqlCommand(query, connection)
                    ' Add parameters to the query
                    cmd.Parameters.AddWithValue("@Description", UpdatedGoal.Description)
                    cmd.Parameters.AddWithValue("@TargetAmount", UpdatedGoal.TargetAmount)
                    cmd.Parameters.AddWithValue("@TargetDate", UpdatedGoal.TargetDate)
                    cmd.Parameters.AddWithValue("@GoalID", UpdatedGoal.GoalId)

                    ' Execute the update query
                    Try
                        cmd.ExecuteNonQuery()
                    Catch sqlEx As MySqlException
                        MessageBox.Show("An error occurred while deleting the goal from the database: " & sqlEx.Message)
                    Catch ex As Exception
                        MessageBox.Show("An error occurred while deleting the goal from the database: " & ex.Message)
                    End Try

                    ' Close the connection
                    connection.Close()
                End Using
            End Using

            ' Close the form with DialogResult set to OK to indicate successful update
            DialogResult = DialogResult.OK
            Close()
        End If
    End Sub

    ' Event handler for the "Cancel" button
    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles StopButton.Click
        ' Close the form with DialogResult set to Cancel to indicate cancellation
        DialogResult = DialogResult.Cancel
        Close()
    End Sub

    ' Function to validate input before updating the goal
    Private Function ValidateInput() As Boolean
        ' Check if any text box is empty
        If String.IsNullOrWhiteSpace(GoalDescriptionTxtBox.Text) OrElse String.IsNullOrWhiteSpace(TargetAmtTxtBox.Text) OrElse String.IsNullOrWhiteSpace(StartingAmtTxtBox.Text) OrElse String.IsNullOrWhiteSpace(CurrentAmtTxtBox.Text) Then
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

End Class