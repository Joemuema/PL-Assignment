<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TakeLoan
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
        TLHome = New Button()
        LoanDetails = New GroupBox()
        TLSave = New Button()
        PayDatePicker = New DateTimePicker()
        DateTknPicker = New DateTimePicker()
        IntRate = New TextBox()
        LoanerName = New TextBox()
        LoanAmt = New TextBox()
        PayDate = New Label()
        TakeDate = New Label()
        InterestRate = New Label()
        Loaner = New Label()
        Amount = New Label()
        LoanDetails.SuspendLayout()
        SuspendLayout()
        ' 
        ' TLHome
        ' 
        TLHome.BackColor = Color.FromArgb(CByte(24), CByte(30), CByte(54))
        TLHome.FlatStyle = FlatStyle.Popup
        TLHome.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        TLHome.ForeColor = SystemColors.ButtonFace
        TLHome.Location = New Point(566, 363)
        TLHome.Margin = New Padding(2)
        TLHome.Name = "TLHome"
        TLHome.Size = New Size(172, 44)
        TLHome.TabIndex = 3
        TLHome.Text = "HOME"
        TLHome.UseVisualStyleBackColor = False
        ' 
        ' LoanDetails
        ' 
        LoanDetails.Controls.Add(TLSave)
        LoanDetails.Controls.Add(PayDatePicker)
        LoanDetails.Controls.Add(DateTknPicker)
        LoanDetails.Controls.Add(IntRate)
        LoanDetails.Controls.Add(LoanerName)
        LoanDetails.Controls.Add(LoanAmt)
        LoanDetails.Controls.Add(PayDate)
        LoanDetails.Controls.Add(TakeDate)
        LoanDetails.Controls.Add(InterestRate)
        LoanDetails.Controls.Add(Loaner)
        LoanDetails.Controls.Add(Amount)
        LoanDetails.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        LoanDetails.ForeColor = SystemColors.ButtonHighlight
        LoanDetails.Location = New Point(12, 23)
        LoanDetails.Margin = New Padding(2)
        LoanDetails.Name = "LoanDetails"
        LoanDetails.Padding = New Padding(2)
        LoanDetails.Size = New Size(743, 247)
        LoanDetails.TabIndex = 2
        LoanDetails.TabStop = False
        LoanDetails.Text = "LOAN DETAILS"
        ' 
        ' TLSave
        ' 
        TLSave.BackColor = Color.FromArgb(CByte(24), CByte(30), CByte(54))
        TLSave.FlatStyle = FlatStyle.Popup
        TLSave.ForeColor = SystemColors.ButtonFace
        TLSave.Location = New Point(648, 212)
        TLSave.Margin = New Padding(2)
        TLSave.Name = "TLSave"
        TLSave.Size = New Size(78, 25)
        TLSave.TabIndex = 10
        TLSave.Text = "SAVE "
        TLSave.UseVisualStyleBackColor = False
        ' 
        ' PayDatePicker
        ' 
        PayDatePicker.Location = New Point(138, 214)
        PayDatePicker.Margin = New Padding(2)
        PayDatePicker.Name = "PayDatePicker"
        PayDatePicker.Size = New Size(211, 23)
        PayDatePicker.TabIndex = 9
        ' 
        ' DateTknPicker
        ' 
        DateTknPicker.Location = New Point(138, 166)
        DateTknPicker.Margin = New Padding(2)
        DateTknPicker.Name = "DateTknPicker"
        DateTknPicker.Size = New Size(211, 23)
        DateTknPicker.TabIndex = 8
        ' 
        ' IntRate
        ' 
        IntRate.Location = New Point(138, 124)
        IntRate.Margin = New Padding(2)
        IntRate.Name = "IntRate"
        IntRate.Size = New Size(153, 23)
        IntRate.TabIndex = 7
        ' 
        ' LoanerName
        ' 
        LoanerName.Location = New Point(138, 77)
        LoanerName.Margin = New Padding(2)
        LoanerName.Name = "LoanerName"
        LoanerName.Size = New Size(153, 23)
        LoanerName.TabIndex = 6
        ' 
        ' LoanAmt
        ' 
        LoanAmt.Location = New Point(138, 34)
        LoanAmt.Margin = New Padding(2)
        LoanAmt.Name = "LoanAmt"
        LoanAmt.Size = New Size(153, 23)
        LoanAmt.TabIndex = 5
        ' 
        ' PayDate
        ' 
        PayDate.AutoSize = True
        PayDate.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        PayDate.ForeColor = SystemColors.ButtonHighlight
        PayDate.Location = New Point(16, 216)
        PayDate.Margin = New Padding(2, 0, 2, 0)
        PayDate.Name = "PayDate"
        PayDate.Size = New Size(90, 15)
        PayDate.TabIndex = 4
        PayDate.Text = "PAYBACK DATE"
        ' 
        ' TakeDate
        ' 
        TakeDate.AutoSize = True
        TakeDate.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        TakeDate.ForeColor = SystemColors.ButtonHighlight
        TakeDate.Location = New Point(16, 169)
        TakeDate.Margin = New Padding(2, 0, 2, 0)
        TakeDate.Name = "TakeDate"
        TakeDate.Size = New Size(76, 15)
        TakeDate.TabIndex = 3
        TakeDate.Text = "DATE TAKEN"
        ' 
        ' InterestRate
        ' 
        InterestRate.AutoSize = True
        InterestRate.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        InterestRate.ForeColor = SystemColors.ButtonHighlight
        InterestRate.Location = New Point(16, 123)
        InterestRate.Margin = New Padding(2, 0, 2, 0)
        InterestRate.Name = "InterestRate"
        InterestRate.Size = New Size(92, 15)
        InterestRate.TabIndex = 2
        InterestRate.Text = "INTEREST RATE"
        ' 
        ' Loaner
        ' 
        Loaner.AutoSize = True
        Loaner.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Loaner.ForeColor = SystemColors.ButtonHighlight
        Loaner.Location = New Point(16, 79)
        Loaner.Margin = New Padding(2, 0, 2, 0)
        Loaner.Name = "Loaner"
        Loaner.Size = New Size(53, 15)
        Loaner.TabIndex = 1
        Loaner.Text = "LOANER"
        ' 
        ' Amount
        ' 
        Amount.AutoSize = True
        Amount.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Amount.ForeColor = SystemColors.ButtonHighlight
        Amount.Location = New Point(16, 35)
        Amount.Margin = New Padding(2, 0, 2, 0)
        Amount.Name = "Amount"
        Amount.Size = New Size(60, 15)
        Amount.TabIndex = 0
        Amount.Text = "AMOUNT"
        ' 
        ' TakeLoan
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(24), CByte(30), CByte(54))
        ClientSize = New Size(800, 450)
        Controls.Add(TLHome)
        Controls.Add(LoanDetails)
        ForeColor = SystemColors.ButtonFace
        MaximizeBox = False
        Name = "TakeLoan"
        Text = "TakeLoan"
        LoanDetails.ResumeLayout(False)
        LoanDetails.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TLHome As Button
    Friend WithEvents LoanDetails As GroupBox
    Friend WithEvents TLSave As Button
    Friend WithEvents PayDatePicker As DateTimePicker
    Friend WithEvents DateTknPicker As DateTimePicker
    Friend WithEvents IntRate As TextBox
    Friend WithEvents LoanerName As TextBox
    Friend WithEvents LoanAmt As TextBox
    Friend WithEvents PayDate As Label
    Friend WithEvents TakeDate As Label
    Friend WithEvents InterestRate As Label
    Friend WithEvents Loaner As Label
    Friend WithEvents Amount As Label
End Class
