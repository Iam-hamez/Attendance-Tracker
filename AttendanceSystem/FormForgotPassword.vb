Imports MySql.Data.MySqlClient

Public Class FormForgotPassword
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Dim username As String = txtUsername.Text.Trim()
        Dim newPass As String = txtNewPassword.Text.Trim()

        If username = "" Or newPass = "" Then
            MessageBox.Show("Please enter your username and new password.")
            Return
        End If

        Using conn As New MySqlConnection(AppGlobals.ConnString)
            conn.Open()

            ' --- Check Admin (by username) ---
            Dim adminCmd As New MySqlCommand("SELECT * FROM admin WHERE username=@u", conn)
            adminCmd.Parameters.AddWithValue("@u", username)
            Dim adminReader = adminCmd.ExecuteReader()

            If adminReader.Read() Then
                adminReader.Close()

                Dim resetCmd As New MySqlCommand("UPDATE admin SET password=@p WHERE username=@u", conn)
                resetCmd.Parameters.AddWithValue("@p", newPass)
                resetCmd.Parameters.AddWithValue("@u", username)
                resetCmd.ExecuteNonQuery()

                MessageBox.Show("Admin password has been updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                FormLogin.Show()
                Me.Close()
                Return
            End If
            adminReader.Close()

            ' --- Check Student (by username) ---
            Dim stuCmd As New MySqlCommand("SELECT * FROM students WHERE student_number=@u", conn)
            stuCmd.Parameters.AddWithValue("@u", username)
            Dim stuReader = stuCmd.ExecuteReader()

            If stuReader.Read() Then
                stuReader.Close()

                Dim resetStuCmd As New MySqlCommand("UPDATE students SET password=@p WHERE student_number=@u", conn)
                resetStuCmd.Parameters.AddWithValue("@p", newPass)
                resetStuCmd.Parameters.AddWithValue("@u", username)
                resetStuCmd.ExecuteNonQuery()

                MessageBox.Show("Student password has been updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                FormLogin.Show()
                Me.Close()
                Return
            End If
            stuReader.Close()

            MessageBox.Show("Username not found in the system.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Using
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        FormLogin.Show()
        Me.Close()
    End Sub
End Class