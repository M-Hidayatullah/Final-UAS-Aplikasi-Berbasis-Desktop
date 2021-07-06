Public Class FormBuku

    Private Sub Form3_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        If e.Cancel = True Then
            End
        End If
    End Sub

    Private Sub TablebukuBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.TablebukuBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PerpustakaanDigitalDataSet)

    End Sub

    Private Sub FormBuku_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PerpustakaanDigitalDataSet.tablebuku' table. You can move, or remove it, as needed.
        Me.TablebukuTableAdapter.Fill(Me.PerpustakaanDigitalDataSet.tablebuku)

    End Sub

    Private Sub btntambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntambah.Click
        Me.TablebukuBindingSource.AddNew()
        ID_BukuTextBox.Enabled = True
        Judul_BukuTextBox.Enabled = True
        PenulisTextBox.Enabled = True
        PenerbitTextBox.Enabled = True
        Tahun_TerbitTextBox.Enabled = True
        btnsimpan.Enabled = True
        btncancel.Enabled = True
        btntambah.Enabled = False
        btnedit.Enabled = False
        btnhapus.Enabled = False
        btnkembali.Enabled = False
        ID_BukuTextBox.Focus()
    End Sub

    Private Sub btnedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit.Click
        If TablebukuDataGridView.RowCount < 1 Then
            MessageBox.Show("Tidak Ada Data Yang Bisa Diupdate!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            ID_BukuTextBox.Enabled = True
            Judul_BukuTextBox.Enabled = True
            PenulisTextBox.Enabled = True
            PenerbitTextBox.Enabled = True
            Tahun_TerbitTextBox.Enabled = True
            btnsimpan.Enabled = True
            btncancel.Enabled = True
            btntambah.Enabled = False
            btnedit.Enabled = False
            btnhapus.Enabled = False
            btnkembali.Enabled = False
            ID_BukuTextBox.Focus()
        End If
    End Sub

    Private Sub btnhapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhapus.Click
        If TablebukuDataGridView.RowCount < 1 Then
            MessageBox.Show("Tidak Ada Data Yang Bisa Dihapus!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf MessageBox.Show("Data Akan Dihapus, Lanjutkan?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Me.TablebukuBindingSource.RemoveCurrent()
                Me.TablebukuTableAdapter.Update(Me.PerpustakaanDigitalDataSet)
                TableAdapterManager.UpdateAll(Me.PerpustakaanDigitalDataSet)
                ID_BukuTextBox.Enabled = False
                Judul_BukuTextBox.Enabled = False
                PenulisTextBox.Enabled = False
                PenerbitTextBox.Enabled = False
                Tahun_TerbitTextBox.Enabled = False
                btnsimpan.Enabled = False
                btncancel.Enabled = False
            ElseIf Windows.Forms.DialogResult.No Then
                Me.TablebukuBindingSource.CancelEdit()
                ID_BukuTextBox.Enabled = False
                Judul_BukuTextBox.Enabled = False
                PenulisTextBox.Enabled = False
                PenerbitTextBox.Enabled = False
                Tahun_TerbitTextBox.Enabled = False
                btnsimpan.Enabled = False
                btncancel.Enabled = False
            End If
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.TablebukuBindingSource.CancelEdit()
        ID_BukuTextBox.Enabled = False
        Judul_BukuTextBox.Enabled = False
        PenulisTextBox.Enabled = False
        PenerbitTextBox.Enabled = False
        Tahun_TerbitTextBox.Enabled = False
        btnsimpan.Enabled = False
        btncancel.Enabled = False
        btntambah.Enabled = True
        btnedit.Enabled = True
        btnhapus.Enabled = True
        btnkembali.Enabled = True
    End Sub

    Private Sub btnsimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsimpan.Click
        Me.Validate()
        Me.TablebukuBindingSource.EndEdit()
        Me.TablebukuTableAdapter.Update(Me.PerpustakaanDigitalDataSet)
        TableAdapterManager.UpdateAll(Me.PerpustakaanDigitalDataSet)
        ID_BukuTextBox.Enabled = False
        Judul_BukuTextBox.Enabled = False
        PenulisTextBox.Enabled = False
        PenerbitTextBox.Enabled = False
        Tahun_TerbitTextBox.Enabled = False
        btnsimpan.Enabled = False
        btncancel.Enabled = False
        btntambah.Enabled = True
        btnedit.Enabled = True
        btnhapus.Enabled = True
        btnkembali.Enabled = True
    End Sub

    Private Sub btnkembali_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnkembali.Click
        FormUtama.Show()
        Me.Hide()
    End Sub
End Class