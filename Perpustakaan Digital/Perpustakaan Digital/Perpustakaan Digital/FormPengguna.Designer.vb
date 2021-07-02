<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPengguna
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
        Dim UsernameLabel As System.Windows.Forms.Label
        Dim PasswordLabel As System.Windows.Forms.Label
        Dim AdminLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPengguna))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.PerpustakaanDigitalDataSet = New Perpustakaan_Digital.PerpustakaanDigitalDataSet()
        Me.TableloginBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableloginTableAdapter = New Perpustakaan_Digital.PerpustakaanDigitalDataSetTableAdapters.tableloginTableAdapter()
        Me.TableAdapterManager = New Perpustakaan_Digital.PerpustakaanDigitalDataSetTableAdapters.TableAdapterManager()
        Me.TableloginDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.AdminCheckBox = New System.Windows.Forms.CheckBox()
        Me.btntambah = New System.Windows.Forms.Button()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.btnhapus = New System.Windows.Forms.Button()
        Me.btnkembali = New System.Windows.Forms.Button()
        UsernameLabel = New System.Windows.Forms.Label()
        PasswordLabel = New System.Windows.Forms.Label()
        AdminLabel = New System.Windows.Forms.Label()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.PerpustakaanDigitalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TableloginBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TableloginDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'UsernameLabel
        '
        UsernameLabel.AutoSize = True
        UsernameLabel.Location = New System.Drawing.Point(6, 22)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New System.Drawing.Size(58, 13)
        UsernameLabel.TabIndex = 0
        UsernameLabel.Text = "Username:"
        '
        'PasswordLabel
        '
        PasswordLabel.AutoSize = True
        PasswordLabel.Location = New System.Drawing.Point(6, 48)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New System.Drawing.Size(56, 13)
        PasswordLabel.TabIndex = 2
        PasswordLabel.Text = "Password:"
        '
        'AdminLabel
        '
        AdminLabel.AutoSize = True
        AdminLabel.Location = New System.Drawing.Point(6, 76)
        AdminLabel.Name = "AdminLabel"
        AdminLabel.Size = New System.Drawing.Size(39, 13)
        AdminLabel.TabIndex = 4
        AdminLabel.Text = "Admin:"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 295)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(444, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(259, 17)
        Me.ToolStripStatusLabel1.Text = "©2016 Perpustakaan Digital. All Rights Reserved"
        '
        'PerpustakaanDigitalDataSet
        '
        Me.PerpustakaanDigitalDataSet.DataSetName = "PerpustakaanDigitalDataSet"
        Me.PerpustakaanDigitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TableloginBindingSource
        '
        Me.TableloginBindingSource.DataMember = "tablelogin"
        Me.TableloginBindingSource.DataSource = Me.PerpustakaanDigitalDataSet
        '
        'TableloginTableAdapter
        '
        Me.TableloginTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tablebukuTableAdapter = Nothing
        Me.TableAdapterManager.tableloginTableAdapter = Me.TableloginTableAdapter
        Me.TableAdapterManager.tablesiswaTableAdapter = Nothing
        Me.TableAdapterManager.tablestatusTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Perpustakaan_Digital.PerpustakaanDigitalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TableloginDataGridView
        '
        Me.TableloginDataGridView.AllowUserToAddRows = False
        Me.TableloginDataGridView.AllowUserToDeleteRows = False
        Me.TableloginDataGridView.AllowUserToResizeColumns = False
        Me.TableloginDataGridView.AllowUserToResizeRows = False
        Me.TableloginDataGridView.AutoGenerateColumns = False
        Me.TableloginDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.TableloginDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TableloginDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewCheckBoxColumn1})
        Me.TableloginDataGridView.DataSource = Me.TableloginBindingSource
        Me.TableloginDataGridView.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableloginDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.TableloginDataGridView.Name = "TableloginDataGridView"
        Me.TableloginDataGridView.Size = New System.Drawing.Size(444, 140)
        Me.TableloginDataGridView.TabIndex = 2
        Me.TableloginDataGridView.TabStop = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Username"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Username"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Password"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Password"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "Admin"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Admin"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btncancel)
        Me.GroupBox1.Controls.Add(Me.btnsimpan)
        Me.GroupBox1.Controls.Add(UsernameLabel)
        Me.GroupBox1.Controls.Add(Me.UsernameTextBox)
        Me.GroupBox1.Controls.Add(PasswordLabel)
        Me.GroupBox1.Controls.Add(Me.PasswordTextBox)
        Me.GroupBox1.Controls.Add(AdminLabel)
        Me.GroupBox1.Controls.Add(Me.AdminCheckBox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 146)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(185, 146)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Input"
        '
        'btncancel
        '
        Me.btncancel.Enabled = False
        Me.btncancel.Image = Global.Perpustakaan_Digital.My.Resources.Resources.block
        Me.btncancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btncancel.Location = New System.Drawing.Point(104, 117)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(75, 23)
        Me.btncancel.TabIndex = 7
        Me.btncancel.Text = "Cancel"
        Me.btncancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'btnsimpan
        '
        Me.btnsimpan.Enabled = False
        Me.btnsimpan.Image = Global.Perpustakaan_Digital.My.Resources.Resources.accept
        Me.btnsimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnsimpan.Location = New System.Drawing.Point(6, 117)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(75, 23)
        Me.btnsimpan.TabIndex = 6
        Me.btnsimpan.Text = "Simpan"
        Me.btnsimpan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnsimpan.UseVisualStyleBackColor = True
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableloginBindingSource, "Username", True))
        Me.UsernameTextBox.Enabled = False
        Me.UsernameTextBox.Location = New System.Drawing.Point(70, 19)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(104, 20)
        Me.UsernameTextBox.TabIndex = 1
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableloginBindingSource, "Password", True))
        Me.PasswordTextBox.Enabled = False
        Me.PasswordTextBox.Location = New System.Drawing.Point(70, 45)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(104, 20)
        Me.PasswordTextBox.TabIndex = 3
        '
        'AdminCheckBox
        '
        Me.AdminCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.TableloginBindingSource, "Admin", True))
        Me.AdminCheckBox.Enabled = False
        Me.AdminCheckBox.Location = New System.Drawing.Point(70, 71)
        Me.AdminCheckBox.Name = "AdminCheckBox"
        Me.AdminCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.AdminCheckBox.TabIndex = 5
        Me.AdminCheckBox.Text = "Yes"
        Me.AdminCheckBox.UseVisualStyleBackColor = True
        '
        'btntambah
        '
        Me.btntambah.Image = Global.Perpustakaan_Digital.My.Resources.Resources.add
        Me.btntambah.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btntambah.Location = New System.Drawing.Point(282, 146)
        Me.btntambah.Name = "btntambah"
        Me.btntambah.Size = New System.Drawing.Size(150, 23)
        Me.btntambah.TabIndex = 4
        Me.btntambah.Text = "Tambah"
        Me.btntambah.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btntambah.UseVisualStyleBackColor = True
        '
        'btnedit
        '
        Me.btnedit.Image = Global.Perpustakaan_Digital.My.Resources.Resources.favicon__3_
        Me.btnedit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnedit.Location = New System.Drawing.Point(282, 175)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(150, 23)
        Me.btnedit.TabIndex = 5
        Me.btnedit.Text = "Edit"
        Me.btnedit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnedit.UseVisualStyleBackColor = True
        '
        'btnhapus
        '
        Me.btnhapus.Image = Global.Perpustakaan_Digital.My.Resources.Resources.delete
        Me.btnhapus.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnhapus.Location = New System.Drawing.Point(282, 204)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(150, 23)
        Me.btnhapus.TabIndex = 6
        Me.btnhapus.Text = "Hapus"
        Me.btnhapus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnhapus.UseVisualStyleBackColor = True
        '
        'btnkembali
        '
        Me.btnkembali.Image = Global.Perpustakaan_Digital.My.Resources.Resources.back
        Me.btnkembali.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnkembali.Location = New System.Drawing.Point(357, 263)
        Me.btnkembali.Name = "btnkembali"
        Me.btnkembali.Size = New System.Drawing.Size(75, 23)
        Me.btnkembali.TabIndex = 7
        Me.btnkembali.Text = "Kembali"
        Me.btnkembali.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnkembali.UseVisualStyleBackColor = True
        '
        'FormPengguna
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(444, 317)
        Me.Controls.Add(Me.btnkembali)
        Me.Controls.Add(Me.btnhapus)
        Me.Controls.Add(Me.btnedit)
        Me.Controls.Add(Me.btntambah)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TableloginDataGridView)
        Me.Controls.Add(Me.StatusStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FormPengguna"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Pengguna (Pustakawan)"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.PerpustakaanDigitalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TableloginBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TableloginDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents PerpustakaanDigitalDataSet As Perpustakaan_Digital.PerpustakaanDigitalDataSet
    Friend WithEvents TableloginBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TableloginTableAdapter As Perpustakaan_Digital.PerpustakaanDigitalDataSetTableAdapters.tableloginTableAdapter
    Friend WithEvents TableAdapterManager As Perpustakaan_Digital.PerpustakaanDigitalDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TableloginDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents btnsimpan As System.Windows.Forms.Button
    Friend WithEvents UsernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AdminCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents btntambah As System.Windows.Forms.Button
    Friend WithEvents btnedit As System.Windows.Forms.Button
    Friend WithEvents btnhapus As System.Windows.Forms.Button
    Friend WithEvents btnkembali As System.Windows.Forms.Button
End Class
