Public Class Master
    Sub SwitchPanel(ByVal p As Form)
        PnlContent.Controls.Clear()
        p.TopLevel = False
        PnlContent.Controls.Add(p)
        p.Show()
    End Sub

    Private Sub Master_Load(sender As Object, e As EventArgs) Handles Me.Load
        SwitchPanel(Dashboard)
    End Sub
End Class