Public Class Login
    Dim Pwd
    Dim otl
    Sub SwitchPanel(ByVal p As Form)
        Form1.Panel1.Controls.Clear()
        p.TopLevel = False
        Form1.Controls.Add(p)
        p.Show()
    End Sub
    Sub Kosongkan()
        TbUsername.Text = "Username"
        TbPassword.Text = "Password"
    End Sub
    Sub Login()

        Pwd = Md5(TbPassword.Text)
        q = "select * from tb_user where username ='" & TbUsername.Text & "' and password = '" & Pwd & "' "
        Cari(q)
        If dr.HasRows Then
            role = dr.Item("role")
            If role = 1 Then
                Master.Admin()
            ElseIf role = "2" Then
                Master.Kasir()
            Else
                Master.Pemilik()
            End If
            otl = dr.Item("id_outlet")
            q = "select * from tb_outlet where id_outlet = '" & otl & "'"
            Cari(q)
            If dr.HasRows Then
                Master.Label1.Text = dr.Item("nama")
                Master.Label1.Text = Master.Label1.Text.ToUpper()
            End If
            Form1.Visible = False
            Master.Show()
            Dashboard.LblNama.Text = dr.Item("nama")
            Logout.LblNama.Text = dr.Item("nama")
        Else
            MsgBox("Username/Email dan password Yang Anda Masukkan Salah")
            Kosongkan()
        End If
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Kosongkan()

    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        If TbUsername.Text = "Username" And TbPassword.Text = "Password" Then
            MsgBox("Data Belum Di isi", MsgBoxStyle.Critical)
        Else
            Login()
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked_1(sender As Object, e As LinkLabelLinkClickedEventArgs)
        SwitchPanel(Reg)
    End Sub


    Private Sub TbUsername_MouseClick(sender As Object, e As MouseEventArgs) Handles TbUsername.MouseClick
        If TbUsername.Text = "Username" Then
            TbUsername.Clear()
        End If

    End Sub



    Private Sub TbUsername_Leave(sender As Object, e As EventArgs) Handles TbUsername.Leave
        If TbUsername.Text = "" Then
            TbUsername.Text = "Username"
        End If
    End Sub

    Private Sub TbPassword_MouseClick(sender As Object, e As MouseEventArgs) Handles TbPassword.MouseClick
        If TbPassword.Text = "Password" Then
            TbPassword.Clear()
            TbPassword.PasswordChar = "*"
        End If
    End Sub

    Private Sub TbPassword_Leave(sender As Object, e As EventArgs) Handles TbPassword.Leave
        If TbPassword.Text = "" Then
            TbPassword.PasswordChar = "*"
            TbPassword.Text = "Password"
        End If
    End Sub

    Private Sub TbPassword_TextChanged(sender As Object, e As EventArgs) Handles TbPassword.TextChanged

    End Sub


End Class