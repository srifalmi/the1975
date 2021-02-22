Imports MySql.Data.MySqlClient

Public Class Transaksi
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

            Else
                koneksi.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Sub tampilkan1()
        perintahmysql.Connection = koneksi
        perintahmysql.CommandType = CommandType.Text
        perintahmysql.CommandText = "SELECT * FROM register"
        tampildata.SelectCommand = perintahmysql
        datatabel.Tables.Clear()
        tampildata.Fill(datatabel, "register")
        DataTRANSAKSI.DataSource = datatabel.Tables("register")
    End Sub
    Sub tampilkan2()
        perintahmysql.Connection = koneksi
        perintahmysql.CommandType = CommandType.Text
        perintahmysql.CommandText = "SELECT * FROM tiketing"
        tampildata.SelectCommand = perintahmysql
        datatabel.Tables.Clear()
        tampildata.Fill(datatabel, "tiketing")
        datatiket.DataSource = datatabel.Tables("tiketing")
    End Sub
    Sub perintah(ByVal kirim As String)
        With perintahmysql
            .CommandText = kirim
            .CommandType = CommandType.Text
            .Connection = koneksi
            .ExecuteNonQuery()

        End With
    End Sub

    Private Sub Transaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi2()
        tampilkan2()
        tampilkan1()

    End Sub



    Sub bersih()
        tbkode.Text = ""
        tbcard.Text = ""
        tbname.Text = ""
        cmbclas.Text = ""
        tbharga.Text = ""
        tbMail.Text = ""
        tbphone.Text = ""
        tbjmlah.Text = ""
        tbtotal.Text = ""
    End Sub

    Private Sub DataTRANSAKSI_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataTRANSAKSI.CellContentClick
        tbkode.Text = DataTRANSAKSI.Rows(e.RowIndex).Cells(0).Value
        tbcard.Text = DataTRANSAKSI.Rows(e.RowIndex).Cells(1).Value
        tbname.Text = DataTRANSAKSI.Rows(e.RowIndex).Cells(2).Value
        cmbclas.Text = DataTRANSAKSI.Rows(e.RowIndex).Cells(3).Value
        tbharga.Text = DataTRANSAKSI.Rows(e.RowIndex).Cells(7).Value
        tbMail.Text = DataTRANSAKSI.Rows(e.RowIndex).Cells(4).Value
        tbphone.Text = DataTRANSAKSI.Rows(e.RowIndex).Cells(5).Value
        tbjmlah.Text = DataTRANSAKSI.Rows(e.RowIndex).Cells(6).Value
        tbtotal.Text = DataTRANSAKSI.Rows(e.RowIndex).Cells(8).Value


    End Sub
    Private Sub datatiket_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datatiket.CellContentClick

        tbcard.Text = datatiket.Rows(e.RowIndex).Cells(0).Value
        tbname.Text = datatiket.Rows(e.RowIndex).Cells(1).Value
        cmbclas.Text = datatiket.Rows(e.RowIndex).Cells(2).Value
        tbharga.Text = datatiket.Rows(e.RowIndex).Cells(3).Value
        tbMail.Text = datatiket.Rows(e.RowIndex).Cells(4).Value
        tbphone.Text = datatiket.Rows(e.RowIndex).Cells(5).Value
        tbjmlah.Text = datatiket.Rows(e.RowIndex).Cells(6).Value
        tbtotal.Text = datatiket.Rows(e.RowIndex).Cells(7).Value



    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Dim kalimatmysql As String = "insert into register value ('" & tbkode.Text & "','" & tbcard.Text & "','" & tbname.Text & "','" & cmbclas.Text & "','" & tbharga.Text & "','" & tbMail.Text & "','" & tbphone.Text & "','" & tbjmlah.Text & "','" & tbtotal.Text & "')"
        perintah(kalimatmysql)
        MsgBox("Data has Been Registered")
        tampilkan2()
        tampilkan1()
        bersih()






    End Sub

    Private Sub btnDelet_Click(sender As Object, e As EventArgs) Handles btnDelet.Click
        If MessageBox.Show("Seriously?", "The 1975", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim apus As String = "DELETE from register WHERE TicketCode = '" & tbkode.Text & "'"
            perintah(apus)
        Else
            bersih()
        End If
        bersih()
        tampilkan2()

        tampilkan1()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        bersih()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Pemesanan.Show()
        Me.Hide()
    End Sub
End Class