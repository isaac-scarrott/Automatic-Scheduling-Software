Public Class frmChangePassword
    Dim con As New OleDb.OleDbConnection
    Dim dbProvider As String
    Dim dbSource As String
    Dim ds As New DataSet
    Dim da As New OleDb.OleDbDataAdapter
    Dim sql As String
    Public Shared Property UserNamePass As String 'This is what is used to carry across the Username that the user is modifying

    Private Sub Back_Button_Click(sender As Object, e As EventArgs) Handles Back_Button.Click ' Takes the user back to the login screen
        Hide()
        frmLoginScreen.Show()

        Pass1_text.Clear() 'Clears the text boxes
        Pass2_text.Clear() '^
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click 'This is the change password button
        Dim Result As MsgBoxResult 'Enables us to see what the user pressed in a message box

        If Pass1_text.Text = Pass2_text.Text Then 'Validates that the user wishes to change it to the inputted password

            If Len(Pass1_text.Text) > 7 Then

                If Len(Pass1_text.Text) < 20 Then

                    Result = MsgBox("Are you sure you wish to change your password?", MsgBoxStyle.YesNo, "Change Password") 'Displays a message box to ask the user if the really want ot change their password

                    If Result = MsgBoxResult.Yes Then 'If the user presses yes then this will run

                        sql = "SELECT * FROM Login WHERE Username = '" & UserNamePass & "'" 'Uses and SQL statement to select the Login form  and then selects the Username from the database

                        da = New OleDb.OleDbDataAdapter(sql, con)
                        da.Fill(ds, "Lgn") 'Fills the data adapter with the data set and calls it lgn

                        ds.Tables("Lgn").Rows(0).Item(2) = Pass1_text.Text 'Sets the ds of the of the login form in the item to of the selected user to the text in the first text box

                        Dim cb As New OleDb.OleDbCommandBuilder(da)
                        da.Update(ds, "Lgn") 'Updates the table

                        MsgBox("Your password has been changed", MsgBoxStyle.Information, "Password changed") 'Tells the user that their password has been changed
                        Hide() 'Hides the current screen
                        frmLoginScreen.Show() 'Shows the login screen
                        Pass1_text.Clear() 'Clears the text boxes
                        Pass2_text.Clear() '

                    Else 'If the user presses no in the message box then this will run
                        MsgBox("Your password has not been changed", MsgBoxStyle.Information, "Password not changed") 'Tells the user their password has NOT been changed
                    End If
                Else
                    MsgBox("Your password cannot be any longer than 20 characters", MsgBoxStyle.Information, "Password not changed") 'If the text in the two text boxes are not the same then they it will tell them that and not change the password
                    Pass1_text.Clear() 'Clears the text boxes
                    Pass2_text.Clear() '^
                End If

            Else
                    MsgBox("Your password has to be atleast 7 characters long", MsgBoxStyle.Information, "Password not changed") 'If the text in the two text boxes are not the same then they it will tell them that and not change the password
                Pass1_text.Clear() 'Clears the text boxes
                Pass2_text.Clear() '^
            End If

        Else
            MsgBox("Passwords do not match", MsgBoxStyle.Information, "Password not changed") 'If the text in the two text boxes are not the same then they it will tell them that and not change the password
            Pass1_text.Clear() 'Clears the text boxes
            Pass2_text.Clear() '^
        End If
    End Sub

    Private Sub frmChangePassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Pass1_text.Clear() 'Clears the text boxes
        Pass2_text.Clear() '

        dbProvider = "PROVIDER=Microsoft.Jet.OLEDB.4.0;"
        dbSource = "Data Source=CityChurchGrimsbyDatabase.mdb"

        con.ConnectionString = dbProvider & dbSource 'Tells vb the provider and source of the database

        con.Open() 'Opens the connection


    End Sub
End Class