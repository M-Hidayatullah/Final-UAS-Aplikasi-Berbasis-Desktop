Public Class FormUtama

    Private Sub Form3_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        If e.Cancel = True Then
            End
        End If
    End Sub

    Private Sub btntransaksi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntransaksi.Click
        FormTransaksi.Show()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        TglJam.Text = Format(Now, "HH:mm:ss")
        TglHari.Text = Format(Now, "dd/MM/yyyy")
    End Sub

    Private Sub btnpengguna_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpengguna.Click
        FormPengguna.Show()
        Me.Hide()
    End Sub

    Private Sub btnbuku_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuku.Click
        FormBuku.Show()
        Me.Hide()
    End Sub

    Private Sub btnsiswa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsiswa.Click
        FormSiswa.Show()
        Me.Hide()
    End Sub

    Private Sub btnlogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogout.Click
        FormLogin.Show()
        Me.Hide()
    End Sub

    Private Sub FormUtama_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
