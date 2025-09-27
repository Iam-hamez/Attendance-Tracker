Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Drawing

Public Class FormAttendanceHistory

    Private Sub FormAttendanceHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Optional: Load history immediately when form opens
        LoadAttendanceHistory()
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        LoadAttendanceHistory()
    End Sub

    Private Sub LoadAttendanceHistory()
        dgvAttendance.Columns.Clear()
        Dim dt As New DataTable()

        Using conn As New MySqlConnection(AppGlobals.ConnString)
            Try
                conn.Open()
                ' Query joins students table to get full_name and student_number
                Dim sql As String = "SELECT a.attendance_id, s.full_name, s.student_number, a.attendance_date, a.attendance_time, a.photo_path " &
                                    "FROM attendance a " &
                                    "JOIN students s ON a.student_id = s.student_id " &
                                    "ORDER BY a.attendance_date DESC, a.attendance_time DESC"

                Using cmd As New MySqlCommand(sql, conn)
                    Using da As New MySqlDataAdapter(cmd)
                        da.Fill(dt)
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error loading attendance: " & ex.Message)
                Return
            End Try
        End Using

        ' Build DataGridView columns
        dgvAttendance.AutoGenerateColumns = False
        Dim colName As New DataGridViewTextBoxColumn() With {.Name = "Name", .HeaderText = "Full Name", .DataPropertyName = "full_name"}
        Dim colNumber As New DataGridViewTextBoxColumn() With {.Name = "Number", .HeaderText = "Student Number", .DataPropertyName = "student_number"}
        Dim colDate As New DataGridViewTextBoxColumn() With {.Name = "Date", .HeaderText = "Date", .DataPropertyName = "attendance_date"}
        Dim colTime As New DataGridViewTextBoxColumn() With {.Name = "Time", .HeaderText = "Time", .DataPropertyName = "attendance_time"}
        Dim colPhoto As New DataGridViewImageColumn() With {.Name = "Photo", .HeaderText = "Photo", .ImageLayout = DataGridViewImageCellLayout.Zoom}

        dgvAttendance.Columns.AddRange(New DataGridViewColumn() {colName, colNumber, colDate, colTime, colPhoto})

        ' Fill rows
        For Each r As DataRow In dt.Rows
            Dim img As Image = Nothing
            Dim path As String = Convert.ToString(r("photo_path"))
            If File.Exists(path) Then
                Try
                    Dim fs As New FileStream(path, FileMode.Open, FileAccess.Read)
                    img = Image.FromStream(fs)
                    fs.Close()
                Catch
                    img = Nothing
                End Try
            End If
            dgvAttendance.Rows.Add(r("full_name"), r("student_number"), r("attendance_date"), r("attendance_time"), img)
        Next
    End Sub

    Private Sub dgvAttendance_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAttendance.CellContentClick

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim adminDash As New FormAdminDashboard2
        adminDash.Show()
        Me.Close()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
End Class
