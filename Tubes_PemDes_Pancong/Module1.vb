Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Module Module1
    Public conn As SqlConnection
    Public Da As SqlDataAdapter
    Public Rd As SqlDataReader
    Public cmd As SqlCommand
    Public Ds As DataSet

    Public Sub koneksi()
        conn = New SqlConnection("Data Source=IZZUL\SQLEXPRESS;Initial Catalog=PemdesTubes;Integrated Security=True")
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub
End Module
