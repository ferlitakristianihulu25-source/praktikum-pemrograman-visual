Option Strict On

Module Module1

    ' Fungsi untuk memvalidasi format kode buku (Nilai Lebih dari Aslab)
    Public Function KodeBukuValid(ByVal kode As String) As Boolean
        Dim kodeTrim As String = kode.Trim().ToUpper()

        ' Memeriksa panjang string dan awalan "BK" menggunakan .StartsWith() dan .Substring()
        If kodeTrim.Length = 6 AndAlso kodeTrim.StartsWith("BK") Then
            Dim sisaDigit As String = kodeTrim.Substring(2)

            ' Memeriksa apakah 4 karakter setelah BK benar-benar berupa angka (digit)
            For Each c As Char In sisaDigit
                If Not Char.IsDigit(c) Then
                    Return False
                End If
            Next
            Return True
        End If

        Return False
    End Function

End Module