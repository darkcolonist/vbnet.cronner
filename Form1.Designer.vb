<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnExecute = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.timIterator = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvLines = New System.Windows.Forms.DataGridView()
        Me.colUrl = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTimeLeft = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colExecutionCount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colIsRunning = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colExecute = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.tsiAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtLastExecuted = New System.Windows.Forms.TextBox()
        Me.txtInput = New System.Windows.Forms.RichTextBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.txtHover = New System.Windows.Forms.ToolStripStatusLabel()
        Me.txtStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.dgvConsole = New System.Windows.Forms.DataGridView()
        Me.dgvConsoleTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvConsoleUrl = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvConsoleOutput = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MyApplicationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvLines, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.dgvConsole, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MyApplicationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnExecute
        '
        Me.btnExecute.Location = New System.Drawing.Point(12, 176)
        Me.btnExecute.Name = "btnExecute"
        Me.btnExecute.Size = New System.Drawing.Size(75, 23)
        Me.btnExecute.TabIndex = 2
        Me.btnExecute.Text = "&Execute"
        Me.btnExecute.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(336, 176)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 4
        Me.btnClear.TabStop = False
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'timIterator
        '
        Me.timIterator.Interval = 1000
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.dgvLines)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 205)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(405, 185)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Running"
        '
        'dgvLines
        '
        Me.dgvLines.AllowUserToAddRows = False
        Me.dgvLines.AllowUserToDeleteRows = False
        Me.dgvLines.AllowUserToResizeRows = False
        Me.dgvLines.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dgvLines.BackgroundColor = System.Drawing.Color.Black
        Me.dgvLines.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colUrl, Me.colTime, Me.colTimeLeft, Me.colExecutionCount, Me.colIsRunning, Me.colExecute})
        Me.dgvLines.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvLines.GridColor = System.Drawing.Color.Lime
        Me.dgvLines.Location = New System.Drawing.Point(6, 19)
        Me.dgvLines.MultiSelect = False
        Me.dgvLines.Name = "dgvLines"
        Me.dgvLines.ReadOnly = True
        Me.dgvLines.RowHeadersVisible = False
        Me.dgvLines.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvLines.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvLines.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvLines.Size = New System.Drawing.Size(393, 160)
        Me.dgvLines.TabIndex = 0
        Me.dgvLines.TabStop = False
        '
        'colUrl
        '
        Me.colUrl.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Lime
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Lime
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colUrl.DefaultCellStyle = DataGridViewCellStyle1
        Me.colUrl.HeaderText = "URL"
        Me.colUrl.Name = "colUrl"
        Me.colUrl.ReadOnly = True
        '
        'colTime
        '
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Lime
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Lime
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        Me.colTime.DefaultCellStyle = DataGridViewCellStyle2
        Me.colTime.HeaderText = "I"
        Me.colTime.Name = "colTime"
        Me.colTime.ReadOnly = True
        Me.colTime.Width = 35
        '
        'colTimeLeft
        '
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Lime
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Lime
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        Me.colTimeLeft.DefaultCellStyle = DataGridViewCellStyle3
        Me.colTimeLeft.HeaderText = "R"
        Me.colTimeLeft.Name = "colTimeLeft"
        Me.colTimeLeft.ReadOnly = True
        Me.colTimeLeft.Width = 35
        '
        'colExecutionCount
        '
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Lime
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Lime
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        Me.colExecutionCount.DefaultCellStyle = DataGridViewCellStyle4
        Me.colExecutionCount.HeaderText = "C"
        Me.colExecutionCount.Name = "colExecutionCount"
        Me.colExecutionCount.ReadOnly = True
        Me.colExecutionCount.Width = 39
        '
        'colIsRunning
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Lime
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Lime
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        Me.colIsRunning.DefaultCellStyle = DataGridViewCellStyle5
        Me.colIsRunning.HeaderText = "Run?"
        Me.colIsRunning.Name = "colIsRunning"
        Me.colIsRunning.ReadOnly = True
        Me.colIsRunning.Width = 35
        '
        'colExecute
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Lime
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Lime
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        Me.colExecute.DefaultCellStyle = DataGridViewCellStyle6
        Me.colExecute.HeaderText = ""
        Me.colExecute.Name = "colExecute"
        Me.colExecute.ReadOnly = True
        Me.colExecute.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colExecute.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.colExecute.Text = ""
        Me.colExecute.Width = 27
        '
        'btnStop
        '
        Me.btnStop.Enabled = False
        Me.btnStop.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnStop.Location = New System.Drawing.Point(93, 176)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(75, 23)
        Me.btnStop.TabIndex = 3
        Me.btnStop.Text = "&Stop"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsiAbout})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(984, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'tsiAbout
        '
        Me.tsiAbout.Name = "tsiAbout"
        Me.tsiAbout.Size = New System.Drawing.Size(52, 20)
        Me.tsiAbout.Text = "About"
        '
        'txtLastExecuted
        '
        Me.txtLastExecuted.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLastExecuted.BackColor = System.Drawing.Color.Black
        Me.txtLastExecuted.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastExecuted.ForeColor = System.Drawing.Color.Lime
        Me.txtLastExecuted.Location = New System.Drawing.Point(12, 396)
        Me.txtLastExecuted.Multiline = True
        Me.txtLastExecuted.Name = "txtLastExecuted"
        Me.txtLastExecuted.ReadOnly = True
        Me.txtLastExecuted.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtLastExecuted.Size = New System.Drawing.Size(960, 181)
        Me.txtLastExecuted.TabIndex = 7
        Me.txtLastExecuted.TabStop = False
        Me.txtLastExecuted.Text = "last executed: ready"
        '
        'txtInput
        '
        Me.txtInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtInput.DetectUrls = False
        Me.txtInput.ForeColor = System.Drawing.Color.Green
        Me.txtInput.Location = New System.Drawing.Point(12, 27)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.txtInput.Size = New System.Drawing.Size(399, 143)
        Me.txtInput.TabIndex = 1
        Me.txtInput.Text = "http://dev.loop/messaging/routine/i_run_batch,5" & Global.Microsoft.VisualBasic.ChrW(10) & "http://dev.loop/messaging/routine" & _
    "/i_map_operators,5"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.txtHover, Me.txtStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 578)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(984, 24)
        Me.StatusStrip1.TabIndex = 8
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'txtHover
        '
        Me.txtHover.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHover.ForeColor = System.Drawing.Color.Green
        Me.txtHover.Name = "txtHover"
        Me.txtHover.Size = New System.Drawing.Size(108, 19)
        Me.txtHover.Text = "%hoveredRowUrl%"
        '
        'txtStatus
        '
        Me.txtStatus.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.Size = New System.Drawing.Size(40, 19)
        Me.txtStatus.Text = "ready"
        '
        'dgvConsole
        '
        Me.dgvConsole.AllowUserToAddRows = False
        Me.dgvConsole.AllowUserToDeleteRows = False
        Me.dgvConsole.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvConsole.BackgroundColor = System.Drawing.Color.Black
        Me.dgvConsole.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvConsole.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvConsoleTime, Me.dgvConsoleUrl, Me.dgvConsoleOutput})
        Me.dgvConsole.GridColor = System.Drawing.Color.Lime
        Me.dgvConsole.Location = New System.Drawing.Point(417, 27)
        Me.dgvConsole.Name = "dgvConsole"
        Me.dgvConsole.ReadOnly = True
        Me.dgvConsole.RowHeadersVisible = False
        Me.dgvConsole.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvConsole.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvConsole.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvConsole.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvConsole.Size = New System.Drawing.Size(555, 363)
        Me.dgvConsole.TabIndex = 6
        '
        'dgvConsoleTime
        '
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Lime
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Lime
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvConsoleTime.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgvConsoleTime.HeaderText = "Time"
        Me.dgvConsoleTime.Name = "dgvConsoleTime"
        Me.dgvConsoleTime.ReadOnly = True
        Me.dgvConsoleTime.Width = 60
        '
        'dgvConsoleUrl
        '
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Lime
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Lime
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvConsoleUrl.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgvConsoleUrl.HeaderText = "URL"
        Me.dgvConsoleUrl.Name = "dgvConsoleUrl"
        Me.dgvConsoleUrl.ReadOnly = True
        '
        'dgvConsoleOutput
        '
        Me.dgvConsoleOutput.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Lime
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Lime
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvConsoleOutput.DefaultCellStyle = DataGridViewCellStyle9
        Me.dgvConsoleOutput.HeaderText = "Output"
        Me.dgvConsoleOutput.Name = "dgvConsoleOutput"
        Me.dgvConsoleOutput.ReadOnly = True
        '
        'MyApplicationBindingSource
        '
        Me.MyApplicationBindingSource.DataSource = GetType(dc.cronner.My.MyApplication)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 602)
        Me.Controls.Add(Me.dgvConsole)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.txtLastExecuted)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnExecute)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimumSize = New System.Drawing.Size(900, 600)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dc.Cronner"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvLines, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.dgvConsole, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MyApplicationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnExecute As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents timIterator As System.Windows.Forms.Timer
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvLines As System.Windows.Forms.DataGridView
    Friend WithEvents btnStop As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents tsiAbout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtLastExecuted As System.Windows.Forms.TextBox
    Friend WithEvents txtInput As System.Windows.Forms.RichTextBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents txtStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents txtHover As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents dgvConsole As System.Windows.Forms.DataGridView
    Friend WithEvents MyApplicationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colUrl As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTime As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTimeLeft As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colExecutionCount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colIsRunning As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colExecute As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents dgvConsoleTime As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvConsoleUrl As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvConsoleOutput As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
