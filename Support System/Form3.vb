Public Class Form3
    Private Sub btnstemres_Click(sender As Object, e As EventArgs) Handles btnstemres.Click
        panelImage.Visible = False
        panelsports.Visible = True

    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        panelsports.Visible = False

        BunifuPages1.Visible = True
        BunifuPages1.SetPage(0)
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        BunifuPages1.Visible = False
        panelsports.Visible = True

    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Dim a = MsgBox("Go back?", vbYesNo + vbQuestion, "Message")
        If a = vbYes Then
            panelsports.Visible = False
            panelImage.Visible = True

        End If
    End Sub

    Private Sub BunifuFlatButton5_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton5.Click
        BunifuPages1.Visible = False
        panelsports.Visible = True

    End Sub

    Private Sub BunifuFlatButton24_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton24.Click
        BunifuPages1.Visible = False
        panelsports.Visible = True

    End Sub

    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click
        panelsports.Visible = False
        BunifuPages1.Visible = True
        BunifuPages1.SetPage(1)

    End Sub

    Private Sub BunifuThinButton23_Click(sender As Object, e As EventArgs) Handles BunifuThinButton23.Click
        panelsports.Visible = False
        BunifuPages1.Visible = True
        BunifuPages1.SetPage(2)

    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        GroupBox1.Visible = True
    End Sub

    Private Sub BunifuFlatButton4_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton4.Click
        GroupBox2.Visible = True

    End Sub

    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click
        GroupBox3.Visible = True

    End Sub

    Private Sub BunifuFlatButton26_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton26.Click
        If ListBox4.SelectedIndex = 0 Then

            MsgBox("FLIGHT ATTENDANT job outlook after 10 years will grow 8%  ", vbInformation, "Information")

        ElseIf ListBox4.SelectedIndex = 1 Then
            MsgBox("Restaurant manager growth rate 5% after 5 years", vbInformation, "Information")
        ElseIf ListBox4.SelectedIndex = 2 Then
            MsgBox("Restaurant manager growth rate 5% after 5 years", vbInformation, "Information")
        ElseIf ListBox4.SelectedIndex = 3 Then
            MsgBox("Restaurant manager growth rate 5% after 5 years", vbInformation, "Information")
        ElseIf ListBox4.SelectedIndex = 4 Then
            MsgBox("Restaurant manager growth rate 5% after 5 years", vbInformation, "Information")
        End If

    End Sub
End Class