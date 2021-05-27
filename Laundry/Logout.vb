Public Class Logout
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim r As String
        r = MsgBox("Yakin Keluar?", vbYesNo)
        If r = vbYes Then
            Master.Visible = False

            Form1.Visible = True
            Login.Kosongkan()


        End If
    End Sub
End Class