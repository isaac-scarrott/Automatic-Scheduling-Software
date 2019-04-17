<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVolunteers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmVolunteers))
        Me.Logo_frmMainScreen = New System.Windows.Forms.PictureBox()
        Me.Back = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FirstName_Label = New System.Windows.Forms.Label()
        Me.LaswtName_Label = New System.Windows.Forms.Label()
        Me.FirstName_Text = New System.Windows.Forms.TextBox()
        Me.LastName_Text = New System.Windows.Forms.TextBox()
        Me.Load_Btn = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
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
        'Back
        '
        Me.Back.Location = New System.Drawing.Point(238, 15)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(41, 23)
        Me.Back.TabIndex = 20
        Me.Back.Text = "Back"
        Me.Back.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label1.Location = New System.Drawing.Point(121, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 20)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Volunteers"
        '
        'FirstName_Label
        '
        Me.FirstName_Label.AutoSize = True
        Me.FirstName_Label.Location = New System.Drawing.Point(18, 81)
        Me.FirstName_Label.Name = "FirstName_Label"
        Me.FirstName_Label.Size = New System.Drawing.Size(10, 13)
        Me.FirstName_Label.TabIndex = 12
        Me.FirstName_Label.Text = " "
        '
        'LaswtName_Label
        '
        Me.LaswtName_Label.AutoSize = True
        Me.LaswtName_Label.Location = New System.Drawing.Point(17, 112)
        Me.LaswtName_Label.Name = "LaswtName_Label"
        Me.LaswtName_Label.Size = New System.Drawing.Size(58, 13)
        Me.LaswtName_Label.TabIndex = 13
        Me.LaswtName_Label.Text = "Last Name"
        '
        'FirstName_Text
        '
        Me.FirstName_Text.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.FirstName_Text.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.FirstName_Text.Location = New System.Drawing.Point(82, 81)
        Me.FirstName_Text.Name = "FirstName_Text"
        Me.FirstName_Text.Size = New System.Drawing.Size(125, 20)
        Me.FirstName_Text.TabIndex = 14
        '
        'LastName_Text
        '
        Me.LastName_Text.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.LastName_Text.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.LastName_Text.Location = New System.Drawing.Point(82, 109)
        Me.LastName_Text.Name = "LastName_Text"
        Me.LastName_Text.Size = New System.Drawing.Size(125, 20)
        Me.LastName_Text.TabIndex = 15
        '
        'Load_Btn
        '
        Me.Load_Btn.Location = New System.Drawing.Point(227, 106)
        Me.Load_Btn.Name = "Load_Btn"
        Me.Load_Btn.Size = New System.Drawing.Size(52, 23)
        Me.Load_Btn.TabIndex = 16
        Me.Load_Btn.Text = "Load"
        Me.Load_Btn.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(227, 78)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(52, 23)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Create"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "First Name"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(227, 135)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(52, 23)
        Me.Button2.TabIndex = 21
        Me.Button2.Text = "View All"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'FrmVolunteers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(287, 160)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Load_Btn)
        Me.Controls.Add(Me.LastName_Text)
        Me.Controls.Add(Me.FirstName_Text)
        Me.Controls.Add(Me.LaswtName_Label)
        Me.Controls.Add(Me.FirstName_Label)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Logo_frmMainScreen)
        Me.Controls.Add(Me.Back)
        Me.Name = "FrmVolunteers"
        Me.Text = "Volunteers"
        CType(Me.Logo_frmMainScreen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Logo_frmMainScreen As System.Windows.Forms.PictureBox
    Friend WithEvents Back As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents FirstName_Label As Label
    Friend WithEvents LaswtName_Label As Label
    Friend WithEvents FirstName_Text As TextBox
    Friend WithEvents LastName_Text As TextBox
    Friend WithEvents Load_Btn As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
End Class
