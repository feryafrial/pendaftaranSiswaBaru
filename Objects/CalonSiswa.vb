Public Class CalonSiswa
    Dim _nisn As String
    Dim _noreg As String
    Dim _namaLengkap As String
    Dim _alamat As String
    Dim _agama As String
    Dim _jenisKel As String
    Dim _tglLahir As Date

    Dim _asalSekolah As String
    Dim _alamatSekolahAsal As String
    Dim _noIjazah As String

    Dim _namaAyah As String
    Dim _namaIbu As String
    Dim _pekerjaanAyah As String
    Dim _pekerjaanIbu As String

    Dim _exists As Boolean

    Public Property NISN() As String
        Get
            Return _nisn
        End Get
        Set(ByVal value As String)
            _nisn = value
        End Set
    End Property

    Public Property Exists() As Boolean
        Get
            Return _exists
        End Get
        Set(ByVal value As Boolean)
            _exists = value
        End Set
    End Property

    Public Property TglLahir() As Date
        Get
            Return _tglLahir
        End Get
        Set(ByVal value As Date)
            _tglLahir = value
        End Set
    End Property
    Public Property NoReg() As String
        Get
            Return _noreg
        End Get
        Set(ByVal value As String)
            _noreg = value
        End Set
    End Property
    Public Property NamaLengkap() As String
        Get
            Return _namaLengkap
        End Get
        Set(ByVal value As String)
            _namaLengkap = value
        End Set
    End Property
    Public Property Alamat() As String
        Get
            Return _alamat
        End Get
        Set(ByVal value As String)
            _alamat = value
        End Set
    End Property
    Public Property Agama() As String
        Get
            Return _agama
        End Get
        Set(ByVal value As String)
            _agama = value
        End Set
    End Property
    Public Property JenisKel() As String
        Get
            Return _jenisKel
        End Get
        Set(ByVal value As String)
            _jenisKel = value
        End Set
    End Property
    Public Property AsalSekolah() As String
        Get
            Return _asalSekolah
        End Get
        Set(ByVal value As String)
            _asalSekolah = value
        End Set
    End Property
    Public Property AlamatSekolahAsal() As String
        Get
            Return _alamatSekolahAsal
        End Get
        Set(ByVal value As String)
            _alamatSekolahAsal = value
        End Set
    End Property
    Public Property NoIjazah() As String
        Get
            Return _noIjazah
        End Get
        Set(ByVal value As String)
            _noIjazah = value
        End Set
    End Property
    Public Property NamaAyah() As String
        Get
            Return _namaAyah
        End Get
        Set(ByVal value As String)
            _namaAyah = value
        End Set
    End Property
    Public Property NamaIbu() As String
        Get
            Return _namaIbu
        End Get
        Set(ByVal value As String)
            _namaIbu = value
        End Set
    End Property

    Public Property PekerjaanAyah() As String
        Get
            Return _pekerjaanAyah
        End Get
        Set(ByVal value As String)
            _pekerjaanAyah = value
        End Set
    End Property
    Public Property PekerjaanIbu() As String
        Get
            Return _pekerjaanIbu
        End Get
        Set(ByVal value As String)
            _pekerjaanIbu = value
        End Set
    End Property
End Class
