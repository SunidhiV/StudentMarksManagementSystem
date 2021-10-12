Imports System.Data.SqlClient
Imports System.Data
Imports System.Management
Imports System.IO
Module TAMod
    Public strContents As String
    Public objReader As StreamReader
    Public str As String
    Public con As New SqlConnection
    Public appCaption As String
    Public username, fid As String
    Public fname, sunqname, dname, semname, facid, facname, subpriority As String
    Public attdt As Date
    Public subqid, deptid, semid As Integer

   
    Public url1, url2, url3, url4, url5, url6, url7, url8 As String
    Public Function FillSpace1(ByRef str_Renamed As String, ByRef num As Integer) As String

        'While Len(str) <= 20
        '    str = str & " "
        'Wend
        Dim I, j As Short
        j = num + Len(str_Renamed)

        For I = j To 25
            str_Renamed = str_Renamed & " "
        Next
        FillSpace1 = str_Renamed
    End Function
    Public Sub FillCombo(ByVal _ComboBox As ComboBox, ByVal Table As String, ByVal ValueMember As String, ByVal Displaymember As String, Optional ByVal Condtlqry As String = "", Optional ByVal Orderby As String = "")
        Dim tbltemp As New DataTable
        Dim qry As String
        If ValueMember <> Displaymember Then
            qry = " select " & ValueMember & " ," & Displaymember & " from " & LCase(Table)
            If Condtlqry <> String.Empty Then
                qry += " where " & Condtlqry
            End If
            _ComboBox.DisplayMember = Displaymember
            Try
                _ComboBox.ValueMember = ValueMember
            Catch ex As Exception

            End Try

        Else
            qry = " select " & Displaymember & " from " & LCase(Table)
            If Condtlqry <> String.Empty Then
                qry += " where " & Condtlqry
            End If
            _ComboBox.DisplayMember = Displaymember
            Try
                _ComboBox.ValueMember = Displaymember
            Catch ex As Exception

            End Try

        End If

        If Orderby = String.Empty Then
            'qry += " order by " & Displaymember
        Else
            qry += " order by " & Orderby
        End If

        _ComboBox.Refresh()
        tbltemp = Fill_Table(qry, Table)
        _ComboBox.DataSource = tbltemp.Copy
        _ComboBox.Refresh()
        _ComboBox.SelectedIndex = -1
    End Sub
    Public Sub FillCombogroupby(ByVal _ComboBox As ComboBox, ByVal Table As String, ByVal ValueMember As String, ByVal Displaymember As String, Optional ByVal Condtlqry As String = "", Optional ByVal groupby As String = "")
        Dim tbltemp As New DataTable
        Dim qry As String
        If ValueMember <> Displaymember Then
            qry = " select " & ValueMember & " ," & Displaymember & " from " & LCase(Table)
            If Condtlqry <> String.Empty Then
                qry += " where " & Condtlqry
            End If
            _ComboBox.DisplayMember = Displaymember
            Try
                _ComboBox.ValueMember = ValueMember
            Catch ex As Exception

            End Try

        Else
            qry = " select " & Displaymember & " from " & LCase(Table)
            If Condtlqry <> String.Empty Then
                qry += " where " & Condtlqry
            End If
            _ComboBox.DisplayMember = Displaymember
            Try
                _ComboBox.ValueMember = Displaymember
            Catch ex As Exception

            End Try

        End If

        If groupby = String.Empty Then
            qry += " group by " & Displaymember
        Else
            qry += " group by " & groupby
        End If

        _ComboBox.Refresh()
        tbltemp = Fill_Table(qry, Table)
        _ComboBox.DataSource = tbltemp.Copy
        _ComboBox.Refresh()
        _ComboBox.SelectedIndex = -1
    End Sub
    Public Function Fill_Table(ByVal sSQL As String, ByVal strTable As String) As System.Data.DataTable
        Dim DS As New DataSet
        Dim tblAdt As SqlDataAdapter
        Dim TBBB As New DataTable
        Dim sqlcmd As New SqlCommand
        sqlcmd.Connection = con
        sqlcmd.CommandTimeout = 250
        sqlcmd.CommandType = CommandType.Text
        sqlcmd.CommandText = sSQL
        'sqlCmd.Parameters(0)
        tblAdt = New SqlDataAdapter
        tblAdt.SelectCommand = sqlcmd
        tblAdt.Fill(DS, strTable)
        Return DS.Tables(strTable)
    End Function
    Public Function ExecuteQueriess(ByVal sSQL As String) As Integer
        If sSQL = String.Empty Then Return 0
        Dim sqlcmd As New SqlCommand
        If sSQL = String.Empty Then Return 0
        sqlcmd.Connection = con
        sqlcmd.CommandText = sSQL
        sqlcmd.CommandTimeout = 250
        Dim CT As Integer = 0
        CT = Val(sqlcmd.ExecuteScalar() & "")
        Return CT
    End Function
    Public Function ExecuteQueriess1(ByVal sSQL As String) As Integer
        If sSQL = String.Empty Then Return 0
        Dim sqlcmd As New SqlCommand
        SetCommandType(sqlcmd, CommandType.Text, Replace(sSQL, "Infinity", 0))
        If sqlcmd Is Nothing Then
            Throw New ArgumentNullException("sqlCmd")
        End If
        'Try
        Dim CT As Integer = 0
        Using cn As SqlConnection = New SqlConnection(con.ConnectionString)
            sqlcmd.Connection = cn
            sqlcmd.CommandTimeout = 250
            cn.Open()
            CT = Val(sqlcmd.ExecuteScalar() & "")
        End Using
        Return CT
    End Function
    Private Sub SetCommandType(ByVal sqlCmd As SqlCommand, ByVal cmdType As CommandType, ByVal cmdText As String)
        sqlCmd.CommandType = cmdType
        sqlCmd.CommandText = cmdText
    End Sub
    Public Function ExecuteQueryString(ByVal sSQL As String) As String
        Try
            If sSQL = String.Empty Then Return ""
            Dim sqlcmd As New SqlCommand
            Dim CT As String = ""
            sqlcmd.Connection = con
            sqlcmd.CommandText = sSQL
            sqlcmd.CommandTimeout = 250
            CT = sqlcmd.ExecuteScalar() & ""
            Return CT
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, appCaption)
            Return ""
        End Try
    End Function
    Function cstring(ByVal str As String) As String
        str = str.Replace("'", "`")
        str = str.Replace(";", ":")
        Return str
    End Function
    Public Function isEmpty(ByVal ctl As Control, ByVal msgg As String, ByVal isVal As Boolean) As Boolean
        If isVal Then
            If Not Val(ctl.Text) > 0 Then
                MsgBox(msgg, MsgBoxStyle.Exclamation, appCaption)
                ctl.Focus()
                isEmpty = True
            Else
                isEmpty = False
            End If
        Else
            If Trim((ctl.Text)) = String.Empty Then
                MsgBox(msgg, MsgBoxStyle.Exclamation, appCaption)
                ctl.Focus()
                isEmpty = True
            Else
                isEmpty = False
            End If
        End If
    End Function
    
    Public Sub NextFocus(ByVal KeyValue As Integer, ByVal ctl As Control)
        If KeyValue = 13 Or KeyValue = 9 Then
            If ctl.Enabled = True Then
                ctl.Focus()
                '  Dim combb As ComboBox
                Try
                    'combb = CType(ctl, ComboBox)
                    ' combb.DroppedDown = True
                Catch ex As Exception
                End Try
            End If
        End If
    End Sub
    Public Sub NextFocus(ByVal KeyValue As Integer, ByVal ctl As ToolStripLabel)

        If KeyValue = 13 Or KeyValue = 9 Then
            If ctl.Enabled = True Then
                ctl.Select()
                '  Dim combb As ComboBox
                Try
                    'combb = CType(ctl, ComboBox)
                    ' combb.DroppedDown = True
                Catch ex As Exception
                End Try
            End If
        End If
    End Sub
    Public Function isDuplicateRecord(ByVal Findclm As String, ByVal findText As String, ByVal tbl As String, ByVal SelectedData As String, ByVal ctl As Control) As Boolean
        Try
            Dim DS As New DataSet
            DS = Fill_Dataset("SELECT " & Findclm & " FROM " & tbl & " WHERE " & Findclm & "='" & Trim(findText) & "' ", tbl)
            If (DS.Tables(tbl).Rows.Count > 0 And Trim(SelectedData) = "") Or (DS.Tables(tbl).Rows.Count > 0 And UCase(Trim(findText)) <> UCase(Trim(SelectedData))) Then
                MsgBox("Duplicate record found (save failed)", MsgBoxStyle.Exclamation, appCaption)
                ctl.Text = ""
                ctl.Focus()
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, appCaption)
        End Try
    End Function
    Public Function Fill_Dataset(ByVal sSQL As String, ByVal strTable As String) As System.Data.DataSet
        Dim DS As New DataSet
        Try
            Dim sqlCmd As SqlCommand
            Dim tblAdt As SqlDataAdapter
            ' Try
            con.Close()
            con.Open()
            tblAdt = New SqlDataAdapter(sSQL, con)
            sqlCmd = New SqlCommand(sSQL, con)
            tblAdt.SelectCommand = sqlCmd
            sqlCmd.CommandTimeout = 180
            tblAdt.Fill(DS, strTable)
            con.Close()
            Return DS
        Catch ex As Exception
            MsgBox(ex.Message)
            Return DS
        End Try
    End Function
    Public Sub SetSize(ByVal Grp As GroupBox, ByVal width As Integer, ByVal height As Integer)
        Grp.Width = width
        Grp.Height = height
    End Sub
    Public Sub SetLocation(ByVal Grp As GroupBox, ByVal Xaxis As Integer, ByVal Yaxis As Integer)
        Grp.Location = New Point(Xaxis, Yaxis)
    End Sub
    Public Enum Mode
        _NEW
        _EDIT
        _DELETE
        _NONE
    End Enum
    
    Public Enum Codeype
        _MAT
        _GATE
        _EMP
    End Enum

    Public Function GeyMycode(ByVal Codeype As Codeype) As String
        Dim tbl As New DataTable
        Dim st As String = ""
        If Codeype = TAMod.Codeype._EMP Then st = "EmpCode"
        If Codeype = TAMod.Codeype._MAT Then st = "MatCode"
        If Codeype = TAMod.Codeype._GATE Then st = "GATENO"
        tbl = Fill_Table("select * from c_counter where modtype='" & st & "'", "tcounter")
        Dim prefix As String = ""
        Dim nextno As Integer
        If tbl.Rows.Count > 0 Then
            prefix = tbl.Rows(0).Item("suf") & ""
            nextno = Val(tbl.Rows(0).Item("Nextno") & "")
        End If
        ExecuteQueryString("update c_counter set Nextno=" & nextno + 1 & " where modtype='" & st & "'")
        Dim returnstring As String = prefix & nextno
        If returnstring.Length < 5 Then
            Dim i As Integer
            For i = returnstring.Length To 5
                returnstring = "0" & returnstring
            Next
        End If
        Return returnstring
    End Function

    Function aspect_ratio_checkrvd(ByVal Filename As String, ByVal picture As PictureBox) As Image
        Try
            Dim image1, image2 As Bitmap
            image1 = New Bitmap(Filename, False)
            Dim asprtH, asprtW As Decimal
            Dim Rh, Rw, H1, W1 As Integer
            H1 = image1.Size.Height
            Rh = picture.Height '550
            Rw = picture.Width
            W1 = image1.Size.Width
            If H1 <= Rh And W1 <= Rw Then
                image1.Dispose()
                Return New Bitmap(Filename, False)
            End If
            asprtH = Rh / H1
            asprtW = Rw / W1
            image2 = New Bitmap(image1, New Size(image1.Size.Width * asprtH, image1.Size.Height * asprtH))
            If Rw <= image2.Size.Width Then
                asprtW = Rw / image2.Width
                image1 = New Bitmap(image2, New Size(image2.Size.Width * asprtW, image2.Size.Height * asprtW))
                image2 = image1
            End If

            Return image2
        Catch ex As Exception
            Return New Bitmap(Filename, False)
        End Try
    End Function
    Sub main()
        Dim sqlpath As String
        sqlpath = (Application.StartupPath & "\SQLCON.txt")
        GetFileContents(sqlpath)
        Str = strContents
        con = New SqlConnection(Str)
    End Sub
    Public Function GetFileContents(ByVal FullPath As String, Optional ByRef ErrInfo As String = "") As String
        Try
            objReader = New StreamReader(FullPath)
            strContents = objReader.ReadToEnd()
            objReader.Close()
            Return strContents
        Catch Ex As Exception
            strContents = "Data Source=./; Initial Catalog=PPSCPL;Uid=sa;Pwd=;"
            SaveTextToFile(strContents, FullPath)
            'ErrInfo = Ex.Message
        End Try
    End Function
    Public Function SaveTextToFile(ByVal strData As String, ByVal FullPath As String, Optional ByVal ErrInfo As String = "") As Boolean

        Dim Contents As String
        Dim bAns As Boolean = False
        Dim objReader As StreamWriter
        Try
            objReader = New StreamWriter(FullPath)
            objReader.Write(strData)
            objReader.Close()
            bAns = True
        Catch Ex As Exception
            ErrInfo = Ex.Message

        End Try
        Return bAns
    End Function
    Public Sub Clearfields(ByVal root As Control)
        Dim date1 As Date
        date1 = CDate("12:00:00 AM")
        For Each ctrl As Control In root.Controls
            Clearfields(ctrl)
            If TypeOf ctrl Is TextBox Then
                CType(ctrl, TextBox).Text = String.Empty
            End If
            If TypeOf ctrl Is ComboBox Then
                CType(ctrl, ComboBox).SelectedIndex = -1
            End If
            If TypeOf ctrl Is RadioButton Then
                CType(ctrl, RadioButton).Checked = False
            End If
            If TypeOf ctrl Is CheckBox Then
                CType(ctrl, CheckBox).Checked = False
            End If
            'If TypeOf ctrl Is DateTimePicker Then
            '    CType(ctrl, DateTimePicker).Value = "00:00"
            'End If
        Next ctrl
    End Sub
    'Sub FillContractor()
    '    Dim tbl As New DataTable
    '    Dim drw As DataGridViewRow
    '    Dim rw As DataRow
    '    dgcontractor.Rows.Clear()
    '    Dim SSQL As String
    '    SSQL = " select id,company,firstname,lastname,address,state,city,country,pincode,"
    '    SSQL += " noofemp, photo, contractor.jtype, descp, mobile, phone, email, state.statename, country.countryname"
    '    SSQL += " ,city.cityname from contractor left join country on country.countryid=contractor.country"
    '    SSQL += " left join state on state.stateid =contractor.state"
    '    SSQL += " left join city on city.cityno=contractor.city order by company"
    '    tbl = Fill_Table(SSQL, "contrator")
    '    For Each rw In tbl.Rows
    '        dgcontractor.Rows.Insert(dgcontractor.Rows.Count, 1)
    '        drw = dgcontractor.Rows(dgcontractor.Rows.Count - 1)
    '        drw.Cells("dgslno").Value = dgcontractor.Rows.Count
    '        drw.Cells("dgcity").Value = rw("cityname") & ""
    '        drw.Cells("dgcityid").Value = rw("city") & ""
    '        drw.Cells("dgcont").Value = rw("company") & ""
    '        drw.Cells("dgcountryid").Value = rw("country") & ""
    '        drw.Cells("dgadd").Value = rw("address") & ""
    '        drw.Cells("dgemail").Value = rw("email") & ""
    '        drw.Cells("dgempname").Value = rw("firstname") & ""
    '        drw.Cells("dgid").Value = rw("id") & ""
    '        drw.Cells("dgjobtype").Value = rw("jtype") & ""
    '        drw.Cells("dgmobile").Value = rw("mobile") & ""
    '        drw.Cells("dgphone").Value = rw("phone") & ""
    '        '   drw.Cells("dgpath").Value = rw("photo") & ""
    '        drw.Cells("dgState").Value = rw("statename") & ""
    '        drw.Cells("dgstateid").Value = rw("state") & ""
    '        drw.Cells("dgdescp").Value = rw("descp") & ""
    '        drw.Cells("dgcountry").Value = rw("countryname") & ""
    '        drw.Cells("dgempno").Value = rw("noofemp") & ""
    '        drw.Cells("dgsecname").Value = rw("lastname") & ""
    '        drw.Cells("dgpin").Value = rw("pincode") & ""
    '    Next

    'End Sub

End Module
