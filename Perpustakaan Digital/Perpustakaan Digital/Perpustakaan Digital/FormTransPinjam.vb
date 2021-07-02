Public Class FormTransPinjam

    Private Sub TablestatusBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.TablestatusBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PerpustakaanDigitalDataSet)

    End Sub

    Private Sub FormTransPinjam_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PerpustakaanDigitalDataSet.tablestatus' table. You can move, or remove it, as needed.
        Me.TablestatusTableAdapter.Fill(Me.PerpustakaanDigitalDataSet.tablestatus)
        StatusComboBox.Text = "Dalam Peminjaman"
        Tgl_KembaliDateTimePicker.Value = Tgl_KembaliDateTimePicker.Value.AddDays(3)
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        No_PeminjamanTextBox.Text = Format(Now, "yyMMddHHmmss")
    End Sub

    Private Sub Tgl_PinjamDateTimePicker_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tgl_PinjamDateTimePicker.ValueChanged
        Tgl_KembaliDateTimePicker.Value = Tgl_PinjamDateTimePicker.Value.AddDays(3)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        FormCariBuku.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim db As New PerpustakaanDigitalDataSetTableAdapters.tablestatusTableAdapter
        db.masuk(No_PeminjamanTextBox.Text, ID_BukuTextBox.Text, Judul_BukuTextBox.Text, NISTextBox.Text, NamaTextBox.Text, KelasComboBox.Text, Tgl_PinjamDateTimePicker.Value, Tgl_KembaliDateTimePicker.Value, StatusComboBox.Text)
        FormTransaksi.TablestatusTableAdapter.Fill(FormTransaksi.PerpustakaanDigitalDataSet.tablestatus)
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        FormCariSiswa.Show()
    End Sub
End Class