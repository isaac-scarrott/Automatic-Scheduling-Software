<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStatisticsVolunteerSelection
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStatisticsVolunteerSelection))
        Me.MainScreen_Text = New System.Windows.Forms.Label()
        Me.Logo_frmMainScreen = New System.Windows.Forms.PictureBox()
        Me.Back_Button = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Load_Btn = New System.Windows.Forms.Button()
        Me.LastName_Text = New System.Windows.Forms.TextBox()
        Me.FirstName_Text = New System.Windows.Forms.TextBox()
        Me.LaswtName_Label = New System.Windows.Forms.Label()
        CType(Me.Logo_frmMainScreen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MainScreen_Text
        '
        Me.MainScreen_Text.AutoSize = True
        Me.MainScreen_Text.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainScreen_Text.ForeColor = System.Drawing.Color.DodgerBlue
        Me.MainScreen_Text.Location = New System.Drawing.Point(92, 28)
        Me.MainScreen_Text.Name = "MainScreen_Text"
        Me.MainScreen_Text.Size = New System.Drawing.Size(175, 24)
        Me.MainScreen_Text.TabIndex = 6
        Me.MainScreen_Text.Text = "Volunteer Selection"
        '
        'Logo_frmMainScreen
        '
        Me.Logo_frmMainScreen.Image = CType(resources.GetObject("Logo_frmMainScreen.Image"), System.Drawing.Image)
        Me.Logo_frmMainScreen.Location = New System.Drawing.Point(-2, -2)
        Me.Logo_frmMainScreen.Name = "Logo_frmMainScreen"
        Me.Logo_frmMainScreen.Size = New System.Drawing.Size(88, 86)
        Me.Logo_frmMainScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Logo_frmMainScreen.TabIndex = 5
        Me.Logo_frmMainScreen.TabStop = False
        '
        'Back_Button
        '
        Me.Back_Button.Location = New System.Drawing.Point(12, 147)
        Me.Back_Button.Name = "Back_Button"
        Me.Back_Button.Size = New System.Drawing.Size(41, 23)
        Me.Back_Button.TabIndex = 29
        Me.Back_Button.Text = "Back"
        Me.Back_Button.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "First Name"
        '
        'Load_Btn
        '
        Me.Load_Btn.Location = New System.Drawing.Point(215, 147)
        Me.Load_Btn.Name = "Load_Btn"
        Me.Load_Btn.Size = New System.Drawing.Size(52, 23)
        Me.Load_Btn.TabIndex = 33
        Me.Load_Btn.Text = "Load"
        Me.Load_Btn.UseVisualStyleBackColor = True
        '
        'LastName_Text
        '
        Me.LastName_Text.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.LastName_Text.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.LastName_Text.Location = New System.Drawing.Point(74, 121)
        Me.LastName_Text.Name = "LastName_Text"
        Me.LastName_Text.Size = New System.Drawing.Size(193, 20)
        Me.LastName_Text.TabIndex = 32
        '
        'FirstName_Text
        '
        Me.FirstName_Text.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.FirstName_Text.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.FirstName_Text.Location = New System.Drawing.Point(74, 93)
        Me.FirstName_Text.Name = "FirstName_Text"
        Me.FirstName_Text.Size = New System.Drawing.Size(193, 20)
        Me.FirstName_Text.TabIndex = 31
        '
        'LaswtName_Label
        '
        Me.LaswtName_Label.AutoSize = True
        Me.LaswtName_Label.Location = New System.Drawing.Point(9, 124)
        Me.LaswtName_Label.Name = "LaswtName_Label"
        Me.LaswtName_Label.Size = New System.Drawing.Size(58, 13)
        Me.LaswtName_Label.TabIndex = 30
        Me.LaswtName_Label.Text = "Last Name"
        '
        'frmStatisticsVolunteerSelection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(284, 175)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Load_Btn)
        Me.Controls.Add(Me.LastName_Text)
        Me.Controls.Add(Me.FirstName_Text)
        Me.Controls.Add(Me.LaswtName_Label)
        Me.Controls.Add(Me.Back_Button)
        Me.Controls.Add(Me.MainScreen_Text)
        Me.Controls.Add(Me.Logo_frmMainScreen)
        Me.Name = "frmStatisticsVolunteerSelection"
        Me.Text = "Select Volunteer"
        CType(Me.Logo_frmMainScreen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MainScreen_Text As System.Windows.Forms.Label
    Friend WithEvents Logo_frmMainScreen As System.Windows.Forms.PictureBox
    Friend WithEvents Back_Button As System.Windows.Forms.Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Load_Btn As Button
    Friend WithEvents LastName_Text As TextBox
    Friend WithEvents FirstName_Text As TextBox
    Friend WithEvents LaswtName_Label As Label
End Class
