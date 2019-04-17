<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmUnavailabilityLoad
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUnavailabilityLoad))
        Me.LastName_Text = New System.Windows.Forms.TextBox()
        Me.FirstName_Text = New System.Windows.Forms.TextBox()
        Me.LaswtName_Label = New System.Windows.Forms.Label()
        Me.FirstName_Label = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Logo_frmMainScreen = New System.Windows.Forms.PictureBox()
        Me.Back = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Update_btn = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.Logo_frmMainScreen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LastName_Text
        '
        Me.LastName_Text.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.LastName_Text.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.LastName_Text.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LastName_Text.Location = New System.Drawing.Point(96, 107)
        Me.LastName_Text.Name = "LastName_Text"
        Me.LastName_Text.ReadOnly = True
        Me.LastName_Text.Size = New System.Drawing.Size(120, 20)
        Me.LastName_Text.TabIndex = 22
        '
        'FirstName_Text
        '
        Me.FirstName_Text.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.FirstName_Text.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.FirstName_Text.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.FirstName_Text.Location = New System.Drawing.Point(96, 79)
        Me.FirstName_Text.Name = "FirstName_Text"
        Me.FirstName_Text.ReadOnly = True
        Me.FirstName_Text.Size = New System.Drawing.Size(120, 20)
        Me.FirstName_Text.TabIndex = 21
        '
        'LaswtName_Label
        '
        Me.LaswtName_Label.AutoSize = True
        Me.LaswtName_Label.Location = New System.Drawing.Point(32, 110)
        Me.LaswtName_Label.Name = "LaswtName_Label"
        Me.LaswtName_Label.Size = New System.Drawing.Size(58, 13)
        Me.LaswtName_Label.TabIndex = 20
        Me.LaswtName_Label.Text = "Last Name"
        '
        'FirstName_Label
        '
        Me.FirstName_Label.AutoSize = True
        Me.FirstName_Label.Location = New System.Drawing.Point(33, 79)
        Me.FirstName_Label.Name = "FirstName_Label"
        Me.FirstName_Label.Size = New System.Drawing.Size(57, 13)
        Me.FirstName_Label.TabIndex = 19
        Me.FirstName_Label.Text = "First Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label1.Location = New System.Drawing.Point(72, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 20)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Volunteers"
        '
        'Logo_frmMainScreen
        '
        Me.Logo_frmMainScreen.Image = CType(resources.GetObject("Logo_frmMainScreen.Image"), System.Drawing.Image)
        Me.Logo_frmMainScreen.Location = New System.Drawing.Point(1, 1)
        Me.Logo_frmMainScreen.Name = "Logo_frmMainScreen"
        Me.Logo_frmMainScreen.Size = New System.Drawing.Size(54, 56)
        Me.Logo_frmMainScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Logo_frmMainScreen.TabIndex = 17
        Me.Logo_frmMainScreen.TabStop = False
        '
        'Back
        '
        Me.Back.Location = New System.Drawing.Point(175, 13)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(41, 23)
        Me.Back.TabIndex = 16
        Me.Back.Text = "Back"
        Me.Back.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 144)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Unavailability"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(96, 144)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 95)
        Me.ListBox1.TabIndex = 24
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(-2, 252)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 13)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Add Unavailability"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(96, 249)
        Me.DateTimePicker1.MinDate = New Date(2016, 1, 22, 0, 0, 0, 0)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(120, 20)
        Me.DateTimePicker1.TabIndex = 26
        '
        'Update_btn
        '
        Me.Update_btn.Location = New System.Drawing.Point(161, 272)
        Me.Update_btn.Name = "Update_btn"
        Me.Update_btn.Size = New System.Drawing.Size(55, 23)
        Me.Update_btn.TabIndex = 27
        Me.Update_btn.Text = "Add"
        Me.Update_btn.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(103, 272)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(55, 23)
        Me.Button1.TabIndex = 28
        Me.Button1.Text = "Delete"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmUnavailabilityLoad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(228, 303)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Update_btn)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LastName_Text)
        Me.Controls.Add(Me.FirstName_Text)
        Me.Controls.Add(Me.LaswtName_Label)
        Me.Controls.Add(Me.FirstName_Label)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Logo_frmMainScreen)
        Me.Controls.Add(Me.Back)
        Me.Name = "frmUnavailabilityLoad"
        Me.Text = "frmUnavailabilityLoad"
        CType(Me.Logo_frmMainScreen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LastName_Text As TextBox
    Friend WithEvents FirstName_Text As TextBox
    Friend WithEvents LaswtName_Label As Label
    Friend WithEvents FirstName_Label As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Logo_frmMainScreen As PictureBox
    Friend WithEvents Back As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Update_btn As Button
    Friend WithEvents Button1 As Button
End Class
