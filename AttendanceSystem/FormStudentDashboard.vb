Imports AForge.Video
Imports AForge.Video.DirectShow
Imports MySql.Data.MySqlClient
Imports System.IO

Public Class FormStudentDashboard

    Private webcam As VideoCaptureDevice
    Private webcams As FilterInfoCollection
    Private capturedPhotoPath As String = ""

    ' --- On Load ---
    Private Sub FormStudentDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCoursesForStudent()

        ' Start webcam
        Try
            webcams = New FilterInfoCollection(FilterCategory.VideoInputDevice)
            If webcams.Count = 0 Then
                MessageBox.Show("No webcam detected.")
                Return
            End If
            webcam = New VideoCaptureDevice(webcams(0).MonikerString)
            AddHandler webcam.NewFrame, AddressOf CaptureFrame
            webcam.Start()
        Catch ex As Exception
            MessageBox.Show("Webcam error: " & ex.Message)
        End Try
    End Sub

    ' --- Webcam Frame Capture ---
    Private Sub CaptureFrame(sender As Object, eventArgs As NewFrameEventArgs)
        Try
            Dim bmp As Bitmap = CType(eventArgs.Frame.Clone(), Bitmap)
            If picWebcam.InvokeRequired Then
                picWebcam.Invoke(Sub() picWebcam.Image = bmp)
            Else
                picWebcam.Image = bmp
            End If
        Catch
        End Try
    End Sub

    Private Sub FormStudentDashboard_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try
            If webcam IsNot Nothing AndAlso webcam.IsRunning Then
                webcam.SignalToStop()
                webcam.WaitForStop()
            End If
        Catch
        End Try
    End Sub

    ' --- Capture Photo ---
    Private Sub btnCapture_Click(sender As Object, e As EventArgs) Handles btnCapture.Click
        If picWebcam.Image Is Nothing Then
            MessageBox.Show("No image to capture.")
            Return
        End If

        Try
            Dim studentId As Integer = AppGlobals.LoggedStudentDbId
            If studentId <= 0 Then
                MessageBox.Show("Student ID not found. Re-login.")
                Return
            End If

            Dim folderPath As String = "C:\AttendancePhotos\"
            If Not Directory.Exists(folderPath) Then Directory.CreateDirectory(folderPath)

            Dim filename As String = $"student{studentId}_{DateTime.Now:yyyyMMdd_HHmmss}.jpg"
            capturedPhotoPath = Path.Combine(folderPath, filename)

            picWebcam.Image.Save(capturedPhotoPath, Imaging.ImageFormat.Jpeg)

            MessageBox.Show("Photo captured and saved. Now click Mark Attendance.")
        Catch ex As Exception
            MessageBox.Show("Capture error: " & ex.Message)
        End Try
    End Sub

    ' --- Mark Attendance ---
    Private Sub btnMarkAttendance_Click(sender As Object, e As EventArgs) Handles btnMarkAttendance.Click
        If cmbCourses.SelectedValue Is Nothing Then
            MessageBox.Show("Select a course first.")
            Return
        End If

        Dim courseId As Integer = CInt(cmbCourses.SelectedValue)
        Dim studentId As Integer = AppGlobals.LoggedStudentDbId

        ' Ensure photo exists
        If String.IsNullOrEmpty(capturedPhotoPath) OrElse Not File.Exists(capturedPhotoPath) Then
            MessageBox.Show("Please capture a photo before marking attendance.")
            Return
        End If

        Using conn As New MySqlConnection(AppGlobals.ConnString)
            conn.Open()
            Dim sql = "INSERT INTO attendance (student_id, course_id, photo_path, attendance_date) VALUES (@s,@c,@p,@d)"
            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@s", studentId)
                cmd.Parameters.AddWithValue("@c", courseId)
                cmd.Parameters.AddWithValue("@p", capturedPhotoPath)
                cmd.Parameters.AddWithValue("@d", DateTime.Now) ' store full datetime
                cmd.ExecuteNonQuery()
            End Using
        End Using

        MessageBox.Show("Attendance marked successfully.")
        LoadMyHistory()
    End Sub

    ' --- Load History ---
    Private Sub btnLoadHistory_Click(sender As Object, e As EventArgs) Handles btnLoadHistory.Click
        LoadMyHistory()
    End Sub

    Private Sub LoadMyHistory()
        dgvMyHistory.Columns.Clear()
        dgvMyHistory.Rows.Clear()

        Dim dt As New DataTable
        Using conn As New MySqlConnection(AppGlobals.ConnString)
            Try
                conn.Open()
                Dim sql As String = "SELECT attendance_date, photo_path FROM attendance WHERE student_id=@sid ORDER BY attendance_date DESC"
                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@sid", AppGlobals.LoggedStudentDbId)
                    Using da As New MySqlDataAdapter(cmd)
                        da.Fill(dt)
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Load history error: " & ex.Message)
                Return
            End Try
        End Using

        ' Define columns
        dgvMyHistory.AutoGenerateColumns = False
        Dim colDate As New DataGridViewTextBoxColumn() With {.Name = "Date", .HeaderText = "Date"}
        Dim colTime As New DataGridViewTextBoxColumn() With {.Name = "Time", .HeaderText = "Time"}
        Dim colPhoto As New DataGridViewImageColumn() With {.Name = "Photo", .HeaderText = "Photo", .ImageLayout = DataGridViewImageCellLayout.Zoom}
        dgvMyHistory.Columns.AddRange(New DataGridViewColumn() {colDate, colTime, colPhoto})

        ' Fill rows
        For Each r As DataRow In dt.Rows
            Dim ts As DateTime = Convert.ToDateTime(r("attendance_date"))
            Dim dtStr As String = ts.ToShortDateString()
            Dim tmStr As String = ts.ToLongTimeString()
            Dim ppath As String = Convert.ToString(r("photo_path"))

            Dim img As Image = Nothing
            If File.Exists(ppath) Then
                Try
                    Using fs As New FileStream(ppath, FileMode.Open, FileAccess.Read)
                        img = Image.FromStream(fs)
                    End Using
                Catch
                    img = Nothing
                End Try
            End If

            dgvMyHistory.Rows.Add(dtStr, tmStr, img)
        Next
    End Sub

    ' --- Load Courses ---
    Private Sub LoadCoursesForStudent()
        Using conn As New MySqlConnection(AppGlobals.ConnString)
            conn.Open()
            Dim sql = "SELECT course_id, course_name FROM courses ORDER BY course_name"
            Dim da As New MySqlDataAdapter(sql, conn)
            Dim dt As New DataTable()
            da.Fill(dt)
            cmbCourses.DataSource = dt
            cmbCourses.DisplayMember = "course_name"
            cmbCourses.ValueMember = "course_id"
        End Using
    End Sub

    ' --- Capture helper ---
    Private Function CapturePhoto() As Image
        If picWebcam.Image IsNot Nothing Then
            Return DirectCast(picWebcam.Image.Clone(), Image)
        Else
            Return Nothing
        End If
    End Function

    ' --- Back Button ---
    ' --- Back Button ---
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Try
            If webcam IsNot Nothing AndAlso webcam.IsRunning Then
                webcam.SignalToStop()
                webcam.WaitForStop()
            End If
        Catch
        End Try

        Me.Hide()
        FormLogin.Show()
    End Sub

    Private Sub cmbCourses_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCourses.SelectedIndexChanged
        If cmbCourses.SelectedIndex = -1 Then
            MessageBox.Show("Please select a course before marking attendance.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbCourses.Focus()
            Exit Sub
        End If

        If String.IsNullOrEmpty(capturedPhotoPath) OrElse Not IO.File.Exists(capturedPhotoPath) Then
            MessageBox.Show("Please capture a photo before marking attendance.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

    End Sub
End Class