Public Class FormLogin
    Dim kesempatan As Integer = 0
    Private Sub TableloginBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.TableloginBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PerpustakaanDigitalDataSet)

    End Sub

    Private Sub FormLogin_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        If e.Cancel = True Then
            End
        End If
    End Sub

    Private Sub FormLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PerpustakaanDigitalDataSet.tablelogin' table. You can move, or remove it, as needed.
        Me.TableloginTableAdapter.Fill(Me.PerpustakaanDigitalDataSet.tablelogin)

    End Sub

    Private Sub btnlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogin.Click
        TableloginBindingSource.Filter = "Username = '" & UsernameTextBox.Text & "' And Password = '" & PasswordTextBox.Text & "'"
        Dim admin As String = ""
        admin = TableloginDataGridView.Rows(0).Cells(2).Value
        If UsernameTextBox.Text = "" And PasswordTextBox.Text = "" Then
            MessageBox.Show("Masukkan Data Terlebih Dahulu!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            UsernameTextBox.Focus()
        ElseIf kesempatan = 2 Then
            MessageBox.Show("Percobaan Login Ilegal, Program Ditutup!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        ElseIf UsernameTextBox.Text <> TableloginDataGridView.Rows(0).Cells(0).Value Or PasswordTextBox.Text <> TableloginDataGridView.Rows(0).Cells(1).Value Then
            MessageBox.Show("Data Yang Anda Masukkan Salah atau Tidak Terdaftar!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            UsernameTextBox.Clear()
            PasswordTextBox.Clear()
            UsernameTextBox.Focus()
            kesempatan = kesempatan + 1
        End If
        If admin = "True" Then
            FormUtama.btnbuku.Visible = True
            FormUtama.btnsiswa.Visible = True
            FormUtama.btnpengguna.Visible = True
            FormUtama.status.Text = "Admin"
            UsernameTextBox.Text = ""
            PasswordTextBox.Text = ""
            UsernameTextBox.Focus()
            MessageBox.Show("Login Sukses, Selamat Datang!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            FormUtama.Show()
            FormUtama.btnbuku.Focus()
            Me.Hide()
        ElseIf admin = "False" Then
            FormUtama.btnbuku.Visible = False
            FormUtama.btnsiswa.Visible = False
            FormUtama.btnpengguna.Visible = False
            FormUtama.status.Text = "User"
            UsernameTextBox.Text = ""
            PasswordTextBox.Text = ""
            UsernameTextBox.Focus()
            MessageBox.Show("Login Sukses, Selamat Datang!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            FormUtama.Show()
            FormUtama.btntransaksi.Focus()
            Me.Hide()
        End If
    End Sub
End Class