Public Class FrmPajak

    Private Sub txtPendapatan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPendapatan.KeyPress
        ' Validasi agar txtPendapatan hanya menerima angka dan tombol kontrol (Backspace)
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        ' 1. & 2. Validasi input pendapatan tidak boleh kosong dan berupa angka valid
        Dim pendapatan As Decimal

        If txtPendapatan.Text.Trim() = "" OrElse Not Decimal.TryParse(txtPendapatan.Text.Trim(), pendapatan) Then
            MessageBox.Show("Masukkan jumlah pendapatan yang valid berupa angka!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPendapatan.Focus()
            Exit Sub
        End If

        Dim persentasePajak As Decimal = 0D
        Dim tarifPajakTeks As String = "0%"

        ' 4. Penentuan persentase pajak berdasarkan ketentuan tabel baru
        If pendapatan <= 5000000D Then
            persentasePajak = 0D
            tarifPajakTeks = "0%"
        ElseIf pendapatan <= 30000000D Then
            persentasePajak = 0.1D
            tarifPajakTeks = "10%"
        ElseIf pendapatan <= 100000000D Then
            persentasePajak = 0.2D
            tarifPajakTeks = "20%"
        Else
            persentasePajak = 0.3D
            tarifPajakTeks = "30%"
        End If

        ' Rumus umum: Pajak = Pendapatan * Persentase Pajak
        Dim totalPajak As Decimal = pendapatan * persentasePajak

        ' 5. & 6. Tampilkan hasil pajak dalam format rupiah tanpa desimal (misal: Rp 1.000.000)
        Dim pesan As String = "Pendapatan: Rp " & pendapatan.ToString("N0") & vbCrLf &
                               "Tarif Pajak: " & tarifPajakTeks & vbCrLf &
                               "Pajak yang harus dibayar: Rp " & totalPajak.ToString("N0")

        MessageBox.Show(pesan, "Hasil Perhitungan Pajak", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        ' 1. Tutup FrmPajak menggunakan method Close
        Me.Close()
    End Sub

    Private Sub FrmPajak_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        ' 2. Tampilkan kembali FrmLogin menggunakan method Show saat form pajak ditutup
        For Each frm As Form In Application.OpenForms
            If TypeOf frm Is FrmLogin Then
                frm.Show()
                Exit For
            End If
        Next
    End Sub

End Class