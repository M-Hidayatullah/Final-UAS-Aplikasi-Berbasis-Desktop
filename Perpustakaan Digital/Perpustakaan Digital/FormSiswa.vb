Public Class FormSiswa

    Private Sub Form3_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        If e.Cancel = True Then
            End
        End If
    End Sub

    Private Sub TablesiswaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.TablesiswaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PerpustakaanDigitalDataSet)

    End Sub

    Private Sub FormSiswa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PerpustakaanDigitalDataSet.tablesiswa' table. You can move, or remove it, as needed.
        Me.TablesiswaTableAdapter.Fill(Me.PerpustakaanDigitalDataSet.tablesiswa)

    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            KelasComboBox.Items.Clear()
            KelasComboBox.Items.Add("X Transmisi")
            KelasComboBox.Items.Add("X Suitsing")
            KelasComboBox.Items.Add("X RPL 1")
            KelasComboBox.Items.Add("X RPL 2")
            KelasComboBox.Items.Add("X MM 1")
            KelasComboBox.Items.Add("X MM 2")
            KelasComboBox.Items.Add("X MM 3")
            KelasComboBox.Items.Add("X TKJ 1")
            KelasComboBox.Items.Add("X TKJ 2")
            KelasComboBox.Items.Add("X TKJ 3")
            KelasComboBox.Items.Add("X TKJ 4")
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked = True Then
            KelasComboBox.Items.Clear()
            KelasComboBox.Items.Add("XI Transmisi")
            KelasComboBox.Items.Add("XI Suitsing")
            KelasComboBox.Items.Add("XI RPL 1")
            KelasComboBox.Items.Add("XI RPL 2")
            KelasComboBox.Items.Add("XI MM 1")
            KelasComboBox.Items.Add("XI MM 2")
            KelasComboBox.Items.Add("XI MM 3")
            KelasComboBox.Items.Add("XI TKJ 1")
            KelasComboBox.Items.Add("XI TKJ 2")
            KelasComboBox.Items.Add("XI TKJ 3")
            KelasComboBox.Items.Add("XI TKJ 4")
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            KelasComboBox.Items.Clear()
            KelasComboBox.Items.Add("XII Transmisi")
            KelasComboBox.Items.Add("XII Suitsing")
            KelasComboBox.Items.Add("XII RPL 1")
            KelasComboBox.Items.Add("XII RPL 2")
            KelasComboBox.Items.Add("XII MM 1")
            KelasComboBox.Items.Add("XII MM 2")
            KelasComboBox.Items.Add("XII MM 3")
            KelasComboBox.Items.Add("XII TKJ 1")
            KelasComboBox.Items.Add("XII TKJ 2")
            KelasComboBox.Items.Add("XII TKJ 3")
            KelasComboBox.Items.Add("XII TKJ 4")
        End If
    End Sub

    Private Sub btnkembali_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnkembali.Click
        FormUtama.Show()
        Me.Hide()
    End Sub

    Private Sub btnsimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsimpan.Click
        Me.Validate()
        Me.TablesiswaBindingSource.EndEdit()
        Me.TablesiswaTableAdapter.Update(Me.PerpustakaanDigitalDataSet)
        TableAdapterManager.UpdateAll(Me.PerpustakaanDigitalDataSet)
        NISTextBox.Enabled = False
        NamaTextBox.Enabled = False
        KelasComboBox.Enabled = False
        RadioButton1.Enabled = False
        RadioButton2.Enabled = False
        RadioButton3.Enabled = False
        btnsimpan.Enabled = False
        btncancel.Enabled = False
        btntambah.Enabled = True
        btnedit.Enabled = True
        btnhapus.Enabled = True
        btnkembali.Enabled = True
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.TablesiswaBindingSource.CancelEdit()
        NISTextBox.Enabled = False
        NamaTextBox.Enabled = False
        KelasComboBox.Enabled = False
        RadioButton1.Enabled = False
        RadioButton2.Enabled = False
        RadioButton3.Enabled = False
        btnsimpan.Enabled = False
        btncancel.Enabled = False
        btntambah.Enabled = True
        btnedit.Enabled = True
        btnhapus.Enabled = True
        btnkembali.Enabled = True
    End Sub

    Private Sub btntambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntambah.Click
        Me.TablesiswaBindingSource.AddNew()
        NISTextBox.Enabled = True
        NamaTextBox.Enabled = True
        KelasComboBox.Enabled = True
        RadioButton1.Enabled = True
        RadioButton2.Enabled = True
        RadioButton3.Enabled = True
        btnsimpan.Enabled = True
        btncancel.Enabled = True
        btntambah.Enabled = False
        btnedit.Enabled = False
        btnhapus.Enabled = False
        btnkembali.Enabled = False
        NISTextBox.Focus()
    End Sub

    Private Sub btnedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit.Click
        If TablesiswaDataGridView.RowCount < 1 Then
            MessageBox.Show("Tidak Ada Data Yang Bisa Diedit!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            NISTextBox.Enabled = True
            NamaTextBox.Enabled = True
            KelasComboBox.Enabled = True
            RadioButton1.Enabled = True
            RadioButton2.Enabled = True
            RadioButton3.Enabled = True
            btnsimpan.Enabled = True
            btncancel.Enabled = True
            btntambah.Enabled = False
            btnedit.Enabled = False
            btnhapus.Enabled = False
            btnkembali.Enabled = False
            NISTextBox.Focus()
        End If
    End Sub

    Private Sub btnhapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhapus.Click
        If TablesiswaDataGridView.RowCount < 1 Then
            MessageBox.Show("Tidak Ada Data Yang Bisa Dihapus!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If MessageBox.Show("Data Akan Dihapus, Lanjutkan?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Me.TablesiswaBindingSource.RemoveCurrent()
                Me.TablesiswaTableAdapter.Update(Me.PerpustakaanDigitalDataSet)
                TableAdapterManager.UpdateAll(Me.PerpustakaanDigitalDataSet)
                NISTextBox.Enabled = False
                NamaTextBox.Enabled = False
                KelasComboBox.Enabled = False
                RadioButton1.Enabled = False
                RadioButton2.Enabled = False
                RadioButton3.Enabled = False
                btnsimpan.Enabled = False
                btncancel.Enabled = False
                btntambah.Enabled = True
                btnedit.Enabled = True
                btnhapus.Enabled = True
                btnkembali.Enabled = True
            ElseIf Windows.Forms.DialogResult.No Then
                Me.TablesiswaBindingSource.CancelEdit()
                NISTextBox.Enabled = False
                NamaTextBox.Enabled = False
                KelasComboBox.Enabled = False
                RadioButton1.Enabled = False
                RadioButton2.Enabled = False
                RadioButton3.Enabled = False
                btnsimpan.Enabled = False
                btncancel.Enabled = False
                btntambah.Enabled = True
                btnedit.Enabled = True
                btnhapus.Enabled = True
                btnkembali.Enabled = True
            End If
        End If
    End Sub
End Class