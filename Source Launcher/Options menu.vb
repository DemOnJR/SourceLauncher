Public Class Form2
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


    Private Sub NsButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonHD.Click
        ButtonHDModels.Show()
    End Sub

    Private Sub NsButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonFPS.Click
        ButtonFPSModels.show()
    End Sub

    Private Sub NsButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonClassic.Click
        ButtonCLASSICModels.Show()
    End Sub

    Private Sub NsButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButonBackUPP.Click
        HLDSGUARD.Show()
        Try
            Dim CounterStrikeZanyxhl() As Process = Process.GetProcessesByName("hl")

            Dim CounterStrikeZanyxcstrike() As Process = Process.GetProcessesByName("cstrike")

            '[Oprim Counter Strike pentru a evita bugurile]

            For Each Process As Process In CounterStrikeZanyxhl
                Process.Kill()
            Next

            For Each Process As Process In CounterStrikeZanyxcstrike
                Process.Kill()
            Next

        Catch x As Exception
        End Try
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub NsButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButonReport.Click
        ButtonReportBug.Show()
    End Sub

    Private Sub Panel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BaraWindow.Click

    End Sub

    Private Sub NsButton7_Click(sender As Object, e As EventArgs) Handles ButtonAuthor1.Click
        If My.Computer.FileSystem.FileExists("cstrike/CheckLicense.dll") Then
            LauncherStart.LauncherNew.Visible = True
            LauncherStart.LauncherScreen.Visible = False
        Else
            MsgBox("The license from the launcher is made for Counter Strike Zanyx V6", MsgBoxStyle.Critical, "License Counter Strike")
        End If
    End Sub

    Private Sub NsButton6_Click(sender As Object, e As EventArgs) Handles BreakingNewsDisabled.Click
        If My.Computer.FileSystem.FileExists("cstrike/CheckLicense.dll") Then
            LauncherStart.Label1.BackColor = Color.Black
            LauncherStart.LauncherScreen.Visible = True
            LauncherStart.LauncherNew.Visible = False
        Else
            MsgBox("The license from the launcher is made for Counter Strike Zanyx V6", MsgBoxStyle.Critical, "License Counter Strike")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Copyright © 2015 HLDS-RUSSIAN", MsgBoxStyle.Information, "HLDS-Project or RUSSIAN-TEAM")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonAuthor2.Click
        MsgBox("Copyright © 2015 SkillartzHD and MaRky", MsgBoxStyle.Information, "HLDS-Project or RUSSIAN-TEAM")
    End Sub

    Private Sub IesireButton_Click(sender As Object, e As EventArgs) Handles IesireButton.Click
        ButtonReportBug.Close()
        ButtonCLASSICModels.Close()
        HLDSGUARD.Close()
        ButtonHDModels.Close()
        Contact.Close()
        ButtonFPSModels.Close()
        StartClient.Close()
    End Sub
End Class