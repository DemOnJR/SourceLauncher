<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ButtonReportBug
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GropBouxReportabug = New Launcher.NSGroupBox()
        Me.NsButton1 = New Launcher.NSButton()
        Me.NamePlayer = New System.Windows.Forms.TextBox()
        Me.TrimiteMesajButton = New System.Windows.Forms.TextBox()
        Me.Message2 = New Launcher.NSLabel()
        Me.ButtonSEND = New Launcher.NSButton()
        Me.Name2 = New Launcher.NSLabel()
        Me.ButtonIesire = New Launcher.NSControlButton()
        Me.BaraWindow = New Launcher.NSLabel()
        Me.GropBouxReportabug.SuspendLayout()
        Me.SuspendLayout()
        '
        'GropBouxReportabug
        '
        Me.GropBouxReportabug.Controls.Add(Me.NsButton1)
        Me.GropBouxReportabug.Controls.Add(Me.NamePlayer)
        Me.GropBouxReportabug.Controls.Add(Me.TrimiteMesajButton)
        Me.GropBouxReportabug.Controls.Add(Me.Message2)
        Me.GropBouxReportabug.Controls.Add(Me.ButtonSEND)
        Me.GropBouxReportabug.Controls.Add(Me.Name2)
        Me.GropBouxReportabug.DrawSeperator = False
        Me.GropBouxReportabug.Location = New System.Drawing.Point(2, 23)
        Me.GropBouxReportabug.Name = "GropBouxReportabug"
        Me.GropBouxReportabug.Size = New System.Drawing.Size(306, 210)
        Me.GropBouxReportabug.SubTitle = ""
        Me.GropBouxReportabug.TabIndex = 28
        Me.GropBouxReportabug.Text = "Report a Bug"
        Me.GropBouxReportabug.Title = "Report a Bug"
        '
        'NsButton1
        '
        Me.NsButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NsButton1.Location = New System.Drawing.Point(242, 132)
        Me.NsButton1.Name = "NsButton1"
        Me.NsButton1.Size = New System.Drawing.Size(56, 26)
        Me.NsButton1.TabIndex = 8
        Me.NsButton1.Text = "Contact"
        '
        'NamePlayer
        '
        Me.NamePlayer.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.NamePlayer.ForeColor = System.Drawing.Color.White
        Me.NamePlayer.Location = New System.Drawing.Point(60, 30)
        Me.NamePlayer.Name = "NamePlayer"
        Me.NamePlayer.Size = New System.Drawing.Size(100, 20)
        Me.NamePlayer.TabIndex = 7
        Me.NamePlayer.Text = "ZX-Player"
        '
        'TrimiteMesajButton
        '
        Me.TrimiteMesajButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.TrimiteMesajButton.ForeColor = System.Drawing.Color.White
        Me.TrimiteMesajButton.Location = New System.Drawing.Point(11, 84)
        Me.TrimiteMesajButton.Multiline = True
        Me.TrimiteMesajButton.Name = "TrimiteMesajButton"
        Me.TrimiteMesajButton.Size = New System.Drawing.Size(223, 119)
        Me.TrimiteMesajButton.TabIndex = 6
        '
        'Message2
        '
        Me.Message2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Message2.Location = New System.Drawing.Point(10, 54)
        Me.Message2.Name = "Message2"
        Me.Message2.Size = New System.Drawing.Size(75, 23)
        Me.Message2.TabIndex = 5
        Me.Message2.Text = "Message"
        Me.Message2.Value1 = "Message"
        Me.Message2.Value2 = ""
        '
        'ButtonSEND
        '
        Me.ButtonSEND.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSEND.Location = New System.Drawing.Point(240, 163)
        Me.ButtonSEND.Name = "ButtonSEND"
        Me.ButtonSEND.Size = New System.Drawing.Size(59, 40)
        Me.ButtonSEND.TabIndex = 0
        Me.ButtonSEND.Text = "  Send"
        '
        'Name2
        '
        Me.Name2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Name2.Location = New System.Drawing.Point(9, 27)
        Me.Name2.Name = "Name2"
        Me.Name2.Size = New System.Drawing.Size(75, 23)
        Me.Name2.TabIndex = 2
        Me.Name2.Text = "NsLabel1"
        Me.Name2.Value1 = "Name:"
        Me.Name2.Value2 = ""
        '
        'ButtonIesire
        '
        Me.ButtonIesire.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonIesire.BackColor = System.Drawing.Color.DarkGray
        Me.ButtonIesire.ControlButton = Launcher.NSControlButton.Button.Close
        Me.ButtonIesire.Location = New System.Drawing.Point(292, 0)
        Me.ButtonIesire.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonIesire.MaximumSize = New System.Drawing.Size(18, 20)
        Me.ButtonIesire.MinimumSize = New System.Drawing.Size(18, 20)
        Me.ButtonIesire.Name = "ButtonIesire"
        Me.ButtonIesire.Size = New System.Drawing.Size(18, 20)
        Me.ButtonIesire.TabIndex = 27
        Me.ButtonIesire.Text = "NsControlButton1"
        '
        'BaraWindow
        '
        Me.BaraWindow.BackColor = System.Drawing.Color.DarkGray
        Me.BaraWindow.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.BaraWindow.Location = New System.Drawing.Point(-1, 0)
        Me.BaraWindow.Name = "BaraWindow"
        Me.BaraWindow.Size = New System.Drawing.Size(331, 20)
        Me.BaraWindow.TabIndex = 20
        Me.BaraWindow.Tag = ""
        Me.BaraWindow.Text = "Options"
        Me.BaraWindow.Value1 = " "
        Me.BaraWindow.Value2 = "Report a bug"
        '
        'ButtonReportBug
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(313, 238)
        Me.Controls.Add(Me.GropBouxReportabug)
        Me.Controls.Add(Me.ButtonIesire)
        Me.Controls.Add(Me.BaraWindow)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ButtonReportBug"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form3"
        Me.GropBouxReportabug.ResumeLayout(False)
        Me.GropBouxReportabug.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BaraWindow As Launcher.NSLabel
    Friend WithEvents ButtonIesire As Launcher.NSControlButton
    Friend WithEvents GropBouxReportabug As Launcher.NSGroupBox
    Friend WithEvents ButtonSEND As Launcher.NSButton
    Friend WithEvents Name2 As Launcher.NSLabel
    Friend WithEvents Message2 As Launcher.NSLabel
    Friend WithEvents NamePlayer As System.Windows.Forms.TextBox
    Friend WithEvents TrimiteMesajButton As System.Windows.Forms.TextBox
    Friend WithEvents NsButton1 As Launcher.NSButton
End Class
