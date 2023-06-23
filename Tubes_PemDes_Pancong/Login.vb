Imports System.Data.SqlClient
Public Class Login 'untuk login
    Private Sub pic_login_Click(sender As Object, e As EventArgs) Handles pic_login.Click
        If txt_user.Text = "" Or txt_pass.Text = "" Then
            MsgBox("Username atau Password tidak boleh kosong!")
        Else
            Call koneksi()
            cmd = New SqlCommand("Select * From TBL_Akun where UsernameAdm = '" & txt_user.Text & "' and PasswordAdm = '" & txt_pass.Text & "'", conn)
            Rd = cmd.ExecuteReader
            Rd.Read()
            If Rd.HasRows = True Then
                MenuUtama.Show()
                Me.Hide()
            Else
                MsgBox("Username atau Password salah!")
            End If
        End If
    End Sub

    Private Sub close_Click(sender As Object, e As EventArgs) Handles close.Click
        Application.Exit()
    End Sub
    Private Sub txt_user_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_user.KeyPress
        If e.KeyChar = Chr(13) Then
            txt_pass.Focus()
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            txt_pass.PasswordChar = ""
        Else
            txt_pass.PasswordChar = "❂"
        End If
    End Sub
End Class
