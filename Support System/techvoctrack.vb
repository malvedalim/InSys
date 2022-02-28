Public Class techvoctrack
    Private Sub btngasinfo_Click(sender As Object, e As EventArgs) Handles btngasinfo.Click
        paneltvl.Visible = False
        tvlinfos.Visible = True
        tvlinfos.SetPage(1)

    End Sub

    Private Sub btnsteminfo_Click(sender As Object, e As EventArgs) Handles btnsteminfo.Click
        paneltvl.Visible = False
        tvlinfos.Visible = True
        tvlinfos.SetPage(0)
    End Sub

    Private Sub btnhummsinfo_Click(sender As Object, e As EventArgs) Handles btnhummsinfo.Click
        paneltvl.Visible = False
        tvlinfos.Visible = True
        tvlinfos.SetPage(2)
    End Sub

    Private Sub btnabminfo_Click(sender As Object, e As EventArgs) Handles btnabminfo.Click
        paneltvl.Visible = False
        tvlinfos.Visible = True
        tvlinfos.SetPage(3)
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        panelheco.Visible = False
        pageheco.Visible = True
        pageheco.SetPage(0)
    End Sub

    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click
        panelheco.Visible = False
        pageheco.Visible = True
        pageheco.SetPage(1)
    End Sub

    Private Sub BunifuThinButton23_Click(sender As Object, e As EventArgs) Handles BunifuThinButton23.Click
        panelheco.Visible = False
        pageheco.Visible = True
        pageheco.SetPage(2)
    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Dim a = MsgBox("Choose other strand?", +vbYesNo + vbQuestion, "Message")
        If a = vbYes Then
            tvlinfos.Visible = False
            paneltvl.Visible = True

        End If
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        pageheco.Visible = False
        panelheco.Visible = True
    End Sub

    Private Sub BunifuFlatButton5_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton5.Click
        pageheco.Visible = False
        panelheco.Visible = True
    End Sub

    Private Sub BunifuFlatButton6_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton6.Click
        pageheco.Visible = False
        panelheco.Visible = True
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Dim a = MsgBox("Choose other strand?", +vbYesNo + vbQuestion, "Message")
        If a = vbYes Then
            tvlinfos.Visible = False
            paneltvl.Visible = True

        End If
    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        Dim a = MsgBox("Choose other strand?", +vbYesNo + vbQuestion, "Message")
        If a = vbYes Then
            tvlinfos.Visible = False
            paneltvl.Visible = True

        End If
    End Sub

    Private Sub BunifuImageButton3_Click(sender As Object, e As EventArgs) Handles BunifuImageButton3.Click
        Dim a = MsgBox("Choose other strand?", +vbYesNo + vbQuestion, "Message")
        If a = vbYes Then
            tvlinfos.Visible = False
            paneltvl.Visible = True

        End If
    End Sub

    Private Sub BunifuFlatButton7_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton7.Click
        pageagri.Visible = False
        panelagri.Visible = True

    End Sub

    Private Sub BunifuFlatButton8_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton8.Click
        pageagri.Visible = False
        panelagri.Visible = True
    End Sub

    Private Sub BunifuFlatButton12_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton12.Click
        pageagri.Visible = False
        panelagri.Visible = True
    End Sub

    Private Sub BunifuFlatButton13_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton13.Click
        pageict.Visible = False
        panelict.Visible = True

    End Sub

    Private Sub BunifuFlatButton14_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton14.Click
        pageict.Visible = False
        panelict.Visible = True
    End Sub

    Private Sub BunifuFlatButton18_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton18.Click
        pageict.Visible = False
        panelict.Visible = True
    End Sub

    Private Sub BunifuFlatButton19_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton19.Click
        pageia.Visible = False
        panelia.Visible = True

    End Sub

    Private Sub BunifuFlatButton20_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton20.Click
        pageia.Visible = False
        panelia.Visible = True
    End Sub

    Private Sub BunifuFlatButton24_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton24.Click
        pageia.Visible = False
        panelia.Visible = True
    End Sub

    Private Sub BunifuFlatButton25_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BunifuFlatButton11_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton11.Click
        GroupBox6.Visible = True

    End Sub

    Private Sub BunifuFlatButton9_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton9.Click
        GroupBox5.Visible = True

    End Sub

    Private Sub BunifuFlatButton10_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton10.Click
        GroupBox4.Visible = True

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

    Private Sub BunifuFlatButton17_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton17.Click
        GroupBox9.Visible = True

    End Sub

    Private Sub BunifuFlatButton15_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton15.Click
        GroupBox8.Visible = True

    End Sub

    Private Sub BunifuFlatButton16_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton16.Click
        GroupBox7.Visible = True

    End Sub

    Private Sub BunifuFlatButton25_Click_1(sender As Object, e As EventArgs) Handles BunifuFlatButton25.Click
        If ListBox1.SelectedIndex = 0 Then

            MsgBox("FLIGHT ATTENDANT job outlook after 10 years will grow 8%  ", vbInformation, "Information")

        ElseIf ListBox1.SelectedIndex = 1 Then
            MsgBox("Restaurant manager growth rate 5% after 5 years", vbInformation, "Information")
        ElseIf ListBox1.SelectedIndex = 2 Then
            MsgBox("Restaurant manager growth rate 5% after 5 years", vbInformation, "Information")
        ElseIf ListBox1.SelectedIndex = 3 Then
            MsgBox("Restaurant manager growth rate 5% after 5 years", vbInformation, "Information")
        ElseIf ListBox1.SelectedIndex = 4 Then
            MsgBox("Restaurant manager growth rate 5% after 5 years", vbInformation, "Information")
        ElseIf ListBox1.SelectedIndex = 5 Then
            MsgBox("Restaurant manager growth rate 5% after 5 years", vbInformation, "Information")
        ElseIf ListBox1.SelectedIndex = 6 Then
            MsgBox("Restaurant manager growth rate 5% after 5 years", vbInformation, "Information")
        ElseIf ListBox1.SelectedIndex = 7 Then
            MsgBox("Restaurant manager growth rate 5% after 5 years", vbInformation, "Information")
        ElseIf ListBox1.SelectedIndex = 8 Then
            MsgBox("Restaurant manager growth rate 5% after 5 years", vbInformation, "Information")
        ElseIf ListBox1.SelectedIndex = 9 Then
            MsgBox("Restaurant manager growth rate 5% after 5 years", vbInformation, "Information")
        ElseIf ListBox1.SelectedIndex = 10 Then
            MsgBox("Restaurant manager growth rate 5% after 5 years", vbInformation, "Information")

        End If
    End Sub

    Private Sub BunifuFlatButton28_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton28.Click
        If ListBox3.SelectedIndex = 0 Then

            MsgBox("FLIGHT ATTENDANT job outlook after 10 years will grow 8%  ", vbInformation, "Information")

        ElseIf ListBox3.SelectedIndex = 1 Then
            MsgBox("Restaurant manager growth rate 5% after 5 years", vbInformation, "Information")
        ElseIf ListBox3.SelectedIndex = 2 Then
            MsgBox("Restaurant manager growth rate 5% after 5 years", vbInformation, "Information")
        ElseIf ListBox3.SelectedIndex = 3 Then
            MsgBox("Restaurant manager growth rate 5% after 5 years", vbInformation, "Information")
        ElseIf ListBox3.SelectedIndex = 4 Then
            MsgBox("Restaurant manager growth rate 5% after 5 years", vbInformation, "Information")
        ElseIf ListBox3.SelectedIndex = 5 Then
            MsgBox("Restaurant manager growth rate 5% after 5 years", vbInformation, "Information")
        ElseIf ListBox3.SelectedIndex = 6 Then
            MsgBox("Restaurant manager growth rate 5% after 5 years", vbInformation, "Information")
        ElseIf ListBox3.SelectedIndex = 7 Then
            MsgBox("Restaurant manager growth rate 5% after 5 years", vbInformation, "Information")
        ElseIf ListBox3.SelectedIndex = 8 Then
            MsgBox("Restaurant manager growth rate 5% after 5 years", vbInformation, "Information")
        ElseIf ListBox3.SelectedIndex = 9 Then
            MsgBox("Restaurant manager growth rate 5% after 5 years", vbInformation, "Information")
        ElseIf ListBox3.SelectedIndex = 10 Then
            MsgBox("Restaurant manager growth rate 5% after 5 years", vbInformation, "Information")

        End If
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
        ElseIf ListBox4.SelectedIndex = 5 Then
            MsgBox("Restaurant manager growth rate 5% after 5 years", vbInformation, "Information")
        ElseIf ListBox4.SelectedIndex = 6 Then
            MsgBox("Restaurant manager growth rate 5% after 5 years", vbInformation, "Information")
        End If

    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged

    End Sub

    Private Sub BunifuFlatButton27_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton27.Click
        If ListBox2.SelectedIndex = 0 Then

            MsgBox("FLIGHT ATTENDANT job outlook after 10 years will grow 8%  ", vbInformation, "Information")

        ElseIf ListBox2.SelectedIndex = 1 Then
            MsgBox("Restaurant manager growth rate 5% after 5 years", vbInformation, "Information")
        ElseIf ListBox2.SelectedIndex = 2 Then
            MsgBox("Restaurant manager growth rate 5% after 5 years", vbInformation, "Information")
        ElseIf ListBox2.SelectedIndex = 3 Then
            MsgBox("Restaurant manager growth rate 5% after 5 years", vbInformation, "Information")
        ElseIf ListBox2.SelectedIndex = 4 Then
            MsgBox("Restaurant manager growth rate 5% after 5 years", vbInformation, "Information")
        ElseIf ListBox2.SelectedIndex = 5 Then
            MsgBox("Restaurant manager growth rate 5% after 5 years", vbInformation, "Information")
        ElseIf ListBox2.SelectedIndex = 6 Then
            MsgBox("Restaurant manager growth rate 5% after 5 years", vbInformation, "Information")
        End If
    End Sub

    Private Sub BunifuThinButton25_Click(sender As Object, e As EventArgs) Handles BunifuThinButton25.Click
        panelagri.Visible = False
        pageagri.Visible = True
        pageagri.SetPage(0)
    End Sub

    Private Sub BunifuThinButton24_Click(sender As Object, e As EventArgs) Handles BunifuThinButton24.Click
        panelagri.Visible = False
        pageagri.Visible = True
        pageagri.SetPage(1)
    End Sub

    Private Sub BunifuThinButton26_Click(sender As Object, e As EventArgs) Handles BunifuThinButton26.Click
        panelagri.Visible = False
        pageagri.Visible = True
        pageagri.SetPage(2)
    End Sub

    Private Sub BunifuThinButton211_Click(sender As Object, e As EventArgs) Handles BunifuThinButton211.Click
        panelict.Visible = False
        pageict.Visible = True
        pageict.SetPage(0)
    End Sub

    Private Sub BunifuThinButton210_Click(sender As Object, e As EventArgs) Handles BunifuThinButton210.Click
        panelict.Visible = False
        pageict.Visible = True
        pageict.SetPage(1)
    End Sub

    Private Sub BunifuThinButton27_Click(sender As Object, e As EventArgs) Handles BunifuThinButton27.Click
        panelict.Visible = False
        pageict.Visible = True
        pageict.SetPage(2)
    End Sub

    Private Sub BunifuThinButton214_Click(sender As Object, e As EventArgs) Handles BunifuThinButton214.Click
        panelia.Visible = False
        pageia.Visible = True
        pageia.SetPage(0)
    End Sub

    Private Sub BunifuThinButton213_Click(sender As Object, e As EventArgs) Handles BunifuThinButton213.Click
        panelia.Visible = False
        pageia.Visible = True
        pageia.SetPage(1)
    End Sub

    Private Sub BunifuThinButton212_Click(sender As Object, e As EventArgs) Handles BunifuThinButton212.Click
        panelia.Visible = False
        pageia.Visible = True
        pageia.SetPage(2)
    End Sub
End Class