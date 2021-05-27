Public Class Manage_User
    Sub Tampilkan()
        Dim clm, tbl As String
        clm = "*"
        tbl = "tb_member"
        Tampil(clm, tbl)
        DGV.DataSource = ds.Tables(0)
        DGV.ReadOnly = True

    End Sub
    Private Sub Manage_User_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Kosongkan()

    End Sub
    Sub Id()
        q = "select * from tb_member order by id_member desc"
        Cari(q)
        If dr.HasRows Then
            TbId.Text = "MBR" + Format(Microsoft.VisualBasic.Right(dr.Item("id_member"), 6) + 1, "000000")
        Else
            TbId.Text = "MBR000001"
        End If

    End Sub
    Sub Kosongkan()
        Tampilkan()
        Id()

        TbNama.Clear()
        TbAlamat.Clear()
        CbJk.ResetText()
        Tbtelphone.Clear()

    End Sub
    Sub Insert()
        q = "select * from tb_member where id_member = '" & TbId.Text & "'"
        Cari(q)
        If dr.HasRows Then
            q = "update tb_member set nama = '" & TbNama.Text & "', alamat = '" & TbAlamat.Text & "',jenis_kelamin = '" & CbJk.Text & "',tlp = '" & Tbtelphone.Text & "' where id_member = '" & TbId.Text & "'"
            ENQ(q)
            Kosongkan()
        Else
            q = "insert into tb_member values('" & TbId.Text & "','" & TbNama.Text & "','" & TbAlamat.Text & "','" & CbJk.Text & "','" & Tbtelphone.Text & "')"
            ENQ(q)
            Kosongkan()
        End If
    End Sub
    Sub Delete()
        q = "delete from tb_member where id_member = '" & TbId.Text & "'"
        ENQ(q)
    End Sub
    Private Sub TbStok_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Tbtelphone.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub BtnInsert_Click(sender As Object, e As EventArgs) Handles BtnInsert.Click
        If TbId.Text = "" Or TbNama.Text = "" Or TbAlamat.Text = "" Or CbJk.Text = "" Or Tbtelphone.Text = "" Then
            MsgBox("Data Tidak Lengkap")
        Else
            Insert()

        End If
    End Sub


    Private Sub DGV_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV.CellMouseDoubleClick
        Try
            q = "select * from tb_member where id_member = '" & DGV.Rows(e.RowIndex).Cells(0).Value & "'"
            Cari(q)
            TbId.Text = dr.Item("id_member")
            TbNama.Text = dr.Item("nama")
            TbAlamat.Text = dr.Item("alamat")
            CbJk.Text = dr.Item("jenis_kelamin")
            Tbtelphone.Text = dr.Item("tlp")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Btndelete_Click(sender As Object, e As EventArgs) Handles Btndelete.Click
        Try
            Dim r = MsgBox("Yakin Hapus?", vbYesNo)
            If r = vbYes Then
                Delete()
                Kosongkan()

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Btncancel_Click(sender As Object, e As EventArgs) Handles Btncancel.Click
        Kosongkan()
    End Sub
End Class