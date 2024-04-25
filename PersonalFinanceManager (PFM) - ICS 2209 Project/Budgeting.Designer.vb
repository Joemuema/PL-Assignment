<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Budgeting
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Budgeting))
        Button9 = New Button()
        Button2 = New Button()
        Button7 = New Button()
        Button3 = New Button()
        Button6 = New Button()
        Button5 = New Button()
        Panel1 = New Panel()
        Panel2 = New Panel()
        Transactions = New Label()
        btnExpenseTracking = New Button()
        btnIncomeTracking = New Button()
        btnBudgetSummary = New Button()
        lblAvailableFunds = New Guna.UI2.WinForms.Guna2HtmlLabel()
        lblExpenses = New Guna.UI2.WinForms.Guna2HtmlLabel()
        lblIncome = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
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
        Button9.Image = My.Resources.Resources.exit__1___1_1
        Button9.ImageAlign = ContentAlignment.MiddleLeft
        Button9.ImeMode = ImeMode.NoControl
        Button9.Location = New Point(-1, 377)
        Button9.Name = "Button9"
        Button9.Size = New Size(188, 66)
        Button9.TabIndex = 27
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
        Button2.Location = New Point(0, 69)
        Button2.Name = "Button2"
        Button2.Size = New Size(188, 70)
        Button2.TabIndex = 21
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
        Button7.Location = New Point(-1, 317)
        Button7.Name = "Button7"
        Button7.Size = New Size(188, 61)
        Button7.TabIndex = 26
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
        Button3.Location = New Point(0, 135)
        Button3.Name = "Button3"
        Button3.Size = New Size(188, 61)
        Button3.TabIndex = 22
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
        Button6.Location = New Point(-1, 255)
        Button6.Name = "Button6"
        Button6.Size = New Size(188, 63)
        Button6.TabIndex = 23
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
        Button5.Location = New Point(-1, 195)
        Button5.Name = "Button5"
        Button5.Size = New Size(188, 61)
        Button5.TabIndex = 25
        Button5.Text = "Loans and Debts"
        Button5.TextAlign = ContentAlignment.MiddleRight
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(24), CByte(30), CByte(54))
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button9)
        Panel1.Controls.Add(Button5)
        Panel1.Controls.Add(Button7)
        Panel1.Controls.Add(Button6)
        Panel1.Controls.Add(Button3)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(190, 729)
        Panel1.TabIndex = 28
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(46), CByte(51), CByte(73))
        Panel2.Controls.Add(Transactions)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(190, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1160, 99)
        Panel2.TabIndex = 29
        ' 
        ' Transactions
        ' 
        Transactions.Font = New Font("Times New Roman", 36F)
        Transactions.ForeColor = Color.DodgerBlue
        Transactions.Image = CType(resources.GetObject("Transactions.Image"), Image)
        Transactions.ImageAlign = ContentAlignment.BottomLeft
        Transactions.ImeMode = ImeMode.NoControl
        Transactions.Location = New Point(0, 0)
        Transactions.Name = "Transactions"
        Transactions.Size = New Size(307, 99)
        Transactions.TabIndex = 1
        Transactions.Text = "Budgeting"
        Transactions.TextAlign = ContentAlignment.BottomRight
        ' 
        ' btnExpenseTracking
        ' 
        btnExpenseTracking.BackColor = Color.FromArgb(CByte(24), CByte(30), CByte(54))
        btnExpenseTracking.FlatStyle = FlatStyle.Popup
        btnExpenseTracking.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnExpenseTracking.ForeColor = SystemColors.ButtonFace
        btnExpenseTracking.Location = New Point(644, 359)
        btnExpenseTracking.Margin = New Padding(2)
        btnExpenseTracking.Name = "btnExpenseTracking"
        btnExpenseTracking.Size = New Size(257, 75)
        btnExpenseTracking.TabIndex = 31
        btnExpenseTracking.Text = "Expense Tracking"
        btnExpenseTracking.UseVisualStyleBackColor = False
        ' 
        ' btnIncomeTracking
        ' 
        btnIncomeTracking.BackColor = Color.FromArgb(CByte(24), CByte(30), CByte(54))
        btnIncomeTracking.FlatStyle = FlatStyle.Popup
        btnIncomeTracking.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnIncomeTracking.ForeColor = SystemColors.ButtonFace
        btnIncomeTracking.Location = New Point(240, 195)
        btnIncomeTracking.Margin = New Padding(2)
        btnIncomeTracking.Name = "btnIncomeTracking"
        btnIncomeTracking.Size = New Size(257, 75)
        btnIncomeTracking.TabIndex = 30
        btnIncomeTracking.Text = "Income Tracking"
        btnIncomeTracking.UseVisualStyleBackColor = False
        ' 
        ' btnBudgetSummary
        ' 
        btnBudgetSummary.BackColor = Color.FromArgb(CByte(24), CByte(30), CByte(54))
        btnBudgetSummary.FlatStyle = FlatStyle.Popup
        btnBudgetSummary.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnBudgetSummary.ForeColor = SystemColors.ButtonFace
        btnBudgetSummary.Location = New Point(1065, 531)
        btnBudgetSummary.Margin = New Padding(2)
        btnBudgetSummary.Name = "btnBudgetSummary"
        btnBudgetSummary.Size = New Size(257, 75)
        btnBudgetSummary.TabIndex = 33
        btnBudgetSummary.Text = "Budget Summary"
        btnBudgetSummary.UseVisualStyleBackColor = False
        ' 
        ' lblAvailableFunds
        ' 
        lblAvailableFunds.BackColor = Color.Transparent
        lblAvailableFunds.ForeColor = SystemColors.ButtonFace
        lblAvailableFunds.Location = New Point(1065, 487)
        lblAvailableFunds.Margin = New Padding(2)
        lblAvailableFunds.Name = "lblAvailableFunds"
        lblAvailableFunds.Size = New Size(98, 17)
        lblAvailableFunds.TabIndex = 41
        lblAvailableFunds.Text = "Guna2HtmlLabel3"
        ' 
        ' lblExpenses
        ' 
        lblExpenses.BackColor = Color.Transparent
        lblExpenses.ForeColor = SystemColors.ButtonFace
        lblExpenses.Location = New Point(644, 317)
        lblExpenses.Margin = New Padding(2)
        lblExpenses.Name = "lblExpenses"
        lblExpenses.Size = New Size(98, 17)
        lblExpenses.TabIndex = 40
        lblExpenses.Text = "Guna2HtmlLabel2"
        ' 
        ' lblIncome
        ' 
        lblIncome.BackColor = Color.Transparent
        lblIncome.ForeColor = SystemColors.ButtonFace
        lblIncome.Location = New Point(240, 146)
        lblIncome.Margin = New Padding(2)
        lblIncome.Name = "lblIncome"
        lblIncome.Size = New Size(98, 17)
        lblIncome.TabIndex = 39
        lblIncome.Text = "Guna2HtmlLabel1"
        ' 
        ' Budgeting
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(37), CByte(42), CByte(64))
        ClientSize = New Size(1350, 729)
        Controls.Add(btnIncomeTracking)
        Controls.Add(btnBudgetSummary)
        Controls.Add(btnExpenseTracking)
        Controls.Add(lblAvailableFunds)
        Controls.Add(lblExpenses)
        Controls.Add(lblIncome)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "Budgeting"
        Text = "Budgeting"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button9 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Transactions As Label
    Friend WithEvents btnExpenseTracking As Button
    Friend WithEvents btnIncomeTracking As Button
    Friend WithEvents btnBudgetSummary As Button
    Friend WithEvents lblAvailableFunds As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblExpenses As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblIncome As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
