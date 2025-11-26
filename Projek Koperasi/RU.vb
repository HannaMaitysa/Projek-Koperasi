Imports System.Data.Odbc
Class RU
    Dim conn As OdbcConnection
    Dim da As OdbcDataAdapter
    Dim ds As DataSet
    Dim cmd As OdbcCommand
    Dim sql1 As String
    Dim sql2 As String

    Sub koneksi()
        conn = New OdbcConnection("Driver={MySQL ODBC 5.1 Driver};server=localhost;uid=root;pwd=;database=db_kop;port=3306")
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub

    Private Sub PU_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
    End Sub

    Private Sub B2_Click(sender As Object, e As EventArgs) Handles B2.Click
        koneksi()
        sql2 = "INSERT INTO tbl_peminjaman (np, nk, jk, na, j, alamat, pekerjaan, nominal, jt) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?)"
        cmd = New OdbcCommand(sql2, conn)
        cmd.Parameters.AddWithValue("np", T1.Text)
        cmd.Parameters.AddWithValue("nk", T2.Text)
        cmd.Parameters.AddWithValue("jk", CB1.Text)
        cmd.Parameters.AddWithValue("na", T3.Text)
        cmd.Parameters.AddWithValue("j", CB2.Text)
        cmd.Parameters.AddWithValue("alamat", T4.Text)
        cmd.Parameters.AddWithValue("pekerjaan", T5.Text)
        cmd.Parameters.AddWithValue("nominal", CB3.Text)
        cmd.Parameters.AddWithValue("jt", dtp.Text)

        MessageBox.Show("Data berhasil dikirim.", "untuk info akan langsung dihubungi.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Dim result As DialogResult = MessageBox.Show("Apakah kamu ingin tetap di halaman ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.No Then
            Me.Close()
        End If
    End Sub

    Private Sub b1_Click(sender As Object, e As EventArgs) Handles B1.Click
        Me.Close()
    End Sub

    Private Sub dtp_ValueChanged(sender As Object, e As EventArgs) Handles dtp.ValueChanged

    End Sub

    Private Sub B3_Click(sender As Object, e As EventArgs) Handles B3.Click
        Dim result As DialogResult
        result = MessageBox.Show("Apakah ingin pindah halaman?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Dim sdkForm As New SDK
            sdkForm.Show()
            Me.Hide()
        Else
        End If
    End Sub
End Class