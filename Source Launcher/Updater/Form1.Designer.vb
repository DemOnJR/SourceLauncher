<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.NsProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.asd = New SkillartzHD.NSLabel()
        Me.NsControlButton1 = New SkillartzHD.NSControlButton()
        Me.Panel1 = New SkillartzHD.NSLabel()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.asd)
        Me.GroupBox1.Controls.Add(Me.NsProgressBar1)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(306, 62)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'NsProgressBar1
        '
        Me.NsProgressBar1.Location = New System.Drawing.Point(5, 33)
        Me.NsProgressBar1.Name = "NsProgressBar1"
        Me.NsProgressBar1.Size = New System.Drawing.Size(295, 23)
        Me.NsProgressBar1.TabIndex = 2
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'asd
        '
        Me.asd.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold)
        Me.asd.Location = New System.Drawing.Point(5, 9)
        Me.asd.Name = "asd"
        Me.asd.Size = New System.Drawing.Size(295, 23)
        Me.asd.TabIndex = 3
        Me.asd.Value1 = " "
        Me.asd.Value2 = "Connect to Server..."
        Me.asd.Visible = False
        '
        'NsControlButton1
        '
        Me.NsControlButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NsControlButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.NsControlButton1.ControlButton = SkillartzHD.NSControlButton.Button.Close
        Me.NsControlButton1.Location = New System.Drawing.Point(293, 2)
        Me.NsControlButton1.Margin = New System.Windows.Forms.Padding(0)
        Me.NsControlButton1.MaximumSize = New System.Drawing.Size(18, 20)
        Me.NsControlButton1.MinimumSize = New System.Drawing.Size(18, 20)
        Me.NsControlButton1.Name = "NsControlButton1"
        Me.NsControlButton1.Size = New System.Drawing.Size(18, 20)
        Me.NsControlButton1.TabIndex = 1
        Me.NsControlButton1.Text = "NsControlButton1"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Panel1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Panel1.ForeColor = System.Drawing.Color.DarkRed
        Me.Panel1.Location = New System.Drawing.Point(2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(322, 20)
        Me.Panel1.TabIndex = 0
        Me.Panel1.Text = "Panel1"
        Me.Panel1.Value1 = "Counter Strike Zanyx"
        Me.Panel1.Value2 = ""
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(313, 90)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.NsControlButton1)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Updater HLDS RUSSIAN"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents NsProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents asd As SkillartzHD.NSLabel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents NsControlButton1 As SkillartzHD.NSControlButton
    Friend WithEvents Panel1 As SkillartzHD.NSLabel

End Class
