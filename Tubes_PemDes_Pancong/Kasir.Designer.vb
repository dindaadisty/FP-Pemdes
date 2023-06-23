<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Kasir
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Kasir))
        Me.TotalHarga = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Kembalian = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboMenu = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.hrgSatuan = New System.Windows.Forms.TextBox()
        Me.Satu = New System.Windows.Forms.RadioButton()
        Me.Stgh = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.inputPesanan = New System.Windows.Forms.Button()
        Me.bayar = New System.Windows.Forms.Button()
        Me.namaPembeli = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.hapusPesanan = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.JumlahBrg = New System.Windows.Forms.NumericUpDown()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.LvMenu = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Tunai = New System.Windows.Forms.NumericUpDown()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JumlahBrg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tunai, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TotalHarga
        '
        Me.TotalHarga.Location = New System.Drawing.Point(130, 376)
        Me.TotalHarga.Name = "TotalHarga"
        Me.TotalHarga.ReadOnly = True
        Me.TotalHarga.Size = New System.Drawing.Size(100, 20)
        Me.TotalHarga.TabIndex = 46
        Me.TotalHarga.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(47, 379)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "Total :"
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(623, 403)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(141, 24)
        Me.Button3.TabIndex = 44
        Me.Button3.Text = "Kembali ke Menu Utama"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Kembalian
        '
        Me.Kembalian.Location = New System.Drawing.Point(391, 407)
        Me.Kembalian.Name = "Kembalian"
        Me.Kembalian.ReadOnly = True
        Me.Kembalian.Size = New System.Drawing.Size(100, 20)
        Me.Kembalian.TabIndex = 43
        Me.Kembalian.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(308, 410)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "Kembalian :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(308, 380)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Tunai :"
        '
        'ComboMenu
        '
        Me.ComboMenu.FormattingEnabled = True
        Me.ComboMenu.Location = New System.Drawing.Point(94, 115)
        Me.ComboMenu.Name = "ComboMenu"
        Me.ComboMenu.Size = New System.Drawing.Size(121, 21)
        Me.ComboMenu.TabIndex = 39
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(623, 67)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(141, 23)
        Me.Button2.TabIndex = 38
        Me.Button2.Text = "Tambah Menu Baru"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(388, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Harga :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(229, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Porsi :"
        '
        'hrgSatuan
        '
        Me.hrgSatuan.Location = New System.Drawing.Point(436, 114)
        Me.hrgSatuan.Name = "hrgSatuan"
        Me.hrgSatuan.Size = New System.Drawing.Size(154, 20)
        Me.hrgSatuan.TabIndex = 35
        '
        'Satu
        '
        Me.Satu.AutoSize = True
        Me.Satu.BackColor = System.Drawing.Color.Transparent
        Me.Satu.Location = New System.Drawing.Point(271, 135)
        Me.Satu.Name = "Satu"
        Me.Satu.Size = New System.Drawing.Size(85, 17)
        Me.Satu.TabIndex = 34
        Me.Satu.TabStop = True
        Me.Satu.Text = "Satu Loyang"
        Me.Satu.UseVisualStyleBackColor = False
        '
        'Stgh
        '
        Me.Stgh.AutoSize = True
        Me.Stgh.BackColor = System.Drawing.Color.Transparent
        Me.Stgh.Location = New System.Drawing.Point(271, 112)
        Me.Stgh.Name = "Stgh"
        Me.Stgh.Size = New System.Drawing.Size(109, 17)
        Me.Stgh.TabIndex = 33
        Me.Stgh.TabStop = True
        Me.Stgh.Text = "Setengah Loyang"
        Me.Stgh.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(47, 114)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Menu :"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(2, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(209, 80)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 31
        Me.PictureBox1.TabStop = False
        '
        'inputPesanan
        '
        Me.inputPesanan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inputPesanan.Location = New System.Drawing.Point(623, 140)
        Me.inputPesanan.Name = "inputPesanan"
        Me.inputPesanan.Size = New System.Drawing.Size(141, 24)
        Me.inputPesanan.TabIndex = 30
        Me.inputPesanan.Text = "Input Pesanan"
        Me.inputPesanan.UseVisualStyleBackColor = True
        '
        'bayar
        '
        Me.bayar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bayar.Location = New System.Drawing.Point(623, 373)
        Me.bayar.Name = "bayar"
        Me.bayar.Size = New System.Drawing.Size(141, 24)
        Me.bayar.TabIndex = 28
        Me.bayar.Text = "Bayar"
        Me.bayar.UseVisualStyleBackColor = True
        '
        'namaPembeli
        '
        Me.namaPembeli.Location = New System.Drawing.Point(94, 87)
        Me.namaPembeli.Name = "namaPembeli"
        Me.namaPembeli.Size = New System.Drawing.Size(121, 20)
        Me.namaPembeli.TabIndex = 47
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(46, 90)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 13)
        Me.Label7.TabIndex = 48
        Me.Label7.Text = "Nama :"
        '
        'hapusPesanan
        '
        Me.hapusPesanan.Location = New System.Drawing.Point(623, 112)
        Me.hapusPesanan.Name = "hapusPesanan"
        Me.hapusPesanan.Size = New System.Drawing.Size(141, 23)
        Me.hapusPesanan.TabIndex = 49
        Me.hapusPesanan.Text = "Hapus Pesanan"
        Me.hapusPesanan.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(46, 151)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 13)
        Me.Label8.TabIndex = 51
        Me.Label8.Text = "Jumlah :"
        '
        'JumlahBrg
        '
        Me.JumlahBrg.Location = New System.Drawing.Point(94, 148)
        Me.JumlahBrg.Name = "JumlahBrg"
        Me.JumlahBrg.Size = New System.Drawing.Size(39, 20)
        Me.JumlahBrg.TabIndex = 52
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(481, 143)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(109, 20)
        Me.TextBox2.TabIndex = 53
        '
        'LvMenu
        '
        Me.LvMenu.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.LvMenu.FullRowSelect = True
        Me.LvMenu.GridLines = True
        Me.LvMenu.HideSelection = False
        Me.LvMenu.Location = New System.Drawing.Point(49, 174)
        Me.LvMenu.Name = "LvMenu"
        Me.LvMenu.Size = New System.Drawing.Size(715, 193)
        Me.LvMenu.TabIndex = 54
        Me.LvMenu.UseCompatibleStateImageBehavior = False
        Me.LvMenu.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Nama Menu"
        Me.ColumnHeader1.Width = 201
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Porsi"
        Me.ColumnHeader2.Width = 96
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Jumlah"
        Me.ColumnHeader3.Width = 91
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Harga Satuan"
        Me.ColumnHeader4.Width = 115
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Total"
        Me.ColumnHeader5.Width = 206
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(388, 146)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 13)
        Me.Label9.TabIndex = 55
        Me.Label9.Text = "Kode Transaksi :"
        '
        'Tunai
        '
        Me.Tunai.Location = New System.Drawing.Point(391, 376)
        Me.Tunai.Maximum = New Decimal(New Integer() {1410065407, 2, 0, 0})
        Me.Tunai.Name = "Tunai"
        Me.Tunai.Size = New System.Drawing.Size(100, 20)
        Me.Tunai.TabIndex = 56
        '
        'Kasir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Tunai)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.LvMenu)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.JumlahBrg)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.hapusPesanan)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.namaPembeli)
        Me.Controls.Add(Me.TotalHarga)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Kembalian)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ComboMenu)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.hrgSatuan)
        Me.Controls.Add(Me.Satu)
        Me.Controls.Add(Me.Stgh)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.inputPesanan)
        Me.Controls.Add(Me.bayar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Kasir"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JumlahBrg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tunai, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TotalHarga As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Kembalian As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboMenu As ComboBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents hrgSatuan As TextBox
    Friend WithEvents Satu As RadioButton
    Public WithEvents Stgh As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents inputPesanan As Button
    Friend WithEvents bayar As Button
    Friend WithEvents namaPembeli As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents hapusPesanan As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents JumlahBrg As NumericUpDown
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents LvMenu As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents Label9 As Label
    Friend WithEvents Tunai As NumericUpDown
End Class
