Public Class frmsem

    
    Private Sub btnsubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsubmit.Click
        Try
            Dim sql As String
            Dim tbl As New DataTable
            If cmbdept.Text = "" Then
                MsgBox("Please enter the Dept Name")
                Exit Sub
            ElseIf txtsem.Text = "" Then
                MsgBox("Please enter the Sem ")
                Exit Sub
            End If
            tbl = Fill_Table("select * from semester where semname='" & Trim(txtsem.Text) & "' and deptid=" & Trim(cmbdept.SelectedValue) & "  ", "semester")
            If tbl.Rows.Count > 0 Then
                MsgBox("Record Already Exist", MsgBoxStyle.Information, "IA MARKS")
                Exit Sub
            End If
            If con.State = ConnectionState.Closed Then con.Open()
            sql = "INSERT INTO semester (semname,deptid,deptname)VALUES ('" & Trim(txtsem.Text) & "'," & Trim(cmbdept.SelectedValue) & ",'" & Trim(cmbdept.Text) & "')"

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
        tbl = Fill_Table("SELECT semname as Sem_Name, deptname as Dept_Name  FROM  semester  ", "semester")
        dgvsem.DataSource = tbl
    End Sub

    Private Sub frmsem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            FillCombo(cmbdept, "DepartmentDetails", "deptid", "deptname")
            populategrid()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
       
    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

End Class