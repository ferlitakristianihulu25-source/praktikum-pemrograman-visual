<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmArray
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
        BtnTampil = New Button()
        txtPanjang = New TextBox()
        txtLebar = New TextBox()
        SuspendLayout()
        ' 
        ' txtPanjang
        ' 
        txtPanjang.Location = New Point(50, 50)
        txtPanjang.Name = "txtPanjang"
        txtPanjang.Size = New Size(100, 27)
        txtPanjang.TabIndex = 0
        ' 
        ' txtLebar
        ' 
        txtLebar.Location = New Point(50, 90)
        txtLebar.Name = "txtLebar"
        txtLebar.Size = New Size(100, 27)
        txtLebar.TabIndex = 1
        ' 
        ' BtnTampil
        ' 
        BtnTampil.Location = New Point(323, 253)
        BtnTampil.Name = "BtnTampil"
        BtnTampil.Size = New Size(94, 29)
        BtnTampil.TabIndex = 2
        BtnTampil.Text = "Tampilkan"
        BtnTampil.UseVisualStyleBackColor = True
        ' 
        ' FrmArray
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(BtnTampil)
        Controls.Add(txtLebar)
        Controls.Add(txtPanjang)
        Name = "FrmArray"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BtnTampil As Button
    Friend WithEvents txtPanjang As TextBox
    Friend WithEvents txtLebar As TextBox

End Class
