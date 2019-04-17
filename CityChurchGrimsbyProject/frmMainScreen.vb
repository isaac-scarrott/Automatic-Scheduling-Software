Public Class frmMainScreen
    Dim con As New OleDb.OleDbConnection
    Dim dbProvider As String
    Dim dbSource As String
    Dim ds As New DataSet
    Dim da As New OleDb.OleDbDataAdapter
    Dim MaxRows As Integer
    Dim sql As String
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Hide()
        SelectedUser = 0
        frmLoginScreen.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Rota_Button.Click
        Hide()
        FrmRota.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Volunteers_Button.Click
        Hide()
        FrmVolunteers.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Jobs_Button.Click
        Hide()
        FrmJobs.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Unavailability_Button.Click
        Hide()
        FrmUnavailability.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Statistics_Button.Click
        Hide()
        frmStatisticsSelection.Show()
    End Sub

    Private Sub frmMainScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dbProvider As String
        Dim dbSource As String

        dbProvider = "PROVIDER=Microsoft.Jet.OLEDB.4.0;"
        dbSource = "Data Source=CityChurchGrimsbyDatabase.mdb"

        con.ConnectionString = dbProvider & dbSource 'Tells vb the provider And source Of the database

        sql = "Select * From Jobs" 'Uses and SQL statement to select the Login form
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "Jobs") 'Fills the data adapter with the data set and calls it jobs

        MaxRows = ds.Tables("Jobs").Rows.Count 'Counts the number of row in the jobs table

        For x = 0 To MaxRows - 1

        Next


    End Sub
End Class