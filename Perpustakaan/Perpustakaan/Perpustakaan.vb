Public Class Perpustakaan

    Public Shared koleksi As Koleksi
    Public Shared selectedTableKoleksi
    Public Shared selectedTableKoleksiNama
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        koleksi = New Koleksi()
        'UpdateDateTableArrayList()
        ReloadDataTableDatabase()
    End Sub
    Private Sub TambahKoleksiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TambahKoleksiToolStripMenuItem.Click
        Dim TambahKoleksi = New TambahKoleksi()
        TambahKoleksi.Show()
    End Sub

    Private Sub TSBtnTambah_Click(sender As Object, e As EventArgs) Handles TSBtnTambah.Click
        Dim TambahKoleksi = New TambahKoleksi()
        TambahKoleksi.Show()
    End Sub

    Private Sub TSBtnHapus_Click(sender As Object, e As EventArgs) Handles TSBtnHapus.Click
        If ListBoxKoleksi.SelectedIndex >= 0 Then
            koleksi.GSHapusKoleksi = ListBoxKoleksi.SelectedItem()
            Dim HapusKoleksi = New HapusKoleksi()
            HapusKoleksi.Show()
        Else
            MessageBox.Show("Pilih koleksi yang ingin dihapus")
        End If
    End Sub

    'Public Sub UpdateDateTableArrayList()
    '    DataGridViewKoleksi.Rows.Clear()
    'For Each rowKoleksi In koleksi.getKoleksiDataTable()
    'Dim dataTable As String() = {rowKoleksi(0),
    '                                    rowKoleksi(1),
    '                                    rowKoleksi(2),
    '                                    rowKoleksi(3),
    '                                    rowKoleksi(4),
    '                                    rowKoleksi(5),
    '                                    rowKoleksi(6),
    '                                    rowKoleksi(7),
    '                                    rowKoleksi(8),
    '                                    rowKoleksi(9),
    '                                    rowKoleksi(10)}
    '        DataGridViewKoleksi.Rows.Add(dataTable)
    'Next
    'End Sub

    Private Sub Perpustakaan_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        'UpdateDateTableArrayList()
        ReloadDataTableDatabase()
    End Sub

    Private Sub DataGridViewKoleksi_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewKoleksi.CellClick
        'selectedTableKoleksi = DataGridViewKoleksi.CurrentRow.Index
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridViewKoleksi.Rows(index)

        selectedTableKoleksi = selectedRow.Cells(0).Value
        selectedTableKoleksiNama = selectedRow.Cells(1).Value
    End Sub

    Private Sub BtnShowSelect_Click(sender As Object, e As EventArgs) Handles BtnShowSelect.Click
        Dim dataselected As List(Of String) = koleksi.GetDataKoleksiByIDDatabse(selectedTableKoleksi)

        'MessageBox.Show(dataselected(10))

        koleksi.GSNamaKoleksi = dataselected(1)
        koleksi.GSJenisKoleksi = dataselected(5)
        koleksi.GSDeskripsi = dataselected(3)
        koleksi.GSPenerbit = dataselected(4)
        koleksi.GSTahunTerbit = dataselected(6)
        koleksi.GSLokasiRak = dataselected(7)
        koleksi.GSTanggalMasuk = dataselected(8)
        koleksi.GSStock = dataselected(9)
        koleksi.GSBahasa = dataselected(10)
        koleksi.GSGambar = dataselected(2)

        Dim data_kategori As List(Of String) = koleksi.ConvertStringToKoleksi(dataselected(11))

        koleksi.GSKategori.Clear()
        For Each info_kategori In data_kategori
            koleksi.GSKategori.Add(info_kategori)
        Next

        Dim infoTambah = New InfoTambahKoleksi
        infoTambah.Show()

    End Sub

    Private Sub ReloadDataTableDatabase()
        DataGridViewKoleksi.DataSource = koleksi.GetDataKoleksiDatabase()
        ListBoxKoleksi.DataSource = koleksi.GetDataName()
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Dim selectedKoleksi As List(Of String) = koleksi.GetDataKoleksiByIDDatabse(selectedTableKoleksi)

        'MessageBox.Show(selectedKoleksi(10))
        Try
            koleksi.GSNamaKoleksi = selectedKoleksi(1)
            koleksi.GSJenisKoleksi = selectedKoleksi(5)
            koleksi.GSDeskripsi = selectedKoleksi(3)
            koleksi.GSPenerbit = selectedKoleksi(4)
            koleksi.GSTahunTerbit = selectedKoleksi(6)
            koleksi.GSLokasiRak = selectedKoleksi(7)
            koleksi.GSTanggalMasuk = selectedKoleksi(8)
            koleksi.GSStock = selectedKoleksi(9)
            koleksi.GSBahasa = selectedKoleksi(10)
            koleksi.GSGambar = selectedKoleksi(2)

            Dim data_kategori As List(Of String) = koleksi.ConvertStringToKoleksi(selectedKoleksi(11))

            koleksi.GSKategori.Clear()
            For Each info_kategori In data_kategori
                koleksi.GSKategori.Add(info_kategori)
            Next

            Dim formupdate = New UpdateKoleksi()
            formupdate.Show()
        Catch ex As Exception
            MsgBox("You have to choose any row yet!")
        End Try

    End Sub

    Private Sub BtnRemove_Click(sender As Object, e As EventArgs) Handles BtnRemove.Click

        Dim dataselected As List(Of String) = koleksi.GetDataKoleksiByIDDatabse(selectedTableKoleksi)
        koleksi.GSNamaKoleksi = dataselected(1)

        Dim formHapus = New HapusKoleksi()
        formHapus.Show()
    End Sub
End Class
