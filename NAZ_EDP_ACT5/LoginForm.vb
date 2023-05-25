Imports MySql.Data.MySqlClient

Public Class Form1

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        With Me
            Call Connect_to_DB()
            Dim mycmd As New MySqlCommand
            Dim myreader As MySqlDataReader


            strSQL = "Select * from users where name = '" _
                & .usernametxt.Text & "' and password = ('" _
                & .passwordtxt.Text & "')"
            'MsgBox(strSQL)
            mycmd.CommandText = strSQL
            mycmd.Connection = myconn

            myreader = mycmd.ExecuteReader
            If myreader.HasRows Then
                Me.Hide()
                adminForm.Show()
            Else
                MessageBox.Show("Invalid username or password")
            End If
            Call Disconnect_to_DB()
        End With
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        registerForm.Show()
    End Sub
End Class
