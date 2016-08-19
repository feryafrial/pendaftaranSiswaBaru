Imports System.Data.OleDb
Imports System.Data

Public Class frmUtama

    Dim _koneksi As OleDbConnection
    Private Sub frmUtama_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        _koneksi = New OleDbConnection
        Me.Hide()
        Dim fLog As New frmLogin
        If fLog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Me.Show()
            Try
                Dim cs As String = Configuration.ConfigurationManager.ConnectionStrings("datapsbConnectionString").ConnectionString
                _koneksi.ConnectionString = cs
                _koneksi.Open()
                statlabelInfo.Text = "ONLINE " & _koneksi.DataSource

                InitStatusLabel()
            Catch ex As Exception
                statlabelInfo.Text = "OFFLINE" & _koneksi.Database
            End Try
        End If

    End Sub

    Private Sub InitStatusLabel()
        statLabelTanggal.Text = Today.ToString("dd MMMM yyyy")
        statLabelJam.Text = Now.ToString("HH:mm")
        statLabelUser.Text = "Belum Login"

    End Sub

    Private Sub menuTransDaftar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuTransDaftar.Click
        Dim frm As New frmDaftar
        frm.ShowDialog()

    End Sub

    Private Sub menuLaporanSiswaBaru_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuLaporanSiswaBaru.Click
        Dim flap As New frmLap
        flap.Path = "\report\daftar.rdlc"

        flap.Show()
    End Sub

    Private Function getDataReport() As DataSet

    End Function
End Class
