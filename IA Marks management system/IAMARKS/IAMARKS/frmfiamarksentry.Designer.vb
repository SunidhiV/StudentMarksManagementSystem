<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmfiamarksentry
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbsub = New System.Windows.Forms.ComboBox()
        Me.rbtest1 = New System.Windows.Forms.RadioButton()
        Me.rbtest2 = New System.Windows.Forms.RadioButton()
        Me.rbtest3 = New System.Windows.Forms.RadioButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.cmbsem = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.lblfont = New System.Windows.Forms.Label()
        Me.btnfillgrid = New System.Windows.Forms.Button()
        Me.rbavg = New System.Windows.Forms.RadioButton()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(461, 11)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(286, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "IA-MARKS ENTRY"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(647, 98)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 26)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Subject"
        '
        'cmbsub
        '
        Me.cmbsub.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbsub.FormattingEnabled = True
        Me.cmbsub.Location = New System.Drawing.Point(749, 98)
        Me.cmbsub.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbsub.Name = "cmbsub"
        Me.cmbsub.Size = New System.Drawing.Size(160, 30)
        Me.cmbsub.TabIndex = 3
        '
        'rbtest1
        '
        Me.rbtest1.AutoSize = True
        Me.rbtest1.BackColor = System.Drawing.Color.Transparent
        Me.rbtest1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtest1.Location = New System.Drawing.Point(312, 159)
        Me.rbtest1.Margin = New System.Windows.Forms.Padding(4)
        Me.rbtest1.Name = "rbtest1"
        Me.rbtest1.Size = New System.Drawing.Size(82, 27)
        Me.rbtest1.TabIndex = 5
        Me.rbtest1.TabStop = True
        Me.rbtest1.Text = "Test 1"
        Me.rbtest1.UseVisualStyleBackColor = False
        '
        'rbtest2
        '
        Me.rbtest2.AutoSize = True
        Me.rbtest2.BackColor = System.Drawing.Color.Transparent
        Me.rbtest2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtest2.Location = New System.Drawing.Point(437, 159)
        Me.rbtest2.Margin = New System.Windows.Forms.Padding(4)
        Me.rbtest2.Name = "rbtest2"
        Me.rbtest2.Size = New System.Drawing.Size(82, 27)
        Me.rbtest2.TabIndex = 6
        Me.rbtest2.TabStop = True
        Me.rbtest2.Text = "Test 2"
        Me.rbtest2.UseVisualStyleBackColor = False
        '
        'rbtest3
        '
        Me.rbtest3.AutoSize = True
        Me.rbtest3.BackColor = System.Drawing.Color.Transparent
        Me.rbtest3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtest3.Location = New System.Drawing.Point(569, 159)
        Me.rbtest3.Margin = New System.Windows.Forms.Padding(4)
        Me.rbtest3.Name = "rbtest3"
        Me.rbtest3.Size = New System.Drawing.Size(82, 27)
        Me.rbtest3.TabIndex = 7
        Me.rbtest3.TabStop = True
        Me.rbtest3.Text = "Test 3"
        Me.rbtest3.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(193, 225)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(877, 492)
        Me.DataGridView1.TabIndex = 8
        '
        'cmbsem
        '
        Me.cmbsem.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbsem.FormattingEnabled = True
        Me.cmbsem.Location = New System.Drawing.Point(387, 97)
        Me.cmbsem.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbsem.Name = "cmbsem"
        Me.cmbsem.Size = New System.Drawing.Size(160, 30)
        Me.cmbsem.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(241, 98)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 26)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Semester"
        '
        'btnsave
        '
        Me.btnsave.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.Location = New System.Drawing.Point(1284, 185)
        Me.btnsave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(100, 41)
        Me.btnsave.TabIndex = 11
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'lblfont
        '
        Me.lblfont.AutoSize = True
        Me.lblfont.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfont.Location = New System.Drawing.Point(1597, 489)
        Me.lblfont.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblfont.Name = "lblfont"
        Me.lblfont.Size = New System.Drawing.Size(83, 26)
        Me.lblfont.TabIndex = 12
        Me.lblfont.Text = "Label5"
        Me.lblfont.Visible = False
        '
        'btnfillgrid
        '
        Me.btnfillgrid.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnfillgrid.Location = New System.Drawing.Point(1137, 185)
        Me.btnfillgrid.Margin = New System.Windows.Forms.Padding(4)
        Me.btnfillgrid.Name = "btnfillgrid"
        Me.btnfillgrid.Size = New System.Drawing.Size(139, 41)
        Me.btnfillgrid.TabIndex = 13
        Me.btnfillgrid.Text = "Fill Grid"
        Me.btnfillgrid.UseVisualStyleBackColor = True
        '
        'rbavg
        '
        Me.rbavg.AutoSize = True
        Me.rbavg.BackColor = System.Drawing.Color.Transparent
        Me.rbavg.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbavg.Location = New System.Drawing.Point(696, 159)
        Me.rbavg.Margin = New System.Windows.Forms.Padding(4)
        Me.rbavg.Name = "rbavg"
        Me.rbavg.Size = New System.Drawing.Size(102, 27)
        Me.rbavg.TabIndex = 14
        Me.rbavg.TabStop = True
        Me.rbavg.Text = "Average"
        Me.rbavg.UseVisualStyleBackColor = False
        '
        'btnclose
        '
        Me.btnclose.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.Location = New System.Drawing.Point(1392, 185)
        Me.btnclose.Margin = New System.Windows.Forms.Padding(4)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(100, 41)
        Me.btnclose.TabIndex = 15
        Me.btnclose.Text = "Close"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(859, 193)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(164, 23)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "If Absent enter : 0"
        '
        'frmfiamarksentry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.IAMARKS.My.Resources.Resources._11
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1799, 721)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.rbavg)
        Me.Controls.Add(Me.btnfillgrid)
        Me.Controls.Add(Me.lblfont)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.cmbsem)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.rbtest3)
        Me.Controls.Add(Me.rbtest2)
        Me.Controls.Add(Me.rbtest1)
        Me.Controls.Add(Me.cmbsub)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmfiamarksentry"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbsub As System.Windows.Forms.ComboBox
    Friend WithEvents rbtest1 As System.Windows.Forms.RadioButton
    Friend WithEvents rbtest2 As System.Windows.Forms.RadioButton
    Friend WithEvents rbtest3 As System.Windows.Forms.RadioButton
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents cmbsem As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents lblfont As System.Windows.Forms.Label
    Friend WithEvents btnfillgrid As System.Windows.Forms.Button
    Friend WithEvents rbavg As System.Windows.Forms.RadioButton
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
