Public Class FrmRota

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back_Button.Click
        Hide()
        frmMainScreen.Show()
    End Sub



    Private Sub ViewRota_Button_Click(sender As Object, e As EventArgs) Handles ViewRota_Button.Click
        Hide()
        frmViewRota.Show()
    End Sub

    Private Sub NewRota_Button_Click(sender As Object, e As EventArgs) Handles NewRota_Button.Click
        Hide()
        frmNewRota.Show()
    End Sub

    Private Sub FrmRota_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class