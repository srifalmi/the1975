Imports MySql.Data.MySqlClient

Public Class Form1
    Dim koneksi As New MySqlConnection
    Dim stringkoneksi As String = "server=localhost;User Id=root;Password=;Database=konser"
    Dim perintahmysql As New MySqlCommand
    Dim datatabel As New DataSet
    Dim tampildata As New MySqlDataAdapter

    Sub koneksi2()
        koneksi.ConnectionString = stringkoneksi
        Try
            If koneksi.State = ConnectionState.Closed Then
                koneksi.Open()
                MsgBox("KONEKSI TERSAMBUNG")
            Else
                koneksi.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi2()
        tampilkan()
    End Sub
    Sub tampilkan()
        perintahmysql.Connection = koneksi
        perintahmysql.CommandType = CommandType.Text
        perintahmysql.CommandText = "SELECT * FROM tbbook"
        tampildata.SelectCommand = perintahmysql
        datatabel.Tables.Clear()
        tampildata.Fill(datatabel, "tbbook")
        DataGridView1.DataSource = datatabel.Tables("tbbook")
    End Sub
    Sub bersih()
        tbkd.Text = ""



    End Sub

    Sub perintah(ByVal kirim As String)
        With perintahmysql
            .CommandText = kirim
            .CommandType = CommandType.Text
            .Connection = koneksi
            .ExecuteNonQuery()

        End With
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        tbkd.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value


    End Sub



    Private Sub btnex_Click(sender As Object, e As EventArgs) Handles btnex.Click
        End
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Dim kalimatmysql As String = "insert into tbbook value ('" & tbkd.Text & "')"
        perintah(kalimatmysql)
        MsgBox("Data Telah Disimpan")
        tampilkan()




    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        Call bersih()

    End Sub

    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        If MessageBox.Show("Apakah Data Ingin Di HAPUS", "Pesan", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim HAPUS As String = "DELETE from tbbook WHERE kodeTiket = '" & tbkd.Text & "'"
            perintah(HAPUS)
        Else
            bersih()

        End If
        bersih()
        tampilkan()
    End Sub

End Class
