Imports System.Data.SqlClient

Public Class Kasir
    Dim loyang As Double
    Dim porsi As String
    Dim totalTransaksi As Integer
    Dim ctr As Control

    Private Sub Kasir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TotalHarga.Text = 0
        Kembalian.Text = 0
        Call koneksi()
        cmd = New SqlCommand("Select * from TBL_Menu", conn)
        Rd = cmd.ExecuteReader

        While Rd.Read
            ComboMenu.Items.Add(Rd.Item("nama_menu"))
        End While
        Rd.Close()

        Dim temp As String
        temp = ""

        cmd = New SqlCommand(“Select case when max(convert(decimal, substring(kode_transaksi,4,10))) IS NULL then 1 Else max(convert(decimal, 
                            substring(kode_transaksi,4,10)))+1 end 'NO' FROM TBL_Transaksi", conn)
        Rd = cmd.ExecuteReader
        If Rd.HasRows Then
            Rd.Read()
            TextBox2.Text = Rd.Item(0)

            For i As Integer = 1 To 4 - TextBox2.TextLength

                temp = temp & "0"

            Next

            TextBox2.Text = "TRA" & temp & TextBox2.Text
            Rd.Close()

        End If
        Rd.Close()

        cmd = New SqlCommand("delete from TBL_DetailTrans where kode_transaksi='" & TextBox2.Text & "'", conn)
        cmd.ExecuteNonQuery()

        Rd.Close()
        cmd.Dispose()

    End Sub
    Private Sub bayar_Click(sender As Object, e As EventArgs) Handles bayar.Click
        If TotalHarga.Text = 0 Then
            MsgBox("Belum ada item yang masuk")
        ElseIf Tunai.Value < totalTransaksi Then
            MsgBox("Nominal Pembayaran Kurang!")
        Else
            MsgBox("Berhasil Melakukan Pembayaran!")

            cmd = New SqlCommand("insert into TBL_Transaksi values ('" & TextBox2.Text & "', getdate() ,'" & namaPembeli.Text & "', 
                                            '" & totalTransaksi & "')", conn)
            cmd.ExecuteNonQuery()

            For Each ctr In Me.Controls
                If TypeOf ctr Is TextBox Then
                    ctr.Text = ""
                End If
                If TypeOf ctr Is NumericUpDown Then
                    ctr.Text = "0"
                End If
            Next
            Stgh.Checked = False
            Satu.Checked = False
            LvMenu.Items.Clear()

            Dim temp As String
            temp = ""

            cmd = New SqlCommand(“Select case when max(convert(decimal, substring(kode_transaksi,4,10))) IS NULL then 1 Else max(convert(decimal, 
                            substring(kode_transaksi,4,10)))+1 end 'NO' FROM TBL_Transaksi", conn)
            Rd = cmd.ExecuteReader
            If Rd.HasRows Then
                Rd.Read()
                TextBox2.Text = Rd.Item(0)
                For i As Integer = 1 To 4 - TextBox2.TextLength
                    temp = temp & "0"
                Next
                TextBox2.Text = "TRA" & temp & TextBox2.Text
                Rd.Close()
            End If

            Rd.Close()
            cmd.Dispose()

        End If

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles inputPesanan.Click
        If namaPembeli.Text = "" Then
            MsgBox("Nama Customer Tidak Boleh Kosong!")
        ElseIf JumlahBrg.Value = 0 Then
            MsgBox("Jumlah Barang Tidak Boleh 0!")
        ElseIf porsi = "" Then
            MsgBox("Porsi Tidak Boleh Kosong!")
        Else
            totalTransaksi = 0
            Dim total As Integer
            total = hrgSatuan.Text * JumlahBrg.Value
            cmd = New SqlCommand("insert into TBL_DetailTrans values ('" & TextBox2.Text & "', '" & namaPembeli.Text & "', '" & ComboMenu.Text & "', 
                                            '" & hrgSatuan.Text & "', " & JumlahBrg.Value & ", '" & total & "', '" & porsi & "')", conn)
            cmd.ExecuteNonQuery()
            LvMenu.Items.Clear()

            cmd = New SqlCommand("select nama_menu, porsi, jumlah_barang, harga_satuan, total from TBL_DetailTrans
                                        where kode_transaksi ='" & TextBox2.Text & "'", conn)

            Rd = cmd.ExecuteReader
            If Rd.HasRows Then
                While Rd.Read
                    LvMenu.Items.Add(Rd.Item(0))
                    LvMenu.Items(LvMenu.Items.Count - 1).SubItems.Add(Rd.Item(1))
                    LvMenu.Items(LvMenu.Items.Count - 1).SubItems.Add(Rd.Item(2))
                    LvMenu.Items(LvMenu.Items.Count - 1).SubItems.Add(Rd.Item(3))
                    LvMenu.Items(LvMenu.Items.Count - 1).SubItems.Add(Rd.Item(4))
                    totalTransaksi = totalTransaksi + Rd.Item(4)
                End While
                Rd.Close()
            End If
            Rd.Close()
            cmd.Dispose()
            TotalHarga.Text = totalTransaksi
        End If
    End Sub
    Private Sub Stgh_CheckedChanged(sender As Object, e As EventArgs) Handles Stgh.CheckedChanged
        Call koneksi()
        cmd = New SqlCommand("select * from TBL_Menu where Nama_Menu ='" & ComboMenu.Text & "'", conn)
        Rd = cmd.ExecuteReader
        Rd.Read()
        Dim harga = Rd.Item(2)
        porsi = "setengah"
        If Stgh.Checked = True Then
            loyang = 0.5
            hrgSatuan.Text = harga * loyang
        End If
        Rd.Close()
        cmd.Dispose()
    End Sub
    Private Sub Satu_CheckedChanged(sender As Object, e As EventArgs) Handles Satu.CheckedChanged
        Call koneksi()
        cmd = New SqlCommand("select * from TBL_Menu where Nama_Menu ='" & ComboMenu.Text & "'", conn)
        Rd = cmd.ExecuteReader
        Rd.Read()
        Dim harga = Rd.Item(2)
        porsi = "satu"
        If Satu.Checked = True Then
            loyang = 1
            hrgSatuan.Text = harga * loyang
        End If
        Rd.Close()
        cmd.Dispose()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MenuPancong.Show()
        Me.Close()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Call koneksi()
        cmd = New SqlCommand("delete from TBL_DetailTrans where kode_transaksi='" & TextBox2.Text & "'", conn)
        cmd.ExecuteNonQuery()
        MenuUtama.Show()
        Me.Close()
    End Sub
    Private Sub hapusPesanan_Click(sender As Object, e As EventArgs) Handles hapusPesanan.Click
        totalTransaksi = 0
        Call koneksi()
        cmd = New SqlCommand("delete from TBL_DetailTrans where nama_menu='" & ComboMenu.Text & "' and porsi='" & porsi & "'", conn)
        cmd.ExecuteNonQuery()

        LvMenu.Items.Clear()

        cmd = New SqlCommand("select nama_menu, porsi, jumlah_barang, harga_satuan, total from TBL_DetailTrans
                                        where kode_transaksi ='" & TextBox2.Text & "'", conn)

        Rd = cmd.ExecuteReader
        If Rd.HasRows Then
            While Rd.Read
                LvMenu.Items.Add(Rd.Item(0))
                LvMenu.Items(LvMenu.Items.Count - 1).SubItems.Add(Rd.Item(1))
                LvMenu.Items(LvMenu.Items.Count - 1).SubItems.Add(Rd.Item(2))
                LvMenu.Items(LvMenu.Items.Count - 1).SubItems.Add(Rd.Item(3))
                LvMenu.Items(LvMenu.Items.Count - 1).SubItems.Add(Rd.Item(4))
                totalTransaksi = totalTransaksi + Rd.Item(4)
            End While
            Rd.Close()
        End If
        Rd.Close()
        cmd.Dispose()
        TotalHarga.Text = totalTransaksi
    End Sub

    Private Sub Tunai_ValueChanged(sender As Object, e As EventArgs) Handles Tunai.ValueChanged
        Kembalian.Text = Tunai.Value - TotalHarga.Text
    End Sub
End Class