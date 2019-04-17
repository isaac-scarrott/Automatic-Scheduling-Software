Public Class frmLoginScreen
    Dim con As New OleDb.OleDbConnection
    Dim dbProvider As String
    Dim dbSource As String
    Dim ds As New DataSet
    Dim da As New OleDb.OleDbDataAdapter
    Dim MaxRows As Integer
    Dim sql As String
    Dim Loginerror As String ' This will tell the user what is wrong with the login

    Public Function Login()

        sql = "Select * From Login" 'Uses and SQL statement to select the Login form  and then selects the Username from the database
        da = New OleDb.OleDbDataAdapter(Sql, con)
        da.Fill(ds, "Login") 'Fills the data adapter with the data set and calls it lgn

        MaxRows = ds.Tables("Login").Rows.Count 'Counts the number of row in the login table

        For x = 0 To MaxRows - 1 'Loops from 1 until x reaches 1 under max rows

            If ds.Tables("Login").Rows(x).Item(1) = StrConv(Username_TextBox.Text, vbProperCase) Then 'This detects if the row that they are currently look at and matches the text in the textbox

                If ds.Tables("Login").Rows(x).Item(2) = Password_Textbox.Text Then 'This will check if the password entered corresponds with the password of the selected user in the database
                    SelectedUser = ds.Tables("Login").Rows(x).Item(0)
                    Return True 'Returns the value of true
                Else
                    Loginerror = "Invalid Password" 'If the password doesn't match then it will set the login error to invalid password
                End If

            End If

        Next

        If Loginerror = "" Then 'If it reaches this point and it is blank then it will run this
            Loginerror = "Invalid Username" 'Sets the login error to invalid username
        End If


        Return False 'Returns the value of false

    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Login_Button.Click

        If Login() = True Then 'If the function is true then this will run
            Hide() 'Closes current form
            frmMainScreen.Show() 'Opens this form



            Username_TextBox.Clear() 'Clears the textbox
            Password_Textbox.Clear() '^

        Else
            MsgBox(Loginerror, MsgBoxStyle.Information, "Error") 'Displays the message box with the value of loginerror

            If Loginerror = "Invalid Password" Then 'If the login error is invalid password
                Password_Textbox.Clear() 'Clears the textbox
            Else
                Password_Textbox.Clear() 'Clears the textbox
                Username_TextBox.Clear() '^
            End If

        End If
    End Sub

    Private Sub ForgottenPassword_Button_Click(sender As Object, e As EventArgs) Handles ForgottenPassword_Button.Click 'Takes you back to the previous screen
        Hide()
        frmForgottenSecurityQuestion.Show()

        Username_TextBox.Clear()
        Password_Textbox.Clear()
    End Sub

    Private Sub frmLoginScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dbProvider = "PROVIDER=Microsoft.Jet.OLEDB.4.0;"
        dbSource = "Data Source=CityChurchGrimsbyDatabase.mdb"

        con.ConnectionString = dbProvider & dbSource 'Tells vb the provider and source of the database

        con.Open() 'Opens the connection

        sql = "Select * From Login" 'Uses and SQL statement to select the Login form  and then selects the Username from the database
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "Login") 'Fills the data adapter with the data set and calls it lgn

    End Sub

    Private Sub Username_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Username_TextBox.TextChanged

    End Sub
End Class