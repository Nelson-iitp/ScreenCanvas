Module ImageEditorCore
    Public Const APPUID As String = "ScreenCanvas"
    Public ReadOnly _appDefTkey As Color = Color.FromArgb(223, 224, 225)
    Public ReadOnly DATA_DIR As String = My.Application.Info.DirectoryPath + "\" + APPUID + "_data"
    Public ReadOnly _config_file As String = DATA_DIR + "\config.ini"
    Public ReadOnly _color_file As String = DATA_DIR + "\color.ini"
    Public ReadOnly _bmark_file As String = DATA_DIR + "\bmark.ini"
    ' cursors array
    Public ReadOnly cursorDir As String = DATA_DIR + "\_cursors"
    Public ReadOnly iconDir As String = DATA_DIR + "\_icons"

    Public Enum EditorTool As Integer
        iPointer = 0 '
        iMarker = 1 '

        iLine = 2 '
        iRectangle = 3 '
        iEllipse = 4 '
        iGraph = 5 '
        iCircleDia = 6 '
        iTable = 7 '
        iPath = 8 '

        iAxisMarker = 9 '
        iImagePaste = 10
        iImagePasteR = 11
        iImageCopy = 12
        iScreenCopy = 13

        iEraser = 14

        iCalligraphy = 15

        iColorPick = 16

        iImageCut = 17
        iDateTime = 18
        iText = 19
        iSelectR = 20
        iCustomPen = 21

    End Enum
    Public Function ValidFilename(ByVal fsna As String) As Boolean
        ValidFilename = False
        If fsna = "" Then Exit Function
        If fsna.Contains("\") Or fsna.Contains("/") Or fsna.Contains(":") Or fsna.Contains("*") Or
            fsna.Contains("?") Or fsna.Contains("""") Or fsna.Contains("<") Or fsna.Contains(">") Or fsna.Contains("|") Then
            Exit Function
        End If
        ValidFilename = True
    End Function
    '~ Sperators those can be used ~~~~~~~~~~~~~~~~~~~~~~~~~~
    Public Const sep_meta As Char = Chr(31) 'unit seperator 
    Public Const sep_rows As Char = Chr(30) 'record seperator
    Public Const sep_cols As Char = Chr(29) 'group seperator
    Public Const sep_list As Char = Chr(28) 'file seperator
    Public Const sep_keys As Char = Chr(24) 'dev control 1
    Public Const SEP_6 As Char = Chr(23) 'dev control 2
    Public Const SEP_7 As Char = Chr(22) 'dev control 3
    Public Const SEP_8 As Char = Chr(21) 'dev control 4
    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

#Region "' Point Transform '"

    Public Function RotatePoint(ByVal a As PointF, ByVal wrt As PointF, ByVal th As Single) As PointF
        Return New PointF(((a.X - wrt.X) * Math.Cos(th) - (a.Y - wrt.Y) * Math.Sin(th)) + wrt.X, ((a.Y - wrt.Y) * Math.Cos(th) + (a.X - wrt.X) * Math.Sin(th)) + wrt.Y)
    End Function

    Public Function Point_st_Rdis_th(ByVal P As PointF, ByVal th As Single, ByVal r As Single) As PointF()
        Return Point_st_Rdis_tanth(P, Math.Tan(th), r)
    End Function

    Public Function Point_st_Rdis_tanth(ByVal P As PointF, ByVal tanth As Single, ByVal r As Single) As PointF()
        If Single.IsInfinity(tanth) Or Single.IsNaN(tanth) Then Return {New PointF(P.X, P.Y + r), New PointF(P.X, P.Y - r)}
        Dim k As Single = r / Math.Pow(1 + tanth * tanth, 0.5)
        Return {New PointF(P.X + k, P.Y + k * tanth), New PointF(P.X - k, P.Y - k * tanth)}
    End Function

#End Region

#Region "' HSL-RGB '"

    Public Function RGB_HSL(ByVal rgb As Color) As Single()
        Dim r As Byte = rgb.R
        Dim g As Byte = rgb.G
        Dim b As Byte = rgb.B
        Dim h, s, l As Single

        Dim var_R As Single = (r / 255)
        Dim var_G As Single = (g / 255)
        Dim var_B As Single = (b / 255)

        Dim var_Min As Single = Math.Min(Math.Min(var_R, var_G), var_B)    '//Min. value of RGB
        Dim var_Max As Single = Math.Max(Math.Max(var_R, var_G), var_B)     '//Max. value of RGB
        Dim del_Max As Single = var_Max - var_Min                      '//Delta RGB value

        l = (var_Max + var_Min) / 2

        If (del_Max = 0) Then
            h = 0
            s = 0
        Else
            '===========
            If (l < 0.5) Then
                s = del_Max / (var_Max + var_Min)
            Else
                s = del_Max / (2 - var_Max - var_Min)
            End If

            Dim del_R = (((var_Max - var_R) / 6) + (del_Max / 2)) / del_Max
            Dim del_G = (((var_Max - var_G) / 6) + (del_Max / 2)) / del_Max
            Dim del_B = (((var_Max - var_B) / 6) + (del_Max / 2)) / del_Max

            If (var_R = var_Max) Then
                h = del_B - del_G
            ElseIf (var_G = var_Max) Then
                h = (1 / 3) + del_R - del_B
            ElseIf (var_B = var_Max) Then
                h = (2 / 3) + del_G - del_R
            End If

            If (h < 0) Then h += 1
            If (h > 1) Then h -= 1
            '=========
        End If

        Return {h, s, l}
    End Function
    Public Function HSL_RGB(ByVal h As Single, ByVal s As Single, ByVal l As Single) As Color
        Dim r, g, b As Byte
        Dim var_1, var_2 As Single
        If s = 0 Then
            r = l * 255
            g = l * 255
            b = l * 255

        Else
            If (l < 0.5) Then
                var_2 = l * (1 + s)
            Else
                var_2 = (l + s) - (s * l)
            End If

            var_1 = 2 * l - var_2
            r = 255 * Hue_2_RGB(var_1, var_2, h + (1 / 3))
            g = 255 * Hue_2_RGB(var_1, var_2, h)
            b = 255 * Hue_2_RGB(var_1, var_2, h - (1 / 3))

        End If
        Return Color.FromArgb(r, g, b)
    End Function
    Public Function Hue_2_RGB(ByVal v1 As Single, ByVal v2 As Single, ByVal vH As Single) As Single          ' //Function Hue_2_RGB
        If (vH < 0) Then vH += 1
        If (vH > 1) Then vH -= 1
        If ((6 * vH) < 1) Then Return (v1 + (v2 - v1) * 6 * vH)
        If ((2 * vH) < 1) Then Return (v2)
        If ((3 * vH) < 2) Then Return (v1 + (v2 - v1) * ((2 / 3) - vH) * 6)
        Return (v1)
    End Function

#End Region

#Region "' Color2String Delegates '"

    Public Function STR_2_COL(ByVal args As String()) As Color
        Return Color.FromArgb(Convert.ToInt32(args(0)))
    End Function
    Public Function COL_2_STR(ByVal field_col As Color) As String()
        Return {field_col.ToArgb.ToString}
    End Function
    Public Function COMPAR_COL(ByVal v1 As Color, ByVal v2 As Color) As Boolean
        If (v1 = v2) Then
            Return True
        Else
            Return False
        End If
    End Function

#End Region

#Region "' Disk IO '"

    Public Function GetImageFromFile(ByVal path As String, ByVal newW As Integer, ByVal newH As Integer) As Bitmap
        'sure exsists
        Try
            Dim res As Image = Image.FromFile(path)
            Dim newB As Bitmap
            If newH <= 0 Then newH = res.Height
            If newW <= 0 Then newW = res.Width
            newB = New Bitmap(newW, newH)
            Dim newG As Graphics = Graphics.FromImage(newB)
            newG.DrawImage(res, 0, 0, newW, newH)
            newG.Dispose()
            res.Dispose()
            GetImageFromFile = newB
        Catch ex As Exception
            GetImageFromFile = Nothing
        End Try
    End Function

    Public Class ListOnDisk(Of T)

        Delegate Function Conv2T(ByVal input_S As String()) As T
        Delegate Function Conv2S(ByVal input_T As T) As String()
        Delegate Function ComparT(ByVal T1 As T, ByVal T2 As T) As Boolean

        Dim _T2S As Conv2S
        Dim _S2T As Conv2T
        Dim _isdup As ComparT

        Dim _sep_col As Char
        Dim _sep_row As Char

        Dim _path As String
        Public ReadOnly Property MyDirectoryName As String
            Get
                Return _path.Remove(_path.LastIndexOf("\"))
            End Get
        End Property
        Public ReadOnly Property MyFileName As String
            Get
                Return _path.Substring(_path.LastIndexOf("\") + 1)
            End Get
        End Property

        Dim _isloaded As Boolean
        Public ReadOnly Property IsLoaded As Boolean
            Get
                Return _isloaded
            End Get
        End Property

        ' real time check for existance
        Public ReadOnly Property ExistOnDisk() As Boolean
            Get
                Return My.Computer.FileSystem.FileExists(_path)
            End Get
        End Property

        Dim _list As List(Of T)
        '   Dim _slist As List(Of String())
        Public ReadOnly Property RowCount As Integer
            Get
                Return _list.Count
            End Get
        End Property

        Dim _ismetadirty As Boolean
        Dim _xlist As List(Of String)
        Public ReadOnly Property MetaCount As Integer ' 0 to CountAux-1 are auxlist
            Get
                Return _xlist.Count
            End Get
        End Property

#Region "' Init and IO "

        Public Sub New(ByVal list_path As String, ByVal do_load As Boolean, ByVal my_row_sep As Char, ByVal my_col_sep As Char, ByVal my_T2S As Conv2S, ByVal my_S2T As Conv2T, ByVal my_isdup As ComparT)

            _isloaded = False

            If my_col_sep = my_row_sep Then
                Err.Raise(vbObject + 554, , "Different Row and Col Sperator required!")
                Exit Sub
            End If

            _xlist = New List(Of String)
            _list = New List(Of T)
            '_slist = New List(Of String())

            _path = list_path
            _sep_col = my_col_sep
            _sep_row = my_row_sep
            _T2S = my_T2S
            _S2T = my_S2T
            _isdup = my_isdup
            If do_load Then Load() '#<---- First Load
        End Sub

        Public Sub Load()
            If ExistOnDisk() Then
                _isloaded = ForceLoad()
            Else
                _isloaded = False
                _ismetadirty = True
            End If
        End Sub
        Private Function ForceLoad() As Boolean
            ' try to read the file
            Dim rr As IO.FileStream = Nothing
            Try

                rr = New IO.FileStream(_path, IO.FileMode.Open, IO.FileAccess.Read)
                CRUD_DeleteAll() ' clear list only after file was opened
                mCRUD_DeleteAll()
                'Dim auxer As Integer = 0
                If rr.Length > 0 Then

                    'read full file
                    Dim read_byte As Byte() = Array.CreateInstance(GetType(Byte), rr.Length)
                    rr.Read(read_byte, 0, rr.Length)
                    Dim read_rows As String() = System.Text.UnicodeEncoding.Unicode.GetString(read_byte).Split(_sep_row)

                    'read 1st row
                    Dim read_cols As String() = read_rows(0).Split(_sep_col)
                    For i = 0 To read_cols.Length - 1
                        _xlist.Add(read_cols(i))
                    Next

                    'read rest rows
                    For i = 1 To read_rows.Length - 1
                        read_cols = read_rows(i).Split(_sep_col)
                        'If read_cols.Length <> ColCount Then Continue For ' dont'read lines with any lesser col count
                        ' _slist.Add(read_cols)
                        _list.Add(_S2T(read_cols))
                    Next

                Else
                    'completely blank file
                End If
                _ismetadirty = False
                ForceLoad = True
            Catch ex As Exception
                ' _isdirty = True
                ForceLoad = False
            Finally
                If Not IsNothing(rr) Then
                    rr.Close()
                    rr.Dispose()
                End If
            End Try
        End Function

        Public Sub Save()

            Dim rw As IO.FileStream = Nothing
            Try
                rw = New IO.FileStream(_path, IO.FileMode.Create, IO.FileAccess.Write) 'open if exsist otherwise create

                Dim filestr As String = ""
                For i = 0 To MetaCount - 1
                    filestr += _xlist(i) + _sep_col
                Next
                If MetaCount > 0 Then filestr = filestr.Remove(filestr.Length - 1)
                filestr += _sep_row

                For i = 0 To _list.Count - 1
                    Dim rowStr As String = ""
                    Dim rowStrA As String() = _T2S(_list(i))
                    For j = 0 To rowStrA.Length - 1
                        rowStr += rowStrA(j) + _sep_col
                    Next
                    rowStr = rowStr.Remove(rowStr.Length - 1)
                    rowStr += _sep_row

                    filestr += rowStr
                Next
                'If RowCount > 0 Then filestr = filestr.Remove(filestr.Length - 1)
                filestr = filestr.Remove(filestr.Length - 1)

                Dim byts As Byte() = System.Text.UnicodeEncoding.Unicode.GetBytes(filestr)
                rw.Write(byts, 0, byts.Length)
            Catch ex As Exception
                'do nothing
            Finally
                If Not IsNothing(rw) Then
                    rw.Close()
                    rw.Dispose()
                End If
            End Try
        End Sub

#End Region

#Region "' DATA CRUD "

        Public Function CRUD_Create(ByVal s As T, ByVal chk_dup As Boolean) As Integer
            'create append
            ' If s.Length < ColCount Then Return False
            Return CRUD_Create(RowCount, s, chk_dup)
        End Function
        Public Function CRUD_Create(ByVal inat As Integer, ByVal ss As T, ByVal chk_dup As Boolean) As Integer
            'create insert
            CRUD_Create = -1
            If inat < 0 Or inat > RowCount Then Exit Function
            ' If s.Length <> ColCount Then Exit Function
            Dim s As String() = _T2S(ss)
            Dim has_duplicate As Boolean = False
            If chk_dup Then
                'check only duplicates 
                For i = 0 To RowCount - 1
                    If _isdup(_list(i), ss) Then
                        has_duplicate = True
                        CRUD_Create = i
                        Exit For
                    End If
                Next
            End If

            If Not has_duplicate Then
                _list.Insert(inat, ss)
                CRUD_Create = inat  ' no duplicates, inserted true = return index at which inserted
            End If
            'if has duplicates then returns the index of first duplicate - inseted false

        End Function
        Public Function CRUD_Read(ByVal r As Integer) As T
            'read-copy row from main - returns a copy

            If r < 0 Then
                If r < -RowCount Then
                    Err.Raise(vbObjectError + 555, , "Index out of bounds")
                    Return Nothing
                Else
                    Return _list(r)
                End If
            Else 'r>=0
                If r < RowCount Then
                    Return _list(r)
                Else
                    Err.Raise(vbObjectError + 555, , "Index out of bounds")
                    Return Nothing
                End If
            End If
        End Function
        Public Sub CRUD_Update(ByVal r As Integer, ByVal value As T, ByVal chk_dup As Boolean)
            If r < 0 Then
                If r < -RowCount Then
                    Err.Raise(vbObjectError + 555, , "Index out of bounds")
                    Exit Sub
                End If
            Else 'r>=0
                If r >= RowCount Then
                    Err.Raise(vbObjectError + 555, , "Index out of bounds")
                    Exit Sub
                End If
            End If

            Dim has_duplicate As Boolean = False

            If chk_dup Then
                'check only duplicates 
                For i = 0 To RowCount - 1
                    If _isdup(_list(i), value) Then
                        has_duplicate = True
                        Exit For
                    End If
                Next
            End If

            If Not has_duplicate Then
                _list(r) = value
            End If
        End Sub
        Public Sub CRUD_Delete(ByVal r As Integer)
            If r < 0 Or r >= RowCount Then Exit Sub
            _list.RemoveAt(r)
            ' _isdirty = True
        End Sub
        Public Sub CRUD_DeleteAll()
            If RowCount > 0 Then
                _list.Clear()
                '  _isdirty = True
            End If
        End Sub

#End Region

#Region "' AUX/META CRUD "

        Public Sub mCRUD_Create(ByVal value As String, ByVal chk_dup As Boolean)
            mCRUD_Create(MetaCount, value, chk_dup)
        End Sub
        Public Sub mCRUD_Create(ByVal i As Integer, ByVal value As String, ByVal chk_dup As Boolean)
            If chk_dup Then If _xlist.Contains(value) Then Exit Sub
            _xlist.Insert(i, value)
            _ismetadirty = True
        End Sub
        Public Function mCRUD_Read(ByVal i As Integer) As String
            Return _xlist(i)
        End Function
        Public Sub mCRUD_Update(ByVal i As Integer, ByVal value As String, ByVal chk_dup As Boolean)
            If i < 0 Or i >= MetaCount Then Exit Sub
            If chk_dup Then If _xlist.Contains(value) Then Exit Sub
            _xlist(i) = value
            _ismetadirty = True
        End Sub
        Public Sub mCRUD_Delete(ByVal r As Integer)
            If r < 0 Or r >= MetaCount Then Exit Sub
            _xlist.RemoveAt(r)
            _ismetadirty = True
        End Sub
        Public Sub mCRUD_DeleteAll()
            If MetaCount > 0 Then
                _xlist.Clear()
                _ismetadirty = True
            End If
        End Sub

#End Region

    End Class

    Public Class HoDOfObject


#Region "Delegates"

        Delegate Function _S2O(ByVal S As String(), ByVal HODT As HoDtype) As Object
        Dim _default_S2O As _S2O

        Delegate Function _O2S(ByVal O As Object, ByVal HODT As HoDtype) As String()
        Dim _default_O2S As _O2S

#End Region

#Region "Vars"

        ' Seperators -----------------------------------------------------
        Dim _sep_meta As Char
        Public ReadOnly Property MyMetaSep As Char
            Get
                Return _sep_meta
            End Get
        End Property
        Dim _sep_col As Char
        Public ReadOnly Property MyColSep As Char
            Get
                Return _sep_col
            End Get
        End Property
        Dim _sep_row As Char
        Public ReadOnly Property MyRowSep As Char
            Get
                Return _sep_row
            End Get
        End Property
        Dim _sep_key As Char
        Public ReadOnly Property MyKeySep As Char
            Get
                Return _sep_key
            End Get
        End Property

        ' File path info  -----------------------------------------------------
        Dim _path As String
        Public ReadOnly Property MyFullPath As String
            Get
                Return _path
            End Get
        End Property
        Public ReadOnly Property MyDirectoryName As String
            Get
                If IsLoaded Then
                    Return _path.Remove(_path.LastIndexOf("\"))
                Else
                    Return ":NotLoaded:"
                End If

            End Get
        End Property
        Public ReadOnly Property MyFileName As String
            Get
                If IsLoaded Then
                    Return _path.Substring(_path.LastIndexOf("\") + 1)
                Else
                    Return ":NotLoaded:"
                End If

            End Get

        End Property
        Public ReadOnly Property ExistOnDisk() As Boolean
            Get 'real time check for existance 
                Return My.Computer.FileSystem.FileExists(_path)
            End Get
        End Property

        ' Flags -----------------------------------------------------
        Dim _isloaded As Boolean
        Public ReadOnly Property IsLoaded As Boolean
            Get
                Return _isloaded
            End Get
        End Property

        ' Data Lists -----------------------------------------------------
        Dim _list As Dictionary(Of String, Object) '<<--- the main list
        Public ReadOnly Property MainCount As Integer
            Get
                Return _list.Count
            End Get
        End Property
        ''' <summary>
        ''' Main List - Exposes Inner List (Of T)
        ''' </summary>
        ''' <value></value>
        ''' <returns>Inner Hashset (of T)</returns>
        ''' <remarks>Can be directly modified in code or use CRUD functions provided</remarks>
        Public ReadOnly Property zHash As Dictionary(Of String, Object)
            Get
                Return _list
            End Get
        End Property

        Dim _xlist As List(Of String) '<<--- the meta list
        Public ReadOnly Property MetaCount As Integer ' 0 to CountAux-1 are auxlist
            Get
                Return _xlist.Count
            End Get
        End Property
        ''' <summary>
        ''' Meta List - Exposes Inner List (Of String)
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public ReadOnly Property zMList As List(Of String)
            Get
                Return _xlist
            End Get
        End Property

        ''' <summary>
        ''' Clear both the meta and the main list
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub zClearAll()
            iDeleteAll()
            miDeleteAll()
        End Sub

#End Region

#Region "' NEW and IO "

        Public Sub New(ByVal hash_path As String,
                       ByVal my_row_sep As Char,
                       ByVal my_col_sep As Char,
                       ByVal my_meta_sep As Char,
                       ByVal my_key_sep As Char,
                       ByVal my_def_S2O As _S2O,
                       ByVal my_def_O2S As _O2S)
            _isloaded = False

            If my_col_sep = my_row_sep Then
                Err.Raise(vbObject + 554, , "Different Row and Col Sperator required!")
                Exit Sub
            End If

            _xlist = New List(Of String)
            _list = New Dictionary(Of String, Object)

            _path = hash_path
            _sep_col = my_col_sep
            _sep_row = my_row_sep
            _sep_meta = my_meta_sep
            _sep_key = my_key_sep

            _default_O2S = my_def_O2S
            _default_S2O = my_def_S2O

            ' If do_load Then ForceLoad()
        End Sub

        Public Function ForceSave(ByVal _schema As Array) As Boolean
            ForceSave = False
            Dim rw As IO.FileStream = Nothing
            Try
                rw = New IO.FileStream(_path, IO.FileMode.Create, IO.FileAccess.Write) 'open if exsist otherwise create


                '@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
                '/META PART///////////////////////////////////////////////////////////////
                '@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
                Dim meta_string As String = ""
                For i = 0 To MetaCount - 1
                    meta_string += _xlist(i) + _sep_col
                Next

                '@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
                '/LIST PART///////////////////////////////////////////////////////////////
                '@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
                Dim list_string As String = ""
                For Each i As String In _list.Keys
                    Dim rowStri As String = ""
                    Dim rowC As Integer = Convert.ToInt32(i.Substring(0, i.IndexOf("_")))
                    Dim rowStrs As String() = _default_O2S.Invoke(_list(i), _schema(rowC, 1))
                    For j = 0 To rowStrs.Length - 1
                        rowStri += rowStrs(j) + _sep_col
                    Next
                    list_string += i + _sep_key + rowStri + _sep_row
                Next


                'Finally JOIN PARTS -  convert to byte and Write to file
                '@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
                Dim byts As Byte() = System.Text.UnicodeEncoding.Unicode.GetBytes(meta_string + _sep_meta + list_string)
                rw.Write(byts, 0, byts.Length)

                ' Set Flags
                _isloaded = True
                ForceSave = True

                'Success
            Catch ex As Exception  'do nothing
                _isloaded = False
            Finally
                If Not IsNothing(rw) Then
                    rw.Close()
                    rw.Dispose()
                End If
            End Try
        End Function

        Public Sub ForceLoad(ByVal _schema As Array)
            _isloaded = False
            If Not ExistOnDisk Then Exit Sub
            ' try to read the file
            Dim rr As IO.FileStream = Nothing
            Try

                rr = New IO.FileStream(_path, IO.FileMode.Open, IO.FileAccess.Read)
                zClearAll() ' clear list only after file was opened

                If rr.Length > 0 Then

                    'read full file
                    Dim read_byte As Byte() = Array.CreateInstance(GetType(Byte), rr.Length)
                    rr.Read(read_byte, 0, rr.Length)

                    Dim file_parts As String() = System.Text.UnicodeEncoding.Unicode.GetString(read_byte).Split(_sep_meta)

                    '@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
                    '/META PART///////////////////////////////////////////////////////////////
                    '@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
                    If file_parts(0) <> "" Then
                        Dim read_meta As String() = file_parts(0).Split(_sep_col)
                        For i = 0 To read_meta.Length - 2
                            _xlist.Add(read_meta(i))
                        Next
                    End If

                    '@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
                    '/LIST PART///////////////////////////////////////////////////////////////
                    '@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
                    If file_parts(1) <> "" Then
                        Dim read_rows As String() = file_parts(1).Split(_sep_row)
                        'read rest rows
                        For i = 0 To read_rows.Length - 2
                            Dim read_keys As String() = read_rows(i).Split(_sep_key)
                            Dim read_cols As String() = read_keys(1).Split(_sep_col)
                            'Dim tempO As Object = Nothing
                            _list.Add(read_keys(0), _default_S2O.Invoke(read_cols, _schema(i, 1)))
                        Next
                    End If
                Else
                    'completely blank file
                End If
                _isloaded = True
            Catch ex As Exception
                ' _isdirty = True
                _isloaded = False
            Finally
                If Not IsNothing(rr) Then
                    rr.Close()
                    rr.Dispose()
                End If
            End Try
        End Sub

#End Region

#Region "' DATA CRUD "

        Public Function iCreate(ByVal inKey As String, ByVal ss As Object) As Boolean
            iCreate = False
            If _list.ContainsKey(inKey) Then Exit Function
            _list.Add(inKey, ss)
            iCreate = True
        End Function

        Public Function iContainKey(ByVal rKey As String) As Boolean
            Return _list.ContainsKey(rKey)
        End Function

        Public Function iRead(ByVal rKey As String) As Object
            If _list.ContainsKey(rKey) Then
                Return _list(rKey)
            Else
                Err.Raise(vbObjectError + 555, , "Index out of bounds")
                Return Nothing
            End If
        End Function

        Public Sub iUpdate(ByVal rKey As String, ByVal value As Object)
            If Not _list.ContainsKey(rKey) Then
                Err.Raise(vbObjectError + 555, , "Index out of bounds")
                Exit Sub
            End If
            _list(rKey) = value
        End Sub

        Public Sub iDelete(ByVal rKey As Integer)
            _list.Remove(rKey)
        End Sub

        Public Sub iDeleteAll()
            _list.Clear()
        End Sub


#End Region

#Region "' META CRUD "

        Public Function miCreate(ByVal value As String, ByVal chk_dup As Boolean) As Boolean
            Return miCreate(MetaCount, value, chk_dup)
        End Function

        Public Function miCreate(ByVal i As Integer, ByVal value As String, ByVal chk_dup As Boolean)
            If chk_dup Then If _xlist.Contains(value) Then Return False
            _xlist.Insert(i, value)
            Return True
        End Function

        Public Function miRead(ByVal i As Integer) As String
            Return _xlist(i)
        End Function

        Public Sub miUpdate(ByVal i As Integer, ByVal value As String, ByVal chk_dup As Boolean)
            If i < 0 Or i >= MetaCount Then Exit Sub
            If chk_dup Then If _xlist.Contains(value) Then Exit Sub
            _xlist(i) = value
        End Sub

        Public Sub miDelete(ByVal r As Integer)
            If r < 0 Or r >= MetaCount Then Exit Sub
            _xlist.RemoveAt(r)
        End Sub

        Public Sub miDeleteAll()
            _xlist.Clear()
        End Sub

#End Region

    End Class
    Public Enum HoDtype
        hod_none = 0
        hod_boolean = 1
        hod_integer = 2
        hod_single = 3
        hod_point = 4
        hod_size = 5
        hod_string = 6
        hod_font = 7
        hod_color = 8
        hod_enum = 9
    End Enum
    Public Function HOD_O2S(ByVal O As Object, ByVal Htype As HoDtype) As String()
        Select Case Htype
            Case HoDtype.hod_boolean, HoDtype.hod_integer, HoDtype.hod_single, HoDtype.hod_string
                Return {O.ToString}
            Case HoDtype.hod_enum
                Return {Convert.ToInt32(O).ToString}
            Case HoDtype.hod_point
                Return {O.X.ToString, O.Y.ToString}
            Case HoDtype.hod_size
                Return {O.Width.ToString, O.Height.ToString}
            Case HoDtype.hod_font
                Dim OO As Font = O
                Return {OO.Name,
              OO.Size.ToString,
             Convert.ToInt32(OO.Style).ToString,
              Convert.ToInt32(OO.Unit).ToString,
              OO.GdiCharSet.ToString,
              OO.GdiVerticalFont.ToString}
            Case HoDtype.hod_color
                Return {O.ToArgb.ToString}


            Case Else
                Return Nothing
        End Select
    End Function
    Public Function HOD_S2O(ByVal S As String(), ByVal Htype As HoDtype) As Object
        Select Case Htype
            Case HoDtype.hod_boolean
                Return Convert.ToBoolean(S(0))
            Case HoDtype.hod_integer
                Return Convert.ToInt32(S(0))
            Case HoDtype.hod_enum
                Return Convert.ToInt32(S(0))
            Case HoDtype.hod_single
                Return Convert.ToSingle(S(0))
            Case HoDtype.hod_point
                Return New Point(Convert.ToInt32(S(0)), Convert.ToInt32(S(1)))
            Case HoDtype.hod_size
                Return New Size(Convert.ToInt32(S(0)), Convert.ToInt32(S(1)))
            Case HoDtype.hod_string
                Return S(0)
            Case HoDtype.hod_font
                Return New Font(S(0),
                           Convert.ToSingle(S(1)),
                           Convert.ToInt32(S(2)),
                            Convert.ToInt32(S(3)),
                           Convert.ToByte(S(4)),
                           Convert.ToBoolean(S(5)))
            Case HoDtype.hod_color
                Return Color.FromArgb(Convert.ToInt32(S(0)))
            Case Else
                Return Nothing
        End Select
    End Function

#End Region

End Module
