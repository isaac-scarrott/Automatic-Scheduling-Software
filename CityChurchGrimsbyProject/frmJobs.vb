Imports System.Data.OleDb
Public Class FrmJobs
    Dim con As New OleDb.OleDbConnection
    Dim dbProvider As String
    Dim dbSource As String
    Dim ds As New DataSet
    Dim da As New OleDb.OleDbDataAdapter
    Dim MaxRows As Integer
    Dim sql As String
    Dim JobNameLoaded As String 'Used to save the row that the loaded job is
    Dim TempName As String 'Used to store the Name
    Dim WeeksTemp As Int32
    Dim ub As Integer
    Dim lb As Integer
    Dim Mid As Integer

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back_Button.Click 'Goes back to the main screen
        Close()
        frmMainScreen.Show()

        Name_text.Clear()
        Description_text.Clear()
        ID_Text.Clear()
    End Sub

    Private Sub FrmJobs_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'Used to load up the selected job from the database

        Dim dbProvider As String
        Dim dbSource As String

        dbProvider = "PROVIDER=Microsoft.Jet.OLEDB.4.0;"
        dbSource = "Data Source=CityChurchGrimsbyDatabase.mdb"

        con.ConnectionString = dbProvider & dbSource 'Tells vb the provider And source Of the database

        Dim dt As New DataTable
        ds.Tables.Add(dt)

        Dim da As New OleDbDataAdapter("Select * from Jobs", con) 'Selectes all the data from the table jobs in the database
        da.Fill(dt)

        Dim r As DataRow

        Name_text.AutoCompleteCustomSource.Clear() 'Clearsd the source of the auto complete address

        For Each r In dt.Rows 'This is used for autocompleted the job name text box. It uses the data in the column 1 and searches the database for what you are typing and ammends it for you as you type
            If r.Item(1) = SelectedUser Then
                Name_text.AutoCompleteCustomSource.Add(r.Item(2).ToString)
            End If
        Next

        sql = "Select * From Jobs" 'Uses and SQL statement to select the Login form
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "Jobs") 'Fills the data adapter with the data set and calls it jobs

        MaxRows = ds.Tables("Jobs").Rows.Count 'Counts the number of row in the jobs table

        If con.State = ConnectionState.Closed Then
            con.Open()
        End If



    End Sub
    Structure Temp
        Dim Row0 As Integer
        Dim Row1 As Integer
        Dim Row2 As String
        Dim Row3 As String
        Dim Row4 As Integer
    End Structure

    Sub insertionSort(ByRef MaxRows As Integer)

        ds.Clear()

        sql = "Select * From Jobs" 'Uses and SQL statement to select the Login form
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "Jobs") 'Fills the data adapter with the data set and calls it jobs

        Dim Temp As Temp
        Dim Counter As Integer

        For x = 1 To MaxRows - 1
            If Asc(ds.Tables("Jobs").Rows(x).Item(2).ToString.Substring(0, 1)) < Asc(ds.Tables("Jobs").Rows(x - 1).Item(2).ToString.Substring(0, 1)) Then
                Temp.Row0 = ds.Tables("Jobs").Rows(x).Item(0)
                Temp.Row1 = ds.Tables("Jobs").Rows(x).Item(1)
                Temp.Row2 = ds.Tables("Jobs").Rows(x).Item(2)
                Temp.Row3 = ds.Tables("Jobs").Rows(x).Item(3)
                Temp.Row4 = ds.Tables("Jobs").Rows(x).Item(4)

                Counter = x

                Do Until Counter = 0 Or Asc(ds.Tables("Jobs").Rows(x).Item(2).ToString.Substring(0, 1)) > Asc(ds.Tables("Jobs").Rows(x - 1).Item(2).ToString.Substring(0, 1))
                    ds.Tables("Jobs").Rows(Counter).Item(2) = ds.Tables("Jobs").Rows(Counter - 1).Item(2)
                    ds.Tables("Jobs").Rows(Counter).Item(0) = ds.Tables("Jobs").Rows(Counter - 1).Item(0)
                    ds.Tables("Jobs").Rows(Counter).Item(1) = ds.Tables("Jobs").Rows(Counter - 1).Item(1)
                    ds.Tables("Jobs").Rows(Counter).Item(3) = ds.Tables("Jobs").Rows(Counter - 1).Item(3)
                    ds.Tables("Jobs").Rows(Counter).Item(4) = ds.Tables("Jobs").Rows(Counter - 1).Item(4)

                    Counter = Counter - 1
                Loop

            End If

            ds.Tables("Jobs").Rows(Counter).Item(0) = Temp.Row0
            ds.Tables("Jobs").Rows(Counter).Item(1) = Temp.Row1
            ds.Tables("Jobs").Rows(Counter).Item(2) = Temp.Row2
            ds.Tables("Jobs").Rows(Counter).Item(3) = Temp.Row3
            ds.Tables("Jobs").Rows(Counter).Item(4) = Temp.Row4


        Next

        Dim cb As New OleDb.OleDbCommandBuilder(da)
        da.Update(ds, "Jobs") 'Updates the table

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        ds.Clear()

        sql = "Select * From Jobs ORDER BY Name" 'Uses and SQL statement to select the jobs table
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "Jobs") 'Fills the data adapter with the data set and calls it Jobs

        lb = 0
        ub = ds.Tables("Jobs").Rows.Count


        Dim Mid As Integer = Int((ub - lb) / 2)

        If Name_text.Text <> "" Then 'If the name textbox is not empty this willrun



            BinarySearch(Mid)

        End If



        con.Close() 'Closes the connection
    End Sub

    Sub BinarySearch(ByRef Mid As Integer)
        'This is a recursive procedure that will search the database using a algorithm called binary search


        If Asc(((ds.Tables("Jobs").Rows(Int(Mid)).Item(2)).ToString).Substring(0, 1)) < Asc((Name_text.Text).Substring(0, 1)) Then 'If the first letter is bigger than than first letter of the item in the database then this will run
            lb = Mid
            Mid = (Int((ub - lb) / 2)) + Mid 'Moves the parameters of the search
            BinarySearch(Mid) 'Recalles the routine
        ElseIf Asc(((ds.Tables("Jobs").Rows(Int(Mid)).Item(2)).ToString).Substring(0, 1)) > Asc((Name_text.Text).Substring(0, 1)) Then 'If the first letter is smaller than than first letter of the item in the database then this will run
            ub = Mid
            Mid = (Int((ub - lb) / 2))'Moves the parameters of the search
            BinarySearch(Mid)'Recalles the routine
        ElseIf ds.Tables("Jobs").Rows(Mid).Item(2) = Name_text.Text Then
            Name_text.Text = ds.Tables("Jobs").Rows(Mid).Item(2) 'Inputs the data from the textbox into the database field
            Description_text.Text = ds.Tables("Jobs").Rows(Mid).Item(3) '^
            ID_Text.Text = ds.Tables("Jobs").Rows(Mid).Item(0)          '^
            Week_text.Text = ds.Tables("Jobs").Rows(Mid).Item(4)

            JobNameLoaded = Mid 'Sets the variable to x so that it know what row you have loaded

            TempName = Name_text.Text 'Sets the temp name to the name in the textbox
            WeeksTemp = Convert.ToInt32(Week_text.Text)
        Else
            MsgBox("Job not found")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        sql = "Select * From Jobs" 'Uses and SQL statement to select the Jobs
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "Jobs") 'Fills the data adapter with the data set and calls it Jobs

        Dim cb As New OleDb.OleDbCommandBuilder(da)
        Dim dsNewRow As DataRow

        If AlreadyExists = False Then

            dsNewRow = ds.Tables("Jobs").NewRow 'Adds the row of the next free row

            dsNewRow.Item(0) = MaxRows + 1 'Used to set the ID of the new item of data
            dsNewRow.Item(2) = Name_text.Text 'Set the Name of the job in the database
            dsNewRow.Item(3) = Description_text.Text 'Adds a description of the job to the database
            dsNewRow.Item(4) = Week_text.Text
            dsNewRow.Item(1) = SelectedUser

            ds.Tables("Jobs").Rows.Add(dsNewRow) 'Creates a row in the database
            da.Update(ds, "Jobs") 'Updates the database with the selected infomation

            MaxRows = MaxRows + 1

            For x = 1 To Convert.ToInt32(Week_text.Text)
                sql = "ALTER TABLE Rota ADD COLUMN " & "R" & SelectedUser & Name_text.Text & x & " TEXT(250);" 'Uses and SQL statement to select the Login form  and then selects the Username from the database
                Dim cmd As New OleDbCommand(sql, con)
                cmd.ExecuteNonQuery()
            Next
            MsgBox("New job added to the database", MsgBoxStyle.Information, "Job Added") 'Displays a message box confirming that the database has been updated

            Dim Result As MsgBoxResult 'Used to determine the outcome of a message box

            Result = MsgBox("In order to use the new item you must restart the program - would you like to restart now?", MsgBoxStyle.YesNo, "Restart Required") ' Asks the user if they want to restart the program in order to update the database

            If Result = MsgBoxResult.Yes Then 'If the user presses yes then this will run
                Application.Restart() 'It will restart the application
            End If
        End If
        con.Close() 'Closes the connection
    End Sub

    Private Sub Update_btn_Click(sender As Object, e As EventArgs) Handles Update_btn.Click

        If AlreadyExists() = False Or TempName = Name_text.Text Then

            If con.State = ConnectionState.Closed Then
                con.Open()
            End If

            'Opens the connection

            Dim Result As MsgBoxResult 'Enables us to see what the user pressed in a message box

            Result = MsgBox("Are you sure you wish to update the records for " & Name_text.Text & "?", MsgBoxStyle.YesNo, "Change Password") 'Displays a message box to ask the user if the really want to update their records

            If Result = MsgBoxResult.Yes Then 'If the user presses yes then this will run

                sql = "SELECT * FROM Jobs" 'Uses and SQL statement to select the Login form  and then selects the Username from the database
                da = New OleDb.OleDbDataAdapter(sql, con)
                da.Fill(ds, "Jobs") 'Fills the data adapter with the data set and calls it jobs

                ds.Tables("Jobs").Rows(JobNameLoaded).Item(0) = ID_Text.Text 'Sets the ds of the of the jobs form in the item to of the selected jobs to the text in the textbox
                ds.Tables("Jobs").Rows(JobNameLoaded).Item(2) = Name_text.Text '^
                ds.Tables("Jobs").Rows(JobNameLoaded).Item(3) = Description_text.Text '^
                ds.Tables("Jobs").Rows(JobNameLoaded).Item(4) = Week_text.Text

                Dim cb As New OleDb.OleDbCommandBuilder(da)
                da.Update(ds, "Jobs") 'Updates the table

                MsgBox("The record has been updated", MsgBoxStyle.Information, "Record Updated") 'Notifys the user that their record has been updated
            End If


            If Week_text.Text <> WeeksTemp Then 'If the weeks text box has changed then this will run

                If WeeksTemp < Week_text.Text Then 'If the new week is more than previously then this will run

                    WeeksTemp = (Convert.ToInt32(WeeksTemp) + 1)

                    ds.Clear() 'Clears the data set

                    Dim lb As Int32 = WeeksTemp
                    Dim ub As Int32 = Convert.ToInt32(Week_text.Text)


                    For x = lb To ub 'Goes from the lower bound and upper bound
                        sql = "ALTER TABLE Rota ADD COLUMN " & SelectedUser & Name_text.Text & x & " TEXT(250);" 'Uses and SQL statement to select the Login form  and then selects the Username from the database
                        Dim cmd As New OleDbCommand(sql, con)
                        cmd.ExecuteNonQuery() 'Executes the sql command
                        If x = ub Then
                            Exit For 'Exits the for loop
                        End If
                        cmd.ExecuteNonQuery()

                    Next

                ElseIf WeeksTemp > Week_text.Text Then 'If the new week is more than previously then this will run


                    ds.Clear() 'Clears the data set

                    Dim lb As Int32 = Convert.ToInt32(Week_text.Text) + 1
                    Dim ub As Int32 = WeeksTemp

                    For x = lb To ub 'Goes from the lower bound and upper bound

                        sql = "ALTER TABLE Rota DROP COLUMN R" & SelectedUser & Name_text.Text & x & ";" 'Uses and SQL statement to select the Login form  and then selects the Username from the database
                        Dim cmd As New OleDbCommand(sql, con)
                        cmd.ExecuteNonQuery() 'Executes the sql command
                        If x = ub Then
                            Exit For 'Exits the for loop
                        End If

                    Next

                End If

            End If

            ds.Clear()
        End If
            con.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        If con.State = ConnectionState.Closed Then
            con.Open()
        End If


        Dim TempWeeksFromDb As Integer
        Dim TempNameFromDb As String

        Dim Result As MsgBoxResult 'Enables us to see what the user pressed in a message box

        Result = MsgBox("Are you sure you wish to delete the records for " & Name_text.Text & "?", MsgBoxStyle.YesNo, "Delete Record") 'Displays a message box to ask the user if the really want to delete the selected record

        If Result = MsgBoxResult.Yes Then 'If the user presses yes then this will run

            Dim cb As New OleDb.OleDbCommandBuilder(da)

            TempWeeksFromDb = Convert.ToInt32(ds.Tables("Jobs").Rows(JobNameLoaded).Item(4))
            TempNameFromDb = ds.Tables("Jobs").Rows(JobNameLoaded).Item(2)

            ds.Tables("Jobs").Rows(JobNameLoaded).Delete() 'Deletes the selected job

            MaxRows = MaxRows - 1
            da.Update(ds, "Jobs")

            For x = 1 To TempWeeksFromDb
                sql = "ALTER TABLE Rota DROP COLUMN " & "R" & SelectedUser & TempNameFromDb & x & ";" 'Uses and SQL statement to select the Login form  and then selects the Username from the database
                Dim cmd As New OleDbCommand(sql, con)
                cmd.ExecuteNonQuery()
            Next

            sql = "SELECT * FROM VolunteerJobs" 'Uses and SQL statement to select the Login form  and then selects the Username from the database
            da = New OleDb.OleDbDataAdapter(sql, con)
            da.Fill(ds, "VolunteerJobs") 'Fills the data adapter with the data set and calls it jobs

            MaxRows = ds.Tables("VolunteerJobs").Rows.Count

            For x = 0 To MaxRows - 1
                If ds.Tables("VolunteerJobs").Rows(x).Item(1) = TempNameFromDb Then
                    ds.Tables("Jobs").Rows(x).Delete()
                End If
            Next

            da.Update(ds, "Jobs")

            MsgBox("The job has been deleted")




        End If
    End Sub

    Private Sub ID_Text_TextChanged(sender As Object, e As EventArgs) Handles ID_Text.TextChanged

    End Sub
    Function AlreadyExists()

        For x = 0 To MaxRows - 1 'Runs for the set interval
            If ds.Tables("Jobs").Rows(x).Item(2) = Name_text.Text And TempName <> Name_text.Text And ds.Tables("Jobs").Rows(x).Item(1) = SelectedUser Then 'Used to check if the job exists. If it does then this will run
                MsgBox("The job " & Name_text.Text & " already exists") 'Tells the user that that the job already exists
                Return True 'Returns true
            End If
        Next

        Return False 'Returns false

    End Function

    Private Sub Name_text_TextChanged(sender As Object, e As EventArgs) Handles Name_text.TextChanged

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Close()
        frmAllJobs.Show()
    End Sub
End Class