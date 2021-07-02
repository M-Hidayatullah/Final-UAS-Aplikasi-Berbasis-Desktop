Public Class FormPengguna

    Private Sub Form3_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        If e.Cancel = True Then
            End
        End If
    End Sub

    Private Sub TableloginBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.TableloginBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PerpustakaanDigitalDataSet)

    End Sub

    Private Sub FormPengguna_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PerpustakaanDigitalDataSet.tablelogin' table. You can move, or remove it, as needed.
        Me.TableloginTableAdapter.Fill(Me.PerpustakaanDigitalDataSet.tablelogin)

    End Sub

    Private Sub btntambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntambah.Click
        Me.TableloginBindingSource.AddNew()
        UsernameTextBox.Enabled = True
        PasswordTextBox.Enabled = True
        AdminCheckBox.Enabled = True
        btnsimpan.Enabled = True
        btncancel.Enabled = True
        btntambah.Enabled = False
        btnedit.Enabled = False
        btnhapus.Enabled = False
        btnkembali.Enabled = False
        AdminCheckBox.CheckState = CheckState.Checked
        UsernameTextBox.Focus()
    End Sub

    Private Sub btnsimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsimpan.Click
        Me.Validate()
        Me.TableloginBindingSource.EndEdit()
        Me.TableloginTableAdapter.Update(Me.PerpustakaanDigitalDataSet)
        TableAdapterManager.UpdateAll(Me.PerpustakaanDigitalDataSet)
        UsernameTextBox.Enabled = False
        PasswordTextBox.Enabled = False
        AdminCheckBox.Enabled = False
        btnsimpan.Enabled = False
        btncancel.Enabled = False
        btntambah.Enabled = True
        btnedit.Enabled = True
        btnhapus.Enabled = True
        btnkembali.Enabled = True
    End Sub

    Private Sub btnedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit.Click
        If TableloginDataGridView.RowCount < 1 Then
            MessageBox.Show("Tidak Ada Data Yang Bisa Diedit!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            UsernameTextBox.Enabled = True
            PasswordTextBox.Enabled = True
            AdminCheckBox.Enabled = True
            btnsimpan.Enabled = True
            btncancel.Enabled = True
            btntambah.Enabled = False
            btnedit.Enabled = False
            btnhapus.Enabled = False
            btnkembali.Enabled = False
            UsernameTextBox.Focus()
        End If
    End Sub

    Private Sub btnhapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhapus.Click
        If TableloginDataGridView.RowCount < 1 Then
            MessageBox.Show("Tidak Ada Data Yang Bisa Dihapus!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If MessageBox.Show("Data Akan Dihapus, Lanjutkan?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Me.TableloginBindingSource.RemoveCurrent()
                Me.TableloginTableAdapter.Update(Me.PerpustakaanDigitalDataSet)
                TableAdapterManager.UpdateAll(Me.PerpustakaanDigitalDataSet)
                UsernameTextBox.Enabled = False
                PasswordTextBox.Enabled = False
                AdminCheckBox.Enabled = False
                btnsimpan.Enabled = False
                btncancel.Enabled = False
            ElseIf Windows.Forms.DialogResult.No Then
                Me.TableloginBindingSource.CancelEdit()
                UsernameTextBox.Enabled = False
                PasswordTextBox.Enabled = False
                AdminCheckBox.Enabled = False
                btnsimpan.Enabled = False
                btncancel.Enabled = False
            End If
        End If
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.TableloginBindingSource.CancelEdit()
        UsernameTextBox.Enabled = False
        PasswordTextBox.Enabled = False
        AdminCheckBox.Enabled = False
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