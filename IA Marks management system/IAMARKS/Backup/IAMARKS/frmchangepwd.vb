Public Class frmchangepwd

    Private Sub btnsubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsubmit.Click
        Try
            If txtusn.Text = "" Then
                MsgBox("Please enter faculty ID")
                Exit Sub
            ElseIf txtsname.Text = "" Then
                MsgBox("Please enter faculty Name")
                Exit Sub
            ElseIf txtoldpwd.Text = "" Then
                MsgBox("Please enter Old Password")
                Exit Sub
            ElseIf txtnewpwd.Text = "" Then
                MsgBox("Please enter New Password")
                Exit Sub
            End If
       
            Dim tbl As New DataTable
            Dim sql As String

            tbl = Fill_Table("select * from facultydetails where facultyid='" & Trim(facid) & "'", "facultydetails")
            If tbl.Rows.Count > 0 Then
                sql = "update facultydetails set facpwd='" & Trim(txtnewpwd.Text) & "' where facultyid='" & Trim(facid) & "' "
            End If
            ExecuteQueriess(sql)
            MsgBox("Password Changed Successfully", MsgBoxStyle.Information, "IA Marks")
            Clearfields(Me)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtconfirmpwd_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtconfirmpwd.TextChanged
        If txtnewpwd.Text = txtconfirmpwd.Text Then
        Else
            MsgBox("New Password and confirm password is not matched")
            txtconfirmpwd.Text = ""

        End If
    End Sub
    Public Sub populategrid()
        Try

        
            Dim tbl As New DataTable
            tbl = Fill_Table("select * from facultydetails where facultyid='" & Trim(facid) & "' ", "subjectdetails")
            If tbl.Rows.Count > 0 Then
                txtusn.Text = tbl.Rows(0).Item("facultyid")
                txtsname.Text = tbl.Rows(0).Item("facultyname")

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub frmchangepwd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        populategrid()
    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Me.Close()

    End Sub
End Class