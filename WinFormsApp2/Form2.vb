Public Class Form2
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Maaf Data Anda Belum Lengkap!", MsgBoxStyle.Critical, "Peringatan")
        Else
            MsgBox("Data Anda Sudah Tersimpan!", MsgBoxStyle.Information, "Informasi")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()

        MsgBox("Data Terhapus", MsgBoxStyle.OkOnly, "Informasi")
    End Sub
End Class