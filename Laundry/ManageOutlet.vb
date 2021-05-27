Public Class ManageOutlet
    Private Sub ManageOutlet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Kosongkan()
    End Sub
    Sub Id()
        q = "select * from tb_outlet order by id_outlet desc"
        Cari(q)
        If dr.HasRows Then
            TbId.Text = "OTL" + Format(Microsoft.VisualBasic.Right(dr.Item("id_outlet"), 2) + 1, "00")
        Else
            TbId.Text = "OTL01"
        End If

    End Sub
    Sub Tampilkan()
        clm = "*"
        tbl = "tb_outlet"
        Tampil(clm, tbl)
        DGV.DataSource = ds.Tables(0)
        DGV.ReadOnly = True
    End Sub
    Sub Kosongkan()
        Id()
        Tampilkan()
        TbNama.Clear()
        TbAlamat.Clear()
        Tbtelphone.Clear()
        TbOwner.Clear()
    End Sub
    Sub Insert()
        q = "select * from tb_outlet where id_outlet ='" & TbId.Text & "'"
        Cari(q)
        If dr.HasRows Then
            q = "update tb_outlet set nama = '" & TbNama.Text & "',alamat = '" & TbAlamat.Text & "',tlp = '" & Tbtelphone.Text & "',owner = '" & TbOwner.Text & "' where id_outlet  = '" & TbId.Text & "'"
            ENQ(q)
        Else
            q = "insert into tb_outlet values('" & TbId.Text & "','" & TbNama.Text & "','" & TbAlamat.Text & "','" & Tbtelphone.Text & "','" & TbOwner.Text & "')"
            ENQ(q)
        End If

    End Sub
    Sub Delete()
        q = "delete from tb_outlet where id_outlet = '" & TbId.Text & "'"
        ENQ(q)
    End Sub

    Private Sub DGV_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV.CellMouseDoubleClick
        Try
            q = "select * from tb_outlet where id_outlet = '" & DGV.Rows(e.RowIndex).Cells(0).Value & "'"
            Cari(q)
            TbId.Text = dr.Item("id_outlet")
            TbNama.Text = dr.Item("nama")
            TbAlamat.Text = dr.Item("alamat")
            Tbtelphone.Text = dr.Item("tlp")
            TbOwner.Text = dr.Item("owner")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnInsert_Click(sender As Object, e As EventArgs) Handles BtnInsert.Click
        Insert()
        Kosongkan()
    End Sub

    Private Sub Btndelete_Click(sender As Object, e As EventArgs) Handles Btndelete.Click
        Dim r = MsgBox("Yakin Hapus?", vbYesNo)
        If r = vbYes Then
            Delete() '
            Kosongkan()
        End If
    End Sub

    Private Sub Btncancel_Click(sender As Object, e As EventArgs) Handles Btncancel.Click
        Kosongkan()
    End Sub
End Class