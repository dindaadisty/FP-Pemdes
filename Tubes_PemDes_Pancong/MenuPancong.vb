Imports System.Data.SqlClient

Public Class MenuPancong
    Dim ctr As Control
    Private Sub MenuPancong_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        ListView1.Items.Clear()
        cmd = New SqlClient.SqlCommand("select kode_menu, nama_menu, harga_menu from TBL_Menu ", conn)
        Rd = cmd.ExecuteReader()
        If Rd.HasRows Then
            While Rd.Read()
                ListView1.Items.Add(Rd.Item(0))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Rd.Item(1))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Rd.Item(2))
            End While
            Rd.Close()
        End If
        Rd.Close()
        cmd.Dispose()

        Dim temp As String
        temp = ""

        cmd = New SqlCommand(“Select case when max(convert(decimal, substring(kode_menu,3,10))) IS NULL then 1 Else max(convert(decimal, 
                            substring(kode_menu,3,10)))+1 end 'NO' FROM TBL_Menu", conn)
        Rd = cmd.ExecuteReader
        If Rd.HasRows Then
            Rd.Read()
            TextBox1.Text = Rd.Item(0)

            For i As Integer = 1 To 4 - TextBox1.TextLength

                temp = temp & "0"

            Next

            TextBox1.Text = "PC" & temp & TextBox1.Text
            Rd.Close()

        End If
        Rd.Close()
        cmd.Dispose()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        For Each ctr In Me.Controls
            If TypeOf ctr Is TextBox Then
                ctr.Text = ""
            End If
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cmd = New SqlCommand("insert into TBL_Menu values ('" & TextBox1.Text & "','" & TextBox2.Text & "'," & TextBox3.Text & ")", conn)
        cmd.ExecuteNonQuery()
        ListView1.Items.Clear()
        cmd = New SqlCommand("select kode_menu, nama_menu, harga_menu from TBL_Menu ", conn)
        Rd = cmd.ExecuteReader()
        If Rd.HasRows Then
            While Rd.Read()
                ListView1.Items.Add(Rd.Item(0))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Rd.Item(1))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Rd.Item(2))
            End While
            Rd.Close()
        End If
        Rd.Close()
        cmd.Dispose()

        For Each ctr In Me.Controls
            If TypeOf ctr Is TextBox Then
                ctr.Text = ""
            End If
        Next

        Dim temp As String
        temp = ""

        cmd = New SqlCommand(“Select case when max(convert(decimal, substring(kode_menu,3,10))) IS NULL then 1 Else max(convert(decimal, 
                            substring(kode_menu,3,10)))+1 end 'NO' FROM TBL_Menu", conn)
        Rd = cmd.ExecuteReader
        If Rd.HasRows Then
            Rd.Read()
            TextBox1.Text = Rd.Item(0)

            For i As Integer = 1 To 4 - TextBox1.TextLength

                temp = temp & "0"

            Next

            TextBox1.Text = "PC" & temp & TextBox1.Text
            Rd.Close()

        End If
        Rd.Close()
        cmd.Dispose()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        cmd = New SqlCommand("update TBL_Menu set nama_menu='" & TextBox2.Text & "',harga_menu='" & TextBox3.Text & "' 
                                        where kode_menu='" & TextBox1.Text & "'", conn)
        cmd.ExecuteNonQuery()
        ListView1.Items.Clear()
        cmd = New SqlCommand("select kode_menu, nama_menu, harga_menu from TBL_Menu ", conn)
        Rd = cmd.ExecuteReader()
        If Rd.HasRows Then
            While Rd.Read()
                ListView1.Items.Add(Rd.Item(0))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Rd.Item(1))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Rd.Item(2))
            End While
            Rd.Close()
        End If
        Rd.Close()
        cmd.Dispose()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        cmd = New SqlCommand("delete TBL_Menu where kode_menu='" & TextBox1.Text & "'", conn)
        cmd.ExecuteNonQuery()

        ListView1.Items.Clear()
        cmd = New SqlCommand("select kode_menu, nama_menu, harga_menu from TBL_Menu ", conn)
        Rd = cmd.ExecuteReader()
        If Rd.HasRows Then
            While Rd.Read()
                ListView1.Items.Add(Rd.Item(0))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Rd.Item(1))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Rd.Item(2))
            End While
            Rd.Close()
        End If
        Rd.Close()
        cmd.Dispose()

        For Each ctr In Me.Controls
            If TypeOf ctr Is TextBox Then
                ctr.Text = ""
            End If
        Next

        Dim temp As String
        temp = ""

        cmd = New SqlCommand(“Select case when max(convert(decimal, substring(kode_menu,3,10))) IS NULL then 1 Else max(convert(decimal, 
                            substring(kode_menu,3,10)))+1 end 'NO' FROM TBL_Menu", conn)
        Rd = cmd.ExecuteReader
        If Rd.HasRows Then
            Rd.Read()
            TextBox1.Text = Rd.Item(0)

            For i As Integer = 1 To 4 - TextBox1.TextLength

                temp = temp & "0"

            Next

            TextBox1.Text = "PC" & temp & TextBox1.Text
            Rd.Close()

        End If
        Rd.Close()
        cmd.Dispose()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Kasir.Show()
        Me.Hide()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class