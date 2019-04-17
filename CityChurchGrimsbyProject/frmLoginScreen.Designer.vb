<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLoginScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLoginScreen))
        Me.ForgottenPassword_Button = New System.Windows.Forms.Button()
        Me.Login_Button = New System.Windows.Forms.Button()
        Me.Password_Textbox = New System.Windows.Forms.TextBox()
        Me.Username_TextBox = New System.Windows.Forms.TextBox()
        Me.Password_label = New System.Windows.Forms.Label()
        Me.Username_Label = New System.Windows.Forms.Label()
        Me.Login_Label = New System.Windows.Forms.Label()
        Me.LoginScreenTitle = New System.Windows.Forms.Label()
        Me.LogoLoginScreen = New System.Windows.Forms.PictureBox()
        CType(Me.LogoLoginScreen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ForgottenPassword_Button
        '
        Me.ForgottenPassword_Button.Location = New System.Drawing.Point(52, 228)
        Me.ForgottenPassword_Button.Name = "ForgottenPassword_Button"
        Me.ForgottenPassword_Button.Size = New System.Drawing.Size(124, 23)
        Me.ForgottenPassword_Button.TabIndex = 17
        Me.ForgottenPassword_Button.Text = "Forgotten Password"
        Me.ForgottenPassword_Button.UseVisualStyleBackColor = True
        '
        'Login_Button
        '
        Me.Login_Button.Location = New System.Drawing.Point(323, 228)
        Me.Login_Button.Name = "Login_Button"
        Me.Login_Button.Size = New System.Drawing.Size(75, 23)
        Me.Login_Button.TabIndex = 16
        Me.Login_Button.Text = "Login"
        Me.Login_Button.UseVisualStyleBackColor = True
        '
        'Password_Textbox
        '
        Me.Password_Textbox.Location = New System.Drawing.Point(149, 176)
        Me.Password_Textbox.Name = "Password_Textbox"
        Me.Password_Textbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9899)
        Me.Password_Textbox.Size = New System.Drawing.Size(249, 20)
        Me.Password_Textbox.TabIndex = 15
        '
        'Username_TextBox
        '
        Me.Username_TextBox.BackColor = System.Drawing.SystemColors.Window
        Me.Username_TextBox.Location = New System.Drawing.Point(149, 131)
        Me.Username_TextBox.Name = "Username_TextBox"
        Me.Username_TextBox.Size = New System.Drawing.Size(249, 20)
        Me.Username_TextBox.TabIndex = 14
        '
        'Password_label
        '
        Me.Password_label.AutoSize = True
        Me.Password_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Password_label.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Password_label.Location = New System.Drawing.Point(48, 176)
        Me.Password_label.Name = "Password_label"
        Me.Password_label.Size = New System.Drawing.Size(78, 20)
        Me.Password_label.TabIndex = 13
        Me.Password_label.Text = "Password"
        '
        'Username_Label
        '
        Me.Username_Label.AutoSize = True
        Me.Username_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Username_Label.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Username_Label.Location = New System.Drawing.Point(48, 131)
        Me.Username_Label.Name = "Username_Label"
        Me.Username_Label.Size = New System.Drawing.Size(83, 20)
        Me.Username_Label.TabIndex = 12
        Me.Username_Label.Text = "Username"
        '
        'Login_Label
        '
        Me.Login_Label.AutoSize = True
        Me.Login_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Login_Label.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Login_Label.Location = New System.Drawing.Point(145, 72)
        Me.Login_Label.Name = "Login_Label"
        Me.Login_Label.Size = New System.Drawing.Size(100, 20)
        Me.Login_Label.TabIndex = 11
        Me.Login_Label.Text = "Please Login"
        '
        'LoginScreenTitle
        '
        Me.LoginScreenTitle.AutoSize = True
        Me.LoginScreenTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.LoginScreenTitle.ForeColor = System.Drawing.Color.DodgerBlue
        Me.LoginScreenTitle.Location = New System.Drawing.Point(144, 17)
        Me.LoginScreenTitle.Name = "LoginScreenTitle"
        Me.LoginScreenTitle.Size = New System.Drawing.Size(308, 25)
        Me.LoginScreenTitle.TabIndex = 10
        Me.LoginScreenTitle.Text = "City Church Grimsby Rota System"
        '
        'LogoLoginScreen
        '
        Me.LogoLoginScreen.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LogoLoginScreen.Image = CType(resources.GetObject("LogoLoginScreen.Image"), System.Drawing.Image)
        Me.LogoLoginScreen.Location = New System.Drawing.Point(14, 14)
        Me.LogoLoginScreen.Name = "LogoLoginScreen"
        Me.LogoLoginScreen.Size = New System.Drawing.Size(117, 93)
        Me.LogoLoginScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LogoLoginScreen.TabIndex = 9
        Me.LogoLoginScreen.TabStop = False
        '
        'frmLoginScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(456, 284)
        Me.Controls.Add(Me.ForgottenPassword_Button)
        Me.Controls.Add(Me.Login_Button)
        Me.Controls.Add(Me.Password_Textbox)
        Me.Controls.Add(Me.Username_TextBox)
        Me.Controls.Add(Me.Password_label)
        Me.Controls.Add(Me.Username_Label)
        Me.Controls.Add(Me.Login_Label)
        Me.Controls.Add(Me.LoginScreenTitle)
        Me.Controls.Add(Me.LogoLoginScreen)
        Me.Name = "frmLoginScreen"
        Me.Text = "Login"
        CType(Me.LogoLoginScreen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ForgottenPassword_Button As System.Windows.Forms.Button
    Friend WithEvents Login_Button As System.Windows.Forms.Button
    Friend WithEvents Password_Textbox As System.Windows.Forms.TextBox
    Friend WithEvents Username_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Password_label As System.Windows.Forms.Label
    Friend WithEvents Username_Label As System.Windows.Forms.Label
    Friend WithEvents Login_Label As System.Windows.Forms.Label
    Friend WithEvents LoginScreenTitle As System.Windows.Forms.Label
    Friend WithEvents LogoLoginScreen As System.Windows.Forms.PictureBox
End Class
