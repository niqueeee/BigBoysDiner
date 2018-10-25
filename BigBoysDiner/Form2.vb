Public Class AdminConfirm

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        If (unameLogin.Text = "admin" And MaskedTextBox1.Text = "1234") Then
            MessageBox.Show("YAY LOGGED IN :D")
        End If
    End Sub
End Class