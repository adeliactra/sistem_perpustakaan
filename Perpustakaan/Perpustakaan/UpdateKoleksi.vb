Public Class UpdateKoleksi
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        PictBoxUpdateKoleksi.Load(Perpustakaan.koleksi.GSGambar)
        PictBoxUpdateKoleksi.SizeMode = PictureBoxSizeMode.StretchImage
        DateTimePickerUpdateTanggalMasukKoleksi.Format = DateTimePickerFormat.Custom
        DateTimePickerUpdateTanggalMasukKoleksi.CustomFormat = "yyyy/MM/dd"
        TxtUpdateNama.Text = Perpustakaan.koleksi.GSNamaKoleksi
        CBoxUpdateJenisKoleksi.SelectedItem() = Perpustakaan.koleksi.GSJenisKoleksi
        RTBUpdateDeskripsi.Text = Perpustakaan.koleksi.GSDeskripsi
        TxtUpdatePenerbit.Text = Perpustakaan.koleksi.GSPenerbit
        TxtUpdateTahunTerbit.Text = Perpustakaan.koleksi.GSTahunTerbit
        TxtUpdateLokasiRak.Text = Perpustakaan.koleksi.GSLokasiRak
        DateTimePickerUpdateTanggalMasukKoleksi.Value = Perpustakaan.koleksi.GSTanggalMasuk
        TxtUpdateStock.Text = Perpustakaan.koleksi.GSStock

        If String.Compare(Perpustakaan.koleksi.GSBahasa, "Bahasa Indonesia") = 0 Then
            RdBtnUpdateBahasaIndonesia.Checked = True
        ElseIf String.Compare(Perpustakaan.koleksi.GSBahasa, "Bahasa Inggris") = 0 Then
            RdBtnUpdateBahasaInggris.Checked = True
        End If

        For Each kategori_item In Perpustakaan.koleksi.GSKategori
            If String.Compare(kategori_item, "Sains") = 0 Then
                CheckBoxUpdateSains.Checked = True
            ElseIf String.Compare(kategori_item, "Sosial") = 0 Then
                CheckBoxUpdateSosial.Checked = True
            ElseIf String.Compare(kategori_item, "Teknologi") = 0 Then
                CheckBoxUpdateTeknologi.Checked = True
            ElseIf String.Compare(kategori_item, "Budaya") = 0 Then
                CheckBoxUpdateBudaya.Checked = True
            End If
        Next

        Perpustakaan.koleksi.GSKategori.Clear()
        'slide61
    End Sub

    Private Sub BtnUpdateGambar_Click(sender As Object, e As EventArgs) Handles BtnUpdateGambar.Click
        OpenFileDialog1.Title = "Tambahkan Foto"
        OpenFileDialog1.Filter = "Image Files (*.jpeg, *.jpg, *.png, *.bmap)|*.jpeg; *.jpg; *.png; *.bmap|All Files (*.*)|*.*"
        OpenFileDialog1.ShowDialog()

        Dim picKoleksiDir As String = OpenFileDialog1.FileName

        PictBoxUpdateKoleksi.Load(picKoleksiDir)
        PictBoxUpdateKoleksi.SizeMode = PictureBoxSizeMode.StretchImage
        Perpustakaan.koleksi.GSGambar = picKoleksiDir.ToString()
        Perpustakaan.koleksi.GSGambar = Perpustakaan.koleksi.GSGambar.Replace("\", "/")
    End Sub

    Private Sub BtnUpdateKoleksi_Click(sender As Object, e As EventArgs) Handles BtnUpdateKoleksi.Click
        Perpustakaan.koleksi.GSNamaKoleksi = TxtUpdateNama.Text.ToString()
        Perpustakaan.koleksi.GSJenisKoleksi = CBoxUpdateJenisKoleksi.SelectedItem().ToString()
        Perpustakaan.koleksi.GSDeskripsi = RTBUpdateDeskripsi.Text.ToString()
        Perpustakaan.koleksi.GSPenerbit = TxtUpdatePenerbit.Text.ToString()
        Perpustakaan.koleksi.GSTahunTerbit = Integer.Parse(TxtUpdateTahunTerbit.Text)
        Perpustakaan.koleksi.GSLokasiRak = TxtUpdateLokasiRak.Text.ToString()
        Perpustakaan.koleksi.GSTanggalMasuk = DateTimePickerUpdateTanggalMasukKoleksi.Value.ToString("yyyy/MM/dd")
        Perpustakaan.koleksi.GSStock = Integer.Parse(TxtUpdateStock.Text)

        If RdBtnUpdateBahasaIndonesia.Checked Then
            Perpustakaan.koleksi.GSBahasa = "Indonesia"
        ElseIf RdBtnUpdateBahasaInggris.Checked Then
            Perpustakaan.koleksi.GSBahasa = "Inggris"
        End If

        If CheckBoxUpdateSains.Checked() Then
            Perpustakaan.koleksi.GSKategori.Add("Sains")
        End If

        If CheckBoxUpdateSosial.Checked() Then
            Perpustakaan.koleksi.GSKategori.Add("Sosial")
        End If

        If CheckBoxUpdateTeknologi.Checked() Then
            Perpustakaan.koleksi.GSKategori.Add("Teknologi")
        End If

        If CheckBoxUpdateBudaya.Checked() Then
            Perpustakaan.koleksi.GSKategori.Add("Budaya")
        End If

        'Perpustakaan.koleksi.add

        'Perpustakaan Koleksi
        Dim convertedKoleksi = Perpustakaan.koleksi.ConvertKoleksiToString(Perpustakaan.koleksi.GSKategori)

        Perpustakaan.koleksi.UpdateDataKoleksiByIDDatabase(Perpustakaan.selectedTableKoleksi,
                                                           Perpustakaan.koleksi.GSNamaKoleksi,
                                                           Perpustakaan.koleksi.GSJenisKoleksi,
                                                           Perpustakaan.koleksi.GSDeskripsi,
                                                           Perpustakaan.koleksi.GSPenerbit,
                                                           Perpustakaan.koleksi.GSTahunTerbit,
                                                           Perpustakaan.koleksi.GSLokasiRak,
                                                           Perpustakaan.koleksi.GSTanggalMasuk,
                                                           Perpustakaan.koleksi.GSStock,
                                                           Perpustakaan.koleksi.GSBahasa,
                                                           convertedKoleksi,
                                                           Perpustakaan.koleksi.GSGambar)

        Dim infoTambah = New InfoTambahKoleksi()
        infoTambah.Show()

        Me.Close()
    End Sub
End Class