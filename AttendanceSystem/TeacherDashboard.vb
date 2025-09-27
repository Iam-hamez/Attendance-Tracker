Imports MySql.Data.MySqlClient


Public Class TeacherDashboard
    Private Sub TeacherDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAssignedCourses()
    End Sub

    Private Sub LoadAssignedCourses()
        Using conn As New MySqlConnection(AppGlobals.ConnString)
            conn.Open()
            Dim sql = "SELECT c.course_id, c.course_name FROM courses c " &
                  "JOIN teacher_courses tc ON c.course_id = tc.course_id " &
                  "WHERE tc.teacher_id = @t ORDER BY c.course_name"
            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@t", AppGlobals.LoggedTeacherDbId)
                Dim da As New MySqlDataAdapter(cmd)
                Dim dt As New DataTable()
                da.Fill(dt)
                cmbTeacherCourses.DataSource = dt
                cmbTeacherCourses.DisplayMember = "course_name"
                cmbTeacherCourses.ValueMember = "course_id"
            End Using
        End Using
    End Sub


    Private Sub btnViewAttendance_Click(sender As Object, e As EventArgs) Handles btnViewAttendance.Click
        If cmbTeacherCourses.SelectedValue Is Nothing Then Return
        Dim courseId As Integer = CInt(cmbTeacherCourses.SelectedValue)

        Using conn As New MySqlConnection(AppGlobals.ConnString)
            conn.Open()
            Dim sql = "SELECT a.attendance_id, s.student_id, s.full_name, c.course_name, a.attendance_date, a.photo_path " &
                  "FROM attendance a " &
                  "JOIN students s ON a.student_id = s.student_id " &
                  "JOIN courses c ON a.course_id = c.course_id " &
                  "WHERE a.course_id = @cid ORDER BY a.attendance_date DESC"
            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@cid", courseId)
                Dim da As New MySqlDataAdapter(cmd)
                Dim dt As New DataTable()
                da.Fill(dt)
                dgvAttendance.DataSource = dt
                dgvAttendance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

                ' Optional: show thumbnails in a column named photo_path
                If dgvAttendance.Columns.Contains("photo_path") Then
                    If Not TypeOf dgvAttendance.Columns("photo_path") Is DataGridViewImageColumn Then
                        Dim imgCol As New DataGridViewImageColumn()
                        imgCol.Name = "PhotoThumb"
                        imgCol.HeaderText = "Photo"
                        imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom
                        dgvAttendance.Columns.Add(imgCol)
                    End If

                    For Each r As DataGridViewRow In dgvAttendance.Rows
                        Try
                            Dim p = r.Cells("photo_path").Value
                            If p IsNot Nothing AndAlso IO.File.Exists(p.ToString()) Then
                                r.Cells("PhotoThumb").Value = Image.FromFile(p.ToString())
                            End If
                        Catch
                        End Try
                    Next
                End If
            End Using
        End Using
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Dim LoginForm As New FormLogin()
        LoginForm.Show()
        Me.Hide()
    End Sub
End Class