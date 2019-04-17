Public Class frmForgottenSecurityQuestion
    Dim con As New OleDb.OleDbConnection
    Dim dbProvider As String
    Dim dbSource As String
    Dim ds As New DataSet
    Dim da As New OleDb.OleDbDataAdapter
    Dim sql As String
    Dim UserRow As Integer
    Dim MaxRows As Integer
    Private Sub frmForgottenSecurityQuestion_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'When the form first loads up

        Username_text.Clear() 'Clears the text box
        Question_Text.Clear() '^
        Answer_Text.Clear() '  ^

        dbProvider = "PROVIDER=Microsoft.Jet.OLEDB.4.0;"
        dbSource = "Data Source='" & Application.StartupPath & "/CityChurchGrimsbyDatabase.mdb'"

        con.ConnectionString = dbProvider & dbSource 'Tells vb the provider and source of the database

        con.Open() 'Opens the connection

        sql = "Select * From Login" 'Uses and SQL statement to select the Login form  and then selects the Username from the database
        da = New OleDb.OleDbDataAdapter(sql, con)

        da.Fill(ds, "Login") 'Fills the data adapter with the data set and calls it lgn

    End Sub

    Private Sub Load_btn_Click(sender As Object, e As EventArgs) Handles Load_btn.Click
        Dim Obj As New frmChangePassword

        sql = "Select * From Login" 'Uses and SQL statement to select the Login form  and then selects the Username from the database
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "Login") 'Fills the data adapter with the data set and calls it lgn

        MaxRows = ds.Tables("Login").Rows.Count 'Counts the number of row in the login table

        Question_Text.Clear() 'Clears the text box
        Answer_Text.Clear() 'Clears the text box

        For x = 0 To MaxRows - 1 'Loops from 1 until x reaches 1 under max rows

            If ds.Tables("Login").Rows(x).Item(1) = StrConv(Username_text.Text, vbProperCase) Then 'This detects if the row that they are currently look at and matches the text in the textbox

                Question_Text.Text = ds.Tables("Login").Rows(x).Item(3) 'Displays the data in item 3 of the current row(x) and puts it in the read-only textbox

                UserRow = x 'Sets the value of x to the user row
                Obj.UserNamePass = Username_text.Text 'Used to carry accross the name of the user to another form

            End If

            If x = MaxRows - 1 And Question_Text.Text = "" Then 'If it reaches the end of it's search and no user is found then it will run this

                MsgBox("User doesn't exist", MsgBoxStyle.Information, "Error") 'Displays a message saying user not found

            End If
        Next


    End Sub

    Private Sub Submit_btn_Click(sender As Object, e As EventArgs) Handles Submit_btn.Click



        sql = "Select * From Login" 'Uses and SQL statement to select the Login form  and then selects the Username from the database
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "Login") 'Fills the data adapter with the data set and calls it lgn

        MaxRows = ds.Tables("Login").Rows.Count 'Sets max rows the the number of rows in the table

        If Answer_Text.Text = ds.Tables("Login").Rows(UserRow).Item(4) Then 'If the answer in the database matches the text box then this message will be shown
            Hide() 'Hides the form
            frmChangePassword.Show() 'Opens the change password form
            Username_text.Clear() 'Clears the text box
            Question_Text.Clear() '^
            Answer_Text.Clear() '  ^

        Else 'How ever if it doesn't match then it'll display this message
            MsgBox("Wrong answer", MsgBoxStyle.Information, "Error") 'Displays this messagebox
        End If
    End Sub

    Private Sub Back_btn_Click(sender As Object, e As EventArgs) Handles Back_btn.Click 'Takes the user back to the previous screen
        Hide()
        frmLoginScreen.Show()
        Username_text.Clear() 'Clears the text box
        Question_Text.Clear() '^
        Answer_Text.Clear() '  ^
    End Sub

    Private Sub Username_text_TextChanged(sender As Object, e As EventArgs) Handles Username_text.TextChanged

    End Sub
End Class