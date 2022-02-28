Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions
Public Class login
    Dim c As New MySqlConnection
    Dim d As New MySqlDataAdapter
    Dim cm As New MySqlCommand
    Dim dr As MySqlDataReader
    Dim ex As MySqlException
    Dim s As New DataSet
    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        c.ConnectionString = "server=localhost; user=root; password=1234; database=supportsys; port= 3307"

    End Sub




    Private Sub BunifuButton2_Click(sender As Object, e As EventArgs) Handles BunifuButton2.Click
        BunifuPages1.SetPage(1)
    End Sub




    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles BunifuButton1.Click
        BunifuPages1.SetPage(0)
    End Sub



    Private Sub BunifuCheckbox1_OnChange(sender As Object, e As EventArgs) Handles BunifuCheckbox1.OnChange
        If BunifuCheckbox1.Checked = True Then
            txtpass.PasswordChar = ""
        Else
            txtpass.PasswordChar = "●"
        End If
    End Sub

    Private Sub BunifuButton4_Click(sender As Object, e As EventArgs) Handles signup.Click
        If txtfname.Text = "" And txtlname.Text = "" And txtregemail.Text = "" And txtreguser.Text = "" And txtregpass.Text = "" And txtchkpass.Text = "" And txtphone.Text = "" Then
            MsgBox("Enter an input!")
            txtfname.Focus()
        Else
            If txtregpass.Text = txtchkpass.Text Then


                Try
                    c.Open()
                    Dim q As String
                    Dim q2 As String
                    q = "SELECT *FROM userinfo where uname='" & txtregemail.Text & "' and pword='" & txtregpass.Text & "'"
                    cm = New MySqlCommand(q, c)
                    dr = cm.ExecuteReader

                    Dim ctr As Integer = 0
                    While dr.Read
                        ctr += 1
                    End While
                    If ctr = 1 Then
                        MsgBox("User Already exist")
                        txtregemail.Focus()
                        c.Dispose()
                        dr.Close()
                    Else
                        c.Close()
                        c.Open()
                        q2 = "INSERT into userinfo(uname,pword,email,fname,lname,phonenum) value('" & txtreguser.Text & "', '" & txtregpass.Text & "','" & txtregemail.Text & "','" & txtfname.Text & "','" & txtlname.Text & "',' " & txtphone.Text & "')"
                        cm = New MySqlCommand(q2, c)
                        dr = cm.ExecuteReader
                        MsgBox("You are registerd")
                        Dim a = MsgBox("Go to signin session?", vbYesNo + vbQuestion, "Successfully Registered")
                        If a = vbYes Then
                            BunifuPages1.SetPage(0)
                        End If
                    End If



                Catch ex As Exception
                    MsgBox(ex.ToString)
                Finally
                    c.Dispose()
                End Try
            Else
                MsgBox("Password Mismatch!")
                txtregpass.Focus()

            End If


        End If






    End Sub

    Private Sub tnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        If txtuser.Text = "" Or txtpass.Text = "" Then
            MsgBox("Enter Username/Password")
            txtuser.Focus()

        Else


            Try
                c.Open()
                Dim q As String
                Dim fname As String
                Dim lname As String
                q = "Select *FROM userinfo where uname='" & txtuser.Text & "' and pword='" & txtpass.Text & "'"
                cm = New MySqlCommand(q, c)
                dr = cm.ExecuteReader
                Dim ctr As Integer = 0
                While dr.Read
                    ctr += 1
                End While
                If ctr = 1 Then
                    With dr
                        .Read()
                        fname = .Item("fname")
                        lname = .Item("lname")
                    End With
                    MsgBox("Welcome " + fname + " " + lname)
                    index.Show()
                    Me.Close()
                Else
                    MsgBox("Invalid Password/Username")
                    txtpass.Clear()
                    txtuser.Focus()


                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                c.Dispose()


            End Try

        End If

    End Sub

    Private Sub BunifuCheckbox2_OnChange(sender As Object, e As EventArgs) Handles BunifuCheckbox2.OnChange
        If BunifuCheckbox2.Checked = True Then
            txtregpass.PasswordChar = ""
            txtchkpass.PasswordChar = ""
        Else
            txtregpass.PasswordChar = "●"
            txtchkpass.PasswordChar = "●"
        End If
    End Sub



    Private Sub txtregpass_GotFocus(sender As Object, e As EventArgs) Handles txtregpass.GotFocus

    End Sub



    Private Sub txtchkpass_GotFocus(sender As Object, e As EventArgs) Handles txtchkpass.GotFocus

    End Sub



    Private Sub txtpass_GotFocus(sender As Object, e As EventArgs) Handles txtpass.GotFocus

    End Sub

    Private Sub BunifuSeparator3_Load(sender As Object, e As EventArgs) Handles BunifuSeparator3.Load

    End Sub

    Private Sub txtregemail_TextChanged(sender As Object, e As EventArgs) Handles txtregemail.TextChanged
        Dim p As Regex = New Regex("^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z]*@[0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$")
        Dim isValid As Boolean = p.IsMatch(txtregemail.Text.Trim)
        If txtregemail.Text = "" Then
            lblinvalid.Visible = False
            imginvalid.Visible = False
            lblvalid.Visible = False
            imgvalid.Visible = False
        Else
            If isValid Then
                lblvalid.Visible = True
                imgvalid.Visible = True
                lblinvalid.Visible = False
                imginvalid.Visible = False

            Else
                lblinvalid.Visible = True
                imginvalid.Visible = True
                lblvalid.Visible = False
                imgvalid.Visible = False


            End If

        End If

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles imgvalid.Click

    End Sub
    Public Sub phoneisValid()

    End Sub
    Private Sub txtphone_TextChanged(sender As Object, e As EventArgs) Handles txtphone.TextChanged
        Dim p As Regex = New Regex("^(09|\+639)\d{9}$")
        Dim isValid As Boolean = p.IsMatch(txtphone.Text.Trim)

        If txtphone.Text = "" Then
            lblnuminvalid.Visible = False
            imgnuminvalid.Visible = False
            imgnuminvalid.Visible = False
            lblnumvalid.Visible = False
            imgnumvalid.Visible = False
        Else
            If isValid Then

                lblnumvalid.Visible = True
                imgnumvalid.Visible = True
                lblnuminvalid.Visible = False
                imgnuminvalid.Visible = False


            Else

                lblnuminvalid.Visible = True
                imgnuminvalid.Visible = True
                lblnumvalid.Visible = False
                imgnumvalid.Visible = False


            End If

        End If

    End Sub

    Private Sub txtregpass_TextChanged(sender As Object, e As EventArgs) Handles txtregpass.TextChanged

    End Sub

    Private Sub txtpass_TextChanged(sender As Object, e As EventArgs) Handles txtpass.TextChanged

    End Sub

    Private Sub txtchkpass_TextChanged(sender As Object, e As EventArgs) Handles txtchkpass.TextChanged

    End Sub

    Private Sub BunifuButton3_Click(sender As Object, e As EventArgs) Handles btnchkemail.Click
        Dim p As Regex = New Regex("^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z]*@[0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$")
        Dim isValid As Boolean = p.IsMatch(txtregemail.Text.Trim)

        Try
            c.Open()

            Dim qemail As String

            qemail = "Select *from userinfo where email='" & txtregemail.Text & "'"

            cm = New MySqlCommand(qemail, c)
            dr = cm.ExecuteReader


            Dim ctr As Integer = 0
            While dr.Read
                ctr += 1
            End While
            If ctr = 1 Then
                MsgBox("Email Already Exist!")
                With txtregemail
                    .Clear()
                    .Focus()

                End With
                c.Dispose()
                dr.Close()
            Else
                If isValid = True Then
                    MsgBox("Emaill is Valid")
                    BunifuButton3.Visible = False

                    signup.Visible = True
                Else
                    MsgBox("Email is invalid")
                    BunifuButton3.Visible = True
                    signup.Visible = False

                End If



            End If


        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally


            c.Dispose()


        End Try



    End Sub

    Private Sub btnchckphone_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BunifuButton3_Click_1(sender As Object, e As EventArgs) Handles BunifuButton3.Click
        Dim p As Regex = New Regex("^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z]*@[0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$")
        Dim isValid As Boolean = p.IsMatch(txtregemail.Text.Trim)
        Dim s As Regex = New Regex("^(09|\+639)\d{9}$")
        Dim pnumisValid As Boolean = s.IsMatch(txtphone.Text.Trim)
        If txtfname.Text = "" And txtlname.Text = "" And txtregemail.Text = "" And txtreguser.Text = "" And txtregpass.Text = "" And txtchkpass.Text = "" And txtphone.Text = "" Then
            MsgBox("Enter an input!")
            txtfname.Focus()
        Else
            If txtreguser.Text = "" Then
                MsgBox("Enter Username")
                txtreguser.Focus()
            Else
                Try
                    c.Open()
                    Dim quser As String
                    Dim username As String
                    quser = "SELECT *from userinfo where uname='" & txtreguser.Text & "'"
                    cm = New MySqlCommand(quser, c)
                    dr = cm.ExecuteReader


                    Dim ctr As String = 0
                    While dr.Read
                        ctr += 1

                    End While
                    If ctr = 1 Then
                        With dr
                            .Read()
                            username = .Item("uname")
                        End With
                        MsgBox("The username " + username + " is already existing")
                        With txtreguser
                            .Clear()
                            .Focus()

                        End With
                    End If
                Catch ex As Exception
                    MsgBox(ex.ToString)
                Finally
                    c.Dispose()

                End Try
            End If
            If txtphone.Text = "" Then
                MsgBox("Put your Mobile No.")
                txtphone.Focus()
            Else
                If pnumisValid = False Then
                    MsgBox("Check Phone No. Format!")
                    With txtphone
                        .Clear()
                        .Focus()
                    End With

                Else


                End If


            End If
            If txtregemail.Text = "" Then
                MsgBox("Enter your E-mail Address")
                txtregemail.Focus()
            Else

                If isValid = False Then
                    MsgBox("Check Email Format!")
                    With txtregemail
                        .Clear()
                        .Focus()
                    End With
                Else
                    MsgBox("Please check if the email is already used")
                End If

            End If

        End If





    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        Dim a = MsgBox("Exit the application?", vbYesNo + vbQuestion, "Exit")
        If vbYes Then
            Application.Exit()

        End If
    End Sub
End Class

