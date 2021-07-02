<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTransPinjam
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormTransPinjam))
        Me.No_PeminjamanTextBox = New System.Windows.Forms.TextBox()
        Me.TablestatusBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PerpustakaanDigitalDataSet = New Perpustakaan_Digital.PerpustakaanDigitalDataSet()
        Me.ID_BukuTextBox = New System.Windows.Forms.TextBox()
        Me.Judul_BukuTextBox = New System.Windows.Forms.TextBox()
        Me.NISTextBox = New System.Windows.Forms.TextBox()
        Me.NamaTextBox = New System.Windows.Forms.TextBox()
        Me.KelasComboBox = New System.Windows.Forms.ComboBox()
        Me.Tgl_PinjamDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Tgl_KembaliDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.StatusComboBox = New System.Windows.Forms.ComboBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TablestatusTableAdapter = New Perpustakaan_Digital.PerpustakaanDigitalDataSetTableAdapters.tablestatusTableAdapter()
        Me.TableAdapterManager = New Perpustakaan_Digital.PerpustakaanDigitalDataSetTableAdapters.TableAdapterManager()
        No_PeminjamanLabel = New System.Windows.Forms.Label()
        ID_BukuLabel = New System.Windows.Forms.Label()
        Judul_BukuLabel = New System.Windows.Forms.Label()
        NISLabel = New System.Windows.Forms.Label()
        NamaLabel = New System.Windows.Forms.Label()
        KelasLabel = New System.Windows.Forms.Label()
        Tgl_PinjamLabel = New System.Windows.Forms.Label()
        Tgl_KembaliLabel = New System.Windows.Forms.Label()
        StatusLabel = New System.Windows.Forms.Label()
        CType(Me.TablestatusBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PerpustakaanDigitalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'No_PeminjamanLabel
        '
        No_PeminjamanLabel.AutoSize = True
        No_PeminjamanLabel.Location = New System.Drawing.Point(12, 15)
        No_PeminjamanLabel.Name = "No_PeminjamanLabel"
        No_PeminjamanLabel.Size = New System.Drawing.Size(84, 13)
        No_PeminjamanLabel.TabIndex = 1
        No_PeminjamanLabel.Text = "No Peminjaman:"
        '
        'ID_BukuLabel
        '
        ID_BukuLabel.AutoSize = True
        ID_BukuLabel.Location = New System.Drawing.Point(12, 41)
        ID_BukuLabel.Name = "ID_BukuLabel"
        ID_BukuLabel.Size = New System.Drawing.Size(49, 13)
        ID_BukuLabel.TabIndex = 3
        ID_BukuLabel.Text = "ID Buku:"
        '
        'Judul_BukuLabel
        '
        Judul_BukuLabel.AutoSize = True
        Judul_BukuLabel.Location = New System.Drawing.Point(12, 67)
        Judul_BukuLabel.Name = "Judul_BukuLabel"
        Judul_BukuLabel.Size = New System.Drawing.Size(63, 13)
        Judul_BukuLabel.TabIndex = 5
        Judul_BukuLabel.Text = "Judul Buku:"
        '
        'NISLabel
        '
        NISLabel.AutoSize = True
        NISLabel.Location = New System.Drawing.Point(12, 93)
        NISLabel.Name = "NISLabel"
        NISLabel.Size = New System.Drawing.Size(28, 13)
        NISLabel.TabIndex = 7
        NISLabel.Text = "NIS:"
        '
        'NamaLabel
        '
        NamaLabel.AutoSize = True
        NamaLabel.Location = New System.Drawing.Point(12, 119)
        NamaLabel.Name = "NamaLabel"
        NamaLabel.Size = New System.Drawing.Size(38, 13)
        NamaLabel.TabIndex = 9
        NamaLabel.Text = "Nama:"
        '
        'KelasLabel
        '
        KelasLabel.AutoSize = True
        KelasLabel.Location = New System.Drawing.Point(12, 145)
        KelasLabel.Name = "KelasLabel"
        KelasLabel.Size = New System.Drawing.Size(36, 13)
        KelasLabel.TabIndex = 11
        KelasLabel.Text = "Kelas:"
        '
        'Tgl_PinjamLabel
        '
        Tgl_PinjamLabel.AutoSize = True
        Tgl_PinjamLabel.Location = New System.Drawing.Point(12, 173)
        Tgl_PinjamLabel.Name = "Tgl_PinjamLabel"
        Tgl_PinjamLabel.Size = New System.Drawing.Size(59, 13)
        Tgl_PinjamLabel.TabIndex = 13
        Tgl_PinjamLabel.Text = "Tgl Pinjam:"
        '
        'Tgl_KembaliLabel
        '
        Tgl_KembaliLabel.AutoSize = True
        Tgl_KembaliLabel.Location = New System.Drawing.Point(12, 199)
        Tgl_KembaliLabel.Name = "Tgl_KembaliLabel"
        Tgl_KembaliLabel.Size = New System.Drawing.Size(65, 13)
        Tgl_KembaliLabel.TabIndex = 15
        Tgl_KembaliLabel.Text = "Tgl Kembali:"
        '
        'StatusLabel
        '
        StatusLabel.AutoSize = True
        StatusLabel.Location = New System.Drawing.Point(12, 224)
        StatusLabel.Name = "StatusLabel"
        StatusLabel.Size = New System.Drawing.Size(40, 13)
        StatusLabel.TabIndex = 16
        StatusLabel.Text = "Status:"
        '
        'No_PeminjamanTextBox
        '
        Me.No_PeminjamanTextBox.BackColor = System.Drawing.SystemColors.Info
        Me.No_PeminjamanTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TablestatusBindingSource, "No_Peminjaman", True))
        Me.No_PeminjamanTextBox.Enabled = False
        Me.No_PeminjamanTextBox.Location = New System.Drawing.Point(102, 12)
        Me.No_PeminjamanTextBox.Name = "No_PeminjamanTextBox"
        Me.No_PeminjamanTextBox.Size = New System.Drawing.Size(200, 20)
        Me.No_PeminjamanTextBox.TabIndex = 2
        '
        'TablestatusBindingSource
        '
        Me.TablestatusBindingSource.DataMember = "tablestatus"
        Me.TablestatusBindingSource.DataSource = Me.PerpustakaanDigitalDataSet
        '
        'PerpustakaanDigitalDataSet
        '
        Me.PerpustakaanDigitalDataSet.DataSetName = "PerpustakaanDigitalDataSet"
        Me.PerpustakaanDigitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ID_BukuTextBox
        '
        Me.ID_BukuTextBox.BackColor = System.Drawing.SystemColors.Info
        Me.ID_BukuTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TablestatusBindingSource, "ID_Buku", True))
        Me.ID_BukuTextBox.Enabled = False
        Me.ID_BukuTextBox.Location = New System.Drawing.Point(102, 38)
        Me.ID_BukuTextBox.Name = "ID_BukuTextBox"
        Me.ID_BukuTextBox.Size = New System.Drawing.Size(150, 20)
        Me.ID_BukuTextBox.TabIndex = 4
        '
        'Judul_BukuTextBox
        '
        Me.Judul_BukuTextBox.BackColor = System.Drawing.SystemColors.Info
        Me.Judul_BukuTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TablestatusBindingSource, "Judul_Buku", True))
        Me.Judul_BukuTextBox.Enabled = False
        Me.Judul_BukuTextBox.Location = New System.Drawing.Point(102, 64)
        Me.Judul_BukuTextBox.Name = "Judul_BukuTextBox"
        Me.Judul_BukuTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Judul_BukuTextBox.TabIndex = 6
        '
        'NISTextBox
        '
        Me.NISTextBox.BackColor = System.Drawing.SystemColors.Info
        Me.NISTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TablestatusBindingSource, "NIS", True))
        Me.NISTextBox.Enabled = False
        Me.NISTextBox.Location = New System.Drawing.Point(102, 90)
        Me.NISTextBox.Name = "NISTextBox"
        Me.NISTextBox.Size = New System.Drawing.Size(150, 20)
        Me.NISTextBox.TabIndex = 8
        '
        'NamaTextBox
        '
        Me.NamaTextBox.BackColor = System.Drawing.SystemColors.Info
        Me.NamaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TablestatusBindingSource, "Nama", True))
        Me.NamaTextBox.Enabled = False
        Me.NamaTextBox.Location = New System.Drawing.Point(102, 116)
        Me.NamaTextBox.Name = "NamaTextBox"
        Me.NamaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NamaTextBox.TabIndex = 10
        '
        'KelasComboBox
        '
        Me.KelasComboBox.BackColor = System.Drawing.SystemColors.Info
        Me.KelasComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TablestatusBindingSource, "Kelas", True))
        Me.KelasComboBox.Enabled = False
        Me.KelasComboBox.FormattingEnabled = True
        Me.KelasComboBox.Location = New System.Drawing.Point(102, 142)
        Me.KelasComboBox.Name = "KelasComboBox"
        Me.KelasComboBox.Size = New System.Drawing.Size(200, 21)
        Me.KelasComboBox.TabIndex = 12
        '
        'Tgl_PinjamDateTimePicker
        '
        Me.Tgl_PinjamDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TablestatusBindingSource, "Tgl_Pinjam", True))
        Me.Tgl_PinjamDateTimePicker.Enabled = False
        Me.Tgl_PinjamDateTimePicker.Location = New System.Drawing.Point(102, 169)
        Me.Tgl_PinjamDateTimePicker.Name = "Tgl_PinjamDateTimePicker"
        Me.Tgl_PinjamDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Tgl_PinjamDateTimePicker.TabIndex = 14
        '
        'Tgl_KembaliDateTimePicker
        '
        Me.Tgl_KembaliDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TablestatusBindingSource, "Tgl_Kembali", True))
        Me.Tgl_KembaliDateTimePicker.Enabled = False
        Me.Tgl_KembaliDateTimePicker.Location = New System.Drawing.Point(102, 195)
        Me.Tgl_KembaliDateTimePicker.Name = "Tgl_KembaliDateTimePicker"
        Me.Tgl_KembaliDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Tgl_KembaliDateTimePicker.TabIndex = 16
        '
        'StatusComboBox
        '
        Me.StatusComboBox.BackColor = System.Drawing.SystemColors.Info
        Me.StatusComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TablestatusBindingSource, "Status", True))
        Me.StatusComboBox.Enabled = False
        Me.StatusComboBox.FormattingEnabled = True
        Me.StatusComboBox.Items.AddRange(New Object() {"Dalam Peminjaman", "Sudah Dikembalikan"})
        Me.StatusComboBox.Location = New System.Drawing.Point(102, 221)
        Me.StatusComboBox.Name = "StatusComboBox"
        Me.StatusComboBox.Size = New System.Drawing.Size(200, 21)
        Me.StatusComboBox.TabIndex = 17
        Me.StatusComboBox.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(146, 248)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 20
        Me.Button3.Text = "Simpan"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(227, 248)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 21
        Me.Button4.Text = "Cancel"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Image = Global.Perpustakaan_Digital.My.Resources.Resources.favicon__9_
        Me.Button2.Location = New System.Drawing.Point(258, 90)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(44, 20)
        Me.Button2.TabIndex = 19
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = Global.Perpustakaan_Digital.My.Resources.Resources.favicon__9_
        Me.Button1.Location = New System.Drawing.Point(258, 38)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(44, 20)
        Me.Button1.TabIndex = 18
        Me.Button1.UseVisualStyleBackColor = True
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
        'FormTransPinjam
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(314, 292)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(StatusLabel)
        Me.Controls.Add(Me.StatusComboBox)
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
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormTransPinjam"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Transaksi Pinjam"
        CType(Me.TablestatusBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PerpustakaanDigitalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PerpustakaanDigitalDataSet As Perpustakaan_Digital.PerpustakaanDigitalDataSet
    Friend WithEvents TablestatusBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TablestatusTableAdapter As Perpustakaan_Digital.PerpustakaanDigitalDataSetTableAdapters.tablestatusTableAdapter
    Friend WithEvents TableAdapterManager As Perpustakaan_Digital.PerpustakaanDigitalDataSetTableAdapters.TableAdapterManager
    Friend WithEvents No_PeminjamanTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ID_BukuTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Judul_BukuTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NISTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NamaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents KelasComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Tgl_PinjamDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Tgl_KembaliDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents StatusComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
End Class
