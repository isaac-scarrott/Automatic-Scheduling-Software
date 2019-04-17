Imports System.Data.OleDb
Public Class frmStatisticsVolunteerSelection
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
        frmStatisticsSelection.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Hide()
        frmStatisticsChosenVolunteer.Show()
    End Sub

    Private Sub Load_Btn_Click(sender As Object, e As EventArgs) Handles Load_Btn.Click
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

        If FindVolunteer() = True Then 'If the function is true then this will run
            Dim obj As New frmStatisticsChosenVolunteer

            obj.VolID = ds.Tables("Volunteer").Rows(Row).Item(0)
            Close() 'Hides the current form
            frmStatisticsChosenVolunteer.Show() 'Shows the selected form
        Else 'If it is not true then this will run
            MsgBox("This volunteer does not exist", MsgBoxStyle.Information, "Error") 'Tell the user that the volunteer doesn't exist
        End If
    End Sub
    Function FindVolunteer()

        Dim UserExists As Boolean = False

        For x = 0 To MaxRows - 1 'Loops from 1 until x reaches 1 under max rows 

            For y = 0 To MaxRows - 1 'Loops from 1 until x reaches 1 under max rows 

                If ds.Tables("Volunteer").Rows(x).Item(1) = FirstName_Text.Text And ds.Tables("Volunteer").Rows(y).Item("LastName") = LastName_Text.Text And SelectedUser = ds.Tables("Volunteer").Rows(y).Item(8) Then 'Used to check that the firstname and lastname match
                    If ds.Tables("Volunteer").Rows(y).Item(1) = ds.Tables("Volunteer").Rows(x).Item(1) Then
                        Row = y 'Used to store the row of the volunteer
                        Return True 'Returns the value of true
                    End If
                End If
            Next
        Next

        Return False 'Returns the value of false

    End Function

    Private Sub frmStatisticsVolunteerSelection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con As New OleDb.OleDbConnection

        Dim dbProvider As String
        Dim dbSource As String

        dbProvider = "PROVIDER=Microsoft.Jet.OLEDB.4.0;"
        dbSource = "Data Source=CityChurchGrimsbyDatabase.mdb"

        con.ConnectionString = dbProvider & dbSource
        con.Open() 'Opens the connection

        Dim dt As New DataTable
        Dim ds As New DataSet
        ds.Tables.Add(dt)

        Dim da As New OleDbDataAdapter("Select * from Volunteer", con)
        da.Fill(dt)

        Dim r As DataRow

        FirstName_Text.AutoCompleteCustomSource.Clear()

        For Each r In dt.Rows 'Used to ammend the textbox with the data in the database
            If r.Item(8) = SelectedUser Then
                FirstName_Text.AutoCompleteCustomSource.Add(r.Item(1).ToString)
            End If
        Next
    End Sub
End Class