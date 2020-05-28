<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ButtonHDModels
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
        Me.GROPBOXHDMODELS = New Launcher.NSGroupBox()
        Me.BUTTONO = New Launcher.NSButton()
        Me.BUTTONYES = New Launcher.NSButton()
        Me.BUTTONDEIESIRE = New Launcher.NSControlButton()
        Me.BARAWINDOW = New Launcher.NSLabel()
        Me.GROPBOXHDMODELS.SuspendLayout()
        Me.SuspendLayout()
        '
        'GROPBOXHDMODELS
        '
        Me.GROPBOXHDMODELS.Controls.Add(Me.BUTTONO)
        Me.GROPBOXHDMODELS.Controls.Add(Me.BUTTONYES)
        Me.GROPBOXHDMODELS.DrawSeperator = False
        Me.GROPBOXHDMODELS.Location = New System.Drawing.Point(7, 27)
        Me.GROPBOXHDMODELS.Name = "GROPBOXHDMODELS"
        Me.GROPBOXHDMODELS.Size = New System.Drawing.Size(275, 59)
        Me.GROPBOXHDMODELS.SubTitle = "Are you sure you want to install HD Models in your client?"
        Me.GROPBOXHDMODELS.TabIndex = 5
        Me.GROPBOXHDMODELS.Text = "NsGroupBox1"
        Me.GROPBOXHDMODELS.Title = ""
        '
        'BUTTONO
        '
        Me.BUTTONO.Location = New System.Drawing.Point(149, 24)
        Me.BUTTONO.Name = "BUTTONO"
        Me.BUTTONO.Size = New System.Drawing.Size(89, 31)
        Me.BUTTONO.TabIndex = 2
        Me.BUTTONO.Text = "          No"
        '
        'BUTTONYES
        '
        Me.BUTTONYES.Location = New System.Drawing.Point(28, 24)
        Me.BUTTONYES.Name = "BUTTONYES"
        Me.BUTTONYES.Size = New System.Drawing.Size(89, 31)
        Me.BUTTONYES.TabIndex = 1
        Me.BUTTONYES.Text = "        Yes"
        '
        'BUTTONDEIESIRE
        '
        Me.BUTTONDEIESIRE.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BUTTONDEIESIRE.BackColor = System.Drawing.Color.DarkGray
        Me.BUTTONDEIESIRE.ControlButton = Launcher.NSControlButton.Button.Close
        Me.BUTTONDEIESIRE.Location = New System.Drawing.Point(268, 2)
        Me.BUTTONDEIESIRE.Margin = New System.Windows.Forms.Padding(0)
        Me.BUTTONDEIESIRE.MaximumSize = New System.Drawing.Size(18, 20)
        Me.BUTTONDEIESIRE.MinimumSize = New System.Drawing.Size(18, 20)
        Me.BUTTONDEIESIRE.Name = "BUTTONDEIESIRE"
        Me.BUTTONDEIESIRE.Size = New System.Drawing.Size(18, 20)
        Me.BUTTONDEIESIRE.TabIndex = 4
        Me.BUTTONDEIESIRE.Text = "NsControlButton1"
        '
        'BARAWINDOW
        '
        Me.BARAWINDOW.BackColor = System.Drawing.Color.DarkGray
        Me.BARAWINDOW.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.BARAWINDOW.Location = New System.Drawing.Point(1, 0)
        Me.BARAWINDOW.Name = "BARAWINDOW"
        Me.BARAWINDOW.Size = New System.Drawing.Size(404, 23)
        Me.BARAWINDOW.TabIndex = 3
        Me.BARAWINDOW.Text = "NsLabel1"
        Me.BARAWINDOW.Value1 = " Zanyx 6"
        Me.BARAWINDOW.Value2 = "  HD Models"
        '
        'ButtonHDModels
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(289, 92)
        Me.Controls.Add(Me.GROPBOXHDMODELS)
        Me.Controls.Add(Me.BUTTONDEIESIRE)
        Me.Controls.Add(Me.BARAWINDOW)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ButtonHDModels"
        Me.Padding = New System.Windows.Forms.Padding(9)
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ButtonHDModels"
        Me.GROPBOXHDMODELS.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BUTTONYES As Launcher.NSButton
    Friend WithEvents BARAWINDOW As Launcher.NSLabel
    Friend WithEvents BUTTONDEIESIRE As Launcher.NSControlButton
    Friend WithEvents GROPBOXHDMODELS As Launcher.NSGroupBox
    Friend WithEvents BUTTONO As Launcher.NSButton

End Class
