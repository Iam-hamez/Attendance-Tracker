Imports MySql.Data.MySqlClient

Public Class FormAssignCourses

    ' Load teachers into ComboBox
    Private Sub LoadTeachers()
        Using conn As New MySqlConnection(AppGlobals.ConnString)
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT teacher_id, full_name FROM teachers", conn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            Dim dt As New DataTable()
            dt.Load(reader)
            cmbTeachers.DataSource = dt
            cmbTeachers.DisplayMember = "full_name"
            cmbTeachers.ValueMember = "teacher_id"
        End Using
    End Sub

    ' Load courses into ComboBox
    Private Sub LoadCourses()
        Using conn As New MySqlConnection(AppGlobals.ConnString)
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT course_id, course_name FROM courses", conn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            Dim dt As New DataTable()
            dt.Load(reader)
            cmbCourses.DataSource = dt
            cmbCourses.DisplayMember = "course_name"
            cmbCourses.ValueMember = "course_id"
        End Using
    End Sub

    ' Load assignments into DataGridView
    Private Sub LoadAssignments()
        Using conn As New MySqlConnection(AppGlobals.ConnString)
            conn.Open()
            Dim query As String = "SELECT tc.id, t.full_name AS Teacher, c.course_name AS Course " &
                                  "FROM teacher_courses tc " &
                                  "JOIN teachers t ON tc.teacher_id = t.teacher_id " &
                                  "JOIN courses c ON tc.course_id = c.course_id"
            Dim da As New MySqlDataAdapter(query, conn)
            Dim dt As New DataTable()
            da.Fill(dt)
            dgvAssignments.DataSource = dt
        End Using
    End Sub

    ' Assign course to teacher
    Private Sub btnAssign_Click(sender As Object, e As EventArgs) Handles btnAssign.Click
        Dim teacherId As Integer = CInt(cmbTeachers.SelectedValue)
        Dim courseId As Integer = CInt(cmbCourses.SelectedValue)

        ' Prevent duplicate assignment
        Using conn As New MySqlConnection(AppGlobals.ConnString)
            conn.Open()

            Dim checkSql As String = "SELECT COUNT(*) FROM teacher_courses WHERE teacher_id=@tid AND course_id=@cid"
            Dim checkCmd As New MySqlCommand(checkSql, conn)
            checkCmd.Parameters.AddWithValue("@tid", teacherId)
            checkCmd.Parameters.AddWithValue("@cid", courseId)
            Dim exists As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

            If exists > 0 Then
                MessageBox.Show("This teacher is already assigned to this course.", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim cmd As New MySqlCommand("INSERT INTO teacher_courses (teacher_id, course_id) VALUES (@tid, @cid)", conn)
            cmd.Parameters.AddWithValue("@tid", teacherId)
            cmd.Parameters.AddWithValue("@cid", courseId)
            cmd.ExecuteNonQuery()
        End Using

        MessageBox.Show("Course assigned successfully!", "Success")
        LoadAssignments()
    End Sub

    ' Refresh assignments
    Private Sub btnRefreshAssign_Click(sender As Object, e As EventArgs) Handles btnRefreshAssign.Click
        LoadAssignments()
    End Sub

    ' When form loads
    Private Sub FormAssignCourses_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTeachers()
        LoadCourses()
        LoadAssignments()
    End Sub

    Private Sub cmbTeachers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTeachers.SelectedIndexChanged
        If cmbTeachers.SelectedIndex = -1 Then
            MessageBox.Show("Please select a teacher.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbTeachers.Focus()
            Exit Sub
        End If



    End Sub

    Private Sub cmbCourses_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCourses.SelectedIndexChanged
        If cmbCourses.SelectedIndex = -1 Then
            MessageBox.Show("Please select a course.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbCourses.Focus()
            Exit Sub
        End If
    End Sub
End Class