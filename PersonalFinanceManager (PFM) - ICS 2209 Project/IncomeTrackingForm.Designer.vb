<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IncomeTrackingForm
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
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IncomeTrackingForm))
        btnSaveIncomeDetails = New Button()
        btnClear = New Button()
        lblIncomeTracking = New Label()
        txtIncomeAmount = New TextBox()
        lblAmount = New Label()
        lblSource = New Label()
        btnBack = New Button()
        Panel1 = New Panel()
        dgvIncome = New DataGridView()
        btnDeleteIncome = New Button()
        lblTotalIncome = New Label()
        txtIncomeSource = New Guna.UI2.WinForms.Guna2TextBox()
        Panel1.SuspendLayout()
        CType(dgvIncome, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnSaveIncomeDetails
        ' 
        btnSaveIncomeDetails.BackColor = Color.FromArgb(CByte(24), CByte(30), CByte(54))
        btnSaveIncomeDetails.FlatStyle = FlatStyle.Popup
        btnSaveIncomeDetails.ForeColor = SystemColors.ButtonFace
        btnSaveIncomeDetails.Location = New Point(11, 209)
        btnSaveIncomeDetails.Margin = New Padding(2)
        btnSaveIncomeDetails.Name = "btnSaveIncomeDetails"
        btnSaveIncomeDetails.Size = New Size(195, 46)
        btnSaveIncomeDetails.TabIndex = 19
        btnSaveIncomeDetails.Text = "Save Income Details"
        btnSaveIncomeDetails.UseVisualStyleBackColor = False
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.FromArgb(CByte(24), CByte(30), CByte(54))
        btnClear.FlatStyle = FlatStyle.Popup
        btnClear.ForeColor = SystemColors.ButtonFace
        btnClear.Location = New Point(269, 222)
        btnClear.Margin = New Padding(2)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(76, 21)
        btnClear.TabIndex = 18
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' lblIncomeTracking
        ' 
        lblIncomeTracking.AutoSize = True
        lblIncomeTracking.Font = New Font("Times New Roman", 27.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblIncomeTracking.ForeColor = Color.DodgerBlue
        lblIncomeTracking.Location = New Point(0, 9)
        lblIncomeTracking.Margin = New Padding(2, 0, 2, 0)
        lblIncomeTracking.Name = "lblIncomeTracking"
        lblIncomeTracking.Size = New Size(265, 42)
        lblIncomeTracking.TabIndex = 17
        lblIncomeTracking.Text = "Income Tracking"
        ' 
        ' txtIncomeAmount
        ' 
        txtIncomeAmount.Location = New Point(126, 162)
        txtIncomeAmount.Margin = New Padding(2)
        txtIncomeAmount.Name = "txtIncomeAmount"
        txtIncomeAmount.Size = New Size(185, 23)
        txtIncomeAmount.TabIndex = 16
        ' 
        ' lblAmount
        ' 
        lblAmount.AutoSize = True
        lblAmount.ForeColor = SystemColors.ButtonFace
        lblAmount.Location = New Point(11, 165)
        lblAmount.Margin = New Padding(2, 0, 2, 0)
        lblAmount.Name = "lblAmount"
        lblAmount.Size = New Size(51, 15)
        lblAmount.TabIndex = 12
        lblAmount.Text = "Amount"
        ' 
        ' lblSource
        ' 
        lblSource.AutoSize = True
        lblSource.ForeColor = SystemColors.ButtonFace
        lblSource.Location = New Point(10, 120)
        lblSource.Margin = New Padding(2, 0, 2, 0)
        lblSource.Name = "lblSource"
        lblSource.Size = New Size(86, 15)
        lblSource.TabIndex = 11
        lblSource.Text = "Income Source"
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = Color.FromArgb(CByte(24), CByte(30), CByte(54))
        btnBack.FlatStyle = FlatStyle.Popup
        btnBack.ForeColor = SystemColors.ButtonFace
        btnBack.Location = New Point(11, 400)
        btnBack.Margin = New Padding(2)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(119, 39)
        btnBack.TabIndex = 10
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(46), CByte(51), CByte(73))
        Panel1.Controls.Add(lblIncomeTracking)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(800, 80)
        Panel1.TabIndex = 20
        ' 
        ' dgvIncome
        ' 
        dgvIncome.AllowUserToAddRows = False
        dgvIncome.AllowUserToDeleteRows = False
        dgvIncome.AllowUserToResizeColumns = False
        dgvIncome.BorderStyle = BorderStyle.Fixed3D
        dgvIncome.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvIncome.GridColor = SystemColors.Menu
        dgvIncome.Location = New Point(441, 120)
        dgvIncome.Margin = New Padding(2)
        dgvIncome.Name = "dgvIncome"
        dgvIncome.RowHeadersWidth = 62
        dgvIncome.Size = New Size(252, 135)
        dgvIncome.TabIndex = 29
        ' 
        ' btnDeleteIncome
        ' 
        btnDeleteIncome.BackColor = Color.FromArgb(CByte(24), CByte(30), CByte(54))
        btnDeleteIncome.FlatStyle = FlatStyle.Popup
        btnDeleteIncome.Location = New Point(462, 279)
        btnDeleteIncome.Margin = New Padding(2)
        btnDeleteIncome.Name = "btnDeleteIncome"
        btnDeleteIncome.Size = New Size(157, 33)
        btnDeleteIncome.TabIndex = 30
        btnDeleteIncome.Text = "Delete Income"
        btnDeleteIncome.UseVisualStyleBackColor = False
        ' 
        ' lblTotalIncome
        ' 
        lblTotalIncome.AutoSize = True
        lblTotalIncome.Location = New Point(10, 292)
        lblTotalIncome.Margin = New Padding(2, 0, 2, 0)
        lblTotalIncome.Name = "lblTotalIncome"
        lblTotalIncome.Size = New Size(41, 15)
        lblTotalIncome.TabIndex = 31
        lblTotalIncome.Text = "Label1"
        ' 
        ' txtIncomeSource
        ' 
        txtIncomeSource.CustomizableEdges = CustomizableEdges1
        txtIncomeSource.DefaultText = ""
        txtIncomeSource.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtIncomeSource.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtIncomeSource.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtIncomeSource.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtIncomeSource.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtIncomeSource.Font = New Font("Segoe UI", 9F)
        txtIncomeSource.ForeColor = Color.Black
        txtIncomeSource.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtIncomeSource.Location = New Point(126, 120)
        txtIncomeSource.Name = "txtIncomeSource"
        txtIncomeSource.PasswordChar = ChrW(0)
        txtIncomeSource.PlaceholderForeColor = Color.Black
        txtIncomeSource.PlaceholderText = ""
        txtIncomeSource.SelectedText = ""
        txtIncomeSource.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        txtIncomeSource.Size = New Size(184, 20)
        txtIncomeSource.TabIndex = 32
        ' 
        ' IncomeTrackingForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(37), CByte(42), CByte(64))
        ClientSize = New Size(800, 450)
        Controls.Add(txtIncomeSource)
        Controls.Add(lblTotalIncome)
        Controls.Add(btnDeleteIncome)
        Controls.Add(dgvIncome)
        Controls.Add(Panel1)
        Controls.Add(btnSaveIncomeDetails)
        Controls.Add(btnClear)
        Controls.Add(txtIncomeAmount)
        Controls.Add(lblAmount)
        Controls.Add(lblSource)
        Controls.Add(btnBack)
        ForeColor = SystemColors.ButtonFace
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "IncomeTrackingForm"
        Text = "IncomeTrackingForm"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(dgvIncome, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnSaveIncomeDetails As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblIncomeTracking As Label
    Friend WithEvents txtIncomeAmount As TextBox
    Friend WithEvents lblAmount As Label
    Friend WithEvents lblSource As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dgvIncome As DataGridView
    Friend WithEvents btnDeleteIncome As Button
    Friend WithEvents lblTotalIncome As Label
    Friend WithEvents txtIncomeSource As Guna.UI2.WinForms.Guna2TextBox
End Class
