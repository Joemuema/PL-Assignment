<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoansDebtsReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoansDebtsReport))
        DLRhome = New Button()
        LDdetails = New TabControl()
        LoansTab = New TabPage()
        DispLoans = New DataGridView()
        DebtsTab = New TabPage()
        DispDebts = New DataGridView()
        LDdetails.SuspendLayout()
        LoansTab.SuspendLayout()
        CType(DispLoans, ComponentModel.ISupportInitialize).BeginInit()
        DebtsTab.SuspendLayout()
        CType(DispDebts, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DLRhome
        ' 
        DLRhome.BackColor = Color.FromArgb(CByte(24), CByte(30), CByte(54))
        DLRhome.FlatStyle = FlatStyle.Popup
        DLRhome.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        DLRhome.ForeColor = SystemColors.ButtonFace
        DLRhome.Location = New Point(762, 394)
        DLRhome.Margin = New Padding(2)
        DLRhome.Name = "DLRhome"
        DLRhome.Size = New Size(132, 45)
        DLRhome.TabIndex = 4
        DLRhome.Text = "HOME"
        DLRhome.UseVisualStyleBackColor = False
        ' 
        ' LDdetails
        ' 
        LDdetails.Controls.Add(LoansTab)
        LDdetails.Controls.Add(DebtsTab)
        LDdetails.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        LDdetails.Location = New Point(29, 73)
        LDdetails.Margin = New Padding(2)
        LDdetails.Name = "LDdetails"
        LDdetails.SelectedIndex = 0
        LDdetails.Size = New Size(865, 304)
        LDdetails.TabIndex = 5
        ' 
        ' LoansTab
        ' 
        LoansTab.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        LoansTab.Controls.Add(DispLoans)
        LoansTab.Location = New Point(4, 24)
        LoansTab.Margin = New Padding(2)
        LoansTab.Name = "LoansTab"
        LoansTab.Padding = New Padding(2)
        LoansTab.Size = New Size(857, 276)
        LoansTab.TabIndex = 0
        LoansTab.Text = "LOANS"
        ' 
        ' DispLoans
        ' 
        DispLoans.AllowUserToAddRows = False
        DispLoans.AllowUserToOrderColumns = True
        DispLoans.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DispLoans.Location = New Point(8, 11)
        DispLoans.Margin = New Padding(2)
        DispLoans.Name = "DispLoans"
        DispLoans.ReadOnly = True
        DispLoans.RowHeadersWidth = 62
        DispLoans.Size = New Size(780, 162)
        DispLoans.TabIndex = 0
        ' 
        ' DebtsTab
        ' 
        DebtsTab.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        DebtsTab.Controls.Add(DispDebts)
        DebtsTab.Location = New Point(4, 24)
        DebtsTab.Margin = New Padding(2)
        DebtsTab.Name = "DebtsTab"
        DebtsTab.Padding = New Padding(2)
        DebtsTab.Size = New Size(857, 276)
        DebtsTab.TabIndex = 1
        DebtsTab.Text = "DEBTS"
        ' 
        ' DispDebts
        ' 
        DispDebts.AllowUserToAddRows = False
        DispDebts.AllowUserToOrderColumns = True
        DispDebts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DispDebts.Location = New Point(4, 12)
        DispDebts.Margin = New Padding(2)
        DispDebts.Name = "DispDebts"
        DispDebts.ReadOnly = True
        DispDebts.RowHeadersWidth = 62
        DispDebts.Size = New Size(676, 142)
        DispDebts.TabIndex = 0
        ' 
        ' LoansDebtsReport
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(37), CByte(42), CByte(64))
        ClientSize = New Size(923, 450)
        Controls.Add(LDdetails)
        Controls.Add(DLRhome)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "LoansDebtsReport"
        Text = "LoansDebtsReport"
        LDdetails.ResumeLayout(False)
        LoansTab.ResumeLayout(False)
        CType(DispLoans, ComponentModel.ISupportInitialize).EndInit()
        DebtsTab.ResumeLayout(False)
        CType(DispDebts, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DLRhome As Button
    Friend WithEvents LDdetails As TabControl
    Friend WithEvents LoansTab As TabPage
    Friend WithEvents DispLoans As DataGridView
    Friend WithEvents DebtsTab As TabPage
    Friend WithEvents DispDebts As DataGridView
End Class
