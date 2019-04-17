<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStatisticsSelection
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStatisticsSelection))
        Me.Modify_Button = New System.Windows.Forms.Button()
        Me.MainScreen_Text = New System.Windows.Forms.Label()
        Me.Logo_frmMainScreen = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.Back_Button = New System.Windows.Forms.Button()
        CType(Me.Logo_frmMainScreen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Modify_Button
        '
        Me.Modify_Button.Location = New System.Drawing.Point(146, 120)
        Me.Modify_Button.Name = "Modify_Button"
        Me.Modify_Button.Size = New System.Drawing.Size(52, 23)
        Me.Modify_Button.TabIndex = 24
        Me.Modify_Button.Text = "Select"
        Me.Modify_Button.UseVisualStyleBackColor = True
        '
        'MainScreen_Text
        '
        Me.MainScreen_Text.AutoSize = True
        Me.MainScreen_Text.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainScreen_Text.ForeColor = System.Drawing.Color.DodgerBlue
        Me.MainScreen_Text.Location = New System.Drawing.Point(90, 24)
        Me.MainScreen_Text.Name = "MainScreen_Text"
        Me.MainScreen_Text.Size = New System.Drawing.Size(108, 29)
        Me.MainScreen_Text.TabIndex = 23
        Me.MainScreen_Text.Text = "Statistics"
        '
        'Logo_frmMainScreen
        '
        Me.Logo_frmMainScreen.Image = CType(resources.GetObject("Logo_frmMainScreen.Image"), System.Drawing.Image)
        Me.Logo_frmMainScreen.Location = New System.Drawing.Point(-4, -3)
        Me.Logo_frmMainScreen.Name = "Logo_frmMainScreen"
        Me.Logo_frmMainScreen.Size = New System.Drawing.Size(88, 86)
        Me.Logo_frmMainScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Logo_frmMainScreen.TabIndex = 22
        Me.Logo_frmMainScreen.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "What do you wish to see statistics on?"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(15, 103)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(70, 17)
        Me.RadioButton1.TabIndex = 26
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Volunteer"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(139, 102)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(59, 17)
        Me.RadioButton2.TabIndex = 27
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Church"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'Back_Button
        '
        Me.Back_Button.Location = New System.Drawing.Point(15, 120)
        Me.Back_Button.Name = "Back_Button"
        Me.Back_Button.Size = New System.Drawing.Size(41, 23)
        Me.Back_Button.TabIndex = 28
        Me.Back_Button.Text = "Back"
        Me.Back_Button.UseVisualStyleBackColor = True
        '
        'frmStatisticsSelection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(211, 146)
        Me.Controls.Add(Me.Back_Button)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Modify_Button)
        Me.Controls.Add(Me.MainScreen_Text)
        Me.Controls.Add(Me.Logo_frmMainScreen)
        Me.Name = "frmStatisticsSelection"
        Me.Text = "Statistics"
        CType(Me.Logo_frmMainScreen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Modify_Button As System.Windows.Forms.Button
    Friend WithEvents MainScreen_Text As System.Windows.Forms.Label
    Friend WithEvents Logo_frmMainScreen As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents Back_Button As System.Windows.Forms.Button
End Class
