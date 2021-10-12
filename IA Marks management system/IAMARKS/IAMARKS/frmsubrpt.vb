Public Class frmsubrpt
    Private Structure pageDetails
        Dim columns As Integer
        Dim rows As Integer
        Dim startCol As Integer
        Dim startRow As Integer
    End Structure
    Dim result As Integer = 0
    Private pages As Dictionary(Of Integer, pageDetails)

    Dim maxPagesWide As Integer
    Dim maxPagesTall As Integer
    Public Sub populategrid()
        Dim tbl As New DataTable
        If rbtest1.Checked = True Then
            
            If subpriority = "Sub1" Then
                tbl = Fill_Table("SELECT usn as USN, sname as Student_Name,test11 as Test1_Marks FROM  IAmarks where subcode1='" & Trim(cmbsub.SelectedValue) & "' and semid=" & Trim(cmbsem.SelectedValue) & "", "IAmarks")
            ElseIf subpriority = "Sub2" Then
                tbl = Fill_Table("SELECT usn as USN, sname as Student_Name,test21 as Test1_Marks FROM  IAmarks where subcode2='" & Trim(cmbsub.SelectedValue) & "' and semid=" & Trim(cmbsem.SelectedValue) & "", "IAmarks")
            ElseIf subpriority = "Sub3" Then
                tbl = Fill_Table("SELECT usn as USN, sname as Student_Name,test31 as Test1_Marks FROM  IAmarks where subcode3='" & Trim(cmbsub.SelectedValue) & "' and semid=" & Trim(cmbsem.SelectedValue) & "", "IAmarks")

            ElseIf subpriority = "Sub4" Then
                tbl = Fill_Table("SELECT usn as USN, sname as Student_Name,test41 as Test1_Marks FROM  IAmarks where subcode4='" & Trim(cmbsub.SelectedValue) & "' and semid=" & Trim(cmbsem.SelectedValue) & "", "IAmarks")

            ElseIf subpriority = "Sub5" Then
                tbl = Fill_Table("SELECT usn as USN, sname as Student_Name,test51 as Test1_Marks FROM  IAmarks where subcode5='" & Trim(cmbsub.SelectedValue) & "' and semid=" & Trim(cmbsem.SelectedValue) & "", "IAmarks")

            ElseIf subpriority = "Sub6" Then
                tbl = Fill_Table("SELECT usn as USN, sname as Student_Name,test61 as Test1_Marks FROM  IAmarks where subcode6='" & Trim(cmbsub.SelectedValue) & "' and semid=" & Trim(cmbsem.SelectedValue) & "", "IAmarks")

            ElseIf subpriority = "Sub7" Then
                tbl = Fill_Table("SELECT usn as USN, sname as Student_Name,test71 as Test1_Marks FROM  IAmarks where subcode7='" & Trim(cmbsub.SelectedValue) & "' and semid=" & Trim(cmbsem.SelectedValue) & "", "IAmarks")

            ElseIf subpriority = "Sub8" Then
                tbl = Fill_Table("SELECT usn as USN, sname as Student_Name,test81 as Test1_Marks FROM  IAmarks where subcode8='" & Trim(cmbsub.SelectedValue) & "' and semid=" & Trim(cmbsem.SelectedValue) & "", "IAmarks")

            End If
            result = 1
        ElseIf rbtest2.Checked = True Then
           
            If subpriority = "Sub1" Then
                tbl = Fill_Table("SELECT usn as USN, sname as Student_Name,test21 as Test2_Marks FROM  IAmarks where subcode1='" & Trim(cmbsub.SelectedValue) & "' and semid=" & Trim(cmbsem.SelectedValue) & "", "IAmarks")

            ElseIf subpriority = "Sub2" Then
                tbl = Fill_Table("SELECT usn as USN, sname as Student_Name,test22 as Test2_Marks FROM  IAmarks where subcode2='" & Trim(cmbsub.SelectedValue) & "' and semid=" & Trim(cmbsem.SelectedValue) & "", "IAmarks")

            ElseIf subpriority = "Sub3" Then
                tbl = Fill_Table("SELECT usn as USN, sname as Student_Name,test32 as Test2_Marks FROM  IAmarks where subcode3='" & Trim(cmbsub.SelectedValue) & "' and semid=" & Trim(cmbsem.SelectedValue) & "", "IAmarks")

            ElseIf subpriority = "Sub4" Then
                tbl = Fill_Table("SELECT usn as USN, sname as Student_Name,test42 as Test2_Marks FROM  IAmarks where subcode4='" & Trim(cmbsub.SelectedValue) & "' and semid=" & Trim(cmbsem.SelectedValue) & "", "IAmarks")

            ElseIf subpriority = "Sub5" Then
                tbl = Fill_Table("SELECT usn as USN, sname as Student_Name,test52 as Test2_Marks FROM  IAmarks where subcode5='" & Trim(cmbsub.SelectedValue) & "' and semid=" & Trim(cmbsem.SelectedValue) & "", "IAmarks")

            ElseIf subpriority = "Sub6" Then
                tbl = Fill_Table("SELECT usn as USN, sname as Student_Name,test62 as Test2_Marks FROM  IAmarks where subcode6='" & Trim(cmbsub.SelectedValue) & "' and semid=" & Trim(cmbsem.SelectedValue) & "", "IAmarks")

            ElseIf subpriority = "Sub7" Then
                tbl = Fill_Table("SELECT usn as USN, sname as Student_Name,test72 as Test2_Marks FROM  IAmarks where subcode7='" & Trim(cmbsub.SelectedValue) & "' and semid=" & Trim(cmbsem.SelectedValue) & "", "IAmarks")

            ElseIf subpriority = "Sub8" Then
                tbl = Fill_Table("SELECT usn as USN, sname as Student_Name,test82 as Test2_Marks FROM  IAmarks where subcode8='" & Trim(cmbsub.SelectedValue) & "' and semid=" & Trim(cmbsem.SelectedValue) & "", "IAmarks")

            End If
            result = 1
        ElseIf rbtest3.Checked = True Then
          
            If subpriority = "Sub1" Then
                tbl = Fill_Table("SELECT usn as USN, sname as Student_Name,test13 as Test3_Marks FROM  IAmarks where subcode1='" & Trim(cmbsub.SelectedValue) & "' and semid=" & Trim(cmbsem.SelectedValue) & "", "IAmarks")

            ElseIf subpriority = "Sub2" Then
                tbl = Fill_Table("SELECT usn as USN, sname as Student_Name,test23 as Test3_Marks FROM  IAmarks where subcode2='" & Trim(cmbsub.SelectedValue) & "' and semid=" & Trim(cmbsem.SelectedValue) & "", "IAmarks")

            ElseIf subpriority = "Sub3" Then
                tbl = Fill_Table("SELECT usn as USN, sname as Student_Name,test33 as Test3_Marks FROM  IAmarks where subcode3='" & Trim(cmbsub.SelectedValue) & "' and semid=" & Trim(cmbsem.SelectedValue) & "", "IAmarks")

            ElseIf subpriority = "Sub4" Then
                tbl = Fill_Table("SELECT usn as USN, sname as Student_Name,test43 as Test3_Marks FROM  IAmarks where subcode4='" & Trim(cmbsub.SelectedValue) & "' and semid=" & Trim(cmbsem.SelectedValue) & "", "IAmarks")

            ElseIf subpriority = "Sub5" Then
                tbl = Fill_Table("SELECT usn as USN, sname as Student_Name,test53 as Test3_Marks FROM  IAmarks where subcode5='" & Trim(cmbsub.SelectedValue) & "' and semid=" & Trim(cmbsem.SelectedValue) & "", "IAmarks")

            ElseIf subpriority = "Sub6" Then
                tbl = Fill_Table("SELECT usn as USN, sname as Student_Name,test63 as Test3_Marks FROM  IAmarks where subcode6='" & Trim(cmbsub.SelectedValue) & "' and semid=" & Trim(cmbsem.SelectedValue) & "", "IAmarks")

            End If
            result = 1
        ElseIf rbavg.Checked = True Then
           
            If subpriority = "Sub1" Then
                tbl = Fill_Table("SELECT usn as USN, sname as Student_Name,avg1 as AVG_Marks FROM  IAmarks where subcode1='" & Trim(cmbsub.SelectedValue) & "' and semid=" & Trim(cmbsem.SelectedValue) & "", "IAmarks")

            ElseIf subpriority = "Sub2" Then
                tbl = Fill_Table("SELECT usn as USN, sname as Student_Name,avg2 as AVG_Marks FROM  IAmarks where subcode1='" & Trim(cmbsub.SelectedValue) & "' and semid=" & Trim(cmbsem.SelectedValue) & "", "IAmarks")

            ElseIf subpriority = "Sub3" Then
                tbl = Fill_Table("SELECT usn as USN, sname as Student_Name,avg3 as AVG_Marks FROM  IAmarks where subcode1='" & Trim(cmbsub.SelectedValue) & "' and semid=" & Trim(cmbsem.SelectedValue) & "", "IAmarks")

            ElseIf subpriority = "Sub4" Then
                tbl = Fill_Table("SELECT usn as USN, sname as Student_Name,avg4 as AVG_Marks FROM  IAmarks where subcode1='" & Trim(cmbsub.SelectedValue) & "' and semid=" & Trim(cmbsem.SelectedValue) & "", "IAmarks")

            ElseIf subpriority = "Sub5" Then
                tbl = Fill_Table("SELECT usn as USN, sname as Student_Name,avg5 as AVG_Marks FROM  IAmarks where subcode1='" & Trim(cmbsub.SelectedValue) & "' and semid=" & Trim(cmbsem.SelectedValue) & "", "IAmarks")

            ElseIf subpriority = "Sub6" Then
                tbl = Fill_Table("SELECT usn as USN, sname as Student_Name,avg6 as AVG_Marks FROM  IAmarks where subcode1='" & Trim(cmbsub.SelectedValue) & "' and semid=" & Trim(cmbsem.SelectedValue) & "", "IAmarks")

            ElseIf subpriority = "Sub7" Then
                tbl = Fill_Table("SELECT usn as USN, sname as Student_Name,avg7 as AVG_Marks FROM  IAmarks where subcode1='" & Trim(cmbsub.SelectedValue) & "' and semid=" & Trim(cmbsem.SelectedValue) & "", "IAmarks")

            ElseIf subpriority = "Sub8" Then
                tbl = Fill_Table("SELECT usn as USN, sname as Student_Name,avg8 as AVG_Marks FROM  IAmarks where subcode1='" & Trim(cmbsub.SelectedValue) & "' and semid=" & Trim(cmbsem.SelectedValue) & "", "IAmarks")

            End If
            result = 1
        End If
        
        dgvsubjewise.DataSource = tbl
        'Dim col As New DataGridViewTextBoxColumn
        'col.DataPropertyName = "Marks"
        'col.HeaderText = "Marks"
        'col.Name = "Marks"

        'dgvsubjewise.Columns.Add(col)

    End Sub

    Private Sub cmbsub_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbsub.SelectedIndexChanged
        Try

            If rbavg.Checked = False And rbtest1.Checked = False And rbtest2.Checked = False And rbtest3.Checked = False Then
                MsgBox("Please select the Test")
                Exit Sub

            End If

            Dim tbl As New DataTable
            tbl = Fill_Table("SELECT * FROM  subjectdetails where subcode='" & Trim(cmbsub.SelectedValue) & "' and semid=" & Trim(cmbsem.SelectedValue) & "", "subjectdetails")
            If tbl.Rows.Count > 0 Then
                subpriority = tbl.Rows(0).Item("subpriority") & ""

            End If
            populategrid()
            If result = 1 Then
                'dgvsubjewise.Columns(1).Width = 180
                'dgvsubjewise.Columns(2).Width = 175
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub frmsubrpt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'connect()
            dgvsubjewise.Font = Label3.Font
            FillCombo(cmbsem, "semester", "semid", "semname")

          
            'semid = 1
            
           
           

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnpreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpreview.Click
        Try
            Dim ppd As New PrintPreviewDialog
            ppd.Document = PrintDocument1
            ppd.WindowState = FormWindowState.Maximized
            ppd.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprint.Click
        Try
            PrintDocument1.Print()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub PrintDocument1_BeginPrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles PrintDocument1.BeginPrint
        PrintDocument1.OriginAtMargins = True
        PrintDocument1.DefaultPageSettings.Margins = New Drawing.Printing.Margins(0, 0, 0, 0)

        pages = New Dictionary(Of Integer, pageDetails)

        Dim maxWidth As Integer = CInt(PrintDocument1.DefaultPageSettings.PrintableArea.Width) - 40
        Dim maxHeight As Integer = CInt(PrintDocument1.DefaultPageSettings.PrintableArea.Height) - 40 + Label1.Height

        Dim pageCounter As Integer = 0
        pages.Add(pageCounter, New pageDetails)

        Dim columnCounter As Integer = 0

        Dim columnSum As Integer = dgvsubjewise.RowHeadersWidth

        For c As Integer = 0 To dgvsubjewise.Columns.Count - 1
            If columnSum + dgvsubjewise.Columns(c).Width < maxWidth Then
                columnSum += dgvsubjewise.Columns(c).Width
                columnCounter += 1
            Else
                pages(pageCounter) = New pageDetails With {.columns = columnCounter, .rows = 0, .startCol = pages(pageCounter).startCol}
                columnSum = dgvsubjewise.RowHeadersWidth + dgvsubjewise.Columns(c).Width
                columnCounter = 1
                pageCounter += 1
                pages.Add(pageCounter, New pageDetails With {.startCol = c})
            End If
            If c = dgvsubjewise.Columns.Count - 1 Then
                If pages(pageCounter).columns = 0 Then
                    pages(pageCounter) = New pageDetails With {.columns = columnCounter, .rows = 0, .startCol = pages(pageCounter).startCol}
                End If
            End If
        Next

        maxPagesWide = pages.Keys.Max + 1

        pageCounter = 0

        Dim rowCounter As Integer = 0

        Dim rowSum As Integer = dgvsubjewise.ColumnHeadersHeight

        For r As Integer = 0 To dgvsubjewise.Rows.Count - 2
            If rowSum + dgvsubjewise.Rows(r).Height < maxHeight Then
                rowSum += dgvsubjewise.Rows(r).Height
                rowCounter += 1
            Else
                pages(pageCounter) = New pageDetails With {.columns = pages(pageCounter).columns, .rows = rowCounter, .startCol = pages(pageCounter).startCol, .startRow = pages(pageCounter).startRow}
                For x As Integer = 1 To maxPagesWide - 1
                    pages(pageCounter + x) = New pageDetails With {.columns = pages(pageCounter + x).columns, .rows = rowCounter, .startCol = pages(pageCounter + x).startCol, .startRow = pages(pageCounter).startRow}
                Next

                pageCounter += maxPagesWide
                For x As Integer = 0 To maxPagesWide - 1
                    pages.Add(pageCounter + x, New pageDetails With {.columns = pages(x).columns, .rows = 0, .startCol = pages(x).startCol, .startRow = r})
                Next

                rowSum = dgvsubjewise.ColumnHeadersHeight + dgvsubjewise.Rows(r).Height
                rowCounter = 1
            End If
            If r = dgvsubjewise.Rows.Count - 2 Then
                For x As Integer = 0 To maxPagesWide - 1
                    If pages(pageCounter + x).rows = 0 Then
                        pages(pageCounter + x) = New pageDetails With {.columns = pages(pageCounter + x).columns, .rows = rowCounter, .startCol = pages(pageCounter + x).startCol, .startRow = pages(pageCounter + x).startRow}
                    End If
                Next
            End If
        Next

        maxPagesTall = pages.Count \ maxPagesWide
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim rect As New Rectangle(20, 40, CInt(PrintDocument1.DefaultPageSettings.PrintableArea.Width), Label1.Height)
        Dim rect1 As New Rectangle(20, 90, CInt(PrintDocument1.DefaultPageSettings.PrintableArea.Width), Label1.Height)
        Dim sf As New StringFormat
        sf.Alignment = StringAlignment.Center
        sf.LineAlignment = StringAlignment.Center

        e.Graphics.DrawString(Label1.Text, Label1.Font, Brushes.Black, rect, sf)
        e.Graphics.DrawString(Label2.Text, Label1.Font, Brushes.Black, rect1, sf)

        sf.Alignment = StringAlignment.Near

        Dim startX As Integer = 170
        Dim startY As Integer = rect1.Bottom

        Static startPage As Integer = 0

        For p As Integer = startPage To pages.Count - 1
            Dim cell As New Rectangle(startX, startY, dgvsubjewise.RowHeadersWidth, dgvsubjewise.ColumnHeadersHeight)
            e.Graphics.FillRectangle(New SolidBrush(SystemColors.ControlLight), cell)
            e.Graphics.DrawRectangle(Pens.Black, cell)

            startY += dgvsubjewise.ColumnHeadersHeight

            For r As Integer = pages(p).startRow To pages(p).startRow + pages(p).rows - 1
                cell = New Rectangle(startX, startY, dgvsubjewise.RowHeadersWidth, dgvsubjewise.Rows(r).Height)
                e.Graphics.FillRectangle(New SolidBrush(SystemColors.ControlLight), cell)
                e.Graphics.DrawRectangle(Pens.Black, cell)
                'e.Graphics.DrawString(DataGridView1.Rows(r).HeaderCell.Value.ToString, DataGridView1.Font, Brushes.Black, cell, sf)
                startY += dgvsubjewise.Rows(r).Height
            Next

            startX += cell.Width
            startY = rect1.Bottom

            For c As Integer = pages(p).startCol To pages(p).startCol + pages(p).columns - 1
                cell = New Rectangle(startX, startY, dgvsubjewise.Columns(c).Width, dgvsubjewise.ColumnHeadersHeight)
                e.Graphics.FillRectangle(New SolidBrush(SystemColors.ControlLight), cell)
                e.Graphics.DrawRectangle(Pens.Black, cell)
                e.Graphics.DrawString(dgvsubjewise.Columns(c).HeaderCell.Value.ToString, dgvsubjewise.Font, Brushes.Black, cell, sf)
                startX += dgvsubjewise.Columns(c).Width
            Next

            startY = rect1.Bottom + dgvsubjewise.ColumnHeadersHeight

            For r As Integer = pages(p).startRow To pages(p).startRow + pages(p).rows - 1
                startX = 170 + dgvsubjewise.RowHeadersWidth
                For c As Integer = pages(p).startCol To pages(p).startCol + pages(p).columns - 1
                    cell = New Rectangle(startX, startY, dgvsubjewise.Columns(c).Width, dgvsubjewise.Rows(r).Height)
                    e.Graphics.DrawRectangle(Pens.Black, cell)
                    e.Graphics.DrawString(dgvsubjewise(c, r).Value.ToString, dgvsubjewise.Font, Brushes.Black, cell, sf)
                    startX += dgvsubjewise.Columns(c).Width
                Next
                startY += dgvsubjewise.Rows(r).Height
            Next

            If p <> pages.Count - 1 Then
                startPage = p + 1
                e.HasMorePages = True
                Return
            Else
                startPage = 0
            End If

        Next
    End Sub

    Private Sub cmbsem_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbsem.SelectedIndexChanged
        If cmbsem.SelectedValue <> 0 Then
            FillCombo(cmbsub, "subjectdetails", "subcode", "subname", "semid=" & Trim(cmbsem.SelectedValue) & "")

        End If
    End Sub
End Class