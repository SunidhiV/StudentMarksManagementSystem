Public Class frmdept

    Private Sub btnsubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsubmit.Click
        Try
            Dim sql As String
            Dim tbl As New DataTable
            If cmbcourse.Text = "" Then
                MsgBox("Please enter the Course Name")
                Exit Sub
            ElseIf txtdept.Text = "" Then
                MsgBox("Please enter the department ")
                Exit Sub
            End If
            tbl = Fill_Table("select * from DepartmentDetails where deptname='" & Trim(txtdept.Text) & "' and courseid=" & Trim(cmbcourse.SelectedValue) & "  ", "DepartmentDetails")
            If tbl.Rows.Count > 0 Then
                MsgBox("Record Already Exist", MsgBoxStyle.Information, "IA Marks")
                Exit Sub
            End If
            If con.State = ConnectionState.Closed Then con.Open()
            sql = "INSERT INTO DepartmentDetails (deptname,courseid,coursename)VALUES ('" & Trim(txtdept.Text) & "'," & Trim(cmbcourse.SelectedValue) & ",'" & Trim(cmbcourse.Text) & "')"

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

        tbl = Fill_Table("SELECT deptname as Dept_Name, coursename as Course_Name  FROM  DepartmentDetails  ", "DepartmentDetails")
        dgvdept.DataSource = tbl

    End Sub

    Private Sub frmdept_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            FillCombo(cmbcourse, "CourseDetails", "courseid", "coursename")
            populategrid()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
       
    End Sub

  
    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub
End Class