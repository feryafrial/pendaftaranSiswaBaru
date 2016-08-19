Public Class UserInfo
    Dim _userId As String
    Dim _pwd As String
    Dim _nip As String

    Public Property NIP() As String
        Get
            Return _nip
        End Get
        Set(ByVal value As String)
            _nip = value
        End Set
    End Property

    Public Property Password() As String
        Get
            Return _pwd
        End Get
        Set(ByVal value As String)
            _pwd = value
        End Set
    End Property

    Public Property UserId() As String
        Get
            Return _userId
        End Get
        Set(ByVal value As String)
            _userId = value
        End Set
    End Property
End Class
