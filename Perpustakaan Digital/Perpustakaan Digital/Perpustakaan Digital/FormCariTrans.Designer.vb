<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCariTrans
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
        Dim No_PeminjamanLabel As System.Windows.Forms.Label
        Dim ID_BukuLabel As System.Windows.Forms.Label
        Dim Judul_BukuLabel As System.Windows.Forms.Label
        Dim NISLabel As System.Windows.Forms.Label
        Dim NamaLabel As System.Windows.Forms.Label
        Dim KelasLabel As System.Windows.Forms.Label
        Dim Tgl_PinjamLabel As System.Windows.Forms.Label
        Dim Tgl_KembaliLabel As System.Windows.Forms.Label
        Dim StatusLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCariTrans))
        Me.PerpustakaanDigitalDataSet = New Perpustakaan_Digital.PerpustakaanDigitalDataSet()
        Me.TablestatusBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TablestatusTableAdapter = New Perpustakaan_Digital.PerpustakaanDigitalDataSetTableAdapters.tablestatusTableAdapter()
        Me.TableAdapterManager = New Perpustakaan_Digital.PerpustakaanDigitalDataSetTableAdapters.TableAdapterManager()
        Me.TablestatusDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.No_PeminjamanTextBox = New System.Windows.Forms.TextBox()
        Me.ID_BukuTextBox = New System.Windows.Forms.TextBox()
        Me.Judul_BukuTextBox = New System.Windows.Forms.TextBox()
        Me.NISTextBox = New System.Windows.Forms.TextBox()
        Me.NamaTextBox = New System.Windows.Forms.TextBox()
        Me.KelasComboBox = New System.Windows.Forms.ComboBox()
        Me.Tgl_PinjamDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Tgl_KembaliDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.StatusComboBox = New System.Windows.Forms.ComboBox()
        No_PeminjamanLabel = New System.Windows.Forms.Label()
        ID_BukuLabel = New System.Windows.Forms.Label()
        Judul_BukuLabel = New System.Windows.Forms.Label()
        NISLabel = New System.Windows.Forms.Label()
        NamaLabel = New System.Windows.Forms.Label()
        KelasLabel = New System.Windows.Forms.Label()
        Tgl_PinjamLabel = New System.Windows.Forms.Label()
        Tgl_KembaliLabel = New System.Windows.Forms.Label()
        StatusLabel = New System.Windows.Forms.Label()
        CType(Me.PerpustakaanDigitalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TablestatusBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TablestatusDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'No_PeminjamanLabel
        '
        No_PeminjamanLabel.AutoSize = True
        No_PeminjamanLabel.Location = New System.Drawing.Point(674, 385)
        No_PeminjamanLabel.Name = "No_PeminjamanLabel"
        No_PeminjamanLabel.Size = New System.Drawing.Size(84, 13)
        No_PeminjamanLabel.TabIndex = 2
        No_PeminjamanLabel.Text = "No Peminjaman:"
        '
        'ID_BukuLabel
        '
        ID_BukuLabel.AutoSize = True
        ID_BukuLabel.Location = New System.Drawing.Point(674, 411)
        ID_BukuLabel.Name = "ID_BukuLabel"
        ID_BukuLabel.Size = New System.Drawing.Size(49, 13)
        ID_BukuLabel.TabIndex = 4
        ID_BukuLabel.Text = "ID Buku:"
        '
        'Judul_BukuLabel
        '
        Judul_BukuLabel.AutoSize = True
        Judul_BukuLabel.Location = New System.Drawing.Point(674, 437)
        Judul_BukuLabel.Name = "Judul_BukuLabel"
        Judul_BukuLabel.Size = New System.Drawing.Size(63, 13)
        Judul_BukuLabel.TabIndex = 6
        Judul_BukuLabel.Text = "Judul Buku:"
        '
        'NISLabel
        '
        NISLabel.AutoSize = True
        NISLabel.Location = New System.Drawing.Point(674, 463)
        NISLabel.Name = "NISLabel"
        NISLabel.Size = New System.Drawing.Size(28, 13)
        NISLabel.TabIndex = 8
        NISLabel.Text = "NIS:"
        '
        'NamaLabel
        '
        NamaLabel.AutoSize = True
        NamaLabel.Location = New System.Drawing.Point(674, 489)
        NamaLabel.Name = "NamaLabel"
        NamaLabel.Size = New System.Drawing.Size(38, 13)
        NamaLabel.TabIndex = 10
        NamaLabel.Text = "Nama:"
        '
        'KelasLabel
        '
        KelasLabel.AutoSize = True
        KelasLabel.Location = New System.Drawing.Point(674, 515)
        KelasLabel.Name = "KelasLabel"
        KelasLabel.Size = New System.Drawing.Size(36, 13)
        KelasLabel.TabIndex = 12
        KelasLabel.Text = "Kelas:"
        '
        'Tgl_PinjamLabel
        '
        Tgl_PinjamLabel.AutoSize = True
        Tgl_PinjamLabel.Location = New System.Drawing.Point(674, 543)
        Tgl_PinjamLabel.Name = "Tgl_PinjamLabel"
        Tgl_PinjamLabel.Size = New System.Drawing.Size(59, 13)
        Tgl_PinjamLabel.TabIndex = 14
        Tgl_PinjamLabel.Text = "Tgl Pinjam:"
        '
        'Tgl_KembaliLabel
        '
        Tgl_KembaliLabel.AutoSize = True
        Tgl_KembaliLabel.Location = New System.Drawing.Point(674, 569)
        Tgl_KembaliLabel.Name = "Tgl_KembaliLabel"
        Tgl_KembaliLabel.Size = New System.Drawing.Size(65, 13)
        Tgl_KembaliLabel.TabIndex = 16
        Tgl_KembaliLabel.Text = "Tgl Kembali:"
        '
        'StatusLabel
        '
        StatusLabel.AutoSize = True
        StatusLabel.Location = New System.Drawing.Point(674, 594)
        StatusLabel.Name = "StatusLabel"
        StatusLabel.Size = New System.Drawing.Size(40, 13)
        StatusLabel.TabIndex = 18
        StatusLabel.Text = "Status:"
        '
        'PerpustakaanDigitalDataSet
        '
        Me.PerpustakaanDigitalDataSet.DataSetName = "PerpustakaanDigitalDataSet"
        Me.PerpustakaanDigitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TablestatusBindingSource
        '
        Me.TablestatusBindingSource.DataMember = "tablestatus"
        Me.TablestatusBindingSource.DataSource = Me.PerpustakaanDigitalDataSet
        '
        'TablestatusTableAdapter
        '
        Me.TablestatusTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tablebukuTableAdapter = Nothing
        Me.TableAdapterManager.tableloginTableAdapter = Nothing
        Me.TableAdapterManager.tablesiswaTableAdapter = Nothing
        Me.TableAdapterManager.tablestatusTableAdapter = Me.TablestatusTableAdapter
        Me.TableAdapterManager.UpdateOrder = Perpustakaan_Digital.PerpustakaanDigitalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TablestatusDataGridView
        '
        Me.TablestatusDataGridView.AllowUserToAddRows = False
        Me.TablestatusDataGridView.AllowUserToDeleteRows = False
        Me.TablestatusDataGridView.AllowUserToResizeColumns = False
        Me.TablestatusDataGridView.AllowUserToResizeRows = False
        Me.TablestatusDataGridView.AutoGenerateColumns = False
        Me.TablestatusDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.TablestatusDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TablestatusDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.TablestatusDataGridView.DataSource = Me.TablestatusBindingSource
        Me.TablestatusDataGridView.Location = New System.Drawing.Point(390, 171)
        Me.TablestatusDataGridView.Name = "TablestatusDataGridView"
        Me.TablestatusDataGridView.Size = New System.Drawing.Size(500, 170)
        Me.TablestatusDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "No_Peminjaman"
        Me.DataGridViewTextBoxColumn1.HeaderText = "No_Peminjaman"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ID_Buku"
        Me.DataGridViewTextBoxColumn2.HeaderText = "ID_Buku"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Judul_Buku"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Judul_Buku"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "NIS"
        Me.DataGridViewTextBoxColumn4.HeaderText = "NIS"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Nama"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Nama"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Kelas"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Kelas"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Tgl_Pinjam"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Tgl_Pinjam"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Tgl_Kembali"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Tgl_Kembali"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Status"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Status"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(335, 85)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cari Data"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(252, 45)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(143, 45)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Cari"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Masukkan No Peminjaman"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(143, 19)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(184, 20)
        Me.TextBox1.TabIndex = 1
        '
        'No_PeminjamanTextBox
        '
        Me.No_PeminjamanTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TablestatusBindingSource, "No_Peminjaman", True))
        Me.No_PeminjamanTextBox.Location = New System.Drawing.Point(764, 382)
        Me.No_PeminjamanTextBox.Name = "No_PeminjamanTextBox"
        Me.No_PeminjamanTextBox.Size = New System.Drawing.Size(200, 20)
        Me.No_PeminjamanTextBox.TabIndex = 3
        '
        'ID_BukuTextBox
        '
        Me.ID_BukuTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TablestatusBindingSource, "ID_Buku", True))
        Me.ID_BukuTextBox.Location = New System.Drawing.Point(764, 408)
        Me.ID_BukuTextBox.Name = "ID_BukuTextBox"
        Me.ID_BukuTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ID_BukuTextBox.TabIndex = 5
        '
        'Judul_BukuTextBox
        '
        Me.Judul_BukuTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TablestatusBindingSource, "Judul_Buku", True))
        Me.Judul_BukuTextBox.Location = New System.Drawing.Point(764, 434)
        Me.Judul_BukuTextBox.Name = "Judul_BukuTextBox"
        Me.Judul_BukuTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Judul_BukuTextBox.TabIndex = 7
        '
        'NISTextBox
        '
        Me.NISTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TablestatusBindingSource, "NIS", True))
        Me.NISTextBox.Location = New System.Drawing.Point(764, 460)
        Me.NISTextBox.Name = "NISTextBox"
        Me.NISTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NISTextBox.TabIndex = 9
        '
        'NamaTextBox
        '
        Me.NamaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TablestatusBindingSource, "Nama", True))
        Me.NamaTextBox.Location = New System.Drawing.Point(764, 486)
        Me.NamaTextBox.Name = "NamaTextBox"
        Me.NamaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NamaTextBox.TabIndex = 11
        '
        'KelasComboBox
        '
        Me.KelasComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TablestatusBindingSource, "Kelas", True))
        Me.KelasComboBox.FormattingEnabled = True
        Me.KelasComboBox.Location = New System.Drawing.Point(764, 512)
        Me.KelasComboBox.Name = "KelasComboBox"
        Me.KelasComboBox.Size = New System.Drawing.Size(200, 21)
        Me.KelasComboBox.TabIndex = 13
        '
        'Tgl_PinjamDateTimePicker
        '
        Me.Tgl_PinjamDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TablestatusBindingSource, "Tgl_Pinjam", True))
        Me.Tgl_PinjamDateTimePicker.Location = New System.Drawing.Point(764, 539)
        Me.Tgl_PinjamDateTimePicker.Name = "Tgl_PinjamDateTimePicker"
        Me.Tgl_PinjamDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Tgl_PinjamDateTimePicker.TabIndex = 15
        '
        'Tgl_KembaliDateTimePicker
        '
        Me.Tgl_KembaliDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TablestatusBindingSource, "Tgl_Kembali", True))
        Me.Tgl_KembaliDateTimePicker.Location = New System.Drawing.Point(764, 565)
        Me.Tgl_KembaliDateTimePicker.Name = "Tgl_KembaliDateTimePicker"
        Me.Tgl_KembaliDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Tgl_KembaliDateTimePicker.TabIndex = 17
        '
        'StatusComboBox
        '
        Me.StatusComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TablestatusBindingSource, "Status", True))
        Me.StatusComboBox.FormattingEnabled = True
        Me.StatusComboBox.Location = New System.Drawing.Point(764, 591)
        Me.StatusComboBox.Name = "StatusComboBox"
        Me.StatusComboBox.Size = New System.Drawing.Size(200, 21)
        Me.StatusComboBox.TabIndex = 19
        '
        'FormCariTrans
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(365, 108)
        Me.Controls.Add(No_PeminjamanLabel)
        Me.Controls.Add(Me.No_PeminjamanTextBox)
        Me.Controls.Add(ID_BukuLabel)
        Me.Controls.Add(Me.ID_BukuTextBox)
        Me.Controls.Add(Judul_BukuLabel)
        Me.Controls.Add(Me.Judul_BukuTextBox)
        Me.Controls.Add(NISLabel)
        Me.Controls.Add(Me.NISTextBox)
        Me.Controls.Add(NamaLabel)
        Me.Controls.Add(Me.NamaTextBox)
        Me.Controls.Add(KelasLabel)
        Me.Controls.Add(Me.KelasComboBox)
        Me.Controls.Add(Tgl_PinjamLabel)
        Me.Controls.Add(Me.Tgl_PinjamDateTimePicker)
        Me.Controls.Add(Tgl_KembaliLabel)
        Me.Controls.Add(Me.Tgl_KembaliDateTimePicker)
        Me.Controls.Add(StatusLabel)
        Me.Controls.Add(Me.StatusComboBox)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TablestatusDataGridView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormCariTrans"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Cari Transaksi"
        CType(Me.PerpustakaanDigitalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TablestatusBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TablestatusDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PerpustakaanDigitalDataSet As Perpustakaan_Digital.PerpustakaanDigitalDataSet
    Friend WithEvents TablestatusBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TablestatusTableAdapter As Perpustakaan_Digital.PerpustakaanDigitalDataSetTableAdapters.tablestatusTableAdapter
    Friend WithEvents TableAdapterManager As Perpustakaan_Digital.PerpustakaanDigitalDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TablestatusDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents No_PeminjamanTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ID_BukuTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Judul_BukuTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NISTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NamaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents KelasComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Tgl_PinjamDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Tgl_KembaliDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents StatusComboBox As System.Windows.Forms.ComboBox
End Class
