<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUtama
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormUtama))
        Me.btnbuku = New System.Windows.Forms.Button()
        Me.btnsiswa = New System.Windows.Forms.Button()
        Me.btnpengguna = New System.Windows.Forms.Button()
        Me.btnlogout = New System.Windows.Forms.Button()
        Me.btntransaksi = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.status = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TglJam = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TglHari = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnbuku
        '
        Me.btnbuku.Location = New System.Drawing.Point(12, 221)
        Me.btnbuku.Name = "btnbuku"
        Me.btnbuku.Size = New System.Drawing.Size(80, 23)
        Me.btnbuku.TabIndex = 1
        Me.btnbuku.Text = "&Data Buku"
        Me.btnbuku.UseVisualStyleBackColor = True
        '
        'btnsiswa
        '
        Me.btnsiswa.Location = New System.Drawing.Point(98, 221)
        Me.btnsiswa.Name = "btnsiswa"
        Me.btnsiswa.Size = New System.Drawing.Size(80, 23)
        Me.btnsiswa.TabIndex = 2
        Me.btnsiswa.Text = "&Data Siswa"
        Me.btnsiswa.UseVisualStyleBackColor = True
        '
        'btnpengguna
        '
        Me.btnpengguna.Location = New System.Drawing.Point(184, 221)
        Me.btnpengguna.Name = "btnpengguna"
        Me.btnpengguna.Size = New System.Drawing.Size(80, 23)
        Me.btnpengguna.TabIndex = 3
        Me.btnpengguna.Text = "&Pustakawan"
        Me.btnpengguna.UseVisualStyleBackColor = True
        '
        'btnlogout
        '
        Me.btnlogout.Location = New System.Drawing.Point(87, 301)
        Me.btnlogout.Name = "btnlogout"
        Me.btnlogout.Size = New System.Drawing.Size(310, 23)
        Me.btnlogout.TabIndex = 5
        Me.btnlogout.Text = "&Log Out"
        Me.btnlogout.UseVisualStyleBackColor = True
        '
        'btntransaksi
        '
        Me.btntransaksi.Location = New System.Drawing.Point(87, 262)
        Me.btntransaksi.Name = "btntransaksi"
        Me.btntransaksi.Size = New System.Drawing.Size(310, 23)
        Me.btntransaksi.TabIndex = 4
        Me.btntransaksi.Text = "&Transaksi"
        Me.btntransaksi.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.status, Me.TglJam, Me.TglHari})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 336)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(471, 22)
        Me.StatusStrip1.TabIndex = 6
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'status
        '
        Me.status.Name = "status"
        Me.status.Size = New System.Drawing.Size(39, 17)
        Me.status.Text = "Status"
        '
        'TglJam
        '
        Me.TglJam.Name = "TglJam"
        Me.TglJam.Size = New System.Drawing.Size(74, 17)
        Me.TglJam.Text = "Tanggal_Jam"
        '
        'TglHari
        '
        Me.TglHari.Name = "TglHari"
        Me.TglHari.Size = New System.Drawing.Size(75, 17)
        Me.TglHari.Text = "Tanggal_Hari"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Poor Richard", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(126, 179)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(243, 23)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "PERPUSTAKAAN DIGITAL"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Image = Global.Perpustakaan_Digital.My.Resources.Resources.perpustakaan_ri
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(471, 160)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(361, 336)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "By : M.Hidayatullah"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(270, 221)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(195, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "&Cetak Laporan Peminjaman"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FormUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(471, 358)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btntransaksi)
        Me.Controls.Add(Me.btnlogout)
        Me.Controls.Add(Me.btnpengguna)
        Me.Controls.Add(Me.btnsiswa)
        Me.Controls.Add(Me.btnbuku)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FormUtama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Perpustakaan Digital"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnbuku As System.Windows.Forms.Button
    Friend WithEvents btnsiswa As System.Windows.Forms.Button
    Friend WithEvents btnpengguna As System.Windows.Forms.Button
    Friend WithEvents btnlogout As System.Windows.Forms.Button
    Friend WithEvents btntransaksi As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents status As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TglJam As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TglHari As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
