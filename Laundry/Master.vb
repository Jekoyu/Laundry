Public Class Master
    Sub SwitchPanel(ByVal p As Form)
        PnlContent.Controls.Clear()
        p.TopLevel = False
        PnlContent.Controls.Add(p)
        p.Show()
    End Sub
    Sub Admin()
        BtnManageUser.Visible = True

    End Sub
    Sub Kasir()
        BtnManageBarang.Visible = True
    End Sub
    Sub Pemilik()
        BtnBelanja.Visible = True
    End Sub
    Private Sub Master_Load(sender As Object, e As EventArgs) Handles Me.Load
        SwitchPanel(Dashboard)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim s As String
        s = MsgBox("Yakin tutup?", vbYesNo)
        If vbYes Then
            Me.Close()
        End If
    End Sub
End Class