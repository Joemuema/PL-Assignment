<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Loans
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Loans))
        Panel1 = New Panel()
        Button9 = New Button()
        Button2 = New Button()
        Button7 = New Button()
        Button3 = New Button()
        Button6 = New Button()
        Button5 = New Button()
        Debts = New GroupBox()
        DebtRepayment = New Button()
        RecordDebt = New Button()
        ViewDebts = New Button()
        Panel2 = New Panel()
        Transactions = New Label()
        GroupBox1 = New GroupBox()
        Button1 = New Button()
        RepayLoan = New Button()
        TakeLoan = New Button()
        Panel1.SuspendLayout()
        Debts.SuspendLayout()
        Panel2.SuspendLayout()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(24), CByte(30), CByte(54))
        Panel1.Controls.Add(Button9)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button7)
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(Button6)
        Panel1.Controls.Add(Button5)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(187, 729)
        Panel1.TabIndex = 0
        ' 
        ' Button9
        ' 
        Button9.AutoSize = True
        Button9.BackColor = Color.FromArgb(CByte(24), CByte(30), CByte(54))
        Button9.BackgroundImageLayout = ImageLayout.None
        Button9.FlatStyle = FlatStyle.Popup
        Button9.Font = New Font("Times New Roman", 9.75F)
        Button9.ForeColor = SystemColors.ButtonFace
        Button9.Image = My.Resources.Resources.exit__1___1_1
        Button9.ImageAlign = ContentAlignment.MiddleLeft
        Button9.ImeMode = ImeMode.NoControl
        Button9.Location = New Point(1, 350)
        Button9.Name = "Button9"
        Button9.Size = New Size(188, 61)
        Button9.TabIndex = 20
        Button9.Text = "Logout"
        Button9.TextAlign = ContentAlignment.MiddleRight
        Button9.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.AutoSize = True
        Button2.BackColor = Color.FromArgb(CByte(24), CByte(30), CByte(54))
        Button2.BackgroundImageLayout = ImageLayout.None
        Button2.FlatStyle = FlatStyle.Popup
        Button2.Font = New Font("Times New Roman", 9.75F)
        Button2.ForeColor = SystemColors.ButtonFace
        Button2.Image = CType(resources.GetObject("Button2.Image"), Image)
        Button2.ImageAlign = ContentAlignment.TopLeft
        Button2.ImeMode = ImeMode.NoControl
        Button2.Location = New Point(1, 50)
        Button2.Name = "Button2"
        Button2.Size = New Size(188, 61)
        Button2.TabIndex = 14
        Button2.Text = "Account overview"
        Button2.TextAlign = ContentAlignment.MiddleRight
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button7
        ' 
        Button7.AutoSize = True
        Button7.BackColor = Color.FromArgb(CByte(24), CByte(30), CByte(54))
        Button7.BackgroundImageLayout = ImageLayout.None
        Button7.FlatStyle = FlatStyle.Popup
        Button7.Font = New Font("Times New Roman", 9.75F)
        Button7.ForeColor = SystemColors.ButtonFace
        Button7.Image = CType(resources.GetObject("Button7.Image"), Image)
        Button7.ImageAlign = ContentAlignment.MiddleLeft
        Button7.ImeMode = ImeMode.NoControl
        Button7.Location = New Point(1, 286)
        Button7.Name = "Button7"
        Button7.Size = New Size(188, 66)
        Button7.TabIndex = 19
        Button7.Text = "Financial Goals"
        Button7.TextAlign = ContentAlignment.MiddleRight
        Button7.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.AutoSize = True
        Button3.BackColor = Color.FromArgb(CByte(24), CByte(30), CByte(54))
        Button3.BackgroundImageLayout = ImageLayout.None
        Button3.FlatStyle = FlatStyle.Popup
        Button3.Font = New Font("Times New Roman", 9.75F)
        Button3.ForeColor = SystemColors.ButtonFace
        Button3.Image = CType(resources.GetObject("Button3.Image"), Image)
        Button3.ImageAlign = ContentAlignment.MiddleLeft
        Button3.ImeMode = ImeMode.NoControl
        Button3.Location = New Point(1, 107)
        Button3.Name = "Button3"
        Button3.Size = New Size(188, 62)
        Button3.TabIndex = 15
        Button3.Text = "Transactions"
        Button3.TextAlign = ContentAlignment.MiddleRight
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button6
        ' 
        Button6.AutoSize = True
        Button6.BackColor = Color.FromArgb(CByte(24), CByte(30), CByte(54))
        Button6.BackgroundImageLayout = ImageLayout.None
        Button6.FlatStyle = FlatStyle.Popup
        Button6.Font = New Font("Times New Roman", 9.75F)
        Button6.ForeColor = SystemColors.ButtonFace
        Button6.Image = CType(resources.GetObject("Button6.Image"), Image)
        Button6.ImageAlign = ContentAlignment.MiddleLeft
        Button6.ImeMode = ImeMode.NoControl
        Button6.Location = New Point(1, 226)
        Button6.Name = "Button6"
        Button6.Size = New Size(188, 61)
        Button6.TabIndex = 16
        Button6.Text = "Budgeting"
        Button6.TextAlign = ContentAlignment.MiddleRight
        Button6.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.AutoSize = True
        Button5.BackColor = Color.FromArgb(CByte(24), CByte(30), CByte(54))
        Button5.BackgroundImageLayout = ImageLayout.None
        Button5.FlatStyle = FlatStyle.Popup
        Button5.Font = New Font("Times New Roman", 9.75F)
        Button5.ForeColor = SystemColors.ButtonFace
        Button5.Image = CType(resources.GetObject("Button5.Image"), Image)
        Button5.ImageAlign = ContentAlignment.MiddleLeft
        Button5.ImeMode = ImeMode.NoControl
        Button5.Location = New Point(1, 168)
        Button5.Name = "Button5"
        Button5.Size = New Size(188, 61)
        Button5.TabIndex = 18
        Button5.Text = "Loans and Debts"
        Button5.TextAlign = ContentAlignment.MiddleRight
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Debts
        ' 
        Debts.Controls.Add(DebtRepayment)
        Debts.Controls.Add(RecordDebt)
        Debts.Controls.Add(ViewDebts)
        Debts.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        Debts.ForeColor = SystemColors.ControlLightLight
        Debts.Location = New Point(771, 433)
        Debts.Margin = New Padding(2)
        Debts.Name = "Debts"
        Debts.Padding = New Padding(2)
        Debts.Size = New Size(568, 223)
        Debts.TabIndex = 3
        Debts.TabStop = False
        Debts.Text = "DEBTS"
        ' 
        ' DebtRepayment
        ' 
        DebtRepayment.BackColor = Color.FromArgb(CByte(24), CByte(30), CByte(54))
        DebtRepayment.FlatStyle = FlatStyle.Popup
        DebtRepayment.ForeColor = SystemColors.ButtonFace
        DebtRepayment.Location = New Point(318, 162)
        DebtRepayment.Margin = New Padding(2)
        DebtRepayment.Name = "DebtRepayment"
        DebtRepayment.Size = New Size(181, 29)
        DebtRepayment.TabIndex = 5
        DebtRepayment.Text = "DEBT REPAYMENT"
        DebtRepayment.UseVisualStyleBackColor = False
        ' 
        ' RecordDebt
        ' 
        RecordDebt.BackColor = Color.FromArgb(CByte(24), CByte(30), CByte(54))
        RecordDebt.FlatStyle = FlatStyle.Popup
        RecordDebt.ForeColor = SystemColors.ButtonFace
        RecordDebt.Location = New Point(309, 58)
        RecordDebt.Margin = New Padding(2)
        RecordDebt.Name = "RecordDebt"
        RecordDebt.Size = New Size(190, 29)
        RecordDebt.TabIndex = 4
        RecordDebt.Text = "RECORD DEBT/DEBTOR"
        RecordDebt.UseVisualStyleBackColor = False
        ' 
        ' ViewDebts
        ' 
        ViewDebts.BackColor = Color.FromArgb(CByte(24), CByte(30), CByte(54))
        ViewDebts.FlatStyle = FlatStyle.Popup
        ViewDebts.ForeColor = SystemColors.ButtonFace
        ViewDebts.Location = New Point(73, 99)
        ViewDebts.Margin = New Padding(2)
        ViewDebts.Name = "ViewDebts"
        ViewDebts.Size = New Size(126, 29)
        ViewDebts.TabIndex = 3
        ViewDebts.Text = "VIEW DEBTS RECORD"
        ViewDebts.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(46), CByte(51), CByte(73))
        Panel2.Controls.Add(Transactions)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(187, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1163, 104)
        Panel2.TabIndex = 4
        ' 
        ' Transactions
        ' 
        Transactions.Font = New Font("Times New Roman", 36F)
        Transactions.ForeColor = Color.DodgerBlue
        Transactions.Image = CType(resources.GetObject("Transactions.Image"), Image)
        Transactions.ImageAlign = ContentAlignment.MiddleLeft
        Transactions.ImeMode = ImeMode.NoControl
        Transactions.Location = New Point(2, 0)
        Transactions.Name = "Transactions"
        Transactions.Size = New Size(452, 111)
        Transactions.TabIndex = 1
        Transactions.Text = "Loans And Debts"
        Transactions.TextAlign = ContentAlignment.BottomRight
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Controls.Add(RepayLoan)
        GroupBox1.Controls.Add(TakeLoan)
        GroupBox1.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        GroupBox1.ForeColor = SystemColors.ButtonFace
        GroupBox1.Location = New Point(194, 158)
        GroupBox1.Margin = New Padding(2)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(2)
        GroupBox1.Size = New Size(556, 223)
        GroupBox1.TabIndex = 5
        GroupBox1.TabStop = False
        GroupBox1.Text = "LOANS"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(24), CByte(30), CByte(54))
        Button1.FlatStyle = FlatStyle.Popup
        Button1.ForeColor = SystemColors.ButtonFace
        Button1.Location = New Point(336, 99)
        Button1.Margin = New Padding(2)
        Button1.Name = "Button1"
        Button1.Size = New Size(133, 29)
        Button1.TabIndex = 2
        Button1.Text = "VIEW LOANS RECORD"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' RepayLoan
        ' 
        RepayLoan.BackColor = Color.FromArgb(CByte(24), CByte(30), CByte(54))
        RepayLoan.FlatStyle = FlatStyle.Popup
        RepayLoan.ForeColor = SystemColors.ButtonFace
        RepayLoan.Location = New Point(60, 162)
        RepayLoan.Margin = New Padding(2)
        RepayLoan.Name = "RepayLoan"
        RepayLoan.Size = New Size(158, 29)
        RepayLoan.TabIndex = 1
        RepayLoan.Text = "REPAY A LOAN"
        RepayLoan.UseVisualStyleBackColor = False
        ' 
        ' TakeLoan
        ' 
        TakeLoan.BackColor = Color.FromArgb(CByte(24), CByte(30), CByte(54))
        TakeLoan.FlatStyle = FlatStyle.Popup
        TakeLoan.ForeColor = SystemColors.ButtonFace
        TakeLoan.Location = New Point(60, 58)
        TakeLoan.Margin = New Padding(2)
        TakeLoan.Name = "TakeLoan"
        TakeLoan.Size = New Size(158, 29)
        TakeLoan.TabIndex = 0
        TakeLoan.Text = "TAKE  OUT A LOAN"
        TakeLoan.UseVisualStyleBackColor = False
        ' 
        ' Loans
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(37), CByte(42), CByte(64))
        ClientSize = New Size(1350, 729)
        Controls.Add(GroupBox1)
        Controls.Add(Panel2)
        Controls.Add(Debts)
        Controls.Add(Panel1)
        ForeColor = SystemColors.ButtonFace
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Loans"
        StartPosition = FormStartPosition.CenterParent
        Text = "Loans"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Debts.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        GroupBox1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Debts As GroupBox
    Friend WithEvents DebtRepayment As Button
    Friend WithEvents RecordDebt As Button
    Friend WithEvents ViewDebts As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Transactions As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents RepayLoan As Button
    Friend WithEvents TakeLoan As Button
End Class
