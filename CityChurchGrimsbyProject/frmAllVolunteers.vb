Public Class frmAllVolunteers
    Dim con As New OleDb.OleDbConnection
    Dim dbProvider As String
    Dim dbSource As String
    Dim ds As New DataSet
    Dim da As New OleDb.OleDbDataAdapter
    Dim MaxRows As Integer
    Dim sql As String
    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        Close()
        FrmVolunteers.Show()
    End Sub

    Private Sub frmAllVolunteers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dbProvider As String
        Dim dbSource As String

        dbProvider = "PROVIDER=Microsoft.Jet.OLEDB.4.0;" 'The provider
        dbSource = "Data Source=CityChurchGrimsbyDatabase.mdb" 'The datasource

        con.ConnectionString = dbProvider & dbSource 'Tells vb the provider And source Of the database

        con.Open() 'Opens the connection

        Dim dt As New DataTable

        ds.Tables.Add(dt) 'Creates a new datatable

        sql = "Select * FROM Volunteer WHERE LinkedUser = " & SelectedUser 'Uses and SQL statement to select the Login form
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(dt) 'Fills the data table with the infomation from the data adapter

        DataGridView1.DataSource = dt.DefaultView 'Fills the data grid with the datatable

    End Sub
End Class