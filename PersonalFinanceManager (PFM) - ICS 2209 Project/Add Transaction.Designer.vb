<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Panel1 = New Panel()
        DateTimePicker1 = New DateTimePicker()
        Button9 = New Button()
        ComboBox3 = New ComboBox()
        ComboBox2 = New ComboBox()
        ComboBox1 = New ComboBox()
        TextBox3 = New TextBox()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Panel2 = New Panel()
        Button1 = New Button()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(24), CByte(30), CByte(54))
        Panel1.Controls.Add(DateTimePicker1)
        Panel1.Controls.Add(Button9)
        Panel1.Controls.Add(ComboBox3)
        Panel1.Controls.Add(ComboBox2)
        Panel1.Controls.Add(ComboBox1)
        Panel1.Controls.Add(TextBox3)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Left
        Panel1.Font = New Font("Times New Roman", 9.75F)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(289, 571)
        Panel1.TabIndex = 0
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(13, 36)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(224, 22)
        DateTimePicker1.TabIndex = 8
        ' 
        ' Button9
        ' 
        Button9.AutoSize = True
        Button9.BackColor = Color.FromArgb(CByte(24), CByte(30), CByte(54))
        Button9.BackgroundImageLayout = ImageLayout.None
        Button9.Dock = DockStyle.Bottom
        Button9.FlatStyle = FlatStyle.Popup
        Button9.Font = New Font("Times New Roman", 9.75F)
        Button9.ForeColor = SystemColors.ButtonFace
        Button9.Image = CType(resources.GetObject("Button9.Image"), Image)
        Button9.ImageAlign = ContentAlignment.MiddleLeft
        Button9.ImeMode = ImeMode.NoControl
        Button9.Location = New Point(0, 510)
        Button9.Name = "Button9"
        Button9.Size = New Size(289, 61)
        Button9.TabIndex = 7
        Button9.Text = "Exit"
        Button9.TextAlign = ContentAlignment.MiddleRight
        Button9.UseVisualStyleBackColor = False
        ' 
        ' ComboBox3
        ' 
        ComboBox3.Font = New Font("Times New Roman", 9.75F)
        ComboBox3.FormattingEnabled = True
        ComboBox3.Items.AddRange(New Object() {"Income", "Savings", "Other"})
        ComboBox3.Location = New Point(12, 289)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(247, 23)
        ComboBox3.TabIndex = 7
        ' 
        ' ComboBox2
        ' 
        ComboBox2.Font = New Font("Times New Roman", 9.75F)
        ComboBox2.FormattingEnabled = True
        ComboBox2.Items.AddRange(New Object() {"Withdrawal", "Deposit"})
        ComboBox2.Location = New Point(12, 174)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(247, 23)
        ComboBox2.TabIndex = 6
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Font = New Font("Times New Roman", 9.75F)
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"General(Family&Friends)", "Income", "Savings", "Other(Outside factors)"})
        ComboBox1.Location = New Point(13, 405)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(246, 23)
        ComboBox1.TabIndex = 5
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Times New Roman", 9.75F)
        TextBox3.Location = New Point(13, 103)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(246, 22)
        TextBox3.TabIndex = 3
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Times New Roman", 9.75F)
        Label5.ForeColor = SystemColors.ButtonFace
        Label5.Location = New Point(12, 387)
        Label5.Name = "Label5"
        Label5.Size = New Size(136, 15)
        Label5.TabIndex = 4
        Label5.Text = "Transaction Destination"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Times New Roman", 9.75F)
        Label4.ForeColor = SystemColors.ButtonFace
        Label4.Location = New Point(12, 75)
        Label4.Name = "Label4"
        Label4.Size = New Size(114, 15)
        Label4.TabIndex = 3
        Label4.Text = "Transaction amount"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Times New Roman", 9.75F)
        Label3.ForeColor = SystemColors.ButtonFace
        Label3.Location = New Point(12, 271)
        Label3.Name = "Label3"
        Label3.Size = New Size(107, 15)
        Label3.TabIndex = 2
        Label3.Text = "Transaction Origin"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Times New Roman", 9.75F)
        Label2.ForeColor = SystemColors.ButtonFace
        Label2.Location = New Point(13, 156)
        Label2.Name = "Label2"
        Label2.Size = New Size(101, 15)
        Label2.TabIndex = 1
        Label2.Text = "Transaction Type"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 9.75F)
        Label1.ForeColor = SystemColors.ButtonFace
        Label1.Location = New Point(12, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(161, 15)
        Label1.TabIndex = 0
        Label1.Text = "Transaction Date(dd/mm/yy)"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(37), CByte(42), CByte(64))
        Panel2.Controls.Add(Button1)
        Panel2.Dock = DockStyle.Bottom
        Panel2.Font = New Font("Times New Roman", 9.75F)
        Panel2.Location = New Point(289, 518)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(690, 53)
        Panel2.TabIndex = 1
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(24), CByte(30), CByte(54))
        Button1.Dock = DockStyle.Right
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Font = New Font("Times New Roman", 9.75F)
        Button1.ForeColor = SystemColors.ButtonFace
        Button1.Location = New Point(480, 0)
        Button1.Name = "Button1"
        Button1.Size = New Size(210, 53)
        Button1.TabIndex = 0
        Button1.Text = "Add Transaction"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(37), CByte(42), CByte(64))
        ClientSize = New Size(979, 571)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form2"
        Text = "Add Transaction"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
