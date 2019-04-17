Public Class frmStatisticsSelection

    Private Sub Back_Button_Click(sender As Object, e As EventArgs) Handles Back_Button.Click
        Hide()
        frmMainScreen.Show()
    End Sub

    Private Sub Modify_Button_Click(sender As Object, e As EventArgs) Handles Modify_Button.Click
        If RadioButton1.Checked Then 'If this radio button is checked then this will run
            Close()
            frmStatisticsVolunteerSelection.Show()
        ElseIf RadioButton2.Checked Then 'If this radio button is checked then this will run
            Close()
            frmStatisticsChurch.Show()
        End If
    End Sub

    Private Sub frmStatisticsSelection_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class