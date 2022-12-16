Public Class TambahKoleksi


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        TxtTahunTerbit.MaxLength = 4

        DateTimePickerTanggalMasukKoleksi.Format = DateTimePickerFormat.Custom
        DateTimePickerTanggalMasukKoleksi.CustomFormat = "yyyy/MM/dd"
    End Sub
    Private Sub TxtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNama.KeyPress
        If Not Char.IsLetterOrDigit(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("Karakter tidak dikenali")
        End If
    End Sub

    Private Sub TxtNama_Leave(sender As Object, e As EventArgs) Handles TxtNama.Leave
        If TxtNama.Text.Length < 1 Then
            TxtNama.Select()
            MessageBox.Show("Please add At lease 1 String")
        End If
    End Sub

    Private Sub RTBDeskripsi_KeyPress(sender As Object, e As KeyPressEventArgs) Handles RTBDeskripsi.KeyPress
        If Not Char.IsLetterOrDigit(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("Karakter tidak dikenali")
        End If
    End Sub

    Private Sub BtnTambahGambar_Click(sender As Object, e As EventArgs) Handles BtnTambahGambar.Click
        OpenFileDialog1.Title = "Tambahkan Foto"
        OpenFileDialog1.Filter = "Image Files (*.jpeg, *.jpg, *.png, *.bmap)|*.jpeg; *.jpg; *.png; *.bmap|All Files (*.*)|*.*"
        OpenFileDialog1.ShowDialog()

        Dim picKoleksiDir As String = OpenFileDialog1.FileName

        PictBoxTambahKoleksi.Load(picKoleksiDir)
        PictBoxTambahKoleksi.SizeMode = PictureBoxSizeMode.StretchImage
        Perpustakaan.koleksi.GSGambar = picKoleksiDir.ToString()
        Perpustakaan.koleksi.GSGambar = Perpustakaan.koleksi.GSGambar.Replace("\", "/")
    End Sub

    Private Sub TxtTahunTerbit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtTahunTerbit.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("Please Insert Number Only")
        End If
    End Sub

    Private Sub TxtTahunTerbit_Leave(sender As Object, e As EventArgs) Handles TxtTahunTerbit.Leave
        If TxtTahunTerbit.Text.Length < 1 Then
            TxtTahunTerbit.Select()
            MessageBox.Show("Please add At lease 1 Number")
        End If
    End Sub


    Private Sub TxtLokasiRak_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtLokasiRak.KeyPress
        If Not Char.IsLetterOrDigit(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("Karakter tidak dikenali")
        End If
    End Sub

    Private Sub TxtLokasiRak_Leave(sender As Object, e As EventArgs) Handles TxtLokasiRak.Leave
        If TxtLokasiRak.Text.Length < 1 Then
            TxtLokasiRak.Select()
            MessageBox.Show("Please add At lease 1 String")
        End If
    End Sub

    Private Sub TxtStock_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtStock.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("Please Insert Number Only")
        End If
    End Sub

    Private Sub TxtStock_Leave(sender As Object, e As EventArgs) Handles TxtStock.Leave
        If TxtStock.Text.Length < 1 Then
            TxtStock.Select()
            MessageBox.Show("Please add At lease 1 Number")
        End If
    End Sub

    Private Sub BtnTambahKoleksi_Click(sender As Object, e As EventArgs) Handles BtnTambahKoleksi.Click
        Perpustakaan.koleksi.GSNamaKoleksi = TxtNama.Text
        Perpustakaan.koleksi.GSJenisKoleksi = CBoxJenisKoleksi.Text
        Perpustakaan.koleksi.GSDeskripsi = RTBDeskripsi.Text
        Perpustakaan.koleksi.GSPenerbit = TxtPenerbit.Text
        Perpustakaan.koleksi.GSTahunTerbit = Integer.Parse(TxtTahunTerbit.Text)
        Perpustakaan.koleksi.GSLokasiRak = TxtLokasiRak.Text
        Perpustakaan.koleksi.GSTanggalMasuk = DateTimePickerTanggalMasukKoleksi.Value.ToString("yyyy/MM/dd")
        Perpustakaan.koleksi.GSStock = Integer.Parse(TxtStock.Text)

        If RdBtnBahasaIndonesia.Checked() Then
            Perpustakaan.koleksi.GSBahasa = RdBtnBahasaIndonesia.Text.ToString()
        ElseIf RdBtnBahasaInggris.Checked() Then
            Perpustakaan.koleksi.GSBahasa = RdBtnBahasaInggris.Text.ToString()
        End If

        Perpustakaan.koleksi.GSKategori.Clear()
        If CheckBoxSains.Checked() Then
            Perpustakaan.koleksi.GSKategori.Add("Sains")
        End If

        If CheckBoxSosial.Checked() Then
            Perpustakaan.koleksi.GSKategori.Add("Sosial")
        End If

        If CheckBoxTeknologi.Checked() Then
            Perpustakaan.koleksi.GSKategori.Add("Teknologi")
        End If

        If CheckBoxBudaya.Checked() Then
            Perpustakaan.koleksi.GSKategori.Add("Budaya")
        End If


        Dim convertedKoleksi = Perpustakaan.koleksi.ConvertKoleksiToString(Perpustakaan.koleksi.GSKategori)
        Perpustakaan.koleksi.AddDataKoleksiDatabase(Perpustakaan.koleksi.GSNamaKoleksi,
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


        Dim info_tambah_koleksi = New InfoTambahKoleksi()
        info_tambah_koleksi.Show()
        Me.Close()
    End Sub
End Class