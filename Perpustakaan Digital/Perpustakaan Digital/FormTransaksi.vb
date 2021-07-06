
Public Class FormTransaksi

    Private Sub TablestatusBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.TablestatusBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PerpustakaanDigitalDataSet)

    End Sub

    Private Sub FormTransaksi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PerpustakaanDigitalDataSet.tablestatus' table. You can move, or remove it, as needed.
        Me.TablestatusTableAdapter.Fill(Me.PerpustakaanDigitalDataSet.tablestatus)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        FormUtama.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        FormTransPinjam.Show()
        FormTransPinjam.No_PeminjamanTextBox.Clear()
        FormTransPinjam.ID_BukuTextBox.Clear()
        FormTransPinjam.Judul_BukuTextBox.Clear()
        FormTransPinjam.NISTextBox.Clear()
        FormTransPinjam.NamaTextBox.Clear()
        FormTransPinjam.KelasComboBox.Text = ""
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        FormTransKembali.Show()
        FormTransKembali.No_PeminjamanTextBox.Clear()
        FormTransKembali.ID_BukuTextBox.Clear()
        FormTransKembali.Judul_BukuTextBox.Clear()
        FormTransKembali.NISTextBox.Clear()
        FormTransKembali.NamaTextBox.Clear()
        FormTransKembali.KelasComboBox.Text = ""
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If TablestatusDataGridView.RowCount < 1 Then
            MessageBox.Show("Tidak Ada Data Yang Bisa Dihapus!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf MessageBox.Show("Data Akan Dihapus, Lanjutkan?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Me.TablestatusBindingSource.RemoveCurrent()
            Me.TablestatusTableAdapter.Update(Me.PerpustakaanDigitalDataSet)
            TableAdapterManager.UpdateAll(Me.PerpustakaanDigitalDataSet)
        ElseIf Windows.Forms.DialogResult.No Then
            Me.TablestatusBindingSource.CancelEdit()
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class