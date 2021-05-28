Public Class ManageProduk
    Private Sub ManageProduk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Kosongkan()

    End Sub

    Sub Kosongkan()
        Tampilkan()
        Data()
        DGV.Columns(0).HeaderText = "ID PAKET"
        DGV.Columns(1).HeaderText = "ID OUTLET"
        DGV.Columns(2).HeaderText = "NAMA PAKET"
        DGV.Columns(3).HeaderText = "HARGA"
        ComboBox1.ResetText()
        TbNama.Clear()
        TbHarga.Clear()

    End Sub
    Sub Insert()
        q = "select * from tb_paket order by id_paket desc"
        Cari(q)
        If dr.HasRows Then
            q = "update tb_paket set "
        End If
    End Sub
    Sub Data()
        ComboBox1.Items.Clear()
        koneksi()
        q = "select * from tb_outlet order by id_outlet asc"
        cmd = New SqlClient.SqlCommand(q, conn)
        dr = cmd.ExecuteReader
        While dr.Read
            ComboBox1.Items.Add(dr.Item("id_outlet") + "-" + dr.Item("nama"))
            '  ComboBox1.Items.Clear()
        End While

    End Sub
    Sub Tampilkan()
        clm = "* "
        tbl = "tb_paket"
        Tampil(clm, tbl)
        DGV.DataSource = ds.Tables(0)
        DGV.ReadOnly = True
    End Sub



    Private Sub TbHarga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbHarga.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        TbNama.Text = ComboBox1.Text.Substring(0, 5)
    End Sub

    Private Sub Btncancel_Click(sender As Object, e As EventArgs) Handles Btncancel.Click
        Kosongkan()
    End Sub
End Class