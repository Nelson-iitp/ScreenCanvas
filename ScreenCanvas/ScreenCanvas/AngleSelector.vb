Public Class AngleSelector

    Dim es_pi As Single = Math.PI
    Dim gMidpt As PointF

    Dim _iAngle As Single = 0
    Public ReadOnly Property CurrentAngle As Single
        Get
            Return _iAngle
        End Get
    End Property
    Public Sub SetCurrentAngle(ByVal value As Single, ByVal CallPaint As Boolean)
        If value < 0 Then
            _iAngle = 0
        ElseIf value >= 360 Then
            _iAngle = 360
        Else
            _iAngle = value
        End If

        If CallPaint Then
            PaintCall(Me.CreateGraphics)
        End If

    End Sub

    Dim _iSmallChange As Single = 1
    Public Property SmallChange As Single
        Get
            Return _iSmallChange
        End Get
        Set(ByVal value As Single)
            _iSmallChange = value
        End Set
    End Property
    Dim _iLargeChange As Single = 10
    Public Property LargeChange As Single
        Get
            Return _iLargeChange
        End Get
        Set(ByVal value As Single)
            _iLargeChange = value
        End Set
    End Property
    Dim _iHugeChange As Single = 45
    Public Property HugeChange As Single
        Get
            Return _iHugeChange
        End Get
        Set(ByVal value As Single)
            _iHugeChange = value
        End Set
    End Property

    Dim _dialMode As Boolean = False
    Public Property DialMode As Boolean
        Get
            Return _dialMode
        End Get
        Set(ByVal value As Boolean)
            _dialMode = value
        End Set
    End Property

    Dim _JokeyPad As Single = 4
    Dim _forebrush, _backbrush As Brush
    Public Overrides Property ForeColor As System.Drawing.Color
        Get
            Return MyBase.ForeColor
        End Get
        Set(ByVal value As System.Drawing.Color)
            MyBase.ForeColor = value
            _forebrush = New SolidBrush(value)
        End Set
    End Property
    Public Overrides Property BackColor As System.Drawing.Color
        Get
            Return MyBase.BackColor
        End Get
        Set(ByVal value As System.Drawing.Color)
            MyBase.BackColor = value
            _backbrush = New SolidBrush(value)
        End Set
    End Property
    Private Sub PaintCall(ByVal gfx As Graphics)

        'gfx.Clear(Me.BackColor)
        ' gfx.DrawString(_iAngle.ToString, Me.Font, Brushes.BlueViolet, 0, 0)
        If _dialMode Then
            gfx.FillPie(_forebrush, Me.DisplayRectangle, _iAngle - _JokeyPad, 2 * _JokeyPad)
            gfx.FillPie(_backbrush, Me.DisplayRectangle, _iAngle - _JokeyPad, -(360 - 2 * _JokeyPad))
            ' gfx.DrawEllipse(Pens.Black, Me.DisplayRectangle)
        Else
            gfx.FillPie(_forebrush, Me.DisplayRectangle, 0, _iAngle)
            gfx.FillPie(_backbrush, Me.DisplayRectangle, 0, -(360 - _iAngle))
        End If
        gfx.DrawEllipse(Pens.Black, Me.DisplayRectangle)
        ' gfx.DrawEllipse(Pens.SpringGreen, gMidpt.X - 5, gMidpt.Y - 5, 10, 10)
        '  gfx.DrawPie(Pens.WhiteSmoke, 0, 0, Me.Width, Me.Height, 0, 2 * es_pi - _iAngle)
    End Sub

    Private Sub AngleSelector_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        PaintCall(e.Graphics)
    End Sub
    Private Sub AngleSelector_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ForeColor = ForeColor
        BackColor = BackColor
    End Sub

    'mouse events
    Private Function modvec(ByVal V As PointF) As Single
        Return Math.Sqrt(V.X * V.X + V.Y * V.Y)
    End Function
    Private Function _anglebw(ByVal A As PointF, ByVal B As PointF) As Single
        'a.b = |a|.|b|.cos0
        Return Math.Acos((A.X * B.X + A.Y * B.Y) / (modvec(A) * modvec(B)))
    End Function
    Private Function diffvec(ByVal A As PointF, ByVal B As PointF) As PointF
        Return New PointF(A.X - B.X, A.Y - B.Y)
    End Function
    Private Sub AngleSelector_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseClick
        gMidpt = New PointF(Me.Width / 2, Me.Height / 2)

        Dim _angleis As Single = _anglebw(diffvec(e.Location, gMidpt), New Point(1, 0)) * 180 / Math.PI
        If e.Location.Y < gMidpt.Y Then _angleis = (360 - _angleis)
        SetCurrentAngle(_angleis, True)
    End Sub
    Private Sub AngleSelector_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDoubleClick
        Select Case e.Button
            Case Windows.Forms.MouseButtons.Left
                text_inputAngle.Text = _iAngle.ToString
                text_inputAngle.Visible = True
                text_inputAngle.Focus()
        End Select
    End Sub

    Private Sub text_inputAngle_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles text_inputAngle.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                text_inputAngle.Visible = False
                PaintCall(Me.CreateGraphics)
                Me.Focus()
            Case Keys.Enter
                Try
                    SetCurrentAngle(Convert.ToSingle(text_inputAngle.Text), False)
                Catch ex As Exception
                    text_inputAngle.Text = _iAngle.ToString
                End Try
                text_inputAngle.Visible = False
                PaintCall(Me.CreateGraphics)
                Me.Focus()
        End Select
    End Sub

End Class
