Public Class LoginForm1

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Try
            Dim tbl As New DataTable
            'Dim sql As String
            Dim usp As String
            usp = "admin"
            If con.State = ConnectionState.Closed Then con.Open()
            If cmbusertype.Text = "" Then
                MsgBox("Please select the User Type")
                Exit Sub
            End If
            If cmbusertype.Text = "Admin" Then
                tbl = Fill_Table("select * from Logintable where Username='" & Trim(UsernameTextBox.Text) & "' and userpassword='" & Trim(PasswordTextBox.Text) & "'", "Logintable")
                If tbl.Rows.Count > 0 Then
                    MsgBox("Successful Login", MsgBoxStyle.Information, "P&T")
                    Homepage1.Show()
                Else
                    MsgBox("Invalid Username and Password", MsgBoxStyle.Information, "P&T")
                End If
            ElseIf cmbusertype.Text = "Student" Then
                tbl = Fill_Table("select * from studentdetails where usn='" & Trim(UsernameTextBox.Text) & "' and userpassword='" & Trim(PasswordTextBox.Text) & "'", "studentdetails")
                If tbl.Rows.Count > 0 Then
                    For Each rw As DataRow In tbl.Rows
                        username = rw("USN") & ""
                        fname = rw("sname") & ""
                        deptid = rw("deptid") & ""
                        dname = rw("deptname") & ""
                        semid = rw("semid") & ""
                        semname = rw("semname") & ""
                    Next
                    MsgBox("Successful Login", MsgBoxStyle.Information, "IA Marks")

                    Student_HomePage.Show()
                Else
                    MsgBox("Invalid Username and Password", MsgBoxStyle.Information, "IA Marks")
                End If
            ElseIf cmbusertype.Text = "Staff" Then
                tbl = Fill_Table("select * from facultydetails where facultyid='" & Trim(UsernameTextBox.Text) & "' and facpwd='" & Trim(PasswordTextBox.Text) & "'", "facultydetails")
                If tbl.Rows.Count > 0 Then
                    For Each rw As DataRow In tbl.Rows
                        username = rw("facultyid") & ""
                        fname = rw("facultyname") & ""
                        deptid = rw("deptid") & ""
                        dname = rw("deptname") & ""
                        semid = rw("fsemid") & ""
                        semname = rw("fsemname") & ""
                    Next
                    MsgBox("Successful Login", MsgBoxStyle.Information, "IA Marks")

                    Homepage.Show()
                Else
                    MsgBox("Invalid Username and Password", MsgBoxStyle.Information, "IA Marks")
                End If
            End If

            Me.Hide()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
      

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub LoginForm1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'connect()
        main()


    End Sub

  
  
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub RichTextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class
