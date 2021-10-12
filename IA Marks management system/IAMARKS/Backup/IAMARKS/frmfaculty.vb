Public Class frmfaculty

    Private Sub btnsubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsubmit.Click
        Dim sql As String
        Dim tbl As New DataTable
        Try
            If txtfacultyid.Text = "" Then
                MsgBox("Please enter the fculty-ID ")
                Exit Sub
            ElseIf txtfname.Text = "" Then
                MsgBox("Please enter the faculty name ")
                Exit Sub
            ElseIf txtmobno.Text = "" Then
                MsgBox("Please enter the Mobile name ")
                Exit Sub
            ElseIf cmbdept.Text = "" Then
                MsgBox("Please enter the Department ")
                Exit Sub
            ElseIf cmbsem1.Text = "" Then
                MsgBox("Please enter the Semester ")
                Exit Sub
            ElseIf cmbsub1.Text = "" Then
                MsgBox("Please enter the Subject ")
                Exit Sub
            End If
            Dim pwd As String
            pwd = "123456"
            If con.State = ConnectionState.Closed Then con.Open()
            tbl = Fill_Table("select * from facultydetails where facultyid='" & Trim(facid) & "'", "facultydetails")
            If tbl.Rows.Count > 0 Then
                sql = "update facultydetails set facultyname='" & Trim(txtfname.Text) & "',fsubid='" & Trim(cmbsub1.SelectedValue) & "',fsubname='" & Trim(cmbsub1.Text) & "',fsemid=" & Trim(cmbsem1.SelectedValue) & ",fsemname='" & Trim(cmbsem1.Text) & "',deptid=" & Trim(cmbdept.SelectedValue) & ",deptname='" & Trim(cmbdept.Text) & "',mobno=" & Trim(txtmobno.Text) & " where facultyid='" & Trim(facid) & "'"
            Else
                sql = "INSERT INTO facultydetails (facultyid,facultyname,fsubid,fsubname,fsemid,fsemname,deptid,deptname,mobno,facpwd)VALUES ('" & Trim(txtfacultyid.Text) & "','" & Trim(txtfname.Text) & "','" & Trim(cmbsub1.SelectedValue) & "','" & Trim(cmbsub1.Text) & "'," & Trim(cmbsem1.SelectedValue) & ",'" & Trim(cmbsem1.Text) & "'," & Trim(cmbdept.SelectedValue) & ",'" & Trim(cmbdept.Text) & "'," & Trim(txtmobno.Text) & ",'" & Trim(pwd) & "')"
            End If
            ExecuteQueriess(sql)
            MsgBox("Saved Successfully", MsgBoxStyle.Information, "IA Marks")
            Clearfields(Me)
            populategrid()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
       
    End Sub
    Public Sub populategrid()
        Dim tbl As New DataTable
        tbl = Fill_Table("SELECT facultyid as Faculty_ID,facultyname as Name,fsemname as Sem_Name,fsubname as Sub_Name, deptname as Dept_Name  FROM  facultydetails  ", "facultydetails")
        dgvfaculty.DataSource = tbl
    End Sub

    Private Sub frmfaculty_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            FillCombo(cmbdept, "DepartmentDetails", "deptid", "deptname")
            populategrid()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
       
    End Sub

    Private Sub cmbdept_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbdept.SelectedIndexChanged
        If cmbdept.SelectedValue <> 0 Then
            FillCombo(cmbsem1, "semester", "semid", "semname", "deptid=" & Trim(cmbdept.SelectedValue) & "")
            
        End If
    End Sub

    Private Sub cmbsem1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbsem1.SelectedIndexChanged
        If cmbsem1.SelectedValue <> 0 Then
            FillCombo(cmbsub1, "subjectdetails", "subcode", "subname", "semid=" & Trim(cmbsem1.SelectedValue) & "")
        End If
    End Sub

    

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub txtfacultyid_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtfacultyid.TextChanged
        Dim tbl As New DataTable
        tbl = Fill_Table("select * from facultydetails where facultyid='" & Trim(txtfacultyid.Text) & "'  ", "facultydetails")
        If tbl.Rows.Count > 0 Then
            txtfname.Text = tbl.Rows(0).Item("facultyname")
            txtmobno.Text = tbl.Rows(0).Item("mobno")
        End If
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