Imports MySql.Data.MySqlClient   ' For MySQL connection, commands, data adapter
Imports System.IO                ' For file handling (optional if you show images)
Imports System.Drawing           ' For image handling (optional if showing thumbnails)




Public Class FormAdminDashboard2

    Private Sub btnAddStudent_Click(sender As Object, e As EventArgs) Handles btnAddStudent.Click
        Dim addForm As New FormAddStudent()
        addForm.ShowDialog() ' ShowDialog keeps focus until form is closed
        ' Optional: Refresh student list after adding
        btnShowStudents.PerformClick()
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Dim LoginForm As New FormLogin()
        LoginForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub





    Private Sub dgvStudents_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvStudents.CellContentClick

    End Sub

    Private Sub btnAttendanceHistory_Click(sender As Object, e As EventArgs) Handles btnAttendanceHistory.Click
        dgvStudents.Columns.Clear() ' Clear previous data


        Try
            Using conn As New MySqlConnection(AppGlobals.ConnString)
                conn.Open()
                Dim sql As String =
                    "SELECT a.attendance_id, s.student_id, s.full_name, s.student_number AS username, a.attendance_date AS Date, a.photo_path " &
                    "FROM attendance a " &
                    "INNER JOIN students s ON a.student_id = s.student_id " &
                    "WHERE s.student_number <> 'student' AND s.is_registered = 1 " &
                    "ORDER BY a.attendance_date DESC"
                Dim da As New MySqlDataAdapter(sql, conn)
                Dim dt As New DataTable()
                da.Fill(dt)
                dgvStudents.DataSource = dt

                dgvStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect
                dgvStudents.MultiSelect = False
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading attendance history: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub btnAddAdmin_Click(sender As Object, e As EventArgs) Handles btnAddAdmin.Click

        Dim addAdminForm As New FormAddAdmin()
        addAdminForm.Show()
        Me.Hide()

    End Sub

    Private Sub FormAdminDashboard2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Add search options
        cmbSearchColumn.Items.Clear()
        cmbSearchColumn.Items.Add("student_id")
        cmbSearchColumn.Items.Add("full_name")
        cmbSearchColumn.SelectedIndex = 0 ' Default

    End Sub
    ' Load Students (renamed button)
    Private Sub btnShowStudents_Click(sender As Object, e As EventArgs) Handles btnShowStudents.Click

        Try
            Using conn As New MySqlConnection(AppGlobals.ConnString)
                conn.Open()
                Dim sql As String =
                "SELECT student_id, full_name, student_number AS username, created_at " &
                "FROM students " &
                "WHERE student_number <> 'student' AND is_registered = 1 " &
                "ORDER BY student_id"
                Dim da As New MySqlDataAdapter(sql, conn)
                Dim dt As New DataTable()
                da.Fill(dt)
                dgvStudents.DataSource = dt

                dgvStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect
                dgvStudents.MultiSelect = False
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading students: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Delete Student
    Private Sub btnDeleteStudent_Click(sender As Object, e As EventArgs) Handles btnDeleteStudent.Click
        If dgvStudents.SelectedRows.Count = 0 Then
            MessageBox.Show("select student full student row to delete", "Please select a student to delete.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Ensure the grid contains student_id
        If Not dgvStudents.Columns.Contains("student_id") Then
            MessageBox.Show("You must switch to 'View Students' before deleting.", "Wrong View", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Get the selected student_id
        Dim studentId As Integer = Convert.ToInt32(dgvStudents.SelectedRows(0).Cells("student_id").Value)

        Dim confirm = MessageBox.Show("Are you sure you want to delete this student?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If confirm = DialogResult.Yes Then
            Using conn As New MySqlConnection(AppGlobals.ConnString)
                Dim sql As String = "DELETE FROM students WHERE student_id = @id"
                Dim cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@id", studentId)
                conn.Open()
                cmd.ExecuteNonQuery()
            End Using
            MessageBox.Show("Student deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Refresh student list
            btnShowStudents.PerformClick()
        End If
    End Sub



    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim columnName As String = cmbSearchColumn.SelectedItem.ToString()
        Dim keyword As String = txtSearch.Text.Trim()

        Using conn As New MySqlConnection(AppGlobals.ConnString)
            Dim sql As String = "SELECT student_id, full_name, student_number, created_at " &
                                "FROM students WHERE " & columnName & " LIKE @keyword"
            Dim cmd As New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@keyword", "%" & keyword & "%")

            Dim da As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()
            da.Fill(dt)
            dgvStudents.DataSource = dt
        End Using
    End Sub



    Private Sub btnShowAll_Click(sender As Object, e As EventArgs) Handles btnShowAll.Click
        txtSearch.Text = ""
        btnShowStudents.PerformClick()

    End Sub

    Private Sub btnViewAttendance_Click(sender As Object, e As EventArgs) Handles btnViewAttendance.Click

        Using conn As New MySqlConnection(AppGlobals.ConnString)
            conn.Open()
            Dim sql = "SELECT a.attendance_id, s.student_id, s.full_name, c.course_name, t.full_name AS teacher_name, a.attendance_date, a.photo_path " &
                  "FROM attendance a " &
                  "JOIN students s ON a.student_id = s.student_id " &
                  "LEFT JOIN courses c ON a.course_id = c.course_id " &
                  "LEFT JOIN teacher_courses tc ON c.course_id = tc.course_id " &
                  "LEFT JOIN teachers t ON tc.teacher_id = t.teacher_id " &
                  "ORDER BY a.attendance_date DESC"
            Dim da As New MySqlDataAdapter(sql, conn)
            Dim dt As New DataTable()
            da.Fill(dt)
            dgvStudents.DataSource = dt
        End Using
    End Sub

    Private Sub txtManageTeachers_Click(sender As Object, e As EventArgs) Handles txtManageTeachers.Click
        Dim f As New FormManageTeachers()
        f.showDialog()
    End Sub

    Private Sub txtManageCourses_Click(sender As Object, e As EventArgs) Handles txtManageCourses.Click
        Dim f As New FormManageCourses()
        f.ShowDialog()
    End Sub

    Private Sub btnAssignCourses_Click(sender As Object, e As EventArgs) Handles btnAssignCourses.Click
        Dim f As New FormAssignCourses()
        f.ShowDialog()
    End Sub
End Class