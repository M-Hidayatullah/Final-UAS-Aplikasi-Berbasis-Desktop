<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCariBuku
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCariBuku))
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ID_BukuTextBox = New System.Windows.Forms.TextBox()
        Me.Judul_BukuTextBox = New System.Windows.Forms.TextBox()
        Me.PenulisTextBox = New System.Windows.Forms.TextBox()
        Me.PenerbitTextBox = New System.Windows.Forms.TextBox()
        Me.Tahun_TerbitTextBox = New System.Windows.Forms.TextBox()
        ID_BukuLabel = New System.Windows.Forms.Label()
        Judul_BukuLabel = New System.Windows.Forms.Label()
        PenulisLabel = New System.Windows.Forms.Label()
        PenerbitLabel = New System.Windows.Forms.Label()
        Tahun_TerbitLabel = New System.Windows.Forms.Label()
        CType(Me.PerpustakaanDigitalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TablebukuBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TablebukuDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ID_BukuLabel
        '
        ID_BukuLabel.AutoSize = True
        ID_BukuLabel.Location = New System.Drawing.Point(671, 387)
        ID_BukuLabel.Name = "ID_BukuLabel"
        ID_BukuLabel.Size = New System.Drawing.Size(49, 13)
        ID_BukuLabel.TabIndex = 2
        ID_BukuLabel.Text = "ID Buku:"
        '
        'Judul_BukuLabel
        '
        Judul_BukuLabel.AutoSize = True
        Judul_BukuLabel.Location = New System.Drawing.Point(671, 413)
        Judul_BukuLabel.Name = "Judul_BukuLabel"
        Judul_BukuLabel.Size = New System.Drawing.Size(63, 13)
        Judul_BukuLabel.TabIndex = 4
        Judul_BukuLabel.Text = "Judul Buku:"
        '
        'PenulisLabel
        '
        PenulisLabel.AutoSize = True
        PenulisLabel.Location = New System.Drawing.Point(671, 439)
        PenulisLabel.Name = "PenulisLabel"
        PenulisLabel.Size = New System.Drawing.Size(44, 13)
        PenulisLabel.TabIndex = 6
        PenulisLabel.Text = "Penulis:"
        '
        'PenerbitLabel
        '
        PenerbitLabel.AutoSize = True
        PenerbitLabel.Location = New System.Drawing.Point(671, 465)
        PenerbitLabel.Name = "PenerbitLabel"
        PenerbitLabel.Size = New System.Drawing.Size(49, 13)
        PenerbitLabel.TabIndex = 8
        PenerbitLabel.Text = "Penerbit:"
        '
        'Tahun_TerbitLabel
        '
        Tahun_TerbitLabel.AutoSize = True
        Tahun_TerbitLabel.Location = New System.Drawing.Point(671, 491)
        Tahun_TerbitLabel.Name = "Tahun_TerbitLabel"
        Tahun_TerbitLabel.Size = New System.Drawing.Size(71, 13)
        Tahun_TerbitLabel.TabIndex = 10
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
        Me.TablebukuDataGridView.Dock = System.Windows.Forms.DockStyle.Top
        Me.TablebukuDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.TablebukuDataGridView.Name = "TablebukuDataGridView"
        Me.TablebukuDataGridView.Size = New System.Drawing.Size(790, 220)
        Me.TablebukuDataGridView.TabIndex = 1
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
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 226)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(250, 105)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cari Data"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(169, 76)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(6, 76)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Pilih"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Cari Berdasarkan"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(100, 46)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(144, 20)
        Me.TextBox1.TabIndex = 1
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"ID_Buku", "Judul_Buku", "Penulis", "Penerbit", "Tahun_Terbit"})
        Me.ComboBox1.Location = New System.Drawing.Point(100, 19)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(144, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'ID_BukuTextBox
        '
        Me.ID_BukuTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TablebukuBindingSource, "ID_Buku", True))
        Me.ID_BukuTextBox.Location = New System.Drawing.Point(748, 384)
        Me.ID_BukuTextBox.Name = "ID_BukuTextBox"
        Me.ID_BukuTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ID_BukuTextBox.TabIndex = 3
        '
        'Judul_BukuTextBox
        '
        Me.Judul_BukuTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TablebukuBindingSource, "Judul_Buku", True))
        Me.Judul_BukuTextBox.Location = New System.Drawing.Point(748, 410)
        Me.Judul_BukuTextBox.Name = "Judul_BukuTextBox"
        Me.Judul_BukuTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Judul_BukuTextBox.TabIndex = 5
        '
        'PenulisTextBox
        '
        Me.PenulisTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TablebukuBindingSource, "Penulis", True))
        Me.PenulisTextBox.Location = New System.Drawing.Point(748, 436)
        Me.PenulisTextBox.Name = "PenulisTextBox"
        Me.PenulisTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PenulisTextBox.TabIndex = 7
        '
        'PenerbitTextBox
        '
        Me.PenerbitTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TablebukuBindingSource, "Penerbit", True))
        Me.PenerbitTextBox.Location = New System.Drawing.Point(748, 462)
        Me.PenerbitTextBox.Name = "PenerbitTextBox"
        Me.PenerbitTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PenerbitTextBox.TabIndex = 9
        '
        'Tahun_TerbitTextBox
        '
        Me.Tahun_TerbitTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TablebukuBindingSource, "Tahun_Terbit", True))
        Me.Tahun_TerbitTextBox.Location = New System.Drawing.Point(748, 488)
        Me.Tahun_TerbitTextBox.Name = "Tahun_TerbitTextBox"
        Me.Tahun_TerbitTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Tahun_TerbitTextBox.TabIndex = 11
        '
        'FormCariBuku
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(790, 343)
        Me.Controls.Add(ID_BukuLabel)
        Me.Controls.Add(Me.ID_BukuTextBox)
        Me.Controls.Add(Judul_BukuLabel)
        Me.Controls.Add(Me.Judul_BukuTextBox)
        Me.Controls.Add(PenulisLabel)
        Me.Controls.Add(Me.PenulisTextBox)
        Me.Controls.Add(PenerbitLabel)
        Me.Controls.Add(Me.PenerbitTextBox)
        Me.Controls.Add(Tahun_TerbitLabel)
        Me.Controls.Add(Me.Tahun_TerbitTextBox)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TablebukuDataGridView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormCariBuku"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Cari Buku"
        CType(Me.PerpustakaanDigitalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TablebukuBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TablebukuDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ID_BukuTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Judul_BukuTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PenulisTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PenerbitTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Tahun_TerbitTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
