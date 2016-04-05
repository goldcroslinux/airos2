<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Desktop
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
        Me.time = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.pm = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Content = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.menudrop = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel2.SuspendLayout()
        Me.Content.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.menudrop.SuspendLayout()
        Me.SuspendLayout()
        '
        'time
        '
        Me.time.BackColor = System.Drawing.Color.Transparent
        Me.time.Font = New System.Drawing.Font("Segoe UI", 45.0!)
        Me.time.ForeColor = System.Drawing.Color.White
        Me.time.Location = New System.Drawing.Point(8, 8)
        Me.time.Margin = New System.Windows.Forms.Padding(8)
        Me.time.Name = "time"
        Me.time.Size = New System.Drawing.Size(177, 84)
        Me.time.TabIndex = 1
        Me.time.Text = "12:00"
        Me.time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel2.Controls.Add(Me.pm)
        Me.Panel2.Controls.Add(Me.time)
        Me.Panel2.Location = New System.Drawing.Point(1104, 633)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(250, 100)
        Me.Panel2.TabIndex = 2
        '
        'pm
        '
        Me.pm.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pm.BackColor = System.Drawing.Color.Transparent
        Me.pm.Font = New System.Drawing.Font("Segoe UI", 25.0!)
        Me.pm.ForeColor = System.Drawing.Color.White
        Me.pm.Location = New System.Drawing.Point(165, 27)
        Me.pm.Margin = New System.Windows.Forms.Padding(8)
        Me.pm.Name = "pm"
        Me.pm.Size = New System.Drawing.Size(77, 65)
        Me.pm.TabIndex = 2
        Me.pm.Text = "PM"
        Me.pm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Content
        '
        Me.Content.BackColor = System.Drawing.Color.Transparent
        Me.Content.Controls.Add(Me.PictureBox2)
        Me.Content.Controls.Add(Me.PictureBox1)
        Me.Content.Controls.Add(Me.Panel2)
        Me.Content.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Content.Location = New System.Drawing.Point(0, 0)
        Me.Content.Name = "Content"
        Me.Content.Size = New System.Drawing.Size(1354, 733)
        Me.Content.TabIndex = 4
        '
        'PictureBox2
        '
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PictureBox2.Image = Global.air_os.My.Resources.Resources.globe
        Me.PictureBox2.Location = New System.Drawing.Point(0, 680)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(1354, 53)
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1354, 733)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'menudrop
        '
        Me.menudrop.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem2})
        Me.menudrop.Name = "menudrop"
        Me.menudrop.Size = New System.Drawing.Size(145, 48)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(144, 22)
        Me.ToolStripMenuItem1.Text = "airbrowser"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(144, 22)
        Me.ToolStripMenuItem2.Text = "airmusic play"
        '
        'Desktop
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = Global.air_os.My.Resources.Resources.material
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1354, 733)
        Me.Controls.Add(Me.Content)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Desktop"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Desktop"
        Me.Panel2.ResumeLayout(False)
        Me.Content.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.menudrop.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents time As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents pm As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Content As System.Windows.Forms.Panel
    Friend WithEvents menudrop As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
End Class