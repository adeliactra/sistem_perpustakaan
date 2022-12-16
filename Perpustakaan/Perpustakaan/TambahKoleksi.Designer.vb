<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TambahKoleksi
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
        Me.LblTambahKoleksi = New System.Windows.Forms.Label()
        Me.PictBoxTambahKoleksi = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.BtnTambahGambar = New System.Windows.Forms.Button()
        Me.LblNamaKoleksi = New System.Windows.Forms.Label()
        Me.LblJenisKoleksi = New System.Windows.Forms.Label()
        Me.LblDeskripsi = New System.Windows.Forms.Label()
        Me.TxtNama = New System.Windows.Forms.TextBox()
        Me.CBoxJenisKoleksi = New System.Windows.Forms.ComboBox()
        Me.RTBDeskripsi = New System.Windows.Forms.RichTextBox()
        Me.LblTahunTerbit = New System.Windows.Forms.Label()
        Me.LblLokasiRak = New System.Windows.Forms.Label()
        Me.TxtTahunTerbit = New System.Windows.Forms.TextBox()
        Me.TxtLokasiRak = New System.Windows.Forms.TextBox()
        Me.LblTanggalMasukKoleksi = New System.Windows.Forms.Label()
        Me.DateTimePickerTanggalMasukKoleksi = New System.Windows.Forms.DateTimePicker()
        Me.LblStock = New System.Windows.Forms.Label()
        Me.TxtStock = New System.Windows.Forms.TextBox()
        Me.LblBahasa = New System.Windows.Forms.Label()
        Me.RdBtnBahasaIndonesia = New System.Windows.Forms.RadioButton()
        Me.GBoxBahasa = New System.Windows.Forms.GroupBox()
        Me.RdBtnBahasaInggris = New System.Windows.Forms.RadioButton()
        Me.LblKategori = New System.Windows.Forms.Label()
        Me.GBoxKategori = New System.Windows.Forms.GroupBox()
        Me.CheckBoxBudaya = New System.Windows.Forms.CheckBox()
        Me.CheckBoxTeknologi = New System.Windows.Forms.CheckBox()
        Me.CheckBoxSosial = New System.Windows.Forms.CheckBox()
        Me.CheckBoxSains = New System.Windows.Forms.CheckBox()
        Me.BtnTambahKoleksi = New System.Windows.Forms.Button()
        Me.TxtPenerbit = New System.Windows.Forms.TextBox()
        Me.LblPenerbit = New System.Windows.Forms.Label()
        CType(Me.PictBoxTambahKoleksi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBoxBahasa.SuspendLayout()
        Me.GBoxKategori.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblTambahKoleksi
        '
        Me.LblTambahKoleksi.AutoSize = True
        Me.LblTambahKoleksi.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblTambahKoleksi.Location = New System.Drawing.Point(12, 9)
        Me.LblTambahKoleksi.Name = "LblTambahKoleksi"
        Me.LblTambahKoleksi.Size = New System.Drawing.Size(192, 32)
        Me.LblTambahKoleksi.TabIndex = 0
        Me.LblTambahKoleksi.Text = "Tambah Koleksi"
        '
        'PictBoxTambahKoleksi
        '
        Me.PictBoxTambahKoleksi.Location = New System.Drawing.Point(12, 54)
        Me.PictBoxTambahKoleksi.Name = "PictBoxTambahKoleksi"
        Me.PictBoxTambahKoleksi.Size = New System.Drawing.Size(100, 133)
        Me.PictBoxTambahKoleksi.TabIndex = 1
        Me.PictBoxTambahKoleksi.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'BtnTambahGambar
        '
        Me.BtnTambahGambar.Location = New System.Drawing.Point(12, 193)
        Me.BtnTambahGambar.Name = "BtnTambahGambar"
        Me.BtnTambahGambar.Size = New System.Drawing.Size(100, 39)
        Me.BtnTambahGambar.TabIndex = 2
        Me.BtnTambahGambar.Text = "Tambah Gambar"
        Me.BtnTambahGambar.UseVisualStyleBackColor = True
        '
        'LblNamaKoleksi
        '
        Me.LblNamaKoleksi.AutoSize = True
        Me.LblNamaKoleksi.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblNamaKoleksi.Location = New System.Drawing.Point(163, 54)
        Me.LblNamaKoleksi.Name = "LblNamaKoleksi"
        Me.LblNamaKoleksi.Size = New System.Drawing.Size(105, 21)
        Me.LblNamaKoleksi.TabIndex = 3
        Me.LblNamaKoleksi.Text = "Nama Koleksi"
        '
        'LblJenisKoleksi
        '
        Me.LblJenisKoleksi.AutoSize = True
        Me.LblJenisKoleksi.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblJenisKoleksi.Location = New System.Drawing.Point(163, 91)
        Me.LblJenisKoleksi.Name = "LblJenisKoleksi"
        Me.LblJenisKoleksi.Size = New System.Drawing.Size(97, 21)
        Me.LblJenisKoleksi.TabIndex = 4
        Me.LblJenisKoleksi.Text = "Jenis Koleksi"
        '
        'LblDeskripsi
        '
        Me.LblDeskripsi.AutoSize = True
        Me.LblDeskripsi.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblDeskripsi.Location = New System.Drawing.Point(163, 129)
        Me.LblDeskripsi.Name = "LblDeskripsi"
        Me.LblDeskripsi.Size = New System.Drawing.Size(74, 21)
        Me.LblDeskripsi.TabIndex = 5
        Me.LblDeskripsi.Text = "Deskripsi"
        '
        'TxtNama
        '
        Me.TxtNama.Location = New System.Drawing.Point(342, 56)
        Me.TxtNama.Name = "TxtNama"
        Me.TxtNama.Size = New System.Drawing.Size(308, 23)
        Me.TxtNama.TabIndex = 6
        '
        'CBoxJenisKoleksi
        '
        Me.CBoxJenisKoleksi.FormattingEnabled = True
        Me.CBoxJenisKoleksi.Items.AddRange(New Object() {"Buku", "Ensiklopedia", "Koran", "Majalah", "Publikasi Penelitian"})
        Me.CBoxJenisKoleksi.Location = New System.Drawing.Point(342, 93)
        Me.CBoxJenisKoleksi.Name = "CBoxJenisKoleksi"
        Me.CBoxJenisKoleksi.Size = New System.Drawing.Size(308, 23)
        Me.CBoxJenisKoleksi.TabIndex = 7
        '
        'RTBDeskripsi
        '
        Me.RTBDeskripsi.Location = New System.Drawing.Point(342, 131)
        Me.RTBDeskripsi.Name = "RTBDeskripsi"
        Me.RTBDeskripsi.Size = New System.Drawing.Size(308, 111)
        Me.RTBDeskripsi.TabIndex = 8
        Me.RTBDeskripsi.Text = ""
        '
        'LblTahunTerbit
        '
        Me.LblTahunTerbit.AutoSize = True
        Me.LblTahunTerbit.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblTahunTerbit.Location = New System.Drawing.Point(163, 294)
        Me.LblTahunTerbit.Name = "LblTahunTerbit"
        Me.LblTahunTerbit.Size = New System.Drawing.Size(93, 21)
        Me.LblTahunTerbit.TabIndex = 9
        Me.LblTahunTerbit.Text = "Tahun Terbit"
        '
        'LblLokasiRak
        '
        Me.LblLokasiRak.AutoSize = True
        Me.LblLokasiRak.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblLokasiRak.Location = New System.Drawing.Point(163, 332)
        Me.LblLokasiRak.Name = "LblLokasiRak"
        Me.LblLokasiRak.Size = New System.Drawing.Size(84, 21)
        Me.LblLokasiRak.TabIndex = 10
        Me.LblLokasiRak.Text = "Lokasi Rak"
        '
        'TxtTahunTerbit
        '
        Me.TxtTahunTerbit.Location = New System.Drawing.Point(342, 296)
        Me.TxtTahunTerbit.Name = "TxtTahunTerbit"
        Me.TxtTahunTerbit.Size = New System.Drawing.Size(308, 23)
        Me.TxtTahunTerbit.TabIndex = 11
        '
        'TxtLokasiRak
        '
        Me.TxtLokasiRak.Location = New System.Drawing.Point(342, 334)
        Me.TxtLokasiRak.Name = "TxtLokasiRak"
        Me.TxtLokasiRak.Size = New System.Drawing.Size(308, 23)
        Me.TxtLokasiRak.TabIndex = 12
        '
        'LblTanggalMasukKoleksi
        '
        Me.LblTanggalMasukKoleksi.AutoSize = True
        Me.LblTanggalMasukKoleksi.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblTanggalMasukKoleksi.Location = New System.Drawing.Point(163, 376)
        Me.LblTanggalMasukKoleksi.Name = "LblTanggalMasukKoleksi"
        Me.LblTanggalMasukKoleksi.Size = New System.Drawing.Size(166, 21)
        Me.LblTanggalMasukKoleksi.TabIndex = 13
        Me.LblTanggalMasukKoleksi.Text = "Tanggal Masuk Koleksi"
        '
        'DateTimePickerTanggalMasukKoleksi
        '
        Me.DateTimePickerTanggalMasukKoleksi.Location = New System.Drawing.Point(342, 375)
        Me.DateTimePickerTanggalMasukKoleksi.Name = "DateTimePickerTanggalMasukKoleksi"
        Me.DateTimePickerTanggalMasukKoleksi.Size = New System.Drawing.Size(308, 23)
        Me.DateTimePickerTanggalMasukKoleksi.TabIndex = 14
        '
        'LblStock
        '
        Me.LblStock.AutoSize = True
        Me.LblStock.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblStock.Location = New System.Drawing.Point(163, 415)
        Me.LblStock.Name = "LblStock"
        Me.LblStock.Size = New System.Drawing.Size(47, 21)
        Me.LblStock.TabIndex = 15
        Me.LblStock.Text = "Stock"
        '
        'TxtStock
        '
        Me.TxtStock.Location = New System.Drawing.Point(342, 417)
        Me.TxtStock.Name = "TxtStock"
        Me.TxtStock.Size = New System.Drawing.Size(308, 23)
        Me.TxtStock.TabIndex = 16
        '
        'LblBahasa
        '
        Me.LblBahasa.AutoSize = True
        Me.LblBahasa.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblBahasa.Location = New System.Drawing.Point(163, 457)
        Me.LblBahasa.Name = "LblBahasa"
        Me.LblBahasa.Size = New System.Drawing.Size(59, 21)
        Me.LblBahasa.TabIndex = 17
        Me.LblBahasa.Text = "Bahasa"
        '
        'RdBtnBahasaIndonesia
        '
        Me.RdBtnBahasaIndonesia.AutoSize = True
        Me.RdBtnBahasaIndonesia.Location = New System.Drawing.Point(6, 22)
        Me.RdBtnBahasaIndonesia.Name = "RdBtnBahasaIndonesia"
        Me.RdBtnBahasaIndonesia.Size = New System.Drawing.Size(116, 19)
        Me.RdBtnBahasaIndonesia.TabIndex = 18
        Me.RdBtnBahasaIndonesia.TabStop = True
        Me.RdBtnBahasaIndonesia.Text = "Bahasa Indonesia"
        Me.RdBtnBahasaIndonesia.UseVisualStyleBackColor = True
        '
        'GBoxBahasa
        '
        Me.GBoxBahasa.Controls.Add(Me.RdBtnBahasaInggris)
        Me.GBoxBahasa.Controls.Add(Me.RdBtnBahasaIndonesia)
        Me.GBoxBahasa.Location = New System.Drawing.Point(342, 457)
        Me.GBoxBahasa.Name = "GBoxBahasa"
        Me.GBoxBahasa.Size = New System.Drawing.Size(308, 81)
        Me.GBoxBahasa.TabIndex = 19
        Me.GBoxBahasa.TabStop = False
        Me.GBoxBahasa.Text = "Bahasa"
        '
        'RdBtnBahasaInggris
        '
        Me.RdBtnBahasaInggris.AutoSize = True
        Me.RdBtnBahasaInggris.Location = New System.Drawing.Point(6, 47)
        Me.RdBtnBahasaInggris.Name = "RdBtnBahasaInggris"
        Me.RdBtnBahasaInggris.Size = New System.Drawing.Size(101, 19)
        Me.RdBtnBahasaInggris.TabIndex = 19
        Me.RdBtnBahasaInggris.TabStop = True
        Me.RdBtnBahasaInggris.Text = "Bahasa Inggris"
        Me.RdBtnBahasaInggris.UseVisualStyleBackColor = True
        '
        'LblKategori
        '
        Me.LblKategori.AutoSize = True
        Me.LblKategori.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblKategori.Location = New System.Drawing.Point(163, 547)
        Me.LblKategori.Name = "LblKategori"
        Me.LblKategori.Size = New System.Drawing.Size(68, 21)
        Me.LblKategori.TabIndex = 20
        Me.LblKategori.Text = "Kategori"
        '
        'GBoxKategori
        '
        Me.GBoxKategori.Controls.Add(Me.CheckBoxBudaya)
        Me.GBoxKategori.Controls.Add(Me.CheckBoxTeknologi)
        Me.GBoxKategori.Controls.Add(Me.CheckBoxSosial)
        Me.GBoxKategori.Controls.Add(Me.CheckBoxSains)
        Me.GBoxKategori.Location = New System.Drawing.Point(342, 547)
        Me.GBoxKategori.Name = "GBoxKategori"
        Me.GBoxKategori.Size = New System.Drawing.Size(308, 80)
        Me.GBoxKategori.TabIndex = 21
        Me.GBoxKategori.TabStop = False
        Me.GBoxKategori.Text = "Kategori"
        '
        'CheckBoxBudaya
        '
        Me.CheckBoxBudaya.AutoSize = True
        Me.CheckBoxBudaya.Location = New System.Drawing.Point(126, 47)
        Me.CheckBoxBudaya.Name = "CheckBoxBudaya"
        Me.CheckBoxBudaya.Size = New System.Drawing.Size(65, 19)
        Me.CheckBoxBudaya.TabIndex = 3
        Me.CheckBoxBudaya.Text = "Budaya"
        Me.CheckBoxBudaya.UseVisualStyleBackColor = True
        '
        'CheckBoxTeknologi
        '
        Me.CheckBoxTeknologi.AutoSize = True
        Me.CheckBoxTeknologi.Location = New System.Drawing.Point(126, 22)
        Me.CheckBoxTeknologi.Name = "CheckBoxTeknologi"
        Me.CheckBoxTeknologi.Size = New System.Drawing.Size(77, 19)
        Me.CheckBoxTeknologi.TabIndex = 2
        Me.CheckBoxTeknologi.Text = "Teknologi"
        Me.CheckBoxTeknologi.UseVisualStyleBackColor = True
        '
        'CheckBoxSosial
        '
        Me.CheckBoxSosial.AutoSize = True
        Me.CheckBoxSosial.Location = New System.Drawing.Point(6, 47)
        Me.CheckBoxSosial.Name = "CheckBoxSosial"
        Me.CheckBoxSosial.Size = New System.Drawing.Size(56, 19)
        Me.CheckBoxSosial.TabIndex = 1
        Me.CheckBoxSosial.Text = "Sosial"
        Me.CheckBoxSosial.UseVisualStyleBackColor = True
        '
        'CheckBoxSains
        '
        Me.CheckBoxSains.AutoSize = True
        Me.CheckBoxSains.Location = New System.Drawing.Point(6, 22)
        Me.CheckBoxSains.Name = "CheckBoxSains"
        Me.CheckBoxSains.Size = New System.Drawing.Size(53, 19)
        Me.CheckBoxSains.TabIndex = 0
        Me.CheckBoxSains.Text = "Sains"
        Me.CheckBoxSains.UseVisualStyleBackColor = True
        '
        'BtnTambahKoleksi
        '
        Me.BtnTambahKoleksi.Location = New System.Drawing.Point(520, 653)
        Me.BtnTambahKoleksi.Name = "BtnTambahKoleksi"
        Me.BtnTambahKoleksi.Size = New System.Drawing.Size(130, 23)
        Me.BtnTambahKoleksi.TabIndex = 22
        Me.BtnTambahKoleksi.Text = "Tambah Koleksi"
        Me.BtnTambahKoleksi.UseVisualStyleBackColor = True
        '
        'TxtPenerbit
        '
        Me.TxtPenerbit.Location = New System.Drawing.Point(342, 257)
        Me.TxtPenerbit.Name = "TxtPenerbit"
        Me.TxtPenerbit.Size = New System.Drawing.Size(308, 23)
        Me.TxtPenerbit.TabIndex = 24
        '
        'LblPenerbit
        '
        Me.LblPenerbit.AutoSize = True
        Me.LblPenerbit.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblPenerbit.Location = New System.Drawing.Point(163, 255)
        Me.LblPenerbit.Name = "LblPenerbit"
        Me.LblPenerbit.Size = New System.Drawing.Size(67, 21)
        Me.LblPenerbit.TabIndex = 23
        Me.LblPenerbit.Text = "Penerbit"
        '
        'TambahKoleksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(704, 780)
        Me.Controls.Add(Me.TxtPenerbit)
        Me.Controls.Add(Me.LblPenerbit)
        Me.Controls.Add(Me.BtnTambahKoleksi)
        Me.Controls.Add(Me.GBoxKategori)
        Me.Controls.Add(Me.LblKategori)
        Me.Controls.Add(Me.GBoxBahasa)
        Me.Controls.Add(Me.LblBahasa)
        Me.Controls.Add(Me.TxtStock)
        Me.Controls.Add(Me.LblStock)
        Me.Controls.Add(Me.DateTimePickerTanggalMasukKoleksi)
        Me.Controls.Add(Me.LblTanggalMasukKoleksi)
        Me.Controls.Add(Me.TxtLokasiRak)
        Me.Controls.Add(Me.TxtTahunTerbit)
        Me.Controls.Add(Me.LblLokasiRak)
        Me.Controls.Add(Me.LblTahunTerbit)
        Me.Controls.Add(Me.RTBDeskripsi)
        Me.Controls.Add(Me.CBoxJenisKoleksi)
        Me.Controls.Add(Me.TxtNama)
        Me.Controls.Add(Me.LblDeskripsi)
        Me.Controls.Add(Me.LblJenisKoleksi)
        Me.Controls.Add(Me.LblNamaKoleksi)
        Me.Controls.Add(Me.BtnTambahGambar)
        Me.Controls.Add(Me.PictBoxTambahKoleksi)
        Me.Controls.Add(Me.LblTambahKoleksi)
        Me.Name = "TambahKoleksi"
        Me.Text = "TambahKoleksi"
        CType(Me.PictBoxTambahKoleksi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBoxBahasa.ResumeLayout(False)
        Me.GBoxBahasa.PerformLayout()
        Me.GBoxKategori.ResumeLayout(False)
        Me.GBoxKategori.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblTambahKoleksi As Label
    Friend WithEvents PictBoxTambahKoleksi As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents BtnTambahGambar As Button
    Friend WithEvents LblNamaKoleksi As Label
    Friend WithEvents LblJenisKoleksi As Label
    Friend WithEvents LblDeskripsi As Label
    Friend WithEvents TxtNama As TextBox
    Friend WithEvents CBoxJenisKoleksi As ComboBox
    Friend WithEvents RTBDeskripsi As RichTextBox
    Friend WithEvents LblTahunTerbit As Label
    Friend WithEvents LblLokasiRak As Label
    Friend WithEvents TxtTahunTerbit As TextBox
    Friend WithEvents TxtLokasiRak As TextBox
    Friend WithEvents LblTanggalMasukKoleksi As Label
    Friend WithEvents DateTimePickerTanggalMasukKoleksi As DateTimePicker
    Friend WithEvents LblStock As Label
    Friend WithEvents TxtStock As TextBox
    Friend WithEvents LblBahasa As Label
    Friend WithEvents RdBtnBahasaIndonesia As RadioButton
    Friend WithEvents GBoxBahasa As GroupBox
    Friend WithEvents RdBtnBahasaInggris As RadioButton
    Friend WithEvents LblKategori As Label
    Friend WithEvents GBoxKategori As GroupBox
    Friend WithEvents CheckBoxBudaya As CheckBox
    Friend WithEvents CheckBoxTeknologi As CheckBox
    Friend WithEvents CheckBoxSosial As CheckBox
    Friend WithEvents CheckBoxSains As CheckBox
    Friend WithEvents BtnTambahKoleksi As Button
    Friend WithEvents TxtPenerbit As TextBox
    Friend WithEvents LblPenerbit As Label
End Class
