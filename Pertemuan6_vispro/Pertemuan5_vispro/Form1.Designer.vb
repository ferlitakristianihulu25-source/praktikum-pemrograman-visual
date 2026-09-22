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
        btnTampilkan = New Button()
        Txtnama = New TextBox()
        TxtNIM = New TextBox()
        TxtJurusan = New TextBox()
        dgvMahasiswa = New DataGridView()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        btnTambah = New Button()
        CType(dgvMahasiswa, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnTampilkan
        ' 
        btnTampilkan.Location = New Point(258, 306)
        btnTampilkan.Name = "btnTampilkan"
        btnTampilkan.Size = New Size(94, 29)
        btnTampilkan.TabIndex = 0
        btnTampilkan.Text = "Tampilkan"
        btnTampilkan.UseVisualStyleBackColor = True
        ' 
        ' Txtnama
        ' 
        Txtnama.Location = New Point(567, 75)
        Txtnama.Name = "Txtnama"
        Txtnama.Size = New Size(125, 27)
        Txtnama.TabIndex = 1
        ' 
        ' TxtNIM
        ' 
        TxtNIM.Location = New Point(567, 137)
        TxtNIM.Name = "TxtNIM"
        TxtNIM.Size = New Size(125, 27)
        TxtNIM.TabIndex = 2
        ' 
        ' TxtJurusan
        ' 
        TxtJurusan.Location = New Point(567, 201)
        TxtJurusan.Name = "TxtJurusan"
        TxtJurusan.Size = New Size(125, 27)
        TxtJurusan.TabIndex = 3
        ' 
        ' dgvMahasiswa
        ' 
        dgvMahasiswa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvMahasiswa.Location = New Point(89, 40)
        dgvMahasiswa.Name = "dgvMahasiswa"
        dgvMahasiswa.RowHeadersWidth = 51
        dgvMahasiswa.Size = New Size(300, 188)
        dgvMahasiswa.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(486, 75)
        Label1.Name = "Label1"
        Label1.Size = New Size(56, 20)
        Label1.TabIndex = 5
        Label1.Text = "Nama :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(486, 137)
        Label2.Name = "Label2"
        Label2.Size = New Size(44, 20)
        Label2.TabIndex = 6
        Label2.Text = "NIM :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(486, 201)
        Label3.Name = "Label3"
        Label3.Size = New Size(64, 20)
        Label3.TabIndex = 7
        Label3.Text = "Jurusan :"
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(589, 274)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(94, 29)
        btnTambah.TabIndex = 8
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnTambah)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(dgvMahasiswa)
        Controls.Add(TxtJurusan)
        Controls.Add(TxtNIM)
        Controls.Add(Txtnama)
        Controls.Add(btnTampilkan)
        Name = "Form1"
        Text = "Form1"
        CType(dgvMahasiswa, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnTampilkan As Button
    Friend WithEvents Txtnama As TextBox
    Friend WithEvents TxtNIM As TextBox
    Friend WithEvents TxtJurusan As TextBox
    Friend WithEvents dgvMahasiswa As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnTambah As Button

End Class
