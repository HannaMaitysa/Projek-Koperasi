Imports System.Data.Odbc

Public Class PU
    Dim conn As OdbcConnection
    Dim da As OdbcDataAdapter
    Dim ds As DataSet
    Dim cmd As OdbcCommand
    Dim rd As OdbcDataReader
    Dim sql1 As String
    Dim sql2 As String

    Sub koneksi()
        conn = New OdbcConnection("Driver={MySQL ODBC 5.1 Driver};server=localhost;uid=root;pwd=;database=db_kop;port=3306")
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub

    Sub tampil()
        da = New OdbcDataAdapter("SELECT * FROM tbl_peminjaman", conn)
        ds = New DataSet
        da.Fill(ds, "tbl_peminjaman")
        dgv.DataSource = ds.Tables("tbl_peminjaman")
        dgv.ReadOnly = True
    End Sub

    Sub noaktif()
        T1.Enabled = False
        T2.Enabled = False
        CB1.Enabled = False
        T3.Enabled = False
        CB2.Enabled = False
        T4.Enabled = False
        T5.Enabled = False
        CB3.Enabled = False
        dtp.Enabled = False
        CB4.Enabled = False

        B1.Enabled = False
        B3.Enabled = False
    End Sub

    Sub kosongkan()
        T1.Clear()
        T2.Clear()
        CB1.Items.Clear()
        CB1.Items.AddRange(New String() {"Male", "Female"})
        T3.Clear()
        CB2.Items.Clear()
        CB2.Items.AddRange(New String() {"Sertifikat", "Kendaraan", "Barang", "Elektronik", "KTP", "Di Tentukan DI Kantor"})
        T4.Clear()
        T5.Clear()
        CB3.Text = "nominal"
        dtp.Value = DateTime.Now
        CB4.SuspendLayout()
    End Sub

    Sub aktifkan()
        T1.Enabled = True
        T2.Enabled = True
        CB1.Enabled = True
        T3.Enabled = True
        CB2.Enabled = True
        T4.Enabled = True
        T5.Enabled = True
        CB3.Enabled = True
        dtp.Enabled = True

        B1.Enabled = True
        B3.Enabled = True
    End Sub

   Sub aturkolom()
        If dgv.Columns.Count >= 10 Then ' pastikan ada 10 kolom
            Dim widths() As Integer = {30, 50, 50, 70, 40, 60, 30, 70, 40, 60}
            For i As Integer = 0 To widths.Length - 1
                dgv.Columns(i).Width = widths(i)
            Next
        End If
    End Sub



    Private Sub PU_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        tampil()
        aturkolom()
        noaktif()
        kosongkan()
    End Sub

    Private Sub B2_Click(sender As Object, e As EventArgs)
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
        cmd.Parameters.AddWithValue("denda", CB4.Text)
        Try
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            tampil()
            kosongkan()
            noaktif()
        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub B3_Click_1(sender As Object, e As EventArgs) Handles B3.Click
        koneksi()
        If T1.Text = "" Then
            MessageBox.Show("Pilih data yang ingin dihapus.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Dim result As DialogResult = MessageBox.Show("Yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            sql1 = "DELETE FROM tbl_peminjaman WHERE np = ?"
            cmd = New OdbcCommand(sql1, conn)
            cmd.Parameters.AddWithValue("np", T1.Text)

            Try
                cmd.ExecuteNonQuery()
                MessageBox.Show("Data berhasil dihapus.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                kosongkan()
                tampil()
                noaktif()
            Catch ex As Exception
                MessageBox.Show("Gagal menghapus data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellClick
        Dim i As Integer = dgv.CurrentRow.Index
        T1.Text = dgv.Item(0, i).Value.ToString()
        T2.Text = dgv.Item(1, i).Value.ToString()
        CB1.Text = dgv.Item(2, i).Value.ToString()
        T3.Text = dgv.Item(3, i).Value.ToString()
        CB2.Text = dgv.Item(4, i).Value.ToString()
        T4.Text = dgv.Item(5, i).Value.ToString()
        T5.Text = dgv.Item(6, i).Value.ToString()
        CB3.Text = dgv.Item(7, i).Value.ToString()
        CB4.Text = dgv.Item(7, i).Value.ToString()
        aktifkan()
        T1.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        aktifkan()
    End Sub

    Private Sub B1_Click(sender As Object, e As EventArgs) Handles B1.Click
        Me.Close()
    End Sub

    Private Sub dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick
        koneksi()
        kosongkan()
        noaktif()
        tampil()
    End Sub


    Private Sub CB4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB4.SelectedIndexChanged

    End Sub
End Class
