Public Class frmcourse

    Private Sub btnsubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsubmit.Click
        Try
            Dim sql As String
            Dim tbl As New DataTable
            If txtcourse.Text = "" Then
                MsgBox("Please enter the Course Name")
                Exit Sub
            ElseIf txtdesc.Text = "" Then
                MsgBox("Please enter the Duration ")
                Exit Sub
            End If
            tbl = Fill_Table("select * from CourseDetails where coursename='" & Trim(txtcourse.Text) & "' ", "CourseDetails")
            If tbl.Rows.Count > 0 Then
                MsgBox("Record Already Exist", MsgBoxStyle.Information, "IA Marks")
                Exit Sub
            End If
            If con.State = ConnectionState.Closed Then con.Open()
            sql = "INSERT INTO CourseDetails (coursename,duration)VALUES ('" & Trim(txtcourse.Text) & "','" & Trim(txtdesc.Text) & "')"

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
        Try
            tbl = Fill_Table("SELECT coursename as Course_Name, duration as Duration  FROM  CourseDetails  ", "CourseDetails")
            dgvcourse.DataSource = tbl
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
      

    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Me.Close()

    End Sub

    Private Sub frmcourse_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            populategrid()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub txtdesc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdesc.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MessageBox.Show("Please enter numbers only")
            e.Handled = True
        End If
    End Sub
End Class