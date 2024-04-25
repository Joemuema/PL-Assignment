<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Record_Debt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Record_Debt))
        RDHome = New Button()
        RDGroupbx = New GroupBox()
        RDSaveDetails = New Button()
        RDPaybackDatedata = New DateTimePicker()
        RDDateTakendata = New DateTimePicker()
        RDDebtorNamedata = New TextBox()
        RDAmountdata = New TextBox()
        RDPaybackDate = New Label()
        RDDateTaken = New Label()
        RDDebtorName = New Label()
        RDAmount = New Label()
        RDGroupbx.SuspendLayout()
        SuspendLayout()
        ' 
        ' RDHome
        ' 
        RDHome.BackColor = Color.FromArgb(CByte(24), CByte(30), CByte(54))
        RDHome.FlatStyle = FlatStyle.Popup
        RDHome.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        RDHome.ForeColor = SystemColors.ButtonFace
        RDHome.Location = New Point(562, 370)
        RDHome.Margin = New Padding(2)
        RDHome.Name = "RDHome"
        RDHome.Size = New Size(126, 33)
        RDHome.TabIndex = 3
        RDHome.Text = "HOME"
        RDHome.UseVisualStyleBackColor = False
        ' 
        ' RDGroupbx
        ' 
        RDGroupbx.Controls.Add(RDSaveDetails)
        RDGroupbx.Controls.Add(RDPaybackDatedata)
        RDGroupbx.Controls.Add(RDDateTakendata)
        RDGroupbx.Controls.Add(RDDebtorNamedata)
        RDGroupbx.Controls.Add(RDAmountdata)
        RDGroupbx.Controls.Add(RDPaybackDate)
        RDGroupbx.Controls.Add(RDDateTaken)
        RDGroupbx.Controls.Add(RDDebtorName)
        RDGroupbx.Controls.Add(RDAmount)
        RDGroupbx.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        RDGroupbx.ForeColor = SystemColors.ButtonFace
        RDGroupbx.Location = New Point(11, 84)
        RDGroupbx.Margin = New Padding(2)
        RDGroupbx.Name = "RDGroupbx"
        RDGroupbx.Padding = New Padding(2)
        RDGroupbx.Size = New Size(695, 266)
        RDGroupbx.TabIndex = 2
        RDGroupbx.TabStop = False
        RDGroupbx.Text = "DEBT DETAILS"
        ' 
        ' RDSaveDetails
        ' 
        RDSaveDetails.BackColor = Color.FromArgb(CByte(24), CByte(30), CByte(54))
        RDSaveDetails.FlatStyle = FlatStyle.Popup
        RDSaveDetails.ForeColor = SystemColors.ButtonFace
        RDSaveDetails.Location = New Point(551, 211)
        RDSaveDetails.Margin = New Padding(2)
        RDSaveDetails.Name = "RDSaveDetails"
        RDSaveDetails.Size = New Size(109, 38)
        RDSaveDetails.TabIndex = 10
        RDSaveDetails.Text = "SAVE DETAILS"
        RDSaveDetails.UseVisualStyleBackColor = False
        ' 
        ' RDPaybackDatedata
        ' 
        RDPaybackDatedata.Location = New Point(135, 190)
        RDPaybackDatedata.Margin = New Padding(2)
        RDPaybackDatedata.Name = "RDPaybackDatedata"
        RDPaybackDatedata.Size = New Size(215, 23)
        RDPaybackDatedata.TabIndex = 9
        ' 
        ' RDDateTakendata
        ' 
        RDDateTakendata.Location = New Point(135, 144)
        RDDateTakendata.Margin = New Padding(2)
        RDDateTakendata.Name = "RDDateTakendata"
        RDDateTakendata.Size = New Size(215, 23)
        RDDateTakendata.TabIndex = 8
        ' 
        ' RDDebtorNamedata
        ' 
        RDDebtorNamedata.Location = New Point(135, 95)
        RDDebtorNamedata.Margin = New Padding(2)
        RDDebtorNamedata.Name = "RDDebtorNamedata"
        RDDebtorNamedata.Size = New Size(168, 23)
        RDDebtorNamedata.TabIndex = 7
        ' 
        ' RDAmountdata
        ' 
        RDAmountdata.Location = New Point(135, 50)
        RDAmountdata.Margin = New Padding(2)
        RDAmountdata.Name = "RDAmountdata"
        RDAmountdata.Size = New Size(168, 23)
        RDAmountdata.TabIndex = 5
        ' 
        ' RDPaybackDate
        ' 
        RDPaybackDate.AutoSize = True
        RDPaybackDate.BackColor = Color.Transparent
        RDPaybackDate.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        RDPaybackDate.ForeColor = SystemColors.ButtonFace
        RDPaybackDate.Location = New Point(7, 193)
        RDPaybackDate.Margin = New Padding(2, 0, 2, 0)
        RDPaybackDate.Name = "RDPaybackDate"
        RDPaybackDate.Size = New Size(90, 15)
        RDPaybackDate.TabIndex = 3
        RDPaybackDate.Text = "PAYBACK DATE"
        ' 
        ' RDDateTaken
        ' 
        RDDateTaken.AutoSize = True
        RDDateTaken.BackColor = Color.Transparent
        RDDateTaken.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        RDDateTaken.ForeColor = SystemColors.ButtonFace
        RDDateTaken.Location = New Point(7, 147)
        RDDateTaken.Margin = New Padding(2, 0, 2, 0)
        RDDateTaken.Name = "RDDateTaken"
        RDDateTaken.Size = New Size(76, 15)
        RDDateTaken.TabIndex = 2
        RDDateTaken.Text = "DATE TAKEN"
        ' 
        ' RDDebtorName
        ' 
        RDDebtorName.AutoSize = True
        RDDebtorName.BackColor = Color.Transparent
        RDDebtorName.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        RDDebtorName.ForeColor = SystemColors.ButtonFace
        RDDebtorName.Location = New Point(7, 96)
        RDDebtorName.Margin = New Padding(2, 0, 2, 0)
        RDDebtorName.Name = "RDDebtorName"
        RDDebtorName.Size = New Size(91, 15)
        RDDebtorName.TabIndex = 1
        RDDebtorName.Text = "DEBTOR NAME"
        ' 
        ' RDAmount
        ' 
        RDAmount.AutoSize = True
        RDAmount.BackColor = Color.Transparent
        RDAmount.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        RDAmount.ForeColor = SystemColors.ButtonFace
        RDAmount.Location = New Point(7, 50)
        RDAmount.Margin = New Padding(2, 0, 2, 0)
        RDAmount.Name = "RDAmount"
        RDAmount.Size = New Size(60, 15)
        RDAmount.TabIndex = 0
        RDAmount.Text = "AMOUNT"
        ' 
        ' Record_Debt
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(24), CByte(30), CByte(54))
        ClientSize = New Size(713, 450)
        Controls.Add(RDHome)
        Controls.Add(RDGroupbx)
        ForeColor = SystemColors.ButtonFace
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "Record_Debt"
        Text = "Record_Debt"
        RDGroupbx.ResumeLayout(False)
        RDGroupbx.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents RDHome As Button
    Friend WithEvents RDGroupbx As GroupBox
    Friend WithEvents RDSaveDetails As Button
    Friend WithEvents RDPaybackDatedata As DateTimePicker
    Friend WithEvents RDDateTakendata As DateTimePicker
    Friend WithEvents RDDebtorNamedata As TextBox
    Friend WithEvents RDAmountdata As TextBox
    Friend WithEvents RDPaybackDate As Label
    Friend WithEvents RDDateTaken As Label
    Friend WithEvents RDDebtorName As Label
    Friend WithEvents RDAmount As Label
End Class
