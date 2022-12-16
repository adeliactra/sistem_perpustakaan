Public Class InfoTambahKoleksi

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        If Not String.IsNullOrEmpty(Perpustakaan.koleksi.GSGambar) Then
            PictBoxTambahKoleksi.Load(Perpustakaan.koleksi.GSGambar)
            PictBoxTambahKoleksi.SizeMode = PictureBoxSizeMode.StretchImage
        End If

        LblTampilInfoNamaKoleksi.Text = Perpustakaan.koleksi.GSNamaKoleksi
        LblTampilInfoJenisKoleksi.Text = Perpustakaan.koleksi.GSJenisKoleksi
        LblTampilInfoDeskripsi.Text = Perpustakaan.koleksi.GSDeskripsi
        LblTampilInfoPenerbit.Text = Perpustakaan.koleksi.GSPenerbit
        LblTampilInfoTahunTerbit.Text = Perpustakaan.koleksi.GSTahunTerbit
        LblTampilInfoLokasiRak.Text = Perpustakaan.koleksi.GSLokasiRak
        LblTampilInfoTanggalMasukKoleksi.Text = Perpustakaan.koleksi.GSTanggalMasuk
        LblTampilInfoStock.Text = Perpustakaan.koleksi.GSStock
        LblTampilInfoBahasa.Text = Perpustakaan.koleksi.GSBahasa

        ListBoxTampilInfoKategori.Items.Clear()
        For Each kat In Perpustakaan.koleksi.GSKategori
            ListBoxTampilInfoKategori.Items.Add(kat)
        Next
    End Sub

    Private Sub BtnTutupInfoTambahKoleksi_Click(sender As Object, e As EventArgs) Handles BtnTutupInfoTambahKoleksi.Click
        'Dim tambah_list = Perpustakaan.koleksi.GSNamaKoleksi
        'Perpustakaan.ListBoxKoleksi.Items.Add(tambah_list)
        Me.Close()
    End Sub
End Class