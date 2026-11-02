<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        lblJudulForm = New Label()
        lblKodeBuku = New Label()
        lblJudul = New Label()
        lblKategori = New Label()
        lblNamaPeminjam = New Label()
        lblLamaPinjam = New Label()
        lblStatus = New Label()
        txtKodeBuku = New TextBox()
        txtJudul = New TextBox()
        txtNamaPeminjam = New TextBox()
        txtLamaPinjam = New TextBox()
        cboKategori = New ComboBox()
        btnPinjam = New Button()
        btnBersihkan = New Button()
        btnEkspor = New Button()
        lstPeminjaman = New ListBox()
        errPinjam = New ErrorProvider(components)
        CType(errPinjam, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblJudulForm
        ' 
        lblJudulForm.AutoSize = True
        lblJudulForm.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblJudulForm.Location = New Point(12, 18)
        lblJudulForm.Name = "lblJudulForm"
        lblJudulForm.Size = New Size(209, 31)
        lblJudulForm.TabIndex = 0
        lblJudulForm.Text = "Peminjaman Buku"
        ' 
        ' lblKodeBuku
        ' 
        lblKodeBuku.AutoSize = True
        lblKodeBuku.Location = New Point(12, 115)
        lblKodeBuku.Name = "lblKodeBuku"
        lblKodeBuku.Size = New Size(80, 20)
        lblKodeBuku.TabIndex = 2
        lblKodeBuku.Text = "Kode Buku"
        ' 
        ' lblJudul
        ' 
        lblJudul.AutoSize = True
        lblJudul.Location = New Point(13, 189)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New Size(79, 20)
        lblJudul.TabIndex = 3
        lblJudul.Text = "Judul Buku"
        ' 
        ' lblKategori
        ' 
        lblKategori.AutoSize = True
        lblKategori.Location = New Point(13, 248)
        lblKategori.Name = "lblKategori"
        lblKategori.Size = New Size(66, 20)
        lblKategori.TabIndex = 4
        lblKategori.Text = "Kategori"
        ' 
        ' lblNamaPeminjam
        ' 
        lblNamaPeminjam.AutoSize = True
        lblNamaPeminjam.Location = New Point(13, 311)
        lblNamaPeminjam.Name = "lblNamaPeminjam"
        lblNamaPeminjam.Size = New Size(118, 20)
        lblNamaPeminjam.TabIndex = 5
        lblNamaPeminjam.Text = "Nama Peminjam"
        ' 
        ' lblLamaPinjam
        ' 
        lblLamaPinjam.AutoSize = True
        lblLamaPinjam.Location = New Point(13, 384)
        lblLamaPinjam.Name = "lblLamaPinjam"
        lblLamaPinjam.Size = New Size(133, 20)
        lblLamaPinjam.TabIndex = 6
        lblLamaPinjam.Text = "Lama Pinjam (hari)"
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.Location = New Point(587, 421)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(214, 20)
        lblStatus.TabIndex = 7
        lblStatus.Text = "Status dan jumlah peminjaman"
        ' 
        ' txtKodeBuku
        ' 
        txtKodeBuku.Location = New Point(13, 148)
        txtKodeBuku.Name = "txtKodeBuku"
        txtKodeBuku.Size = New Size(157, 27)
        txtKodeBuku.TabIndex = 8
        ' 
        ' txtJudul
        ' 
        txtJudul.Location = New Point(13, 218)
        txtJudul.Name = "txtJudul"
        txtJudul.Size = New Size(157, 27)
        txtJudul.TabIndex = 9
        ' 
        ' txtNamaPeminjam
        ' 
        txtNamaPeminjam.Location = New Point(13, 343)
        txtNamaPeminjam.Name = "txtNamaPeminjam"
        txtNamaPeminjam.Size = New Size(157, 27)
        txtNamaPeminjam.TabIndex = 10
        ' 
        ' txtLamaPinjam
        ' 
        txtLamaPinjam.Location = New Point(13, 411)
        txtLamaPinjam.Name = "txtLamaPinjam"
        txtLamaPinjam.Size = New Size(157, 27)
        txtLamaPinjam.TabIndex = 11
        ' 
        ' cboKategori
        ' 
        cboKategori.DropDownStyle = ComboBoxStyle.DropDownList
        cboKategori.FormattingEnabled = True
        cboKategori.Location = New Point(12, 271)
        cboKategori.Name = "cboKategori"
        cboKategori.Size = New Size(158, 28)
        cboKategori.TabIndex = 12
        ' 
        ' btnPinjam
        ' 
        btnPinjam.Location = New Point(232, 365)
        btnPinjam.Name = "btnPinjam"
        btnPinjam.Size = New Size(94, 29)
        btnPinjam.TabIndex = 13
        btnPinjam.Text = "Pinjam"
        btnPinjam.UseVisualStyleBackColor = True
        ' 
        ' btnBersihkan
        ' 
        btnBersihkan.CausesValidation = False
        btnBersihkan.Location = New Point(392, 365)
        btnBersihkan.Name = "btnBersihkan"
        btnBersihkan.Size = New Size(94, 29)
        btnBersihkan.TabIndex = 14
        btnBersihkan.Text = "Bersihkan"
        btnBersihkan.UseVisualStyleBackColor = True
        ' 
        ' btnEkspor
        ' 
        btnEkspor.Location = New Point(545, 365)
        btnEkspor.Name = "btnEkspor"
        btnEkspor.Size = New Size(94, 29)
        btnEkspor.TabIndex = 15
        btnEkspor.Text = "Ekspor CSV"
        btnEkspor.UseVisualStyleBackColor = True
        ' 
        ' lstPeminjaman
        ' 
        lstPeminjaman.FormattingEnabled = True
        lstPeminjaman.Location = New Point(301, 135)
        lstPeminjaman.Name = "lstPeminjaman"
        lstPeminjaman.Size = New Size(404, 184)
        lstPeminjaman.TabIndex = 16
        ' 
        ' errPinjam
        ' 
        errPinjam.ContainerControl = Me
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lstPeminjaman)
        Controls.Add(btnEkspor)
        Controls.Add(btnBersihkan)
        Controls.Add(btnPinjam)
        Controls.Add(cboKategori)
        Controls.Add(txtLamaPinjam)
        Controls.Add(txtNamaPeminjam)
        Controls.Add(txtJudul)
        Controls.Add(txtKodeBuku)
        Controls.Add(lblStatus)
        Controls.Add(lblLamaPinjam)
        Controls.Add(lblNamaPeminjam)
        Controls.Add(lblKategori)
        Controls.Add(lblJudul)
        Controls.Add(lblKodeBuku)
        Controls.Add(lblJudulForm)
        Name = "Form1"
        Text = "Form1"
        CType(errPinjam, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblJudulForm As Label
    Friend WithEvents lblKodeBuku As Label
    Friend WithEvents lblJudul As Label
    Friend WithEvents lblKategori As Label
    Friend WithEvents lblNamaPeminjam As Label
    Friend WithEvents lblLamaPinjam As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents txtKodeBuku As TextBox
    Friend WithEvents txtJudul As TextBox
    Friend WithEvents txtNamaPeminjam As TextBox
    Friend WithEvents txtLamaPinjam As TextBox
    Friend WithEvents cboKategori As ComboBox
    Friend WithEvents btnPinjam As Button
    Friend WithEvents btnBersihkan As Button
    Friend WithEvents btnEkspor As Button
    Friend WithEvents lstPeminjaman As ListBox
    Friend WithEvents errPinjam As ErrorProvider

End Class
