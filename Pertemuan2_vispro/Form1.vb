Public Class Form1
    Private Sub lblName_Click(sender As Object, e As EventArgs) Handles lblName.Click

    End Sub

    Private Sub txtNama_TextChanged(sender As Object, e As EventArgs) Handles txtNama.TextChanged

    End Sub

    Private Sub lblNim_Click(sender As Object, e As EventArgs) Handles lblNim.Click
    End Sub

    Private Sub btnTampilkan_Click(sender As Object, e As EventArgs) Handles btnTampilkan.Click
        MessageBox.Show("Halo Selamat Datang !" & vbCrLf &
            "Nama : " & txtNama.Text & vbCrLf &
            "NIM  : " & txtNim.Text & vbCrLf &
            "KOM  : " & txtKom.Text
        )
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtNim_TextChanged(sender As Object, e As EventArgs) Handles txtNim.TextChanged

    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        txtNama.Clear()
        txtNim.Clear()
        txtKom.Clear()
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Me.Close()
    End Sub
End Class
