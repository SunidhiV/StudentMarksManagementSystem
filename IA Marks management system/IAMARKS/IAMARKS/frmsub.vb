Public Class frmsub

    Private Sub btnsubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsubmit.Click
        Try
            Dim sql As String
            Dim tbl As New DataTable
            If cmbdept.Text = "" Then
                MsgBox("Please enter the Dept Name")
                Exit Sub
            ElseIf cmbsem.Text = "" Then
                MsgBox("Please enter the semester ")
                Exit Sub
            ElseIf txtsubcode.Text = "" Then
                MsgBox("Please enter the Subject code ")
                Exit Sub
            ElseIf txtsubname.Text = "" Then
                MsgBox("Please enter the Subject name ")
                Exit Sub
            End If
            tbl = Fill_Table("select * from subjectdetails where subcode='" & Trim(txtsubcode.Text) & "' and semid=" & Trim(cmbsem.SelectedValue) & " and deptid=" & Trim(cmbdept.SelectedValue) & "  ", "subjectdetails")
            If tbl.Rows.Count > 0 Then
                MsgBox("Record Already Exist", MsgBoxStyle.Information, "IA Marks")
                Exit Sub
            End If
            If con.State = ConnectionState.Closed Then con.Open()
            sql = "INSERT INTO subjectdetails (subcode,subname,semid,semname,deptid,deptname,subpriority,maxmarks)VALUES ('" & Trim(txtsubcode.Text) & "','" & Trim(txtsubname.Text) & "'," & Trim(cmbsem.SelectedValue) & ",'" & Trim(cmbsem.Text) & "'," & Trim(cmbdept.SelectedValue) & ",'" & Trim(cmbdept.Text) & "','" & Trim(cmbpriority.Text) & "'," & Trim(txtmaxmarks.Text) & ")"

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
        tbl = Fill_Table("SELECT subcode as Sub_Code,subname as Sub_Name,semname as Sem_Name, deptname as Dept_Name  FROM  subjectdetails  ", "subjectdetails")
        dgvsub.DataSource = tbl
    End Sub

    Private Sub frmsub_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

    Private Sub txtmaxmarks_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtmaxmarks.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MessageBox.Show("Please enter numbers only")
            e.Handled = True
        End If
    End Sub

    Private Sub txtmaxmarks_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtmaxmarks.TextChanged

    End Sub
End Class