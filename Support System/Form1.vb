Public Class Form1
    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles BunifuButton1.Click
        index.bfubtnacad.Enabled = True
        index.bfubtntvl.Enabled = True
        index.bfubtnarts.Enabled = True
        index.bnfbtnsports.Enabled = True
        index.btnmore.Enabled = True
        Dim a = MsgBox("Enjoy your experience!", vbInformation, "Have Fun!")


    End Sub
End Class