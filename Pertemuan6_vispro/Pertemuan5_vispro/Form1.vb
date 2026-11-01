Public Class Form1
    Private Sub btnTampilkan_Click(sender As Object, e As EventArgs) Handles btnTampilkan.Click
        dgvMahasiswa.AutoGenerateColumns = True
        dgvMahasiswa.DataSource = ModQuery.TampilkanData()
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If ModQuery.TambahData(
            TxtNIM.Text,
            Txtnama.Text,
            TxtJurusan.Text
    ) Then
            MessageBox.Show("Data Berhasil Disimpan!")
        End If
        TxtJurusan.Clear()
        Txtnama.Clear()
        TxtNIM.Clear()
    End Sub


End Class