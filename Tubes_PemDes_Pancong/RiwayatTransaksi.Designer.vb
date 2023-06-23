<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RiwayatTransaksi
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RiwayatTransaksi))
        Me.backtokasir2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TotalPemasukan = New System.Windows.Forms.TextBox()
        Me.TblTrans = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label9 = New System.Windows.Forms.Label()
        Me.inputKodeTrans = New System.Windows.Forms.TextBox()
        Me.Cari = New System.Windows.Forms.Button()
        Me.LvMenu = New System.Windows.Forms.ListView()
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'backtokasir2
        '
        Me.backtokasir2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.backtokasir2.Location = New System.Drawing.Point(40, 409)
        Me.backtokasir2.Name = "backtokasir2"
        Me.backtokasir2.Size = New System.Drawing.Size(164, 25)
        Me.backtokasir2.TabIndex = 23
        Me.backtokasir2.Text = "Kembali ke Menu Kasir"
        Me.backtokasir2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(461, 416)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Total Pemasukan :"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(6, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(271, 70)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'TotalPemasukan
        '
        Me.TotalPemasukan.Location = New System.Drawing.Point(563, 413)
        Me.TotalPemasukan.Name = "TotalPemasukan"
        Me.TotalPemasukan.Size = New System.Drawing.Size(180, 20)
        Me.TotalPemasukan.TabIndex = 19
        '
        'TblTrans
        '
        Me.TblTrans.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.TblTrans.GridLines = True
        Me.TblTrans.HideSelection = False
        Me.TblTrans.Location = New System.Drawing.Point(40, 68)
        Me.TblTrans.Name = "TblTrans"
        Me.TblTrans.Size = New System.Drawing.Size(703, 156)
        Me.TblTrans.TabIndex = 18
        Me.TblTrans.UseCompatibleStateImageBehavior = False
        Me.TblTrans.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Kode Transaksi"
        Me.ColumnHeader1.Width = 120
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Tanggal"
        Me.ColumnHeader2.Width = 190
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Nama Customer"
        Me.ColumnHeader3.Width = 178
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Total Pembelian"
        Me.ColumnHeader4.Width = 180
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(37, 245)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(243, 13)
        Me.Label9.TabIndex = 56
        Me.Label9.Text = "Cari Detail Transaksi, Masukkan Kode Transaksi :"
        '
        'inputKodeTrans
        '
        Me.inputKodeTrans.Location = New System.Drawing.Point(286, 242)
        Me.inputKodeTrans.Name = "inputKodeTrans"
        Me.inputKodeTrans.Size = New System.Drawing.Size(100, 20)
        Me.inputKodeTrans.TabIndex = 57
        Me.inputKodeTrans.Text = "TRA"
        '
        'Cari
        '
        Me.Cari.Location = New System.Drawing.Point(405, 240)
        Me.Cari.Name = "Cari"
        Me.Cari.Size = New System.Drawing.Size(75, 23)
        Me.Cari.TabIndex = 58
        Me.Cari.Text = "Cari"
        Me.Cari.UseVisualStyleBackColor = True
        '
        'LvMenu
        '
        Me.LvMenu.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9})
        Me.LvMenu.FullRowSelect = True
        Me.LvMenu.GridLines = True
        Me.LvMenu.HideSelection = False
        Me.LvMenu.Location = New System.Drawing.Point(40, 268)
        Me.LvMenu.Name = "LvMenu"
        Me.LvMenu.Size = New System.Drawing.Size(703, 135)
        Me.LvMenu.TabIndex = 59
        Me.LvMenu.UseCompatibleStateImageBehavior = False
        Me.LvMenu.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Nama Menu"
        Me.ColumnHeader5.Width = 201
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Porsi"
        Me.ColumnHeader6.Width = 96
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Jumlah"
        Me.ColumnHeader7.Width = 91
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Harga Satuan"
        Me.ColumnHeader8.Width = 115
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Total"
        Me.ColumnHeader9.Width = 206
        '
        'RiwayatTransaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LvMenu)
        Me.Controls.Add(Me.Cari)
        Me.Controls.Add(Me.inputKodeTrans)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.backtokasir2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TotalPemasukan)
        Me.Controls.Add(Me.TblTrans)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "RiwayatTransaksi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form4"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents backtokasir2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TotalPemasukan As TextBox
    Friend WithEvents TblTrans As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents Label9 As Label
    Friend WithEvents inputKodeTrans As TextBox
    Friend WithEvents Cari As Button
    Friend WithEvents LvMenu As ListView
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
End Class
