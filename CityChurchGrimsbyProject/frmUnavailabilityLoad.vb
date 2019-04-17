Public Class frmUnavailabilityLoad
    Dim con As New OleDb.OleDbConnection
    Dim dbProvider As String
    Dim dbSource As String
    Dim ds As New DataSet
    Dim da As New OleDb.OleDbDataAdapter
    Dim MaxRows As Integer
    Dim sql As String
    Dim DeleteRow As Integer
    Public Shared Property IDPass As Integer 'Used to pass data between forms
    Public Shared Property Row As Integer '^
    Private Sub frmUnavailabilityLoad_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DateTimePicker1.Format = DateTimePickerFormat.Custom 'Used to tell the program that there is a custom format
        DateTimePicker1.CustomFormat = "dd/MM/yyy" 'Tells the program the format it should output in

        dbProvider = "PROVIDER=Microsoft.Jet.OLEDB.4.0;"
        dbSource = "Data Source=CityChurchGrimsbyDatabase.mdb"

        con.ConnectionString = dbProvider & dbSource 'Tells vb the provider and source of the database

        con.Open() 'Opens the connection

        sql = "Select * From Volunteer" 'Uses and SQL statement to select the volunteer table
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "Volunteer") 'Fills the data adapter with the data set and calls it volunteer

        FirstName_Text.Text = ds.Tables("Volunteer").Rows(Row).Item(1) 'Inputs the data from the table into the textbox
        LastName_Text.Text = ds.Tables("Volunteer").Rows(Row).Item(2) '^

        ds.Clear()

        sql = "Select * From Unavailability" 'Uses and SQL statement to select the LJobs table
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "Unavailability") 'Fills the data adapter with the data set and calls it Jobs

        MaxRows = ds.Tables("Unavailability").Rows.Count 'Counts the number of row in the table

        For x = 0 To MaxRows - 1 'Loops from 0 to one under max rows
            If ds.Tables("Unavailability").Rows(x).Item(0) = IDPass Then 'If the ID in the database matches the ID passed between the forms
                ListBox1.Items.Add(ds.Tables("Unavailability").Rows(x).Item(1)) 'It will input into the list box all of the data in the table
            End If
        Next


    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged



    End Sub

    Private Sub Update_btn_Click(sender As Object, e As EventArgs) Handles Update_btn.Click 'Used to update the database


        Dim cb As New OleDb.OleDbCommandBuilder(da)
        Dim dsNewRow As DataRow

        dsNewRow = ds.Tables("Unavailability").NewRow 'Adds the row of the next free row

        dsNewRow.Item(0) = IDPass
        dsNewRow.Item(1) = (DateTimePicker1.Text).ToString

        ds.Tables("Unavailability").Rows.Add(dsNewRow) 'Creates a row in the database
        da.Update(ds, "Unavailability") 'Updates the database with the selected infomation

        MsgBox("New unavailability added to the database", MsgBoxStyle.Information, "Unavailability Added") 'Displays a message box confirming that the database has been updated

        Dim Result As MsgBoxResult 'Used to determine the outcome of a message box

        Result = MsgBox("In order to use the new item you must restart the program - would you like to restart now?", MsgBoxStyle.YesNo, "Restart Required") ' Asks the user if they want to restart the program in order to update the database

        If Result = MsgBoxResult.Yes Then 'If the user presses yes then this will run
        End If

        sql = "Select * From VolunteerStatistics" 'Uses and SQL statement to select the LJobs table
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "VolunteerStatistics") 'Fills the data adapter with the data set and calls it Jobs

        MaxRows = ds.Tables("VolunteerStatistics").Rows.Count 'Counts the number of row in the table

        For x = 0 To MaxRows - 1
            If ds.Tables("VolunteerStatistics").Rows(x).Item(0) = IDPass Then
                ds.Tables("VolunteerStatistics").Rows(x).Item(2) = ds.Tables("VolunteerStatistics").Rows(x).Item(2) + 1
            End If
        Next

        cb = New OleDb.OleDbCommandBuilder(da)

        da.Update(ds, "VolunteerStatistics")

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click 'Goes back to the previous form
        FirstName_Text.Clear()
        LastName_Text.Clear()
        ListBox1.ClearSelected()
        Hide()
        FrmUnavailability.Show()

    End Sub

    Private Sub Delete_Btn_Click(sender As Object, e As EventArgs)




    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sql = "Select * From Unavailability" 'Uses and SQL statement to select the LJobs table
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "Unavailability") 'Fills the data adapter with the data set and calls it Jobs

        MaxRows = ds.Tables("Unavailability").Rows.Count 'Counts the number of row in the table

        Dim SelectedItem As String = ListBox1.SelectedItem.ToString


        Dim Result As MsgBoxResult 'Enables us to see what the user pressed in a message box

        Result = MsgBox("Are you sure you wish to delete the records?", MsgBoxStyle.YesNo, "Delete Record") 'Displays a message box to ask the user if the really want to delete the selected record

        If Result = MsgBoxResult.Yes Then 'If the user presses yes then this will run



            For x = 0 To MaxRows - 1 'Goes through each row in the database

                If ds.Tables("Unavailability").Rows(x).Item(0) = IDPass Then 'If it matches then this will run

                    If ds.Tables("Unavailability").Rows(x).Item(1) = SelectedItem.ToString Then
                        x = Row 'The row of the item that the user was searching for


                        Exit For
                    End If
                End If
            Next
        End If

        Dim cb As New OleDb.OleDbCommandBuilder(da)

        ds.Tables("Unavailability").Rows(DeleteRow).Delete() 'Deletes the selected row

        da.Update(ds, "Unavailability") 'Updates the table

        sql = "Select * From VolutneerStatistics" 'Uses and SQL statement to select the LJobs table
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "VolutneerStatistics") 'Fills the data adapter with the data set and calls it Jobs

        MaxRows = ds.Tables("VolutneerStatistics").Rows.Count 'Counts the number of row in the table

        For x = 0 To MaxRows - 1 'Goes through each row in the database
            If ds.Tables("VolunteerStatistics").Rows(x).Item(0) = IDPass Then 'If it matches then this will run
                ds.Tables("VolunteerStatistics").Rows(x).Item(2) = ListBox1.Items.Count
            End If
        Next

        cb = New OleDb.OleDbCommandBuilder(da)

        da.Update(ds, "VolunteerStatistics") 'Updates the table

    End Sub
End Class