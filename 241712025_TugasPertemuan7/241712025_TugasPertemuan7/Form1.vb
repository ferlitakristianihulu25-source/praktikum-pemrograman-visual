Option Strict On

Imports System.IO

Public Class Form1

    ' List untuk menyimpan daftar buku yang sedang dipinjam (mencegah duplikasi)
    Private daftarPeminjaman As New List(Of String)()

    ' 1. Inisialisasi Data awal saat Form Load
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboKategori.Items.Clear()
        cboKategori.Items.AddRange(New String() {"Fiksi", "Nonfiksi", "Referensi", "Majalah"})
        cboKategori.SelectedIndex = -1
        UpdateStatus()
    End Sub

    ' 2. Fungsi Validasi Terpusat Memakai errPinjam dan Function dari Module
    Private Function ValidasiInput() As Boolean
        Dim isValid As Boolean = True
        errPinjam.Clear()

        ' A. Validasi Kode Buku menggunakan fungsi di Module
        Dim kodeBuku As String = txtKodeBuku.Text.Trim().ToUpper()
        If Not KodeBukuValid(kodeBuku) Then
            errPinjam.SetError(txtKodeBuku, "Kode buku harus BK diikuti 4 digit, contoh BK0012.")
            isValid = False
        Else
            ' Cek apakah buku sedang dipinjam
            For Each item As String In lstPeminjaman.Items
                If item.StartsWith(kodeBuku & " |") Then
                    errPinjam.SetError(txtKodeBuku, "Buku ini sedang dipinjam.")
                    isValid = False
                    Exit For
                End If
            Next
        End If

        ' B. Validasi Judul Buku (Wajib diisi)
        If String.IsNullOrWhiteSpace(txtJudul.Text) Then
            errPinjam.SetError(txtJudul, "Judul buku wajib diisi.")
            isValid = False
        End If

        ' C. Validasi Kategori (Wajib dipilih)
        If cboKategori.SelectedIndex = -1 Then
            errPinjam.SetError(cboKategori, "Kategori wajib dipilih.")
            isValid = False
        End If

        ' D. Validasi Nama Peminjam (Minimal 3 karakter tanpa spasi awal/akhir)
        Dim namaPeminjam As String = txtNamaPeminjam.Text.Trim()
        If namaPeminjam.Length < 3 Then
            errPinjam.SetError(txtNamaPeminjam, "Nama peminjam minimal 3 karakter.")
            isValid = False
        End If

        ' E. Validasi Lama Pinjam (Bilangan bulat 1 sampai 14 menggunakan Integer.TryParse)
        Dim lamaPinjam As Integer
        If Not Integer.TryParse(txtLamaPinjam.Text.Trim(), lamaPinjam) OrElse lamaPinjam < 1 OrElse lamaPinjam > 14 Then
            errPinjam.SetError(txtLamaPinjam, "Lama pinjam harus bilangan bulat antara 1 sampai 14 hari.")
            isValid = False
        End If

        Return isValid
    End Function

    ' 3. Tantangan Tambahan: Event Validating untuk txtKodeBuku (tanpa e.Cancel = True)
    Private Sub txtKodeBuku_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtKodeBuku.Validating
        Dim kodeBuku As String = txtKodeBuku.Text.Trim().ToUpper()
        If Not String.IsNullOrEmpty(kodeBuku) AndAlso Not KodeBukuValid(kodeBuku) Then
            errPinjam.SetError(txtKodeBuku, "Format kode buku salah (contoh: BK0012).")
        Else
            errPinjam.SetError(txtKodeBuku, "")
        End If
    End Sub

    ' 4. Tombol Pinjam
    Private Sub btnPinjam_Click(sender As Object, e As EventArgs) Handles btnPinjam.Click
        If ValidasiInput() Then
            Dim kodeBuku As String = txtKodeBuku.Text.Trim().ToUpper()
            Dim judul As String = txtJudul.Text.Trim()
            Dim kategori As String = cboKategori.SelectedItem.ToString()
            Dim nama As String = txtNamaPeminjam.Text.Trim()
            Dim lama As Integer = Convert.ToInt32(txtLamaPinjam.Text.Trim())

            ' Tanggal kembali: Date.Today.AddDays(lama) sesuai petunjuk aslab
            Dim tanggalKembali As String = Date.Today.AddDays(lama).ToString("dd/MM/yyyy")

            ' Format baris data sesuai ketentuan
            Dim barisData As String = $"{kodeBuku} | {judul} | {kategori} | {nama} | {lama} hari | kembali {tanggalKembali}"

            lstPeminjaman.Items.Add(barisData)
            daftarPeminjaman.Add(kodeBuku)

            BersihkanForm()
            UpdateStatus()
        End If
    End Sub

    ' 5. Tombol Bersihkan (CausesValidation diset False)
    Private Sub btnBersihkan_Click(sender As Object, e As EventArgs) Handles btnBersihkan.Click
        BersihkanForm()
    End Sub

    Private Sub BersihkanForm()
        txtKodeBuku.Clear()
        txtJudul.Clear()
        cboKategori.SelectedIndex = -1
        txtNamaPeminjam.Clear()
        txtLamaPinjam.Clear()
        errPinjam.Clear()
        UpdateStatus()
    End Sub

    ' 6. Tombol Ekspor ke CSV dengan Try...Catch...Finally dan 2 Catch spesifik
    Private Sub btnEkspor_Click(sender As Object, e As EventArgs) Handles btnEkspor.Click
        If lstPeminjaman.Items.Count = 0 Then
            MessageBox.Show("Daftar peminjaman masih kosong. Tidak ada data yang dapat diekspor.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim pathDocuments As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        Dim filePath As String = Path.Combine(pathDocuments, "peminjaman.csv")
        Dim sw As StreamWriter = Nothing

        Try
            sw = New StreamWriter(filePath, False)
            ' Baris pertama judul kolom dengan pemisah titik koma (;)
            sw.WriteLine("KodeBuku;JudulBuku;Kategori;NamaPeminjam;LamaPinjam;TanggalKembali")

            For Each item As Object In lstPeminjaman.Items
                Dim barisStr As String = item.ToString()
                Dim barisCsv As String = barisStr.Replace(" | ", ";").Replace(" hari", "").Replace("kembali ", "")
                sw.WriteLine(barisCsv)
            Next

            MessageBox.Show($"Data berhasil diekspor ke: {filePath}", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As IOException
            MessageBox.Show("Terjadi kesalahan I/O (File mungkin sedang dibuka di Excel): " & ex.Message, "Error IOException", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As UnauthorizedAccessException
            MessageBox.Show("Akses ditolak untuk menulis ke folder Documents: " & ex.Message, "Error Unauthorized", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' StreamWriter ditutup di blok Finally
            If sw IsNot Nothing Then
                sw.Close()
            End If
        End Try
    End Sub

    Private Sub UpdateStatus()
        lblStatus.Text = $"Jumlah peminjaman: {lstPeminjaman.Items.Count}"
    End Sub

End Class