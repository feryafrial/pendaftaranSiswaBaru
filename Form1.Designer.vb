<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUtama
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.SistemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.menuLogin = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.menuKeluar = New System.Windows.Forms.ToolStripMenuItem
        Me.TransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.menuTransDaftar = New System.Windows.Forms.ToolStripMenuItem
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.menuLaporanSiswaBaru = New System.Windows.Forms.ToolStripMenuItem
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.statLabelTanggal = New System.Windows.Forms.ToolStripStatusLabel
        Me.statLabelJam = New System.Windows.Forms.ToolStripStatusLabel
        Me.statLabelUser = New System.Windows.Forms.ToolStripStatusLabel
        Me.statlabelInfo = New System.Windows.Forms.ToolStripStatusLabel
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SistemToolStripMenuItem, Me.TransaksiToolStripMenuItem, Me.LaporanToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(731, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SistemToolStripMenuItem
        '
        Me.SistemToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuLogin, Me.ToolStripMenuItem1, Me.menuKeluar})
        Me.SistemToolStripMenuItem.Name = "SistemToolStripMenuItem"
        Me.SistemToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.SistemToolStripMenuItem.Text = "Sistem"
        '
        'menuLogin
        '
        Me.menuLogin.Name = "menuLogin"
        Me.menuLogin.Size = New System.Drawing.Size(107, 22)
        Me.menuLogin.Text = "Login"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(104, 6)
        '
        'menuKeluar
        '
        Me.menuKeluar.Name = "menuKeluar"
        Me.menuKeluar.Size = New System.Drawing.Size(107, 22)
        Me.menuKeluar.Text = "Keluar"
        '
        'TransaksiToolStripMenuItem
        '
        Me.TransaksiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuTransDaftar})
        Me.TransaksiToolStripMenuItem.Name = "TransaksiToolStripMenuItem"
        Me.TransaksiToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.TransaksiToolStripMenuItem.Text = "Transaksi"
        '
        'menuTransDaftar
        '
        Me.menuTransDaftar.Name = "menuTransDaftar"
        Me.menuTransDaftar.Size = New System.Drawing.Size(165, 22)
        Me.menuTransDaftar.Text = "Daftar Siswa Baru"
        '
        'LaporanToolStripMenuItem
        '
        Me.LaporanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuLaporanSiswaBaru})
        Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.LaporanToolStripMenuItem.Text = "Laporan"
        '
        'menuLaporanSiswaBaru
        '
        Me.menuLaporanSiswaBaru.Name = "menuLaporanSiswaBaru"
        Me.menuLaporanSiswaBaru.Size = New System.Drawing.Size(152, 22)
        Me.menuLaporanSiswaBaru.Text = "Siswa Baru"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.statLabelTanggal, Me.statLabelJam, Me.statLabelUser, Me.statlabelInfo})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 473)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(731, 24)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'statLabelTanggal
        '
        Me.statLabelTanggal.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.statLabelTanggal.BorderStyle = System.Windows.Forms.Border3DStyle.Raised
        Me.statLabelTanggal.Name = "statLabelTanggal"
        Me.statLabelTanggal.Size = New System.Drawing.Size(53, 19)
        Me.statLabelTanggal.Text = "Tanggal"
        '
        'statLabelJam
        '
        Me.statLabelJam.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.statLabelJam.BorderStyle = System.Windows.Forms.Border3DStyle.Etched
        Me.statLabelJam.Name = "statLabelJam"
        Me.statLabelJam.Size = New System.Drawing.Size(32, 19)
        Me.statLabelJam.Text = "Jam"
        '
        'statLabelUser
        '
        Me.statLabelUser.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.statLabelUser.Name = "statLabelUser"
        Me.statLabelUser.Size = New System.Drawing.Size(64, 19)
        Me.statLabelUser.Text = "Username"
        '
        'statlabelInfo
        '
        Me.statlabelInfo.AutoSize = False
        Me.statlabelInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.statlabelInfo.Name = "statlabelInfo"
        Me.statlabelInfo.Size = New System.Drawing.Size(567, 19)
        Me.statlabelInfo.Spring = True
        '
        'frmUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(731, 497)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmUtama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pendaftaran Siswa Baru MTS Al-Ikhlas versi 0.1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents SistemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuLogin As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents menuKeluar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransaksiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuTransDaftar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuLaporanSiswaBaru As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents statLabelTanggal As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents statLabelJam As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents statLabelUser As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents statlabelInfo As System.Windows.Forms.ToolStripStatusLabel

End Class
