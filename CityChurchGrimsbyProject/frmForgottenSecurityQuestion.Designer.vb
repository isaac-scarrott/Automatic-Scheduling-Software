<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmForgottenSecurityQuestion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmForgottenSecurityQuestion))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Logo_frmMainScreen = New System.Windows.Forms.PictureBox()
        Me.Username_Label = New System.Windows.Forms.Label()
        Me.Username_text = New System.Windows.Forms.TextBox()
        Me.Load_btn = New System.Windows.Forms.Button()
        Me.Question_Label = New System.Windows.Forms.Label()
        Me.Question_Text = New System.Windows.Forms.TextBox()
        Me.Answer_Text = New System.Windows.Forms.TextBox()
        Me.Answer_Label = New System.Windows.Forms.Label()
        Me.Submit_btn = New System.Windows.Forms.Button()
        Me.Back_btn = New System.Windows.Forms.Button()
        CType(Me.Logo_frmMainScreen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label3.Location = New System.Drawing.Point(94, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(186, 25)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Forgotten Password"
        '
        'Logo_frmMainScreen
        '
        Me.Logo_frmMainScreen.Image = CType(resources.GetObject("Logo_frmMainScreen.Image"), System.Drawing.Image)
        Me.Logo_frmMainScreen.Location = New System.Drawing.Point(0, 0)
        Me.Logo_frmMainScreen.Name = "Logo_frmMainScreen"
        Me.Logo_frmMainScreen.Size = New System.Drawing.Size(88, 86)
        Me.Logo_frmMainScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Logo_frmMainScreen.TabIndex = 16
        Me.Logo_frmMainScreen.TabStop = False
        '
        'Username_Label
        '
        Me.Username_Label.AutoSize = True
        Me.Username_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Username_Label.Location = New System.Drawing.Point(12, 102)
        Me.Username_Label.Name = "Username_Label"
        Me.Username_Label.Size = New System.Drawing.Size(83, 20)
        Me.Username_Label.TabIndex = 18
        Me.Username_Label.Text = "Username"
        '
        'Username_text
        '
        Me.Username_text.Location = New System.Drawing.Point(99, 101)
        Me.Username_text.Name = "Username_text"
        Me.Username_text.Size = New System.Drawing.Size(120, 20)
        Me.Username_text.TabIndex = 19
        '
        'Load_btn
        '
        Me.Load_btn.Location = New System.Drawing.Point(225, 102)
        Me.Load_btn.Name = "Load_btn"
        Me.Load_btn.Size = New System.Drawing.Size(47, 21)
        Me.Load_btn.TabIndex = 20
        Me.Load_btn.Text = "Load"
        Me.Load_btn.UseVisualStyleBackColor = True
        '
        'Question_Label
        '
        Me.Question_Label.AutoSize = True
        Me.Question_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Question_Label.Location = New System.Drawing.Point(22, 133)
        Me.Question_Label.Name = "Question_Label"
        Me.Question_Label.Size = New System.Drawing.Size(73, 20)
        Me.Question_Label.TabIndex = 21
        Me.Question_Label.Text = "Question"
        '
        'Question_Text
        '
        Me.Question_Text.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Question_Text.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Question_Text.Location = New System.Drawing.Point(99, 138)
        Me.Question_Text.Name = "Question_Text"
        Me.Question_Text.ReadOnly = True
        Me.Question_Text.Size = New System.Drawing.Size(173, 13)
        Me.Question_Text.TabIndex = 23
        '
        'Answer_Text
        '
        Me.Answer_Text.Location = New System.Drawing.Point(99, 162)
        Me.Answer_Text.Name = "Answer_Text"
        Me.Answer_Text.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9899)
        Me.Answer_Text.Size = New System.Drawing.Size(173, 20)
        Me.Answer_Text.TabIndex = 21
        '
        'Answer_Label
        '
        Me.Answer_Label.AutoSize = True
        Me.Answer_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Answer_Label.Location = New System.Drawing.Point(31, 162)
        Me.Answer_Label.Name = "Answer_Label"
        Me.Answer_Label.Size = New System.Drawing.Size(62, 20)
        Me.Answer_Label.TabIndex = 23
        Me.Answer_Label.Text = "Answer"
        '
        'Submit_btn
        '
        Me.Submit_btn.Location = New System.Drawing.Point(225, 196)
        Me.Submit_btn.Name = "Submit_btn"
        Me.Submit_btn.Size = New System.Drawing.Size(47, 21)
        Me.Submit_btn.TabIndex = 22
        Me.Submit_btn.Text = "Submit"
        Me.Submit_btn.UseVisualStyleBackColor = True
        '
        'Back_btn
        '
        Me.Back_btn.Location = New System.Drawing.Point(12, 196)
        Me.Back_btn.Name = "Back_btn"
        Me.Back_btn.Size = New System.Drawing.Size(47, 21)
        Me.Back_btn.TabIndex = 26
        Me.Back_btn.Text = "Back"
        Me.Back_btn.UseVisualStyleBackColor = True
        '
        'frmForgottenSecurityQuestion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(284, 224)
        Me.Controls.Add(Me.Back_btn)
        Me.Controls.Add(Me.Submit_btn)
        Me.Controls.Add(Me.Answer_Text)
        Me.Controls.Add(Me.Answer_Label)
        Me.Controls.Add(Me.Question_Text)
        Me.Controls.Add(Me.Question_Label)
        Me.Controls.Add(Me.Load_btn)
        Me.Controls.Add(Me.Username_text)
        Me.Controls.Add(Me.Username_Label)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Logo_frmMainScreen)
        Me.Name = "frmForgottenSecurityQuestion"
        Me.Text = "frmForgottenSecurityQuestion"
        CType(Me.Logo_frmMainScreen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Logo_frmMainScreen As PictureBox
    Friend WithEvents Username_Label As Label
    Friend WithEvents Username_text As TextBox
    Friend WithEvents Load_btn As Button
    Friend WithEvents Question_Label As Label
    Friend WithEvents Question_Text As TextBox
    Friend WithEvents Answer_Text As TextBox
    Friend WithEvents Answer_Label As Label
    Friend WithEvents Submit_btn As Button
    Friend WithEvents Back_btn As Button
End Class
