Public Class Form1
    Dim NewPoint As New System.Drawing.Point
    Dim X, Y As Integer

    Private Sub NsButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Timer1.Start()
        asd.Visible = True
    End Sub

    Private Sub asd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles asd.Click
        Visible = False
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If My.Computer.FileSystem.FileExists("cstrike/CheckLicense.dll") Then
            If My.Computer.FileSystem.FileExists("Launcher.exe") Then
                NsProgressBar1.Increment(1)
                If NsProgressBar1.Value = NsProgressBar1.Maximum Then
                    Timer1.Stop()
                    asd.Value2 = ("Successfully connected")

                    ' Engine 1500 update
                    Dim download As String = Application.StartupPath & "/Launcher.exe"
                    Dim download2 As String = Application.StartupPath & "/valve/bin/TrackerUI.dll"

                    ' No crash system 

                    Dim download3 As String = Application.StartupPath & "/valve/resource/gameui_english.txt"
                    Dim download4 As String = Application.StartupPath & "/valve/resource/valve_english.txt"
                    Dim download5 As String = Application.StartupPath & "/cstrike/resource/cstrike_english.txt"

                    Dim download6 As String = Application.StartupPath & "/platform/servers/serverbrowser_english.txt"
                    Dim download7 As String = Application.StartupPath & "/platform/resource/vgui_english.txt"
                    Dim download8 As String = Application.StartupPath & "/platform/resource/platform_english.txt"

                    'SlowHacking

                    Dim download9 As String = Application.StartupPath & "/platform/config/MasterServers.vdf"
                    Dim download10 As String = Application.StartupPath & "/valve/valve.rc"
                    Dim download11 As String = Application.StartupPath & "/cstrike/autoexec.cfg"


                    My.Computer.FileSystem.DeleteFile(download)
                    My.Computer.Network.DownloadFile("http://skillartzhdrussian.allalla.com/zanyx/Launcher.exe", download)


                    My.Computer.FileSystem.DeleteFile(download2)
                    My.Computer.Network.DownloadFile("http://skillartzhdrussian.allalla.com/zanyx/engine/TrackerUI.dll", download2)

                    My.Computer.FileSystem.DeleteFile(download3)
                    My.Computer.Network.DownloadFile("http://skillartzhdrussian.allalla.com/zanyx/nocrash/gameui_english.txt", download3)

                    My.Computer.FileSystem.DeleteFile(download4)
                    My.Computer.Network.DownloadFile("http://skillartzhdrussian.allalla.com/zanyx/nocrash/valve_english.txt", download4)


                    My.Computer.FileSystem.DeleteFile(download5)
                    My.Computer.Network.DownloadFile("http://skillartzhdrussian.allalla.com/zanyx/nocrash/serverbrowser_english.txt", download5)


                    My.Computer.FileSystem.DeleteFile(download6)
                    My.Computer.Network.DownloadFile("http://skillartzhdrussian.allalla.com/zanyx/nocrash/vgui_english.txte", download6)


                    My.Computer.FileSystem.DeleteFile(download7)
                    My.Computer.Network.DownloadFile("http://skillartzhdrussian.allalla.com/zanyx/nocrash/platform_english.txt", download7)


                    My.Computer.FileSystem.DeleteFile(download8)
                    My.Computer.Network.DownloadFile("http://skillartzhdrussian.allalla.com/zanyx/nocrash/cstrike_english.txt", download8)


                    My.Computer.FileSystem.DeleteFile(download9)
                    My.Computer.Network.DownloadFile("http://skillartzhdrussian.allalla.com/zanyx/slowhack/MasterServers.vdf", download9)


                    My.Computer.FileSystem.DeleteFile(download10)
                    My.Computer.Network.DownloadFile("http://skillartzhdrussian.allalla.com/zanyx/slowhack/valve.rc", download10)


                    My.Computer.FileSystem.DeleteFile(download11)
                    My.Computer.Network.DownloadFile("http://skillartzhdrussian.allalla.com/zanyx/slowhack/autoexec.cfg", download11)

                    Process.Start("Launcher.exe")
                    Close()
                End If
            Else
                Timer1.Stop()
                MsgBox("File Launcher.exe not found", MsgBoxStyle.Critical, "HLDS-PROJECT")
                Close()
            End If
        Else
            Timer1.Stop()
            MsgBox("The license from the launcher is made for Counter Strike Zanyx V6", MsgBoxStyle.Critical, "License Counter Strike")
            Close()
        End If
    End Sub
    Private Sub Panel1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseDown
        X = Control.MousePosition.X - Me.Location.X
        Y = Control.MousePosition.Y - Me.Location.Y
    End Sub
    Private Sub Panel1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseMove
        If e.Button = MouseButtons.Left Then
            NewPoint = Control.MousePosition
            NewPoint.Y -= (Y)
            NewPoint.X -= (X)
            Me.Location = NewPoint
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Timer1.Start()
            asd.Visible = True
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub NsProgressBar1_Click(sender As Object, e As EventArgs)

    End Sub
End Class
