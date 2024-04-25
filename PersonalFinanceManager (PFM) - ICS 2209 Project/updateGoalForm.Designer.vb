<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class updateGoalForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(updateGoalForm))
        StopButton = New Button()
        UpdateButton = New Button()
        GroupBox1 = New GroupBox()
        TargetDateTimePicker = New DateTimePicker()
        Label2 = New Label()
        StartDateTimePicker = New DateTimePicker()
        Label4 = New Label()
        TargetAmtTxtBox = New TextBox()
        Label1 = New Label()
        GoalDescriptionTxtBox = New TextBox()
        Label5 = New Label()
        StartingAmtTxtBox = New TextBox()
        Label3 = New Label()
        CurrentAmtTxtBox = New TextBox()
        Label6 = New Label()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' StopButton
        ' 
        StopButton.BackColor = Color.FromArgb(CByte(24), CByte(30), CByte(54))
        StopButton.FlatStyle = FlatStyle.Popup
        StopButton.Font = New Font("Times New Roman", 9F)
        StopButton.ForeColor = SystemColors.ButtonFace
        StopButton.Location = New Point(364, 319)
        StopButton.Margin = New Padding(2)
        StopButton.Name = "StopButton"
        StopButton.Size = New Size(85, 29)
        StopButton.TabIndex = 5
        StopButton.Text = "Cancel"
        StopButton.UseVisualStyleBackColor = False
        ' 
        ' UpdateButton
        ' 
        UpdateButton.BackColor = Color.FromArgb(CByte(24), CByte(30), CByte(54))
        UpdateButton.FlatStyle = FlatStyle.Popup
        UpdateButton.Font = New Font("Times New Roman", 9F)
        UpdateButton.ForeColor = SystemColors.ButtonFace
        UpdateButton.Location = New Point(14, 319)
        UpdateButton.Margin = New Padding(2)
        UpdateButton.Name = "UpdateButton"
        UpdateButton.Size = New Size(85, 29)
        UpdateButton.TabIndex = 4
        UpdateButton.Text = "Update"
        UpdateButton.UseVisualStyleBackColor = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox1.AutoSize = True
        GroupBox1.Controls.Add(CurrentAmtTxtBox)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(TargetDateTimePicker)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(StartDateTimePicker)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(TargetAmtTxtBox)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(GoalDescriptionTxtBox)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(StartingAmtTxtBox)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.FlatStyle = FlatStyle.Popup
        GroupBox1.Font = New Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBox1.ForeColor = Color.Transparent
        GroupBox1.Location = New Point(11, 11)
        GroupBox1.Margin = New Padding(2)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(2)
        GroupBox1.Size = New Size(451, 288)
        GroupBox1.TabIndex = 3
        GroupBox1.TabStop = False
        ' 
        ' TargetDateTimePicker
        ' 
        TargetDateTimePicker.Format = DateTimePickerFormat.Short
        TargetDateTimePicker.Location = New Point(200, 214)
        TargetDateTimePicker.Margin = New Padding(2)
        TargetDateTimePicker.MinDate = New Date(2024, 3, 3, 0, 0, 0, 0)
        TargetDateTimePicker.Name = "TargetDateTimePicker"
        TargetDateTimePicker.Size = New Size(238, 21)
        TargetDateTimePicker.TabIndex = 17
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(22, 213)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(66, 15)
        Label2.TabIndex = 16
        Label2.Text = "Target Date:"
        ' 
        ' StartDateTimePicker
        ' 
        StartDateTimePicker.Format = DateTimePickerFormat.Short
        StartDateTimePicker.Location = New Point(200, 184)
        StartDateTimePicker.Margin = New Padding(2)
        StartDateTimePicker.MinDate = New Date(2024, 3, 3, 0, 0, 0, 0)
        StartDateTimePicker.Name = "StartDateTimePicker"
        StartDateTimePicker.Size = New Size(238, 21)
        StartDateTimePicker.TabIndex = 15
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(22, 183)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(59, 15)
        Label4.TabIndex = 14
        Label4.Text = "Start Date:"
        ' 
        ' TargetAmtTxtBox
        ' 
        TargetAmtTxtBox.Location = New Point(200, 119)
        TargetAmtTxtBox.Margin = New Padding(2)
        TargetAmtTxtBox.Name = "TargetAmtTxtBox"
        TargetAmtTxtBox.PlaceholderText = "Enter Target Amount"
        TargetAmtTxtBox.Size = New Size(238, 21)
        TargetAmtTxtBox.TabIndex = 13
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(22, 118)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(82, 15)
        Label1.TabIndex = 12
        Label1.Text = "Target Amount:"
        ' 
        ' GoalDescriptionTxtBox
        ' 
        GoalDescriptionTxtBox.Location = New Point(200, 18)
        GoalDescriptionTxtBox.Margin = New Padding(2)
        GoalDescriptionTxtBox.Multiline = True
        GoalDescriptionTxtBox.Name = "GoalDescriptionTxtBox"
        GoalDescriptionTxtBox.PlaceholderText = "Short Description"
        GoalDescriptionTxtBox.Size = New Size(238, 47)
        GoalDescriptionTxtBox.TabIndex = 11
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(22, 15)
        Label5.Margin = New Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(93, 15)
        Label5.TabIndex = 10
        Label5.Text = "Goal Description:"
        ' 
        ' StartingAmtTxtBox
        ' 
        StartingAmtTxtBox.Location = New Point(200, 82)
        StartingAmtTxtBox.Margin = New Padding(2)
        StartingAmtTxtBox.Name = "StartingAmtTxtBox"
        StartingAmtTxtBox.PlaceholderText = "Enter Starting Amount"
        StartingAmtTxtBox.Size = New Size(238, 21)
        StartingAmtTxtBox.TabIndex = 7
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(22, 81)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(89, 15)
        Label3.TabIndex = 5
        Label3.Text = "Starting Amount:"
        ' 
        ' CurrentAmtTxtBox
        ' 
        CurrentAmtTxtBox.Location = New Point(199, 150)
        CurrentAmtTxtBox.Margin = New Padding(2)
        CurrentAmtTxtBox.Name = "CurrentAmtTxtBox"
        CurrentAmtTxtBox.PlaceholderText = "Current Amount"
        CurrentAmtTxtBox.Size = New Size(239, 21)
        CurrentAmtTxtBox.TabIndex = 21
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(22, 150)
        Label6.Margin = New Padding(2, 0, 2, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(86, 15)
        Label6.TabIndex = 20
        Label6.Text = "Current Amount"
        ' 
        ' updateGoalForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(37), CByte(42), CByte(64))
        ClientSize = New Size(469, 387)
        Controls.Add(StopButton)
        Controls.Add(UpdateButton)
        Controls.Add(GroupBox1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "updateGoalForm"
        Text = "updateGoalForm"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents StopButton As Button
    Friend WithEvents UpdateButton As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TargetDateTimePicker As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents StartDateTimePicker As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents TargetAmtTxtBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GoalDescriptionTxtBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents StartingAmtTxtBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents CurrentAmtTxtBox As TextBox
    Friend WithEvents Label6 As Label
End Class
