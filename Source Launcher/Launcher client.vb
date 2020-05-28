Public Class LauncherStart
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

    Private Sub NsButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VisitForumALPHCS.Click
        Process.Start("www.alphacs.ro")
    End Sub

    Private Sub NsButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PlayZanyx.Click
  
        'MY PROJECT 2013[XRUSSIAN]

        Dim xRUSSIAN As String
        Dim xRUSSIANasi As String
        Dim xRUSSIANini As String

        xRUSSIAN = "xRUSSIAN.dll"
        xRUSSIANasi = "xRUSSIAN.asi"
        xRUSSIANini = "xRUSSIAN.ini"

        'HUAN GUARD V4

        Dim HuaNGuard As String
        Dim HuaNGuardasi As String
        Dim HuaNGuardini As String

        HuaNGuard = "HuaNGuardV4.dll"
        HuaNGuardasi = "HuaNGuardV4.asi"
        HuaNGuardini = "HuaNLOAD.ini"

        'CTShield by ostrog 

        Dim CTShield2 As String
        Dim CTShieldasi As String
        Dim CTShieldini As String
        Dim CTShieldtxt As String
        Dim CTShieldnick As String

        CTShield2 = "CTShield.dll"
        CTShieldasi = "CTShield.asi"
        CTShieldini = "CTShield.ini"
        CTShieldtxt = "CTShield.txt"
        CTShieldnick = "nick_list.ini"

        'RAIZ0 GUARD

        Dim RAIZ0CFG As String
        Dim RAIZ0CFGasi As String
        Dim RAIZ0CFGini As String

        RAIZ0CFG = "raiz0CFG.dll"
        RAIZ0CFGasi = "raiz0CFG.asi"
        RAIZ0CFGini = "raiz0CFG.ini"

        'Cardinal GUARD

        Dim Cardinal As String
        Dim Cardinalasi As String
        Dim Cardinalini As String

        Cardinal = "Cardinal.dll"
        Cardinalasi = "Cardinal.asi"
        Cardinalini = "Cardinal.ini"

        'CSXGUARD

        Dim CSXGuard As String
        Dim CSXGuardasi As String
        Dim CSXGuardini As String

        CSXGuard = "CSXGuard.dll"
        CSXGuardasi = "CSXGuard.asi"
        CSXGuardini = "CSXGuard.ini"

        Dim TrackerUI As String
        ' Dim Libgam As String

        'Fixi bug client

        TrackerUI = "cstrike\bin\TrackerUI.dll"
        '  Libgam = ""

        'If System.IO.File.Exists(xRUSSIAN) = True Then

        'MY PROJECT 2013[XRUSSIAN]

        System.IO.File.Delete(xRUSSIAN)
        System.IO.File.Delete(xRUSSIANasi)
        System.IO.File.Delete(xRUSSIANini)

        'HUAN GUARD V4

        System.IO.File.Delete(HuaNGuard)
        System.IO.File.Delete(HuaNGuardasi)
        System.IO.File.Delete(HuaNGuardini)

        'CTSHIELD BY OSTROG 
        System.IO.File.Delete(CTShield2)
        System.IO.File.Delete(CTShieldasi)
        System.IO.File.Delete(CTShieldini)
        System.IO.File.Delete(CTShieldtxt)
        System.IO.File.Delete(CTShieldnick)

        'RAIZ0 GUARD

        System.IO.File.Delete(RAIZ0CFG)
        System.IO.File.Delete(RAIZ0CFGasi)
        System.IO.File.Delete(RAIZ0CFGini)

        'Cardinal GUARD

        System.IO.File.Delete(Cardinal)
        System.IO.File.Delete(Cardinalasi)
        System.IO.File.Delete(Cardinalini)

        'CSXGuard

        System.IO.File.Delete(CSXGuard)
        System.IO.File.Delete(CSXGuardasi)
        System.IO.File.Delete(CSXGuardini)

        'fixi bug client

        System.IO.File.Delete(TrackerUI)

        ' MsgBox("Incompatible files have been deleted", MsgBoxStyle.Information, "HLDS-RUSSIAN")

        '  End If
        If My.Computer.FileSystem.FileExists("cstrike/CheckLicense.dll") Then
            If My.Computer.FileSystem.FileExists("cstrike.exe") Then
                Process.Start("cstrike.exe")
                Close()
            Else
                MsgBox("File cstrike.exe not found", MsgBoxStyle.Critical, "HLDS-PROJECT")
            End If
        Else
            MsgBox("The license from the launcher is made for Counter Strike Zanyx V6", MsgBoxStyle.Critical, "License Counter Strike")
        End If
    End Sub

    Private Sub NsButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Updater.Click
        If My.Computer.FileSystem.FileExists("cstrike/CheckLicense.dll") Then
            If My.Computer.FileSystem.FileExists("Updater.exe") Then
                Process.Start("Updater.exe")
                Close()
            Else
                MsgBox("File Updater.exe not found", MsgBoxStyle.Critical, "HLDS-PROJECT")
            End If
        Else
            MsgBox("The license from the launcher is made for Counter Strike Zanyx V6", MsgBoxStyle.Critical, "License Counter Strike")
        End If
    End Sub

    Private Sub NsButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptionsMenu.Click
        Form2.Show()
    End Sub

    Private Sub Panel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BaraWindow.Click

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'MY PROJECT 2013[XRUSSIAN]

        Dim xRUSSIAN As String
        Dim xRUSSIANasi As String
        Dim xRUSSIANini As String

        xRUSSIAN = "xRUSSIAN.dll"
        xRUSSIANasi = "xRUSSIAN.asi"
        xRUSSIANini = "xRUSSIAN.ini"

        'HUAN GUARD V4

        Dim HuaNGuard As String
        Dim HuaNGuardasi As String
        Dim HuaNGuardini As String

        HuaNGuard = "HuaNGuardV4.dll"
        HuaNGuardasi = "HuaNGuardV4.asi"
        HuaNGuardini = "HuaNLOAD.ini"

        'CTShield by ostrog 

        Dim CTShield2 As String
        Dim CTShieldasi As String
        Dim CTShieldini As String
        Dim CTShieldtxt As String
        Dim CTShieldnick As String

        CTShield2 = "CTShield.dll"
        CTShieldasi = "CTShield.asi"
        CTShieldini = "CTShield.ini"
        CTShieldtxt = "CTShield.txt"
        CTShieldnick = "nick_list.ini"

        'RAIZ0 GUARD

        Dim RAIZ0CFG As String
        Dim RAIZ0CFGasi As String
        Dim RAIZ0CFGini As String

        RAIZ0CFG = "raiz0CFG.dll"
        RAIZ0CFGasi = "raiz0CFG.asi"
        RAIZ0CFGini = "raiz0CFG.ini"

        'Cardinal GUARD

        Dim Cardinal As String
        Dim Cardinalasi As String
        Dim Cardinalini As String

        Cardinal = "Cardinal.dll"
        Cardinalasi = "Cardinal.asi"
        Cardinalini = "Cardinal.ini"

        'CSXGUARD

        Dim CSXGuard As String
        Dim CSXGuardasi As String
        Dim CSXGuardini As String

        CSXGuard = "CSXGuard.dll"
        CSXGuardasi = "CSXGuard.asi"
        CSXGuardini = "CSXGuard.ini"

        Dim TrackerUI As String
        ' Dim Libgam As String

        'Fixi bug client

        TrackerUI = "cstrike\bin\TrackerUI.dll"
        '  Libgam = ""
        My.Computer.FileSystem.CreateDirectory(
          "cstrike\bin")

        'If System.IO.File.Exists(xRUSSIAN) = True Then

        'MY PROJECT 2013[XRUSSIAN]

        System.IO.File.Delete(xRUSSIAN)
        System.IO.File.Delete(xRUSSIANasi)
        System.IO.File.Delete(xRUSSIANini)

        'HUAN GUARD V4

        System.IO.File.Delete(HuaNGuard)
        System.IO.File.Delete(HuaNGuardasi)
        System.IO.File.Delete(HuaNGuardini)

        'CTSHIELD BY OSTROG 
        System.IO.File.Delete(CTShield2)
        System.IO.File.Delete(CTShieldasi)
        System.IO.File.Delete(CTShieldini)
        System.IO.File.Delete(CTShieldtxt)
        System.IO.File.Delete(CTShieldnick)

        'RAIZ0 GUARD

        System.IO.File.Delete(RAIZ0CFG)
        System.IO.File.Delete(RAIZ0CFGasi)
        System.IO.File.Delete(RAIZ0CFGini)

        'Cardinal GUARD

        System.IO.File.Delete(Cardinal)
        System.IO.File.Delete(Cardinalasi)
        System.IO.File.Delete(Cardinalini)

        'CSXGuard

        System.IO.File.Delete(CSXGuard)
        System.IO.File.Delete(CSXGuardasi)
        System.IO.File.Delete(CSXGuardini)

        'fixi bug client

        System.IO.File.Delete(TrackerUI)

        ' MsgBox("Incompatible files have been deleted", MsgBoxStyle.Information, "HLDS-RUSSIAN")

        '  End If

        If My.Computer.FileSystem.FileExists("classic.zanyx") Then
            wpn.ForeColor = Color.ForestGreen
            wpn.Text = ("Weapons Models : Classic")
        Else
        End If

        If My.Computer.FileSystem.FileExists("fps.zanyx") Then
            wpn.ForeColor = Color.ForestGreen
            wpn.Text = ("Weapons Models : FPS")
        Else
        End If

        If My.Computer.FileSystem.FileExists("hd.zanyx") Then
            wpn.ForeColor = Color.ForestGreen
            wpn.Text = ("Weapons Models : HD")
        Else
        End If

        If My.Computer.FileSystem.FileExists("Updater.exe") Then
            If My.Computer.FileSystem.FileExists("valve\bin\TrackerUI.dll") Then
                GuardChecker.Text = ("HLDS-GUARD : ON")
            Else
                GuardChecker.Text = ("HLDS-GUARD : OFF")
                GuardChecker.ForeColor = Color.Red
            End If
        Else
            MsgBox("File Updater.exe not found", MsgBoxStyle.Critical, "HLDS-RUSSIAN")
            Close()
        End If
        If My.Computer.FileSystem.FileExists("valve\bin\TrackerUI.ini") Then
        Else
            MsgBox("File HLDS-Protector.dll not found", MsgBoxStyle.Critical, "HLDS-RUSSIAN")
            Close()
        End If
    End Sub

    Private Sub LauncherNew_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles LauncherNew.DocumentCompleted

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles GuardChecker.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub ButtonAuthor2_Click(sender As Object, e As EventArgs)
        'BaraWindow.BackColor = Color.Green
        ' Minimare.BackColor = Color.Green
        ' Iesire.BackColor = Color.Green
    End Sub

    Private Sub TableZanyx_Click(sender As Object, e As EventArgs) Handles TableZanyx.Click

    End Sub
End Class
