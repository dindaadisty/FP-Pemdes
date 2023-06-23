Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Data.SqlClient
Public Class RiwayatTransaksi
    Dim pemasukan As Integer
    Private Sub RiwayatTransaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pemasukan = 0
        Call koneksi()
        TblTrans.Items.Clear()

        cmd = New SqlCommand("select kode_transaksi, tanggal, nama_pelanggan, total_pembelian from TBL_Transaksi", conn)
        Rd = cmd.ExecuteReader
        If Rd.HasRows Then
            While Rd.Read()
                TblTrans.Items.Add(Rd.Item(0))
                TblTrans.Items(TblTrans.Items.Count - 1).SubItems.Add(Rd.Item(1))
                TblTrans.Items(TblTrans.Items.Count - 1).SubItems.Add(Rd.Item(2))
                TblTrans.Items(TblTrans.Items.Count - 1).SubItems.Add(Rd.Item(3))
                pemasukan = pemasukan + Rd.Item(3)
            End While
            Rd.Close()
        End If
        Rd.Close()
        cmd.Dispose()
        TotalPemasukan.Text = pemasukan
    End Sub


    Private Sub backtokasir2_Click(sender As Object, e As EventArgs) Handles backtokasir2.Click
        MenuUtama.Show()
        Me.Hide()
    End Sub

    Private Sub Cari_Click(sender As Object, e As EventArgs) Handles Cari.Click
        LvMenu.Items.Clear()

        If inputKodeTrans.Text = "" Then
            MsgBox("Kode Transaksi Tidak boleh kosong!")
        Else
            cmd = New SqlCommand("select nama_menu, porsi, jumlah_barang, harga_satuan, total from TBL_DetailTrans
                                        where kode_transaksi ='" & inputKodeTrans.Text & "'", conn)

            Rd = cmd.ExecuteReader
            If Rd.HasRows Then
                While Rd.Read
                    LvMenu.Items.Add(Rd.Item(0))
                    LvMenu.Items(LvMenu.Items.Count - 1).SubItems.Add(Rd.Item(1))
                    LvMenu.Items(LvMenu.Items.Count - 1).SubItems.Add(Rd.Item(2))
                    LvMenu.Items(LvMenu.Items.Count - 1).SubItems.Add(Rd.Item(3))
                    LvMenu.Items(LvMenu.Items.Count - 1).SubItems.Add(Rd.Item(4))
                End While
                Rd.Close()
            End If
            Rd.Close()
            cmd.Dispose()
        End If
    End Sub
End Class