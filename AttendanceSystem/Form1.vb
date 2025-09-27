Imports MySql.Data.MySqlClient

Public Class FormSplash

    Private Sub FormSplash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' initialize progress bar
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = 100
        ProgressBar1.Value = 0

        ' Timer interval: 30 ms -> 100 steps * 100ms = 10,000ms = 30s
        ' Change Interval or step size below if you want shorter/longer splash.
        Timer1.Interval = 30
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            If ProgressBar1.Value < ProgressBar1.Maximum Then
                ProgressBar1.Value += 1
            Else
                ' progress complete
                Timer1.Stop()
                CheckAdminAndProceed()
            End If
        Catch ex As Exception
            ' Fail-safe: stop the timer and proceed to login on unexpected error
            Timer1.Stop()
            MessageBox.Show("Splash error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            CheckAdminAndProceed()
        End Try
    End Sub

    Private Sub CheckAdminAndProceed()
        ' This performs the DB admin existence check and opens the next form.
        Using conn As New MySqlConnection(AppGlobals.ConnString)
            Try
                conn.Open()
                Dim sql As String = "SELECT COUNT(*) FROM admin"
                Using cmd As New MySqlCommand(sql, conn)
                    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                    If count = 0 Then
                        ' No admin yet -> open admin registration form
                        Dim adminForm As New FormAdminRegistration()
                        adminForm.Show()
                    Else
                        ' Admin exists -> open login form
                        Dim loginForm As New FormLogin()
                        loginForm.Show()
                    End If
                End Using
            Catch ex As Exception
                ' If DB check fails, show an error and try to open login as fallback
                MessageBox.Show("Error checking admin: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Try
                    Dim loginForm As New FormLogin()
                    loginForm.Show()
                Catch
                    ' swallow - we don't want to crash the splash
                End Try
            Finally
                ' hide splash in all cases (we already showed the next form)
                Me.Hide()
            End Try
        End Using
    End Sub

End Class
