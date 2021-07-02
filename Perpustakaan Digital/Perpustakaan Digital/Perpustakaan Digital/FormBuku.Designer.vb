<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBuku
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
        Dim ID_BukuLabel As System.Windows.Forms.Label
        Dim Judul_BukuLabel As System.Windows.Forms.Label
        Dim PenulisLabel As System.Windows.Forms.Label
        Dim PenerbitLabel As System.Windows.Forms.Label
        Dim Tahun_TerbitLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBuku))
        Me.PerpustakaanDigitalDataSet = New Perpustakaan_Digital.PerpustakaanDigitalDataSet()
        Me.TablebukuBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TablebukuTableAdapter = New Perpustakaan_Digital.PerpustakaanDigitalDataSetTableAdapters.tablebukuTableAdapter()
        Me.TableAdapterManager = New Perpustakaan_Digital.PerpustakaanDigitalDataSetTableAdapters.TableAdapterManager()
        Me.TablebukuDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.ID_BukuTextBox = New System.Windows.Forms.TextBox()
        Me.Judul_BukuTextBox = New System.Windows.Forms.TextBox()
        Me.PenulisTextBox = New System.Windows.Forms.TextBox()
        Me.PenerbitTextBox = New System.Windows.Forms.TextBox()
        Me.Tahun_TerbitTextBox = New System.Windows.Forms.TextBox()
        Me.btnkembali = New System.Windows.Forms.Button()
        Me.btnhapus = New System.Windows.Forms.Button()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.btntambah = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        ID_BukuLabel = New System.Windows.Forms.Label()
        Judul_BukuLabel = New System.Windows.Forms.Label()
        PenulisLabel = New System.Windows.Forms.Label()
        PenerbitLabel = New System.Windows.Forms.Label()
        Tahun_TerbitLabel = New System.Windows.Forms.Label()
        CType(Me.PerpustakaanDigitalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TablebukuBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TablebukuDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ID_BukuLabel
        '
        ID_BukuLabel.AutoSize = True
        ID_BukuLabel.Location = New System.Drawing.Point(6, 22)
        ID_BukuLabel.Name = "ID_BukuLabel"
        ID_BukuLabel.Size = New System.Drawing.Size(49, 13)
        ID_BukuLabel.TabIndex = 0
        ID_BukuLabel.Text = "ID Buku:"
        '
        'Judul_BukuLabel
        '
        Judul_BukuLabel.AutoSize = True
        Judul_BukuLabel.Location = New System.Drawing.Point(6, 48)
        Judul_BukuLabel.Name = "Judul_BukuLabel"
        Judul_BukuLabel.Size = New System.Drawing.Size(63, 13)
        Judul_BukuLabel.TabIndex = 2
        Judul_BukuLabel.Text = "Judul Buku:"
        '
        'PenulisLabel
        '
        PenulisLabel.AutoSize = True
        PenulisLabel.Location = New System.Drawing.Point(6, 74)
        PenulisLabel.Name = "PenulisLabel"
        PenulisLabel.Size = New System.Drawing.Size(44, 13)
        PenulisLabel.TabIndex = 4
        PenulisLabel.Text = "Penulis:"
        '
        'PenerbitLabel
        '
        PenerbitLabel.AutoSize = True
        PenerbitLabel.Location = New System.Drawing.Point(6, 100)
        PenerbitLabel.Name = "PenerbitLabel"
        PenerbitLabel.Size = New System.Drawing.Size(49, 13)
        PenerbitLabel.TabIndex = 6
        PenerbitLabel.Text = "Penerbit:"
        '
        'Tahun_TerbitLabel
        '
        Tahun_TerbitLabel.AutoSize = True
        Tahun_TerbitLabel.Location = New System.Drawing.Point(6, 126)
        Tahun_TerbitLabel.Name = "Tahun_TerbitLabel"
        Tahun_TerbitLabel.Size = New System.Drawing.Size(71, 13)
        Tahun_TerbitLabel.TabIndex = 8
        Tahun_TerbitLabel.Text = "Tahun Terbit:"
        '
        'PerpustakaanDigitalDataSet
        '
        Me.PerpustakaanDigitalDataSet.DataSetName = "PerpustakaanDigitalDataSet"
        Me.PerpustakaanDigitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TablebukuBindingSource
        '
        Me.TablebukuBindingSource.DataMember = "tablebuku"
        Me.TablebukuBindingSource.DataSource = Me.PerpustakaanDigitalDataSet
        '
        'TablebukuTableAdapter
        '
        Me.TablebukuTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tablebukuTableAdapter = Me.TablebukuTableAdapter
        Me.TableAdapterManager.tableloginTableAdapter = Nothing
        Me.TableAdapterManager.tablesiswaTableAdapter = Nothing
        Me.TableAdapterManager.tablestatusTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Perpustakaan_Digital.PerpustakaanDigitalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TablebukuDataGridView
        '
        Me.TablebukuDataGridView.AllowUserToAddRows = False
        Me.TablebukuDataGridView.AllowUserToDeleteRows = False
        Me.TablebukuDataGridView.AllowUserToResizeColumns = False
        Me.TablebukuDataGridView.AllowUserToResizeRows = False
        Me.TablebukuDataGridView.AutoGenerateColumns = False
        Me.TablebukuDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.TablebukuDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TablebukuDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.TablebukuDataGridView.DataSource = Me.TablebukuBindingSource
        Me.TablebukuDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TablebukuDataGridView.Location = New System.Drawing.Point(0, 262)
        Me.TablebukuDataGridView.Name = "TablebukuDataGridView"
        Me.TablebukuDataGridView.Size = New System.Drawing.Size(839, 200)
        Me.TablebukuDataGridView.TabIndex = 1
        Me.TablebukuDataGridView.TabStop = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID_Buku"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID_Buku"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Judul_Buku"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Judul_Buku"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Penulis"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Penulis"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Penerbit"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Penerbit"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Tahun_Terbit"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Tahun_Terbit"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btncancel)
        Me.GroupBox1.Controls.Add(Me.btnsimpan)
        Me.GroupBox1.Controls.Add(ID_BukuLabel)
        Me.GroupBox1.Controls.Add(Me.ID_BukuTextBox)
        Me.GroupBox1.Controls.Add(Judul_BukuLabel)
        Me.GroupBox1.Controls.Add(Me.Judul_BukuTextBox)
        Me.GroupBox1.Controls.Add(PenulisLabel)
        Me.GroupBox1.Controls.Add(Me.PenulisTextBox)
        Me.GroupBox1.Controls.Add(PenerbitLabel)
        Me.GroupBox1.Controls.Add(Me.PenerbitTextBox)
        Me.GroupBox1.Controls.Add(Tahun_TerbitLabel)
        Me.GroupBox1.Controls.Add(Me.Tahun_TerbitTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(350, 244)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Input Data Buku"
        '
        'btncancel
        '
        Me.btncancel.Enabled = False
        Me.btncancel.Image = Global.Perpustakaan_Digital.My.Resources.Resources.block
        Me.btncancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btncancel.Location = New System.Drawing.Point(268, 215)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(75, 23)
        Me.btncancel.TabIndex = 11
        Me.btncancel.Text = "Cancel"
        Me.btncancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'btnsimpan
        '
        Me.btnsimpan.Enabled = False
        Me.btnsimpan.Image = Global.Perpustakaan_Digital.My.Resources.Resources.accept
        Me.btnsimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnsimpan.Location = New System.Drawing.Point(9, 215)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(75, 23)
        Me.btnsimpan.TabIndex = 10
        Me.btnsimpan.Text = "Simpan"
        Me.btnsimpan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnsimpan.UseVisualStyleBackColor = True
        '
        'ID_BukuTextBox
        '
        Me.ID_BukuTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TablebukuBindingSource, "ID_Buku", True))
        Me.ID_BukuTextBox.Enabled = False
        Me.ID_BukuTextBox.Location = New System.Drawing.Point(83, 19)
        Me.ID_BukuTextBox.Name = "ID_BukuTextBox"
        Me.ID_BukuTextBox.Size = New System.Drawing.Size(260, 20)
        Me.ID_BukuTextBox.TabIndex = 1
        '
        'Judul_BukuTextBox
        '
        Me.Judul_BukuTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TablebukuBindingSource, "Judul_Buku", True))
        Me.Judul_BukuTextBox.Enabled = False
        Me.Judul_BukuTextBox.Location = New System.Drawing.Point(83, 45)
        Me.Judul_BukuTextBox.Name = "Judul_BukuTextBox"
        Me.Judul_BukuTextBox.Size = New System.Drawing.Size(260, 20)
        Me.Judul_BukuTextBox.TabIndex = 3
        '
        'PenulisTextBox
        '
        Me.PenulisTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TablebukuBindingSource, "Penulis", True))
        Me.PenulisTextBox.Enabled = False
        Me.PenulisTextBox.Location = New System.Drawing.Point(83, 71)
        Me.PenulisTextBox.Name = "PenulisTextBox"
        Me.PenulisTextBox.Size = New System.Drawing.Size(260, 20)
        Me.PenulisTextBox.TabIndex = 5
        '
        'PenerbitTextBox
        '
        Me.PenerbitTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TablebukuBindingSource, "Penerbit", True))
        Me.PenerbitTextBox.Enabled = False
        Me.PenerbitTextBox.Location = New System.Drawing.Point(83, 97)
        Me.PenerbitTextBox.Name = "PenerbitTextBox"
        Me.PenerbitTextBox.Size = New System.Drawing.Size(260, 20)
        Me.PenerbitTextBox.TabIndex = 7
        '
        'Tahun_TerbitTextBox
        '
        Me.Tahun_TerbitTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TablebukuBindingSource, "Tahun_Terbit", True))
        Me.Tahun_TerbitTextBox.Enabled = False
        Me.Tahun_TerbitTextBox.Location = New System.Drawing.Point(83, 123)
        Me.Tahun_TerbitTextBox.Name = "Tahun_TerbitTextBox"
        Me.Tahun_TerbitTextBox.Size = New System.Drawing.Size(260, 20)
        Me.Tahun_TerbitTextBox.TabIndex = 9
        '
        'btnkembali
        '
        Me.btnkembali.Image = Global.Perpustakaan_Digital.My.Resources.Resources.back
        Me.btnkembali.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnkembali.Location = New System.Drawing.Point(368, 227)
        Me.btnkembali.Name = "btnkembali"
        Me.btnkembali.Size = New System.Drawing.Size(150, 23)
        Me.btnkembali.TabIndex = 16
        Me.btnkembali.Text = "Kembali"
        Me.btnkembali.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnkembali.UseVisualStyleBackColor = True
        '
        'btnhapus
        '
        Me.btnhapus.Image = Global.Perpustakaan_Digital.My.Resources.Resources.delete
        Me.btnhapus.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnhapus.Location = New System.Drawing.Point(368, 198)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(150, 23)
        Me.btnhapus.TabIndex = 15
        Me.btnhapus.Text = "Hapus"
        Me.btnhapus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnhapus.UseVisualStyleBackColor = True
        '
        'btnedit
        '
        Me.btnedit.Image = Global.Perpustakaan_Digital.My.Resources.Resources.favicon__3_
        Me.btnedit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnedit.Location = New System.Drawing.Point(368, 169)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(150, 23)
        Me.btnedit.TabIndex = 14
        Me.btnedit.Text = "Edit"
        Me.btnedit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnedit.UseVisualStyleBackColor = True
        '
        'btntambah
        '
        Me.btntambah.Image = Global.Perpustakaan_Digital.My.Resources.Resources.add
        Me.btntambah.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btntambah.Location = New System.Drawing.Point(368, 140)
        Me.btntambah.Name = "btntambah"
        Me.btntambah.Size = New System.Drawing.Size(150, 23)
        Me.btntambah.TabIndex = 13
        Me.btntambah.Text = "Tambah"
        Me.btntambah.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btntambah.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Perpustakaan_Digital.My.Resources.Resources.buku_3
        Me.PictureBox1.Location = New System.Drawing.Point(555, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(250, 244)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'FormBuku
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(839, 462)
        Me.Controls.Add(Me.btnkembali)
        Me.Controls.Add(Me.btnhapus)
        Me.Controls.Add(Me.btnedit)
        Me.Controls.Add(Me.btntambah)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TablebukuDataGridView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FormBuku"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Buku"
        CType(Me.PerpustakaanDigitalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TablebukuBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TablebukuDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PerpustakaanDigitalDataSet As Perpustakaan_Digital.PerpustakaanDigitalDataSet
    Friend WithEvents TablebukuBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TablebukuTableAdapter As Perpustakaan_Digital.PerpustakaanDigitalDataSetTableAdapters.tablebukuTableAdapter
    Friend WithEvents TableAdapterManager As Perpustakaan_Digital.PerpustakaanDigitalDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TablebukuDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents btnsimpan As System.Windows.Forms.Button
    Friend WithEvents ID_BukuTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Judul_BukuTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PenulisTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PenerbitTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Tahun_TerbitTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btntambah As System.Windows.Forms.Button
    Friend WithEvents btnedit As System.Windows.Forms.Button
    Friend WithEvents btnhapus As System.Windows.Forms.Button
    Friend WithEvents btnkembali As System.Windows.Forms.Button
End Class
