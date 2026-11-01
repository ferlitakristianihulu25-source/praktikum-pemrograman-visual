<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmUtama
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
        LblJudul = New Label()
        btnDariArray = New Button()
        btnDariList = New Button()
        btnDataTable = New Button()
        btnCariList = New Button()
        SuspendLayout()
        ' 
        ' LblJudul
        ' 
        LblJudul.AutoSize = True
        LblJudul.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblJudul.Location = New Point(86, 9)
        LblJudul.Name = "LblJudul"
        LblJudul.Size = New Size(207, 28)
        LblJudul.TabIndex = 0
        LblJudul.Text = "Contoh Pertemuan 8"
        ' 
        ' btnDariArray
        ' 
        btnDariArray.Location = New Point(23, 62)
        btnDariArray.Name = "btnDariArray"
        btnDariArray.Size = New Size(206, 29)
        btnDariArray.TabIndex = 1
        btnDariArray.Text = "1. DataGridView dari Array"
        btnDariArray.UseVisualStyleBackColor = True
        ' 
        ' btnDariList
        ' 
        btnDariList.Location = New Point(23, 109)
        btnDariList.Name = "btnDariList"
        btnDariList.Size = New Size(233, 29)
        btnDariList.TabIndex = 2
        btnDariList.Text = "2. Binding List(Of Mahasiswa)"
        btnDariList.UseVisualStyleBackColor = True
        ' 
        ' btnDataTable
        ' 
        btnDataTable.Location = New Point(23, 161)
        btnDataTable.Name = "btnDataTable"
        btnDataTable.Size = New Size(287, 29)
        btnDataTable.TabIndex = 3
        btnDataTable.Text = "3. DataTable, Rapikan Kolom dan Filter"
        btnDataTable.UseVisualStyleBackColor = True
        ' 
        ' btnCariList
        ' 
        btnCariList.Location = New Point(23, 212)
        btnCariList.Name = "btnCariList"
        btnCariList.Size = New Size(256, 29)
        btnCariList.TabIndex = 4
        btnCariList.Text = "4. Pencarian dengan Perulangan"
        btnCariList.UseVisualStyleBackColor = True
        ' 
        ' FrmUtama
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(422, 253)
        Controls.Add(btnCariList)
        Controls.Add(btnDataTable)
        Controls.Add(btnDariList)
        Controls.Add(btnDariArray)
        Controls.Add(LblJudul)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "FrmUtama"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Pertemuan 8 - DataGridView, Array & Koleksi Data"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LblJudul As Label
    Friend WithEvents btnDariArray As Button
    Friend WithEvents btnDariList As Button
    Friend WithEvents btnDataTable As Button
    Friend WithEvents btnCariList As Button

End Class
