Public Class Contact

    Dim NewPoint As New System.Drawing.Point
    Dim X, Y As Integer

    Private Sub Panel1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BaraWindow.MouseDown
        X = Control.MousePosition.X - Me.Location.X
        Y = Control.MousePosition.Y - Me.Location.Y
    End Sub
    Private Sub Panel1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BaraWindow.MouseMove
        If e.Button = MouseButtons.Left Then
            NewPoint = Control.MousePosition
            NewPoint.Y -= (Y)
            NewPoint.X -= (X)
            Me.Location = NewPoint
        End If
    End Sub
    Private Sub BaraWindow_Click(sender As Object, e As EventArgs) Handles BaraWindow.Click
    End Sub

    Private Sub Contact_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ListeazaAdreselenoastre_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListeazaAdreselenoastre.SelectedIndexChanged
    End Sub
End Class