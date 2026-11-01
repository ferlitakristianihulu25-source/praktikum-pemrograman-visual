Imports System.IO

Public Class FrmLogin



    Private Sub cmbRole_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRole.SelectedIndexChanged
        If cmbRole.SelectedItem IsNot Nothing Then
            If cmbRole.SelectedItem.ToString() = "Staff" Then
                LoadImage("Staff1.jpg")
            ElseIf cmbRole.SelectedItem.ToString() = "Manager" Then
                LoadImage("Manager2.jpg")
            End If
        End If
    End Sub

    Private Sub LoadImage(fileName As String)
        Dim imagePath As String = Path.Combine(Application.StartupPath, "Assets", fileName)
        If File.Exists(imagePath) Then
            picImage.Image = Image.FromFile(imagePath)
        End If
    End Sub

    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtNIM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNIM.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim inputRole As String = If(cmbRole.SelectedItem IsNot Nothing, cmbRole.SelectedItem.ToString(), "")
        Dim inputNama As String = txtNama.Text.Trim()
        Dim inputNIM As String = txtNIM.Text.Trim()

        If inputNama = "" Then
            MessageBox.Show("Nama tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNama.Focus()
            Exit Sub
        End If

        If inputNIM = "" Then
            MessageBox.Show("NIM tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNIM.Focus()
            Exit Sub
        End If

        Dim isValidAccount As Boolean = False

        If inputRole = "Staff" AndAlso inputNama.Equals("Lita", StringComparison.OrdinalIgnoreCase) AndAlso inputNIM = "241712026" Then
            isValidAccount = True
        ElseIf inputRole = "Manager" AndAlso inputNama.Equals("Ferlita", StringComparison.OrdinalIgnoreCase) AndAlso inputNIM = "241712025" Then
            isValidAccount = True
        End If

        If isValidAccount Then
            MessageBox.Show("Login berhasil! Selamat datang, " & inputNama & ".", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)

            txtNama.Clear()
            txtNIM.Clear()

            Dim formPajak As New FrmPajak()
            formPajak.Show()
            Me.Hide()
        Else
            MessageBox.Show("Role, Nama, atau NIM yang Anda masukkan tidak sesuai!", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtNama.Focus()
        End If
    End Sub

End Class