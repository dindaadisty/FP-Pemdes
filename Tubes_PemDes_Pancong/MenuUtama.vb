Public Class MenuUtama
    Private Sub kasir_Click(sender As Object, e As EventArgs)
        RiwayatTransaksi.Show()
        Me.Dispose()
    End Sub
    Private Sub cekriwayattransaksi_Click(sender As Object, e As EventArgs) Handles cekriwayattransaksi.Click
        RiwayatTransaksi.Show()
        Me.Hide()
    End Sub
    Private Sub close_Click(sender As Object, e As EventArgs) Handles close.Click
        Application.Exit()
    End Sub
    Private Sub MenuUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Kasir.Show()
        Me.Hide()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Kasir.Show()
        Me.Hide()
    End Sub

End Class