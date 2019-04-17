Imports System.Text.RegularExpressions
Public Class frmCreateVolunteer
    Public Shared Property NewFirstName As String
    Public Shared Property NewLastName As String

    Dim con As New OleDb.OleDbConnection
    Dim dbProvider As String
    Dim dbSource As String
    Dim ds As New DataSet
    Dim da As New OleDb.OleDbDataAdapter
    Dim MaxRows As Integer
    Dim sql As String
    Dim Error1 As String

    Private Sub frmCreateVolunteer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DOB_Text.Format = DateTimePickerFormat.Custom
        DOB_Text.CustomFormat = "dd/MM/yyy"

        FirstName_TextBox.Text = NewFirstName 'Carries over the first name of the volunteer that you wish to create from the previous form
        LastName_TextBox.Text = NewLastName 'Carries over the last name of the volunteer that you wish to create from the previous form

        Dim dbProvider As String
        Dim dbSource As String

        dbProvider = "PROVIDER=Microsoft.Jet.OLEDB.4.0;"
        dbSource = "Data Source=CityChurchGrimsbyDatabase.mdb"

        con.ConnectionString = dbProvider & dbSource 'Tells vb the provider And source Of the database
        con.Open() 'Opens the connection

        Dim dt As New DataTable
        Dim ds As New DataSet
        ds.Tables.Add(dt) 'Creates a new data table

        Dim da As New OleDb.OleDbDataAdapter("Select * from Jobs", con)
        da.Fill(dt) 'Fills the datatable with the infomation in the data adapter

        Dim r As DataRow

        ComboBox1.AutoCompleteCustomSource.Clear()

        For Each r In dt.Rows 'Used to ammend the textbox with the data in the database
            If r.Item(1) = SelectedUser Then
                ComboBox1.Items.Add(r.Item(2).ToString)
            End If
        Next

    End Sub

    Private Sub Modify_Button_Click(sender As Object, e As EventArgs) Handles Modify_Button.Click
        Dim ID As Integer
        MsgBox("You need to fill in all of the required fields")
        If Validation() Then

            sql = "Select * From Volunteer" 'Uses and SQL statement to select the volunteer table
            da = New OleDb.OleDbDataAdapter(sql, con)
            da.Fill(ds, "Volunteer") 'Fills the data adapter with the data set and calls it volunteer

            Dim cb As New OleDb.OleDbCommandBuilder(da)
            Dim dsNewRow As DataRow

            MaxRows = ds.Tables("Volunteer").Rows.Count 'The number of rows in the table

            dsNewRow = ds.Tables("Volunteer").NewRow 'Adds the row of the next free row

            dsNewRow.Item(0) = MaxRows + 1 'Adds a new ID to the database using how many rows there are
            ID = MaxRows + 1
            dsNewRow.Item(1) = FirstName_TextBox.Text 'Inserts the data from the textbox into the corrisponing item in the table
            dsNewRow.Item(2) = LastName_TextBox.Text '^
            dsNewRow.Item(3) = PhoneNumber_Text.Text '^
            dsNewRow.Item(4) = EmailAddress_Text.Text '^
            dsNewRow.Item(6) = MaxTimesOn_Text.Text '^
            dsNewRow.Item(7) = (DOB_Text.Text).ToString '^
            dsNewRow.Item(8) = SelectedUser

            ds.Tables("Volunteer").Rows.Add(dsNewRow) 'Creates a row in the database
            da.Update(ds, "Volunteer") 'Updates the database with the selected infomation

            ds.Clear()

            sql = "Select * From VolunteerJobs" 'Uses and SQL statement to select the volunteer table
            da = New OleDb.OleDbDataAdapter(sql, con)
            da.Fill(ds, "VolunteerJobs") 'Fills the data adapter with the data set and calls it volunteer

            cb = New OleDb.OleDbCommandBuilder(da)

            Dim myItem As Object


            For Each myItem In JobQualified_ListBox.Items
                dsNewRow = ds.Tables("VolunteerJobs").NewRow 'Adds the row of the next free row

                dsNewRow.Item(0) = ID
                dsNewRow.Item(1) = myItem.ToString
                ds.Tables("VolunteerJobs").Rows.Add(dsNewRow) 'Creates a row in the database
                da.Update(ds, "VolunteerJobs") 'Updates the database with the selected infomation
            Next



            ds.Clear()

            sql = "Select * From VolunteerStatistics" 'Uses and SQL statement to select the volunteer table
            da = New OleDb.OleDbDataAdapter(sql, con)
            da.Fill(ds, "VolunteerStatistics") 'Fills the data adapter with the data set and calls it volunteer

            cb = New OleDb.OleDbCommandBuilder(da)

            dsNewRow = ds.Tables("VolunteerStatistics").NewRow 'Creates a new row

            'Fills the columns in the new row witht the selected infomation

            dsNewRow.Item(0) = ID
            dsNewRow.Item(1) = 0
            dsNewRow.Item(2) = 0
            dsNewRow.Item(3) = JobQualified_ListBox.Items.Count

            ds.Tables("VolunteerStatistics").Rows.Add(dsNewRow) 'Creates a row in the database
            da.Update(ds, "VolunteerStatistics") 'Updates the database with the selected infomation

            sql = "Select * From ChurchStatistics" 'Uses and SQL statement to select the volunteer table
            da = New OleDb.OleDbDataAdapter(sql, con)
            da.Fill(ds, "ChurchStatistics") 'Fills the data adapter with the data set and calls it volunteer

            cb = New OleDb.OleDbCommandBuilder(da)

            ds.Tables("ChurchStatistics").Rows(0).Item(0) = ds.Tables("ChurchStatistics").Rows(0).Item(0) + 1
            ds.Tables("ChurchStatistics").Rows(0).Item(1) = ds.Tables("ChurchStatistics").Rows(0).Item(1) + 1

            cb = New OleDb.OleDbCommandBuilder(da)

            da.Update(ds, "ChurchStatistics") 'Updates the database with the selected infomation

            MsgBox("New volunteer added to the database", MsgBoxStyle.Information, "Volunteer Added") 'Displays a message box confirming the new user has been created



            Dim Result As MsgBoxResult 'Used to determine the outcome of a message box

            Result = MsgBox("In order to use the new item you must restart the program - would you like to restart now?", MsgBoxStyle.YesNo, "Restart Required") ' Asks the user if they want to restart the program in order to update the database

            If Result = MsgBoxResult.Yes Then 'If the user presses yes then this will run
                Application.Restart() 'It will restart the application
            End If
            con.Close() 'Closes the connection
        Else
            MsgBox(Error1)
        End If

    End Sub

    Private Sub Back_Button_Click(sender As Object, e As EventArgs) Handles Back_Button.Click 'Back to the current screen
        Close()
        FrmVolunteers.Show()
    End Sub

    Function Validation() 'Validates each of the textboxes
        Dim pattern As String = "^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$" 'Sets the pattern of an email address
        Dim emailAddressMatch As Match = Regex.Match(EmailAddress_Text.Text, pattern) 'Tests if the email address is a valid email address

        If FirstName_TextBox.Text = "" Or Len(FirstName_TextBox.Text) < 3 Or Len(FirstName_TextBox.Text) > 20 Then 'Checks if it is between 3 and 20 character

            Error1 = "There is a problem with the first name" 'The type of error it is
            Return False 'Return the value false straight away

        ElseIf LastName_TextBox.Text = "" Or Len(LastName_TextBox.Text) < 3 Or Len(LastName_TextBox.Text) > 20 Then 'Checks if it is between 3 and 20 character

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


        Return True
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'Copies accross the data from the combo box into the list box and then removes it fom the combo box when the button is pressed

        JobQualified_ListBox.Items.Add(ComboBox1.Text)
        ComboBox1.Items.Remove(ComboBox1.SelectedItem)
        ComboBox1.Text = ""

    End Sub

    Private Sub ListBox1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles JobQualified_ListBox.KeyDown

        'When the delete key is pressed then it will remove it from the list box and then adds it back into the combo box

        If e.KeyCode = Keys.Delete AndAlso JobQualified_ListBox.SelectedItem <> Nothing Then
            ComboBox1.Items.Add(JobQualified_ListBox.SelectedItem.ToString)
            JobQualified_ListBox.Items.RemoveAt(JobQualified_ListBox.SelectedIndex)
        End If
    End Sub

    Private Sub JobQualified_ListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles JobQualified_ListBox.SelectedIndexChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub DOB_Text_ValueChanged(sender As Object, e As EventArgs) Handles DOB_Text.ValueChanged

    End Sub
End Class