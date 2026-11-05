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
        lblJumlah = New Label()
        lblTotalStok = New Label()
        txtKodeBuku = New TextBox()
        txtStok = New TextBox()
        txtTahun = New TextBox()
        txtPenulis = New TextBox()
        txtCari = New TextBox()
        txtJudul = New TextBox()
        lblKodeBuku = New Label()
        lblJudulBuku = New Label()
        lblCariJudulPenulis = New Label()
        lblPenulis = New Label()
        lblKategori = New Label()
        lblTahunTerbit = New Label()
        cboKategori = New ComboBox()
        lblStok = New Label()
        btnTambah = New Button()
        btnBersihkan = New Button()
        lblFilter = New Label()
        cboFilterKategori = New ComboBox()
        chkStokHabis = New CheckBox()
        dgvBuku = New DataGridView()
        cboUrut = New ComboBox()
        lblUrutanBuku = New Label()
        bsBuku = New BindingSource(components)
        errBuku = New ErrorProvider(components)
        CType(dgvBuku, ComponentModel.ISupportInitialize).BeginInit()
        CType(bsBuku, ComponentModel.ISupportInitialize).BeginInit()
        CType(errBuku, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblJudulForm
        ' 
        lblJudulForm.AutoSize = True
        lblJudulForm.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblJudulForm.Location = New Point(12, 9)
        lblJudulForm.Name = "lblJudulForm"
        lblJudulForm.Size = New Size(332, 31)
        lblJudulForm.TabIndex = 0
        lblJudulForm.Text = "Inventaris Buku Perpustakaan"
        ' 
        ' lblJumlah
        ' 
        lblJumlah.AutoSize = True
        lblJumlah.Location = New Point(583, 404)
        lblJumlah.Name = "lblJumlah"
        lblJumlah.Size = New Size(205, 20)
        lblJumlah.TabIndex = 1
        lblJumlah.Text = "Menampilkan 11 dari 11 buku"
        ' 
        ' lblTotalStok
        ' 
        lblTotalStok.AutoSize = True
        lblTotalStok.Location = New Point(583, 424)
        lblTotalStok.Name = "lblTotalStok"
        lblTotalStok.Size = New Size(88, 20)
        lblTotalStok.TabIndex = 2
        lblTotalStok.Text = "Total stok: 0"
        ' 
        ' txtKodeBuku
        ' 
        txtKodeBuku.Location = New Point(13, 77)
        txtKodeBuku.Name = "txtKodeBuku"
        txtKodeBuku.Size = New Size(125, 27)
        txtKodeBuku.TabIndex = 3
        ' 
        ' txtStok
        ' 
        txtStok.Location = New Point(12, 404)
        txtStok.Name = "txtStok"
        txtStok.Size = New Size(125, 27)
        txtStok.TabIndex = 4
        ' 
        ' txtTahun
        ' 
        txtTahun.Location = New Point(12, 338)
        txtTahun.Name = "txtTahun"
        txtTahun.Size = New Size(125, 27)
        txtTahun.TabIndex = 5
        ' 
        ' txtPenulis
        ' 
        txtPenulis.Location = New Point(14, 204)
        txtPenulis.Name = "txtPenulis"
        txtPenulis.Size = New Size(125, 27)
        txtPenulis.TabIndex = 6
        ' 
        ' txtCari
        ' 
        txtCari.Location = New Point(218, 77)
        txtCari.Name = "txtCari"
        txtCari.Size = New Size(286, 27)
        txtCari.TabIndex = 7
        ' 
        ' txtJudul
        ' 
        txtJudul.Location = New Point(14, 141)
        txtJudul.Name = "txtJudul"
        txtJudul.Size = New Size(125, 27)
        txtJudul.TabIndex = 8
        ' 
        ' lblKodeBuku
        ' 
        lblKodeBuku.AutoSize = True
        lblKodeBuku.Location = New Point(13, 54)
        lblKodeBuku.Name = "lblKodeBuku"
        lblKodeBuku.Size = New Size(80, 20)
        lblKodeBuku.TabIndex = 9
        lblKodeBuku.Text = "Kode Buku"
        ' 
        ' lblJudulBuku
        ' 
        lblJudulBuku.AutoSize = True
        lblJudulBuku.Location = New Point(14, 118)
        lblJudulBuku.Name = "lblJudulBuku"
        lblJudulBuku.Size = New Size(79, 20)
        lblJudulBuku.TabIndex = 10
        lblJudulBuku.Text = "Judul Buku"
        ' 
        ' lblCariJudulPenulis
        ' 
        lblCariJudulPenulis.AutoSize = True
        lblCariJudulPenulis.Location = New Point(218, 54)
        lblCariJudulPenulis.Name = "lblCariJudulPenulis"
        lblCariJudulPenulis.Size = New Size(126, 20)
        lblCariJudulPenulis.TabIndex = 11
        lblCariJudulPenulis.Text = "Cari Judul/penulis"
        ' 
        ' lblPenulis
        ' 
        lblPenulis.AutoSize = True
        lblPenulis.Location = New Point(14, 181)
        lblPenulis.Name = "lblPenulis"
        lblPenulis.Size = New Size(54, 20)
        lblPenulis.TabIndex = 12
        lblPenulis.Text = "Penulis"
        ' 
        ' lblKategori
        ' 
        lblKategori.AutoSize = True
        lblKategori.Location = New Point(12, 244)
        lblKategori.Name = "lblKategori"
        lblKategori.Size = New Size(66, 20)
        lblKategori.TabIndex = 13
        lblKategori.Text = "Kategori"
        ' 
        ' lblTahunTerbit
        ' 
        lblTahunTerbit.AutoSize = True
        lblTahunTerbit.Location = New Point(12, 315)
        lblTahunTerbit.Name = "lblTahunTerbit"
        lblTahunTerbit.Size = New Size(89, 20)
        lblTahunTerbit.TabIndex = 14
        lblTahunTerbit.Text = "Tahun Terbit"
        ' 
        ' cboKategori
        ' 
        cboKategori.DropDownStyle = ComboBoxStyle.DropDownList
        cboKategori.FormattingEnabled = True
        cboKategori.Items.AddRange(New Object() {"Fiksi", "Nonfiksi", "Referensi", "Majalah"})
        cboKategori.Location = New Point(14, 267)
        cboKategori.Name = "cboKategori"
        cboKategori.Size = New Size(151, 28)
        cboKategori.TabIndex = 15
        ' 
        ' lblStok
        ' 
        lblStok.AutoSize = True
        lblStok.Location = New Point(12, 381)
        lblStok.Name = "lblStok"
        lblStok.Size = New Size(38, 20)
        lblStok.TabIndex = 16
        lblStok.Text = "Stok"
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(183, 400)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(107, 29)
        btnTambah.TabIndex = 17
        btnTambah.Text = "Tambah Buku"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' btnBersihkan
        ' 
        btnBersihkan.CausesValidation = False
        btnBersihkan.Location = New Point(296, 400)
        btnBersihkan.Name = "btnBersihkan"
        btnBersihkan.Size = New Size(94, 29)
        btnBersihkan.TabIndex = 18
        btnBersihkan.Text = "Bersihkan"
        btnBersihkan.UseVisualStyleBackColor = True
        ' 
        ' lblFilter
        ' 
        lblFilter.AutoSize = True
        lblFilter.Location = New Point(218, 118)
        lblFilter.Name = "lblFilter"
        lblFilter.Size = New Size(103, 20)
        lblFilter.TabIndex = 19
        lblFilter.Text = "Filter Kategori"
        ' 
        ' cboFilterKategori
        ' 
        cboFilterKategori.CausesValidation = False
        cboFilterKategori.DropDownStyle = ComboBoxStyle.DropDownList
        cboFilterKategori.FormattingEnabled = True
        cboFilterKategori.Items.AddRange(New Object() {"Semua", "Fiksi", "Nonfiksi", "Referensi", "Majalah"})
        cboFilterKategori.Location = New Point(218, 140)
        cboFilterKategori.Name = "cboFilterKategori"
        cboFilterKategori.Size = New Size(151, 28)
        cboFilterKategori.TabIndex = 20
        ' 
        ' chkStokHabis
        ' 
        chkStokHabis.AutoSize = True
        chkStokHabis.Location = New Point(401, 140)
        chkStokHabis.Name = "chkStokHabis"
        chkStokHabis.Size = New Size(143, 24)
        chkStokHabis.TabIndex = 21
        chkStokHabis.Text = "Hanya stok habis"
        chkStokHabis.UseVisualStyleBackColor = True
        ' 
        ' dgvBuku
        ' 
        dgvBuku.AllowUserToAddRows = False
        dgvBuku.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvBuku.Location = New Point(218, 181)
        dgvBuku.MultiSelect = False
        dgvBuku.Name = "dgvBuku"
        dgvBuku.ReadOnly = True
        dgvBuku.RowHeadersWidth = 51
        dgvBuku.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvBuku.Size = New Size(570, 188)
        dgvBuku.TabIndex = 22
        ' 
        ' cboUrut
        ' 
        cboUrut.CausesValidation = False
        cboUrut.DropDownStyle = ComboBoxStyle.DropDownList
        cboUrut.FormattingEnabled = True
        cboUrut.Items.AddRange(New Object() {"Urutkan awal", "Judul A-Z", "Tahun terbaru", "Stok terbanyak"})
        cboUrut.Location = New Point(583, 141)
        cboUrut.Name = "cboUrut"
        cboUrut.Size = New Size(151, 28)
        cboUrut.TabIndex = 23
        ' 
        ' lblUrutanBuku
        ' 
        lblUrutanBuku.AutoSize = True
        lblUrutanBuku.Location = New Point(583, 118)
        lblUrutanBuku.Name = "lblUrutanBuku"
        lblUrutanBuku.Size = New Size(89, 20)
        lblUrutanBuku.TabIndex = 24
        lblUrutanBuku.Text = "Urutan Buku"
        ' 
        ' errBuku
        ' 
        errBuku.ContainerControl = Me
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblUrutanBuku)
        Controls.Add(cboUrut)
        Controls.Add(dgvBuku)
        Controls.Add(chkStokHabis)
        Controls.Add(cboFilterKategori)
        Controls.Add(lblFilter)
        Controls.Add(btnBersihkan)
        Controls.Add(btnTambah)
        Controls.Add(lblStok)
        Controls.Add(cboKategori)
        Controls.Add(lblTahunTerbit)
        Controls.Add(lblKategori)
        Controls.Add(lblPenulis)
        Controls.Add(lblCariJudulPenulis)
        Controls.Add(lblJudulBuku)
        Controls.Add(lblKodeBuku)
        Controls.Add(txtJudul)
        Controls.Add(txtCari)
        Controls.Add(txtPenulis)
        Controls.Add(txtTahun)
        Controls.Add(txtStok)
        Controls.Add(txtKodeBuku)
        Controls.Add(lblTotalStok)
        Controls.Add(lblJumlah)
        Controls.Add(lblJudulForm)
        Name = "Form1"
        Text = "Form1"
        CType(dgvBuku, ComponentModel.ISupportInitialize).EndInit()
        CType(bsBuku, ComponentModel.ISupportInitialize).EndInit()
        CType(errBuku, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblJudulForm As Label
    Friend WithEvents lblJumlah As Label
    Friend WithEvents lblTotalStok As Label
    Friend WithEvents txtKodeBuku As TextBox
    Friend WithEvents txtStok As TextBox
    Friend WithEvents txtTahun As TextBox
    Friend WithEvents txtPenulis As TextBox
    Friend WithEvents txtCari As TextBox
    Friend WithEvents txtJudul As TextBox
    Friend WithEvents lblKodeBuku As Label
    Friend WithEvents lblJudulBuku As Label
    Friend WithEvents lblCariJudulPenulis As Label
    Friend WithEvents lblPenulis As Label
    Friend WithEvents lblKategori As Label
    Friend WithEvents lblTahunTerbit As Label
    Friend WithEvents cboKategori As ComboBox
    Friend WithEvents lblStok As Label
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnBersihkan As Button
    Friend WithEvents lblFilter As Label
    Friend WithEvents cboFilterKategori As ComboBox
    Friend WithEvents chkStokHabis As CheckBox
    Friend WithEvents dgvBuku As DataGridView
    Friend WithEvents cboUrut As ComboBox
    Friend WithEvents lblUrutanBuku As Label
    Friend WithEvents bsBuku As BindingSource
    Friend WithEvents errBuku As ErrorProvider

End Class
