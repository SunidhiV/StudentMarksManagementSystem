<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmnewiaentry
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblusn = New System.Windows.Forms.TextBox()
        Me.lblsem = New System.Windows.Forms.Label()
        Me.lblsname = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbsub = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.rbavg = New System.Windows.Forms.RadioButton()
        Me.rbtest3 = New System.Windows.Forms.RadioButton()
        Me.rbtest2 = New System.Windows.Forms.RadioButton()
        Me.rbtest1 = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtmarks = New System.Windows.Forms.TextBox()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblusn
        '
        Me.lblusn.Location = New System.Drawing.Point(468, 102)
        Me.lblusn.Margin = New System.Windows.Forms.Padding(4)
        Me.lblusn.Name = "lblusn"
        Me.lblusn.Size = New System.Drawing.Size(200, 22)
        Me.lblusn.TabIndex = 35
        '
        'lblsem
        '
        Me.lblsem.AutoSize = True
        Me.lblsem.BackColor = System.Drawing.Color.Transparent
        Me.lblsem.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsem.Location = New System.Drawing.Point(463, 198)
        Me.lblsem.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblsem.Name = "lblsem"
        Me.lblsem.Size = New System.Drawing.Size(0, 26)
        Me.lblsem.TabIndex = 34
        '
        'lblsname
        '
        Me.lblsname.AutoSize = True
        Me.lblsname.BackColor = System.Drawing.Color.Transparent
        Me.lblsname.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsname.Location = New System.Drawing.Point(463, 150)
        Me.lblsname.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblsname.Name = "lblsname"
        Me.lblsname.Size = New System.Drawing.Size(0, 26)
        Me.lblsname.TabIndex = 33
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(205, 202)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 26)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Semester"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(205, 154)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(156, 26)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Student Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(205, 102)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 26)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "USN"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(204, 28)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(588, 39)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "INTERNAL ASSESSMENT MARKS"
        '
        'cmbsub
        '
        Me.cmbsub.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbsub.FormattingEnabled = True
        Me.cmbsub.Location = New System.Drawing.Point(468, 241)
        Me.cmbsub.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbsub.Name = "cmbsub"
        Me.cmbsub.Size = New System.Drawing.Size(200, 30)
        Me.cmbsub.TabIndex = 37
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(205, 251)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 26)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Subject"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(757, 434)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(164, 23)
        Me.Label6.TabIndex = 42
        Me.Label6.Text = "If Absent enter : 0"
        '
        'rbavg
        '
        Me.rbavg.AutoSize = True
        Me.rbavg.BackColor = System.Drawing.Color.Transparent
        Me.rbavg.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbavg.Location = New System.Drawing.Point(595, 400)
        Me.rbavg.Margin = New System.Windows.Forms.Padding(4)
        Me.rbavg.Name = "rbavg"
        Me.rbavg.Size = New System.Drawing.Size(102, 27)
        Me.rbavg.TabIndex = 41
        Me.rbavg.TabStop = True
        Me.rbavg.Text = "Average"
        Me.rbavg.UseVisualStyleBackColor = False
        '
        'rbtest3
        '
        Me.rbtest3.AutoSize = True
        Me.rbtest3.BackColor = System.Drawing.Color.Transparent
        Me.rbtest3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtest3.Location = New System.Drawing.Point(468, 400)
        Me.rbtest3.Margin = New System.Windows.Forms.Padding(4)
        Me.rbtest3.Name = "rbtest3"
        Me.rbtest3.Size = New System.Drawing.Size(82, 27)
        Me.rbtest3.TabIndex = 40
        Me.rbtest3.TabStop = True
        Me.rbtest3.Text = "Test 3"
        Me.rbtest3.UseVisualStyleBackColor = False
        '
        'rbtest2
        '
        Me.rbtest2.AutoSize = True
        Me.rbtest2.BackColor = System.Drawing.Color.Transparent
        Me.rbtest2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtest2.Location = New System.Drawing.Point(336, 400)
        Me.rbtest2.Margin = New System.Windows.Forms.Padding(4)
        Me.rbtest2.Name = "rbtest2"
        Me.rbtest2.Size = New System.Drawing.Size(82, 27)
        Me.rbtest2.TabIndex = 39
        Me.rbtest2.TabStop = True
        Me.rbtest2.Text = "Test 2"
        Me.rbtest2.UseVisualStyleBackColor = False
        '
        'rbtest1
        '
        Me.rbtest1.AutoSize = True
        Me.rbtest1.BackColor = System.Drawing.Color.Transparent
        Me.rbtest1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtest1.Location = New System.Drawing.Point(211, 400)
        Me.rbtest1.Margin = New System.Windows.Forms.Padding(4)
        Me.rbtest1.Name = "rbtest1"
        Me.rbtest1.Size = New System.Drawing.Size(82, 27)
        Me.rbtest1.TabIndex = 38
        Me.rbtest1.TabStop = True
        Me.rbtest1.Text = "Test 1"
        Me.rbtest1.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(205, 311)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(182, 26)
        Me.Label7.TabIndex = 43
        Me.Label7.Text = "Marks Obtained"
        '
        'txtmarks
        '
        Me.txtmarks.Location = New System.Drawing.Point(468, 315)
        Me.txtmarks.Margin = New System.Windows.Forms.Padding(4)
        Me.txtmarks.Name = "txtmarks"
        Me.txtmarks.Size = New System.Drawing.Size(200, 22)
        Me.txtmarks.TabIndex = 44
        '
        'btnclose
        '
        Me.btnclose.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.Location = New System.Drawing.Point(497, 555)
        Me.btnclose.Margin = New System.Windows.Forms.Padding(4)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(100, 41)
        Me.btnclose.TabIndex = 46
        Me.btnclose.Text = "Close"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.Location = New System.Drawing.Point(363, 555)
        Me.btnsave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(100, 41)
        Me.btnsave.TabIndex = 45
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'frmnewiaentry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1227, 693)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.txtmarks)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.rbavg)
        Me.Controls.Add(Me.rbtest3)
        Me.Controls.Add(Me.rbtest2)
        Me.Controls.Add(Me.rbtest1)
        Me.Controls.Add(Me.cmbsub)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblusn)
        Me.Controls.Add(Me.lblsem)
        Me.Controls.Add(Me.lblsname)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmnewiaentry"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblusn As System.Windows.Forms.TextBox
    Friend WithEvents lblsem As System.Windows.Forms.Label
    Friend WithEvents lblsname As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbsub As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents rbavg As System.Windows.Forms.RadioButton
    Friend WithEvents rbtest3 As System.Windows.Forms.RadioButton
    Friend WithEvents rbtest2 As System.Windows.Forms.RadioButton
    Friend WithEvents rbtest1 As System.Windows.Forms.RadioButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtmarks As System.Windows.Forms.TextBox
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
End Class
