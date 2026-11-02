<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDariList
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
        components = New ComponentModel.Container()
        LblJudul = New Label()
        LblNim = New Label()
        LblNama = New Label()
        LblJurusan = New Label()
        LblAngkatan = New Label()
        LblIpk = New Label()
        LblJumlah = New Label()
        txtNim = New TextBox()
        txtNama = New TextBox()
        txtAngkatan = New TextBox()
        txtIpk = New TextBox()
        cboJurusan = New ComboBox()
        btnTambah = New Button()
        dgvMahasiswa = New DataGridView()
        bsMahasiswa = New BindingSource(components)
        errInput = New ErrorProvider(components)
        CType(dgvMahasiswa, ComponentModel.ISupportInitialize).BeginInit()
        CType(bsMahasiswa, ComponentModel.ISupportInitialize).BeginInit()
        CType(errInput, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' LblJudul
        ' 
        LblJudul.AutoSize = True
        LblJudul.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblJudul.Location = New Point(12, 22)
        LblJudul.Name = "LblJudul"
        LblJudul.Size = New Size(403, 31)
        LblJudul.TabIndex = 0
        LblJudul.Text = "List(Of Mahasiswa) + BindingSource"
        ' 
        ' LblNim
        ' 
        LblNim.AutoSize = True
        LblNim.Location = New Point(12, 92)
        LblNim.Name = "LblNim"
        LblNim.Size = New Size(37, 20)
        LblNim.TabIndex = 1
        LblNim.Text = "NIM"
        ' 
        ' LblNama
        ' 
        LblNama.AutoSize = True
        LblNama.Location = New Point(317, 92)
        LblNama.Name = "LblNama"
        LblNama.Size = New Size(53, 20)
        LblNama.TabIndex = 2
        LblNama.Text = "NAMA"
        ' 
        ' LblJurusan
        ' 
        LblJurusan.AutoSize = True
        LblJurusan.Location = New Point(640, 92)
        LblJurusan.Name = "LblJurusan"
        LblJurusan.Size = New Size(72, 20)
        LblJurusan.TabIndex = 3
        LblJurusan.Text = "JURUSAN"
        ' 
        ' LblAngkatan
        ' 
        LblAngkatan.AutoSize = True
        LblAngkatan.Location = New Point(12, 188)
        LblAngkatan.Name = "LblAngkatan"
        LblAngkatan.Size = New Size(86, 20)
        LblAngkatan.TabIndex = 4
        LblAngkatan.Text = "ANGKATAN"
        ' 
        ' LblIpk
        ' 
        LblIpk.AutoSize = True
        LblIpk.Location = New Point(304, 188)
        LblIpk.Name = "LblIpk"
        LblIpk.Size = New Size(30, 20)
        LblIpk.TabIndex = 5
        LblIpk.Text = "IPK"
        ' 
        ' LblJumlah
        ' 
        LblJumlah.AutoSize = True
        LblJumlah.Location = New Point(47, 394)
        LblJumlah.Name = "LblJumlah"
        LblJumlah.Size = New Size(104, 20)
        LblJumlah.TabIndex = 6
        LblJumlah.Text = "Jumlah data: 0"
        ' 
        ' txtNim
        ' 
        txtNim.Location = New Point(12, 115)
        txtNim.MaxLength = 9
        txtNim.Name = "txtNim"
        txtNim.Size = New Size(125, 27)
        txtNim.TabIndex = 7
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(281, 115)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(125, 27)
        txtNama.TabIndex = 8
        ' 
        ' txtAngkatan
        ' 
        txtAngkatan.Location = New Point(12, 211)
        txtAngkatan.MaxLength = 4
        txtAngkatan.Name = "txtAngkatan"
        txtAngkatan.Size = New Size(125, 27)
        txtAngkatan.TabIndex = 9
        ' 
        ' txtIpk
        ' 
        txtIpk.Location = New Point(281, 211)
        txtIpk.MaxLength = 4
        txtIpk.Name = "txtIpk"
        txtIpk.Size = New Size(125, 27)
        txtIpk.TabIndex = 10
        ' 
        ' cboJurusan
        ' 
        cboJurusan.DropDownStyle = ComboBoxStyle.DropDownList
        cboJurusan.FormattingEnabled = True
        cboJurusan.Items.AddRange(New Object() {" Teknik Informatika", "Sistem Informasi", "Manajemen Informatika", " Teknik Komputer"})
        cboJurusan.Location = New Point(579, 115)
        cboJurusan.Name = "cboJurusan"
        cboJurusan.Size = New Size(151, 28)
        cboJurusan.TabIndex = 11
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(462, 211)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(94, 29)
        btnTambah.TabIndex = 12
        btnTambah.Text = "TAMBAH"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' dgvMahasiswa
        ' 
        dgvMahasiswa.AllowUserToAddRows = False
        dgvMahasiswa.AllowUserToDeleteRows = False
        dgvMahasiswa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvMahasiswa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvMahasiswa.Location = New Point(12, 257)
        dgvMahasiswa.MultiSelect = False
        dgvMahasiswa.Name = "dgvMahasiswa"
        dgvMahasiswa.ReadOnly = True
        dgvMahasiswa.RowHeadersWidth = 51
        dgvMahasiswa.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvMahasiswa.Size = New Size(700, 135)
        dgvMahasiswa.TabIndex = 13
        ' 
        ' errInput
        ' 
        errInput.ContainerControl = Me
        ' 
        ' FrmDariList
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(742, 423)
        Controls.Add(dgvMahasiswa)
        Controls.Add(btnTambah)
        Controls.Add(cboJurusan)
        Controls.Add(txtIpk)
        Controls.Add(txtAngkatan)
        Controls.Add(txtNama)
        Controls.Add(txtNim)
        Controls.Add(LblJumlah)
        Controls.Add(LblIpk)
        Controls.Add(LblAngkatan)
        Controls.Add(LblJurusan)
        Controls.Add(LblNama)
        Controls.Add(LblNim)
        Controls.Add(LblJudul)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "FrmDariList"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Binding List(Of Mahasiswa)"
        CType(dgvMahasiswa, ComponentModel.ISupportInitialize).EndInit()
        CType(bsMahasiswa, ComponentModel.ISupportInitialize).EndInit()
        CType(errInput, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LblJudul As Label
    Friend WithEvents LblNim As Label
    Friend WithEvents LblNama As Label
    Friend WithEvents LblJurusan As Label
    Friend WithEvents LblAngkatan As Label
    Friend WithEvents LblIpk As Label
    Friend WithEvents LblJumlah As Label
    Friend WithEvents txtNim As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtAngkatan As TextBox
    Friend WithEvents txtIpk As TextBox
    Friend WithEvents cboJurusan As ComboBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents dgvMahasiswa As DataGridView
    Friend WithEvents bsMahasiswa As BindingSource
    Friend WithEvents errInput As ErrorProvider
End Class
