
Public Class index


    Sub switchPanel(ByVal panel As Form)
        Panel1.Controls.Clear()
        panel.TopLevel = False
        Panel1.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dropdownbutton()
        hidebutton()


    End Sub
    Public Sub hidebutton()
        If panelMore.Visible = True Then
            panelMore.Visible = False

        End If
    End Sub
    Public Sub showSubmenu(subMenu As Panel)
        If subMenu.Visible = False Then
            hidebutton()
            subMenu.Visible = True
        Else
            subMenu.Visible = False

        End If
    End Sub





    Private Sub bfubtnacad_Click_2(sender As Object, e As EventArgs) Handles bfubtnacad.Click
        If panelLeftSide.Width = 50 Then


            panelLeftSide.Visible = False
            panelLeftSide.Width = 180
            panelAnimatpr.ShowSync(panelLeftSide)
        Else
            bfumenu2.Visible = True
            bfumenu.Visible = False
            Panel1.Width = 1100
            panelLeftSide.Visible = False
            panelLeftSide.Width = 50
            panelAnimatpr.ShowSync(panelLeftSide)


        End If

        switchPanel(acadtrack)
    End Sub


    Private Sub bfumenu_Click(sender As Object, e As EventArgs) Handles bfumenu.Click
        If panelLeftSide.Width = 50 Then


            panelLeftSide.Visible = False
            panelLeftSide.Width = 180
            panelAnimatpr.ShowSync(panelLeftSide)
        Else
            bfumenu2.Visible = True
            bfumenu.Visible = False
            Panel1.Width = 1100
            panelLeftSide.Visible = False
            panelLeftSide.Width = 50
            panelAnimatpr.ShowSync(panelLeftSide)


        End If
    End Sub

    Private Sub bfumenu2_Click_1(sender As Object, e As EventArgs) Handles bfumenu2.Click
        If panelLeftSide.Width = 50 Then
            bfumenu.Visible = True
            bfumenu2.Visible = False

            panelLeftSide.Visible = False
            panelLeftSide.Width = 180

            panelAnimatpr.ShowSync(panelLeftSide)


        Else
            bfumenu.Visible = True
            bfumenu2.Visible = False
            Panel1.Width = 1100
            panelLeftSide.Visible = False
            panelLeftSide.Width = 50
            panelAnimatpr.ShowSync(panelLeftSide)


        End If


    End Sub
    Public Sub dropdownbutton()
        panelMore.Visible = False

    End Sub

    Private Sub BunifuFlatButton4_Click(sender As Object, e As EventArgs) Handles btnmore.Click
        showSubmenu(panelMore)
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles compatbilty.Click
        If panelLeftSide.Width = 50 Then


            panelLeftSide.Visible = False
            panelLeftSide.Width = 180
            panelAnimatpr.ShowSync(panelLeftSide)
        Else
            bfumenu2.Visible = True
            bfumenu.Visible = False
            Panel1.Width = 1100
            panelLeftSide.Visible = False
            panelLeftSide.Width = 50
            panelAnimatpr.ShowSync(panelLeftSide)


        End If
        switchPanel(Form2)
        hidebutton()

    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs)
        If panelLeftSide.Width = 50 Then


            panelLeftSide.Visible = False
            panelLeftSide.Width = 180
            panelAnimatpr.ShowSync(panelLeftSide)
        Else
            bfumenu2.Visible = True
            bfumenu.Visible = False
            Panel1.Width = 1100
            panelLeftSide.Visible = False
            panelLeftSide.Width = 50
            panelAnimatpr.ShowSync(panelLeftSide)


        End If
        hidebutton()


    End Sub

    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click
        If panelLeftSide.Width = 50 Then


            panelLeftSide.Visible = False
            panelLeftSide.Width = 180
            panelAnimatpr.ShowSync(panelLeftSide)
        Else
            bfumenu2.Visible = True
            bfumenu.Visible = False
            Panel1.Width = 1100
            panelLeftSide.Visible = False
            panelLeftSide.Width = 50
            panelAnimatpr.ShowSync(panelLeftSide)


        End If
        hidebutton()
        Dim a = MsgBox("Do you want to logout?", vbYesNo + vbQuestion, "Signout")
        If a = vbYes Then
            Application.Exit()



        End If
    End Sub

    Private Sub bfubtntvl_Click(sender As Object, e As EventArgs) Handles bfubtntvl.Click
        If panelLeftSide.Width = 50 Then


            panelLeftSide.Visible = False
            panelLeftSide.Width = 180
            panelAnimatpr.ShowSync(panelLeftSide)
        Else
            bfumenu2.Visible = True
            bfumenu.Visible = False
            Panel1.Width = 1100
            panelLeftSide.Visible = False
            panelLeftSide.Width = 50
            panelAnimatpr.ShowSync(panelLeftSide)


        End If

        switchPanel(techvoctrack)
    End Sub

    Private Sub bfubtnarts_Click(sender As Object, e As EventArgs) Handles bfubtnarts.Click
        If panelLeftSide.Width = 50 Then


            panelLeftSide.Visible = False
            panelLeftSide.Width = 180
            panelAnimatpr.ShowSync(panelLeftSide)
        Else
            bfumenu2.Visible = True
            bfumenu.Visible = False
            Panel1.Width = 1100
            panelLeftSide.Visible = False
            panelLeftSide.Width = 50
            panelAnimatpr.ShowSync(panelLeftSide)


        End If
        switchPanel(Form3)
    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        Dim a = MsgBox("Do you want to exit the application?", vbYesNo + vbQuestion, "Exit")
        If a = vbYes Then
            Application.Exit()

        End If
    End Sub

    Private Sub bnfbtnsports_Click(sender As Object, e As EventArgs) Handles bnfbtnsports.Click
        If panelLeftSide.Width = 50 Then


            panelLeftSide.Visible = False
            panelLeftSide.Width = 180
            panelAnimatpr.ShowSync(panelLeftSide)
        Else
            bfumenu2.Visible = True
            bfumenu.Visible = False
            Panel1.Width = 1100
            panelLeftSide.Visible = False
            panelLeftSide.Width = 50
            panelAnimatpr.ShowSync(panelLeftSide)


        End If
        switchPanel(Form3)
    End Sub

    Private Sub bfubtnhome_Click(sender As Object, e As EventArgs) Handles bfubtnhome.Click
        If panelLeftSide.Width = 50 Then


            panelLeftSide.Visible = False
            panelLeftSide.Width = 180
            panelAnimatpr.ShowSync(panelLeftSide)
        Else
            bfumenu2.Visible = True
            bfumenu.Visible = False
            Panel1.Width = 1100
            panelLeftSide.Visible = False
            panelLeftSide.Width = 50
            panelAnimatpr.ShowSync(panelLeftSide)


        End If
        switchPanel(Form1)
    End Sub
End Class
