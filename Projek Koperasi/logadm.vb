Public Class logadm

   Private Sub B1_Click(sender As Object, e As EventArgs) Handles B1.Click
        If TextBox1.Text = "1" And TextBox2.Text = "1" Then
            Me.Hide()
            adm.Show()
            MsgBox("login ke absen")
        ElseIf TextBox1.Text = "2" And TextBox2.Text = "2" Then
            Me.Hide()
            PU.Show()
            MsgBox("login ke data")
        Else
            MsgBox("username/password salah")
        End If
    End Sub
End Class
