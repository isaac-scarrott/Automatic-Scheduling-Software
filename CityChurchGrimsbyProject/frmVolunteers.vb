Imports System.Data.OleDb
Public Class FrmVolunteers
    Dim con As New OleDb.OleDbConnection
    Dim dbProvider As String
    Dim dbSource As String
    Dim ds As New DataSet
    Dim da As New OleDb.OleDbDataAdapter
    Dim MaxRows As Integer
    Dim sql As String
    Dim Row As Integer

    Private Sub FrmVolunteers_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

        Dim VFirstName As String = FirstName_Text.Text
    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click 'Goes back to the previous screen
        Close()
        frmMainScreen.Show()

        FirstName_Text.Clear()
        LastName_Text.Clear()
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
            Dim obj As New frmLoadVolunteer

            obj.Row = Row 'Used to carry over the row number into the another form
            Close() 'Hides the current form
            frmLoadVolunteer.Show() 'Shows the selected form
        Else 'If it is not true then this will run
            MsgBox("This volunteer does not exist", MsgBoxStyle.Information, "Error") 'Tell the user that the volunteer doesn't exist
        End If
    End Sub

    Private Sub FirstName_Text_TextChanged(sender As Object, e As EventArgs) Handles FirstName_Text.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Obj As New frmCreateVolunteer
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



        Dim result As MsgBoxResult

        If FindVolunteer() = True Then 'If the function is true then this will run
            result = MsgBox("There is already a volunteer named " & ds.Tables("Volunteer").Rows(Row).Item(1) & " " & ds.Tables("Volunteer").Rows(Row).Item(2) & "." & vbCrLf + "Are you sure you wish to create a new volunteer?", MsgBoxStyle.YesNo) 'Asks the user if they still want to create a volunteer under this name even though one under this already exists

            If result = MsgBoxResult.Yes Then 'If the user presses yes then this will run
                Obj.NewFirstName = FirstName_Text.Text 'Used to carry over the first name of the volunteer
                Obj.NewLastName = LastName_Text.Text 'Used to carry over the last name of the volunteer

                Hide() 'Hides the current form
                frmCreateVolunteer.Show() 'Shows the create volunteer form
            End If


        Else
            Obj.NewFirstName = FirstName_Text.Text 'Used to carry over the first name of the volunteer
            Obj.NewLastName = LastName_Text.Text 'Used to carry over the last name of the volunteer

            Hide() 'Hides the current form
            frmCreateVolunteer.Show() 'Shows the create volunteer form
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
        frmAllVolunteers.Show()
    End Sub

    Private Sub LaswtName_Label_Click(sender As Object, e As EventArgs) Handles LaswtName_Label.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub LastName_Text_TextChanged(sender As Object, e As EventArgs) Handles LastName_Text.TextChanged

    End Sub
    Private Sub FirstName_Text_KeyPress(ByVal sender As Object,
                              ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles FirstName_Text.KeyPress
        e.Handled = Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub LastName_Text_KeyPress(ByVal sender As Object,
                              ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles LastName_Text.KeyPress
        e.Handled = Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar)
    End Sub
End Class