Public Class HLDSGUARD
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

    Private Sub NsButton2_Click(sender As Object, e As EventArgs) Handles NsButton2.Click
        If My.Computer.FileSystem.FileExists("cstrike/CheckLicense.dll") Then
            If My.Computer.FileSystem.FileExists("valve/bin/TrackerUI.dll") Then
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
                LauncherStart.GuardChecker.ForeColor = Color.Red
                LauncherStart.GuardChecker.Text = ("HLDS-GUARD : OFF")
                MsgBox(" WARNING: If you disable the guard you will be vulnerable to harmfull commands!", MsgBoxStyle.Information, "WARNING")
                If My.Computer.FileSystem.FileExists("valve/bin/TrackerUI.dll") Then
                    My.Computer.FileSystem.RenameFile("valve/bin/TrackerUI.dll", "TrackerUI.dll.bak")
                    StartClient.Show()
                    MsgBox("HLDS-GUARD has been disabled succesfully", MsgBoxStyle.Information, "HLDS-GUARD Disabled")
                    Close()
                Else
                    MsgBox("File HLDS-GUARD not found", MsgBoxStyle.Information, "HLDS-GUARD Disabled")
                    Close()
                End If
            Else
                MsgBox("HLDS-GUARD is already disabled", MsgBoxStyle.Information, "HLDS-GUARD Disabled")
            End If
        Else
            MsgBox("The license from the launcher is made for Counter Strike Zanyx V6", MsgBoxStyle.Critical, "License Counter Strike")
            Close()
        End If
    End Sub

    Private Sub NsButton1_Click(sender As Object, e As EventArgs) Handles NsButton1.Click
        If My.Computer.FileSystem.FileExists("cstrike/CheckLicense.dll") Then
            If My.Computer.FileSystem.FileExists("valve/bin/TrackerUI.dll.bak") Then


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
                LauncherStart.GuardChecker.ForeColor = Color.ForestGreen
                LauncherStart.GuardChecker.Text = ("HLDS-GUARD : ON")
                If My.Computer.FileSystem.FileExists("valve/bin/TrackerUI.dll.bak") Then
                    My.Computer.FileSystem.RenameFile("valve/bin/TrackerUI.dll.bak", "TrackerUI.dll")
                    StartClient.Show()
                    MsgBox("HLDS-GUARD has been enabled succesfully", MsgBoxStyle.Information, "HLDS-GUARD Enabled")
                    Close()
                Else
                    MsgBox("File HLDS-GUARD not found", MsgBoxStyle.Information, "HLDS-GUARD Disabled")
                End If
            Else
                MsgBox("HLDS-GUARD is already enabled", MsgBoxStyle.Information, "HLDS-GUARD Enabled")
            End If
        Else
            MsgBox("The license from the launcher is made for Counter Strike Zanyx V6", MsgBoxStyle.Critical, "License Counter Strike")
            Close()
        End If
    End Sub

    Private Sub NsButton5_Click(sender As Object, e As EventArgs) Handles NsButton5.Click
        If My.Computer.FileSystem.FileExists("valve/bin/SVC_BlockCommand.log") Then
            Process.Start("valve\bin\SVC_BlockCommand.log")
        Else
            MsgBox("File SVC_BlockCommand.log not found", MsgBoxStyle.Information, "Log")
        End If

    End Sub

    Private Sub NsButton3_Click(sender As Object, e As EventArgs) Handles NsButton3.Click
        If My.Computer.FileSystem.FileExists("cstrike/CheckLicense.dll") Then
        Else
            MsgBox("The license from the launcher is made for Counter Strike Zanyx V6", MsgBoxStyle.Critical, "License Counter Strike")
            Close()
        End If
        If My.Computer.FileSystem.FileExists("valve/bin/TrackerUI.dll") Then
            Dim dwd As String = Application.StartupPath & "/valve/bin/TrackerUI.dll"

            My.Computer.FileSystem.DeleteFile(dwd)
            My.Computer.Network.DownloadFile("http://skillartzhdrussian.allalla.com/zanyx/engine/TrackerUI_clear.dll", dwd)
            MsgBox("Done", MsgBoxStyle.Information, "HLDS-GUARD")
        Else
            MsgBox("File valve/bin/TrackerUI.dll not found", MsgBoxStyle.Critical, "HLDS-GUARD")
        End If

    End Sub

    Private Sub HLDSGUARD_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub NsButton4_Click(sender As Object, e As EventArgs) Handles NsButton4.Click
        If My.Computer.FileSystem.FileExists("cstrike/CheckLicense.dll") Then
        Else
            MsgBox("The license from the launcher is made for Counter Strike Zanyx V6", MsgBoxStyle.Critical, "License Counter Strike")
            Close()
        End If
        If My.Computer.FileSystem.FileExists("valve/bin/TrackerUI.dll") Then
            Dim dwd As String = Application.StartupPath & "/valve/bin/TrackerUI.dll"

            My.Computer.FileSystem.DeleteFile(dwd)
            My.Computer.Network.DownloadFile("http://skillartzhdrussian.allalla.com/zanyx/engine/TrackerUI.dll", dwd)
            MsgBox("Done", MsgBoxStyle.Information, "HLDS-GUARD")
        Else
            MsgBox("File valve/bin/TrackerUI.dll not found", MsgBoxStyle.Critical, "HLDS-GUARD")
        End If
    End Sub
End Class