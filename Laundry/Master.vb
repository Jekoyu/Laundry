Public Class Master
    Sub SwitchPanel(ByVal p As Form)
        PnlContent.Controls.Clear()
        p.TopLevel = False
        PnlContent.Controls.Add(p)
        p.Show()
    End Sub
    Sub Admin()
        BtnManageUser.Visible = True
        BtnHome.Visible = True
        BtnManageBarang.Visible = True
        ManageUser.Visible = True
        Belanja.Visible = True
        Laporan.Visible = True
        BtnLogout.Visible = True

    End Sub
    Sub Kasir()
        BtnHome.Visible = True
        BtnManageBarang.Visible = True
        ManageUser.Visible = True
        Belanja.Visible = True
        Laporan.Visible = True
        BtnLogout.Visible = True

    End Sub
    Sub Pemilik()
        BtnHome.Visible = True
        Laporan.Visible = True
        BtnLogout.Visible = True
    End Sub
    Private Sub Master_Load(sender As Object, e As EventArgs) Handles Me.Load
        SwitchPanel(Dashboard)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim s As String
        s = MsgBox("Yakin tutup?", vbYesNo)
        If vbYes Then
            Application.Exit()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        WindowState = WindowState.Minimized
    End Sub

    Private Sub Logout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        SwitchPanel(Logout)
    End Sub

    Private Sub ManageUser_Click(sender As Object, e As EventArgs) Handles ManageUser.Click
        SwitchPanel(Manage_User)
        Manage_User.Kosongkan()
    End Sub

    Private Sub BtnManageUser_Click(sender As Object, e As EventArgs) Handles BtnManageUser.Click
        SwitchPanel(ManageOutlet)
        ManageOutlet.Kosongkan()
    End Sub

    Private Sub BtnHome_Click(sender As Object, e As EventArgs) Handles BtnHome.Click
        SwitchPanel(Dashboard)
    End Sub

    Private Sub BtnManageBarang_Click(sender As Object, e As EventArgs) Handles BtnManageBarang.Click
        SwitchPanel(ManageProduk)
        ManageProduk.Kosongkan()
    End Sub
End Class