Public Class frmstudchangepwd

    Private Sub txtconfirmpwd_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtconfirmpwd.TextChanged
        If txtnewpwd.Text = txtconfirmpwd.Text Then
        Else
            MsgBox("New Password and confirm password is not matched")
            txtconfirmpwd.Text = ""

        End If
    End Sub

    Private Sub btnsubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsubmit.Click
        Dim tbl As New DataTable
        Dim sql As String
        Try

       
            If txtusn.Text = "" Then
                MsgBox("Please enter Student ID")
                Exit Sub
            ElseIf txtsname.Text = "" Then
                MsgBox("Please enter Student Name")
                Exit Sub
            ElseIf txtoldpwd.Text = "" Then
                MsgBox("Please enter Old Password")
                Exit Sub
            ElseIf txtnewpwd.Text = "" Then
                MsgBox("Please enter New Password")
                Exit Sub
            End If
            tbl = Fill_Table("select * from studentdetails where usn='" & Trim(txtusn.Text) & "'  ", "subjectdetails")
            If tbl.Rows.Count > 0 Then
                sql = "update studentdetails set userpassword='" & Trim(txtnewpwd.Text) & "' where usn='" & Trim(txtusn.Text) & "' "
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
       
      
    End Sub

    Private Sub frmstudchangepwd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

       
            populategrid()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub populategrid()
        Dim tbl As New DataTable
        tbl = Fill_Table("select * from studentdetails where usn='" & Trim(txtusn.Text) & "'  ", "subjectdetails")
        If tbl.Rows.Count > 0 Then
            txtusn.Text = tbl.Rows(0).Item("usn")
            txtsname.Text = tbl.Rows(0).Item("sname")

        End If
       
    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Me.Close()

    End Sub
End Class