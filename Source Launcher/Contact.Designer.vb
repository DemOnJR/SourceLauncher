<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Contact
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Contact))
        Me.ButtonIesire = New Launcher.NSControlButton()
        Me.BaraWindow = New Launcher.NSLabel()
        Me.DalaDeAboutBox = New Launcher.NSGroupBox()
        Me.ListeazaAdreselenoastre = New System.Windows.Forms.ListBox()
        Me.Listeazaposibitatidegasire = New System.Windows.Forms.ListBox()
        Me.DalaDeAboutBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonIesire
        '
        Me.ButtonIesire.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonIesire.BackColor = System.Drawing.Color.DarkGray
        Me.ButtonIesire.ControlButton = Launcher.NSControlButton.Button.Close
        Me.ButtonIesire.Location = New System.Drawing.Point(318, 0)
        Me.ButtonIesire.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonIesire.MaximumSize = New System.Drawing.Size(18, 20)
        Me.ButtonIesire.MinimumSize = New System.Drawing.Size(18, 20)
        Me.ButtonIesire.Name = "ButtonIesire"
        Me.ButtonIesire.Size = New System.Drawing.Size(18, 20)
        Me.ButtonIesire.TabIndex = 29
        Me.ButtonIesire.Text = "NsControlButton1"
        '
        'BaraWindow
        '
        Me.BaraWindow.BackColor = System.Drawing.Color.DarkGray
        Me.BaraWindow.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.BaraWindow.Location = New System.Drawing.Point(0, 0)
        Me.BaraWindow.Name = "BaraWindow"
        Me.BaraWindow.Size = New System.Drawing.Size(444, 20)
        Me.BaraWindow.TabIndex = 28
        Me.BaraWindow.Tag = ""
        Me.BaraWindow.Text = "Options"
        Me.BaraWindow.Value1 = " "
        Me.BaraWindow.Value2 = "Contact Author"
        '
        'DalaDeAboutBox
        '
        Me.DalaDeAboutBox.Controls.Add(Me.ListeazaAdreselenoastre)
        Me.DalaDeAboutBox.Controls.Add(Me.Listeazaposibitatidegasire)
        Me.DalaDeAboutBox.DrawSeperator = False
        Me.DalaDeAboutBox.Location = New System.Drawing.Point(3, 23)
        Me.DalaDeAboutBox.Name = "DalaDeAboutBox"
        Me.DalaDeAboutBox.Size = New System.Drawing.Size(331, 185)
        Me.DalaDeAboutBox.SubTitle = "Contact:"
        Me.DalaDeAboutBox.TabIndex = 31
        Me.DalaDeAboutBox.Text = "NsGroupBox1"
        Me.DalaDeAboutBox.Title = ""
        '
        'ListeazaAdreselenoastre
        '
        Me.ListeazaAdreselenoastre.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ListeazaAdreselenoastre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListeazaAdreselenoastre.ForeColor = System.Drawing.Color.GreenYellow
        Me.ListeazaAdreselenoastre.FormattingEnabled = True
        Me.ListeazaAdreselenoastre.Items.AddRange(New Object() {"[ ====================]", "", "arwared.cone@yahoo.com", "spyware.spyware1", "76561198060162740", "", "[ ====================]", "", "danutu_ionascu@yahoo.com", "rdklbq.daniel", "76561198072332517"})
        Me.ListeazaAdreselenoastre.Location = New System.Drawing.Point(129, 18)
        Me.ListeazaAdreselenoastre.Name = "ListeazaAdreselenoastre"
        Me.ListeazaAdreselenoastre.Size = New System.Drawing.Size(195, 160)
        Me.ListeazaAdreselenoastre.TabIndex = 32
        '
        'Listeazaposibitatidegasire
        '
        Me.Listeazaposibitatidegasire.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Listeazaposibitatidegasire.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Listeazaposibitatidegasire.ForeColor = System.Drawing.Color.GreenYellow
        Me.Listeazaposibitatidegasire.FormattingEnabled = True
        Me.Listeazaposibitatidegasire.Items.AddRange(New Object() {"[=== SkillartzHD ===]", "", "Email Address:", "Skype Address:", "Steam Address:", "", "[=== MaRky ===]", "", "Email Address:", "Skype Address:", "Steam Address:"})
        Me.Listeazaposibitatidegasire.Location = New System.Drawing.Point(3, 18)
        Me.Listeazaposibitatidegasire.Name = "Listeazaposibitatidegasire"
        Me.Listeazaposibitatidegasire.Size = New System.Drawing.Size(131, 160)
        Me.Listeazaposibitatidegasire.TabIndex = 31
        '
        'Contact
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(339, 215)
        Me.Controls.Add(Me.DalaDeAboutBox)
        Me.Controls.Add(Me.ButtonIesire)
        Me.Controls.Add(Me.BaraWindow)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Contact"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Contact pe pula mea"
        Me.DalaDeAboutBox.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ButtonIesire As Launcher.NSControlButton
    Friend WithEvents BaraWindow As Launcher.NSLabel
    Friend WithEvents DalaDeAboutBox As Launcher.NSGroupBox
    Friend WithEvents ListeazaAdreselenoastre As System.Windows.Forms.ListBox
    Friend WithEvents Listeazaposibitatidegasire As System.Windows.Forms.ListBox
End Class
