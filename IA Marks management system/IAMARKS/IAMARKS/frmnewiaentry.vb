Public Class frmnewiaentry
    Dim did As Integer
    Dim dname, sname As String
    Dim maxmarks As Integer
    Private Sub lblusn_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblusn.TextChanged
        Try
            Dim tbl As New DataTable
            tbl = Fill_Table("SELECT * FROM  studentdetails where usn='" & Trim(lblusn.Text) & "'  ", "studentdetails")
            If tbl.Rows.Count > 0 Then
                'lblusn.Text = tbl.Rows(0).Item("usn") & ""
                lblsname.Text = tbl.Rows(0).Item("sname") & ""
                lblsem.Text = tbl.Rows(0).Item("semid") & ""
                sname = tbl.Rows(0).Item("semname") & ""
                did = tbl.Rows(0).Item("deptid") & ""
                dname = tbl.Rows(0).Item("deptname") & ""
                Try
                    If lblsem.Text <> "" Then
                        FillCombo(cmbsub, "facultydetails", "fsubid", "fsubname", "facultyid='" & Trim(username) & "' and fsemid=" & Trim(lblsem.Text) & "")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub frmnewiaentry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If rbtest1.Checked = False And rbtest2.Checked = False And rbtest3.Checked = False And rbavg.Checked = False Then
            MsgBox("Please select the test, marks to be entered")
            Exit Sub
        End If
        savegrid()

    End Sub
    Public Sub savegrid()
        Dim sql, sql1, testtype As String
        Dim result, result1 As Integer
        Dim marks As Integer = 0


        Try
            marks=int(txtmarks.Text)
            'oppening the connection
            Dim tbl, tbl1 As New DataTable
            Dim recordexist, recordexist1 As Integer
            recordexist = 0
            recordexist1 = 0
            'con.Open()
            'DataGridViewRow represents a row in the DataGridView Control
            'Rows is to get the collection of rows in the DataGridView control
            'the syntax is , getting the rows one by one
            'For Each row As DataGridViewRow In DataGridView1.Rows
            'Cells is to get the collection of cell that populate the row
            'FormattedValue is to get the value of the cell as formtted for display
            'the condition is, if the cell is not empty then it save to the database
            'If row.Cells(0).FormattedValue <> "" Or row.Cells(1).FormattedValue <> "" Then
            'store your query to a variable(sql)
            If rbtest1.Checked = True Then
                testtype = "Test1"
                tbl = Fill_Table("SELECT * FROM  IAmarks where semid=" & Trim(lblsem.Text) & " and deptid=" & Trim(did) & " and usn='" & Trim(lblusn.Text) & "'", "IAmarks")
                If tbl.Rows.Count > 0 Then
                    recordexist = 1
                End If
                tbl1 = Fill_Table("SELECT * FROM  tempiamarks where semid=" & Trim(lblsem.Text) & " and deptid=" & Trim(did) & " and usn='" & Trim(lblusn.Text) & "' and teston='" & Trim(testtype) & "'", "tempiamarks")
                If tbl1.Rows.Count > 0 Then
                    recordexist1 = 1
                End If
                If subpriority = "Sub1" Then
                    If recordexist1 = 0 Then
                        sql = "INSERT INTO tempiamarks (usn,sname,deptid,dname,semid,semname,teston,sub1) VALUES ('" & Trim(lblusn.Text) & "','" & Trim(lblsname.Text) & "'," & Trim(did) & ",'" & Trim(dname) & "'," & Trim(lblsem.Text) & ",'" & Trim(sname) & "','" & Trim(testtype) & "','" & Trim(marks) & "')"
                    ElseIf recordexist1 = 1 Then
                        sql = "update tempiamarks set sub1='" & Trim(marks) & "' where usn='" & Trim(lblusn.Text) & "'and teston='" & Trim(testtype) & "'"
                    End If
                    If recordexist = 0 Then
                        sql1 = "INSERT INTO IAmarks (usn,sname,deptid,dname,semid,semname,subcode1,subname1,test11) VALUES ('" & Trim(lblusn.Text) & "','" & Trim(lblsname.Text) & "'," & Trim(did) & ",'" & Trim(dname) & "'," & Trim(lblsem.Text) & ",'" & Trim(sname) & "','" & Trim(cmbsub.SelectedValue) & "','" & Trim(cmbsub.Text) & "','" & Trim(marks) & "')"
                    ElseIf recordexist = 1 Then
                        sql1 = "update IAmarks set subcode1='" & Trim(cmbsub.SelectedValue) & "',subname1='" & Trim(cmbsub.Text) & "',test11='" & Trim(marks) & "' where usn='" & Trim(lblusn.Text) & "'"
                    End If
                ElseIf subpriority = "Sub2" Then
                    If recordexist1 = 0 Then
                        sql = "INSERT INTO tempiamarks (usn,sname,deptid,dname,semid,semname,teston,sub2) VALUES ('" & Trim(lblusn.Text) & "','" & Trim(lblsname.Text) & "','" & Trim(did) & "','" & Trim(dname) & "','" & Trim(lblsem.Text) & "','" & Trim(sname) & "','" & Trim(testtype) & "','" & Trim(marks) & "')"
                    ElseIf recordexist1 = 1 Then
                        sql = "update tempiamarks set sub2='" & Trim(marks) & "' where usn='" & Trim(lblusn.Text) & "' and teston='" & Trim(testtype) & "'"
                    End If
                    If recordexist = 0 Then
                        sql1 = "INSERT INTO IAmarks (usn,sname,deptid,dname,semid,semname,subcode2,subname2,test21) VALUES ('" & Trim(lblusn.Text) & "','" & Trim(lblsname.Text) & "'," & Trim(did) & ",'" & Trim(dname) & "'," & Trim(lblsem.Text) & ",'" & Trim(sname) & "','" & Trim(cmbsub.SelectedValue) & "','" & Trim(cmbsub.Text) & "','" & Trim(marks) & "')"
                    ElseIf recordexist = 1 Then
                        sql1 = "update IAmarks set subcode2='" & Trim(cmbsub.SelectedValue) & "',subname2='" & Trim(cmbsub.Text) & "',test21='" & Trim(marks) & "' where usn='" & Trim(lblusn.Text) & "'"
                    End If

                ElseIf subpriority = "Sub3" Then
                    If recordexist1 = 0 Then
                        sql = "INSERT INTO tempiamarks (usn,sname,deptid,dname,semid,semname,teston,sub3) VALUES ('" & Trim(lblusn.Text) & "','" & Trim(lblsname.Text) & "','" & Trim(did) & "','" & Trim(dname) & "','" & Trim(lblsem.Text) & "','" & Trim(sname) & "','" & Trim(testtype) & "','" & Trim(marks) & "')"
                    ElseIf recordexist1 = 1 Then
                        sql = "update tempiamarks set sub3='" & Trim(marks) & "' where usn='" & Trim(lblusn.Text) & "' and teston='" & Trim(testtype) & "'"
                    End If
                    If recordexist = 0 Then
                        sql1 = "INSERT INTO IAmarks (usn,sname,deptid,dname,semid,semname,subcode3,subname3,test31) VALUES ('" & Trim(lblusn.Text) & "','" & Trim(lblsname.Text) & "'," & Trim(did) & ",'" & Trim(dname) & "'," & Trim(lblsem.Text) & ",'" & Trim(sname) & "','" & Trim(cmbsub.SelectedValue) & "','" & Trim(cmbsub.Text) & "','" & Trim(marks) & "')"
                    ElseIf recordexist = 1 Then
                        sql1 = "update IAmarks set subcode3='" & Trim(cmbsub.SelectedValue) & "',subname3='" & Trim(cmbsub.Text) & "',test31='" & Trim(marks) & "' where usn='" & Trim(lblusn.Text) & "'"
                    End If

                ElseIf subpriority = "Sub4" Then
                    If recordexist1 = 0 Then
                        sql = "INSERT INTO tempiamarks (usn,sname,deptid,dname,semid,semname,teston,sub4) VALUES ('" & Trim(lblusn.Text) & "','" & Trim(lblsname.Text) & "','" & Trim(did) & "','" & Trim(dname) & "','" & Trim(lblsem.Text) & "','" & Trim(sname) & "','" & Trim(testtype) & "','" & Trim(marks) & "')"
                    ElseIf recordexist1 = 1 Then
                        sql = "update tempiamarks set sub4='" & Trim(marks) & "' where usn='" & Trim(lblusn.Text) & "' and teston='" & Trim(testtype) & "'"
                    End If
                    If recordexist = 0 Then
                        sql1 = "INSERT INTO IAmarks (usn,sname,deptid,dname,semid,semname,subcode4,subname4,test41) VALUES ('" & Trim(lblusn.Text) & "','" & Trim(lblsname.Text) & "'," & Trim(did) & ",'" & Trim(dname) & "'," & Trim(lblsem.Text) & ",'" & Trim(sname) & "','" & Trim(cmbsub.SelectedValue) & "','" & Trim(cmbsub.Text) & "','" & Trim(marks) & "')"
                    ElseIf recordexist = 1 Then
                        sql1 = "update IAmarks set subcode4='" & Trim(cmbsub.SelectedValue) & "',subname4='" & Trim(cmbsub.Text) & "',test41='" & Trim(marks) & "' where usn='" & Trim(lblusn.Text) & "'"
                    End If

                ElseIf subpriority = "Sub5" Then
                    If recordexist1 = 0 Then
                        sql = "INSERT INTO tempiamarks (usn,sname,deptid,dname,semid,semname,teston,sub5) VALUES ('" & Trim(lblusn.Text) & "','" & Trim(lblsname.Text) & "','" & Trim(did) & "','" & Trim(dname) & "','" & Trim(lblsem.Text) & "','" & Trim(sname) & "','" & Trim(testtype) & "','" & Trim(marks) & "')"
                    ElseIf recordexist1 = 1 Then
                        sql = "update tempiamarks set sub5='" & Trim(marks) & "' where usn='" & Trim(lblusn.Text) & "' and teston='" & Trim(testtype) & "'"
                    End If
                    If recordexist = 0 Then
                        sql1 = "INSERT INTO IAmarks (usn,sname,deptid,dname,semid,semname,subcode5,subname5,test51) VALUES ('" & Trim(lblusn.Text) & "','" & Trim(lblsname.Text) & "'," & Trim(did) & ",'" & Trim(dname) & "'," & Trim(lblsem.Text) & ",'" & Trim(sname) & "','" & Trim(cmbsub.SelectedValue) & "','" & Trim(cmbsub.Text) & "','" & Trim(marks) & "')"
                    ElseIf recordexist = 1 Then
                        sql1 = "update IAmarks set subcode5='" & Trim(cmbsub.SelectedValue) & "',subname5='" & Trim(cmbsub.Text) & "',test51='" & Trim(marks) & "' where usn='" & Trim(lblusn.Text) & "'"
                    End If

                ElseIf subpriority = "Sub6" Then
                    If recordexist1 = 0 Then
                        sql = "INSERT INTO tempiamarks (usn,sname,deptid,dname,semid,semname,teston,sub6) VALUES ('" & Trim(lblusn.Text) & "','" & Trim(lblsname.Text) & "','" & Trim(did) & "','" & Trim(dname) & "','" & Trim(lblsem.Text) & "','" & Trim(sname) & "','" & Trim(testtype) & "','" & Trim(marks) & "')"
                    ElseIf recordexist1 = 1 Then
                        sql = "update tempiamarks set sub6='" & Trim(marks) & "' where usn='" & Trim(lblusn.Text) & "' and teston='" & Trim(testtype) & "'"
                    End If
                    If recordexist = 0 Then
                        sql1 = "INSERT INTO IAmarks (usn,sname,deptid,dname,semid,semname,subcode6,subname6,test61) VALUES ('" & Trim(lblusn.Text) & "','" & Trim(lblsname.Text) & "'," & Trim(did) & ",'" & Trim(dname) & "'," & Trim(lblsem.Text) & ",'" & Trim(sname) & "','" & Trim(cmbsub.SelectedValue) & "','" & Trim(cmbsub.Text) & "','" & Trim(marks) & "')"
                    ElseIf recordexist = 1 Then
                        sql1 = "update IAmarks set subcode6='" & Trim(cmbsub.SelectedValue) & "',subname6='" & Trim(cmbsub.Text) & "',test61='" & Trim(marks) & "' where usn='" & Trim(lblusn.Text) & "'"
                    End If

                ElseIf subpriority = "Sub7" Then
                    If recordexist1 = 0 Then
                        sql = "INSERT INTO tempiamarks (usn,sname,deptid,dname,semid,semname,teston,sub7) VALUES ('" & Trim(lblusn.Text) & "','" & Trim(lblsname.Text) & "','" & Trim(did) & "','" & Trim(dname) & "','" & Trim(lblsem.Text) & "','" & Trim(sname) & "','" & Trim(testtype) & "','" & Trim(marks) & "')"
                    ElseIf recordexist1 = 1 Then
                        sql = "update tempiamarks set sub7='" & Trim(marks) & "' where usn='" & Trim(lblusn.Text) & "' and teston='" & Trim(testtype) & "'"
                    End If
                    If recordexist = 0 Then
                        sql1 = "INSERT INTO IAmarks (usn,sname,deptid,dname,semid,semname,subcode7,subname7,test71) VALUES ('" & Trim(lblusn.Text) & "','" & Trim(lblsname.Text) & "'," & Trim(did) & ",'" & Trim(dname) & "'," & Trim(lblsem.Text) & ",'" & Trim(sname) & "','" & Trim(cmbsub.SelectedValue) & "','" & Trim(cmbsub.Text) & "','" & Trim(marks) & "')"
                    ElseIf recordexist = 1 Then
                        sql1 = "update IAmarks set subcode7='" & Trim(cmbsub.SelectedValue) & "',subname7='" & Trim(cmbsub.Text) & "',test71='" & Trim(marks) & "' where usn='" & Trim(lblusn.Text) & "'"
                    End If
                ElseIf subpriority = "Sub8" Then
                    If recordexist1 = 0 Then
                        sql = "INSERT INTO tempiamarks (usn,sname,deptid,dname,semid,semname,teston,sub8) VALUES ('" & Trim(lblusn.Text) & "','" & Trim(lblsname.Text) & "','" & Trim(did) & "','" & Trim(dname) & "','" & Trim(lblsem.Text) & "','" & Trim(sname) & "','" & Trim(testtype) & "','" & Trim(marks) & "')"
                    ElseIf recordexist1 = 1 Then
                        sql = "update tempiamarks set sub8='" & Trim(marks) & "' where usn='" & Trim(lblusn.Text) & "' and teston='" & Trim(testtype) & "'"
                    End If
                    If recordexist = 0 Then
                        sql1 = "INSERT INTO IAmarks (usn,sname,deptid,dname,semid,semname,subcode8,subname8,test81) VALUES ('" & Trim(lblusn.Text) & "','" & Trim(lblsname.Text) & "'," & Trim(did) & ",'" & Trim(dname) & "'," & Trim(lblsem.Text) & ",'" & Trim(sname) & "','" & Trim(cmbsub.SelectedValue) & "','" & Trim(cmbsub.Text) & "','" & Trim(marks) & "')"
                    ElseIf recordexist = 1 Then
                        sql1 = "update IAmarks set subcode8='" & Trim(cmbsub.SelectedValue) & "',subname8='" & Trim(cmbsub.Text) & "',test81='" & Trim(marks) & "' where usn='" & Trim(lblusn.Text) & "'"
                    End If
                End If

            ElseIf rbtest2.Checked = True Then
                testtype = "Test2"
                tbl = Fill_Table("SELECT * FROM  IAmarks where semid=" & Trim(lblsem.Text) & " and deptid=" & Trim(did) & " and usn='" & Trim(lblusn.Text) & "'", "IAmarks")
                If tbl.Rows.Count > 0 Then
                    recordexist = 1
                End If
                tbl1 = Fill_Table("SELECT * FROM  tempiamarks where semid=" & Trim(lblsem.Text) & " and deptid=" & Trim(did) & " and usn='" & Trim(lblusn.Text) & "' and teston='" & Trim(testtype) & "'", "tempiamarks")
                If tbl1.Rows.Count > 0 Then
                    recordexist1 = 1
                End If
                If subpriority = "Sub1" Then
                    If recordexist1 = 0 Then
                        sql = "INSERT INTO tempiamarks (usn,sname,deptid,dname,semid,semname,teston,sub1) VALUES ('" & Trim(lblusn.Text) & "','" & Trim(lblsname.Text) & "'," & Trim(did) & ",'" & Trim(dname) & "'," & Trim(lblsem.Text) & ",'" & Trim(sname) & "','" & Trim(testtype) & "','" & Trim(marks) & "')"
                    ElseIf recordexist1 = 1 Then
                        sql = "update tempiamarks set sub1='" & Trim(marks) & "' where usn='" & Trim(lblusn.Text) & "' and teston='" & Trim(testtype) & "'"
                    End If
                    If recordexist = 0 Then
                        sql1 = "INSERT INTO IAmarks (usn,sname,deptid,dname,semid,semname,subcode1,subname1,test12) VALUES ('" & Trim(lblusn.Text) & "','" & Trim(lblsname.Text) & "'," & Trim(did) & ",'" & Trim(dname) & "'," & Trim(lblsem.Text) & ",'" & Trim(sname) & "','" & Trim(cmbsub.SelectedValue) & "','" & Trim(cmbsub.Text) & "','" & Trim(marks) & "')"
                    ElseIf recordexist = 1 Then
                        sql1 = "update IAmarks set subcode1='" & Trim(cmbsub.SelectedValue) & "',subname1='" & Trim(cmbsub.Text) & "',test12='" & Trim(marks) & "' where usn='" & Trim(lblusn.Text) & "'"
                    End If
                ElseIf subpriority = "Sub2" Then
                    If recordexist1 = 0 Then
                        sql = "INSERT INTO tempiamarks (usn,sname,deptid,dname,semid,semname,teston,sub2) VALUES ('" & Trim(lblusn.Text) & "','" & Trim(lblsname.Text) & "','" & Trim(did) & "','" & Trim(dname) & "','" & Trim(lblsem.Text) & "','" & Trim(sname) & "','" & Trim(testtype) & "','" & Trim(marks) & "')"
                    ElseIf recordexist1 = 1 Then
                        sql = "update tempiamarks set sub2='" & Trim(marks) & "' where usn='" & Trim(lblusn.Text) & "' and teston='" & Trim(testtype) & "'"
                    End If
                    If recordexist = 0 Then
                        sql1 = "INSERT INTO IAmarks (usn,sname,deptid,dname,semid,semname,subcode2,subname2,test22) VALUES ('" & Trim(lblusn.Text) & "','" & Trim(lblsname.Text) & "'," & Trim(did) & ",'" & Trim(dname) & "'," & Trim(lblsem.Text) & ",'" & Trim(sname) & "','" & Trim(cmbsub.SelectedValue) & "','" & Trim(cmbsub.Text) & "','" & Trim(marks) & "')"
                    ElseIf recordexist = 1 Then
                        sql1 = "update IAmarks set subcode2='" & Trim(cmbsub.SelectedValue) & "',subname2='" & Trim(cmbsub.Text) & "',test22='" & Trim(marks) & "' where usn='" & Trim(lblusn.Text) & "'"
                    End If

                ElseIf subpriority = "Sub3" Then

                    If recordexist1 = 0 Then
                        sql = "INSERT INTO tempiamarks (usn,sname,deptid,dname,semid,semname,teston,sub3) VALUES ('" & Trim(lblusn.Text) & "','" & Trim(lblsname.Text) & "','" & Trim(did) & "','" & Trim(dname) & "','" & Trim(lblsem.Text) & "','" & Trim(sname) & "','" & Trim(testtype) & "','" & Trim(marks) & "')"
                    ElseIf recordexist1 = 1 Then
                        sql = "update tempiamarks set sub3='" & Trim(marks) & "' where usn='" & Trim(lblusn.Text) & "' and teston='" & Trim(testtype) & "'"
                    End If
                    If recordexist = 0 Then
                        sql1 = "INSERT INTO IAmarks (usn,sname,deptid,dname,semid,semname,subcode3,subname3,test32) VALUES ('" & Trim(lblusn.Text) & "','" & Trim(lblsname.Text) & "'," & Trim(did) & ",'" & Trim(dname) & "'," & Trim(lblsem.Text) & ",'" & Trim(sname) & "','" & Trim(cmbsub.SelectedValue) & "','" & Trim(cmbsub.Text) & "','" & Trim(marks) & "')"
                    ElseIf recordexist = 1 Then
                        sql1 = "update IAmarks set subcode3='" & Trim(cmbsub.SelectedValue) & "',subname3='" & Trim(cmbsub.Text) & "',test32='" & Trim(marks) & "' where usn='" & Trim(lblusn.Text) & "'"
                    End If

                ElseIf subpriority = "Sub4" Then
                    If recordexist1 = 0 Then
                        sql = "INSERT INTO tempiamarks (usn,sname,deptid,dname,semid,semname,teston,sub4) VALUES ('" & Trim(lblusn.Text) & "','" & Trim(lblsname.Text) & "','" & Trim(did) & "','" & Trim(dname) & "','" & Trim(lblsem.Text) & "','" & Trim(sname) & "','" & Trim(testtype) & "','" & Trim(marks) & "')"
                    ElseIf recordexist1 = 1 Then
                        sql = "update tempiamarks set sub4='" & Trim(marks) & "' where usn='" & Trim(lblusn.Text) & "' and teston='" & Trim(testtype) & "'"
                    End If
                    If recordexist = 0 Then
                        sql1 = "INSERT INTO IAmarks (usn,sname,deptid,dname,semid,semname,subcode4,subname4,test42) VALUES ('" & Trim(lblusn.Text) & "','" & Trim(lblsname.Text) & "'," & Trim(did) & ",'" & Trim(dname) & "'," & Trim(lblsem.Text) & ",'" & Trim(sname) & "','" & Trim(cmbsub.SelectedValue) & "','" & Trim(cmbsub.Text) & "','" & Trim(marks) & "')"
                    ElseIf recordexist = 1 Then
                        sql1 = "update IAmarks set subcode4='" & Trim(cmbsub.SelectedValue) & "',subname4='" & Trim(cmbsub.Text) & "',test42='" & Trim(marks) & "' where usn='" & Trim(lblusn.Text) & "'"
                    End If

                ElseIf subpriority = "Sub5" Then
                    If recordexist1 = 0 Then
                        sql = "INSERT INTO tempiamarks (usn,sname,deptid,dname,semid,semname,teston,sub5) VALUES ('" & Trim(lblusn.Text) & "','" & Trim(lblsname.Text) & "','" & Trim(did) & "','" & Trim(dname) & "','" & Trim(lblsem.Text) & "','" & Trim(sname) & "','" & Trim(testtype) & "','" & Trim(marks) & "')"
                    ElseIf recordexist1 = 1 Then
                        sql = "update tempiamarks set sub5='" & Trim(marks) & "' where usn='" & Trim(lblusn.Text) & "' and teston='" & Trim(testtype) & "'"
                    End If
                    If recordexist = 0 Then
                        sql1 = "INSERT INTO IAmarks (usn,sname,deptid,dname,semid,semname,subcode5,subname5,test52) VALUES ('" & Trim(lblusn.Text) & "','" & Trim(lblsname.Text) & "'," & Trim(did) & ",'" & Trim(dname) & "'," & Trim(lblsem.Text) & ",'" & Trim(sname) & "','" & Trim(cmbsub.SelectedValue) & "','" & Trim(cmbsub.Text) & "','" & Trim(marks) & "')"
                    ElseIf recordexist = 1 Then
                        sql1 = "update IAmarks set subcode5='" & Trim(cmbsub.SelectedValue) & "',subname5='" & Trim(cmbsub.Text) & "',test52='" & Trim(marks) & "' where usn='" & Trim(lblusn.Text) & "'"
                    End If

                ElseIf subpriority = "Sub6" Then
                    If recordexist1 = 0 Then
                        sql = "INSERT INTO tempiamarks (usn,sname,deptid,dname,semid,semname,teston,sub6) VALUES ('" & Trim(lblusn.Text) & "','" & Trim(lblsname.Text) & "','" & Trim(did) & "','" & Trim(dname) & "','" & Trim(lblsem.Text) & "','" & Trim(sname) & "','" & Trim(testtype) & "','" & Trim(marks) & "')"
                    ElseIf recordexist1 = 1 Then
                        sql = "update tempiamarks set sub6='" & Trim(marks) & "' where usn='" & Trim(lblusn.Text) & "' and teston='" & Trim(testtype) & "'"
                    End If
                    If recordexist = 0 Then
                        sql1 = "INSERT INTO IAmarks (usn,sname,deptid,dname,semid,semname,subcode6,subname6,test62) VALUES ('" & Trim(lblusn.Text) & "','" & Trim(lblsname.Text) & "'," & Trim(did) & ",'" & Trim(dname) & "'," & Trim(lblsem.Text) & ",'" & Trim(sname) & "','" & Trim(cmbsub.SelectedValue) & "','" & Trim(cmbsub.Text) & "','" & Trim(marks) & "')"
                    ElseIf recordexist = 1 Then
                        sql1 = "update IAmarks set subcode6='" & Trim(cmbsub.SelectedValue) & "',subname6='" & Trim(cmbsub.Text) & "',test62='" & Trim(marks) & "' where usn='" & Trim(lblusn.Text) & "'"
                    End If

                ElseIf subpriority = "Sub7" Then
                    If recordexist1 = 0 Then
                        sql = "INSERT INTO tempiamarks (usn,sname,deptid,dname,semid,semname,teston,sub7) VALUES ('" & Trim(lblusn.Text) & "','" & Trim(lblsname.Text) & "','" & Trim(did) & "','" & Trim(dname) & "','" & Trim(lblsem.Text) & "','" & Trim(sname) & "','" & Trim(testtype) & "','" & Trim(marks) & "')"
                    ElseIf recordexist1 = 1 Then
                        sql = "update tempiamarks set sub7='" & Trim(marks) & "' where usn='" & Trim(lblusn.Text) & "' and teston='" & Trim(testtype) & "'"
                    End If
                    If recordexist = 0 Then
                        sql1 = "INSERT INTO IAmarks (usn,sname,deptid,dname,semid,semname,subcode7,subname7,test72) VALUES ('" & Trim(lblusn.Text) & "','" & Trim(lblsname.Text) & "'," & Trim(did) & ",'" & Trim(dname) & "'," & Trim(lblsem.Text) & ",'" & Trim(sname) & "','" & Trim(cmbsub.SelectedValue) & "','" & Trim(cmbsub.Text) & "','" & Trim(marks) & "')"
                    ElseIf recordexist = 1 Then
                        sql1 = "update IAmarks set subcode7='" & Trim(cmbsub.SelectedValue) & "',subname7='" & Trim(cmbsub.Text) & "',test72='" & Trim(marks) & "' where usn='" & Trim(lblusn.Text) & "'"
                    End If
                ElseIf subpriority = "Sub8" Then
                    If recordexist1 = 0 Then
                        sql = "INSERT INTO tempiamarks (usn,sname,deptid,dname,semid,semname,teston,sub8) VALUES ('" & Trim(lblusn.Text) & "','" & Trim(lblsname.Text) & "','" & Trim(did) & "','" & Trim(dname) & "','" & Trim(lblsem.Text) & "','" & Trim(sname) & "','" & Trim(testtype) & "','" & Trim(marks) & "')"
                    ElseIf recordexist1 = 1 Then
                        sql = "update tempiamarks set sub8='" & Trim(marks) & "' where usn='" & Trim(lblusn.Text) & "' and teston='" & Trim(testtype) & "'"
                    End If
                    If recordexist = 0 Then
                        sql1 = "INSERT INTO IAmarks (usn,sname,deptid,dname,semid,semname,subcode8,subname8,test82) VALUES ('" & Trim(lblusn.Text) & "','" & Trim(lblsname.Text) & "'," & Trim(did) & ",'" & Trim(dname) & "'," & Trim(lblsem.Text) & ",'" & Trim(sname) & "','" & Trim(cmbsub.SelectedValue) & "','" & Trim(cmbsub.Text) & "','" & Trim(marks) & "')"
                    ElseIf recordexist = 1 Then
                        sql1 = "update IAmarks set subcode8='" & Trim(cmbsub.SelectedValue) & "',subname8='" & Trim(cmbsub.Text) & "',test82='" & Trim(marks) & "' where usn='" & Trim(lblusn.Text) & "'"
                    End If
                End If

            ElseIf rbtest3.Checked = True Then
                testtype = "Test3"
                tbl = Fill_Table("SELECT * FROM  IAmarks where semid=" & Trim(lblsem.Text) & " and deptid=" & Trim(did) & " and usn='" & Trim(lblusn.Text) & "'", "IAmarks")
                If tbl.Rows.Count > 0 Then
                    recordexist = 1
                End If
                tbl1 = Fill_Table("SELECT * FROM  tempiamarks where semid=" & Trim(lblsem.Text) & " and deptid=" & Trim(did) & " and usn='" & Trim(lblusn.Text) & "' and teston='" & Trim(testtype) & "'", "tempiamarks")
                If tbl1.Rows.Count > 0 Then
                    recordexist1 = 1
                End If
                If subpriority = "Sub1" Then
                    If recordexist1 = 0 Then
                        sql = "INSERT INTO tempiamarks (usn,sname,deptid,dname,semid,semname,teston,sub1) VALUES ('" & Trim(lblusn.Text) & "','" & Trim(lblsname.Text) & "'," & Trim(did) & ",'" & Trim(dname) & "'," & Trim(lblsem.Text) & ",'" & Trim(sname) & "','" & Trim(testtype) & "','" & Trim(marks) & "')"
                    ElseIf recordexist1 = 1 Then
                        sql = "update tempiamarks set sub1='" & Trim(marks) & "' where usn='" & Trim(lblusn.Text) & "' and teston='" & Trim(testtype) & "'"

                    End If
                    If recordexist = 0 Then
                        sql1 = "INSERT INTO IAmarks (usn,sname,deptid,dname,semid,semname,subcode1,subname1,test13) VALUES ('" & Trim(lblusn.Text) & "','" & Trim(lblsname.Text) & "'," & Trim(did) & ",'" & Trim(dname) & "'," & Trim(lblsem.Text) & ",'" & Trim(sname) & "','" & Trim(cmbsub.SelectedValue) & "','" & Trim(cmbsub.Text) & "','" & Trim(marks) & "')"
                    ElseIf recordexist = 1 Then

                        sql1 = "update IAmarks set subcode1='" & Trim(cmbsub.SelectedValue) & "',subname1='" & Trim(cmbsub.Text) & "',test13='" & Trim(marks) & "' where usn='" & Trim(lblusn.Text) & "'"
                    End If
                ElseIf subpriority = "Sub2" Then
                    If recordexist1 = 0 Then
                        sql = "INSERT INTO tempiamarks (usn,sname,deptid,dname,semid,semname,teston,sub2) VALUES ('" & Trim(lblusn.Text) & "','" & Trim(lblsname.Text) & "','" & Trim(did) & "','" & Trim(dname) & "','" & Trim(lblsem.Text) & "','" & Trim(sname) & "','" & Trim(testtype) & "','" & Trim(marks) & "')"
                    ElseIf recordexist1 = 1 Then
                        sql = "update tempiamarks set sub2='" & Trim(marks) & "' where usn='" & Trim(lblusn.Text) & "' and teston='" & Trim(testtype) & "'"
                    End If
                    If recordexist = 0 Then
                        sql1 = "INSERT INTO IAmarks (usn,sname,deptid,dname,semid,semname,subcode2,subname2,test23) VALUES ('" & Trim(lblusn.Text) & "','" & Trim(lblsname.Text) & "'," & Trim(did) & ",'" & Trim(dname) & "'," & Trim(lblsem.Text) & ",'" & Trim(sname) & "','" & Trim(cmbsub.SelectedValue) & "','" & Trim(cmbsub.Text) & "','" & Trim(marks) & "')"
                    ElseIf recordexist = 1 Then
                        sql1 = "update IAmarks set subcode2='" & Trim(cmbsub.SelectedValue) & "',subname2='" & Trim(cmbsub.Text) & "',test23='" & Trim(marks) & "' where usn='" & Trim(lblusn.Text) & "'"
                    End If

                ElseIf subpriority = "Sub3" Then
                    If recordexist1 = 0 Then
                        sql = "INSERT INTO tempiamarks (usn,sname,deptid,dname,semid,semname,teston,sub3) VALUES ('" & Trim(lblusn.Text) & "','" & Trim(lblsname.Text) & "','" & Trim(did) & "','" & Trim(dname) & "','" & Trim(lblsem.Text) & "','" & Trim(sname) & "','" & Trim(testtype) & "','" & Trim(marks) & "')"
                    ElseIf recordexist1 = 1 Then
                        sql = "update tempiamarks set sub3='" & Trim(marks) & "' where usn='" & Trim(lblusn.Text) & "' and teston='" & Trim(testtype) & "'"
                    End If
                    If recordexist = 0 Then
                        sql1 = "INSERT INTO IAmarks (usn,sname,deptid,dname,semid,semname,subcode3,subname3,test33) VALUES ('" & Trim(lblusn.Text) & "','" & Trim(lblsname.Text) & "'," & Trim(did) & ",'" & Trim(dname) & "'," & Trim(lblsem.Text) & ",'" & Trim(sname) & "','" & Trim(cmbsub.SelectedValue) & "','" & Trim(cmbsub.Text) & "','" & Trim(marks) & "')"
                    ElseIf recordexist = 1 Then
                        sql1 = "update IAmarks set subcode3='" & Trim(cmbsub.SelectedValue) & "',subname3='" & Trim(cmbsub.Text) & "',test33='" & Trim(marks) & "' where usn='" & Trim(lblusn.Text) & "'"
                    End If

                ElseIf subpriority = "Sub4" Then
                    If recordexist1 = 0 Then
                        sql = "INSERT INTO tempiamarks (usn,sname,deptid,dname,semid,semname,teston,sub4) VALUES ('" & Trim(lblusn.Text) & "','" & Trim(lblsname.Text) & "','" & Trim(did) & "','" & Trim(dname) & "','" & Trim(lblsem.Text) & "','" & Trim(sname) & "','" & Trim(testtype) & "','" & Trim(marks) & "')"
                    ElseIf recordexist1 = 1 Then
                        sql = "update tempiamarks set sub4='" & Trim(marks) & "' where usn='" & Trim(lblusn.Text) & "' and teston='" & Trim(testtype) & "'"
                    End If
                    If recordexist = 0 Then
                        sql1 = "INSERT INTO IAmarks (usn,sname,deptid,dname,semid,semname,subcode4,subname4,test43) VALUES ('" & Trim(lblusn.Text) & "','" & Trim(lblsname.Text) & "'," & Trim(did) & ",'" & Trim(dname) & "'," & Trim(lblsem.Text) & ",'" & Trim(sname) & "','" & Trim(cmbsub.SelectedValue) & "','" & Trim(cmbsub.Text) & "','" & Trim(marks) & "')"
                    ElseIf recordexist = 1 Then
                        sql1 = "update IAmarks set subcode4='" & Trim(cmbsub.SelectedValue) & "',subname4='" & Trim(cmbsub.Text) & "',test43='" & Trim(marks) & "' where usn='" & Trim(lblusn.Text) & "'"
                    End If

                ElseIf subpriority = "Sub5" Then
                    If recordexist1 = 0 Then
                        sql = "INSERT INTO tempiamarks (usn,sname,deptid,dname,semid,semname,teston,sub5) VALUES ('" & Trim(lblusn.Text) & "','" & Trim(lblsname.Text) & "','" & Trim(did) & "','" & Trim(dname) & "','" & Trim(lblsem.Text) & "','" & Trim(sname) & "','" & Trim(testtype) & "','" & Trim(marks) & "')"
                    ElseIf recordexist1 = 1 Then
                        sql = "update tempiamarks set sub5='" & Trim(marks) & "' where usn='" & Trim(lblusn.Text) & "'and teston='" & Trim(testtype) & "'"
                    End If
                    If recordexist = 0 Then
                        sql1 = "INSERT INTO IAmarks (usn,sname,deptid,dname,semid,semname,subcode5,subname5,test53) VALUES ('" & Trim(lblusn.Text) & "','" & Trim(lblsname.Text) & "'," & Trim(did) & ",'" & Trim(dname) & "'," & Trim(lblsem.Text) & ",'" & Trim(sname) & "','" & Trim(cmbsub.SelectedValue) & "','" & Trim(cmbsub.Text) & "','" & Trim(marks) & "')"
                    ElseIf recordexist = 1 Then
                        sql1 = "update IAmarks set subcode5='" & Trim(cmbsub.SelectedValue) & "',subname5='" & Trim(cmbsub.Text) & "',test53='" & Trim(marks) & "' where usn='" & Trim(lblusn.Text) & "'"
                    End If

                ElseIf subpriority = "Sub6" Then
                    If recordexist1 = 0 Then
                        sql = "INSERT INTO tempiamarks (usn,sname,deptid,dname,semid,semname,teston,sub6) VALUES ('" & Trim(lblusn.Text) & "','" & Trim(lblsname.Text) & "','" & Trim(did) & "','" & Trim(dname) & "','" & Trim(lblsem.Text) & "','" & Trim(sname) & "','" & Trim(testtype) & "','" & Trim(marks) & "')"
                    ElseIf recordexist1 = 1 Then
                        sql = "update tempiamarks set sub6='" & Trim(marks) & "' where usn='" & Trim(lblusn.Text) & "' and teston='" & Trim(testtype) & "'"
                    End If
                    If recordexist = 0 Then
                        sql1 = "INSERT INTO IAmarks (usn,sname,deptid,dname,semid,semname,subcode6,subname6,test63) VALUES ('" & Trim(lblusn.Text) & "','" & Trim(lblsname.Text) & "'," & Trim(did) & ",'" & Trim(dname) & "'," & Trim(lblsem.Text) & ",'" & Trim(sname) & "','" & Trim(cmbsub.SelectedValue) & "','" & Trim(cmbsub.Text) & "','" & Trim(marks) & "')"
                    ElseIf recordexist = 1 Then
                        sql1 = "update IAmarks set subcode6='" & Trim(cmbsub.SelectedValue) & "',subname6='" & Trim(cmbsub.Text) & "',test63='" & Trim(marks) & "' where usn='" & Trim(lblusn.Text) & "'"
                    End If
                End If
            ElseIf rbavg.Checked = True Then
                testtype = "avg"
                tbl = Fill_Table("SELECT * FROM  IAmarks where semid=" & Trim(lblsem.Text) & " and deptid=" & Trim(did) & " and usn='" & Trim(lblusn.Text) & "'", "IAmarks")
                If tbl.Rows.Count > 0 Then
                    recordexist = 1
                End If
                tbl1 = Fill_Table("SELECT * FROM  tempiamarks where semid=" & Trim(lblsem.Text) & " and deptid=" & Trim(did) & " and usn='" & Trim(lblusn.Text) & "' and teston='" & Trim(testtype) & "'", "tempiamarks")
                If tbl1.Rows.Count > 0 Then
                    recordexist1 = 1
                End If
                If subpriority = "Sub1" Then
                    If recordexist1 = 0 Then
                        sql = "INSERT INTO tempiamarks (usn,sname,deptid,dname,semid,semname,teston,sub1) VALUES ('" & Trim(lblusn.Text) & "','" & Trim(lblsname.Text) & "'," & Trim(did) & ",'" & Trim(dname) & "'," & Trim(lblsem.Text) & ",'" & Trim(sname) & "','" & Trim(testtype) & "','" & Trim(marks) & "')"
                    ElseIf recordexist1 = 1 Then
                        sql = "update tempiamarks set sub1='" & Trim(marks) & "' where usn='" & Trim(lblusn.Text) & "'and teston='" & Trim(testtype) & "'"
                    End If
                    If recordexist = 0 Then
                        sql1 = "INSERT INTO IAmarks (usn,sname,deptid,dname,semid,semname,subcode1,subname1,avg1) VALUES ('" & Trim(lblusn.Text) & "','" & Trim(lblsname.Text) & "'," & Trim(did) & ",'" & Trim(dname) & "'," & Trim(lblsem.Text) & ",'" & Trim(sname) & "','" & Trim(cmbsub.SelectedValue) & "','" & Trim(cmbsub.Text) & "','" & Trim(marks) & "')"
                    ElseIf recordexist = 1 Then
                        sql1 = "update IAmarks set subcode1='" & Trim(cmbsub.SelectedValue) & "',subname1='" & Trim(cmbsub.Text) & "',avg1='" & Trim(marks) & "' where usn='" & Trim(lblusn.Text) & "'"
                    End If
                ElseIf subpriority = "Sub2" Then
                    If recordexist1 = 0 Then
                        sql = "INSERT INTO tempiamarks (usn,sname,deptid,dname,semid,semname,teston,sub2) VALUES ('" & Trim(lblusn.Text) & "','" & Trim(lblsname.Text) & "','" & Trim(did) & "','" & Trim(dname) & "','" & Trim(lblsem.Text) & "','" & Trim(sname) & "','" & Trim(testtype) & "','" & Trim(marks) & "')"
                    ElseIf recordexist1 = 1 Then
                        sql = "update tempiamarks set sub2='" & Trim(marks) & "' where usn='" & Trim(lblusn.Text) & "' and teston='" & Trim(testtype) & "'"
                    End If
                    If recordexist = 0 Then
                        sql1 = "INSERT INTO IAmarks (usn,sname,deptid,dname,semid,semname,subcode2,subname2,avg2) VALUES ('" & Trim(lblusn.Text) & "','" & Trim(lblsname.Text) & "'," & Trim(did) & ",'" & Trim(dname) & "'," & Trim(lblsem.Text) & ",'" & Trim(sname) & "','" & Trim(cmbsub.SelectedValue) & "','" & Trim(cmbsub.Text) & "','" & Trim(marks) & "')"
                    ElseIf recordexist = 1 Then
                        sql1 = "update IAmarks set subcode2='" & Trim(cmbsub.SelectedValue) & "',subname2='" & Trim(cmbsub.Text) & "',avg2='" & Trim(marks) & "' where usn='" & Trim(lblusn.Text) & "'"
                    End If

                ElseIf subpriority = "Sub3" Then
                    If recordexist1 = 0 Then
                        sql = "INSERT INTO tempiamarks (usn,sname,deptid,dname,semid,semname,teston,sub3) VALUES ('" & Trim(lblusn.Text) & "','" & Trim(lblsname.Text) & "','" & Trim(did) & "','" & Trim(dname) & "','" & Trim(lblsem.Text) & "','" & Trim(sname) & "','" & Trim(testtype) & "','" & Trim(marks) & "')"
                    ElseIf recordexist1 = 1 Then
                        sql = "update tempiamarks set sub3='" & Trim(marks) & "' where usn='" & Trim(lblusn.Text) & "' and teston='" & Trim(testtype) & "'"
                    End If
                    If recordexist = 0 Then
                        sql1 = "INSERT INTO IAmarks (usn,sname,deptid,dname,semid,semname,subcode3,subname3,avg3) VALUES ('" & Trim(lblusn.Text) & "','" & Trim(lblsname.Text) & "'," & Trim(did) & ",'" & Trim(dname) & "'," & Trim(lblsem.Text) & ",'" & Trim(sname) & "','" & Trim(cmbsub.SelectedValue) & "','" & Trim(cmbsub.Text) & "','" & Trim(marks) & "')"
                    ElseIf recordexist = 1 Then
                        sql1 = "update IAmarks set subcode3='" & Trim(cmbsub.SelectedValue) & "',subname3='" & Trim(cmbsub.Text) & "',avg3='" & Trim(marks) & "' where usn='" & Trim(lblusn.Text) & "'"
                    End If

                ElseIf subpriority = "Sub4" Then
                    If recordexist1 = 0 Then
                        sql = "INSERT INTO tempiamarks (usn,sname,deptid,dname,semid,semname,teston,sub4) VALUES ('" & Trim(lblusn.Text) & "','" & Trim(lblsname.Text) & "','" & Trim(did) & "','" & Trim(dname) & "','" & Trim(lblsem.Text) & "','" & Trim(sname) & "','" & Trim(testtype) & "','" & Trim(marks) & "')"
                    ElseIf recordexist1 = 1 Then
                        sql = "update tempiamarks set sub4='" & Trim(marks) & "' where usn='" & Trim(lblusn.Text) & "' and teston='" & Trim(testtype) & "'"
                    End If
                    If recordexist = 0 Then
                        sql1 = "INSERT INTO IAmarks (usn,sname,deptid,dname,semid,semname,subcode4,subname4,avg4) VALUES ('" & Trim(lblusn.Text) & "','" & Trim(lblsname.Text) & "'," & Trim(did) & ",'" & Trim(dname) & "'," & Trim(lblsem.Text) & ",'" & Trim(sname) & "','" & Trim(cmbsub.SelectedValue) & "','" & Trim(cmbsub.Text) & "','" & Trim(marks) & "')"
                    ElseIf recordexist = 1 Then
                        sql1 = "update IAmarks set subcode4='" & Trim(cmbsub.SelectedValue) & "',subname4='" & Trim(cmbsub.Text) & "',avg4='" & Trim(marks) & "' where usn='" & Trim(lblusn.Text) & "'"
                    End If

                ElseIf subpriority = "Sub5" Then
                    If recordexist1 = 0 Then
                        sql = "INSERT INTO tempiamarks (usn,sname,deptid,dname,semid,semname,teston,sub5) VALUES ('" & Trim(lblusn.Text) & "','" & Trim(lblsname.Text) & "','" & Trim(did) & "','" & Trim(dname) & "','" & Trim(lblsem.Text) & "','" & Trim(sname) & "','" & Trim(testtype) & "','" & Trim(marks) & "')"
                    ElseIf recordexist1 = 1 Then
                        sql = "update tempiamarks set sub5='" & Trim(marks) & "' where usn='" & Trim(lblusn.Text) & "' and teston='" & Trim(testtype) & "'"
                    End If
                    If recordexist = 0 Then
                        sql1 = "INSERT INTO IAmarks (usn,sname,deptid,dname,semid,semname,subcode5,subname5,avg5) VALUES ('" & Trim(lblusn.Text) & "','" & Trim(lblsname.Text) & "'," & Trim(did) & ",'" & Trim(dname) & "'," & Trim(lblsem.Text) & ",'" & Trim(sname) & "','" & Trim(cmbsub.SelectedValue) & "','" & Trim(cmbsub.Text) & "','" & Trim(marks) & "')"
                    ElseIf recordexist = 1 Then
                        sql1 = "update IAmarks set subcode5='" & Trim(cmbsub.SelectedValue) & "',subname5='" & Trim(cmbsub.Text) & "',avg5='" & Trim(marks) & "' where usn='" & Trim(lblusn.Text) & "'"
                    End If

                ElseIf subpriority = "Sub6" Then
                    If recordexist1 = 0 Then
                        sql = "INSERT INTO tempiamarks (usn,sname,deptid,dname,semid,semname,teston,sub6) VALUES ('" & Trim(lblusn.Text) & "','" & Trim(lblsname.Text) & "','" & Trim(did) & "','" & Trim(dname) & "','" & Trim(lblsem.Text) & "','" & Trim(sname) & "','" & Trim(testtype) & "','" & Trim(marks) & "')"
                    ElseIf recordexist1 = 1 Then
                        sql = "update tempiamarks set sub6='" & Trim(marks) & "' where usn='" & Trim(lblusn.Text) & "' and teston='" & Trim(testtype) & "'"
                    End If
                    If recordexist = 0 Then
                        sql1 = "INSERT INTO IAmarks (usn,sname,deptid,dname,semid,semname,subcode6,subname6,avg6) VALUES ('" & Trim(lblusn.Text) & "','" & Trim(lblsname.Text) & "'," & Trim(did) & ",'" & Trim(dname) & "'," & Trim(lblsem.Text) & ",'" & Trim(sname) & "','" & Trim(cmbsub.SelectedValue) & "','" & Trim(cmbsub.Text) & "','" & Trim(marks) & "')"
                    ElseIf recordexist = 1 Then
                        sql1 = "update IAmarks set subcode6='" & Trim(cmbsub.SelectedValue) & "',subname6='" & Trim(cmbsub.Text) & "',avg6='" & Trim(marks) & "' where usn='" & Trim(lblusn.Text) & "'"
                    End If

                ElseIf subpriority = "Sub7" Then
                    If recordexist1 = 0 Then
                        sql = "INSERT INTO tempiamarks (usn,sname,deptid,dname,semid,semname,teston,sub7) VALUES ('" & Trim(lblusn.Text) & "','" & Trim(lblsname.Text) & "','" & Trim(did) & "','" & Trim(dname) & "','" & Trim(lblsem.Text) & "','" & Trim(sname) & "','" & Trim(testtype) & "','" & Trim(marks) & "')"
                    ElseIf recordexist1 = 1 Then
                        sql = "update tempiamarks set sub7='" & Trim(marks) & "' where usn='" & Trim(lblusn.Text) & "' and teston='" & Trim(testtype) & "'"
                    End If
                    If recordexist = 0 Then
                        sql1 = "INSERT INTO IAmarks (usn,sname,deptid,dname,semid,semname,subcode7,subname7,avg7) VALUES ('" & Trim(lblusn.Text) & "','" & Trim(lblsname.Text) & "'," & Trim(did) & ",'" & Trim(dname) & "'," & Trim(lblsem.Text) & ",'" & Trim(sname) & "','" & Trim(cmbsub.SelectedValue) & "','" & Trim(cmbsub.Text) & "','" & Trim(marks) & "')"
                    ElseIf recordexist = 1 Then
                        sql1 = "update IAmarks set subcode7='" & Trim(cmbsub.SelectedValue) & "',subname7='" & Trim(cmbsub.Text) & "',avg7='" & Trim(marks) & "' where usn='" & Trim(lblusn.Text) & "'"
                    End If
                ElseIf subpriority = "Sub8" Then
                    If recordexist1 = 0 Then
                        sql = "INSERT INTO tempiamarks (usn,sname,deptid,dname,semid,semname,teston,sub8) VALUES ('" & Trim(lblusn.Text) & "','" & Trim(lblsname.Text) & "','" & Trim(did) & "','" & Trim(dname) & "','" & Trim(lblsem.Text) & "','" & Trim(sname) & "','" & Trim(testtype) & "','" & Trim(marks) & "')"
                    ElseIf recordexist1 = 1 Then
                        sql = "update tempiamarks set sub8='" & Trim(marks) & "' where usn='" & Trim(lblusn.Text) & "' and teston='" & Trim(testtype) & "'"
                    End If
                    If recordexist = 0 Then
                        sql1 = "INSERT INTO IAmarks (usn,sname,deptid,dname,semid,semname,subcode8,subname8,avg8) VALUES ('" & Trim(lblusn.Text) & "','" & Trim(lblsname.Text) & "'," & Trim(did) & ",'" & Trim(dname) & "'," & Trim(lblsem.Text) & ",'" & Trim(sname) & "','" & Trim(cmbsub.SelectedValue) & "','" & Trim(cmbsub.Text) & "','" & Trim(marks) & "')"
                    ElseIf recordexist = 1 Then
                        sql1 = "update IAmarks set subcode8='" & Trim(cmbsub.SelectedValue) & "',subname8='" & Trim(cmbsub.Text) & "',avg8='" & Trim(marks) & "' where usn='" & Trim(lblusn.Text) & "'"
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
            'End If
            'Next
            'the condition is, if the result is equals to zero
            'then the message will appear and says "No saved Record."
            'and if not the message will appear and says "All Records Saved."
            If result = 0 And result1 = 0 Then
                MsgBox("Marks Entered")
            Else
                MsgBox("No saved Record.")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'Close the connection
        'con.Close()
    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Me.Close()

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
End Class