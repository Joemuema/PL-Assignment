<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Transaction
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Transaction))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Panel2 = New Panel()
        Panel4 = New Panel()
        Button2 = New Button()
        Button8 = New Button()
        Button10 = New Button()
        Transactions = New Label()
        Panel1 = New Panel()
        Button9 = New Button()
        Button7 = New Button()
        Button6 = New Button()
        Button5 = New Button()
        Button3 = New Button()
        Button1 = New Button()
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Button11 = New Button()
        FileSystemWatcher1 = New IO.FileSystemWatcher()
        Button12 = New Button()
        Panel2.SuspendLayout()
        Panel4.SuspendLayout()
        Panel1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(FileSystemWatcher1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(46), CByte(51), CByte(73))
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(Panel4)
        Panel2.Controls.Add(Transactions)
        resources.ApplyResources(Panel2, "Panel2")
        Panel2.Name = "Panel2"
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(Button2)
        Panel4.Controls.Add(Button8)
        Panel4.Controls.Add(Button10)
        resources.ApplyResources(Panel4, "Panel4")
        Panel4.Name = "Panel4"
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(24), CByte(30), CByte(54))
        resources.ApplyResources(Button2, "Button2")
        Button2.ForeColor = SystemColors.ButtonFace
        Button2.Name = "Button2"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button8
        ' 
        Button8.BackColor = Color.FromArgb(CByte(24), CByte(30), CByte(54))
        resources.ApplyResources(Button8, "Button8")
        Button8.ForeColor = SystemColors.ButtonFace
        Button8.Name = "Button8"
        Button8.UseVisualStyleBackColor = False
        ' 
        ' Button10
        ' 
        Button10.BackColor = Color.FromArgb(CByte(24), CByte(30), CByte(54))
        resources.ApplyResources(Button10, "Button10")
        Button10.ForeColor = SystemColors.ButtonFace
        Button10.Name = "Button10"
        Button10.UseVisualStyleBackColor = False
        ' 
        ' Transactions
        ' 
        resources.ApplyResources(Transactions, "Transactions")
        Transactions.ForeColor = Color.DodgerBlue
        Transactions.Name = "Transactions"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(24), CByte(30), CByte(54))
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(Button9)
        Panel1.Controls.Add(Button7)
        Panel1.Controls.Add(Button6)
        Panel1.Controls.Add(Button5)
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(Button1)
        resources.ApplyResources(Panel1, "Panel1")
        Panel1.ForeColor = SystemColors.ButtonFace
        Panel1.Name = "Panel1"
        ' 
        ' Button9
        ' 
        resources.ApplyResources(Button9, "Button9")
        Button9.BackColor = Color.FromArgb(CByte(24), CByte(30), CByte(54))
        Button9.ForeColor = SystemColors.ButtonFace
        Button9.Name = "Button9"
        Button9.UseVisualStyleBackColor = False
        ' 
        ' Button7
        ' 
        resources.ApplyResources(Button7, "Button7")
        Button7.BackColor = Color.FromArgb(CByte(24), CByte(30), CByte(54))
        Button7.ForeColor = SystemColors.ButtonFace
        Button7.Name = "Button7"
        Button7.UseVisualStyleBackColor = False
        ' 
        ' Button6
        ' 
        resources.ApplyResources(Button6, "Button6")
        Button6.BackColor = Color.FromArgb(CByte(24), CByte(30), CByte(54))
        Button6.ForeColor = SystemColors.ButtonFace
        Button6.Name = "Button6"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        resources.ApplyResources(Button5, "Button5")
        Button5.BackColor = Color.FromArgb(CByte(24), CByte(30), CByte(54))
        Button5.ForeColor = SystemColors.ButtonFace
        Button5.Name = "Button5"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        resources.ApplyResources(Button3, "Button3")
        Button3.BackColor = Color.FromArgb(CByte(24), CByte(30), CByte(54))
        Button3.ForeColor = SystemColors.ButtonFace
        Button3.Name = "Button3"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        resources.ApplyResources(Button1, "Button1")
        Button1.BackColor = Color.FromArgb(CByte(24), CByte(30), CByte(54))
        Button1.ForeColor = SystemColors.ButtonFace
        Button1.Name = "Button1"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridViewCellStyle1.BackColor = Color.White
        DataGridViewCellStyle1.ForeColor = Color.Black
        DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridView1.BackgroundColor = Color.FromArgb(CByte(37), CByte(42), CByte(64))
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5, Column6})
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.White
        DataGridViewCellStyle2.Font = New Font("Times New Roman", 9.75F)
        DataGridViewCellStyle2.ForeColor = Color.Black
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.ButtonFace
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        resources.ApplyResources(DataGridView1, "DataGridView1")
        DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.DarkGray
        DataGridViewCellStyle3.Font = New Font("Times New Roman", 9.75F)
        DataGridViewCellStyle3.ForeColor = SystemColors.ButtonFace
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        DataGridViewCellStyle4.BackColor = Color.White
        DataGridViewCellStyle4.ForeColor = Color.Black
        DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle4
        ' 
        ' Column1
        ' 
        resources.ApplyResources(Column1, "Column1")
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        ' 
        ' Column2
        ' 
        resources.ApplyResources(Column2, "Column2")
        Column2.Name = "Column2"
        ' 
        ' Column3
        ' 
        resources.ApplyResources(Column3, "Column3")
        Column3.Name = "Column3"
        ' 
        ' Column4
        ' 
        resources.ApplyResources(Column4, "Column4")
        Column4.Name = "Column4"
        ' 
        ' Column5
        ' 
        Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        resources.ApplyResources(Column5, "Column5")
        Column5.Name = "Column5"
        ' 
        ' Column6
        ' 
        resources.ApplyResources(Column6, "Column6")
        Column6.Name = "Column6"
        ' 
        ' Button11
        ' 
        Button11.BackColor = Color.FromArgb(CByte(24), CByte(30), CByte(54))
        resources.ApplyResources(Button11, "Button11")
        Button11.ForeColor = SystemColors.ButtonFace
        Button11.Name = "Button11"
        Button11.UseVisualStyleBackColor = False
        ' 
        ' FileSystemWatcher1
        ' 
        FileSystemWatcher1.EnableRaisingEvents = True
        FileSystemWatcher1.SynchronizingObject = Me
        ' 
        ' Button12
        ' 
        resources.ApplyResources(Button12, "Button12")
        Button12.BackColor = Color.FromArgb(CByte(24), CByte(30), CByte(54))
        Button12.ForeColor = SystemColors.ButtonFace
        Button12.Name = "Button12"
        Button12.UseVisualStyleBackColor = False
        ' 
        ' Transaction
        ' 
        resources.ApplyResources(Me, "$this")
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(226), CByte(243), CByte(245))
        Controls.Add(Button12)
        Controls.Add(Button11)
        Controls.Add(DataGridView1)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "Transaction"
        WindowState = FormWindowState.Maximized
        Panel2.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(FileSystemWatcher1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Transactions As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button11 As Button
    Friend WithEvents FileSystemWatcher1 As IO.FileSystemWatcher
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Button12 As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn

End Class
