<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBrowse
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
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.colNisn = New System.Windows.Forms.ColumnHeader
        Me.colNamaSis = New System.Windows.Forms.ColumnHeader
        Me.colAlamat = New System.Windows.Forms.ColumnHeader
        Me.colAsalSkl = New System.Windows.Forms.ColumnHeader
        Me.colTglLahir = New System.Windows.Forms.ColumnHeader
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colNisn, Me.colNamaSis, Me.colTglLahir, Me.colAlamat, Me.colAsalSkl})
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView1.Location = New System.Drawing.Point(0, 0)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(679, 299)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'colNisn
        '
        Me.colNisn.Text = "NISN"
        '
        'colNamaSis
        '
        Me.colNamaSis.Text = "Nama Siswa"
        Me.colNamaSis.Width = 120
        '
        'colAlamat
        '
        Me.colAlamat.DisplayIndex = 2
        Me.colAlamat.Text = "Alamat"
        '
        'colAsalSkl
        '
        Me.colAsalSkl.DisplayIndex = 3
        Me.colAsalSkl.Text = "Asal Sekolah"
        Me.colAsalSkl.Width = 116
        '
        'colTglLahir
        '
        Me.colTglLahir.Text = "Tanggal Lahir"
        Me.colTglLahir.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.colTglLahir.Width = 85
        '
        'frmBrowse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(679, 299)
        Me.Controls.Add(Me.ListView1)
        Me.Font = New System.Drawing.Font("Segoe UI Emoji", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmBrowse"
        Me.Text = "Lihat Data..."
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents colNisn As System.Windows.Forms.ColumnHeader
    Friend WithEvents colNamaSis As System.Windows.Forms.ColumnHeader
    Friend WithEvents colAlamat As System.Windows.Forms.ColumnHeader
    Friend WithEvents colAsalSkl As System.Windows.Forms.ColumnHeader
    Friend WithEvents colTglLahir As System.Windows.Forms.ColumnHeader
End Class
