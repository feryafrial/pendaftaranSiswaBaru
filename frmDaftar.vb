Imports System.Data.OleDb
Imports System.Data
Imports System.Configuration
Public Class frmDaftar
    Dim _mode As String
    Dim cs As String
    Dim _siswaEdit As CalonSiswa

    Private Sub addButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addButton.Click
        _mode = "Baru"
        SetForm(_mode)
        SetToolbar(_mode)
    End Sub

    Private Sub clearForm()
        txtNISN.ResetText()
        txtNamaSiswa.ResetText()
        txtAlamatSiswa.ResetText()
        comboAgama.SelectedIndex = 0
        opsiLk.Checked = True
        dateTgLahir.Value = Today

        txtAsalSekolah.ResetText()
        txtAlamatSekolahAsal.ResetText()
        txtNoIjazah.ResetText()

        txtNamaAyah.ResetText()
        txtNamaIbu.ResetText()
        txtPkjAyah.ResetText()
        txtPkjIbu.ResetText()

        txtNISN.Focus()
    End Sub

    Private Sub SetForm(Optional ByVal modeForm As String = "")
        If modeForm = "" Then
            GroupBox1.Enabled = False
            GroupBox2.Enabled = False
            GroupBox3.Enabled = False
            clearForm()
        End If
        If modeForm = "Baru" Or modeForm = "Edit" Then
            GroupBox1.Enabled = True
            GroupBox2.Enabled = True
            GroupBox3.Enabled = True
            'txtNISN.Enabled = False
            txtNamaSiswa.Enabled = True
        End If
        If modeForm = "Cari" Then
            GroupBox1.Enabled = True
            GroupBox2.Enabled = False
            GroupBox3.Enabled = False

            txtNISN.Enabled = True
            txtNamaSiswa.Enabled = True


        End If
    End Sub

    Private Sub SetToolbar(Optional ByVal command As String = "")
        If command = "" Then
            addButton.Enabled = True
            findButton.Enabled = True
            cancelButton.Enabled = False
            saveButton.Enabled = False
            printButton.Enabled = False
            delButton.Enabled = False
            browseButton.Enabled = False
        End If
        If command = "Baru" Or command = "Cari" Then
            saveButton.Enabled = True
            cancelButton.Enabled = True
            addButton.Enabled = False
            findButton.Enabled = False
            printButton.Enabled = False
            delButton.Enabled = False
            browseButton.Enabled = False
            _mode = command
        End If
        If command = "Edit" Then
            saveButton.Enabled = True
            cancelButton.Enabled = True
            addButton.Enabled = False
            findButton.Enabled = False
            printButton.Enabled = True
            delButton.Enabled = True
            browseButton.Enabled = False
            _mode = command
        End If

        menuStrip.Text = command

    End Sub

    Private Sub frmDaftar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetToolbar()
        SetForm()

        cs = ConfigurationManager.ConnectionStrings("datapsbConnectionString").ConnectionString
    End Sub

    Private Sub saveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles saveButton.Click
        If _mode = "Baru" Then
            Dim casis As New CalonSiswa
            With casis
                .NISN = txtNISN.Text
                .NamaLengkap = txtNamaSiswa.Text
                .Alamat = txtAlamatSiswa.Text
                .Agama = comboAgama.Text
                .JenisKel = IIf(opsiLk.Checked, "L", "P")
                .TglLahir = dateTgLahir.Value
                .AsalSekolah = txtAsalSekolah.Text
                .AlamatSekolahAsal = txtAlamatSekolahAsal.Text
                .NoIjazah = txtNoIjazah.Text

                .NamaAyah = txtNamaAyah.Text
                .NamaIbu = txtNamaIbu.Text
                .PekerjaanAyah = txtPkjAyah.Text
                .PekerjaanIbu = txtPkjIbu.Text
            End With

            If Not CekNISN(txtNISN.Text) Then
                If SimpanData(casis) Then
                    MessageBox.Show("Data berhasil disimpan.", "Simpan Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    clearForm()

                    'SetToolbar()
                    'SetForm()
                End If
            Else
                MessageBox.Show("NISN sudah terdaftar dalam database. Silahkan periksa kembali inputan anda.")
            End If

        ElseIf _mode = "Cari" Then
            'MessageBox.Show("Mulai pencarian dan tampilkan data pertama")
            Dim hasil As List(Of CalonSiswa) = CariData()
            If hasil.Count <= 0 Then
                MessageBox.Show("Data tidak ditemukan.", "Cari Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                'clearForm()
                'SetToolbar()
                'SetForm()
            Else
                Dim fb As New frmBrowse
                fb.Data = hasil
                fb.CS = cs
                If fb.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    Dim siswa = fb.ReturnSiswa
                    _mode = "Edit"
                    txtNISN.Text = siswa.NISN
                    txtNamaSiswa.Text = siswa.NamaLengkap
                    txtAlamatSiswa.Text = siswa.Alamat
                    comboAgama.Text = siswa.Agama
                    If siswa.JenisKel = "L" Then
                        opsiLk.Checked = True
                    Else
                        opsiPr.Checked = True
                    End If
                    dateTgLahir.Value = siswa.TglLahir

                    txtAsalSekolah.Text = siswa.AsalSekolah
                    txtAlamatSekolahAsal.Text = siswa.AlamatSekolahAsal
                    txtNoIjazah.Text = siswa.NoIjazah

                    txtNamaAyah.Text = siswa.NamaAyah
                    txtNamaIbu.Text = siswa.NamaIbu
                    txtPkjAyah.Text = siswa.PekerjaanAyah
                    txtPkjIbu.Text = siswa.PekerjaanIbu

                    SetForm(_mode)
                    SetToolbar(_mode)
                End If

            End If
        ElseIf _mode = "Edit" Then
            Dim casis As New CalonSiswa
            With casis
                .NISN = txtNISN.Text
                .NamaLengkap = txtNamaSiswa.Text
                .Alamat = txtAlamatSiswa.Text
                .Agama = comboAgama.Text
                .JenisKel = IIf(opsiLk.Checked, "L", "P")
                .TglLahir = dateTgLahir.Value
                .AsalSekolah = txtAsalSekolah.Text
                .AlamatSekolahAsal = txtAlamatSekolahAsal.Text
                .NoIjazah = txtNoIjazah.Text

                .NamaAyah = txtNamaAyah.Text
                .NamaIbu = txtNamaIbu.Text
                .PekerjaanAyah = txtPkjAyah.Text
                .PekerjaanIbu = txtPkjIbu.Text
            End With
            If PerbaruiData(casis) Then
                MessageBox.Show("Data berhasil diperbarui.", "Perbarui Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
                clearForm()
                SetForm("Baru")
                SetToolbar("Baru")
            End If
        End If
    End Sub

    Private Sub cancelButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancelButton.Click
        SetForm()
        SetToolbar()
        'isi form dengan data sebelumnya
    End Sub

    Private Sub printButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles printButton.Click
        MessageBox.Show("Cetak formulir")
    End Sub

    Private Sub findButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles findButton.Click
        SetToolbar("Cari")
        SetForm("Cari")
    End Sub

    Private Sub delButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles delButton.Click
        Dim tanya As DialogResult

        tanya = MessageBox.Show("Data ini akan dihapus. Lanjutkan?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If tanya = Windows.Forms.DialogResult.Yes Then
            If HapusData(txtNISN.Text) Then
                MessageBox.Show("Data berhasil dihapus.", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                clearForm()
                SetForm("Baru")
                SetToolbar("Baru")
            End If
        End If
    End Sub

#Region " Fungsi dan Prosedur "
    Private Function SimpanData(ByVal data As CalonSiswa) As Boolean
        Dim con As OleDb.OleDbConnection = New OleDbConnection(cs)
        Dim cmd As String
        Dim sqlcom As OleDbCommand
        Dim param As OleDbParameter
        Dim hasil As Boolean
        Try
            con.Open()
            cmd = "Insert Into Siswa (NISN,NamaSiswa,Alamat,TglLahir,JenisKelamin,Agama,AsalSekolah,AlamatSekolah,NoIjazah,NamaAyah,NamaIbu,PekerjaanAyah,PekerjaanIbu) "
            cmd &= " values (@nisn,@namasiswa,@alamat,@tgllahir,@jk,@agama,@asal,@alamatasal,@ijz,@ayah,@ibu,@pkjAyah,@pkjIbu) "

            sqlcom = New OleDbCommand(cmd, con)
            param = New OleDbParameter("@nisn", DbType.String)
            param.Value = data.NISN
            sqlcom.Parameters.Add(param)
            param = New OleDbParameter("@namasiswa", DbType.String)
            param.Value = data.NamaLengkap
            sqlcom.Parameters.Add(param)
            param = New OleDbParameter("@alamat", DbType.String)
            param.Value = data.Alamat
            sqlcom.Parameters.Add(param)
            param = New OleDbParameter("@tgllahir", DbType.Date)
            param.Value = data.TglLahir
            sqlcom.Parameters.Add(param)
            param = New OleDbParameter("@jk", DbType.String)
            param.Value = data.JenisKel
            sqlcom.Parameters.Add(param)
            param = New OleDbParameter("@agama", DbType.String)
            param.Value = data.Agama
            sqlcom.Parameters.Add(param)
            param = New OleDbParameter("@asal", DbType.String)
            param.Value = data.AsalSekolah
            sqlcom.Parameters.Add(param)
            param = New OleDbParameter("@alamatasal", DbType.String)
            param.Value = data.AlamatSekolahAsal
            sqlcom.Parameters.Add(param)
            param = New OleDbParameter("@ijz", DbType.String)
            param.Value = data.NoIjazah
            sqlcom.Parameters.Add(param)
            param = New OleDbParameter("@ayah", DbType.String)
            param.Value = data.NamaAyah
            sqlcom.Parameters.Add(param)
            param = New OleDbParameter("@ibu", DbType.String)
            param.Value = data.NamaIbu
            sqlcom.Parameters.Add(param)
            param = New OleDbParameter("@pkjAyah", DbType.String)
            param.Value = data.PekerjaanAyah
            sqlcom.Parameters.Add(param)
            param = New OleDbParameter("@pkjIbu", DbType.String)
            param.Value = data.PekerjaanIbu
            sqlcom.Parameters.Add(param)

            sqlcom.ExecuteNonQuery()
            hasil = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return hasil
    End Function

    Private Function PerbaruiData(ByVal siswa As CalonSiswa) As Boolean
        Dim con As OleDb.OleDbConnection = New OleDbConnection(cs)
        Dim cmd As String
        Dim sqlcom As OleDbCommand
        Dim param As OleDbParameter
        Dim hasil As Boolean

        Try
            con.Open()

            cmd = "Update Siswa set NamaSiswa = ?, Alamat=?, TglLahir = ?, "
            cmd &= "JenisKelamin= ?,Agama= ?,AsalSekolah= ? ,AlamatSekolah= ?,"
            cmd &= "NoIjazah= ?,NamaAyah= ?,NamaIbu= ?,PekerjaanAyah= ?,PekerjaanIbu= ? "
            cmd &= "Where NISN = ?"

            sqlcom = New OleDbCommand(cmd, con)
            param = New OleDbParameter("?nama", DbType.String)
            param.Value = siswa.NamaLengkap
            sqlcom.Parameters.Add(param)

            param = New OleDbParameter("?alamat", DbType.String)
            param.Value = siswa.Alamat
            sqlcom.Parameters.Add(param)

            param = New OleDbParameter("?tgllhr", DbType.Date)
            param.Value = siswa.TglLahir
            sqlcom.Parameters.Add(param)

            param = New OleDbParameter("?jk", DbType.String)
            param.Value = siswa.JenisKel
            sqlcom.Parameters.Add(param)

            param = New OleDbParameter("?agama", DbType.String)
            param.Value = siswa.Agama
            sqlcom.Parameters.Add(param)

            param = New OleDbParameter("?asal", DbType.String)
            param.Value = siswa.AsalSekolah
            sqlcom.Parameters.Add(param)

            param = New OleDbParameter("?alamatasal", DbType.String)
            param.Value = siswa.AlamatSekolahAsal
            sqlcom.Parameters.Add(param)

            param = New OleDbParameter("?ijz", DbType.String)
            param.Value = siswa.NoIjazah
            sqlcom.Parameters.Add(param)

            param = New OleDbParameter("?ayah", DbType.String)
            param.Value = siswa.NamaAyah
            sqlcom.Parameters.Add(param)

            param = New OleDbParameter("?ibu", DbType.String)
            param.Value = siswa.NamaIbu
            sqlcom.Parameters.Add(param)

            param = New OleDbParameter("?pkAyah", DbType.String)
            param.Value = siswa.PekerjaanAyah
            sqlcom.Parameters.Add(param)

            param = New OleDbParameter("?pkIbu", DbType.String)
            param.Value = siswa.PekerjaanIbu
            sqlcom.Parameters.Add(param)

            param = New OleDbParameter("?nisn", DbType.String)
            param.Value = siswa.NISN
            sqlcom.Parameters.Add(param)

            sqlcom.ExecuteNonQuery()
            hasil = True
        Catch ex As Exception

        End Try
        Return hasil
    End Function

    Private Function CariData() As List(Of CalonSiswa)
        Dim olecon As New OleDbConnection(cs)
        Dim cmd As String
        Dim reader As OleDbDataReader
        Dim sqlcom As OleDbCommand
        Dim param As OleDbParameter
        Dim data As New List(Of CalonSiswa)
        Dim siswa As CalonSiswa
        Try
            olecon.Open()
            cmd = "Select * from Siswa Where (NISN like '%'+?+'%') OR (NamaSiswa like '%'+?+'%')"
            sqlcom = New OleDbCommand(cmd, olecon)

            param = New OleDbParameter("?nisn", DbType.String)
            param.Value = txtNISN.Text
            sqlcom.Parameters.Add(param)
            param = New OleDbParameter("?nama", DbType.String)
            param.Value = txtNamaSiswa.Text
            sqlcom.Parameters.Add(param)

            reader = sqlcom.ExecuteReader
            While reader.Read
                siswa = New CalonSiswa
                siswa.NamaLengkap = reader("NamaSiswa")
                siswa.NISN = reader("nisn")
                siswa.Alamat = reader("alamat")
                siswa.JenisKel = reader("jeniskelamin")
                siswa.Agama = reader("agama")
                siswa.AsalSekolah = reader("AsalSekolah")
                siswa.AlamatSekolahAsal = reader("AlamatSekolah")
                siswa.NoIjazah = reader("noIjazah")
                siswa.NamaAyah = reader("namaAyah")
                siswa.NamaIbu = reader("namaibu")
                siswa.PekerjaanAyah = reader("pekerjaanAyah")
                siswa.PekerjaanIbu = reader("pekerjaanIbu")

                data.Add(siswa)
            End While
            reader.Close()

        Catch ex As Exception

        End Try
        Return data
    End Function

    Private Function CekNISN(ByVal nisn As String) As Boolean
        Dim olecon As New OleDbConnection(cs)
        Dim cmd As String
        Dim reader As OleDbDataReader
        Dim sqlcom As OleDbCommand
        Dim param As OleDbParameter
        Dim hasil As Boolean
        Try
            olecon.Open()
            cmd = "Select * from Siswa Where NISN=@nisn"
            sqlcom = New OleDbCommand(cmd, olecon)

            param = New OleDbParameter("@nisn", DbType.String)
            param.Value = nisn
            sqlcom.Parameters.Add(param)

            reader = sqlcom.ExecuteReader
            While reader.Read
                hasil = True
            End While
            reader.Close()

        Catch ex As Exception

        End Try
        Return hasil
    End Function

    Private Function HapusData(ByVal nisn As String) As Boolean
        Dim con As OleDb.OleDbConnection = New OleDbConnection(cs)
        Dim cmd As String
        Dim sqlcom As OleDbCommand
        Dim param As OleDbParameter
        Dim hasil As Boolean

        Try
            con.Open()
            cmd = "Delete From Siswa Where Nisn=?"
            sqlcom = New OleDbCommand(cmd, con)
            param = New OleDbParameter("?nisn", DbType.String)
            param.Value = nisn
            sqlcom.Parameters.Add(param)

            sqlcom.ExecuteNonQuery()
            hasil = True
        Catch ex As Exception

        End Try
        Return hasil
    End Function
    
#End Region

    
End Class