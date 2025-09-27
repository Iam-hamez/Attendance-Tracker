Imports MySql.Data.MySqlClient

Public Class FormAddAdmin
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim username As String = txtAdminUsername.Text.Trim()
        Dim password As String = txtAdminPassword.Text.Trim()

        If username = "" Or password = "" Then
            MessageBox.Show("Please enter both username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Using conn As New MySqlConnection(AppGlobals.ConnString)
            Try
                conn.Open()
                Dim sql As String = "INSERT INTO admin (username, password) VALUES (@u, @p)"
                Dim cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@u", username)
                cmd.Parameters.AddWithValue("@p", password)

                cmd.ExecuteNonQuery()

                MessageBox.Show("New admin has been added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                txtAdminUsername.Clear()
                txtAdminPassword.Clear()

            Catch ex As MySqlException
                If ex.Number = 1062 Then
                    MessageBox.Show("This username is already taken.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    MessageBox.Show("Error adding admin: " & ex.Message)
                End If
            End Try
        End Using
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        FormAdminDashboard2.Show()
    End Sub

    Private Sub txtAdminUsername_TextChanged(sender As Object, e As EventArgs) Handles txtAdminUsername.TextChanged
        If txtAdminUsername.Text.Trim() = "" Then
            MessageBox.Show("Username is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtAdminUsername.Focus()
            Exit Sub
        End If

        If txtAdminUsername.Text.Any(AddressOf Char.IsDigit) Then
            MessageBox.Show("Username cannot contain numbers.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtAdminUsername.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub txtAdminPassword_TextChanged(sender As Object, e As EventArgs) Handles txtAdminPassword.TextChanged
        If txtAdminPassword.Text.Trim() = "" Then
            MessageBox.Show("Password is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtAdminPassword.Focus()
            Exit Sub
        End If
    End Sub
End Class