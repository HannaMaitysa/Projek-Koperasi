Imports System.Data.Odbc

Public Class adm
    Public conn As OdbcConnection
    Public da As OdbcDataAdapter
    Public ds As DataSet
    Public cmd As OdbcCommand
    Public rd As OdbcDataReader
    Public sql1 As String

    Sub koneksi()
        sql1 = "Driver={MySQL ODBC 5.1 Driver};server=localhost;uid=root;database=db_kop;port=3306"
        conn = New OdbcConnection(sql1)
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub

    Sub kosong()
        T1.Text = ""
        T2.Text = ""
        dtp.Value = Now
        T1.Focus()
    End Sub

    Sub tampilkan()
        Try
            koneksi()
            da = New OdbcDataAdapter("SELECT * FROM tbl_adm ORDER BY ak DESC", conn)
            ds = New DataSet
            da.Fill(ds, "tbl_adm")
            dgv.DataSource = ds.Tables("tbl_adm")
            aturKolom()
        Catch ex As Exception
            MessageBox.Show("Gagal menampilkan data: " & ex.Message)
        End Try
    End Sub

    Sub aturKolom()
        If dgv.Columns.Count >= 3 Then
            dgv.Columns(0).HeaderText = "Nama Berjaga"
            dgv.Columns(1).HeaderText = "ID Berjaga"
            dgv.Columns(2).HeaderText = "Tanggal Absen"

            dgv.Columns(0).Width = 150
            dgv.Columns(1).Width = 100
            dgv.Columns(2).Width = 120
        End If
    End Sub

    Private Sub B1_Click(sender As Object, e As EventArgs) Handles B1.Click
        koneksi()
        Dim nama As String = T1.Text.Trim()
        Dim id As String = T2.Text.Trim()
        Dim tgl As String = dtp.Value.ToString("yyyy-MM-dd")

        If nama = "" Or id = "" Then
            MessageBox.Show("Semua data harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Try
                sql1 = "INSERT INTO tbl_adm (nb, ib, ak) VALUES (?, ?, ?)"
                cmd = New OdbcCommand(sql1, conn)
                cmd.Parameters.AddWithValue("?", nama)
                cmd.Parameters.AddWithValue("?", id)
                cmd.Parameters.AddWithValue("?", tgl)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Data berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                kosong()
                tampilkan()
            Catch ex As Exception
                MessageBox.Show("Gagal menyimpan data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub B2_Click(sender As Object, e As EventArgs) Handles B2.Click
        Close()
    End Sub

    Private Sub B3_Click(sender As Object, e As EventArgs) Handles B3.Click
        If T1.Text = "" Or T2.Text = "" Then
            MessageBox.Show("Pilih data yang akan dihapus.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            If MessageBox.Show("Yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Try
                    koneksi()
                    sql1 = "DELETE FROM tbl_adm WHERE ib = ? AND ak = ?"
                    cmd = New OdbcCommand(sql1, conn)
                    cmd.Parameters.AddWithValue("?", T2.Text.Trim())
                    cmd.Parameters.AddWithValue("?", dtp.Value.ToString("yyyy-MM-dd"))
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Data berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    kosong()
                    tampilkan()
                Catch ex As Exception
                    MessageBox.Show("Gagal menghapus data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End If
    End Sub

    Private Sub adm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilkan()
    End Sub

    Private Sub dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgv.Rows(e.RowIndex)
            T1.Text = row.Cells(0).Value.ToString()
            T2.Text = row.Cells(1).Value.ToString()
            dtp.Value = Convert.ToDateTime(row.Cells(2).Value)
        End If
    End Sub

    Private Sub dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick

    End Sub
End Class
