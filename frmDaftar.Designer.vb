<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDaftar
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtNoReg = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.opsiPr = New System.Windows.Forms.RadioButton
        Me.opsiLk = New System.Windows.Forms.RadioButton
        Me.Label12 = New System.Windows.Forms.Label
        Me.comboAgama = New System.Windows.Forms.ComboBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtAlamatSiswa = New System.Windows.Forms.TextBox
        Me.txtNamaSiswa = New System.Windows.Forms.TextBox
        Me.txtNISN = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtNoIjazah = New System.Windows.Forms.TextBox
        Me.txtAlamatSekolahAsal = New System.Windows.Forms.TextBox
        Me.txtAsalSekolah = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.txtPkjIbu = New System.Windows.Forms.TextBox
        Me.txtPkjAyah = New System.Windows.Forms.TextBox
        Me.txtNamaIbu = New System.Windows.Forms.TextBox
        Me.txtNamaAyah = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.addButton = New System.Windows.Forms.ToolStripButton
        Me.saveButton = New System.Windows.Forms.ToolStripButton
        Me.cancelButton = New System.Windows.Forms.ToolStripButton
        Me.printButton = New System.Windows.Forms.ToolStripButton
        Me.findButton = New System.Windows.Forms.ToolStripButton
        Me.browseButton = New System.Windows.Forms.ToolStripButton
        Me.delButton = New System.Windows.Forms.ToolStripButton
        Me.Label14 = New System.Windows.Forms.Label
        Me.dateTgLahir = New System.Windows.Forms.DateTimePicker
        Me.menuStrip = New System.Windows.Forms.ToolStripLabel
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dateTgLahir)
        Me.GroupBox1.Controls.Add(Me.txtNoReg)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.opsiPr)
        Me.GroupBox1.Controls.Add(Me.opsiLk)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.comboAgama)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtAlamatSiswa)
        Me.GroupBox1.Controls.Add(Me.txtNamaSiswa)
        Me.GroupBox1.Controls.Add(Me.txtNISN)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Location = New System.Drawing.Point(12, 35)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(504, 175)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Identitas Calon Siswa"
        '
        'txtNoReg
        '
        Me.txtNoReg.Enabled = False
        Me.txtNoReg.Location = New System.Drawing.Point(400, 27)
        Me.txtNoReg.Name = "txtNoReg"
        Me.txtNoReg.Size = New System.Drawing.Size(81, 22)
        Me.txtNoReg.TabIndex = 1
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(325, 27)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(70, 13)
        Me.Label13.TabIndex = 11
        Me.Label13.Text = "No.Register:"
        '
        'opsiPr
        '
        Me.opsiPr.AutoSize = True
        Me.opsiPr.Location = New System.Drawing.Point(236, 130)
        Me.opsiPr.Name = "opsiPr"
        Me.opsiPr.Size = New System.Drawing.Size(83, 17)
        Me.opsiPr.TabIndex = 10
        Me.opsiPr.TabStop = True
        Me.opsiPr.Text = "Perempuan"
        Me.opsiPr.UseVisualStyleBackColor = True
        '
        'opsiLk
        '
        Me.opsiLk.AutoSize = True
        Me.opsiLk.Checked = True
        Me.opsiLk.Location = New System.Drawing.Point(143, 130)
        Me.opsiLk.Name = "opsiLk"
        Me.opsiLk.Size = New System.Drawing.Size(69, 17)
        Me.opsiLk.TabIndex = 9
        Me.opsiLk.TabStop = True
        Me.opsiLk.Text = "Laki-Laki"
        Me.opsiLk.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(18, 132)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(78, 13)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "Jenis Kelamin:"
        '
        'comboAgama
        '
        Me.comboAgama.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboAgama.FormattingEnabled = True
        Me.comboAgama.Items.AddRange(New Object() {"ISLAM", "HINDU", "BUDHA", "PROTESTAN", "KATOLIK"})
        Me.comboAgama.Location = New System.Drawing.Point(141, 102)
        Me.comboAgama.Name = "comboAgama"
        Me.comboAgama.Size = New System.Drawing.Size(167, 21)
        Me.comboAgama.TabIndex = 4
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(19, 104)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 13)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Agama:"
        '
        'txtAlamatSiswa
        '
        Me.txtAlamatSiswa.Location = New System.Drawing.Point(141, 76)
        Me.txtAlamatSiswa.Name = "txtAlamatSiswa"
        Me.txtAlamatSiswa.Size = New System.Drawing.Size(340, 22)
        Me.txtAlamatSiswa.TabIndex = 3
        '
        'txtNamaSiswa
        '
        Me.txtNamaSiswa.Location = New System.Drawing.Point(141, 52)
        Me.txtNamaSiswa.Name = "txtNamaSiswa"
        Me.txtNamaSiswa.Size = New System.Drawing.Size(178, 22)
        Me.txtNamaSiswa.TabIndex = 2
        '
        'txtNISN
        '
        Me.txtNISN.Location = New System.Drawing.Point(141, 27)
        Me.txtNISN.Name = "txtNISN"
        Me.txtNISN.Size = New System.Drawing.Size(178, 22)
        Me.txtNISN.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Alamat Siswa:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Siswa:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NISN:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtNoIjazah)
        Me.GroupBox2.Controls.Add(Me.txtAlamatSekolahAsal)
        Me.GroupBox2.Controls.Add(Me.txtAsalSekolah)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Enabled = False
        Me.GroupBox2.Location = New System.Drawing.Point(12, 226)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(504, 118)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Asal Sekolah"
        '
        'txtNoIjazah
        '
        Me.txtNoIjazah.Location = New System.Drawing.Point(141, 78)
        Me.txtNoIjazah.Name = "txtNoIjazah"
        Me.txtNoIjazah.Size = New System.Drawing.Size(340, 22)
        Me.txtNoIjazah.TabIndex = 2
        '
        'txtAlamatSekolahAsal
        '
        Me.txtAlamatSekolahAsal.Location = New System.Drawing.Point(141, 52)
        Me.txtAlamatSekolahAsal.Name = "txtAlamatSekolahAsal"
        Me.txtAlamatSekolahAsal.Size = New System.Drawing.Size(340, 22)
        Me.txtAlamatSekolahAsal.TabIndex = 1
        '
        'txtAsalSekolah
        '
        Me.txtAsalSekolah.Location = New System.Drawing.Point(141, 26)
        Me.txtAsalSekolah.Name = "txtAsalSekolah"
        Me.txtAsalSekolah.Size = New System.Drawing.Size(340, 22)
        Me.txtAsalSekolah.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(21, 81)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Nomor Ijazah:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Alamat:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Nama Sekolah:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtPkjIbu)
        Me.GroupBox3.Controls.Add(Me.txtPkjAyah)
        Me.GroupBox3.Controls.Add(Me.txtNamaIbu)
        Me.GroupBox3.Controls.Add(Me.txtNamaAyah)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Enabled = False
        Me.GroupBox3.Location = New System.Drawing.Point(12, 359)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(504, 150)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Identitas Orang Tua/Wali"
        '
        'txtPkjIbu
        '
        Me.txtPkjIbu.Location = New System.Drawing.Point(141, 101)
        Me.txtPkjIbu.Name = "txtPkjIbu"
        Me.txtPkjIbu.Size = New System.Drawing.Size(339, 22)
        Me.txtPkjIbu.TabIndex = 3
        '
        'txtPkjAyah
        '
        Me.txtPkjAyah.Location = New System.Drawing.Point(141, 76)
        Me.txtPkjAyah.Name = "txtPkjAyah"
        Me.txtPkjAyah.Size = New System.Drawing.Size(339, 22)
        Me.txtPkjAyah.TabIndex = 2
        '
        'txtNamaIbu
        '
        Me.txtNamaIbu.Location = New System.Drawing.Point(141, 51)
        Me.txtNamaIbu.Name = "txtNamaIbu"
        Me.txtNamaIbu.Size = New System.Drawing.Size(339, 22)
        Me.txtNamaIbu.TabIndex = 1
        '
        'txtNamaAyah
        '
        Me.txtNamaAyah.Location = New System.Drawing.Point(141, 25)
        Me.txtNamaAyah.Name = "txtNamaAyah"
        Me.txtNamaAyah.Size = New System.Drawing.Size(339, 22)
        Me.txtNamaAyah.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(23, 108)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 13)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Pekerjaan Ibu:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(23, 79)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Pekerjaan Ayah:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(23, 54)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Nama Ibu:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(23, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Nama Ayah:"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.addButton, Me.saveButton, Me.cancelButton, Me.printButton, Me.ToolStripSeparator1, Me.findButton, Me.browseButton, Me.ToolStripSeparator2, Me.delButton, Me.menuStrip})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(535, 25)
        Me.ToolStrip1.TabIndex = 3
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'addButton
        '
        Me.addButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.addButton.Image = Global.PendaftaranSiswaBaru.My.Resources.Resources.application__plus
        Me.addButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.addButton.Name = "addButton"
        Me.addButton.Size = New System.Drawing.Size(23, 22)
        Me.addButton.Text = "Baru"
        '
        'saveButton
        '
        Me.saveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.saveButton.Image = Global.PendaftaranSiswaBaru.My.Resources.Resources.disk
        Me.saveButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.saveButton.Name = "saveButton"
        Me.saveButton.Size = New System.Drawing.Size(23, 22)
        Me.saveButton.Text = "Simpan"
        '
        'cancelButton
        '
        Me.cancelButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cancelButton.Image = Global.PendaftaranSiswaBaru.My.Resources.Resources.cross_circle
        Me.cancelButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cancelButton.Name = "cancelButton"
        Me.cancelButton.Size = New System.Drawing.Size(23, 22)
        Me.cancelButton.Text = "Cancel"
        '
        'printButton
        '
        Me.printButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.printButton.Image = Global.PendaftaranSiswaBaru.My.Resources.Resources.printer
        Me.printButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.printButton.Name = "printButton"
        Me.printButton.Size = New System.Drawing.Size(23, 22)
        Me.printButton.Text = "Cetak"
        '
        'findButton
        '
        Me.findButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.findButton.Image = Global.PendaftaranSiswaBaru.My.Resources.Resources.binocular
        Me.findButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.findButton.Name = "findButton"
        Me.findButton.Size = New System.Drawing.Size(23, 22)
        Me.findButton.Text = "Cari"
        '
        'browseButton
        '
        Me.browseButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.browseButton.Image = Global.PendaftaranSiswaBaru.My.Resources.Resources.book_open_next
        Me.browseButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.browseButton.Name = "browseButton"
        Me.browseButton.Size = New System.Drawing.Size(23, 22)
        Me.browseButton.Text = "Lihat..."
        '
        'delButton
        '
        Me.delButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.delButton.Image = Global.PendaftaranSiswaBaru.My.Resources.Resources.bin
        Me.delButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.delButton.Name = "delButton"
        Me.delButton.Size = New System.Drawing.Size(23, 22)
        Me.delButton.Text = "Hapus"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(325, 55)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(52, 13)
        Me.Label14.TabIndex = 11
        Me.Label14.Text = "Tgl Lahir:"
        '
        'dateTgLahir
        '
        Me.dateTgLahir.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateTgLahir.Location = New System.Drawing.Point(384, 52)
        Me.dateTgLahir.MaxDate = New Date(2020, 12, 31, 0, 0, 0, 0)
        Me.dateTgLahir.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
        Me.dateTgLahir.Name = "dateTgLahir"
        Me.dateTgLahir.Size = New System.Drawing.Size(97, 22)
        Me.dateTgLahir.TabIndex = 12
        '
        'menuStrip
        '
        Me.menuStrip.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menuStrip.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.menuStrip.Name = "menuStrip"
        Me.menuStrip.Size = New System.Drawing.Size(39, 22)
        Me.menuStrip.Text = "Mode"
        '
        'frmDaftar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(535, 528)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDaftar"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Daftar"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents addButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents delButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents printButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents txtAlamatSiswa As System.Windows.Forms.TextBox
    Friend WithEvents txtNamaSiswa As System.Windows.Forms.TextBox
    Friend WithEvents txtNISN As System.Windows.Forms.TextBox
    Friend WithEvents txtNoIjazah As System.Windows.Forms.TextBox
    Friend WithEvents txtAlamatSekolahAsal As System.Windows.Forms.TextBox
    Friend WithEvents txtAsalSekolah As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents comboAgama As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents opsiPr As System.Windows.Forms.RadioButton
    Friend WithEvents opsiLk As System.Windows.Forms.RadioButton
    Friend WithEvents txtPkjIbu As System.Windows.Forms.TextBox
    Friend WithEvents txtPkjAyah As System.Windows.Forms.TextBox
    Friend WithEvents txtNamaIbu As System.Windows.Forms.TextBox
    Friend WithEvents txtNamaAyah As System.Windows.Forms.TextBox
    Friend WithEvents findButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents browseButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtNoReg As System.Windows.Forms.TextBox
    Friend WithEvents saveButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents cancelButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents dateTgLahir As System.Windows.Forms.DateTimePicker
    Friend WithEvents menuStrip As System.Windows.Forms.ToolStripLabel
End Class
