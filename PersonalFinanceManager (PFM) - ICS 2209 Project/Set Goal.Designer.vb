<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        TargetDateTimePicker = New DateTimePicker()
        StartDateTimePicker = New DateTimePicker()
        GoalDescriptionTxtBox = New TextBox()
        Label5 = New Label()
        Label4 = New Label()
        StartingAmtTxtBox = New TextBox()
        TargetAmtTxtBox = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Panel5 = New Panel()
        Panel1 = New Panel()
        Backbtn = New Button()
        SaveBtn = New Button()
        Panel5.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TargetDateTimePicker
        ' 
        TargetDateTimePicker.Font = New Font("Times New Roman", 9F)
        TargetDateTimePicker.Format = DateTimePickerFormat.Short
        TargetDateTimePicker.Location = New Point(186, 112)
        TargetDateTimePicker.Margin = New Padding(2)
        TargetDateTimePicker.MinDate = New Date(2024, 3, 3, 0, 0, 0, 0)
        TargetDateTimePicker.Name = "TargetDateTimePicker"
        TargetDateTimePicker.Size = New Size(268, 21)
        TargetDateTimePicker.TabIndex = 23
        ' 
        ' StartDateTimePicker
        ' 
        StartDateTimePicker.Font = New Font("Times New Roman", 9F)
        StartDateTimePicker.Format = DateTimePickerFormat.Short
        StartDateTimePicker.Location = New Point(186, 84)
        StartDateTimePicker.Margin = New Padding(2)
        StartDateTimePicker.MinDate = New Date(2024, 3, 3, 0, 0, 0, 0)
        StartDateTimePicker.Name = "StartDateTimePicker"
        StartDateTimePicker.Size = New Size(268, 21)
        StartDateTimePicker.TabIndex = 22
        ' 
        ' GoalDescriptionTxtBox
        ' 
        GoalDescriptionTxtBox.Font = New Font("Times New Roman", 9F)
        GoalDescriptionTxtBox.Location = New Point(186, 141)
        GoalDescriptionTxtBox.Margin = New Padding(2)
        GoalDescriptionTxtBox.Multiline = True
        GoalDescriptionTxtBox.Name = "GoalDescriptionTxtBox"
        GoalDescriptionTxtBox.PlaceholderText = "Short Description"
        GoalDescriptionTxtBox.Size = New Size(268, 47)
        GoalDescriptionTxtBox.TabIndex = 21
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Times New Roman", 9F)
        Label5.ForeColor = SystemColors.ButtonFace
        Label5.Location = New Point(17, 141)
        Label5.Margin = New Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(93, 15)
        Label5.TabIndex = 20
        Label5.Text = "Goal Description:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Times New Roman", 9F)
        Label4.ForeColor = SystemColors.ButtonFace
        Label4.Location = New Point(17, 84)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(59, 15)
        Label4.TabIndex = 19
        Label4.Text = "Start Date:"
        ' 
        ' StartingAmtTxtBox
        ' 
        StartingAmtTxtBox.Font = New Font("Times New Roman", 9F)
        StartingAmtTxtBox.Location = New Point(186, 25)
        StartingAmtTxtBox.Margin = New Padding(2)
        StartingAmtTxtBox.Name = "StartingAmtTxtBox"
        StartingAmtTxtBox.PlaceholderText = "Enter Starting Amount"
        StartingAmtTxtBox.Size = New Size(268, 21)
        StartingAmtTxtBox.TabIndex = 18
        ' 
        ' TargetAmtTxtBox
        ' 
        TargetAmtTxtBox.Font = New Font("Times New Roman", 9F)
        TargetAmtTxtBox.Location = New Point(186, 55)
        TargetAmtTxtBox.Margin = New Padding(2)
        TargetAmtTxtBox.Name = "TargetAmtTxtBox"
        TargetAmtTxtBox.PlaceholderText = "Enter Target Amount"
        TargetAmtTxtBox.Size = New Size(268, 21)
        TargetAmtTxtBox.TabIndex = 17
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Times New Roman", 9F)
        Label3.ForeColor = SystemColors.ButtonFace
        Label3.Location = New Point(17, 25)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(89, 15)
        Label3.TabIndex = 16
        Label3.Text = "Starting Amount:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Times New Roman", 9F)
        Label2.ForeColor = SystemColors.ButtonFace
        Label2.Location = New Point(17, 112)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(66, 15)
        Label2.TabIndex = 15
        Label2.Text = "Target Date:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 9F)
        Label1.ForeColor = SystemColors.ButtonFace
        Label1.Location = New Point(17, 55)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(82, 15)
        Label1.TabIndex = 14
        Label1.Text = "Target Amount:"
        ' 
        ' Panel5
        ' 
        Panel5.Controls.Add(Panel1)
        Panel5.Dock = DockStyle.Bottom
        Panel5.Location = New Point(0, 239)
        Panel5.Margin = New Padding(2)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(478, 90)
        Panel5.TabIndex = 24
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Backbtn)
        Panel1.Controls.Add(SaveBtn)
        Panel1.Dock = DockStyle.Left
        Panel1.Font = New Font("Times New Roman", 9F)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(235, 90)
        Panel1.TabIndex = 0
        ' 
        ' Backbtn
        ' 
        Backbtn.BackColor = Color.FromArgb(CByte(24), CByte(30), CByte(54))
        Backbtn.Dock = DockStyle.Bottom
        Backbtn.FlatStyle = FlatStyle.Popup
        Backbtn.ForeColor = SystemColors.ButtonFace
        Backbtn.Location = New Point(0, 56)
        Backbtn.Margin = New Padding(2)
        Backbtn.Name = "Backbtn"
        Backbtn.Size = New Size(235, 34)
        Backbtn.TabIndex = 1
        Backbtn.Text = "Back"
        Backbtn.UseVisualStyleBackColor = False
        ' 
        ' SaveBtn
        ' 
        SaveBtn.BackColor = Color.FromArgb(CByte(24), CByte(30), CByte(54))
        SaveBtn.Dock = DockStyle.Top
        SaveBtn.FlatStyle = FlatStyle.Popup
        SaveBtn.ForeColor = SystemColors.ButtonFace
        SaveBtn.Location = New Point(0, 0)
        SaveBtn.Margin = New Padding(2)
        SaveBtn.Name = "SaveBtn"
        SaveBtn.Size = New Size(235, 34)
        SaveBtn.TabIndex = 11
        SaveBtn.Text = "Save"
        SaveBtn.UseVisualStyleBackColor = False
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(37), CByte(42), CByte(64))
        ClientSize = New Size(478, 329)
        Controls.Add(Panel5)
        Controls.Add(TargetDateTimePicker)
        Controls.Add(StartDateTimePicker)
        Controls.Add(GoalDescriptionTxtBox)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(StartingAmtTxtBox)
        Controls.Add(TargetAmtTxtBox)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Font = New Font("Times New Roman", 9F)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "Form3"
        Text = "Set Goals"
        Panel5.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TargetDateTimePicker As DateTimePicker
    Friend WithEvents StartDateTimePicker As DateTimePicker
    Friend WithEvents GoalDescriptionTxtBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents StartingAmtTxtBox As TextBox
    Friend WithEvents TargetAmtTxtBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Backbtn As Button
    Friend WithEvents SaveBtn As Button
    Friend WithEvents Panel1 As Panel
End Class
