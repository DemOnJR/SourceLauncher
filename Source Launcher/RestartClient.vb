Public Class StartClient
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

    Private Sub NsButton1_Click(sender As Object, e As EventArgs) Handles NsButton1.Click
        If My.Computer.FileSystem.FileExists("cstrike/CheckLicense.dll") Then
            If My.Computer.FileSystem.FileExists("cstrike.exe") Then
                Process.Start("cstrike.exe")
                LauncherStart.Close()
            Else
                MsgBox("File cstrike.exe not found", MsgBoxStyle.Critical, "HLDS-PROJECT")
                Close()
            End If
        Else
            MsgBox("The license from the launcher is made for Counter Strike Zanyx V6", MsgBoxStyle.Critical, "License Counter Strike")
            Close()
        End If
    End Sub

    Private Sub NsButton2_Click(sender As Object, e As EventArgs) Handles NsButton2.Click
        Close()
    End Sub
End Class