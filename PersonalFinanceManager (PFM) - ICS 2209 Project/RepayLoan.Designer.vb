<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RepayLoan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RepayLoan))
        RLHome = New Button()
        RepayGroupBox = New GroupBox()
        DspLoanername = New TextBox()
        RLLoanername = New Label()
        CheckDetails = New Button()
        CheckLoanID = New Button()
        Label1 = New Label()
        SaveLoanPayment = New Button()
        ProgressBar1 = New ProgressBar()
        TotalAmt = New TextBox()
        RepayAmount = New TextBox()
        RLLoanid = New TextBox()
        MonthCalendar1 = New MonthCalendar()
        RLPayProgress = New Label()
        RLPayByDate = New Label()
        DepositAmt = New Label()
        RLDepoAmt = New Label()
        LoanID = New Label()
        RepayGroupBox.SuspendLayout()
        SuspendLayout()
        ' 
        ' RLHome
        ' 
        RLHome.BackColor = Color.FromArgb(CByte(24), CByte(30), CByte(54))
        RLHome.FlatStyle = FlatStyle.Popup
        RLHome.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        RLHome.ForeColor = SystemColors.ButtonFace
        RLHome.Location = New Point(637, 379)
        RLHome.Margin = New Padding(2)
        RLHome.Name = "RLHome"
        RLHome.Size = New Size(116, 24)
        RLHome.TabIndex = 3
        RLHome.Text = "HOME"
        RLHome.UseVisualStyleBackColor = False
        ' 
        ' RepayGroupBox
        ' 
        RepayGroupBox.BackColor = Color.FromArgb(CByte(37), CByte(42), CByte(64))
        RepayGroupBox.Controls.Add(DspLoanername)
        RepayGroupBox.Controls.Add(RLLoanername)
        RepayGroupBox.Controls.Add(CheckDetails)
        RepayGroupBox.Controls.Add(CheckLoanID)
        RepayGroupBox.Controls.Add(Label1)
        RepayGroupBox.Controls.Add(SaveLoanPayment)
        RepayGroupBox.Controls.Add(ProgressBar1)
        RepayGroupBox.Controls.Add(TotalAmt)
        RepayGroupBox.Controls.Add(RepayAmount)
        RepayGroupBox.Controls.Add(RLLoanid)
        RepayGroupBox.Controls.Add(MonthCalendar1)
        RepayGroupBox.Controls.Add(RLPayProgress)
        RepayGroupBox.Controls.Add(RLPayByDate)
        RepayGroupBox.Controls.Add(DepositAmt)
        RepayGroupBox.Controls.Add(RLDepoAmt)
        RepayGroupBox.Controls.Add(LoanID)
        RepayGroupBox.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        RepayGroupBox.ForeColor = Color.White
        RepayGroupBox.Location = New Point(11, 64)
        RepayGroupBox.Margin = New Padding(2)
        RepayGroupBox.Name = "RepayGroupBox"
        RepayGroupBox.Padding = New Padding(2)
        RepayGroupBox.Size = New Size(757, 279)
        RepayGroupBox.TabIndex = 2
        RepayGroupBox.TabStop = False
        RepayGroupBox.Text = "LOAN DETAILS"
        ' 
        ' DspLoanername
        ' 
        DspLoanername.Location = New Point(178, 209)
        DspLoanername.Margin = New Padding(2)
        DspLoanername.Name = "DspLoanername"
        DspLoanername.ReadOnly = True
        DspLoanername.Size = New Size(164, 23)
        DspLoanername.TabIndex = 20
        ' 
        ' RLLoanername
        ' 
        RLLoanername.AutoSize = True
        RLLoanername.BackColor = Color.Transparent
        RLLoanername.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        RLLoanername.ForeColor = SystemColors.ButtonHighlight
        RLLoanername.Location = New Point(22, 209)
        RLLoanername.Margin = New Padding(2, 0, 2, 0)
        RLLoanername.Name = "RLLoanername"
        RLLoanername.Size = New Size(101, 15)
        RLLoanername.TabIndex = 19
        RLLoanername.Text = "LOANER'S NAME"
        ' 
        ' CheckDetails
        ' 
        CheckDetails.BackColor = Color.FromArgb(CByte(24), CByte(30), CByte(54))
        CheckDetails.FlatStyle = FlatStyle.Popup
        CheckDetails.ForeColor = Color.White
        CheckDetails.Location = New Point(181, 61)
        CheckDetails.Margin = New Padding(2)
        CheckDetails.Name = "CheckDetails"
        CheckDetails.Size = New Size(134, 20)
        CheckDetails.TabIndex = 18
        CheckDetails.Text = "GET LOAN DETAILS"
        CheckDetails.UseVisualStyleBackColor = False
        ' 
        ' CheckLoanID
        ' 
        CheckLoanID.BackColor = Color.FromArgb(CByte(24), CByte(30), CByte(54))
        CheckLoanID.FlatStyle = FlatStyle.Popup
        CheckLoanID.ForeColor = Color.White
        CheckLoanID.Location = New Point(181, 94)
        CheckLoanID.Margin = New Padding(2)
        CheckLoanID.Name = "CheckLoanID"
        CheckLoanID.Size = New Size(115, 20)
        CheckLoanID.TabIndex = 17
        CheckLoanID.Text = "CHECK Loan ID"
        CheckLoanID.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F)
        Label1.Location = New Point(22, 97)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(134, 15)
        Label1.TabIndex = 16
        Label1.Text = "Not sure of the Loan ID?"
        ' 
        ' SaveLoanPayment
        ' 
        SaveLoanPayment.BackColor = Color.FromArgb(CByte(24), CByte(30), CByte(54))
        SaveLoanPayment.FlatStyle = FlatStyle.Popup
        SaveLoanPayment.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        SaveLoanPayment.ForeColor = SystemColors.ButtonFace
        SaveLoanPayment.Location = New Point(626, 237)
        SaveLoanPayment.Margin = New Padding(2)
        SaveLoanPayment.Name = "SaveLoanPayment"
        SaveLoanPayment.Size = New Size(116, 24)
        SaveLoanPayment.TabIndex = 5
        SaveLoanPayment.Text = "SAVE DETAILS"
        SaveLoanPayment.UseVisualStyleBackColor = False
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Location = New Point(178, 247)
        ProgressBar1.Margin = New Padding(2)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(164, 20)
        ProgressBar1.TabIndex = 9
        ' 
        ' TotalAmt
        ' 
        TotalAmt.Location = New Point(178, 171)
        TotalAmt.Margin = New Padding(2)
        TotalAmt.Name = "TotalAmt"
        TotalAmt.ReadOnly = True
        TotalAmt.Size = New Size(164, 23)
        TotalAmt.TabIndex = 8
        ' 
        ' RepayAmount
        ' 
        RepayAmount.Location = New Point(178, 128)
        RepayAmount.Margin = New Padding(2)
        RepayAmount.Name = "RepayAmount"
        RepayAmount.Size = New Size(164, 23)
        RepayAmount.TabIndex = 7
        ' 
        ' RLLoanid
        ' 
        RLLoanid.Location = New Point(181, 26)
        RLLoanid.Margin = New Padding(2)
        RLLoanid.Name = "RLLoanid"
        RLLoanid.Size = New Size(164, 23)
        RLLoanid.TabIndex = 6
        ' 
        ' MonthCalendar1
        ' 
        MonthCalendar1.Location = New Point(515, 47)
        MonthCalendar1.Margin = New Padding(6, 5, 6, 5)
        MonthCalendar1.Name = "MonthCalendar1"
        MonthCalendar1.TabIndex = 5
        ' 
        ' RLPayProgress
        ' 
        RLPayProgress.AutoSize = True
        RLPayProgress.BackColor = Color.Transparent
        RLPayProgress.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        RLPayProgress.ForeColor = SystemColors.ButtonHighlight
        RLPayProgress.Location = New Point(22, 247)
        RLPayProgress.Margin = New Padding(2, 0, 2, 0)
        RLPayProgress.Name = "RLPayProgress"
        RLPayProgress.Size = New Size(124, 15)
        RLPayProgress.TabIndex = 4
        RLPayProgress.Text = "PAYMENT PROGRESS"
        ' 
        ' RLPayByDate
        ' 
        RLPayByDate.AutoSize = True
        RLPayByDate.BackColor = Color.Transparent
        RLPayByDate.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        RLPayByDate.ForeColor = SystemColors.ButtonHighlight
        RLPayByDate.Location = New Point(408, 46)
        RLPayByDate.Margin = New Padding(2, 0, 2, 0)
        RLPayByDate.Name = "RLPayByDate"
        RLPayByDate.Size = New Size(77, 15)
        RLPayByDate.TabIndex = 3
        RLPayByDate.Text = "PAY BY DATE"
        ' 
        ' DepositAmt
        ' 
        DepositAmt.AutoSize = True
        DepositAmt.BackColor = Color.Transparent
        DepositAmt.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        DepositAmt.ForeColor = SystemColors.ButtonHighlight
        DepositAmt.Location = New Point(22, 131)
        DepositAmt.Margin = New Padding(2, 0, 2, 0)
        DepositAmt.Name = "DepositAmt"
        DepositAmt.Size = New Size(112, 15)
        DepositAmt.TabIndex = 2
        DepositAmt.Text = "DEPOSIT AMOUNT"
        ' 
        ' RLDepoAmt
        ' 
        RLDepoAmt.AutoSize = True
        RLDepoAmt.BackColor = Color.Transparent
        RLDepoAmt.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        RLDepoAmt.ForeColor = SystemColors.ButtonHighlight
        RLDepoAmt.Location = New Point(22, 174)
        RLDepoAmt.Margin = New Padding(2, 0, 2, 0)
        RLDepoAmt.Name = "RLDepoAmt"
        RLDepoAmt.Size = New Size(134, 15)
        RLDepoAmt.TabIndex = 1
        RLDepoAmt.Text = "TOTAL LOAN AMOUNT"
        ' 
        ' LoanID
        ' 
        LoanID.AutoSize = True
        LoanID.BackColor = Color.Transparent
        LoanID.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        LoanID.ForeColor = SystemColors.ButtonHighlight
        LoanID.Location = New Point(22, 29)
        LoanID.Margin = New Padding(2, 0, 2, 0)
        LoanID.Name = "LoanID"
        LoanID.Size = New Size(55, 15)
        LoanID.TabIndex = 0
        LoanID.Text = "LOAN ID"
        ' 
        ' RepayLoan
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(24), CByte(30), CByte(54))
        ClientSize = New Size(800, 450)
        Controls.Add(RLHome)
        Controls.Add(RepayGroupBox)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "RepayLoan"
        Text = "RepayLoan"
        RepayGroupBox.ResumeLayout(False)
        RepayGroupBox.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents RLHome As Button
    Friend WithEvents RepayGroupBox As GroupBox
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents TotalAmt As TextBox
    Friend WithEvents RepayAmount As TextBox
    Friend WithEvents RLLoanid As TextBox
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents RLPayProgress As Label
    Friend WithEvents RLPayByDate As Label
    Friend WithEvents DepositAmt As Label
    Friend WithEvents RLDepoAmt As Label
    Friend WithEvents LoanID As Label
    Friend WithEvents SaveLoanPayment As Button
    Friend WithEvents CheckLoanID As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents CheckDetails As Button
    Friend WithEvents DspLoanername As TextBox
    Friend WithEvents RLLoanername As Label
End Class
