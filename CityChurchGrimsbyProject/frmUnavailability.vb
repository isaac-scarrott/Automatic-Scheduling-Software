Imports System.Data.OleDb
Public Class FrmUnavailability
    Dim con As New OleDb.OleDbConnection
    Dim dbProvider As String
    Dim dbSource As String
    Dim ds As New DataSet
    Dim da As New OleDb.OleDbDataAdapter
    Dim MaxRows As Integer
    Dim sql As String
    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back_Button.Click 'Used to go back to the previous screen
        Hide()
        frmMainScreen.Show()
    End Sub


    Private Sub ModifyUnavailability_Button_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DeleteUnavailability_Button_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub AddUnavailability_Button_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FrmUnavailability_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con As New OleDb.OleDbConnection

        Dim dbProvider As String
        Dim dbSource As String

        dbProvider = "PROVIDER=Microsoft.Jet.OLEDB.4.0;"
        dbSource = "Data Source=CityChurchGrimsbyDatabase.mdb"

        con.ConnectionString = dbProvider & dbSource
        con.Open()

        Dim dt As New DataTable
        Dim ds As New DataSet
        ds.Tables.Add(dt)

        Dim da As New OleDbDataAdapter("Select * from Volunteer", con)
        da.Fill(dt) 'Fills the data table

        Dim r As DataRow

        FirstName_Text.AutoCompleteCustomSource.Clear() 'Clears the auto complete source

        For Each r In dt.Rows 'Used to ammend the textbox as the user types using the data in the database
            If r.Item(8) = SelectedUser Then
                FirstName_Text.AutoCompleteCustomSource.Add(r.Item(1).ToString) 'Tells the program where the to look in the database
            End If
        Next

        Dim VFirstName As String = FirstName_Text.Text

    End Sub

    Private Sub Load_btn_Click(sender As Object, e As EventArgs) Handles Load_btn.Click
        Dim con As New OleDb.OleDbConnection

        Dim dbProvider As String
        Dim dbSource As String

        dbProvider = "PROVIDER=Microsoft.Jet.OLEDB.4.0;"
        dbSource = "Data Source=CityChurchGrimsbyDatabase.mdb"

        con.ConnectionString = dbProvider & dbSource

        con.Open() 'Opens the connection

        sql = "Select * From Volunteer" 'Uses and SQL statement to select the volunteer table
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "Volunteer") 'Fills the data adapter with the data set and calls it volunteer
        MaxRows = ds.Tables("Volunteer").Rows.Count

        If FindVolunteer() = True Then 'Run the function and if it is true then this code will run
            Hide() 'It will hide the current form
            frmUnavailabilityLoad.Show() 'Load the unavailability form
        Else
            MsgBox("This volunteer does not exist", MsgBoxStyle.Information, "Error") ' Telle the user that the volunteer can exist
        End If
    End Sub

    Function FindVolunteer()
        Dim Obj1 As frmUnavailabilityLoad
        Dim Obj2 As frmUnavailabilityLoad
        Dim UserExists As Boolean = False

        For x = 0 To MaxRows - 1 'Loops from 1 until x reaches 1 under max rows 

            For y = 0 To MaxRows - 1 'Loops from 1 until x reaches 1 under max rows 

                If ds.Tables("Volunteer").Rows(x).Item(1) = FirstName_Text.Text And ds.Tables("Volunteer").Rows(y).Item("LastName") = LastName_Text.Text And SelectedUser = ds.Tables("Volunteer").Rows(y).Item(8) Then 'Tests if the volunteer firstname matches the last name as well
                    If ds.Tables("Volunteer").Rows(y).Item(1) = ds.Tables("Volunteer").Rows(x).Item(1) Then 'If it does equal this then this will run
                        Obj1.IDPass = ds.Tables("Volunteer").Rows(y).Item(0) 'Carries over the ID of the volunteer to the next form
                        Obj2.Row = y 'Carries over the row of the form
                        Return True 'Returns the value of true
                    End If
                End If
            Next
        Next

        Return False 'Returns the value of false

    End Function

End Class