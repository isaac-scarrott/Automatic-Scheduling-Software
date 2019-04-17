Public Class frmNewRota
    Dim con As New OleDb.OleDbConnection
    Dim dbProvider As String
    Dim dbSource As String
    Dim ds As New DataSet
    Dim da As New OleDb.OleDbDataAdapter
    Dim MaxRows As Integer
    Dim sql As String

    Private Sub Back_Button_Click(sender As Object, e As EventArgs) Handles Back_Button.Click
        Hide()
        FrmRota.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim NotDuplicate As Boolean = True


        Dim Obj As New frmNewRotaGenerated



        ds.Clear()

        sql = "Select * From Rota" 'Uses and SQL statement to select the Login form
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "Rota") 'Fills the data adapter with the data set and calls it jobs

        MaxRows = ds.Tables("Rota").Rows.Count 'Counts the number of row in the jobs table

        For x = 0 To MaxRows - 1
            If ds.Tables("Rota").Rows(x).Item(1) = DateTimePicker1.Text Then
                NotDuplicate = False
            End If
        Next

        If NotDuplicate Then
            Dim cb As New OleDb.OleDbCommandBuilder(da)
            Dim dsNewRow As DataRow

            dsNewRow = ds.Tables("Rota").NewRow 'Adds the row of the next free row
            If MaxRows > 0 Then
                dsNewRow.Item(0) = ds.Tables("Rota").Rows(MaxRows - 1).Item(0) + 1
            Else
                dsNewRow.Item(0) = 1
            End If

            dsNewRow.Item(1) = DateTimePicker1.Text
            dsNewRow.Item(2) = SelectedUser

            DateTimePicker1.ShowUpDown = True
            DateTimePicker1.CustomFormat = "MM"
            DateTimePicker1.Format = DateTimePickerFormat.Custom 'Puts the output of the date time picker in the right format

            Obj.RotaMonthInteger = DateTimePicker1.Text 'Carries over the infomation onto the next screen

            DateTimePicker1.ShowUpDown = True
            DateTimePicker1.CustomFormat = "MMMM"
            DateTimePicker1.Format = DateTimePickerFormat.Custom 'Puts the output of the date time picker in the right format

            Obj.RotaMonthString = DateTimePicker1.Text 'Carries over the infomation onto the next screen

            DateTimePicker1.ShowUpDown = True
            DateTimePicker1.CustomFormat = "yyyy"
            DateTimePicker1.Format = DateTimePickerFormat.Custom 'Puts the output of the date time picker in the right format

            Obj.RotaYear = DateTimePicker1.Text 'Carries over the infomation onto the next screen



            Obj.NewRow = MaxRows

            Dim CurrentDate As DateTime = New DateTime(Obj.RotaYear, Obj.RotaMonthInteger, 1)
            Dim DaysInMonth As Integer = System.DateTime.DaysInMonth(Obj.RotaYear, Obj.RotaMonthInteger)
            Dim FirstSunday As Date = "#01/" & Obj.RotaMonthInteger & "/" & Obj.RotaYear & "#"




            For x As Integer = 0 To 31
                CurrentDate = CurrentDate.AddDays(1)
                If CurrentDate.DayOfWeek = DayOfWeek.Sunday And CurrentDate < DaysInMonth & "/" & Obj.RotaMonthInteger & "/" & Obj.RotaYear Then
                    dsNewRow.Item(3) = CurrentDate
                    Exit For
                End If
            Next

            ds.Tables("Rota").Rows.Add(dsNewRow) 'Creates a row in the database
            da.Update(ds, "Rota") 'Updates the database with the selected infomation





            MaxRows = MaxRows + 1

            con.Close()




            Close()
            frmNewRotaGenerated.Show()

        Else
            MsgBox("This rota already exists!")
        End If

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub frmNewRota_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePicker1.ShowUpDown = True
        DateTimePicker1.CustomFormat = "MMMMyyyy"
        DateTimePicker1.Format = DateTimePickerFormat.Custom 'Puts the output of the date time picker in the right format

        Dim dbProvider As String
        Dim dbSource As String

        dbProvider = "PROVIDER=Microsoft.Jet.OLEDB.4.0;"
        dbSource = "Data Source=CityChurchGrimsbyDatabase.mdb"

        con.ConnectionString = dbProvider & dbSource 'Tells vb the provider And source Of the database

        con.Open()

        sql = "Select * From Rota" 'Uses and SQL statement to select the Login form
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "Rota") 'Fills the data adapter with the data set and calls it jobs

        MaxRows = ds.Tables("Rota").Rows.Count 'Counts the number of row in the jobs table





    End Sub
End Class