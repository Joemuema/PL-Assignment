<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        BackPanel = New Panel()
        RegisterErrorLabel = New Label()
        FullNameWarningLabel = New Label()
        FullNameTextBox = New TextBox()
        FullNameLabel = New Label()
        CPWarningLabel = New Label()
        EmailWarningLabel = New Label()
        ColonLabel = New Label()
        PasswordLabel2 = New Label()
        ConfirmLabel = New Label()
        ConfirmPasswordTextBox = New TextBox()
        EmailLabel = New Label()
        EmailTextBox = New TextBox()
        PasswordWarningLabel = New Label()
        UserNameWarningLabel = New Label()
        SignUpLabel = New Label()
        RegisterButton = New Button()
        NoAccountLabel = New Label()
        PasswordLabel = New Label()
        PasswordTextBox = New TextBox()
        UserNameTextBox = New TextBox()
        UserNameLabel = New Label()
        UserImage = New PictureBox()
        SignInLabel = New Label()
        BackPanel.SuspendLayout()
        CType(UserImage, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' BackPanel
        ' 
        BackPanel.BackColor = Color.DimGray
        BackPanel.BorderStyle = BorderStyle.FixedSingle
        BackPanel.Controls.Add(RegisterErrorLabel)
        BackPanel.Controls.Add(FullNameWarningLabel)
        BackPanel.Controls.Add(FullNameTextBox)
        BackPanel.Controls.Add(FullNameLabel)
        BackPanel.Controls.Add(CPWarningLabel)
        BackPanel.Controls.Add(EmailWarningLabel)
        BackPanel.Controls.Add(ColonLabel)
        BackPanel.Controls.Add(PasswordLabel2)
        BackPanel.Controls.Add(ConfirmLabel)
        BackPanel.Controls.Add(ConfirmPasswordTextBox)
        BackPanel.Controls.Add(EmailLabel)
        BackPanel.Controls.Add(EmailTextBox)
        BackPanel.Controls.Add(PasswordWarningLabel)
        BackPanel.Controls.Add(UserNameWarningLabel)
        BackPanel.Controls.Add(SignUpLabel)
        BackPanel.Controls.Add(RegisterButton)
        BackPanel.Controls.Add(NoAccountLabel)
        BackPanel.Controls.Add(PasswordLabel)
        BackPanel.Controls.Add(PasswordTextBox)
        BackPanel.Controls.Add(UserNameTextBox)
        BackPanel.Controls.Add(UserNameLabel)
        BackPanel.Controls.Add(UserImage)
        BackPanel.Controls.Add(SignInLabel)
        BackPanel.Location = New Point(512, 168)
        BackPanel.Name = "BackPanel"
        BackPanel.Size = New Size(344, 438)
        BackPanel.TabIndex = 1
        ' 
        ' RegisterErrorLabel
        ' 
        RegisterErrorLabel.AutoSize = True
        RegisterErrorLabel.BackColor = Color.Transparent
        RegisterErrorLabel.Font = New Font("Segoe UI", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        RegisterErrorLabel.ForeColor = Color.Red
        RegisterErrorLabel.Location = New Point(69, 381)
        RegisterErrorLabel.Name = "RegisterErrorLabel"
        RegisterErrorLabel.Size = New Size(0, 15)
        RegisterErrorLabel.TabIndex = 22
        ' 
        ' FullNameWarningLabel
        ' 
        FullNameWarningLabel.AutoSize = True
        FullNameWarningLabel.BackColor = Color.Transparent
        FullNameWarningLabel.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        FullNameWarningLabel.ForeColor = Color.Red
        FullNameWarningLabel.Location = New Point(106, 124)
        FullNameWarningLabel.Name = "FullNameWarningLabel"
        FullNameWarningLabel.Size = New Size(0, 13)
        FullNameWarningLabel.TabIndex = 21
        ' 
        ' FullNameTextBox
        ' 
        FullNameTextBox.Location = New Point(106, 140)
        FullNameTextBox.MaxLength = 30
        FullNameTextBox.Name = "FullNameTextBox"
        FullNameTextBox.Size = New Size(199, 23)
        FullNameTextBox.TabIndex = 20
        ' 
        ' FullNameLabel
        ' 
        FullNameLabel.AutoSize = True
        FullNameLabel.BackColor = Color.Transparent
        FullNameLabel.ForeColor = Color.White
        FullNameLabel.Location = New Point(32, 143)
        FullNameLabel.Name = "FullNameLabel"
        FullNameLabel.Size = New Size(65, 15)
        FullNameLabel.TabIndex = 19
        FullNameLabel.Text = "Full name :"
        ' 
        ' CPWarningLabel
        ' 
        CPWarningLabel.AutoSize = True
        CPWarningLabel.BackColor = Color.Transparent
        CPWarningLabel.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        CPWarningLabel.ForeColor = Color.Red
        CPWarningLabel.Location = New Point(106, 294)
        CPWarningLabel.Name = "CPWarningLabel"
        CPWarningLabel.Size = New Size(0, 13)
        CPWarningLabel.TabIndex = 18
        ' 
        ' EmailWarningLabel
        ' 
        EmailWarningLabel.AutoSize = True
        EmailWarningLabel.BackColor = Color.Transparent
        EmailWarningLabel.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        EmailWarningLabel.ForeColor = Color.Red
        EmailWarningLabel.Location = New Point(106, 208)
        EmailWarningLabel.Name = "EmailWarningLabel"
        EmailWarningLabel.Size = New Size(0, 13)
        EmailWarningLabel.TabIndex = 17
        ' 
        ' ColonLabel
        ' 
        ColonLabel.AutoSize = True
        ColonLabel.BackColor = Color.Transparent
        ColonLabel.ForeColor = Color.White
        ColonLabel.Location = New Point(87, 313)
        ColonLabel.Name = "ColonLabel"
        ColonLabel.Size = New Size(10, 15)
        ColonLabel.TabIndex = 16
        ColonLabel.Text = ":"
        ' 
        ' PasswordLabel2
        ' 
        PasswordLabel2.AutoSize = True
        PasswordLabel2.BackColor = Color.Transparent
        PasswordLabel2.ForeColor = Color.White
        PasswordLabel2.Location = New Point(34, 318)
        PasswordLabel2.Name = "PasswordLabel2"
        PasswordLabel2.Size = New Size(57, 15)
        PasswordLabel2.TabIndex = 15
        PasswordLabel2.Text = "Password"
        ' 
        ' ConfirmLabel
        ' 
        ConfirmLabel.AutoSize = True
        ConfirmLabel.BackColor = Color.Transparent
        ConfirmLabel.ForeColor = Color.White
        ConfirmLabel.Location = New Point(40, 303)
        ConfirmLabel.Name = "ConfirmLabel"
        ConfirmLabel.Size = New Size(51, 15)
        ConfirmLabel.TabIndex = 14
        ConfirmLabel.Text = "Confirm"
        ' 
        ' ConfirmPasswordTextBox
        ' 
        ConfirmPasswordTextBox.BackColor = SystemColors.Window
        ConfirmPasswordTextBox.Location = New Point(106, 310)
        ConfirmPasswordTextBox.MaxLength = 30
        ConfirmPasswordTextBox.Name = "ConfirmPasswordTextBox"
        ConfirmPasswordTextBox.PasswordChar = "*"c
        ConfirmPasswordTextBox.Size = New Size(199, 23)
        ConfirmPasswordTextBox.TabIndex = 13
        ' 
        ' EmailLabel
        ' 
        EmailLabel.AutoSize = True
        EmailLabel.BackColor = Color.Transparent
        EmailLabel.ForeColor = Color.White
        EmailLabel.Location = New Point(55, 227)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New Size(42, 15)
        EmailLabel.TabIndex = 12
        EmailLabel.Text = "Email :"
        ' 
        ' EmailTextBox
        ' 
        EmailTextBox.Location = New Point(106, 224)
        EmailTextBox.Name = "EmailTextBox"
        EmailTextBox.Size = New Size(199, 23)
        EmailTextBox.TabIndex = 11
        ' 
        ' PasswordWarningLabel
        ' 
        PasswordWarningLabel.AutoSize = True
        PasswordWarningLabel.BackColor = Color.Transparent
        PasswordWarningLabel.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        PasswordWarningLabel.ForeColor = Color.Red
        PasswordWarningLabel.Location = New Point(106, 250)
        PasswordWarningLabel.Name = "PasswordWarningLabel"
        PasswordWarningLabel.Size = New Size(0, 13)
        PasswordWarningLabel.TabIndex = 10
        ' 
        ' UserNameWarningLabel
        ' 
        UserNameWarningLabel.AutoSize = True
        UserNameWarningLabel.BackColor = Color.Transparent
        UserNameWarningLabel.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        UserNameWarningLabel.ForeColor = Color.Red
        UserNameWarningLabel.Location = New Point(106, 166)
        UserNameWarningLabel.Name = "UserNameWarningLabel"
        UserNameWarningLabel.Size = New Size(0, 13)
        UserNameWarningLabel.TabIndex = 9
        ' 
        ' SignUpLabel
        ' 
        SignUpLabel.AutoSize = True
        SignUpLabel.BackColor = Color.Transparent
        SignUpLabel.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        SignUpLabel.Location = New Point(225, 407)
        SignUpLabel.Name = "SignUpLabel"
        SignUpLabel.Size = New Size(44, 15)
        SignUpLabel.TabIndex = 8
        SignUpLabel.Text = "Sign in"
        ' 
        ' RegisterButton
        ' 
        RegisterButton.BackColor = Color.SlateGray
        RegisterButton.FlatStyle = FlatStyle.Popup
        RegisterButton.ForeColor = Color.Black
        RegisterButton.Location = New Point(225, 355)
        RegisterButton.Name = "RegisterButton"
        RegisterButton.Size = New Size(80, 23)
        RegisterButton.TabIndex = 7
        RegisterButton.Text = "Continue"
        RegisterButton.UseVisualStyleBackColor = False
        ' 
        ' NoAccountLabel
        ' 
        NoAccountLabel.AutoSize = True
        NoAccountLabel.BackColor = Color.Transparent
        NoAccountLabel.ForeColor = Color.White
        NoAccountLabel.Location = New Point(87, 407)
        NoAccountLabel.Name = "NoAccountLabel"
        NoAccountLabel.Size = New Size(142, 15)
        NoAccountLabel.TabIndex = 6
        NoAccountLabel.Text = "Already have an account?"
        ' 
        ' PasswordLabel
        ' 
        PasswordLabel.AutoSize = True
        PasswordLabel.BackColor = Color.Transparent
        PasswordLabel.ForeColor = Color.White
        PasswordLabel.Location = New Point(34, 269)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New Size(63, 15)
        PasswordLabel.TabIndex = 5
        PasswordLabel.Text = "Password :"
        ' 
        ' PasswordTextBox
        ' 
        PasswordTextBox.BackColor = SystemColors.Window
        PasswordTextBox.Location = New Point(106, 266)
        PasswordTextBox.MaxLength = 30
        PasswordTextBox.Name = "PasswordTextBox"
        PasswordTextBox.PasswordChar = "*"c
        PasswordTextBox.Size = New Size(199, 23)
        PasswordTextBox.TabIndex = 4
        ' 
        ' UserNameTextBox
        ' 
        UserNameTextBox.Location = New Point(106, 182)
        UserNameTextBox.MaxLength = 30
        UserNameTextBox.Name = "UserNameTextBox"
        UserNameTextBox.Size = New Size(199, 23)
        UserNameTextBox.TabIndex = 3
        ' 
        ' UserNameLabel
        ' 
        UserNameLabel.AutoSize = True
        UserNameLabel.BackColor = Color.Transparent
        UserNameLabel.ForeColor = Color.White
        UserNameLabel.Location = New Point(31, 185)
        UserNameLabel.Name = "UserNameLabel"
        UserNameLabel.Size = New Size(66, 15)
        UserNameLabel.TabIndex = 2
        UserNameLabel.Text = "Username :"
        ' 
        ' UserImage
        ' 
        UserImage.BackColor = Color.Transparent
        UserImage.BackgroundImage = CType(resources.GetObject("UserImage.BackgroundImage"), Image)
        UserImage.BackgroundImageLayout = ImageLayout.Zoom
        UserImage.Location = New Point(145, 16)
        UserImage.Name = "UserImage"
        UserImage.Size = New Size(63, 67)
        UserImage.SizeMode = PictureBoxSizeMode.Zoom
        UserImage.TabIndex = 1
        UserImage.TabStop = False
        ' 
        ' SignInLabel
        ' 
        SignInLabel.AutoSize = True
        SignInLabel.BackColor = Color.Transparent
        SignInLabel.Font = New Font("Bell MT", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SignInLabel.ForeColor = Color.White
        SignInLabel.Location = New Point(100, 86)
        SignInLabel.Name = "SignInLabel"
        SignInLabel.Size = New Size(155, 25)
        SignInLabel.TabIndex = 0
        SignInLabel.Text = "Create Account"
        ' 
        ' Form1
        ' 
        AutoScaleMode = AutoScaleMode.None
        AutoSize = True
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1350, 729)
        Controls.Add(BackPanel)
        Name = "Form1"
        Text = "Register"
        WindowState = FormWindowState.Maximized
        BackPanel.ResumeLayout(False)
        BackPanel.PerformLayout()
        CType(UserImage, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents BackPanel As Panel
    Friend WithEvents PasswordWarningLabel As Label
    Friend WithEvents UserNameWarningLabel As Label
    Friend WithEvents SignUpLabel As Label
    Friend WithEvents RegisterButton As Button
    Friend WithEvents NoAccountLabel As Label
    Friend WithEvents PasswordLabel As Label
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents UserNameTextBox As TextBox
    Friend WithEvents UserNameLabel As Label
    Friend WithEvents UserImage As PictureBox
    Friend WithEvents SignInLabel As Label
    Friend WithEvents EmailLabel As Label
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents ConfirmLabel As Label
    Friend WithEvents ConfirmPasswordTextBox As TextBox
    Friend WithEvents ColonLabel As Label
    Friend WithEvents PasswordLabel2 As Label
    Friend WithEvents CPWarningLabel As Label
    Friend WithEvents EmailWarningLabel As Label
    Friend WithEvents FullNameLabel As Label
    Friend WithEvents FullNameWarningLabel As Label
    Friend WithEvents FullNameTextBox As TextBox
    Friend WithEvents RegisterErrorLabel As Label
End Class
