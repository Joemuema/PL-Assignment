<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        BackPanel = New Panel()
        ExitLabel = New Label()
        Label1 = New Label()
        LoginErrorLabel = New Label()
        PasswordWarningLabel = New Label()
        UserNameWarningLabel = New Label()
        SignUpLabel = New Label()
        LoginButton = New Button()
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
        BackPanel.Anchor = AnchorStyles.None
        BackPanel.BackColor = Color.DimGray
        BackPanel.BorderStyle = BorderStyle.FixedSingle
        BackPanel.Controls.Add(ExitLabel)
        BackPanel.Controls.Add(Label1)
        BackPanel.Controls.Add(LoginErrorLabel)
        BackPanel.Controls.Add(PasswordWarningLabel)
        BackPanel.Controls.Add(UserNameWarningLabel)
        BackPanel.Controls.Add(SignUpLabel)
        BackPanel.Controls.Add(LoginButton)
        BackPanel.Controls.Add(NoAccountLabel)
        BackPanel.Controls.Add(PasswordLabel)
        BackPanel.Controls.Add(PasswordTextBox)
        BackPanel.Controls.Add(UserNameTextBox)
        BackPanel.Controls.Add(UserNameLabel)
        BackPanel.Controls.Add(UserImage)
        BackPanel.Controls.Add(SignInLabel)
        BackPanel.Location = New Point(512, 210)
        BackPanel.Name = "BackPanel"
        BackPanel.Size = New Size(344, 308)
        BackPanel.TabIndex = 0
        ' 
        ' ExitLabel
        ' 
        ExitLabel.Anchor = AnchorStyles.None
        ExitLabel.BackColor = Color.Transparent
        ExitLabel.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        ExitLabel.Location = New Point(257, 274)
        ExitLabel.Name = "ExitLabel"
        ExitLabel.Size = New Size(32, 15)
        ExitLabel.TabIndex = 25
        ExitLabel.Text = "EXIT"
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(239, 274)
        Label1.Name = "Label1"
        Label1.Size = New Size(22, 15)
        Label1.TabIndex = 24
        Label1.Text = "Or"
        ' 
        ' LoginErrorLabel
        ' 
        LoginErrorLabel.AutoSize = True
        LoginErrorLabel.BackColor = Color.Transparent
        LoginErrorLabel.Font = New Font("Segoe UI", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        LoginErrorLabel.ForeColor = Color.Red
        LoginErrorLabel.Location = New Point(67, 248)
        LoginErrorLabel.Name = "LoginErrorLabel"
        LoginErrorLabel.Size = New Size(0, 15)
        LoginErrorLabel.TabIndex = 23
        ' 
        ' PasswordWarningLabel
        ' 
        PasswordWarningLabel.Anchor = AnchorStyles.None
        PasswordWarningLabel.BackColor = Color.Transparent
        PasswordWarningLabel.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        PasswordWarningLabel.ForeColor = Color.Red
        PasswordWarningLabel.Location = New Point(102, 161)
        PasswordWarningLabel.Name = "PasswordWarningLabel"
        PasswordWarningLabel.Size = New Size(196, 13)
        PasswordWarningLabel.TabIndex = 10
        ' 
        ' UserNameWarningLabel
        ' 
        UserNameWarningLabel.Anchor = AnchorStyles.None
        UserNameWarningLabel.BackColor = Color.Transparent
        UserNameWarningLabel.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        UserNameWarningLabel.ForeColor = Color.Red
        UserNameWarningLabel.Location = New Point(102, 119)
        UserNameWarningLabel.Name = "UserNameWarningLabel"
        UserNameWarningLabel.Size = New Size(199, 13)
        UserNameWarningLabel.TabIndex = 9
        ' 
        ' SignUpLabel
        ' 
        SignUpLabel.Anchor = AnchorStyles.None
        SignUpLabel.BackColor = Color.Transparent
        SignUpLabel.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        SignUpLabel.Location = New Point(194, 274)
        SignUpLabel.Name = "SignUpLabel"
        SignUpLabel.Size = New Size(48, 15)
        SignUpLabel.TabIndex = 8
        SignUpLabel.Text = "Sign up"
        ' 
        ' LoginButton
        ' 
        LoginButton.Anchor = AnchorStyles.None
        LoginButton.BackColor = Color.SlateGray
        LoginButton.FlatStyle = FlatStyle.Popup
        LoginButton.ForeColor = Color.Black
        LoginButton.Location = New Point(221, 220)
        LoginButton.Name = "LoginButton"
        LoginButton.Size = New Size(80, 25)
        LoginButton.TabIndex = 7
        LoginButton.Text = "Continue"
        LoginButton.UseVisualStyleBackColor = False
        ' 
        ' NoAccountLabel
        ' 
        NoAccountLabel.Anchor = AnchorStyles.None
        NoAccountLabel.BackColor = Color.Transparent
        NoAccountLabel.ForeColor = Color.White
        NoAccountLabel.Location = New Point(67, 274)
        NoAccountLabel.Name = "NoAccountLabel"
        NoAccountLabel.Size = New Size(131, 15)
        NoAccountLabel.TabIndex = 6
        NoAccountLabel.Text = "Don't have an account?"
        ' 
        ' PasswordLabel
        ' 
        PasswordLabel.Anchor = AnchorStyles.None
        PasswordLabel.BackColor = Color.Transparent
        PasswordLabel.ForeColor = Color.White
        PasswordLabel.Location = New Point(36, 180)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New Size(60, 15)
        PasswordLabel.TabIndex = 5
        PasswordLabel.Text = "Password:"
        ' 
        ' PasswordTextBox
        ' 
        PasswordTextBox.Anchor = AnchorStyles.None
        PasswordTextBox.BackColor = SystemColors.Window
        PasswordTextBox.Location = New Point(102, 177)
        PasswordTextBox.MaxLength = 30
        PasswordTextBox.Name = "PasswordTextBox"
        PasswordTextBox.PasswordChar = "*"c
        PasswordTextBox.Size = New Size(199, 23)
        PasswordTextBox.TabIndex = 4
        ' 
        ' UserNameTextBox
        ' 
        UserNameTextBox.Anchor = AnchorStyles.None
        UserNameTextBox.Location = New Point(102, 135)
        UserNameTextBox.MaxLength = 30
        UserNameTextBox.Name = "UserNameTextBox"
        UserNameTextBox.Size = New Size(199, 23)
        UserNameTextBox.TabIndex = 3
        ' 
        ' UserNameLabel
        ' 
        UserNameLabel.Anchor = AnchorStyles.None
        UserNameLabel.BackColor = Color.Transparent
        UserNameLabel.ForeColor = Color.White
        UserNameLabel.Location = New Point(33, 138)
        UserNameLabel.Name = "UserNameLabel"
        UserNameLabel.Size = New Size(63, 15)
        UserNameLabel.TabIndex = 2
        UserNameLabel.Text = "Username:"
        ' 
        ' UserImage
        ' 
        UserImage.Anchor = AnchorStyles.None
        UserImage.BackColor = Color.Transparent
        UserImage.BackgroundImage = CType(resources.GetObject("UserImage.BackgroundImage"), Image)
        UserImage.BackgroundImageLayout = ImageLayout.Zoom
        UserImage.Location = New Point(141, 16)
        UserImage.Name = "UserImage"
        UserImage.Size = New Size(63, 67)
        UserImage.SizeMode = PictureBoxSizeMode.Zoom
        UserImage.TabIndex = 1
        UserImage.TabStop = False
        ' 
        ' SignInLabel
        ' 
        SignInLabel.Anchor = AnchorStyles.None
        SignInLabel.BackColor = Color.Transparent
        SignInLabel.Font = New Font("Bell MT", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SignInLabel.ForeColor = Color.White
        SignInLabel.Location = New Point(141, 86)
        SignInLabel.Name = "SignInLabel"
        SignInLabel.Size = New Size(77, 25)
        SignInLabel.TabIndex = 0
        SignInLabel.Text = "Sign In"
        ' 
        ' LoginForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1350, 706)
        Controls.Add(BackPanel)
        Name = "LoginForm"
        Text = "Login"
        WindowState = FormWindowState.Maximized
        BackPanel.ResumeLayout(False)
        BackPanel.PerformLayout()
        CType(UserImage, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents BackPanel As Panel
    Friend WithEvents SignInLabel As Label
    Friend WithEvents UserImage As PictureBox
    Friend WithEvents UserNameLabel As Label
    Friend WithEvents UserNameTextBox As TextBox
    Friend WithEvents SignUpLabel As Label
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents PasswordLabel As Label
    Friend WithEvents NoAccountLabel As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents LoginButton As Button
    Friend WithEvents PasswordWarningLabel As Label
    Friend WithEvents UserNameWarningLabel As Label
    Friend WithEvents LoginErrorLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ExitLabel As Label

End Class
