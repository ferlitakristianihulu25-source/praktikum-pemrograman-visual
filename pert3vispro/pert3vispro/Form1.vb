Public Class Form1
    Private Sub btnInput_Click(sender As Object, e As EventArgs) Handles BtnInput.Click
        Dim nilai As Integer
        If Not Integer.TryParse(txtNilai.Text, nilai) Then
            MessageBox.Show("Masukkan dalam bentuk angka")
            txtNilai.Focus()
            Return
        End If

        If nilai < 0 OrElse nilai > 100 Then
            MessageBox.Show("Masukkan nilai 0-100")
            txtNilai.Focus()
            Return
        End If

        If nilai <= 50 Then
            PicImage.Image = Image.FromFile("Assets\1.jpeg")
        End If
    End Sub

    Private Sub txtNilai_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNilai.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class