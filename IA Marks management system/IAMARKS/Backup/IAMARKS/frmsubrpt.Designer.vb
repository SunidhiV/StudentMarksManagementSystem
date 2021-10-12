<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmsubrpt
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.btnpreview = New System.Windows.Forms.Button
        Me.btnclose = New System.Windows.Forms.Button
        Me.btnprint = New System.Windows.Forms.Button
        Me.dgvsubjewise = New System.Windows.Forms.DataGridView
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbsub = New System.Windows.Forms.ComboBox
        Me.rbtest1 = New System.Windows.Forms.RadioButton
        Me.rbtest2 = New System.Windows.Forms.RadioButton
        Me.rbtest3 = New System.Windows.Forms.RadioButton
        Me.rbavg = New System.Windows.Forms.RadioButton
        Me.cmbsem = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        CType(Me.dgvsubjewise, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnpreview
        '
        Me.btnpreview.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpreview.Location = New System.Drawing.Point(798, 94)
        Me.btnpreview.Name = "btnpreview"
        Me.btnpreview.Size = New System.Drawing.Size(136, 37)
        Me.btnpreview.TabIndex = 84
        Me.btnpreview.Text = "Print Preview"
        Me.btnpreview.UseVisualStyleBackColor = True
        '
        'btnclose
        '
        Me.btnclose.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.Location = New System.Drawing.Point(1031, 94)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(75, 37)
        Me.btnclose.TabIndex = 83
        Me.btnclose.Text = "Close"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'btnprint
        '
        Me.btnprint.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnprint.Location = New System.Drawing.Point(940, 94)
        Me.btnprint.Name = "btnprint"
        Me.btnprint.Size = New System.Drawing.Size(75, 37)
        Me.btnprint.TabIndex = 82
        Me.btnprint.Text = "Print"
        Me.btnprint.UseVisualStyleBackColor = True
        '
        'dgvsubjewise
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvsubjewise.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvsubjewise.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvsubjewise.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvsubjewise.Location = New System.Drawing.Point(327, 148)
        Me.dgvsubjewise.Name = "dgvsubjewise"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvsubjewise.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvsubjewise.Size = New System.Drawing.Size(497, 387)
        Me.dgvsubjewise.TabIndex = 81
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(372, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(489, 31)
        Me.Label1.TabIndex = 80
        Me.Label1.Text = "INTERNAL ASSESSMENT MARKS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(505, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(233, 25)
        Me.Label2.TabIndex = 85
        Me.Label2.Text = "Subject-Wise Report"
        '
        'PrintDocument1
        '
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(64, 228)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 22)
        Me.Label3.TabIndex = 86
        Me.Label3.Text = "Subject"
        '
        'cmbsub
        '
        Me.cmbsub.FormattingEnabled = True
        Me.cmbsub.Location = New System.Drawing.Point(165, 229)
        Me.cmbsub.Name = "cmbsub"
        Me.cmbsub.Size = New System.Drawing.Size(121, 21)
        Me.cmbsub.TabIndex = 87
        '
        'rbtest1
        '
        Me.rbtest1.AutoSize = True
        Me.rbtest1.BackColor = System.Drawing.Color.Transparent
        Me.rbtest1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtest1.Location = New System.Drawing.Point(71, 94)
        Me.rbtest1.Name = "rbtest1"
        Me.rbtest1.Size = New System.Drawing.Size(64, 23)
        Me.rbtest1.TabIndex = 88
        Me.rbtest1.TabStop = True
        Me.rbtest1.Text = "Test1"
        Me.rbtest1.UseVisualStyleBackColor = False
        '
        'rbtest2
        '
        Me.rbtest2.AutoSize = True
        Me.rbtest2.BackColor = System.Drawing.Color.Transparent
        Me.rbtest2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtest2.Location = New System.Drawing.Point(141, 94)
        Me.rbtest2.Name = "rbtest2"
        Me.rbtest2.Size = New System.Drawing.Size(64, 23)
        Me.rbtest2.TabIndex = 89
        Me.rbtest2.TabStop = True
        Me.rbtest2.Text = "Test2"
        Me.rbtest2.UseVisualStyleBackColor = False
        '
        'rbtest3
        '
        Me.rbtest3.AutoSize = True
        Me.rbtest3.BackColor = System.Drawing.Color.Transparent
        Me.rbtest3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtest3.Location = New System.Drawing.Point(225, 94)
        Me.rbtest3.Name = "rbtest3"
        Me.rbtest3.Size = New System.Drawing.Size(64, 23)
        Me.rbtest3.TabIndex = 90
        Me.rbtest3.TabStop = True
        Me.rbtest3.Text = "Test3"
        Me.rbtest3.UseVisualStyleBackColor = False
        '
        'rbavg
        '
        Me.rbavg.AutoSize = True
        Me.rbavg.BackColor = System.Drawing.Color.Transparent
        Me.rbavg.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbavg.Location = New System.Drawing.Point(314, 94)
        Me.rbavg.Name = "rbavg"
        Me.rbavg.Size = New System.Drawing.Size(83, 23)
        Me.rbavg.TabIndex = 91
        Me.rbavg.TabStop = True
        Me.rbavg.Text = "Average"
        Me.rbavg.UseVisualStyleBackColor = False
        '
        'cmbsem
        '
        Me.cmbsem.FormattingEnabled = True
        Me.cmbsem.Location = New System.Drawing.Point(165, 180)
        Me.cmbsem.Name = "cmbsem"
        Me.cmbsem.Size = New System.Drawing.Size(121, 21)
        Me.cmbsem.TabIndex = 93
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(64, 179)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 22)
        Me.Label4.TabIndex = 92
        Me.Label4.Text = "Semester"
        '
        'frmsubrpt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.IAMARKS.My.Resources.Resources.bgbar
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1349, 563)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmbsem)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.rbavg)
        Me.Controls.Add(Me.rbtest3)
        Me.Controls.Add(Me.rbtest2)
        Me.Controls.Add(Me.rbtest1)
        Me.Controls.Add(Me.cmbsub)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnpreview)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.btnprint)
        Me.Controls.Add(Me.dgvsubjewise)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Name = "frmsubrpt"
        CType(Me.dgvsubjewise, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnpreview As System.Windows.Forms.Button
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents btnprint As System.Windows.Forms.Button
    Friend WithEvents dgvsubjewise As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbsub As System.Windows.Forms.ComboBox
    Friend WithEvents rbtest1 As System.Windows.Forms.RadioButton
    Friend WithEvents rbtest2 As System.Windows.Forms.RadioButton
    Friend WithEvents rbtest3 As System.Windows.Forms.RadioButton
    Friend WithEvents rbavg As System.Windows.Forms.RadioButton
    Friend WithEvents cmbsem As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
