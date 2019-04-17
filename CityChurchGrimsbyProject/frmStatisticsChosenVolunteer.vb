Public Class frmStatisticsChosenVolunteer
    Public Shared Property VolID As Integer
    Dim con As New OleDb.OleDbConnection
    Dim dbProvider As String
    Dim dbSource As String
    Dim ds As New DataSet
    Dim da As New OleDb.OleDbDataAdapter
    Dim MaxRows As Integer
    Dim sql As String
    Dim Row As Integer
    Private Sub Back_Button_Click(sender As Object, e As EventArgs) Handles Back_Button.Click
        Hide()
        frmStatisticsVolunteerSelection.Show()
    End Sub

    Private Sub frmStatisticsChosenVolunteer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con As New OleDb.OleDbConnection

        Dim dbProvider As String
        Dim dbSource As String

        dbProvider = "PROVIDER=Microsoft.Jet.OLEDB.4.0;"
        dbSource = "Data Source=CityChurchGrimsbyDatabase.mdb"

        con.ConnectionString = dbProvider & dbSource

        con.Open() 'Opens the connection

        Dim dt As New DataTable

        ds.Tables.Add(dt) 'Create a new data table
        sql = "Select * From VolunteerStatistics WHERE ID = " & VolID 'Uses and SQL statement to select the volunteer table
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(dt) 'Fills the data adapter with the data set and calls it jobs



        DataGridView1.DataSource = dt.DefaultView 'Fills the data table

    End Sub
End Class