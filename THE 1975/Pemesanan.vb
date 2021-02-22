Imports MySql.Data.MySqlClient

Public Class Pemesanan
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
                MsgBox("CONNECTED")
            Else
                koneksi.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Sub tampilkan()
        perintahmysql.Connection = koneksi
        perintahmysql.CommandType = CommandType.Text
        perintahmysql.CommandText = "SELECT * FROM tiketing"
        tampildata.SelectCommand = perintahmysql
        datatabel.Tables.Clear()
        tampildata.Fill(datatabel, "tiketing")
        DataGridView1.DataSource = datatabel.Tables("tiketing")
    End Sub

    Sub perintah(ByVal kirim As String)
        With perintahmysql
            .CommandText = kirim
            .CommandType = CommandType.Text
            .Connection = koneksi
            .ExecuteNonQuery()

        End With
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub



    Private Sub cmjenis_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmjenis.SelectedIndexChanged
        If cmjenis.Text = "PLATINUM" Then

            tbprice.Text = "8000000"
        ElseIf cmjenis.Text = "VIP" Then

            tbprice.Text = "6000000"
        ElseIf cmjenis.Text = "GOLD" Then

            tbprice.Text = "4000000"
        ElseIf cmjenis.Text = "SILVER" Then

            tbprice.Text = "3000000"
        ElseIf cmjenis.Text = "BRONZE" Then

            tbprice.Text = "1500000"
        End If

    End Sub
    Sub bersih()
        tbjmlah.Text = ""
        tbhp.Text = ""
        tbmail.Text = ""
        tbnama.Text = ""
        tbreg.Text = ""
        cmjenis.Text = ""
        tbttal.Text = ""
        tbprice.Text = ""
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim kalimatmysql As String = "insert into tiketing value ('" & tbreg.Text & "','" & tbnama.Text & "','" & cmjenis.Text & "','" & tbmail.Text & "','" & tbhp.Text & "','" & tbjmlah.Text & "','" & tbprice.Text & "','" & tbttal.Text & "')"
        perintah(kalimatmysql)
        MsgBox("Data has Been Registered, Check Your Transaction")
        tampilkan()
        bersih()
        Transaksi.Show()
        Me.Hide()

    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Call bersih()
    End Sub

    Private Sub btncheck_Click(sender As Object, e As EventArgs) Handles btncheck.Click
        tbttal.Text = Val(tbjmlah.Text) * Val(tbprice.Text)
    End Sub


    Private Sub Pemesanan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi2()
        tampilkan()

    End Sub

    Private Sub btndelet_Click(sender As Object, e As EventArgs) Handles btndelet.Click
        If MessageBox.Show("Seriously?", "The 1975", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim apus As String = "DELETE from tiketing WHERE IdCard = '" & tbreg.Text & "'"
            perintah(apus)
        Else
            bersih()
        End If
        bersih()
        tampilkan()

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        tbreg.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        tbnama.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
        cmjenis.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
        tbmail.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value
        tbhp.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value
        tbjmlah.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value
        tbprice.Text = DataGridView1.Rows(e.RowIndex).Cells(6).Value
        tbttal.Text = DataGridView1.Rows(e.RowIndex).Cells(7).Value
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        first.Show()
        Me.Hide()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Transaksi.Show()
        Me.Hide()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class