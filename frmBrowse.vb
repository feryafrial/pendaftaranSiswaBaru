Imports System.Data.OleDb
Imports System.Data
Public Class frmBrowse

    Public Data As List(Of CalonSiswa)
    Public ReturnSiswa As CalonSiswa
    Public CS As String

    Private Sub frmBrowse_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim i As Integer
        If Data IsNot Nothing Then
            For Each cs As CalonSiswa In Data
                ListView1.Items.Add(cs.NISN)
                ListView1.Items(i).SubItems.Add(cs.NamaLengkap)
                ListView1.Items(i).SubItems.Add(cs.TglLahir)
                ListView1.Items(i).SubItems.Add(cs.Alamat)
                ListView1.Items(i).SubItems.Add(cs.AsalSekolah)
                i += 1
            Next
        End If
    End Sub

    Private Sub ListView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.DoubleClick
        Dim nisn = ListView1.SelectedItems(0).SubItems(0).Text
        ReturnSiswa = CariSiswa(nisn)
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Function CariSiswa(ByVal nisn As String) As CalonSiswa
        Dim olecon As New OleDbConnection(cs)
        Dim cmd As String
        Dim reader As OleDbDataReader
        Dim sqlcom As OleDbCommand
        Dim param As OleDbParameter
        Dim siswa As CalonSiswa = Nothing
        Try
            olecon.Open()
            cmd = "Select * from Siswa Where NISN=@nisn"
            sqlcom = New OleDbCommand(cmd, olecon)

            param = New OleDbParameter("@nisn", DbType.String)
            param.Value = nisn
            sqlcom.Parameters.Add(param)

            reader = sqlcom.ExecuteReader
            While reader.Read
                siswa = New CalonSiswa
                siswa.NamaLengkap = reader("NamaSiswa")
                siswa.NISN = reader("nisn")
                siswa.Alamat = reader("alamat")
                siswa.JenisKel = reader("jeniskelamin")
                siswa.Agama = reader("agama")
                siswa.TglLahir = reader("tgllahir")
                siswa.AsalSekolah = reader("asalSekolah")
                siswa.AlamatSekolahAsal = reader("AlamatSekolah")
                siswa.NoIjazah = reader("noIjazah")
                siswa.NamaAyah = reader("namaAyah")
                siswa.NamaIbu = reader("namaibu")
                siswa.PekerjaanAyah = reader("pekerjaanAyah")
                siswa.PekerjaanIbu = reader("pekerjaanIbu")

            End While
            reader.Close()

        Catch ex As Exception

        End Try
        Return siswa
    End Function


End Class