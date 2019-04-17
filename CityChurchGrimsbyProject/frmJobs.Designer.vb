<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmJobs
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmJobs))
        Me.Logo_frmMainScreen = New System.Windows.Forms.PictureBox()
        Me.Back_Button = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Name_Label = New System.Windows.Forms.Label()
        Me.Description_Label = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ID_Text = New System.Windows.Forms.TextBox()
        Me.Description_text = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Name_text = New System.Windows.Forms.TextBox()
        Me.Update_btn = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Week_text = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
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
        Me.Back_Button.Location = New System.Drawing.Point(216, 19)
        Me.Back_Button.Name = "Back_Button"
        Me.Back_Button.Size = New System.Drawing.Size(41, 23)
        Me.Back_Button.TabIndex = 9
        Me.Back_Button.Text = "Back"
        Me.Back_Button.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label1.Location = New System.Drawing.Point(107, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 24)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Jobs"
        '
        'Name_Label
        '
        Me.Name_Label.AutoSize = True
        Me.Name_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name_Label.Location = New System.Drawing.Point(37, 62)
        Me.Name_Label.Name = "Name_Label"
        Me.Name_Label.Size = New System.Drawing.Size(51, 20)
        Me.Name_Label.TabIndex = 12
        Me.Name_Label.Text = "Name"
        '
        'Description_Label
        '
        Me.Description_Label.AutoSize = True
        Me.Description_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Description_Label.Location = New System.Drawing.Point(-1, 82)
        Me.Description_Label.Name = "Description_Label"
        Me.Description_Label.Size = New System.Drawing.Size(89, 20)
        Me.Description_Label.TabIndex = 13
        Me.Description_Label.Text = "Description"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(62, 132)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 20)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "ID"
        '
        'ID_Text
        '
        Me.ID_Text.BackColor = System.Drawing.Color.White
        Me.ID_Text.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ID_Text.Location = New System.Drawing.Point(94, 134)
        Me.ID_Text.Name = "ID_Text"
        Me.ID_Text.Size = New System.Drawing.Size(100, 13)
        Me.ID_Text.TabIndex = 16
        '
        'Description_text
        '
        Me.Description_text.Location = New System.Drawing.Point(94, 83)
        Me.Description_text.Name = "Description_text"
        Me.Description_text.Size = New System.Drawing.Size(100, 20)
        Me.Description_text.TabIndex = 17
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(200, 101)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(56, 23)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Create"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(200, 59)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(56, 23)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "Load"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(201, 157)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(56, 23)
        Me.Button3.TabIndex = 20
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Name_text
        '
        Me.Name_text.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.Name_text.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.Name_text.Location = New System.Drawing.Point(94, 62)
        Me.Name_text.Name = "Name_text"
        Me.Name_text.Size = New System.Drawing.Size(100, 20)
        Me.Name_text.TabIndex = 21
        '
        'Update_btn
        '
        Me.Update_btn.Location = New System.Drawing.Point(138, 157)
        Me.Update_btn.Name = "Update_btn"
        Me.Update_btn.Size = New System.Drawing.Size(56, 23)
        Me.Update_btn.TabIndex = 22
        Me.Update_btn.Text = "Update"
        Me.Update_btn.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 20)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Per Week"
        '
        'Week_text
        '
        Me.Week_text.Location = New System.Drawing.Point(94, 104)
        Me.Week_text.Name = "Week_text"
        Me.Week_text.Size = New System.Drawing.Size(100, 20)
        Me.Week_text.TabIndex = 24
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(3, 157)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(56, 23)
        Me.Button4.TabIndex = 25
        Me.Button4.Text = "View All"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'FrmJobs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(269, 188)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Week_text)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Update_btn)
        Me.Controls.Add(Me.Name_text)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Description_text)
        Me.Controls.Add(Me.ID_Text)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Description_Label)
        Me.Controls.Add(Me.Name_Label)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Logo_frmMainScreen)
        Me.Controls.Add(Me.Back_Button)
        Me.Name = "FrmJobs"
        Me.Text = "Jobs"
        CType(Me.Logo_frmMainScreen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Logo_frmMainScreen As System.Windows.Forms.PictureBox
    Friend WithEvents Back_Button As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Name_Label As Label
    Friend WithEvents Description_Label As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ID_Text As TextBox
    Friend WithEvents Description_text As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Name_text As TextBox
    Friend WithEvents Update_btn As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Week_text As TextBox
    Friend WithEvents Button4 As Button
End Class
