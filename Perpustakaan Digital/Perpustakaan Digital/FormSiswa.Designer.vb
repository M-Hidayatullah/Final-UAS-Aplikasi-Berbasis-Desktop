<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSiswa
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
        Dim NISLabel As System.Windows.Forms.Label
        Dim NamaLabel As System.Windows.Forms.Label
        Dim KelasLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSiswa))
        Me.PerpustakaanDigitalDataSet = New Perpustakaan_Digital.PerpustakaanDigitalDataSet()
        Me.TablesiswaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TablesiswaTableAdapter = New Perpustakaan_Digital.PerpustakaanDigitalDataSetTableAdapters.tablesiswaTableAdapter()
        Me.TableAdapterManager = New Perpustakaan_Digital.PerpustakaanDigitalDataSetTableAdapters.TableAdapterManager()
        Me.TablesiswaDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NISTextBox = New System.Windows.Forms.TextBox()
        Me.NamaTextBox = New System.Windows.Forms.TextBox()
        Me.KelasComboBox = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.btntambah = New System.Windows.Forms.Button()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.btnhapus = New System.Windows.Forms.Button()
        Me.btnkembali = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        NISLabel = New System.Windows.Forms.Label()
        NamaLabel = New System.Windows.Forms.Label()
        KelasLabel = New System.Windows.Forms.Label()
        CType(Me.PerpustakaanDigitalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TablesiswaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TablesiswaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NISLabel
        '
        NISLabel.AutoSize = True
        NISLabel.Location = New System.Drawing.Point(6, 22)
        NISLabel.Name = "NISLabel"
        NISLabel.Size = New System.Drawing.Size(28, 13)
        NISLabel.TabIndex = 1
        NISLabel.Text = "NIS:"
        '
        'NamaLabel
        '
        NamaLabel.AutoSize = True
        NamaLabel.Location = New System.Drawing.Point(6, 48)
        NamaLabel.Name = "NamaLabel"
        NamaLabel.Size = New System.Drawing.Size(38, 13)
        NamaLabel.TabIndex = 3
        NamaLabel.Text = "Nama:"
        '
        'KelasLabel
        '
        KelasLabel.AutoSize = True
        KelasLabel.Location = New System.Drawing.Point(6, 74)
        KelasLabel.Name = "KelasLabel"
        KelasLabel.Size = New System.Drawing.Size(36, 13)
        KelasLabel.TabIndex = 5
        KelasLabel.Text = "Kelas:"
        '
        'PerpustakaanDigitalDataSet
        '
        Me.PerpustakaanDigitalDataSet.DataSetName = "PerpustakaanDigitalDataSet"
        Me.PerpustakaanDigitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TablesiswaBindingSource
        '
        Me.TablesiswaBindingSource.DataMember = "tablesiswa"
        Me.TablesiswaBindingSource.DataSource = Me.PerpustakaanDigitalDataSet
        '
        'TablesiswaTableAdapter
        '
        Me.TablesiswaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tablebukuTableAdapter = Nothing
        Me.TableAdapterManager.tableloginTableAdapter = Nothing
        Me.TableAdapterManager.tablesiswaTableAdapter = Me.TablesiswaTableAdapter
        Me.TableAdapterManager.tablestatusTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Perpustakaan_Digital.PerpustakaanDigitalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TablesiswaDataGridView
        '
        Me.TablesiswaDataGridView.AllowUserToAddRows = False
        Me.TablesiswaDataGridView.AllowUserToDeleteRows = False
        Me.TablesiswaDataGridView.AllowUserToResizeColumns = False
        Me.TablesiswaDataGridView.AllowUserToResizeRows = False
        Me.TablesiswaDataGridView.AutoGenerateColumns = False
        Me.TablesiswaDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.TablesiswaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TablesiswaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.TablesiswaDataGridView.DataSource = Me.TablesiswaBindingSource
        Me.TablesiswaDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TablesiswaDataGridView.Location = New System.Drawing.Point(0, 262)
        Me.TablesiswaDataGridView.Name = "TablesiswaDataGridView"
        Me.TablesiswaDataGridView.Size = New System.Drawing.Size(839, 200)
        Me.TablesiswaDataGridView.TabIndex = 1
        Me.TablesiswaDataGridView.TabStop = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "NIS"
        Me.DataGridViewTextBoxColumn1.HeaderText = "NIS"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Nama"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nama"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Kelas"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Kelas"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'NISTextBox
        '
        Me.NISTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TablesiswaBindingSource, "NIS", True))
        Me.NISTextBox.Enabled = False
        Me.NISTextBox.Location = New System.Drawing.Point(50, 19)
        Me.NISTextBox.Name = "NISTextBox"
        Me.NISTextBox.Size = New System.Drawing.Size(120, 20)
        Me.NISTextBox.TabIndex = 2
        '
        'NamaTextBox
        '
        Me.NamaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TablesiswaBindingSource, "Nama", True))
        Me.NamaTextBox.Enabled = False
        Me.NamaTextBox.Location = New System.Drawing.Point(50, 45)
        Me.NamaTextBox.Name = "NamaTextBox"
        Me.NamaTextBox.Size = New System.Drawing.Size(290, 20)
        Me.NamaTextBox.TabIndex = 4
        '
        'KelasComboBox
        '
        Me.KelasComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TablesiswaBindingSource, "Kelas", True))
        Me.KelasComboBox.Enabled = False
        Me.KelasComboBox.FormattingEnabled = True
        Me.KelasComboBox.Location = New System.Drawing.Point(50, 71)
        Me.KelasComboBox.Name = "KelasComboBox"
        Me.KelasComboBox.Size = New System.Drawing.Size(120, 21)
        Me.KelasComboBox.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btncancel)
        Me.GroupBox1.Controls.Add(Me.btnsimpan)
        Me.GroupBox1.Controls.Add(Me.RadioButton3)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(NISLabel)
        Me.GroupBox1.Controls.Add(Me.KelasComboBox)
        Me.GroupBox1.Controls.Add(Me.NISTextBox)
        Me.GroupBox1.Controls.Add(KelasLabel)
        Me.GroupBox1.Controls.Add(NamaLabel)
        Me.GroupBox1.Controls.Add(Me.NamaTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(350, 244)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Input Data Siswa"
        '
        'btncancel
        '
        Me.btncancel.Enabled = False
        Me.btncancel.Image = Global.Perpustakaan_Digital.My.Resources.Resources.block
        Me.btncancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btncancel.Location = New System.Drawing.Point(265, 215)
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
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Enabled = False
        Me.RadioButton3.Location = New System.Drawing.Point(88, 98)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(35, 17)
        Me.RadioButton3.TabIndex = 9
        Me.RadioButton3.Text = "XI"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Enabled = False
        Me.RadioButton2.Location = New System.Drawing.Point(129, 98)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(38, 17)
        Me.RadioButton2.TabIndex = 8
        Me.RadioButton2.Text = "XII"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Enabled = False
        Me.RadioButton1.Location = New System.Drawing.Point(50, 98)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(32, 17)
        Me.RadioButton1.TabIndex = 7
        Me.RadioButton1.Text = "X"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'btntambah
        '
        Me.btntambah.Image = Global.Perpustakaan_Digital.My.Resources.Resources.add
        Me.btntambah.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btntambah.Location = New System.Drawing.Point(368, 140)
        Me.btntambah.Name = "btntambah"
        Me.btntambah.Size = New System.Drawing.Size(150, 23)
        Me.btntambah.TabIndex = 12
        Me.btntambah.Text = "Tambah"
        Me.btntambah.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btntambah.UseVisualStyleBackColor = True
        '
        'btnedit
        '
        Me.btnedit.Image = Global.Perpustakaan_Digital.My.Resources.Resources.favicon__3_
        Me.btnedit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnedit.Location = New System.Drawing.Point(368, 169)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(150, 23)
        Me.btnedit.TabIndex = 13
        Me.btnedit.Text = "Edit"
        Me.btnedit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnedit.UseVisualStyleBackColor = True
        '
        'btnhapus
        '
        Me.btnhapus.Image = Global.Perpustakaan_Digital.My.Resources.Resources.delete
        Me.btnhapus.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnhapus.Location = New System.Drawing.Point(368, 198)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(150, 23)
        Me.btnhapus.TabIndex = 14
        Me.btnhapus.Text = "Hapus"
        Me.btnhapus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnhapus.UseVisualStyleBackColor = True
        '
        'btnkembali
        '
        Me.btnkembali.Image = Global.Perpustakaan_Digital.My.Resources.Resources.back
        Me.btnkembali.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnkembali.Location = New System.Drawing.Point(368, 227)
        Me.btnkembali.Name = "btnkembali"
        Me.btnkembali.Size = New System.Drawing.Size(150, 23)
        Me.btnkembali.TabIndex = 15
        Me.btnkembali.Text = "Kembali"
        Me.btnkembali.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnkembali.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Perpustakaan_Digital.My.Resources.Resources.span_logo
        Me.PictureBox1.Location = New System.Drawing.Point(555, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(250, 244)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'FormSiswa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(839, 462)
        Me.Controls.Add(Me.btnedit)
        Me.Controls.Add(Me.btnhapus)
        Me.Controls.Add(Me.btnkembali)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btntambah)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TablesiswaDataGridView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FormSiswa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Siswa"
        CType(Me.PerpustakaanDigitalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TablesiswaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TablesiswaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PerpustakaanDigitalDataSet As Perpustakaan_Digital.PerpustakaanDigitalDataSet
    Friend WithEvents TablesiswaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TablesiswaTableAdapter As Perpustakaan_Digital.PerpustakaanDigitalDataSetTableAdapters.tablesiswaTableAdapter
    Friend WithEvents TableAdapterManager As Perpustakaan_Digital.PerpustakaanDigitalDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TablesiswaDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NISTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NamaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents KelasComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents btnsimpan As System.Windows.Forms.Button
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents btnkembali As System.Windows.Forms.Button
    Friend WithEvents btnhapus As System.Windows.Forms.Button
    Friend WithEvents btnedit As System.Windows.Forms.Button
    Friend WithEvents btntambah As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
