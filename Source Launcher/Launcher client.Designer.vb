<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LauncherStart
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LauncherStart))
        Me.Minimare = New Launcher.NSControlButton()
        Me.TableZanyx = New Launcher.NSGroupBox()
        Me.VisitForumALPHCS = New Launcher.NSButton()
        Me.OptionsMenu = New Launcher.NSButton()
        Me.Updater = New Launcher.NSButton()
        Me.PlayZanyx = New Launcher.NSButton()
        Me.Iesire = New Launcher.NSControlButton()
        Me.TableCSaWB = New Launcher.NSGroupBox()
        Me.wpn = New System.Windows.Forms.Label()
        Me.GuardChecker = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LauncherScreen = New System.Windows.Forms.PictureBox()
        Me.LauncherNew = New System.Windows.Forms.WebBrowser()
        Me.BaraWindow = New Launcher.NSLabel()
        Me.TableZanyx.SuspendLayout()
        Me.TableCSaWB.SuspendLayout()
        CType(Me.LauncherScreen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Minimare
        '
        Me.Minimare.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Minimare.BackColor = System.Drawing.Color.DarkGray
        Me.Minimare.ControlButton = Launcher.NSControlButton.Button.Minimize
        Me.Minimare.Location = New System.Drawing.Point(519, 1)
        Me.Minimare.Margin = New System.Windows.Forms.Padding(0)
        Me.Minimare.MaximumSize = New System.Drawing.Size(18, 20)
        Me.Minimare.MinimumSize = New System.Drawing.Size(18, 20)
        Me.Minimare.Name = "Minimare"
        Me.Minimare.Size = New System.Drawing.Size(18, 20)
        Me.Minimare.TabIndex = 25
        Me.Minimare.Text = "NsControlButton2"
        '
        'TableZanyx
        '
        Me.TableZanyx.Controls.Add(Me.VisitForumALPHCS)
        Me.TableZanyx.Controls.Add(Me.OptionsMenu)
        Me.TableZanyx.Controls.Add(Me.Updater)
        Me.TableZanyx.Controls.Add(Me.PlayZanyx)
        Me.TableZanyx.DrawSeperator = False
        Me.TableZanyx.Location = New System.Drawing.Point(5, 385)
        Me.TableZanyx.Name = "TableZanyx"
        Me.TableZanyx.Size = New System.Drawing.Size(549, 51)
        Me.TableZanyx.SubTitle = ""
        Me.TableZanyx.TabIndex = 22
        Me.TableZanyx.Title = ""
        '
        'VisitForumALPHCS
        '
        Me.VisitForumALPHCS.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VisitForumALPHCS.Location = New System.Drawing.Point(266, 6)
        Me.VisitForumALPHCS.Name = "VisitForumALPHCS"
        Me.VisitForumALPHCS.Size = New System.Drawing.Size(107, 41)
        Me.VisitForumALPHCS.TabIndex = 3
        Me.VisitForumALPHCS.Text = " Visit forum"
        '
        'OptionsMenu
        '
        Me.OptionsMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.OptionsMenu.Location = New System.Drawing.Point(136, 6)
        Me.OptionsMenu.Name = "OptionsMenu"
        Me.OptionsMenu.Size = New System.Drawing.Size(107, 41)
        Me.OptionsMenu.TabIndex = 2
        Me.OptionsMenu.Text = "   Options"
        '
        'Updater
        '
        Me.Updater.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Updater.Location = New System.Drawing.Point(6, 6)
        Me.Updater.Name = "Updater"
        Me.Updater.Size = New System.Drawing.Size(107, 41)
        Me.Updater.TabIndex = 1
        Me.Updater.Text = "   Update"
        '
        'PlayZanyx
        '
        Me.PlayZanyx.BackgroundImage = CType(resources.GetObject("PlayZanyx.BackgroundImage"), System.Drawing.Image)
        Me.PlayZanyx.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlayZanyx.ForeColor = System.Drawing.Color.Sienna
        Me.PlayZanyx.Location = New System.Drawing.Point(414, 3)
        Me.PlayZanyx.Name = "PlayZanyx"
        Me.PlayZanyx.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.PlayZanyx.Size = New System.Drawing.Size(131, 44)
        Me.PlayZanyx.TabIndex = 0
        Me.PlayZanyx.Text = "     PLAY"
        '
        'Iesire
        '
        Me.Iesire.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Iesire.BackColor = System.Drawing.Color.DarkGray
        Me.Iesire.ControlButton = Launcher.NSControlButton.Button.Close
        Me.Iesire.Location = New System.Drawing.Point(539, 2)
        Me.Iesire.Margin = New System.Windows.Forms.Padding(0)
        Me.Iesire.MaximumSize = New System.Drawing.Size(18, 20)
        Me.Iesire.MinimumSize = New System.Drawing.Size(18, 20)
        Me.Iesire.Name = "Iesire"
        Me.Iesire.Size = New System.Drawing.Size(18, 20)
        Me.Iesire.TabIndex = 24
        Me.Iesire.Text = "NsControlButton1"
        '
        'TableCSaWB
        '
        Me.TableCSaWB.Controls.Add(Me.wpn)
        Me.TableCSaWB.Controls.Add(Me.GuardChecker)
        Me.TableCSaWB.Controls.Add(Me.Label1)
        Me.TableCSaWB.Controls.Add(Me.LauncherScreen)
        Me.TableCSaWB.Controls.Add(Me.LauncherNew)
        Me.TableCSaWB.DrawSeperator = False
        Me.TableCSaWB.Location = New System.Drawing.Point(5, 29)
        Me.TableCSaWB.Name = "TableCSaWB"
        Me.TableCSaWB.Size = New System.Drawing.Size(549, 353)
        Me.TableCSaWB.SubTitle = ""
        Me.TableCSaWB.TabIndex = 19
        Me.TableCSaWB.Title = ""
        '
        'wpn
        '
        Me.wpn.AutoSize = True
        Me.wpn.BackColor = System.Drawing.Color.Black
        Me.wpn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.wpn.ForeColor = System.Drawing.Color.Red
        Me.wpn.Location = New System.Drawing.Point(6, 332)
        Me.wpn.Name = "wpn"
        Me.wpn.Size = New System.Drawing.Size(147, 15)
        Me.wpn.TabIndex = 27
        Me.wpn.Text = "Weapons Models : Unknown"
        '
        'GuardChecker
        '
        Me.GuardChecker.AutoSize = True
        Me.GuardChecker.BackColor = System.Drawing.Color.Black
        Me.GuardChecker.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GuardChecker.ForeColor = System.Drawing.Color.ForestGreen
        Me.GuardChecker.Location = New System.Drawing.Point(415, 318)
        Me.GuardChecker.Name = "GuardChecker"
        Me.GuardChecker.Size = New System.Drawing.Size(105, 15)
        Me.GuardChecker.TabIndex = 26
        Me.GuardChecker.Text = "HLDS-GUARD : ON"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label1.Location = New System.Drawing.Point(415, 333)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 15)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Build Version : 1300"
        '
        'LauncherScreen
        '
        Me.LauncherScreen.Image = CType(resources.GetObject("LauncherScreen.Image"), System.Drawing.Image)
        Me.LauncherScreen.Location = New System.Drawing.Point(3, 4)
        Me.LauncherScreen.Name = "LauncherScreen"
        Me.LauncherScreen.Size = New System.Drawing.Size(541, 346)
        Me.LauncherScreen.TabIndex = 26
        Me.LauncherScreen.TabStop = False
        '
        'LauncherNew
        '
        Me.LauncherNew.Location = New System.Drawing.Point(3, 4)
        Me.LauncherNew.MinimumSize = New System.Drawing.Size(20, 20)
        Me.LauncherNew.Name = "LauncherNew"
        Me.LauncherNew.Size = New System.Drawing.Size(541, 346)
        Me.LauncherNew.TabIndex = 22
        Me.LauncherNew.Url = New System.Uri("http://skillartzhdrussian.allalla.com/zanyx/", System.UriKind.Absolute)
        Me.LauncherNew.Visible = False
        '
        'BaraWindow
        '
        Me.BaraWindow.BackColor = System.Drawing.SystemColors.ControlDark
        Me.BaraWindow.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.BaraWindow.Location = New System.Drawing.Point(-1, -3)
        Me.BaraWindow.Name = "BaraWindow"
        Me.BaraWindow.Size = New System.Drawing.Size(563, 26)
        Me.BaraWindow.TabIndex = 18
        Me.BaraWindow.Text = "Panel1"
        Me.BaraWindow.Value1 = " Counter Strike"
        Me.BaraWindow.Value2 = "  Launcher"
        '
        'LauncherStart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(559, 441)
        Me.Controls.Add(Me.Minimare)
        Me.Controls.Add(Me.TableZanyx)
        Me.Controls.Add(Me.Iesire)
        Me.Controls.Add(Me.TableCSaWB)
        Me.Controls.Add(Me.BaraWindow)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "LauncherStart"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Counter Strike"
        Me.TableZanyx.ResumeLayout(False)
        Me.TableCSaWB.ResumeLayout(False)
        Me.TableCSaWB.PerformLayout()
        CType(Me.LauncherScreen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BaraWindow As Launcher.NSLabel
    Friend WithEvents TableCSaWB As Launcher.NSGroupBox
    Friend WithEvents Iesire As Launcher.NSControlButton
    Friend WithEvents TableZanyx As Launcher.NSGroupBox
    Friend WithEvents PlayZanyx As Launcher.NSButton
    Friend WithEvents VisitForumALPHCS As Launcher.NSButton
    Friend WithEvents OptionsMenu As Launcher.NSButton
    Friend WithEvents Updater As Launcher.NSButton
    Friend WithEvents Minimare As Launcher.NSControlButton
    Friend WithEvents LauncherNew As System.Windows.Forms.WebBrowser
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LauncherScreen As System.Windows.Forms.PictureBox
    Friend WithEvents GuardChecker As System.Windows.Forms.Label
    Friend WithEvents wpn As System.Windows.Forms.Label

End Class
