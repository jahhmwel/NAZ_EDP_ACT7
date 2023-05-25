Imports MySql.Data.MySqlClient

Public Class registerForm

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call Connect_to_DB()
        Dim mycmd As New MySqlCommand

        Dim name As String = usernametxtbox.Text
        Dim password As String = passwordtextbox.Text
        Dim address As String = addresstextbox.Text
        Dim email As String = emailtextbox.Text

        Dim sql As String = "INSERT INTO users (name, password, address, email) VALUES (@name, @password, @address @email)"
        mycmd = New MySqlCommand(sql, myconn)

        mycmd.Parameters.AddWithValue("@name", Name)
        mycmd.Parameters.AddWithValue("@password", password)
        mycmd.Parameters.AddWithValue("@address", address)
        mycmd.Parameters.AddWithValue("@email", email)
        mycmd.ExecuteNonQuery()
        MessageBox.Show("Account Successfully Created!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Call Disconnect_to_DB()
        Form1.Show()
        Hide()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Hide()
        Form1.Show()
    End Sub

End Class