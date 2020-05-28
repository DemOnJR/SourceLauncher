<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HLDSGUARD
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HLDSGUARD))
        Me.NsGroupBox1 = New Launcher.NSGroupBox()
        Me.NsGroupBox3 = New Launcher.NSGroupBox()
        Me.NsButton5 = New Launcher.NSButton()
        Me.NsLabel3 = New Launcher.NSLabel()
        Me.NsLabel1 = New Launcher.NSLabel()
        Me.NsButton1 = New Launcher.NSButton()
        Me.NsButton2 = New Launcher.NSButton()
        Me.NsGroupBox2 = New Launcher.NSGroupBox()
        Me.NsLabel4 = New Launcher.NSLabel()
        Me.NsLabel2 = New Launcher.NSLabel()
        Me.NsButton3 = New Launcher.NSButton()
        Me.NsButton4 = New Launcher.NSButton()
        Me.ButtonIesire = New Launcher.NSControlButton()
        Me.BaraWindow = New Launcher.NSLabel()
        Me.NsGroupBox1.SuspendLayout()
        Me.NsGroupBox3.SuspendLayout()
        Me.NsGroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'NsGroupBox1
        '
        Me.NsGroupBox1.Controls.Add(Me.NsGroupBox3)
        Me.NsGroupBox1.Controls.Add(Me.NsGroupBox2)
        Me.NsGroupBox1.DrawSeperator = False
        Me.NsGroupBox1.Location = New System.Drawing.Point(5, 24)
        Me.NsGroupBox1.Name = "NsGroupBox1"
        Me.NsGroupBox1.Size = New System.Drawing.Size(461, 186)
        Me.NsGroupBox1.SubTitle = ""
        Me.NsGroupBox1.TabIndex = 32
        Me.NsGroupBox1.Text = "NsGroupBox1"
        Me.NsGroupBox1.Title = ""
        '
        'NsGroupBox3
        '
        Me.NsGroupBox3.Controls.Add(Me.NsButton5)
        Me.NsGroupBox3.Controls.Add(Me.NsLabel3)
        Me.NsGroupBox3.Controls.Add(Me.NsLabel1)
        Me.NsGroupBox3.Controls.Add(Me.NsButton1)
        Me.NsGroupBox3.Controls.Add(Me.NsButton2)
        Me.NsGroupBox3.DrawSeperator = False
        Me.NsGroupBox3.Location = New System.Drawing.Point(7, 94)
        Me.NsGroupBox3.Name = "NsGroupBox3"
        Me.NsGroupBox3.Size = New System.Drawing.Size(445, 82)
        Me.NsGroupBox3.SubTitle = "Details :  Protection guard and stop commands svc_director and svc_stufftext type" &
    " slowhacking"
        Me.NsGroupBox3.TabIndex = 4
        Me.NsGroupBox3.Text = "NsGroupBox3"
        Me.NsGroupBox3.Title = "HLDS-ClientProtector"
        '
        'NsButton5
        '
        Me.NsButton5.Location = New System.Drawing.Point(95, 48)
        Me.NsButton5.Name = "NsButton5"
        Me.NsButton5.Size = New System.Drawing.Size(40, 17)
        Me.NsButton5.TabIndex = 4
        Me.NsButton5.Text = "LOG"
        '
        'NsLabel3
        '
        Me.NsLabel3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold)
        Me.NsLabel3.Location = New System.Drawing.Point(90, 61)
        Me.NsLabel3.Name = "NsLabel3"
        Me.NsLabel3.Size = New System.Drawing.Size(256, 15)
        Me.NsLabel3.TabIndex = 3
        Me.NsLabel3.Text = "NsLabel3"
        Me.NsLabel3.Value1 = "-"
        Me.NsLabel3.Value2 = "-------------------------------------------"
        '
        'NsLabel1
        '
        Me.NsLabel1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold)
        Me.NsLabel1.Location = New System.Drawing.Point(90, 34)
        Me.NsLabel1.Name = "NsLabel1"
        Me.NsLabel1.Size = New System.Drawing.Size(256, 15)
        Me.NsLabel1.TabIndex = 2
        Me.NsLabel1.Text = "NsLabel1"
        Me.NsLabel1.Value1 = "-"
        Me.NsLabel1.Value2 = "-------------------------------------------"
        '
        'NsButton1
        '
        Me.NsButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.NsButton1.Location = New System.Drawing.Point(10, 34)
        Me.NsButton1.Name = "NsButton1"
        Me.NsButton1.Size = New System.Drawing.Size(74, 42)
        Me.NsButton1.TabIndex = 0
        Me.NsButton1.Text = "Enable"
        '
        'NsButton2
        '
        Me.NsButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NsButton2.Location = New System.Drawing.Point(352, 34)
        Me.NsButton2.Name = "NsButton2"
        Me.NsButton2.Size = New System.Drawing.Size(74, 42)
        Me.NsButton2.TabIndex = 1
        Me.NsButton2.Text = "Disable"
        '
        'NsGroupBox2
        '
        Me.NsGroupBox2.Controls.Add(Me.NsLabel4)
        Me.NsGroupBox2.Controls.Add(Me.NsLabel2)
        Me.NsGroupBox2.Controls.Add(Me.NsButton3)
        Me.NsGroupBox2.Controls.Add(Me.NsButton4)
        Me.NsGroupBox2.DrawSeperator = False
        Me.NsGroupBox2.Location = New System.Drawing.Point(6, 6)
        Me.NsGroupBox2.Name = "NsGroupBox2"
        Me.NsGroupBox2.Size = New System.Drawing.Size(446, 82)
        Me.NsGroupBox2.SubTitle = "Details : Get_user_info automatically delete every connect/disconnect and start c" &
    "lient "
        Me.NsGroupBox2.TabIndex = 3
        Me.NsGroupBox2.Text = "NsGroupBox2"
        Me.NsGroupBox2.Title = "HLDS-ClientInfo"
        '
        'NsLabel4
        '
        Me.NsLabel4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold)
        Me.NsLabel4.Location = New System.Drawing.Point(91, 62)
        Me.NsLabel4.Name = "NsLabel4"
        Me.NsLabel4.Size = New System.Drawing.Size(256, 15)
        Me.NsLabel4.TabIndex = 6
        Me.NsLabel4.Text = "NsLabel4"
        Me.NsLabel4.Value1 = "-"
        Me.NsLabel4.Value2 = "-------------------------------------------"
        '
        'NsLabel2
        '
        Me.NsLabel2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold)
        Me.NsLabel2.Location = New System.Drawing.Point(91, 35)
        Me.NsLabel2.Name = "NsLabel2"
        Me.NsLabel2.Size = New System.Drawing.Size(256, 15)
        Me.NsLabel2.TabIndex = 5
        Me.NsLabel2.Text = "NsLabel2"
        Me.NsLabel2.Value1 = "-"
        Me.NsLabel2.Value2 = "-------------------------------------------"
        '
        'NsButton3
        '
        Me.NsButton3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.NsButton3.Location = New System.Drawing.Point(11, 35)
        Me.NsButton3.Name = "NsButton3"
        Me.NsButton3.Size = New System.Drawing.Size(74, 42)
        Me.NsButton3.TabIndex = 3
        Me.NsButton3.Text = "Enable"
        '
        'NsButton4
        '
        Me.NsButton4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NsButton4.Location = New System.Drawing.Point(353, 35)
        Me.NsButton4.Name = "NsButton4"
        Me.NsButton4.Size = New System.Drawing.Size(74, 42)
        Me.NsButton4.TabIndex = 4
        Me.NsButton4.Text = "Disable"
        '
        'ButtonIesire
        '
        Me.ButtonIesire.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonIesire.BackColor = System.Drawing.Color.DarkGray
        Me.ButtonIesire.ControlButton = Launcher.NSControlButton.Button.Close
        Me.ButtonIesire.Location = New System.Drawing.Point(452, 0)
        Me.ButtonIesire.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonIesire.MaximumSize = New System.Drawing.Size(18, 20)
        Me.ButtonIesire.MinimumSize = New System.Drawing.Size(18, 20)
        Me.ButtonIesire.Name = "ButtonIesire"
        Me.ButtonIesire.Size = New System.Drawing.Size(18, 20)
        Me.ButtonIesire.TabIndex = 31
        Me.ButtonIesire.Text = "NsControlButton1"
        '
        'BaraWindow
        '
        Me.BaraWindow.BackColor = System.Drawing.Color.DarkGray
        Me.BaraWindow.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.BaraWindow.Location = New System.Drawing.Point(0, 0)
        Me.BaraWindow.Name = "BaraWindow"
        Me.BaraWindow.Size = New System.Drawing.Size(664, 20)
        Me.BaraWindow.TabIndex = 30
        Me.BaraWindow.Tag = ""
        Me.BaraWindow.Text = "Options"
        Me.BaraWindow.Value1 = " "
        Me.BaraWindow.Value2 = "HLDS-Engine 1300"
        '
        'HLDSGUARD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(473, 217)
        Me.Controls.Add(Me.NsGroupBox1)
        Me.Controls.Add(Me.ButtonIesire)
        Me.Controls.Add(Me.BaraWindow)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "HLDSGUARD"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "12414"
        Me.NsGroupBox1.ResumeLayout(False)
        Me.NsGroupBox3.ResumeLayout(False)
        Me.NsGroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents NsButton1 As Launcher.NSButton
    Friend WithEvents NsGroupBox1 As Launcher.NSGroupBox
    Friend WithEvents NsButton2 As Launcher.NSButton
    Friend WithEvents ButtonIesire As Launcher.NSControlButton
    Friend WithEvents BaraWindow As Launcher.NSLabel
    Friend WithEvents NsGroupBox3 As Launcher.NSGroupBox
    Friend WithEvents NsLabel3 As Launcher.NSLabel
    Friend WithEvents NsLabel1 As Launcher.NSLabel
    Friend WithEvents NsGroupBox2 As Launcher.NSGroupBox
    Friend WithEvents NsLabel4 As Launcher.NSLabel
    Friend WithEvents NsLabel2 As Launcher.NSLabel
    Friend WithEvents NsButton3 As Launcher.NSButton
    Friend WithEvents NsButton4 As Launcher.NSButton
    Friend WithEvents NsButton5 As Launcher.NSButton
End Class
