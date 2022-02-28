Public Class acadtrack
    Sub switchPanel(ByVal panel As Form)

        panel.TopLevel = False

        panel.Show()
    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load





    End Sub




    Private Sub btnsteminfo_Click(sender As Object, e As EventArgs) Handles btnsteminfo.Click
        panelAcad.Visible = False
        acadinfos.Visible = True
        acadinfos.SetPage(0)
    End Sub

    Private Sub btnabminfo_Click(sender As Object, e As EventArgs) Handles btnabminfo.Click
        panelAcad.Visible = False
        acadinfos.Visible = True
        acadinfos.SetPage(1)
    End Sub

    Private Sub btnhummsinfo_Click(sender As Object, e As EventArgs) Handles btnhummsinfo.Click
        panelAcad.Visible = False
        acadinfos.Visible = True
        acadinfos.SetPage(2)
    End Sub

    Private Sub btngasinfo_Click(sender As Object, e As EventArgs) Handles btngasinfo.Click
        panelAcad.Visible = False
        acadinfos.Visible = True
        acadinfos.SetPage(3)
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        panelstem.Visible = False
        pagestem.Visible = True
        pagestem.SetPage(0)
    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        gbocorestem.Visible = True

    End Sub

    Private Sub BunifuFlatButton4_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton4.Click
        gboappstem.Visible = True

    End Sub

    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click
        gbospecistem.Visible = True

    End Sub

    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click
        panelstem.Visible = False
        pagestem.Visible = True
        pagestem.SetPage(1)
    End Sub

    Private Sub BunifuFlatButton5_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton5.Click
        pagestem.Visible = False
        panelstem.Visible = True
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        pagestem.Visible = False
        panelstem.Visible = True
    End Sub

    Private Sub BunifuFlatButton6_Click(sender As Object, e As EventArgs)
        pagestem.Visible = False
        panelstem.Visible = True
    End Sub

    Private Sub BunifuThinButton26_Click(sender As Object, e As EventArgs) Handles BunifuThinButton26.Click
        panelabm.Visible = False
        pagesabm.Visible = True
        pagesabm.SetPage(2)
    End Sub

    Private Sub BunifuThinButton25_Click(sender As Object, e As EventArgs) Handles BunifuThinButton25.Click
        panelabm.Visible = False
        pagesabm.Visible = True
        pagesabm.SetPage(0)
    End Sub

    Private Sub BunifuThinButton24_Click(sender As Object, e As EventArgs) Handles BunifuThinButton24.Click
        panelabm.Visible = False
        pagesabm.Visible = True
        pagesabm.SetPage(1)
    End Sub

    Private Sub BunifuFlatButton7_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton7.Click
        pagesabm.Visible = False
        panelabm.Visible = True

    End Sub

    Private Sub BunifuFlatButton8_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton8.Click
        pagesabm.Visible = False
        panelabm.Visible = True
    End Sub

    Private Sub BunifuFlatButton12_Click(sender As Object, e As EventArgs)
        pagesabm.Visible = False
        panelabm.Visible = True
    End Sub

    Private Sub BunifuThinButton211_Click(sender As Object, e As EventArgs) Handles BunifuThinButton211.Click
        panelhumms.Visible = False
        pagehumms.Visible = True
        pagehumms.SetPage(0)

    End Sub

    Private Sub BunifuThinButton210_Click(sender As Object, e As EventArgs) Handles BunifuThinButton210.Click
        panelhumms.Visible = False
        pagehumms.Visible = True
        pagehumms.SetPage(1)
    End Sub

    Private Sub BunifuThinButton27_Click(sender As Object, e As EventArgs) Handles BunifuThinButton27.Click
        panelhumms.Visible = False
        pagehumms.Visible = True
        pagehumms.SetPage(2)
    End Sub

    Private Sub BunifuFlatButton13_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton13.Click
        pagehumms.Visible = False
        panelhumms.Visible = True

    End Sub

    Private Sub BunifuFlatButton14_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton14.Click
        pagehumms.Visible = False
        panelhumms.Visible = True

    End Sub

    Private Sub BunifuFlatButton18_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton18.Click
        pagehumms.Visible = False
        panelhumms.Visible = True

    End Sub

    Private Sub BunifuThinButton23_Click(sender As Object, e As EventArgs) Handles BunifuThinButton23.Click
        panelstem.Visible = False
        pagestem.Visible = True
        pagestem.SetPage(2)
    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Dim a = MsgBox("Choose other strand?", +vbYesNo + vbQuestion, "Message")
        If a = vbYes Then
            acadinfos.Visible = False
            panelAcad.Visible = True

        End If
    End Sub

    Private Sub BunifuThinButton214_Click(sender As Object, e As EventArgs) Handles BunifuThinButton214.Click
        panelGas.Visible = False
        pageGas.Visible = True
        pageGas.SetPage(0)

    End Sub

    Private Sub BunifuThinButton213_Click(sender As Object, e As EventArgs) Handles BunifuThinButton213.Click
        panelGas.Visible = False
        pageGas.Visible = True
        pageGas.SetPage(1)
    End Sub

    Private Sub BunifuThinButton212_Click(sender As Object, e As EventArgs) Handles BunifuThinButton212.Click
        panelGas.Visible = False
        pageGas.Visible = True
        pageGas.SetPage(2)
    End Sub

    Private Sub BunifuFlatButton19_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton19.Click
        pageGas.Visible = False
        panelGas.Visible = True

    End Sub

    Private Sub BunifuFlatButton20_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton20.Click
        pageGas.Visible = False
        panelGas.Visible = True
    End Sub

    Private Sub BunifuFlatButton24_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton24.Click
        pageGas.Visible = False
        panelGas.Visible = True
    End Sub

    Private Sub BunifuImageButton3_Click(sender As Object, e As EventArgs) Handles BunifuImageButton3.Click
        Dim a = MsgBox("Choose other strand?", +vbYesNo + vbQuestion, "Message")
        If a = vbYes Then
            acadinfos.Visible = False
            panelAcad.Visible = True

        End If
    End Sub

    Private Sub BunifuImageButton1_Click_1(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Dim a = MsgBox("Choose other strand?", +vbYesNo + vbQuestion, "Message")
        If a = vbYes Then
            acadinfos.Visible = False
            panelAcad.Visible = True

        End If
    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        Dim a = MsgBox("Choose other strand?", +vbYesNo + vbQuestion, "Message")
        If a = vbYes Then
            acadinfos.Visible = False
            panelAcad.Visible = True

        End If
    End Sub


    Private Sub btngrowth_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub btngrowth_Click(sender As Object, e As EventArgs) Handles btngrowth.Click
        If ListBox2.SelectedIndex = 0 Then

            MsgBox("Doctors job outlook after 10 years will grow 8%  ", vbInformation, "Information")
        ElseIf ListBox2.SelectedIndex = 1 Then
            MsgBox("Nurse job outlook after 10 years will grow 8%s", vbInformation, "Information")
        ElseIf ListBox2.SelectedIndex = 2 Then
            MsgBox("Dentist job outlook after 10 years will grow 8%", vbInformation, "Information")
        ElseIf ListBox2.SelectedIndex = 3 Then
            MsgBox("Pharmacist job outlook after 10 years will grow 8%", vbInformation, "Information")
        ElseIf ListBox2.SelectedIndex = 4 Then
            MsgBox("Nurse job outlook after 10 years will grow 8%s", vbInformation, "Information")
        ElseIf ListBox2.SelectedIndex = 5 Then
            MsgBox("Nurse job outlook after 10 years will grow 8%s", vbInformation, "Information")
        ElseIf ListBox2.SelectedIndex = 6 Then
            MsgBox("Nurse job outlook after 10 years will grow 8%s", vbInformation, "Information")
        ElseIf ListBox2.SelectedIndex = 7 Then
            MsgBox("Nurse job outlook after 10 years will grow 8%s", vbInformation, "Information")
        ElseIf ListBox2.SelectedIndex = 8 Then
            MsgBox("Nurse job outlook after 10 years will grow 8%s", vbInformation, "Information")
        ElseIf ListBox2.SelectedIndex = 9 Then
            MsgBox("Nurse job outlook after 10 years will grow 8%s", vbInformation, "Information")
        ElseIf ListBox2.SelectedIndex = 10 Then
            MsgBox("Nurse job outlook after 10 years will grow 8%s", vbInformation, "Information")
        ElseIf ListBox2.SelectedIndex = 11 Then
            MsgBox("Nurse job outlook after 10 years will grow 8%s", vbInformation, "Information")
        ElseIf ListBox2.SelectedIndex = 12 Then
            MsgBox("Nurse job outlook after 10 years will grow 8%s", vbInformation, "Information")
        End If
    End Sub

    Private Sub btnabmback_Click(sender As Object, e As EventArgs) Handles btnabmback.Click
        pagesabm.Visible = False
        panelabm.Visible = True
    End Sub

    Private Sub BunifuFlatButton6_Click_1(sender As Object, e As EventArgs) Handles BunifuFlatButton6.Click
        pagestem.Visible = False
        panelstem.Visible = True

    End Sub

    Private Sub BunifuCustomLabel18_Click(sender As Object, e As EventArgs) Handles BunifuCustomLabel18.Click

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

    Private Sub BunifuFlatButton11_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton11.Click
        GroupBox6.Visible = True

    End Sub

    Private Sub BunifuFlatButton9_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton9.Click
        GroupBox5.Visible = True

    End Sub

    Private Sub BunifuFlatButton10_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton10.Click
        GroupBox4.Visible = True

    End Sub

    Private Sub btnabmgrowth_Click(sender As Object, e As EventArgs) Handles btnabmgrowth.Click

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
        End If
    End Sub

    Private Sub BunifuFlatButton25_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton25.Click
        If ListBox3.SelectedIndex = 0 Then

            MsgBox("Software Engineering growth rate 5% after 5 years", vbInformation, "Information")
        ElseIf ListBox3.SelectedIndex = 1 Then
            MsgBox("Software Engineering growth rate 5% after 5 years", vbInformation, "Information")
        ElseIf ListBox3.SelectedIndex = 2 Then
            MsgBox("Software Engineering growth rate 5% after 5 years", vbInformation, "Information")
        ElseIf ListBox3.SelectedIndex = 3 Then
            MsgBox("Software Engineering growth rate 5% after 5 years", vbInformation, "Information")
        ElseIf ListBox3.SelectedIndex = 4 Then
            MsgBox("Software Engineering growth rate 5% after 5 years", vbInformation, "Information")
        ElseIf ListBox3.SelectedIndex = 5 Then
            MsgBox("Software Engineering growth rate 5% after 5 years", vbInformation, "Information")

        ElseIf ListBox3.SelectedIndex = 6 Then
            MsgBox("Software Engineering growth rate 5% after 5 years", vbInformation, "Information")


        End If
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

    Private Sub BunifuFlatButton23_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton23.Click
        GroupBox12.Visible = True

    End Sub

    Private Sub BunifuFlatButton21_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton21.Click
        GroupBox11.Visible = True

    End Sub

    Private Sub BunifuFlatButton22_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton22.Click
        GroupBox10.Visible = True

    End Sub

    Private Sub BunifuCustomLabel6_Click(sender As Object, e As EventArgs) Handles BunifuCustomLabel6.Click

    End Sub

    Private Sub BunifuCustomLabel72_Click(sender As Object, e As EventArgs) Handles BunifuCustomLabel72.Click

    End Sub
End Class