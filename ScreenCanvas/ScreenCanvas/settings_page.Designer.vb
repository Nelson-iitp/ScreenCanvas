<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class settings_page
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(settings_page))
        Me.NUD_maxUndo = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label_imgC = New System.Windows.Forms.Label()
        Me.PictureBoxicon = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.nud_canvasY = New System.Windows.Forms.NumericUpDown()
        Me.nud_canvasX = New System.Windows.Forms.NumericUpDown()
        Me.b_XAdd = New System.Windows.Forms.Button()
        Me.b_XSub = New System.Windows.Forms.Button()
        Me.b_YSub = New System.Windows.Forms.Button()
        Me.b_YAdd = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cms_canvassize = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.WorkingAreaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ScreenBoundsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cms_quicksave = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ChangePathToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyPathToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenInExplorerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.b_setSize = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Check_sDate = New System.Windows.Forms.CheckBox()
        Me.L_SetTkey = New System.Windows.Forms.Label()
        Me.nud_anchorW = New System.Windows.Forms.NumericUpDown()
        Me.nud_anchorH = New System.Windows.Forms.NumericUpDown()
        Me.L_pathR = New System.Windows.Forms.Label()
        Me.L_pathG = New System.Windows.Forms.Label()
        Me.L_pathY = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TSTBPrefixS = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Check_tooltips = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Check_sTime = New System.Windows.Forms.CheckBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Check_HideAnchr = New System.Windows.Forms.CheckBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Combo_pixFormat = New System.Windows.Forms.ComboBox()
        Me.Check_resetpanonDrop = New System.Windows.Forms.CheckBox()
        CType(Me.NUD_maxUndo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxicon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nud_canvasY, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nud_canvasX, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cms_canvassize.SuspendLayout()
        Me.cms_quicksave.SuspendLayout()
        CType(Me.nud_anchorW, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nud_anchorH, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'NUD_maxUndo
        '
        Me.NUD_maxUndo.Location = New System.Drawing.Point(145, 22)
        Me.NUD_maxUndo.Margin = New System.Windows.Forms.Padding(4)
        Me.NUD_maxUndo.Minimum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.NUD_maxUndo.Name = "NUD_maxUndo"
        Me.NUD_maxUndo.Size = New System.Drawing.Size(59, 23)
        Me.NUD_maxUndo.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.NUD_maxUndo, "Note: Allowing more # of undo actions will take up more memory. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "           To C" & _
                "lear the undo stack manually, click on the stack counter.")
        Me.NUD_maxUndo.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(0, 2)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(276, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Undo Options"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.Label1, "Maximum size of undo stack (*requires restart)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Note: Allowing more # of undo act" & _
                "ions will take up more memory. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "           To Clear the undo stack manually, cl" & _
                "ick on the stack counter.")
        '
        'Label_imgC
        '
        Me.Label_imgC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label_imgC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_imgC.ForeColor = System.Drawing.Color.Purple
        Me.Label_imgC.Location = New System.Drawing.Point(209, 22)
        Me.Label_imgC.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_imgC.Name = "Label_imgC"
        Me.Label_imgC.Size = New System.Drawing.Size(41, 22)
        Me.Label_imgC.TabIndex = 6
        Me.Label_imgC.Text = "5"
        Me.Label_imgC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.Label_imgC, "Current Count of Undo Stack (click to clear stack )")
        '
        'PictureBoxicon
        '
        Me.PictureBoxicon.Location = New System.Drawing.Point(209, 164)
        Me.PictureBoxicon.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBoxicon.Name = "PictureBoxicon"
        Me.PictureBoxicon.Size = New System.Drawing.Size(64, 64)
        Me.PictureBoxicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxicon.TabIndex = 9
        Me.PictureBoxicon.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'nud_canvasY
        '
        Me.nud_canvasY.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.nud_canvasY.Location = New System.Drawing.Point(7, 52)
        Me.nud_canvasY.Margin = New System.Windows.Forms.Padding(4)
        Me.nud_canvasY.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nud_canvasY.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nud_canvasY.Name = "nud_canvasY"
        Me.nud_canvasY.Size = New System.Drawing.Size(153, 23)
        Me.nud_canvasY.TabIndex = 5
        Me.nud_canvasY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.nud_canvasY, "Height or Y-Entension")
        Me.nud_canvasY.Value = New Decimal(New Integer() {1000, 0, 0, 0})
        '
        'nud_canvasX
        '
        Me.nud_canvasX.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.nud_canvasX.Location = New System.Drawing.Point(7, 27)
        Me.nud_canvasX.Margin = New System.Windows.Forms.Padding(4)
        Me.nud_canvasX.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nud_canvasX.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nud_canvasX.Name = "nud_canvasX"
        Me.nud_canvasX.Size = New System.Drawing.Size(153, 23)
        Me.nud_canvasX.TabIndex = 4
        Me.nud_canvasX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.nud_canvasX, "Width or X-Entension")
        Me.nud_canvasX.Value = New Decimal(New Integer() {1000, 0, 0, 0})
        '
        'b_XAdd
        '
        Me.b_XAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.b_XAdd.Font = New System.Drawing.Font("Wingdings", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.b_XAdd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.b_XAdd.Location = New System.Drawing.Point(232, 32)
        Me.b_XAdd.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.b_XAdd.Name = "b_XAdd"
        Me.b_XAdd.Size = New System.Drawing.Size(24, 24)
        Me.b_XAdd.TabIndex = 7
        Me.b_XAdd.Text = "à"
        Me.ToolTip1.SetToolTip(Me.b_XAdd, "Increase Canvas Size Horizontally")
        Me.b_XAdd.UseVisualStyleBackColor = True
        '
        'b_XSub
        '
        Me.b_XSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.b_XSub.Font = New System.Drawing.Font("Wingdings", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.b_XSub.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.b_XSub.Location = New System.Drawing.Point(182, 32)
        Me.b_XSub.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.b_XSub.Name = "b_XSub"
        Me.b_XSub.Size = New System.Drawing.Size(24, 24)
        Me.b_XSub.TabIndex = 9
        Me.b_XSub.Text = "ß"
        Me.ToolTip1.SetToolTip(Me.b_XSub, "Decrease Canvas Size Horizontally")
        Me.b_XSub.UseVisualStyleBackColor = True
        '
        'b_YSub
        '
        Me.b_YSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.b_YSub.Font = New System.Drawing.Font("Wingdings", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.b_YSub.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.b_YSub.Location = New System.Drawing.Point(207, 58)
        Me.b_YSub.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.b_YSub.Name = "b_YSub"
        Me.b_YSub.Size = New System.Drawing.Size(24, 24)
        Me.b_YSub.TabIndex = 8
        Me.b_YSub.Text = "â"
        Me.ToolTip1.SetToolTip(Me.b_YSub, "Increase Canvas Size Vertically")
        Me.b_YSub.UseVisualStyleBackColor = True
        '
        'b_YAdd
        '
        Me.b_YAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.b_YAdd.Font = New System.Drawing.Font("Wingdings", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.b_YAdd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.b_YAdd.Location = New System.Drawing.Point(207, 8)
        Me.b_YAdd.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.b_YAdd.Name = "b_YAdd"
        Me.b_YAdd.Size = New System.Drawing.Size(24, 24)
        Me.b_YAdd.TabIndex = 10
        Me.b_YAdd.Text = "á"
        Me.ToolTip1.SetToolTip(Me.b_YAdd, "Decrease Canvas Size Vertically")
        Me.b_YAdd.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.ContextMenuStrip = Me.cms_canvassize
        Me.Label7.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(-4, 5)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 16)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Canvas Size"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ToolTip1.SetToolTip(Me.Label7, "Right-Click to get default size")
        '
        'cms_canvassize
        '
        Me.cms_canvassize.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WorkingAreaToolStripMenuItem, Me.ScreenBoundsToolStripMenuItem})
        Me.cms_canvassize.Name = "cms_canvassize"
        Me.cms_canvassize.ShowImageMargin = False
        Me.cms_canvassize.Size = New System.Drawing.Size(149, 48)
        '
        'WorkingAreaToolStripMenuItem
        '
        Me.WorkingAreaToolStripMenuItem.Name = "WorkingAreaToolStripMenuItem"
        Me.WorkingAreaToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.WorkingAreaToolStripMenuItem.Text = "Get Working Area"
        '
        'ScreenBoundsToolStripMenuItem
        '
        Me.ScreenBoundsToolStripMenuItem.Name = "ScreenBoundsToolStripMenuItem"
        Me.ScreenBoundsToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.ScreenBoundsToolStripMenuItem.Text = "Get Screen Bounds"
        '
        'Label8
        '
        Me.Label8.ContextMenuStrip = Me.cms_canvassize
        Me.Label8.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Purple
        Me.Label8.Location = New System.Drawing.Point(75, 4)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 16)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "1000 x 1000"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.Label8, "Current Canvas Size")
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.Font = New System.Drawing.Font("Wingdings", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(8, 31)
        Me.Label9.Margin = New System.Windows.Forms.Padding(0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(21, 15)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "ó"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.Font = New System.Drawing.Font("Wingdings", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(9, 55)
        Me.Label10.Margin = New System.Windows.Forms.Padding(0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(18, 15)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "ô"
        '
        'Label12
        '
        Me.Label12.ContextMenuStrip = Me.cms_quicksave
        Me.Label12.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Purple
        Me.Label12.Location = New System.Drawing.Point(3, 64)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(269, 43)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "%"
        Me.ToolTip1.SetToolTip(Me.Label12, "Folder for Quick Save" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " (left-click to open in explorer)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " (right-click to change" & _
                ")")
        '
        'cms_quicksave
        '
        Me.cms_quicksave.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangePathToolStripMenuItem, Me.CopyPathToolStripMenuItem, Me.OpenInExplorerToolStripMenuItem})
        Me.cms_quicksave.Name = "cms_quicksave"
        Me.cms_quicksave.ShowImageMargin = False
        Me.cms_quicksave.Size = New System.Drawing.Size(138, 70)
        '
        'ChangePathToolStripMenuItem
        '
        Me.ChangePathToolStripMenuItem.Name = "ChangePathToolStripMenuItem"
        Me.ChangePathToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.ChangePathToolStripMenuItem.Text = "Change &Path"
        '
        'CopyPathToolStripMenuItem
        '
        Me.CopyPathToolStripMenuItem.Name = "CopyPathToolStripMenuItem"
        Me.CopyPathToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.CopyPathToolStripMenuItem.Text = "&Copy Path"
        '
        'OpenInExplorerToolStripMenuItem
        '
        Me.OpenInExplorerToolStripMenuItem.Name = "OpenInExplorerToolStripMenuItem"
        Me.OpenInExplorerToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.OpenInExplorerToolStripMenuItem.Text = "&Open in Explorer"
        '
        'b_setSize
        '
        Me.b_setSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.b_setSize.Font = New System.Drawing.Font("Wingdings", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.b_setSize.ForeColor = System.Drawing.Color.Green
        Me.b_setSize.Location = New System.Drawing.Point(207, 33)
        Me.b_setSize.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.b_setSize.Name = "b_setSize"
        Me.b_setSize.Size = New System.Drawing.Size(24, 24)
        Me.b_setSize.TabIndex = 6
        Me.b_setSize.Text = "p"
        Me.ToolTip1.SetToolTip(Me.b_setSize, "Set Absolute Canvas Size")
        Me.b_setSize.UseVisualStyleBackColor = True
        '
        'ToolTip1
        '
        Me.ToolTip1.AutoPopDelay = 15000
        Me.ToolTip1.InitialDelay = 500
        Me.ToolTip1.ReshowDelay = 100
        '
        'Label2
        '
        Me.Label2.ContextMenuStrip = Me.cms_canvassize
        Me.Label2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Indigo
        Me.Label2.Location = New System.Drawing.Point(0, 289)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(552, 20)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "ScreenCanvas "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.Label2, "ScreenCanvas by SpOOKy~Labs, Freeware, 2021" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Click to visit official website" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'Check_sDate
        '
        Me.Check_sDate.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Check_sDate.Location = New System.Drawing.Point(3, 65)
        Me.Check_sDate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Check_sDate.Name = "Check_sDate"
        Me.Check_sDate.Size = New System.Drawing.Size(269, 18)
        Me.Check_sDate.TabIndex = 3
        Me.Check_sDate.Text = "Show Month numbers in TimeStamps"
        Me.ToolTip1.SetToolTip(Me.Check_sDate, "... instead of showing month Names")
        Me.Check_sDate.UseVisualStyleBackColor = True
        '
        'L_SetTkey
        '
        Me.L_SetTkey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.L_SetTkey.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_SetTkey.ForeColor = System.Drawing.Color.Black
        Me.L_SetTkey.Location = New System.Drawing.Point(275, 0)
        Me.L_SetTkey.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.L_SetTkey.Name = "L_SetTkey"
        Me.L_SetTkey.Size = New System.Drawing.Size(277, 30)
        Me.L_SetTkey.TabIndex = 36
        Me.L_SetTkey.Text = "Transapency Key"
        Me.L_SetTkey.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.L_SetTkey, resources.GetString("L_SetTkey.ToolTip"))
        '
        'nud_anchorW
        '
        Me.nud_anchorW.Location = New System.Drawing.Point(63, 184)
        Me.nud_anchorW.Margin = New System.Windows.Forms.Padding(4)
        Me.nud_anchorW.Minimum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.nud_anchorW.Name = "nud_anchorW"
        Me.nud_anchorW.Size = New System.Drawing.Size(47, 23)
        Me.nud_anchorW.TabIndex = 37
        Me.ToolTip1.SetToolTip(Me.nud_anchorW, "Anchor Width")
        Me.nud_anchorW.Value = New Decimal(New Integer() {64, 0, 0, 0})
        '
        'nud_anchorH
        '
        Me.nud_anchorH.Location = New System.Drawing.Point(118, 184)
        Me.nud_anchorH.Margin = New System.Windows.Forms.Padding(4)
        Me.nud_anchorH.Minimum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.nud_anchorH.Name = "nud_anchorH"
        Me.nud_anchorH.Size = New System.Drawing.Size(47, 23)
        Me.nud_anchorH.TabIndex = 38
        Me.ToolTip1.SetToolTip(Me.nud_anchorH, "Anchor Height")
        Me.nud_anchorH.Value = New Decimal(New Integer() {64, 0, 0, 0})
        '
        'L_pathR
        '
        Me.L_pathR.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.L_pathR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.L_pathR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.L_pathR.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_pathR.ForeColor = System.Drawing.Color.Black
        Me.L_pathR.Location = New System.Drawing.Point(-1, -1)
        Me.L_pathR.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.L_pathR.Name = "L_pathR"
        Me.L_pathR.Size = New System.Drawing.Size(553, 19)
        Me.L_pathR.TabIndex = 39
        Me.L_pathR.Tag = "1"
        Me.L_pathR.Text = "%"
        Me.ToolTip1.SetToolTip(Me.L_pathR, "Anchor Image for Canvas Mode ON" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Left-Click to Select Image" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Right-Click to Cle" & _
                "ar Image (Use Default)")
        '
        'L_pathG
        '
        Me.L_pathG.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.L_pathG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.L_pathG.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.L_pathG.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_pathG.ForeColor = System.Drawing.Color.Black
        Me.L_pathG.Location = New System.Drawing.Point(-1, 35)
        Me.L_pathG.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.L_pathG.Name = "L_pathG"
        Me.L_pathG.Size = New System.Drawing.Size(553, 19)
        Me.L_pathG.TabIndex = 40
        Me.L_pathG.Tag = "0"
        Me.L_pathG.Text = "%"
        Me.ToolTip1.SetToolTip(Me.L_pathG, "Anchor Image for Canvas Mode OFF" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Left-Click to Select Image" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Right-Click to Cl" & _
                "ear Image (Use Default)")
        '
        'L_pathY
        '
        Me.L_pathY.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.L_pathY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.L_pathY.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.L_pathY.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_pathY.ForeColor = System.Drawing.Color.Black
        Me.L_pathY.Location = New System.Drawing.Point(-1, 17)
        Me.L_pathY.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.L_pathY.Name = "L_pathY"
        Me.L_pathY.Size = New System.Drawing.Size(553, 19)
        Me.L_pathY.TabIndex = 41
        Me.L_pathY.Tag = "2"
        Me.L_pathY.Text = "%"
        Me.ToolTip1.SetToolTip(Me.L_pathY, "Anchor Image for Notification Animation" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Left-Click to Select Image" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Right-Clic" & _
                "k to Clear Image (Use Default)")
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(43, 164)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(143, 16)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Anchor size"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ToolTip1.SetToolTip(Me.Label4, "Double-Click to get default size")
        '
        'TSTBPrefixS
        '
        Me.TSTBPrefixS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TSTBPrefixS.Location = New System.Drawing.Point(118, 12)
        Me.TSTBPrefixS.Name = "TSTBPrefixS"
        Me.TSTBPrefixS.Size = New System.Drawing.Size(153, 23)
        Me.TSTBPrefixS.TabIndex = 45
        Me.ToolTip1.SetToolTip(Me.TSTBPrefixS, "Prefix to use for quick save")
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(1, 36)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(110, 23)
        Me.Label13.TabIndex = 47
        Me.Label13.Text = "Pixel Format"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.Label13, "Pixel format to use for saving png images")
        '
        'Check_tooltips
        '
        Me.Check_tooltips.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Check_tooltips.Checked = True
        Me.Check_tooltips.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Check_tooltips.Location = New System.Drawing.Point(3, 24)
        Me.Check_tooltips.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Check_tooltips.Name = "Check_tooltips"
        Me.Check_tooltips.Size = New System.Drawing.Size(269, 18)
        Me.Check_tooltips.TabIndex = 2
        Me.Check_tooltips.Text = "Show tool tips on toolbox items"
        Me.Check_tooltips.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(0, 23)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(137, 16)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "Max Undo Allowed"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Check_sTime
        '
        Me.Check_sTime.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Check_sTime.Location = New System.Drawing.Point(3, 85)
        Me.Check_sTime.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Check_sTime.Name = "Check_sTime"
        Me.Check_sTime.Size = New System.Drawing.Size(269, 18)
        Me.Check_sTime.TabIndex = 4
        Me.Check_sTime.Text = "Hide Seconds in TimeStamps"
        Me.Check_sTime.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.b_setSize)
        Me.Panel1.Controls.Add(Me.nud_canvasX)
        Me.Panel1.Controls.Add(Me.nud_canvasY)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.b_YAdd)
        Me.Panel1.Controls.Add(Me.b_YSub)
        Me.Panel1.Controls.Add(Me.b_XSub)
        Me.Panel1.Controls.Add(Me.b_XAdd)
        Me.Panel1.Location = New System.Drawing.Point(275, 29)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(277, 91)
        Me.Panel1.TabIndex = 31
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.NUD_maxUndo)
        Me.Panel2.Controls.Add(Me.Label_imgC)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(-1, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(277, 51)
        Me.Panel2.TabIndex = 0
        Me.Panel2.TabStop = True
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Check_resetpanonDrop)
        Me.Panel3.Controls.Add(Me.Check_sTime)
        Me.Panel3.Controls.Add(Me.Check_tooltips)
        Me.Panel3.Controls.Add(Me.Check_HideAnchr)
        Me.Panel3.Controls.Add(Me.Check_sDate)
        Me.Panel3.Location = New System.Drawing.Point(-1, 49)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(277, 112)
        Me.Panel3.TabIndex = 34
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.L_pathR)
        Me.Panel4.Controls.Add(Me.L_pathG)
        Me.Panel4.Controls.Add(Me.L_pathY)
        Me.Panel4.Location = New System.Drawing.Point(-1, 230)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(553, 56)
        Me.Panel4.TabIndex = 43
        '
        'Check_HideAnchr
        '
        Me.Check_HideAnchr.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Check_HideAnchr.Location = New System.Drawing.Point(3, 44)
        Me.Check_HideAnchr.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Check_HideAnchr.Name = "Check_HideAnchr"
        Me.Check_HideAnchr.Size = New System.Drawing.Size(269, 18)
        Me.Check_HideAnchr.TabIndex = 44
        Me.Check_HideAnchr.Text = "Hide Anchor in Canvas Mode"
        Me.Check_HideAnchr.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(4, 11)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(110, 21)
        Me.Label11.TabIndex = 43
        Me.Label11.Text = "QuickSave Prefix"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.Label13)
        Me.Panel5.Controls.Add(Me.Combo_pixFormat)
        Me.Panel5.Controls.Add(Me.Label11)
        Me.Panel5.Controls.Add(Me.TSTBPrefixS)
        Me.Panel5.Controls.Add(Me.Label12)
        Me.Panel5.Location = New System.Drawing.Point(275, 119)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(277, 112)
        Me.Panel5.TabIndex = 46
        '
        'Combo_pixFormat
        '
        Me.Combo_pixFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combo_pixFormat.FormattingEnabled = True
        Me.Combo_pixFormat.Location = New System.Drawing.Point(118, 37)
        Me.Combo_pixFormat.Name = "Combo_pixFormat"
        Me.Combo_pixFormat.Size = New System.Drawing.Size(153, 23)
        Me.Combo_pixFormat.TabIndex = 46
        '
        'Check_resetpanonDrop
        '
        Me.Check_resetpanonDrop.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Check_resetpanonDrop.Location = New System.Drawing.Point(3, 4)
        Me.Check_resetpanonDrop.Name = "Check_resetpanonDrop"
        Me.Check_resetpanonDrop.Size = New System.Drawing.Size(269, 17)
        Me.Check_resetpanonDrop.TabIndex = 47
        Me.Check_resetpanonDrop.Text = "Always Reset Pan on File Drop"
        Me.Check_resetpanonDrop.UseVisualStyleBackColor = True
        '
        'settings_page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(551, 314)
        Me.Controls.Add(Me.nud_anchorH)
        Me.Controls.Add(Me.nud_anchorW)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.PictureBoxicon)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.L_SetTkey)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "settings_page"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ScreenCanvas Settings"
        Me.TopMost = True
        CType(Me.NUD_maxUndo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxicon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nud_canvasY, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nud_canvasX, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cms_canvassize.ResumeLayout(False)
        Me.cms_quicksave.ResumeLayout(False)
        CType(Me.nud_anchorW, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nud_anchorH, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents NUD_maxUndo As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label_imgC As System.Windows.Forms.Label
    Friend WithEvents PictureBoxicon As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents nud_canvasY As System.Windows.Forms.NumericUpDown
    Friend WithEvents nud_canvasX As System.Windows.Forms.NumericUpDown
    Friend WithEvents b_XAdd As System.Windows.Forms.Button
    Friend WithEvents b_XSub As System.Windows.Forms.Button
    Friend WithEvents b_YSub As System.Windows.Forms.Button
    Friend WithEvents b_YAdd As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents b_setSize As System.Windows.Forms.Button
    Friend WithEvents cms_canvassize As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents WorkingAreaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ScreenBoundsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents cms_quicksave As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ChangePathToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyPathToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenInExplorerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Check_tooltips As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Check_sTime As System.Windows.Forms.CheckBox
    Friend WithEvents Check_sDate As System.Windows.Forms.CheckBox
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents L_SetTkey As System.Windows.Forms.Label
    Friend WithEvents nud_anchorW As System.Windows.Forms.NumericUpDown
    Friend WithEvents nud_anchorH As System.Windows.Forms.NumericUpDown
    Friend WithEvents L_pathR As System.Windows.Forms.Label
    Friend WithEvents L_pathG As System.Windows.Forms.Label
    Friend WithEvents L_pathY As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Check_HideAnchr As System.Windows.Forms.CheckBox
    Friend WithEvents TSTBPrefixS As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Combo_pixFormat As System.Windows.Forms.ComboBox
    Friend WithEvents Check_resetpanonDrop As System.Windows.Forms.CheckBox
End Class
