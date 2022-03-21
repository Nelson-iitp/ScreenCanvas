Public Class settings_page

    Friend _pxFNames As Array = [Enum].GetNames(GetType(System.Drawing.Imaging.PixelFormat))
    Friend _pxFVals As Array = [Enum].GetValues(GetType(System.Drawing.Imaging.PixelFormat))

    ReadOnly _helpLink As String = "https://spookyisgod.wordpress.com/screencanvas/"
    Dim cimgi As Integer    'required for animation
    '  TSTBPrefix.Text = _SETTING.iRead(_settings_types(28, 0))
    ' call back to parents
    Delegate Sub CallbackSP()

    Delegate Function CallbackTkey(ByVal C As Color) As Color
    Delegate Function CallbackSetIcon(ByVal iPATH As String, ByVal iIndex As Integer) As String
    Delegate Function CallbackExtendCanvas(ByVal XXX As Integer, ByVal YYY As Integer, ByVal DEX As Boolean) As String
    Dim _proxyCB As CallbackSP
    Dim _proxyTIP As CallbackSP
    Dim _proxyACB As CallbackSP
    Dim _proxySetTk As CallbackTkey
    Dim _proxySetIcon As CallbackSetIcon
    Dim _proxyCBE As CallbackExtendCanvas
    Dim _proxyPrefix As CallbackSP
    Dim _proxyICO As Image()
    Dim _proxyPixF As CallbackSP
    '  Dim _proxyPreviousPtext As String
    Dim _DoneBuilt As Boolean = False
    ' user calling
    Public Sub BuildMe(ByVal PIXFCB As CallbackSP,
                       ByVal PREFIXCB As CallbackSP,
                       ByVal SetTKCB As CallbackTkey,
                       ByVal SetIconCB As CallbackSetIcon,
                       ByVal SetAncSizeCB As CallbackSP,
                       ByVal TIPCB As CallbackSP,
                       ByVal CB As CallbackSP,
                       ByVal CBE As CallbackExtendCanvas,
                       ByVal ICO As Image(),
                       ByVal THSET As Object,
                       ByVal THSCHEMA As Object(,))

        Dim _SETTING_proxy As HoDOfObject = THSET


        NUD_maxUndo.Value = _SETTING_proxy.iRead(THSCHEMA(7, 0))
        _proxyCB = CB
        _proxyCBE = CBE
        _proxyICO = ICO
        _proxyTIP = TIPCB
        _proxySetTk = SetTKCB
        _proxySetIcon = SetIconCB
        _proxyACB = SetAncSizeCB
        _proxyPrefix = PREFIXCB
        _proxyPixF = PIXFCB
        nud_canvasX.Value = _SETTING_proxy.iRead(THSCHEMA(13, 0)).X
        nud_canvasY.Value = _SETTING_proxy.iRead(THSCHEMA(13, 0)).Y
        ' CheckBox_nosavedialog.Checked = _SETTING_proxy.iRead(THSCHEMA(14, 0)) '<<<<<< unsed setting
        Label12.Text = _SETTING_proxy.iRead(THSCHEMA(15, 0))
        Check_tooltips.Checked = _SETTING_proxy.iRead(THSCHEMA(18, 0))
        ' LabelTSFpreview.Font = _SETTING_proxy.iRead(THSCHEMA(19, 0))
        L_SetTkey.BackColor = _SETTING_proxy.iRead(THSCHEMA(23, 0))
        Check_sDate.Checked = _SETTING_proxy.iRead(THSCHEMA(20, 0))
        Check_sTime.Checked = _SETTING_proxy.iRead(THSCHEMA(21, 0))
        Check_HideAnchr.Checked = _SETTING_proxy.iRead(THSCHEMA(32, 0))
        nud_anchorW.Value = _SETTING_proxy.iRead(THSCHEMA(24, 0)).Width
        nud_anchorH.Value = _SETTING_proxy.iRead(THSCHEMA(24, 0)).Height
        L_pathG.Text = _SETTING_proxy.iRead(THSCHEMA(25, 0))
        L_pathR.Text = _SETTING_proxy.iRead(THSCHEMA(26, 0))
        L_pathY.Text = _SETTING_proxy.iRead(THSCHEMA(27, 0))
        TSTBPrefixS.Text = _SETTING_proxy.iRead(THSCHEMA(28, 0))
        Combo_pixFormat.DataSource = _pxFNames
        Dim jkl As Drawing.Imaging.PixelFormat = _SETTING_proxy.iRead(THSCHEMA(34, 0))
        Combo_pixFormat.SelectedIndex = Array.IndexOf(_pxFVals, jkl)
        '@~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        Label2.Text += "v." + My.Application.Info.Version.ToString
        _DoneBuilt = True
    End Sub
    Public Function ShowCustomDialog(ByVal owner As Windows.Forms.IWin32Window, ByVal curr_imgC As Integer, ByVal curr_imgSize As Size, ByVal enable_resize As Boolean) As DialogResult
        Label_imgC.Text = curr_imgC.ToString
        Label8.Text = curr_imgSize.Width.ToString + " x " + curr_imgSize.Height.ToString
        Panel1.Enabled = enable_resize
        _DoneBuilt = False
        ' Combo_pixFormat.SelectedIndex = Array.IndexOf(_pxFVals, curr_Pixf)
        _DoneBuilt = True
        Return Me.ShowDialog(owner)
    End Function

    'load-close
    Private Sub settings_page_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Timer1.Stop()
        _proxyPrefix.Invoke()
    End Sub
    Private Sub settings_page_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        cimgi = 0
        Me.PictureBoxicon.Image = _proxyICO(0)
        Timer1.Start()
    End Sub

    'animation
    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        cimgi = (cimgi + 1) Mod 3
        Me.PictureBoxicon.Image = _proxyICO(cimgi)
        RefDateStr()
    End Sub
    Private Sub PictureBoxicon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        Process.Start(_helpLink)
    End Sub

    ' canvas related
    Friend Sub b_XAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_XAdd.Click
        Label8.Text = _proxyCBE(nud_canvasX.Value, 0, False)
    End Sub
    Friend Sub b_XSub_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_XSub.Click
        Label8.Text = _proxyCBE(-nud_canvasX.Value, 0, False)
    End Sub
    Friend Sub b_YAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_YAdd.Click
        Label8.Text = _proxyCBE(0, nud_canvasY.Value, False)
    End Sub
    Friend Sub b_YSub_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_YSub.Click
        Label8.Text = _proxyCBE(0, -nud_canvasY.Value, False)
    End Sub
    Friend Sub RESTCanvas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_setSize.Click
        Label8.Text = _proxyCBE(nud_canvasX.Value, nud_canvasY.Value, True)
    End Sub
    Private Sub CopyScreensize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WorkingAreaToolStripMenuItem.Click
        nud_canvasX.Value = My.Computer.Screen.WorkingArea.Width
        nud_canvasY.Value = My.Computer.Screen.WorkingArea.Height
    End Sub
    Private Sub ScreenBoundsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ScreenBoundsToolStripMenuItem.Click
        nud_canvasX.Value = My.Computer.Screen.Bounds.Width
        nud_canvasY.Value = My.Computer.Screen.Bounds.Height
    End Sub

    'stack clearing
    Private Sub LabelClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label_imgC.Click
        If MsgBox("Clear Action Stack?", vbYesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
            _proxyCB.Invoke()
        End If
    End Sub

    ' quicksave related
    Private Sub Label12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label12.Click
        OpenInExplorerToolStripMenuItem_Click(Nothing, Nothing)
    End Sub
    Private Sub ChangePathToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangePathToolStripMenuItem.Click
        FolderBrowserDialog1.SelectedPath = Label12.Text
        If FolderBrowserDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Label12.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub
    Private Sub CopyPathToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyPathToolStripMenuItem.Click
        My.Computer.Clipboard.SetText(Label12.Text)
        My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
    End Sub
    Private Sub OpenInExplorerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenInExplorerToolStripMenuItem.Click
        If My.Computer.FileSystem.DirectoryExists(Label12.Text) Then
            Process.Start(Label12.Text)
        Else
            MsgBox("Folder does not exist: " + Label12.Text, vbCritical)
        End If
    End Sub

    Private Sub RefDateStr()
        Dim _dtN As DateTime = DateTime.Now
        Dim _dTS As String

        If Check_sDate.Checked Then
            _dTS = _dtN.ToShortDateString + " | "
        Else
            _dTS = _dtN.ToLongDateString + " | "
        End If

        If Check_sTime.Checked Then
            _dTS += _dtN.ToShortTimeString
        Else
            _dTS += _dtN.ToLongTimeString
        End If
        '  LabelTSFpreview.Text = _dTS
    End Sub
    Private Sub SetTkey_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles L_SetTkey.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Left Then
            ColorDialog1.Color = L_SetTkey.BackColor
            If ColorDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                If L_SetTkey.BackColor = ColorDialog1.Color Then Exit Sub
                L_SetTkey.BackColor = _proxySetTk(ColorDialog1.Color)
            End If
        ElseIf e.Button = Windows.Forms.MouseButtons.Right Then
            If L_SetTkey.BackColor = _appDefTkey Then Exit Sub

            If MsgBox("Reset Transparency Key to App Default?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                L_SetTkey.BackColor = _proxySetTk(_appDefTkey)
            End If
        End If
    End Sub

    Private Sub X_pathR_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles L_pathG.MouseClick, L_pathR.MouseClick, L_pathY.MouseClick
        Select Case e.Button

            Case Windows.Forms.MouseButtons.Left
                If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                    If sender.Text <> OpenFileDialog1.FileName Then
                        sender.Text = _proxySetIcon(OpenFileDialog1.FileName, sender.Tag)
                    End If
                End If
            Case Windows.Forms.MouseButtons.Right
                Dim de_ico As String = iconDir + "\" + sender.Tag.ToString + ".ico"
                If sender.Text <> de_ico Then
                    sender.Text = de_ico
                    sender.Text = _proxySetIcon(de_ico, sender.Tag)
                End If
            Case Windows.Forms.MouseButtons.Middle
                'copy or open in explorer?
                My.Computer.Clipboard.SetText(sender.Text)
        End Select
    End Sub

    ' Anchor Related
    Private Sub nud_anchor_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nud_anchorW.ValueChanged, nud_anchorH.ValueChanged
        If _DoneBuilt Then _proxyACB()
    End Sub
    Private Sub Label4_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label4.MouseDoubleClick
        _DoneBuilt = False
        nud_anchorH.Value = 64
        _DoneBuilt = True
        nud_anchorW.Value = 64
    End Sub


    Private Sub Combo_pixFormat_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Combo_pixFormat.SelectedIndexChanged
        If _DoneBuilt Then _proxyPixF.Invoke()
    End Sub
End Class


