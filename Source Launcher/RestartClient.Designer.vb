<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StartClient
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StartClient))
        Me.BaraWindow = New Launcher.NSLabel()
        Me.ButtonIesire = New Launcher.NSControlButton()
        Me.NsGroupBox1 = New Launcher.NSGroupBox()
        Me.NsButton2 = New Launcher.NSButton()
        Me.NsButton1 = New Launcher.NSButton()
        Me.NsGroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BaraWindow
        '
        Me.BaraWindow.BackColor = System.Drawing.Color.DarkGray
        Me.BaraWindow.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.BaraWindow.Location = New System.Drawing.Point(0, 1)
        Me.BaraWindow.Name = "BaraWindow"
        Me.BaraWindow.Size = New System.Drawing.Size(331, 20)
        Me.BaraWindow.TabIndex = 21
        Me.BaraWindow.Tag = ""
        Me.BaraWindow.Text = "Options"
        Me.BaraWindow.Value1 = " "
        Me.BaraWindow.Value2 = "Restart Client"
        '
        'ButtonIesire
        '
        Me.ButtonIesire.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonIesire.BackColor = System.Drawing.Color.DarkGray
        Me.ButtonIesire.ControlButton = Launcher.NSControlButton.Button.Close
        Me.ButtonIesire.Location = New System.Drawing.Point(165, 1)
        Me.ButtonIesire.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonIesire.MaximumSize = New System.Drawing.Size(18, 20)
        Me.ButtonIesire.MinimumSize = New System.Drawing.Size(18, 20)
        Me.ButtonIesire.Name = "ButtonIesire"
        Me.ButtonIesire.Size = New System.Drawing.Size(18, 20)
        Me.ButtonIesire.TabIndex = 28
        Me.ButtonIesire.Text = "NsControlButton1"
        '
        'NsGroupBox1
        '
        Me.NsGroupBox1.Controls.Add(Me.NsButton2)
        Me.NsGroupBox1.Controls.Add(Me.NsButton1)
        Me.NsGroupBox1.DrawSeperator = False
        Me.NsGroupBox1.Location = New System.Drawing.Point(5, 27)
        Me.NsGroupBox1.Name = "NsGroupBox1"
        Me.NsGroupBox1.Size = New System.Drawing.Size(174, 71)
        Me.NsGroupBox1.SubTitle = "Do you want to restart the client ?"
        Me.NsGroupBox1.TabIndex = 29
        Me.NsGroupBox1.Text = "NsGroupBox1"
        Me.NsGroupBox1.Title = ""
        '
        'NsButton2
        '
        Me.NsButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Me.NsButton2.Location = New System.Drawing.Point(87, 20)
        Me.NsButton2.Name = "NsButton2"
        Me.NsButton2.Size = New System.Drawing.Size(74, 42)
        Me.NsButton2.TabIndex = 1
        Me.NsButton2.Text = "  NO"
        '
        'NsButton1
        '
        Me.NsButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NsButton1.Location = New System.Drawing.Point(7, 20)
        Me.NsButton1.Name = "NsButton1"
        Me.NsButton1.Size = New System.Drawing.Size(74, 42)
        Me.NsButton1.TabIndex = 0
        Me.NsButton1.Text = " YES"
        '
        'StartClient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(185, 104)
        Me.Controls.Add(Me.NsGroupBox1)
        Me.Controls.Add(Me.ButtonIesire)
        Me.Controls.Add(Me.BaraWindow)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "StartClient"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.NsGroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BaraWindow As Launcher.NSLabel
    Friend WithEvents ButtonIesire As Launcher.NSControlButton
    Friend WithEvents NsGroupBox1 As Launcher.NSGroupBox
    Friend WithEvents NsButton2 As Launcher.NSButton
    Friend WithEvents NsButton1 As Launcher.NSButton
End Class
