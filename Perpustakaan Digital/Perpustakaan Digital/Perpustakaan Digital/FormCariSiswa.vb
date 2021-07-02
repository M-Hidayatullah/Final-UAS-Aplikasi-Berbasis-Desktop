Public Class FormCariSiswa

    Private Sub TablesiswaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.TablesiswaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PerpustakaanDigitalDataSet)

    End Sub

    Private Sub FormCariSiswa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PerpustakaanDigitalDataSet.tablesiswa' table. You can move, or remove it, as needed.
        Me.TablesiswaTableAdapter.Fill(Me.PerpustakaanDigitalDataSet.tablesiswa)

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        If ComboBox1.Text = "NIS" Then
            TablesiswaBindingSource.Filter = "ID_Buku like '%" & TextBox1.Text & "%'"
        ElseIf ComboBox1.Text = "Nama" Then
            TablesiswaBindingSource.Filter = "Nama like '%" & TextBox1.Text & "%'"
        ElseIf ComboBox1.Text = "Kelas" Then
            TablesiswaBindingSource.Filter = "Kelas like '%" & TextBox1.Text & "%'"
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        FormTransPinjam.NISTextBox.Text = Me.NISTextBox.Text
        FormTransPinjam.NamaTextBox.Text = Me.NamaTextBox.Text
        FormTransPinjam.KelasComboBox.Text = Me.KelasTextBox.Text
        Me.Close()
    End Sub
End Class