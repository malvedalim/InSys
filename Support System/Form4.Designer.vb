<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim Animation1 As Utilities.BunifuPages.BunifuAnimatorNS.Animation = New Utilities.BunifuPages.BunifuAnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.pagesarts = New Bunifu.UI.WinForms.BunifuPages()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.BunifuFlatButton1 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.BunifuFlatButton5 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BunifuFlatButton4 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BunifuCustomLabel22 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel23 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel24 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel25 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel26 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel27 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel28 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel29 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuFlatButton3 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton2 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.BunifuFlatButton24 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton26 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.ListBox4 = New System.Windows.Forms.ListBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.panelartsimg = New System.Windows.Forms.Panel()
        Me.btnstemres = New Bunifu.Framework.UI.BunifuTileButton()
        Me.BunifuCustomLabel13 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.panelarts = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnback = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuThinButton23 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuThinButton22 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuThinButton21 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.pagesarts.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.panelartsimg.SuspendLayout()
        Me.panelarts.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnback, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pagesarts
        '
        Me.pagesarts.Alignment = System.Windows.Forms.TabAlignment.Bottom
        Me.pagesarts.AllowTransitions = True
        Me.pagesarts.Controls.Add(Me.TabPage2)
        Me.pagesarts.Controls.Add(Me.TabPage3)
        Me.pagesarts.Controls.Add(Me.TabPage1)
        Me.pagesarts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pagesarts.Location = New System.Drawing.Point(0, 0)
        Me.pagesarts.Multiline = True
        Me.pagesarts.Name = "pagesarts"
        Me.pagesarts.Page = Me.TabPage1
        Me.pagesarts.PageIndex = 2
        Me.pagesarts.PageName = "TabPage1"
        Me.pagesarts.PageTitle = "TabPage1"
        Me.pagesarts.SelectedIndex = 0
        Me.pagesarts.Size = New System.Drawing.Size(1010, 589)
        Me.pagesarts.TabIndex = 78
        Animation1.AnimateOnlyDifferences = False
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 0
        Animation1.Padding = New System.Windows.Forms.Padding(0)
        Animation1.RotateCoeff = 0!
        Animation1.RotateLimit = 0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 0!
        Animation1.TransparencyCoeff = 0!
        Me.pagesarts.Transition = Animation1
        Me.pagesarts.TransitionType = Utilities.BunifuPages.BunifuAnimatorNS.AnimationType.Custom
        Me.pagesarts.Visible = False
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.BunifuFlatButton1)
        Me.TabPage2.Controls.Add(Me.RichTextBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1002, 560)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'BunifuFlatButton1
        '
        Me.BunifuFlatButton1.Active = False
        Me.BunifuFlatButton1.Activecolor = System.Drawing.Color.Red
        Me.BunifuFlatButton1.BackColor = System.Drawing.Color.Maroon
        Me.BunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton1.BorderRadius = 0
        Me.BunifuFlatButton1.ButtonText = "Back"
        Me.BunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.Iconimage = Nothing
        Me.BunifuFlatButton1.Iconimage_right = Nothing
        Me.BunifuFlatButton1.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton1.Iconimage_Selected = Nothing
        Me.BunifuFlatButton1.IconMarginLeft = 0
        Me.BunifuFlatButton1.IconMarginRight = 0
        Me.BunifuFlatButton1.IconRightVisible = False
        Me.BunifuFlatButton1.IconRightZoom = 0R
        Me.BunifuFlatButton1.IconVisible = False
        Me.BunifuFlatButton1.IconZoom = 90.0R
        Me.BunifuFlatButton1.IsTab = False
        Me.BunifuFlatButton1.Location = New System.Drawing.Point(770, 493)
        Me.BunifuFlatButton1.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuFlatButton1.Name = "BunifuFlatButton1"
        Me.BunifuFlatButton1.Normalcolor = System.Drawing.Color.Maroon
        Me.BunifuFlatButton1.OnHovercolor = System.Drawing.Color.DarkRed
        Me.BunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton1.selected = False
        Me.BunifuFlatButton1.Size = New System.Drawing.Size(121, 33)
        Me.BunifuFlatButton1.TabIndex = 4
        Me.BunifuFlatButton1.Text = "Back"
        Me.BunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton1.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton1.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Font = New System.Drawing.Font("Courier New", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.ForeColor = System.Drawing.Color.DarkRed
        Me.RichTextBox1.Location = New System.Drawing.Point(31, 106)
        Me.RichTextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(944, 341)
        Me.RichTextBox1.TabIndex = 3
        Me.RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        Me.RichTextBox1.ZoomFactor = 2.0!
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.BunifuFlatButton5)
        Me.TabPage3.Controls.Add(Me.GroupBox3)
        Me.TabPage3.Controls.Add(Me.GroupBox2)
        Me.TabPage3.Controls.Add(Me.BunifuFlatButton4)
        Me.TabPage3.Controls.Add(Me.GroupBox1)
        Me.TabPage3.Controls.Add(Me.BunifuFlatButton3)
        Me.TabPage3.Controls.Add(Me.BunifuFlatButton2)
        Me.TabPage3.Location = New System.Drawing.Point(4, 4)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(1002, 560)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "TabPage3"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'BunifuFlatButton5
        '
        Me.BunifuFlatButton5.Active = False
        Me.BunifuFlatButton5.Activecolor = System.Drawing.Color.Red
        Me.BunifuFlatButton5.BackColor = System.Drawing.Color.Maroon
        Me.BunifuFlatButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton5.BorderRadius = 0
        Me.BunifuFlatButton5.ButtonText = "Back"
        Me.BunifuFlatButton5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton5.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton5.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton5.Iconimage = Nothing
        Me.BunifuFlatButton5.Iconimage_right = Nothing
        Me.BunifuFlatButton5.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton5.Iconimage_Selected = Nothing
        Me.BunifuFlatButton5.IconMarginLeft = 0
        Me.BunifuFlatButton5.IconMarginRight = 0
        Me.BunifuFlatButton5.IconRightVisible = False
        Me.BunifuFlatButton5.IconRightZoom = 0R
        Me.BunifuFlatButton5.IconVisible = False
        Me.BunifuFlatButton5.IconZoom = 90.0R
        Me.BunifuFlatButton5.IsTab = False
        Me.BunifuFlatButton5.Location = New System.Drawing.Point(774, 489)
        Me.BunifuFlatButton5.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuFlatButton5.Name = "BunifuFlatButton5"
        Me.BunifuFlatButton5.Normalcolor = System.Drawing.Color.Maroon
        Me.BunifuFlatButton5.OnHovercolor = System.Drawing.Color.DarkRed
        Me.BunifuFlatButton5.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton5.selected = False
        Me.BunifuFlatButton5.Size = New System.Drawing.Size(121, 33)
        Me.BunifuFlatButton5.TabIndex = 15
        Me.BunifuFlatButton5.Text = "Back"
        Me.BunifuFlatButton5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton5.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton5.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'GroupBox3
        '
        Me.GroupBox3.Location = New System.Drawing.Point(657, 116)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(238, 364)
        Me.GroupBox3.TabIndex = 14
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(383, 116)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(238, 364)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Visible = False
        '
        'BunifuFlatButton4
        '
        Me.BunifuFlatButton4.Active = False
        Me.BunifuFlatButton4.Activecolor = System.Drawing.Color.Red
        Me.BunifuFlatButton4.BackColor = System.Drawing.Color.Maroon
        Me.BunifuFlatButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton4.BorderRadius = 0
        Me.BunifuFlatButton4.ButtonText = "Applied Subjects"
        Me.BunifuFlatButton4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton4.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton4.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton4.Iconimage = Nothing
        Me.BunifuFlatButton4.Iconimage_right = Nothing
        Me.BunifuFlatButton4.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton4.Iconimage_Selected = Nothing
        Me.BunifuFlatButton4.IconMarginLeft = 0
        Me.BunifuFlatButton4.IconMarginRight = 0
        Me.BunifuFlatButton4.IconRightVisible = False
        Me.BunifuFlatButton4.IconRightZoom = 0R
        Me.BunifuFlatButton4.IconVisible = False
        Me.BunifuFlatButton4.IconZoom = 90.0R
        Me.BunifuFlatButton4.IsTab = False
        Me.BunifuFlatButton4.Location = New System.Drawing.Point(406, 39)
        Me.BunifuFlatButton4.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuFlatButton4.Name = "BunifuFlatButton4"
        Me.BunifuFlatButton4.Normalcolor = System.Drawing.Color.Maroon
        Me.BunifuFlatButton4.OnHovercolor = System.Drawing.Color.DarkRed
        Me.BunifuFlatButton4.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton4.selected = False
        Me.BunifuFlatButton4.Size = New System.Drawing.Size(178, 51)
        Me.BunifuFlatButton4.TabIndex = 13
        Me.BunifuFlatButton4.Text = "Applied Subjects"
        Me.BunifuFlatButton4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton4.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton4.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BunifuCustomLabel22)
        Me.GroupBox1.Controls.Add(Me.BunifuCustomLabel23)
        Me.GroupBox1.Controls.Add(Me.BunifuCustomLabel24)
        Me.GroupBox1.Controls.Add(Me.BunifuCustomLabel25)
        Me.GroupBox1.Controls.Add(Me.BunifuCustomLabel26)
        Me.GroupBox1.Controls.Add(Me.BunifuCustomLabel27)
        Me.GroupBox1.Controls.Add(Me.BunifuCustomLabel28)
        Me.GroupBox1.Controls.Add(Me.BunifuCustomLabel29)
        Me.GroupBox1.Location = New System.Drawing.Point(108, 116)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(238, 364)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Visible = False
        '
        'BunifuCustomLabel22
        '
        Me.BunifuCustomLabel22.AutoSize = True
        Me.BunifuCustomLabel22.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel22.ForeColor = System.Drawing.Color.DarkRed
        Me.BunifuCustomLabel22.Location = New System.Drawing.Point(33, 278)
        Me.BunifuCustomLabel22.Name = "BunifuCustomLabel22"
        Me.BunifuCustomLabel22.Size = New System.Drawing.Size(171, 17)
        Me.BunifuCustomLabel22.TabIndex = 48
        Me.BunifuCustomLabel22.Text = "Introduction to Philosophy"
        '
        'BunifuCustomLabel23
        '
        Me.BunifuCustomLabel23.AutoSize = True
        Me.BunifuCustomLabel23.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel23.ForeColor = System.Drawing.Color.DarkRed
        Me.BunifuCustomLabel23.Location = New System.Drawing.Point(33, 170)
        Me.BunifuCustomLabel23.Name = "BunifuCustomLabel23"
        Me.BunifuCustomLabel23.Size = New System.Drawing.Size(162, 17)
        Me.BunifuCustomLabel23.TabIndex = 43
        Me.BunifuCustomLabel23.Text = "Statistics and Probability"
        '
        'BunifuCustomLabel24
        '
        Me.BunifuCustomLabel24.AutoSize = True
        Me.BunifuCustomLabel24.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel24.ForeColor = System.Drawing.Color.DarkRed
        Me.BunifuCustomLabel24.Location = New System.Drawing.Point(33, 314)
        Me.BunifuCustomLabel24.Name = "BunifuCustomLabel24"
        Me.BunifuCustomLabel24.Size = New System.Drawing.Size(151, 17)
        Me.BunifuCustomLabel24.TabIndex = 47
        Me.BunifuCustomLabel24.Text = "Earth and Life Science"
        '
        'BunifuCustomLabel25
        '
        Me.BunifuCustomLabel25.AutoSize = True
        Me.BunifuCustomLabel25.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel25.ForeColor = System.Drawing.Color.DarkRed
        Me.BunifuCustomLabel25.Location = New System.Drawing.Point(33, 34)
        Me.BunifuCustomLabel25.Name = "BunifuCustomLabel25"
        Me.BunifuCustomLabel25.Size = New System.Drawing.Size(135, 17)
        Me.BunifuCustomLabel25.TabIndex = 41
        Me.BunifuCustomLabel25.Text = "Oral Communication"
        '
        'BunifuCustomLabel26
        '
        Me.BunifuCustomLabel26.AutoSize = True
        Me.BunifuCustomLabel26.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel26.ForeColor = System.Drawing.Color.DarkRed
        Me.BunifuCustomLabel26.Location = New System.Drawing.Point(33, 242)
        Me.BunifuCustomLabel26.Name = "BunifuCustomLabel26"
        Me.BunifuCustomLabel26.Size = New System.Drawing.Size(151, 17)
        Me.BunifuCustomLabel26.TabIndex = 46
        Me.BunifuCustomLabel26.Text = "Personal Development"
        '
        'BunifuCustomLabel27
        '
        Me.BunifuCustomLabel27.AutoSize = True
        Me.BunifuCustomLabel27.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel27.ForeColor = System.Drawing.Color.DarkRed
        Me.BunifuCustomLabel27.Location = New System.Drawing.Point(33, 70)
        Me.BunifuCustomLabel27.Name = "BunifuCustomLabel27"
        Me.BunifuCustomLabel27.Size = New System.Drawing.Size(142, 17)
        Me.BunifuCustomLabel27.TabIndex = 42
        Me.BunifuCustomLabel27.Text = "General Mathematics"
        '
        'BunifuCustomLabel28
        '
        Me.BunifuCustomLabel28.AutoSize = True
        Me.BunifuCustomLabel28.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel28.ForeColor = System.Drawing.Color.DarkRed
        Me.BunifuCustomLabel28.Location = New System.Drawing.Point(33, 206)
        Me.BunifuCustomLabel28.Name = "BunifuCustomLabel28"
        Me.BunifuCustomLabel28.Size = New System.Drawing.Size(173, 17)
        Me.BunifuCustomLabel28.TabIndex = 45
        Me.BunifuCustomLabel28.Text = "Reading and Writing Skills"
        '
        'BunifuCustomLabel29
        '
        Me.BunifuCustomLabel29.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel29.ForeColor = System.Drawing.Color.DarkRed
        Me.BunifuCustomLabel29.Location = New System.Drawing.Point(33, 106)
        Me.BunifuCustomLabel29.Name = "BunifuCustomLabel29"
        Me.BunifuCustomLabel29.Size = New System.Drawing.Size(154, 45)
        Me.BunifuCustomLabel29.TabIndex = 44
        Me.BunifuCustomLabel29.Text = "Understand Culture, Society and Politics"
        '
        'BunifuFlatButton3
        '
        Me.BunifuFlatButton3.Active = False
        Me.BunifuFlatButton3.Activecolor = System.Drawing.Color.Red
        Me.BunifuFlatButton3.BackColor = System.Drawing.Color.Maroon
        Me.BunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton3.BorderRadius = 0
        Me.BunifuFlatButton3.ButtonText = "Specialized Subjects"
        Me.BunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton3.Iconimage = Nothing
        Me.BunifuFlatButton3.Iconimage_right = Nothing
        Me.BunifuFlatButton3.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton3.Iconimage_Selected = Nothing
        Me.BunifuFlatButton3.IconMarginLeft = 0
        Me.BunifuFlatButton3.IconMarginRight = 0
        Me.BunifuFlatButton3.IconRightVisible = False
        Me.BunifuFlatButton3.IconRightZoom = 0R
        Me.BunifuFlatButton3.IconVisible = False
        Me.BunifuFlatButton3.IconZoom = 90.0R
        Me.BunifuFlatButton3.IsTab = False
        Me.BunifuFlatButton3.Location = New System.Drawing.Point(689, 39)
        Me.BunifuFlatButton3.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuFlatButton3.Name = "BunifuFlatButton3"
        Me.BunifuFlatButton3.Normalcolor = System.Drawing.Color.Maroon
        Me.BunifuFlatButton3.OnHovercolor = System.Drawing.Color.DarkRed
        Me.BunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton3.selected = False
        Me.BunifuFlatButton3.Size = New System.Drawing.Size(178, 51)
        Me.BunifuFlatButton3.TabIndex = 10
        Me.BunifuFlatButton3.Text = "Specialized Subjects"
        Me.BunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton3.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton3.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuFlatButton2
        '
        Me.BunifuFlatButton2.Active = False
        Me.BunifuFlatButton2.Activecolor = System.Drawing.Color.Red
        Me.BunifuFlatButton2.BackColor = System.Drawing.Color.Maroon
        Me.BunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton2.BorderRadius = 0
        Me.BunifuFlatButton2.ButtonText = "Core Subjects"
        Me.BunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton2.Iconimage = Nothing
        Me.BunifuFlatButton2.Iconimage_right = Nothing
        Me.BunifuFlatButton2.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton2.Iconimage_Selected = Nothing
        Me.BunifuFlatButton2.IconMarginLeft = 0
        Me.BunifuFlatButton2.IconMarginRight = 0
        Me.BunifuFlatButton2.IconRightVisible = False
        Me.BunifuFlatButton2.IconRightZoom = 0R
        Me.BunifuFlatButton2.IconVisible = False
        Me.BunifuFlatButton2.IconZoom = 90.0R
        Me.BunifuFlatButton2.IsTab = False
        Me.BunifuFlatButton2.Location = New System.Drawing.Point(149, 39)
        Me.BunifuFlatButton2.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuFlatButton2.Name = "BunifuFlatButton2"
        Me.BunifuFlatButton2.Normalcolor = System.Drawing.Color.Maroon
        Me.BunifuFlatButton2.OnHovercolor = System.Drawing.Color.DarkRed
        Me.BunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton2.selected = False
        Me.BunifuFlatButton2.Size = New System.Drawing.Size(178, 51)
        Me.BunifuFlatButton2.TabIndex = 9
        Me.BunifuFlatButton2.Text = "Core Subjects"
        Me.BunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton2.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton2.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.BunifuFlatButton24)
        Me.TabPage1.Controls.Add(Me.BunifuFlatButton26)
        Me.TabPage1.Controls.Add(Me.ListBox4)
        Me.TabPage1.Controls.Add(Me.Panel4)
        Me.TabPage1.Location = New System.Drawing.Point(4, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1002, 560)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'BunifuFlatButton24
        '
        Me.BunifuFlatButton24.Active = False
        Me.BunifuFlatButton24.Activecolor = System.Drawing.Color.Red
        Me.BunifuFlatButton24.BackColor = System.Drawing.Color.Maroon
        Me.BunifuFlatButton24.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton24.BorderRadius = 0
        Me.BunifuFlatButton24.ButtonText = "Back"
        Me.BunifuFlatButton24.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton24.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton24.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton24.Iconimage = Nothing
        Me.BunifuFlatButton24.Iconimage_right = Nothing
        Me.BunifuFlatButton24.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton24.Iconimage_Selected = Nothing
        Me.BunifuFlatButton24.IconMarginLeft = 0
        Me.BunifuFlatButton24.IconMarginRight = 0
        Me.BunifuFlatButton24.IconRightVisible = False
        Me.BunifuFlatButton24.IconRightZoom = 0R
        Me.BunifuFlatButton24.IconVisible = False
        Me.BunifuFlatButton24.IconZoom = 90.0R
        Me.BunifuFlatButton24.IsTab = False
        Me.BunifuFlatButton24.Location = New System.Drawing.Point(809, 479)
        Me.BunifuFlatButton24.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuFlatButton24.Name = "BunifuFlatButton24"
        Me.BunifuFlatButton24.Normalcolor = System.Drawing.Color.Maroon
        Me.BunifuFlatButton24.OnHovercolor = System.Drawing.Color.DarkRed
        Me.BunifuFlatButton24.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton24.selected = False
        Me.BunifuFlatButton24.Size = New System.Drawing.Size(121, 33)
        Me.BunifuFlatButton24.TabIndex = 32
        Me.BunifuFlatButton24.Text = "Back"
        Me.BunifuFlatButton24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton24.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton24.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuFlatButton26
        '
        Me.BunifuFlatButton26.Active = False
        Me.BunifuFlatButton26.Activecolor = System.Drawing.Color.Red
        Me.BunifuFlatButton26.BackColor = System.Drawing.Color.Maroon
        Me.BunifuFlatButton26.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton26.BorderRadius = 0
        Me.BunifuFlatButton26.ButtonText = "Growth Rate"
        Me.BunifuFlatButton26.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton26.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton26.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton26.Iconimage = Nothing
        Me.BunifuFlatButton26.Iconimage_right = Nothing
        Me.BunifuFlatButton26.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton26.Iconimage_Selected = Nothing
        Me.BunifuFlatButton26.IconMarginLeft = 0
        Me.BunifuFlatButton26.IconMarginRight = 0
        Me.BunifuFlatButton26.IconRightVisible = False
        Me.BunifuFlatButton26.IconRightZoom = 0R
        Me.BunifuFlatButton26.IconVisible = False
        Me.BunifuFlatButton26.IconZoom = 90.0R
        Me.BunifuFlatButton26.IsTab = False
        Me.BunifuFlatButton26.Location = New System.Drawing.Point(809, 423)
        Me.BunifuFlatButton26.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuFlatButton26.Name = "BunifuFlatButton26"
        Me.BunifuFlatButton26.Normalcolor = System.Drawing.Color.Maroon
        Me.BunifuFlatButton26.OnHovercolor = System.Drawing.Color.DarkRed
        Me.BunifuFlatButton26.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton26.selected = False
        Me.BunifuFlatButton26.Size = New System.Drawing.Size(121, 33)
        Me.BunifuFlatButton26.TabIndex = 34
        Me.BunifuFlatButton26.Text = "Growth Rate"
        Me.BunifuFlatButton26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton26.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton26.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'ListBox4
        '
        Me.ListBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox4.ForeColor = System.Drawing.Color.DarkRed
        Me.ListBox4.FormattingEnabled = True
        Me.ListBox4.ItemHeight = 31
        Me.ListBox4.Items.AddRange(New Object() {"•ENGINEER", "•TEACHER", "•ACCOUNTANT", "•PSYCHOLOGIST", "•ARCHITECT", "•POLICE"})
        Me.ListBox4.Location = New System.Drawing.Point(3, 74)
        Me.ListBox4.Name = "ListBox4"
        Me.ListBox4.Size = New System.Drawing.Size(996, 483)
        Me.ListBox4.TabIndex = 35
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.BunifuCustomLabel2)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(3, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(996, 71)
        Me.Panel4.TabIndex = 33
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Courier New", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.ForeColor = System.Drawing.Color.Maroon
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(183, 4)
        Me.BunifuCustomLabel2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(569, 67)
        Me.BunifuCustomLabel2.TabIndex = 19
        Me.BunifuCustomLabel2.Text = "ARTS AND DESIGN"
        '
        'panelartsimg
        '
        Me.panelartsimg.Controls.Add(Me.btnstemres)
        Me.panelartsimg.Controls.Add(Me.BunifuCustomLabel13)
        Me.panelartsimg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelartsimg.Location = New System.Drawing.Point(0, 0)
        Me.panelartsimg.Name = "panelartsimg"
        Me.panelartsimg.Size = New System.Drawing.Size(1010, 589)
        Me.panelartsimg.TabIndex = 79
        '
        'btnstemres
        '
        Me.btnstemres.BackColor = System.Drawing.Color.Transparent
        Me.btnstemres.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.btnstemres.color = System.Drawing.Color.Transparent
        Me.btnstemres.colorActive = System.Drawing.Color.LightGray
        Me.btnstemres.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnstemres.Font = New System.Drawing.Font("Courier New", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnstemres.ForeColor = System.Drawing.Color.Maroon
        Me.btnstemres.Image = Global.Support_System.My.Resources.Resources.artss1
        Me.btnstemres.ImagePosition = 4
        Me.btnstemres.ImageZoom = 50
        Me.btnstemres.LabelPosition = 20
        Me.btnstemres.LabelText = ""
        Me.btnstemres.Location = New System.Drawing.Point(317, 230)
        Me.btnstemres.Margin = New System.Windows.Forms.Padding(9, 7, 9, 7)
        Me.btnstemres.Name = "btnstemres"
        Me.btnstemres.Size = New System.Drawing.Size(277, 157)
        Me.btnstemres.TabIndex = 21
        '
        'BunifuCustomLabel13
        '
        Me.BunifuCustomLabel13.AutoSize = True
        Me.BunifuCustomLabel13.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel13.Font = New System.Drawing.Font("Courier New", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel13.ForeColor = System.Drawing.Color.Maroon
        Me.BunifuCustomLabel13.Location = New System.Drawing.Point(110, 123)
        Me.BunifuCustomLabel13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.BunifuCustomLabel13.Name = "BunifuCustomLabel13"
        Me.BunifuCustomLabel13.Size = New System.Drawing.Size(785, 67)
        Me.BunifuCustomLabel13.TabIndex = 20
        Me.BunifuCustomLabel13.Text = "ARTS AND DESIGN TRACK"
        '
        'panelarts
        '
        Me.panelarts.Controls.Add(Me.PictureBox1)
        Me.panelarts.Controls.Add(Me.btnback)
        Me.panelarts.Controls.Add(Me.BunifuThinButton23)
        Me.panelarts.Controls.Add(Me.BunifuThinButton22)
        Me.panelarts.Controls.Add(Me.BunifuThinButton21)
        Me.panelarts.Controls.Add(Me.BunifuCustomLabel1)
        Me.panelarts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelarts.Location = New System.Drawing.Point(0, 0)
        Me.panelarts.Name = "panelarts"
        Me.panelarts.Size = New System.Drawing.Size(1010, 589)
        Me.panelarts.TabIndex = 80
        Me.panelarts.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Image = Global.Support_System.My.Resources.Resources.artss1
        Me.PictureBox1.Location = New System.Drawing.Point(561, 110)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(139, 103)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        '
        'btnback
        '
        Me.btnback.BackColor = System.Drawing.Color.Transparent
        Me.btnback.Image = Global.Support_System.My.Resources.Resources.icons8_back_arrow_100
        Me.btnback.ImageActive = Nothing
        Me.btnback.Location = New System.Drawing.Point(898, 31)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(81, 65)
        Me.btnback.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnback.TabIndex = 24
        Me.btnback.TabStop = False
        Me.btnback.UseWaitCursor = True
        Me.btnback.WaitOnLoad = True
        Me.btnback.Zoom = 40
        '
        'BunifuThinButton23
        '
        Me.BunifuThinButton23.ActiveBorderThickness = 1
        Me.BunifuThinButton23.ActiveCornerRadius = 20
        Me.BunifuThinButton23.ActiveFillColor = System.Drawing.Color.Red
        Me.BunifuThinButton23.ActiveForecolor = System.Drawing.Color.WhiteSmoke
        Me.BunifuThinButton23.ActiveLineColor = System.Drawing.Color.Maroon
        Me.BunifuThinButton23.BackColor = System.Drawing.SystemColors.Control
        Me.BunifuThinButton23.BackgroundImage = CType(resources.GetObject("BunifuThinButton23.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton23.ButtonText = "CAREER PATH"
        Me.BunifuThinButton23.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton23.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton23.ForeColor = System.Drawing.Color.White
        Me.BunifuThinButton23.IdleBorderThickness = 1
        Me.BunifuThinButton23.IdleCornerRadius = 20
        Me.BunifuThinButton23.IdleFillColor = System.Drawing.Color.Maroon
        Me.BunifuThinButton23.IdleForecolor = System.Drawing.Color.WhiteSmoke
        Me.BunifuThinButton23.IdleLineColor = System.Drawing.Color.Red
        Me.BunifuThinButton23.Location = New System.Drawing.Point(331, 390)
        Me.BunifuThinButton23.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.BunifuThinButton23.Name = "BunifuThinButton23"
        Me.BunifuThinButton23.Size = New System.Drawing.Size(304, 84)
        Me.BunifuThinButton23.TabIndex = 23
        Me.BunifuThinButton23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuThinButton22
        '
        Me.BunifuThinButton22.ActiveBorderThickness = 1
        Me.BunifuThinButton22.ActiveCornerRadius = 20
        Me.BunifuThinButton22.ActiveFillColor = System.Drawing.Color.Red
        Me.BunifuThinButton22.ActiveForecolor = System.Drawing.Color.WhiteSmoke
        Me.BunifuThinButton22.ActiveLineColor = System.Drawing.Color.Maroon
        Me.BunifuThinButton22.BackColor = System.Drawing.SystemColors.Control
        Me.BunifuThinButton22.BackgroundImage = CType(resources.GetObject("BunifuThinButton22.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton22.ButtonText = "SUBJECTS"
        Me.BunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton22.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton22.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton22.IdleBorderThickness = 1
        Me.BunifuThinButton22.IdleCornerRadius = 20
        Me.BunifuThinButton22.IdleFillColor = System.Drawing.Color.Maroon
        Me.BunifuThinButton22.IdleForecolor = System.Drawing.Color.WhiteSmoke
        Me.BunifuThinButton22.IdleLineColor = System.Drawing.Color.Red
        Me.BunifuThinButton22.Location = New System.Drawing.Point(518, 281)
        Me.BunifuThinButton22.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.BunifuThinButton22.Name = "BunifuThinButton22"
        Me.BunifuThinButton22.Size = New System.Drawing.Size(304, 84)
        Me.BunifuThinButton22.TabIndex = 22
        Me.BunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuThinButton21
        '
        Me.BunifuThinButton21.ActiveBorderThickness = 1
        Me.BunifuThinButton21.ActiveCornerRadius = 20
        Me.BunifuThinButton21.ActiveFillColor = System.Drawing.Color.Red
        Me.BunifuThinButton21.ActiveForecolor = System.Drawing.Color.WhiteSmoke
        Me.BunifuThinButton21.ActiveLineColor = System.Drawing.Color.Maroon
        Me.BunifuThinButton21.BackColor = System.Drawing.SystemColors.Control
        Me.BunifuThinButton21.BackgroundImage = CType(resources.GetObject("BunifuThinButton21.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton21.ButtonText = "ABOUT ARTS"
        Me.BunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton21.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton21.ForeColor = System.Drawing.Color.White
        Me.BunifuThinButton21.IdleBorderThickness = 1
        Me.BunifuThinButton21.IdleCornerRadius = 20
        Me.BunifuThinButton21.IdleFillColor = System.Drawing.Color.Maroon
        Me.BunifuThinButton21.IdleForecolor = System.Drawing.Color.WhiteSmoke
        Me.BunifuThinButton21.IdleLineColor = System.Drawing.Color.Red
        Me.BunifuThinButton21.Location = New System.Drawing.Point(158, 281)
        Me.BunifuThinButton21.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.BunifuThinButton21.Name = "BunifuThinButton21"
        Me.BunifuThinButton21.Size = New System.Drawing.Size(304, 84)
        Me.BunifuThinButton21.TabIndex = 21
        Me.BunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Courier New", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.Maroon
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(169, 95)
        Me.BunifuCustomLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(387, 151)
        Me.BunifuCustomLabel1.TabIndex = 19
        Me.BunifuCustomLabel1.Text = "ARTS AND" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " DESIGN "
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1010, 589)
        Me.Controls.Add(Me.panelartsimg)
        Me.Controls.Add(Me.panelarts)
        Me.Controls.Add(Me.pagesarts)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form4"
        Me.Text = "Form4"
        Me.pagesarts.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.panelartsimg.ResumeLayout(False)
        Me.panelartsimg.PerformLayout()
        Me.panelarts.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnback, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pagesarts As Bunifu.UI.WinForms.BunifuPages
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents BunifuFlatButton1 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents BunifuFlatButton5 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BunifuFlatButton4 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BunifuFlatButton3 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton2 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents BunifuFlatButton24 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton26 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents ListBox4 As ListBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents panelartsimg As Panel
    Friend WithEvents btnstemres As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents BunifuCustomLabel13 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents panelarts As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnback As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuThinButton23 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuThinButton22 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuThinButton21 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel22 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel23 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel24 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel25 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel26 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel27 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel28 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel29 As Bunifu.Framework.UI.BunifuCustomLabel
End Class
