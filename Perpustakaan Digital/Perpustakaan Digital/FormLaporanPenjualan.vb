Imports CrystalDecisions.CrystalReports.Engine
Public Class FormLaporanPenjualan

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim reportKu As New ReportDocument
        Dim strPath As String = AppDomain.CurrentDomain.BaseDirectory
        FormCetak.LaporanTransaksi1.Refresh()
        FormCetak.StartPosition = FormStartPosition.CenterScreen
        FormTransaksi.ShowDialog()
    End Sub

    Private Sub FormLaporanPenjualan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class