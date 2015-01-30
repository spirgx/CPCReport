<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請不要使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
        Me.Label1 = New System.Windows.Forms.Label
        Me.StartDatePicker = New System.Windows.Forms.DateTimePicker
        Me.StartTimePicker = New System.Windows.Forms.DateTimePicker
        Me.EndTimePicker = New System.Windows.Forms.DateTimePicker
        Me.EndDatePicker = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.DataView = New System.Windows.Forms.DataGridView
        Me.SearchButton = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.MenuStrip = New System.Windows.Forms.MenuStrip
        Me.FuncTSMI = New System.Windows.Forms.ToolStripMenuItem
        Me.DbTSMI = New System.Windows.Forms.ToolStripMenuItem
        Me.SettingTSMI = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitTSMI = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpTSMI = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutTSMI = New System.Windows.Forms.ToolStripMenuItem
        Me.Label9 = New System.Windows.Forms.Label
        Me.NotifyIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.MachineSelect = New System.Windows.Forms.ComboBox
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.DataView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 60)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "開始時間："
        '
        'StartDatePicker
        '
        Me.StartDatePicker.CustomFormat = "yyyy年 MM月 dd日"
        Me.StartDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.StartDatePicker.Location = New System.Drawing.Point(129, 56)
        Me.StartDatePicker.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.StartDatePicker.Name = "StartDatePicker"
        Me.StartDatePicker.Size = New System.Drawing.Size(200, 32)
        Me.StartDatePicker.TabIndex = 1
        '
        'StartTimePicker
        '
        Me.StartTimePicker.CustomFormat = "tt hh : mm : ss"
        Me.StartTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.StartTimePicker.Location = New System.Drawing.Point(337, 56)
        Me.StartTimePicker.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.StartTimePicker.Name = "StartTimePicker"
        Me.StartTimePicker.ShowUpDown = True
        Me.StartTimePicker.Size = New System.Drawing.Size(200, 32)
        Me.StartTimePicker.TabIndex = 2
        '
        'EndTimePicker
        '
        Me.EndTimePicker.CustomFormat = "tt hh : mm : ss"
        Me.EndTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.EndTimePicker.Location = New System.Drawing.Point(337, 100)
        Me.EndTimePicker.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.EndTimePicker.Name = "EndTimePicker"
        Me.EndTimePicker.ShowUpDown = True
        Me.EndTimePicker.Size = New System.Drawing.Size(200, 32)
        Me.EndTimePicker.TabIndex = 5
        '
        'EndDatePicker
        '
        Me.EndDatePicker.CustomFormat = "yyyy年 MM月 dd日"
        Me.EndDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.EndDatePicker.Location = New System.Drawing.Point(129, 100)
        Me.EndDatePicker.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.EndDatePicker.Name = "EndDatePicker"
        Me.EndDatePicker.Size = New System.Drawing.Size(200, 32)
        Me.EndDatePicker.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 103)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 24)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "結束時間："
        '
        'DataView
        '
        Me.DataView.AllowUserToAddRows = False
        Me.DataView.AllowUserToDeleteRows = False
        Me.DataView.AllowUserToResizeRows = False
        Me.DataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataView.Location = New System.Drawing.Point(15, 188)
        Me.DataView.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.DataView.Name = "DataView"
        Me.DataView.RowTemplate.Height = 24
        Me.DataView.Size = New System.Drawing.Size(990, 537)
        Me.DataView.TabIndex = 6
        '
        'SearchButton
        '
        Me.SearchButton.Location = New System.Drawing.Point(563, 56)
        Me.SearchButton.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(125, 120)
        Me.SearchButton.TabIndex = 7
        Me.SearchButton.Text = "搜尋"
        Me.SearchButton.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(1258, 125)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(136, 47)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "目前報表"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(1258, 40)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(136, 47)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "設定"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'MenuStrip
        '
        Me.MenuStrip.Enabled = False
        Me.MenuStrip.Font = New System.Drawing.Font("微軟正黑體", 14.0!)
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FuncTSMI, Me.HelpTSMI})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Padding = New System.Windows.Forms.Padding(7, 3, 0, 3)
        Me.MenuStrip.Size = New System.Drawing.Size(1018, 34)
        Me.MenuStrip.TabIndex = 17
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'FuncTSMI
        '
        Me.FuncTSMI.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DbTSMI, Me.SettingTSMI, Me.ExitTSMI})
        Me.FuncTSMI.Name = "FuncTSMI"
        Me.FuncTSMI.Size = New System.Drawing.Size(82, 28)
        Me.FuncTSMI.Text = "功能(&F)"
        '
        'DbTSMI
        '
        Me.DbTSMI.Name = "DbTSMI"
        Me.DbTSMI.Size = New System.Drawing.Size(169, 28)
        Me.DbTSMI.Text = "資料庫(&N) "
        '
        'SettingTSMI
        '
        Me.SettingTSMI.Name = "SettingTSMI"
        Me.SettingTSMI.Size = New System.Drawing.Size(169, 28)
        Me.SettingTSMI.Text = "設定(&S)"
        '
        'ExitTSMI
        '
        Me.ExitTSMI.Name = "ExitTSMI"
        Me.ExitTSMI.Size = New System.Drawing.Size(169, 28)
        Me.ExitTSMI.Text = "離開(&E)"
        '
        'HelpTSMI
        '
        Me.HelpTSMI.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutTSMI})
        Me.HelpTSMI.Name = "HelpTSMI"
        Me.HelpTSMI.Size = New System.Drawing.Size(86, 28)
        Me.HelpTSMI.Text = "幫助(&H)"
        '
        'AboutTSMI
        '
        Me.AboutTSMI.Name = "AboutTSMI"
        Me.AboutTSMI.Size = New System.Drawing.Size(143, 28)
        Me.AboutTSMI.Text = "關於(&A)"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(16, 147)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(105, 24)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "機台選擇："
        '
        'NotifyIcon
        '
        Me.NotifyIcon.Icon = CType(resources.GetObject("NotifyIcon.Icon"), System.Drawing.Icon)
        Me.NotifyIcon.Text = "中油報表程式"
        Me.NotifyIcon.Visible = True
        '
        'MachineSelect
        '
        Me.MachineSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MachineSelect.FormattingEnabled = True
        Me.MachineSelect.Location = New System.Drawing.Point(129, 141)
        Me.MachineSelect.Name = "MachineSelect"
        Me.MachineSelect.Size = New System.Drawing.Size(200, 32)
        Me.MachineSelect.TabIndex = 19
        '
        'Timer
        '
        Me.Timer.Interval = 1000
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1018, 740)
        Me.Controls.Add(Me.MachineSelect)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.SearchButton)
        Me.Controls.Add(Me.DataView)
        Me.Controls.Add(Me.EndTimePicker)
        Me.Controls.Add(Me.EndDatePicker)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.StartTimePicker)
        Me.Controls.Add(Me.StartDatePicker)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip)
        Me.Font = New System.Drawing.Font("微軟正黑體", 14.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "中油報表系統"
        CType(Me.DataView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents StartDatePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents StartTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents EndTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents EndDatePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DataView As System.Windows.Forms.DataGridView
    Friend WithEvents SearchButton As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents FuncTSMI As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DbTSMI As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingTSMI As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitTSMI As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpTSMI As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutTSMI As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents NotifyIcon As System.Windows.Forms.NotifyIcon
    Friend WithEvents MachineSelect As System.Windows.Forms.ComboBox
    Friend WithEvents Timer As System.Windows.Forms.Timer

End Class
