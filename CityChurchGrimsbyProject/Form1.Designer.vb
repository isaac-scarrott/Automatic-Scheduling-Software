<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Background
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Background))
        Me.LogoLoginScreen = New System.Windows.Forms.PictureBox()
        Me.LoginScreenTitle = New System.Windows.Forms.Label()
        Me.Login_Label = New System.Windows.Forms.Label()
        Me.Username_Label = New System.Windows.Forms.Label()
        Me.Password_label = New System.Windows.Forms.Label()
        Me.Username_TextBox = New System.Windows.Forms.TextBox()
        Me.Password_Textbox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.LogoLoginScreen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LogoLoginScreen
        '
        Me.LogoLoginScreen.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LogoLoginScreen.Image = CType(resources.GetObject("LogoLoginScreen.Image"), System.Drawing.Image)
        Me.LogoLoginScreen.Location = New System.Drawing.Point(12, 12)
        Me.LogoLoginScreen.Name = "LogoLoginScreen"
        Me.LogoLoginScreen.Size = New System.Drawing.Size(117, 93)
        Me.LogoLoginScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LogoLoginScreen.TabIndex = 0
        Me.LogoLoginScreen.TabStop = False
        '
        'LoginScreenTitle
        '
        Me.LoginScreenTitle.AutoSize = True
        Me.LoginScreenTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.LoginScreenTitle.Location = New System.Drawing.Point(142, 15)
        Me.LoginScreenTitle.Name = "LoginScreenTitle"
        Me.LoginScreenTitle.Size = New System.Drawing.Size(308, 25)
        Me.LoginScreenTitle.TabIndex = 1
        Me.LoginScreenTitle.Text = "City Church Grimsby Rota System"
        '
        'Login_Label
        '
        Me.Login_Label.AutoSize = True
        Me.Login_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Login_Label.Location = New System.Drawing.Point(143, 69)
        Me.Login_Label.Name = "Login_Label"
        Me.Login_Label.Size = New System.Drawing.Size(100, 20)
        Me.Login_Label.TabIndex = 2
        Me.Login_Label.Text = "Please Login"
        '
        'Username_Label
        '
        Me.Username_Label.AutoSize = True
        Me.Username_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Username_Label.Location = New System.Drawing.Point(46, 129)
        Me.Username_Label.Name = "Username_Label"
        Me.Username_Label.Size = New System.Drawing.Size(83, 20)
        Me.Username_Label.TabIndex = 3
        Me.Username_Label.Text = "Username"
        '
        'Password_label
        '
        Me.Password_label.AutoSize = True
        Me.Password_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Password_label.Location = New System.Drawing.Point(51, 174)
        Me.Password_label.Name = "Password_label"
        Me.Password_label.Size = New System.Drawing.Size(78, 20)
        Me.Password_label.TabIndex = 4
        Me.Password_label.Text = "Password"
        '
        'Username_TextBox
        '
        Me.Username_TextBox.Location = New System.Drawing.Point(147, 129)
        Me.Username_TextBox.Name = "Username_TextBox"
        Me.Username_TextBox.Size = New System.Drawing.Size(249, 20)
        Me.Username_TextBox.TabIndex = 5
        '
        'Password_Textbox
        '
        Me.Password_Textbox.Location = New System.Drawing.Point(147, 174)
        Me.Password_Textbox.Name = "Password_Textbox"
        Me.Password_Textbox.Size = New System.Drawing.Size(249, 20)
        Me.Password_Textbox.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(321, 215)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Login"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(50, 215)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(124, 23)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Forgotten Password"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Background
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(456, 284)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Password_Textbox)
        Me.Controls.Add(Me.Username_TextBox)
        Me.Controls.Add(Me.Password_label)
        Me.Controls.Add(Me.Username_Label)
        Me.Controls.Add(Me.Login_Label)
        Me.Controls.Add(Me.LoginScreenTitle)
        Me.Controls.Add(Me.LogoLoginScreen)
        Me.Name = "Background"
        Me.Text = "Login Screen"
        CType(Me.LogoLoginScreen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LogoLoginScreen As System.Windows.Forms.PictureBox
    Friend WithEvents LoginScreenTitle As System.Windows.Forms.Label
    Friend WithEvents Login_Label As System.Windows.Forms.Label
    Friend WithEvents Username_Label As System.Windows.Forms.Label
    Friend WithEvents Password_label As System.Windows.Forms.Label
    Friend WithEvents Username_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Password_Textbox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button

End Class
