Public Class frmstudentdetails

    Private Sub btnsubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsubmit.Click
        Try
            Dim sql As String
            Dim tbl As New DataTable
            If txtusn.Text = "" Then
                MsgBox("Please enter the USN")
                Exit Sub
            ElseIf txtsname.Text = "" Then
                MsgBox("Please enter the Student Name ")
                Exit Sub
            ElseIf cmbdept.Text = "" Then
                MsgBox("Please enter the Department ")
                Exit Sub
            ElseIf cmbsem.Text = "" Then
                MsgBox("Please enter the Semester ")
                Exit Sub
            ElseIf txtmobno.Text = "" Then
                MsgBox("Please enter the Mobile no")
                Exit Sub
            End If
            lblpwd.Text = "123456"
            If con.State = ConnectionState.Closed Then con.Open()
            tbl = Fill_Table("select * from studentdetails where usn='" & Trim(txtusn.Text) & "'  ", "subjectdetails")
            If tbl.Rows.Count > 0 Then
                sql = "update studentdetails set sname='" & Trim(txtsname.Text) & "',deptid=" & Trim(cmbdept.SelectedValue) & ",deptname='" & Trim(cmbdept.Text) & "',semid=" & Trim(cmbsem.SelectedValue) & ",semname='" & Trim(cmbsem.Text) & "',mobno=" & Trim(txtmobno.Text) & " where usn='" & Trim(txtusn.Text) & "' "
            Else
                sql = "INSERT INTO studentdetails (usn,sname,deptid,deptname,semid,semname,mobno,userpassword)VALUES ('" & Trim(txtusn.Text) & "','" & Trim(txtsname.Text) & "'," & Trim(cmbdept.SelectedValue) & ",'" & Trim(cmbdept.Text) & "'," & Trim(cmbsem.SelectedValue) & ",'" & Trim(cmbsem.Text) & "'," & Trim(txtmobno.Text) & ",'" & Trim(lblpwd.Text) & "')"
            End If
            ExecuteQueriess(sql)
            MsgBox("Saved Successfully", MsgBoxStyle.Information, "IA MARKS")
            Clearfields(Me)
            populategrid()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        
    End Sub
    Public Sub populategrid()
        Dim tbl As New DataTable
        tbl = Fill_Table("SELECT usn as Sub_Code,sname as Sub_Name,semname as Sem_Name, deptname as Dept_Name  FROM  studentdetails  ", "studentdetails")
        dgvstudentdetails.DataSource = tbl
    End Sub

    Private Sub frmstudentdetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            FillCombo(cmbdept, "DepartmentDetails", "deptid", "deptname")
            populategrid()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
      
    End Sub

    Private Sub cmbdept_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbdept.SelectedIndexChanged
        If cmbdept.SelectedValue <> 0 Then
            FillCombo(cmbsem, "semester", "semid", "semname", "deptid=" & Trim(cmbdept.SelectedValue) & "")
        End If
    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub txtmobno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtmobno.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MessageBox.Show("Please enter numbers only")
            e.Handled = True
        End If

    End Sub

   
    Private Sub txtmobno_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtmobno.TextChanged
        If Len(txtmobno.Text) > 9 Then
            MsgBox("Only 10 digits")
        End If
    End Sub
End Class