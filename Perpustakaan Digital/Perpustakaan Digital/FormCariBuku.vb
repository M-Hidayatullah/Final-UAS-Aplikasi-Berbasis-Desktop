Public Class FormCariBuku

    Private Sub TablebukuBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.TablebukuBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PerpustakaanDigitalDataSet)

    End Sub

    Private Sub FormCariBuku_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PerpustakaanDigitalDataSet.tablebuku' table. You can move, or remove it, as needed.
        Me.TablebukuTableAdapter.Fill(Me.PerpustakaanDigitalDataSet.tablebuku)

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        If ComboBox1.Text = "ID_Buku" Then
            TablebukuBindingSource.Filter = "ID_Buku like '%" & TextBox1.Text & "%'"
        ElseIf ComboBox1.Text = "Judul_Buku" Then
            TablebukuBindingSource.Filter = "Judul_Buku like '%" & TextBox1.Text & "%'"
        ElseIf ComboBox1.Text = "Penulis" Then
            TablebukuBindingSource.Filter = "Penulis like '%" & TextBox1.Text & "%'"
        ElseIf ComboBox1.Text = "Penerbit" Then
            TablebukuBindingSource.Filter = "Penerbit like '%" & TextBox1.Text & "%'"
        ElseIf ComboBox1.Text = "Tahun_Terbit" Then
            TablebukuBindingSource.Filter = "Tahun_Terbit like '%" & TextBox1.Text & "%'"
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        FormTransPinjam.ID_BukuTextBox.Text = Me.ID_BukuTextBox.Text
        FormTransPinjam.Judul_BukuTextBox.Text = Me.Judul_BukuTextBox.Text
        FormTransPinjam.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        FormTransPinjam.Show()
        Me.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class