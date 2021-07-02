Public Class FormTransKembali

    Private Sub FormTransKembali_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PerpustakaanDigitalDataSet.tablestatus' table. You can move, or remove it, as needed.
        Me.TablestatusTableAdapter.Fill(Me.PerpustakaanDigitalDataSet.tablestatus)
        StatusComboBox.Text = "Sudah Dikembalikan"
    End Sub

    Private Sub TablestatusBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.TablestatusBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PerpustakaanDigitalDataSet)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        FormCariTrans.Show()
        FormCariTrans.TextBox1.Focus()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim db As New PerpustakaanDigitalDataSetTableAdapters.tablestatusTableAdapter
        db.ubah(StatusComboBox.Text, No_PeminjamanTextBox.Text)
        FormTransaksi.TablestatusTableAdapter.Fill(FormTransaksi.PerpustakaanDigitalDataSet.tablestatus)
        Me.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class