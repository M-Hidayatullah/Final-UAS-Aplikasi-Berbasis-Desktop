Public Class FormCariTrans

    Private Sub TablestatusBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.TablestatusBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PerpustakaanDigitalDataSet)

    End Sub

    Private Sub FormCariTrans_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PerpustakaanDigitalDataSet.tablestatus' table. You can move, or remove it, as needed.
        Me.TablestatusTableAdapter.Fill(Me.PerpustakaanDigitalDataSet.tablestatus)

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        TablestatusBindingSource.Filter = "No_Peminjaman like '%" & TextBox1.Text & "%'"
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        FormTransKembali.No_PeminjamanTextBox.Text = Me.No_PeminjamanTextBox.Text
        FormTransKembali.ID_BukuTextBox.Text = Me.ID_BukuTextBox.Text
        FormTransKembali.Judul_BukuTextBox.Text = Me.Judul_BukuTextBox.Text
        FormTransKembali.NISTextBox.Text = Me.NISTextBox.Text
        FormTransKembali.NamaTextBox.Text = Me.NamaTextBox.Text
        FormTransKembali.KelasComboBox.Text = Me.KelasComboBox.Text
        FormTransKembali.Tgl_PinjamDateTimePicker.Text = Me.Tgl_PinjamDateTimePicker.Text
        FormTransKembali.Tgl_KembaliDateTimePicker.Text = Me.Tgl_KembaliDateTimePicker.Text
        FormTransKembali.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class