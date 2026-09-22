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
        BtnInput = New Button()
        txtNilai = New TextBox()
        PicImage = New PictureBox()
        CType(PicImage, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' BtnInput
        ' 
        BtnInput.Location = New Point(349, 240)
        BtnInput.Name = "BtnInput"
        BtnInput.Size = New Size(94, 29)
        BtnInput.TabIndex = 0
        BtnInput.Text = "Input"
        BtnInput.UseVisualStyleBackColor = True
        ' 
        ' txtNilai
        ' 
        txtNilai.Location = New Point(338, 207)
        txtNilai.Name = "txtNilai"
        txtNilai.Size = New Size(125, 27)
        txtNilai.TabIndex = 1
        ' 
        ' PicImage
        ' 
        PicImage.Location = New Point(338, 64)
        PicImage.Name = "PicImage"
        PicImage.Size = New Size(105, 123)
        PicImage.TabIndex = 2
        PicImage.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(PicImage)
        Controls.Add(txtNilai)
        Controls.Add(BtnInput)
        Name = "Form1"
        Text = "Form1"
        CType(PicImage, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BtnInput As Button
    Friend WithEvents txtNilai As TextBox
    Friend WithEvents PicImage As PictureBox

End Class
