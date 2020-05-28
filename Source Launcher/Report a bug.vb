Imports System.Net.Mail
Imports System.IO
Public Class ButtonReportBug
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

    Private Sub Panel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub NsButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSEND.Click
        If My.Computer.FileSystem.FileExists("cstrike/CheckLicense.dll") Then
            Dim MyMailMessage As New MailMessage()
            Try
                MyMailMessage.From = New MailAddress("zanyxcs@gmail.com")
                MyMailMessage.To.Add("zanyxcs@gmail.com")
                MyMailMessage.Subject = NamePlayer.Text
                MyMailMessage.Body = TrimiteMesajButton.Text
                Dim SMTP As New SmtpClient("smtp.gmail.com")
                SMTP.Port = 587
                SMTP.EnableSsl = True
                SMTP.Credentials = New System.Net.NetworkCredential("zanyxcs@gmail.com", "****************")
                SMTP.Send(MyMailMessage)
                MsgBox("Sending Successfully", MsgBoxStyle.Information, "Report a bug")
                Close()
            Catch ex As Exception
            End Try
            Close()
        Else
            MsgBox("The license from the launcher is made for Counter Strike Zanyx V6", MsgBoxStyle.Critical, "License Counter Strike")
            Close()
        End If
    End Sub

    Private Sub NsGroupBox1_Click(sender As Object, e As EventArgs) Handles GropBouxReportabug.Click

    End Sub

    Private Sub BaraWindow_Click(sender As Object, e As EventArgs) Handles BaraWindow.Click

    End Sub

    Private Sub ButtonIesire_Click(sender As Object, e As EventArgs) Handles ButtonIesire.Click

    End Sub

    Private Sub NsButton1_Click_1(sender As Object, e As EventArgs) Handles NsButton1.Click
        Contact.Show()
        Close()
    End Sub
End Class