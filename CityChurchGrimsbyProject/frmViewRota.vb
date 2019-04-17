Public Class frmViewRota
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
        If My.Computer.FileSystem.FileExists(Application.StartupPath & "\Rotas\" & DateTimePicker1.Text & ".xlsx") Then 'Checks if the file exists
            Process.Start(Application.StartupPath & "\Rotas\" & DateTimePicker1.Text & ".xlsx") 'Opens up the selected file
        Else 'If it can't find it then it will show this
            MsgBox("The rota does not exist") 'Tells the user that the rota they have searched for doesn't exist
        End If

    End Sub

    Private Sub frmViewRota_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePicker1.ShowUpDown = True
        DateTimePicker1.CustomFormat = "MMMMyyyy"
        DateTimePicker1.Format = DateTimePickerFormat.Custom 'puts the date time picker output into the correct format

        Dim dbProvider As String
        Dim dbSource As String

        dbProvider = "PROVIDER=Microsoft.Jet.OLEDB.4.0;"
        dbSource = "Data Source=CityChurchGrimsbyDatabase.mdb"

        con.ConnectionString = dbProvider & dbSource 'Tells vb the provider And source Of the database

        con.Open()

        Sql = "Select * From Rota" 'Uses and SQL statement to select the Login form
        da = New OleDb.OleDbDataAdapter(Sql, con)
        da.Fill(ds, "Rota") 'Fills the data adapter with the data set and calls it jobs

        MaxRows = ds.Tables("Rota").Rows.Count 'Counts the number of row in the jobs table
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For x = 0 To MaxRows - 1 'Searches each row of the database
            If ds.Tables("Rota").Rows(x).Item(1) = DateTimePicker1.Text Then
                ds.Tables("Rota").Rows(x).Delete() 'Deletes the selected row
                If My.Computer.FileSystem.FileExists(Application.StartupPath & "\Rotas\" & DateTimePicker1.Text & ".xlsx") Then 'Checks if the file exists
                    System.IO.File.Delete(Application.StartupPath & "\Rotas\" & DateTimePicker1.Text & ".xlsx") 'Delete the selected file
                End If
            End If
        Next

        Dim cb As New OleDb.OleDbCommandBuilder(da)
        da.Update(ds, "Rota") 'Updates the tabl

        MsgBox("Rota deleted") 'Tells the user that the rota has been deleted
        MaxRows = MaxRows - 1
    End Sub
End Class