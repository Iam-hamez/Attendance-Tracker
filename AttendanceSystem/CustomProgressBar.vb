Imports System.Drawing
Imports System.Windows.Forms

Public Class CustomProgressBar
    Inherits ProgressBar

    Public Sub New()
        ' Enable custom painting
        Me.SetStyle(ControlStyles.UserPaint, True)
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Dim rect As Rectangle = e.ClipRectangle

        ' Calculate filled portion width
        rect.Width = CInt(rect.Width * (CDbl(Me.Value) / Me.Maximum))

        ' Fill progress area in gray
        If rect.Width > 0 Then
            e.Graphics.FillRectangle(Brushes.Gray, 0, 0, rect.Width, Me.Height)
        End If

        ' Draw border
        e.Graphics.DrawRectangle(Pens.Gray, 0, 0, Me.Width - 1, Me.Height - 1)
    End Sub
End Class