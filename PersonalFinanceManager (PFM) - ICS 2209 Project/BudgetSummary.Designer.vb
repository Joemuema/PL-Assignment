<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BudgetSummary
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BudgetSummary))
        btnBack = New Button()
        Label1 = New Label()
        Panel1 = New Panel()
        GroupBox3 = New GroupBox()
        Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        lblExpensePercentage = New Guna.UI2.WinForms.Guna2HtmlLabel()
        lblIncomePercentage = New Guna.UI2.WinForms.Guna2HtmlLabel()
        GroupBox1 = New GroupBox()
        lblNetIncome = New Guna.UI2.WinForms.Guna2HtmlLabel()
        lblTotalIncome = New Label()
        lblTotalExpenses = New Label()
        GroupBox2 = New GroupBox()
        dgvIncome = New DataGridView()
        Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        dgvExpenses = New DataGridView()
        Panel1.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(dgvIncome, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvExpenses, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = Color.FromArgb(CByte(24), CByte(30), CByte(54))
        btnBack.FlatStyle = FlatStyle.Popup
        btnBack.ForeColor = SystemColors.ButtonFace
        btnBack.Location = New Point(8, 450)
        btnBack.Margin = New Padding(2)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(191, 52)
        btnBack.TabIndex = 9
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Times New Roman", 27.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.DodgerBlue
        Label1.Location = New Point(0, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(351, 62)
        Label1.TabIndex = 10
        Label1.Text = "Budget Summary"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(46), CByte(51), CByte(73))
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1027, 93)
        Panel1.TabIndex = 11
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(Guna2HtmlLabel5)
        GroupBox3.Controls.Add(Guna2HtmlLabel4)
        GroupBox3.Controls.Add(Guna2HtmlLabel3)
        GroupBox3.Controls.Add(lblExpensePercentage)
        GroupBox3.Controls.Add(lblIncomePercentage)
        GroupBox3.ForeColor = SystemColors.ButtonFace
        GroupBox3.Location = New Point(8, 369)
        GroupBox3.Margin = New Padding(2)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Padding = New Padding(2)
        GroupBox3.Size = New Size(783, 77)
        GroupBox3.TabIndex = 18
        GroupBox3.TabStop = False
        GroupBox3.Text = "Income vs. Expenses"
        ' 
        ' Guna2HtmlLabel5
        ' 
        Guna2HtmlLabel5.BackColor = Color.Transparent
        Guna2HtmlLabel5.ForeColor = Color.Orange
        Guna2HtmlLabel5.Location = New Point(677, 28)
        Guna2HtmlLabel5.Margin = New Padding(2)
        Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Guna2HtmlLabel5.Size = New Size(83, 17)
        Guna2HtmlLabel5.TabIndex = 4
        Guna2HtmlLabel5.Text = "Cutting it close"
        ' 
        ' Guna2HtmlLabel4
        ' 
        Guna2HtmlLabel4.BackColor = Color.Transparent
        Guna2HtmlLabel4.ForeColor = Color.LightGreen
        Guna2HtmlLabel4.Location = New Point(705, 8)
        Guna2HtmlLabel4.Margin = New Padding(2)
        Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Guna2HtmlLabel4.Size = New Size(32, 17)
        Guna2HtmlLabel4.TabIndex = 3
        Guna2HtmlLabel4.Text = "Good"
        ' 
        ' Guna2HtmlLabel3
        ' 
        Guna2HtmlLabel3.BackColor = Color.Transparent
        Guna2HtmlLabel3.ForeColor = Color.Red
        Guna2HtmlLabel3.Location = New Point(686, 48)
        Guna2HtmlLabel3.Margin = New Padding(2)
        Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Guna2HtmlLabel3.Size = New Size(66, 17)
        Guna2HtmlLabel3.TabIndex = 2
        Guna2HtmlLabel3.Text = "Overbudget"
        ' 
        ' lblExpensePercentage
        ' 
        lblExpensePercentage.BackColor = Color.Transparent
        lblExpensePercentage.Location = New Point(6, 48)
        lblExpensePercentage.Margin = New Padding(2)
        lblExpensePercentage.Name = "lblExpensePercentage"
        lblExpensePercentage.Size = New Size(98, 17)
        lblExpensePercentage.TabIndex = 1
        lblExpensePercentage.Text = "Guna2HtmlLabel4"
        ' 
        ' lblIncomePercentage
        ' 
        lblIncomePercentage.BackColor = Color.Transparent
        lblIncomePercentage.Location = New Point(6, 20)
        lblIncomePercentage.Margin = New Padding(2)
        lblIncomePercentage.Name = "lblIncomePercentage"
        lblIncomePercentage.Size = New Size(98, 17)
        lblIncomePercentage.TabIndex = 0
        lblIncomePercentage.Text = "Guna2HtmlLabel3"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(lblNetIncome)
        GroupBox1.Controls.Add(lblTotalIncome)
        GroupBox1.Controls.Add(lblTotalExpenses)
        GroupBox1.ForeColor = SystemColors.ButtonFace
        GroupBox1.Location = New Point(8, 98)
        GroupBox1.Margin = New Padding(2)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(2)
        GroupBox1.Size = New Size(1005, 90)
        GroupBox1.TabIndex = 16
        GroupBox1.TabStop = False
        GroupBox1.Text = "Summary"
        ' 
        ' lblNetIncome
        ' 
        lblNetIncome.BackColor = Color.Transparent
        lblNetIncome.Location = New Point(6, 55)
        lblNetIncome.Margin = New Padding(2)
        lblNetIncome.Name = "lblNetIncome"
        lblNetIncome.Size = New Size(98, 17)
        lblNetIncome.TabIndex = 8
        lblNetIncome.Text = "Guna2HtmlLabel5"
        ' 
        ' lblTotalIncome
        ' 
        lblTotalIncome.AutoSize = True
        lblTotalIncome.ForeColor = SystemColors.ButtonFace
        lblTotalIncome.Location = New Point(6, 18)
        lblTotalIncome.Margin = New Padding(2, 0, 2, 0)
        lblTotalIncome.Name = "lblTotalIncome"
        lblTotalIncome.Size = New Size(112, 15)
        lblTotalIncome.TabIndex = 6
        lblTotalIncome.Text = "Monthly income is: "
        ' 
        ' lblTotalExpenses
        ' 
        lblTotalExpenses.AutoSize = True
        lblTotalExpenses.ForeColor = SystemColors.ButtonFace
        lblTotalExpenses.Location = New Point(4, 38)
        lblTotalExpenses.Margin = New Padding(2, 0, 2, 0)
        lblTotalExpenses.Name = "lblTotalExpenses"
        lblTotalExpenses.Size = New Size(112, 15)
        lblTotalExpenses.TabIndex = 7
        lblTotalExpenses.Text = "idk what this is for 3"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(dgvIncome)
        GroupBox2.Controls.Add(Guna2HtmlLabel2)
        GroupBox2.Controls.Add(Guna2HtmlLabel1)
        GroupBox2.Controls.Add(dgvExpenses)
        GroupBox2.ForeColor = SystemColors.ButtonFace
        GroupBox2.Location = New Point(8, 192)
        GroupBox2.Margin = New Padding(2)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Padding = New Padding(2)
        GroupBox2.Size = New Size(1005, 173)
        GroupBox2.TabIndex = 17
        GroupBox2.TabStop = False
        GroupBox2.Text = "Incomes and Expenses"
        ' 
        ' dgvIncome
        ' 
        dgvIncome.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvIncome.Location = New Point(6, 31)
        dgvIncome.Margin = New Padding(2)
        dgvIncome.Name = "dgvIncome"
        dgvIncome.RowHeadersWidth = 62
        dgvIncome.Size = New Size(459, 130)
        dgvIncome.TabIndex = 12
        ' 
        ' Guna2HtmlLabel2
        ' 
        Guna2HtmlLabel2.BackColor = Color.Transparent
        Guna2HtmlLabel2.ForeColor = SystemColors.ButtonFace
        Guna2HtmlLabel2.Location = New Point(528, 10)
        Guna2HtmlLabel2.Margin = New Padding(2)
        Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Guna2HtmlLabel2.Size = New Size(51, 17)
        Guna2HtmlLabel2.TabIndex = 11
        Guna2HtmlLabel2.Text = "Expenses"
        ' 
        ' Guna2HtmlLabel1
        ' 
        Guna2HtmlLabel1.BackColor = Color.Transparent
        Guna2HtmlLabel1.ForeColor = SystemColors.ButtonFace
        Guna2HtmlLabel1.Location = New Point(195, 10)
        Guna2HtmlLabel1.Margin = New Padding(2)
        Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Guna2HtmlLabel1.Size = New Size(48, 17)
        Guna2HtmlLabel1.TabIndex = 10
        Guna2HtmlLabel1.Text = "Incomes"
        ' 
        ' dgvExpenses
        ' 
        dgvExpenses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvExpenses.Location = New Point(528, 31)
        dgvExpenses.Margin = New Padding(2)
        dgvExpenses.Name = "dgvExpenses"
        dgvExpenses.ReadOnly = True
        dgvExpenses.RowHeadersWidth = 62
        dgvExpenses.Size = New Size(464, 130)
        dgvExpenses.TabIndex = 8
        ' 
        ' BudgetSummary
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(37), CByte(42), CByte(64))
        ClientSize = New Size(1027, 514)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox1)
        Controls.Add(GroupBox2)
        Controls.Add(Panel1)
        Controls.Add(btnBack)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "BudgetSummary"
        Text = "BudgetSummary"
        Panel1.ResumeLayout(False)
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        CType(dgvIncome, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvExpenses, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblExpensePercentage As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblIncomePercentage As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblNetIncome As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblTotalIncome As Label
    Friend WithEvents lblTotalExpenses As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dgvIncome As DataGridView
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents dgvExpenses As DataGridView
End Class
