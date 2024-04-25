<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GoalChecking
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GoalChecking))
        DepositButton = New Button()
        CheckBackButton = New Button()
        DeleteButton = New Button()
        UpdateButton = New Button()
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Panel1 = New Panel()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' DepositButton
        ' 
        DepositButton.BackColor = Color.FromArgb(CByte(24), CByte(30), CByte(54))
        DepositButton.FlatStyle = FlatStyle.Popup
        DepositButton.ForeColor = SystemColors.ButtonFace
        DepositButton.Location = New Point(29, 284)
        DepositButton.Margin = New Padding(2)
        DepositButton.Name = "DepositButton"
        DepositButton.Size = New Size(124, 34)
        DepositButton.TabIndex = 9
        DepositButton.Text = "Deposit"
        DepositButton.UseVisualStyleBackColor = False
        ' 
        ' CheckBackButton
        ' 
        CheckBackButton.BackColor = Color.FromArgb(CByte(24), CByte(30), CByte(54))
        CheckBackButton.FlatStyle = FlatStyle.Popup
        CheckBackButton.ForeColor = SystemColors.ButtonFace
        CheckBackButton.Location = New Point(369, 284)
        CheckBackButton.Margin = New Padding(2)
        CheckBackButton.Name = "CheckBackButton"
        CheckBackButton.Size = New Size(124, 34)
        CheckBackButton.TabIndex = 8
        CheckBackButton.Text = "Back"
        CheckBackButton.UseVisualStyleBackColor = False
        ' 
        ' DeleteButton
        ' 
        DeleteButton.BackColor = Color.FromArgb(CByte(24), CByte(30), CByte(54))
        DeleteButton.FlatStyle = FlatStyle.Popup
        DeleteButton.ForeColor = SystemColors.ButtonFace
        DeleteButton.Location = New Point(369, 224)
        DeleteButton.Margin = New Padding(2)
        DeleteButton.Name = "DeleteButton"
        DeleteButton.Size = New Size(124, 34)
        DeleteButton.TabIndex = 7
        DeleteButton.Text = "Delete"
        DeleteButton.UseVisualStyleBackColor = False
        ' 
        ' UpdateButton
        ' 
        UpdateButton.BackColor = Color.FromArgb(CByte(24), CByte(30), CByte(54))
        UpdateButton.FlatStyle = FlatStyle.Popup
        UpdateButton.ForeColor = SystemColors.ButtonFace
        UpdateButton.Location = New Point(29, 224)
        UpdateButton.Margin = New Padding(2)
        UpdateButton.Name = "UpdateButton"
        UpdateButton.Size = New Size(124, 34)
        UpdateButton.TabIndex = 6
        UpdateButton.Text = "Update Goals"
        UpdateButton.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column6, Column4, Column5})
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Window
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle1.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.False
        DataGridView1.DefaultCellStyle = DataGridViewCellStyle1
        DataGridView1.Dock = DockStyle.Fill
        DataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically
        DataGridView1.Location = New Point(0, 0)
        DataGridView1.Margin = New Padding(2)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersWidth = 62
        DataGridViewCellStyle2.ForeColor = Color.Black
        DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle2
        DataGridView1.Size = New Size(999, 188)
        DataGridView1.TabIndex = 0
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Goal Description"
        Column1.MinimumWidth = 8
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.Width = 165
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Starting Amount"
        Column2.MinimumWidth = 8
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        Column2.Width = 165
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Target Amount"
        Column3.MinimumWidth = 8
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        Column3.Width = 165
        ' 
        ' Column6
        ' 
        Column6.HeaderText = "Current Amount"
        Column6.MinimumWidth = 8
        Column6.Name = "Column6"
        Column6.ReadOnly = True
        Column6.Width = 165
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Starting Date"
        Column4.MinimumWidth = 8
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        Column4.Width = 165
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "Target Date"
        Column5.MinimumWidth = 8
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        Column5.Width = 165
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(DataGridView1)
        Panel1.Location = New Point(11, 11)
        Panel1.Margin = New Padding(2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(999, 188)
        Panel1.TabIndex = 10
        ' 
        ' GoalChecking
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(37), CByte(42), CByte(64))
        ClientSize = New Size(1018, 380)
        Controls.Add(Panel1)
        Controls.Add(DepositButton)
        Controls.Add(CheckBackButton)
        Controls.Add(DeleteButton)
        Controls.Add(UpdateButton)
        ForeColor = SystemColors.ButtonFace
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "GoalChecking"
        Text = "GoalChecking"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub
    Friend WithEvents DepositButton As Button
    Friend WithEvents CheckBackButton As Button
    Friend WithEvents DeleteButton As Button
    Friend WithEvents UpdateButton As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As Panel
End Class
