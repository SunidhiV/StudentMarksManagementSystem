Public Class frmindividualrpt

    Private Sub frmindividualrpt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'connect()
        'username = "1ew001"
        'semid = 1
        Label5.Anchor = AnchorStyles.Bottom
        Label6.Anchor = AnchorStyles.Bottom
        Label7.Anchor = AnchorStyles.Bottom
        lblsub1.Anchor = AnchorStyles.Bottom
        lblsub2.Anchor = AnchorStyles.Bottom
        lblsub3.Anchor = AnchorStyles.Bottom
        lblsub4.Anchor = AnchorStyles.Bottom
        lblsub5.Anchor = AnchorStyles.Bottom
        lblsub6.Anchor = AnchorStyles.Bottom
        lblsub7.Anchor = AnchorStyles.Bottom
        lblsub8.Anchor = AnchorStyles.Bottom
        lblsubname1.Anchor = AnchorStyles.Bottom
        lblsubname2.Anchor = AnchorStyles.Bottom
        lblsubname3.Anchor = AnchorStyles.Bottom
        lblsubname4.Anchor = AnchorStyles.Bottom
        lblsubname5.Anchor = AnchorStyles.Bottom
        lblsubname6.Anchor = AnchorStyles.Bottom
        lblsubname7.Anchor = AnchorStyles.Bottom
        lblsubname8.Anchor = AnchorStyles.Bottom
        lblts1.Anchor = AnchorStyles.Bottom
        lblts2.Anchor = AnchorStyles.Bottom
        lblts3.Anchor = AnchorStyles.Bottom
        lblts4.Anchor = AnchorStyles.Bottom
        lblts5.Anchor = AnchorStyles.Bottom
        lblts6.Anchor = AnchorStyles.Bottom
        lblts7.Anchor = AnchorStyles.Bottom
        lblts8.Anchor = AnchorStyles.Bottom
        populategrid()
    End Sub
    Public Sub populategrid()
        Dim tbl As New DataTable
        tbl = Fill_Table("SELECT * FROM  IAmarks where usn='" & Trim(username) & "' and semid=" & Trim(semid) & " ", "IAmarks")
        If tbl.Rows.Count > 0 Then
            lblusn.Text = tbl.Rows(0).Item("usn") & ""
            lblsname.Text = tbl.Rows(0).Item("sname") & ""
            lblsem.Text = tbl.Rows(0).Item("semname") & ""
            lblsub1.Text = tbl.Rows(0).Item("subcode1") & ""
            lblsub2.Text = tbl.Rows(0).Item("subcode2") & ""
            lblsub3.Text = tbl.Rows(0).Item("subcode3") & ""
            lblsub4.Text = tbl.Rows(0).Item("subcode4") & ""
            lblsub5.Text = tbl.Rows(0).Item("subcode5") & ""
            lblsub6.Text = tbl.Rows(0).Item("subcode6") & ""
            lblsub7.Text = tbl.Rows(0).Item("subcode7") & ""
            lblsub8.Text = tbl.Rows(0).Item("subcode8") & ""
            lblsubname1.Text = tbl.Rows(0).Item("subname1") & ""
            lblsubname2.Text = tbl.Rows(0).Item("subname2") & ""
            lblsubname3.Text = tbl.Rows(0).Item("subname3") & ""
            lblsubname4.Text = tbl.Rows(0).Item("subname4") & ""
            lblsubname5.Text = tbl.Rows(0).Item("subname5") & ""
            lblsubname6.Text = tbl.Rows(0).Item("subname6") & ""
            lblsubname7.Text = tbl.Rows(0).Item("subname7") & ""
            lblsubname8.Text = tbl.Rows(0).Item("subname8") & ""
            If rbt1.Checked = True Then
                lblts1.Text = tbl.Rows(0).Item("test11") & ""
                lblts2.Text = tbl.Rows(0).Item("test21") & ""
                lblts3.Text = tbl.Rows(0).Item("test31") & ""
                lblts4.Text = tbl.Rows(0).Item("test41") & ""
                lblts5.Text = tbl.Rows(0).Item("test51") & ""
                lblts6.Text = tbl.Rows(0).Item("test61") & ""
                lblts7.Text = tbl.Rows(0).Item("test71") & ""
                lblts8.Text = tbl.Rows(0).Item("test81") & ""
            ElseIf rbt2.Checked = True Then
                lblts1.Text = tbl.Rows(0).Item("test12") & ""
                lblts2.Text = tbl.Rows(0).Item("test22") & ""
                lblts3.Text = tbl.Rows(0).Item("test32") & ""
                lblts4.Text = tbl.Rows(0).Item("test42") & ""
                lblts5.Text = tbl.Rows(0).Item("test52") & ""
                lblts6.Text = tbl.Rows(0).Item("test62") & ""
                lblts7.Text = tbl.Rows(0).Item("test72") & ""
                lblts8.Text = tbl.Rows(0).Item("test82") & ""
            ElseIf rbt3.Checked = True Then
                lblts1.Text = tbl.Rows(0).Item("test13") & ""
                lblts2.Text = tbl.Rows(0).Item("test23") & ""
                lblts3.Text = tbl.Rows(0).Item("test33") & ""
                lblts4.Text = tbl.Rows(0).Item("test43") & ""
                lblts5.Text = tbl.Rows(0).Item("test53") & ""
                lblts6.Text = tbl.Rows(0).Item("test63") & ""
               
            ElseIf rbt4.Checked = True Then
                lblts1.Text = tbl.Rows(0).Item("avg1") & ""
                lblts2.Text = tbl.Rows(0).Item("avg2") & ""
                lblts3.Text = tbl.Rows(0).Item("avg3") & ""
                lblts4.Text = tbl.Rows(0).Item("avg4") & ""
                lblts5.Text = tbl.Rows(0).Item("avg5") & ""
                lblts6.Text = tbl.Rows(0).Item("avg6") & ""
                lblts7.Text = tbl.Rows(0).Item("avg7") & ""
                lblts8.Text = tbl.Rows(0).Item("avg8") & ""
            End If
           

        End If
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub rbt1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbt1.CheckedChanged
        populategrid()
    End Sub

    Private Sub rbt2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbt2.CheckedChanged
        populategrid()
    End Sub

    Private Sub rbt3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbt3.CheckedChanged
        populategrid()
    End Sub

    Private Sub rbt4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbt4.CheckedChanged
        populategrid()
    End Sub

    Private Sub btnprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprint.Click
        rbt1.Visible = False
        rbt2.Visible = False
        rbt3.Visible = False
        rbt4.Visible = False
        btnprint.Visible = False
        btnclose.Visible = False

        PrintForm1.Print()
      
    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub TableLayoutPanel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub
End Class