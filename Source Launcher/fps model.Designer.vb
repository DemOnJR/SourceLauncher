<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ButtonFPSModels
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
        Me.GROPBOXFPSMODELS = New Launcher.NSGroupBox()
        Me.BUTTONNO = New Launcher.NSButton()
        Me.BUTONYES = New Launcher.NSButton()
        Me.BUTTONIESIRE = New Launcher.NSControlButton()
        Me.BARAWINDOWS = New Launcher.NSLabel()
        Me.GROPBOXFPSMODELS.SuspendLayout()
        Me.SuspendLayout()
        '
        'GROPBOXFPSMODELS
        '
        Me.GROPBOXFPSMODELS.Controls.Add(Me.BUTTONNO)
        Me.GROPBOXFPSMODELS.Controls.Add(Me.BUTONYES)
        Me.GROPBOXFPSMODELS.DrawSeperator = False
        Me.GROPBOXFPSMODELS.Location = New System.Drawing.Point(4, 25)
        Me.GROPBOXFPSMODELS.Name = "GROPBOXFPSMODELS"
        Me.GROPBOXFPSMODELS.Size = New System.Drawing.Size(275, 59)
        Me.GROPBOXFPSMODELS.SubTitle = "Are you sure you want to install FPS Models in your client?"
        Me.GROPBOXFPSMODELS.TabIndex = 8
        Me.GROPBOXFPSMODELS.Text = "NsGroupBox1"
        Me.GROPBOXFPSMODELS.Title = ""
        '
        'BUTTONNO
        '
        Me.BUTTONNO.Location = New System.Drawing.Point(156, 24)
        Me.BUTTONNO.Name = "BUTTONNO"
        Me.BUTTONNO.Size = New System.Drawing.Size(86, 31)
        Me.BUTTONNO.TabIndex = 2
        Me.BUTTONNO.Text = "          No"
        '
        'BUTONYES
        '
        Me.BUTONYES.Location = New System.Drawing.Point(28, 24)
        Me.BUTONYES.Name = "BUTONYES"
        Me.BUTONYES.Size = New System.Drawing.Size(86, 31)
        Me.BUTONYES.TabIndex = 1
        Me.BUTONYES.Text = "        Yes"
        '
        'BUTTONIESIRE
        '
        Me.BUTTONIESIRE.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BUTTONIESIRE.BackColor = System.Drawing.Color.DarkGray
        Me.BUTTONIESIRE.ControlButton = Launcher.NSControlButton.Button.Close
        Me.BUTTONIESIRE.Location = New System.Drawing.Point(265, 1)
        Me.BUTTONIESIRE.Margin = New System.Windows.Forms.Padding(0)
        Me.BUTTONIESIRE.MaximumSize = New System.Drawing.Size(18, 20)
        Me.BUTTONIESIRE.MinimumSize = New System.Drawing.Size(18, 20)
        Me.BUTTONIESIRE.Name = "BUTTONIESIRE"
        Me.BUTTONIESIRE.Size = New System.Drawing.Size(18, 20)
        Me.BUTTONIESIRE.TabIndex = 7
        Me.BUTTONIESIRE.Text = "NsControlButton1"
        '
        'BARAWINDOWS
        '
        Me.BARAWINDOWS.BackColor = System.Drawing.Color.DarkGray
        Me.BARAWINDOWS.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.BARAWINDOWS.Location = New System.Drawing.Point(-2, -2)
        Me.BARAWINDOWS.Name = "BARAWINDOWS"
        Me.BARAWINDOWS.Size = New System.Drawing.Size(404, 23)
        Me.BARAWINDOWS.TabIndex = 6
        Me.BARAWINDOWS.Text = "NsLabel1"
        Me.BARAWINDOWS.Value1 = " Zanyx 6"
        Me.BARAWINDOWS.Value2 = "  FPS Models"
        '
        'ButtonFPSModels
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(287, 89)
        Me.Controls.Add(Me.GROPBOXFPSMODELS)
        Me.Controls.Add(Me.BUTTONIESIRE)
        Me.Controls.Add(Me.BARAWINDOWS)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ButtonFPSModels"
        Me.Padding = New System.Windows.Forms.Padding(9)
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ButtonFPSModels"
        Me.GROPBOXFPSMODELS.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GROPBOXFPSMODELS As Launcher.NSGroupBox
    Friend WithEvents BUTTONNO As Launcher.NSButton
    Friend WithEvents BUTONYES As Launcher.NSButton
    Friend WithEvents BUTTONIESIRE As Launcher.NSControlButton
    Friend WithEvents BARAWINDOWS As Launcher.NSLabel

End Class
