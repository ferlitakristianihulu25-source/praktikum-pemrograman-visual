<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDataTable
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
        LblCari = New Label()
        LblJumlah = New Label()
        txtCari = New TextBox()
        dgvMahasiswa = New DataGridView()
        BtnRapikan = New Button()
        bsMahasiswa = New BindingSource(components)
        CType(dgvMahasiswa, ComponentModel.ISupportInitialize).BeginInit()
        CType(bsMahasiswa, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' LblJudul
        ' 
        LblJudul.AutoSize = True
        LblJudul.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblJudul.Location = New Point(12, 9)
        LblJudul.Name = "LblJudul"
        LblJudul.Size = New Size(306, 31)
        LblJudul.TabIndex = 0
        LblJudul.Text = "DataTable + BindingSource"
        ' 
        ' LblCari
        ' 
        LblCari.AutoSize = True
        LblCari.Location = New Point(12, 78)
        LblCari.Name = "LblCari"
        LblCari.Size = New Size(113, 20)
        LblCari.TabIndex = 1
        LblCari.Text = "Cari nama/NIM:"
        ' 
        ' LblJumlah
        ' 
        LblJumlah.AutoSize = True
        LblJumlah.Location = New Point(12, 381)
        LblJumlah.Name = "LblJumlah"
        LblJumlah.Size = New Size(187, 20)
        LblJumlah.TabIndex = 2
        LblJumlah.Text = "Menampilkan 0 dari 0 data"
        ' 
        ' txtCari
        ' 
        txtCari.Location = New Point(143, 78)
        txtCari.Name = "txtCari"
        txtCari.Size = New Size(125, 27)
        txtCari.TabIndex = 3
        ' 
        ' dgvMahasiswa
        ' 
        dgvMahasiswa.AllowUserToAddRows = False
        dgvMahasiswa.AllowUserToDeleteRows = False
        dgvMahasiswa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvMahasiswa.Location = New Point(18, 146)
        dgvMahasiswa.MultiSelect = False
        dgvMahasiswa.Name = "dgvMahasiswa"
        dgvMahasiswa.ReadOnly = True
        dgvMahasiswa.RowHeadersWidth = 51
        dgvMahasiswa.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvMahasiswa.Size = New Size(681, 188)
        dgvMahasiswa.TabIndex = 4
        ' 
        ' BtnRapikan
        ' 
        BtnRapikan.Location = New Point(589, 67)
        BtnRapikan.Name = "BtnRapikan"
        BtnRapikan.Size = New Size(94, 29)
        BtnRapikan.TabIndex = 5
        BtnRapikan.Text = "Rapikan Kolom"
        BtnRapikan.UseVisualStyleBackColor = True
        ' 
        ' FrmDataTable
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(742, 423)
        Controls.Add(BtnRapikan)
        Controls.Add(dgvMahasiswa)
        Controls.Add(txtCari)
        Controls.Add(LblJumlah)
        Controls.Add(LblCari)
        Controls.Add(LblJudul)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "FrmDataTable"
        StartPosition = FormStartPosition.CenterScreen
        Text = "DataTable, BindingSource & Filter"
        CType(dgvMahasiswa, ComponentModel.ISupportInitialize).EndInit()
        CType(bsMahasiswa, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LblJudul As Label
    Friend WithEvents LblCari As Label
    Friend WithEvents LblJumlah As Label
    Friend WithEvents txtCari As TextBox
    Friend WithEvents dgvMahasiswa As DataGridView
    Friend WithEvents BtnRapikan As Button
    Friend WithEvents bsMahasiswa As BindingSource
End Class
