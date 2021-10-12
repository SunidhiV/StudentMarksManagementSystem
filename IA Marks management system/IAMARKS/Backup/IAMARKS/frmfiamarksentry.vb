Public Class frmfiamarksentry

    Dim did As Integer
    Dim dname As String
    Dim maxmarks As Integer

    Private Sub frmfiamarksentry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            FillCombo(cmbsem, "semester", "semid", "semname")
            Me.DataGridView1.Font = lblfont.Font
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        facid = facid
        did = deptid
        dname = dname

    End Sub
    Public Sub populategrid()
        Dim tbl As New DataTable
        tbl = Fill_Table("SELECT usn as USN, sname as Student_Name  FROM  studentdetails where semid=" & Trim(cmbsem.SelectedValue) & " and deptid=" & Trim(deptid) & "", "studentdetails")
        
        DataGridView1.DataSource = tbl
        If DataGridView1.Columns.Contains("Marks") = True Then
        Else

            Dim col As New DataGridViewTextBoxColumn
            col.DataPropertyName = "Marks"
            col.HeaderText = "Marks"
            col.Name = "Marks"

            DataGridView1.Columns.Add(col)

        End If
    End Sub
    Public Sub savegrid()
        Dim sql, sql1, testtype As String
        Dim result, result1 As Integer
        Try
            'oppening the connection
            Dim tbl, tbl1 As New DataTable
            Dim recordexist, recordexist1 As Integer
            recordexist = 0
            recordexist1 = 0
            'con.Open()
            'DataGridViewRow represents a row in the DataGridView Control
            'Rows is to get the collection of rows in the DataGridView control
            'the syntax is , getting the rows one by one
            For Each row As DataGridViewRow In DataGridView1.Rows
                'Cells is to get the collection of cell that populate the row
                'FormattedValue is to get the value of the cell as formtted for display
                'the condition is, if the cell is not empty then it save to the database
                If row.Cells(0).FormattedValue <> "" Or row.Cells(1).FormattedValue <> "" Then
                    'store your query to a variable(sql)
                    If rbtest1.Checked = True Then
                        testtype = "Test1"
                        tbl = Fill_Table("SELECT * FROM  IAmarks where semid=" & Trim(cmbsem.SelectedValue) & " and deptid=" & Trim(did) & " and usn='" & CStr(row.Cells(0).FormattedValue) & "'", "IAmarks")
                        If tbl.Rows.Count > 0 Then
                            recordexist = 1
                        End If
                        tbl1 = Fill_Table("SELECT * FROM  tempiamarks where semid=" & Trim(cmbsem.SelectedValue) & " and deptid=" & Trim(did) & " and usn='" & CStr(row.Cells(0).FormattedValue) & "' and teston='" & Trim(testtype) & "'", "tempiamarks")
                        If tbl1.Rows.Count > 0 Then
                            recordexist1 = 1
                        End If
                        If subpriority = "Sub1" Then
                            If recordexist1 = 0 Then
                                sql = "INSERT INTO tempiamarks (usn,sname,deptid,dname,semid,semname,teston,sub1) VALUES ('" & CStr(row.Cells(0).FormattedValue) & "','" & CStr(row.Cells(1).FormattedValue) & "'," & Trim(did) & ",'" & Trim(dname) & "'," & Trim(cmbsem.SelectedValue) & ",'" & Trim(cmbsem.Text) & "','" & Trim(testtype) & "','" & CStr(row.Cells(2).FormattedValue) & "')"
                            ElseIf recordexist1 = 1 Then
                                sql = "update tempiamarks set sub1='" & CStr(row.Cells(2).FormattedValue) & "' where usn='" & CStr(row.Cells(0).FormattedValue) & "'and teston='" & Trim(testtype) & "'"
                            End If
                            If recordexist = 0 Then
                                sql1 = "INSERT INTO IAmarks (usn,sname,deptid,dname,semid,semname,subcode1,subname1,test11) VALUES ('" & CStr(row.Cells(0).FormattedValue) & "','" & CStr(row.Cells(1).FormattedValue) & "'," & Trim(did) & ",'" & Trim(dname) & "'," & Trim(cmbsem.SelectedValue) & ",'" & Trim(cmbsem.Text) & "','" & Trim(cmbsub.SelectedValue) & "','" & Trim(cmbsub.Text) & "','" & CStr(row.Cells(2).FormattedValue) & "')"
                            ElseIf recordexist = 1 Then
                                sql1 = "update IAmarks set subcode1='" & Trim(cmbsub.SelectedValue) & "',subname1='" & Trim(cmbsub.Text) & "',test11='" & CStr(row.Cells(2).FormattedValue) & "' where usn='" & CStr(row.Cells(0).FormattedValue) & "'"
                            End If
                        ElseIf subpriority = "Sub2" Then
                            If recordexist1 = 0 Then
                                sql = "INSERT INTO tempiamarks (usn,sname,deptid,dname,semid,semname,teston,sub2) VALUES ('" & CStr(row.Cells(0).FormattedValue) & "','" & CStr(row.Cells(1).FormattedValue) & "','" & Trim(did) & "','" & Trim(dname) & "','" & Trim(cmbsem.SelectedValue) & "','" & Trim(cmbsem.Text) & "','" & Trim(testtype) & "','" & CStr(row.Cells(2).FormattedValue) & "')"
                            ElseIf recordexist1 = 1 Then
                                sql = "update tempiamarks set sub2='" & CStr(row.Cells(2).FormattedValue) & "' where usn='" & CStr(row.Cells(0).FormattedValue) & "' and teston='" & Trim(testtype) & "'"
                            End If
                            If recordexist = 0 Then
                                sql1 = "INSERT INTO IAmarks (usn,sname,deptid,dname,semid,semname,subcode2,subname2,test21) VALUES ('" & CStr(row.Cells(0).FormattedValue) & "','" & CStr(row.Cells(1).FormattedValue) & "'," & Trim(did) & ",'" & Trim(dname) & "'," & Trim(cmbsem.SelectedValue) & ",'" & Trim(cmbsem.Text) & "','" & Trim(cmbsub.SelectedValue) & "','" & Trim(cmbsub.Text) & "','" & CStr(row.Cells(2).FormattedValue) & "')"
                            ElseIf recordexist = 1 Then
                                sql1 = "update IAmarks set subcode2='" & Trim(cmbsub.SelectedValue) & "',subname2='" & Trim(cmbsub.Text) & "',test21='" & CStr(row.Cells(2).FormattedValue) & "' where usn='" & CStr(row.Cells(0).FormattedValue) & "'"
                            End If

                        ElseIf subpriority = "Sub3" Then
                            If recordexist1 = 0 Then
                                sql = "INSERT INTO tempiamarks (usn,sname,deptid,dname,semid,semname,teston,sub3) VALUES ('" & CStr(row.Cells(0).FormattedValue) & "','" & CStr(row.Cells(1).FormattedValue) & "','" & Trim(did) & "','" & Trim(dname) & "','" & Trim(cmbsem.SelectedValue) & "','" & Trim(cmbsem.Text) & "','" & Trim(testtype) & "','" & CStr(row.Cells(2).FormattedValue) & "')"
                            ElseIf recordexist1 = 1 Then
                                sql = "update tempiamarks set sub3='" & CStr(row.Cells(2).FormattedValue) & "' where usn='" & CStr(row.Cells(0).FormattedValue) & "' and teston='" & Trim(testtype) & "'"
                            End If
                            If recordexist = 0 Then
                                sql1 = "INSERT INTO IAmarks (usn,sname,deptid,dname,semid,semname,subcode3,subname3,test31) VALUES ('" & CStr(row.Cells(0).FormattedValue) & "','" & CStr(row.Cells(1).FormattedValue) & "'," & Trim(did) & ",'" & Trim(dname) & "'," & Trim(cmbsem.SelectedValue) & ",'" & Trim(cmbsem.Text) & "','" & Trim(cmbsub.SelectedValue) & "','" & Trim(cmbsub.Text) & "','" & CStr(row.Cells(2).FormattedValue) & "')"
                            ElseIf recordexist = 1 Then
                                sql1 = "update IAmarks set subcode3='" & Trim(cmbsub.SelectedValue) & "',subname3='" & Trim(cmbsub.Text) & "',test31='" & CStr(row.Cells(2).FormattedValue) & "' where usn='" & CStr(row.Cells(0).FormattedValue) & "'"
                            End If

                        ElseIf subpriority = "Sub4" Then
                            If recordexist1 = 0 Then
                                sql = "INSERT INTO tempiamarks (usn,sname,deptid,dname,semid,semname,teston,sub4) VALUES ('" & CStr(row.Cells(0).FormattedValue) & "','" & CStr(row.Cells(1).FormattedValue) & "','" & Trim(did) & "','" & Trim(dname) & "','" & Trim(cmbsem.SelectedValue) & "','" & Trim(cmbsem.Text) & "','" & Trim(testtype) & "','" & CStr(row.Cells(2).FormattedValue) & "')"
                            ElseIf recordexist1 = 1 Then
                                sql = "update tempiamarks set sub4='" & CStr(row.Cells(2).FormattedValue) & "' where usn='" & CStr(row.Cells(0).FormattedValue) & "' and teston='" & Trim(testtype) & "'"
                            End If
                            If recordexist = 0 Then
                                sql1 = "INSERT INTO IAmarks (usn,sname,deptid,dname,semid,semname,subcode4,subname4,test41) VALUES ('" & CStr(row.Cells(0).FormattedValue) & "','" & CStr(row.Cells(1).FormattedValue) & "'," & Trim(did) & ",'" & Trim(dname) & "'," & Trim(cmbsem.SelectedValue) & ",'" & Trim(cmbsem.Text) & "','" & Trim(cmbsub.SelectedValue) & "','" & Trim(cmbsub.Text) & "','" & CStr(row.Cells(2).FormattedValue) & "')"
                            ElseIf recordexist = 1 Then
                                sql1 = "update IAmarks set subcode4='" & Trim(cmbsub.SelectedValue) & "',subname4='" & Trim(cmbsub.Text) & "',test41='" & CStr(row.Cells(2).FormattedValue) & "' where usn='" & CStr(row.Cells(0).FormattedValue) & "'"
                            End If

                        ElseIf subpriority = "Sub5" Then
                            If recordexist1 = 0 Then
                                sql = "INSERT INTO tempiamarks (usn,sname,deptid,dname,semid,semname,teston,sub5) VALUES ('" & CStr(row.Cells(0).FormattedValue) & "','" & CStr(row.Cells(1).FormattedValue) & "','" & Trim(did) & "','" & Trim(dname) & "','" & Trim(cmbsem.SelectedValue) & "','" & Trim(cmbsem.Text) & "','" & Trim(testtype) & "','" & CStr(row.Cells(2).FormattedValue) & "')"
                            ElseIf recordexist1 = 1 Then
                                sql = "update tempiamarks set sub5='" & CStr(row.Cells(2).FormattedValue) & "' where usn='" & CStr(row.Cells(0).FormattedValue) & "' and teston='" & Trim(testtype) & "'"
                            End If
                            If recordexist = 0 Then
                                sql1 = "INSERT INTO IAmarks (usn,sname,deptid,dname,semid,semname,subcode5,subname5,test51) VALUES ('" & CStr(row.Cells(0).FormattedValue) & "','" & CStr(row.Cells(1).FormattedValue) & "'," & Trim(did) & ",'" & Trim(dname) & "'," & Trim(cmbsem.SelectedValue) & ",'" & Trim(cmbsem.Text) & "','" & Trim(cmbsub.SelectedValue) & "','" & Trim(cmbsub.Text) & "','" & CStr(row.Cells(2).FormattedValue) & "')"
                            ElseIf recordexist = 1 Then
                                sql1 = "update IAmarks set subcode5='" & Trim(cmbsub.SelectedValue) & "',subname5='" & Trim(cmbsub.Text) & "',test51='" & CStr(row.Cells(2).FormattedValue) & "' where usn='" & CStr(row.Cells(0).FormattedValue) & "'"
                            End If

                        ElseIf subpriority = "Sub6" Then
                            If recordexist1 = 0 Then
                                sql = "INSERT INTO tempiamarks (usn,sname,deptid,dname,semid,semname,teston,sub6) VALUES ('" & CStr(row.Cells(0).FormattedValue) & "','" & CStr(row.Cells(1).FormattedValue) & "','" & Trim(did) & "','" & Trim(dname) & "','" & Trim(cmbsem.SelectedValue) & "','" & Trim(cmbsem.Text) & "','" & Trim(testtype) & "','" & CStr(row.Cells(2).FormattedValue) & "')"
                            ElseIf recordexist1 = 1 Then
                                sql = "update tempiamarks set sub6='" & CStr(row.Cells(2).FormattedValue) & "' where usn='" & CStr(row.Cells(0).FormattedValue) & "' and teston='" & Trim(testtype) & "'"
                            End If
                            If recordexist = 0 Then
                                sql1 = "INSERT INTO IAmarks (usn,sname,deptid,dname,semid,semname,subcode6,subname6,test61) VALUES ('" & CStr(row.Cells(0).FormattedValue) & "','" & CStr(row.Cells(1).FormattedValue) & "'," & Trim(did) & ",'" & Trim(dname) & "'," & Trim(cmbsem.SelectedValue) & ",'" & Trim(cmbsem.Text) & "','" & Trim(cmbsub.SelectedValue) & "','" & Trim(cmbsub.Text) & "','" & CStr(row.Cells(2).FormattedValue) & "')"
                            ElseIf recordexist = 1 Then
                                sql1 = "update IAmarks set subcode6='" & Trim(cmbsub.SelectedValue) & "',subname6='" & Trim(cmbsub.Text) & "',test61='" & CStr(row.Cells(2).FormattedValue) & "' where usn='" & CStr(row.Cells(0).FormattedValue) & "'"
                            End If

                        ElseIf subpriority = "Sub7" Then
                            If recordexist1 = 0 Then
                                sql = "INSERT INTO tempiamarks (usn,sname,deptid,dname,semid,semname,teston,sub7) VALUES ('" & CStr(row.Cells(0).FormattedValue) & "','" & CStr(row.Cells(1).FormattedValue) & "','" & Trim(did) & "','" & Trim(dname) & "','" & Trim(cmbsem.SelectedValue) & "','" & Trim(cmbsem.Text) & "','" & Trim(testtype) & "','" & CStr(row.Cells(2).FormattedValue) & "')"
                            ElseIf recordexist1 = 1 Then
                                sql = "update tempiamarks set sub7='" & CStr(row.Cells(2).FormattedValue) & "' where usn='" & CStr(row.Cells(0).FormattedValue) & "' and teston='" & Trim(testtype) & "'"
                            End If
                            If recordexist = 0 Then
                                sql1 = "INSERT INTO IAmarks (usn,sname,deptid,dname,semid,semname,subcode7,subname7,test71) VALUES ('" & CStr(row.Cells(0).FormattedValue) & "','" & CStr(row.Cells(1).FormattedValue) & "'," & Trim(did) & ",'" & Trim(dname) & "'," & Trim(cmbsem.SelectedValue) & ",'" & Trim(cmbsem.Text) & "','" & Trim(cmbsub.SelectedValue) & "','" & Trim(cmbsub.Text) & "','" & CStr(row.Cells(2).FormattedValue) & "')"
                            ElseIf recordexist = 1 Then
                                sql1 = "update IAmarks set subcode7='" & Trim(cmbsub.SelectedValue) & "',subname7='" & Trim(cmbsub.Text) & "',test71='" & CStr(row.Cells(2).FormattedValue) & "' where usn='" & CStr(row.Cells(0).FormattedValue) & "'"
                            End If
                        ElseIf subpriority = "Sub8" Then
                            If recordexist1 = 0 Then
                                sql = "INSERT INTO tempiamarks (usn,sname,deptid,dname,semid,semname,teston,sub8) VALUES ('" & CStr(row.Cells(0).FormattedValue) & "','" & CStr(row.Cells(1).FormattedValue) & "','" & Trim(did) & "','" & Trim(dname) & "','" & Trim(cmbsem.SelectedValue) & "','" & Trim(cmbsem.Text) & "','" & Trim(testtype) & "','" & CStr(row.Cells(2).FormattedValue) & "')"
                            ElseIf recordexist1 = 1 Then
                                sql = "update tempiamarks set sub8='" & CStr(row.Cells(2).FormattedValue) & "' where usn='" & CStr(row.Cells(0).FormattedValue) & "' and teston='" & Trim(testtype) & "'"
                            End If
                            If recordexist = 0 Then
                                sql1 = "INSERT INTO IAmarks (usn,sname,deptid,dname,semid,semname,subcode8,subname8,test81) VALUES ('" & CStr(row.Cells(0).FormattedValue) & "','" & CStr(row.Cells(1).FormattedValue) & "'," & Trim(did) & ",'" & Trim(dname) & "'," & Trim(cmbsem.SelectedValue) & ",'" & Trim(cmbsem.Text) & "','" & Trim(cmbsub.SelectedValue) & "','" & Trim(cmbsub.Text) & "','" & CStr(row.Cells(2).FormattedValue) & "')"
                            ElseIf recordexist = 1 Then
                                sql1 = "update IAmarks set subcode8='" & Trim(cmbsub.SelectedValue) & "',subname8='" & Trim(cmbsub.Text) & "',test81='" & CStr(row.Cells(2).FormattedValue) & "' where usn='" & CStr(row.Cells(0).FormattedValue) & "'"
                            End If
                        End If

                    ElseIf rbtest2.Checked = True Then
                        testtype = "Test2"
                        tbl = Fill_Table("SELECT * FROM  IAmarks where semid=" & Trim(cmbsem.SelectedValue) & " and deptid=" & Trim(did) & " and usn='" & CStr(row.Cells(0).FormattedValue) & "'", "IAmarks")
                        If tbl.Rows.Count > 0 Then
                            recordexist = 1
                        End If
                        tbl1 = Fill_Table("SELECT * FROM  tempiamarks where semid=" & Trim(cmbsem.SelectedValue) & " and deptid=" & Trim(did) & " and usn='" & CStr(row.Cells(0).FormattedValue) & "' and teston='" & Trim(testtype) & "'", "tempiamarks")
                        If tbl1.Rows.Count > 0 Then
                            recordexist1 = 1
                        End If
                        If subpriority = "Sub1" Then
                            If recordexist1 = 0 Then
                                sql = "INSERT INTO tempiamarks (usn,sname,deptid,dname,semid,semname,teston,sub1) VALUES ('" & CStr(row.Cells(0).FormattedValue) & "','" & CStr(row.Cells(1).FormattedValue) & "'," & Trim(did) & ",'" & Trim(dname) & "'," & Trim(cmbsem.SelectedValue) & ",'" & Trim(cmbsem.Text) & "','" & Trim(testtype) & "','" & CStr(row.Cells(2).FormattedValue) & "')"
                            ElseIf recordexist1 = 1 Then
                                sql = "update tempiamarks set sub1='" & CStr(row.Cells(2).FormattedValue) & "' where usn='" & CStr(row.Cells(0).FormattedValue) & "' and teston='" & Trim(testtype) & "'"
                            End If
                            If recordexist = 0 Then
                                sql1 = "INSERT INTO IAmarks (usn,sname,deptid,dname,semid,semname,subcode1,subname1,test12) VALUES ('" & CStr(row.Cells(0).FormattedValue) & "','" & CStr(row.Cells(1).FormattedValue) & "'," & Trim(did) & ",'" & Trim(dname) & "'," & Trim(cmbsem.SelectedValue) & ",'" & Trim(cmbsem.Text) & "','" & Trim(cmbsub.SelectedValue) & "','" & Trim(cmbsub.Text) & "','" & CStr(row.Cells(2).FormattedValue) & "')"
                            ElseIf recordexist = 1 Then
                                sql1 = "update IAmarks set subcode1='" & Trim(cmbsub.SelectedValue) & "',subname1='" & Trim(cmbsub.Text) & "',test12='" & CStr(row.Cells(2).FormattedValue) & "' where usn='" & CStr(row.Cells(0).FormattedValue) & "'"
                            End If
                        ElseIf subpriority = "Sub2" Then
                            If recordexist1 = 0 Then
                                sql = "INSERT INTO tempiamarks (usn,sname,deptid,dname,semid,semname,teston,sub2) VALUES ('" & CStr(row.Cells(0).FormattedValue) & "','" & CStr(row.Cells(1).FormattedValue) & "','" & Trim(did) & "','" & Trim(dname) & "','" & Trim(cmbsem.SelectedValue) & "','" & Trim(cmbsem.Text) & "','" & Trim(testtype) & "','" & CStr(row.Cells(2).FormattedValue) & "')"
                            ElseIf recordexist1 = 1 Then
                                sql = "update tempiamarks set sub2='" & CStr(row.Cells(2).FormattedValue) & "' where usn='" & CStr(row.Cells(0).FormattedValue) & "' and teston='" & Trim(testtype) & "'"
                            End If
                            If recordexist = 0 Then
                                sql1 = "INSERT INTO IAmarks (usn,sname,deptid,dname,semid,semname,subcode2,subname2,test22) VALUES ('" & CStr(row.Cells(0).FormattedValue) & "','" & CStr(row.Cells(1).FormattedValue) & "'," & Trim(did) & ",'" & Trim(dname) & "'," & Trim(cmbsem.SelectedValue) & ",'" & Trim(cmbsem.Text) & "','" & Trim(cmbsub.SelectedValue) & "','" & Trim(cmbsub.Text) & "','" & CStr(row.Cells(2).FormattedValue) & "')"
                            ElseIf recordexist = 1 Then
                                sql1 = "update IAmarks set subcode2='" & Trim(cmbsub.SelectedValue) & "',subname2='" & Trim(cmbsub.Text) & "',test22='" & CStr(row.Cells(2).FormattedValue) & "' where usn='" & CStr(row.Cells(0).FormattedValue) & "'"
                            End If

                        ElseIf subpriority = "Sub3" Then

                            If recordexist1 = 0 Then
                                sql = "INSERT INTO tempiamarks (usn,sname,deptid,dname,semid,semname,teston,sub3) VALUES ('" & CStr(row.Cells(0).FormattedValue) & "','" & CStr(row.Cells(1).FormattedValue) & "','" & Trim(did) & "','" & Trim(dname) & "','" & Trim(cmbsem.SelectedValue) & "','" & Trim(cmbsem.Text) & "','" & Trim(testtype) & "','" & CStr(row.Cells(2).FormattedValue) & "')"
                            ElseIf recordexist1 = 1 Then
                                sql = "update tempiamarks set sub3='" & CStr(row.Cells(2).FormattedValue) & "' where usn='" & CStr(row.Cells(0).FormattedValue) & "' and teston='" & Trim(testtype) & "'"
                            End If
                            If recordexist = 0 Then
                                sql1 = "INSERT INTO IAmarks (usn,sname,deptid,dname,semid,semname,subcode3,subname3,test32) VALUES ('" & CStr(row.Cells(0).FormattedValue) & "','" & CStr(row.Cells(1).FormattedValue) & "'," & Trim(did) & ",'" & Trim(dname) & "'," & Trim(cmbsem.SelectedValue) & ",'" & Trim(cmbsem.Text) & "','" & Trim(cmbsub.SelectedValue) & "','" & Trim(cmbsub.Text) & "','" & CStr(row.Cells(2).FormattedValue) & "')"
                            ElseIf recordexist = 1 Then
                                sql1 = "update IAmarks set subcode3='" & Trim(cmbsub.SelectedValue) & "',subname3='" & Trim(cmbsub.Text) & "',test32='" & CStr(row.Cells(2).FormattedValue) & "' where usn='" & CStr(row.Cells(0).FormattedValue) & "'"
                            End If

                        ElseIf subpriority = "Sub4" Then
                            If recordexist1 = 0 Then
                                sql = "INSERT INTO tempiamarks (usn,sname,deptid,dname,semid,semname,teston,sub4) VALUES ('" & CStr(row.Cells(0).FormattedValue) & "','" & CStr(row.Cells(1).FormattedValue) & "','" & Trim(did) & "','" & Trim(dname) & "','" & Trim(cmbsem.SelectedValue) & "','" & Trim(cmbsem.Text) & "','" & Trim(testtype) & "','" & CStr(row.Cells(2).FormattedValue) & "')"
                            ElseIf recordexist1 = 1 Then
                                sql = "update tempiamarks set sub4='" & CStr(row.Cells(2).FormattedValue) & "' where usn='" & CStr(row.Cells(0).FormattedValue) & "' and teston='" & Trim(testtype) & "'"
                            End If
                            If recordexist = 0 Then
                                sql1 = "INSERT INTO IAmarks (usn,sname,deptid,dname,semid,semname,subcode4,subname4,test42) VALUES ('" & CStr(row.Cells(0).FormattedValue) & "','" & CStr(row.Cells(1).FormattedValue) & "'," & Trim(did) & ",'" & Trim(dname) & "'," & Trim(cmbsem.SelectedValue) & ",'" & Trim(cmbsem.Text) & "','" & Trim(cmbsub.SelectedValue) & "','" & Trim(cmbsub.Text) & "','" & CStr(row.Cells(2).FormattedValue) & "')"
                            ElseIf recordexist = 1 Then
                                sql1 = "update IAmarks set subcode4='" & Trim(cmbsub.SelectedValue) & "',subname4='" & Trim(cmbsub.Text) & "',test42='" & CStr(row.Cells(2).FormattedValue) & "' where usn='" & CStr(row.Cells(0).FormattedValue) & "'"
                            End If

                        ElseIf subpriority = "Sub5" Then
                            If recordexist1 = 0 Then
                                sql = "INSERT INTO tempiamarks (usn,sname,deptid,dname,semid,semname,teston,sub5) VALUES ('" & CStr(row.Cells(0).FormattedValue) & "','" & CStr(row.Cells(1).FormattedValue) & "','" & Trim(did) & "','" & Trim(dname) & "','" & Trim(cmbsem.SelectedValue) & "','" & Trim(cmbsem.Text) & "','" & Trim(testtype) & "','" & CStr(row.Cells(2).FormattedValue) & "')"
                            ElseIf recordexist1 = 1 Then
                                sql = "update tempiamarks set sub5='" & CStr(row.Cells(2).FormattedValue) & "' where usn='" & CStr(row.Cells(0).FormattedValue) & "' and teston='" & Trim(testtype) & "'"
                            End If
                            If recordexist = 0 Then
                                sql1 = "INSERT INTO IAmarks (usn,sname,deptid,dname,semid,semname,subcode5,subname5,test52) VALUES ('" & CStr(row.Cells(0).FormattedValue) & "','" & CStr(row.Cells(1).FormattedValue) & "'," & Trim(did) & ",'" & Trim(dname) & "'," & Trim(cmbsem.SelectedValue) & ",'" & Trim(cmbsem.Text) & "','" & Trim(cmbsub.SelectedValue) & "','" & Trim(cmbsub.Text) & "','" & CStr(row.Cells(2).FormattedValue) & "')"
                            ElseIf recordexist = 1 Then
                                sql1 = "update IAmarks set subcode5='" & Trim(cmbsub.SelectedValue) & "',subname5='" & Trim(cmbsub.Text) & "',test52='" & CStr(row.Cells(2).FormattedValue) & "' where usn='" & CStr(row.Cells(0).FormattedValue) & "'"
                            End If

                        ElseIf subpriority = "Sub6" Then
                            If recordexist1 = 0 Then
                                sql = "INSERT INTO tempiamarks (usn,sname,deptid,dname,semid,semname,teston,sub6) VALUES ('" & CStr(row.Cells(0).FormattedValue) & "','" & CStr(row.Cells(1).FormattedValue) & "','" & Trim(did) & "','" & Trim(dname) & "','" & Trim(cmbsem.SelectedValue) & "','" & Trim(cmbsem.Text) & "','" & Trim(testtype) & "','" & CStr(row.Cells(2).FormattedValue) & "')"
                            ElseIf recordexist1 = 1 Then
                                sql = "update tempiamarks set sub6='" & CStr(row.Cells(2).FormattedValue) & "' where usn='" & CStr(row.Cells(0).FormattedValue) & "' and teston='" & Trim(testtype) & "'"
                            End If
                            If recordexist = 0 Then
                                sql1 = "INSERT INTO IAmarks (usn,sname,deptid,dname,semid,semname,subcode6,subname6,test62) VALUES ('" & CStr(row.Cells(0).FormattedValue) & "','" & CStr(row.Cells(1).FormattedValue) & "'," & Trim(did) & ",'" & Trim(dname) & "'," & Trim(cmbsem.SelectedValue) & ",'" & Trim(cmbsem.Text) & "','" & Trim(cmbsub.SelectedValue) & "','" & Trim(cmbsub.Text) & "','" & CStr(row.Cells(2).FormattedValue) & "')"
                            ElseIf recordexist = 1 Then
                                sql1 = "update IAmarks set subcode6='" & Trim(cmbsub.SelectedValue) & "',subname6='" & Trim(cmbsub.Text) & "',test62='" & CStr(row.Cells(2).FormattedValue) & "' where usn='" & CStr(row.Cells(0).FormattedValue) & "'"
                            End If

                        ElseIf subpriority = "Sub7" Then
                            If recordexist1 = 0 Then
                                sql = "INSERT INTO tempiamarks (usn,sname,deptid,dname,semid,semname,teston,sub7) VALUES ('" & CStr(row.Cells(0).FormattedValue) & "','" & CStr(row.Cells(1).FormattedValue) & "','" & Trim(did) & "','" & Trim(dname) & "','" & Trim(cmbsem.SelectedValue) & "','" & Trim(cmbsem.Text) & "','" & Trim(testtype) & "','" & CStr(row.Cells(2).FormattedValue) & "')"
                            ElseIf recordexist1 = 1 Then
                                sql = "update tempiamarks set sub7='" & CStr(row.Cells(2).FormattedValue) & "' where usn='" & CStr(row.Cells(0).FormattedValue) & "' and teston='" & Trim(testtype) & "'"
                            End If
                            If recordexist = 0 Then
                                sql1 = "INSERT INTO IAmarks (usn,sname,deptid,dname,semid,semname,subcode7,subname7,test72) VALUES ('" & CStr(row.Cells(0).FormattedValue) & "','" & CStr(row.Cells(1).FormattedValue) & "'," & Trim(did) & ",'" & Trim(dname) & "'," & Trim(cmbsem.SelectedValue) & ",'" & Trim(cmbsem.Text) & "','" & Trim(cmbsub.SelectedValue) & "','" & Trim(cmbsub.Text) & "','" & CStr(row.Cells(2).FormattedValue) & "')"
                            ElseIf recordexist = 1 Then
                                sql1 = "update IAmarks set subcode7='" & Trim(cmbsub.SelectedValue) & "',subname7='" & Trim(cmbsub.Text) & "',test72='" & CStr(row.Cells(2).FormattedValue) & "' where usn='" & CStr(row.Cells(0).FormattedValue) & "'"
                            End If
                        ElseIf subpriority = "Sub8" Then
                            If recordexist1 = 0 Then
                                sql = "INSERT INTO tempiamarks (usn,sname,deptid,dname,semid,semname,teston,sub8) VALUES ('" & CStr(row.Cells(0).FormattedValue) & "','" & CStr(row.Cells(1).FormattedValue) & "','" & Trim(did) & "','" & Trim(dname) & "','" & Trim(cmbsem.SelectedValue) & "','" & Trim(cmbsem.Text) & "','" & Trim(testtype) & "','" & CStr(row.Cells(2).FormattedValue) & "')"
                            ElseIf recordexist1 = 1 Then
                                sql = "update tempiamarks set sub8='" & CStr(row.Cells(2).FormattedValue) & "' where usn='" & CStr(row.Cells(0).FormattedValue) & "' and teston='" & Trim(testtype) & "'"
                            End If
                            If recordexist = 0 Then
                                sql1 = "INSERT INTO IAmarks (usn,sname,deptid,dname,semid,semname,subcode8,subname8,test82) VALUES ('" & CStr(row.Cells(0).FormattedValue) & "','" & CStr(row.Cells(1).FormattedValue) & "'," & Trim(did) & ",'" & Trim(dname) & "'," & Trim(cmbsem.SelectedValue) & ",'" & Trim(cmbsem.Text) & "','" & Trim(cmbsub.SelectedValue) & "','" & Trim(cmbsub.Text) & "','" & CStr(row.Cells(2).FormattedValue) & "')"
                            ElseIf recordexist = 1 Then
                                sql1 = "update IAmarks set subcode8='" & Trim(cmbsub.SelectedValue) & "',subname8='" & Trim(cmbsub.Text) & "',test82='" & CStr(row.Cells(2).FormattedValue) & "' where usn='" & CStr(row.Cells(0).FormattedValue) & "'"
                            End If
                        End If

                    ElseIf rbtest3.Checked = True Then
                        testtype = "Test3"
                        tbl = Fill_Table("SELECT * FROM  IAmarks where semid=" & Trim(cmbsem.SelectedValue) & " and deptid=" & Trim(did) & " and usn='" & CStr(row.Cells(0).FormattedValue) & "'", "IAmarks")
                        If tbl.Rows.Count > 0 Then
                            recordexist = 1
                        End If
                        tbl1 = Fill_Table("SELECT * FROM  tempiamarks where semid=" & Trim(cmbsem.SelectedValue) & " and deptid=" & Trim(did) & " and usn='" & CStr(row.Cells(0).FormattedValue) & "' and teston='" & Trim(testtype) & "'", "tempiamarks")
                        If tbl1.Rows.Count > 0 Then
                            recordexist1 = 1
                        End If
                        If subpriority = "Sub1" Then
                            If recordexist1 = 0 Then
                                sql = "INSERT INTO tempiamarks (usn,sname,deptid,dname,semid,semname,teston,sub1) VALUES ('" & CStr(row.Cells(0).FormattedValue) & "','" & CStr(row.Cells(1).FormattedValue) & "'," & Trim(did) & ",'" & Trim(dname) & "'," & Trim(cmbsem.SelectedValue) & ",'" & Trim(cmbsem.Text) & "','" & Trim(testtype) & "','" & CStr(row.Cells(2).FormattedValue) & "')"
                            ElseIf recordexist1 = 1 Then
                                sql = "update tempiamarks set sub1='" & CStr(row.Cells(2).FormattedValue) & "' where usn='" & CStr(row.Cells(0).FormattedValue) & "' and teston='" & Trim(testtype) & "'"

                            End If
                            If recordexist = 0 Then
                                sql1 = "INSERT INTO IAmarks (usn,sname,deptid,dname,semid,semname,subcode1,subname1,test13) VALUES ('" & CStr(row.Cells(0).FormattedValue) & "','" & CStr(row.Cells(1).FormattedValue) & "'," & Trim(did) & ",'" & Trim(dname) & "'," & Trim(cmbsem.SelectedValue) & ",'" & Trim(cmbsem.Text) & "','" & Trim(cmbsub.SelectedValue) & "','" & Trim(cmbsub.Text) & "','" & CStr(row.Cells(2).FormattedValue) & "')"
                            ElseIf recordexist = 1 Then

                                sql1 = "update IAmarks set subcode1='" & Trim(cmbsub.SelectedValue) & "',subname1='" & Trim(cmbsub.Text) & "',test13='" & CStr(row.Cells(2).FormattedValue) & "' where usn='" & CStr(row.Cells(0).FormattedValue) & "'"
                            End If
                        ElseIf subpriority = "Sub2" Then
                            If recordexist1 = 0 Then
                                sql = "INSERT INTO tempiamarks (usn,sname,deptid,dname,semid,semname,teston,sub2) VALUES ('" & CStr(row.Cells(0).FormattedValue) & "','" & CStr(row.Cells(1).FormattedValue) & "','" & Trim(did) & "','" & Trim(dname) & "','" & Trim(cmbsem.SelectedValue) & "','" & Trim(cmbsem.Text) & "','" & Trim(testtype) & "','" & CStr(row.Cells(2).FormattedValue) & "')"
                            ElseIf recordexist1 = 1 Then
                                sql = "update tempiamarks set sub2='" & CStr(row.Cells(2).FormattedValue) & "' where usn='" & CStr(row.Cells(0).FormattedValue) & "' and teston='" & Trim(testtype) & "'"
                            End If
                            If recordexist = 0 Then
                                sql1 = "INSERT INTO IAmarks (usn,sname,deptid,dname,semid,semname,subcode2,subname2,test23) VALUES ('" & CStr(row.Cells(0).FormattedValue) & "','" & CStr(row.Cells(1).FormattedValue) & "'," & Trim(did) & ",'" & Trim(dname) & "'," & Trim(cmbsem.SelectedValue) & ",'" & Trim(cmbsem.Text) & "','" & Trim(cmbsub.SelectedValue) & "','" & Trim(cmbsub.Text) & "','" & CStr(row.Cells(2).FormattedValue) & "')"
                            ElseIf recordexist = 1 Then
                                sql1 = "update IAmarks set subcode2='" & Trim(cmbsub.SelectedValue) & "',subname2='" & Trim(cmbsub.Text) & "',test23='" & CStr(row.Cells(2).FormattedValue) & "' where usn='" & CStr(row.Cells(0).FormattedValue) & "'"
                            End If

                        ElseIf subpriority = "Sub3" Then
                            If recordexist1 = 0 Then
                                sql = "INSERT INTO tempiamarks (usn,sname,deptid,dname,semid,semname,teston,sub3) VALUES ('" & CStr(row.Cells(0).FormattedValue) & "','" & CStr(row.Cells(1).FormattedValue) & "','" & Trim(did) & "','" & Trim(dname) & "','" & Trim(cmbsem.SelectedValue) & "','" & Trim(cmbsem.Text) & "','" & Trim(testtype) & "','" & CStr(row.Cells(2).FormattedValue) & "')"
                            ElseIf recordexist1 = 1 Then
                                sql = "update tempiamarks set sub3='" & CStr(row.Cells(2).FormattedValue) & "' where usn='" & CStr(row.Cells(0).FormattedValue) & "' and teston='" & Trim(testtype) & "'"
                            End If
                            If recordexist = 0 Then
                                sql1 = "INSERT INTO IAmarks (usn,sname,deptid,dname,semid,semname,subcode3,subname3,test33) VALUES ('" & CStr(row.Cells(0).FormattedValue) & "','" & CStr(row.Cells(1).FormattedValue) & "'," & Trim(did) & ",'" & Trim(dname) & "'," & Trim(cmbsem.SelectedValue) & ",'" & Trim(cmbsem.Text) & "','" & Trim(cmbsub.SelectedValue) & "','" & Trim(cmbsub.Text) & "','" & CStr(row.Cells(2).FormattedValue) & "')"
                            ElseIf recordexist = 1 Then
                                sql1 = "update IAmarks set subcode3='" & Trim(cmbsub.SelectedValue) & "',subname3='" & Trim(cmbsub.Text) & "',test33='" & CStr(row.Cells(2).FormattedValue) & "' where usn='" & CStr(row.Cells(0).FormattedValue) & "'"
                            End If

                        ElseIf subpriority = "Sub4" Then
                            If recordexist1 = 0 Then
                                sql = "INSERT INTO tempiamarks (usn,sname,deptid,dname,semid,semname,teston,sub4) VALUES ('" & CStr(row.Cells(0).FormattedValue) & "','" & CStr(row.Cells(1).FormattedValue) & "','" & Trim(did) & "','" & Trim(dname) & "','" & Trim(cmbsem.SelectedValue) & "','" & Trim(cmbsem.Text) & "','" & Trim(testtype) & "','" & CStr(row.Cells(2).FormattedValue) & "')"
                            ElseIf recordexist1 = 1 Then
                                sql = "update tempiamarks set sub4='" & CStr(row.Cells(2).FormattedValue) & "' where usn='" & CStr(row.Cells(0).FormattedValue) & "' and teston='" & Trim(testtype) & "'"
                            End If
                            If recordexist = 0 Then
                                sql1 = "INSERT INTO IAmarks (usn,sname,deptid,dname,semid,semname,subcode4,subname4,test43) VALUES ('" & CStr(row.Cells(0).FormattedValue) & "','" & CStr(row.Cells(1).FormattedValue) & "'," & Trim(did) & ",'" & Trim(dname) & "'," & Trim(cmbsem.SelectedValue) & ",'" & Trim(cmbsem.Text) & "','" & Trim(cmbsub.SelectedValue) & "','" & Trim(cmbsub.Text) & "','" & CStr(row.Cells(2).FormattedValue) & "')"
                            ElseIf recordexist = 1 Then
                                sql1 = "update IAmarks set subcode4='" & Trim(cmbsub.SelectedValue) & "',subname4='" & Trim(cmbsub.Text) & "',test43='" & CStr(row.Cells(2).FormattedValue) & "' where usn='" & CStr(row.Cells(0).FormattedValue) & "'"
                            End If

                        ElseIf subpriority = "Sub5" Then
                            If recordexist1 = 0 Then
                                sql = "INSERT INTO tempiamarks (usn,sname,deptid,dname,semid,semname,teston,sub5) VALUES ('" & CStr(row.Cells(0).FormattedValue) & "','" & CStr(row.Cells(1).FormattedValue) & "','" & Trim(did) & "','" & Trim(dname) & "','" & Trim(cmbsem.SelectedValue) & "','" & Trim(cmbsem.Text) & "','" & Trim(testtype) & "','" & CStr(row.Cells(2).FormattedValue) & "')"
                            ElseIf recordexist1 = 1 Then
                                sql = "update tempiamarks set sub5='" & CStr(row.Cells(2).FormattedValue) & "' where usn='" & CStr(row.Cells(0).FormattedValue) & "'and teston='" & Trim(testtype) & "'"
                            End If
                            If recordexist = 0 Then
                                sql1 = "INSERT INTO IAmarks (usn,sname,deptid,dname,semid,semname,subcode5,subname5,test53) VALUES ('" & CStr(row.Cells(0).FormattedValue) & "','" & CStr(row.Cells(1).FormattedValue) & "'," & Trim(did) & ",'" & Trim(dname) & "'," & Trim(cmbsem.SelectedValue) & ",'" & Trim(cmbsem.Text) & "','" & Trim(cmbsub.SelectedValue) & "','" & Trim(cmbsub.Text) & "','" & CStr(row.Cells(2).FormattedValue) & "')"
                            ElseIf recordexist = 1 Then
                                sql1 = "update IAmarks set subcode5='" & Trim(cmbsub.SelectedValue) & "',subname5='" & Trim(cmbsub.Text) & "',test53='" & CStr(row.Cells(2).FormattedValue) & "' where usn='" & CStr(row.Cells(0).FormattedValue) & "'"
                            End If

                        ElseIf subpriority = "Sub6" Then
                            If recordexist1 = 0 Then
                                sql = "INSERT INTO tempiamarks (usn,sname,deptid,dname,semid,semname,teston,sub6) VALUES ('" & CStr(row.Cells(0).FormattedValue) & "','" & CStr(row.Cells(1).FormattedValue) & "','" & Trim(did) & "','" & Trim(dname) & "','" & Trim(cmbsem.SelectedValue) & "','" & Trim(cmbsem.Text) & "','" & Trim(testtype) & "','" & CStr(row.Cells(2).FormattedValue) & "')"
                            ElseIf recordexist1 = 1 Then
                                sql = "update tempiamarks set sub6='" & CStr(row.Cells(2).FormattedValue) & "' where usn='" & CStr(row.Cells(0).FormattedValue) & "' and teston='" & Trim(testtype) & "'"
                            End If
                            If recordexist = 0 Then
                                sql1 = "INSERT INTO IAmarks (usn,sname,deptid,dname,semid,semname,subcode6,subname6,test63) VALUES ('" & CStr(row.Cells(0).FormattedValue) & "','" & CStr(row.Cells(1).FormattedValue) & "'," & Trim(did) & ",'" & Trim(dname) & "'," & Trim(cmbsem.SelectedValue) & ",'" & Trim(cmbsem.Text) & "','" & Trim(cmbsub.SelectedValue) & "','" & Trim(cmbsub.Text) & "','" & CStr(row.Cells(2).FormattedValue) & "')"
                            ElseIf recordexist = 1 Then
                                sql1 = "update IAmarks set subcode6='" & Trim(cmbsub.SelectedValue) & "',subname6='" & Trim(cmbsub.Text) & "',test63='" & CStr(row.Cells(2).FormattedValue) & "' where usn='" & CStr(row.Cells(0).FormattedValue) & "'"
                            End If
                        End If
                    ElseIf rbavg.Checked = True Then
                        testtype = "avg"
                        tbl = Fill_Table("SELECT * FROM  IAmarks where semid=" & Trim(cmbsem.SelectedValue) & " and deptid=" & Trim(did) & " and usn='" & CStr(row.Cells(0).FormattedValue) & "'", "IAmarks")
                        If tbl.Rows.Count > 0 Then
                            recordexist = 1
                        End If
                        tbl1 = Fill_Table("SELECT * FROM  tempiamarks where semid=" & Trim(cmbsem.SelectedValue) & " and deptid=" & Trim(did) & " and usn='" & CStr(row.Cells(0).FormattedValue) & "' and teston='" & Trim(testtype) & "'", "tempiamarks")
                        If tbl1.Rows.Count > 0 Then
                            recordexist1 = 1
                        End If
                        If subpriority = "Sub1" Then
                            If recordexist1 = 0 Then
                                sql = "INSERT INTO tempiamarks (usn,sname,deptid,dname,semid,semname,teston,sub1) VALUES ('" & CStr(row.Cells(0).FormattedValue) & "','" & CStr(row.Cells(1).FormattedValue) & "'," & Trim(did) & ",'" & Trim(dname) & "'," & Trim(cmbsem.SelectedValue) & ",'" & Trim(cmbsem.Text) & "','" & Trim(testtype) & "','" & CStr(row.Cells(2).FormattedValue) & "')"
                            ElseIf recordexist1 = 1 Then
                                sql = "update tempiamarks set sub1='" & CStr(row.Cells(2).FormattedValue) & "' where usn='" & CStr(row.Cells(0).FormattedValue) & "'and teston='" & Trim(testtype) & "'"
                            End If
                            If recordexist = 0 Then
                                sql1 = "INSERT INTO IAmarks (usn,sname,deptid,dname,semid,semname,subcode1,subname1,avg1) VALUES ('" & CStr(row.Cells(0).FormattedValue) & "','" & CStr(row.Cells(1).FormattedValue) & "'," & Trim(did) & ",'" & Trim(dname) & "'," & Trim(cmbsem.SelectedValue) & ",'" & Trim(cmbsem.Text) & "','" & Trim(cmbsub.SelectedValue) & "','" & Trim(cmbsub.Text) & "','" & CStr(row.Cells(2).FormattedValue) & "')"
                            ElseIf recordexist = 1 Then
                                sql1 = "update IAmarks set subcode1='" & Trim(cmbsub.SelectedValue) & "',subname1='" & Trim(cmbsub.Text) & "',avg1='" & CStr(row.Cells(2).FormattedValue) & "' where usn='" & CStr(row.Cells(0).FormattedValue) & "'"
                            End If
                        ElseIf subpriority = "Sub2" Then
                            If recordexist1 = 0 Then
                                sql = "INSERT INTO tempiamarks (usn,sname,deptid,dname,semid,semname,teston,sub2) VALUES ('" & CStr(row.Cells(0).FormattedValue) & "','" & CStr(row.Cells(1).FormattedValue) & "','" & Trim(did) & "','" & Trim(dname) & "','" & Trim(cmbsem.SelectedValue) & "','" & Trim(cmbsem.Text) & "','" & Trim(testtype) & "','" & CStr(row.Cells(2).FormattedValue) & "')"
                            ElseIf recordexist1 = 1 Then
                                sql = "update tempiamarks set sub2='" & CStr(row.Cells(2).FormattedValue) & "' where usn='" & CStr(row.Cells(0).FormattedValue) & "' and teston='" & Trim(testtype) & "'"
                            End If
                            If recordexist = 0 Then
                                sql1 = "INSERT INTO IAmarks (usn,sname,deptid,dname,semid,semname,subcode2,subname2,avg2) VALUES ('" & CStr(row.Cells(0).FormattedValue) & "','" & CStr(row.Cells(1).FormattedValue) & "'," & Trim(did) & ",'" & Trim(dname) & "'," & Trim(cmbsem.SelectedValue) & ",'" & Trim(cmbsem.Text) & "','" & Trim(cmbsub.SelectedValue) & "','" & Trim(cmbsub.Text) & "','" & CStr(row.Cells(2).FormattedValue) & "')"
                            ElseIf recordexist = 1 Then
                                sql1 = "update IAmarks set subcode2='" & Trim(cmbsub.SelectedValue) & "',subname2='" & Trim(cmbsub.Text) & "',avg2='" & CStr(row.Cells(2).FormattedValue) & "' where usn='" & CStr(row.Cells(0).FormattedValue) & "'"
                            End If

                        ElseIf subpriority = "Sub3" Then
                            If recordexist1 = 0 Then
                                sql = "INSERT INTO tempiamarks (usn,sname,deptid,dname,semid,semname,teston,sub3) VALUES ('" & CStr(row.Cells(0).FormattedValue) & "','" & CStr(row.Cells(1).FormattedValue) & "','" & Trim(did) & "','" & Trim(dname) & "','" & Trim(cmbsem.SelectedValue) & "','" & Trim(cmbsem.Text) & "','" & Trim(testtype) & "','" & CStr(row.Cells(2).FormattedValue) & "')"
                            ElseIf recordexist1 = 1 Then
                                sql = "update tempiamarks set sub3='" & CStr(row.Cells(2).FormattedValue) & "' where usn='" & CStr(row.Cells(0).FormattedValue) & "' and teston='" & Trim(testtype) & "'"
                            End If
                            If recordexist = 0 Then
                                sql1 = "INSERT INTO IAmarks (usn,sname,deptid,dname,semid,semname,subcode3,subname3,avg3) VALUES ('" & CStr(row.Cells(0).FormattedValue) & "','" & CStr(row.Cells(1).FormattedValue) & "'," & Trim(did) & ",'" & Trim(dname) & "'," & Trim(cmbsem.SelectedValue) & ",'" & Trim(cmbsem.Text) & "','" & Trim(cmbsub.SelectedValue) & "','" & Trim(cmbsub.Text) & "','" & CStr(row.Cells(2).FormattedValue) & "')"
                            ElseIf recordexist = 1 Then
                                sql1 = "update IAmarks set subcode3='" & Trim(cmbsub.SelectedValue) & "',subname3='" & Trim(cmbsub.Text) & "',avg3='" & CStr(row.Cells(2).FormattedValue) & "' where usn='" & CStr(row.Cells(0).FormattedValue) & "'"
                            End If

                        ElseIf subpriority = "Sub4" Then
                            If recordexist1 = 0 Then
                                sql = "INSERT INTO tempiamarks (usn,sname,deptid,dname,semid,semname,teston,sub4) VALUES ('" & CStr(row.Cells(0).FormattedValue) & "','" & CStr(row.Cells(1).FormattedValue) & "','" & Trim(did) & "','" & Trim(dname) & "','" & Trim(cmbsem.SelectedValue) & "','" & Trim(cmbsem.Text) & "','" & Trim(testtype) & "','" & CStr(row.Cells(2).FormattedValue) & "')"
                            ElseIf recordexist1 = 1 Then
                                sql = "update tempiamarks set sub4='" & CStr(row.Cells(2).FormattedValue) & "' where usn='" & CStr(row.Cells(0).FormattedValue) & "' and teston='" & Trim(testtype) & "'"
                            End If
                            If recordexist = 0 Then
                                sql1 = "INSERT INTO IAmarks (usn,sname,deptid,dname,semid,semname,subcode4,subname4,avg4) VALUES ('" & CStr(row.Cells(0).FormattedValue) & "','" & CStr(row.Cells(1).FormattedValue) & "'," & Trim(did) & ",'" & Trim(dname) & "'," & Trim(cmbsem.SelectedValue) & ",'" & Trim(cmbsem.Text) & "','" & Trim(cmbsub.SelectedValue) & "','" & Trim(cmbsub.Text) & "','" & CStr(row.Cells(2).FormattedValue) & "')"
                            ElseIf recordexist = 1 Then
                                sql1 = "update IAmarks set subcode4='" & Trim(cmbsub.SelectedValue) & "',subname4='" & Trim(cmbsub.Text) & "',avg4='" & CStr(row.Cells(2).FormattedValue) & "' where usn='" & CStr(row.Cells(0).FormattedValue) & "'"
                            End If

                        ElseIf subpriority = "Sub5" Then
                            If recordexist1 = 0 Then
                                sql = "INSERT INTO tempiamarks (usn,sname,deptid,dname,semid,semname,teston,sub5) VALUES ('" & CStr(row.Cells(0).FormattedValue) & "','" & CStr(row.Cells(1).FormattedValue) & "','" & Trim(did) & "','" & Trim(dname) & "','" & Trim(cmbsem.SelectedValue) & "','" & Trim(cmbsem.Text) & "','" & Trim(testtype) & "','" & CStr(row.Cells(2).FormattedValue) & "')"
                            ElseIf recordexist1 = 1 Then
                                sql = "update tempiamarks set sub5='" & CStr(row.Cells(2).FormattedValue) & "' where usn='" & CStr(row.Cells(0).FormattedValue) & "' and teston='" & Trim(testtype) & "'"
                            End If
                            If recordexist = 0 Then
                                sql1 = "INSERT INTO IAmarks (usn,sname,deptid,dname,semid,semname,subcode5,subname5,avg5) VALUES ('" & CStr(row.Cells(0).FormattedValue) & "','" & CStr(row.Cells(1).FormattedValue) & "'," & Trim(did) & ",'" & Trim(dname) & "'," & Trim(cmbsem.SelectedValue) & ",'" & Trim(cmbsem.Text) & "','" & Trim(cmbsub.SelectedValue) & "','" & Trim(cmbsub.Text) & "','" & CStr(row.Cells(2).FormattedValue) & "')"
                            ElseIf recordexist = 1 Then
                                sql1 = "update IAmarks set subcode5='" & Trim(cmbsub.SelectedValue) & "',subname5='" & Trim(cmbsub.Text) & "',avg5='" & CStr(row.Cells(2).FormattedValue) & "' where usn='" & CStr(row.Cells(0).FormattedValue) & "'"
                            End If

                        ElseIf subpriority = "Sub6" Then
                            If recordexist1 = 0 Then
                                sql = "INSERT INTO tempiamarks (usn,sname,deptid,dname,semid,semname,teston,sub6) VALUES ('" & CStr(row.Cells(0).FormattedValue) & "','" & CStr(row.Cells(1).FormattedValue) & "','" & Trim(did) & "','" & Trim(dname) & "','" & Trim(cmbsem.SelectedValue) & "','" & Trim(cmbsem.Text) & "','" & Trim(testtype) & "','" & CStr(row.Cells(2).FormattedValue) & "')"
                            ElseIf recordexist1 = 1 Then
                                sql = "update tempiamarks set sub6='" & CStr(row.Cells(2).FormattedValue) & "' where usn='" & CStr(row.Cells(0).FormattedValue) & "' and teston='" & Trim(testtype) & "'"
                            End If
                            If recordexist = 0 Then
                                sql1 = "INSERT INTO IAmarks (usn,sname,deptid,dname,semid,semname,subcode6,subname6,avg6) VALUES ('" & CStr(row.Cells(0).FormattedValue) & "','" & CStr(row.Cells(1).FormattedValue) & "'," & Trim(did) & ",'" & Trim(dname) & "'," & Trim(cmbsem.SelectedValue) & ",'" & Trim(cmbsem.Text) & "','" & Trim(cmbsub.SelectedValue) & "','" & Trim(cmbsub.Text) & "','" & CStr(row.Cells(2).FormattedValue) & "')"
                            ElseIf recordexist = 1 Then
                                sql1 = "update IAmarks set subcode6='" & Trim(cmbsub.SelectedValue) & "',subname6='" & Trim(cmbsub.Text) & "',avg6='" & CStr(row.Cells(2).FormattedValue) & "' where usn='" & CStr(row.Cells(0).FormattedValue) & "'"
                            End If

                        ElseIf subpriority = "Sub7" Then
                            If recordexist1 = 0 Then
                                sql = "INSERT INTO tempiamarks (usn,sname,deptid,dname,semid,semname,teston,sub7) VALUES ('" & CStr(row.Cells(0).FormattedValue) & "','" & CStr(row.Cells(1).FormattedValue) & "','" & Trim(did) & "','" & Trim(dname) & "','" & Trim(cmbsem.SelectedValue) & "','" & Trim(cmbsem.Text) & "','" & Trim(testtype) & "','" & CStr(row.Cells(2).FormattedValue) & "')"
                            ElseIf recordexist1 = 1 Then
                                sql = "update tempiamarks set sub7='" & CStr(row.Cells(2).FormattedValue) & "' where usn='" & CStr(row.Cells(0).FormattedValue) & "' and teston='" & Trim(testtype) & "'"
                            End If
                            If recordexist = 0 Then
                                sql1 = "INSERT INTO IAmarks (usn,sname,deptid,dname,semid,semname,subcode7,subname7,avg7) VALUES ('" & CStr(row.Cells(0).FormattedValue) & "','" & CStr(row.Cells(1).FormattedValue) & "'," & Trim(did) & ",'" & Trim(dname) & "'," & Trim(cmbsem.SelectedValue) & ",'" & Trim(cmbsem.Text) & "','" & Trim(cmbsub.SelectedValue) & "','" & Trim(cmbsub.Text) & "','" & CStr(row.Cells(2).FormattedValue) & "')"
                            ElseIf recordexist = 1 Then
                                sql1 = "update IAmarks set subcode7='" & Trim(cmbsub.SelectedValue) & "',subname7='" & Trim(cmbsub.Text) & "',avg7='" & CStr(row.Cells(2).FormattedValue) & "' where usn='" & CStr(row.Cells(0).FormattedValue) & "'"
                            End If
                        ElseIf subpriority = "Sub8" Then
                            If recordexist1 = 0 Then
                                sql = "INSERT INTO tempiamarks (usn,sname,deptid,dname,semid,semname,teston,sub8) VALUES ('" & CStr(row.Cells(0).FormattedValue) & "','" & CStr(row.Cells(1).FormattedValue) & "','" & Trim(did) & "','" & Trim(dname) & "','" & Trim(cmbsem.SelectedValue) & "','" & Trim(cmbsem.Text) & "','" & Trim(testtype) & "','" & CStr(row.Cells(2).FormattedValue) & "')"
                            ElseIf recordexist1 = 1 Then
                                sql = "update tempiamarks set sub8='" & CStr(row.Cells(2).FormattedValue) & "' where usn='" & CStr(row.Cells(0).FormattedValue) & "' and teston='" & Trim(testtype) & "'"
                            End If
                            If recordexist = 0 Then
                                sql1 = "INSERT INTO IAmarks (usn,sname,deptid,dname,semid,semname,subcode8,subname8,avg8) VALUES ('" & CStr(row.Cells(0).FormattedValue) & "','" & CStr(row.Cells(1).FormattedValue) & "'," & Trim(did) & ",'" & Trim(dname) & "'," & Trim(cmbsem.SelectedValue) & ",'" & Trim(cmbsem.Text) & "','" & Trim(cmbsub.SelectedValue) & "','" & Trim(cmbsub.Text) & "','" & CStr(row.Cells(2).FormattedValue) & "')"
                            ElseIf recordexist = 1 Then
                                sql1 = "update IAmarks set subcode8='" & Trim(cmbsub.SelectedValue) & "',subname8='" & Trim(cmbsub.Text) & "',avg8='" & CStr(row.Cells(2).FormattedValue) & "' where usn='" & CStr(row.Cells(0).FormattedValue) & "'"
                            End If
                        End If
                    End If

                    'Set your MySQL COMMANDS
                    If con.State = ConnectionState.Closed Then con.Open()

                    'With cmd
                    '    .Connection = con
                    '    .CommandText = sql
                    'End With
                    'With cmd1
                    '    .Connection = con
                    '    .CommandText = sql1
                    'End With
                    'Execute the Data
                    result = ExecuteQueriess(sql)
                    result1 = ExecuteQueriess(sql1)
                    'result = cmd.ExecuteNonQuery()

                    'result1 = cmd1.ExecuteNonQuery()
                End If
            Next
            'the condition is, if the result is equals to zero
            'then the message will appear and says "No saved Record."
            'and if not the message will appear and says "All Records Saved."
            If result = 0 And result1 = 0 Then
                MsgBox("All Records Inserted.")
            Else
                MsgBox("No saved Record.")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'Close the connection
        'con.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If rbtest1.Checked = False And rbtest2.Checked = False And rbtest2.Checked = False And rbavg.Checked = False Then
            MsgBox("Please select the test, marks to be entered")
            Exit Sub
        End If
        savegrid()
    End Sub

    Private Sub cmbsem_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbsem.SelectedIndexChanged
        Try
            If cmbsem.SelectedValue <> 0 Then
                FillCombo(cmbsub, "facultydetails", "fsubid", "fsubname", "facultyid='" & Trim(username) & "' and fsemid=" & Trim(cmbsem.SelectedValue) & "")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmbsub_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbsub.SelectedIndexChanged

        Try

       
            Dim tbl As New DataTable
            tbl = Fill_Table("SELECT *  FROM  subjectdetails where  subcode='" & Trim(cmbsub.SelectedValue) & "'  ", "subjectdetails")
            If tbl.Rows.Count > 0 Then

                subpriority = tbl.Rows(0).Item("subpriority")

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnfillgrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfillgrid.Click
        Try

        
            populategrid()
            Dim tbl As New DataTable
            tbl = Fill_Table("SELECT *  FROM  subjectdetails where  subcode='" & Trim(cmbsub.SelectedValue) & "'  ", "subjectdetails")
            If tbl.Rows.Count > 0 Then
                maxmarks = tbl.Rows(0).Item("maxmarks")

            End If
            Dim column As DataGridViewColumn = DataGridView1.Columns(0)
            column.Width = 60
        Catch ex As Exception

            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try

      
            Dim MAXMKS As Integer
            Dim i As Integer


            If e.RowIndex > 0 Then
                i = e.RowIndex - 1
                Dim selectedrow As DataGridViewRow
                selectedrow = DataGridView1.Rows(i)
                MAXMKS = selectedrow.Cells(2).Value


                If MAXMKS > maxmarks Then
                    MsgBox("Marks should be less than or equal to " & maxmarks)
                End If


            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    'Private Sub btncalavg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    'Dim tbl As New DataTable
    '    'Dim t1, t2, t3 As Integer
    '    'If rbavg.Checked = True Then
    '    '    For Each row As DataGridViewRow In DataGridView1.Rows
    '    '        If row.Cells(0).FormattedValue <> "" Or row.Cells(1).FormattedValue <> "" Then
    '    '            If subpriority = "Sub1" Then
    '    '                tbl = Fill_Table("SELECT *  FROM  IAmarks where  subcode1='" & Trim(cmbsub.SelectedValue) & "' and usn='" & CStr(row.Cells(0).FormattedValue) & "'  ", "IAmarks")
    '    '                If tbl.Rows.Count > 0 Then
    '    '                    t1 = tbl.Rows(0).Item("test11")
    '    '                    t2 = tbl.Rows(0).Item("test12")
    '    '                    t3 = tbl.Rows(0).Item("test13")
    '    '                    If t1 > t2 Then

    '    '                    End If
    '    '                End If


    '    '            End If
    '    '        End If
    '    '    Next


    '    'End If
    'End Sub

    


   
    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class