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
        lblName = New Label()
        txtNama = New TextBox()
        txtNim = New TextBox()
        lblNim = New Label()
        txtKom = New TextBox()
        lblKom = New Label()
        btnTampilkan = New Button()
        btnHapus = New Button()
        btnKeluar = New Button()
        SuspendLayout()
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Location = New Point(142, 62)
        lblName.Name = "lblName"
        lblName.Size = New Size(45, 15)
        lblName.TabIndex = 0
        lblName.Text = "Nama :"
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(193, 59)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(100, 23)
        txtNama.TabIndex = 1
        ' 
        ' txtNim
        ' 
        txtNim.Location = New Point(193, 88)
        txtNim.Name = "txtNim"
        txtNim.Size = New Size(100, 23)
        txtNim.TabIndex = 3
        ' 
        ' lblNim
        ' 
        lblNim.AutoSize = True
        lblNim.Location = New Point(142, 91)
        lblNim.Name = "lblNim"
        lblNim.Size = New Size(36, 15)
        lblNim.TabIndex = 2
        lblNim.Text = "NIM :"
        ' 
        ' txtKom
        ' 
        txtKom.Location = New Point(193, 117)
        txtKom.Name = "txtKom"
        txtKom.Size = New Size(100, 23)
        txtKom.TabIndex = 5
        ' 
        ' lblKom
        ' 
        lblKom.AutoSize = True
        lblKom.Location = New Point(142, 120)
        lblKom.Name = "lblKom"
        lblKom.Size = New Size(39, 15)
        lblKom.TabIndex = 4
        lblKom.Text = "KOM :"
        ' 
        ' btnTampilkan
        ' 
        btnTampilkan.Location = New Point(142, 163)
        btnTampilkan.Name = "btnTampilkan"
        btnTampilkan.Size = New Size(75, 23)
        btnTampilkan.TabIndex = 6
        btnTampilkan.Text = "Tampilkan"
        btnTampilkan.UseVisualStyleBackColor = True
        ' 
        ' btnHapus
        ' 
        btnHapus.Location = New Point(263, 163)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(47, 23)
        btnHapus.TabIndex = 7
        btnHapus.Text = "Reset"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' btnKeluar
        ' 
        btnKeluar.Location = New Point(212, 212)
        btnKeluar.Name = "btnKeluar"
        btnKeluar.Size = New Size(57, 23)
        btnKeluar.TabIndex = 8
        btnKeluar.Text = "Keluar"
        btnKeluar.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnKeluar)
        Controls.Add(btnHapus)
        Controls.Add(btnTampilkan)
        Controls.Add(txtKom)
        Controls.Add(lblKom)
        Controls.Add(txtNim)
        Controls.Add(lblNim)
        Controls.Add(txtNama)
        Controls.Add(lblName)
        Name = "Form1"
        Text = "Profile Mahasiswa"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtNim As TextBox
    Friend WithEvents lblNim As Label
    Friend WithEvents txtKom As TextBox
    Friend WithEvents lblKom As Label
    Friend WithEvents btnTampilkan As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnKeluar As Button

End Class
