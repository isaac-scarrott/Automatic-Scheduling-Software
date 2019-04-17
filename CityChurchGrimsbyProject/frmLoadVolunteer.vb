Imports System.Text.RegularExpressions
Public Class frmLoadVolunteer
    Dim con As New OleDb.OleDbConnection
    Dim dbProvider As String
    Dim dbSource As String
    Dim ds As New DataSet
    Dim da As New OleDb.OleDbDataAdapter
    Dim MaxRows As Integer
    Dim sql As String
    Dim Error1 As String

    Public Shared Property Row As Integer 'Used to pass the row of the volunteer through the forms
    Private Sub FirstName_TextBox_TextChanged(sender As Object, e As EventArgs) Handles FirstName_Text.TextChanged
    End Sub

    Public Sub frmLoadVolunteer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DOB_Text.Format = DateTimePickerFormat.Custom
        DOB_Text.CustomFormat = "dd/MM/yyy"

        Dim dbProvider As String
        Dim dbSource As String

        dbProvider = "PROVIDER=Microsoft.Jet.OLEDB.4.0;"
        dbSource = "Data Source=CityChurchGrimsbyDatabase.mdb"

        con.ConnectionString = dbProvider & dbSource 'Tells vb the provider And source Of the database

        con.Open()

        Dim dt As New DataTable
        Dim ds As New DataSet
        ds.Tables.Add(dt) 'Creates a new data table

        Dim da As New OleDb.OleDbDataAdapter("Select * from Jobs", con)
        da.Fill(dt) 'Fills the data table

        Dim r As DataRow

        ComboBox1.AutoCompleteCustomSource.Clear()

        For Each r In dt.Rows 'Used to ammend the textbox with the data in the database
            If r.Item(1) = SelectedUser Then
                ComboBox1.Items.Add(r.Item(2).ToString)
            End If
        Next

        ds.Clear()

        sql = "Select * From Volunteer" 'Uses and SQL statement to select the LJobs table
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "Volunteer") 'Fills the data adapter with the data set and calls it Jobs

        FirstName_Text.Text = ds.Tables("Volunteer").Rows(Row).Item(1) 'Inputs the item into the textbox
        LastName_Text.Text = ds.Tables("Volunteer").Rows(Row).Item(2) '^
        PhoneNumber_Text.Text = ds.Tables("Volunteer").Rows(Row).Item(3) '^
        EmailAddress_Text.Text = ds.Tables("Volunteer").Rows(Row).Item(4) '^
        MaxTimesOn_Text.Text = ds.Tables("Volunteer").Rows(Row).Item(6) '^
        DOB_Text.Text = ds.Tables("Volunteer").Rows(Row).Item(7) '^



    End Sub

    Private Sub Back_Button_Click(sender As Object, e As EventArgs) Handles Back_Button.Click 'Used to go back to the previous screen
        Close()
        FrmVolunteers.Show()

        FirstName_Text.Clear()
        LastName_Text.Clear()
        PhoneNumber_Text.Clear()
        EmailAddress_Text.Clear()
        MaxTimesOn_Text.Clear()

    End Sub

    Private Sub Modify_Button_Click(sender As Object, e As EventArgs) Handles Modify_Button.Click

        If Validation() Then 'If the function validation is true then this will run

            Dim Result As MsgBoxResult 'Enables us to see what the user pressed in a message box

            Result = MsgBox("Are you sure you wish to update the records for " & FirstName_Text.Text & " " & LastName_Text.Text & "?", MsgBoxStyle.YesNo, "Change Password") 'Displays a message box to ask the user if the really want to update their records

            If Result = MsgBoxResult.Yes Then 'If the user presses yes then this will run
                sql = "SELECT * FROM Volunteer" 'Uses and SQL statement to select the Login form  and then selects the volunteer database
                da = New OleDb.OleDbDataAdapter(sql, con)
                da.Fill(ds, "Volunteer") 'Fills the data adapter with the data set and calls it volunteer

                ds.Tables("Volunteer").Rows(Row).Item(1) = FirstName_Text.Text 'Inputs the item into the textbox
                ds.Tables("Volunteer").Rows(Row).Item(2) = LastName_Text.Text '^
                ds.Tables("Volunteer").Rows(Row).Item(3) = PhoneNumber_Text.Text '^
                ds.Tables("Volunteer").Rows(Row).Item(4) = EmailAddress_Text.Text '^
                ds.Tables("Volunteer").Rows(Row).Item(6) = MaxTimesOn_Text.Text '^
                ds.Tables("Volunteer").Rows(Row).Item(7) = DOB_Text.Text '^

                Dim ID As Integer = ds.Tables("Volunteer").Rows(Row).Item(0)
                Dim cb As New OleDb.OleDbCommandBuilder(da)
                da.Update(ds, "Volunteer") 'Updates the table

                ds.Clear()

                sql = "Select * From VolunteerJobs" 'Uses and SQL statement to select the volunteer table
                da = New OleDb.OleDbDataAdapter(sql, con)
                da.Fill(ds, "VolunteerJobs") 'Fills the data adapter with the data set and calls it volunteer

                cb = New OleDb.OleDbCommandBuilder(da)

                Dim myItem As Object


                For Each myItem In JobQualified_ListBox.Items
                    MaxRows = ds.Tables("VolunteerJobs").Rows.Count
                    For x = 0 To MaxRows - 1
                        If ds.Tables("VolunteerJobs").Rows(x).Item(0) = ID And ds.Tables("VolunteerJobs").Rows(x).Item(1) <> myItem.ToString Then
                            ds.Tables("Volunteer").Rows(x).Delete()
                        End If
                    Next
                Next

                da.Update(ds, "Volunteer")

                ds.Clear()

                sql = "Select * From VolunteerStatistics" 'Uses and SQL statement to select the volunteer table
                da = New OleDb.OleDbDataAdapter(sql, con)
                da.Fill(ds, "VolunteerStatistics") 'Fills the data adapter with the data set and calls it volunteer

                cb = New OleDb.OleDbCommandBuilder(da)

                MaxRows = ds.Tables("VolunteerStatistics").Rows.Count

                For x = 0 To MaxRows - 1
                    If ds.Tables("VolunteerStatistics").Rows(x).Item(0) = ID Then
                        ds.Tables("VolunteerStatistics").Rows(x).Item(3) = JobQualified_ListBox.Items.Count
                    End If
                Next

                da.Update(ds, "VolunteerStatistics")

                MsgBox("The record has been updated", MsgBoxStyle.Information, "Record Updated") 'Notifys the user that their record has been updated
            End If
        Else
            MsgBox(Error1) 'Displays the error that the program has encounters
        End If

    End Sub

    Function Validation() 'Runs this function

        Dim pattern As String = "^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$" 'Sets the pattern of an email address
        Dim emailAddressMatch As Match = Regex.Match(EmailAddress_Text.Text, pattern) 'Tests if the email address is a valid email address

        If FirstName_Text.Text = "" Or Len(FirstName_Text.Text) < 3 Or Len(FirstName_Text.Text) > 20 Then 'Checks if it is between 3 and 20 character

            Error1 = "There is a problem with the first name" 'The type of error it is
            Return False 'Return the value false straight away

        ElseIf LastName_Text.Text = "" Or Len(LastName_Text.Text) < 3 Or Len(LastName_Text.Text) > 20 Then 'Checks if it is between 3 and 20 character

            Error1 = "There is a problem with the last name" 'The type of error it is
            Return False 'Return the value false straight away

        ElseIf Len(PhoneNumber_Text.Text) <> 11 Or IsNumeric(PhoneNumber_Text.Text) = False Then 'Checks that it is exactly 11 digits long and it is a number

            Error1 = "There is a problem with the phone number" 'The type of error it is
            Return False 'Return the value false straight away

        ElseIf emailAddressMatch.Success = False Then 'Checks if it is in the correct email format

            Error1 = "There is a problem with the email address" 'The type of error it is
            Return False 'Return the value false straight away

        ElseIf MaxTimesOn_Text.Text = "" Or IsNumeric(MaxTimesOn_Text.Text) = False Or MaxTimesOn_Text.Text > 5 Or MaxTimesOn_Text.Text < 1 Then 'Makes sure that it is a number

            Error1 = "There is a problem with the max times on" 'The type of error it is
            Return False 'Return the value false straight away

        End If
        MsgBox("You need to fill in all of the required fields")
        Return True





    End Function

    Private Sub Delete_Btn_Click(sender As Object, e As EventArgs) Handles Delete_Btn.Click
        Dim Result As MsgBoxResult 'Enables us to see what the user pressed in a message box

        Result = MsgBox("Are you sure you wish to delete the records for " & FirstName_Text.Text & " " & LastName_Text.Text & "?", MsgBoxStyle.YesNo, "Delete Record") 'Displays a message box to ask the user if the really want to delete the selected record

        If Result = MsgBoxResult.Yes Then 'If the user presses yes then this will run

            sql = "Select * From Volunteer" 'Uses and SQL statement to select the LJobs table
            da = New OleDb.OleDbDataAdapter(sql, con)
            da.Fill(ds, "Volunteer") 'Fills the data adapter with the data set and calls it Jobs

            Dim cb As New OleDb.OleDbCommandBuilder(da)


            sql = "Select * From VolunteerStatistics" 'Uses and SQL statement to select the LJobs table
            da = New OleDb.OleDbDataAdapter(sql, con)
            da.Fill(ds, "VolunteerStatistics") 'Fills the data adapter with the data set and calls it Jobs

            MaxRows = ds.Tables("VolunteerStatistics").Rows.Count 'Counts the number of row in the table

            For x = 0 To MaxRows - 1
                If ds.Tables("VolunteerStatistics").Rows(x).Item(0) = ds.Tables("Volunteer").Rows(Row).Item(0) Then
                    ds.Tables("VolunteerStatistics").Rows(x).Delete()
                End If
            Next



            cb = New OleDb.OleDbCommandBuilder(da)

            da.Update(ds, "VolunteerStatistics")



            sql = "Select * From Unavailability" 'Uses and SQL statement to select the LJobs table
            da = New OleDb.OleDbDataAdapter(sql, con)
            da.Fill(ds, "Unavailability") 'Fills the data adapter with the data set and calls it Jobs

            MaxRows = ds.Tables("Unavailability").Rows.Count 'Counts the number of row in the table

            For x = 0 To MaxRows - 1
                If ds.Tables("Unavailability").Rows(x).Item(0) = ds.Tables("Volunteer").Rows(Row).Item(0) Then
                    ds.Tables("Unavailability").Rows(x).Delete()
                End If
            Next



            cb = New OleDb.OleDbCommandBuilder(da)

            da.Update(ds, "Unavailability")

            sql = "Select * From Volunteer" 'Uses and SQL statement to select the LJobs table
            da = New OleDb.OleDbDataAdapter(sql, con)
            da.Fill(ds, "Volunteer") 'Fills the data adapter with the data set and calls it Jobs

            cb = New OleDb.OleDbCommandBuilder(da)

            ds.Tables("Volunteer").Rows(Row).Delete()
            MaxRows = MaxRows - 1
            da.Update(ds, "Volunteer")

            sql = "Select * From ChurchStatistics" 'Uses and SQL statement to select the volunteer table
            da = New OleDb.OleDbDataAdapter(sql, con)
            da.Fill(ds, "ChurchStatistics") 'Fills the data adapter with the data set and calls it volunteer

            cb = New OleDb.OleDbCommandBuilder(da)

            ds.Tables("ChurchStatistics").Rows(0).Item(0) = ds.Tables("ChurchStatistics").Rows(0).Item(0) - 1

            cb = New OleDb.OleDbCommandBuilder(da)

            da.Update(ds, "ChurchStatistics") 'Updates the database with the selected infomation




            MsgBox("The volunteer has been deleted")

            Close()
            FrmVolunteers.Show()





        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        JobQualified_ListBox.Items.Add(ComboBox1.Text)
        ComboBox1.Items.Remove(ComboBox1.SelectedItem)
        ComboBox1.Text = ""

    End Sub

    Private Sub ListBox1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles JobQualified_ListBox.KeyDown
        If e.KeyCode = Keys.Delete AndAlso JobQualified_ListBox.SelectedItem <> Nothing Then
            ComboBox1.Items.Add(JobQualified_ListBox.SelectedIndex)
            JobQualified_ListBox.Items.RemoveAt(JobQualified_ListBox.SelectedIndex)
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub DOB_Text_ValueChanged(sender As Object, e As EventArgs) Handles DOB_Text.ValueChanged

    End Sub
End Class