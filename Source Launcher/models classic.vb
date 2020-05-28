Public NotInheritable Class ButtonCLASSICModels

    Private Sub AboutBox4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub NsButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttoNO.Click
        Close()
    End Sub

    Private Sub NsButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonYES.Click
        'asta e gata 

        Dim FileToDelete As String

        FileToDelete = "fps.zanyx"

        If System.IO.File.Exists(FileToDelete) = True Then

            System.IO.File.Delete(FileToDelete)

        End If

        Dim FileToDelete2 As String
        FileToDelete2 = "hd.zanyx"

        If System.IO.File.Exists(FileToDelete2) = True Then

            System.IO.File.Exists(FileToDelete2)

        End If

        Dim filepath As String = "classic.zanyx"
        If Not System.IO.File.Exists(filepath) Then
            System.IO.File.Create(filepath).Dispose()
        End If

        LauncherStart.wpn.ForeColor = Color.ForestGreen
        LauncherStart.wpn.Text = ("Weapons Models : Classic")

        Dim upaa3 As String = Application.StartupPath & "/cstrike/models/chick.mdl"
        Dim upaa4 As String = Application.StartupPath & "/cstrike/models/pshell.mdl"
        Dim upaa5 As String = Application.StartupPath & "/cstrike/models/rshell.mdl"
        Dim upaa6 As String = Application.StartupPath & "/cstrike/models/rshell_big.mdl"

        Dim upa3 As String = Application.StartupPath & "/cstrike/models/v_ak47.mdl"
        Dim upa4 As String = Application.StartupPath & "/cstrike/models/p_ak47.mdl"
        Dim upa5 As String = Application.StartupPath & "/cstrike/models/w_ak47.mdl"
        Dim upa6 As String = Application.StartupPath & "/cstrike/models/v_m4a1.mdl"
        Dim upa7 As String = Application.StartupPath & "/cstrike/models/p_m4a1.mdl"
        Dim upa8 As String = Application.StartupPath & "/cstrike/models/w_m4a1.mdl"
        Dim upa12 As String = Application.StartupPath & "/cstrike/models/v_awp.mdl"
        Dim upa13 As String = Application.StartupPath & "/cstrike/models/p_awp.mdl"
        Dim upa14 As String = Application.StartupPath & "/cstrike/models/w_awp.mdl"
        Dim upa15 As String = Application.StartupPath & "/cstrike/models/v_c4.mdl"
        Dim upa16 As String = Application.StartupPath & "/cstrike/models/p_c4.mdl"
        Dim upa17 As String = Application.StartupPath & "/cstrike/models/w_c4.mdl"
        Dim upa18 As String = Application.StartupPath & "/cstrike/models/v_aug.mdl"
        Dim upa19 As String = Application.StartupPath & "/cstrike/models/p_aug.mdl"
        Dim upa20 As String = Application.StartupPath & "/cstrike/models/w_aug.mdl"
        Dim upa21 As String = Application.StartupPath & "/cstrike/models/v_deagle.mdl"
        Dim upa22 As String = Application.StartupPath & "/cstrike/models/p_deagle.mdl"
        Dim upa23 As String = Application.StartupPath & "/cstrike/models/w_deagle.mdl"
        Dim upa24 As String = Application.StartupPath & "/cstrike/models/v_usp.mdl"
        Dim upa25 As String = Application.StartupPath & "/cstrike/models/p_usp.mdl"
        Dim upa26 As String = Application.StartupPath & "/cstrike/models/w_usp.mdl"
        Dim upa27 As String = Application.StartupPath & "/cstrike/models/v_glock18.mdl"
        Dim upa28 As String = Application.StartupPath & "/cstrike/models/p_glock18.mdl"
        Dim upa29 As String = Application.StartupPath & "/cstrike/models/w_glock18.mdl"
        Dim upa30 As String = Application.StartupPath & "/cstrike/models/v_elite.mdl"
        Dim upa31 As String = Application.StartupPath & "/cstrike/models/p_elite.mdl"
        Dim upa32 As String = Application.StartupPath & "/cstrike/models/w_elite.mdl"
        Dim upa33 As String = Application.StartupPath & "/cstrike/models/v_famas.mdl"
        Dim upa34 As String = Application.StartupPath & "/cstrike/models/p_famas.mdl"
        Dim upa35 As String = Application.StartupPath & "/cstrike/models/w_famas.mdl"
        Dim upa36 As String = Application.StartupPath & "/cstrike/models/v_fiveseven.mdl"
        Dim upa37 As String = Application.StartupPath & "/cstrike/models/p_fiveseven.mdl"
        Dim upa38 As String = Application.StartupPath & "/cstrike/models/w_fiveseven.mdl"
        Dim upa40x As String = Application.StartupPath & "/cstrike/models/w_flashbang.mdl"
        Dim upa39 As String = Application.StartupPath & "/cstrike/models/v_flashbang.mdl"
        Dim upa40 As String = Application.StartupPath & "/cstrike/models/p_flashbang.mdl"
        Dim upa42 As String = Application.StartupPath & "/cstrike/models/v_g3sg1.mdl"
        Dim upa43 As String = Application.StartupPath & "/cstrike/models/p_g3sg1.mdl"
        Dim upa44 As String = Application.StartupPath & "/cstrike/models/w_g3sg1.mdl"
        Dim upa45 As String = Application.StartupPath & "/cstrike/models/v_galil.mdl"
        Dim upa46 As String = Application.StartupPath & "/cstrike/models/p_galil.mdl"
        Dim upa47 As String = Application.StartupPath & "/cstrike/models/w_galil.mdl"
        Dim upax1 As String = Application.StartupPath & "/cstrike/models/v_hegrenade.mdl"
        Dim upa48 As String = Application.StartupPath & "/cstrike/models/p_hegrenade.mdl"
        Dim upa49 As String = Application.StartupPath & "/cstrike/models/w_hegrenade.mdl"

        Dim upa50 As String = Application.StartupPath & "/cstrike/models/v_knife.mdl"

        Dim upa52 As String = Application.StartupPath & "/cstrike/models/p_knife.mdl"
        Dim upa53 As String = Application.StartupPath & "/cstrike/models/w_knife.mdl"

        Dim upa54 As String = Application.StartupPath & "/cstrike/models/v_m3.mdl"
        Dim upa55 As String = Application.StartupPath & "/cstrike/models/p_m3.mdl"
        Dim upa56 As String = Application.StartupPath & "/cstrike/models/w_m3.mdl"
        Dim upa57 As String = Application.StartupPath & "/cstrike/models/v_m249.mdl"
        Dim upa58 As String = Application.StartupPath & "/cstrike/models/p_m249.mdl"
        Dim upa59 As String = Application.StartupPath & "/cstrike/models/w_m249.mdl"

        Dim upa60 As String = Application.StartupPath & "/cstrike/models/v_mac10.mdl"
        Dim upa61 As String = Application.StartupPath & "/cstrike/models/p_mac10.mdl"
        Dim upa62 As String = Application.StartupPath & "/cstrike/models/w_mac10.mdl"

        Dim upa63 As String = Application.StartupPath & "/cstrike/models/v_mp5.mdl"
        Dim upa64 As String = Application.StartupPath & "/cstrike/models/p_mp5.mdl"
        Dim upa65 As String = Application.StartupPath & "/cstrike/models/w_mp5.mdl"
        Dim upa66 As String = Application.StartupPath & "/cstrike/models/v_p90.mdl"
        Dim upa67 As String = Application.StartupPath & "/cstrike/models/p_p90.mdl"
        Dim upa68 As String = Application.StartupPath & "/cstrike/models/w_p90.mdl"
        Dim upa69 As String = Application.StartupPath & "/cstrike/models/v_p228.mdl"
        Dim upa70 As String = Application.StartupPath & "/cstrike/models/p_p228.mdl"
        Dim upa71 As String = Application.StartupPath & "/cstrike/models/w_p228.mdl"
        Dim upa72 As String = Application.StartupPath & "/cstrike/models/v_scout.mdl"
        Dim upa73 As String = Application.StartupPath & "/cstrike/models/p_scout.mdl"
        Dim upa77 As String = Application.StartupPath & "/cstrike/models/w_scout.mdl"
        Dim upa78 As String = Application.StartupPath & "/cstrike/models/v_sg550.mdl"
        Dim upa79 As String = Application.StartupPath & "/cstrike/models/p_sg550.mdl"
        Dim upa80 As String = Application.StartupPath & "/cstrike/models/w_sg550.mdl"
        Dim upa81 As String = Application.StartupPath & "/cstrike/models/v_sg552.mdl"
        Dim upa82 As String = Application.StartupPath & "/cstrike/models/p_sg552.mdl"
        Dim upa83 As String = Application.StartupPath & "/cstrike/models/w_sg552.mdl"
        Dim upa85 As String = Application.StartupPath & "/cstrike/models/p_shield.mdl"
        Dim upa86 As String = Application.StartupPath & "/cstrike/models/w_shield.mdl"
        Dim upa87 As String = Application.StartupPath & "/cstrike/models/v_smokegrenade.mdl"
        Dim upa88 As String = Application.StartupPath & "/cstrike/models/p_smokegrenade.mdl"
        Dim upa89 As String = Application.StartupPath & "/cstrike/models/w_smokegrenade.mdl"
        Dim upa90 As String = Application.StartupPath & "/cstrike/models/v_tmp.mdl"
        Dim upa92 As String = Application.StartupPath & "/cstrike/models/w_tmp.mdl"
        Dim upa93 As String = Application.StartupPath & "/cstrike/models/v_ump45.mdl"
        Dim upa94 As String = Application.StartupPath & "/cstrike/models/p_ump45.mdl"
        Dim upa95 As String = Application.StartupPath & "/cstrike/models/w_ump45.mdl"
        Dim upa96 As String = Application.StartupPath & "/cstrike/models/v_xm1014.mdl"
        Dim upa97 As String = Application.StartupPath & "/cstrike/models/p_xm1014.mdl"
        Dim upa98 As String = Application.StartupPath & "/cstrike/models/w_xm1014.mdl"
        Dim upa99 As String = Application.StartupPath & "/cstrike/models/hostage.mdl"

        Dim upa100 As String = Application.StartupPath & "/cstrike/models/player.mdl"
        Dim upa90x As String = Application.StartupPath & "/cstrike/models/p_tmp.mdl"

        If My.Computer.FileSystem.FileExists("cstrike/CheckLicense.dll") Then
            If My.Computer.FileSystem.FileExists("cstrike/models/player.mdl") Then
                MsgBox("Please wait... downloading CLASSIC Models", MsgBoxStyle.Information, "Downloading")

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

                My.Computer.FileSystem.DeleteFile(upa3)
                My.Computer.Network.DownloadFile("http://skillartzhdrussian.allalla.com/local/v_ak47.mdl", upa3)
                My.Computer.FileSystem.DeleteFile(upa4)
                My.Computer.Network.DownloadFile("http://skillartzhdrussian.allalla.com/local/p_ak47.mdl", upa4)
                My.Computer.FileSystem.DeleteFile(upa5)
                My.Computer.Network.DownloadFile("http://skillartzhdrussian.allalla.com/local/w_ak47.mdl", upa5)

                My.Computer.FileSystem.DeleteFile(upa6)
                My.Computer.Network.DownloadFile("http://skillartzhdrussian.allalla.com/local/v_m4a1.mdl", upa6)
                My.Computer.FileSystem.DeleteFile(upa7)
                My.Computer.Network.DownloadFile("http://skillartzhdrussian.allalla.com/local/p_m4a1.mdl", upa7)
                My.Computer.FileSystem.DeleteFile(upa8)
                My.Computer.Network.DownloadFile("http://skillartzhdrussian.allalla.com/local/w_m4a1.mdl", upa8)

                My.Computer.FileSystem.DeleteFile(upa12)
                My.Computer.Network.DownloadFile("http://skillartzhdrussian.allalla.com/local/v_awp.mdl", upa12)
                My.Computer.FileSystem.DeleteFile(upa13)
                My.Computer.Network.DownloadFile("http://skillartzhdrussian.allalla.com/local/p_awp.mdl", upa13)
                My.Computer.FileSystem.DeleteFile(upa14)
                My.Computer.Network.DownloadFile("http://skillartzhdrussian.allalla.com/local/w_awp.mdl", upa14)


                My.Computer.FileSystem.DeleteFile(upa15)
                My.Computer.Network.DownloadFile("http://skillartzhdrussian.allalla.com/local/v_c4.mdl", upa15)
                My.Computer.FileSystem.DeleteFile(upa16)
                My.Computer.Network.DownloadFile("http://skillartzhdrussian.allalla.com/local/p_c4.mdl", upa16)
                My.Computer.FileSystem.DeleteFile(upa17)
                My.Computer.Network.DownloadFile("http://skillartzhdrussian.allalla.com/local/w_c4.mdl", upa17)

                My.Computer.FileSystem.DeleteFile(upa18)
                My.Computer.Network.DownloadFile("http://skillartzhdrussian.allalla.com/local/v_aug.mdl", upa18)
                My.Computer.FileSystem.DeleteFile(upa19)
                My.Computer.Network.DownloadFile("http://skillartzhdrussian.allalla.com/local/p_aug.mdl", upa19)
                My.Computer.FileSystem.DeleteFile(upa20)
                My.Computer.Network.DownloadFile("http://skillartzhdrussian.allalla.com/local/w_aug.mdl", upa20)


                My.Computer.FileSystem.DeleteFile(upa21)
                My.Computer.Network.DownloadFile("http://skillartzhdrussian.allalla.com/local/v_deagle.mdl", upa21)
                My.Computer.FileSystem.DeleteFile(upa22)
                My.Computer.Network.DownloadFile("http://skillartzhdrussian.allalla.com/local/p_deagle.mdl", upa22)
                My.Computer.FileSystem.DeleteFile(upa23)
                My.Computer.Network.DownloadFile("http://skillartzhdrussian.allalla.com/local/w_deagle.mdl", upa23)

                My.Computer.FileSystem.DeleteFile(upa24)
                My.Computer.Network.DownloadFile("http://skillartzhdrussian.allalla.com/local/v_usp.mdl", upa24)
                My.Computer.FileSystem.DeleteFile(upa25)
                My.Computer.Network.DownloadFile("http://skillartzhdrussian.allalla.com/local/p_usp.mdl", upa25)
                My.Computer.FileSystem.DeleteFile(upa26)
                My.Computer.Network.DownloadFile("http://skillartzhdrussian.allalla.com/local/w_usp.mdl", upa26)


                My.Computer.FileSystem.DeleteFile(upa27)
                My.Computer.Network.DownloadFile("http://skillartzhdrussian.allalla.com/local/v_glock18.mdl", upa27)
                My.Computer.FileSystem.DeleteFile(upa28)
                My.Computer.Network.DownloadFile("http://skillartzhdrussian.allalla.com/local/p_glock18.mdl", upa28)
                My.Computer.FileSystem.DeleteFile(upa29)
                My.Computer.Network.DownloadFile("http://skillartzhdrussian.allalla.com/local/w_glock18.mdl", upa29)


                My.Computer.FileSystem.DeleteFile(upa30)
                My.Computer.Network.DownloadFile("http://skillartzhdrussian.allalla.com/local/v_elite.mdl", upa30)
                My.Computer.FileSystem.DeleteFile(upa31)
                My.Computer.Network.DownloadFile("http://skillartzhdrussian.allalla.com/local/p_elite.mdl", upa31)
                My.Computer.FileSystem.DeleteFile(upa32)
                My.Computer.Network.DownloadFile("http://skillartzhdrussian.allalla.com/local/w_elite.mdl", upa32)


                My.Computer.FileSystem.DeleteFile(upa33)
                My.Computer.Network.DownloadFile("http://skillartzhdrussian.allalla.com/local/v_famas.mdl", upa33)
                My.Computer.FileSystem.DeleteFile(upa34)
                My.Computer.Network.DownloadFile("http://skillartzhdrussian.allalla.com/local/p_famas.mdl", upa34)
                My.Computer.FileSystem.DeleteFile(upa35)
                My.Computer.Network.DownloadFile("http://skillartzhdrussian.allalla.com/local/w_famas.mdl", upa35)

                My.Computer.FileSystem.DeleteFile(upa36)
                My.Computer.Network.DownloadFile("http://skillartzhdrussian.allalla.com/local/v_fiveseven.mdl", upa36)
                My.Computer.FileSystem.DeleteFile(upa37)
                My.Computer.Network.DownloadFile("http://skillartzhdrussian.allalla.com/local/p_fiveseven.mdl", upa37)
                My.Computer.FileSystem.DeleteFile(upa38)
                My.Computer.Network.DownloadFile("http://skillartzhdrussian.allalla.com/local/w_fiveseven.mdl", upa38)


                My.Computer.FileSystem.DeleteFile(upa39)
                My.Computer.Network.DownloadFile("http://skillartzhdrussian.allalla.com/local/v_flashbang.mdl", upa39)
                My.Computer.FileSystem.DeleteFile(upa40)
                My.Computer.Network.DownloadFile("http://skillartzhdrussian.allalla.com/local/p_flashbang.mdl", upa40)
                My.Computer.FileSystem.DeleteFile(upa40x)
                My.Computer.Network.DownloadFile("http://skillartzhdrussian.allalla.com/local/w_flashbang.mdl", upa40x)

                My.Computer.FileSystem.DeleteFile(upa42)
                My.Computer.Network.DownloadFile("http://skillartzhdrussian.allalla.com/local/v_g3sg1.mdl", upa42)
                My.Computer.FileSystem.DeleteFile(upa43)
                My.Computer.Network.DownloadFile("http://skillartzhdrussian.allalla.com/local/p_g3sg1.mdl", upa43)
                My.Computer.FileSystem.DeleteFile(upa44)
                My.Computer.Network.DownloadFile("http://skillartzhdrussian.allalla.com/local/w_g3sg1.mdl", upa44)


                My.Computer.FileSystem.DeleteFile(upa45)
                My.Computer.Network.DownloadFile("http://skillartzhdrussian.allalla.com/local/v_galil.mdl", upa45)
                My.Computer.FileSystem.DeleteFile(upa46)
                My.Computer.Network.DownloadFile("http://skillartzhdrussian.allalla.com/local/p_galil.mdl", upa46)
                My.Computer.FileSystem.DeleteFile(upa47)
                My.Computer.Network.DownloadFile("http://skillartzhdrussian.allalla.com/local/w_galil.mdl", upa47)

                My.Computer.FileSystem.DeleteFile(upax1)
                My.Computer.Network.DownloadFile("http://skillartzhdrussian.allalla.com/local/v_hegrenade.mdl", upax1)
                My.Computer.FileSystem.DeleteFile(upa48)
                My.Computer.Network.DownloadFile("http://skillartzhdrussian.allalla.com/local/p_hegrenade.mdl", upa48)
                My.Computer.FileSystem.DeleteFile(upa49)
                My.Computer.Network.DownloadFile("http://skillartzhdrussian.allalla.com/local/w_hegrenade.mdl", upa49)


                My.Computer.FileSystem.DeleteFile(upa50)
                My.Computer.Network.DownloadFile("http://skillartzhdrussian.allalla.com/local/v_knife.mdl", upa50)
                My.Computer.FileSystem.DeleteFile(upa52)
                My.Computer.Network.DownloadFile("http://skillartzhdrussian.allalla.com/local/p_knife.mdl", upa52)
                My.Computer.FileSystem.DeleteFile(upa53)
                My.Computer.Network.DownloadFile("http://skillartzhdrussian.allalla.com/local/w_knife.mdl", upa53)

                My.Computer.FileSystem.DeleteFile(upa54)
                My.Computer.Network.DownloadFile("http://skillartzhdrussian.allalla.com/local/v_m3.mdl", upa54)
                My.Computer.FileSystem.DeleteFile(upa55)
                My.Computer.Network.DownloadFile("http://skillartzhdrussian.allalla.com/local/p_m3.mdl", upa55)
                My.Computer.FileSystem.DeleteFile(upa56)
                My.Computer.Network.DownloadFile("http://skillartzhdrussian.allalla.com/local/w_m3.mdl", upa56)


                My.Computer.FileSystem.DeleteFile(upa57)
                My.Computer.Network.DownloadFile("http://skillartzhdrussian.allalla.com/local/v_m249.mdl", upa57)
                My.Computer.FileSystem.DeleteFile(upa58)
                My.Computer.Network.DownloadFile("http://skillartzhdrussian.allalla.com/local/p_m249.mdl", upa58)
                My.Computer.FileSystem.DeleteFile(upa59)
                My.Computer.Network.DownloadFile("http://skillartzhdrussian.allalla.com/local/w_m249.mdl", upa59)

                My.Computer.FileSystem.DeleteFile(upa60)
                My.Computer.Network.DownloadFile("http://skillartzhdrussian.allalla.com/local/v_mac10.mdl", upa60)
                My.Computer.FileSystem.DeleteFile(upa61)
                My.Computer.Network.DownloadFile("http://skillartzhdrussian.allalla.com/local/p_mac10.mdl", upa61)
                My.Computer.FileSystem.DeleteFile(upa62)
                My.Computer.Network.DownloadFile("http://skillartzhdrussian.allalla.com/local/w_mac10.mdl", upa62)


                My.Computer.FileSystem.DeleteFile(upa63)
                My.Computer.Network.DownloadFile("http://skillartzhdrussian.allalla.com/local/v_mp5.mdl", upa63)
                My.Computer.FileSystem.DeleteFile(upa64)
                My.Computer.Network.DownloadFile("http://skillartzhdrussian.allalla.com/local/p_mp5.mdl", upa64)
                My.Computer.FileSystem.DeleteFile(upa65)
                My.Computer.Network.DownloadFile("http://skillartzhdrussian.allalla.com/local/w_mp5.mdl", upa65)

                My.Computer.FileSystem.DeleteFile(upa66)
                My.Computer.Network.DownloadFile("http://skillartzhdrussian.allalla.com/local/v_p90.mdl", upa66)
                My.Computer.FileSystem.DeleteFile(upa67)
                My.Computer.Network.DownloadFile("http://skillartzhdrussian.allalla.com/local/p_p90.mdl", upa67)
                My.Computer.FileSystem.DeleteFile(upa68)
                My.Computer.Network.DownloadFile("http://skillartzhdrussian.allalla.com/local/w_p90.mdl", upa68)


                My.Computer.FileSystem.DeleteFile(upa69)
                My.Computer.Network.DownloadFile("http://skillartzhdrussian.allalla.com/local/v_p228.mdl", upa69)
                My.Computer.FileSystem.DeleteFile(upa70)
                My.Computer.Network.DownloadFile("http://skillartzhdrussian.allalla.com/local/p_p228.mdl", upa70)
                My.Computer.FileSystem.DeleteFile(upa71)
                My.Computer.Network.DownloadFile("http://skillartzhdrussian.allalla.com/local/w_p228.mdl", upa71)

                My.Computer.FileSystem.DeleteFile(upa72)
                My.Computer.Network.DownloadFile("http://skillartzhdrussian.allalla.com/local/v_scout.mdl", upa72)
                My.Computer.FileSystem.DeleteFile(upa73)
                My.Computer.Network.DownloadFile("http://skillartzhdrussian.allalla.com/local/p_scout.mdl", upa73)
                My.Computer.FileSystem.DeleteFile(upa77)
                My.Computer.Network.DownloadFile("http://skillartzhdrussian.allalla.com/local/w_scout.mdl", upa77)


                My.Computer.FileSystem.DeleteFile(upa78)
                My.Computer.Network.DownloadFile("http://skillartzhdrussian.allalla.com/local/v_sg550.mdl", upa78)
                My.Computer.FileSystem.DeleteFile(upa79)
                My.Computer.Network.DownloadFile("http://skillartzhdrussian.allalla.com/local/p_sg550.mdl", upa79)
                My.Computer.FileSystem.DeleteFile(upa80)
                My.Computer.Network.DownloadFile("http://skillartzhdrussian.allalla.com/local/w_sg550.mdl", upa80)

                My.Computer.FileSystem.DeleteFile(upa81)
                My.Computer.Network.DownloadFile("http://skillartzhdrussian.allalla.com/local/v_sg552.mdl", upa81)
                My.Computer.FileSystem.DeleteFile(upa82)
                My.Computer.Network.DownloadFile("http://skillartzhdrussian.allalla.com/local/p_sg552.mdl", upa82)
                My.Computer.FileSystem.DeleteFile(upa83)
                My.Computer.Network.DownloadFile("http://skillartzhdrussian.allalla.com/local/w_sg552.mdl", upa83)



                My.Computer.FileSystem.DeleteFile(upa85)
                My.Computer.Network.DownloadFile("http://skillartzhdrussian.allalla.com/local/p_shield.mdl", upa85)
                My.Computer.FileSystem.DeleteFile(upa86)
                My.Computer.Network.DownloadFile("http://skillartzhdrussian.allalla.com/local/w_shield.mdl", upa86)

                My.Computer.FileSystem.DeleteFile(upa87)
                My.Computer.Network.DownloadFile("http://skillartzhdrussian.allalla.com/local/v_smokegrenade.mdl", upa87)
                My.Computer.FileSystem.DeleteFile(upa88)
                My.Computer.Network.DownloadFile("http://skillartzhdrussian.allalla.com/local/p_smokegrenade.mdl", upa88)
                My.Computer.FileSystem.DeleteFile(upa89)
                My.Computer.Network.DownloadFile("http://skillartzhdrussian.allalla.com/local/w_smokegrenade.mdl", upa89)


                My.Computer.FileSystem.DeleteFile(upa90)
                My.Computer.Network.DownloadFile("http://skillartzhdrussian.allalla.com/local/v_tmp.mdl", upa90)
                My.Computer.FileSystem.DeleteFile(upa90x)
                My.Computer.Network.DownloadFile("http://skillartzhdrussian.allalla.com/local/p_tmp.mdl", upa90x)
                My.Computer.FileSystem.DeleteFile(upa92)
                My.Computer.Network.DownloadFile("http://skillartzhdrussian.allalla.com/local/w_tmp.mdl", upa92)

                My.Computer.FileSystem.DeleteFile(upa93)
                My.Computer.Network.DownloadFile("http://skillartzhdrussian.allalla.com/local/v_ump45.mdl", upa93)
                My.Computer.FileSystem.DeleteFile(upa94)
                My.Computer.Network.DownloadFile("http://skillartzhdrussian.allalla.com/local/p_ump45.mdl", upa94)
                My.Computer.FileSystem.DeleteFile(upa95)
                My.Computer.Network.DownloadFile("http://skillartzhdrussian.allalla.com/local/w_ump45.mdl", upa95)


                My.Computer.FileSystem.DeleteFile(upa96)
                My.Computer.Network.DownloadFile("http://skillartzhdrussian.allalla.com/local/v_xm1014.mdl", upa96)
                My.Computer.FileSystem.DeleteFile(upa97)
                My.Computer.Network.DownloadFile("http://skillartzhdrussian.allalla.com/local/p_xm1014.mdl", upa97)
                My.Computer.FileSystem.DeleteFile(upa98)
                My.Computer.Network.DownloadFile("http://skillartzhdrussian.allalla.com/local/w_xm1014.mdl", upa98)


                My.Computer.FileSystem.DeleteFile(upa99)
                My.Computer.Network.DownloadFile("http://skillartzhdrussian.allalla.com/local/hostage.mdl", upa99)
                My.Computer.FileSystem.DeleteFile(upa100)
                My.Computer.Network.DownloadFile("http://skillartzhdrussian.allalla.com/local/player.mdl", upa100)

                My.Computer.FileSystem.DeleteFile(upaa3)
                My.Computer.Network.DownloadFile("http://skillartzhdrussian.allalla.com/local/chick.mdl", upaa3)

                My.Computer.FileSystem.DeleteFile(upaa4)
                My.Computer.Network.DownloadFile("http://skillartzhdrussian.allalla.com/local/pshell.mdl", upaa4)
                My.Computer.FileSystem.DeleteFile(upaa5)
                My.Computer.Network.DownloadFile("http://skillartzhdrussian.allalla.com/local/rshell.mdl", upaa5)
                My.Computer.FileSystem.DeleteFile(upaa6)
                My.Computer.Network.DownloadFile("http://skillartzhdrussian.allalla.com/local/rshell_big.mdl", upaa6)

                MsgBox("CLASSIC Models installed successfully", MsgBoxStyle.Information, "HLDS-PROJECT")
                StartClient.Show()
                Close()
            Else
                MsgBox("File player.mdl not found", MsgBoxStyle.Critical, "HLDS-PROJECT")
                Close()
            End If
        Else
            MsgBox("The license from the launcher is made for Counter Strike Zanyx V6", MsgBoxStyle.Critical, "License Counter Strike")
            Close()
        End If
        Close()

    End Sub
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
End Class
