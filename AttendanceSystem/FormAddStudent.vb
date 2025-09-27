Imports MySql.Data.MySqlClient

Public Class FormAddStudent
    Private Sub btnSaveStudent_Click(sender As Object, e As EventArgs) Handles btnSaveStudent.Click
        Dim studentNumber As String = txtStudentNumber.Text.Trim()
        Dim fullName As String = txtFullname.Text.Trim()
        Dim email As String = txtEmail.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()

        If studentNumber = "" Or fullName = "" Or password = "" Then
            MessageBox.Show("Please fill all required fields.")
            Return
        End If

        Using conn As New MySqlConnection(AppGlobals.ConnString)
            Try
                conn.Open()
                Dim sql As String = "INSERT INTO students (student_number, full_name, email, password, is_registered) VALUES (@num, @name, @email, @pass, 1)"
                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@num", studentNumber)
                    cmd.Parameters.AddWithValue("@name", fullName)
                    cmd.Parameters.AddWithValue("@email", email)
                    cmd.Parameters.AddWithValue("@pass", password)
                    cmd.ExecuteNonQuery()
                End Using
                MessageBox.Show("Student added successfully!")
                Me.Close()
            Catch ex As Exception
                MessageBox.Show("Error adding student: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub txtStudentNumber_TextChanged(sender As Object, e As EventArgs) Handles txtStudentNumber.TextChanged
        If txtStudentNumber.Text.Trim() = "" Then
            MessageBox.Show("Username is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtStudentNumber.Focus()
            Exit Sub
        End If
        If txtStudentNumber.Text.Any(AddressOf Char.IsDigit) Then
            MessageBox.Show("Username cannot contain numbers.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtStudentNumber.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub lblstudentNumber_Click(sender As Object, e As EventArgs) Handles lblUsername.Click

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

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        If txtPassword.Text.Trim() = "" Then
            MessageBox.Show("Password is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
    End Sub

    Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged
        ' If txtEmail.Text.Trim() = "" Then
        'MessageBox.Show("Email is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        'txtEmail.Focus()
        'Exit Sub
        ' End If

        Dim email As String = txtEmail.Text.Trim()

        ' If Not email.Contains("@") OrElse Not email.EndsWith(".com") Then
        'MessageBox.Show("Please enter a valid email (must contain '@' and end with '.com').", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        'txtEmail.Focus()
        'Exit Sub
        'End If

    End Sub
End Class
