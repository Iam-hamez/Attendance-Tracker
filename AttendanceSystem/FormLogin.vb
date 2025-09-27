Imports MySql.Data.MySqlClient

Public Class FormLogin

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()

        If username = "" Or password = "" Then
            MessageBox.Show("Please enter both username and password.")
            Return
        End If

        Using conn As New MySqlConnection(AppGlobals.ConnString)
            conn.Open()

            ' --- 1. Check Admin login ---
            Dim adminCmd As New MySqlCommand("SELECT * FROM admin WHERE username=@u AND password=@p", conn)
            adminCmd.Parameters.AddWithValue("@u", username)
            adminCmd.Parameters.AddWithValue("@p", password)
            Dim adminReader = adminCmd.ExecuteReader()
            If adminReader.Read() Then
                adminReader.Close()
                Dim dash As New FormAdminDashboard2()
                dash.Show()
                Me.Hide()
                Return
            End If
            adminReader.Close()

            ' --- 2. Check Teacher login ---
            Dim teacherCmd As New MySqlCommand("SELECT * FROM teachers WHERE username=@u AND password=@p", conn)
            teacherCmd.Parameters.AddWithValue("@u", username)
            teacherCmd.Parameters.AddWithValue("@p", password)
            Dim teacherReader = teacherCmd.ExecuteReader()
            If teacherReader.Read() Then
                ' Save globals
                AppGlobals.LoggedTeacherDbId = Convert.ToInt32(teacherReader("teacher_id"))
                AppGlobals.LoggedTeacherName = teacherReader("full_name").ToString()

                teacherReader.Close()
                Dim dash As New TeacherDashboard()
                dash.Show()
                Me.Hide()
                Return
            End If
            teacherReader.Close()

            ' --- 3. Check Existing Students ---
            Dim stuCmd As New MySqlCommand("SELECT student_id, is_registered FROM students WHERE student_number=@u AND password=@p", conn)
            stuCmd.Parameters.AddWithValue("@u", username)
            stuCmd.Parameters.AddWithValue("@p", password)
            Dim stuReader = stuCmd.ExecuteReader()
            If stuReader.Read() Then
                Dim studentId = Convert.ToInt32(stuReader("student_id"))
                Dim isRegistered = Convert.ToInt32(stuReader("is_registered"))
                stuReader.Close()

                ' Save globals
                AppGlobals.LoggedStudentDbId = studentId
                AppGlobals.LoggedStudentNumber = username

                ' Open dashboard or registration
                If isRegistered = 1 Then
                    Dim dash As New FormStudentDashboard()
                    dash.Show()
                Else
                    Dim regForm As New FormStudentRegistration()
                    regForm.txtPreferredUsername.Text = username
                    regForm.Show()
                End If
                Me.Hide()
                Return
            End If
            stuReader.Close()

            ' --- 4. New student placeholder for "student/student" ---
            If username = "student" And password = "student" Then
                Dim tempStudentNumber As String = "student" & DateTime.Now.Ticks.ToString()
                Dim tempEmail As String = "temp" & DateTime.Now.Ticks.ToString() & "@placeholder.com"

                Using insertCmd As New MySqlCommand(
                    "INSERT INTO students (student_number, password, is_registered, email) VALUES (@num, @pass, 0, @email); SELECT LAST_INSERT_ID();", conn)

                    insertCmd.Parameters.AddWithValue("@num", tempStudentNumber)
                    insertCmd.Parameters.AddWithValue("@pass", "student")
                    insertCmd.Parameters.AddWithValue("@email", tempEmail)

                    Dim newId As Integer = Convert.ToInt32(insertCmd.ExecuteScalar())

                    ' Save globals
                    AppGlobals.LoggedStudentDbId = newId
                    AppGlobals.LoggedStudentNumber = tempStudentNumber
                    AppGlobals.LoggedStudentName = ""

                    ' Open registration form
                    Dim regForm As New FormStudentRegistration()
                    regForm.txtPreferredUsername.Text = tempStudentNumber
                    regForm.Show()
                    Me.Hide()
                End Using
                Return
            End If

            ' --- 5. Invalid login ---
            MessageBox.Show("Invalid username or password.")
        End Using
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnNewStudent_Click(sender As Object, e As EventArgs) Handles btnNewStudent.Click
        FormStudentRegistration.Show()
        Me.Hide()
    End Sub

    Private Sub LinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel.LinkClicked
        Dim f As New FormForgotPassword()
        f.Show()
        Me.Hide()
    End Sub

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged
        If txtUsername.Text.Trim() = "" Then
            MessageBox.Show("Username is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtUsername.Focus()
            Exit Sub
        End If
        If txtUsername.Text.Any(AddressOf Char.IsDigit) Then
            MessageBox.Show("Username cannot contain numbers.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtUsername.Focus()
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

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        FormStudentRegistration.Show()
        Me.Hide()
    End Sub
End Class