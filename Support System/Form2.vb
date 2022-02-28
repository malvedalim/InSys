Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic

Public Class Form2
    Dim avg As Double = 100
    Dim c As New MySqlConnection
    Dim d As New MySqlDataAdapter
    Dim cm As New MySqlCommand
    Dim dr As MySqlDataReader
    Dim ex As MySqlException
    Dim s As New DataSet
    Dim stemag As Double
    Dim abmag As Double
    Dim hummsag As Double
    Dim gasag As Double
    Dim agriag As Double
    Dim hecoag As Double
    Dim ictag As Double
    Dim iag As Double
    Dim sportsag As Double
    Dim artsag As Double


    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles BunifuButton1.Click
        cptblty.Visible = True
        cptblty.SetPage(0)
        acadtrack.Visible = True

    End Sub


    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs)
        acad.Visible = True

        acad.SetPage(0)
    End Sub



    Private Sub btnsaveres_Click(sender As Object, e As EventArgs)
        If txtstemarchi.Text = "" Or txtstemnatsci.Text = "" Or txtstemproserv.Text = "" Or txtstemsci.Text = "" Or txtstemtech.Text = "" Then
            MsgBox("Unfilled Textbox!")
            txtstemsci.Focus()
        Else


            Try
                c.Open()
                If c.State = ConnectionState.Open Then
                    d.SelectCommand = c.CreateCommand
                    d.SelectCommand.CommandText = "INSERT INTO ncaestem (science,engr,archi,tech,natsci) value('" & txtstemsci.Text & "','" & txtstengr.Text & "','" & txtstemarchi.Text & "','" & txtstemtech.Text & "','" & txtstemnatsci.Text & "')"
                    d.SelectCommand.ExecuteReader()
                    c.Close()
                    Dim a = MsgBox("Continue?", vbYesNo + vbQuestion, "Your Result has been saved")
                    If a = vbYes Then
                        acad.SetPage(1)
                    End If


                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                c.Dispose()

            End Try
        End If
    End Sub


    Private Sub btnstemres_Click(sender As Object, e As EventArgs)




    End Sub

    Private Sub btnabmres_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnsaveres_Click_1(sender As Object, e As EventArgs)


    End Sub

    Private Sub BunifuThinButton224_Click(sender As Object, e As EventArgs)
        If txtstemarchi.Text = "" Or txtstemnatsci.Text = "" Or txtstemproserv.Text = "" Or txtstemsci.Text = "" Or txtstemtech.Text = "" Then
            MsgBox("Unfilled Textbox!")
            txtstemsci.Focus()
        Else

        End If

    End Sub



    Private Sub txtstemsci_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtstemsci.KeyPress
        numberonly(e)
    End Sub
    Public Sub numberonly(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 46 Then
        Else
            e.Handled = True
            MsgBox("Only Numbers are Allowed!")

        End If
    End Sub

    Private Sub txtstemnatsci_KeyPress(sender As Object, e As EventArgs) Handles txtstemnatsci.KeyPress
        numberonly(e)
    End Sub

    Private Sub txtstemtech_KeyPress(sender As Object, e As EventArgs) Handles txtstemtech.KeyPress
        numberonly(e)
    End Sub

    Private Sub txtstengr_KeyPress(sender As Object, e As EventArgs) Handles txtstengr.KeyPress
        numberonly(e)
    End Sub

    Private Sub txtstemarchi_KeyPress(sender As Object, e As EventArgs) Handles txtstemarchi.KeyPress
        numberonly(e)
    End Sub

    Private Sub txtstemproserv_KeyPress(sender As Object, e As EventArgs) Handles txtstemproserv.KeyPress
        numberonly(e)
    End Sub

    Private Sub txtabmbusi_KeyPress(sender As Object, e As EventArgs) Handles txtabmbusi.KeyPress
        numberonly(e)
    End Sub

    Private Sub txtabmprofserv_KeyPress(sender As Object, e As EventArgs) Handles txtabmprofserv.KeyPress
        numberonly(e)
    End Sub

    Private Sub txthummsmedia_KeyPress(sender As Object, e As EventArgs) Handles txthummsmedia.KeyPress
        numberonly(e)
    End Sub

    Private Sub txthummsarts_KeyPress(sender As Object, e As EventArgs) Handles txthummsarts.KeyPress
        numberonly(e)

    End Sub

    Private Sub txthummsfash_KeyPress(sender As Object, e As EventArgs) Handles txthummsfash.KeyPress
        numberonly(e)

    End Sub

    Private Sub txthummsspir_KeyPress(sender As Object, e As EventArgs) Handles txthummsspir.KeyPress
        numberonly(e)
    End Sub

    Private Sub txthummsperserv_KeyPress(sender As Object, e As EventArgs) Handles txthummsperserv.KeyPress
        numberonly(e)
    End Sub

    Private Sub txtgasprofserv_KeyPress(sender As Object, e As EventArgs) Handles txtgasprofserv.KeyPress
        numberonly(e)
    End Sub

    Private Sub txtgasbusi_KeyPress(sender As Object, e As EventArgs) Handles txtgasbusi.KeyPress
        numberonly(e)
    End Sub

    Private Sub txtgasperserv_KeyPress(sender As Object, e As EventArgs) Handles txtgasperserv.KeyPress
        numberonly(e)
    End Sub

    Private Sub txtgascommunity_KeyPress(sender As Object, e As EventArgs) Handles txtgascommunity.KeyPress
        numberonly(e)
    End Sub

    Private Sub txtgasspirit_KeyPress(sender As Object, e As EventArgs) Handles txtgasspirit.KeyPress
        numberonly(e)
    End Sub

    Private Sub txthecofash_KeyPress(sender As Object, e As EventArgs) Handles txthecofash.KeyPress
        numberonly(e)
    End Sub

    Private Sub txthecocomserv_KeyPress(sender As Object, e As EventArgs) Handles txthecocomserv.KeyPress
        numberonly(e)
    End Sub

    Private Sub txthecoperserv_KeyPress(sender As Object, e As EventArgs) Handles txthecoperserv.KeyPress
        numberonly(e)
    End Sub

    Private Sub txtictengr_KeyPress(sender As Object, e As EventArgs) Handles txtictengr.KeyPress
        numberonly(e)
    End Sub

    Private Sub txtictcompu_KeyPress(sender As Object, e As EventArgs) Handles txtictcompu.KeyPress
        numberonly(e)
    End Sub

    Private Sub txtictbusi_KeyPress(sender As Object, e As EventArgs) Handles txtictbusi.KeyPress
        numberonly(e)
    End Sub

    Private Sub txtagriaaf_KeyPress(sender As Object, e As EventArgs) Handles txtagriaaf.KeyPress
        numberonly(e)
    End Sub

    Private Sub txtagriengr_KeyPress(sender As Object, e As EventArgs) Handles txtagriengr.KeyPress
        numberonly(e)
    End Sub

    Private Sub txtagribfc_KeyPress(sender As Object, e As EventArgs) Handles txtagribfc.KeyPress
        numberonly(e)
    End Sub

    Private Sub txtiaarchi_KeyPress(sender As Object, e As EventArgs) Handles txtiaarchi.KeyPress
        numberonly(e)
    End Sub

    Private Sub txtiaengr_KeyPress(sender As Object, e As EventArgs) Handles txtiaengr.KeyPress
        numberonly(e)
    End Sub

    Private Sub txtiafash_KeyPress(sender As Object, e As EventArgs) Handles txtiafash.KeyPress
        numberonly(e)
    End Sub

    Private Sub txtsportsmili_KeyPress(sender As Object, e As EventArgs) Handles txtsportsmili.KeyPress
        numberonly(e)
    End Sub

    Private Sub txtsportscomserv_KeyPress(sender As Object, e As EventArgs) Handles txtsportscomserv.KeyPress
        numberonly(e)
    End Sub

    Private Sub txtsportsperserv_KeyPress(sender As Object, e As EventArgs) Handles txtsportsperserv.KeyPress
        numberonly(e)
    End Sub

    Private Sub GunaTextBox3_KeyPress(sender As Object, e As EventArgs) Handles txtartsmedia.KeyPress
        numberonly(e)
    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs)
        acad.Visible = True

        acad.SetPage(1)
    End Sub

    Private Sub BunifuImageButton4_Click(sender As Object, e As EventArgs)
        acad.Visible = True

        acad.SetPage(2)
    End Sub

    Private Sub BunifuImageButton5_Click(sender As Object, e As EventArgs)
        acad.Visible = True

        acad.SetPage(3)
    End Sub

    Private Sub BunifuButton2_Click(sender As Object, e As EventArgs) Handles BunifuButton2.Click
        cptblty.Visible = True
        cptblty.SetPage(1)

        tvl.Visible = True

    End Sub

    Private Sub BunifuImageButton8_Click(sender As Object, e As EventArgs)
        pagetvl.Visible = True
        pagetvl.SetPage(0)

    End Sub

    Private Sub BunifuImageButton7_Click(sender As Object, e As EventArgs)
        pagetvl.Visible = True
        pagetvl.SetPage(1)
    End Sub

    Private Sub BunifuImageButton6_Click(sender As Object, e As EventArgs)
        pagetvl.Visible = True
        pagetvl.SetPage(2)
    End Sub

    Private Sub BunifuImageButton3_Click(sender As Object, e As EventArgs)
        pagetvl.Visible = True
        pagetvl.SetPage(3)
    End Sub

    Private Sub BunifuButton3_Click(sender As Object, e As EventArgs) Handles BunifuButton3.Click
        cptblty.Visible = True
        cptblty.SetPage(2)
        panelImage.Visible = True


    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub BunifuImageButton9_Click(sender As Object, e As EventArgs)
        panelSports.Visible = True
        BunifuImageButton9.Visible = False

    End Sub

    Private Sub BunifuImageButton10_Click(sender As Object, e As EventArgs)
        panelArts.Visible = True
    End Sub

    Private Sub BunifuImageButton9_Click_1(sender As Object, e As EventArgs)
        panelImage.Visible = False

        panelSports.Visible = True


    End Sub

    Private Sub BunifuButton4_Click(sender As Object, e As EventArgs) Handles BunifuButton4.Click
        cptblty.Visible = True
        cptblty.SetPage(3)
        panelimgarts.Visible = True

    End Sub

    Private Sub BunifuImageButton10_Click_1(sender As Object, e As EventArgs)
        panelimgarts.Visible = False

        panelArts.Visible = True

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        c.ConnectionString = "server=localhost; user=root; password=1234; database=supportsys; port= 3307"
    End Sub



    Private Sub btnstem_Click(sender As Object, e As EventArgs)
        panelAcad.Visible = False
        acad.Visible = True
        acad.SetPage(0)
    End Sub

    Private Sub btnabm_Click(sender As Object, e As EventArgs)
        panelAcad.Visible = False
        acad.Visible = True
        acad.SetPage(1)
    End Sub

    Private Sub btnhumms_Click(sender As Object, e As EventArgs)
        panelAcad.Visible = False
        acad.Visible = True
        acad.SetPage(2)
    End Sub

    Private Sub btngas_Click(sender As Object, e As EventArgs)
        panelAcad.Visible = False
        acad.Visible = True
        acad.SetPage(3)
    End Sub

    Private Sub BunifuThinButton224_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnsaveres_Click_2(sender As Object, e As EventArgs) Handles btnsaveres.Click

        If txtstemarchi.Text = "" Or txtstemnatsci.Text = "" Or txtstemproserv.Text = "" Or txtstemsci.Text = "" Or txtstemtech.Text = "" Then
            MsgBox("Unfilled Textbox!")
            txtstemsci.Focus()
        ElseIf txtstemarchi.Text > 100 Or txtstemnatsci.Text > 100 Or txtstemproserv.Text > 100 Or txtstemsci.Text > 100 Or txtstemtech.Text > 100 Then
            MsgBox("Input exceeded the required number!")
            txtstemsci.Focus()
        Else
            Dim stem As Double = Double.Parse(txtstengr.Text) + Double.Parse(txtstemarchi.Text) + Double.Parse(txtstemnatsci.Text) + Double.Parse(txtstemnatsci.Text) + Double.Parse(txtstemnatsci.Text) + Double.Parse(txtstemnatsci.Text)
            Dim stemtot As Double = stem / 600
            stemag = stemtot * avg

            Try
                c.Open()
                If c.State = ConnectionState.Open Then
                    d.SelectCommand = c.CreateCommand
                    d.SelectCommand.CommandText = "INSERT INTO stem(stemscience,stemengr,stemarchi,stemtech,stemnatsci) value('" & txtstemsci.Text & "','" & txtstengr.Text & "','" & txtstemarchi.Text & "','" & txtstemtech.Text & "','" & txtstemnatsci.Text & "')"
                    d.SelectCommand.ExecuteReader()
                    c.Close()

                    Dim b = MsgBox("Input will be disabled", vbOKOnly + vbReadOnly, "Warning")

                    If b = vbOK Then
                        txtstemarchi.Enabled = False
                        txtstemsci.Enabled = False
                        txtstemnatsci.Enabled = False
                        txtstemproserv.Enabled = False
                        txtstemtech.Enabled = False
                        txtstengr.Enabled = False
                        Dim a = MsgBox("Save data?", vbYesNo + vbQuestion, "Message")
                        If a = vbYes Then
                            MsgBox("Successfuly Saved!")
                            acad.Visible = False
                            panelAcad.Visible = True
                            btnstemclear.Enabled = False





                        End If
                    End If

                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                c.Dispose()

            End Try
        End If



    End Sub





    Private Sub btnabmsave_Click(sender As Object, e As EventArgs) Handles btnabmsave.Click

        If txtabmbusi.Text = "" Or txtabmprofserv.Text = "" Then
            MsgBox("Fill up the empty textbox!")
            txtabmbusi.Focus()
        ElseIf txtabmbusi.Text > 100 Or txtabmprofserv.Text > 100 Then
            MsgBox("Input exceeded the required number!")
            txtabmbusi.Focus()
        Else

            Dim abm As Double = Double.Parse(txtabmbusi.Text) + Double.Parse(txtabmprofserv.Text)
            Dim abmtot As Double = abm / 200
            abmag = abmtot * avg
            Try
                c.Open()
                If c.State = ConnectionState.Open Then
                    d.SelectCommand = c.CreateCommand
                    d.SelectCommand.CommandText = "INSERT INTO abm(abmbusiness,abmprofserv) value('" & txtabmbusi.Text & "','" & txtabmprofserv.Text & "')"
                    d.SelectCommand.ExecuteReader()
                    c.Close()
                    Dim b = MsgBox("Input will be disabled", vbOKOnly + vbReadOnly, "Warning")

                    If b = vbOK Then
                        txtabmbusi.Enabled = False
                        txtabmprofserv.Enabled = False

                        Dim a = MsgBox("Save data?", vbYesNo + vbQuestion, "Message")
                        If a = vbYes Then
                            MsgBox("Successfuly Saved!")
                            acad.Visible = False
                            panelAcad.Visible = True
                            btnabmclear.Enabled = False





                        End If
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                c.Dispose()

            End Try
        End If


    End Sub



    Private Sub btnhummsave_Click(sender As Object, e As EventArgs) Handles btnhummsave.Click

        If txthummsarts.Text = "" Or txthummscomu.Text = "" Or txthummsfash.Text = "" Or txthummsmedia.Text = "" Or txthummsmili.Text = "" Or txthummsspir.Text = "" Or txthummsperserv.Text = "" Then
            MsgBox("Fill up the empty textbox!")
            txthummsmedia.Focus()
        ElseIf txthummsarts.Text > 100 Or txthummscomu.Text > 100 Or txthummsfash.Text > 100 Or txthummsmedia.Text > 100 Or txthummsmili.Text > 100 Or txthummsspir.Text > 100 Or txthummsperserv.Text > 100 Then
            MsgBox("Input exceeded the required number!")
            txthummsmedia.Focus()

        Else
            Dim humms As Double = Double.Parse(txthummscomu.Text) + Double.Parse(txthummsarts.Text) + Double.Parse(txthummsfash.Text) + Double.Parse(txthummsmedia.Text) + Double.Parse(txthummsmili.Text) + Double.Parse(txthummsperserv.Text) + Double.Parse(txthummsspir.Text)
            Dim hummstot As Double = humms / 700
            hummsag = hummstot * avg

            Try
                c.Open()
                If c.State = ConnectionState.Open Then
                    d.SelectCommand = c.CreateCommand
                    d.SelectCommand.CommandText = "INSERT INTO humms(hummsmedia,hummscommu,hummsarts,hummsfash,hummsspirit,hummsmilitary,hummsperserv) value('" & txthummsmedia.Text & "','" & txthummscomu.Text & "', '" & txthummsarts.Text & "', '" & txthummsfash.Text & "','" & txthummsspir.Text & "', '" & txthummsmili.Text & "','" & txthummsperserv.Text & "')"
                    d.SelectCommand.ExecuteReader()
                    c.Close()
                    Dim b = MsgBox("Input will be disabled", vbOKOnly + vbReadOnly, "Warning")

                    If b = vbOK Then
                        txthummsarts.Enabled = False
                        txthummscomu.Enabled = False
                        txthummsfash.Enabled = False
                        txthummsmedia.Enabled = False
                        txthummsmili.Enabled = False
                        txthummsspir.Enabled = False
                        txthummsperserv.Enabled = False

                        Dim a = MsgBox("Save data?", vbYesNo + vbQuestion, "Message")
                        If a = vbYes Then
                            MsgBox("Successfuly Saved!")
                            acad.Visible = False
                            panelAcad.Visible = True
                            btnhummsclear.Enabled = False

                        End If

                    End If


                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                c.Dispose()

            End Try
        End If

    End Sub

    Private Sub txtgasspirit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtgasspirit.KeyPress

    End Sub



    Private Sub btngasave_Click(sender As Object, e As EventArgs) Handles btngasave.Click

        If txtgasbusi.Text = "" Or txtgascommunity.Text = "" Or txtgasperserv.Text = "" Or txtgasspirit.Text = "" Or txtgasprofserv.Text = "" Then
            MsgBox("Fill up the empty textbox!")
            txtgasprofserv.Focus()
        ElseIf txtgasbusi.Text > 100 Or txtgascommunity.Text > 100 Or txtgasperserv.Text > 100 Or txtgasspirit.Text > 100 Or txtgasprofserv.Text > 100 Then
            MsgBox("Input exceeded the required number!")
            txtgasprofserv.Focus()
        Else
            Dim gas As Double = Double.Parse(txtgascommunity.Text) + Double.Parse(txtgasperserv.Text) + Double.Parse(txtgasprofserv.Text) + Double.Parse(txtgasspirit.Text) + Double.Parse(txtgasbusi.Text)
            Dim gastot As Double = gas / 500
            gasag = gastot * avg
            Try
                c.Open()
                If c.State = ConnectionState.Open Then
                    d.SelectCommand = c.CreateCommand
                    d.SelectCommand.CommandText = "INSERT INTO gas(gasprofserv, gasfinance, gasperserv, gascomserv,gaspirit) value('" & txtgasprofserv.Text & "','" & txtgasbusi.Text & "','" & txtgasperserv.Text & "','" & txtgascommunity.Text & "','" & txtgasspirit.Text & "')"
                    d.SelectCommand.ExecuteReader()
                    c.Close()
                    Dim b = MsgBox("Input will be disabled", vbOKOnly + vbReadOnly, "Warning")

                    If b = vbOK Then
                        txtgasbusi.Enabled = False
                        txtgascommunity.Enabled = False
                        txtgasperserv.Enabled = False
                        txtgasspirit.Enabled = False
                        txtgasprofserv.Enabled = False


                        Dim a = MsgBox("Save data?", vbYesNo + vbQuestion, "Message")
                        If a = vbYes Then
                            MsgBox("Successfuly Saved!")
                            acad.Visible = False
                            panelAcad.Visible = True
                        End If

                    End If
                End If



            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                c.Dispose()


            End Try
        End If

    End Sub

    Private Sub btnagri_Click(sender As Object, e As EventArgs)
        panelTVL.Visible = False
        pagetvl.Visible = True
        pagetvl.SetPage(0)
    End Sub

    Private Sub BunifuThinButton214_Click(sender As Object, e As EventArgs) Handles btnagrisave.Click

        If txtagriaaf.Text = "" Or txtagribfc.Text = "" Or txtagriengr.Text = "" Then
            MsgBox("Fill up the empty textbox!")
            txtgasprofserv.Focus()
        ElseIf txtagriaaf.Text > 100 Or txtagribfc.Text > 100 Or txtagriengr.Text > 100 Then
            MsgBox("Input  Exceeded the recquired number!")
            txtgasprofserv.Focus()
        Else

            Dim agri As Double = Double.Parse(txtagriaaf.Text) + Double.Parse(txtagribfc.Text) + Double.Parse(txtagriengr.Text)
            Dim agritot As Double = agri / 300
            agriag = agritot * avg
            Try
                c.Open()
                If c.State = ConnectionState.Open Then
                    d.SelectCommand = c.CreateCommand
                    d.SelectCommand.CommandText = "INSERT INTO agri(agriaqua, agribusiness, agriengr) value('" & txtagriaaf.Text & "','" & txtagribfc.Text & "','" & txtagriengr.Text & "')"
                    d.SelectCommand.ExecuteReader()
                    c.Close()
                    Dim b = MsgBox("Input will be disabled", vbOKOnly + vbReadOnly, "Warning")

                    If b = vbOK Then
                        txtgasbusi.Enabled = False
                        txtgascommunity.Enabled = False
                        txtgasperserv.Enabled = False
                        txtgasspirit.Enabled = False
                        txtgasprofserv.Enabled = False
                        Dim a = MsgBox("Save data?", vbYesNo + vbQuestion, "Message")
                        If a = vbYes Then
                            MsgBox("Successfuly Saved!")
                            pagetvl.Visible = False
                            panelTVL.Visible = True
                        End If

                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                c.Dispose()

            End Try
        End If

    End Sub
    Private Sub btnheconsave_Click(sender As Object, e As EventArgs) Handles btnheconsave.Click

        If txthecocomserv.Text = "" Or txthecofash.Text = "" Or txthecoperserv.Text = "" Then
            MsgBox("Fill up the empty textbox!")
            txthecofash.Focus()
        ElseIf txthecocomserv.Text > 100 Or txthecofash.Text > 100 Or txthecoperserv.Text > 100 Then
            MsgBox("Input  Exceeded the recquired number!")
            txthecofash.Focus()
        Else
            Dim hecon As Double = Double.Parse(txthecocomserv.Text) + Double.Parse(txthecofash.Text) + Double.Parse(txthecoperserv.Text)
            Dim hecontot As Double = hecon / 300
            hecoag = hecontot * avg
            Try
                c.Open()
                If c.State = ConnectionState.Open Then
                    d.SelectCommand = c.CreateCommand
                    d.SelectCommand.CommandText = "INSERT INTO homecon(heconfashion, heconcomserv, heconperserv) value('" & txthecofash.Text & "','" & txthecocomserv.Text & "','" & txthecoperserv.Text & "')"
                    d.SelectCommand.ExecuteReader()
                    c.Close()
                    Dim b = MsgBox("Input will be disabled", vbOKOnly + vbReadOnly, "Warning")

                    If b = vbOK Then
                        txthecocomserv.Enabled = False
                        txthecofash.Enabled = False
                        txthecoperserv.Enabled = False

                        Dim a = MsgBox("Save data?", vbYesNo + vbQuestion, "Message")
                        If a = vbYes Then
                            MsgBox("Successfuly Saved!")
                            tvl.Visible = False
                            panelTVL.Visible = True
                        End If

                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                c.Dispose()

            End Try
        End If
    End Sub
    Private Sub btnictsave_Click(sender As Object, e As EventArgs) Handles btnictsave.Click

        If txtictbusi.Text = "" Or txtictcompu.Text = "" Or txtictengr.Text = "" Then
            MsgBox("Fill up the empty textbox!")
            txtictengr.Focus()
        ElseIf txtictbusi.Text > 100 Or txtictcompu.Text > 100 Or txtictengr.Text > 100 Then
            MsgBox("Input  Exceeded the recquired number!")
            txtictengr.Focus()

        Else
            Dim ict As Double = Double.Parse(txtictbusi.Text) + Double.Parse(txtictcompu.Text) + Double.Parse(txtictengr.Text)
            Dim ictot As Double = ict / 300
            ictag = ictot * avg
            Try
                c.Open()
                If c.State = ConnectionState.Open Then
                    d.SelectCommand = c.CreateCommand
                    d.SelectCommand.CommandText = "INSERT INTO ict(ictengr,ictcomputer, ictbusiness) value('" & txtictengr.Text & "','" & txtictcompu.Text & "','" & txtictbusi.Text & "')"
                    d.SelectCommand.ExecuteReader()
                    c.Close()
                    Dim b = MsgBox("Input will be disabled", vbOKOnly + vbReadOnly, "Warning")

                    If b = vbOK Then
                        txtictbusi.Enabled = False
                        txtictcompu.Enabled = False
                        txtictengr.Enabled = False

                        Dim a = MsgBox("Save data?", vbYesNo + vbQuestion, "Message")
                        If a = vbYes Then
                            MsgBox("Successfuly Saved!")
                            tvl.Visible = False
                            panelTVL.Visible = True
                        End If

                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                c.Dispose()

            End Try
        End If
    End Sub
    Private Sub btniasave_Click(sender As Object, e As EventArgs) Handles btniasave.Click

        If txtiaarchi.Text = "" Or txtiaengr.Text = "" Or txtiafash.Text = "" Then
            MsgBox("Fill up the empty textbox!")
            txtictengr.Focus()
        ElseIf txtiaarchi.Text > 100 Or txtiaengr.Text > 100 Or txtiafash.Text > 100 Then
            MsgBox("Input  Exceeded the recquired number!")
            txtictengr.Focus()

        Else
            Dim ia As Double = Double.Parse(txtiaarchi.Text) + Double.Parse(txtiaengr.Text) + Double.Parse(txtiafash.Text)
            Dim iatot As Double = ia / 300
            iag = iatot * avg
            Try
                c.Open()
                If c.State = ConnectionState.Open Then
                    d.SelectCommand = c.CreateCommand
                    d.SelectCommand.CommandText = "INSERT INTO industarts(iaarchi,iaengr, iafashion) value('" & txtiaarchi.Text & "','" & txtiaengr.Text & "','" & txtiafash.Text & "')"
                    d.SelectCommand.ExecuteReader()
                    c.Close()
                    Dim b = MsgBox("Input will be disabled", vbOKOnly + vbReadOnly, "Warning")

                    If b = vbOK Then
                        txtiaarchi.Enabled = False
                        txtiaengr.Enabled = False
                        txtiafash.Enabled = False

                        Dim a = MsgBox("Save data?", vbYesNo + vbQuestion, "Message")
                        If a = vbYes Then
                            MsgBox("Successfuly Saved!")
                            tvl.Visible = False
                            panelTVL.Visible = True
                        End If

                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                c.Dispose()

            End Try
        End If
    End Sub

    Private Sub bfumenu_Click(sender As Object, e As EventArgs) Handles bfumenu.Click
        Dim a = MsgBox("Go back selecting academic track offers?", vbYesNo + vbQuestion, "Message")
        If vbYes Then
            acad.Visible = False
            panelAcad.Visible = True

        End If
    End Sub

    Private Sub GunaGroupBox2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BunifuImageButton1_Click_1(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Dim a = MsgBox("Go back selecting academic track offers?", vbYesNo + vbQuestion, "Message")
        If vbYes Then
            acad.Visible = False
            panelAcad.Visible = True

        End If
    End Sub

    Private Sub BunifuImageButton3_Click_1(sender As Object, e As EventArgs) Handles BunifuImageButton3.Click
        Dim a = MsgBox("Go back selecting academic track offers?", vbYesNo + vbQuestion, "Message")
        If vbYes Then
            acad.Visible = False
            panelAcad.Visible = True

        End If
    End Sub

    Private Sub BunifuImageButton2_Click_1(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        Dim a = MsgBox("Go back selecting academic track offers?", vbYesNo + vbQuestion, "Message")
        If vbYes Then
            acad.Visible = False
            panelAcad.Visible = True

        End If
    End Sub

    Private Sub BunifuThinButton26_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtictengr_TextChanged(sender As Object, e As EventArgs) Handles txtictengr.TextChanged

    End Sub

    Private Sub BunifuImageButton9_Click_2(sender As Object, e As EventArgs) Handles BunifuImageButton9.Click
        panelImage.Visible = False
        panelSports.Visible = True

    End Sub

    Private Sub btnsportsave_Click(sender As Object, e As EventArgs) Handles btnsportsave.Click

        If txtsportscomserv.Text = "" Or txtsportsmili.Text = "" Or txtsportsperserv.Text = "" Then
            MsgBox("Fill up the empty textbox!")
            txtictengr.Focus()
        ElseIf txtsportscomserv.Text > 100 Or txtsportsmili.Text > 100 Or txtsportsperserv.Text > 100 Then
            MsgBox("Input  Exceeded the recquired number!")
            txtictengr.Focus()

        Else
            Dim sprtrs As Double = Double.Parse(txtsportscomserv.Text) + Double.Parse(txtsportsmili.Text) + Double.Parse(txtsportsperserv.Text)
            Dim sptot As Double = sprtrs / 300

            sportsag = sptot * avg
            Try
                c.Open()
                If c.State = ConnectionState.Open Then
                    d.SelectCommand = c.CreateCommand
                    d.SelectCommand.CommandText = "INSERT INTO sportstrack(sportsmili,sportscomserv, sportsperserv) value('" & txtsportsmili.Text & "','" & txtsportscomserv.Text & "','" & txtsportsperserv.Text & "')"
                    d.SelectCommand.ExecuteReader()
                    c.Close()
                    Dim b = MsgBox("Input will be disabled", vbOKOnly + vbReadOnly, "Warning")

                    If b = vbOK Then
                        txtsportscomserv.Enabled = False
                        txtsportsmili.Enabled = False
                        txtsportsperserv.Enabled = False

                        Dim a = MsgBox("Save data?", vbYesNo + vbQuestion, "Message")
                        If a = vbYes Then
                            MsgBox("Successfuly Saved!")
                            panelSports.Visible = False
                            panelImage.Visible = True
                            btnsportsclear.Enabled = False

                        End If

                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                c.Dispose()

            End Try
        End If
    End Sub

    Private Sub BunifuImageButton10_Click_2(sender As Object, e As EventArgs) Handles BunifuImageButton10.Click
        panelimgarts.Visible = False
        panelArts.Visible = True

    End Sub

    Private Sub BunifuThinButton222_Click(sender As Object, e As EventArgs) Handles BunifuThinButton222.Click

        If txtarts.Text = "" Or txtartsfashion.Text = "" Or txtartsmedia.Text = "" Or txtartsprofserv.Text = "" Then
            MsgBox("Fill up the empty textbox!")
            txtictengr.Focus()
        ElseIf txtarts.Text > 100 Or txtartsmedia.Text > 100 Or txtartsprofserv.Text > 100 Or txtartsfashion.Text > 100 Then
            MsgBox("Input  Exceeded the recquired number!")
            txtictengr.Focus()

        Else
            Dim ar As Double = Double.Parse(txtarts.Text) + Double.Parse(txtartsfashion.Text) + Double.Parse(txtartsmedia.Text) + Double.Parse(txtartsprofserv.Text)
            Dim artot As Double = ar / 400
            artsag = artot * avg
            Try
                c.Open()
                If c.State = ConnectionState.Open Then
                    d.SelectCommand = c.CreateCommand
                    d.SelectCommand.CommandText = "INSERT INTO artsdesigntrack(artsmedia,artsprofserv, arts, artsfashion) value('" & txtartsmedia.Text & "','" & txtartsprofserv.Text & "','" & txtarts.Text & "','" & txtartsfashion.Text & "')"
                    d.SelectCommand.ExecuteReader()
                    c.Close()
                    Dim b = MsgBox("Input will be disabled", vbOKOnly + vbReadOnly, "Warning")

                    If b = vbOK Then
                        txtartsmedia.Enabled = False
                        txtartsprofserv.Enabled = False
                        txtarts.Enabled = False
                        txtartsfashion.Enabled = False
                        Dim a = MsgBox("Save data?", vbYesNo + vbQuestion, "Message")
                        If a = vbYes Then
                            MsgBox("Successfuly Saved!")
                            panelArts.Visible = False
                            panelimgarts.Visible = True
                            btnartsclear.Enabled = False

                        End If

                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                c.Dispose()

            End Try
        End If
    End Sub

    Private Sub txtstemresult_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnhummsres_Click(sender As Object, e As EventArgs)




    End Sub

    Private Sub btnhummsres_Click_1(sender As Object, e As EventArgs) Handles btnacadres.Click

        Dim a = MsgBox("Do you want to generate the result?", vbYesNo + vbQuestion, "Message")
        If vbYes Then

            txtstemresult.Text = Math.Round(stemag, 2, MidpointRounding.ToEven)

            If txtstemresult.Text >= 76 And txtstemresult.Text <= 100 Then
                lblstemrate.Text = "HP"
            ElseIf txtstemresult.Text >= 51 And txtstemresult.Text <= 75 Then
                lblstemrate.Text = "MP"
            ElseIf txtstemresult.Text >= 26 And txtstemresult.Text <= 50 Then
                lblstemrate.Text = "LP"
            ElseIf txtstemresult.Text >= 0 And txtstemresult.Text <= 25 Then
                lblstemrate.Text = "VLP"
            End If
            txtabmresult.Text = Math.Round(abmag, 2, MidpointRounding.ToEven)
            If txtabmresult.Text >= 76 And txtabmresult.Text <= 100 Then
                lblabmrate.Text = "HP"
            ElseIf txtabmresult.Text >= 51 And txtabmresult.Text <= 75 Then
                lblabmrate.Text = "MP"
            ElseIf txtabmresult.Text >= 26 And txtabmresult.Text <= 50 Then
                lblabmrate.Text = "LP"
            ElseIf txtabmresult.Text >= 0 And txtabmresult.Text <= 25 Then
                lblabmrate.Text = "VLP"
            End If
            txthummsresult.Text = Math.Round(hummsag, 2, MidpointRounding.ToEven)
            If txthummsresult.Text >= 76 And txthummsresult.Text <= 100 Then
                lblhummsrate.Text = "HP"
            ElseIf txthummsresult.Text >= 51 And txthummsresult.Text <= 75 Then
                lblhummsrate.Text = "MP"
            ElseIf txthummsresult.Text >= 26 And txthummsresult.Text <= 50 Then
                lblhummsrate.Text = "LP"
            ElseIf txthummsresult.Text >= 0 And txthummsresult.Text <= 25 Then
                lblhummsrate.Text = "VLP"
            End If
            txtgasresult.Text = Math.Round(gasag, 2, MidpointRounding.ToEven)
            If txtgasresult.Text >= 76 And txtgasresult.Text <= 100 Then
                lblgasrate.Text = "HP"
            ElseIf txtgasresult.Text >= 51 And txtgasresult.Text <= 75 Then
                lblgasrate.Text = "MP"
            ElseIf txtgasresult.Text >= 26 And txtgasresult.Text <= 50 Then
                lblgasrate.Text = "LP"
            ElseIf txtgasresult.Text >= 0 And txtgasresult.Text <= 25 Then
                lblgasrate.Text = "VLP"
            End If

        End If
    End Sub

    Private Sub BunifuButton5_Click(sender As Object, e As EventArgs) Handles BunifuButton5.Click
        cptblty.Visible = True
        cptblty.SetPage(4)
    End Sub

    Private Sub btnacadress_Click(sender As Object, e As EventArgs) Handles btnacadress.Click
        panelres.Visible = False
        pageres.Visible = True
        pageres.SetPage(0)
    End Sub

    Private Sub btntvlress_Click(sender As Object, e As EventArgs) Handles btntvlress.Click
        panelres.Visible = False
        pageres.Visible = True
        pageres.SetPage(1)
    End Sub

    Private Sub btnstemres_Click_1(sender As Object, e As EventArgs) Handles btnstemres.Click
        panelres.Visible = False
        pageres.Visible = True
        pageres.SetPage(2)
    End Sub

    Private Sub btnartsress_Click(sender As Object, e As EventArgs) Handles btnartsress.Click
        panelres.Visible = False
        pageres.Visible = True
        pageres.SetPage(3)
    End Sub

    Private Sub btnstem_Click_1(sender As Object, e As EventArgs)
        panelAcad.Visible = False
        acad.Visible = True
        acad.SetPage(0)
    End Sub

    Private Sub btnhumms_Click_1(sender As Object, e As EventArgs)
        panelAcad.Visible = False
        acad.Visible = True
        acad.SetPage(2)
    End Sub

    Private Sub btnstem_Click_2(sender As Object, e As EventArgs) Handles btnstem.Click
        panelAcad.Visible = False
        acad.Visible = True
        acad.SetPage(0)
    End Sub

    Private Sub btnhumms_Click_2(sender As Object, e As EventArgs) Handles btnhumms.Click
        panelAcad.Visible = False
        acad.Visible = True
        acad.SetPage(2)
    End Sub

    Private Sub btngas_Click_1(sender As Object, e As EventArgs) Handles btngas.Click
        panelAcad.Visible = False
        acad.Visible = True
        acad.SetPage(3)
    End Sub

    Private Sub btnagri_Click_1(sender As Object, e As EventArgs) Handles btnagri.Click
        panelTVL.Visible = False
        pagetvl.Visible = True
        pagetvl.SetPage(0)
    End Sub

    Private Sub btnhecon_Click(sender As Object, e As EventArgs) Handles btnhecon.Click
        panelTVL.Visible = False
        pagetvl.Visible = True
        pagetvl.SetPage(1)
    End Sub

    Private Sub btnict_Click(sender As Object, e As EventArgs) Handles btnict.Click
        panelTVL.Visible = False
        pagetvl.Visible = True
        pagetvl.SetPage(2)
    End Sub

    Private Sub btnia_Click(sender As Object, e As EventArgs) Handles btnia.Click
        panelTVL.Visible = False
        pagetvl.Visible = True
        pagetvl.SetPage(3)
    End Sub

    Private Sub btnacadsave_Click(sender As Object, e As EventArgs) Handles btnacadsave.Click
        If txtstemresult.Text = "" Or txtabmresult.Text = "" Or txthummsresult.Text = "" Or txtgasresult.Text = "" Then
            MsgBox("Generate the result before saving!")
        ElseIf txtstemresult.Text > 100 Or txtabmresult.Text > 100 Or txthummsresult.Text > 100 Or txtgasresult.Text > 100 Then
            MsgBox("Result Exceeded the Over Value!")
            txtstemresult.Text = ""
            txtabmresult.Text = ""
            txthummsresult.Text = ""
            txtgasresult.Text = ""
        Else
            Try
                c.Open()
                If c.State = ConnectionState.Open Then
                    d.SelectCommand = c.CreateCommand
                    d.SelectCommand.CommandText = "INSERT INTO acadresults(stemres,abmres,hummsres,gasres) value('" & txtstemresult.Text & "','" & txtabmresult.Text & "','" & txthummsresult.Text & "','" & txtgasresult.Text & "')"
                    d.SelectCommand.ExecuteReader()
                    c.Close()
                    MsgBox("RESULT IS SAVED!")
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                c.Dispose()

            End Try

        End If
    End Sub

    Private Sub btnabm_Click_1(sender As Object, e As EventArgs) Handles btnabm.Click
        panelAcad.Visible = False
        acad.Visible = True
        acad.SetPage(1)
    End Sub

    Private Sub BunifuThinButton216_Click(sender As Object, e As EventArgs) Handles BunifuThinButton216.Click

    End Sub

    Private Sub BunifuImageButton7_Click_1(sender As Object, e As EventArgs) Handles BunifuImageButton7.Click
        Dim a = MsgBox("Go back selecting academic track offers?", vbYesNo + vbQuestion, "Message")
        If vbYes Then
            pagetvl.Visible = False
            panelTVL.Visible = True

        End If
    End Sub

    Private Sub BunifuImageButton6_Click_1(sender As Object, e As EventArgs) Handles BunifuImageButton6.Click
        Dim a = MsgBox("Go back selecting academic track offers?", vbYesNo + vbQuestion, "Message")
        If vbYes Then
            pagetvl.Visible = False
            panelTVL.Visible = True

        End If
    End Sub

    Private Sub BunifuImageButton5_Click_1(sender As Object, e As EventArgs) Handles BunifuImageButton5.Click
        Dim a = MsgBox("Go back selecting academic track offers?", vbYesNo + vbQuestion, "Message")
        If vbYes Then
            pagetvl.Visible = False
            panelTVL.Visible = True

        End If
    End Sub

    Private Sub BunifuImageButton4_Click_1(sender As Object, e As EventArgs) Handles BunifuImageButton4.Click
        Dim a = MsgBox("Go back selecting academic track offers?", vbYesNo + vbQuestion, "Message")
        If vbYes Then
            pagetvl.Visible = False
            panelTVL.Visible = True

        End If
    End Sub

    Private Sub btntvlres_Click(sender As Object, e As EventArgs) Handles btntvlres.Click
        Dim a = MsgBox("Do you want to generate the result?", vbYesNo + vbQuestion, "Message")
        If vbYes Then

            txtagrires.Text = Math.Round(agriag, 2, MidpointRounding.ToEven)
            If txtagrires.Text >= 76 And txtagrires.Text <= 100 Then
                lblagrirate.Text = "HP"
            ElseIf txtagrires.Text >= 51 And txtagrires.Text <= 75 Then
                lblagrirate.Text = "MP"
            ElseIf txtagrires.Text >= 26 And txtagrires.Text <= 50 Then
                lblagrirate.Text = "LP"
            ElseIf txtagrires.Text >= 0 And txtagrires.Text <= 25 Then
                lblagrirate.Text = "VLP"
            End If
            txthecores.Text = Math.Round(hecoag, 2, MidpointRounding.ToEven)
            If txthecores.Text >= 76 And txthecores.Text <= 100 Then
                lblhecorate.Text = "HP"
            ElseIf txthecores.Text >= 51 And txthecores.Text <= 75 Then
                lblhecorate.Text = "MP"
            ElseIf txthecores.Text >= 26 And txthecores.Text <= 50 Then
                lblhecorate.Text = "LP"
            ElseIf txthecores.Text >= 0 And txthecores.Text <= 25 Then
                lblhecorate.Text = "VLP"
            End If
            txtictres.Text = Math.Round(ictag, 2, MidpointRounding.ToEven)
            If txtictres.Text >= 76 And txtictres.Text <= 100 Then
                lblictrate.Text = "HP"
            ElseIf txtictres.Text >= 51 And txtictres.Text <= 75 Then
                lblictrate.Text = "MP"
            ElseIf txtictres.Text >= 26 And txtictres.Text <= 50 Then
                lblictrate.Text = "LP"
            ElseIf txtictres.Text >= 0 And txtictres.Text <= 25 Then
                lblictrate.Text = "VLP"
            End If
            txtiares.Text = Math.Round(iag, 2, MidpointRounding.ToEven)
            If txtiares.Text >= 76 And txtiares.Text <= 100 Then
                lbliarate.Text = "HP"
            ElseIf txtiares.Text >= 51 And txtiares.Text <= 75 Then
                lbliarate.Text = "MP"
            ElseIf txtiares.Text >= 26 And txtiares.Text <= 50 Then
                lbliarate.Text = "LP"
            ElseIf txtiares.Text >= 0 And txtiares.Text <= 25 Then
                lbliarate.Text = "VLP"
            End If

        End If

    End Sub

    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs)
        pageres.Visible = False
        panelres.Visible = True

    End Sub

    Private Sub btntvlsave_Click(sender As Object, e As EventArgs) Handles btntvlsave.Click
        If txtagrires.Text = "" Or txthecores.Text = "" Or txtictres.Text = "" Or txtiares.Text = "" Then
            MsgBox("Generate the result before saving!")
        ElseIf txtagrires.Text > 100 Or txthecores.Text > 100 Or txtictres.Text > 100 Or txtiares.Text > 100 Then
            MsgBox("Result Exceeded the Over Value!")
            txtagrires.Text = ""
            txthecores.Text = ""
            txtictres.Text = ""
            txtiares.Text = ""
        Else
            Try
                c.Open()
                If c.State = ConnectionState.Open Then
                    d.SelectCommand = c.CreateCommand
                    d.SelectCommand.CommandText = "INSERT INTO tvlresults(agrires,,hecores,ictres,iares) value('" & txtagrires.Text & "','" & txthecores.Text & "','" & txtictres.Text & "','" & txtiares.Text & "')"
                    d.SelectCommand.ExecuteReader()
                    c.Close()
                    MsgBox("RESULT IS SAVED!")
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                c.Dispose()

            End Try

        End If
    End Sub

    Private Sub BunifuFlatButton13_Click(sender As Object, e As EventArgs)
        pageres.Visible = False
        panelres.Visible = True

    End Sub

    Private Sub tvlres_Click(sender As Object, e As EventArgs) Handles tvlres.Click

    End Sub

    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles btnstemclear.Click
        txtstemarchi.Text = ""
        txtstemnatsci.Text = ""
        With txtstemsci
            .Focus()
            .Text = ""
        End With
        txtstemproserv.Text = ""
        txtstengr.Text = ""
        txtstemtech.Text = ""
    End Sub

    Private Sub BunifuThinButton25_Click(sender As Object, e As EventArgs) Handles btnabmclear.Click
        txtabmbusi.Text = ""
        txtabmbusi.Focus()

        txtabmprofserv.Text = ""
    End Sub

    Private Sub btnhummsclear_Click(sender As Object, e As EventArgs) Handles btnhummsclear.Click
        With txthummsmedia
            .Focus()
            .Text = ""
        End With
        txthummscomu.Text = ""
        txthummsarts.Text = ""
        txthummsfash.Text = ""
        txthummsmili.Text = ""
        txthummsperserv.Text = ""
        txthummsspir.Text = ""
    End Sub

    Private Sub BunifuImageButton8_Click_1(sender As Object, e As EventArgs) Handles BunifuImageButton8.Click
        panelSports.Visible = False
        panelImage.Visible = True

    End Sub

    Private Sub BunifuImageButton11_Click(sender As Object, e As EventArgs) Handles BunifuImageButton11.Click
        panelArts.Visible = False
        panelimgarts.Visible = True

    End Sub

    Private Sub BunifuImageButton12_Click(sender As Object, e As EventArgs) Handles BunifuImageButton12.Click
        Dim a = MsgBox("Check other track results?", vbYesNo + vbQuestion, "Continue")
        If a = vbYes Then
            pageres.Visible = False
            panelres.Visible = True
        End If


    End Sub

    Private Sub BunifuImageButton13_Click(sender As Object, e As EventArgs) Handles BunifuImageButton13.Click
        Dim a = MsgBox("Check other track results?", vbYesNo + vbQuestion, "Continue")
        If a = vbYes Then
            pageres.Visible = False
            panelres.Visible = True
        End If
    End Sub

    Private Sub BunifuImageButton14_Click(sender As Object, e As EventArgs) Handles BunifuImageButton14.Click
        Dim a = MsgBox("Check other track results?", vbYesNo + vbQuestion, "Continue")
        If a = vbYes Then
            pageres.Visible = False
            panelres.Visible = True
        End If
    End Sub

    Private Sub BunifuImageButton15_Click(sender As Object, e As EventArgs) Handles BunifuImageButton15.Click
        Dim a = MsgBox("Check other track results?", vbYesNo + vbQuestion, "Continue")
        If a = vbYes Then
            pageres.Visible = False
            panelres.Visible = True
        End If
    End Sub

    Private Sub btnsprtsres_Click(sender As Object, e As EventArgs) Handles btnsprtsres.Click
        Dim a = MsgBox("Do you want to generate the result?", vbYesNo + vbQuestion, "Message")
        If vbYes Then


            txtsportsres.Text = Math.Round(sportsag, 2, MidpointRounding.ToEven)
            If txtsportsres.Text >= 76 And txtsportsres.Text <= 100 Then
                lblsportsrate.Text = "HP"
            ElseIf txtsportsres.Text >= 51 And txtsportsres.Text <= 75 Then
                lblsportsrate.Text = "MP"
            ElseIf txtsportsres.Text >= 26 And txtsportsres.Text <= 50 Then
                lblsportsrate.Text = "LP"
            ElseIf txtsportsres.Text >= 0 And txtsportsres.Text <= 25 Then
                lblsportsrate.Text = "VLP"
            End If

        End If

    End Sub

    Private Sub btnsprtsve_Click(sender As Object, e As EventArgs) Handles btnsprtsve.Click
        If txtsportsres.Text = "" Then
            MsgBox("Generate the result before saving!")
        ElseIf txtsportsres.Text > 100 Then
            MsgBox("Result Exceeded the Over Value!")
            txtsportsres.Text = ""

        Else
            Try
                c.Open()
                If c.State = ConnectionState.Open Then
                    d.SelectCommand = c.CreateCommand
                    d.SelectCommand.CommandText = "INSERT INTO sportsresults(sportsres) value('" & txtsportsres.Text & "')"
                    d.SelectCommand.ExecuteReader()
                    c.Close()
                    MsgBox("RESULT IS SAVED!")
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                c.Dispose()

            End Try

        End If
    End Sub

    Private Sub btnartsve_Click(sender As Object, e As EventArgs) Handles btnartsve.Click
        If txtartsres.Text = "" Or
            MsgBox("Generate the result before saving!") Then
        ElseIf txtartsres.Text > 100 Then
            MsgBox("Result Exceeded the Over Value!")
            txtsportsres.Text = ""

        Else
            Try
                c.Open()
                If c.State = ConnectionState.Open Then
                    d.SelectCommand = c.CreateCommand
                    d.SelectCommand.CommandText = "INSERT INTO artsresult(artsress) value('" & txtartsres.Text & "')"
                    d.SelectCommand.ExecuteReader()
                    c.Close()
                    MsgBox("RESULT IS SAVED!")
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                c.Dispose()

            End Try

        End If
    End Sub

    Private Sub btnartsres_Click(sender As Object, e As EventArgs) Handles btnartsres.Click
        Dim a = MsgBox("Do you want to generate the result?", vbYesNo + vbQuestion, "Message")
        If a = vbYes Then
            txtartsres.Text = Math.Round(artsag, 2, MidpointRounding.ToEven)
            If txtartsres.Text >= 76 And txtartsres.Text <= 100 Then
                lblartsres.Text = "HP"
            ElseIf txtartsres.Text >= 51 And txtartsres.Text <= 75 Then
                lblartsres.Text = "MP"
            ElseIf txtartsres.Text >= 26 And txtartsres.Text <= 50 Then
                lblartsres.Text = "LP"
            ElseIf txtartsres.Text >= 0 And txtartsres.Text <= 25 Then
                lblartsres.Text = "VLP"
            End If
        End If
    End Sub

    Private Sub Label22_Click(sender As Object, e As EventArgs) Handles Label22.Click

    End Sub

    Private Sub BunifuThinButton213_Click(sender As Object, e As EventArgs) Handles BunifuThinButton213.Click

    End Sub

    Private Sub Label35_Click(sender As Object, e As EventArgs) Handles Label35.Click

    End Sub

    Private Sub Label34_Click(sender As Object, e As EventArgs) Handles Label34.Click

    End Sub

    Private Sub txthecoperserv_TextChanged(sender As Object, e As EventArgs) Handles txthecoperserv.TextChanged

    End Sub

    Private Sub Label36_Click(sender As Object, e As EventArgs) Handles Label36.Click

    End Sub

    Private Sub txthecocomserv_TextChanged(sender As Object, e As EventArgs) Handles txthecocomserv.TextChanged

    End Sub

    Private Sub txthecofash_TextChanged(sender As Object, e As EventArgs) Handles txthecofash.TextChanged

    End Sub

    Private Sub GunaTextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtartsmedia.KeyPress

    End Sub

    Private Sub Label46_Click(sender As Object, e As EventArgs) Handles Label46.Click

    End Sub

    Private Sub txtictres_TextChanged(sender As Object, e As EventArgs) Handles txtictres.TextChanged

    End Sub
End Class