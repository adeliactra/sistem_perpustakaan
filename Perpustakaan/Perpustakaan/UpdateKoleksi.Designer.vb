<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateKoleksi
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
        Me.LblPenerbit = New System.Windows.Forms.Label()
        Me.BtnUpdateKoleksi = New System.Windows.Forms.Button()
        Me.CheckBoxUpdateBudaya = New System.Windows.Forms.CheckBox()
        Me.CheckBoxUpdateTeknologi = New System.Windows.Forms.CheckBox()
        Me.CheckBoxUpdateSosial = New System.Windows.Forms.CheckBox()
        Me.CheckBoxUpdateSains = New System.Windows.Forms.CheckBox()
        Me.GBoxUpdateKategori = New System.Windows.Forms.GroupBox()
        Me.LblKategori = New System.Windows.Forms.Label()
        Me.RdBtnUpdateBahasaInggris = New System.Windows.Forms.RadioButton()
        Me.GBoxUpdateBahasa = New System.Windows.Forms.GroupBox()
        Me.RdBtnUpdateBahasaIndonesia = New System.Windows.Forms.RadioButton()
        Me.TxtUpdatePenerbit = New System.Windows.Forms.TextBox()
        Me.LblBahasa = New System.Windows.Forms.Label()
        Me.TxtUpdateStock = New System.Windows.Forms.TextBox()
        Me.LblStock = New System.Windows.Forms.Label()
        Me.DateTimePickerUpdateTanggalMasukKoleksi = New System.Windows.Forms.DateTimePicker()
        Me.TxtUpdateLokasiRak = New System.Windows.Forms.TextBox()
        Me.TxtUpdateTahunTerbit = New System.Windows.Forms.TextBox()
        Me.LblLokasiRak = New System.Windows.Forms.Label()
        Me.LblTahunTerbit = New System.Windows.Forms.Label()
        Me.RTBUpdateDeskripsi = New System.Windows.Forms.RichTextBox()
        Me.CBoxUpdateJenisKoleksi = New System.Windows.Forms.ComboBox()
        Me.TxtUpdateNama = New System.Windows.Forms.TextBox()
        Me.LblDeskripsi = New System.Windows.Forms.Label()
        Me.LblJenisKoleksi = New System.Windows.Forms.Label()
        Me.LblNamaKoleksi = New System.Windows.Forms.Label()
        Me.BtnUpdateGambar = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.LblTanggalMasukKoleksi = New System.Windows.Forms.Label()
        Me.PictBoxUpdateKoleksi = New System.Windows.Forms.PictureBox()
        Me.LblUpdateKoleksi = New System.Windows.Forms.Label()
        Me.GBoxUpdateKategori.SuspendLayout()
        Me.GBoxUpdateBahasa.SuspendLayout()
        CType(Me.PictBoxUpdateKoleksi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblPenerbit
        '
        Me.LblPenerbit.AutoSize = True
        Me.LblPenerbit.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblPenerbit.Location = New System.Drawing.Point(189, 261)
        Me.LblPenerbit.Name = "LblPenerbit"
        Me.LblPenerbit.Size = New System.Drawing.Size(67, 21)
        Me.LblPenerbit.TabIndex = 47
        Me.LblPenerbit.Text = "Penerbit"
        '
        'BtnUpdateKoleksi
        '
        Me.BtnUpdateKoleksi.Location = New System.Drawing.Point(546, 659)
        Me.BtnUpdateKoleksi.Name = "BtnUpdateKoleksi"
        Me.BtnUpdateKoleksi.Size = New System.Drawing.Size(130, 23)
        Me.BtnUpdateKoleksi.TabIndex = 46
        Me.BtnUpdateKoleksi.Text = "Update Koleksi"
        Me.BtnUpdateKoleksi.UseVisualStyleBackColor = True
        '
        'CheckBoxUpdateBudaya
        '
        Me.CheckBoxUpdateBudaya.AutoSize = True
        Me.CheckBoxUpdateBudaya.Location = New System.Drawing.Point(126, 47)
        Me.CheckBoxUpdateBudaya.Name = "CheckBoxUpdateBudaya"
        Me.CheckBoxUpdateBudaya.Size = New System.Drawing.Size(65, 19)
        Me.CheckBoxUpdateBudaya.TabIndex = 3
        Me.CheckBoxUpdateBudaya.Text = "Budaya"
        Me.CheckBoxUpdateBudaya.UseVisualStyleBackColor = True
        '
        'CheckBoxUpdateTeknologi
        '
        Me.CheckBoxUpdateTeknologi.AutoSize = True
        Me.CheckBoxUpdateTeknologi.Location = New System.Drawing.Point(126, 22)
        Me.CheckBoxUpdateTeknologi.Name = "CheckBoxUpdateTeknologi"
        Me.CheckBoxUpdateTeknologi.Size = New System.Drawing.Size(77, 19)
        Me.CheckBoxUpdateTeknologi.TabIndex = 2
        Me.CheckBoxUpdateTeknologi.Text = "Teknologi"
        Me.CheckBoxUpdateTeknologi.UseVisualStyleBackColor = True
        '
        'CheckBoxUpdateSosial
        '
        Me.CheckBoxUpdateSosial.AutoSize = True
        Me.CheckBoxUpdateSosial.Location = New System.Drawing.Point(6, 47)
        Me.CheckBoxUpdateSosial.Name = "CheckBoxUpdateSosial"
        Me.CheckBoxUpdateSosial.Size = New System.Drawing.Size(56, 19)
        Me.CheckBoxUpdateSosial.TabIndex = 1
        Me.CheckBoxUpdateSosial.Text = "Sosial"
        Me.CheckBoxUpdateSosial.UseVisualStyleBackColor = True
        '
        'CheckBoxUpdateSains
        '
        Me.CheckBoxUpdateSains.AutoSize = True
        Me.CheckBoxUpdateSains.Location = New System.Drawing.Point(6, 22)
        Me.CheckBoxUpdateSains.Name = "CheckBoxUpdateSains"
        Me.CheckBoxUpdateSains.Size = New System.Drawing.Size(53, 19)
        Me.CheckBoxUpdateSains.TabIndex = 0
        Me.CheckBoxUpdateSains.Text = "Sains"
        Me.CheckBoxUpdateSains.UseVisualStyleBackColor = True
        '
        'GBoxUpdateKategori
        '
        Me.GBoxUpdateKategori.Controls.Add(Me.CheckBoxUpdateBudaya)
        Me.GBoxUpdateKategori.Controls.Add(Me.CheckBoxUpdateTeknologi)
        Me.GBoxUpdateKategori.Controls.Add(Me.CheckBoxUpdateSosial)
        Me.GBoxUpdateKategori.Controls.Add(Me.CheckBoxUpdateSains)
        Me.GBoxUpdateKategori.Location = New System.Drawing.Point(368, 553)
        Me.GBoxUpdateKategori.Name = "GBoxUpdateKategori"
        Me.GBoxUpdateKategori.Size = New System.Drawing.Size(308, 80)
        Me.GBoxUpdateKategori.TabIndex = 45
        Me.GBoxUpdateKategori.TabStop = False
        Me.GBoxUpdateKategori.Text = "Kategori"
        '
        'LblKategori
        '
        Me.LblKategori.AutoSize = True
        Me.LblKategori.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblKategori.Location = New System.Drawing.Point(189, 553)
        Me.LblKategori.Name = "LblKategori"
        Me.LblKategori.Size = New System.Drawing.Size(68, 21)
        Me.LblKategori.TabIndex = 44
        Me.LblKategori.Text = "Kategori"
        '
        'RdBtnUpdateBahasaInggris
        '
        Me.RdBtnUpdateBahasaInggris.AutoSize = True
        Me.RdBtnUpdateBahasaInggris.Location = New System.Drawing.Point(6, 47)
        Me.RdBtnUpdateBahasaInggris.Name = "RdBtnUpdateBahasaInggris"
        Me.RdBtnUpdateBahasaInggris.Size = New System.Drawing.Size(101, 19)
        Me.RdBtnUpdateBahasaInggris.TabIndex = 19
        Me.RdBtnUpdateBahasaInggris.TabStop = True
        Me.RdBtnUpdateBahasaInggris.Text = "Bahasa Inggris"
        Me.RdBtnUpdateBahasaInggris.UseVisualStyleBackColor = True
        '
        'GBoxUpdateBahasa
        '
        Me.GBoxUpdateBahasa.Controls.Add(Me.RdBtnUpdateBahasaInggris)
        Me.GBoxUpdateBahasa.Controls.Add(Me.RdBtnUpdateBahasaIndonesia)
        Me.GBoxUpdateBahasa.Location = New System.Drawing.Point(368, 463)
        Me.GBoxUpdateBahasa.Name = "GBoxUpdateBahasa"
        Me.GBoxUpdateBahasa.Size = New System.Drawing.Size(308, 81)
        Me.GBoxUpdateBahasa.TabIndex = 43
        Me.GBoxUpdateBahasa.TabStop = False
        Me.GBoxUpdateBahasa.Text = "Bahasa"
        '
        'RdBtnUpdateBahasaIndonesia
        '
        Me.RdBtnUpdateBahasaIndonesia.AutoSize = True
        Me.RdBtnUpdateBahasaIndonesia.Location = New System.Drawing.Point(6, 22)
        Me.RdBtnUpdateBahasaIndonesia.Name = "RdBtnUpdateBahasaIndonesia"
        Me.RdBtnUpdateBahasaIndonesia.Size = New System.Drawing.Size(116, 19)
        Me.RdBtnUpdateBahasaIndonesia.TabIndex = 18
        Me.RdBtnUpdateBahasaIndonesia.TabStop = True
        Me.RdBtnUpdateBahasaIndonesia.Text = "Bahasa Indonesia"
        Me.RdBtnUpdateBahasaIndonesia.UseVisualStyleBackColor = True
        '
        'TxtUpdatePenerbit
        '
        Me.TxtUpdatePenerbit.Location = New System.Drawing.Point(368, 263)
        Me.TxtUpdatePenerbit.Name = "TxtUpdatePenerbit"
        Me.TxtUpdatePenerbit.Size = New System.Drawing.Size(308, 23)
        Me.TxtUpdatePenerbit.TabIndex = 48
        '
        'LblBahasa
        '
        Me.LblBahasa.AutoSize = True
        Me.LblBahasa.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblBahasa.Location = New System.Drawing.Point(189, 463)
        Me.LblBahasa.Name = "LblBahasa"
        Me.LblBahasa.Size = New System.Drawing.Size(59, 21)
        Me.LblBahasa.TabIndex = 42
        Me.LblBahasa.Text = "Bahasa"
        '
        'TxtUpdateStock
        '
        Me.TxtUpdateStock.Location = New System.Drawing.Point(368, 423)
        Me.TxtUpdateStock.Name = "TxtUpdateStock"
        Me.TxtUpdateStock.Size = New System.Drawing.Size(308, 23)
        Me.TxtUpdateStock.TabIndex = 41
        '
        'LblStock
        '
        Me.LblStock.AutoSize = True
        Me.LblStock.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblStock.Location = New System.Drawing.Point(189, 421)
        Me.LblStock.Name = "LblStock"
        Me.LblStock.Size = New System.Drawing.Size(47, 21)
        Me.LblStock.TabIndex = 40
        Me.LblStock.Text = "Stock"
        '
        'DateTimePickerUpdateTanggalMasukKoleksi
        '
        Me.DateTimePickerUpdateTanggalMasukKoleksi.Location = New System.Drawing.Point(368, 381)
        Me.DateTimePickerUpdateTanggalMasukKoleksi.Name = "DateTimePickerUpdateTanggalMasukKoleksi"
        Me.DateTimePickerUpdateTanggalMasukKoleksi.Size = New System.Drawing.Size(308, 23)
        Me.DateTimePickerUpdateTanggalMasukKoleksi.TabIndex = 39
        '
        'TxtUpdateLokasiRak
        '
        Me.TxtUpdateLokasiRak.Location = New System.Drawing.Point(368, 340)
        Me.TxtUpdateLokasiRak.Name = "TxtUpdateLokasiRak"
        Me.TxtUpdateLokasiRak.Size = New System.Drawing.Size(308, 23)
        Me.TxtUpdateLokasiRak.TabIndex = 37
        '
        'TxtUpdateTahunTerbit
        '
        Me.TxtUpdateTahunTerbit.Location = New System.Drawing.Point(368, 302)
        Me.TxtUpdateTahunTerbit.Name = "TxtUpdateTahunTerbit"
        Me.TxtUpdateTahunTerbit.Size = New System.Drawing.Size(308, 23)
        Me.TxtUpdateTahunTerbit.TabIndex = 36
        '
        'LblLokasiRak
        '
        Me.LblLokasiRak.AutoSize = True
        Me.LblLokasiRak.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblLokasiRak.Location = New System.Drawing.Point(189, 338)
        Me.LblLokasiRak.Name = "LblLokasiRak"
        Me.LblLokasiRak.Size = New System.Drawing.Size(84, 21)
        Me.LblLokasiRak.TabIndex = 35
        Me.LblLokasiRak.Text = "Lokasi Rak"
        '
        'LblTahunTerbit
        '
        Me.LblTahunTerbit.AutoSize = True
        Me.LblTahunTerbit.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblTahunTerbit.Location = New System.Drawing.Point(189, 300)
        Me.LblTahunTerbit.Name = "LblTahunTerbit"
        Me.LblTahunTerbit.Size = New System.Drawing.Size(93, 21)
        Me.LblTahunTerbit.TabIndex = 34
        Me.LblTahunTerbit.Text = "Tahun Terbit"
        '
        'RTBUpdateDeskripsi
        '
        Me.RTBUpdateDeskripsi.Location = New System.Drawing.Point(368, 137)
        Me.RTBUpdateDeskripsi.Name = "RTBUpdateDeskripsi"
        Me.RTBUpdateDeskripsi.Size = New System.Drawing.Size(308, 111)
        Me.RTBUpdateDeskripsi.TabIndex = 33
        Me.RTBUpdateDeskripsi.Text = ""
        '
        'CBoxUpdateJenisKoleksi
        '
        Me.CBoxUpdateJenisKoleksi.FormattingEnabled = True
        Me.CBoxUpdateJenisKoleksi.Items.AddRange(New Object() {"Buku", "Ensiklopedia", "Koran", "Majalah", "Publikasi Penelitian"})
        Me.CBoxUpdateJenisKoleksi.Location = New System.Drawing.Point(368, 99)
        Me.CBoxUpdateJenisKoleksi.Name = "CBoxUpdateJenisKoleksi"
        Me.CBoxUpdateJenisKoleksi.Size = New System.Drawing.Size(308, 23)
        Me.CBoxUpdateJenisKoleksi.TabIndex = 32
        '
        'TxtUpdateNama
        '
        Me.TxtUpdateNama.Location = New System.Drawing.Point(368, 62)
        Me.TxtUpdateNama.Name = "TxtUpdateNama"
        Me.TxtUpdateNama.Size = New System.Drawing.Size(308, 23)
        Me.TxtUpdateNama.TabIndex = 31
        '
        'LblDeskripsi
        '
        Me.LblDeskripsi.AutoSize = True
        Me.LblDeskripsi.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblDeskripsi.Location = New System.Drawing.Point(189, 135)
        Me.LblDeskripsi.Name = "LblDeskripsi"
        Me.LblDeskripsi.Size = New System.Drawing.Size(74, 21)
        Me.LblDeskripsi.TabIndex = 30
        Me.LblDeskripsi.Text = "Deskripsi"
        '
        'LblJenisKoleksi
        '
        Me.LblJenisKoleksi.AutoSize = True
        Me.LblJenisKoleksi.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblJenisKoleksi.Location = New System.Drawing.Point(189, 97)
        Me.LblJenisKoleksi.Name = "LblJenisKoleksi"
        Me.LblJenisKoleksi.Size = New System.Drawing.Size(97, 21)
        Me.LblJenisKoleksi.TabIndex = 29
        Me.LblJenisKoleksi.Text = "Jenis Koleksi"
        '
        'LblNamaKoleksi
        '
        Me.LblNamaKoleksi.AutoSize = True
        Me.LblNamaKoleksi.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblNamaKoleksi.Location = New System.Drawing.Point(189, 60)
        Me.LblNamaKoleksi.Name = "LblNamaKoleksi"
        Me.LblNamaKoleksi.Size = New System.Drawing.Size(105, 21)
        Me.LblNamaKoleksi.TabIndex = 28
        Me.LblNamaKoleksi.Text = "Nama Koleksi"
        '
        'BtnUpdateGambar
        '
        Me.BtnUpdateGambar.Location = New System.Drawing.Point(38, 199)
        Me.BtnUpdateGambar.Name = "BtnUpdateGambar"
        Me.BtnUpdateGambar.Size = New System.Drawing.Size(100, 39)
        Me.BtnUpdateGambar.TabIndex = 27
        Me.BtnUpdateGambar.Text = "Tambah Gambar"
        Me.BtnUpdateGambar.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'LblTanggalMasukKoleksi
        '
        Me.LblTanggalMasukKoleksi.AutoSize = True
        Me.LblTanggalMasukKoleksi.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblTanggalMasukKoleksi.Location = New System.Drawing.Point(189, 382)
        Me.LblTanggalMasukKoleksi.Name = "LblTanggalMasukKoleksi"
        Me.LblTanggalMasukKoleksi.Size = New System.Drawing.Size(166, 21)
        Me.LblTanggalMasukKoleksi.TabIndex = 38
        Me.LblTanggalMasukKoleksi.Text = "Tanggal Masuk Koleksi"
        '
        'PictBoxUpdateKoleksi
        '
        Me.PictBoxUpdateKoleksi.Location = New System.Drawing.Point(38, 60)
        Me.PictBoxUpdateKoleksi.Name = "PictBoxUpdateKoleksi"
        Me.PictBoxUpdateKoleksi.Size = New System.Drawing.Size(100, 133)
        Me.PictBoxUpdateKoleksi.TabIndex = 26
        Me.PictBoxUpdateKoleksi.TabStop = False
        '
        'LblUpdateKoleksi
        '
        Me.LblUpdateKoleksi.AutoSize = True
        Me.LblUpdateKoleksi.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblUpdateKoleksi.Location = New System.Drawing.Point(38, 15)
        Me.LblUpdateKoleksi.Name = "LblUpdateKoleksi"
        Me.LblUpdateKoleksi.Size = New System.Drawing.Size(185, 32)
        Me.LblUpdateKoleksi.TabIndex = 25
        Me.LblUpdateKoleksi.Text = "Update Koleksi"
        '
        'UpdateKoleksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(715, 696)
        Me.Controls.Add(Me.LblPenerbit)
        Me.Controls.Add(Me.BtnUpdateKoleksi)
        Me.Controls.Add(Me.GBoxUpdateKategori)
        Me.Controls.Add(Me.LblKategori)
        Me.Controls.Add(Me.GBoxUpdateBahasa)
        Me.Controls.Add(Me.TxtUpdatePenerbit)
        Me.Controls.Add(Me.LblBahasa)
        Me.Controls.Add(Me.TxtUpdateStock)
        Me.Controls.Add(Me.LblStock)
        Me.Controls.Add(Me.DateTimePickerUpdateTanggalMasukKoleksi)
        Me.Controls.Add(Me.TxtUpdateLokasiRak)
        Me.Controls.Add(Me.TxtUpdateTahunTerbit)
        Me.Controls.Add(Me.LblLokasiRak)
        Me.Controls.Add(Me.LblTahunTerbit)
        Me.Controls.Add(Me.RTBUpdateDeskripsi)
        Me.Controls.Add(Me.CBoxUpdateJenisKoleksi)
        Me.Controls.Add(Me.TxtUpdateNama)
        Me.Controls.Add(Me.LblDeskripsi)
        Me.Controls.Add(Me.LblJenisKoleksi)
        Me.Controls.Add(Me.LblNamaKoleksi)
        Me.Controls.Add(Me.BtnUpdateGambar)
        Me.Controls.Add(Me.LblTanggalMasukKoleksi)
        Me.Controls.Add(Me.PictBoxUpdateKoleksi)
        Me.Controls.Add(Me.LblUpdateKoleksi)
        Me.Name = "UpdateKoleksi"
        Me.Text = "UpdateKoleksi"
        Me.GBoxUpdateKategori.ResumeLayout(False)
        Me.GBoxUpdateKategori.PerformLayout()
        Me.GBoxUpdateBahasa.ResumeLayout(False)
        Me.GBoxUpdateBahasa.PerformLayout()
        CType(Me.PictBoxUpdateKoleksi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblPenerbit As Label
    Friend WithEvents BtnUpdateKoleksi As Button
    Friend WithEvents CheckBoxUpdateBudaya As CheckBox
    Friend WithEvents CheckBoxUpdateTeknologi As CheckBox
    Friend WithEvents CheckBoxUpdateSosial As CheckBox
    Friend WithEvents CheckBoxUpdateSains As CheckBox
    Friend WithEvents GBoxUpdateKategori As GroupBox
    Friend WithEvents LblKategori As Label
    Friend WithEvents RdBtnUpdateBahasaInggris As RadioButton
    Friend WithEvents GBoxUpdateBahasa As GroupBox
    Friend WithEvents RdBtnUpdateBahasaIndonesia As RadioButton
    Friend WithEvents TxtUpdatePenerbit As TextBox
    Friend WithEvents LblBahasa As Label
    Friend WithEvents TxtUpdateStock As TextBox
    Friend WithEvents LblStock As Label
    Friend WithEvents DateTimePickerUpdateTanggalMasukKoleksi As DateTimePicker
    Friend WithEvents TxtUpdateLokasiRak As TextBox
    Friend WithEvents TxtUpdateTahunTerbit As TextBox
    Friend WithEvents LblLokasiRak As Label
    Friend WithEvents LblTahunTerbit As Label
    Friend WithEvents RTBUpdateDeskripsi As RichTextBox
    Friend WithEvents CBoxUpdateJenisKoleksi As ComboBox
    Friend WithEvents TxtUpdateNama As TextBox
    Friend WithEvents LblDeskripsi As Label
    Friend WithEvents LblJenisKoleksi As Label
    Friend WithEvents LblNamaKoleksi As Label
    Friend WithEvents BtnUpdateGambar As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents LblTanggalMasukKoleksi As Label
    Friend WithEvents PictBoxUpdateKoleksi As PictureBox
    Friend WithEvents LblUpdateKoleksi As Label
End Class
