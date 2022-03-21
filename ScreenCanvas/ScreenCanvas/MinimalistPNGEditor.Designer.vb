<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MinimalistPNGEditor
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MinimalistPNGEditor))
        Me.my_canvas = New System.Windows.Forms.Panel()
        Me.Panel_webber = New System.Windows.Forms.Panel()
        Me.webber = New System.Windows.Forms.WebBrowser()
        Me.ListBox_bmark = New System.Windows.Forms.ListBox()
        Me.Panel_bottomW = New System.Windows.Forms.Panel()
        Me.text_webaddr = New System.Windows.Forms.TextBox()
        Me.Button_webAppdir = New System.Windows.Forms.Button()
        Me.Button_webup = New System.Windows.Forms.Button()
        Me.ButtonWebGo = New System.Windows.Forms.Button()
        Me.Button_webBrowse = New System.Windows.Forms.Button()
        Me.Panel_cornorW = New System.Windows.Forms.Panel()
        Me.Button_webClose = New System.Windows.Forms.Button()
        Me.Panel_coords = New System.Windows.Forms.Panel()
        Me.Label_coord = New System.Windows.Forms.Label()
        Me.cms_coords = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CoordrelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CordCopy2ClipToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CordPastePointsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel_Anchor = New System.Windows.Forms.Panel()
        Me.Pic_Anchor = New System.Windows.Forms.PictureBox()
        Me.cms_canvasctrl = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ScreenshotToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AllScreensToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportClipboardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportClipoardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CloseImageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetCanvasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CenterAnchorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetToolbarsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.QuicksaveFolderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AppDirectoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.SetTKeyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ControlTestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel_textInput = New System.Windows.Forms.Panel()
        Me.TextTootl = New System.Windows.Forms.TextBox()
        Me.Panel_bottom = New System.Windows.Forms.Panel()
        Me.B_FontChange = New System.Windows.Forms.Button()
        Me.B_ClearTextIn = New System.Windows.Forms.Button()
        Me.Panel_cornor = New System.Windows.Forms.Panel()
        Me.B_hideTextIn = New System.Windows.Forms.Button()
        Me.Panel_tools = New System.Windows.Forms.FlowLayoutPanel()
        Me.rb_pointer = New System.Windows.Forms.RadioButton()
        Me.rb_marker = New System.Windows.Forms.RadioButton()
        Me.rb_caligraphy = New System.Windows.Forms.RadioButton()
        Me.NUD_ANGLEsel = New ScreenCanvas.AngleSelector()
        Me.rb_path = New System.Windows.Forms.RadioButton()
        Me.rb_table = New System.Windows.Forms.RadioButton()
        Me.cms_tableTool = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tstb_rows = New System.Windows.Forms.ToolStripTextBox()
        Me.tstb_cols = New System.Windows.Forms.ToolStripTextBox()
        Me.rb_ellipse = New System.Windows.Forms.RadioButton()
        Me.rb_screencopy = New System.Windows.Forms.RadioButton()
        Me.cms_ScreenCopy = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SaveToFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.rb_SelectR = New System.Windows.Forms.RadioButton()
        Me.cms_Selection = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SelCutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelCopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelSaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.rb_paste = New System.Windows.Forms.RadioButton()
        Me.rb_pasteR = New System.Windows.Forms.RadioButton()
        Me.rb_eraser = New System.Windows.Forms.RadioButton()
        Me.rb_text = New System.Windows.Forms.RadioButton()
        Me.cms_textTool = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.FromClipboardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnterTextToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.rb_colorpick = New System.Windows.Forms.RadioButton()
        Me.rb_axismarker = New System.Windows.Forms.RadioButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.nud_rotXangle = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.B_clearaxisPots = New System.Windows.Forms.Button()
        Me.chk_showScale = New System.Windows.Forms.CheckBox()
        Me.Check_dropPP = New System.Windows.Forms.CheckBox()
        Me.B_inputfocus = New System.Windows.Forms.Button()
        Me.CheckBox_lockXscroll = New System.Windows.Forms.CheckBox()
        Me.CheckBox_lockYscroll = New System.Windows.Forms.CheckBox()
        Me.B_Undo = New System.Windows.Forms.Button()
        Me.B_Redo = New System.Windows.Forms.Button()
        Me.Check_erasretrail = New System.Windows.Forms.CheckBox()
        Me.chk_fillOn = New System.Windows.Forms.CheckBox()
        Me.chk_rainbow = New System.Windows.Forms.CheckBox()
        Me.cms_rainbow = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TSTB_rainbowDelta = New System.Windows.Forms.ToolStripTextBox()
        Me.Check_copy2clip = New System.Windows.Forms.CheckBox()
        Me.Check_fixedToolbox = New System.Windows.Forms.CheckBox()
        Me.cms_docker = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Combo_dockStc = New System.Windows.Forms.ToolStripComboBox()
        Me.Check_showCoords = New System.Windows.Forms.CheckBox()
        Me.b_close = New System.Windows.Forms.Button()
        Me.t_kp = New System.Windows.Forms.TextBox()
        Me.Panel_Pallete = New System.Windows.Forms.Panel()
        Me.pan_gridpen = New System.Windows.Forms.Panel()
        Me.pan_gridpenx = New System.Windows.Forms.Panel()
        Me.pan_gridpeny = New System.Windows.Forms.Panel()
        Me.lab_ewid = New System.Windows.Forms.Label()
        Me.lab_EraserDis = New System.Windows.Forms.Label()
        Me.lab_shapeDis = New System.Windows.Forms.Label()
        Me.xcp12 = New System.Windows.Forms.Panel()
        Me.lab_swid = New System.Windows.Forms.Label()
        Me.xcp16 = New System.Windows.Forms.Panel()
        Me.Panel_SelCol = New System.Windows.Forms.Panel()
        Me.cms_selCol = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.FillCanvasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.SelectColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RandomColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSTB_hueDelta = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.CopyAsRGBToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteAsRGBToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.xcp7 = New System.Windows.Forms.Panel()
        Me.xcp9 = New System.Windows.Forms.Panel()
        Me.lab_mwid = New System.Windows.Forms.Label()
        Me.xcp3 = New System.Windows.Forms.Panel()
        Me.lab_markerDis = New System.Windows.Forms.Label()
        Me.xcp14 = New System.Windows.Forms.Panel()
        Me.xcp5 = New System.Windows.Forms.Panel()
        Me.xcp11 = New System.Windows.Forms.Panel()
        Me.xcp1 = New System.Windows.Forms.Panel()
        Me.xcp8 = New System.Windows.Forms.Panel()
        Me.xcp6 = New System.Windows.Forms.Panel()
        Me.xcp15 = New System.Windows.Forms.Panel()
        Me.xcp2 = New System.Windows.Forms.Panel()
        Me.xcp10 = New System.Windows.Forms.Panel()
        Me.xcp13 = New System.Windows.Forms.Panel()
        Me.xcp17 = New System.Windows.Forms.Panel()
        Me.xcp4 = New System.Windows.Forms.Panel()
        Me.xcp0 = New System.Windows.Forms.Panel()
        Me.track_mwid = New System.Windows.Forms.TrackBar()
        Me.track_eraser = New System.Windows.Forms.TrackBar()
        Me.track_swid = New System.Windows.Forms.TrackBar()
        Me.cms_timestamTool = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TimeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSTB_sep = New System.Windows.Forms.ToolStripTextBox()
        Me.PalleteCD = New System.Windows.Forms.ColorDialog()
        Me.mytooltips = New System.Windows.Forms.ToolTip(Me.components)
        Me.sfdia = New System.Windows.Forms.SaveFileDialog()
        Me.trayico = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.time_animate = New System.Windows.Forms.Timer(Me.components)
        Me.time_AnchorSlide = New System.Windows.Forms.Timer(Me.components)
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.bgwudp = New System.ComponentModel.BackgroundWorker()
        Me.webFolder = New System.Windows.Forms.FolderBrowserDialog()
        Me.my_canvas.SuspendLayout()
        Me.Panel_webber.SuspendLayout()
        Me.Panel_bottomW.SuspendLayout()
        Me.Panel_coords.SuspendLayout()
        Me.cms_coords.SuspendLayout()
        Me.Panel_Anchor.SuspendLayout()
        CType(Me.Pic_Anchor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cms_canvasctrl.SuspendLayout()
        Me.Panel_textInput.SuspendLayout()
        Me.Panel_bottom.SuspendLayout()
        Me.Panel_tools.SuspendLayout()
        Me.cms_tableTool.SuspendLayout()
        Me.cms_ScreenCopy.SuspendLayout()
        Me.cms_Selection.SuspendLayout()
        Me.cms_textTool.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.cms_rainbow.SuspendLayout()
        Me.cms_docker.SuspendLayout()
        Me.Panel_Pallete.SuspendLayout()
        Me.cms_selCol.SuspendLayout()
        CType(Me.track_mwid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.track_eraser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.track_swid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cms_timestamTool.SuspendLayout()
        Me.SuspendLayout()
        '
        'my_canvas
        '
        Me.my_canvas.BackColor = System.Drawing.Color.White
        Me.my_canvas.Controls.Add(Me.Panel_webber)
        Me.my_canvas.Controls.Add(Me.Panel_coords)
        Me.my_canvas.Controls.Add(Me.Panel_Anchor)
        Me.my_canvas.Controls.Add(Me.Panel_textInput)
        Me.my_canvas.Controls.Add(Me.Panel_tools)
        Me.my_canvas.Controls.Add(Me.t_kp)
        Me.my_canvas.Controls.Add(Me.Panel_Pallete)
        Me.my_canvas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.my_canvas.Location = New System.Drawing.Point(0, 0)
        Me.my_canvas.Margin = New System.Windows.Forms.Padding(0)
        Me.my_canvas.Name = "my_canvas"
        Me.my_canvas.Size = New System.Drawing.Size(954, 580)
        Me.my_canvas.TabIndex = 0
        '
        'Panel_webber
        '
        Me.Panel_webber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel_webber.Controls.Add(Me.webber)
        Me.Panel_webber.Controls.Add(Me.ListBox_bmark)
        Me.Panel_webber.Controls.Add(Me.Panel_bottomW)
        Me.Panel_webber.Location = New System.Drawing.Point(0, 286)
        Me.Panel_webber.Name = "Panel_webber"
        Me.Panel_webber.Size = New System.Drawing.Size(634, 206)
        Me.Panel_webber.TabIndex = 42
        Me.Panel_webber.Visible = False
        '
        'webber
        '
        Me.webber.Dock = System.Windows.Forms.DockStyle.Fill
        Me.webber.Location = New System.Drawing.Point(137, 0)
        Me.webber.MinimumSize = New System.Drawing.Size(20, 20)
        Me.webber.Name = "webber"
        Me.webber.Size = New System.Drawing.Size(495, 168)
        Me.webber.TabIndex = 45
        Me.webber.TabStop = False
        '
        'ListBox_bmark
        '
        Me.ListBox_bmark.Dock = System.Windows.Forms.DockStyle.Left
        Me.ListBox_bmark.FormattingEnabled = True
        Me.ListBox_bmark.ItemHeight = 19
        Me.ListBox_bmark.Location = New System.Drawing.Point(0, 0)
        Me.ListBox_bmark.Name = "ListBox_bmark"
        Me.ListBox_bmark.Size = New System.Drawing.Size(137, 168)
        Me.ListBox_bmark.TabIndex = 46
        '
        'Panel_bottomW
        '
        Me.Panel_bottomW.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel_bottomW.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel_bottomW.Controls.Add(Me.text_webaddr)
        Me.Panel_bottomW.Controls.Add(Me.Button_webAppdir)
        Me.Panel_bottomW.Controls.Add(Me.Button_webup)
        Me.Panel_bottomW.Controls.Add(Me.ButtonWebGo)
        Me.Panel_bottomW.Controls.Add(Me.Button_webBrowse)
        Me.Panel_bottomW.Controls.Add(Me.Panel_cornorW)
        Me.Panel_bottomW.Controls.Add(Me.Button_webClose)
        Me.Panel_bottomW.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel_bottomW.Location = New System.Drawing.Point(0, 168)
        Me.Panel_bottomW.Name = "Panel_bottomW"
        Me.Panel_bottomW.Size = New System.Drawing.Size(632, 36)
        Me.Panel_bottomW.TabIndex = 44
        '
        'text_webaddr
        '
        Me.text_webaddr.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.text_webaddr.Dock = System.Windows.Forms.DockStyle.Fill
        Me.text_webaddr.Location = New System.Drawing.Point(136, 0)
        Me.text_webaddr.Name = "text_webaddr"
        Me.text_webaddr.Size = New System.Drawing.Size(450, 27)
        Me.text_webaddr.TabIndex = 41
        Me.mytooltips.SetToolTip(Me.text_webaddr, "Enter to go to address" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ctrl+Enter to add http" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "shift+Enter to add https")
        '
        'Button_webAppdir
        '
        Me.Button_webAppdir.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.Button_webAppdir.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button_webAppdir.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button_webAppdir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_webAppdir.Font = New System.Drawing.Font("Wingdings", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Button_webAppdir.ForeColor = System.Drawing.Color.Black
        Me.Button_webAppdir.Location = New System.Drawing.Point(102, 0)
        Me.Button_webAppdir.Margin = New System.Windows.Forms.Padding(0)
        Me.Button_webAppdir.Name = "Button_webAppdir"
        Me.Button_webAppdir.Size = New System.Drawing.Size(34, 34)
        Me.Button_webAppdir.TabIndex = 48
        Me.Button_webAppdir.TabStop = False
        Me.Button_webAppdir.Text = "µ"
        Me.mytooltips.SetToolTip(Me.Button_webAppdir, "Bookmark")
        Me.Button_webAppdir.UseVisualStyleBackColor = False
        '
        'Button_webup
        '
        Me.Button_webup.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.Button_webup.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button_webup.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button_webup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_webup.Font = New System.Drawing.Font("Wingdings", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Button_webup.ForeColor = System.Drawing.Color.Black
        Me.Button_webup.Location = New System.Drawing.Point(68, 0)
        Me.Button_webup.Margin = New System.Windows.Forms.Padding(0)
        Me.Button_webup.Name = "Button_webup"
        Me.Button_webup.Size = New System.Drawing.Size(34, 34)
        Me.Button_webup.TabIndex = 46
        Me.Button_webup.TabStop = False
        Me.Button_webup.Text = "Ý"
        Me.mytooltips.SetToolTip(Me.Button_webup, "Go Up")
        Me.Button_webup.UseVisualStyleBackColor = False
        '
        'ButtonWebGo
        '
        Me.ButtonWebGo.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.ButtonWebGo.Dock = System.Windows.Forms.DockStyle.Right
        Me.ButtonWebGo.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ButtonWebGo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonWebGo.Font = New System.Drawing.Font("Wingdings", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.ButtonWebGo.ForeColor = System.Drawing.Color.Black
        Me.ButtonWebGo.Location = New System.Drawing.Point(586, 0)
        Me.ButtonWebGo.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonWebGo.Name = "ButtonWebGo"
        Me.ButtonWebGo.Size = New System.Drawing.Size(34, 34)
        Me.ButtonWebGo.TabIndex = 49
        Me.ButtonWebGo.TabStop = False
        Me.ButtonWebGo.Text = "Ø"
        Me.mytooltips.SetToolTip(Me.ButtonWebGo, "Go")
        Me.ButtonWebGo.UseVisualStyleBackColor = False
        '
        'Button_webBrowse
        '
        Me.Button_webBrowse.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.Button_webBrowse.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button_webBrowse.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button_webBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_webBrowse.Font = New System.Drawing.Font("Wingdings", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Button_webBrowse.ForeColor = System.Drawing.Color.Black
        Me.Button_webBrowse.Location = New System.Drawing.Point(34, 0)
        Me.Button_webBrowse.Margin = New System.Windows.Forms.Padding(0)
        Me.Button_webBrowse.Name = "Button_webBrowse"
        Me.Button_webBrowse.Size = New System.Drawing.Size(34, 34)
        Me.Button_webBrowse.TabIndex = 47
        Me.Button_webBrowse.TabStop = False
        Me.Button_webBrowse.Text = "1"
        Me.mytooltips.SetToolTip(Me.Button_webBrowse, "Browse Folder")
        Me.Button_webBrowse.UseVisualStyleBackColor = False
        '
        'Panel_cornorW
        '
        Me.Panel_cornorW.BackColor = System.Drawing.Color.DimGray
        Me.Panel_cornorW.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel_cornorW.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel_cornorW.Location = New System.Drawing.Point(620, 0)
        Me.Panel_cornorW.Name = "Panel_cornorW"
        Me.Panel_cornorW.Size = New System.Drawing.Size(10, 34)
        Me.Panel_cornorW.TabIndex = 44
        '
        'Button_webClose
        '
        Me.Button_webClose.BackColor = System.Drawing.Color.IndianRed
        Me.Button_webClose.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button_webClose.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button_webClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_webClose.Font = New System.Drawing.Font("Wingdings", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Button_webClose.ForeColor = System.Drawing.Color.Black
        Me.Button_webClose.Location = New System.Drawing.Point(0, 0)
        Me.Button_webClose.Margin = New System.Windows.Forms.Padding(0)
        Me.Button_webClose.Name = "Button_webClose"
        Me.Button_webClose.Size = New System.Drawing.Size(34, 34)
        Me.Button_webClose.TabIndex = 40
        Me.Button_webClose.TabStop = False
        Me.Button_webClose.Text = "û"
        Me.mytooltips.SetToolTip(Me.Button_webClose, "Hide")
        Me.Button_webClose.UseVisualStyleBackColor = False
        '
        'Panel_coords
        '
        Me.Panel_coords.Controls.Add(Me.Label_coord)
        Me.Panel_coords.Location = New System.Drawing.Point(64, 64)
        Me.Panel_coords.Name = "Panel_coords"
        Me.Panel_coords.Size = New System.Drawing.Size(139, 32)
        Me.Panel_coords.TabIndex = 40
        Me.Panel_coords.Visible = False
        '
        'Label_coord
        '
        Me.Label_coord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label_coord.ContextMenuStrip = Me.cms_coords
        Me.Label_coord.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label_coord.Location = New System.Drawing.Point(0, 0)
        Me.Label_coord.Name = "Label_coord"
        Me.Label_coord.Size = New System.Drawing.Size(139, 32)
        Me.Label_coord.TabIndex = 0
        Me.Label_coord.Text = "{X=0000,Y=0000}"
        Me.Label_coord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cms_coords
        '
        Me.cms_coords.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CoordrelToolStripMenuItem, Me.CordCopy2ClipToolStripMenuItem, Me.CordPastePointsToolStripMenuItem})
        Me.cms_coords.Name = "cms_coords"
        Me.cms_coords.ShowCheckMargin = True
        Me.cms_coords.ShowImageMargin = False
        Me.cms_coords.Size = New System.Drawing.Size(168, 70)
        '
        'CoordrelToolStripMenuItem
        '
        Me.CoordrelToolStripMenuItem.CheckOnClick = True
        Me.CoordrelToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CoordrelToolStripMenuItem.Name = "CoordrelToolStripMenuItem"
        Me.CoordrelToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.CoordrelToolStripMenuItem.Text = "Relative to Center"
        '
        'CordCopy2ClipToolStripMenuItem
        '
        Me.CordCopy2ClipToolStripMenuItem.Name = "CordCopy2ClipToolStripMenuItem"
        Me.CordCopy2ClipToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.CordCopy2ClipToolStripMenuItem.Text = "Copy Axis Points"
        '
        'CordPastePointsToolStripMenuItem
        '
        Me.CordPastePointsToolStripMenuItem.Name = "CordPastePointsToolStripMenuItem"
        Me.CordPastePointsToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.CordPastePointsToolStripMenuItem.Text = "Paste Axis Points"
        '
        'Panel_Anchor
        '
        Me.Panel_Anchor.AllowDrop = True
        Me.Panel_Anchor.Controls.Add(Me.Pic_Anchor)
        Me.Panel_Anchor.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Anchor.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel_Anchor.Name = "Panel_Anchor"
        Me.Panel_Anchor.Size = New System.Drawing.Size(64, 64)
        Me.Panel_Anchor.TabIndex = 39
        Me.Panel_Anchor.Visible = False
        '
        'Pic_Anchor
        '
        Me.Pic_Anchor.BackColor = System.Drawing.Color.White
        Me.Pic_Anchor.ContextMenuStrip = Me.cms_canvasctrl
        Me.Pic_Anchor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Pic_Anchor.Location = New System.Drawing.Point(0, 0)
        Me.Pic_Anchor.Name = "Pic_Anchor"
        Me.Pic_Anchor.Size = New System.Drawing.Size(64, 64)
        Me.Pic_Anchor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_Anchor.TabIndex = 5
        Me.Pic_Anchor.TabStop = False
        '
        'cms_canvasctrl
        '
        Me.cms_canvasctrl.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearToolStripMenuItem, Me.SaveToolStripMenuItem, Me.ScreenshotToolStripMenuItem, Me.ImportClipboardToolStripMenuItem, Me.ExportClipoardToolStripMenuItem, Me.ToolStripSeparator1, Me.CloseImageToolStripMenuItem, Me.ResetCanvasToolStripMenuItem, Me.CenterAnchorToolStripMenuItem, Me.ResetToolbarsToolStripMenuItem, Me.ToolStripSeparator2, Me.QuicksaveFolderToolStripMenuItem, Me.AppDirectoryToolStripMenuItem, Me.ToolStripSeparator3, Me.SetTKeyToolStripMenuItem, Me.QuitToolStripMenuItem, Me.ControlTestToolStripMenuItem})
        Me.cms_canvasctrl.Name = "cms_canvasctrl"
        Me.cms_canvasctrl.ShowImageMargin = False
        Me.cms_canvasctrl.Size = New System.Drawing.Size(141, 330)
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Enabled = False
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.ShortcutKeyDisplayString = ""
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.ClearToolStripMenuItem.Text = "&Clear"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.SaveToolStripMenuItem.Text = "&Save"
        '
        'ScreenshotToolStripMenuItem
        '
        Me.ScreenshotToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AllScreensToolStripMenuItem})
        Me.ScreenshotToolStripMenuItem.Name = "ScreenshotToolStripMenuItem"
        Me.ScreenshotToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.ScreenshotToolStripMenuItem.Text = "Screenshot"
        '
        'AllScreensToolStripMenuItem
        '
        Me.AllScreensToolStripMenuItem.CheckOnClick = True
        Me.AllScreensToolStripMenuItem.Name = "AllScreensToolStripMenuItem"
        Me.AllScreensToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.AllScreensToolStripMenuItem.Text = "All Screens"
        '
        'ImportClipboardToolStripMenuItem
        '
        Me.ImportClipboardToolStripMenuItem.Name = "ImportClipboardToolStripMenuItem"
        Me.ImportClipboardToolStripMenuItem.ShortcutKeyDisplayString = ""
        Me.ImportClipboardToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.ImportClipboardToolStripMenuItem.Text = "&Import Clipboard"
        '
        'ExportClipoardToolStripMenuItem
        '
        Me.ExportClipoardToolStripMenuItem.Name = "ExportClipoardToolStripMenuItem"
        Me.ExportClipoardToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.ExportClipoardToolStripMenuItem.Text = "&Export Clipoard"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(137, 6)
        '
        'CloseImageToolStripMenuItem
        '
        Me.CloseImageToolStripMenuItem.Name = "CloseImageToolStripMenuItem"
        Me.CloseImageToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.CloseImageToolStripMenuItem.Text = "Close Image"
        '
        'ResetCanvasToolStripMenuItem
        '
        Me.ResetCanvasToolStripMenuItem.Name = "ResetCanvasToolStripMenuItem"
        Me.ResetCanvasToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.ResetCanvasToolStripMenuItem.Text = "Reset Canvas"
        '
        'CenterAnchorToolStripMenuItem
        '
        Me.CenterAnchorToolStripMenuItem.Name = "CenterAnchorToolStripMenuItem"
        Me.CenterAnchorToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.CenterAnchorToolStripMenuItem.Text = "Reset Anc&hor"
        '
        'ResetToolbarsToolStripMenuItem
        '
        Me.ResetToolbarsToolStripMenuItem.Name = "ResetToolbarsToolStripMenuItem"
        Me.ResetToolbarsToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.ResetToolbarsToolStripMenuItem.Text = "Reset Tool&bars"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(137, 6)
        '
        'QuicksaveFolderToolStripMenuItem
        '
        Me.QuicksaveFolderToolStripMenuItem.Name = "QuicksaveFolderToolStripMenuItem"
        Me.QuicksaveFolderToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.QuicksaveFolderToolStripMenuItem.Text = "QuickSave &Folder"
        '
        'AppDirectoryToolStripMenuItem
        '
        Me.AppDirectoryToolStripMenuItem.Name = "AppDirectoryToolStripMenuItem"
        Me.AppDirectoryToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.AppDirectoryToolStripMenuItem.Text = "Ap&p Directory"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(137, 6)
        '
        'SetTKeyToolStripMenuItem
        '
        Me.SetTKeyToolStripMenuItem.Name = "SetTKeyToolStripMenuItem"
        Me.SetTKeyToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.SetTKeyToolStripMenuItem.Text = "Settings"
        '
        'QuitToolStripMenuItem
        '
        Me.QuitToolStripMenuItem.Name = "QuitToolStripMenuItem"
        Me.QuitToolStripMenuItem.ShortcutKeyDisplayString = ""
        Me.QuitToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.QuitToolStripMenuItem.Text = "&Quit"
        '
        'ControlTestToolStripMenuItem
        '
        Me.ControlTestToolStripMenuItem.Name = "ControlTestToolStripMenuItem"
        Me.ControlTestToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.ControlTestToolStripMenuItem.Text = "ControlTest"
        Me.ControlTestToolStripMenuItem.Visible = False
        '
        'Panel_textInput
        '
        Me.Panel_textInput.Controls.Add(Me.TextTootl)
        Me.Panel_textInput.Controls.Add(Me.Panel_bottom)
        Me.Panel_textInput.Location = New System.Drawing.Point(0, 104)
        Me.Panel_textInput.Name = "Panel_textInput"
        Me.Panel_textInput.Size = New System.Drawing.Size(634, 176)
        Me.Panel_textInput.TabIndex = 5
        Me.Panel_textInput.Visible = False
        '
        'TextTootl
        '
        Me.TextTootl.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextTootl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextTootl.Location = New System.Drawing.Point(0, 0)
        Me.TextTootl.Multiline = True
        Me.TextTootl.Name = "TextTootl"
        Me.TextTootl.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextTootl.Size = New System.Drawing.Size(634, 142)
        Me.TextTootl.TabIndex = 39
        Me.TextTootl.WordWrap = False
        '
        'Panel_bottom
        '
        Me.Panel_bottom.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel_bottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel_bottom.Controls.Add(Me.B_FontChange)
        Me.Panel_bottom.Controls.Add(Me.B_ClearTextIn)
        Me.Panel_bottom.Controls.Add(Me.Panel_cornor)
        Me.Panel_bottom.Controls.Add(Me.B_hideTextIn)
        Me.Panel_bottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel_bottom.Location = New System.Drawing.Point(0, 142)
        Me.Panel_bottom.Name = "Panel_bottom"
        Me.Panel_bottom.Size = New System.Drawing.Size(634, 34)
        Me.Panel_bottom.TabIndex = 43
        '
        'B_FontChange
        '
        Me.B_FontChange.BackColor = System.Drawing.Color.White
        Me.B_FontChange.Dock = System.Windows.Forms.DockStyle.Left
        Me.B_FontChange.Enabled = False
        Me.B_FontChange.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.B_FontChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.B_FontChange.Font = New System.Drawing.Font("Calibri", 14.25!)
        Me.B_FontChange.ForeColor = System.Drawing.Color.Black
        Me.B_FontChange.Location = New System.Drawing.Point(64, 0)
        Me.B_FontChange.Margin = New System.Windows.Forms.Padding(0)
        Me.B_FontChange.Name = "B_FontChange"
        Me.B_FontChange.Size = New System.Drawing.Size(32, 32)
        Me.B_FontChange.TabIndex = 42
        Me.B_FontChange.TabStop = False
        Me.B_FontChange.Text = "F"
        Me.mytooltips.SetToolTip(Me.B_FontChange, "Change Font")
        Me.B_FontChange.UseVisualStyleBackColor = False
        '
        'B_ClearTextIn
        '
        Me.B_ClearTextIn.BackColor = System.Drawing.Color.Beige
        Me.B_ClearTextIn.Dock = System.Windows.Forms.DockStyle.Left
        Me.B_ClearTextIn.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.B_ClearTextIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.B_ClearTextIn.Font = New System.Drawing.Font("Wingdings", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.B_ClearTextIn.ForeColor = System.Drawing.Color.Black
        Me.B_ClearTextIn.Location = New System.Drawing.Point(32, 0)
        Me.B_ClearTextIn.Margin = New System.Windows.Forms.Padding(0)
        Me.B_ClearTextIn.Name = "B_ClearTextIn"
        Me.B_ClearTextIn.Size = New System.Drawing.Size(32, 32)
        Me.B_ClearTextIn.TabIndex = 41
        Me.B_ClearTextIn.TabStop = False
        Me.B_ClearTextIn.Text = "l"
        Me.mytooltips.SetToolTip(Me.B_ClearTextIn, "Clear")
        Me.B_ClearTextIn.UseVisualStyleBackColor = False
        '
        'Panel_cornor
        '
        Me.Panel_cornor.BackColor = System.Drawing.Color.DimGray
        Me.Panel_cornor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel_cornor.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel_cornor.Location = New System.Drawing.Point(622, 0)
        Me.Panel_cornor.Name = "Panel_cornor"
        Me.Panel_cornor.Size = New System.Drawing.Size(10, 32)
        Me.Panel_cornor.TabIndex = 44
        '
        'B_hideTextIn
        '
        Me.B_hideTextIn.BackColor = System.Drawing.Color.IndianRed
        Me.B_hideTextIn.Dock = System.Windows.Forms.DockStyle.Left
        Me.B_hideTextIn.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.B_hideTextIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.B_hideTextIn.Font = New System.Drawing.Font("Wingdings", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.B_hideTextIn.ForeColor = System.Drawing.Color.Black
        Me.B_hideTextIn.Location = New System.Drawing.Point(0, 0)
        Me.B_hideTextIn.Margin = New System.Windows.Forms.Padding(0)
        Me.B_hideTextIn.Name = "B_hideTextIn"
        Me.B_hideTextIn.Size = New System.Drawing.Size(32, 32)
        Me.B_hideTextIn.TabIndex = 40
        Me.B_hideTextIn.TabStop = False
        Me.B_hideTextIn.Text = "û"
        Me.mytooltips.SetToolTip(Me.B_hideTextIn, "Hide [ Escape ]")
        Me.B_hideTextIn.UseVisualStyleBackColor = False
        '
        'Panel_tools
        '
        Me.Panel_tools.BackColor = System.Drawing.Color.White
        Me.Panel_tools.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel_tools.ContextMenuStrip = Me.cms_canvasctrl
        Me.Panel_tools.Controls.Add(Me.rb_pointer)
        Me.Panel_tools.Controls.Add(Me.rb_marker)
        Me.Panel_tools.Controls.Add(Me.rb_caligraphy)
        Me.Panel_tools.Controls.Add(Me.NUD_ANGLEsel)
        Me.Panel_tools.Controls.Add(Me.rb_path)
        Me.Panel_tools.Controls.Add(Me.rb_table)
        Me.Panel_tools.Controls.Add(Me.rb_ellipse)
        Me.Panel_tools.Controls.Add(Me.rb_screencopy)
        Me.Panel_tools.Controls.Add(Me.rb_SelectR)
        Me.Panel_tools.Controls.Add(Me.rb_paste)
        Me.Panel_tools.Controls.Add(Me.rb_pasteR)
        Me.Panel_tools.Controls.Add(Me.rb_eraser)
        Me.Panel_tools.Controls.Add(Me.rb_text)
        Me.Panel_tools.Controls.Add(Me.rb_colorpick)
        Me.Panel_tools.Controls.Add(Me.rb_axismarker)
        Me.Panel_tools.Controls.Add(Me.Panel3)
        Me.Panel_tools.Controls.Add(Me.chk_showScale)
        Me.Panel_tools.Controls.Add(Me.Check_dropPP)
        Me.Panel_tools.Controls.Add(Me.B_inputfocus)
        Me.Panel_tools.Controls.Add(Me.CheckBox_lockXscroll)
        Me.Panel_tools.Controls.Add(Me.CheckBox_lockYscroll)
        Me.Panel_tools.Controls.Add(Me.B_Undo)
        Me.Panel_tools.Controls.Add(Me.B_Redo)
        Me.Panel_tools.Controls.Add(Me.Check_erasretrail)
        Me.Panel_tools.Controls.Add(Me.chk_fillOn)
        Me.Panel_tools.Controls.Add(Me.chk_rainbow)
        Me.Panel_tools.Controls.Add(Me.Check_copy2clip)
        Me.Panel_tools.Controls.Add(Me.Check_fixedToolbox)
        Me.Panel_tools.Controls.Add(Me.Check_showCoords)
        Me.Panel_tools.Controls.Add(Me.b_close)
        Me.Panel_tools.Location = New System.Drawing.Point(247, 3)
        Me.Panel_tools.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel_tools.Name = "Panel_tools"
        Me.Panel_tools.Size = New System.Drawing.Size(354, 98)
        Me.Panel_tools.TabIndex = 38
        Me.Panel_tools.Visible = False
        '
        'rb_pointer
        '
        Me.rb_pointer.Appearance = System.Windows.Forms.Appearance.Button
        Me.rb_pointer.BackColor = System.Drawing.Color.White
        Me.rb_pointer.Checked = True
        Me.rb_pointer.FlatAppearance.CheckedBackColor = System.Drawing.Color.Plum
        Me.rb_pointer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rb_pointer.Font = New System.Drawing.Font("Wingdings", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.rb_pointer.Location = New System.Drawing.Point(0, 0)
        Me.rb_pointer.Margin = New System.Windows.Forms.Padding(0)
        Me.rb_pointer.Name = "rb_pointer"
        Me.rb_pointer.Size = New System.Drawing.Size(32, 32)
        Me.rb_pointer.TabIndex = 1
        Me.rb_pointer.TabStop = True
        Me.rb_pointer.Tag = "0"
        Me.rb_pointer.Text = "8"
        Me.rb_pointer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.mytooltips.SetToolTip(Me.rb_pointer, "Tool: Pointer [ P ]" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Hint: Click on canvas to center screen that point")
        Me.rb_pointer.UseVisualStyleBackColor = False
        '
        'rb_marker
        '
        Me.rb_marker.Appearance = System.Windows.Forms.Appearance.Button
        Me.rb_marker.BackColor = System.Drawing.Color.White
        Me.rb_marker.FlatAppearance.CheckedBackColor = System.Drawing.Color.Plum
        Me.rb_marker.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rb_marker.Font = New System.Drawing.Font("Wingdings", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.rb_marker.Location = New System.Drawing.Point(32, 0)
        Me.rb_marker.Margin = New System.Windows.Forms.Padding(0)
        Me.rb_marker.Name = "rb_marker"
        Me.rb_marker.Size = New System.Drawing.Size(32, 32)
        Me.rb_marker.TabIndex = 2
        Me.rb_marker.Tag = "1"
        Me.rb_marker.Text = "!"
        Me.rb_marker.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.mytooltips.SetToolTip(Me.rb_marker, "Tool: Marker  [ M ]")
        Me.rb_marker.UseVisualStyleBackColor = False
        '
        'rb_caligraphy
        '
        Me.rb_caligraphy.Appearance = System.Windows.Forms.Appearance.Button
        Me.rb_caligraphy.BackColor = System.Drawing.Color.White
        Me.rb_caligraphy.FlatAppearance.CheckedBackColor = System.Drawing.Color.Plum
        Me.rb_caligraphy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rb_caligraphy.Font = New System.Drawing.Font("Wingdings", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.rb_caligraphy.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.rb_caligraphy.Location = New System.Drawing.Point(64, 0)
        Me.rb_caligraphy.Margin = New System.Windows.Forms.Padding(0)
        Me.rb_caligraphy.Name = "rb_caligraphy"
        Me.rb_caligraphy.Size = New System.Drawing.Size(32, 32)
        Me.rb_caligraphy.TabIndex = 3
        Me.rb_caligraphy.Tag = "15"
        Me.rb_caligraphy.Text = "!"
        Me.rb_caligraphy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.mytooltips.SetToolTip(Me.rb_caligraphy, "Tool: Caligraphy [ N ]")
        Me.rb_caligraphy.UseVisualStyleBackColor = False
        '
        'NUD_ANGLEsel
        '
        Me.NUD_ANGLEsel.BackColor = System.Drawing.Color.White
        Me.NUD_ANGLEsel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NUD_ANGLEsel.DialMode = False
        Me.NUD_ANGLEsel.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NUD_ANGLEsel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.NUD_ANGLEsel.HugeChange = 45.0!
        Me.NUD_ANGLEsel.LargeChange = 10.0!
        Me.NUD_ANGLEsel.Location = New System.Drawing.Point(96, 0)
        Me.NUD_ANGLEsel.Margin = New System.Windows.Forms.Padding(0)
        Me.NUD_ANGLEsel.Name = "NUD_ANGLEsel"
        Me.NUD_ANGLEsel.Padding = New System.Windows.Forms.Padding(2)
        Me.NUD_ANGLEsel.Size = New System.Drawing.Size(32, 32)
        Me.NUD_ANGLEsel.SmallChange = 1.0!
        Me.NUD_ANGLEsel.TabIndex = 4
        Me.NUD_ANGLEsel.TabStop = False
        Me.mytooltips.SetToolTip(Me.NUD_ANGLEsel, "Inclination or Slope for Calligraphy Brush")
        '
        'rb_path
        '
        Me.rb_path.Appearance = System.Windows.Forms.Appearance.Button
        Me.rb_path.BackColor = System.Drawing.Color.White
        Me.rb_path.FlatAppearance.CheckedBackColor = System.Drawing.Color.Plum
        Me.rb_path.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rb_path.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_path.Location = New System.Drawing.Point(128, 0)
        Me.rb_path.Margin = New System.Windows.Forms.Padding(0)
        Me.rb_path.Name = "rb_path"
        Me.rb_path.Size = New System.Drawing.Size(32, 32)
        Me.rb_path.TabIndex = 7
        Me.rb_path.Tag = "8"
        Me.rb_path.Text = "\_/"
        Me.rb_path.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.mytooltips.SetToolTip(Me.rb_path, "Tool: Path [ H ]" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Points Required: unlimited" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " Pn: nth point in path" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Draw st" &
        "right line segments b/w consicutive points")
        Me.rb_path.UseVisualStyleBackColor = False
        '
        'rb_table
        '
        Me.rb_table.Appearance = System.Windows.Forms.Appearance.Button
        Me.rb_table.BackColor = System.Drawing.Color.White
        Me.rb_table.ContextMenuStrip = Me.cms_tableTool
        Me.rb_table.FlatAppearance.CheckedBackColor = System.Drawing.Color.Plum
        Me.rb_table.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rb_table.Font = New System.Drawing.Font("Webdings", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.rb_table.Location = New System.Drawing.Point(160, 0)
        Me.rb_table.Margin = New System.Windows.Forms.Padding(0)
        Me.rb_table.Name = "rb_table"
        Me.rb_table.Size = New System.Drawing.Size(32, 32)
        Me.rb_table.TabIndex = 9
        Me.rb_table.Tag = "7"
        Me.rb_table.Text = ""
        Me.rb_table.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.mytooltips.SetToolTip(Me.rb_table, resources.GetString("rb_table.ToolTip"))
        Me.rb_table.UseVisualStyleBackColor = False
        '
        'cms_tableTool
        '
        Me.cms_tableTool.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tstb_rows, Me.tstb_cols})
        Me.cms_tableTool.Name = "cms_tableTool"
        Me.cms_tableTool.ShowImageMargin = False
        Me.cms_tableTool.Size = New System.Drawing.Size(136, 54)
        Me.cms_tableTool.Text = "3"
        '
        'tstb_rows
        '
        Me.tstb_rows.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tstb_rows.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tstb_rows.Name = "tstb_rows"
        Me.tstb_rows.Size = New System.Drawing.Size(100, 23)
        Me.tstb_rows.Text = "3"
        '
        'tstb_cols
        '
        Me.tstb_cols.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tstb_cols.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tstb_cols.Name = "tstb_cols"
        Me.tstb_cols.Size = New System.Drawing.Size(100, 23)
        Me.tstb_cols.Text = "3"
        '
        'rb_ellipse
        '
        Me.rb_ellipse.Appearance = System.Windows.Forms.Appearance.Button
        Me.rb_ellipse.BackColor = System.Drawing.Color.White
        Me.rb_ellipse.FlatAppearance.CheckedBackColor = System.Drawing.Color.Plum
        Me.rb_ellipse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rb_ellipse.Font = New System.Drawing.Font("Wingdings", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.rb_ellipse.Location = New System.Drawing.Point(192, 0)
        Me.rb_ellipse.Margin = New System.Windows.Forms.Padding(0)
        Me.rb_ellipse.Name = "rb_ellipse"
        Me.rb_ellipse.Size = New System.Drawing.Size(32, 32)
        Me.rb_ellipse.TabIndex = 11
        Me.rb_ellipse.Tag = "4"
        Me.rb_ellipse.Text = "¡"
        Me.rb_ellipse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.mytooltips.SetToolTip(Me.rb_ellipse, "Tool: Ellipse [ I ]" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Points Required: 2" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " P1: Diagonal Start Point" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " P2: Diagon" &
        "al End Point" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Draw an ellipse within a rectangle " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "with its diagonal points at" &
        " P1, P2")
        Me.rb_ellipse.UseVisualStyleBackColor = False
        '
        'rb_screencopy
        '
        Me.rb_screencopy.Appearance = System.Windows.Forms.Appearance.Button
        Me.rb_screencopy.BackColor = System.Drawing.Color.White
        Me.rb_screencopy.ContextMenuStrip = Me.cms_ScreenCopy
        Me.rb_screencopy.FlatAppearance.CheckedBackColor = System.Drawing.Color.Plum
        Me.rb_screencopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rb_screencopy.Font = New System.Drawing.Font("Wingdings", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.rb_screencopy.Location = New System.Drawing.Point(224, 0)
        Me.rb_screencopy.Margin = New System.Windows.Forms.Padding(0)
        Me.rb_screencopy.Name = "rb_screencopy"
        Me.rb_screencopy.Size = New System.Drawing.Size(32, 32)
        Me.rb_screencopy.TabIndex = 14
        Me.rb_screencopy.Tag = "13"
        Me.rb_screencopy.Text = "Ì"
        Me.rb_screencopy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.mytooltips.SetToolTip(Me.rb_screencopy, resources.GetString("rb_screencopy.ToolTip"))
        Me.rb_screencopy.UseVisualStyleBackColor = False
        '
        'cms_ScreenCopy
        '
        Me.cms_ScreenCopy.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToFileToolStripMenuItem})
        Me.cms_ScreenCopy.Name = "cms_ScreenCopy"
        Me.cms_ScreenCopy.ShowCheckMargin = True
        Me.cms_ScreenCopy.ShowImageMargin = False
        Me.cms_ScreenCopy.Size = New System.Drawing.Size(134, 26)
        '
        'SaveToFileToolStripMenuItem
        '
        Me.SaveToFileToolStripMenuItem.CheckOnClick = True
        Me.SaveToFileToolStripMenuItem.Name = "SaveToFileToolStripMenuItem"
        Me.SaveToFileToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.SaveToFileToolStripMenuItem.Text = "Save to File"
        '
        'rb_SelectR
        '
        Me.rb_SelectR.Appearance = System.Windows.Forms.Appearance.Button
        Me.rb_SelectR.BackColor = System.Drawing.Color.White
        Me.rb_SelectR.ContextMenuStrip = Me.cms_Selection
        Me.rb_SelectR.FlatAppearance.CheckedBackColor = System.Drawing.Color.Plum
        Me.rb_SelectR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rb_SelectR.Font = New System.Drawing.Font("Webdings", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.rb_SelectR.Location = New System.Drawing.Point(256, 0)
        Me.rb_SelectR.Margin = New System.Windows.Forms.Padding(0)
        Me.rb_SelectR.Name = "rb_SelectR"
        Me.rb_SelectR.Size = New System.Drawing.Size(32, 32)
        Me.rb_SelectR.TabIndex = 83
        Me.rb_SelectR.Tag = "20"
        Me.rb_SelectR.Text = "`"
        Me.rb_SelectR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.mytooltips.SetToolTip(Me.rb_SelectR, resources.GetString("rb_SelectR.ToolTip"))
        Me.rb_SelectR.UseVisualStyleBackColor = False
        '
        'cms_Selection
        '
        Me.cms_Selection.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelCutToolStripMenuItem, Me.SelCopyToolStripMenuItem, Me.SelSaveToolStripMenuItem, Me.SelClearToolStripMenuItem})
        Me.cms_Selection.Name = "cms_Selection"
        Me.cms_Selection.ShowImageMargin = False
        Me.cms_Selection.Size = New System.Drawing.Size(124, 92)
        '
        'SelCutToolStripMenuItem
        '
        Me.SelCutToolStripMenuItem.Name = "SelCutToolStripMenuItem"
        Me.SelCutToolStripMenuItem.ShortcutKeyDisplayString = "ctrl + X"
        Me.SelCutToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.SelCutToolStripMenuItem.Text = "Cut"
        '
        'SelCopyToolStripMenuItem
        '
        Me.SelCopyToolStripMenuItem.Name = "SelCopyToolStripMenuItem"
        Me.SelCopyToolStripMenuItem.ShortcutKeyDisplayString = "ctrl + C"
        Me.SelCopyToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.SelCopyToolStripMenuItem.Text = "Copy"
        '
        'SelSaveToolStripMenuItem
        '
        Me.SelSaveToolStripMenuItem.Name = "SelSaveToolStripMenuItem"
        Me.SelSaveToolStripMenuItem.ShortcutKeyDisplayString = "ctrl + S"
        Me.SelSaveToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.SelSaveToolStripMenuItem.Text = "Save"
        '
        'SelClearToolStripMenuItem
        '
        Me.SelClearToolStripMenuItem.Name = "SelClearToolStripMenuItem"
        Me.SelClearToolStripMenuItem.ShortcutKeyDisplayString = "Delete"
        Me.SelClearToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.SelClearToolStripMenuItem.Text = "Clear"
        '
        'rb_paste
        '
        Me.rb_paste.Appearance = System.Windows.Forms.Appearance.Button
        Me.rb_paste.BackColor = System.Drawing.Color.White
        Me.rb_paste.FlatAppearance.CheckedBackColor = System.Drawing.Color.Plum
        Me.rb_paste.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rb_paste.Font = New System.Drawing.Font("Wingdings", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.rb_paste.Location = New System.Drawing.Point(288, 0)
        Me.rb_paste.Margin = New System.Windows.Forms.Padding(0)
        Me.rb_paste.Name = "rb_paste"
        Me.rb_paste.Size = New System.Drawing.Size(32, 32)
        Me.rb_paste.TabIndex = 17
        Me.rb_paste.Tag = "10"
        Me.rb_paste.Text = "w"
        Me.rb_paste.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.mytooltips.SetToolTip(Me.rb_paste, "Tool: Paste [ ctrl + V ]" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Points Required: 1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Paste Image from Clipboard at Poi" &
        "nt P1")
        Me.rb_paste.UseVisualStyleBackColor = False
        '
        'rb_pasteR
        '
        Me.rb_pasteR.Appearance = System.Windows.Forms.Appearance.Button
        Me.rb_pasteR.BackColor = System.Drawing.Color.White
        Me.rb_pasteR.FlatAppearance.CheckedBackColor = System.Drawing.Color.Plum
        Me.rb_pasteR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rb_pasteR.Font = New System.Drawing.Font("Wingdings", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.rb_pasteR.Location = New System.Drawing.Point(320, 0)
        Me.rb_pasteR.Margin = New System.Windows.Forms.Padding(0)
        Me.rb_pasteR.Name = "rb_pasteR"
        Me.rb_pasteR.Size = New System.Drawing.Size(32, 32)
        Me.rb_pasteR.TabIndex = 18
        Me.rb_pasteR.Tag = "11"
        Me.rb_pasteR.Text = "v"
        Me.rb_pasteR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.mytooltips.SetToolTip(Me.rb_pasteR, "Tool: Paste Rectangle [ shift + V ]" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Points Required: 2" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Paste Image from Clipb" &
        "oard in a  rectangular region " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "specified by Diagonal Points P1, P2" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.rb_pasteR.UseVisualStyleBackColor = False
        '
        'rb_eraser
        '
        Me.rb_eraser.Appearance = System.Windows.Forms.Appearance.Button
        Me.rb_eraser.BackColor = System.Drawing.Color.White
        Me.rb_eraser.FlatAppearance.CheckedBackColor = System.Drawing.Color.Plum
        Me.rb_eraser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rb_eraser.Font = New System.Drawing.Font("Wingdings", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.rb_eraser.Location = New System.Drawing.Point(0, 32)
        Me.rb_eraser.Margin = New System.Windows.Forms.Padding(0)
        Me.rb_eraser.Name = "rb_eraser"
        Me.rb_eraser.Size = New System.Drawing.Size(32, 32)
        Me.rb_eraser.TabIndex = 5
        Me.rb_eraser.Tag = "14"
        Me.rb_eraser.Text = "Õ"
        Me.rb_eraser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.mytooltips.SetToolTip(Me.rb_eraser, "Tool: Eraser [ E ]")
        Me.rb_eraser.UseVisualStyleBackColor = False
        '
        'rb_text
        '
        Me.rb_text.Appearance = System.Windows.Forms.Appearance.Button
        Me.rb_text.BackColor = System.Drawing.Color.White
        Me.rb_text.ContextMenuStrip = Me.cms_textTool
        Me.rb_text.FlatAppearance.CheckedBackColor = System.Drawing.Color.Plum
        Me.rb_text.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rb_text.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_text.Location = New System.Drawing.Point(32, 32)
        Me.rb_text.Margin = New System.Windows.Forms.Padding(0)
        Me.rb_text.Name = "rb_text"
        Me.rb_text.Size = New System.Drawing.Size(32, 32)
        Me.rb_text.TabIndex = 19
        Me.rb_text.Tag = "19"
        Me.rb_text.Text = "T"
        Me.rb_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.mytooltips.SetToolTip(Me.rb_text, "Tool: Text Insert [ T ] (right-click to see more)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Hint: use [ ctrl + T ] to see " &
        "text input" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "          use [ shift + T ] to toogle clipboard text" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.rb_text.UseVisualStyleBackColor = False
        '
        'cms_textTool
        '
        Me.cms_textTool.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FromClipboardToolStripMenuItem, Me.EnterTextToolStripMenuItem})
        Me.cms_textTool.Name = "cms_textTool"
        Me.cms_textTool.ShowCheckMargin = True
        Me.cms_textTool.ShowImageMargin = False
        Me.cms_textTool.Size = New System.Drawing.Size(158, 48)
        '
        'FromClipboardToolStripMenuItem
        '
        Me.FromClipboardToolStripMenuItem.CheckOnClick = True
        Me.FromClipboardToolStripMenuItem.Name = "FromClipboardToolStripMenuItem"
        Me.FromClipboardToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.FromClipboardToolStripMenuItem.Text = "From Clipboard"
        '
        'EnterTextToolStripMenuItem
        '
        Me.EnterTextToolStripMenuItem.Name = "EnterTextToolStripMenuItem"
        Me.EnterTextToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.EnterTextToolStripMenuItem.Text = "Enter Text"
        '
        'rb_colorpick
        '
        Me.rb_colorpick.Appearance = System.Windows.Forms.Appearance.Button
        Me.rb_colorpick.BackColor = System.Drawing.Color.White
        Me.rb_colorpick.FlatAppearance.CheckedBackColor = System.Drawing.Color.Plum
        Me.rb_colorpick.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rb_colorpick.Font = New System.Drawing.Font("Wingdings", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.rb_colorpick.Location = New System.Drawing.Point(64, 32)
        Me.rb_colorpick.Margin = New System.Windows.Forms.Padding(0)
        Me.rb_colorpick.Name = "rb_colorpick"
        Me.rb_colorpick.Size = New System.Drawing.Size(32, 32)
        Me.rb_colorpick.TabIndex = 21
        Me.rb_colorpick.Tag = "16"
        Me.rb_colorpick.Text = "µ"
        Me.rb_colorpick.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.mytooltips.SetToolTip(Me.rb_colorpick, "Tool: Color Picker [ K ]")
        Me.rb_colorpick.UseVisualStyleBackColor = False
        '
        'rb_axismarker
        '
        Me.rb_axismarker.Appearance = System.Windows.Forms.Appearance.Button
        Me.rb_axismarker.BackColor = System.Drawing.Color.White
        Me.rb_axismarker.FlatAppearance.CheckedBackColor = System.Drawing.Color.Plum
        Me.rb_axismarker.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rb_axismarker.Font = New System.Drawing.Font("Wingdings", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.rb_axismarker.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.rb_axismarker.Location = New System.Drawing.Point(96, 32)
        Me.rb_axismarker.Margin = New System.Windows.Forms.Padding(0)
        Me.rb_axismarker.Name = "rb_axismarker"
        Me.rb_axismarker.Size = New System.Drawing.Size(32, 32)
        Me.rb_axismarker.TabIndex = 22
        Me.rb_axismarker.Tag = "9"
        Me.rb_axismarker.Text = "±"
        Me.rb_axismarker.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.mytooltips.SetToolTip(Me.rb_axismarker, "Tool: Axis Marker [ U ]" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Mark points relative to axis that are not drawn on ima" &
        "ge." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Note: Points don't translate with Pan or Zoom")
        Me.rb_axismarker.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.nud_rotXangle)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.B_clearaxisPots)
        Me.Panel3.Location = New System.Drawing.Point(128, 32)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(64, 32)
        Me.Panel3.TabIndex = 82
        '
        'nud_rotXangle
        '
        Me.nud_rotXangle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.nud_rotXangle.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.nud_rotXangle.Font = New System.Drawing.Font("Calibri", 8.25!)
        Me.nud_rotXangle.Location = New System.Drawing.Point(32, 2)
        Me.nud_rotXangle.Name = "nud_rotXangle"
        Me.nud_rotXangle.Size = New System.Drawing.Size(32, 14)
        Me.nud_rotXangle.TabIndex = 24
        Me.nud_rotXangle.TabStop = False
        Me.nud_rotXangle.Text = "0"
        Me.nud_rotXangle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.mytooltips.SetToolTip(Me.nud_rotXangle, "Axis Rotation - Use arrow keys to rotate")
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(31, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 32)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "deg"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'B_clearaxisPots
        '
        Me.B_clearaxisPots.BackColor = System.Drawing.Color.White
        Me.B_clearaxisPots.Dock = System.Windows.Forms.DockStyle.Left
        Me.B_clearaxisPots.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.B_clearaxisPots.Font = New System.Drawing.Font("Wingdings", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.B_clearaxisPots.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.B_clearaxisPots.Location = New System.Drawing.Point(0, 0)
        Me.B_clearaxisPots.Margin = New System.Windows.Forms.Padding(0)
        Me.B_clearaxisPots.Name = "B_clearaxisPots"
        Me.B_clearaxisPots.Size = New System.Drawing.Size(32, 32)
        Me.B_clearaxisPots.TabIndex = 23
        Me.B_clearaxisPots.TabStop = False
        Me.B_clearaxisPots.Text = "³"
        Me.mytooltips.SetToolTip(Me.B_clearaxisPots, "Clear Axis Points [ ctrl + U ]")
        Me.B_clearaxisPots.UseVisualStyleBackColor = False
        '
        'chk_showScale
        '
        Me.chk_showScale.Appearance = System.Windows.Forms.Appearance.Button
        Me.chk_showScale.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.chk_showScale.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.chk_showScale.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chk_showScale.Font = New System.Drawing.Font("Wingdings", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.chk_showScale.Location = New System.Drawing.Point(192, 32)
        Me.chk_showScale.Margin = New System.Windows.Forms.Padding(0)
        Me.chk_showScale.Name = "chk_showScale"
        Me.chk_showScale.Size = New System.Drawing.Size(32, 32)
        Me.chk_showScale.TabIndex = 26
        Me.chk_showScale.TabStop = False
        Me.chk_showScale.Text = "°"
        Me.chk_showScale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.mytooltips.SetToolTip(Me.chk_showScale, "Show Axis [ shift + U ]")
        Me.chk_showScale.UseVisualStyleBackColor = False
        '
        'Check_dropPP
        '
        Me.Check_dropPP.Appearance = System.Windows.Forms.Appearance.Button
        Me.Check_dropPP.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Check_dropPP.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Check_dropPP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Check_dropPP.Font = New System.Drawing.Font("Wingdings", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Check_dropPP.Location = New System.Drawing.Point(224, 32)
        Me.Check_dropPP.Margin = New System.Windows.Forms.Padding(0)
        Me.Check_dropPP.Name = "Check_dropPP"
        Me.Check_dropPP.Size = New System.Drawing.Size(32, 32)
        Me.Check_dropPP.TabIndex = 27
        Me.Check_dropPP.TabStop = False
        Me.Check_dropPP.Text = "d"
        Me.Check_dropPP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.mytooltips.SetToolTip(Me.Check_dropPP, "Drop Perpendiculars [ alt + U ]" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " ... on both axis, from marked axis points")
        Me.Check_dropPP.UseVisualStyleBackColor = False
        '
        'B_inputfocus
        '
        Me.B_inputfocus.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.B_inputfocus.Enabled = False
        Me.B_inputfocus.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.B_inputfocus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.B_inputfocus.Font = New System.Drawing.Font("Wingdings", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.B_inputfocus.ForeColor = System.Drawing.Color.Black
        Me.B_inputfocus.Location = New System.Drawing.Point(256, 32)
        Me.B_inputfocus.Margin = New System.Windows.Forms.Padding(0)
        Me.B_inputfocus.Name = "B_inputfocus"
        Me.B_inputfocus.Size = New System.Drawing.Size(32, 32)
        Me.B_inputfocus.TabIndex = 84
        Me.B_inputfocus.TabStop = False
        Me.B_inputfocus.Text = "7"
        Me.mytooltips.SetToolTip(Me.B_inputfocus, "Indicates if currently accepting keyboard inputs" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Note: this is just an indicat" &
        "or, automatically " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "changes values indicating if the textbox for " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "detecting key" &
        "strokes has focus or not")
        Me.B_inputfocus.UseVisualStyleBackColor = False
        '
        'CheckBox_lockXscroll
        '
        Me.CheckBox_lockXscroll.Appearance = System.Windows.Forms.Appearance.Button
        Me.CheckBox_lockXscroll.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CheckBox_lockXscroll.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CheckBox_lockXscroll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox_lockXscroll.Font = New System.Drawing.Font("Wingdings", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.CheckBox_lockXscroll.Location = New System.Drawing.Point(288, 32)
        Me.CheckBox_lockXscroll.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBox_lockXscroll.Name = "CheckBox_lockXscroll"
        Me.CheckBox_lockXscroll.Size = New System.Drawing.Size(32, 32)
        Me.CheckBox_lockXscroll.TabIndex = 31
        Me.CheckBox_lockXscroll.TabStop = False
        Me.CheckBox_lockXscroll.Text = "ó"
        Me.CheckBox_lockXscroll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.mytooltips.SetToolTip(Me.CheckBox_lockXscroll, resources.GetString("CheckBox_lockXscroll.ToolTip"))
        Me.CheckBox_lockXscroll.UseVisualStyleBackColor = False
        '
        'CheckBox_lockYscroll
        '
        Me.CheckBox_lockYscroll.Appearance = System.Windows.Forms.Appearance.Button
        Me.CheckBox_lockYscroll.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CheckBox_lockYscroll.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CheckBox_lockYscroll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox_lockYscroll.Font = New System.Drawing.Font("Wingdings", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.CheckBox_lockYscroll.Location = New System.Drawing.Point(320, 32)
        Me.CheckBox_lockYscroll.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBox_lockYscroll.Name = "CheckBox_lockYscroll"
        Me.CheckBox_lockYscroll.Size = New System.Drawing.Size(32, 32)
        Me.CheckBox_lockYscroll.TabIndex = 32
        Me.CheckBox_lockYscroll.TabStop = False
        Me.CheckBox_lockYscroll.Text = "ô"
        Me.CheckBox_lockYscroll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.mytooltips.SetToolTip(Me.CheckBox_lockYscroll, resources.GetString("CheckBox_lockYscroll.ToolTip"))
        Me.CheckBox_lockYscroll.UseVisualStyleBackColor = False
        '
        'B_Undo
        '
        Me.B_Undo.BackColor = System.Drawing.Color.White
        Me.B_Undo.Enabled = False
        Me.B_Undo.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.B_Undo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.B_Undo.Font = New System.Drawing.Font("Wingdings", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.B_Undo.ForeColor = System.Drawing.Color.Red
        Me.B_Undo.Location = New System.Drawing.Point(0, 64)
        Me.B_Undo.Margin = New System.Windows.Forms.Padding(0)
        Me.B_Undo.Name = "B_Undo"
        Me.B_Undo.Size = New System.Drawing.Size(32, 32)
        Me.B_Undo.TabIndex = 28
        Me.B_Undo.TabStop = False
        Me.B_Undo.Text = "Û"
        Me.mytooltips.SetToolTip(Me.B_Undo, "Undo [ ctrl + Z ]")
        Me.B_Undo.UseVisualStyleBackColor = False
        '
        'B_Redo
        '
        Me.B_Redo.BackColor = System.Drawing.Color.White
        Me.B_Redo.Enabled = False
        Me.B_Redo.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.B_Redo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.B_Redo.Font = New System.Drawing.Font("Wingdings", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.B_Redo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.B_Redo.Location = New System.Drawing.Point(32, 64)
        Me.B_Redo.Margin = New System.Windows.Forms.Padding(0)
        Me.B_Redo.Name = "B_Redo"
        Me.B_Redo.Size = New System.Drawing.Size(32, 32)
        Me.B_Redo.TabIndex = 29
        Me.B_Redo.TabStop = False
        Me.B_Redo.Text = "Ü"
        Me.mytooltips.SetToolTip(Me.B_Redo, "Redo [ ctrl + Y ]")
        Me.B_Redo.UseVisualStyleBackColor = False
        '
        'Check_erasretrail
        '
        Me.Check_erasretrail.Appearance = System.Windows.Forms.Appearance.Button
        Me.Check_erasretrail.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Check_erasretrail.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Check_erasretrail.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Check_erasretrail.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Check_erasretrail.Font = New System.Drawing.Font("Wingdings", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Check_erasretrail.Location = New System.Drawing.Point(64, 64)
        Me.Check_erasretrail.Margin = New System.Windows.Forms.Padding(0)
        Me.Check_erasretrail.Name = "Check_erasretrail"
        Me.Check_erasretrail.Size = New System.Drawing.Size(32, 32)
        Me.Check_erasretrail.TabIndex = 33
        Me.Check_erasretrail.TabStop = False
        Me.Check_erasretrail.Tag = ""
        Me.Check_erasretrail.Text = "m"
        Me.Check_erasretrail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.mytooltips.SetToolTip(Me.Check_erasretrail, "Flag: Enable Eraser Trace [ shift + E ]")
        Me.Check_erasretrail.UseVisualStyleBackColor = False
        '
        'chk_fillOn
        '
        Me.chk_fillOn.Appearance = System.Windows.Forms.Appearance.Button
        Me.chk_fillOn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.chk_fillOn.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chk_fillOn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.chk_fillOn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chk_fillOn.Font = New System.Drawing.Font("Wingdings", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.chk_fillOn.Location = New System.Drawing.Point(96, 64)
        Me.chk_fillOn.Margin = New System.Windows.Forms.Padding(0)
        Me.chk_fillOn.Name = "chk_fillOn"
        Me.chk_fillOn.Size = New System.Drawing.Size(32, 32)
        Me.chk_fillOn.TabIndex = 13
        Me.chk_fillOn.TabStop = False
        Me.chk_fillOn.Tag = ""
        Me.chk_fillOn.Text = "S"
        Me.chk_fillOn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.mytooltips.SetToolTip(Me.chk_fillOn, "Flag: Enable Fill Mode")
        Me.chk_fillOn.UseVisualStyleBackColor = False
        '
        'chk_rainbow
        '
        Me.chk_rainbow.Appearance = System.Windows.Forms.Appearance.Button
        Me.chk_rainbow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.chk_rainbow.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chk_rainbow.ContextMenuStrip = Me.cms_rainbow
        Me.chk_rainbow.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.chk_rainbow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chk_rainbow.Font = New System.Drawing.Font("Wingdings", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.chk_rainbow.Location = New System.Drawing.Point(128, 64)
        Me.chk_rainbow.Margin = New System.Windows.Forms.Padding(0)
        Me.chk_rainbow.Name = "chk_rainbow"
        Me.chk_rainbow.Size = New System.Drawing.Size(32, 32)
        Me.chk_rainbow.TabIndex = 34
        Me.chk_rainbow.TabStop = False
        Me.chk_rainbow.Tag = ""
        Me.chk_rainbow.Text = "ÿ"
        Me.chk_rainbow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.mytooltips.SetToolTip(Me.chk_rainbow, resources.GetString("chk_rainbow.ToolTip"))
        Me.chk_rainbow.UseVisualStyleBackColor = False
        '
        'cms_rainbow
        '
        Me.cms_rainbow.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSTB_rainbowDelta})
        Me.cms_rainbow.Name = "cms_rainbow"
        Me.cms_rainbow.ShowImageMargin = False
        Me.cms_rainbow.Size = New System.Drawing.Size(136, 29)
        '
        'TSTB_rainbowDelta
        '
        Me.TSTB_rainbowDelta.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TSTB_rainbowDelta.Name = "TSTB_rainbowDelta"
        Me.TSTB_rainbowDelta.Size = New System.Drawing.Size(100, 23)
        Me.TSTB_rainbowDelta.Text = "1"
        '
        'Check_copy2clip
        '
        Me.Check_copy2clip.Appearance = System.Windows.Forms.Appearance.Button
        Me.Check_copy2clip.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Check_copy2clip.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Check_copy2clip.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Check_copy2clip.Font = New System.Drawing.Font("Webdings", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Check_copy2clip.Location = New System.Drawing.Point(160, 64)
        Me.Check_copy2clip.Margin = New System.Windows.Forms.Padding(0)
        Me.Check_copy2clip.Name = "Check_copy2clip"
        Me.Check_copy2clip.Size = New System.Drawing.Size(32, 32)
        Me.Check_copy2clip.TabIndex = 35
        Me.Check_copy2clip.TabStop = False
        Me.Check_copy2clip.Text = "2"
        Me.Check_copy2clip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.mytooltips.SetToolTip(Me.Check_copy2clip, resources.GetString("Check_copy2clip.ToolTip"))
        Me.Check_copy2clip.UseVisualStyleBackColor = False
        '
        'Check_fixedToolbox
        '
        Me.Check_fixedToolbox.Appearance = System.Windows.Forms.Appearance.Button
        Me.Check_fixedToolbox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Check_fixedToolbox.ContextMenuStrip = Me.cms_docker
        Me.Check_fixedToolbox.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Check_fixedToolbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Check_fixedToolbox.Font = New System.Drawing.Font("Wingdings", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Check_fixedToolbox.Location = New System.Drawing.Point(192, 64)
        Me.Check_fixedToolbox.Margin = New System.Windows.Forms.Padding(0)
        Me.Check_fixedToolbox.Name = "Check_fixedToolbox"
        Me.Check_fixedToolbox.Size = New System.Drawing.Size(32, 32)
        Me.Check_fixedToolbox.TabIndex = 36
        Me.Check_fixedToolbox.TabStop = False
        Me.Check_fixedToolbox.Text = "f"
        Me.Check_fixedToolbox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.mytooltips.SetToolTip(Me.Check_fixedToolbox, "Enable Fixed Toolbar (right-click to see docking options)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Toolbar will not follo" &
        "w Mouse-Click")
        Me.Check_fixedToolbox.UseVisualStyleBackColor = False
        '
        'cms_docker
        '
        Me.cms_docker.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Combo_dockStc})
        Me.cms_docker.Name = "cms_docker"
        Me.cms_docker.ShowImageMargin = False
        Me.cms_docker.Size = New System.Drawing.Size(157, 31)
        '
        'Combo_dockStc
        '
        Me.Combo_dockStc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combo_dockStc.Items.AddRange(New Object() {"Float", "Dock Top", "Dock Bot"})
        Me.Combo_dockStc.Name = "Combo_dockStc"
        Me.Combo_dockStc.Size = New System.Drawing.Size(121, 23)
        '
        'Check_showCoords
        '
        Me.Check_showCoords.Appearance = System.Windows.Forms.Appearance.Button
        Me.Check_showCoords.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Check_showCoords.ContextMenuStrip = Me.cms_docker
        Me.Check_showCoords.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Check_showCoords.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Check_showCoords.Font = New System.Drawing.Font("Wingdings", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Check_showCoords.Location = New System.Drawing.Point(224, 64)
        Me.Check_showCoords.Margin = New System.Windows.Forms.Padding(0)
        Me.Check_showCoords.Name = "Check_showCoords"
        Me.Check_showCoords.Size = New System.Drawing.Size(32, 32)
        Me.Check_showCoords.TabIndex = 86
        Me.Check_showCoords.TabStop = False
        Me.Check_showCoords.Text = "ª"
        Me.Check_showCoords.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.mytooltips.SetToolTip(Me.Check_showCoords, "Show Coordinates")
        Me.Check_showCoords.UseVisualStyleBackColor = False
        '
        'b_close
        '
        Me.b_close.BackColor = System.Drawing.Color.IndianRed
        Me.b_close.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.b_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.b_close.Font = New System.Drawing.Font("Wingdings", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.b_close.ForeColor = System.Drawing.Color.Snow
        Me.b_close.Location = New System.Drawing.Point(256, 64)
        Me.b_close.Margin = New System.Windows.Forms.Padding(0)
        Me.b_close.Name = "b_close"
        Me.b_close.Size = New System.Drawing.Size(32, 32)
        Me.b_close.TabIndex = 37
        Me.b_close.TabStop = False
        Me.b_close.Text = "û"
        Me.mytooltips.SetToolTip(Me.b_close, "Exit [ Escape ]")
        Me.b_close.UseVisualStyleBackColor = False
        '
        't_kp
        '
        Me.t_kp.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.t_kp.Font = New System.Drawing.Font("Microsoft Sans Serif", 2.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t_kp.Location = New System.Drawing.Point(0, 0)
        Me.t_kp.Name = "t_kp"
        Me.t_kp.ReadOnly = True
        Me.t_kp.Size = New System.Drawing.Size(0, 4)
        Me.t_kp.TabIndex = 0
        '
        'Panel_Pallete
        '
        Me.Panel_Pallete.BackColor = System.Drawing.Color.White
        Me.Panel_Pallete.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel_Pallete.Controls.Add(Me.pan_gridpen)
        Me.Panel_Pallete.Controls.Add(Me.pan_gridpenx)
        Me.Panel_Pallete.Controls.Add(Me.pan_gridpeny)
        Me.Panel_Pallete.Controls.Add(Me.lab_ewid)
        Me.Panel_Pallete.Controls.Add(Me.lab_EraserDis)
        Me.Panel_Pallete.Controls.Add(Me.lab_shapeDis)
        Me.Panel_Pallete.Controls.Add(Me.xcp12)
        Me.Panel_Pallete.Controls.Add(Me.lab_swid)
        Me.Panel_Pallete.Controls.Add(Me.xcp16)
        Me.Panel_Pallete.Controls.Add(Me.Panel_SelCol)
        Me.Panel_Pallete.Controls.Add(Me.xcp7)
        Me.Panel_Pallete.Controls.Add(Me.xcp9)
        Me.Panel_Pallete.Controls.Add(Me.lab_mwid)
        Me.Panel_Pallete.Controls.Add(Me.xcp3)
        Me.Panel_Pallete.Controls.Add(Me.lab_markerDis)
        Me.Panel_Pallete.Controls.Add(Me.xcp14)
        Me.Panel_Pallete.Controls.Add(Me.xcp5)
        Me.Panel_Pallete.Controls.Add(Me.xcp11)
        Me.Panel_Pallete.Controls.Add(Me.xcp1)
        Me.Panel_Pallete.Controls.Add(Me.xcp8)
        Me.Panel_Pallete.Controls.Add(Me.xcp6)
        Me.Panel_Pallete.Controls.Add(Me.xcp15)
        Me.Panel_Pallete.Controls.Add(Me.xcp2)
        Me.Panel_Pallete.Controls.Add(Me.xcp10)
        Me.Panel_Pallete.Controls.Add(Me.xcp13)
        Me.Panel_Pallete.Controls.Add(Me.xcp17)
        Me.Panel_Pallete.Controls.Add(Me.xcp4)
        Me.Panel_Pallete.Controls.Add(Me.xcp0)
        Me.Panel_Pallete.Controls.Add(Me.track_mwid)
        Me.Panel_Pallete.Controls.Add(Me.track_eraser)
        Me.Panel_Pallete.Controls.Add(Me.track_swid)
        Me.Panel_Pallete.Cursor = System.Windows.Forms.Cursors.Default
        Me.Panel_Pallete.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel_Pallete.Location = New System.Drawing.Point(66, 3)
        Me.Panel_Pallete.Name = "Panel_Pallete"
        Me.Panel_Pallete.Size = New System.Drawing.Size(176, 54)
        Me.Panel_Pallete.TabIndex = 0
        Me.Panel_Pallete.Visible = False
        '
        'pan_gridpen
        '
        Me.pan_gridpen.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pan_gridpen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pan_gridpen.Location = New System.Drawing.Point(137, 35)
        Me.pan_gridpen.Name = "pan_gridpen"
        Me.pan_gridpen.Size = New System.Drawing.Size(16, 16)
        Me.pan_gridpen.TabIndex = 69
        Me.mytooltips.SetToolTip(Me.pan_gridpen, "Base-Axis Color")
        '
        'pan_gridpenx
        '
        Me.pan_gridpenx.BackColor = System.Drawing.Color.Red
        Me.pan_gridpenx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pan_gridpenx.Location = New System.Drawing.Point(137, 1)
        Me.pan_gridpenx.Name = "pan_gridpenx"
        Me.pan_gridpenx.Size = New System.Drawing.Size(16, 16)
        Me.pan_gridpenx.TabIndex = 67
        Me.mytooltips.SetToolTip(Me.pan_gridpenx, "X-Axis Color")
        '
        'pan_gridpeny
        '
        Me.pan_gridpeny.BackColor = System.Drawing.Color.Blue
        Me.pan_gridpeny.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pan_gridpeny.Location = New System.Drawing.Point(137, 18)
        Me.pan_gridpeny.Name = "pan_gridpeny"
        Me.pan_gridpeny.Size = New System.Drawing.Size(16, 16)
        Me.pan_gridpeny.TabIndex = 68
        Me.mytooltips.SetToolTip(Me.pan_gridpeny, "Y-Axis Color")
        '
        'lab_ewid
        '
        Me.lab_ewid.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lab_ewid.Location = New System.Drawing.Point(258, 1)
        Me.lab_ewid.Name = "lab_ewid"
        Me.lab_ewid.Size = New System.Drawing.Size(28, 16)
        Me.lab_ewid.TabIndex = 74
        Me.lab_ewid.Text = "1"
        Me.lab_ewid.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lab_EraserDis
        '
        Me.lab_EraserDis.ContextMenuStrip = Me.cms_canvasctrl
        Me.lab_EraserDis.Font = New System.Drawing.Font("Wingdings", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.lab_EraserDis.Location = New System.Drawing.Point(155, 2)
        Me.lab_EraserDis.Name = "lab_EraserDis"
        Me.lab_EraserDis.Size = New System.Drawing.Size(16, 16)
        Me.lab_EraserDis.TabIndex = 77
        Me.lab_EraserDis.Text = "m"
        Me.lab_EraserDis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.mytooltips.SetToolTip(Me.lab_EraserDis, "Right-Click for More" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Left-Click to toogle trackbars" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Middle-Click to Hide Only T" &
        "oolbox (not the color pallete)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'lab_shapeDis
        '
        Me.lab_shapeDis.ContextMenuStrip = Me.cms_canvasctrl
        Me.lab_shapeDis.Font = New System.Drawing.Font("Wingdings", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.lab_shapeDis.Location = New System.Drawing.Point(155, 19)
        Me.lab_shapeDis.Name = "lab_shapeDis"
        Me.lab_shapeDis.Size = New System.Drawing.Size(16, 16)
        Me.lab_shapeDis.TabIndex = 0
        Me.lab_shapeDis.Text = "¨"
        Me.lab_shapeDis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.mytooltips.SetToolTip(Me.lab_shapeDis, "Right-Click for More" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Left-Click to toogle trackbars" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Middle-Click to Hide Only T" &
        "oolbox (not the color pallete)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'xcp12
        '
        Me.xcp12.BackColor = System.Drawing.Color.Crimson
        Me.xcp12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xcp12.Location = New System.Drawing.Point(1, 1)
        Me.xcp12.Margin = New System.Windows.Forms.Padding(0)
        Me.xcp12.Name = "xcp12"
        Me.xcp12.Size = New System.Drawing.Size(16, 16)
        Me.xcp12.TabIndex = 19
        '
        'lab_swid
        '
        Me.lab_swid.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lab_swid.Location = New System.Drawing.Point(258, 18)
        Me.lab_swid.Name = "lab_swid"
        Me.lab_swid.Size = New System.Drawing.Size(28, 16)
        Me.lab_swid.TabIndex = 59
        Me.lab_swid.Text = "1"
        Me.lab_swid.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'xcp16
        '
        Me.xcp16.BackColor = System.Drawing.Color.DarkViolet
        Me.xcp16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xcp16.Location = New System.Drawing.Point(18, 1)
        Me.xcp16.Margin = New System.Windows.Forms.Padding(0)
        Me.xcp16.Name = "xcp16"
        Me.xcp16.Size = New System.Drawing.Size(16, 16)
        Me.xcp16.TabIndex = 23
        '
        'Panel_SelCol
        '
        Me.Panel_SelCol.BackColor = System.Drawing.Color.Black
        Me.Panel_SelCol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel_SelCol.ContextMenuStrip = Me.cms_selCol
        Me.Panel_SelCol.Location = New System.Drawing.Point(103, 1)
        Me.Panel_SelCol.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel_SelCol.Name = "Panel_SelCol"
        Me.Panel_SelCol.Size = New System.Drawing.Size(33, 50)
        Me.Panel_SelCol.TabIndex = 28
        Me.mytooltips.SetToolTip(Me.Panel_SelCol, "Marker and Shape Draw Color" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Hint: Right-Click to see more.." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "          Left-Clic" &
        "k to Hue Shift" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "          Middle-click to Clear Canvas" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'cms_selCol
        '
        Me.cms_selCol.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FillCanvasToolStripMenuItem, Me.ToolStripSeparator5, Me.SelectColorToolStripMenuItem, Me.RandomColorToolStripMenuItem, Me.TSTB_hueDelta, Me.ToolStripSeparator6, Me.CopyAsRGBToolStripMenuItem, Me.PasteAsRGBToolStripMenuItem})
        Me.cms_selCol.Name = "cms_selCol"
        Me.cms_selCol.ShowImageMargin = False
        Me.cms_selCol.Size = New System.Drawing.Size(136, 151)
        '
        'FillCanvasToolStripMenuItem
        '
        Me.FillCanvasToolStripMenuItem.Name = "FillCanvasToolStripMenuItem"
        Me.FillCanvasToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.FillCanvasToolStripMenuItem.Text = "Fill Canvas"
        Me.FillCanvasToolStripMenuItem.ToolTipText = "Use this color a Canvas Background"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(132, 6)
        '
        'SelectColorToolStripMenuItem
        '
        Me.SelectColorToolStripMenuItem.Name = "SelectColorToolStripMenuItem"
        Me.SelectColorToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.SelectColorToolStripMenuItem.Text = "Select &Color"
        '
        'RandomColorToolStripMenuItem
        '
        Me.RandomColorToolStripMenuItem.Name = "RandomColorToolStripMenuItem"
        Me.RandomColorToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.RandomColorToolStripMenuItem.Text = "Random Color"
        '
        'TSTB_hueDelta
        '
        Me.TSTB_hueDelta.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TSTB_hueDelta.Name = "TSTB_hueDelta"
        Me.TSTB_hueDelta.Size = New System.Drawing.Size(100, 23)
        Me.TSTB_hueDelta.Text = "60"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(132, 6)
        '
        'CopyAsRGBToolStripMenuItem
        '
        Me.CopyAsRGBToolStripMenuItem.Name = "CopyAsRGBToolStripMenuItem"
        Me.CopyAsRGBToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.CopyAsRGBToolStripMenuItem.Text = "Copy as RGB"
        '
        'PasteAsRGBToolStripMenuItem
        '
        Me.PasteAsRGBToolStripMenuItem.Name = "PasteAsRGBToolStripMenuItem"
        Me.PasteAsRGBToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.PasteAsRGBToolStripMenuItem.Text = "Paste as RGB"
        '
        'xcp7
        '
        Me.xcp7.BackColor = System.Drawing.Color.RoyalBlue
        Me.xcp7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xcp7.Location = New System.Drawing.Point(18, 18)
        Me.xcp7.Margin = New System.Windows.Forms.Padding(0)
        Me.xcp7.Name = "xcp7"
        Me.xcp7.Size = New System.Drawing.Size(16, 16)
        Me.xcp7.TabIndex = 8
        '
        'xcp9
        '
        Me.xcp9.BackColor = System.Drawing.Color.Aquamarine
        Me.xcp9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xcp9.Location = New System.Drawing.Point(35, 1)
        Me.xcp9.Margin = New System.Windows.Forms.Padding(0)
        Me.xcp9.Name = "xcp9"
        Me.xcp9.Size = New System.Drawing.Size(16, 16)
        Me.xcp9.TabIndex = 15
        '
        'lab_mwid
        '
        Me.lab_mwid.Font = New System.Drawing.Font("Calibri", 8.25!)
        Me.lab_mwid.Location = New System.Drawing.Point(258, 37)
        Me.lab_mwid.Margin = New System.Windows.Forms.Padding(0)
        Me.lab_mwid.Name = "lab_mwid"
        Me.lab_mwid.Size = New System.Drawing.Size(28, 16)
        Me.lab_mwid.TabIndex = 0
        Me.lab_mwid.Text = "1"
        Me.lab_mwid.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xcp3
        '
        Me.xcp3.BackColor = System.Drawing.Color.Turquoise
        Me.xcp3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xcp3.Location = New System.Drawing.Point(35, 18)
        Me.xcp3.Margin = New System.Windows.Forms.Padding(0)
        Me.xcp3.Name = "xcp3"
        Me.xcp3.Size = New System.Drawing.Size(16, 16)
        Me.xcp3.TabIndex = 4
        '
        'lab_markerDis
        '
        Me.lab_markerDis.ContextMenuStrip = Me.cms_canvasctrl
        Me.lab_markerDis.Font = New System.Drawing.Font("Wingdings", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.lab_markerDis.Location = New System.Drawing.Point(155, 36)
        Me.lab_markerDis.Margin = New System.Windows.Forms.Padding(0)
        Me.lab_markerDis.Name = "lab_markerDis"
        Me.lab_markerDis.Size = New System.Drawing.Size(16, 16)
        Me.lab_markerDis.TabIndex = 0
        Me.lab_markerDis.Text = "!"
        Me.lab_markerDis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.mytooltips.SetToolTip(Me.lab_markerDis, "Right-Click for More" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Left-Click to toogle trackbars" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Middle-Click to Hide Only T" &
        "oolbox (not the color pallete)")
        '
        'xcp14
        '
        Me.xcp14.BackColor = System.Drawing.Color.Gold
        Me.xcp14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xcp14.Location = New System.Drawing.Point(52, 1)
        Me.xcp14.Margin = New System.Windows.Forms.Padding(0)
        Me.xcp14.Name = "xcp14"
        Me.xcp14.Size = New System.Drawing.Size(16, 16)
        Me.xcp14.TabIndex = 21
        '
        'xcp5
        '
        Me.xcp5.BackColor = System.Drawing.Color.DarkOrange
        Me.xcp5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xcp5.Location = New System.Drawing.Point(69, 1)
        Me.xcp5.Margin = New System.Windows.Forms.Padding(0)
        Me.xcp5.Name = "xcp5"
        Me.xcp5.Size = New System.Drawing.Size(16, 16)
        Me.xcp5.TabIndex = 6
        '
        'xcp11
        '
        Me.xcp11.BackColor = System.Drawing.Color.WhiteSmoke
        Me.xcp11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xcp11.Location = New System.Drawing.Point(86, 35)
        Me.xcp11.Margin = New System.Windows.Forms.Padding(0)
        Me.xcp11.Name = "xcp11"
        Me.xcp11.Size = New System.Drawing.Size(16, 16)
        Me.xcp11.TabIndex = 18
        '
        'xcp1
        '
        Me.xcp1.BackColor = System.Drawing.Color.Gainsboro
        Me.xcp1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xcp1.Location = New System.Drawing.Point(86, 18)
        Me.xcp1.Margin = New System.Windows.Forms.Padding(0)
        Me.xcp1.Name = "xcp1"
        Me.xcp1.Size = New System.Drawing.Size(16, 16)
        Me.xcp1.TabIndex = 2
        Me.xcp1.Tag = ""
        '
        'xcp8
        '
        Me.xcp8.BackColor = System.Drawing.Color.Khaki
        Me.xcp8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xcp8.Location = New System.Drawing.Point(69, 18)
        Me.xcp8.Margin = New System.Windows.Forms.Padding(0)
        Me.xcp8.Name = "xcp8"
        Me.xcp8.Size = New System.Drawing.Size(16, 16)
        Me.xcp8.TabIndex = 17
        '
        'xcp6
        '
        Me.xcp6.BackColor = System.Drawing.Color.Black
        Me.xcp6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xcp6.Location = New System.Drawing.Point(86, 1)
        Me.xcp6.Margin = New System.Windows.Forms.Padding(0)
        Me.xcp6.Name = "xcp6"
        Me.xcp6.Size = New System.Drawing.Size(16, 16)
        Me.xcp6.TabIndex = 7
        '
        'xcp15
        '
        Me.xcp15.BackColor = System.Drawing.Color.RosyBrown
        Me.xcp15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xcp15.Location = New System.Drawing.Point(69, 35)
        Me.xcp15.Margin = New System.Windows.Forms.Padding(0)
        Me.xcp15.Name = "xcp15"
        Me.xcp15.Size = New System.Drawing.Size(16, 16)
        Me.xcp15.TabIndex = 22
        '
        'xcp2
        '
        Me.xcp2.BackColor = System.Drawing.Color.LightPink
        Me.xcp2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xcp2.Location = New System.Drawing.Point(1, 18)
        Me.xcp2.Margin = New System.Windows.Forms.Padding(0)
        Me.xcp2.Name = "xcp2"
        Me.xcp2.Size = New System.Drawing.Size(16, 16)
        Me.xcp2.TabIndex = 3
        '
        'xcp10
        '
        Me.xcp10.BackColor = System.Drawing.Color.Yellow
        Me.xcp10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xcp10.Location = New System.Drawing.Point(52, 18)
        Me.xcp10.Margin = New System.Windows.Forms.Padding(0)
        Me.xcp10.Name = "xcp10"
        Me.xcp10.Size = New System.Drawing.Size(16, 16)
        Me.xcp10.TabIndex = 16
        '
        'xcp13
        '
        Me.xcp13.BackColor = System.Drawing.Color.Violet
        Me.xcp13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xcp13.Location = New System.Drawing.Point(1, 35)
        Me.xcp13.Margin = New System.Windows.Forms.Padding(0)
        Me.xcp13.Name = "xcp13"
        Me.xcp13.Size = New System.Drawing.Size(16, 16)
        Me.xcp13.TabIndex = 20
        '
        'xcp17
        '
        Me.xcp17.BackColor = System.Drawing.Color.LimeGreen
        Me.xcp17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xcp17.Location = New System.Drawing.Point(35, 35)
        Me.xcp17.Margin = New System.Windows.Forms.Padding(0)
        Me.xcp17.Name = "xcp17"
        Me.xcp17.Size = New System.Drawing.Size(16, 16)
        Me.xcp17.TabIndex = 24
        '
        'xcp4
        '
        Me.xcp4.BackColor = System.Drawing.Color.LightSkyBlue
        Me.xcp4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xcp4.Location = New System.Drawing.Point(18, 35)
        Me.xcp4.Margin = New System.Windows.Forms.Padding(0)
        Me.xcp4.Name = "xcp4"
        Me.xcp4.Size = New System.Drawing.Size(16, 16)
        Me.xcp4.TabIndex = 5
        '
        'xcp0
        '
        Me.xcp0.BackColor = System.Drawing.Color.GreenYellow
        Me.xcp0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xcp0.Location = New System.Drawing.Point(52, 35)
        Me.xcp0.Margin = New System.Windows.Forms.Padding(0)
        Me.xcp0.Name = "xcp0"
        Me.xcp0.Size = New System.Drawing.Size(16, 16)
        Me.xcp0.TabIndex = 1
        Me.xcp0.Tag = ""
        '
        'track_mwid
        '
        Me.track_mwid.AutoSize = False
        Me.track_mwid.LargeChange = 1
        Me.track_mwid.Location = New System.Drawing.Point(169, 36)
        Me.track_mwid.Margin = New System.Windows.Forms.Padding(0)
        Me.track_mwid.Maximum = 200
        Me.track_mwid.Minimum = 1
        Me.track_mwid.Name = "track_mwid"
        Me.track_mwid.Size = New System.Drawing.Size(94, 16)
        Me.track_mwid.TabIndex = 1
        Me.track_mwid.TabStop = False
        Me.track_mwid.Tag = ""
        Me.track_mwid.TickFrequency = 0
        Me.track_mwid.TickStyle = System.Windows.Forms.TickStyle.None
        Me.mytooltips.SetToolTip(Me.track_mwid, "Marker Pen Width" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ShortCuts:  combine ctrl and shift with + or - keys" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "          " &
        "           while using marker or calligraphy tool")
        Me.track_mwid.Value = 1
        '
        'track_eraser
        '
        Me.track_eraser.AutoSize = False
        Me.track_eraser.LargeChange = 1
        Me.track_eraser.Location = New System.Drawing.Point(169, 2)
        Me.track_eraser.Maximum = 200
        Me.track_eraser.Minimum = 1
        Me.track_eraser.Name = "track_eraser"
        Me.track_eraser.Size = New System.Drawing.Size(94, 16)
        Me.track_eraser.TabIndex = 73
        Me.track_eraser.TabStop = False
        Me.track_eraser.Tag = ""
        Me.track_eraser.TickFrequency = 0
        Me.track_eraser.TickStyle = System.Windows.Forms.TickStyle.None
        Me.mytooltips.SetToolTip(Me.track_eraser, "Eraser Width" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ShortCuts:  combine ctrl and shift with + or - keys" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "              " &
        "       while using eraser tool")
        Me.track_eraser.Value = 1
        '
        'track_swid
        '
        Me.track_swid.AutoSize = False
        Me.track_swid.LargeChange = 1
        Me.track_swid.Location = New System.Drawing.Point(169, 19)
        Me.track_swid.Maximum = 200
        Me.track_swid.Minimum = 1
        Me.track_swid.Name = "track_swid"
        Me.track_swid.Size = New System.Drawing.Size(94, 16)
        Me.track_swid.TabIndex = 2
        Me.track_swid.TabStop = False
        Me.track_swid.Tag = ""
        Me.track_swid.TickFrequency = 0
        Me.track_swid.TickStyle = System.Windows.Forms.TickStyle.None
        Me.mytooltips.SetToolTip(Me.track_swid, "Shape Pen Width" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ShortCuts:  combine ctrl and shift with + or - keys" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "           " &
        "          while using any shape tools")
        Me.track_swid.Value = 1
        '
        'cms_timestamTool
        '
        Me.cms_timestamTool.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DateToolStripMenuItem, Me.TimeToolStripMenuItem, Me.TSTB_sep})
        Me.cms_timestamTool.Name = "cms_timestamTool"
        Me.cms_timestamTool.ShowCheckMargin = True
        Me.cms_timestamTool.ShowImageMargin = False
        Me.cms_timestamTool.Size = New System.Drawing.Size(161, 73)
        '
        'DateToolStripMenuItem
        '
        Me.DateToolStripMenuItem.Checked = True
        Me.DateToolStripMenuItem.CheckOnClick = True
        Me.DateToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.DateToolStripMenuItem.Name = "DateToolStripMenuItem"
        Me.DateToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.DateToolStripMenuItem.Text = "Date"
        '
        'TimeToolStripMenuItem
        '
        Me.TimeToolStripMenuItem.Checked = True
        Me.TimeToolStripMenuItem.CheckOnClick = True
        Me.TimeToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.TimeToolStripMenuItem.Name = "TimeToolStripMenuItem"
        Me.TimeToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.TimeToolStripMenuItem.Text = "Time"
        '
        'TSTB_sep
        '
        Me.TSTB_sep.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TSTB_sep.Name = "TSTB_sep"
        Me.TSTB_sep.Size = New System.Drawing.Size(100, 23)
        Me.TSTB_sep.Text = " | "
        '
        'mytooltips
        '
        Me.mytooltips.AutoPopDelay = 15000
        Me.mytooltips.InitialDelay = 100
        Me.mytooltips.ReshowDelay = 100
        '
        'sfdia
        '
        Me.sfdia.DefaultExt = "png"
        Me.sfdia.Filter = "PNG|*.png"
        '
        'trayico
        '
        Me.trayico.ContextMenuStrip = Me.cms_canvasctrl
        Me.trayico.Icon = CType(resources.GetObject("trayico.Icon"), System.Drawing.Icon)
        Me.trayico.Text = "ScreenCanvas"
        Me.trayico.Visible = True
        '
        'time_animate
        '
        '
        'time_AnchorSlide
        '
        Me.time_AnchorSlide.Interval = 25
        '
        'bgwudp
        '
        Me.bgwudp.WorkerReportsProgress = True
        Me.bgwudp.WorkerSupportsCancellation = True
        '
        'MinimalistPNGEditor
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(954, 580)
        Me.Controls.Add(Me.my_canvas)
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MinimalistPNGEditor"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "ImageEditor"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.my_canvas.ResumeLayout(False)
        Me.my_canvas.PerformLayout()
        Me.Panel_webber.ResumeLayout(False)
        Me.Panel_bottomW.ResumeLayout(False)
        Me.Panel_bottomW.PerformLayout()
        Me.Panel_coords.ResumeLayout(False)
        Me.cms_coords.ResumeLayout(False)
        Me.Panel_Anchor.ResumeLayout(False)
        CType(Me.Pic_Anchor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cms_canvasctrl.ResumeLayout(False)
        Me.Panel_textInput.ResumeLayout(False)
        Me.Panel_textInput.PerformLayout()
        Me.Panel_bottom.ResumeLayout(False)
        Me.Panel_tools.ResumeLayout(False)
        Me.cms_tableTool.ResumeLayout(False)
        Me.cms_tableTool.PerformLayout()
        Me.cms_ScreenCopy.ResumeLayout(False)
        Me.cms_Selection.ResumeLayout(False)
        Me.cms_textTool.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.cms_rainbow.ResumeLayout(False)
        Me.cms_rainbow.PerformLayout()
        Me.cms_docker.ResumeLayout(False)
        Me.Panel_Pallete.ResumeLayout(False)
        Me.cms_selCol.ResumeLayout(False)
        Me.cms_selCol.PerformLayout()
        CType(Me.track_mwid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.track_eraser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.track_swid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cms_timestamTool.ResumeLayout(False)
        Me.cms_timestamTool.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents my_canvas As System.Windows.Forms.Panel
    Friend WithEvents Panel_Pallete As System.Windows.Forms.Panel
    Friend WithEvents xcp11 As System.Windows.Forms.Panel
    Friend WithEvents xcp8 As System.Windows.Forms.Panel
    Friend WithEvents xcp15 As System.Windows.Forms.Panel
    Friend WithEvents xcp10 As System.Windows.Forms.Panel
    Friend WithEvents xcp17 As System.Windows.Forms.Panel
    Friend WithEvents xcp13 As System.Windows.Forms.Panel
    Friend WithEvents xcp14 As System.Windows.Forms.Panel
    Friend WithEvents xcp9 As System.Windows.Forms.Panel
    Friend WithEvents xcp16 As System.Windows.Forms.Panel
    Friend WithEvents xcp12 As System.Windows.Forms.Panel
    Friend WithEvents xcp7 As System.Windows.Forms.Panel
    Friend WithEvents xcp3 As System.Windows.Forms.Panel
    Friend WithEvents xcp5 As System.Windows.Forms.Panel
    Friend WithEvents xcp1 As System.Windows.Forms.Panel
    Friend WithEvents xcp6 As System.Windows.Forms.Panel
    Friend WithEvents xcp2 As System.Windows.Forms.Panel
    Friend WithEvents xcp4 As System.Windows.Forms.Panel
    Friend WithEvents xcp0 As System.Windows.Forms.Panel
    Friend WithEvents rb_marker As System.Windows.Forms.RadioButton
    Friend WithEvents rb_pointer As System.Windows.Forms.RadioButton
    Friend WithEvents Panel_SelCol As System.Windows.Forms.Panel
    Friend WithEvents PalleteCD As System.Windows.Forms.ColorDialog
    Friend WithEvents rb_ellipse As System.Windows.Forms.RadioButton
    Friend WithEvents rb_table As System.Windows.Forms.RadioButton
    Friend WithEvents rb_path As System.Windows.Forms.RadioButton
    Friend WithEvents track_mwid As System.Windows.Forms.TrackBar
    Friend WithEvents track_swid As System.Windows.Forms.TrackBar
    Friend WithEvents lab_mwid As System.Windows.Forms.Label
    Friend WithEvents lab_swid As System.Windows.Forms.Label
    Friend WithEvents chk_showScale As System.Windows.Forms.CheckBox
    Friend WithEvents lab_shapeDis As System.Windows.Forms.Label
    Friend WithEvents lab_markerDis As System.Windows.Forms.Label
    Friend WithEvents nud_rotXangle As System.Windows.Forms.TextBox
    Friend WithEvents B_Undo As System.Windows.Forms.Button
    Friend WithEvents B_Redo As System.Windows.Forms.Button
    Friend WithEvents rb_axismarker As System.Windows.Forms.RadioButton
    Friend WithEvents B_clearaxisPots As System.Windows.Forms.Button
    Friend WithEvents cms_canvasctrl As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ClearToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents chk_fillOn As System.Windows.Forms.CheckBox
    Friend WithEvents pan_gridpen As System.Windows.Forms.Panel
    Friend WithEvents pan_gridpenx As System.Windows.Forms.Panel
    Friend WithEvents pan_gridpeny As System.Windows.Forms.Panel
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mytooltips As System.Windows.Forms.ToolTip
    Friend WithEvents SetTKeyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents b_close As System.Windows.Forms.Button
    Friend WithEvents sfdia As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AppDirectoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents trayico As System.Windows.Forms.NotifyIcon
    Friend WithEvents CenterAnchorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents time_animate As System.Windows.Forms.Timer
    Friend WithEvents t_kp As System.Windows.Forms.TextBox
    Friend WithEvents rb_pasteR As System.Windows.Forms.RadioButton
    Friend WithEvents rb_paste As System.Windows.Forms.RadioButton
    Friend WithEvents rb_screencopy As System.Windows.Forms.RadioButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents rb_eraser As System.Windows.Forms.RadioButton
    Friend WithEvents track_eraser As System.Windows.Forms.TrackBar
    Friend WithEvents lab_ewid As System.Windows.Forms.Label
    Friend WithEvents lab_EraserDis As System.Windows.Forms.Label
    Friend WithEvents Panel_tools As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Check_erasretrail As System.Windows.Forms.CheckBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Check_fixedToolbox As System.Windows.Forms.CheckBox
    Friend WithEvents ResetToolbarsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Check_copy2clip As System.Windows.Forms.CheckBox
    Friend WithEvents rb_caligraphy As System.Windows.Forms.RadioButton
    Friend WithEvents NUD_ANGLEsel As ScreenCanvas.AngleSelector
    Friend WithEvents Check_dropPP As System.Windows.Forms.CheckBox
    Friend WithEvents rb_colorpick As System.Windows.Forms.RadioButton
    Friend WithEvents CheckBox_lockXscroll As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox_lockYscroll As System.Windows.Forms.CheckBox
    Friend WithEvents cms_tableTool As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents tstb_rows As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents tstb_cols As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents cms_docker As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents Combo_dockStc As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents cms_timestamTool As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TimeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSTB_sep As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents rb_text As System.Windows.Forms.RadioButton
    Friend WithEvents cms_textTool As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents FromClipboardToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents B_FontChange As System.Windows.Forms.Button
    Friend WithEvents cms_selCol As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents SelectColorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSTB_hueDelta As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents CopyAsRGBToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PasteAsRGBToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ControlTestToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FillCanvasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents time_AnchorSlide As System.Windows.Forms.Timer
    Friend WithEvents RandomColorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TextTootl As System.Windows.Forms.TextBox
    Friend WithEvents EnterTextToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel_textInput As System.Windows.Forms.Panel
    Friend WithEvents B_hideTextIn As System.Windows.Forms.Button
    Friend WithEvents B_ClearTextIn As System.Windows.Forms.Button
    Friend WithEvents Panel_bottom As System.Windows.Forms.Panel
    Friend WithEvents Panel_cornor As System.Windows.Forms.Panel
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents chk_rainbow As System.Windows.Forms.CheckBox
    Friend WithEvents cms_rainbow As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents TSTB_rainbowDelta As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ImportClipboardToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents rb_SelectR As System.Windows.Forms.RadioButton
    Friend WithEvents cms_Selection As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents SelCutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SelCopyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SelSaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SelClearToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ScreenshotToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AllScreensToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents B_inputfocus As System.Windows.Forms.Button
    Friend WithEvents cms_ScreenCopy As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents SaveToFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExportClipoardToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuicksaveFolderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel_Anchor As System.Windows.Forms.Panel
    Friend WithEvents Pic_Anchor As System.Windows.Forms.PictureBox
    Friend WithEvents Panel_coords As System.Windows.Forms.Panel
    Friend WithEvents Label_coord As System.Windows.Forms.Label
    Friend WithEvents cms_coords As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CordCopy2ClipToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CordPastePointsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CoordrelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents bgwudp As System.ComponentModel.BackgroundWorker
    Friend WithEvents webber As System.Windows.Forms.WebBrowser
    Friend WithEvents Panel_webber As System.Windows.Forms.Panel
    Friend WithEvents Panel_bottomW As System.Windows.Forms.Panel
    Friend WithEvents Panel_cornorW As System.Windows.Forms.Panel
    Friend WithEvents Button_webClose As System.Windows.Forms.Button
    Friend WithEvents Button_webup As System.Windows.Forms.Button
    Friend WithEvents text_webaddr As System.Windows.Forms.TextBox
    Friend WithEvents Button_webBrowse As System.Windows.Forms.Button
    Friend WithEvents webFolder As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents Button_webAppdir As System.Windows.Forms.Button
    Friend WithEvents CloseImageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResetCanvasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ButtonWebGo As System.Windows.Forms.Button
    Friend WithEvents ListBox_bmark As System.Windows.Forms.ListBox
    Friend WithEvents Check_showCoords As System.Windows.Forms.CheckBox
End Class
