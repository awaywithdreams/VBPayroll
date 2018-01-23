<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radiohourly = New System.Windows.Forms.RadioButton()
        Me.radiosalary = New System.Windows.Forms.RadioButton()
        Me.txtrate = New System.Windows.Forms.TextBox()
        Me.txthours = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuabout = New System.Windows.Forms.ToolStripMenuItem()
        Me.menurecord = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisplayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuexit = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnrecord = New System.Windows.Forms.Button()
        Me.btndisplay = New System.Windows.Forms.Button()
        Me.dgvdisplay = New System.Windows.Forms.DataGridView()
        Me.btnreport = New System.Windows.Forms.Button()
        Me.lstreport = New System.Windows.Forms.ListBox()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dgvdisplay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtname
        '
        Me.txtname.BackColor = System.Drawing.Color.PaleGreen
        Me.txtname.Font = New System.Drawing.Font("Elephant", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname.Location = New System.Drawing.Point(68, 28)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(166, 24)
        Me.txtname.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Elephant", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Name:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.radiohourly)
        Me.GroupBox1.Controls.Add(Me.radiosalary)
        Me.GroupBox1.Font = New System.Drawing.Font("Elephant", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(15, 58)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(198, 56)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Type:"
        '
        'radiohourly
        '
        Me.radiohourly.AutoSize = True
        Me.radiohourly.Location = New System.Drawing.Point(102, 20)
        Me.radiohourly.Name = "radiohourly"
        Me.radiohourly.Size = New System.Drawing.Size(72, 21)
        Me.radiohourly.TabIndex = 1
        Me.radiohourly.TabStop = True
        Me.radiohourly.Text = "Hourly"
        Me.radiohourly.UseVisualStyleBackColor = True
        '
        'radiosalary
        '
        Me.radiosalary.AutoSize = True
        Me.radiosalary.Location = New System.Drawing.Point(17, 20)
        Me.radiosalary.Name = "radiosalary"
        Me.radiosalary.Size = New System.Drawing.Size(79, 21)
        Me.radiosalary.TabIndex = 0
        Me.radiosalary.TabStop = True
        Me.radiosalary.Text = "Salaried"
        Me.radiosalary.UseVisualStyleBackColor = True
        '
        'txtrate
        '
        Me.txtrate.BackColor = System.Drawing.Color.PaleGreen
        Me.txtrate.Font = New System.Drawing.Font("Elephant", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrate.Location = New System.Drawing.Point(315, 33)
        Me.txtrate.Name = "txtrate"
        Me.txtrate.Size = New System.Drawing.Size(100, 24)
        Me.txtrate.TabIndex = 3
        '
        'txthours
        '
        Me.txthours.BackColor = System.Drawing.Color.PaleGreen
        Me.txthours.Font = New System.Drawing.Font("Elephant", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txthours.Location = New System.Drawing.Point(315, 78)
        Me.txthours.Name = "txthours"
        Me.txthours.Size = New System.Drawing.Size(100, 24)
        Me.txthours.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Elephant", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(260, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Rate"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Elephant", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(260, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Hours"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Font = New System.Drawing.Font("Elephant", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(472, 25)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuabout, Me.ToolStripMenuItem1, Me.menurecord, Me.DisplayToolStripMenuItem, Me.menuexit})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(45, 21)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'menuabout
        '
        Me.menuabout.BackColor = System.Drawing.Color.LightGreen
        Me.menuabout.Image = CType(resources.GetObject("menuabout.Image"), System.Drawing.Image)
        Me.menuabout.Name = "menuabout"
        Me.menuabout.Size = New System.Drawing.Size(152, 22)
        Me.menuabout.Text = "About"
        '
        'menurecord
        '
        Me.menurecord.BackColor = System.Drawing.Color.LightGreen
        Me.menurecord.Name = "menurecord"
        Me.menurecord.Size = New System.Drawing.Size(152, 22)
        Me.menurecord.Text = "Record"
        '
        'DisplayToolStripMenuItem
        '
        Me.DisplayToolStripMenuItem.BackColor = System.Drawing.Color.LightGreen
        Me.DisplayToolStripMenuItem.Name = "DisplayToolStripMenuItem"
        Me.DisplayToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DisplayToolStripMenuItem.Text = "Display"
        '
        'menuexit
        '
        Me.menuexit.BackColor = System.Drawing.Color.LightGreen
        Me.menuexit.Image = CType(resources.GetObject("menuexit.Image"), System.Drawing.Image)
        Me.menuexit.Name = "menuexit"
        Me.menuexit.Size = New System.Drawing.Size(124, 22)
        Me.menuexit.Text = "Exit"
        '
        'btnrecord
        '
        Me.btnrecord.BackColor = System.Drawing.Color.Transparent
        Me.btnrecord.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnrecord.Font = New System.Drawing.Font("Elephant", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrecord.Location = New System.Drawing.Point(142, 120)
        Me.btnrecord.Name = "btnrecord"
        Me.btnrecord.Size = New System.Drawing.Size(178, 33)
        Me.btnrecord.TabIndex = 8
        Me.btnrecord.Text = "Record Employee Hours"
        Me.btnrecord.UseVisualStyleBackColor = False
        '
        'btndisplay
        '
        Me.btndisplay.BackColor = System.Drawing.Color.Transparent
        Me.btndisplay.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btndisplay.Font = New System.Drawing.Font("Elephant", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndisplay.Location = New System.Drawing.Point(326, 120)
        Me.btndisplay.Name = "btndisplay"
        Me.btndisplay.Size = New System.Drawing.Size(117, 33)
        Me.btndisplay.TabIndex = 9
        Me.btndisplay.Text = "Display Payroll"
        Me.btndisplay.UseVisualStyleBackColor = False
        '
        'dgvdisplay
        '
        DataGridViewCellStyle16.BackColor = System.Drawing.Color.LightGreen
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Elephant", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.DarkOliveGreen
        Me.dgvdisplay.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle16
        Me.dgvdisplay.BackgroundColor = System.Drawing.Color.PaleGreen
        Me.dgvdisplay.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle17.BackColor = System.Drawing.Color.LightGreen
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Elephant", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.DarkOliveGreen
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvdisplay.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle17
        Me.dgvdisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle18.BackColor = System.Drawing.Color.LightGreen
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Elephant", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.DarkOliveGreen
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvdisplay.DefaultCellStyle = DataGridViewCellStyle18
        Me.dgvdisplay.GridColor = System.Drawing.Color.Lime
        Me.dgvdisplay.Location = New System.Drawing.Point(12, 170)
        Me.dgvdisplay.Name = "dgvdisplay"
        Me.dgvdisplay.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle19.BackColor = System.Drawing.Color.LightGreen
        DataGridViewCellStyle19.Font = New System.Drawing.Font("Elephant", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.DarkOliveGreen
        DataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvdisplay.RowHeadersDefaultCellStyle = DataGridViewCellStyle19
        DataGridViewCellStyle20.BackColor = System.Drawing.Color.LightGreen
        DataGridViewCellStyle20.Font = New System.Drawing.Font("Elephant", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle20.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.DarkOliveGreen
        Me.dgvdisplay.RowsDefaultCellStyle = DataGridViewCellStyle20
        Me.dgvdisplay.Size = New System.Drawing.Size(431, 101)
        Me.dgvdisplay.TabIndex = 10
        '
        'btnreport
        '
        Me.btnreport.BackColor = System.Drawing.Color.Transparent
        Me.btnreport.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnreport.Font = New System.Drawing.Font("Elephant", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreport.Location = New System.Drawing.Point(12, 120)
        Me.btnreport.Name = "btnreport"
        Me.btnreport.Size = New System.Drawing.Size(124, 33)
        Me.btnreport.TabIndex = 11
        Me.btnreport.Text = "Display Report"
        Me.btnreport.UseVisualStyleBackColor = False
        '
        'lstreport
        '
        Me.lstreport.BackColor = System.Drawing.Color.PaleGreen
        Me.lstreport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstreport.Font = New System.Drawing.Font("Elephant", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstreport.FormattingEnabled = True
        Me.lstreport.ItemHeight = 20
        Me.lstreport.Location = New System.Drawing.Point(12, 277)
        Me.lstreport.Name = "lstreport"
        Me.lstreport.Size = New System.Drawing.Size(431, 102)
        Me.lstreport.TabIndex = 12
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.BackColor = System.Drawing.Color.LightGreen
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.ToolStripMenuItem1.Text = "Report"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(472, 410)
        Me.Controls.Add(Me.lstreport)
        Me.Controls.Add(Me.btnreport)
        Me.Controls.Add(Me.dgvdisplay)
        Me.Controls.Add(Me.btndisplay)
        Me.Controls.Add(Me.btnrecord)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txthours)
        Me.Controls.Add(Me.txtrate)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Payroll"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dgvdisplay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtname As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radiohourly As RadioButton
    Friend WithEvents radiosalary As RadioButton
    Friend WithEvents txtrate As TextBox
    Friend WithEvents txthours As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents menuabout As ToolStripMenuItem
    Friend WithEvents menurecord As ToolStripMenuItem
    Friend WithEvents DisplayToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents menuexit As ToolStripMenuItem
    Friend WithEvents btnrecord As Button
    Friend WithEvents btndisplay As Button
    Friend WithEvents dgvdisplay As DataGridView
    Friend WithEvents btnreport As Button
    Friend WithEvents lstreport As ListBox
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
End Class
