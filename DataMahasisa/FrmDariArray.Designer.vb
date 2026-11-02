<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDariArray
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
        lblJudul = New Label()
        dgvMahasiswa = New DataGridView()
        btnTampilkan = New Button()
        btnKosongkan = New Button()
        lblJumlah = New Label()
        colNim = New DataGridViewTextBoxColumn()
        ColNama = New DataGridViewTextBoxColumn()
        ColJurusan = New DataGridViewTextBoxColumn()
        ColAngkatan = New DataGridViewTextBoxColumn()
        ColIpk = New DataGridViewTextBoxColumn()
        CType(dgvMahasiswa, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblJudul
        ' 
        lblJudul.AutoSize = True
        lblJudul.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblJudul.Location = New Point(12, 9)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New Size(289, 31)
        lblJudul.TabIndex = 0
        lblJudul.Text = "Data dari Array 2 Dimensi"
        ' 
        ' dgvMahasiswa
        ' 
        dgvMahasiswa.AllowUserToAddRows = False
        dgvMahasiswa.AllowUserToDeleteRows = False
        dgvMahasiswa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvMahasiswa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvMahasiswa.Columns.AddRange(New DataGridViewColumn() {colNim, ColNama, ColJurusan, ColAngkatan, ColIpk})
        dgvMahasiswa.Location = New Point(36, 69)
        dgvMahasiswa.MultiSelect = False
        dgvMahasiswa.Name = "dgvMahasiswa"
        dgvMahasiswa.ReadOnly = True
        dgvMahasiswa.RowHeadersWidth = 51
        dgvMahasiswa.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvMahasiswa.Size = New Size(624, 188)
        dgvMahasiswa.TabIndex = 1
        ' 
        ' btnTampilkan
        ' 
        btnTampilkan.Location = New Point(36, 294)
        btnTampilkan.Name = "btnTampilkan"
        btnTampilkan.Size = New Size(94, 29)
        btnTampilkan.TabIndex = 2
        btnTampilkan.Text = "Tampilkan"
        btnTampilkan.UseVisualStyleBackColor = True
        ' 
        ' btnKosongkan
        ' 
        btnKosongkan.Location = New Point(298, 294)
        btnKosongkan.Name = "btnKosongkan"
        btnKosongkan.Size = New Size(94, 29)
        btnKosongkan.TabIndex = 3
        btnKosongkan.Text = "Kosongkan"
        btnKosongkan.UseVisualStyleBackColor = True
        ' 
        ' lblJumlah
        ' 
        lblJumlah.AutoSize = True
        lblJumlah.Location = New Point(556, 294)
        lblJumlah.Name = "lblJumlah"
        lblJumlah.Size = New Size(104, 20)
        lblJumlah.TabIndex = 4
        lblJumlah.Text = "Jumlah data: 0"
        ' 
        ' colNim
        ' 
        colNim.HeaderText = "NIM"
        colNim.MinimumWidth = 6
        colNim.Name = "colNim"
        colNim.ReadOnly = True
        ' 
        ' ColNama
        ' 
        ColNama.HeaderText = "NAMA"
        ColNama.MinimumWidth = 6
        ColNama.Name = "ColNama"
        ColNama.ReadOnly = True
        ' 
        ' ColJurusan
        ' 
        ColJurusan.HeaderText = "JURUSAN"
        ColJurusan.MinimumWidth = 6
        ColJurusan.Name = "ColJurusan"
        ColJurusan.ReadOnly = True
        ' 
        ' ColAngkatan
        ' 
        ColAngkatan.HeaderText = "ANGKATAN"
        ColAngkatan.MinimumWidth = 6
        ColAngkatan.Name = "ColAngkatan"
        ColAngkatan.ReadOnly = True
        ' 
        ' ColIpk
        ' 
        ColIpk.HeaderText = "IPK"
        ColIpk.MinimumWidth = 6
        ColIpk.Name = "ColIpk"
        ColIpk.ReadOnly = True
        ' 
        ' FrmDariArray
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(702, 353)
        Controls.Add(lblJumlah)
        Controls.Add(btnKosongkan)
        Controls.Add(btnTampilkan)
        Controls.Add(dgvMahasiswa)
        Controls.Add(lblJudul)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MinimizeBox = False
        Name = "FrmDariArray"
        StartPosition = FormStartPosition.CenterScreen
        Text = "DataGridView dari Array"
        CType(dgvMahasiswa, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblJudul As Label
    Friend WithEvents dgvMahasiswa As DataGridView
    Friend WithEvents btnTampilkan As Button
    Friend WithEvents btnKosongkan As Button
    Friend WithEvents lblJumlah As Label
    Friend WithEvents colNim As DataGridViewTextBoxColumn
    Friend WithEvents ColNama As DataGridViewTextBoxColumn
    Friend WithEvents ColJurusan As DataGridViewTextBoxColumn
    Friend WithEvents ColAngkatan As DataGridViewTextBoxColumn
    Friend WithEvents ColIpk As DataGridViewTextBoxColumn
End Class
