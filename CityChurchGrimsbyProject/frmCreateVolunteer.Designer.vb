<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCreateVolunteer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCreateVolunteer))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.JobQualified_ListBox = New System.Windows.Forms.ListBox()
        Me.MaxTimesOn_Text = New System.Windows.Forms.TextBox()
        Me.EmailAddress_Text = New System.Windows.Forms.TextBox()
        Me.PhoneNumber_Text = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Back_Button = New System.Windows.Forms.Button()
        Me.Modify_Button = New System.Windows.Forms.Button()
        Me.LastName_TextBox = New System.Windows.Forms.TextBox()
        Me.FirstName_TextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FirstName_Label = New System.Windows.Forms.Label()
        Me.MainScreen_Text = New System.Windows.Forms.Label()
        Me.Logo_frmMainScreen = New System.Windows.Forms.PictureBox()
        Me.DOB_Text = New System.Windows.Forms.DateTimePicker()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Logo_frmMainScreen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(39, 304)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(58, 23)
        Me.Button1.TabIndex = 62
        Me.Button1.Text = "Add Job"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(14, 264)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 13)
        Me.Label7.TabIndex = 60
        Me.Label7.Text = "Job Name"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(9, 260)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(115, 72)
        Me.PictureBox1.TabIndex = 59
        Me.PictureBox1.TabStop = False
        '
        'JobQualified_ListBox
        '
        Me.JobQualified_ListBox.FormattingEnabled = True
        Me.JobQualified_ListBox.Location = New System.Drawing.Point(130, 236)
        Me.JobQualified_ListBox.Name = "JobQualified_ListBox"
        Me.JobQualified_ListBox.Size = New System.Drawing.Size(140, 134)
        Me.JobQualified_ListBox.TabIndex = 58
        '
        'MaxTimesOn_Text
        '
        Me.MaxTimesOn_Text.Location = New System.Drawing.Point(132, 376)
        Me.MaxTimesOn_Text.Name = "MaxTimesOn_Text"
        Me.MaxTimesOn_Text.Size = New System.Drawing.Size(138, 20)
        Me.MaxTimesOn_Text.TabIndex = 57
        '
        'EmailAddress_Text
        '
        Me.EmailAddress_Text.Location = New System.Drawing.Point(130, 205)
        Me.EmailAddress_Text.Name = "EmailAddress_Text"
        Me.EmailAddress_Text.Size = New System.Drawing.Size(138, 20)
        Me.EmailAddress_Text.TabIndex = 55
        '
        'PhoneNumber_Text
        '
        Me.PhoneNumber_Text.Location = New System.Drawing.Point(130, 171)
        Me.PhoneNumber_Text.Name = "PhoneNumber_Text"
        Me.PhoneNumber_Text.Size = New System.Drawing.Size(138, 20)
        Me.PhoneNumber_Text.TabIndex = 54
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(7, 406)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 20)
        Me.Label6.TabIndex = 53
        Me.Label6.Text = "Date of Birth"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(5, 376)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 20)
        Me.Label5.TabIndex = 52
        Me.Label5.Text = "Max Times On"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 236)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 20)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "Jobs Qualified"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 203)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 20)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "Email Address"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 171)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 20)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "Phone Number"
        '
        'Back_Button
        '
        Me.Back_Button.Location = New System.Drawing.Point(11, 446)
        Me.Back_Button.Name = "Back_Button"
        Me.Back_Button.Size = New System.Drawing.Size(41, 23)
        Me.Back_Button.TabIndex = 48
        Me.Back_Button.Text = "Back"
        Me.Back_Button.UseVisualStyleBackColor = True
        '
        'Modify_Button
        '
        Me.Modify_Button.Location = New System.Drawing.Point(218, 446)
        Me.Modify_Button.Name = "Modify_Button"
        Me.Modify_Button.Size = New System.Drawing.Size(52, 23)
        Me.Modify_Button.TabIndex = 47
        Me.Modify_Button.Text = "Create"
        Me.Modify_Button.UseVisualStyleBackColor = True
        '
        'LastName_TextBox
        '
        Me.LastName_TextBox.Location = New System.Drawing.Point(130, 138)
        Me.LastName_TextBox.Name = "LastName_TextBox"
        Me.LastName_TextBox.Size = New System.Drawing.Size(138, 20)
        Me.LastName_TextBox.TabIndex = 46
        '
        'FirstName_TextBox
        '
        Me.FirstName_TextBox.Location = New System.Drawing.Point(130, 103)
        Me.FirstName_TextBox.Name = "FirstName_TextBox"
        Me.FirstName_TextBox.Size = New System.Drawing.Size(138, 20)
        Me.FirstName_TextBox.TabIndex = 45
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 138)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 20)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Last Name"
        '
        'FirstName_Label
        '
        Me.FirstName_Label.AutoSize = True
        Me.FirstName_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FirstName_Label.Location = New System.Drawing.Point(3, 103)
        Me.FirstName_Label.Name = "FirstName_Label"
        Me.FirstName_Label.Size = New System.Drawing.Size(86, 20)
        Me.FirstName_Label.TabIndex = 43
        Me.FirstName_Label.Text = "First Name"
        '
        'MainScreen_Text
        '
        Me.MainScreen_Text.AutoSize = True
        Me.MainScreen_Text.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainScreen_Text.ForeColor = System.Drawing.Color.DodgerBlue
        Me.MainScreen_Text.Location = New System.Drawing.Point(95, 31)
        Me.MainScreen_Text.Name = "MainScreen_Text"
        Me.MainScreen_Text.Size = New System.Drawing.Size(194, 29)
        Me.MainScreen_Text.TabIndex = 42
        Me.MainScreen_Text.Text = "Create Volunteer"
        '
        'Logo_frmMainScreen
        '
        Me.Logo_frmMainScreen.Image = CType(resources.GetObject("Logo_frmMainScreen.Image"), System.Drawing.Image)
        Me.Logo_frmMainScreen.Location = New System.Drawing.Point(1, 2)
        Me.Logo_frmMainScreen.Name = "Logo_frmMainScreen"
        Me.Logo_frmMainScreen.Size = New System.Drawing.Size(88, 86)
        Me.Logo_frmMainScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Logo_frmMainScreen.TabIndex = 41
        Me.Logo_frmMainScreen.TabStop = False
        '
        'DOB_Text
        '
        Me.DOB_Text.Location = New System.Drawing.Point(132, 406)
        Me.DOB_Text.MaxDate = New Date(2016, 1, 26, 0, 0, 0, 0)
        Me.DOB_Text.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.DOB_Text.Name = "DOB_Text"
        Me.DOB_Text.Size = New System.Drawing.Size(138, 20)
        Me.DOB_Text.TabIndex = 63
        Me.DOB_Text.Value = New Date(2016, 1, 26, 0, 0, 0, 0)
        '
        'ComboBox1
        '
        Me.ComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(14, 281)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(106, 21)
        Me.ComboBox1.TabIndex = 64
        '
        'frmCreateVolunteer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(288, 471)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.DOB_Text)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.JobQualified_ListBox)
        Me.Controls.Add(Me.MaxTimesOn_Text)
        Me.Controls.Add(Me.EmailAddress_Text)
        Me.Controls.Add(Me.PhoneNumber_Text)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Back_Button)
        Me.Controls.Add(Me.Modify_Button)
        Me.Controls.Add(Me.LastName_TextBox)
        Me.Controls.Add(Me.FirstName_TextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.FirstName_Label)
        Me.Controls.Add(Me.MainScreen_Text)
        Me.Controls.Add(Me.Logo_frmMainScreen)
        Me.Name = "frmCreateVolunteer"
        Me.Text = "frmCreateVolunteer"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Logo_frmMainScreen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents JobQualified_ListBox As ListBox
    Friend WithEvents MaxTimesOn_Text As TextBox
    Friend WithEvents EmailAddress_Text As TextBox
    Friend WithEvents PhoneNumber_Text As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Back_Button As Button
    Friend WithEvents Modify_Button As Button
    Friend WithEvents LastName_TextBox As TextBox
    Friend WithEvents FirstName_TextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents FirstName_Label As Label
    Friend WithEvents MainScreen_Text As Label
    Friend WithEvents Logo_frmMainScreen As PictureBox
    Friend WithEvents DOB_Text As DateTimePicker
    Friend WithEvents ComboBox1 As ComboBox
End Class
