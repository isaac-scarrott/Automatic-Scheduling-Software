<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainScreen))
        Me.Logo_frmMainScreen = New System.Windows.Forms.PictureBox()
        Me.MainScreen_Text = New System.Windows.Forms.Label()
        Me.Rota_Button = New System.Windows.Forms.Button()
        Me.Volunteers_Button = New System.Windows.Forms.Button()
        Me.Jobs_Button = New System.Windows.Forms.Button()
        Me.Unavailability_Button = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Statistics_Button = New System.Windows.Forms.Button()
        CType(Me.Logo_frmMainScreen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Logo_frmMainScreen
        '
        Me.Logo_frmMainScreen.Image = CType(resources.GetObject("Logo_frmMainScreen.Image"), System.Drawing.Image)
        Me.Logo_frmMainScreen.Location = New System.Drawing.Point(0, 2)
        Me.Logo_frmMainScreen.Name = "Logo_frmMainScreen"
        Me.Logo_frmMainScreen.Size = New System.Drawing.Size(88, 86)
        Me.Logo_frmMainScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Logo_frmMainScreen.TabIndex = 0
        Me.Logo_frmMainScreen.TabStop = False
        '
        'MainScreen_Text
        '
        Me.MainScreen_Text.AutoSize = True
        Me.MainScreen_Text.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.MainScreen_Text.ForeColor = System.Drawing.Color.DodgerBlue
        Me.MainScreen_Text.Location = New System.Drawing.Point(124, 30)
        Me.MainScreen_Text.Name = "MainScreen_Text"
        Me.MainScreen_Text.Size = New System.Drawing.Size(165, 31)
        Me.MainScreen_Text.TabIndex = 1
        Me.MainScreen_Text.Text = "Main Screen"
        '
        'Rota_Button
        '
        Me.Rota_Button.Location = New System.Drawing.Point(39, 104)
        Me.Rota_Button.Name = "Rota_Button"
        Me.Rota_Button.Size = New System.Drawing.Size(98, 28)
        Me.Rota_Button.TabIndex = 2
        Me.Rota_Button.Text = "Rota"
        Me.Rota_Button.UseVisualStyleBackColor = True
        '
        'Volunteers_Button
        '
        Me.Volunteers_Button.Location = New System.Drawing.Point(39, 177)
        Me.Volunteers_Button.Name = "Volunteers_Button"
        Me.Volunteers_Button.Size = New System.Drawing.Size(98, 28)
        Me.Volunteers_Button.TabIndex = 3
        Me.Volunteers_Button.Text = "Volunteers"
        Me.Volunteers_Button.UseVisualStyleBackColor = True
        '
        'Jobs_Button
        '
        Me.Jobs_Button.Location = New System.Drawing.Point(39, 255)
        Me.Jobs_Button.Name = "Jobs_Button"
        Me.Jobs_Button.Size = New System.Drawing.Size(98, 28)
        Me.Jobs_Button.TabIndex = 4
        Me.Jobs_Button.Text = "Jobs"
        Me.Jobs_Button.UseVisualStyleBackColor = True
        '
        'Unavailability_Button
        '
        Me.Unavailability_Button.Location = New System.Drawing.Point(211, 104)
        Me.Unavailability_Button.Name = "Unavailability_Button"
        Me.Unavailability_Button.Size = New System.Drawing.Size(98, 28)
        Me.Unavailability_Button.TabIndex = 5
        Me.Unavailability_Button.Text = "Unavailability"
        Me.Unavailability_Button.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(211, 255)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(98, 28)
        Me.Button5.TabIndex = 7
        Me.Button5.Text = "Log Out"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Statistics_Button
        '
        Me.Statistics_Button.Location = New System.Drawing.Point(211, 177)
        Me.Statistics_Button.Name = "Statistics_Button"
        Me.Statistics_Button.Size = New System.Drawing.Size(98, 28)
        Me.Statistics_Button.TabIndex = 6
        Me.Statistics_Button.Text = "Statistics"
        Me.Statistics_Button.UseVisualStyleBackColor = True
        '
        'frmMainScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(340, 316)
        Me.Controls.Add(Me.Statistics_Button)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Unavailability_Button)
        Me.Controls.Add(Me.Jobs_Button)
        Me.Controls.Add(Me.Volunteers_Button)
        Me.Controls.Add(Me.Rota_Button)
        Me.Controls.Add(Me.MainScreen_Text)
        Me.Controls.Add(Me.Logo_frmMainScreen)
        Me.Name = "frmMainScreen"
        Me.Text = "Main Screen"
        CType(Me.Logo_frmMainScreen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Logo_frmMainScreen As System.Windows.Forms.PictureBox
    Friend WithEvents MainScreen_Text As System.Windows.Forms.Label
    Friend WithEvents Rota_Button As System.Windows.Forms.Button
    Friend WithEvents Volunteers_Button As System.Windows.Forms.Button
    Friend WithEvents Jobs_Button As System.Windows.Forms.Button
    Friend WithEvents Unavailability_Button As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Statistics_Button As System.Windows.Forms.Button
End Class
