Imports System.Data.Odbc
Public Class login
    Public Shared user As String
    Public Shared pw As String
    Public conn As OdbcConnection
    Public dr As OdbcDataReader
    Public da As OdbcDataAdapter
    Public ds As DataSet
    Public cmd As OdbcCommand
    Public sql1 As String
    Public sql2 As String


    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        conn = New OdbcConnection("Driver={MySQL ODBC 5.1 Driver};server=localhost;uid=root;pwd=;database=db_kop;port=3306")
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub

    Private Sub B2_Click(sender As Object, e As EventArgs) Handles B2.Click
        End
    End Sub

    Private Sub B1_Click(sender As Object, e As EventArgs) Handles B1.Click
        Call koneksi()
        cmd = New OdbcCommand("SELECT * FROM login WHERE user='" & T1.Text & "' AND pw='" & T2.Text & "'", conn)
        dr = cmd.ExecuteReader
        If dr.Read Then
            user = dr("user").ToString()
            pw = dr("nk").ToString()

            MsgBox("Login berhasil!", vbInformation)
            lobby.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub koneksi()
        Dim connStr As String = "Driver={MySQL ODBC 5.1 Driver};Server=localhost;Database=db_kop;Uid=root;Pwd=;"
        conn = New OdbcConnection(connStr)
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
        Catch ex As Exception
            MessageBox.Show("Gagal koneksi ke database: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub T1_TextChanged(sender As Object, e As EventArgs) Handles T1.TextChanged

    End Sub

    Private Sub T2_TextChanged(sender As Object, e As EventArgs) Handles T2.TextChanged

    End Sub

    Private Sub RectangleShape4_Click(sender As Object, e As EventArgs) Handles RectangleShape4.Click

    End Sub

    Private Sub B3_Click(sender As Object, e As EventArgs) Handles B3.Click
        regin.Show()
    End Sub
End Class

