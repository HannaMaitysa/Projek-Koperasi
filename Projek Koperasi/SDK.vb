Public Class SDK


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim result As DialogResult
        result = MessageBox.Show("Apakah sudah mengerti?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Dim sdkForm As New SDK
            PU.Show()
            Me.Hide()
        Else
        End If
    End Sub
End Class