Imports MySql.Data.MySqlClient

Public Class FormManageCourses
    Private Sub FormManageCourses_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCourses()
    End Sub

    Private Sub LoadCourses()
        Using conn As New MySqlConnection(AppGlobals.ConnString)
            conn.Open()
            Dim sql = "SELECT course_id, course_name, course_code, created_at FROM courses ORDER BY course_id"
            Dim da As New MySqlDataAdapter(sql, conn)
            Dim dt As New DataTable()
            da.Fill(dt)
            dgvCourses.DataSource = dt
            dgvCourses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        End Using
    End Sub

    Private Sub btnAddCourse_Click(sender As Object, e As EventArgs) Handles btnAddCourse.Click
        If txtCourseName.Text.Trim() = "" Or txtCourseCode.Text.Trim() = "" Then
            MessageBox.Show("Please fill all fields.")
            Return
        End If

        Using conn As New MySqlConnection(AppGlobals.ConnString)
            Try
                conn.Open()
                Dim sql = "INSERT INTO courses (course_name, course_code) VALUES (@n,@c)"
                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@n", txtCourseName.Text.Trim())
                    cmd.Parameters.AddWithValue("@c", txtCourseCode.Text.Trim())
                    cmd.ExecuteNonQuery()
                End Using
                MessageBox.Show("Course added.")
                LoadCourses()
                txtCourseName.Clear() : txtCourseCode.Clear()
            Catch ex As MySqlException
                If ex.Number = 1062 Then
                    MessageBox.Show("Course code already exists.")
                Else
                    MessageBox.Show("Error: " & ex.Message)
                End If
            End Try
        End Using
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        FormAdminDashboard2.Show()
        Me.Close()
    End Sub

    Private Sub txtCourseName_TextChanged(sender As Object, e As EventArgs) Handles txtCourseName.TextChanged
        If txtCourseName.Text.Trim() = "" Then
            MessageBox.Show("Course name is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCourseName.Focus()
            Exit Sub
        End If


    End Sub

    Private Sub txtCourseCode_TextChanged(sender As Object, e As EventArgs) Handles txtCourseCode.TextChanged

        If txtCourseCode.Text.Trim() = "" Then
            MessageBox.Show("Course code is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCourseCode.Focus()
            Exit Sub
        End If
    End Sub
End Class