<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCariSiswa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCariSiswa))
        Me.PerpustakaanDigitalDataSet = New Perpustakaan_Digital.PerpustakaanDigitalDataSet()
        Me.TablesiswaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TablesiswaTableAdapter = New Perpustakaan_Digital.PerpustakaanDigitalDataSetTableAdapters.tablesiswaTableAdapter()
        Me.TableAdapterManager = New Perpustakaan_Digital.PerpustakaanDigitalDataSetTableAdapters.TableAdapterManager()
        Me.TablesiswaDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NISTextBox = New System.Windows.Forms.TextBox()
        Me.NamaTextBox = New System.Windows.Forms.TextBox()
        Me.KelasTextBox = New System.Windows.Forms.TextBox()
        NISLabel = New System.Windows.Forms.Label()
        NamaLabel = New System.Windows.Forms.Label()
        KelasLabel = New System.Windows.Forms.Label()
        CType(Me.PerpustakaanDigitalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TablesiswaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TablesiswaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'NISLabel
        '
        NISLabel.AutoSize = True
        NISLabel.Location = New System.Drawing.Point(809, 272)
        NISLabel.Name = "NISLabel"
        NISLabel.Size = New System.Drawing.Size(28, 13)
        NISLabel.TabIndex = 2
        NISLabel.Text = "NIS:"
        '
        'NamaLabel
        '
        NamaLabel.AutoSize = True
        NamaLabel.Location = New System.Drawing.Point(809, 298)
        NamaLabel.Name = "NamaLabel"
        NamaLabel.Size = New System.Drawing.Size(38, 13)
        NamaLabel.TabIndex = 4
        NamaLabel.Text = "Nama:"
        '
        'KelasLabel
        '
        KelasLabel.AutoSize = True
        KelasLabel.Location = New System.Drawing.Point(809, 324)
        KelasLabel.Name = "KelasLabel"
        KelasLabel.Size = New System.Drawing.Size(36, 13)
        KelasLabel.TabIndex = 6
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
        Me.TablesiswaDataGridView.Dock = System.Windows.Forms.DockStyle.Top
        Me.TablesiswaDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.TablesiswaDataGridView.Name = "TablesiswaDataGridView"
        Me.TablesiswaDataGridView.Size = New System.Drawing.Size(790, 220)
        Me.TablesiswaDataGridView.TabIndex = 1
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 226)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(260, 105)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cari Data"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(179, 76)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(100, 46)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(154, 20)
        Me.TextBox1.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(9, 76)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Pilih"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"NIS", "Nama", "Kelas"})
        Me.ComboBox1.Location = New System.Drawing.Point(100, 19)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(154, 21)
        Me.ComboBox1.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Cari Berdasarkan"
        '
        'NISTextBox
        '
        Me.NISTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TablesiswaBindingSource, "NIS", True))
        Me.NISTextBox.Location = New System.Drawing.Point(853, 269)
        Me.NISTextBox.Name = "NISTextBox"
        Me.NISTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NISTextBox.TabIndex = 3
        '
        'NamaTextBox
        '
        Me.NamaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TablesiswaBindingSource, "Nama", True))
        Me.NamaTextBox.Location = New System.Drawing.Point(853, 295)
        Me.NamaTextBox.Name = "NamaTextBox"
        Me.NamaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NamaTextBox.TabIndex = 5
        '
        'KelasTextBox
        '
        Me.KelasTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TablesiswaBindingSource, "Kelas", True))
        Me.KelasTextBox.Location = New System.Drawing.Point(853, 321)
        Me.KelasTextBox.Name = "KelasTextBox"
        Me.KelasTextBox.Size = New System.Drawing.Size(100, 20)
        Me.KelasTextBox.TabIndex = 7
        '
        'FormCariSiswa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(790, 343)
        Me.Controls.Add(NISLabel)
        Me.Controls.Add(Me.NISTextBox)
        Me.Controls.Add(NamaLabel)
        Me.Controls.Add(Me.NamaTextBox)
        Me.Controls.Add(KelasLabel)
        Me.Controls.Add(Me.KelasTextBox)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TablesiswaDataGridView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormCariSiswa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Cari Siswa"
        CType(Me.PerpustakaanDigitalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TablesiswaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TablesiswaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PerpustakaanDigitalDataSet As Perpustakaan_Digital.PerpustakaanDigitalDataSet
    Friend WithEvents TablesiswaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TablesiswaTableAdapter As Perpustakaan_Digital.PerpustakaanDigitalDataSetTableAdapters.tablesiswaTableAdapter
    Friend WithEvents TableAdapterManager As Perpustakaan_Digital.PerpustakaanDigitalDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TablesiswaDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents NISTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NamaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents KelasTextBox As System.Windows.Forms.TextBox
End Class
