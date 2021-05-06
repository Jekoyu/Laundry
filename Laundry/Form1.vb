Public Class Form1
    Sub SwicthPanel(ByVal p As Form)
        Panel1.Controls.Clear()
        p.TopLevel = False
        Panel1.Controls.Add(p)
        p.Show()

    End Sub


    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Panel1_Resize(sender As Object, e As EventArgs) Handles Panel1.Resize
        Dim PW As Integer = Me.Width
        Dim PH As Integer = Me.Height
        ' Panel1.Size = New Drawing.Size(PW,)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SwicthPanel(Login)
    End Sub
End Class
