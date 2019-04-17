<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStatisticsChosenVolunteer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStatisticsChosenVolunteer))
        Me.Back_Button = New System.Windows.Forms.Button()
        Me.Logo_frmMainScreen = New System.Windows.Forms.PictureBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.Logo_frmMainScreen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Back_Button
        '
        Me.Back_Button.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Back_Button.Location = New System.Drawing.Point(12, 196)
        Me.Back_Button.Name = "Back_Button"
        Me.Back_Button.Size = New System.Drawing.Size(41, 23)
        Me.Back_Button.TabIndex = 30
        Me.Back_Button.Text = "Back"
        Me.Back_Button.UseVisualStyleBackColor = False
        '
        'Logo_frmMainScreen
        '
        Me.Logo_frmMainScreen.Image = CType(resources.GetObject("Logo_frmMainScreen.Image"), System.Drawing.Image)
        Me.Logo_frmMainScreen.Location = New System.Drawing.Point(-1, -1)
        Me.Logo_frmMainScreen.Name = "Logo_frmMainScreen"
        Me.Logo_frmMainScreen.Size = New System.Drawing.Size(88, 86)
        Me.Logo_frmMainScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Logo_frmMainScreen.TabIndex = 31
        Me.Logo_frmMainScreen.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(13, 108)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(364, 82)
        Me.DataGridView1.TabIndex = 32
        '
        'frmStatisticsChosenVolunteer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(389, 231)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Logo_frmMainScreen)
        Me.Controls.Add(Me.Back_Button)
        Me.Name = "frmStatisticsChosenVolunteer"
        Me.Text = "frmStatisticsChosenVolunteer"
        CType(Me.Logo_frmMainScreen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Back_Button As System.Windows.Forms.Button
    Friend WithEvents Logo_frmMainScreen As System.Windows.Forms.PictureBox
    Friend WithEvents DataGridView1 As DataGridView
End Class
