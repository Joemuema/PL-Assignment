<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExpenseTrackingForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ExpenseTrackingForm))
        txtExpenseAmount = New TextBox()
        txtExpenseCategory = New TextBox()
        lblExpenseAmount = New Label()
        lblCategory = New Label()
        btnAddExpense = New Button()
        btnBack = New Button()
        Label1 = New Label()
        Panel1 = New Panel()
        btnDeleteExpense = New Button()
        btnClear = New Button()
        lblExpenses = New Guna.UI2.WinForms.Guna2HtmlLabel()
        dgvExpenses = New DataGridView()
        Panel1.SuspendLayout()
        CType(dgvExpenses, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtExpenseAmount
        ' 
        txtExpenseAmount.Font = New Font("Times New Roman", 9F)
        txtExpenseAmount.ForeColor = SystemColors.ButtonFace
        txtExpenseAmount.Location = New Point(70, 128)
        txtExpenseAmount.Margin = New Padding(2)
        txtExpenseAmount.Name = "txtExpenseAmount"
        txtExpenseAmount.Size = New Size(171, 21)
        txtExpenseAmount.TabIndex = 13
        ' 
        ' txtExpenseCategory
        ' 
        txtExpenseCategory.Font = New Font("Times New Roman", 9F)
        txtExpenseCategory.ForeColor = SystemColors.ButtonFace
        txtExpenseCategory.Location = New Point(70, 81)
        txtExpenseCategory.Margin = New Padding(2)
        txtExpenseCategory.Name = "txtExpenseCategory"
        txtExpenseCategory.Size = New Size(171, 21)
        txtExpenseCategory.TabIndex = 12
        ' 
        ' lblExpenseAmount
        ' 
        lblExpenseAmount.AutoSize = True
        lblExpenseAmount.Font = New Font("Times New Roman", 9F)
        lblExpenseAmount.ForeColor = SystemColors.ButtonFace
        lblExpenseAmount.Location = New Point(15, 131)
        lblExpenseAmount.Margin = New Padding(2, 0, 2, 0)
        lblExpenseAmount.Name = "lblExpenseAmount"
        lblExpenseAmount.Size = New Size(47, 15)
        lblExpenseAmount.TabIndex = 11
        lblExpenseAmount.Text = "Amount"
        ' 
        ' lblCategory
        ' 
        lblCategory.AutoSize = True
        lblCategory.Font = New Font("Times New Roman", 9F)
        lblCategory.ForeColor = SystemColors.ButtonFace
        lblCategory.Location = New Point(15, 81)
        lblCategory.Margin = New Padding(2, 0, 2, 0)
        lblCategory.Name = "lblCategory"
        lblCategory.Size = New Size(51, 15)
        lblCategory.TabIndex = 10
        lblCategory.Text = "Category"
        ' 
        ' btnAddExpense
        ' 
        btnAddExpense.BackColor = Color.FromArgb(CByte(24), CByte(30), CByte(54))
        btnAddExpense.FlatStyle = FlatStyle.Popup
        btnAddExpense.Font = New Font("Times New Roman", 9F)
        btnAddExpense.ForeColor = SystemColors.ButtonFace
        btnAddExpense.Location = New Point(15, 171)
        btnAddExpense.Margin = New Padding(2)
        btnAddExpense.Name = "btnAddExpense"
        btnAddExpense.Size = New Size(136, 36)
        btnAddExpense.TabIndex = 9
        btnAddExpense.Text = "Add Expense"
        btnAddExpense.UseVisualStyleBackColor = False
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = Color.FromArgb(CByte(24), CByte(30), CByte(54))
        btnBack.FlatStyle = FlatStyle.Popup
        btnBack.Font = New Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnBack.ForeColor = SystemColors.ButtonFace
        btnBack.Location = New Point(15, 390)
        btnBack.Margin = New Padding(2)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(152, 39)
        btnBack.TabIndex = 7
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 26.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.DodgerBlue
        Label1.Location = New Point(0, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(268, 40)
        Label1.TabIndex = 14
        Label1.Text = "Expense Tracking"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(46), CByte(51), CByte(73))
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(800, 67)
        Panel1.TabIndex = 15
        ' 
        ' btnDeleteExpense
        ' 
        btnDeleteExpense.BackColor = Color.FromArgb(CByte(24), CByte(30), CByte(54))
        btnDeleteExpense.FlatStyle = FlatStyle.Popup
        btnDeleteExpense.Font = New Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnDeleteExpense.ForeColor = SystemColors.ButtonFace
        btnDeleteExpense.Location = New Point(341, 228)
        btnDeleteExpense.Margin = New Padding(2)
        btnDeleteExpense.Name = "btnDeleteExpense"
        btnDeleteExpense.Size = New Size(169, 33)
        btnDeleteExpense.TabIndex = 20
        btnDeleteExpense.Text = "Delete Expense"
        btnDeleteExpense.UseVisualStyleBackColor = False
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.FromArgb(CByte(24), CByte(30), CByte(54))
        btnClear.FlatStyle = FlatStyle.Popup
        btnClear.Font = New Font("Times New Roman", 9F)
        btnClear.ForeColor = SystemColors.ButtonFace
        btnClear.Location = New Point(15, 228)
        btnClear.Margin = New Padding(2)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(136, 33)
        btnClear.TabIndex = 21
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' lblExpenses
        ' 
        lblExpenses.AutoSize = False
        lblExpenses.BackColor = Color.Transparent
        lblExpenses.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblExpenses.ForeColor = SystemColors.ControlLightLight
        lblExpenses.Location = New Point(15, 308)
        lblExpenses.Margin = New Padding(2)
        lblExpenses.Name = "lblExpenses"
        lblExpenses.Size = New Size(226, 43)
        lblExpenses.TabIndex = 22
        lblExpenses.Text = "Total Expenses"
        ' 
        ' dgvExpenses
        ' 
        dgvExpenses.AllowUserToAddRows = False
        dgvExpenses.AllowUserToDeleteRows = False
        dgvExpenses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvExpenses.Location = New Point(278, 72)
        dgvExpenses.Margin = New Padding(2)
        dgvExpenses.Name = "dgvExpenses"
        dgvExpenses.ReadOnly = True
        dgvExpenses.RowHeadersWidth = 62
        dgvExpenses.Size = New Size(407, 135)
        dgvExpenses.TabIndex = 23
        ' 
        ' ExpenseTrackingForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(37), CByte(42), CByte(64))
        ClientSize = New Size(800, 450)
        Controls.Add(dgvExpenses)
        Controls.Add(lblExpenses)
        Controls.Add(btnClear)
        Controls.Add(btnDeleteExpense)
        Controls.Add(Panel1)
        Controls.Add(txtExpenseAmount)
        Controls.Add(txtExpenseCategory)
        Controls.Add(lblExpenseAmount)
        Controls.Add(lblCategory)
        Controls.Add(btnAddExpense)
        Controls.Add(btnBack)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "ExpenseTrackingForm"
        Text = "ExpenseTrackingForm"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(dgvExpenses, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtExpenseAmount As TextBox
    Friend WithEvents txtExpenseCategory As TextBox
    Friend WithEvents lblExpenseAmount As Label
    Friend WithEvents lblCategory As Label
    Friend WithEvents btnAddExpense As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnDeleteExpense As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblExpenses As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents dgvExpenses As DataGridView
End Class
