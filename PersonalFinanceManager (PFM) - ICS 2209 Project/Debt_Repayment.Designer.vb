<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Debt_Repayment
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
        RDHome = New Button()
        DRDetails = New GroupBox()
        Button1 = New Button()
        Label1 = New Label()
        RepayAmt = New TextBox()
        checkDebtDetails = New Button()
        RDRepaymentProgressdata = New ProgressBar()
        DRDebtAmount = New TextBox()
        DRDebtorNamedata = New TextBox()
        DRDebtIDdata = New TextBox()
        DRProgress = New Label()
        DRRepayAmount = New Label()
        DRDebtorName = New Label()
        DRAmount = New Label()
        DRDebtID = New Label()
        RDSaveDetails = New Button()
        DRDueDatedata = New MonthCalendar()
        DRDueDate = New Label()
        DRDetails.SuspendLayout()
        SuspendLayout()
        ' 
        ' RDHome
        ' 
        RDHome.BackColor = Color.FromArgb(CByte(24), CByte(30), CByte(54))
        RDHome.FlatStyle = FlatStyle.Popup
        RDHome.ForeColor = SystemColors.ButtonFace
        RDHome.Location = New Point(520, 497)
        RDHome.Name = "RDHome"
        RDHome.Size = New Size(137, 34)
        RDHome.TabIndex = 3
        RDHome.Text = "HOME"
        RDHome.UseVisualStyleBackColor = False
        ' 
        ' DRDetails
        ' 
        DRDetails.BackColor = Color.FromArgb(CByte(24), CByte(30), CByte(54))
        DRDetails.Controls.Add(Button1)
        DRDetails.Controls.Add(Label1)
        DRDetails.Controls.Add(RepayAmt)
        DRDetails.Controls.Add(checkDebtDetails)
        DRDetails.Controls.Add(RDRepaymentProgressdata)
        DRDetails.Controls.Add(DRDebtAmount)
        DRDetails.Controls.Add(DRDebtorNamedata)
        DRDetails.Controls.Add(DRDebtIDdata)
        DRDetails.Controls.Add(DRProgress)
        DRDetails.Controls.Add(DRRepayAmount)
        DRDetails.Controls.Add(DRDebtorName)
        DRDetails.Controls.Add(DRAmount)
        DRDetails.Controls.Add(DRDebtID)
        DRDetails.Controls.Add(RDSaveDetails)
        DRDetails.Controls.Add(DRDueDatedata)
        DRDetails.Controls.Add(DRDueDate)
        DRDetails.ForeColor = Color.White
        DRDetails.Location = New Point(11, 7)
        DRDetails.Name = "DRDetails"
        DRDetails.Size = New Size(711, 452)
        DRDetails.TabIndex = 2
        DRDetails.TabStop = False
        DRDetails.Text = "DEBT DETAILS"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(24), CByte(30), CByte(54))
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(164, 157)
        Button1.Margin = New Padding(2)
        Button1.Name = "Button1"
        Button1.Size = New Size(140, 34)
        Button1.TabIndex = 29
        Button1.Text = "CHECK Debt ID"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F)
        Label1.Location = New Point(8, 160)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(133, 15)
        Label1.TabIndex = 28
        Label1.Text = "Not sure of the Debt ID?"
        ' 
        ' RepayAmt
        ' 
        RepayAmt.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        RepayAmt.Location = New Point(165, 281)
        RepayAmt.Margin = New Padding(2)
        RepayAmt.Name = "RepayAmt"
        RepayAmt.Size = New Size(232, 23)
        RepayAmt.TabIndex = 27
        ' 
        ' checkDebtDetails
        ' 
        checkDebtDetails.BackColor = Color.FromArgb(CByte(24), CByte(30), CByte(54))
        checkDebtDetails.FlatStyle = FlatStyle.Popup
        checkDebtDetails.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        checkDebtDetails.ForeColor = Color.White
        checkDebtDetails.Location = New Point(164, 114)
        checkDebtDetails.Margin = New Padding(2)
        checkDebtDetails.Name = "checkDebtDetails"
        checkDebtDetails.Size = New Size(140, 30)
        checkDebtDetails.TabIndex = 26
        checkDebtDetails.Text = "CHECK DETAILS"
        checkDebtDetails.UseVisualStyleBackColor = False
        ' 
        ' RDRepaymentProgressdata
        ' 
        RDRepaymentProgressdata.Location = New Point(165, 325)
        RDRepaymentProgressdata.Name = "RDRepaymentProgressdata"
        RDRepaymentProgressdata.Size = New Size(230, 22)
        RDRepaymentProgressdata.Style = ProgressBarStyle.Continuous
        RDRepaymentProgressdata.TabIndex = 25
        ' 
        ' DRDebtAmount
        ' 
        DRDebtAmount.BackColor = Color.White
        DRDebtAmount.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        DRDebtAmount.Location = New Point(165, 236)
        DRDebtAmount.Name = "DRDebtAmount"
        DRDebtAmount.ReadOnly = True
        DRDebtAmount.Size = New Size(232, 23)
        DRDebtAmount.TabIndex = 24
        ' 
        ' DRDebtorNamedata
        ' 
        DRDebtorNamedata.BackColor = Color.White
        DRDebtorNamedata.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        DRDebtorNamedata.Location = New Point(165, 196)
        DRDebtorNamedata.Name = "DRDebtorNamedata"
        DRDebtorNamedata.ReadOnly = True
        DRDebtorNamedata.Size = New Size(232, 23)
        DRDebtorNamedata.TabIndex = 23
        ' 
        ' DRDebtIDdata
        ' 
        DRDebtIDdata.BackColor = Color.White
        DRDebtIDdata.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        DRDebtIDdata.Location = New Point(164, 85)
        DRDebtIDdata.Name = "DRDebtIDdata"
        DRDebtIDdata.Size = New Size(231, 23)
        DRDebtIDdata.TabIndex = 22
        ' 
        ' DRProgress
        ' 
        DRProgress.AutoSize = True
        DRProgress.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        DRProgress.ForeColor = Color.White
        DRProgress.Location = New Point(2, 325)
        DRProgress.Name = "DRProgress"
        DRProgress.Size = New Size(138, 15)
        DRProgress.TabIndex = 21
        DRProgress.Text = "REPAYMENT PROGRESS"
        ' 
        ' DRRepayAmount
        ' 
        DRRepayAmount.AutoSize = True
        DRRepayAmount.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        DRRepayAmount.ForeColor = Color.White
        DRRepayAmount.Location = New Point(37, 281)
        DRRepayAmount.Name = "DRRepayAmount"
        DRRepayAmount.Size = New Size(97, 15)
        DRRepayAmount.TabIndex = 20
        DRRepayAmount.Text = "REPAY AMOUNT"
        ' 
        ' DRDebtorName
        ' 
        DRDebtorName.AutoSize = True
        DRDebtorName.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        DRDebtorName.ForeColor = Color.White
        DRDebtorName.Location = New Point(46, 196)
        DRDebtorName.Name = "DRDebtorName"
        DRDebtorName.Size = New Size(91, 15)
        DRDebtorName.TabIndex = 19
        DRDebtorName.Text = "DEBTOR NAME"
        ' 
        ' DRAmount
        ' 
        DRAmount.AutoSize = True
        DRAmount.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        DRAmount.ForeColor = Color.White
        DRAmount.Location = New Point(9, 236)
        DRAmount.Name = "DRAmount"
        DRAmount.Size = New Size(132, 15)
        DRAmount.TabIndex = 18
        DRAmount.Text = "TOTAL DEBT AMOUNT"
        ' 
        ' DRDebtID
        ' 
        DRDebtID.AutoSize = True
        DRDebtID.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        DRDebtID.ForeColor = Color.White
        DRDebtID.Location = New Point(14, 89)
        DRDebtID.Name = "DRDebtID"
        DRDebtID.Size = New Size(53, 15)
        DRDebtID.TabIndex = 17
        DRDebtID.Text = "DEBT ID"
        ' 
        ' RDSaveDetails
        ' 
        RDSaveDetails.BackColor = Color.FromArgb(CByte(24), CByte(30), CByte(54))
        RDSaveDetails.FlatStyle = FlatStyle.Popup
        RDSaveDetails.ForeColor = SystemColors.ButtonFace
        RDSaveDetails.Location = New Point(494, 412)
        RDSaveDetails.Name = "RDSaveDetails"
        RDSaveDetails.Size = New Size(152, 34)
        RDSaveDetails.TabIndex = 12
        RDSaveDetails.Text = "SAVE DETAILS"
        RDSaveDetails.UseVisualStyleBackColor = False
        ' 
        ' DRDueDatedata
        ' 
        DRDueDatedata.Location = New Point(473, 89)
        DRDueDatedata.Name = "DRDueDatedata"
        DRDueDatedata.TabIndex = 10
        ' 
        ' DRDueDate
        ' 
        DRDueDate.AutoSize = True
        DRDueDate.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        DRDueDate.ForeColor = Color.White
        DRDueDate.Location = New Point(558, 59)
        DRDueDate.Name = "DRDueDate"
        DRDueDate.Size = New Size(87, 21)
        DRDueDate.TabIndex = 4
        DRDueDate.Text = "DUE DATE"
        ' 
        ' Debt_Repayment
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(24), CByte(30), CByte(54))
        ClientSize = New Size(729, 566)
        Controls.Add(RDHome)
        Controls.Add(DRDetails)
        MaximizeBox = False
        Name = "Debt_Repayment"
        Text = "Debt_Repayment"
        DRDetails.ResumeLayout(False)
        DRDetails.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents RDHome As Button
    Friend WithEvents DRDetails As GroupBox
    Friend WithEvents RDSaveDetails As Button
    Friend WithEvents DRDueDatedata As MonthCalendar
    Friend WithEvents DRDueDate As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents RepayAmt As TextBox
    Friend WithEvents checkDebtDetails As Button
    Friend WithEvents RDRepaymentProgressdata As ProgressBar
    Friend WithEvents DRDebtAmount As TextBox
    Friend WithEvents DRDebtorNamedata As TextBox
    Friend WithEvents DRDebtIDdata As TextBox
    Friend WithEvents DRProgress As Label
    Friend WithEvents DRRepayAmount As Label
    Friend WithEvents DRDebtorName As Label
    Friend WithEvents DRAmount As Label
    Friend WithEvents DRDebtID As Label
End Class
