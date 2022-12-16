Imports System.Text
Imports MySql.Data.MySqlClient
Public Class Koleksi

    Private fotokoleksi As String
    Private nama_koleksi As String
    Private jenis_koleksi As Object
    Private deskripsi As String
    Private penerbit As String
    Private tahun_terbit As Integer
    Private lokasi_rak As String
    Private tanggal_masuk As String
    Private stock As Integer
    Private bahasa As Object
    Private kategori As New List(Of String)
    Private hapuskoleksi As Object
    Private koleksiDataTable As New ArrayList()

    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Private sqlQuery As String

    Private server As String = "localhost"
    Private username As String = "root"
    Private password As String = ""
    Private database As String = "perpustakaan"
    Public Property GSHapusKoleksi() As Object
        Get
            Return hapuskoleksi
        End Get
        Set(value As Object)
            hapuskoleksi = value
        End Set
    End Property

    Public Property GSNamaKoleksi() As String
        Get
            Return nama_koleksi
        End Get
        Set(value As String)
            nama_koleksi = value
        End Set
    End Property

    Public Property GSJenisKoleksi() As Object
        Get
            Return jenis_koleksi
        End Get
        Set(value As Object)
            jenis_koleksi = value
        End Set
    End Property

    Public Property GSDeskripsi() As String
        Get
            Return deskripsi
        End Get
        Set(value As String)
            deskripsi = value
        End Set
    End Property

    Public Property GSTahunTerbit() As Integer
        Get
            Return tahun_terbit
        End Get
        Set(value As Integer)
            tahun_terbit = value
        End Set
    End Property
    Public Property GSLokasiRak() As String
        Get
            Return lokasi_rak
        End Get
        Set(value As String)
            lokasi_rak = value
        End Set
    End Property

    Public Property GSTanggalMasuk() As String
        Get
            Return tanggal_masuk
        End Get
        Set(value As String)
            tanggal_masuk = value
        End Set
    End Property

    Public Property GSStock() As Integer
        Get
            Return stock
        End Get
        Set(value As Integer)
            stock = value
        End Set
    End Property

    Public Property GSBahasa() As Object
        Get
            Return bahasa
        End Get
        Set(value As Object)
            bahasa = value
        End Set
    End Property
    Public Property GSGambar() As Object
        Get
            Return fotokoleksi
        End Get
        Set(value As Object)
            fotokoleksi = value
        End Set
    End Property
    Public Property GSKategori() As List(Of String)
        Get
            Return kategori
        End Get
        Set(value As List(Of String))
            kategori = value
        End Set
    End Property

    Public Property GSPenerbit() As String
        Get
            Return penerbit
        End Get
        Set(value As String)
            penerbit = value
        End Set
    End Property

    Public Function AddKoleksiDataTable(nama_koleksi As String,
                                        jenis_koleksi As String,
                                        deskripsi As String,
                                        penerbit As String,
                                        tahun_terbit As String,
                                        lokasi_rak As String,
                                        tanggal_masuk As String,
                                        stock As Integer,
                                        bahasa As String,
                                        kategori As String,
                                        fotokoleksi As String)

        koleksiDataTable.Add({nama_koleksi,
                             jenis_koleksi,
                             deskripsi,
                             penerbit,
                             tahun_terbit,
                             lokasi_rak,
                             tanggal_masuk,
                             stock,
                             bahasa,
                             kategori,
                             fotokoleksi})

    End Function

    Public Function RemoveKoleksiDataTable(index As Integer)
        koleksiDataTable.RemoveAt(index)
    End Function

    Public ReadOnly Property getKoleksiDataTable() As ArrayList
        Get
            Return koleksiDataTable
        End Get
    End Property

    Public Function ConvertKoleksiToString(vals As List(Of String))
        Dim builder As StringBuilder = New StringBuilder()
        For Each val As String In vals
            builder.Append(val).Append("|")
        Next

        'Convert to string
        Dim res = builder.ToString()
        Return res
    End Function

    Public Function ConvertStringToKoleksi(value As String)
        Dim arr() As String = value.Split("|")

        'Convert to list
        Dim vals As List(Of String) = arr.ToList()
        Return vals
    End Function

    Public Function GetDataKoleksiDatabase() As DataTable
        Dim result As New DataTable

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" + "password =" + password _
            + ";" + "database =" + database

        dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlCommand.CommandText = "SELECT id_koleksi AS 'ID',
                                  nama_koleksi AS 'Nama Koleksi',
                                  dir_gambar AS 'Gambar',
                                  deskripsi AS 'Deskripsi',
                                  penerbit AS 'Penerbit',
                                  jenis_koleksi AS 'Jenis Koleksi',
                                  tahun_terbit AS 'Tahu Terbit',
                                  lokasi AS 'Lokasi Rak',
                                  tanggal_masuk_koleksi AS 'Tanggal Masuk',
                                  stock AS 'Stock',
                                  bahasa AS 'Bahasa',
                                  kategori AS 'kategori'
                                  FROM koleksi"

            sqlRead = sqlCommand.ExecuteReader

            result.Load(sqlRead)
            sqlRead.Close()
            dbConn.Close()
        Return result


    End Function

    Public Function GetDataName()
        Dim result As New List(Of String)

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" + "password =" + password _
            + ";" + "database =" + database
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT nama_koleksi FROM koleksi"

        sqlRead = sqlCommand.ExecuteReader

        While sqlRead.Read
            result.Add(sqlRead.GetString(0))
        End While

        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function
    Public Function AddDataKoleksiDatabase(nama_koleksi As String,
                                        jenis_koleksi As String,
                                        deskripsi_koleksi As String,
                                        penerbit_koreksi As String,
                                        tahun_terbit As String,
                                        lokasi_rak As String,
                                        tanggal_masuk As String,
                                        stock_koleksi As Integer,
                                        bahasa_koleksi As String,
                                        kategori_koleksi As String,
                                        dir_gambar As String)

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" + "password =" + password _
            + ";" + "database =" + database
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "INSERT INTO KOLEKSI (nama_koleksi, dir_gambar, deskripsi, penerbit,
                        jenis_koleksi, tahun_terbit, lokasi, tanggal_masuk_koleksi,
                        stock, bahasa, kategori) VALUE ('" _
                        & nama_koleksi & "', '" _
                        & dir_gambar & "', '" _
                        & deskripsi_koleksi & "', '" _
                        & penerbit_koreksi & "', '" _
                        & jenis_koleksi & "', '" _
                        & tahun_terbit & "', '" _
                        & lokasi_rak & "', '" _
                        & tanggal_masuk & "', '" _
                        & stock_koleksi & "', '" _
                        & bahasa_koleksi & "', '" _
                        & kategori_koleksi & "')"
            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            dbConn.Close()

            'Perpustakaan.sqDt.Load(sqlReader)
            sqlRead.Close()
            dbConn.Close()
        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try
    End Function

    Public Function GetDataKoleksiByIDDatabse(ID As Integer) As List(Of String)
        Dim result As New List(Of String)

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" + "password =" + password _
            + ";" + "database =" + database
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT * FROM koleksi
                                  WHERE id_koleksi= '" & ID & "'"

        sqlRead = sqlCommand.ExecuteReader

        While sqlRead.Read
            result.Add(sqlRead.GetString(0).ToString())
            result.Add(sqlRead.GetString(1).ToString())
            result.Add(sqlRead.GetString(2).ToString())
            result.Add(sqlRead.GetString(3).ToString())
            result.Add(sqlRead.GetString(4).ToString())
            result.Add(sqlRead.GetString(5).ToString())
            result.Add(sqlRead.GetString(6).ToString())
            result.Add(sqlRead.GetString(7).ToString())
            result.Add(sqlRead.GetString(8).ToString())
            result.Add(sqlRead.GetString(9).ToString())
            result.Add(sqlRead.GetString(10).ToString())
            result.Add(sqlRead.GetString(11).ToString())
        End While

        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function

    Public Function UpdateDataKoleksiByIDDatabase(ID As Integer,
                                        nama_koleksi As String,
                                        jenis_koleksi As String,
                                        deskripsi_koleksi As String,
                                        penerbit_koleksi As String,
                                        tahun_terbit As String,
                                        lokasi_rak As String,
                                        tanggal_masuk As String,
                                        stock_koleksi As Integer,
                                        bahasa_koleksi As String,
                                        kategori_koleksi As String,
                                        dir_gambar As String)

        tahun_terbit = tahun_terbit.ToString()
        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" + "password =" + password _
            + ";" + "database =" + database

        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "UPDATE koleksi SET " _
                        + "nama_koleksi='" & nama_koleksi & "'," _
                        + "dir_gambar='" & dir_gambar & "'," _
                        + "deskripsi='" & deskripsi_koleksi & "'," _
                        + "penerbit='" & penerbit_koleksi & "'," _
                        + "jenis_koleksi='" & jenis_koleksi & "'," _
                        + "tahun_terbit='" & tahun_terbit & "'," _
                        + "lokasi='" & lokasi_rak & "'," _
                        + "tanggal_masuk_koleksi='" & tanggal_masuk & "'," _
                        + "stock='" & stock_koleksi & "'," _
                        + "bahasa='" & bahasa_koleksi & "'," _
                        + "kategori='" & kategori_koleksi & "' WHERE id_koleksi='" & ID & "' "
            Try
                sqlCommand = New MySqlCommand(sqlQuery, dbConn)
                sqlRead = sqlCommand.ExecuteReader
                dbConn.Close()

                'Perpustakaan.sqDt.Load(sqlReader)
                sqlRead.Close()
                dbConn.Close()
            Catch ex As Exception
                MessageBox.Show("Failed to update data : " & ex.Message.ToString())
            Finally
                dbConn.Dispose()
            End Try
            sqlRead.Close()
        Catch ex As Exception
            MessageBox.Show("Connection Error : " & ex.Message.ToString())
        End Try
    End Function

    Public Function DeleteDataKoleksiByIDDatabase(ID As Integer)
        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" + "password =" + password _
            + ";" + "database =" + database

        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "DELETE FROM koleksi " &
                       "WHERE id_koleksi='" & ID & "'"

            Debug.WriteLine(sqlQuery)

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            dbConn.Close()

            'Perpustakaan.sqlDt.Load(sqlRead)
            sqlRead.Close()
            dbConn.Close()
        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try

    End Function
End Class
