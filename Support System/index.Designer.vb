<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class index
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Animation3 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(index))
        Dim Animation4 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.panelTopSide = New System.Windows.Forms.Panel()
        Me.BunifuImageButton2 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.panelAnimatpr = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.panelLeftSide = New System.Windows.Forms.Panel()
        Me.panelMore = New System.Windows.Forms.Panel()
        Me.BunifuFlatButton3 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.compatbilty = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.panelmenus = New System.Windows.Forms.Panel()
        Me.btnmore = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.bfubtnhome = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.bnfbtnsports = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.bfubtnacad = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.bfubtnarts = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.bfubtntvl = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.bfumenu = New Bunifu.Framework.UI.BunifuImageButton()
        Me.bfumenu2 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.panel1animator = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.panelTopSide.SuspendLayout()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelLeftSide.SuspendLayout()
        Me.panelMore.SuspendLayout()
        Me.panelmenus.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.bfumenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bfumenu2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.panelTopSide
        Me.BunifuDragControl1.Vertical = True
        '
        'panelTopSide
        '
        Me.panelTopSide.BackColor = System.Drawing.Color.Maroon
        Me.panelTopSide.Controls.Add(Me.BunifuImageButton2)
        Me.panel1animator.SetDecoration(Me.panelTopSide, BunifuAnimatorNS.DecorationType.None)
        Me.panelAnimatpr.SetDecoration(Me.panelTopSide, BunifuAnimatorNS.DecorationType.None)
        Me.panelTopSide.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelTopSide.ForeColor = System.Drawing.SystemColors.Control
        Me.panelTopSide.Location = New System.Drawing.Point(0, 0)
        Me.panelTopSide.Name = "panelTopSide"
        Me.panelTopSide.Size = New System.Drawing.Size(1059, 33)
        Me.panelTopSide.TabIndex = 33
        '
        'BunifuImageButton2
        '
        Me.BunifuImageButton2.BackColor = System.Drawing.Color.Maroon
        Me.panel1animator.SetDecoration(Me.BunifuImageButton2, BunifuAnimatorNS.DecorationType.None)
        Me.panelAnimatpr.SetDecoration(Me.BunifuImageButton2, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuImageButton2.Dock = System.Windows.Forms.DockStyle.Right
        Me.BunifuImageButton2.Image = CType(resources.GetObject("BunifuImageButton2.Image"), System.Drawing.Image)
        Me.BunifuImageButton2.ImageActive = Nothing
        Me.BunifuImageButton2.Location = New System.Drawing.Point(1034, 0)
        Me.BunifuImageButton2.Name = "BunifuImageButton2"
        Me.BunifuImageButton2.Size = New System.Drawing.Size(25, 33)
        Me.BunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton2.TabIndex = 21
        Me.BunifuImageButton2.TabStop = False
        Me.BunifuImageButton2.Zoom = 40
        '
        'panelAnimatpr
        '
        Me.panelAnimatpr.AnimationType = BunifuAnimatorNS.AnimationType.Transparent
        Me.panelAnimatpr.Cursor = Nothing
        Animation3.AnimateOnlyDifferences = True
        Animation3.BlindCoeff = CType(resources.GetObject("Animation3.BlindCoeff"), System.Drawing.PointF)
        Animation3.LeafCoeff = 0!
        Animation3.MaxTime = 1.0!
        Animation3.MinTime = 0!
        Animation3.MosaicCoeff = CType(resources.GetObject("Animation3.MosaicCoeff"), System.Drawing.PointF)
        Animation3.MosaicShift = CType(resources.GetObject("Animation3.MosaicShift"), System.Drawing.PointF)
        Animation3.MosaicSize = 0
        Animation3.Padding = New System.Windows.Forms.Padding(0)
        Animation3.RotateCoeff = 0!
        Animation3.RotateLimit = 0!
        Animation3.ScaleCoeff = CType(resources.GetObject("Animation3.ScaleCoeff"), System.Drawing.PointF)
        Animation3.SlideCoeff = CType(resources.GetObject("Animation3.SlideCoeff"), System.Drawing.PointF)
        Animation3.TimeCoeff = 0!
        Animation3.TransparencyCoeff = 1.0!
        Me.panelAnimatpr.DefaultAnimation = Animation3
        '
        'panelLeftSide
        '
        Me.panelLeftSide.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.panelLeftSide.Controls.Add(Me.panelMore)
        Me.panelLeftSide.Controls.Add(Me.panelmenus)
        Me.panelLeftSide.Controls.Add(Me.Panel2)
        Me.panel1animator.SetDecoration(Me.panelLeftSide, BunifuAnimatorNS.DecorationType.None)
        Me.panelAnimatpr.SetDecoration(Me.panelLeftSide, BunifuAnimatorNS.DecorationType.None)
        Me.panelLeftSide.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelLeftSide.Location = New System.Drawing.Point(0, 33)
        Me.panelLeftSide.Name = "panelLeftSide"
        Me.panelLeftSide.Size = New System.Drawing.Size(236, 542)
        Me.panelLeftSide.TabIndex = 35
        '
        'panelMore
        '
        Me.panelMore.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.panelMore.Controls.Add(Me.BunifuFlatButton3)
        Me.panelMore.Controls.Add(Me.compatbilty)
        Me.panel1animator.SetDecoration(Me.panelMore, BunifuAnimatorNS.DecorationType.None)
        Me.panelAnimatpr.SetDecoration(Me.panelMore, BunifuAnimatorNS.DecorationType.None)
        Me.panelMore.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelMore.Location = New System.Drawing.Point(0, 430)
        Me.panelMore.Name = "panelMore"
        Me.panelMore.Size = New System.Drawing.Size(236, 160)
        Me.panelMore.TabIndex = 23
        '
        'BunifuFlatButton3
        '
        Me.BunifuFlatButton3.Active = False
        Me.BunifuFlatButton3.Activecolor = System.Drawing.Color.Maroon
        Me.BunifuFlatButton3.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.BunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton3.BorderRadius = 0
        Me.BunifuFlatButton3.ButtonText = "                Logout"
        Me.BunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.panel1animator.SetDecoration(Me.BunifuFlatButton3, BunifuAnimatorNS.DecorationType.None)
        Me.panelAnimatpr.SetDecoration(Me.BunifuFlatButton3, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton3.Dock = System.Windows.Forms.DockStyle.Top
        Me.BunifuFlatButton3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.BunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton3.Iconimage = Global.Support_System.My.Resources.Resources.icons8_shutdown_64
        Me.BunifuFlatButton3.Iconimage_right = Nothing
        Me.BunifuFlatButton3.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton3.Iconimage_Selected = Nothing
        Me.BunifuFlatButton3.IconMarginLeft = 0
        Me.BunifuFlatButton3.IconMarginRight = 0
        Me.BunifuFlatButton3.IconRightVisible = False
        Me.BunifuFlatButton3.IconRightZoom = 0R
        Me.BunifuFlatButton3.IconVisible = True
        Me.BunifuFlatButton3.IconZoom = 60.0R
        Me.BunifuFlatButton3.IsTab = True
        Me.BunifuFlatButton3.Location = New System.Drawing.Point(0, 50)
        Me.BunifuFlatButton3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BunifuFlatButton3.Name = "BunifuFlatButton3"
        Me.BunifuFlatButton3.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.BunifuFlatButton3.OnHovercolor = System.Drawing.Color.BurlyWood
        Me.BunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton3.selected = False
        Me.BunifuFlatButton3.Size = New System.Drawing.Size(236, 50)
        Me.BunifuFlatButton3.TabIndex = 9
        Me.BunifuFlatButton3.Text = "                Logout"
        Me.BunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton3.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton3.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'compatbilty
        '
        Me.compatbilty.Active = False
        Me.compatbilty.Activecolor = System.Drawing.Color.Maroon
        Me.compatbilty.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.compatbilty.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.compatbilty.BorderRadius = 0
        Me.compatbilty.ButtonText = "                Compatibility"
        Me.compatbilty.Cursor = System.Windows.Forms.Cursors.Hand
        Me.panel1animator.SetDecoration(Me.compatbilty, BunifuAnimatorNS.DecorationType.None)
        Me.panelAnimatpr.SetDecoration(Me.compatbilty, BunifuAnimatorNS.DecorationType.None)
        Me.compatbilty.DisabledColor = System.Drawing.Color.Gray
        Me.compatbilty.Dock = System.Windows.Forms.DockStyle.Top
        Me.compatbilty.ForeColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.compatbilty.Iconcolor = System.Drawing.Color.Transparent
        Me.compatbilty.Iconimage = Global.Support_System.My.Resources.Resources.icons8_autism_50
        Me.compatbilty.Iconimage_right = Nothing
        Me.compatbilty.Iconimage_right_Selected = Nothing
        Me.compatbilty.Iconimage_Selected = Nothing
        Me.compatbilty.IconMarginLeft = 0
        Me.compatbilty.IconMarginRight = 0
        Me.compatbilty.IconRightVisible = False
        Me.compatbilty.IconRightZoom = 0R
        Me.compatbilty.IconVisible = True
        Me.compatbilty.IconZoom = 60.0R
        Me.compatbilty.IsTab = True
        Me.compatbilty.Location = New System.Drawing.Point(0, 0)
        Me.compatbilty.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.compatbilty.Name = "compatbilty"
        Me.compatbilty.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.compatbilty.OnHovercolor = System.Drawing.Color.BurlyWood
        Me.compatbilty.OnHoverTextColor = System.Drawing.Color.Transparent
        Me.compatbilty.selected = False
        Me.compatbilty.Size = New System.Drawing.Size(236, 50)
        Me.compatbilty.TabIndex = 7
        Me.compatbilty.Text = "                Compatibility"
        Me.compatbilty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.compatbilty.Textcolor = System.Drawing.Color.White
        Me.compatbilty.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'panelmenus
        '
        Me.panelmenus.Controls.Add(Me.btnmore)
        Me.panelmenus.Controls.Add(Me.bfubtnhome)
        Me.panelmenus.Controls.Add(Me.bnfbtnsports)
        Me.panelmenus.Controls.Add(Me.bfubtnacad)
        Me.panelmenus.Controls.Add(Me.bfubtnarts)
        Me.panelmenus.Controls.Add(Me.bfubtntvl)
        Me.panel1animator.SetDecoration(Me.panelmenus, BunifuAnimatorNS.DecorationType.None)
        Me.panelAnimatpr.SetDecoration(Me.panelmenus, BunifuAnimatorNS.DecorationType.None)
        Me.panelmenus.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelmenus.Location = New System.Drawing.Point(0, 64)
        Me.panelmenus.Name = "panelmenus"
        Me.panelmenus.Size = New System.Drawing.Size(236, 366)
        Me.panelmenus.TabIndex = 20
        '
        'btnmore
        '
        Me.btnmore.Active = False
        Me.btnmore.Activecolor = System.Drawing.Color.Maroon
        Me.btnmore.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnmore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnmore.BorderRadius = 0
        Me.btnmore.ButtonText = "                More"
        Me.btnmore.Cursor = System.Windows.Forms.Cursors.Hand
        Me.panel1animator.SetDecoration(Me.btnmore, BunifuAnimatorNS.DecorationType.None)
        Me.panelAnimatpr.SetDecoration(Me.btnmore, BunifuAnimatorNS.DecorationType.None)
        Me.btnmore.DisabledColor = System.Drawing.Color.Gray
        Me.btnmore.Enabled = False
        Me.btnmore.Iconcolor = System.Drawing.Color.Transparent
        Me.btnmore.Iconimage = Global.Support_System.My.Resources.Resources.icons8_ellipsis_50
        Me.btnmore.Iconimage_right = Nothing
        Me.btnmore.Iconimage_right_Selected = Nothing
        Me.btnmore.Iconimage_Selected = Nothing
        Me.btnmore.IconMarginLeft = 0
        Me.btnmore.IconMarginRight = 0
        Me.btnmore.IconRightVisible = False
        Me.btnmore.IconRightZoom = 0R
        Me.btnmore.IconVisible = True
        Me.btnmore.IconZoom = 60.0R
        Me.btnmore.IsTab = True
        Me.btnmore.Location = New System.Drawing.Point(0, 303)
        Me.btnmore.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnmore.Name = "btnmore"
        Me.btnmore.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnmore.OnHovercolor = System.Drawing.Color.BurlyWood
        Me.btnmore.OnHoverTextColor = System.Drawing.Color.Transparent
        Me.btnmore.selected = False
        Me.btnmore.Size = New System.Drawing.Size(237, 59)
        Me.btnmore.TabIndex = 23
        Me.btnmore.Text = "                More"
        Me.btnmore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnmore.Textcolor = System.Drawing.Color.White
        Me.btnmore.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'bfubtnhome
        '
        Me.bfubtnhome.Active = True
        Me.bfubtnhome.Activecolor = System.Drawing.Color.Maroon
        Me.bfubtnhome.BackColor = System.Drawing.Color.Maroon
        Me.bfubtnhome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bfubtnhome.BorderRadius = 0
        Me.bfubtnhome.ButtonText = "                Home"
        Me.bfubtnhome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.panel1animator.SetDecoration(Me.bfubtnhome, BunifuAnimatorNS.DecorationType.None)
        Me.panelAnimatpr.SetDecoration(Me.bfubtnhome, BunifuAnimatorNS.DecorationType.None)
        Me.bfubtnhome.DisabledColor = System.Drawing.Color.Gray
        Me.bfubtnhome.Iconcolor = System.Drawing.Color.Transparent
        Me.bfubtnhome.Iconimage = CType(resources.GetObject("bfubtnhome.Iconimage"), System.Drawing.Image)
        Me.bfubtnhome.Iconimage_right = Nothing
        Me.bfubtnhome.Iconimage_right_Selected = Nothing
        Me.bfubtnhome.Iconimage_Selected = Nothing
        Me.bfubtnhome.IconMarginLeft = 0
        Me.bfubtnhome.IconMarginRight = 0
        Me.bfubtnhome.IconRightVisible = False
        Me.bfubtnhome.IconRightZoom = 0R
        Me.bfubtnhome.IconVisible = True
        Me.bfubtnhome.IconZoom = 60.0R
        Me.bfubtnhome.IsTab = True
        Me.bfubtnhome.Location = New System.Drawing.Point(0, 0)
        Me.bfubtnhome.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.bfubtnhome.Name = "bfubtnhome"
        Me.bfubtnhome.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.bfubtnhome.OnHovercolor = System.Drawing.Color.BurlyWood
        Me.bfubtnhome.OnHoverTextColor = System.Drawing.Color.Transparent
        Me.bfubtnhome.selected = True
        Me.bfubtnhome.Size = New System.Drawing.Size(241, 59)
        Me.bfubtnhome.TabIndex = 1
        Me.bfubtnhome.Text = "                Home"
        Me.bfubtnhome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bfubtnhome.Textcolor = System.Drawing.Color.White
        Me.bfubtnhome.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'bnfbtnsports
        '
        Me.bnfbtnsports.Active = False
        Me.bnfbtnsports.Activecolor = System.Drawing.Color.Maroon
        Me.bnfbtnsports.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.bnfbtnsports.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bnfbtnsports.BorderRadius = 0
        Me.bnfbtnsports.ButtonText = "                Sports Track"
        Me.bnfbtnsports.Cursor = System.Windows.Forms.Cursors.Hand
        Me.panel1animator.SetDecoration(Me.bnfbtnsports, BunifuAnimatorNS.DecorationType.None)
        Me.panelAnimatpr.SetDecoration(Me.bnfbtnsports, BunifuAnimatorNS.DecorationType.None)
        Me.bnfbtnsports.DisabledColor = System.Drawing.Color.Gray
        Me.bnfbtnsports.Enabled = False
        Me.bnfbtnsports.Iconcolor = System.Drawing.Color.Transparent
        Me.bnfbtnsports.Iconimage = CType(resources.GetObject("bnfbtnsports.Iconimage"), System.Drawing.Image)
        Me.bnfbtnsports.Iconimage_right = Nothing
        Me.bnfbtnsports.Iconimage_right_Selected = Nothing
        Me.bnfbtnsports.Iconimage_Selected = Nothing
        Me.bnfbtnsports.IconMarginLeft = 0
        Me.bnfbtnsports.IconMarginRight = 0
        Me.bnfbtnsports.IconRightVisible = False
        Me.bnfbtnsports.IconRightZoom = 0R
        Me.bnfbtnsports.IconVisible = True
        Me.bnfbtnsports.IconZoom = 60.0R
        Me.bnfbtnsports.IsTab = True
        Me.bnfbtnsports.Location = New System.Drawing.Point(4, 244)
        Me.bnfbtnsports.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.bnfbtnsports.Name = "bnfbtnsports"
        Me.bnfbtnsports.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.bnfbtnsports.OnHovercolor = System.Drawing.Color.BurlyWood
        Me.bnfbtnsports.OnHoverTextColor = System.Drawing.Color.Transparent
        Me.bnfbtnsports.selected = False
        Me.bnfbtnsports.Size = New System.Drawing.Size(233, 59)
        Me.bnfbtnsports.TabIndex = 5
        Me.bnfbtnsports.Text = "                Sports Track"
        Me.bnfbtnsports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bnfbtnsports.Textcolor = System.Drawing.Color.White
        Me.bnfbtnsports.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'bfubtnacad
        '
        Me.bfubtnacad.Active = False
        Me.bfubtnacad.Activecolor = System.Drawing.Color.Maroon
        Me.bfubtnacad.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.bfubtnacad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bfubtnacad.BorderRadius = 0
        Me.bfubtnacad.ButtonText = "               Academic"
        Me.bfubtnacad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.panel1animator.SetDecoration(Me.bfubtnacad, BunifuAnimatorNS.DecorationType.None)
        Me.panelAnimatpr.SetDecoration(Me.bfubtnacad, BunifuAnimatorNS.DecorationType.None)
        Me.bfubtnacad.DisabledColor = System.Drawing.Color.Gray
        Me.bfubtnacad.Enabled = False
        Me.bfubtnacad.Iconcolor = System.Drawing.Color.Transparent
        Me.bfubtnacad.Iconimage = CType(resources.GetObject("bfubtnacad.Iconimage"), System.Drawing.Image)
        Me.bfubtnacad.Iconimage_right = Nothing
        Me.bfubtnacad.Iconimage_right_Selected = Nothing
        Me.bfubtnacad.Iconimage_Selected = Nothing
        Me.bfubtnacad.IconMarginLeft = 0
        Me.bfubtnacad.IconMarginRight = 0
        Me.bfubtnacad.IconRightVisible = False
        Me.bfubtnacad.IconRightZoom = 0R
        Me.bfubtnacad.IconVisible = True
        Me.bfubtnacad.IconZoom = 50.0R
        Me.bfubtnacad.IsTab = True
        Me.bfubtnacad.Location = New System.Drawing.Point(0, 67)
        Me.bfubtnacad.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.bfubtnacad.Name = "bfubtnacad"
        Me.bfubtnacad.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.bfubtnacad.OnHovercolor = System.Drawing.Color.BurlyWood
        Me.bfubtnacad.OnHoverTextColor = System.Drawing.Color.Transparent
        Me.bfubtnacad.selected = False
        Me.bfubtnacad.Size = New System.Drawing.Size(241, 59)
        Me.bfubtnacad.TabIndex = 2
        Me.bfubtnacad.Text = "               Academic"
        Me.bfubtnacad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bfubtnacad.Textcolor = System.Drawing.Color.White
        Me.bfubtnacad.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'bfubtnarts
        '
        Me.bfubtnarts.Active = False
        Me.bfubtnarts.Activecolor = System.Drawing.Color.Maroon
        Me.bfubtnarts.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.bfubtnarts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bfubtnarts.BorderRadius = 0
        Me.bfubtnarts.ButtonText = "                Arts/Design Track"
        Me.bfubtnarts.Cursor = System.Windows.Forms.Cursors.Hand
        Me.panel1animator.SetDecoration(Me.bfubtnarts, BunifuAnimatorNS.DecorationType.None)
        Me.panelAnimatpr.SetDecoration(Me.bfubtnarts, BunifuAnimatorNS.DecorationType.None)
        Me.bfubtnarts.DisabledColor = System.Drawing.Color.Gray
        Me.bfubtnarts.Enabled = False
        Me.bfubtnarts.Iconcolor = System.Drawing.Color.Transparent
        Me.bfubtnarts.Iconimage = CType(resources.GetObject("bfubtnarts.Iconimage"), System.Drawing.Image)
        Me.bfubtnarts.Iconimage_right = Nothing
        Me.bfubtnarts.Iconimage_right_Selected = Nothing
        Me.bfubtnarts.Iconimage_Selected = Nothing
        Me.bfubtnarts.IconMarginLeft = 0
        Me.bfubtnarts.IconMarginRight = 0
        Me.bfubtnarts.IconRightVisible = False
        Me.bfubtnarts.IconRightZoom = 0R
        Me.bfubtnarts.IconVisible = True
        Me.bfubtnarts.IconZoom = 60.0R
        Me.bfubtnarts.IsTab = True
        Me.bfubtnarts.Location = New System.Drawing.Point(0, 185)
        Me.bfubtnarts.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.bfubtnarts.Name = "bfubtnarts"
        Me.bfubtnarts.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.bfubtnarts.OnHovercolor = System.Drawing.Color.BurlyWood
        Me.bfubtnarts.OnHoverTextColor = System.Drawing.Color.Transparent
        Me.bfubtnarts.selected = False
        Me.bfubtnarts.Size = New System.Drawing.Size(237, 59)
        Me.bfubtnarts.TabIndex = 4
        Me.bfubtnarts.Text = "                Arts/Design Track"
        Me.bfubtnarts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.bfubtnarts.Textcolor = System.Drawing.Color.White
        Me.bfubtnarts.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'bfubtntvl
        '
        Me.bfubtntvl.Active = False
        Me.bfubtntvl.Activecolor = System.Drawing.Color.Maroon
        Me.bfubtntvl.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.bfubtntvl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bfubtntvl.BorderRadius = 0
        Me.bfubtntvl.ButtonText = "               Tech-Voc  "
        Me.bfubtntvl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.panel1animator.SetDecoration(Me.bfubtntvl, BunifuAnimatorNS.DecorationType.None)
        Me.panelAnimatpr.SetDecoration(Me.bfubtntvl, BunifuAnimatorNS.DecorationType.None)
        Me.bfubtntvl.DisabledColor = System.Drawing.Color.Gray
        Me.bfubtntvl.Enabled = False
        Me.bfubtntvl.Iconcolor = System.Drawing.Color.Transparent
        Me.bfubtntvl.Iconimage = CType(resources.GetObject("bfubtntvl.Iconimage"), System.Drawing.Image)
        Me.bfubtntvl.Iconimage_right = Nothing
        Me.bfubtntvl.Iconimage_right_Selected = Nothing
        Me.bfubtntvl.Iconimage_Selected = Nothing
        Me.bfubtntvl.IconMarginLeft = 0
        Me.bfubtntvl.IconMarginRight = 0
        Me.bfubtntvl.IconRightVisible = True
        Me.bfubtntvl.IconRightZoom = 0R
        Me.bfubtntvl.IconVisible = True
        Me.bfubtntvl.IconZoom = 60.0R
        Me.bfubtntvl.IsTab = True
        Me.bfubtntvl.Location = New System.Drawing.Point(0, 126)
        Me.bfubtntvl.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.bfubtntvl.Name = "bfubtntvl"
        Me.bfubtntvl.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.bfubtntvl.OnHovercolor = System.Drawing.Color.BurlyWood
        Me.bfubtntvl.OnHoverTextColor = System.Drawing.Color.Transparent
        Me.bfubtntvl.selected = False
        Me.bfubtntvl.Size = New System.Drawing.Size(241, 59)
        Me.bfubtntvl.TabIndex = 3
        Me.bfubtntvl.Text = "               Tech-Voc  "
        Me.bfubtntvl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bfubtntvl.Textcolor = System.Drawing.Color.White
        Me.bfubtntvl.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.bfumenu)
        Me.Panel2.Controls.Add(Me.bfumenu2)
        Me.panel1animator.SetDecoration(Me.Panel2, BunifuAnimatorNS.DecorationType.None)
        Me.panelAnimatpr.SetDecoration(Me.Panel2, BunifuAnimatorNS.DecorationType.None)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(236, 64)
        Me.Panel2.TabIndex = 19
        '
        'bfumenu
        '
        Me.bfumenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.panel1animator.SetDecoration(Me.bfumenu, BunifuAnimatorNS.DecorationType.None)
        Me.panelAnimatpr.SetDecoration(Me.bfumenu, BunifuAnimatorNS.DecorationType.None)
        Me.bfumenu.Image = CType(resources.GetObject("bfumenu.Image"), System.Drawing.Image)
        Me.bfumenu.ImageActive = Nothing
        Me.bfumenu.Location = New System.Drawing.Point(203, 17)
        Me.bfumenu.Name = "bfumenu"
        Me.bfumenu.Size = New System.Drawing.Size(25, 25)
        Me.bfumenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.bfumenu.TabIndex = 17
        Me.bfumenu.TabStop = False
        Me.bfumenu.UseWaitCursor = True
        Me.bfumenu.WaitOnLoad = True
        Me.bfumenu.Zoom = 40
        '
        'bfumenu2
        '
        Me.bfumenu2.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.panel1animator.SetDecoration(Me.bfumenu2, BunifuAnimatorNS.DecorationType.None)
        Me.panelAnimatpr.SetDecoration(Me.bfumenu2, BunifuAnimatorNS.DecorationType.None)
        Me.bfumenu2.Image = CType(resources.GetObject("bfumenu2.Image"), System.Drawing.Image)
        Me.bfumenu2.ImageActive = Nothing
        Me.bfumenu2.Location = New System.Drawing.Point(12, 17)
        Me.bfumenu2.Name = "bfumenu2"
        Me.bfumenu2.Size = New System.Drawing.Size(25, 25)
        Me.bfumenu2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.bfumenu2.TabIndex = 18
        Me.bfumenu2.TabStop = False
        Me.bfumenu2.UseWaitCursor = True
        Me.bfumenu2.Visible = False
        Me.bfumenu2.WaitOnLoad = True
        Me.bfumenu2.Zoom = 40
        '
        'Panel1
        '
        Me.panel1animator.SetDecoration(Me.Panel1, BunifuAnimatorNS.DecorationType.None)
        Me.panelAnimatpr.SetDecoration(Me.Panel1, BunifuAnimatorNS.DecorationType.None)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(236, 33)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(823, 542)
        Me.Panel1.TabIndex = 36
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'panel1animator
        '
        Me.panel1animator.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide
        Me.panel1animator.Cursor = Nothing
        Animation4.AnimateOnlyDifferences = True
        Animation4.BlindCoeff = CType(resources.GetObject("Animation4.BlindCoeff"), System.Drawing.PointF)
        Animation4.LeafCoeff = 0!
        Animation4.MaxTime = 1.0!
        Animation4.MinTime = 0!
        Animation4.MosaicCoeff = CType(resources.GetObject("Animation4.MosaicCoeff"), System.Drawing.PointF)
        Animation4.MosaicShift = CType(resources.GetObject("Animation4.MosaicShift"), System.Drawing.PointF)
        Animation4.MosaicSize = 0
        Animation4.Padding = New System.Windows.Forms.Padding(0)
        Animation4.RotateCoeff = 0!
        Animation4.RotateLimit = 0!
        Animation4.ScaleCoeff = CType(resources.GetObject("Animation4.ScaleCoeff"), System.Drawing.PointF)
        Animation4.SlideCoeff = CType(resources.GetObject("Animation4.SlideCoeff"), System.Drawing.PointF)
        Animation4.TimeCoeff = 0!
        Animation4.TransparencyCoeff = 0!
        Me.panel1animator.DefaultAnimation = Animation4
        '
        'index
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1059, 575)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.panelLeftSide)
        Me.Controls.Add(Me.panelTopSide)
        Me.panelAnimatpr.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.panel1animator.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(1059, 650)
        Me.MinimumSize = New System.Drawing.Size(950, 470)
        Me.Name = "index"
        Me.Text = "Form1"
        Me.panelTopSide.ResumeLayout(False)
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelLeftSide.ResumeLayout(False)
        Me.panelMore.ResumeLayout(False)
        Me.panelmenus.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.bfumenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bfumenu2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents panelAnimatpr As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents panelTopSide As Panel
    Friend WithEvents panel1animator As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents Panel1 As Panel
    Friend WithEvents panelLeftSide As Panel
    Friend WithEvents bfumenu2 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents bfumenu As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BunifuImageButton2 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents panelMore As Panel
    Friend WithEvents BunifuFlatButton3 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents compatbilty As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents panelmenus As Panel
    Friend WithEvents btnmore As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents bfubtnhome As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents bnfbtnsports As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents bfubtnacad As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents bfubtnarts As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents bfubtntvl As Bunifu.Framework.UI.BunifuFlatButton
End Class
