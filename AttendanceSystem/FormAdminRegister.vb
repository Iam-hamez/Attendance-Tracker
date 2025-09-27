Imports MySql.Data.MySqlClient

Public Class FormAdminRegistration

    Private Sub btnRegisterAdmin_Click(sender As Object, e As EventArgs) Handles btnRegisterAdmin.Click
        Dim username As String = txtAdminUsername.Text.Trim()
        Dim password As String = txtAdminPassword.Text.Trim()

        If username = "" Or password = "" Then
            MessageBox.Show("Please provide both username and password.")
            Return
        End If

        Using conn As New MySqlConnection(AppGlobals.ConnString)
            Try
                conn.Open()
                Dim sql As String = "INSERT INTO admin (username, password, created_at) VALUES (@u, @p, NOW())"
                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@u", username)
                    cmd.Parameters.AddWithValue("@p", password) ' for now plain text
                    cmd.ExecuteNonQuery()
                End Using
                MessageBox.Show("Admin registered successfully!Welcome Admin")
                ' Open login form
                Dim loginForm As New FormLogin()
                loginForm.Show()
                Me.Close()
            Catch ex As Exception
                MessageBox.Show("Error registering admin: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub txtAdminPassword_TextChanged(sender As Object, e As EventArgs) Handles txtAdminPassword.TextChanged

    End Sub
End Class
