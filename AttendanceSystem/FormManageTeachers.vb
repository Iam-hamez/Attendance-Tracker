Imports MySql.Data.MySqlClient

Public Class FormManageTeachers
    Private Sub FormManageTeachers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTeachers()
    End Sub

    Private Sub LoadTeachers()
        Using conn As New MySqlConnection(AppGlobals.ConnString)
            conn.Open()
            Dim sql = "SELECT teacher_id, full_name, username, created_at FROM teachers ORDER BY teacher_id"
            Dim da As New MySqlDataAdapter(sql, conn)
            Dim dt As New DataTable()
            da.Fill(dt)
            dgvTeachers.DataSource = dt
            dgvTeachers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            dgvTeachers.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgvTeachers.MultiSelect = False
        End Using
    End Sub

    Private Sub btnAddTeacher_Click(sender As Object, e As EventArgs) Handles btnAddTeacher.Click
        If txtFullName.Text.Trim() = "" Or txtUsername.Text.Trim() = "" Or txtPassword.Text.Trim() = "" Then
            MessageBox.Show("Please fill all fields.")
            Return
        End If

        Using conn As New MySqlConnection(AppGlobals.ConnString)
            Try
                conn.Open()
                Dim sql = "INSERT INTO teachers (full_name, username, password) VALUES (@n,@u,@p)"
                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@n", txtFullName.Text.Trim())
                    cmd.Parameters.AddWithValue("@u", txtUsername.Text.Trim())
                    cmd.Parameters.AddWithValue("@p", txtPassword.Text.Trim())
                    cmd.ExecuteNonQuery()
                End Using
                MessageBox.Show("Teacher added.")
                LoadTeachers()
                txtFullName.Clear() : txtUsername.Clear() : txtPassword.Clear()
            Catch ex As MySqlException
                If ex.Number = 1062 Then
                    MessageBox.Show("Username already exists.")
                Else
                    MessageBox.Show("Error: " & ex.Message)
                End If
            End Try
        End Using
    End Sub

    Private Sub btnRefreshTeachers_Click(sender As Object, e As EventArgs) Handles btnRefreshTeachers.Click
        LoadTeachers()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        FormAdminDashboard2.Show()
        Me.Close()
    End Sub

    Private Sub txtFullName_TextChanged(sender As Object, e As EventArgs) Handles txtFullName.TextChanged
        If txtFullName.Text.Trim() = "" Then
            MessageBox.Show("Teacher name is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtFullName.Focus()
            Exit Sub
        End If
        If txtFullName.Text.Any(AddressOf Char.IsDigit) Then
            MessageBox.Show("Full name cannot contain numbers.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtFullName.Focus()
            Exit Sub
        End If

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
End Class