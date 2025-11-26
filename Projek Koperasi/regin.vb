Imports System.Data.Odbc
Public Class regin
    Public conn As OdbcConnection
    Public dr As OdbcDataReader
    Public da As OdbcDataAdapter
    Public ds As DataSet
    Public cmd As OdbcCommand
    Public sql1 As String
    Public sql2 As String

    Sub koneksi()
        sql1 = "Driver={MySQL ODBC 5.1 Driver};server=localhost;uid=root;database=db_kop;port=3306"
        conn = New OdbcConnection(sql1)
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
    End Sub

    Private Sub B2_Click(sender As Object, e As EventArgs) Handles B2.Click
        End
    End Sub

    Private Sub B1_Click(sender As Object, e As EventArgs) Handles B1.Click
        Try
            koneksi()
            Dim user As String = T1.Text.Trim()
            Dim pw As String = T2.Text.Trim()
            Dim nk As String = T3.Text.Trim()

            If user = "" Or pw = "" Or nk = "" Then
                MessageBox.Show("Semua data harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            sql1 = "SELECT * FROM login WHERE user=?"
            cmd = New OdbcCommand(sql1, conn)
            cmd.Parameters.AddWithValue("?", user)
            dr = cmd.ExecuteReader()

            If dr.HasRows Then
                MessageBox.Show("Username sudah digunakan!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                conn.Close()
                Exit Sub
            End If
            dr.Close()

            ' Insert user baru
            sql1 = "INSERT INTO login (user, pw, nk) VALUES (?, ?, ?)"
            cmd = New OdbcCommand(sql1, conn)
            cmd.Parameters.AddWithValue("?", user)
            cmd.Parameters.AddWithValue("?", pw)
            cmd.Parameters.AddWithValue("?", nk)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Registrasi Berhasil!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            conn.Close()

            ' Pindah ke form login (jika ada)
            login.Show()
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
End Class