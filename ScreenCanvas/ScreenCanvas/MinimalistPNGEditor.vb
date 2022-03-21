Public Class MinimalistPNGEditor

#Region "' Declearations '"

    Dim _config_error As Boolean
    Dim _do_sounds As Boolean = True
    'Dim _show_Coords As Boolean = False

    Dim _itool2cursor(0 To 21) As Cursor
    Dim ImgL(0 To 2) As Image
    Dim _pixFormat As Drawing.Imaging.PixelFormat = Drawing.Imaging.PixelFormat.Format24bppRgb


    Dim _SETTING_COLORS As ListOnDisk(Of Color)     ' an LoD which stores custom colors to disk
    Dim _SETTING As HoDOfObject                     ' an LoD for AppSettings to disk
    Dim _settings_types As Object(,)
    Dim _SETTING_BOOKMARKS As ListOnDisk(Of BookMarkItem)


    Dim _col_marker As Color = Color.Black                  ' Marker Color
    Dim _col_write_penN As New Pen(_col_marker, _pen_size)  ' pen for marker and calligraphy
    Dim _col_shape_pen As New Pen(_col_marker, _shape_size) ' pen for shapes
    Dim _col_marker_bruN As New SolidBrush(_col_marker)      ' a brush of the same color
    ' Dim _col_marker_bruH As New SolidBrush(Color.FromArgb(80, _col_marker))     ' a brush of the same color
    Dim _calpen As New Pen(_col_marker, 1)                  ' pen for calligraphy
    Dim _calangle As Single = -35 * (Math.PI / 180)         ' inclination angle for calligraphy

    Dim _picColor As Boolean = False                        ' flag for color-picker

    Dim _xpen As Pen            ' pen for eraser (color = transperancy key of the form)
    Dim _xbru As Brush          ' a brush of the same color

    Dim grid_penX As Pen = Pens.IndianRed           ' pen for X-Axis
    Dim grid_penY As Pen = Pens.Blue                ' pen for Y-Axis
    Dim grid_pen As Pen = Pens.GreenYellow          ' pen for overlay axis
    Dim grid_brush As Brush = Brushes.GreenYellow   ' a brush of the same color

    Dim _vfx As Graphics = Nothing                                      ' the graphics object for screen
    Dim _VRect As New RectangleF(New PointF(0, 0), New SizeF(1, 1))     ' this view rectangle is placed on image
    Dim _VBase As New RectangleF(New Point(0, 0), New SizeF(1, 1))      ' this is base rectagle placed on canvas
    Dim _VbaseMid As New Point(0, 0)                                    ' the mid point of view canvas


    ' Zoom related variables - zoom is not implement 
    ' Dim _Vzoom As Single = 1                                            ' zoom - not implemented
    ' Dim _imgRect As Rectangle   ' a rectangle that represents image bounds on the viewing frame
    ' Dim _imgRegi As Region      ' a region that is used to XoR with view frame for finding gray area

    Dim _ifx As Graphics = Nothing          ' graphics to draw on image
    Dim _img As Bitmap                      ' the actual image/canvas
    Dim _imgStack As New List(Of Bitmap)    ' the Undo Stack
    Dim _imgC As Integer = -1               ' the Undo stack pointer


    ' AXIS POINTS AND ROTATION - defines axis end points used to draw axis lines
    Dim _rotScale As Single = 0
    Dim _endp As PointF() = {New PointF(_VBase.Width, _VbaseMid.Y),
                             New PointF(_VbaseMid.X, 0),
                             New PointF(0, _VbaseMid.Y),
                             New PointF(_VbaseMid.X, _VBase.Height)} 'east-norst-west-south

    Dim _axis_points_pts As New List(Of PointF) ' marked points on axis
    Dim _axis_points_pens As New List(Of Pen)   ' color for marked points


    ' Misc
    Dim _ZeroPt As New Point(0, 0)          ' default origin point
    Dim _isOpen As Boolean = False          ' flag indicating if an Image is Open (user can interact)
    Dim _prevME As Boolean = False          ' flag to refresh canvas on mouse enter event
    Dim _isTBVis As Boolean = True          ' flag to hide toolbox only (not color pallete)
    Dim _lastvrect As PointF                ' memory for canvas-pan
    Dim _phmd As Boolean = False            ' flag for Mouse down for anchor
    Dim _phpt As Point                      ' last point for Mouse down for anchor
    Dim _isPltExand As Boolean = False    ' for collapsing trackbars

    ' for anchor animation and icons
    Dim _swapImg As Integer = -1
    Dim _trueImg As Boolean
    Dim totaltime As Integer
    Dim _unitV As Point


    ' screen shot related
    Dim _smalPt As Point
    Dim ScreenBounds As Rectangle
    Dim WorkBounds As Rectangle
    Dim _prevDialogstate As Boolean
    Dim _prevDialogPoint As Point
    Dim _prevPtext As String = ""


    'selection related
    Dim _selecting As Boolean = False
    Dim _selRect As Rectangle

    'keyboar input focus
    Dim _lostFocusBC As Color = Color.FromArgb(255, 192, 192)
    Dim _gotFocusBC As Color = Color.FromArgb(192, 255, 192)

    'for form load
    Dim _isfirstLoad As Boolean = False
    Dim _arrOfCols As Panel()
    Dim _modeBig As Boolean = False
    Dim setpage As settings_page            ' <<---------- SETTINGS FORM

    ' for Canvas Mouse-Events and editor tools
    Dim _isMD As Boolean                    ' flag for mouse down event
    Dim _downPT, _downPTx, _eLx As PointF   ' memory for mouse points
    Dim _point_argsx As Point() = {_ZeroPt, _ZeroPt, _ZeroPt, _ZeroPt}
    Dim _point_argsT As Point() = {_ZeroPt, _ZeroPt, _ZeroPt, _ZeroPt}
    Dim _ipoints As Integer = -1

    ' drawing delegates for rainbow effect
    Delegate Sub Draw_Next_DG(ByVal EL As PointF)
    Dim DN_marker As Draw_Next_DG
    Dim DN_cally As Draw_Next_DG
    Dim DN_custom As Draw_Next_DG
    Dim _rainbow_shift As Single = 1

    'for textInput area
    Dim _mdTxtIn As Boolean = False
    Dim _mdTxtInPt As Point
    Dim _mdtresize As Boolean = False
    Dim _mdtresizePt As Point
    Const TextPanel_MinSize As Integer = 66

    ' for Panel Mouse-Events
    Dim _panel_md As Boolean = False
    Dim _panel_mp As Point

    'for hue shift in panel_selcol
    Dim hsl_col As Single()
    Dim hsl_colF As Single()



    ' marker, eraser, cally Tool Properties
    Dim _eraser_size As Integer = 1
    Dim _pen_size As Integer = 1
    Dim _pen_half_size As Single = 0.5
    Dim _shape_size As Integer = 1
    Dim _sfac As Integer = 0
    Dim _iTool As EditorTool = EditorTool.iPointer
    Public Property MyEditorTool As Integer
        Get
            Return _iTool
        End Get
        Set(ByVal value As Integer)
            _iTool = value
            my_canvas.Cursor = _itool2cursor(value)
        End Set
    End Property
    Public Property MyMarkerSize As Integer
        Get
            Return _pen_size
        End Get
        Set(ByVal value As Integer)
            If _pen_size = value Then Exit Property
            _pen_size = value
            _pen_half_size = value / 2
            _col_write_penN.Width = value
        End Set
    End Property
    Public Property MyEraserSize As Integer
        Get
            Return _eraser_size
        End Get
        Set(ByVal value As Integer)
            If _eraser_size = value Then Exit Property
            _eraser_size = value
            _xpen.Width = value * 2
        End Set
    End Property
    Public Property MyShapeSize As Integer
        Get
            Return _shape_size
        End Get
        Set(ByVal value As Integer)
            If _shape_size = value Then Exit Property
            _shape_size = value
            _col_shape_pen.Width = value
            _sfac = Convert.ToInt32(_shape_size / 2)
        End Set
    End Property
    Public Property MyMarkerColor As Color
        Get
            Return _col_marker
        End Get
        Set(ByVal value As Color)
            If _col_marker = value Then Exit Property
            _col_marker = value
            _col_write_penN.Color = _col_marker ' = New Pen(_col_marker, _pen_size)
            _col_shape_pen.Color = _col_marker '= New Pen(_col_marker, _shape_size)
            _col_marker_bruN.Color = _col_marker ' = New SolidBrush(_col_marker)
            '_col_marker_bruH.Color = Color.FromArgb(80, _col_marker)
            _calpen.Color = _col_marker
            _cpen.Color = _col_marker
            _cbru.Color = _col_marker
        End Set
    End Property

#End Region

#Region "' Undo-Stack '"

    Private Sub AddImageStack()
        Dim MAX_UNDO As Integer = setpage.NUD_maxUndo.Value
        If _imgC = _imgStack.Count - 1 Then            ' has no redo
            _imgStack.Add(_img.Clone)
            _imgC += 1
            If _imgC > MAX_UNDO Then
                _imgC -= 1
                _imgStack(0).Dispose()
                _imgStack.RemoveAt(0)
            End If
        Else                                            ' has redo - remove all redo
            For i = _imgC + 1 To _imgStack.Count - _imgC - 1
                _imgStack(i).Dispose()
            Next
            _imgStack.RemoveRange(_imgC + 1, _imgStack.Count - _imgC - 1)
            _imgC += 1
            _imgStack.Add(_img.Clone)
        End If
    End Sub
    Private Function AddImageStack(ByVal _imgArg As Bitmap) As Graphics
        Dim MAX_UNDO As Integer = setpage.NUD_maxUndo.Value
        _img = _imgArg
        '  canvasOverlay.Size = New Size(_olRatio * _img.Width, _olRatio * _img.Height)
        If _imgC = _imgStack.Count - 1 Then            ' has no redo
            _imgC += 1
            _imgStack.Add(_img.Clone)
            If _imgC > MAX_UNDO Then
                _imgC -= 1
                _imgStack.RemoveAt(0)
            End If
        Else                                            ' has redo - remove all redo
            _imgStack.RemoveRange(_imgC + 1, _imgStack.Count - _imgC - 1)
            _imgC += 1
            _imgStack.Add(_img.Clone)
        End If

        Return Graphics.FromImage(_img)
    End Function
    Private Function AddImageStack(ByVal _imgArg As Bitmap, ByVal clear_col As Color) As Graphics
        Dim MAX_UNDO As Integer = setpage.NUD_maxUndo.Value
        _img = _imgArg
        '  canvasOverlay.Size = New Size(_olRatio * _img.Width, _olRatio * _img.Height)
        Dim rfx As Graphics = Graphics.FromImage(_img)
        rfx.Clear(clear_col)

        If _imgC = _imgStack.Count - 1 Then
            ' has no redo
            _imgC += 1
            _imgStack.Add(_img.Clone)
            If _imgC > MAX_UNDO Then
                _imgC -= 1
                _imgStack.RemoveAt(0)
            End If
        Else
            _imgStack.RemoveRange(_imgC + 1, _imgStack.Count - _imgC - 1)

            _imgC += 1
            _imgStack.Add(_img.Clone)
        End If
        Return rfx
    End Function

    Private Sub UndoStack()
        If _imgC < 1 Then Exit Sub
        _imgC -= 1
        _img = _imgStack(_imgC).Clone
        '  canvasOverlay.Size = New Size(_olRatio * _img.Width, _olRatio * _img.Height)
        _ifx = Graphics.FromImage(_img)
        View_Draw(True)
    End Sub
    Private Sub RedoStack()
        If _imgC >= _imgStack.Count - 1 Then Exit Sub
        _imgC += 1
        _img = _imgStack(_imgC).Clone
        'canvasOverlay.Size = New Size(_olRatio * _img.Width, _olRatio * _img.Height)
        _ifx = Graphics.FromImage(_img)
        View_Draw(True)
    End Sub

    Private Sub B_Redo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Redo.Click
        If Not _isOpen Then Exit Sub
        RedoStack()
    End Sub
    Private Sub B_Undo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Undo.Click
        If Not _isOpen Then Exit Sub
        UndoStack()
    End Sub

#End Region

#Region "' Image & View '"

    ' those controls which require an image to be open already
    Private Sub Image_OC_Enable_controls(ByVal en As Boolean)
        ClearToolStripMenuItem.Enabled = en
        B_Undo.Enabled = en
        B_Redo.Enabled = en
        '   B_ResetPan.Enabled = en
        B_FontChange.Enabled = en
        B_inputfocus.Enabled = en
    End Sub

    Private Sub Image_Close()
        If _imgStack.Count > 0 Then
            _vfx.Dispose()
            _ifx.Dispose()
            _img.Dispose()

            _vfx = Nothing
            _ifx = Nothing
            _img = Nothing
            '  canvasOverlay.Size = New Size(0, 0)
            For i = 0 To _imgStack.Count - 1
                _imgStack(i).Dispose()
            Next
            _imgStack.Clear()
            _imgC = -1
        End If


        Image_OC_Enable_controls(False)         'disable control that work on opened images only
        _isOpen = False                         'set open flag 
    End Sub

    Private Sub Image_Create(ByVal xwid As Integer, ByVal yhig As Integer, ByVal clear_col As Color, ByVal arg_reset_pan As Boolean)
        If _isOpen Then Image_Close()
        _ifx = AddImageStack(New Bitmap(xwid, yhig, _pixFormat), clear_col)
        View_Create(arg_reset_pan)
        View_Draw(False)
        Image_OC_Enable_controls(True)
        _isOpen = True
    End Sub

    Private Sub View_AxisRot(ByVal rotation_radian As Single, ByVal dodraw As Boolean)
        _rotScale = rotation_radian
        Dim _maxDia As Single = Math.Pow(_VBase.Width * _VBase.Width + _VBase.Height * _VBase.Height, 0.5)
        _endp(0) = RotatePoint(New PointF(_maxDia, _VbaseMid.Y), _VbaseMid, _rotScale)
        _endp(1) = RotatePoint(New PointF(_VbaseMid.X, -_maxDia), _VbaseMid, _rotScale)
        _endp(2) = RotatePoint(New PointF(-_maxDia, _VbaseMid.Y), _VbaseMid, _rotScale)
        _endp(3) = RotatePoint(New PointF(_VbaseMid.X, _maxDia), _VbaseMid, _rotScale)
        If dodraw And _isOpen Then View_Draw(False)
    End Sub

    Private Sub View_Create(ByVal arg_reset_pan As Boolean)
        _vfx = my_canvas.CreateGraphics
        _VBase.Width = my_canvas.Width
        _VBase.Height = my_canvas.Height
        _VbaseMid.X = _VBase.Width / 2
        _VbaseMid.Y = _VBase.Height / 2
        _VRect.Width = _VBase.Width
        _VRect.Height = _VBase.Height
        _orect.Width = _olRatio * _VRect.Width
        _orect.Height = _olRatio * _VRect.Height
        If arg_reset_pan Then Reset_Pan()
        View_AxisRot(_rotScale, False)
    End Sub

    Private Sub View_Draw(ByVal do_clear As Boolean)

        'clear if required
        If do_clear Then _vfx.Clear(Me.TransparencyKey)

        'Draw Image
        _vfx.DrawImage(_img, _VBase, _VRect, GraphicsUnit.Pixel)

        'Draw Border
        _vfx.DrawRectangle(grid_pen, -_VRect.X - 1, -_VRect.Y - 1, _img.Width + 1, _img.Height + 1)

        'Draw Axis and grid points
        If chk_showScale.Checked Then
            _vfx.DrawLine(grid_penX, _endp(0), _endp(2))
            _vfx.DrawLine(grid_penY, _endp(1), _endp(3))
            _vfx.DrawEllipse(grid_pen, _VbaseMid.X - 15, _VbaseMid.Y - 15, 30, 30)
            _vfx.DrawLine(grid_pen, 0, _VbaseMid.Y, _VBase.Width, _VbaseMid.Y)
            _vfx.DrawLine(grid_pen, _VbaseMid.X, 0, _VbaseMid.X, _VBase.Height)
            For i = 0 To _axis_points_pts.Count - 1
                _vfx.DrawEllipse(_axis_points_pens(i), _axis_points_pts(i).X - 2, _axis_points_pts(i).Y - 2, 4, 4)
                _vfx.DrawEllipse(_axis_points_pens(i), _axis_points_pts(i).X - 10, _axis_points_pts(i).Y - 10, 20, 20)
            Next
            ' drop-perpendiculars on axis
            If Check_dropPP.Checked Then
                For i = 0 To _axis_points_pts.Count - 1
                    _vfx.DrawLine(_axis_points_pens(i), 0, _axis_points_pts(i).Y, _VRect.Width, _axis_points_pts(i).Y)
                    _vfx.DrawLine(_axis_points_pens(i), _axis_points_pts(i).X, 0, _axis_points_pts(i).X, _VRect.Height)
                Next
            End If
        End If

        ' draw any existing marker points
        drawMarkerPoint()

        'draw selection
        If _selecting Then
            ' _vfx.DrawRectangle(grid_penX, _selectedRect)
            Dim _selectedRectT As New Rectangle(_selRect.X - _VRect.X,
                                                _selRect.Y - _VRect.Y,
                                                 _selRect.Width, _selRect.Height)

            _vfx.DrawRectangle(grid_pen, _selectedRectT)
        End If


    End Sub

    Private Sub drawMarkerPoint()
        'draws temporary points that are required by some tools
        If _ipoints > -1 Then
            For i = 0 To _ipoints
                _vfx.DrawEllipse(grid_penX, _point_argsT(i).X - 1, _point_argsT(i).Y - 1, 2, 2)
                _vfx.DrawEllipse(grid_penY, _point_argsT(i).X - 2, _point_argsT(i).Y - 2, 4, 4)
            Next
        End If
    End Sub

    Private Sub View_Pan(ByVal Horz As Integer, ByVal Vert As Integer)
        If Horz = 0 And Vert = 0 Then Exit Sub
        _VRect.X += Horz
        _VRect.Y += Vert
        _orect.X += _olRatio * Horz
        _orect.Y += _olRatio * Vert
        _lastvrect = _VRect.Location
    End Sub
    Private Sub Reset_Pan()
        _VRect.X = 0
        _VRect.Y = 0
        _orect.X = 0
        _orect.Y = 0
        _lastvrect = _VRect.Location
    End Sub
    Private Sub B_ResetPan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Reset_Pan()
        View_Draw(True)
    End Sub

    Friend Function ExtendCanvas(ByVal xdir As Integer, ByVal ydir As Integer, ByVal do_set As Boolean) As String
        If Not _isOpen Then Return "not opened!!"
        If xdir = 0 And ydir = 0 Then Return _img.Width.ToString + " x " + _img.Height.ToString

        Dim newX, newY As Integer
        If do_set Then
            newX = xdir
            newY = ydir
        Else
            newX = _img.Width + xdir
            newY = _img.Height + ydir
        End If
        If newX <= 0 Or newY <= 0 Then
            MsgBox("Invalid Extension: New size is [" + newX.ToString + ", " + newY.ToString + "]", vbCritical)
            Return _img.Width.ToString + " x " + _img.Height.ToString
        End If
        Dim _timg As New Bitmap(newX, newY, _pixFormat)
        Dim _tifx As Graphics = Graphics.FromImage(_timg)
        _tifx.Clear(Me.TransparencyKey)
        _tifx.DrawImage(_img, 0, 0)

        ' Image_Fix_Rect()
        _ifx = AddImageStack(_timg)
        View_Create(False)
        View_Draw(True)
        If _do_sounds Then My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
        Return newX.ToString + " x " + newY.ToString
    End Function

#End Region

#Region "' CanVas Mouse Events '"

    Private Sub _rainshift()
        hsl_col = RGB_HSL(MyMarkerColor)
        hsl_col(0) += (0.002777777778 * _rainbow_shift) Mod 1
        MyMarkerColor = HSL_RGB(hsl_col(0), hsl_col(1), hsl_col(2))
    End Sub

    Private Sub MinimalistPNGEditor_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles my_canvas.MouseEnter
        If Not _prevME Then
            View_Draw(False)
            _prevME = False
            t_kp.Focus()
        End If

    End Sub

    Private Sub TextTootl_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextTootl.GotFocus, text_webaddr.GotFocus
        _prevME = True
    End Sub

    Private Sub Draw_Next(ByVal eLA As PointF)

        'transform points
        _downPTx.X = _VRect.X + _downPT.X
        _downPTx.Y = _VRect.Y + _downPT.Y
        _eLx.X = _VRect.X + eLA.X
        _eLx.Y = _VRect.Y + eLA.Y

        ' draw on screen
        _vfx.DrawLine(_col_write_penN, _downPT, eLA)
        _vfx.FillEllipse(_col_marker_bruN,
                         eLA.X - _pen_half_size, eLA.Y - _pen_half_size,
                          _pen_size, _pen_size)

        ' draw on image
        _ifx.DrawLine(_col_write_penN, _downPTx, _eLx)
        _ifx.FillEllipse(_col_marker_bruN,
                         _eLx.X - _pen_half_size, _eLx.Y - _pen_half_size,
                          _pen_size, _pen_size)

    End Sub
    Private Sub Draw_Down(ByVal eLA As PointF)

        'transform points
        _eLx.X = _VRect.X + eLA.X
        _eLx.Y = _VRect.Y + eLA.Y

        ' draw on screen
        _vfx.FillEllipse(_col_marker_bruN, eLA.X - _pen_half_size, eLA.Y - _pen_half_size, _pen_size, _pen_size)

        ' draw on image
        _ifx.FillEllipse(_col_marker_bruN, _eLx.X - _pen_half_size, _eLx.Y - _pen_half_size, _pen_size, _pen_size)

        If chk_rainbow.Checked Then _rainshift()
    End Sub
    Private Sub Draw_NextR(ByVal eLA As PointF)
        _rainshift()
        Draw_Next(eLA)

    End Sub

    Private Sub Draw_Next_iCally(ByVal eLA As PointF)
        _downPTx.X = _VRect.X + _downPT.X
        _downPTx.Y = _VRect.Y + _downPT.Y
        _eLx.X = _VRect.X + eLA.X
        _eLx.Y = _VRect.Y + eLA.Y

        Dim elATLR As PointF() = Point_st_Rdis_th(eLA, _calangle, _pen_half_size)
        Dim dpTLR As PointF() = Point_st_Rdis_th(_downPT, _calangle, _pen_half_size)
        _vfx.FillPolygon(_col_marker_bruN, {dpTLR(0), dpTLR(1), elATLR(1), elATLR(0)})
        _vfx.DrawLine(_calpen, _downPT, eLA)

        Dim elxTLR As PointF() = Point_st_Rdis_th(_eLx, _calangle, _pen_half_size)
        Dim dpxTLR As PointF() = Point_st_Rdis_th(_downPTx, _calangle, _pen_half_size)
        _ifx.FillPolygon(_col_marker_bruN, {dpxTLR(0), dpxTLR(1), elxTLR(1), elxTLR(0)})
        _ifx.DrawLine(_calpen, _downPTx, _eLx)

    End Sub
    Private Sub Draw_Down_iCally(ByVal eLA As PointF)
        _eLx.X = _VRect.X + eLA.X
        _eLx.Y = _VRect.Y + eLA.Y

        Dim elATLR As PointF() = Point_st_Rdis_th(eLA, _calangle, _pen_half_size)
        _vfx.DrawLine(_calpen, elATLR(0), elATLR(1))

        Dim elxTLR As PointF() = Point_st_Rdis_th(_eLx, _calangle, _pen_half_size)
        _ifx.DrawLine(_calpen, elxTLR(0), elxTLR(1))
        If chk_rainbow.Checked Then _rainshift()

    End Sub
    Private Sub Draw_NextR_iCally(ByVal eLA As PointF)
        _rainshift()
        Draw_Next_iCally(eLA)
    End Sub

    ' Dim _cwid As Integer = 1
    '  Dim _ccol As Color = Color.Navy
    Dim _cbru As SolidBrush = New SolidBrush(_col_marker)
    Dim _cpen As New Pen(_col_marker, 1)
    '@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
    Private Sub Draw_Down_iCustom(ByVal eLA As PointF)
        _eLx.X = _VRect.X + eLA.X
        _eLx.Y = _VRect.Y + eLA.Y

        '   Dim elATLR As PointF() = Point_st_Rdis_th(eLA, _calangle, _pen_half_size)
        ' _vfx.DrawLine(_cpen, eLA, eLA)

        ' Dim elxTLR As PointF() = Point_st_Rdis_th(_eLx, _calangle, _pen_half_size)
        ' _ifx.DrawLine(_cpen, elxTLR(0), elxTLR(1))
        '    If chk_rainbow.Checked Then _rainshift()
        _vfx.FillEllipse(_cbru, eLA.X - 1, eLA.Y - 1, 2, 2)
        _ifx.FillEllipse(_cbru, _eLx.X - 1, _eLx.Y - 1, 2, 2)

        _cpen.LineJoin = Drawing2D.LineJoin.Bevel
        _cpen.DashStyle = Drawing2D.DashStyle.Dot
        '  _cpen.Alignment = System.Drawing.Drawing2D.PenAlignment.Left
        'System.Drawing.Drawing2D.PenType.
    End Sub
    Private Sub Draw_Next_iCustom(ByVal eLA As PointF)
        _downPTx.X = _VRect.X + _downPT.X
        _downPTx.Y = _VRect.Y + _downPT.Y
        _eLx.X = _VRect.X + eLA.X
        _eLx.Y = _VRect.Y + eLA.Y

        Dim elATLR As PointF() = Point_st_Rdis_th(eLA, _calangle, 2)
        Dim dpTLR As PointF() = Point_st_Rdis_th(_downPT, _calangle, 2)
        _vfx.FillPolygon(_cbru, {dpTLR(0), dpTLR(1), elATLR(1), elATLR(0)}, Drawing2D.FillMode.Winding)
        _vfx.DrawLine(_cpen, _downPT, eLA)
        '_vfx.FillEllipse(_cbru, eLA.X - _cwid, eLA.Y - _cwid, _cwid * 2, _cwid * 2)

        Dim elxTLR As PointF() = Point_st_Rdis_th(_eLx, _calangle, 2)
        Dim dpxTLR As PointF() = Point_st_Rdis_th(_downPTx, _calangle, 2)
        _ifx.FillPolygon(_cbru, {dpxTLR(0), dpxTLR(1), elxTLR(1), elxTLR(0)}, Drawing2D.FillMode.Winding)
        ' _ifx.FillPolygon(_cbru, {dpxTLR(0), dpxTLR(1), elxTLR(0), elxTLR(1)}, Drawing2D.FillMode.Winding)
        _ifx.DrawLine(_cpen, _downPTx, _eLx)
        ' _ifx.FillEllipse(_cbru, _eLx.X - _cwid, _eLx.Y - _cwid, _cwid * 2, _cwid * 2)
    End Sub

    '@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
    Private Sub Erase_Down(ByVal eLA As PointF)
        _eLx.X = _VRect.X + eLA.X
        _eLx.Y = _VRect.Y + eLA.Y
        _vfx.FillEllipse(_xbru, eLA.X - _eraser_size, eLA.Y - _eraser_size, _eraser_size * 2, _eraser_size * 2)
        _ifx.FillEllipse(_xbru, _eLx.X - _eraser_size, _eLx.Y - _eraser_size, _eraser_size * 2, _eraser_size * 2)
    End Sub
    Private Sub Erase_Next(ByVal eLA As PointF)
        _downPTx.X = _VRect.X + _downPT.X
        _downPTx.Y = _VRect.Y + _downPT.Y
        _eLx.X = _VRect.X + eLA.X
        _eLx.Y = _VRect.Y + eLA.Y

        _vfx.DrawLine(_xpen, _downPT, eLA)

        If Check_erasretrail.Checked Then
            _vfx.DrawEllipse(grid_pen,
                            eLA.X - _eraser_size - 1, eLA.Y - _eraser_size - 1,
                             _eraser_size * 2 + 2, _eraser_size * 2 + 2)
        End If

        _vfx.FillEllipse(_xbru,
                         eLA.X - _eraser_size, eLA.Y - _eraser_size,
                          _eraser_size * 2, _eraser_size * 2)

        _ifx.DrawLine(_xpen, _downPTx, _eLx)
        _ifx.FillEllipse(_xbru,
                         _eLx.X - _eraser_size, _eLx.Y - _eraser_size,
                          _eraser_size * 2, _eraser_size * 2)


    End Sub
    ' Private onn As Boolean = False

    '  Private Declare Sub mouse_event Lib "user32" (ByVal dwFlags As Integer, _
    '   ByVal dx As Integer, ByVal dy As Integer, ByVal cButtons As Integer, _
    '  ByVal dwExtraInfo As Integer)
    '   Dim onn As Boolean = False



    Private Sub my_canvas_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles my_canvas.MouseClick
        t_kp.Focus()
        Select Case e.Button
            Case Windows.Forms.MouseButtons.Right

                If Panel_Pallete.Visible Then
                    Pallet_CloseDialog()
                Else
                    Pallet_showDialog(e.Location)
                End If


            Case Else
        End Select
    End Sub

    Private Sub my_canvas_MouseWheel(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles my_canvas.MouseWheel
        'If Not _isOpen Then Exit Sub
        ' If onn Then Exit Sub
        If e.Delta < 0 Then 'zoom out
            nud_rotXangle.Text = Rad2Deg(_rotScale + 0.01)
            nud_rotXangle_Validated(Nothing, Nothing)
        Else ''zoom in
            nud_rotXangle.Text = Rad2Deg(_rotScale - 0.01)
            nud_rotXangle_Validated(Nothing, Nothing)
        End If
    End Sub

    Private Sub my_canvas_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles my_canvas.MouseDown
        '  If onn Then Exit Sub
        If Not _isOpen Then Exit Sub

        _isMD = False
        _picColor = False
        If e.Button = Windows.Forms.MouseButtons.Left Then

            Select Case _iTool
                Case EditorTool.iPointer
                    View_Draw(True)
                Case EditorTool.iCustomPen
                    _isMD = True
                    _downPT = e.Location
                    _calangle = NUD_ANGLEsel.CurrentAngle * (Math.PI / 180)
                    ' If chk_rainbow.Checked Then
                    '  DN_cally = AddressOf Draw_NextR_iCally
                    '  Else

                    DN_custom = AddressOf Draw_Next_iCustom
                    ' End If
                    Draw_Down_iCustom(e.Location)

                Case EditorTool.iColorPick
                    View_Draw(True)
                    _picColor = True
                    _isMD = True

                Case EditorTool.iMarker
                    _isMD = True
                    _downPT = e.Location
                    If chk_rainbow.Checked Then
                        DN_marker = AddressOf Draw_NextR
                    Else
                        DN_marker = AddressOf Draw_Next
                    End If
                    Draw_Down(e.Location)

                Case EditorTool.iCalligraphy
                    _isMD = True
                    _downPT = e.Location
                    _calangle = NUD_ANGLEsel.CurrentAngle * (Math.PI / 180)
                    If chk_rainbow.Checked Then
                        DN_cally = AddressOf Draw_NextR_iCally
                    Else
                        DN_cally = AddressOf Draw_Next_iCally
                    End If
                    Draw_Down_iCally(e.Location)

                Case EditorTool.iEraser
                    _isMD = True
                    _downPT = e.Location
                    Erase_Down(e.Location)
                Case EditorTool.iLine
                    et_iLine(e.Location)
                Case EditorTool.iRectangle
                    et_iRectangle(e.Location)
                Case EditorTool.iEllipse
                    et_iEllipse(e.Location)
                Case EditorTool.iGraph
                    et_iGraph(e.Location)
                Case EditorTool.iCircleDia
                    et_iCircleDia(e.Location)
                Case EditorTool.iTable
                    et_iTable(e.Location)
                Case EditorTool.iPath
                    et_iPath(e.Location)
                Case EditorTool.iAxisMarker
                    If Not chk_showScale.Checked Then chk_showScale.Checked = True
                    et_iAxisMarker(e.Location)
                Case EditorTool.iImagePaste
                    et_iImagePaste(e.Location)
                Case EditorTool.iImageCopy
                    et_iImageCopy(e.Location)
                Case EditorTool.iImageCut
                    et_iImageCut(e.Location)
                Case EditorTool.iScreenCopy
                    et_iScreenCopy(e.Location)
                Case EditorTool.iImagePasteR
                    et_iImagePasteR(e.Location)
                Case EditorTool.iDateTime
                    et_iDateTime(e.Location)
                Case EditorTool.iText
                    et_iText(e.Location)
                Case EditorTool.iSelectR
                    et_iSelectR(e.Location)
                Case Else
                    ' no valid editor tool
            End Select
        ElseIf e.Button = Windows.Forms.MouseButtons.Middle Then
            _isMD = True
            _downPT = e.Location
        End If
    End Sub
    Private Function pointSub(ByVal A As Object, ByVal B As Object) As Point
        Return New Point(A.X - B.X, A.Y - B.Y)
    End Function
    Private Function pointAdd(ByVal A As Object, ByVal B As Object) As Point
        Return New Point(A.X + B.X, A.Y + B.Y)
    End Function
    Private Sub my_canvas_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles my_canvas.MouseMove
        ' If onn Then Exit Sub
        '   If _selecting Then
        '   _vfx.DrawRectangle(Pens.AliceBlue, 
        ' End If
        If Check_showCoords.Checked Then
            If CoordrelToolStripMenuItem.Checked Then
                Label_coord.Text = pointSub(e.Location, _VbaseMid).ToString
            Else
                Label_coord.Text = pointAdd(e.Location, _VRect.Location).ToString
            End If
        End If


        If Not _isMD Then Exit Sub
        Select Case e.Button
            Case Windows.Forms.MouseButtons.Left

                Select Case _iTool
                    Case EditorTool.iCustomPen
                        DN_custom(e.Location)
                    Case EditorTool.iMarker
                        DN_marker(e.Location)
                    Case EditorTool.iEraser
                        Erase_Next(e.Location)
                    Case EditorTool.iCalligraphy
                        DN_cally(e.Location)
                End Select
                _downPT = e.Location
        End Select
    End Sub

    Private Sub my_canvas_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles my_canvas.MouseUp
        '   If onn Then Exit Sub
        _isMD = False
        If Not _isOpen Then Exit Sub
        Select Case e.Button

            Case Windows.Forms.MouseButtons.Left

                Select Case _iTool
                    Case EditorTool.iColorPick
                        If _picColor Then
                            Dim onep As New Bitmap(1, 1)
                            Dim _clipfx As Graphics = Graphics.FromImage(onep)


                            Dim scri As Integer = Int(Me.Location.X / ScreenBounds.Width)
                            _clipfx.CopyFromScreen(SystemInformation.VirtualScreen.X + ScreenBounds.Width * scri + e.Location.X,
                                       SystemInformation.VirtualScreen.Y + e.Location.Y,
                                          0, 0, New Size(1, 1))
                            MyMarkerColor = onep.GetPixel(0, 0)
                            Panel_SelCol.BackColor = MyMarkerColor
                            _clipfx.Dispose()
                            onep.Dispose()
                        End If
                    Case EditorTool.iMarker, EditorTool.iEraser, EditorTool.iCalligraphy
                        If chk_rainbow.Checked Then Panel_SelCol.BackColor = MyMarkerColor
                        AddImageStack()
                        View_Draw(False)
                    Case EditorTool.iCustomPen
                        AddImageStack()
                        View_Draw(False)
                End Select

            Case Windows.Forms.MouseButtons.Middle
                Dim newP As Point
                If _downPT = e.Location Then
                    'click event - centerimage.
                    newP = New Point(e.X - _VbaseMid.X, e.Y - _VbaseMid.Y)
                Else
                    ' drag event - pan image.
                    newP = New Point(-e.Location.X + _downPT.X, -e.Location.Y + _downPT.Y)
                End If
                If CheckBox_lockXscroll.Checked Then newP.X = 0
                If CheckBox_lockYscroll.Checked Then newP.Y = 0
                View_Pan(newP.X, newP.Y)
                View_Draw(True)

        End Select
    End Sub

#End Region

#Region "' et_function '"
    'editor tools realted functions

    Private Sub _SetTransform(ByVal eLoc As Point)
        _ipoints += 1
        _point_argsT(_ipoints) = eLoc
        _point_argsx(_ipoints).X = _VRect.X + _point_argsT(_ipoints).X
        _point_argsx(_ipoints).Y = _VRect.Y + _point_argsT(_ipoints).Y
    End Sub

    Private Sub et_iLine(ByVal eLocation As Point)
        If _ipoints = 0 Then
            _SetTransform(eLocation)
            _ipoints = -1
            _ifx.DrawLine(_col_shape_pen, _point_argsx(0), _point_argsx(1))
            _ifx.FillEllipse(_col_marker_bruN,
                       _point_argsx(0).X - _sfac,
                       _point_argsx(0).Y - _sfac,
                        _shape_size, _shape_size)
            _ifx.FillEllipse(_col_marker_bruN,
                            _point_argsx(1).X - _sfac,
                            _point_argsx(1).Y - _sfac,
                             _shape_size, _shape_size)
            AddImageStack()
            View_Draw(False)
        Else
            _SetTransform(eLocation)
            drawMarkerPoint()
        End If
    End Sub
    Private Sub et_iRectangle(ByVal eLocation As Point)
        If _ipoints = 0 Then
            _SetTransform(eLocation)
            _ipoints = -1
            Dim _clipRect As Rectangle = _GetClipRect()
            If _clipRect.Width <= 0 Or _clipRect.Height <= 0 Then
                If _do_sounds Then My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Exclamation)
                View_Draw(False)
                Exit Sub
            End If

            If chk_fillOn.Checked Then
                _ifx.FillRectangle(_col_marker_bruN, _clipRect)
            Else
                _ifx.DrawRectangle(_col_shape_pen, _clipRect)
            End If
            AddImageStack()
            View_Draw(False)
        Else
            _SetTransform(eLocation)
            drawMarkerPoint()
        End If
    End Sub
    Private Sub et_iEllipse(ByVal eLocation As Point)
        If _ipoints = 0 Then
            _SetTransform(eLocation)
            _ipoints = -1
            Dim _clipRect As Rectangle = _GetClipRect()
            If _clipRect.Width <= 0 Or _clipRect.Height <= 0 Then
                If _do_sounds Then My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Exclamation)
                View_Draw(False)
                Exit Sub
            End If

            If chk_fillOn.Checked Then
                _ifx.FillEllipse(_col_marker_bruN, _clipRect)
            Else
                _ifx.DrawEllipse(_col_shape_pen, _clipRect)
            End If
            AddImageStack()
            View_Draw(False)
        Else
            _SetTransform(eLocation)
            drawMarkerPoint()
        End If
    End Sub
    Private Sub et_iGraph(ByVal eLocation As Point)
        If _ipoints = 0 Then
            _SetTransform(eLocation)
            _ipoints = -1
            Dim _delta As New PointF(_point_argsx(1).X - _point_argsx(0).X, _point_argsx(1).Y - _point_argsx(0).Y)
            If _delta.X < 0 Then
                If _delta.Y < 0 Then
                    _ifx.DrawLine(_col_shape_pen, _point_argsx(0).X, _point_argsx(0).Y,
                                 _point_argsx(0).X, _point_argsx(1).Y)

                    _ifx.DrawLine(_col_shape_pen, _point_argsx(0).X, _point_argsx(0).Y,
                                 _point_argsx(1).X, _point_argsx(0).Y)
                Else
                    _ifx.DrawLine(_col_shape_pen, _point_argsx(0).X, _point_argsx(0).Y,
                                 _point_argsx(0).X, _point_argsx(1).Y)

                    _ifx.DrawLine(_col_shape_pen, _point_argsx(0).X, _point_argsx(0).Y,
                                 _point_argsx(1).X, _point_argsx(0).Y)
                End If
            Else
                If _delta.Y < 0 Then
                    _ifx.DrawLine(_col_shape_pen, _point_argsx(0).X, _point_argsx(0).Y,
                                 _point_argsx(0).X, _point_argsx(1).Y)

                    _ifx.DrawLine(_col_shape_pen, _point_argsx(0).X, _point_argsx(0).Y,
                                 _point_argsx(1).X, _point_argsx(0).Y)
                Else
                    _ifx.DrawLine(_col_shape_pen, _point_argsx(0).X, _point_argsx(0).Y,
                                 _point_argsx(0).X, _point_argsx(1).Y)

                    _ifx.DrawLine(_col_shape_pen, _point_argsx(0).X, _point_argsx(0).Y,
                                 _point_argsx(1).X, _point_argsx(0).Y)
                End If
            End If
            _ifx.FillRectangle(_col_marker_bruN,
                       _point_argsx(0).X - _sfac,
                       _point_argsx(0).Y - _sfac,
                        _shape_size, _shape_size)
            AddImageStack()
            View_Draw(False)
        Else
            _SetTransform(eLocation)
            drawMarkerPoint()
        End If
    End Sub
    Private Sub et_iCircleDia(ByVal eLocation As Point)
        If _ipoints = 0 Then
            _SetTransform(eLocation)
            _ipoints = -1
            Dim _delta As New PointF(_point_argsx(1).X - _point_argsx(0).X, _point_argsx(1).Y - _point_argsx(0).Y)
            Dim _mid As New PointF((_point_argsx(1).X + _point_argsx(0).X) / 2, (_point_argsx(1).Y + _point_argsx(0).Y) / 2)
            Dim _dia As Single = ((_delta.X ^ 2 + _delta.Y ^ 2) ^ 0.5)
            _mid.X -= _dia / 2
            _mid.Y -= _dia / 2
            If chk_fillOn.Checked Then
                _ifx.FillEllipse(_col_marker_bruN, _mid.X, _mid.Y, _dia, _dia)
            Else
                _ifx.DrawEllipse(_col_shape_pen, _mid.X, _mid.Y, _dia, _dia)
            End If
            AddImageStack()
            View_Draw(False)
        Else
            _SetTransform(eLocation)
            drawMarkerPoint()
        End If
    End Sub
    Private Sub et_iTable(ByVal eLocation As Point)
        If _ipoints = 0 Then
            _SetTransform(eLocation)
            _ipoints = -1
            Dim _delta As New PointF(_point_argsx(1).X - _point_argsx(0).X, _point_argsx(1).Y - _point_argsx(0).Y)
            Dim Po As PointF
            Dim PH As PointF
            Dim PV As PointF
            If _delta.X < 0 Then
                If _delta.Y < 0 Then
                    Po = New PointF(_point_argsx(1).X, _point_argsx(1).Y)
                    PH = New PointF(_point_argsx(0).X, _point_argsx(1).Y)
                    PV = New PointF(_point_argsx(1).X, _point_argsx(0).Y)
                Else
                    Po = New PointF(_point_argsx(1).X, _point_argsx(1).Y - _delta.Y)
                    PH = New PointF(_point_argsx(0).X, _point_argsx(1).Y - _delta.Y)
                    PV = New PointF(_point_argsx(1).X, _point_argsx(0).Y + _delta.Y)
                End If
            Else
                If _delta.Y < 0 Then
                    Po = New PointF(_point_argsx(0).X, _point_argsx(0).Y + _delta.Y)
                    PH = New PointF(_point_argsx(1).X, _point_argsx(0).Y + _delta.Y)
                    PV = New PointF(_point_argsx(0).X, _point_argsx(1).Y - _delta.Y)
                Else
                    Po = New PointF(_point_argsx(0).X, _point_argsx(0).Y)
                    PH = New PointF(_point_argsx(1).X, _point_argsx(0).Y)
                    PV = New PointF(_point_argsx(0).X, _point_argsx(1).Y)
                End If
            End If

            Dim nrow As Integer = 0
            Dim ncol As Integer = 0
            Try
                nrow = Convert.ToInt32(tstb_rows.Text)
                ncol = Convert.ToInt32(tstb_cols.Text)
            Catch ex As Exception
                MsgBox("Please select valid number of rows and cols (right click on Table Tool)", vbCritical)
                Exit Sub
            End Try

            Dim rowH As Single = Math.Abs(_delta.Y) / nrow
            Dim colW As Single = Math.Abs(_delta.X) / ncol
            _ifx.DrawLine(_col_shape_pen, Po, PH)
            _ifx.DrawLine(_col_shape_pen, Po, PV)
            For rowi = 1 To nrow
                _ifx.DrawLine(_col_shape_pen,
                          Po.X, Po.Y + rowH * rowi,
                          PH.X, PH.Y + rowH * rowi)
            Next
            For colj = 1 To ncol
                _ifx.DrawLine(_col_shape_pen,
                          Po.X + colW * colj, Po.Y,
                          PV.X + colW * colj, PV.Y)
            Next

            _ifx.FillEllipse(_col_marker_bruN,
                   Po.X - _sfac,
                   Po.Y - _sfac,
                    _shape_size, _shape_size)
            _ifx.FillEllipse(_col_marker_bruN,
                       PH.X - _sfac,
                       PH.Y - _sfac,
                        _shape_size, _shape_size)
            _ifx.FillEllipse(_col_marker_bruN,
                       PV.X - _sfac,
                      PV.Y - _sfac,
                        _shape_size, _shape_size)
            _ifx.FillEllipse(_col_marker_bruN,
                       Po.X + Math.Abs(_delta.X) - _sfac,
                       Po.Y + Math.Abs(_delta.Y) - _sfac,
                        _shape_size, _shape_size)
            AddImageStack()
            View_Draw(False)
        Else
            _SetTransform(eLocation)
            drawMarkerPoint()
        End If
    End Sub


    Private Sub et_iPath(ByVal eLocation As Point)
        If _ipoints >= 0 Then
            _SetTransform(eLocation)
            _ifx.DrawLine(_col_shape_pen, _point_argsx(0), _point_argsx(1))
            _ifx.FillEllipse(_col_marker_bruN,
                       _point_argsx(0).X - _sfac,
                       _point_argsx(0).Y - _sfac,
                        _shape_size, _shape_size)
            AddImageStack()
            View_Draw(False)
            _point_argsx(0) = _point_argsx(1)
            _ipoints = 0
        Else
            _SetTransform(eLocation)
            drawMarkerPoint()
        End If
    End Sub
    Private Sub et_iAxisMarker(ByVal eLocation As Point)
        _axis_points_pts.Add(eLocation)
        _axis_points_pens.Add(New Pen(_col_marker_bruN))
        View_Draw(False)
    End Sub

    Private Sub etHelper_iImageCopy(ByVal _clipRect As Rectangle)
        If _clipRect.Width <= 0 Or _clipRect.Height <= 0 Then
            If _do_sounds Then My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Exclamation)
            View_Draw(False)
            Exit Sub
        End If

        Dim _destRect As New Rectangle(0, 0, _clipRect.Width, _clipRect.Height)
        Dim _clipImg As New Bitmap(_clipRect.Width, _clipRect.Height, _pixFormat)
        Dim _clipfx As Graphics = Graphics.FromImage(_clipImg)
        _clipfx.DrawImage(_img,
                           _destRect,
                          _clipRect, GraphicsUnit.Pixel)
        My.Computer.Clipboard.SetImage(_clipImg)
        _clipfx.Dispose()
    End Sub
    Private Sub et_iImageCopy(ByVal eLocation As Point)
        If _ipoints = 0 Then
            _SetTransform(eLocation)
            _ipoints = -1
            _vfx.DrawEllipse(grid_penX, eLocation.X - 1, eLocation.Y - 1, 2, 2)
            _vfx.DrawEllipse(grid_penY, eLocation.X - 2, eLocation.Y - 2, 4, 4)
            etHelper_iImageCopy(_GetClipRect())
        Else
            _SetTransform(eLocation)
            drawMarkerPoint()
        End If
    End Sub

    Private Sub etHelper_iImageClear(ByVal _clipRect As Rectangle)
        If _clipRect.Width <= 0 Or _clipRect.Height <= 0 Then
            If _do_sounds Then My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Exclamation)
            View_Draw(False)
            Exit Sub
        End If
        _ifx.FillRectangle(_xbru, _clipRect)
        View_Draw(True)
    End Sub
    Private Sub etHelper_iImageCut(ByVal _clipRect As Rectangle)
        If _clipRect.Width <= 0 Or _clipRect.Height <= 0 Then
            If _do_sounds Then My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Exclamation)
            View_Draw(False)
            Exit Sub
        End If

        Dim _destRect As New Rectangle(0, 0, _clipRect.Width, _clipRect.Height)
        Dim _clipImg As New Bitmap(_clipRect.Width, _clipRect.Height, _pixFormat)
        Dim _clipfx As Graphics = Graphics.FromImage(_clipImg)
        _clipfx.DrawImage(_img,
                           _destRect,
                          _clipRect, GraphicsUnit.Pixel)
        My.Computer.Clipboard.SetImage(_clipImg)
        _ifx.FillRectangle(_xbru, _clipRect)
        View_Draw(True)
        _clipfx.Dispose()
    End Sub
    Private Sub et_iImageCut(ByVal eLocation As Point)
        If _ipoints = 0 Then
            _SetTransform(eLocation)
            _ipoints = -1
            _vfx.DrawEllipse(grid_penX, eLocation.X - 1, eLocation.Y - 1, 2, 2)
            _vfx.DrawEllipse(grid_penY, eLocation.X - 2, eLocation.Y - 2, 4, 4)
            etHelper_iImageCut(_GetClipRect())
        Else
            _SetTransform(eLocation)
            drawMarkerPoint()
        End If
    End Sub

    Private Sub et_iImagePaste(ByVal eLocation As Point)
        _SetTransform(eLocation)
        _ipoints = -1
        If My.Computer.Clipboard.ContainsImage Then
            _ifx.DrawImage(My.Computer.Clipboard.GetImage, _point_argsx(0))
            AddImageStack()
            View_Draw(False)
        ElseIf My.Computer.Clipboard.ContainsFileDropList Then
            Try
                Dim res As String = My.Computer.Clipboard.GetFileDropList(0)
                Dim dropI As Bitmap = GetImageFromFile(res, 0, 0)
                _ifx.DrawImage(dropI, _point_argsx(0))
                AddImageStack()
                dropI.Dispose()
                _add2Recent(res)
                View_Draw(False)
            Catch ex As Exception
                If _do_sounds Then My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Hand)
            End Try
        Else
            If _do_sounds Then My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Exclamation)
        End If

    End Sub
    Private Sub et_iImagePasteR(ByVal eLocation As Point)
        If _ipoints = 0 Then
            _SetTransform(eLocation)
            _ipoints = -1
            _vfx.DrawEllipse(grid_penX, eLocation.X - 1, eLocation.Y - 1, 2, 2)
            _vfx.DrawEllipse(grid_penY, eLocation.X - 2, eLocation.Y - 2, 4, 4)
            Dim _clipRect As Rectangle = _GetClipRect()
            If _clipRect.Width <= 0 Or _clipRect.Height <= 0 Then
                If _do_sounds Then My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Exclamation)
                View_Draw(False)
                Exit Sub
            End If

            If My.Computer.Clipboard.ContainsImage Then
                Dim _clipImg As Image = My.Computer.Clipboard.GetImage
                Dim _clipSrc As New Rectangle(0, 0, _clipImg.Width, _clipImg.Height)
                _ifx.DrawImage(_clipImg,
                                    _clipRect,
                                   _clipSrc, GraphicsUnit.Pixel)
                AddImageStack()
                View_Draw(False)
            ElseIf My.Computer.Clipboard.ContainsFileDropList Then
                Try
                    Dim res As String = My.Computer.Clipboard.GetFileDropList(0)
                    Dim dropI As Bitmap = GetImageFromFile(res, 0, 0)
                    Dim _clipSrc As New Rectangle(0, 0, dropI.Width, dropI.Height)
                    _ifx.DrawImage(dropI, _clipRect,
                                   _clipSrc, GraphicsUnit.Pixel)
                    AddImageStack()
                    dropI.Dispose()
                    _add2Recent(res)
                    View_Draw(False)
                Catch ex As Exception
                    If _do_sounds Then My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Hand)
                End Try
            Else
                If _do_sounds Then My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Exclamation)
            End If
        Else
            _SetTransform(eLocation)
            drawMarkerPoint()
        End If
    End Sub
    Private Sub et_iScreenCopy(ByVal eLocation As Point)
        If _ipoints = 0 Then
            _SetTransform(eLocation)
            _ipoints = -1
            _vfx.DrawEllipse(grid_penX, eLocation.X - 1, eLocation.Y - 1, 2, 2)
            _vfx.DrawEllipse(grid_penY, eLocation.X - 2, eLocation.Y - 2, 4, 4)
            Dim _clipRect As Rectangle = _GetClipRect()
            If _clipRect.Width <= 0 Or _clipRect.Height <= 0 Then
                If _do_sounds Then My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Exclamation)
                View_Draw(False)
                Exit Sub
            End If


            '------------------------------------------------------------------------
            _prevDialogstate = Panel_Pallete.Visible
            Pallet_CloseDialog()
            cms_canvasctrl.Close()
            Panel_Anchor.Visible = False

            Dim _destRect As New Rectangle(0, 0, _clipRect.Width, _clipRect.Height)
            Dim _clipImg As New Bitmap(_clipRect.Width, _clipRect.Height, _pixFormat)
            Dim _clipfx As Graphics = Graphics.FromImage(_clipImg)
            Dim scri As Integer = Int(Me.Location.X / ScreenBounds.Width)
            _clipfx.CopyFromScreen(SystemInformation.VirtualScreen.X + ScreenBounds.Width * scri + _clipRect.X - _VRect.X,
                       SystemInformation.VirtualScreen.Y + _clipRect.Y - _VRect.Y,
                          0, 0, SystemInformation.VirtualScreen.Size)

            My.Computer.Clipboard.SetImage(_clipImg)

            If SaveToFileToolStripMenuItem.Checked Then
                If My.Computer.FileSystem.DirectoryExists(setpage.Label12.Text) Then
                    Dim uname As String = setpage.Label12.Text + "\" + _prevPtext + GetUniqueName(".png")
                    _clipImg.Save(uname, Drawing.Imaging.ImageFormat.Png)
                    _add2Recent(uname)
                    StartAnimatate()
                Else
                    MsgBox("Quicksave directory does not exist!!" + Environment.NewLine + setpage.Label12.Text, vbCritical)
                    Exit Sub
                End If
            End If

            _clipImg.Dispose()
            If _prevDialogstate Then Pallet_showDialog(_prevDialogPoint)
            Panel_Anchor.Visible = True
            '------------------------------------------------------------------------
        Else
            _SetTransform(eLocation)
            drawMarkerPoint()
        End If
    End Sub

    Private Sub et_iDateTime(ByVal eLocation As Point)
        _SetTransform(eLocation)
        _ipoints = -1
        Dim _dtN As DateTime = DateTime.Now
        Dim _dTS As String = ""

        If DateToolStripMenuItem.Checked Then
            If setpage.Check_sDate.Checked Then
                _dTS += _dtN.ToShortDateString
            Else
                _dTS += _dtN.ToLongDateString
            End If
        End If

        If TimeToolStripMenuItem.Checked Then
            If setpage.Check_sTime.Checked Then
                _dTS += TSTB_sep.Text + _dtN.ToShortTimeString
            Else
                _dTS += TSTB_sep.Text + _dtN.ToLongTimeString
            End If
        End If
        _ifx.DrawString(_dTS, TextTootl.Font, _col_marker_bruN, _point_argsx(0))

        AddImageStack()
        View_Draw(False)

    End Sub
    Private Sub et_iText(ByVal eLocation As Point)
        _SetTransform(eLocation)
        _ipoints = -1

        Dim _dTS As String = ""

        If FromClipboardToolStripMenuItem.Checked Then
            If My.Computer.Clipboard.ContainsText Then
                _dTS = My.Computer.Clipboard.GetText()
            End If
        Else
            _dTS = TextTootl.Text
        End If

        If _dTS = "" Then Exit Sub
        _ifx.DrawString(_dTS, TextTootl.Font, _col_marker_bruN, _point_argsx(0))

        AddImageStack()
        View_Draw(False)

    End Sub

    Private Sub et_iSelectR(ByVal eLocation As Point)
        If _ipoints = 0 Then
            _SetTransform(eLocation)
            _ipoints = -1
            _vfx.DrawEllipse(grid_penX, eLocation.X - 1, eLocation.Y - 1, 2, 2)
            _vfx.DrawEllipse(grid_penY, eLocation.X - 2, eLocation.Y - 2, 4, 4)

            Dim _clipRect As Rectangle = _GetClipRect()
            If _clipRect.Width <= 0 Or _clipRect.Height <= 0 Then
                If _do_sounds Then My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Exclamation)
                View_Draw(False)
                Exit Sub
            End If
            _selRect = _clipRect
            _selecting = True
            View_Draw(False)
        Else
            ' _selecting = False
            _SetTransform(eLocation)
            drawMarkerPoint()

        End If
    End Sub

    Private Sub et_iSample_Function(ByVal eLocation As Point, ByVal _points_needed As Integer)
        ' template function
        If _ipoints >= _points_needed - 2 Then
            _SetTransform(eLocation)
            _ipoints = -1
            '===========================================
            'use _point_argsx(i) points to draw something
            '===========================================
            AddImageStack()
            View_Draw(False)
        Else
            _SetTransform(eLocation)
            drawMarkerPoint()
        End If
    End Sub

    Private Function _GetClipRect() As Rectangle
        Dim _delta As New PointF(_point_argsx(1).X - _point_argsx(0).X, _point_argsx(1).Y - _point_argsx(0).Y)
        If _delta.X < 0 Then
            If _delta.Y < 0 Then
                _GetClipRect = New Rectangle(_point_argsx(1).X, _point_argsx(1).Y, -_delta.X, -_delta.Y)
            Else
                _GetClipRect = New Rectangle(_point_argsx(1).X, _point_argsx(1).Y - _delta.Y, -_delta.X, _delta.Y)
            End If
        Else
            If _delta.Y < 0 Then
                _GetClipRect = New Rectangle(_point_argsx(0).X, _point_argsx(0).Y + _delta.Y, _delta.X, -_delta.Y)
            Else

                _GetClipRect = New Rectangle(_point_argsx(0).X, _point_argsx(0).Y, _delta.X, _delta.Y)
            End If
        End If
    End Function

#End Region

#Region "' ToolBox and Anchor '"

    Private Sub Pallet_showDialog(ByVal start_loc As Point)
        If Check_fixedToolbox.Checked Then
            start_loc = _prevDialogPoint
        End If
        Panel_Pallete.Location = New Point(start_loc.X + Panel_Pallete.Tag.X,
                                   start_loc.Y + Panel_Pallete.Tag.Y)
        If Panel_tools.Dock = DockStyle.None Then
            Panel_tools.Location = New Point(start_loc.X + Panel_tools.Tag.X,
                                               start_loc.Y + Panel_tools.Tag.Y)

        End If
        Panel_Pallete.Visible = True
        Panel_tools.Visible = _isTBVis
        _prevDialogPoint = start_loc
    End Sub
    Private Sub Pallet_CloseDialog()
        Panel_Pallete.Visible = False
        Panel_tools.Visible = False
        If _isOpen Then View_Draw(False)
        t_kp.Focus()
    End Sub

    Private Sub lab_XDis_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lab_markerDis.MouseClick, lab_EraserDis.MouseClick, lab_shapeDis.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Left Then
            _isPltExand = Not _isPltExand
            If _isPltExand Then
                Panel_Pallete.Width = 288
            Else
                Panel_Pallete.Width = 176
                _prevME = False
            End If
        ElseIf e.Button = Windows.Forms.MouseButtons.Middle Then
            _isTBVis = Not _isTBVis
            Panel_tools.Visible = _isTBVis
            If Not _isTBVis Then _prevME = False
        End If
    End Sub
    Private Sub ColorPalleteMove_MD(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel_Pallete.MouseDown,
                                                                                           lab_markerDis.MouseDown, lab_shapeDis.MouseDown, lab_EraserDis.MouseDown,
                                                                                           lab_mwid.MouseDown, lab_swid.MouseDown, lab_ewid.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            _panel_md = True
            _panel_mp = e.Location
        End If
    End Sub
    Private Sub ColorPalleteMove_MU(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel_Pallete.MouseUp,
                                                                                                lab_shapeDis.MouseUp, lab_markerDis.MouseUp, lab_EraserDis.MouseUp,
                                                                                                lab_mwid.MouseUp, lab_swid.MouseUp, lab_ewid.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Left Then
            If Not _panel_md Then Exit Sub
            Dim diff_vect As Point = (_panel_mp - e.Location)
            If diff_vect.X <> 0 Or diff_vect.Y <> 0 Then

                If Object.Equals(Panel_Pallete, sender) Then
                    sender.Location = sender.Location - diff_vect
                    sender.Tag = sender.Tag - diff_vect
                Else
                    sender.Tag.Location = sender.Tag.Location - diff_vect
                    sender.Tag.Tag = sender.Tag.Tag - diff_vect
                End If
                If _isOpen Then View_Draw(True)
            End If
        End If
        _panel_md = False
    End Sub

    Private Sub toolPanel_MD(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel_tools.MouseDown
        If e.Button = MouseButtons.Left Then
            If Panel_tools.Dock <> DockStyle.None Then Exit Sub
            _panel_md = True
            _panel_mp = e.Location
        End If
    End Sub
    Private Sub toolPanel_MU(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel_tools.MouseUp
        If Not _panel_md Then Exit Sub
        sender.Location = sender.Location - (_panel_mp - e.Location)
        sender.Tag = sender.Tag - (_panel_mp - e.Location)
        _panel_md = False
        If _isOpen Then View_Draw(True)
    End Sub

    ' color pallet selection
    Private Sub PanelCol_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles xcp0.MouseClick, xcp1.MouseClick, xcp2.MouseClick,
                                                                                        xcp3.MouseClick, xcp4.MouseClick, xcp5.MouseClick, xcp6.MouseClick, xcp7.MouseClick, xcp8.MouseClick,
                                                                                        xcp9.MouseClick, xcp10.MouseClick, xcp11.MouseClick, xcp12.MouseClick, xcp13.MouseClick, xcp14.MouseClick,
                                                                                        xcp15.MouseClick, xcp16.MouseClick, xcp17.MouseClick, pan_gridpenx.MouseClick, pan_gridpeny.MouseClick, pan_gridpen.MouseClick
        Select Case e.Button

            Case Windows.Forms.MouseButtons.Left

                MyMarkerColor = sender.BackColor
                Panel_SelCol.BackColor = MyMarkerColor

            Case Windows.Forms.MouseButtons.Right

                PalleteCD.Color = sender.BackColor
                If PalleteCD.ShowDialog = Windows.Forms.DialogResult.OK Then
                    If PalleteCD.Color <> Me.TransparencyKey Then
                        sender.BackColor = PalleteCD.Color
                        _SETTING_COLORS.CRUD_Update(sender.Tag, PalleteCD.Color, False)
                        grid_penX = New Pen(pan_gridpenx.BackColor, 1)
                        grid_penY = New Pen(pan_gridpeny.BackColor, 1)
                        grid_pen = New Pen(pan_gridpen.BackColor, 1)
                        grid_brush = New SolidBrush(pan_gridpen.BackColor)
                    Else
                        MsgBox("Selected Color is the Transperancy Key, Cannot select it as usable color", vbExclamation)
                    End If
                End If

            Case Windows.Forms.MouseButtons.Middle

                If Panel_SelCol.BackColor <> Me.TransparencyKey Then
                    sender.BackColor = Panel_SelCol.BackColor
                    _SETTING_COLORS.CRUD_Update(sender.Tag, Panel_SelCol.BackColor, False)
                    grid_penX = New Pen(pan_gridpenx.BackColor, 1)
                    grid_penY = New Pen(pan_gridpeny.BackColor, 1)
                    grid_pen = New Pen(pan_gridpen.BackColor, 1)
                    grid_brush = New SolidBrush(pan_gridpen.BackColor)
                Else
                    MsgBox("Selected Color is the Transperancy Key, Cannot select it as usable color", vbExclamation)
                End If

        End Select
    End Sub

    'radio-buttons for editor tools
    Private Sub rb_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_pointer.CheckedChanged,
                                                                                               rb_marker.CheckedChanged,
                                                                                               rb_ellipse.CheckedChanged,
        rb_table.CheckedChanged,
        rb_path.CheckedChanged,
        rb_axismarker.CheckedChanged,
        rb_paste.CheckedChanged,
        rb_pasteR.CheckedChanged,
        rb_screencopy.CheckedChanged,
        rb_eraser.CheckedChanged,
        rb_caligraphy.CheckedChanged,
        rb_colorpick.CheckedChanged,
         rb_text.CheckedChanged,
         rb_SelectR.CheckedChanged




        If sender.Checked Then
            MyEditorTool = sender.Tag
        Else
            _lastTool = sender
        End If

        _ipoints = -1
        _selecting = False
    End Sub
    Dim _lastTool As RadioButton
    ' track-bars for sizes
    Private Sub track_mwid_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles track_mwid.Scroll
        MyMarkerSize = track_mwid.Value
    End Sub
    Private Sub track_swid_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles track_swid.Scroll
        MyShapeSize = track_swid.Value
    End Sub
    Private Sub track_eraser_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles track_eraser.Scroll
        MyEraserSize = track_eraser.Value
    End Sub
    Private Sub track_swid_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles track_swid.ValueChanged
        lab_swid.Text = track_swid.Value.ToString
    End Sub
    Private Sub track_eraser_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles track_eraser.ValueChanged
        lab_ewid.Text = track_eraser.Value.ToString
    End Sub
    Private Sub track_mwid_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles track_mwid.ValueChanged
        lab_mwid.Text = track_mwid.Value.ToString
    End Sub
    Private Sub _set_scrolls(ByRef sender As TrackBar,
                             ByVal ectrl As Boolean, ByVal eshft As Boolean,
                             ByVal multipier As Integer)

        Dim newVal As Integer
        If ectrl Then
            newVal = sender.Value + 25 * multipier
        Else
            If eshft Then
                newVal = sender.Value + 5 * multipier
            Else
                newVal = sender.Value + 1 * multipier
            End If
        End If
        If newVal > sender.Maximum Then
            newVal = sender.Maximum
        Else
            If newVal < sender.Minimum Then newVal = sender.Minimum
        End If


        sender.Value = newVal
        Select Case sender.Tag
            Case 0
                track_mwid_Scroll(Nothing, Nothing)
            Case 1
                track_swid_Scroll(Nothing, Nothing)
            Case 2
                track_eraser_Scroll(Nothing, Nothing)
        End Select

    End Sub

    ' Axis-Related
    Private Sub ClearToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearToolStripMenuItem.Click
        If Not _isOpen Then Exit Sub

        If _isFileOpen Then
            drop_file(_FileOpened)
            View_Draw(True)
        Else
            _ifx.Clear(Me.TransparencyKey)
            AddImageStack()
            View_Draw(True)
            StartAnimatate()
        End If

    End Sub
    Private Sub chk_showScale_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_showScale.CheckedChanged, Check_dropPP.CheckedChanged
        If _isOpen Then View_Draw(False)
    End Sub
    Private Function Rad2Deg(ByVal radAngle As Single, Optional ByVal round_upto As Byte = 2) As Single
        Return -Math.Round((radAngle * 180 / Math.PI), round_upto).ToString
    End Function
    Private Sub nud_rotXangle_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles nud_rotXangle.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                nud_rotXangle_Validated(Nothing, Nothing)
            Case Keys.Up
                nud_rotXangle.Text = Rad2Deg(_rotScale + 0.01)
                nud_rotXangle_Validated(Nothing, Nothing)
            Case Keys.Down
                nud_rotXangle.Text = Rad2Deg(_rotScale - 0.01)
                nud_rotXangle_Validated(Nothing, Nothing)
        End Select
    End Sub
    Private Sub nud_rotXangle_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles nud_rotXangle.Validated
        Try
            Dim n1 As Single = -(Convert.ToSingle(nud_rotXangle.Text) * Math.PI / 180)
            If n1 <> _rotScale Then
                View_AxisRot(n1, True)
            End If

        Catch ex As Exception
            ' nud_rotXangle.Text = Rad2Deg(_rotScale)
        End Try
        nud_rotXangle.Text = Rad2Deg(_rotScale)
    End Sub
    Private Sub B_clearaxisPots_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_clearaxisPots.Click
        _axis_points_pts.Clear()
        _axis_points_pens.Clear()
        If _isOpen Then View_Draw(False)
    End Sub

    'docking
    Private Sub Combo_dockSty_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Combo_dockStc.SelectedIndexChanged
        If Combo_dockStc.SelectedIndex = -1 Then Exit Sub
        Panel_tools.Dock = Combo_dockStc.SelectedIndex

        If Combo_dockStc.SelectedIndex = 0 Then
            Panel_tools.Height = 98
            Panel_tools.Location = New Point(_prevDialogPoint.X + Panel_tools.Tag.X,
                                              _prevDialogPoint.Y + Panel_tools.Tag.Y)
        Else
            Panel_tools.Height = 32
        End If

        If _isOpen Then View_Draw(False)
        cms_docker.Close()
    End Sub

    ' Selected Color
    Private Sub Panel_SelCol_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel_SelCol.MouseClick
        Select Case e.Button
            Case Windows.Forms.MouseButtons.Left
                hsl_col = RGB_HSL(sender.BackColor)

                Dim hsl_shift_degree As Integer = 0
                Try
                    hsl_shift_degree = Convert.ToInt32(TSTB_hueDelta.Text)
                Catch ex As Exception
                    MsgBox("Please set proper value for Hue Delta! (right-click to see more)", vbCritical)
                    hsl_shift_degree = 0
                End Try

                hsl_col(0) += (0.002777777778 * hsl_shift_degree) Mod 1        '1.0 degree
                'hsl_col(0) += (0.001388888889) Mod 1        ' 0.5 degree
                sender.BackColor = HSL_RGB(hsl_col(0), hsl_col(1), hsl_col(2))
                MyMarkerColor = sender.BackColor
                ' sender.BackColor = PalleteCD.Color
            Case Windows.Forms.MouseButtons.Middle
                ClearToolStripMenuItem_Click(Nothing, Nothing)
        End Select
    End Sub
    Private Sub SelectColorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectColorToolStripMenuItem.Click
        PalleteCD.Color = Panel_SelCol.BackColor
        If PalleteCD.ShowDialog = Windows.Forms.DialogResult.OK Then
            If PalleteCD.Color <> Me.TransparencyKey Then
                MyMarkerColor = PalleteCD.Color
                Panel_SelCol.BackColor = PalleteCD.Color
            Else
                MsgBox("Selected Color is the Transperancy Key, Cannot select it as usable color", vbExclamation)
            End If
        End If
    End Sub
    Private Sub RandomColorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RandomColorToolStripMenuItem.Click
        Dim rndx As New Random
        Dim x As Byte() = {0, 0, 0}

        rndx.NextBytes(x)
        Dim randomCol As Color = Color.FromArgb(x(0), x(1), x(2))
        While randomCol = Me.TransparencyKey
            rndx.NextBytes(x)
            randomCol = Color.FromArgb(x(0), x(1), x(2))
        End While
        Panel_SelCol.BackColor = randomCol
        MyMarkerColor = randomCol

    End Sub
    Private Sub CopyAsRGBToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyAsRGBToolStripMenuItem.Click
        My.Computer.Clipboard.SetText(Panel_SelCol.BackColor.R.ToString + "," +
                                              Panel_SelCol.BackColor.G.ToString + "," +
                                              Panel_SelCol.BackColor.B.ToString)
        If _do_sounds Then My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
    End Sub
    Private Sub PasteAsRGBToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasteAsRGBToolStripMenuItem.Click
        If My.Computer.Clipboard.ContainsText Then
            Try
                Dim rgbs As String() = My.Computer.Clipboard.GetText.Split(",")
                Panel_SelCol.BackColor = Color.FromArgb(Convert.ToByte(rgbs(0)), Convert.ToByte(rgbs(1)), Convert.ToByte(rgbs(2)))
                MyMarkerColor = Panel_SelCol.BackColor
                If _do_sounds Then My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
            Catch ex As Exception
                If _do_sounds Then My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Hand)
            End Try
        End If
    End Sub
    Private Sub FillCanvasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FillCanvasToolStripMenuItem.Click
        If Not _isOpen Then Exit Sub
        _ifx.Clear(Panel_SelCol.BackColor)
        AddImageStack()
        View_Draw(True)
    End Sub

    'tool strips
    Private Sub cms_canvasctrl_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cms_canvasctrl.Opening
        ImportClipboardToolStripMenuItem.Enabled = _modeBig
        CloseImageToolStripMenuItem.Enabled = _isFileOpen
    End Sub

    Dim _isFileOpen As Boolean = False
    Dim _FileOpened As String = ""
    Private Sub _closeImage()
        _FileOpened = ""
        _isFileOpen = False
    End Sub
    Public Function drop_arg(ByVal res As String) As Boolean
        drop_arg = False
        Try
            Dim dropI As Bitmap = GetImageFromFile(res, 0, 0)
            If _isFileOpen Then _closeImage()
            Image_Create(dropI.Width, dropI.Height, Me.TransparencyKey, setpage.Check_resetpanonDrop.Checked)
            _ifx.DrawImage(dropI, _ZeroPt)
            AddImageStack()
            dropI.Dispose()
            _add2Recent(res)
            _isFileOpen = True
            _FileOpened = res
            drop_arg = True
        Catch ex As Exception
            If _do_sounds Then My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Hand)
        End Try
    End Function
    Public Function drop_file(ByVal res As String) As Boolean
        drop_file = False
        If Not _modeBig Then Exit Function
        If res.Length = 0 Then Exit Function
        If Not My.Computer.FileSystem.FileExists(res) Then Exit Function
        drop_file = drop_arg(res)
    End Function


    Public Function drop_image(ByVal dropI As Image) As Boolean
        drop_image = False
        If Not _modeBig Then Exit Function
        'If res.Length = 0 Then Exit Sub
        'If Not My.Computer.FileSystem.FileExists(res) Then Exit Sub
        Try
            ' Dim dropI As Bitmap = GetImageFromFile(res, 0, 0)
            Image_Create(dropI.Width, dropI.Height, Me.TransparencyKey, setpage.Check_resetpanonDrop.Checked)
            _ifx.DrawImage(dropI, _ZeroPt)
            AddImageStack()
            ' dropI.Dispose()
            drop_image = True
        Catch ex As Exception
            '  If _do_sounds Then My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Hand)
        End Try
    End Function
    Private Sub ImportClipboardToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImportClipboardToolStripMenuItem.Click
        If My.Computer.Clipboard.ContainsFileDropList Then
            If drop_file(My.Computer.Clipboard.GetFileDropList(0)) Then
                View_Draw(True)
                If _do_sounds Then My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
            Else
                If _do_sounds Then My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Hand)
            End If
        ElseIf My.Computer.Clipboard.ContainsImage Then
            If drop_image(My.Computer.Clipboard.GetImage) Then
                View_Draw(True)
                If _do_sounds Then My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
            Else
                If _do_sounds Then My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Hand)
            End If
        End If
    End Sub
    Private Sub ExportClipoardToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportClipoardToolStripMenuItem.Click
        If My.Computer.Clipboard.ContainsImage Then
            If sfdia.ShowDialog = vbOK Then
                My.Computer.Clipboard.GetImage.Save(sfdia.FileName, Drawing.Imaging.ImageFormat.Png)
                _add2Recent(sfdia.FileName)
                If _do_sounds Then My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
                StartAnimatate()
            End If
        Else
            If _do_sounds Then My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Exclamation)
        End If
    End Sub
    Private Sub QuicksaveFolderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuicksaveFolderToolStripMenuItem.Click
        If My.Computer.FileSystem.DirectoryExists(setpage.Label12.Text) Then
            Process.Start(setpage.Label12.Text)
        Else
            MsgBox("Folder does not exist: " + setpage.Label12.Text, vbCritical)
        End If
    End Sub
    Private Sub Settings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SetTKeyToolStripMenuItem.Click
        If Panel_Pallete.Visible Then Pallet_CloseDialog()
        setpage.ShowCustomDialog(Me, _imgC, _img.Size, _modeBig)
    End Sub
    Private Sub AppDirectoryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AppDirectoryToolStripMenuItem.Click
        Process.Start(My.Application.Info.DirectoryPath)
    End Sub
    Private Sub QuitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuitToolStripMenuItem.Click
        Me.Close()
    End Sub
    Private Sub ResetToolbarsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetToolbarsToolStripMenuItem.Click
        If Panel_Pallete.Visible Then Pallet_CloseDialog()
        Panel_Pallete.Tag = New Point(2, -2 - Panel_Pallete.Height)
        Panel_tools.Tag = New Point(2, 2)
    End Sub
    Private Sub CenterAnchorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CenterAnchorToolStripMenuItem.Click
        If _modeBig Then
            Panel_Anchor.Location = _ZeroPt
        Else
            Me.Location = _ZeroPt
        End If
        StartAnimatate()
    End Sub
    Private Sub B_FontChange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_FontChange.Click
        FontDialog1.Font = TextTootl.Font

        If FontDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            TextTootl.Font = FontDialog1.Font
            ' setpage.LabelTSFpreview.Font = FontDialog1.Font
        End If
    End Sub
    ' Private Sub ModeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModeToolStripMenuItem.Click
    '    SetMode(Not _modeBig, 0)
    '  End Sub
    Private Sub cms_rainbow_Closing(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolStripDropDownClosingEventArgs) Handles cms_rainbow.Closing
        Try
            _rainbow_shift = Convert.ToSingle(TSTB_rainbowDelta.Text)
        Catch ex As Exception
            TSTB_rainbowDelta.Text = _rainbow_shift.ToString
            ' MsgBox("Invalid delta value!!")
        End Try
    End Sub
    Private Sub ScreenshotToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ScreenshotToolStripMenuItem.Click
        If AllScreensToolStripMenuItem.Checked Then
            SaveSSAll()
        Else
            SaveSS()
        End If
    End Sub
    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        _saveStart(True, False, True)
    End Sub

    'selection toolstrips
    Private Sub SelCutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelCutToolStripMenuItem.Click
        If _selecting Then
            etHelper_iImageCut(_selRect)
        Else
            If _do_sounds Then My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Exclamation)
        End If
    End Sub
    Private Sub SelCopyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelCopyToolStripMenuItem.Click
        If _selecting Then
            etHelper_iImageCopy(_selRect)
        Else
            If _do_sounds Then My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Exclamation)
        End If
    End Sub
    Private Sub SelSaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelSaveToolStripMenuItem.Click
        _saveStart(True, True, True)
    End Sub
    Private Sub SelClearToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelClearToolStripMenuItem.Click
        If _selecting Then
            etHelper_iImageClear(_selRect)
        Else
            If _do_sounds Then My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Exclamation)
        End If
    End Sub

    'Animate
    Private Sub StartAnimatate(Optional ByVal time_interval As Integer = 4)
        If time_interval = 0 Then Exit Sub
        If _modeBig Then
            _swapImg = 1
        Else
            _swapImg = 0
        End If
        _trueImg = True
        totaltime = time_interval
        'trayico.ShowBalloonTip(2, "rest:title", "test:text", ToolTipIcon.Error)
        time_animate.Start()
    End Sub
    Private Sub time_animate_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles time_animate.Tick
        If _trueImg Then
            Pic_Anchor.Image = ImgL(2)
        Else
            Pic_Anchor.Image = ImgL(_swapImg)
        End If
        _trueImg = Not _trueImg

        totaltime -= 1
        If totaltime = 0 Then
            Pic_Anchor.Image = ImgL(_swapImg)
            time_animate.Stop()
        End If
    End Sub

    ' Anchor events - for mode toggle
    Private Sub SetMode(ByVal asBig As Boolean, ByVal time_animate As Integer)

        If asBig Then
            Panel_Anchor.Visible = False
            Me.WindowState = FormWindowState.Maximized
            Panel_Anchor.Location = New Point(_smalPt.X Mod ScreenBounds.Width, _smalPt.Y Mod ScreenBounds.Height)
            Pic_Anchor.Image = ImgL(1)
            Panel_Anchor.Visible = Not setpage.Check_HideAnchr.Checked
            View_Draw(True)
            '  ModeToolStripMenuItem.Text = "Switch OFF"
        Else
            Panel_Anchor.Visible = True
            Dim prevPoint As Point = Panel_Anchor.Location + Me.Location

            Me.WindowState = FormWindowState.Normal
            Panel_Anchor.Location = _ZeroPt
            Me.Size = New Size(Panel_Anchor.Size)

            Me.Location = prevPoint
            _smalPt = Me.Location
            Pic_Anchor.Image = ImgL(0)

            ' Panel_Pallete.Visible = False
            ' Panel_tools.Visible = False
            ' Panel_textInput.Visible = False
            ' ModeToolStripMenuItem.Text = "Switch ON"
        End If
        _modeBig = asBig
        StartAnimatate(time_animate)

    End Sub



    ' keyboard input focus
    Private Sub t_kp_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles t_kp.LostFocus
        B_inputfocus.BackColor = _lostFocusBC
    End Sub
    Private Sub t_kp_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles t_kp.GotFocus
        B_inputfocus.BackColor = _gotFocusBC
    End Sub
    Private Sub B_inputfocus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_inputfocus.Click
        t_kp.Focus()
    End Sub

    'tray icon
    Private Sub trayico_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles trayico.MouseDoubleClick
        CenterAnchorToolStripMenuItem_Click(Nothing, Nothing)
    End Sub
    Private Sub b_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_close.Click
        Me.Close()
    End Sub

#End Region

#Region "' Load and Close '"

    Private Sub _updateSetting()
        With _SETTING

            .iUpdate(_settings_types(0, 0), Panel_Pallete.Tag)
            .iUpdate(_settings_types(1, 0), Panel_tools.Tag)
            If _modeBig Then
                _SETTING.iUpdate(_settings_types(2, 0), Panel_Anchor.Location)
            Else
                _SETTING.iUpdate(_settings_types(2, 0), Me.Location)
            End If
            .iUpdate(_settings_types(3, 0), _prevDialogPoint)
            .iUpdate(_settings_types(4, 0), _pen_size)
            .iUpdate(_settings_types(5, 0), _shape_size)
            .iUpdate(_settings_types(6, 0), _eraser_size)
            .iUpdate(_settings_types(8, 0), Check_copy2clip.Checked)
            .iUpdate(_settings_types(7, 0), setpage.NUD_maxUndo.Value)
            .iUpdate(_settings_types(9, 0), Panel_tools.Dock)
            .iUpdate(_settings_types(10, 0), Check_erasretrail.Checked)
            .iUpdate(_settings_types(11, 0), Check_fixedToolbox.Checked)
            .iUpdate(_settings_types(12, 0), NUD_ANGLEsel.CurrentAngle * (Math.PI / 180))
            .iUpdate(_settings_types(13, 0), New Point(setpage.nud_canvasX.Value, setpage.nud_canvasY.Value))
            .iUpdate(_settings_types(14, 0), AllScreensToolStripMenuItem.Checked)
            .iUpdate(_settings_types(15, 0), setpage.Label12.Text)
            .iUpdate(_settings_types(16, 0), CheckBox_lockXscroll.Checked)
            .iUpdate(_settings_types(17, 0), CheckBox_lockYscroll.Checked)
            .iUpdate(_settings_types(18, 0), setpage.Check_tooltips.Checked)
            .iUpdate(_settings_types(19, 0), TextTootl.Font)
            .iUpdate(_settings_types(20, 0), setpage.Check_sDate.Checked)
            .iUpdate(_settings_types(21, 0), setpage.Check_sTime.Checked)
            .iUpdate(_settings_types(22, 0), Convert.ToInt32(TSTB_hueDelta.Text))
            .iUpdate(_settings_types(23, 0), Me.TransparencyKey)
            .iUpdate(_settings_types(24, 0), Panel_Anchor.Size)
            .iUpdate(_settings_types(25, 0), setpage.L_pathG.Text)
            .iUpdate(_settings_types(26, 0), setpage.L_pathR.Text)
            .iUpdate(_settings_types(27, 0), setpage.L_pathY.Text)
            .iUpdate(_settings_types(28, 0), _prevPtext)
            .iUpdate(_settings_types(29, 0), Panel_textInput.Location)
            .iUpdate(_settings_types(30, 0), Panel_textInput.Size)
            .iUpdate(_settings_types(31, 0), _rainbow_shift)
            .iUpdate(_settings_types(32, 0), setpage.Check_HideAnchr.Checked)
            .iUpdate(_settings_types(33, 0), _do_sounds)
            .iUpdate(_settings_types(34, 0), _pixFormat)

            .iUpdate(_settings_types(35, 0), Panel_webber.Location)
            .iUpdate(_settings_types(36, 0), Panel_webber.Size)
            .iUpdate(_settings_types(37, 0), text_webaddr.Text)
        End With
    End Sub


    Private Sub __initSettingSchema__()
        _settings_types = {
            {"0_PalleteLoc", HoDtype.hod_point, New Point(2, -2 - Panel_Pallete.Height)},
            {"1_ToolboxLoc", HoDtype.hod_point, New Point(2, 2)},
            {"2_AnchorLoc", HoDtype.hod_point, Panel_Anchor.Location},
            {"3_TBLoc", HoDtype.hod_point, New Point(100, 100)},
            {"4_MarkerWid", HoDtype.hod_integer, _pen_size},
            {"5_ShapeWid", HoDtype.hod_integer, _shape_size},
            {"6_EraserWid", HoDtype.hod_integer, _eraser_size},
            {"7_MaxUndo", HoDtype.hod_integer, 5},
            {"8_Copy2Clip", HoDtype.hod_boolean, Check_copy2clip.Checked},
            {"9_DockStyle", HoDtype.hod_enum, Panel_tools.Dock},
            {"10_EraserTrail", HoDtype.hod_boolean, Check_erasretrail.Checked},
            {"11_FixToolBar", HoDtype.hod_boolean, Check_fixedToolbox.Checked},
            {"12_CallySlope", HoDtype.hod_single, _calangle},
            {"13_CanvasParam", HoDtype.hod_point, New Point(My.Computer.Screen.WorkingArea.Width, My.Computer.Screen.WorkingArea.Height)},
            {"14_QSAllScreen", HoDtype.hod_boolean, False},
            {"15_QuickSavePath", HoDtype.hod_string, My.Application.Info.DirectoryPath},
            {"16_LockXPan", HoDtype.hod_boolean, CheckBox_lockXscroll.Checked},
            {"17_LockYPan", HoDtype.hod_boolean, CheckBox_lockYscroll.Checked},
            {"18_ShowTips", HoDtype.hod_boolean, mytooltips.Active},
            {"19_Font", HoDtype.hod_font, Me.Font},
            {"20_ShortDate", HoDtype.hod_boolean, False},
            {"21_ShortTime", HoDtype.hod_boolean, False},
            {"22_HueDelta", HoDtype.hod_single, 60},
            {"23_Tkey", HoDtype.hod_color, _appDefTkey},
            {"24_AnchorSize", HoDtype.hod_size, Panel_Anchor.Size},
            {"25_CanvasG", HoDtype.hod_string, iconDir + "\0.ico"},
            {"26_CanvasR", HoDtype.hod_string, iconDir + "\1.ico"},
            {"27_CanvasY", HoDtype.hod_string, iconDir + "\2.ico"},
            {"28_SavePrefix", HoDtype.hod_string, ""},
            {"29_TextInputLoc", HoDtype.hod_point, _ZeroPt},
            {"30_TextInputSize", HoDtype.hod_size, Panel_textInput.Size},
            {"31_RainbowDelta", HoDtype.hod_single, _rainbow_shift},
            {"32_AnchorHide", HoDtype.hod_boolean, False},
            {"33_DoSounds", HoDtype.hod_boolean, _do_sounds},
            {"34_PixelFormat", HoDtype.hod_enum, _pixFormat},
            {"35_webloc", HoDtype.hod_point, Panel_webber.Location},
            {"36_websize", HoDtype.hod_size, Panel_webber.Size},
            {"37_webaddress", HoDtype.hod_string, text_webaddr.Text}
            }
    End Sub
    Const _Settings_nos As Integer = 38

    Private Sub _buildDefaultSettings(ByVal do_clear As Boolean)
        If do_clear Then _SETTING.zClearAll()
        For i = 0 To _Settings_nos - 1
            _SETTING.iCreate(_settings_types(i, 0), _settings_types(i, 2))
        Next
    End Sub
    Private Function _applySettings() As Boolean
        ' Initialize
        _SETTING = New HoDOfObject(_config_file,
                                sep_rows, sep_cols, sep_meta, sep_keys,
                                AddressOf HOD_S2O, AddressOf HOD_O2S)

        ' load first time
        _SETTING.ForceLoad(_settings_types)

        'check if loaded
        If Not _SETTING.IsLoaded Then
            ' build default and save
            _buildDefaultSettings(_SETTING.ExistOnDisk)
            _SETTING.ForceSave(_settings_types)
        Else
            'chk before applying 'check if applicable - fill missing
            For i = 0 To _Settings_nos - 1
                If Not _SETTING.iContainKey(_settings_types(i, 0)) Then
                    _SETTING.iCreate(_settings_types(i, 0), _settings_types(i, 2))
                End If
            Next
        End If


        '-------------> continue to truly apply: 
        'Setting types may be integer but not all integers may be valid values 
        'like Markerwid cannot be <=0
        Try
            _do_sounds = _SETTING.iRead(_settings_types(33, 0))
            _loadSR_TkeySet(_SETTING.iRead(_settings_types(23, 0)))
            Panel_Pallete.Tag = _SETTING.iRead(_settings_types(0, 0))
            Panel_tools.Tag = _SETTING.iRead(_settings_types(1, 0))
            Panel_Anchor.Location = _SETTING.iRead(_settings_types(2, 0))
            _prevDialogPoint = _SETTING.iRead(_settings_types(3, 0))

            MyMarkerSize = _SETTING.iRead(_settings_types(4, 0))
            track_mwid.Value = MyMarkerSize

            MyShapeSize = _SETTING.iRead(_settings_types(5, 0))
            track_swid.Value = MyShapeSize

            MyEraserSize = _SETTING.iRead(_settings_types(6, 0))
            track_eraser.Value = MyEraserSize

            _pixFormat = _SETTING.iRead(_settings_types(34, 0))


            Combo_dockStc.SelectedIndex = _SETTING.iRead(_settings_types(9, 0))
            Check_erasretrail.Checked = _SETTING.iRead(_settings_types(10, 0))
            Check_fixedToolbox.Checked = _SETTING.iRead(_settings_types(11, 0))
            Check_copy2clip.Checked = _SETTING.iRead(_settings_types(8, 0))
            NUD_ANGLEsel.SetCurrentAngle((_SETTING.iRead(_settings_types(12, 0)) * 180 / Math.PI).ToString, True)


            CheckBox_lockXscroll.Checked = _SETTING.iRead(_settings_types(16, 0))
            CheckBox_lockYscroll.Checked = _SETTING.iRead(_settings_types(17, 0))
            mytooltips.Active = _SETTING.iRead(_settings_types(18, 0))
            TSTB_hueDelta.Text = _SETTING.iRead(_settings_types(22, 0))

            Panel_webber.Location = _SETTING.iRead(_settings_types(35, 0))
            Panel_webber.Size = _SETTING.iRead(_settings_types(36, 0))
            text_webaddr.Text = _SETTING.iRead(_settings_types(37, 0))

            Panel_textInput.Location = _SETTING.iRead(_settings_types(29, 0))
            Panel_textInput.Size = _SETTING.iRead(_settings_types(30, 0))
            TextTootl.Font = _SETTING.iRead(_settings_types(19, 0))
            _rainbow_shift = _SETTING.iRead(_settings_types(31, 0))
            TSTB_rainbowDelta.Text = _rainbow_shift
            Panel_Anchor.Size = _SETTING.iRead(_settings_types(24, 0))
            _load_custom_icon(_SETTING.iRead(_settings_types(25, 0)), 0)
            _load_custom_icon(_SETTING.iRead(_settings_types(26, 0)), 1)
            _load_custom_icon(_SETTING.iRead(_settings_types(27, 0)), 2)
            AllScreensToolStripMenuItem.Checked = _SETTING.iRead(_settings_types(14, 0))
            setpage.BuildMe(AddressOf SetPixFormat, AddressOf _validatePrefix, AddressOf _loadSR_TkeySet, AddressOf _load_custom_icon,
                            AddressOf Callback_SetAnchorSize, AddressOf Callback_Setpage_TipSet,
                            AddressOf Callback_Setpage_clearAStack, AddressOf ExtendCanvas,
                             ImgL, _SETTING, _settings_types)
            _applySettings = True
        Catch ex As Exception
            ' some error occured
            ' mostlikely - invalid values supplied
            ' remove settings file and close app
            _applySettings = False
        End Try

    End Function
    Friend Sub SetPixFormat()
        _pixFormat = setpage._pxFVals(setpage.Combo_pixFormat.SelectedIndex)
    End Sub
    Friend Function _loadSR_TkeySet(ByVal C As Color) As Color
        If C = Color.White Or C = Color.Black Then Return Me.TransparencyKey
        Me.TransparencyKey = C

        ' set transparent and grid pen/brush
        _xpen = New Pen(Me.TransparencyKey, _eraser_size * 2)
        _xbru = New SolidBrush(Me.TransparencyKey)

        ' set transparency colors
        Me.BackColor = Me.TransparencyKey
        my_canvas.BackColor = Me.TransparencyKey
        SetTKeyToolStripMenuItem.BackColor = Me.TransparencyKey
        Pic_Anchor.BackColor = Me.TransparencyKey
        Label_coord.BackColor = Color.White
        If _isOpen Then View_Draw(True)
        Return Me.TransparencyKey
    End Function
    Friend Function _load_custom_icon(ByVal iX As String, ByVal iI As Integer) As String
        ImgL(iI) = Pic_Anchor.ErrorImage
        _load_custom_icon = ""
        If iX <> "" Then
            If My.Computer.FileSystem.FileExists(iX) Then
                Dim imgX As Image = GetImageFromFile(iX, Panel_Anchor.Width, Panel_Anchor.Height)
                If Not IsNothing(imgX) Then
                    ImgL(iI) = imgX
                    _load_custom_icon = iX
                End If
            End If
        End If
    End Function
    Private Sub _load_checkDirs()
        If Not My.Computer.FileSystem.DirectoryExists(DATA_DIR) Then
            My.Computer.FileSystem.CreateDirectory(DATA_DIR)
        End If
        If Not My.Computer.FileSystem.DirectoryExists(cursorDir) Then
            My.Computer.FileSystem.CreateDirectory(cursorDir)
        End If
        If Not My.Computer.FileSystem.DirectoryExists(iconDir) Then
            My.Computer.FileSystem.CreateDirectory(iconDir)
        End If

    End Sub
    Private Sub _load_cursors()
        For i = 0 To _itool2cursor.Length - 1
            Dim this_curFile As String = cursorDir + "\" + i.ToString + ".cur"
            If My.Computer.FileSystem.FileExists(this_curFile) Then
                _itool2cursor(i) = New Cursor(this_curFile)
            Else
                _itool2cursor(i) = Cursors.UpArrow
            End If
        Next
    End Sub
    Private Sub _applyColors()
        _SETTING_COLORS = New ListOnDisk(Of Color)(_color_file, True,
                                           sep_rows, sep_cols,
                                           AddressOf COL_2_STR,
                                           AddressOf STR_2_COL,
                                           AddressOf COMPAR_COL)

        _arrOfCols = {xcp0, xcp1, xcp2, xcp3, xcp4, xcp5, xcp6, xcp7, xcp9, xcp8, xcp9,
        xcp10, xcp11, xcp12, xcp13, xcp14, xcp15, xcp16, xcp17,
         pan_gridpenx, pan_gridpeny, pan_gridpen, Panel_SelCol}

        If Not _SETTING_COLORS.IsLoaded Then
            If _SETTING_COLORS.ExistOnDisk Then
                _SETTING_COLORS.CRUD_DeleteAll()
                _SETTING_COLORS.mCRUD_DeleteAll()
            End If
            For i = 0 To _arrOfCols.Length - 1
                _SETTING_COLORS.CRUD_Create(_arrOfCols(i).BackColor, False)
            Next
            _SETTING_COLORS.Save()
        End If

        'apply colors
        'On Error Resume Next
        For i = 0 To _SETTING_COLORS.RowCount - 1
            _arrOfCols(i).Tag = i
            _arrOfCols(i).BackColor = _SETTING_COLORS.CRUD_Read(i)
        Next

    End Sub

    Private Sub _load_bookmarks()
        _SETTING_BOOKMARKS = New ListOnDisk(Of BookMarkItem)(_bmark_file, True,
                                         sep_rows, sep_cols,
                                         AddressOf BookMarkItem._2str,
                                         AddressOf BookMarkItem._2obj,
                                         AddressOf BookMarkItem._compar)


        If Not _SETTING_BOOKMARKS.IsLoaded Then
            If _SETTING_BOOKMARKS.ExistOnDisk Then
                _SETTING_BOOKMARKS.CRUD_DeleteAll()
                _SETTING_BOOKMARKS.mCRUD_DeleteAll()
            End If
            _SETTING_BOOKMARKS.Save()
        End If

        'apply colors
        'On Error Resume Next
        For i = 0 To _SETTING_BOOKMARKS.RowCount - 1
            ListBox_bmark.Items.Add(_SETTING_BOOKMARKS.CRUD_Read(i))
        Next
    End Sub

    Private Sub MinimalistPNGEditor_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        _load_checkDirs()
        Threading.Thread.Sleep(10)
        _load_cursors()

        __initSettingSchema__()
        ' create settings page
        setpage = New settings_page
        _config_error = Not _applySettings()
        If _config_error Then
            MsgBox("Settings File has invalid values!!" + Environment.NewLine +
             "The current settings files will be deleted and app will exit. Please start the app again to restore default settings.",
             vbCritical)
            Try
                My.Computer.FileSystem.DeleteFile(_config_file)
            Catch ex As Exception
            End Try
            Me.Close()
            Exit Sub
        End If

        ' check and load colors <<-------- use colors after this call
        _applyColors()
        MyMarkerColor = Panel_SelCol.BackColor

        'set screenbounds global variable
        ScreenBounds = My.Computer.Screen.Bounds
        WorkBounds = My.Computer.Screen.WorkingArea
        ' set tags for moving color pallete
        lab_shapeDis.Tag = Panel_Pallete
        lab_markerDis.Tag = Panel_Pallete
        lab_EraserDis.Tag = Panel_Pallete
        lab_mwid.Tag = Panel_Pallete
        lab_swid.Tag = Panel_Pallete
        lab_ewid.Tag = Panel_Pallete
        track_mwid.Tag = 0
        track_swid.Tag = 1
        track_eraser.Tag = 2
        ' set grid pens
        grid_penX = New Pen(pan_gridpenx.BackColor, 1)
        grid_penY = New Pen(pan_gridpeny.BackColor, 1)
        grid_pen = New Pen(pan_gridpen.BackColor, 1)
        grid_brush = New SolidBrush(pan_gridpen.BackColor)

        _cbru = New SolidBrush(_col_marker)
        _cpen = New Pen(_col_marker, 1)
        'set topmost
        Me.TopMost = True

    End Sub
    Private Sub MinimalistPNGEditor_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        ' Me.Opacity = 0
        MyEditorTool = EditorTool.iPointer
        If My.Application.CommandLineArgs.Count > 0 Then
            If My.Computer.FileSystem.FileExists(My.Application.CommandLineArgs(0)) Then
                drop_arg(My.Application.CommandLineArgs(0))
            Else
                Image_Create(setpage.nud_canvasX.Value, setpage.nud_canvasY.Value, Me.TransparencyKey, True)
            End If
        Else
            Image_Create(setpage.nud_canvasX.Value, setpage.nud_canvasY.Value, Me.TransparencyKey, True)
        End If

        If _isOpen Then View_Draw(True)

        '  Timer_initAnimate.Start()
        If _isfirstLoad Then
            SetMode(False, 10) ' blinks longer on first start
        Else
            SetMode(False, 4)
        End If
        t_kp.Focus()

        ' webber.Url = New Uri(DATA_DIR)
        ' _buildUDPC()
        _load_bookmarks()
        ' _col_write_penN.LineJoin = Drawing2D.LineJoin.Bevel
        If _do_sounds Then My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)

    End Sub
    Private Sub MinimalistPNGEditor_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        If _config_error Then Exit Sub

        If e.CloseReason = CloseReason.UserClosing Then
            ' _queryServer(SDMSG, False)
            On Error Resume Next
            Image_Close()
            _updateSetting()
            _SETTING.ForceSave(_settings_types)

            _SETTING_BOOKMARKS.Save()
            _SETTING_COLORS.CRUD_Update(_SETTING_COLORS.RowCount - 1, Panel_SelCol.BackColor, False)
            _SETTING_COLORS.Save()
        End If
    End Sub

    ' Private Sub QueryImageToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QueryImageToolStripMenuItem.Click
    'first save to tempfile
    'Dim svpath As String = My.Application.Info.DirectoryPath + "\temp.png"
    '    _img.Save(svpath)
    '     Threading.Thread.Sleep(100)
    '    _queryServer(svpath)
    ' End Sub
    ' Const SDMSG As String = "gg"
    ' Private Sub ShutdownServerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShutdownServerToolStripMenuItem.Click
    '     _queryServer(SDMSG, False)
    '  End Sub
    '  Dim udpc As Sockets.UdpClient
    ' Dim psrv As IPEndPoint
    '  Dim _clientbusy As Boolean = False
    '   Private Sub _buildUDPC()
    '    udpc = New Sockets.UdpClient()
    '    psrv = New IPEndPoint(IPAddress.Loopback, 20001)
    '   _clientbusy = False
    '  End Sub


    'Private Sub _queryServer(ByVal msg As String, Optional ByVal chk_reply As Boolean = True)
    '    'Dim msg As String = InputBox("message")
    '    If _clientbusy Then
    '        If _do_sounds Then My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Hand)
    '        Dim jj As Boolean = bgwudp.IsBusy
    '        bgwudp.CancelAsync()
    '        Exit Sub
    '    End If

    '    _clientbusy = True
    '    Dim msgb As Byte() = System.Text.UTF8Encoding.UTF8.GetBytes(msg)
    '    udpc.Send(msgb, msgb.Length, psrv)

    '    System.Threading.Thread.Sleep(1000)
    '    If chk_reply Then bgwudp.RunWorkerAsync()
    'End Sub
    'Dim ack As String = ""
    'Private Sub bgwudp_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgwudp.DoWork
    '    Try
    '        ack = System.Text.UTF8Encoding.UTF8.GetString(udpc.Receive(psrv))
    '        e.Result = True
    '    Catch ex As Exception
    '        If _do_sounds Then My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Hand)
    '        e.Result = False
    '    End Try

    'End Sub
    'Private Sub bgwudp_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwudp.RunWorkerCompleted
    '    If e.Result = True Then
    '        StartAnimatate()
    '        EnterTextToolStripMenuItem_Click(Nothing, Nothing)
    '        View_Draw(False)
    '        TextTootl.Text = ack
    '    Else
    '        TextTootl.Text = "Error!"
    '    End If
    '    _clientbusy = False
    'End Sub
#End Region

#Region "' Save Images '"

    Private Sub _validatePrefix()
        Dim nexPrefix As String = setpage.TSTBPrefixS.Text
        If nexPrefix = "" Or nexPrefix = _prevPtext Then Exit Sub
        If ValidFilename(nexPrefix) Then
            _prevPtext = nexPrefix
        End If
        setpage.TSTBPrefixS.Text = _prevPtext
    End Sub
    Private Sub _saveColorSRSel(ByVal fs As String, ByVal new_bg As Color)
        '  If Not _selecting Then Exit Sub
        Dim _imgTemp As New Bitmap(_selRect.Width, _selRect.Height, _pixFormat)
        Dim _imgfx As Graphics = Graphics.FromImage(_imgTemp)
        _imgfx.DrawImage(_img, 0, 0, _selRect, GraphicsUnit.Pixel)

        If new_bg = Me.TransparencyKey Then
            _imgTemp.Save(fs, Drawing.Imaging.ImageFormat.Png)
            _add2Recent(fs)
        Else
            _imgTemp.MakeTransparent(Me.TransparencyKey)
            Dim _imgTemp2 As New Bitmap(_imgTemp.Width, _imgTemp.Height, _pixFormat)
            Dim _img2gfx As Graphics = Graphics.FromImage(_imgTemp2)
            _img2gfx.Clear(PalleteCD.Color)
            _img2gfx.DrawImage(_imgTemp, _ZeroPt)

            _imgTemp2.Save(fs, Drawing.Imaging.ImageFormat.Png)
            _add2Recent(fs)
            _img2gfx.Dispose()
            _imgTemp2.Dispose()

        End If
        _imgfx.Dispose()
        _imgTemp.Dispose()
        StartAnimatate()
    End Sub
    Private Sub _saveColorSR(ByVal fs As String, ByVal new_bg As Color)

        If new_bg = Me.TransparencyKey Then
            _img.Save(fs, Drawing.Imaging.ImageFormat.Png)
            _add2Recent(fs)
        Else
            Dim _imgTemp As Bitmap = _img.Clone
            _imgTemp.MakeTransparent(Me.TransparencyKey)

            Dim _imgTemp2 As New Bitmap(_imgTemp.Width, _imgTemp.Height, _pixFormat)
            Dim _img2gfx As Graphics = Graphics.FromImage(_imgTemp2)
            _img2gfx.Clear(PalleteCD.Color)
            _img2gfx.DrawImage(_imgTemp, _ZeroPt)

            _imgTemp2.Save(fs, Drawing.Imaging.ImageFormat.Png)
            _add2Recent(fs)

            _img2gfx.Dispose()
            _imgTemp.Dispose()
            _imgTemp2.Dispose()

        End If
        StartAnimatate()
    End Sub
    Private Sub _saveTransSRSel(ByVal fs As String)
        ' If Not _selecting Then Exit Sub
        Dim _imgTemp As New Bitmap(_selRect.Width, _selRect.Height, _pixFormat)
        Dim _imgfx As Graphics = Graphics.FromImage(_imgTemp)
        _imgfx.DrawImage(_img, 0, 0, _selRect, GraphicsUnit.Pixel)
        _imgTemp.MakeTransparent(Me.TransparencyKey)
        _imgTemp.Save(fs, Drawing.Imaging.ImageFormat.Png)
        _add2Recent(fs)
        _imgfx.Dispose()
        _imgTemp.Dispose()

        StartAnimatate()
    End Sub
    Private Sub _saveTransSR(ByVal fs As String)
        Dim _imgTemp As Bitmap = _img.Clone
        _imgTemp.MakeTransparent(Me.TransparencyKey)
        _imgTemp.Save(fs, Drawing.Imaging.ImageFormat.Png)
        _add2Recent(fs)
        _imgTemp.Dispose()
        StartAnimatate()
    End Sub
    Private Sub _saveStart(ByVal on_trans As Boolean, ByVal on_sel As Boolean, ByVal do_quick As Boolean)
        If Not _isOpen Then Exit Sub
        If on_sel And Not _selecting Then
            If _do_sounds Then My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Exclamation)
            Exit Sub
        End If

        Dim fst As String = ""
        If do_quick Then
            If My.Computer.FileSystem.DirectoryExists(setpage.Label12.Text) Then
                fst = setpage.Label12.Text + "\" + _prevPtext + GetUniqueName(".png")
            Else
                MsgBox("Quicksave directory does not exist!!" + Environment.NewLine + setpage.Label12.Text, vbCritical)
                Exit Sub
            End If
        Else
            If sfdia.ShowDialog <> Windows.Forms.DialogResult.OK Then Exit Sub
            fst = sfdia.FileName
        End If

        If on_trans Then
            If on_sel Then
                _saveTransSRSel(fst)
            Else
                _saveTransSR(fst)
            End If
        Else
            PalleteCD.Color = Me.TransparencyKey
            If PalleteCD.ShowDialog <> vbOK Then Exit Sub
            If on_sel Then
                _saveColorSRSel(fst, PalleteCD.Color)
            Else
                _saveColorSR(fst, PalleteCD.Color)
            End If
        End If
    End Sub
    Private Sub _saveOverwite()
        If Not _isFileOpen Then Exit Sub
        Try
            Dim _imgTemp As Bitmap = _img.Clone
            '_imgTemp.MakeTransparent(Me.TransparencyKey)
            _imgTemp.Save(_FileOpened, Drawing.Imaging.ImageFormat.Png)
            _imgTemp.Dispose()
            If _do_sounds Then My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
            StartAnimatate()

        Catch ex As Exception
            If _do_sounds Then My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Hand)
        End Try
    End Sub
    Private Sub SaveSS()
        _prevDialogstate = Panel_Pallete.Visible
        Pallet_CloseDialog()
        cms_canvasctrl.Close()
        Panel_Anchor.Visible = False
        View_Draw(False)
        Dim screenGrab As New Bitmap(ScreenBounds.Width, ScreenBounds.Height, _pixFormat)
        Dim scri As Integer = Int(Me.Location.X / ScreenBounds.Width)
        Dim g As Graphics = Graphics.FromImage(screenGrab)
        g.CopyFromScreen(SystemInformation.VirtualScreen.X + ScreenBounds.Width * scri,
                       SystemInformation.VirtualScreen.Y,
                         0, 0, SystemInformation.VirtualScreen.Size)
        g.DrawImage(screenGrab, 0, 0)
        If Check_copy2clip.Checked Then
            My.Computer.Clipboard.SetImage(screenGrab)
        Else
            Dim uname As String = setpage.Label12.Text + "\" + _prevPtext + GetUniqueName(".png")
            screenGrab.Save(uname, Drawing.Imaging.ImageFormat.Png)
            _add2Recent(uname)
        End If
        screenGrab.Dispose()
        g.Dispose()
        If _prevDialogstate Then Pallet_showDialog(_prevDialogPoint)
        Panel_Anchor.Visible = True
        StartAnimatate()
    End Sub
    Private Sub SaveSSAll()
        _prevDialogstate = Panel_Pallete.Visible
        Pallet_CloseDialog()
        cms_canvasctrl.Close()
        Panel_Anchor.Visible = False
        View_Draw(False)
        Dim screenGrab As Bitmap = New Bitmap( _
                        Screen.AllScreens.Sum(Function(s As Screen) s.Bounds.Width),
                        Screen.AllScreens.Max(Function(s As Screen) s.Bounds.Height), _pixFormat)
        Dim g As Graphics = Graphics.FromImage(screenGrab)
        g.CopyFromScreen(SystemInformation.VirtualScreen.X,
                           SystemInformation.VirtualScreen.Y,
                           0, 0, SystemInformation.VirtualScreen.Size)

        g.DrawImage(screenGrab, 0, 0)
        Dim uname As String = setpage.Label12.Text + "\" + _prevPtext + GetUniqueName(".png")
        screenGrab.Save(uname, Drawing.Imaging.ImageFormat.Png)
        _add2Recent(uname)
        screenGrab.Dispose()
        g.Dispose()
        If _prevDialogstate Then Pallet_showDialog(_prevDialogPoint)

        Panel_Anchor.Visible = True
        StartAnimatate()
    End Sub

    Public Function GetUniqueName(ByVal addext As String, Optional ByVal sep As Char = "_") As String
        Dim _now As DateTime = DateTime.Now
        Dim _s As String = ""
        Dim _t As String = ""

        _s += _now.Year.ToString + sep

        _t = _now.Month.ToString
        While _t.Length < 2
            _t = "0" + _t
        End While
        _s += _t + sep

        _t = _now.Day.ToString
        While _t.Length < 2
            _t = "0" + _t
        End While
        _s += _t + sep

        _t = _now.Hour.ToString
        While _t.Length < 2
            _t = "0" + _t
        End While
        _s += _t + sep

        _t = _now.Minute.ToString
        While _t.Length < 2
            _t = "0" + _t
        End While
        _s += _t + sep

        _t = _now.Second.ToString
        While _t.Length < 2
            _t = "0" + _t
        End While
        _s += _t + sep

        _t = _now.Millisecond.ToString
        While _t.Length < 3
            _t = "0" + _t
        End While
        _s += _t + sep

        Return _s + addext
    End Function

#End Region

#Region "' Settings Callbacks '"


    Friend Sub Callback_Setpage_TipSet()
        mytooltips.Active = setpage.Check_tooltips.Checked
    End Sub

    Friend Sub Callback_Setpage_clearAStack()
        ' callback from settings-page to clear undo-stack
        For i = 0 To _imgStack.Count - 1
            _imgStack(i).Dispose()
        Next
        _imgStack.Clear()
        _imgC = -1
        AddImageStack()
        setpage.Label_imgC.Text = _imgC.ToString
    End Sub

    Friend Sub Callback_SetAnchorSize()
        Panel_Anchor.Size = New Size(setpage.nud_anchorW.Value, setpage.nud_anchorH.Value)
    End Sub

#End Region

#Region "' TextInput '"

    Private Sub EnterTextToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnterTextToolStripMenuItem.Click
        If TextTootl.Visible = True Then Exit Sub
        Panel_textInput.Visible = True
        FromClipboardToolStripMenuItem.Checked = False
        TextTootl.Focus()

    End Sub

    Private Sub TextTootl_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextTootl.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                B_hideTextIn_Click(Nothing, Nothing)
            Case Keys.Space
                If e.Control Then
                    e.SuppressKeyPress = True
                    View_Draw(False)
                End If
        End Select
    End Sub

    Private Sub B_hideTextIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_hideTextIn.Click
        t_kp.Focus()
        Panel_textInput.Visible = False
        View_Draw(False)
    End Sub

    Private Sub Panel_textInHead_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel_bottom.MouseDown
        Select Case e.Button
            Case Windows.Forms.MouseButtons.Left
                _mdTxtIn = True
                _mdTxtInPt = e.Location
        End Select

    End Sub

    Private Sub Panel_textInHead_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel_bottom.MouseUp
        Panel_textInput.Location = Panel_textInput.Location + (e.Location - _mdTxtInPt)
        _mdTxtIn = False
    End Sub

    Private Sub B_ClearTextIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_ClearTextIn.Click
        TextTootl.Text = ""
        TextTootl.Focus()
    End Sub

    Private Sub RESIZE_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel_cornor.MouseDown
        Select Case e.Button
            Case Windows.Forms.MouseButtons.Left
                _mdtresize = True
                _mdtresizePt = e.Location
        End Select
    End Sub

    Private Sub RESIZE_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel_cornor.MouseUp
        Panel_textInput.Size = (Panel_textInput.Size - New Size(_mdtresizePt - e.Location))
        If Panel_textInput.Size.Width < TextPanel_MinSize Then Panel_textInput.Size = New Size(TextPanel_MinSize, Panel_textInput.Size.Height)
        If Panel_textInput.Size.Height < TextPanel_MinSize Then Panel_textInput.Size = New Size(Panel_textInput.Size.Width, TextPanel_MinSize)

        _mdtresize = False
    End Sub

#End Region



    Private Sub KEYBOARD_CONTROLS(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles t_kp.KeyDown
        e.SuppressKeyPress = True
        '   If onn Then Exit Sub
        Select Case e.KeyCode

            ' 0 <<-------------------------------------------- Exit
            Case Keys.Escape
                If _modeBig Then
                    SetMode(Not _modeBig, 0)
                Else
                    Me.Close()
                    Exit Sub
                End If
            Case Keys.F2
                If e.Control Then
                    If _RecentFiles.Count > 0 Then
                        _RecentFiles.Clear()
                        If _do_sounds Then My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
                    End If
                Else
                    Recent_Show()
                End If
            Case Keys.F5
                View_Draw(True)


            Case Keys.F1
                _do_sounds = Not _do_sounds
                If _do_sounds Then My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Question)
                ' 1 <<-------------------------------------------- Mode
            Case Keys.Enter
                SetMode(Not _modeBig, 0)

            Case Keys.Z '2 <<--------------------------------------------Undo 
                If e.Control Then B_Undo_Click(Nothing, Nothing)
            Case Keys.Y '3 <<--------------------------------------------Redo
                If e.Control Then B_Redo_Click(Nothing, Nothing)


                '4,5<<-----------marker size
            Case Keys.Add '<---- 4
                Select Case _iTool
                    Case EditorTool.iMarker, EditorTool.iCalligraphy
                        _set_scrolls(track_mwid, e.Control, e.Shift, 1)
                    Case EditorTool.iEraser
                        _set_scrolls(track_eraser, e.Control, e.Shift, 1)
                    Case EditorTool.iLine, EditorTool.iPath, EditorTool.iGraph, EditorTool.iRectangle, EditorTool.iEllipse, EditorTool.iCircleDia, EditorTool.iTable
                        _set_scrolls(track_swid, e.Control, e.Shift, 1)
                End Select
            Case Keys.Subtract '<---- 5
                Select Case _iTool
                    Case EditorTool.iMarker, EditorTool.iCalligraphy
                        _set_scrolls(track_mwid, e.Control, e.Shift, -1)
                    Case EditorTool.iEraser
                        _set_scrolls(track_eraser, e.Control, e.Shift, -1)
                    Case EditorTool.iLine, EditorTool.iPath, EditorTool.iGraph, EditorTool.iRectangle, EditorTool.iEllipse, EditorTool.iCircleDia, EditorTool.iTable
                        _set_scrolls(track_swid, e.Control, e.Shift, -1)
                End Select

                '<<--------------------------------------------Canvas resizer
            Case Keys.Left
                If e.Control Then
                    setpage.b_XSub_Click(Nothing, Nothing)
                Else
                    If e.Alt Then
                        'align left wdge with screen0
                        View_Pan(-_VRect.X, 0)
                    Else
                        If e.Shift Then
                            View_Pan(-100, 0)
                        Else
                            View_Pan(-ScreenBounds.Width, 0)
                        End If
                    End If
                End If
                View_Draw(True)
            Case Keys.Right
                If e.Control Then
                    setpage.b_XAdd_Click(Nothing, Nothing)
                Else
                    If e.Alt Then
                        View_Pan(-(ScreenBounds.Width - _img.Width + _VRect.X), 0)
                    Else
                        If e.Shift Then
                            View_Pan(100, 0)
                        Else
                            View_Pan(ScreenBounds.Width, 0)
                        End If
                    End If
                End If
                View_Draw(True)
            Case Keys.Up
                If e.Control Then
                    setpage.b_YSub_Click(Nothing, Nothing)
                Else
                    If e.Alt Then
                        View_Pan(0, -_VRect.Y)
                    Else
                        If e.Shift Then
                            View_Pan(0, -100)
                        Else
                            View_Pan(0, -ScreenBounds.Height)
                        End If
                    End If
                End If
                View_Draw(True)
            Case Keys.Down
                If e.Control Then
                    setpage.b_YAdd_Click(Nothing, Nothing)
                Else
                    If e.Alt Then
                        View_Pan(0, -(ScreenBounds.Height - _img.Height + _VRect.Y))
                    Else
                        If e.Shift Then
                            View_Pan(0, 100)
                        Else
                            View_Pan(0, ScreenBounds.Height)
                        End If
                    End If
                End If
                View_Draw(True)
                '<<-------------------------------------------- Clear / Reset Canvas
            Case Keys.Space
                If e.Control Then
                    If e.Alt Then
                        setpage.RESTCanvas_Click(Nothing, Nothing) '<<-- ctrl + alt + space = reset size
                    Else
                        If e.Shift Then
                            SaveSSAll() '' ctrl + shift + space = screen shot all
                        Else
                            SaveSS() ''ctrl + Space = quick screenshot
                        End If
                    End If
                Else
                    If e.Alt Then
                        B_ResetPan_Click(Nothing, Nothing) ' <<-- alt + space       reset pan
                    Else
                        If e.Shift Then
                            ClearToolStripMenuItem_Click(Nothing, Nothing) '<<< shift + space  clear canvas
                        Else
                            Overlay_Show() ' space : overlay
                        End If
                    End If

                End If


                '<<-------------------------------------------- Save
            Case Keys.S
                _saveStart(Not e.Shift, e.Control, Not e.Alt)
            Case Keys.A 'Select all
                rb_SelectR.Checked = True
                If e.Control Then
                    _selRect = New Rectangle(_ZeroPt, _img.Size)
                    _selecting = True
                    View_Draw(False)
                End If
                '<<-------------------------------------------- Cut Copy Paste Tools
            Case Keys.Delete, Keys.Back
                SelClearToolStripMenuItem_Click(Nothing, Nothing)

            Case Keys.X
                If e.Control And _selecting Then etHelper_iImageCut(_selRect)
            Case Keys.C
                If e.Control Then
                    If _selecting Then
                        etHelper_iImageCopy(_selRect)
                    Else
                        If _do_sounds Then My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Exclamation)
                    End If
                Else
                    If e.Shift Then
                        rb_screencopy.Checked = True
                    Else
                        ExportClipoardToolStripMenuItem_Click(Nothing, Nothing)
                    End If

                End If
            Case Keys.V
                If Not _isOpen Then Exit Sub
                If e.Control Then
                    rb_paste.Checked = True
                Else
                    If e.Shift Then
                        rb_pasteR.Checked = True
                    Else
                        ImportClipboardToolStripMenuItem_Click(Nothing, Nothing)
                    End If

                End If

                '@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
                '<<-------------------------------------------- Editor Tools
                ' X C V S A Z Y already taken
                '   Case Keys.Q
                '     If e.Control Then
                'ShutdownServerToolStripMenuItem_Click(Nothing, Nothing)
                ' Else
                ' QueryImageToolStripMenuItem_Click(Nothing, Nothing)
                '  End If
            Case Keys.W

                If e.Control Then
                    _saveOverwite()
                Else
                    _closeImage()
                    If e.Alt Then B_ResetPan_Click(Nothing, Nothing)
                    If e.Shift Then ClearToolStripMenuItem_Click(Nothing, Nothing)
                End If

            Case Keys.Decimal
                StartAnimatate()
                ' If Not _modeBig Then Exit Sub
                '   If onn Then Exit Sub
                ' rb_pointer.Checked = True
                '   onn = True

                ' If onn Then
                If _do_sounds Then My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
                '  Else
                ' If _do_sounds Then My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
                ' End If
            Case Keys.P
                rb_pointer.Checked = True
            Case Keys.M
                rb_marker.Checked = True
            Case Keys.N
                rb_caligraphy.Checked = True
            Case Keys.U
                If e.Control Then
                    B_clearaxisPots_Click(Nothing, Nothing)
                Else
                    If e.Shift Then
                        chk_showScale.Checked = Not chk_showScale.Checked
                    Else
                        If e.Alt Then
                            Check_dropPP.Checked = Not Check_dropPP.Checked
                        Else
                            rb_axismarker.Checked = True
                        End If
                    End If
                End If
                '  Case Keys.L
                '  rb_line.Checked = True
            Case Keys.H
                rb_path.Checked = True
            Case Keys.E
                If e.Shift Then
                    Check_erasretrail.Checked = Not Check_erasretrail.Checked
                Else
                    rb_eraser.Checked = True
                End If
            Case Keys.B
                rb_table.Checked = True
                '   Case Keys.G
                '  rb_graph.Checked = True
                ' Case Keys.R
                '    rb_rectangle.Checked = True
            Case Keys.I
                rb_ellipse.Checked = True
            Case Keys.D
                '   rb_Datetime.Checked = True
                If Panel_webber.Visible Then
                    BHideW_Click(Nothing, Nothing)
                Else
                    B_webberShow_Click()
                End If

            Case Keys.K
                rb_colorpick.Checked = True
            Case Keys.T

                If e.Control Then
                    EnterTextToolStripMenuItem_Click(Nothing, Nothing)
                    View_Draw(False)
                Else
                    rb_text.Checked = True
                    If e.Shift Then
                        FromClipboardToolStripMenuItem.Checked = Not FromClipboardToolStripMenuItem.Checked
                    End If
                End If


        End Select
    End Sub

    Private Sub ControlTestToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ControlTestToolStripMenuItem.Click
        'Test Here

        'PasteAsHexaToolStripMenuItem_Click(Nothing, Nothing)
        'setpage.B_SetTkey_Click(Nothing, Nothing)
        'ImportClipboardToolStripMenuItem_Click(Nothing, Nothing)

    End Sub

    ' altername mode -> 0 = none , overlay(1) or recent(2)
    Dim _altMode As Integer = 0

    'recent files
    Dim _RecentFiles As New List(Of String)
    Dim _ritemSize As New Size(200, 200)
    Dim _rItemperRow As Integer

    'recent
    Dim _olRatio As Single = 0.1
    Dim _ofx As Graphics
    Dim _orect As Rectangle
    Dim _bsize As Size
    Dim _olpen As Pen
    Dim _cpan As Point
    Private Sub OverLay_draw()
        _ofx.Clear(Me.TransparencyKey)

        _ofx.DrawImage(_img, -_cpan.X, -_cpan.Y, _bsize.Width, _bsize.Height)
        _ofx.DrawRectangle(_olpen, -_cpan.X - 5, -_cpan.Y - 5, _bsize.Width + 10, _bsize.Height + 10)
        _ofx.DrawRectangle(grid_penY, _orect.X - 2 - _cpan.X, _orect.Y - 2 - _cpan.Y, _orect.Width + 4, _orect.Height + 4)
        _ofx.DrawRectangle(grid_penX, _orect.X - 1 - _cpan.X, _orect.Y - 1 - _cpan.Y, _orect.Width + 2, _orect.Height + 2)

        _ofx.DrawRectangle(grid_pen, _orect.X - _cpan.X, _orect.Y - _cpan.Y, _orect.Width, _orect.Height)

    End Sub

    Private Sub Overlay_Show()
        If _altMode <> 0 Or Not _modeBig Then
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Exclamation)
            Exit Sub
        End If
        t_kp.Enabled = False
        Pallet_CloseDialog()
        my_canvas.Visible = False
        _altMode = 1
        _olRatio = Math.Min(ScreenBounds.Width / _img.Width, ScreenBounds.Height / _img.Height)
        _cpan = New Point((_olRatio * _img.Width - ScreenBounds.Width) / 2, (_olRatio * _img.Height - ScreenBounds.Height) / 2)
        _bsize = New Size(_olRatio * _img.Width, _olRatio * _img.Height)
        _orect = New Rectangle(_olRatio * _VRect.X, _olRatio * _VRect.Y, _olRatio * _VRect.Width, _olRatio * _VRect.Height)
        _ofx = Me.CreateGraphics
        _olpen = New Pen(grid_pen.Color, 5)
        OverLay_draw()
    End Sub

    Private Sub Overlay_Hide()
        _ofx.Dispose()
        _altMode = 0
        my_canvas.Visible = True
        t_kp.Enabled = True
        t_kp.Focus()
    End Sub

    Private Sub MinimalistPNGEditor_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseClick

        Select Case _altMode
            Case 0
                Exit Sub
            Case 1 ' overlay
                Select Case e.Button
                    Case Windows.Forms.MouseButtons.Left
                        Dim newP As Point
                        newP = New Point((e.X + _cpan.X) / _olRatio - _VRect.X - _VbaseMid.X, (e.Y + _cpan.Y) / _olRatio - _VRect.Y - _VbaseMid.Y)
                        View_Pan(newP.X, newP.Y)
                        Overlay_Hide()
                    Case Windows.Forms.MouseButtons.Right
                        Overlay_Hide()
                End Select
            Case 2 ' recent
                Select Case e.Button
                    Case Windows.Forms.MouseButtons.Left
                        Recent_Hide()
                        If e.X <= _rItemperRow * _ritemSize.Width Then
                            Dim clickedint As Integer = Int(e.Y / _ritemSize.Height) * _rItemperRow + Int(e.X / _ritemSize.Width)
                            If clickedint < _RecentFiles.Count And clickedint >= 0 Then
                                Dim clickedfile As String = _RecentFiles(clickedint)
                                'MsgBox(clickedint.ToString + "@" + clickedfile)

                                If drop_file(clickedfile) Then
                                    If _do_sounds Then My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
                                Else
                                    If _do_sounds Then My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Hand)
                                End If

                            End If
                        End If
                        '  View_Draw(True)
                    Case Windows.Forms.MouseButtons.Right
                        Recent_Hide()
                        If e.X <= _rItemperRow * _ritemSize.Width Then
                            Dim clickedint As Integer = Int(e.Y / _ritemSize.Height) * _rItemperRow + Int(e.X / _ritemSize.Width)
                            If clickedint < _RecentFiles.Count And clickedint >= 0 Then
                                Dim clickedfile As String = _RecentFiles(clickedint)
                                'MsgBox(clickedint.ToString + "@" + clickedfile)

                                If My.Computer.FileSystem.FileExists(clickedfile) Then
                                    Dim los As New Collections.Specialized.StringCollection
                                    los.Add(clickedfile)
                                    My.Computer.Clipboard.SetFileDropList(los)
                                    If _do_sounds Then My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
                                Else
                                    If _do_sounds Then My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Hand)
                                End If
                            End If
                        End If
                    Case Windows.Forms.MouseButtons.Middle
                        Recent_Hide()
                        If e.X <= _rItemperRow * _ritemSize.Width Then
                            Dim clickedint As Integer = Int(e.Y / _ritemSize.Height) * _rItemperRow + Int(e.X / _ritemSize.Width)
                            If clickedint < _RecentFiles.Count And clickedint >= 0 Then
                                Dim clickedfile As String = _RecentFiles(clickedint)
                                'MsgBox(clickedint.ToString + "@" + clickedfile)
                                Try
                                    My.Computer.Clipboard.SetImage(GetImageFromFile(clickedfile, 0, 0))
                                    If _do_sounds Then My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
                                Catch ex As Exception
                                    If _do_sounds Then My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Hand)
                                End Try
                            End If
                        End If
                End Select
                ' Recent_Hide()
        End Select
        View_Draw(True)
    End Sub


    Private Sub _add2Recent(ByVal spath As String)
        _RecentFiles.Add(spath)
    End Sub

    Private Sub Recent_draw()
        _ofx.Clear(Me.TransparencyKey)

        Dim xx, yy, xs, ys As Integer
        xx = 0
        yy = 0
        For i = 0 To _RecentFiles.Count - 1


            Dim tempImg As Image = GetImageFromFile(_RecentFiles(i), _ritemSize.Width, _ritemSize.Height)
            xs = xx * _ritemSize.Width
            ys = yy * _ritemSize.Height

            _ofx.DrawImage(tempImg, xs + 2, ys + 2,
                           _ritemSize.Width - 4, _ritemSize.Height - 4)
            _ofx.FillRectangle(Brushes.Black, xs, ys, _ritemSize.Width, 20)
            _ofx.DrawRectangle(grid_pen, xs, ys,
                           _ritemSize.Width, _ritemSize.Height)

            _ofx.DrawString(i.ToString + "@" + IO.Path.GetFileNameWithoutExtension(_RecentFiles(i)),
                            Me.Font, Brushes.White,
                            xx * _ritemSize.Width, yy * _ritemSize.Height)

            tempImg.Dispose()
            xx = (xx + 1) Mod _rItemperRow
            If xx = 0 Then yy += 1
            ' yy = Int(i / _rItemperCol)
            ' If xx = _rItemperCol Then xx = 0
        Next

        '_ofx.DrawRectangle(_olpen, -_cpan.X - 5, -_cpan.Y - 5, _bsize.Width + 10, _bsize.Height + 10)
        '_ofx.DrawRectangle(grid_penY, _orect.X - 2 - _cpan.X, _orect.Y - 2 - _cpan.Y, _orect.Width + 4, _orect.Height + 4)
        '_ofx.DrawRectangle(grid_penX, _orect.X - 1 - _cpan.X, _orect.Y - 1 - _cpan.Y, _orect.Width + 2, _orect.Height + 2)
        '_ofx.DrawRectangle(grid_pen, _orect.X - _cpan.X, _orect.Y - _cpan.Y, _orect.Width, _orect.Height)

    End Sub

    Private Sub Recent_Show()
        If _altMode <> 0 Or Not _modeBig Or _RecentFiles.Count = 0 Then
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Exclamation)
            Exit Sub
        End If

        t_kp.Enabled = False
        Pallet_CloseDialog()
        my_canvas.Visible = False
        _altMode = 2
        _rItemperRow = Int(ScreenBounds.Width / _ritemSize.Width)
        _ofx = Me.CreateGraphics
        '   _RecentFiles.Clear()
        ' _RecentFiles.AddRange(_getQSFiles)
        Recent_draw()
    End Sub

    Private Sub Recent_Hide()
        _ofx.Dispose()
        _altMode = 0
        my_canvas.Visible = True
        t_kp.Enabled = True
        t_kp.Focus()
    End Sub


    Private Sub Anchor_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Pic_Anchor.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Middle Then ClearToolStripMenuItem_Click(Nothing, Nothing)
    End Sub
    Private Sub Anchor_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Pic_Anchor.MouseDoubleClick
        If e.Button = Windows.Forms.MouseButtons.Left Then SetMode(Not _modeBig, 0)
    End Sub
    Private Sub Anchor_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Pic_Anchor.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            _phmd = True
            _phpt = e.Location
        End If
    End Sub
    Private Sub Anchor_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Pic_Anchor.MouseUp
        If Not _phmd Then Exit Sub
        _AhnchorMouseUp(e.Location)
    End Sub
    Private Sub _AhnchorMouseUp(ByVal eLocation)
        Dim diffV As Point = eLocation - _phpt
        If _modeBig Then

            Dim tp As Point = Panel_Anchor.Location + diffV

            'Check X-Bounds
            If tp.X < 0 Then
                tp.X = 0
            ElseIf tp.X + Panel_Anchor.Width > WorkBounds.Width Then
                tp.X = WorkBounds.Width - Panel_Anchor.Width
            End If

            'CheckY-Bounds
            If tp.Y < 0 Then
                tp.Y = 0
            ElseIf tp.Y + Panel_Anchor.Height > WorkBounds.Height Then
                tp.Y = WorkBounds.Height - Panel_Anchor.Height
            End If

            Panel_Anchor.Location = New Point(tp.X Mod ScreenBounds.Width, tp.Y Mod ScreenBounds.Height)

        Else
            _DoSlide_Mode(diffV)
        End If
        _phmd = False
    End Sub
    Private Sub _DoSlide_Mode(ByVal DiffVector As Point)
        _unitV = New Point(DiffVector.X * 0.5,
                              DiffVector.Y * 0.5)
        time_AnchorSlide.Start()
    End Sub
    Private Sub time_AnchorSlide_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles time_AnchorSlide.Tick
        If Not _modeBig Then
            If Math.Abs(_unitV.X) > 0.1 Or Math.Abs(_unitV.Y) > 0.1 Then
                Me.Location = Me.Location + _unitV
                _unitV.X = (_unitV.X * 0.5)
                _unitV.Y = (_unitV.Y * 0.5)
                _smalPt = Me.Location
            Else
                time_AnchorSlide.Stop()
                _smalPt = Me.Location
            End If
        Else
            time_AnchorSlide.Stop()
        End If
    End Sub

    Private Sub Panel_Anchor_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Panel_Anchor.DragDrop
        drop_command(e.Data.GetData(Windows.Forms.DataFormats.FileDrop))
    End Sub

    Private Sub Panel_Anchor_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Panel_Anchor.DragEnter
        If e.Data.GetDataPresent(Windows.Forms.DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy ' (+) sign
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Public Sub drop_command(ByVal ress As String())
        If ress.Length = 0 Then Exit Sub
        If Not _modeBig Then SetMode(True, 0)
        If drop_file(ress(0)) Then
            View_Draw(True)
            If _do_sounds Then My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
        Else
            If _do_sounds Then My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Hand)
        End If
    End Sub


    Dim _mdcoord As Boolean = False
    Dim _ptcord As Point
    Private Sub coords_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label_coord.MouseDown
        Select Case e.Button
            Case Windows.Forms.MouseButtons.Left
                _mdcoord = True
                _ptcord = e.Location
        End Select

    End Sub
    Private Sub coords_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label_coord.MouseUp
        If Not _mdcoord Then Exit Sub
        Select Case e.Button
            Case Windows.Forms.MouseButtons.Left
                Panel_coords.Location = Panel_coords.Location + (e.Location - _ptcord)

        End Select
        _mdcoord = False
    End Sub
    Private Sub CordCopy2ClipToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CordCopy2ClipToolStripMenuItem.Click
        If _axis_points_pts.Count > 0 Then
            Dim cptxt As String = ""
            For i = 0 To _axis_points_pts.Count - 1
                cptxt += _axispt2str(i, ",") + Environment.NewLine
            Next
            My.Computer.Clipboard.SetText(cptxt)
            If _do_sounds Then My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
        Else
            If _do_sounds Then My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Exclamation)
        End If
    End Sub
    Private Function _axispt2str(ByVal axi As Integer, ByVal sepr As Char) As String
        Return _axis_points_pts(axi).X.ToString + sepr +
            _axis_points_pts(axi).Y.ToString + sepr +
            _axis_points_pens(axi).Color.ToArgb.ToString
    End Function
    Private Sub _str2axispt(ByVal ast As String, ByVal sepr As Char)
        Dim astS As String() = ast.Split(sepr)
        If ast.Length < 2 Then Exit Sub
        Dim ax, ay As Integer
        Dim az As Color = MyMarkerColor

        Try
            ax = Convert.ToInt32(astS(0))
            ay = Convert.ToInt32(astS(1))
            If astS.Length > 2 Then
                az = Color.FromArgb(Convert.ToInt32(astS(2)))
            End If
            _axis_points_pts.Add(New PointF(ax, ay))
            _axis_points_pens.Add(New Pen(az))

        Catch ex As Exception
        End Try

    End Sub

    Private Sub CordPastePointsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CordPastePointsToolStripMenuItem.Click
        If My.Computer.Clipboard.ContainsText Then
            Dim clpS As String() = My.Computer.Clipboard.GetText().Split(Environment.NewLine)
            For i = 0 To clpS.Length - 1
                _str2axispt(clpS(i), ",")
            Next
            If _isOpen Then View_Draw(False)
            If _do_sounds Then My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
        Else
            If _do_sounds Then My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Exclamation)
        End If
    End Sub


    Dim _mdWeb As Boolean
    Dim _mdWebPt As Point
    Private Sub Panel_web_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel_bottomW.MouseDown
        Select Case e.Button
            Case Windows.Forms.MouseButtons.Left
                _mdWeb = True
                _mdWebPt = e.Location
        End Select

    End Sub

    Private Sub Panel_web_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel_bottomW.MouseUp
        Panel_webber.Location = Panel_webber.Location + (e.Location - _mdWebPt)
        _mdWeb = False
    End Sub


    Private Sub RESIZEW_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel_cornorW.MouseDown
        Select Case e.Button
            Case Windows.Forms.MouseButtons.Left
                _mdtresize = True
                _mdtresizePt = e.Location
        End Select
    End Sub

    Private Sub RESIZEW_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel_cornorW.MouseUp
        Panel_webber.Size = (Panel_webber.Size - New Size(_mdtresizePt - e.Location))
        If Panel_webber.Size.Width < TextPanel_MinSize Then Panel_webber.Size = New Size(TextPanel_MinSize, Panel_webber.Size.Height)
        If Panel_webber.Size.Height < TextPanel_MinSize Then Panel_webber.Size = New Size(Panel_webber.Size.Width, TextPanel_MinSize)

        _mdtresize = False
    End Sub

    Private Sub BHideW_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_webClose.Click
        t_kp.Focus()
        Panel_webber.Visible = False
        View_Draw(False)
    End Sub

    Private Sub Button_webBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_webBrowse.Click
        If webFolder.ShowDialog = Windows.Forms.DialogResult.OK Then
            text_webaddr.Text = webFolder.SelectedPath
            _webGo()
        End If
    End Sub

    Private Sub _webGo()
        Try
            webber.Url = New Uri(text_webaddr.Text)
        Catch ex As Exception
            text_webaddr.Text = ""
            webber.Url = Nothing
        End Try

    End Sub

    Private Sub Button_webup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_webup.Click
        Try
            text_webaddr.Text = IO.Path.GetDirectoryName(text_webaddr.Text)
            _webGo()
        Catch ex As Exception
            If _do_sounds Then My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Hand)
        End Try

    End Sub

    Private Sub text_webaddr_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles text_webaddr.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                BHideW_Click(Nothing, Nothing)
            Case Keys.Enter
                If e.Control Then
                    text_webaddr.Text = "http://" + text_webaddr.Text
                Else
                    If e.Shift Then
                        text_webaddr.Text = "https://" + text_webaddr.Text
                    End If
                End If
                _webGo()
            Case Keys.Space
                If e.Control Then
                    e.SuppressKeyPress = True
                    View_Draw(False)
                End If
        End Select
    End Sub

    Private Sub CloseImageToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseImageToolStripMenuItem.Click
        _closeImage()
    End Sub
    Private Sub ResetCanvasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetCanvasToolStripMenuItem.Click
        setpage.RESTCanvas_Click(Nothing, Nothing)
    End Sub

    Private Sub ButtonWebGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonWebGo.Click
        _webGo()
    End Sub

    Private Sub webber_DocumentCompleted(ByVal sender As Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles webber.DocumentCompleted
        text_webaddr.Text = e.Url.AbsolutePath
    End Sub

    Private Sub ListBox_bmark_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ListBox_bmark.KeyDown
        If ListBox_bmark.SelectedIndex < 0 Then Exit Sub
        Select Case e.KeyCode
            Case Keys.Delete
                _SETTING_BOOKMARKS.CRUD_Delete(ListBox_bmark.SelectedIndex)
                ListBox_bmark.Items.Remove(ListBox_bmark.SelectedItem)
        End Select
    End Sub
    Private Sub ListBox_bmark_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBox_bmark.MouseDoubleClick
        If ListBox_bmark.SelectedIndex < 0 Then Exit Sub
        Select Case e.Button
            Case Windows.Forms.MouseButtons.Left
                text_webaddr.Text = ListBox_bmark.SelectedItem._path
                _webGo()

        End Select

    End Sub
    Private Sub Button_webAppdir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_webAppdir.Click

        Dim temp As New BookMarkItem(IO.Path.GetFileName(text_webaddr.Text),
                                                  text_webaddr.Text)
        ListBox_bmark.Items.Add(temp)
        _SETTING_BOOKMARKS.CRUD_Create(temp, False)
    End Sub



    Private Sub Check_showCoords_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Check_showCoords.CheckedChanged
        Panel_coords.Visible = Check_showCoords.Checked
    End Sub

    Private Sub B_webberShow_Click()
        If Panel_webber.Visible Then Exit Sub
        Panel_webber.Visible = True
        View_Draw(False)
        text_webaddr.Focus()
    End Sub

End Class
Public Structure BookMarkItem
    Dim _alias As String
    Dim _path As String
    Public Sub New(ByVal arg_alias As String, ByVal arg_path As String)
        _alias = arg_alias
        _path = arg_path
    End Sub
    Public Overrides Function ToString() As String
        Return _alias
    End Function
    Public Shared Function _2str(ByVal A As BookMarkItem) As String()
        Return {A._alias, A._path}
    End Function
    Public Shared Function _2obj(ByVal S As String()) As BookMarkItem
        Return New BookMarkItem(S(0), S(1))
    End Function
    Public Shared Function _compar(ByVal A As BookMarkItem, ByVal B As BookMarkItem) As Boolean
        If A._path.ToLower = B._path.ToLower Then
            Return True
        Else
            Return False
        End If
    End Function
End Structure