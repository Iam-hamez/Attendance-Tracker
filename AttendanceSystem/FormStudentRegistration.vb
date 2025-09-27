
Imports MySql.Data.MySqlClient

Public Class FormStudentRegistration

        ' txtStudentNumber should be pre-filled by FormLogin before showing this form.

        Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click


        ' --- Validate fields ---
        If txtPreferredUsername.Text.Trim() = "" Or txtFullname.Text.Trim() = "" Or txtEmail.Text.Trim() = "" Or txtPassword.Text.Trim() = "" Then
            MessageBox.Show("Please fill all required fields.")
            Return
        End If

        Using conn As New MySqlConnection(AppGlobals.ConnString)
            Try
                conn.Open()

                ' Check if preferred username already exists
                Dim checkUser As New MySqlCommand("SELECT COUNT(*) FROM students WHERE student_number=@u AND student_id<>@id", conn)
                checkUser.Parameters.AddWithValue("@u", txtPreferredUsername.Text.Trim())
                checkUser.Parameters.AddWithValue("@id", AppGlobals.LoggedStudentDbId)
                Dim userExists As Integer = Convert.ToInt32(checkUser.ExecuteScalar())
                If userExists > 0 Then
                    MessageBox.Show("This username is already taken. Please choose another one.")
                    Return
                End If

                ' Check if email already exists
                Dim checkEmail As New MySqlCommand("SELECT COUNT(*) FROM students WHERE email=@e AND student_id<>@id", conn)
                checkEmail.Parameters.AddWithValue("@e", txtEmail.Text.Trim())
                checkEmail.Parameters.AddWithValue("@id", AppGlobals.LoggedStudentDbId)
                Dim emailExists As Integer = Convert.ToInt32(checkEmail.ExecuteScalar())
                If emailExists > 0 Then
                    MessageBox.Show("This email is already registered. Please use another one.")
                    Return
                End If

                ' Update placeholder record with real info
                Dim sql As String = "UPDATE students SET student_number=@snum, full_name=@name, email=@email, password=@pass, is_registered=1 WHERE student_id=@id"
                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@snum", txtPreferredUsername.Text.Trim())
                    cmd.Parameters.AddWithValue("@name", txtFullname.Text.Trim())
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim())
                    cmd.Parameters.AddWithValue("@pass", txtPassword.Text.Trim())
                    cmd.Parameters.AddWithValue("@id", AppGlobals.LoggedStudentDbId)
                    cmd.ExecuteNonQuery()
                End Using

                MessageBox.Show("Registration successful!Welcome Student")
                ' Open Student Dashboard
                Dim dash As New FormStudentDashboard()
                dash.Show()
                Me.Close()

            Catch ex As Exception
                MessageBox.Show("Error during registration: " & ex.Message)
            End Try
        End Using
    End Sub







    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim adminDash As New FormAdminDashboard2()
        FormLogin.Show()
        Me.Close()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub txtEmail_Leave(sender As Object, e As EventArgs) Handles txtEmail.Leave
        If txtEmail.Text.Trim() = "" Then
            MessageBox.Show("Email is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtEmail.Focus()
            Exit Sub
        End If

        Dim email As String = txtEmail.Text.Trim()

        If Not email.Contains("@") OrElse Not email.EndsWith(".com") Then
            MessageBox.Show("Please enter a valid email (must contain '@' and end with '.com').", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtEmail.Focus()
            Exit Sub
        End If

    End Sub

    Private Sub txtFullname_TextChanged(sender As Object, e As EventArgs) Handles txtFullname.TextChanged
        If txtFullname.Text.Trim() = "" Then
            MessageBox.Show("Full name is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtFullname.Focus()
            Exit Sub
        End If
        If txtFullname.Text.Any(AddressOf Char.IsDigit) Then
            MessageBox.Show("Full name cannot contain numbers.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtFullname.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub txtPreferredUsername_TextChanged(sender As Object, e As EventArgs) Handles txtPreferredUsername.TextChanged
        If txtPreferredUsername.Text.Trim() = "" Then
            MessageBox.Show("Username is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPreferredUsername.Focus()
            Exit Sub
        End If

        If txtPreferredUsername.Text.Any(AddressOf Char.IsDigit) Then
            MessageBox.Show("Username cannot contain numbers.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPreferredUsername.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        If txtPassword.Text.Trim() = "" Then
            MessageBox.Show("Password is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPassword.Focus()
            Exit Sub
        End If
    End Sub
End Class


