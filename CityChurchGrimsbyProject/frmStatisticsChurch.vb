Public Class frmStatisticsChurch
    Dim con As New OleDb.OleDbConnection
    Dim dbProvider As String
    Dim dbSource As String
    Dim ds As New DataSet
    Dim da As New OleDb.OleDbDataAdapter
    Dim MaxRows As Integer
    Dim MaxRows2 As Integer
    Dim sql As String
    Dim cb As New OleDb.OleDbCommandBuilder(da)
    Private Sub Back_Button_Click(sender As Object, e As EventArgs) Handles Back_Button.Click
        Hide()
        frmStatisticsSelection.Show()
    End Sub

    Private Sub frmStatisticsChurch_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim con As New OleDb.OleDbConnection

        Dim dbProvider As String
        Dim dbSource As String

        dbProvider = "PROVIDER=Microsoft.Jet.OLEDB.4.0;"
        dbSource = "Data Source=CityChurchGrimsbyDatabase.mdb"

        con.ConnectionString = dbProvider & dbSource

        con.Open()

        sql = "Select * From Volunteer" 'Uses and SQL statement to select the volunteer table
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "Volunteer") 'Fills the data adapter with the data set and calls it volunteer

        MaxRows = ds.Tables("Volunteer").Rows.Count

        sql = "Select * From VolunteerJobs" 'Uses and SQL statement to select the volunteer table
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "VolunteerJobs") 'Fills the data adapter with the data set and calls it volunteer

        MaxRows2 = ds.Tables("VolunteerJobs").Rows.Count

        sql = "Select * From ChurchStatistics" 'Uses and SQL statement to select the volunteer table
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "ChurchStatistics") 'Fills the data adapter with the data set and calls it volunteer

        cb = New OleDb.OleDbCommandBuilder(da)

        ds.Tables("ChurchStatistics").Rows(0).Item(2) = MaxRows2 / MaxRows


        cb = New OleDb.OleDbCommandBuilder(da)

        da.Update(ds, "ChurchStatistics") 'Updates the database with the selected infomation

        Dim dt As New DataTable

        ds.Tables.Add(dt)

        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(dt) 'Fills the data adapter with the data set and calls it jobs



        DataGridView1.DataSource = dt.DefaultView


    End Sub
End Class