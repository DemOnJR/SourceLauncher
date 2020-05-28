<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ButtonCLASSICModels
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
        Me.GropBoxTableCLS = New Launcher.NSGroupBox()
        Me.buttoNO = New Launcher.NSButton()
        Me.buttonYES = New Launcher.NSButton()
        Me.Iesire = New Launcher.NSControlButton()
        Me.BaraWindow = New Launcher.NSLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GropBoxTableCLS.SuspendLayout()
        Me.SuspendLayout()
        '
        'GropBoxTableCLS
        '
        Me.GropBoxTableCLS.Controls.Add(Me.buttoNO)
        Me.GropBoxTableCLS.Controls.Add(Me.buttonYES)
        Me.GropBoxTableCLS.DrawSeperator = False
        Me.GropBoxTableCLS.Location = New System.Drawing.Point(4, 27)
        Me.GropBoxTableCLS.Name = "GropBoxTableCLS"
        Me.GropBoxTableCLS.Size = New System.Drawing.Size(289, 59)
        Me.GropBoxTableCLS.SubTitle = "Are you sure you want to install Classic Models in your client?"
        Me.GropBoxTableCLS.TabIndex = 8
        Me.GropBoxTableCLS.Text = "NsGroupBox1"
        Me.GropBoxTableCLS.Title = ""
        '
        'buttoNO
        '
        Me.buttoNO.Location = New System.Drawing.Point(160, 25)
        Me.buttoNO.Name = "buttoNO"
        Me.buttoNO.Size = New System.Drawing.Size(86, 31)
        Me.buttoNO.TabIndex = 2
        Me.buttoNO.Text = "          No"
        '
        'buttonYES
        '
        Me.buttonYES.Location = New System.Drawing.Point(28, 25)
        Me.buttonYES.Name = "buttonYES"
        Me.buttonYES.Size = New System.Drawing.Size(86, 31)
        Me.buttonYES.TabIndex = 1
        Me.buttonYES.Text = "        Yes"
        '
        'Iesire
        '
        Me.Iesire.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Iesire.BackColor = System.Drawing.Color.DarkGray
        Me.Iesire.ControlButton = Launcher.NSControlButton.Button.Close
        Me.Iesire.Location = New System.Drawing.Point(281, 2)
        Me.Iesire.Margin = New System.Windows.Forms.Padding(0)
        Me.Iesire.MaximumSize = New System.Drawing.Size(18, 20)
        Me.Iesire.MinimumSize = New System.Drawing.Size(18, 20)
        Me.Iesire.Name = "Iesire"
        Me.Iesire.Size = New System.Drawing.Size(18, 20)
        Me.Iesire.TabIndex = 7
        Me.Iesire.Text = "NsControlButton1"
        '
        'BaraWindow
        '
        Me.BaraWindow.BackColor = System.Drawing.Color.DarkGray
        Me.BaraWindow.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.BaraWindow.Location = New System.Drawing.Point(-2, 0)
        Me.BaraWindow.Name = "BaraWindow"
        Me.BaraWindow.Size = New System.Drawing.Size(404, 23)
        Me.BaraWindow.TabIndex = 6
        Me.BaraWindow.Text = "NsLabel1"
        Me.BaraWindow.Value1 = " Zanyx 6"
        Me.BaraWindow.Value2 = "  Classic Models"
        '
        'ButtonCLASSICModels
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(300, 94)
        Me.Controls.Add(Me.GropBoxTableCLS)
        Me.Controls.Add(Me.Iesire)
        Me.Controls.Add(Me.BaraWindow)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ButtonCLASSICModels"
        Me.Padding = New System.Windows.Forms.Padding(9)
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ButtonCLASSICModels"
        Me.GropBoxTableCLS.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GropBoxTableCLS As Launcher.NSGroupBox
    Friend WithEvents buttoNO As Launcher.NSButton
    Friend WithEvents buttonYES As Launcher.NSButton
    Friend WithEvents Iesire As Launcher.NSControlButton
    Friend WithEvents BaraWindow As Launcher.NSLabel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
