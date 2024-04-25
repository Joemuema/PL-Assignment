<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Account
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Account))
        Button9 = New Button()
        Button7 = New Button()
        Button6 = New Button()
        Button5 = New Button()
        Button3 = New Button()
        Button1 = New Button()
        Panel1 = New Panel()
        Panel2 = New Panel()
        Panel3 = New Panel()
        UsernameLabel = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label1 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        LoanDataGridView = New DataGridView()
        Label6 = New Label()
        DebtDataGridView = New DataGridView()
        Label7 = New Label()
        Label8 = New Label()
        IncomeTextBox = New TextBox()
        ExpensesTextBox = New TextBox()
        Label9 = New Label()
        GoalDataGridView = New DataGridView()
        TransactionDataGridView = New DataGridView()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(LoanDataGridView, ComponentModel.ISupportInitialize).BeginInit()
        CType(DebtDataGridView, ComponentModel.ISupportInitialize).BeginInit()
        CType(GoalDataGridView, ComponentModel.ISupportInitialize).BeginInit()
        CType(TransactionDataGridView, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button9
        ' 
        Button9.AutoSize = True
        Button9.BackColor = Color.FromArgb(CByte(24), CByte(30), CByte(54))
        Button9.BackgroundImageLayout = ImageLayout.None
        Button9.FlatStyle = FlatStyle.Popup
        Button9.Font = New Font("Times New Roman", 9.75F)
        Button9.ForeColor = SystemColors.ButtonFace
        Button9.Image = CType(resources.GetObject("Button9.Image"), Image)
        Button9.ImageAlign = ContentAlignment.MiddleLeft
        Button9.ImeMode = ImeMode.NoControl
        Button9.Location = New Point(-2, 364)
        Button9.Name = "Button9"
        Button9.Size = New Size(188, 70)
        Button9.TabIndex = 13
        Button9.Text = "Logout"
        Button9.TextAlign = ContentAlignment.MiddleRight
        Button9.UseVisualStyleBackColor = False
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
        Button7.Location = New Point(-2, 304)
        Button7.Name = "Button7"
        Button7.Size = New Size(188, 61)
        Button7.TabIndex = 12
        Button7.Text = "Financial Goals"
        Button7.TextAlign = ContentAlignment.MiddleRight
        Button7.UseVisualStyleBackColor = False
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
        Button6.Location = New Point(-2, 244)
        Button6.Name = "Button6"
        Button6.Size = New Size(188, 61)
        Button6.TabIndex = 9
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
        Button5.Location = New Point(-2, 186)
        Button5.Name = "Button5"
        Button5.Size = New Size(188, 61)
        Button5.TabIndex = 11
        Button5.Text = "Loans and Debts"
        Button5.TextAlign = ContentAlignment.MiddleRight
        Button5.UseVisualStyleBackColor = False
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
        Button3.Location = New Point(0, 127)
        Button3.Name = "Button3"
        Button3.Size = New Size(188, 61)
        Button3.TabIndex = 8
        Button3.Text = "Transactions"
        Button3.TextAlign = ContentAlignment.MiddleRight
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.AutoSize = True
        Button1.BackColor = Color.FromArgb(CByte(24), CByte(30), CByte(54))
        Button1.BackgroundImageLayout = ImageLayout.None
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Font = New Font("Times New Roman", 9.75F)
        Button1.ForeColor = SystemColors.ButtonFace
        Button1.Image = CType(resources.GetObject("Button1.Image"), Image)
        Button1.ImageAlign = ContentAlignment.TopLeft
        Button1.ImeMode = ImeMode.NoControl
        Button1.Location = New Point(0, 67)
        Button1.Name = "Button1"
        Button1.Size = New Size(188, 61)
        Button1.TabIndex = 7
        Button1.Text = "Account overview"
        Button1.TextAlign = ContentAlignment.MiddleRight
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(24), CByte(30), CByte(54))
        Panel1.Controls.Add(Button9)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Button7)
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(Button6)
        Panel1.Controls.Add(Button5)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(187, 729)
        Panel1.TabIndex = 14
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(46), CByte(51), CByte(73))
        Panel2.Controls.Add(Panel3)
        Panel2.Controls.Add(UsernameLabel)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(187, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1163, 87)
        Panel2.TabIndex = 15
        ' 
        ' Panel3
        ' 
        Panel3.BackgroundImage = My.Resources.Resources.noun_account_5953570__1_
        Panel3.BackgroundImageLayout = ImageLayout.None
        Panel3.Location = New Point(0, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(93, 88)
        Panel3.TabIndex = 18
        ' 
        ' UsernameLabel
        ' 
        UsernameLabel.Font = New Font("Times New Roman", 36F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        UsernameLabel.ForeColor = Color.DodgerBlue
        UsernameLabel.Location = New Point(88, 19)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New Size(1054, 68)
        UsernameLabel.TabIndex = 16
        UsernameLabel.Text = "Username"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Times New Roman", 21.75F)
        Label2.ForeColor = SystemColors.ButtonHighlight
        Label2.Location = New Point(547, 286)
        Label2.Name = "Label2"
        Label2.Size = New Size(0, 33)
        Label2.TabIndex = 16
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Times New Roman", 21.75F)
        Label3.ForeColor = SystemColors.ButtonHighlight
        Label3.Location = New Point(547, 155)
        Label3.Name = "Label3"
        Label3.Size = New Size(0, 33)
        Label3.TabIndex = 17
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.Control
        Label1.Location = New Point(192, 191)
        Label1.Name = "Label1"
        Label1.Size = New Size(121, 21)
        Label1.TabIndex = 18
        Label1.Text = "Last Transaction"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(248, 215)
        Label4.Name = "Label4"
        Label4.Size = New Size(0, 15)
        Label4.TabIndex = 20
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = SystemColors.Control
        Label5.Location = New Point(192, 304)
        Label5.Name = "Label5"
        Label5.Size = New Size(167, 21)
        Label5.TabIndex = 21
        Label5.Text = "Nearest Loan Deadline"
        ' 
        ' LoanDataGridView
        ' 
        LoanDataGridView.BackgroundColor = SystemColors.Control
        LoanDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        LoanDataGridView.Location = New Point(194, 328)
        LoanDataGridView.Name = "LoanDataGridView"
        LoanDataGridView.ReadOnly = True
        LoanDataGridView.Size = New Size(1144, 61)
        LoanDataGridView.TabIndex = 23
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = SystemColors.Control
        Label6.Location = New Point(196, 413)
        Label6.Name = "Label6"
        Label6.Size = New Size(166, 21)
        Label6.TabIndex = 24
        Label6.Text = "Nearest Debt Deadline"
        ' 
        ' DebtDataGridView
        ' 
        DebtDataGridView.BackgroundColor = SystemColors.Control
        DebtDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DebtDataGridView.Location = New Point(196, 437)
        DebtDataGridView.Name = "DebtDataGridView"
        DebtDataGridView.ReadOnly = True
        DebtDataGridView.Size = New Size(1144, 61)
        DebtDataGridView.TabIndex = 25
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = SystemColors.Control
        Label7.Location = New Point(343, 129)
        Label7.Name = "Label7"
        Label7.Size = New Size(100, 21)
        Label7.TabIndex = 26
        Label7.Text = "Total Income:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = SystemColors.Control
        Label8.Location = New Point(841, 129)
        Label8.Name = "Label8"
        Label8.Size = New Size(112, 21)
        Label8.TabIndex = 27
        Label8.Text = "Total Expenses:"
        ' 
        ' IncomeTextBox
        ' 
        IncomeTextBox.Location = New Point(449, 127)
        IncomeTextBox.Name = "IncomeTextBox"
        IncomeTextBox.ReadOnly = True
        IncomeTextBox.Size = New Size(184, 23)
        IncomeTextBox.TabIndex = 28
        ' 
        ' ExpensesTextBox
        ' 
        ExpensesTextBox.Location = New Point(959, 127)
        ExpensesTextBox.Name = "ExpensesTextBox"
        ExpensesTextBox.ReadOnly = True
        ExpensesTextBox.Size = New Size(184, 23)
        ExpensesTextBox.TabIndex = 29
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = SystemColors.Control
        Label9.Location = New Point(196, 523)
        Label9.Name = "Label9"
        Label9.Size = New Size(142, 21)
        Label9.TabIndex = 30
        Label9.Text = "Closest Goal Target"
        ' 
        ' GoalDataGridView
        ' 
        GoalDataGridView.BackgroundColor = SystemColors.Control
        GoalDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        GoalDataGridView.Location = New Point(196, 547)
        GoalDataGridView.Name = "GoalDataGridView"
        GoalDataGridView.ReadOnly = True
        GoalDataGridView.Size = New Size(1144, 61)
        GoalDataGridView.TabIndex = 31
        ' 
        ' TransactionDataGridView
        ' 
        TransactionDataGridView.BackgroundColor = SystemColors.Control
        TransactionDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        TransactionDataGridView.Location = New Point(196, 215)
        TransactionDataGridView.Name = "TransactionDataGridView"
        TransactionDataGridView.ReadOnly = True
        TransactionDataGridView.Size = New Size(1144, 61)
        TransactionDataGridView.TabIndex = 34
        ' 
        ' Account
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(37), CByte(42), CByte(64))
        ClientSize = New Size(1350, 729)
        Controls.Add(TransactionDataGridView)
        Controls.Add(GoalDataGridView)
        Controls.Add(Label9)
        Controls.Add(ExpensesTextBox)
        Controls.Add(IncomeTextBox)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(DebtDataGridView)
        Controls.Add(Label6)
        Controls.Add(LoanDataGridView)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Account"
        Text = "My Account"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        CType(LoanDataGridView, ComponentModel.ISupportInitialize).EndInit()
        CType(DebtDataGridView, ComponentModel.ISupportInitialize).EndInit()
        CType(GoalDataGridView, ComponentModel.ISupportInitialize).EndInit()
        CType(TransactionDataGridView, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button9 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents UsernameLabel As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LoanDataGridView As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents DebtDataGridView As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents IncomeTextBox As TextBox
    Friend WithEvents ExpensesTextBox As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents GoalDataGridView As DataGridView
    Friend WithEvents TransactionDataGridView As DataGridView
End Class
