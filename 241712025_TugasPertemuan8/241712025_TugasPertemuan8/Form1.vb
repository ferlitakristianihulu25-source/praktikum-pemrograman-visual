Option Strict On

Public Class Form1

    ' Deklarasi DataTable untuk menyimpan inventaris di memori
    Private tabelBuku As New DataTable()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 1. Inisialisasi Kolom DataTable
        tabelBuku.Columns.Add("KodeBuku", GetType(String))
        tabelBuku.Columns.Add("Judul", GetType(String))
        tabelBuku.Columns.Add("Penulis", GetType(String))
        tabelBuku.Columns.Add("Kategori", GetType(String))
        tabelBuku.Columns.Add("Tahun", GetType(Integer))
        tabelBuku.Columns.Add("Stok", GetType(Integer))

        ' 2. Mengisi Data Awal (Minimal 10 buku, mewakili semua kategori, ada stok 0)[cite: 10]
        tabelBuku.Rows.Add("BK0001", "Laskar Pelangi", "Andrea Hirata", "Fiksi", 2005, 8)
        tabelBuku.Rows.Add("BK0002", "Bumi Manusia", "Pramoedya Ananta Toer", "Fiksi", 1980, 0)
        tabelBuku.Rows.Add("BK0003", "Filosofi Teras", "Henry Manampiring", "Nonfiksi", 2018, 5)
        tabelBuku.Rows.Add("BK0004", "Kamus Bahasa Indonesia", "Tim Bahasa", "Referensi", 2020, 3)
        tabelBuku.Rows.Add("BK0005", "Majalah Sains Nusantara", "Redaksi Sains", "Majalah", 2024, 0)
        tabelBuku.Rows.Add("BK0006", "Ma'rifat Cahaya", "Ahmad Fauzi", "Nonfiksi", 2019, 4)
        tabelBuku.Rows.Add("BK0007", "Negeri 5 Menara", "Ahmad Fuadi", "Fiksi", 2009, 6)
        tabelBuku.Rows.Add("BK0008", "Atlas Indonesia", "Tim Kartografi", "Referensi", 2022, 2)
        tabelBuku.Rows.Add("BK0009", "Majalah Taman Kita", "Redaksi Taman", "Majalah", 2023, 7)
        tabelBuku.Rows.Add("BK0010", "Sejarah Nusantara", "Dewi Lestari P.", "Nonfiksi", 2021, 0)
        tabelBuku.Rows.Add("BK0011", "Ronggeng Dukuh Paruk", "Ahmad Tohari", "Fiksi", 2003, 4)

        ' 3. Hubungkan DataTable ke BindingSource, lalu ke DataGridView[cite: 10]
        bsBuku.DataSource = tabelBuku
        dgvBuku.DataSource = bsBuku

        ' 4. Mengatur Tampilan Kolom DataGridView agar Rapi[cite: 10]
        AturTampilanKolomGrid()

        ' 5. Inisialisasi ComboBox Kategori, Filter, dan Urut
        cboKategori.Items.AddRange(New String() {"Fiksi", "Nonfiksi", "Referensi", "Majalah"})
        cboKategori.SelectedIndex = -1

        cboFilterKategori.Items.AddRange(New String() {"Semua", "Fiksi", "Nonfiksi", "Referensi", "Majalah"})
        cboFilterKategori.SelectedIndex = 0

        cboUrut.Items.AddRange(New String() {"Urutkan awal", "Judul A-Z", "Tahun terbaru", "Stok terbanyak"})
        cboUrut.SelectedIndex = 0

        UpdateRingkasan()
    End Sub

    ' --- FUNGSI MENGATUR KOLOM GRID ---
    Private Sub AturTampilanKolomGrid()
        If dgvBuku.Columns.Contains("KodeBuku") Then
            dgvBuku.Columns("KodeBuku").HeaderText = "Kode Buku"
            dgvBuku.Columns("KodeBuku").Width = 100
        End If

        If dgvBuku.Columns.Contains("Judul") Then
            dgvBuku.Columns("Judul").HeaderText = "Judul"
            dgvBuku.Columns("Judul").FillWeight = 200 ' Kolom judul lebih lebar[cite: 10]
        End If

        If dgvBuku.Columns.Contains("Penulis") Then
            dgvBuku.Columns("Penulis").HeaderText = "Penulis"
        End If

        If dgvBuku.Columns.Contains("Kategori") Then
            dgvBuku.Columns("Kategori").HeaderText = "Kategori"
        End If

        If dgvBuku.Columns.Contains("Tahun") Then
            dgvBuku.Columns("Tahun").HeaderText = "Tahun"
            dgvBuku.Columns("Tahun").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        End If

        If dgvBuku.Columns.Contains("Stok") Then
            dgvBuku.Columns("Stok").HeaderText = "Stok"
            dgvBuku.Columns("Stok").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        End If

        dgvBuku.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    ' --- FUNGSI VALIDASI TERPUSAT ---
    Private Function ValidasiInput() As Boolean
        Dim isValid As Boolean = True
        errBuku.Clear()

        ' A. Validasi Kode Buku (Format: BK + 4 digit dan belum ada di tabelBuku)[cite: 10]
        Dim kodeBuku As String = txtKodeBuku.Text.Trim().ToUpper()
        Dim pattern As String = "^BK\d{4}$"
        If Not System.Text.RegularExpressions.Regex.IsMatch(kodeBuku, pattern) Then
            errBuku.SetError(txtKodeBuku, "Kode buku harus BK diikuti 4 digit (contoh: BK0012).")
            isValid = False
        Else
            ' Cek apakah kode buku sudah terdaftar menggunakan perulangan DataRow[cite: 10]
            For Each row As DataRow In tabelBuku.Rows
                If row("KodeBuku").ToString().ToUpper() = kodeBuku Then
                    errBuku.SetError(txtKodeBuku, "Kode buku sudah terdaftar di inventaris.")
                    isValid = False
                    Exit For
                End If
            Next
        End If

        ' B. Validasi Judul Wajib Diisi[cite: 10]
        If String.IsNullOrWhiteSpace(txtJudul.Text) Then
            errBuku.SetError(txtJudul, "Judul buku wajib diisi.")
            isValid = False
        End If

        ' C. Validasi Penulis Wajib Diisi[cite: 10]
        If String.IsNullOrWhiteSpace(txtPenulis.Text) Then
            errBuku.SetError(txtPenulis, "Penulis wajib diisi.")
            isValid = False
        End If

        ' D. Validasi Kategori Wajib Dipilih[cite: 10]
        If cboKategori.SelectedIndex = -1 Then
            errBuku.SetError(cboKategori, "Kategori wajib dipilih.")
            isValid = False
        End If

        ' E. Validasi Tahun (Bilangan bulat dari 1900 sampai tahun saat ini)[cite: 10]
        Dim tahun As Integer
        Dim tahunSekarang As Integer = Date.Now.Year
        If Not Integer.TryParse(txtTahun.Text.Trim(), tahun) OrElse tahun < 1900 OrElse tahun > tahunSekarang Then
            errBuku.SetError(txtTahun, $"Tahun harus berupa angka antara 1900 sampai {tahunSekarang}.")
            isValid = False
        End If

        ' F. Validasi Stok (Bilangan bulat 0 atau lebih)[cite: 10]
        Dim stok As Integer
        If Not Integer.TryParse(txtStok.Text.Trim(), stok) OrElse stok < 0 Then
            errBuku.SetError(txtStok, "Stok harus berupa angka 0 atau lebih.")
            isValid = False
        End If

        Return isValid
    End Function

    ' --- TOMBOL TAMBAH BUKU ---
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If ValidasiInput() Then
            Dim kode As String = txtKodeBuku.Text.Trim().ToUpper()
            Dim judul As String = txtJudul.Text.Trim()
            Dim penulis As String = txtPenulis.Text.Trim()
            Dim kategori As String = cboKategori.SelectedItem.ToString()
            Dim tahun As Integer = Convert.ToInt32(txtTahun.Text.Trim())
            Dim stok As Integer = Convert.ToInt32(txtStok.Text.Trim())

            ' Menambahkan data langsung ke DataTable (Grid langsung memperbarui tampilan)[cite: 10]
            tabelBuku.Rows.Add(kode, judul, penulis, kategori, tahun, stok)

            MessageBox.Show("Buku baru berhasil ditambahkan ke inventaris!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            BersihkanForm()
            TerapkanFilter()
        End If
    End Sub

    ' --- TOMBOL BERSIHKAN ---
    Private Sub btnBersihkan_Click(sender As Object, e As EventArgs) Handles btnBersihkan.Click
        BersihkanForm()
    End Sub

    Private Sub BersihkanForm()
        txtKodeBuku.Clear()
        txtJudul.Clear()
        txtPenulis.Clear()
        cboKategori.SelectedIndex = -1
        txtTahun.Clear()
        txtStok.Clear()
        errBuku.Clear()
    End Sub

    ' --- EVENT PENCARIAN & FILTER ---
    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        TerapkanFilter()
    End Sub

    Private Sub cboFilterKategori_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFilterKategori.SelectedIndexChanged
        TerapkanFilter()
    End Sub

    Private Sub chkStokHabis_CheckedChanged(sender As Object, e As EventArgs) Handles chkStokHabis.CheckedChanged
        TerapkanFilter()
    End Sub

    Private Sub cboUrut_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboUrut.SelectedIndexChanged
        TerapkanFilter()
    End Sub

    ' --- PENCARIAN GABUNGAN DAN PENGURUTAN ---
    Private Sub TerapkanFilter()
        Dim keyword As String = txtCari.Text.Trim()

        ' Mengamankan karakter khusus (tanda kutip ' ) agar tidak membuat filter error[cite: 10]
        keyword = keyword.[Replace]("'", "''")

        Dim kategoriPilih As String = If(cboFilterKategori.SelectedItem IsNot Nothing, cboFilterKategori.SelectedItem.ToString(), "Semua")
        Dim filterList As New List(Of String)()

        ' 1. Filter teks pencarian (Judul atau Penulis)[cite: 10]
        If Not String.IsNullOrEmpty(keyword) Then
            filterList.Add($"(Judul LIKE '%{keyword}%' OR Penulis LIKE '%{keyword}%')")
        End If

        ' 2. Filter Kategori[cite: 10]
        If kategoriPilih <> "Semua" Then
            filterList.Add($"Kategori = '{kategoriPilih}'")
        End If

        ' 3. Tantangan Tambahan: Filter CheckBox "Hanya stok habis"[cite: 10]
        If chkStokHabis.Checked Then
            filterList.Add("Stok = 0")
        End If

        ' Gabungkan syarat filter dengan operator AND[cite: 10]
        If filterList.Count > 0 Then
            bsBuku.Filter = String.Join(" AND ", filterList)
        Else
            bsBuku.Filter = String.Empty
        End If

        ' 4. Tantangan Tambahan: Pengurutan data (bsBuku.Sort)[cite: 10]
        If cboUrut.SelectedItem IsNot Nothing Then
            Dim pilihanUrut As String = cboUrut.SelectedItem.ToString()
            Select Case pilihanUrut
                Case "Judul A-Z"
                    bsBuku.Sort = "Judul ASC"
                Case "Tahun terbaru"
                    bsBuku.Sort = "Tahun DESC"
                Case "Stok terbanyak"
                    bsBuku.Sort = "Stok DESC"
                Case Else
                    bsBuku.Sort = String.Empty
            End Select
        End If

        UpdateRingkasan()
    End Sub

    ' --- RINGKASAN HASIL (lblJumlah & lblTotalStok) ---
    Private Sub UpdateRingkasan()
        Dim totalDitampilkan As Integer = dgvBuku.Rows.Count
        Dim totalSeluruh As Integer = tabelBuku.Rows.Count

        ' Menampilkan label jumlah baris (X dari Y buku)[cite: 10]
        lblJumlah.Text = $"Menampilkan {totalDitampilkan} dari {totalSeluruh} buku"

        ' Menghitung total stok dari baris yang sedang tampil di grid menggunakan perulangan DataGridViewRow[cite: 10]
        Dim totalStok As Integer = 0
        For Each row As DataGridViewRow In dgvBuku.Rows
            If row.Cells("Stok").Value IsNot Nothing Then
                totalStok += Convert.ToInt32(row.Cells("Stok").Value)
            End If
        Next

        lblTotalStok.Text = $"Total stok yang tampil: {totalStok}"
    End Sub

End Class