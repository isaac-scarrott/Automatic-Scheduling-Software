
Public Class frmNewRotaGenerated
    Dim con As New OleDb.OleDbConnection
    Dim dbProvider As String
    Dim dbSource As String
    Dim ds As New DataSet
    Dim da As New OleDb.OleDbDataAdapter
    Dim da2 As New OleDb.OleDbDataAdapter
    Dim MaxRows As Integer
    Dim sql As String
    Public Shared Property RotaMonthInteger As String
    Public Shared Property RotaMonthString As String
    Public Shared Property RotaYear As String
    Public Shared Property NewRow As Integer
    Dim Current As Integer
    Dim Counter As Integer = 0
    Dim NoOfVolunteers As Integer
    Dim NoOfJobs As Integer
    Dim VolunteerColumnName(30) As JobFilled
    Dim SundayDate(5) As Date
    Dim NoOfSundays As Integer
    Dim Job(30) As String
    Dim MaxJobs As Integer
    Dim MaxVolunteers As Integer
    Dim RotaID As Integer
    Dim RotaDate As String
    Dim NoVolunteersWithJob As Integer
    Dim NoOfJobFilled As Integer

    Structure JobFilled
        Dim Name As String
        Dim IsJobFiled As Boolean
    End Structure

    Private Sub Back_Button_Click(sender As Object, e As EventArgs) Handles Back_Button.Click
        Close()
        frmNewRota.Show()
    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub frmNewRotaGenerated_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cb As New OleDb.OleDbCommandBuilder(da)


        Dim dbProvider As String
        Dim dbSource As String

        dbProvider = "PROVIDER=Microsoft.Jet.OLEDB.4.0;"
        dbSource = "Data Source=CityChurchGrimsbyDatabase.mdb"

        con.ConnectionString = dbProvider & dbSource 'Tells vb the provider And source Of the database

        con.Open()

        GenerateRota()

        sql = "Select * From ChurchStatistics" 'Uses and SQL statement to select the volunteer table
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "ChurchStatistics") 'Fills the data adapter with the data set and calls it volunteer

        cb = New OleDb.OleDbCommandBuilder(da)

        ds.Tables("ChurchStatistics").Rows(0).Item(3) = ds.Tables("ChurchStatistics").Rows(0).Item(3) + 1

        cb = New OleDb.OleDbCommandBuilder(da)

        da.Update(ds, "ChurchStatistics") 'Updates the database with the selected infomation

        Dim dt As New DataTable

        ds.Tables.Add(dt)

        sql = "Select * FROM Rota WHERE RotaDate = '" & RotaMonthString & RotaYear & "'" 'Uses and SQL statement to select the Login form
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(dt) 'Fills the data adapter with the data set and calls it jobs

        DataGridView1.AutoGenerateColumns = False

        DataGridView1.ColumnCount = MaxJobs + 2 'Defines the number of columns to be used

        DataGridView1.Columns(0).Name = "RotaDate"
        DataGridView1.Columns(0).HeaderText = "Rota Date" 'The name of the column
        DataGridView1.Columns(0).DataPropertyName = "RotaDate"

        DataGridView1.Columns(1).Name = "RotaWeek"
        DataGridView1.Columns(1).HeaderText = "Week" 'The name of the column
        DataGridView1.Columns(1).DataPropertyName = "RotaWeek"

        For x = 1 To MaxJobs 'For each of the rows
            DataGridView1.Columns(x + 1).Name = VolunteerColumnName(x).Name
            DataGridView1.Columns(x + 1).HeaderText = VolunteerColumnName(x).Name.Substring(2) 'The name of the column and disregards the unneeded infomation such as the selected user attached to the name of the row
            DataGridView1.Columns(x + 1).DataPropertyName = VolunteerColumnName(x).Name
        Next

        DataGridView1.DataSource = dt 'Fills the data grid
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Public Structure Volunteer
        Dim FirstName As String
        Dim LastName As String
        Dim MaxTimes As Integer
        Dim TimesOn As Integer
        Dim Identification As String
        Dim LinkedUser As String
        Dim HasJob As Boolean
        Dim JobQualified1 As String
        Dim JobQualified2 As String
        Dim JobQualified3 As String
        Dim JobQualified4 As String
        Dim JobQualified5 As String

        Dim Unavailability1 As String
        Dim Unavailability2 As String
        Dim Unavailability3 As String
        Dim Unavailability4 As String
        Dim Unavailability5 As String
        Dim Unavailability6 As String
        Dim Unavailability7 As String
        Dim Unavailability8 As String
        Dim Unavailability9 As String
        Dim Unavailability10 As String
        Dim Unavailability11 As String
        Dim Unavailability12 As String
        Dim Unavailability13 As String
        Dim Unavailability14 As String
        Dim Unavailability15 As String
        Dim Unavailability16 As String
        Dim Unavailability17 As String
        Dim Unavailability18 As String
        Dim Unavailability19 As String

    End Structure


    Public Sub GenerateRota()

        System.Threading.Thread.Sleep(2000) 'Waits a few seconds for the database to update

        sql = "Select * FROM Volunteer WHERE LinkedUser = " & SelectedUser 'Uses and SQL statement to select the Login form
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "Volunteer") 'Fills the data adapter with the data set and calls it jobs

        NoOfVolunteers = ds.Tables("Volunteer").Rows.Count 'Counts the number of row in the jobs table

        Dim Volunteer(NoOfVolunteers) As Volunteer

        VolunteerData(Volunteer)

        ColumnNames()

        Dim DaysInMonth As Integer = System.DateTime.DaysInMonth(RotaYear, RotaMonthInteger) 'Finds the number of days in the month of the new rota
        Dim FirstSunday As Date = "#01/" & RotaMonthInteger & "/" & RotaYear & "#" 'Gets the first day of the month

        Dim CurrentDate As DateTime = New DateTime(RotaYear, RotaMonthInteger, 1)

        Counter = 1

        ' Keep looping, adding day's to the start date until sunday is reached  
        For x As Integer = 1 To 31 'For 1st to the max dasys in a month
            If CurrentDate.DayOfWeek = DayOfWeek.Sunday And CurrentDate < DaysInMonth & "/" & RotaMonthInteger & "/" & RotaYear Then 'If the day is a Sunday then this will run
                SundayDate(Counter) = CurrentDate 'Adds the Date to the array as it is a Sunday
                Counter = Counter + 1
            End If
            CurrentDate = CurrentDate.AddDays(1) 'Goes to the next day
        Next

        NoOfSundays = Counter 'Number of sundays in the month

        Counter = 0

        ds.Clear()

        sql = "Select * FROM Rota" 'Uses and SQL statement to select the Login form
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "Rota") 'Fills the data adapter with the data set and calls it jobs

        sql = "Select * FROM VolunteerStatistics" 'Uses and SQL statement to select the Login form
        da2 = New OleDb.OleDbDataAdapter(sql, con)
        da2.Fill(ds, "VolunteerStatistics") 'Fills the data adapter with the data set and calls it jobs

        Dim StatisticsRows As Integer = ds.Tables("VolunteerStatistics").Rows.Count - 1
        MaxRows = ds.Tables("Rota").Rows.Count

        RotaID = ds.Tables("Rota").Rows(NewRow).Item(0)
        RotaDate = ds.Tables("Rota").Rows(NewRow).Item(1)

        Dim NoVolunteersWithJob As Integer

        Dim rng As New Random 'To create a random number

        For x = 1 To NoOfVolunteers 'Resets the data
            Volunteer(x).HasJob = False
        Next


        Do Until NoVolunteersWithJob = NoOfVolunteers Or MaxJobs = NoOfJobFilled 'If all the volunteer has a job or all the jobs are filled then this will run
            Counter = rng.Next(1, NoOfVolunteers + 1) 'Gets a random number
            If Volunteer(Counter).HasJob = False Then 'If the volunteer doesn't have a job then it will run this
                For j = 1 To MaxJobs 'Goes for each of the jobs
                    If VolunteerColumnName(j).IsJobFiled = False Then 'If this selected job isn't filled then this will run
                        If Volunteer(Counter).Unavailability1 <> CStr(SundayDate(1)) And Volunteer(Counter).Unavailability2 <> CStr(SundayDate(1)) And Volunteer(Counter).Unavailability3 <> CStr(SundayDate(1)) And Volunteer(Counter).Unavailability4 <> CStr(SundayDate(1)) And Volunteer(Counter).Unavailability5 <> CStr(SundayDate(1)) And Volunteer(Counter).Unavailability6 <> CStr(SundayDate(1)) And Volunteer(Counter).Unavailability7 <> CStr(SundayDate(1)) And Volunteer(Counter).Unavailability8 <> CStr(SundayDate(1)) And Volunteer(Counter).Unavailability9 <> CStr(SundayDate(1)) And Volunteer(Counter).Unavailability10 <> CStr(SundayDate(1)) And Volunteer(Counter).Unavailability11 <> CStr(SundayDate(1)) And Volunteer(Counter).Unavailability12 <> CStr(SundayDate(1)) And Volunteer(Counter).Unavailability13 <> CStr(SundayDate(1)) And Volunteer(Counter).Unavailability14 <> CStr(SundayDate(1)) And Volunteer(Counter).Unavailability15 <> CStr(SundayDate(1)) And Volunteer(Counter).Unavailability16 <> CStr(SundayDate(1)) And Volunteer(Counter).Unavailability17 <> CStr(SundayDate(1)) And Volunteer(Counter).Unavailability18 <> CStr(SundayDate(1)) And Volunteer(Counter).Unavailability19 <> CStr(SundayDate(1)) Then
                            If Volunteer(Counter).JobQualified1 = (VolunteerColumnName(j).Name.Remove(0, 2)).Substring(0, (VolunteerColumnName(j).Name.Remove(0, 1)).Length - 2) Then
                                ds.Tables("Rota").Rows(NewRow).Item(VolunteerColumnName(j).Name.ToString) = Volunteer(Counter).FirstName & " " & Volunteer(Counter).LastName 'Adds to the database
                                VolunteerColumnName(j).IsJobFiled = True 'Tells the program that the job has been filled
                                Volunteer(Counter).TimesOn = Volunteer(Counter).TimesOn + 1 'Updates the statistic
                                NoVolunteersWithJob = NoOfVolunteers + 1
                                Volunteer(Counter).HasJob = True 'Tells the program that the volunteer has a job
                                NoOfJobFilled = NoOfJobFilled + 1
                                For x = 0 To StatisticsRows 'Adds to the statistic database
                                    If ds.Tables("VolunteerStatistics").Rows(x).Item(0) = Volunteer(Counter).Identification Then
                                        ds.Tables("VolunteerStatistics").Rows(x).Item(1) = ds.Tables("VolunteerStatistics").Rows(x).Item(1) + 1
                                    End If
                                Next
                                Exit For
                            ElseIf Volunteer(Counter).JobQualified2 = (VolunteerColumnName(j).Name.Remove(0, 2)).Substring(0, (VolunteerColumnName(j).Name.Remove(0, 1)).Length - 2) Then
                                ds.Tables("Rota").Rows(NewRow).Item(VolunteerColumnName(j).Name.ToString) = Volunteer(Counter).FirstName & " " & Volunteer(Counter).LastName
                                VolunteerColumnName(j).IsJobFiled = True
                                Volunteer(Counter).TimesOn = Volunteer(Counter).TimesOn + 1
                                NoVolunteersWithJob = NoOfVolunteers + 1
                                Volunteer(Counter).HasJob = True
                                NoOfJobFilled = NoOfJobFilled + 1
                                For x = 0 To StatisticsRows
                                    If ds.Tables("VolunteerStatistics").Rows(x).Item(0) = Volunteer(Counter).Identification Then
                                        ds.Tables("VolunteerStatistics").Rows(x).Item(1) = ds.Tables("VolunteerStatistics").Rows(x).Item(1) + 1
                                    End If
                                Next
                                Exit For
                            ElseIf Volunteer(Counter).JobQualified3 = (VolunteerColumnName(j).Name.Remove(0, 2)).Substring(0, (VolunteerColumnName(j).Name.Remove(0, 1)).Length - 2) Then
                                ds.Tables("Rota").Rows(NewRow).Item(VolunteerColumnName(j).Name.ToString) = Volunteer(Counter).FirstName & " " & Volunteer(Counter).LastName
                                VolunteerColumnName(j).IsJobFiled = True
                                Volunteer(Counter).TimesOn = Volunteer(Counter).TimesOn + 1
                                Volunteer(Counter).HasJob = True
                                NoOfJobFilled = NoOfJobFilled + 1
                                For x = 0 To StatisticsRows
                                    If ds.Tables("VolunteerStatistics").Rows(x).Item(0) = Volunteer(Counter).Identification Then
                                        ds.Tables("VolunteerStatistics").Rows(x).Item(1) = ds.Tables("VolunteerStatistics").Rows(x).Item(1) + 1
                                    End If
                                Next
                                Exit For
                            ElseIf Volunteer(Counter).JobQualified4 = (VolunteerColumnName(j).Name.Remove(0, 2)).Substring(0, (VolunteerColumnName(j).Name.Remove(0, 1)).Length - 2) Then
                                ds.Tables("Rota").Rows(NewRow).Item(VolunteerColumnName(j).Name.ToString) = Volunteer(Counter).FirstName & " " & Volunteer(Counter).LastName
                                VolunteerColumnName(j).IsJobFiled = True
                                Volunteer(Counter).TimesOn = Volunteer(Counter).TimesOn + 1
                                Volunteer(Counter).HasJob = True
                                NoOfJobFilled = NoOfJobFilled + 1
                                For x = 0 To StatisticsRows
                                    If ds.Tables("VolunteerStatistics").Rows(x).Item(0) = Volunteer(Counter).Identification Then
                                        ds.Tables("VolunteerStatistics").Rows(x).Item(1) = ds.Tables("VolunteerStatistics").Rows(x).Item(1) + 1
                                    End If
                                Next
                                Exit For
                            ElseIf Volunteer(Counter).JobQualified5 = (VolunteerColumnName(j).Name.Remove(0, 2)).Substring(0, (VolunteerColumnName(j).Name.Remove(0, 1)).Length - 2) Then
                                ds.Tables("Rota").Rows(NewRow).Item(VolunteerColumnName(j).Name.ToString) = Volunteer(Counter).FirstName & " " & Volunteer(Counter).LastName
                                VolunteerColumnName(j).IsJobFiled = True
                                Volunteer(Counter).TimesOn = Volunteer(Counter).TimesOn + 1
                                Volunteer(Counter).HasJob = True
                                NoOfJobFilled = NoOfJobFilled + 1
                                For x = 0 To StatisticsRows
                                    If ds.Tables("VolunteerStatistics").Rows(x).Item(0) = Volunteer(Counter).Identification Then
                                        ds.Tables("VolunteerStatistics").Rows(x).Item(1) = ds.Tables("VolunteerStatistics").Rows(x).Item(1) + 1
                                    End If
                                Next
                                Exit For
                            End If
                        End If
                    End If
                Next
            End If
        Loop

        ds.Tables("Rota").Rows(NewRow).Item(3) = CStr(SundayDate(1)) 'Adds the date to the volunteer

        Dim cb2 As New OleDb.OleDbCommandBuilder(da)

        da.Update(ds, "Rota") 'Updates the table

        Dim cb As New OleDb.OleDbCommandBuilder(da2)
        da2.Update(ds, "VolunteerStatistics") 'Updates the volunteer statistics








        For x = 1 To 30 'Resets the data
            VolunteerColumnName(x).IsJobFiled = False
        Next

        For x = 1 To NoOfVolunteers 'Resets the data
            Volunteer(x).HasJob = False
        Next



        cb = New OleDb.OleDbCommandBuilder(da)
        Dim dsNewRow As DataRow

        dsNewRow = ds.Tables("Rota").NewRow 'Creates a new row


        dsNewRow.Item(0) = RotaID
        dsNewRow.Item(1) = RotaDate
        dsNewRow.Item(2) = SelectedUser
        dsNewRow.Item(3) = CStr(SundayDate(2))

        ds.Tables("Rota").Rows.Add(dsNewRow)
        da.Update(ds, "Rota") 'Updates the table

        NoVolunteersWithJob = 0
        NoOfJobFilled = 0

        MaxRows = MaxRows

        Do Until NoVolunteersWithJob = NoOfVolunteers Or MaxJobs = NoOfJobFilled
            Counter = rng.Next(1, NoOfVolunteers + 1)
            If Volunteer(Counter).HasJob = False Then
                If Volunteer(Counter).TimesOn < Volunteer(Counter).MaxTimes Then
                    For j = 1 To MaxJobs
                        If VolunteerColumnName(j).IsJobFiled = False Then
                            If Volunteer(Counter).Unavailability3 <> CStr(SundayDate(2)) And Volunteer(Counter).Unavailability2 <> CStr(SundayDate(2)) And Volunteer(Counter).Unavailability3 <> CStr(SundayDate(2)) And Volunteer(Counter).Unavailability4 <> CStr(SundayDate(2)) And Volunteer(Counter).Unavailability5 <> CStr(SundayDate(2)) And Volunteer(Counter).Unavailability6 <> CStr(SundayDate(2)) And Volunteer(Counter).Unavailability7 <> CStr(SundayDate(2)) And Volunteer(Counter).Unavailability8 <> CStr(SundayDate(2)) And Volunteer(Counter).Unavailability9 <> CStr(SundayDate(2)) And Volunteer(Counter).Unavailability10 <> CStr(SundayDate(2)) And Volunteer(Counter).Unavailability11 <> CStr(SundayDate(2)) And Volunteer(Counter).Unavailability12 <> CStr(SundayDate(2)) And Volunteer(Counter).Unavailability13 <> CStr(SundayDate(2)) And Volunteer(Counter).Unavailability14 <> CStr(SundayDate(2)) And Volunteer(Counter).Unavailability15 <> CStr(SundayDate(2)) And Volunteer(Counter).Unavailability16 <> CStr(SundayDate(2)) And Volunteer(Counter).Unavailability17 <> CStr(SundayDate(2)) And Volunteer(Counter).Unavailability18 <> CStr(SundayDate(2)) And Volunteer(Counter).Unavailability19 <> CStr(SundayDate(2)) Then
                                If Volunteer(Counter).JobQualified1 = (VolunteerColumnName(j).Name.Remove(0, 2)).Substring(0, (VolunteerColumnName(j).Name.Remove(0, 1)).Length - 2) Then
                                    ds.Tables("Rota").Rows(MaxRows).Item(VolunteerColumnName(j).Name.ToString) = Volunteer(Counter).FirstName & " " & Volunteer(Counter).LastName
                                    VolunteerColumnName(j).IsJobFiled = True
                                    Volunteer(Counter).TimesOn = Volunteer(Counter).TimesOn + 1
                                    Volunteer(Counter).HasJob = True
                                    NoOfJobFilled = NoOfJobFilled + 1
                                    For x = 0 To StatisticsRows
                                        If ds.Tables("VolunteerStatistics").Rows(x).Item(0) = Volunteer(Counter).Identification Then
                                            ds.Tables("VolunteerStatistics").Rows(x).Item(1) = ds.Tables("VolunteerStatistics").Rows(x).Item(1) + 1
                                        End If
                                    Next
                                    Exit For
                                ElseIf Volunteer(Counter).JobQualified4 = (VolunteerColumnName(j).Name.Remove(0, 2)).Substring(0, (VolunteerColumnName(j).Name.Remove(0, 1)).Length - 2) Then
                                    ds.Tables("Rota").Rows(MaxRows).Item(VolunteerColumnName(j).Name.ToString) = Volunteer(Counter).FirstName & " " & Volunteer(Counter).LastName
                                    VolunteerColumnName(j).IsJobFiled = True
                                    Volunteer(Counter).TimesOn = Volunteer(Counter).TimesOn + 1
                                    Volunteer(Counter).HasJob = True
                                    NoOfJobFilled = NoOfJobFilled + 1
                                    For x = 0 To StatisticsRows
                                        If ds.Tables("VolunteerStatistics").Rows(x).Item(0) = Volunteer(Counter).Identification Then
                                            ds.Tables("VolunteerStatistics").Rows(x).Item(1) = ds.Tables("VolunteerStatistics").Rows(x).Item(1) + 1
                                        End If
                                    Next
                                    Exit For
                                ElseIf Volunteer(Counter).JobQualified1 = (VolunteerColumnName(j).Name.Remove(0, 2)).Substring(0, (VolunteerColumnName(j).Name.Remove(0, 1)).Length - 2) Then
                                    ds.Tables("Rota").Rows(MaxRows).Item(VolunteerColumnName(j).Name.ToString) = Volunteer(Counter).FirstName & " " & Volunteer(Counter).LastName
                                    VolunteerColumnName(j).IsJobFiled = True
                                    Volunteer(Counter).TimesOn = Volunteer(Counter).TimesOn + 1
                                    Volunteer(Counter).HasJob = True
                                    NoOfJobFilled = NoOfJobFilled + 1
                                    For x = 0 To StatisticsRows
                                        If ds.Tables("VolunteerStatistics").Rows(x).Item(0) = Volunteer(Counter).Identification Then
                                            ds.Tables("VolunteerStatistics").Rows(x).Item(1) = ds.Tables("VolunteerStatistics").Rows(x).Item(1) + 1
                                        End If
                                    Next
                                    Exit For
                                ElseIf Volunteer(Counter).JobQualified3 = (VolunteerColumnName(j).Name.Remove(0, 2)).Substring(0, (VolunteerColumnName(j).Name.Remove(0, 1)).Length - 2) Then
                                    ds.Tables("Rota").Rows(MaxRows).Item(VolunteerColumnName(j).Name.ToString) = Volunteer(Counter).FirstName & " " & Volunteer(Counter).LastName
                                    VolunteerColumnName(j).IsJobFiled = True
                                    Volunteer(Counter).TimesOn = Volunteer(Counter).TimesOn + 1
                                    Volunteer(Counter).HasJob = True
                                    NoOfJobFilled = NoOfJobFilled + 1
                                    For x = 0 To StatisticsRows
                                        If ds.Tables("VolunteerStatistics").Rows(x).Item(0) = Volunteer(Counter).Identification Then
                                            ds.Tables("VolunteerStatistics").Rows(x).Item(1) = ds.Tables("VolunteerStatistics").Rows(x).Item(1) + 1
                                        End If
                                    Next
                                    Exit For
                                ElseIf Volunteer(Counter).JobQualified2 = (VolunteerColumnName(j).Name.Remove(0, 2)).Substring(0, (VolunteerColumnName(j).Name.Remove(0, 1)).Length - 2) Then
                                    ds.Tables("Rota").Rows(MaxRows).Item(VolunteerColumnName(j).Name.ToString) = Volunteer(Counter).FirstName & " " & Volunteer(Counter).LastName
                                    VolunteerColumnName(j).IsJobFiled = True
                                    Volunteer(Counter).TimesOn = Volunteer(Counter).TimesOn + 1
                                    Volunteer(Counter).HasJob = True
                                    NoOfJobFilled = NoOfJobFilled + 1
                                    For x = 0 To StatisticsRows
                                        If ds.Tables("VolunteerStatistics").Rows(x).Item(0) = Volunteer(Counter).Identification Then
                                            ds.Tables("VolunteerStatistics").Rows(x).Item(1) = ds.Tables("VolunteerStatistics").Rows(x).Item(1) + 1
                                        End If
                                    Next
                                    Exit For
                                End If
                            End If
                        End If
                    Next
                End If
            End If
        Loop

        cb = New OleDb.OleDbCommandBuilder(da)

        da.Update(ds, "Rota") 'Updates the table

        cb = New OleDb.OleDbCommandBuilder(da2)

        da2.Update(ds, "VolunteerStatistics") 'Updates the table






        For x = 1 To 30
            VolunteerColumnName(x).IsJobFiled = False
        Next

        For x = 1 To NoOfVolunteers
            Volunteer(x).HasJob = False
        Next


        dsNewRow = ds.Tables("Rota").NewRow

        MaxRows = MaxRows + 1

        dsNewRow.Item(0) = RotaID
        dsNewRow.Item(1) = RotaDate
        dsNewRow.Item(2) = SelectedUser
        dsNewRow.Item(3) = CStr(SundayDate(3))

        ds.Tables("Rota").Rows.Add(dsNewRow)
        da.Update(ds, "Rota") 'Updates the table

        NoVolunteersWithJob = 0
        NoOfJobFilled = 0

        Do Until NoVolunteersWithJob = NoOfVolunteers Or MaxJobs = NoOfJobFilled
            Counter = rng.Next(1, NoOfVolunteers + 1)
            If Volunteer(Counter).HasJob = False Then
                If Volunteer(Counter).TimesOn < Volunteer(Counter).MaxTimes Then
                    For j = 1 To MaxJobs
                        If VolunteerColumnName(j).IsJobFiled = False Then
                            If Volunteer(Counter).Unavailability1 <> CStr(SundayDate(3)) And Volunteer(Counter).Unavailability2 <> CStr(SundayDate(3)) And Volunteer(Counter).Unavailability3 <> CStr(SundayDate(3)) And Volunteer(Counter).Unavailability4 <> CStr(SundayDate(3)) And Volunteer(Counter).Unavailability5 <> CStr(SundayDate(3)) And Volunteer(Counter).Unavailability6 <> CStr(SundayDate(3)) And Volunteer(Counter).Unavailability7 <> CStr(SundayDate(3)) And Volunteer(Counter).Unavailability8 <> CStr(SundayDate(3)) And Volunteer(Counter).Unavailability9 <> CStr(SundayDate(3)) And Volunteer(Counter).Unavailability10 <> CStr(SundayDate(3)) And Volunteer(Counter).Unavailability11 <> CStr(SundayDate(3)) And Volunteer(Counter).Unavailability12 <> CStr(SundayDate(3)) And Volunteer(Counter).Unavailability13 <> CStr(SundayDate(3)) And Volunteer(Counter).Unavailability14 <> CStr(SundayDate(3)) And Volunteer(Counter).Unavailability15 <> CStr(SundayDate(3)) And Volunteer(Counter).Unavailability16 <> CStr(SundayDate(3)) And Volunteer(Counter).Unavailability17 <> CStr(SundayDate(3)) And Volunteer(Counter).Unavailability18 <> CStr(SundayDate(3)) And Volunteer(Counter).Unavailability19 <> CStr(SundayDate(3)) Then
                                If Volunteer(Counter).JobQualified5 = (VolunteerColumnName(j).Name.Remove(0, 2)).Substring(0, (VolunteerColumnName(j).Name.Remove(0, 1)).Length - 2) Then
                                    ds.Tables("Rota").Rows(MaxRows).Item(VolunteerColumnName(j).Name.ToString) = Volunteer(Counter).FirstName & " " & Volunteer(Counter).LastName
                                    VolunteerColumnName(j).IsJobFiled = True
                                    Volunteer(Counter).TimesOn = Volunteer(Counter).TimesOn + 1
                                    Volunteer(Counter).HasJob = True
                                    NoOfJobFilled = NoOfJobFilled + 1
                                    For x = 0 To StatisticsRows
                                        If ds.Tables("VolunteerStatistics").Rows(x).Item(0) = Volunteer(Counter).Identification Then
                                            ds.Tables("VolunteerStatistics").Rows(x).Item(1) = ds.Tables("VolunteerStatistics").Rows(x).Item(1) + 1
                                        End If
                                    Next
                                    Exit For
                                ElseIf Volunteer(Counter).JobQualified3 = (VolunteerColumnName(j).Name.Remove(0, 2)).Substring(0, (VolunteerColumnName(j).Name.Remove(0, 1)).Length - 2) Then
                                    ds.Tables("Rota").Rows(MaxRows).Item(VolunteerColumnName(j).Name.ToString) = Volunteer(Counter).FirstName & " " & Volunteer(Counter).LastName
                                    VolunteerColumnName(j).IsJobFiled = True
                                    Volunteer(Counter).TimesOn = Volunteer(Counter).TimesOn + 1
                                    Volunteer(Counter).HasJob = True
                                    NoOfJobFilled = NoOfJobFilled + 1
                                    For x = 0 To StatisticsRows
                                        If ds.Tables("VolunteerStatistics").Rows(x).Item(0) = Volunteer(Counter).Identification Then
                                            ds.Tables("VolunteerStatistics").Rows(x).Item(1) = ds.Tables("VolunteerStatistics").Rows(x).Item(1) + 1
                                        End If
                                    Next
                                    Exit For
                                ElseIf Volunteer(Counter).JobQualified1 = (VolunteerColumnName(j).Name.Remove(0, 2)).Substring(0, (VolunteerColumnName(j).Name.Remove(0, 1)).Length - 2) Then
                                    ds.Tables("Rota").Rows(MaxRows).Item(VolunteerColumnName(j).Name.ToString) = Volunteer(Counter).FirstName & " " & Volunteer(Counter).LastName
                                    VolunteerColumnName(j).IsJobFiled = True
                                    Volunteer(Counter).TimesOn = Volunteer(Counter).TimesOn + 1
                                    Volunteer(Counter).HasJob = True
                                    NoOfJobFilled = NoOfJobFilled + 1
                                    For x = 0 To StatisticsRows
                                        If ds.Tables("VolunteerStatistics").Rows(x).Item(0) = Volunteer(Counter).Identification Then
                                            ds.Tables("VolunteerStatistics").Rows(x).Item(1) = ds.Tables("VolunteerStatistics").Rows(x).Item(1) + 1
                                        End If
                                    Next
                                    Exit For
                                ElseIf Volunteer(Counter).JobQualified4 = (VolunteerColumnName(j).Name.Remove(0, 2)).Substring(0, (VolunteerColumnName(j).Name.Remove(0, 1)).Length - 2) Then
                                    ds.Tables("Rota").Rows(MaxRows).Item(VolunteerColumnName(j).Name.ToString) = Volunteer(Counter).FirstName & " " & Volunteer(Counter).LastName
                                    VolunteerColumnName(j).IsJobFiled = True
                                    Volunteer(Counter).TimesOn = Volunteer(Counter).TimesOn + 1
                                    Volunteer(Counter).HasJob = True
                                    NoOfJobFilled = NoOfJobFilled + 1
                                    For x = 0 To StatisticsRows
                                        If ds.Tables("VolunteerStatistics").Rows(x).Item(0) = Volunteer(Counter).Identification Then
                                            ds.Tables("VolunteerStatistics").Rows(x).Item(1) = ds.Tables("VolunteerStatistics").Rows(x).Item(1) + 1
                                        End If
                                    Next
                                    Exit For
                                ElseIf Volunteer(Counter).JobQualified2 = (VolunteerColumnName(j).Name.Remove(0, 2)).Substring(0, (VolunteerColumnName(j).Name.Remove(0, 1)).Length - 2) Then
                                    ds.Tables("Rota").Rows(MaxRows).Item(VolunteerColumnName(j).Name.ToString) = Volunteer(Counter).FirstName & " " & Volunteer(Counter).LastName
                                    VolunteerColumnName(j).IsJobFiled = True
                                    Volunteer(Counter).TimesOn = Volunteer(Counter).TimesOn + 1
                                    Volunteer(Counter).HasJob = True
                                    NoOfJobFilled = NoOfJobFilled + 1
                                    For x = 0 To StatisticsRows
                                        If ds.Tables("VolunteerStatistics").Rows(x).Item(0) = Volunteer(Counter).Identification Then
                                            ds.Tables("VolunteerStatistics").Rows(x).Item(1) = ds.Tables("VolunteerStatistics").Rows(x).Item(1) + 1
                                        End If
                                    Next
                                    Exit For
                                End If
                            End If
                        End If

                    Next
                End If
            End If
        Loop

        cb = New OleDb.OleDbCommandBuilder(da)

        da.Update(ds, "Rota") 'Updates the table

        cb = New OleDb.OleDbCommandBuilder(da2)

        da2.Update(ds, "VolunteerStatistics") 'Updates the table





        For x = 1 To 30
            VolunteerColumnName(x).IsJobFiled = False
        Next

        For x = 1 To NoOfVolunteers
            Volunteer(x).HasJob = False
        Next

        dsNewRow = ds.Tables("Rota").NewRow

        MaxRows = ds.Tables("Rota").Rows.Count - 1

        dsNewRow.Item(0) = RotaID
        dsNewRow.Item(1) = RotaDate
        dsNewRow.Item(2) = SelectedUser
        dsNewRow.Item(3) = CStr(SundayDate(4))

        ds.Tables("Rota").Rows.Add(dsNewRow)
        da.Update(ds, "Rota") 'Updates the table

        MaxRows = MaxRows + 1

        NoVolunteersWithJob = 0
        NoOfJobFilled = 0

        Do Until NoVolunteersWithJob = NoOfVolunteers Or MaxJobs = NoOfJobFilled
            Counter = rng.Next(1, NoOfVolunteers + 1)
            If Volunteer(Counter).HasJob = False Then
                If Volunteer(Counter).TimesOn < Volunteer(Counter).MaxTimes Then
                    For j = 1 To MaxJobs
                        If VolunteerColumnName(j).IsJobFiled = False Then
                            If Volunteer(Counter).Unavailability1 <> CStr(SundayDate(4)) And Volunteer(Counter).Unavailability2 <> CStr(SundayDate(4)) And Volunteer(Counter).Unavailability3 <> CStr(SundayDate(4)) And Volunteer(Counter).Unavailability4 <> CStr(SundayDate(4)) And Volunteer(Counter).Unavailability5 <> CStr(SundayDate(4)) And Volunteer(Counter).Unavailability6 <> CStr(SundayDate(4)) And Volunteer(Counter).Unavailability7 <> CStr(SundayDate(4)) And Volunteer(Counter).Unavailability8 <> CStr(SundayDate(4)) And Volunteer(Counter).Unavailability9 <> CStr(SundayDate(4)) And Volunteer(Counter).Unavailability10 <> CStr(SundayDate(4)) And Volunteer(Counter).Unavailability11 <> CStr(SundayDate(4)) And Volunteer(Counter).Unavailability12 <> CStr(SundayDate(4)) And Volunteer(Counter).Unavailability13 <> CStr(SundayDate(4)) And Volunteer(Counter).Unavailability14 <> CStr(SundayDate(4)) And Volunteer(Counter).Unavailability15 <> CStr(SundayDate(4)) And Volunteer(Counter).Unavailability16 <> CStr(SundayDate(4)) And Volunteer(Counter).Unavailability17 <> CStr(SundayDate(4)) And Volunteer(Counter).Unavailability18 <> CStr(SundayDate(4)) And Volunteer(Counter).Unavailability19 <> CStr(SundayDate(4)) Then
                                If Volunteer(Counter).JobQualified2 = (VolunteerColumnName(j).Name.Remove(0, 2)).Substring(0, (VolunteerColumnName(j).Name.Remove(0, 1)).Length - 2) Then
                                    ds.Tables("Rota").Rows(MaxRows).Item(VolunteerColumnName(j).Name.ToString) = Volunteer(Counter).FirstName & " " & Volunteer(Counter).LastName
                                    VolunteerColumnName(j).IsJobFiled = True
                                    Volunteer(Counter).TimesOn = Volunteer(Counter).TimesOn + 1
                                    Volunteer(Counter).HasJob = True
                                    NoOfJobFilled = NoOfJobFilled + 1
                                    For x = 0 To StatisticsRows
                                        If ds.Tables("VolunteerStatistics").Rows(x).Item(0) = Volunteer(Counter).Identification Then
                                            ds.Tables("VolunteerStatistics").Rows(x).Item(1) = ds.Tables("VolunteerStatistics").Rows(x).Item(1) + 1
                                        End If
                                    Next
                                    Exit For
                                ElseIf Volunteer(Counter).JobQualified3 = (VolunteerColumnName(j).Name.Remove(0, 2)).Substring(0, (VolunteerColumnName(j).Name.Remove(0, 1)).Length - 2) Then
                                    ds.Tables("Rota").Rows(MaxRows).Item(VolunteerColumnName(j).Name.ToString) = Volunteer(Counter).FirstName & " " & Volunteer(Counter).LastName
                                    VolunteerColumnName(j).IsJobFiled = True
                                    Volunteer(Counter).TimesOn = Volunteer(Counter).TimesOn + 1
                                    Volunteer(Counter).HasJob = True
                                    NoOfJobFilled = NoOfJobFilled + 1
                                    For x = 0 To StatisticsRows
                                        If ds.Tables("VolunteerStatistics").Rows(x).Item(0) = Volunteer(Counter).Identification Then
                                            ds.Tables("VolunteerStatistics").Rows(x).Item(1) = ds.Tables("VolunteerStatistics").Rows(x).Item(1) + 1
                                        End If
                                    Next
                                    Exit For
                                ElseIf Volunteer(Counter).JobQualified1 = (VolunteerColumnName(j).Name.Remove(0, 2)).Substring(0, (VolunteerColumnName(j).Name.Remove(0, 1)).Length - 2) Then
                                    ds.Tables("Rota").Rows(MaxRows).Item(VolunteerColumnName(j).Name.ToString) = Volunteer(Counter).FirstName & " " & Volunteer(Counter).LastName
                                    VolunteerColumnName(j).IsJobFiled = True
                                    Volunteer(Counter).TimesOn = Volunteer(Counter).TimesOn + 1
                                    Volunteer(Counter).HasJob = True
                                    NoOfJobFilled = NoOfJobFilled + 1
                                    For x = 0 To StatisticsRows
                                        If ds.Tables("VolunteerStatistics").Rows(x).Item(0) = Volunteer(Counter).Identification Then
                                            ds.Tables("VolunteerStatistics").Rows(x).Item(1) = ds.Tables("VolunteerStatistics").Rows(x).Item(1) + 1
                                        End If
                                    Next
                                    Exit For
                                ElseIf Volunteer(Counter).JobQualified5 = (VolunteerColumnName(j).Name.Remove(0, 2)).Substring(0, (VolunteerColumnName(j).Name.Remove(0, 1)).Length - 2) Then
                                    ds.Tables("Rota").Rows(MaxRows).Item(VolunteerColumnName(j).Name.ToString) = Volunteer(Counter).FirstName & " " & Volunteer(Counter).LastName
                                    VolunteerColumnName(j).IsJobFiled = True
                                    Volunteer(Counter).TimesOn = Volunteer(Counter).TimesOn + 1
                                    Volunteer(Counter).HasJob = True
                                    NoOfJobFilled = NoOfJobFilled + 1
                                    For x = 0 To StatisticsRows
                                        If ds.Tables("VolunteerStatistics").Rows(x).Item(0) = Volunteer(Counter).Identification Then
                                            ds.Tables("VolunteerStatistics").Rows(x).Item(1) = ds.Tables("VolunteerStatistics").Rows(x).Item(1) + 1
                                        End If
                                    Next
                                    Exit For
                                ElseIf Volunteer(Counter).JobQualified4 = (VolunteerColumnName(j).Name.Remove(0, 2)).Substring(0, (VolunteerColumnName(j).Name.Remove(0, 1)).Length - 2) Then
                                    ds.Tables("Rota").Rows(MaxRows).Item(VolunteerColumnName(j).Name.ToString) = Volunteer(Counter).FirstName & " " & Volunteer(Counter).LastName
                                    VolunteerColumnName(j).IsJobFiled = True
                                    Volunteer(Counter).TimesOn = Volunteer(Counter).TimesOn + 1
                                    Volunteer(Counter).HasJob = True
                                    NoOfJobFilled = NoOfJobFilled + 1
                                    For x = 0 To StatisticsRows
                                        If ds.Tables("VolunteerStatistics").Rows(x).Item(0) = Volunteer(Counter).Identification Then
                                            ds.Tables("VolunteerStatistics").Rows(x).Item(1) = ds.Tables("VolunteerStatistics").Rows(x).Item(1) + 1
                                        End If
                                    Next
                                    Exit For
                                End If
                            End If
                        End If
                    Next
                End If
            End If
        Loop

        cb = New OleDb.OleDbCommandBuilder(da)

        da.Update(ds, "Rota") 'Updates the table

        cb = New OleDb.OleDbCommandBuilder(da2)

        da2.Update(ds, "VolunteerStatistics") 'Updates the table







        If SundayDate(5) <> Nothing Then 'If the month does have 5 Sundays then this will run

            For x = 1 To 30
                VolunteerColumnName(x).IsJobFiled = False
            Next

            For x = 1 To NoOfVolunteers
                Volunteer(x).HasJob = False
            Next

            dsNewRow = ds.Tables("Rota").NewRow



            dsNewRow.Item(0) = RotaID
            dsNewRow.Item(1) = RotaDate
            dsNewRow.Item(2) = SelectedUser
            dsNewRow.Item(3) = CStr(SundayDate(5))

            ds.Tables("Rota").Rows.Add(dsNewRow)
            da.Update(ds, "Rota") 'Updates the table

            MaxRows = MaxRows + 1

            NoVolunteersWithJob = 0
            NoOfJobFilled = 0

            Do Until NoVolunteersWithJob = NoOfVolunteers Or MaxJobs = NoOfJobFilled
                Counter = rng.Next(1, NoOfVolunteers + 1)
                If Volunteer(Counter).HasJob = False Then
                    If Volunteer(Counter).TimesOn < Volunteer(Counter).MaxTimes Then
                        For j = 1 To MaxJobs
                            If VolunteerColumnName(j).IsJobFiled = False Then
                                If Volunteer(Counter).Unavailability1 <> CStr(SundayDate(5)) And Volunteer(Counter).Unavailability2 <> CStr(SundayDate(5)) And Volunteer(Counter).Unavailability3 <> CStr(SundayDate(5)) And Volunteer(Counter).Unavailability4 <> CStr(SundayDate(5)) And Volunteer(Counter).Unavailability5 <> CStr(SundayDate(5)) And Volunteer(Counter).Unavailability6 <> CStr(SundayDate(5)) And Volunteer(Counter).Unavailability7 <> CStr(SundayDate(5)) And Volunteer(Counter).Unavailability8 <> CStr(SundayDate(5)) And Volunteer(Counter).Unavailability9 <> CStr(SundayDate(5)) And Volunteer(Counter).Unavailability10 <> CStr(SundayDate(5)) And Volunteer(Counter).Unavailability11 <> CStr(SundayDate(5)) And Volunteer(Counter).Unavailability12 <> CStr(SundayDate(5)) And Volunteer(Counter).Unavailability13 <> CStr(SundayDate(5)) And Volunteer(Counter).Unavailability14 <> CStr(SundayDate(5)) And Volunteer(Counter).Unavailability15 <> CStr(SundayDate(5)) And Volunteer(Counter).Unavailability16 <> CStr(SundayDate(5)) And Volunteer(Counter).Unavailability17 <> CStr(SundayDate(5)) And Volunteer(Counter).Unavailability18 <> CStr(SundayDate(5)) And Volunteer(Counter).Unavailability19 <> CStr(SundayDate(5)) Then
                                    If Volunteer(Counter).JobQualified1 = (VolunteerColumnName(j).Name.Remove(0, 2)).Substring(0, (VolunteerColumnName(j).Name.Remove(0, 1)).Length - 2) Then
                                        ds.Tables("Rota").Rows(MaxRows).Item(VolunteerColumnName(j).Name.ToString) = Volunteer(Counter).FirstName & " " & Volunteer(Counter).LastName
                                        VolunteerColumnName(j).IsJobFiled = True
                                        Volunteer(Counter).TimesOn = Volunteer(Counter).TimesOn + 1
                                        NoOfJobFilled = NoOfJobFilled + 1
                                        Volunteer(Counter).HasJob = True
                                        For x = 0 To StatisticsRows
                                            If ds.Tables("VolunteerStatistics").Rows(x).Item(0) = Volunteer(Counter).Identification Then
                                                ds.Tables("VolunteerStatistics").Rows(x).Item(1) = ds.Tables("VolunteerStatistics").Rows(x).Item(1) + 1
                                            End If
                                        Next
                                        Exit For
                                    ElseIf Volunteer(Counter).JobQualified2 = (VolunteerColumnName(j).Name.Remove(0, 2)).Substring(0, (VolunteerColumnName(j).Name.Remove(0, 1)).Length - 2) Then
                                        ds.Tables("Rota").Rows(MaxRows).Item(VolunteerColumnName(j).Name.ToString) = Volunteer(Counter).FirstName & " " & Volunteer(Counter).LastName
                                        VolunteerColumnName(j).IsJobFiled = True
                                        Volunteer(Counter).TimesOn = Volunteer(Counter).TimesOn + 1
                                        Volunteer(Counter).HasJob = True
                                        NoOfJobFilled = NoOfJobFilled + 1
                                        For x = 0 To StatisticsRows
                                            If ds.Tables("VolunteerStatistics").Rows(x).Item(0) = Volunteer(Counter).Identification Then
                                                ds.Tables("VolunteerStatistics").Rows(x).Item(1) = ds.Tables("VolunteerStatistics").Rows(x).Item(1) + 1
                                            End If
                                        Next
                                        Exit For
                                    ElseIf Volunteer(Counter).JobQualified5 = (VolunteerColumnName(j).Name.Remove(0, 2)).Substring(0, (VolunteerColumnName(j).Name.Remove(0, 1)).Length - 2) Then
                                        ds.Tables("Rota").Rows(MaxRows).Item(VolunteerColumnName(j).Name.ToString) = Volunteer(Counter).FirstName & " " & Volunteer(Counter).LastName
                                        VolunteerColumnName(j).IsJobFiled = True
                                        Volunteer(Counter).TimesOn = Volunteer(Counter).TimesOn + 1
                                        Volunteer(Counter).HasJob = True
                                        NoOfJobFilled = NoOfJobFilled + 1
                                        For x = 0 To StatisticsRows
                                            If ds.Tables("VolunteerStatistics").Rows(x).Item(0) = Volunteer(Counter).Identification Then
                                                ds.Tables("VolunteerStatistics").Rows(x).Item(1) = ds.Tables("VolunteerStatistics").Rows(x).Item(1) + 1
                                            End If
                                        Next
                                        Exit For
                                    ElseIf Volunteer(Counter).JobQualified3 = (VolunteerColumnName(j).Name.Remove(0, 2)).Substring(0, (VolunteerColumnName(j).Name.Remove(0, 1)).Length - 2) Then
                                        ds.Tables("Rota").Rows(MaxRows).Item(VolunteerColumnName(j).Name.ToString) = Volunteer(Counter).FirstName & " " & Volunteer(Counter).LastName
                                        VolunteerColumnName(j).IsJobFiled = True
                                        Volunteer(Counter).TimesOn = Volunteer(Counter).TimesOn + 1
                                        Volunteer(Counter).HasJob = True
                                        NoOfJobFilled = NoOfJobFilled + 1
                                        For x = 0 To StatisticsRows
                                            If ds.Tables("VolunteerStatistics").Rows(x).Item(0) = Volunteer(Counter).Identification Then
                                                ds.Tables("VolunteerStatistics").Rows(x).Item(1) = ds.Tables("VolunteerStatistics").Rows(x).Item(1) + 1
                                            End If
                                        Next
                                        Exit For
                                    ElseIf Volunteer(Counter).JobQualified4 = (VolunteerColumnName(j).Name.Remove(0, 2)).Substring(0, (VolunteerColumnName(j).Name.Remove(0, 1)).Length - 2) Then
                                        ds.Tables("Rota").Rows(MaxRows).Item(VolunteerColumnName(j).Name.ToString) = Volunteer(Counter).FirstName & " " & Volunteer(Counter).LastName
                                        VolunteerColumnName(j).IsJobFiled = True
                                        Volunteer(Counter).TimesOn = Volunteer(Counter).TimesOn + 1
                                        Volunteer(Counter).HasJob = True
                                        NoOfJobFilled = NoOfJobFilled + 1
                                        For x = 0 To StatisticsRows
                                            If ds.Tables("VolunteerStatistics").Rows(x).Item(0) = Volunteer(Counter).Identification Then
                                                ds.Tables("VolunteerStatistics").Rows(x).Item(1) = ds.Tables("VolunteerStatistics").Rows(x).Item(1) + 1
                                            End If
                                        Next
                                        Exit For
                                    End If
                                End If
                            End If
                        Next
                    End If
                End If
            Loop



            cb = New OleDb.OleDbCommandBuilder(da)

            da.Update(ds, "Rota") 'Updates the table

            cb = New OleDb.OleDbCommandBuilder(da2)

            da2.Update(ds, "VolunteerStatistics") 'Updates the table
        End If


    End Sub


    Public Sub VolunteerData(ByVal Volunteer() As Volunteer)

        ds.Clear()

        sql = "Select * FROM Volunteer WHERE LinkedUser = " & SelectedUser 'Uses and SQL statement to select the Login form
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "Volunteer") 'Fills the data adapter with the data set and calls it jobs

        NoOfVolunteers = ds.Tables("Volunteer").Rows.Count 'Counts the number of row in the jobs table



        For x = 0 To NoOfVolunteers - 1 'Finds the selected volunteer
            If ds.Tables("Volunteer").Rows(x).Item(8) = SelectedUser Then 'When it finds the user then this will run
                Volunteer(x + 1).Identification = ds.Tables("Volunteer").Rows(x).Item(0) 'Inputs the data
                Volunteer(x + 1).FirstName = ds.Tables("Volunteer").Rows(x).Item(1) 'Inputs the data
                Volunteer(x + 1).LastName = ds.Tables("Volunteer").Rows(x).Item(2) 'Inputs the data
                Volunteer(x + 1).MaxTimes = ds.Tables("Volunteer").Rows(x).Item(6) 'Inputs the data
                Volunteer(x + 1).LinkedUser = ds.Tables("Volunteer").Rows(x).Item(8) 'Inputs the data
            End If

        Next

        VolunteerJobsData(Volunteer)

        VolunteerUnavailability(Volunteer)


    End Sub

    Public Sub VolunteerJobsData(ByRef Volunteer() As Volunteer)

        ds.Clear()

        sql = "Select * FROM VolunteerJobs" 'Uses and SQL statement to select the Login form
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "VolunteerJobs") 'Fills the data adapter with the data set and calls it jobs

        MaxRows = ds.Tables("VolunteerJobs").Rows.Count 'Counts the number of row in the jobs tabl




        For x = 0 To NoOfVolunteers - 1 'Finds the selected volunteer
            For y = 0 To MaxRows - 1
                If Volunteer(x + 1).Identification = ds.Tables("VolunteerJobs").Rows(y).Item(0) Then
                    If Volunteer(x + 1).JobQualified1 = "" Then 'Adds the qualified job from the database to the variable

                        Volunteer(x + 1).JobQualified1 = ds.Tables("VolunteerJobs").Rows(y).Item(1)

                    ElseIf Volunteer(x + 1).JobQualified2 = "" Then

                        Volunteer(x + 1).JobQualified2 = ds.Tables("VolunteerJobs").Rows(y).Item(1)

                    ElseIf Volunteer(x + 1).JobQualified3 = "" Then

                        Volunteer(x + 1).JobQualified3 = ds.Tables("VolunteerJobs").Rows(y).Item(1)

                    ElseIf Volunteer(x + 1).JobQualified4 = "" Then

                        Volunteer(x + 1).JobQualified4 = ds.Tables("VolunteerJobs").Rows(y).Item(1)

                    ElseIf Volunteer(x + 1).JobQualified5 = "" Then

                        Volunteer(x + 1).JobQualified5 = ds.Tables("VolunteerJobs").Rows(y).Item(1)

                    End If
                End If
            Next
        Next

        Counter = 0
    End Sub

    Public Sub VolunteerUnavailability(ByRef Volunteer() As Volunteer)
        ds.Clear()

        sql = "Select * FROM Unavailability" 'Uses and SQL statement to select the Login form
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "Unavailability") 'Fills the data adapter with the data set and calls it jobs

        MaxRows = ds.Tables("Unavailability").Rows.Count 'Counts the number of row in the jobs tab

        For x = 0 To NoOfVolunteers - 1 'Finds the volunteer
            For y = 0 To MaxRows - 1
                If Volunteer(x + 1).Identification = ds.Tables("Unavailability").Rows(y).Item(0) Then
                    If Volunteer(x + 1).Unavailability1 = "" Then 'Adds the unavailvility to the variable

                        Volunteer(x + 1).Unavailability1 = ds.Tables("Unavailability").Rows(x).Item(1)

                    ElseIf Volunteer(x + 1).Unavailability2 = "" Then

                        Volunteer(x + 1).JobQualified2 = ds.Tables("Unavailability").Rows(x).Item(1)

                    ElseIf Volunteer(x + 1).Unavailability3 = "" Then

                        Volunteer(x + 1).JobQualified3 = ds.Tables("Unavailability").Rows(x).Item(1)

                    ElseIf Volunteer(x + 1).Unavailability4 = "" Then

                        Volunteer(x + 1).JobQualified4 = ds.Tables("Unavailability").Rows(x).Item(1)

                    ElseIf Volunteer(x + 1).Unavailability5 = "" Then

                        Volunteer(x + 1).JobQualified5 = ds.Tables("Unavailability").Rows(x).Item(1)

                    ElseIf Volunteer(x + 1).Unavailability6 = "" Then

                        Volunteer(x + 1).Unavailability6 = ds.Tables("Unavailability").Rows(x).Item(1)

                    ElseIf Volunteer(x + 1).Unavailability7 = "" Then

                        Volunteer(x + 1).Unavailability7 = ds.Tables("Unavailability").Rows(x).Item(1)

                    ElseIf Volunteer(x + 1).Unavailability8 = "" Then

                        Volunteer(x + 1).Unavailability8 = ds.Tables("Unavailability").Rows(x).Item(1)

                    ElseIf Volunteer(x + 1).Unavailability9 = "" Then

                        Volunteer(x + 1).Unavailability9 = ds.Tables("Unavailability").Rows(x).Item(1)

                    ElseIf Volunteer(x + 1).Unavailability10 = "" Then

                        Volunteer(x + 1).Unavailability10 = ds.Tables("Unavailability").Rows(x).Item(1)

                    ElseIf Volunteer(x + 1).Unavailability11 = "" Then

                        Volunteer(x + 1).Unavailability11 = ds.Tables("Unavailability").Rows(x).Item(1)

                    ElseIf Volunteer(x + 1).Unavailability12 = "" Then

                        Volunteer(x + 1).Unavailability12 = ds.Tables("Unavailability").Rows(x).Item(1)

                    ElseIf Volunteer(x + 1).Unavailability13 = "" Then

                        Volunteer(x + 1).Unavailability13 = ds.Tables("Unavailability").Rows(x).Item(1)

                    ElseIf Volunteer(x + 1).Unavailability14 = "" Then

                        Volunteer(x + 1).Unavailability14 = ds.Tables("Unavailability").Rows(x).Item(1)

                    ElseIf Volunteer(x + 1).Unavailability15 = "" Then

                        Volunteer(x + 1).Unavailability15 = ds.Tables("Unavailability").Rows(x).Item(1)

                    ElseIf Volunteer(x + 1).Unavailability16 = "" Then

                        Volunteer(x + 1).Unavailability16 = ds.Tables("Unavailability").Rows(x).Item(1)

                    ElseIf Volunteer(x + 1).Unavailability17 = "" Then

                        Volunteer(x + 1).Unavailability17 = ds.Tables("Unavailability").Rows(x).Item(1)

                    ElseIf Volunteer(x + 1).Unavailability18 = "" Then

                        Volunteer(x + 1).Unavailability18 = ds.Tables("Unavailability").Rows(x).Item(1)

                    ElseIf Volunteer(x + 1).Unavailability19 = "" Then

                        Volunteer(x + 1).Unavailability19 = ds.Tables("Unavailability").Rows(x).Item(1)

                    End If

                End If
            Next
        Next

    End Sub

    Public Sub ColumnNames()

        sql = "Select * FROM Rota" 'Uses and SQL statement to select the Login form
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "Rota") 'Fills the data adapter with the data set and calls it jobs


        Dim table As DataTable = ds.Tables("Rota")
        Dim column As DataColumn

        Counter = 1

        For Each column In table.Columns 'Goes through each of the columns
            If (column.ColumnName.ToString).Substring(1, 1) = (SelectedUser).ToString Then 'If the column is assosiated with the selected user then this will run
                VolunteerColumnName(Counter).Name = column.ColumnName.ToString 'Adds the column name to the variable
                MaxJobs = Counter
                Counter = Counter + 1

            End If
        Next

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim xlapp As Microsoft.Office.Interop.Excel.Application
        Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
        Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet

        Dim misValue As Object = System.Reflection.Missing.Value

        xlapp = New Microsoft.Office.Interop.Excel.Application 'Creates a new excel document
        xlWorkBook = xlapp.Workbooks.Add(misValue)
        xlWorkSheet = xlWorkBook.Sheets("sheet1") 'Selects the new sheet

        For x = 0 To DataGridView1.RowCount - 1 'for each of the items in the data grid
            For y = 0 To DataGridView1.ColumnCount - 1 'For each of the column in the data grid view
                For z As Integer = 1 To DataGridView1.Columns.Count
                    xlWorkSheet.Cells(1, z) = DataGridView1.Columns(z - 1).HeaderText
                    xlWorkSheet.Cells(x + 2, y + 1) = DataGridView1(y, x).Value.ToString 'Adds the selected data grid to the excel document
                Next
            Next
        Next


        xlWorkSheet.SaveAs(Application.StartupPath & "\Rotas\" & RotaDate & ".xlsx") 'Saves the rota in the debug/rotas folder
        xlWorkBook.Close() 'Closes the connection
        xlapp.Quit()

        releaseObject(xlapp)
        releaseObject(xlWorkBook)
        releaseObject(xlWorkSheet)

        MsgBox("File exported") 'Tells the user that the file has been exported
        Dim res As MsgBoxResult
        res = MsgBox("Would you like to view the file now?", MsgBoxStyle.YesNo) 'asks if you would  like to open up the file
        If (res = MsgBoxResult.Yes) Then
            Process.Start(Application.StartupPath & "\Rotas/" & RotaDate & ".xlsx") 'If they do then it will open the selected file
        End If


    End Sub

    Private Sub releaseObject(ByVal obj5 As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj5)
            obj5 = Nothing
        Catch ex As Exception
            obj5 = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub
End Class