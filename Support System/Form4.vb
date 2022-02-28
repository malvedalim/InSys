Public Class Form4
    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        pagesarts.Visible = False
        panelarts.Visible = True

    End Sub

    Private Sub btnstemres_Click(sender As Object, e As EventArgs) Handles btnstemres.Click
        panelartsimg.Visible = False
        panelarts.Visible = True

    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        panelarts.Visible = False

        panelartsimg.Visible = True

    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        panelarts.Visible = False
        pagesarts.Visible = True
        pagesarts.SetPage(0)
    End Sub

    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click
        panelarts.Visible = False
        pagesarts.Visible = True
        pagesarts.SetPage(1)
    End Sub

    Private Sub BunifuThinButton23_Click(sender As Object, e As EventArgs) Handles BunifuThinButton23.Click
        panelarts.Visible = False
        pagesarts.Visible = True
        pagesarts.SetPage(2)
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

    Private Sub BunifuFlatButton5_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton5.Click
        pagesarts.Visible = False
        panelarts.Visible = True

    End Sub

    Private Sub BunifuFlatButton24_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton24.Click
        pagesarts.Visible = False
        panelarts.Visible = True

    End Sub

    Private Sub BunifuFlatButton26_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton26.Click
        If ListBox4.SelectedIndex = 0 Then

            MsgBox("Software Engineering growth rate 5% after 5 years", vbInformation, "Information")
        ElseIf ListBox4.SelectedIndex = 1 Then
            MsgBox("Software Engineering growth rate 5% after 5 years", vbInformation, "Information")
        ElseIf ListBox4.SelectedIndex = 2 Then
            MsgBox("Software Engineering growth rate 5% after 5 years", vbInformation, "Information")
        ElseIf ListBox4.SelectedIndex = 3 Then
            MsgBox("Software Engineering growth rate 5% after 5 years", vbInformation, "Information")
        ElseIf ListBox4.SelectedIndex = 4 Then
            MsgBox("Software Engineering growth rate 5% after 5 years", vbInformation, "Information")
        ElseIf ListBox4.SelectedIndex = 5 Then
            MsgBox("Software Engineering growth rate 5% after 5 years", vbInformation, "Information")


        End If
    End Sub
End Class