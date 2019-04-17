<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUnavailability
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmUnavailability))
        Me.Logo_frmMainScreen = New System.Windows.Forms.PictureBox()
        Me.Back_Button = New System.Windows.Forms.Button()
        Me.MainScreen_Text = New System.Windows.Forms.Label()
        Me.Volunteer_Label = New System.Windows.Forms.Label()
        Me.FirstName_Text = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LastName_Text = New System.Windows.Forms.TextBox()
        Me.Load_btn = New System.Windows.Forms.Button()
        CType(Me.Logo_frmMainScreen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Logo_frmMainScreen
        '
        Me.Logo_frmMainScreen.Image = CType(resources.GetObject("Logo_frmMainScreen.Image"), System.Drawing.Image)
        Me.Logo_frmMainScreen.Location = New System.Drawing.Point(3, 3)
        Me.Logo_frmMainScreen.Name = "Logo_frmMainScreen"
        Me.Logo_frmMainScreen.Size = New System.Drawing.Size(54, 56)
        Me.Logo_frmMainScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Logo_frmMainScreen.TabIndex = 10
        Me.Logo_frmMainScreen.TabStop = False
        '
        'Back_Button
        '
        Me.Back_Button.Location = New System.Drawing.Point(199, 12)
        Me.Back_Button.Name = "Back_Button"
        Me.Back_Button.Size = New System.Drawing.Size(41, 23)
        Me.Back_Button.TabIndex = 9
        Me.Back_Button.Text = "Back"
        Me.Back_Button.UseVisualStyleBackColor = True
        '
        'MainScreen_Text
        '
        Me.MainScreen_Text.AutoSize = True
        Me.MainScreen_Text.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainScreen_Text.ForeColor = System.Drawing.Color.DodgerBlue
        Me.MainScreen_Text.Location = New System.Drawing.Point(64, 12)
        Me.MainScreen_Text.Name = "MainScreen_Text"
        Me.MainScreen_Text.Size = New System.Drawing.Size(117, 24)
        Me.MainScreen_Text.TabIndex = 12
        Me.MainScreen_Text.Text = "Unavailability"
        '
        'Volunteer_Label
        '
        Me.Volunteer_Label.AutoSize = True
        Me.Volunteer_Label.Location = New System.Drawing.Point(3, 81)
        Me.Volunteer_Label.Name = "Volunteer_Label"
        Me.Volunteer_Label.Size = New System.Drawing.Size(57, 13)
        Me.Volunteer_Label.TabIndex = 14
        Me.Volunteer_Label.Text = "First Name"
        '
        'FirstName_Text
        '
        Me.FirstName_Text.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.FirstName_Text.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.FirstName_Text.Location = New System.Drawing.Point(66, 78)
        Me.FirstName_Text.Name = "FirstName_Text"
        Me.FirstName_Text.Size = New System.Drawing.Size(115, 20)
        Me.FirstName_Text.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 111)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Last Name"
        '
        'LastName_Text
        '
        Me.LastName_Text.Location = New System.Drawing.Point(66, 108)
        Me.LastName_Text.Name = "LastName_Text"
        Me.LastName_Text.Size = New System.Drawing.Size(115, 20)
        Me.LastName_Text.TabIndex = 17
        '
        'Load_btn
        '
        Me.Load_btn.Location = New System.Drawing.Point(199, 106)
        Me.Load_btn.Name = "Load_btn"
        Me.Load_btn.Size = New System.Drawing.Size(41, 23)
        Me.Load_btn.TabIndex = 19
        Me.Load_btn.Text = "Load"
        Me.Load_btn.UseVisualStyleBackColor = True
        '
        'FrmUnavailability
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(249, 141)
        Me.Controls.Add(Me.Load_btn)
        Me.Controls.Add(Me.LastName_Text)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.FirstName_Text)
        Me.Controls.Add(Me.Volunteer_Label)
        Me.Controls.Add(Me.MainScreen_Text)
        Me.Controls.Add(Me.Logo_frmMainScreen)
        Me.Controls.Add(Me.Back_Button)
        Me.Name = "FrmUnavailability"
        Me.Text = "Unavailability"
        CType(Me.Logo_frmMainScreen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Logo_frmMainScreen As System.Windows.Forms.PictureBox
    Friend WithEvents Back_Button As System.Windows.Forms.Button
    Friend WithEvents MainScreen_Text As System.Windows.Forms.Label
    Friend WithEvents Volunteer_Label As Label
    Friend WithEvents FirstName_Text As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LastName_Text As TextBox
    Friend WithEvents Load_btn As Button
End Class
