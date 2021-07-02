<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTransaksi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormTransaksi))
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
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        CType(Me.PerpustakaanDigitalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TablestatusBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TablestatusDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.TablestatusDataGridView.Dock = System.Windows.Forms.DockStyle.Top
        Me.TablestatusDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.TablestatusDataGridView.Name = "TablestatusDataGridView"
        Me.TablestatusDataGridView.Size = New System.Drawing.Size(1370, 669)
        Me.TablestatusDataGridView.TabIndex = 0
        Me.TablestatusDataGridView.TabStop = False
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
        'Button3
        '
        Me.Button3.Image = Global.Perpustakaan_Digital.My.Resources.Resources.back
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.Location = New System.Drawing.Point(324, 675)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 52)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Kembali"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Image = Global.Perpustakaan_Digital.My.Resources.Resources.favicon__6_
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.Location = New System.Drawing.Point(168, 675)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(150, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Transaksi Pengembalian"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = Global.Perpustakaan_Digital.My.Resources.Resources.favicon__6_
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(12, 675)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(150, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Transaksi Peminjaman"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Image = Global.Perpustakaan_Digital.My.Resources.Resources.delete
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.Location = New System.Drawing.Point(12, 704)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(306, 23)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Hapus Transaksi"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'FormTransaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 756)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TablestatusDataGridView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormTransaksi"
        Me.Text = "Form Transaksi"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PerpustakaanDigitalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TablestatusBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TablestatusDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

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
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
End Class
