Public Class HapusKoleksi
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LblNamaKoleksiHapus.Text = Perpustakaan.koleksi.GSNamaKoleksi
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        'Perpustakaan.ListBoxKoleksi.Items.RemoveAt(Perpustakaan.ListBoxKoleksi.SelectedIndex)
        Perpustakaan.koleksi.DeleteDataKoleksiByIDDatabase(Perpustakaan.selectedTableKoleksi)
        Me.Close()
    End Sub
End Class