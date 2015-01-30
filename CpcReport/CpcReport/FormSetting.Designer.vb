<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSetting
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSetting))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.DayReportTemplet = New System.Windows.Forms.TextBox
        Me.File01CheckBox = New System.Windows.Forms.CheckBox
        Me.File01Name = New System.Windows.Forms.TextBox
        Me.File02Name = New System.Windows.Forms.TextBox
        Me.File02CheckBox = New System.Windows.Forms.CheckBox
        Me.File03Name = New System.Windows.Forms.TextBox
        Me.File03CheckBox = New System.Windows.Forms.CheckBox
        Me.File04Name = New System.Windows.Forms.TextBox
        Me.File04CheckBox = New System.Windows.Forms.CheckBox
        Me.File05Name = New System.Windows.Forms.TextBox
        Me.File05CheckBox = New System.Windows.Forms.CheckBox
        Me.File06Name = New System.Windows.Forms.TextBox
        Me.File06CheckBox = New System.Windows.Forms.CheckBox
        Me.File07Name = New System.Windows.Forms.TextBox
        Me.File07CheckBox = New System.Windows.Forms.CheckBox
        Me.File08Name = New System.Windows.Forms.TextBox
        Me.File08CheckBox = New System.Windows.Forms.CheckBox
        Me.File09Name = New System.Windows.Forms.TextBox
        Me.File09CheckBox = New System.Windows.Forms.CheckBox
        Me.File10Name = New System.Windows.Forms.TextBox
        Me.File10CheckBox = New System.Windows.Forms.CheckBox
        Me.DayReportPath = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.TempletSelectButton = New System.Windows.Forms.Button
        Me.PathSelectButton = New System.Windows.Forms.Button
        Me.HourText = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.MinText = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.SecText = New System.Windows.Forms.TextBox
        Me.SaveButton = New System.Windows.Forms.Button
        Me.CloseButton = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.FolderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 18)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 24)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "日報表時間："
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 53)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 24)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "日報表範例："
        '
        'DayReportTemplet
        '
        Me.DayReportTemplet.Location = New System.Drawing.Point(163, 50)
        Me.DayReportTemplet.Name = "DayReportTemplet"
        Me.DayReportTemplet.Size = New System.Drawing.Size(461, 32)
        Me.DayReportTemplet.TabIndex = 6
        '
        'File01CheckBox
        '
        Me.File01CheckBox.AutoSize = True
        Me.File01CheckBox.Location = New System.Drawing.Point(17, 129)
        Me.File01CheckBox.Name = "File01CheckBox"
        Me.File01CheckBox.Size = New System.Drawing.Size(89, 28)
        Me.File01CheckBox.TabIndex = 7
        Me.File01CheckBox.Text = "機台01"
        Me.File01CheckBox.UseVisualStyleBackColor = True
        '
        'File01Name
        '
        Me.File01Name.Location = New System.Drawing.Point(163, 126)
        Me.File01Name.Name = "File01Name"
        Me.File01Name.Size = New System.Drawing.Size(500, 32)
        Me.File01Name.TabIndex = 8
        '
        'File02Name
        '
        Me.File02Name.Location = New System.Drawing.Point(163, 164)
        Me.File02Name.Name = "File02Name"
        Me.File02Name.Size = New System.Drawing.Size(500, 32)
        Me.File02Name.TabIndex = 10
        '
        'File02CheckBox
        '
        Me.File02CheckBox.AutoSize = True
        Me.File02CheckBox.Location = New System.Drawing.Point(17, 167)
        Me.File02CheckBox.Name = "File02CheckBox"
        Me.File02CheckBox.Size = New System.Drawing.Size(89, 28)
        Me.File02CheckBox.TabIndex = 9
        Me.File02CheckBox.Text = "機台02"
        Me.File02CheckBox.UseVisualStyleBackColor = True
        '
        'File03Name
        '
        Me.File03Name.Location = New System.Drawing.Point(163, 202)
        Me.File03Name.Name = "File03Name"
        Me.File03Name.Size = New System.Drawing.Size(500, 32)
        Me.File03Name.TabIndex = 12
        '
        'File03CheckBox
        '
        Me.File03CheckBox.AutoSize = True
        Me.File03CheckBox.Location = New System.Drawing.Point(17, 205)
        Me.File03CheckBox.Name = "File03CheckBox"
        Me.File03CheckBox.Size = New System.Drawing.Size(89, 28)
        Me.File03CheckBox.TabIndex = 11
        Me.File03CheckBox.Text = "機台03"
        Me.File03CheckBox.UseVisualStyleBackColor = True
        '
        'File04Name
        '
        Me.File04Name.Location = New System.Drawing.Point(163, 240)
        Me.File04Name.Name = "File04Name"
        Me.File04Name.Size = New System.Drawing.Size(500, 32)
        Me.File04Name.TabIndex = 14
        '
        'File04CheckBox
        '
        Me.File04CheckBox.AutoSize = True
        Me.File04CheckBox.Location = New System.Drawing.Point(17, 243)
        Me.File04CheckBox.Name = "File04CheckBox"
        Me.File04CheckBox.Size = New System.Drawing.Size(89, 28)
        Me.File04CheckBox.TabIndex = 13
        Me.File04CheckBox.Text = "機台04"
        Me.File04CheckBox.UseVisualStyleBackColor = True
        '
        'File05Name
        '
        Me.File05Name.Location = New System.Drawing.Point(163, 278)
        Me.File05Name.Name = "File05Name"
        Me.File05Name.Size = New System.Drawing.Size(500, 32)
        Me.File05Name.TabIndex = 16
        '
        'File05CheckBox
        '
        Me.File05CheckBox.AutoSize = True
        Me.File05CheckBox.Location = New System.Drawing.Point(17, 281)
        Me.File05CheckBox.Name = "File05CheckBox"
        Me.File05CheckBox.Size = New System.Drawing.Size(89, 28)
        Me.File05CheckBox.TabIndex = 15
        Me.File05CheckBox.Text = "機台05"
        Me.File05CheckBox.UseVisualStyleBackColor = True
        '
        'File06Name
        '
        Me.File06Name.Location = New System.Drawing.Point(163, 316)
        Me.File06Name.Name = "File06Name"
        Me.File06Name.Size = New System.Drawing.Size(500, 32)
        Me.File06Name.TabIndex = 18
        '
        'File06CheckBox
        '
        Me.File06CheckBox.AutoSize = True
        Me.File06CheckBox.Location = New System.Drawing.Point(17, 319)
        Me.File06CheckBox.Name = "File06CheckBox"
        Me.File06CheckBox.Size = New System.Drawing.Size(89, 28)
        Me.File06CheckBox.TabIndex = 17
        Me.File06CheckBox.Text = "機台06"
        Me.File06CheckBox.UseVisualStyleBackColor = True
        '
        'File07Name
        '
        Me.File07Name.Location = New System.Drawing.Point(163, 354)
        Me.File07Name.Name = "File07Name"
        Me.File07Name.Size = New System.Drawing.Size(500, 32)
        Me.File07Name.TabIndex = 20
        '
        'File07CheckBox
        '
        Me.File07CheckBox.AutoSize = True
        Me.File07CheckBox.Location = New System.Drawing.Point(17, 357)
        Me.File07CheckBox.Name = "File07CheckBox"
        Me.File07CheckBox.Size = New System.Drawing.Size(89, 28)
        Me.File07CheckBox.TabIndex = 19
        Me.File07CheckBox.Text = "機台07"
        Me.File07CheckBox.UseVisualStyleBackColor = True
        '
        'File08Name
        '
        Me.File08Name.Location = New System.Drawing.Point(163, 392)
        Me.File08Name.Name = "File08Name"
        Me.File08Name.Size = New System.Drawing.Size(500, 32)
        Me.File08Name.TabIndex = 22
        '
        'File08CheckBox
        '
        Me.File08CheckBox.AutoSize = True
        Me.File08CheckBox.Location = New System.Drawing.Point(17, 395)
        Me.File08CheckBox.Name = "File08CheckBox"
        Me.File08CheckBox.Size = New System.Drawing.Size(89, 28)
        Me.File08CheckBox.TabIndex = 21
        Me.File08CheckBox.Text = "機台08"
        Me.File08CheckBox.UseVisualStyleBackColor = True
        '
        'File09Name
        '
        Me.File09Name.Location = New System.Drawing.Point(163, 430)
        Me.File09Name.Name = "File09Name"
        Me.File09Name.Size = New System.Drawing.Size(500, 32)
        Me.File09Name.TabIndex = 24
        '
        'File09CheckBox
        '
        Me.File09CheckBox.AutoSize = True
        Me.File09CheckBox.Location = New System.Drawing.Point(17, 433)
        Me.File09CheckBox.Name = "File09CheckBox"
        Me.File09CheckBox.Size = New System.Drawing.Size(89, 28)
        Me.File09CheckBox.TabIndex = 23
        Me.File09CheckBox.Text = "機台09"
        Me.File09CheckBox.UseVisualStyleBackColor = True
        '
        'File10Name
        '
        Me.File10Name.Location = New System.Drawing.Point(163, 468)
        Me.File10Name.Name = "File10Name"
        Me.File10Name.Size = New System.Drawing.Size(500, 32)
        Me.File10Name.TabIndex = 26
        '
        'File10CheckBox
        '
        Me.File10CheckBox.AutoSize = True
        Me.File10CheckBox.Location = New System.Drawing.Point(17, 471)
        Me.File10CheckBox.Name = "File10CheckBox"
        Me.File10CheckBox.Size = New System.Drawing.Size(89, 28)
        Me.File10CheckBox.TabIndex = 25
        Me.File10CheckBox.Text = "機台10"
        Me.File10CheckBox.UseVisualStyleBackColor = True
        '
        'DayReportPath
        '
        Me.DayReportPath.Location = New System.Drawing.Point(163, 88)
        Me.DayReportPath.Name = "DayReportPath"
        Me.DayReportPath.Size = New System.Drawing.Size(461, 32)
        Me.DayReportPath.TabIndex = 28
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 91)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 24)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "日報表路徑："
        '
        'TempletSelectButton
        '
        Me.TempletSelectButton.Location = New System.Drawing.Point(630, 50)
        Me.TempletSelectButton.Name = "TempletSelectButton"
        Me.TempletSelectButton.Size = New System.Drawing.Size(33, 33)
        Me.TempletSelectButton.TabIndex = 29
        Me.TempletSelectButton.Text = "…"
        Me.TempletSelectButton.UseVisualStyleBackColor = True
        '
        'PathSelectButton
        '
        Me.PathSelectButton.Location = New System.Drawing.Point(630, 87)
        Me.PathSelectButton.Name = "PathSelectButton"
        Me.PathSelectButton.Size = New System.Drawing.Size(33, 33)
        Me.PathSelectButton.TabIndex = 30
        Me.PathSelectButton.Text = "…"
        Me.PathSelectButton.UseVisualStyleBackColor = True
        '
        'HourText
        '
        Me.HourText.Location = New System.Drawing.Point(163, 12)
        Me.HourText.Name = "HourText"
        Me.HourText.Size = New System.Drawing.Size(100, 32)
        Me.HourText.TabIndex = 31
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(270, 16)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 24)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "時"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(413, 16)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 24)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "分"
        '
        'MinText
        '
        Me.MinText.Location = New System.Drawing.Point(306, 12)
        Me.MinText.Name = "MinText"
        Me.MinText.Size = New System.Drawing.Size(100, 32)
        Me.MinText.TabIndex = 33
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(556, 14)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 24)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "秒"
        '
        'SecText
        '
        Me.SecText.Location = New System.Drawing.Point(449, 10)
        Me.SecText.Name = "SecText"
        Me.SecText.Size = New System.Drawing.Size(100, 32)
        Me.SecText.TabIndex = 35
        '
        'SaveButton
        '
        Me.SaveButton.Location = New System.Drawing.Point(453, 511)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(96, 31)
        Me.SaveButton.TabIndex = 37
        Me.SaveButton.Text = "儲存"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'CloseButton
        '
        Me.CloseButton.Location = New System.Drawing.Point(567, 511)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(96, 31)
        Me.CloseButton.TabIndex = 38
        Me.CloseButton.Text = "取消"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(578, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 20)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "(24小時制)"
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.Filter = "Excel檔(*.xltx;*.xlsx)|*.xltx;*.xlsx"
        '
        'FormSetting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 554)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.SecText)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.MinText)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.HourText)
        Me.Controls.Add(Me.PathSelectButton)
        Me.Controls.Add(Me.TempletSelectButton)
        Me.Controls.Add(Me.DayReportPath)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.File10Name)
        Me.Controls.Add(Me.File10CheckBox)
        Me.Controls.Add(Me.File09Name)
        Me.Controls.Add(Me.File09CheckBox)
        Me.Controls.Add(Me.File08Name)
        Me.Controls.Add(Me.File08CheckBox)
        Me.Controls.Add(Me.File07Name)
        Me.Controls.Add(Me.File07CheckBox)
        Me.Controls.Add(Me.File06Name)
        Me.Controls.Add(Me.File06CheckBox)
        Me.Controls.Add(Me.File05Name)
        Me.Controls.Add(Me.File05CheckBox)
        Me.Controls.Add(Me.File04Name)
        Me.Controls.Add(Me.File04CheckBox)
        Me.Controls.Add(Me.File03Name)
        Me.Controls.Add(Me.File03CheckBox)
        Me.Controls.Add(Me.File02Name)
        Me.Controls.Add(Me.File02CheckBox)
        Me.Controls.Add(Me.File01Name)
        Me.Controls.Add(Me.File01CheckBox)
        Me.Controls.Add(Me.DayReportTemplet)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("微軟正黑體", 14.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormSetting"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "設定"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DayReportTemplet As System.Windows.Forms.TextBox
    Friend WithEvents File01CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents File01Name As System.Windows.Forms.TextBox
    Friend WithEvents File02Name As System.Windows.Forms.TextBox
    Friend WithEvents File02CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents File03Name As System.Windows.Forms.TextBox
    Friend WithEvents File03CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents File04Name As System.Windows.Forms.TextBox
    Friend WithEvents File04CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents File05Name As System.Windows.Forms.TextBox
    Friend WithEvents File05CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents File06Name As System.Windows.Forms.TextBox
    Friend WithEvents File06CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents File07Name As System.Windows.Forms.TextBox
    Friend WithEvents File07CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents File08Name As System.Windows.Forms.TextBox
    Friend WithEvents File08CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents File09Name As System.Windows.Forms.TextBox
    Friend WithEvents File09CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents File10Name As System.Windows.Forms.TextBox
    Friend WithEvents File10CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents DayReportPath As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TempletSelectButton As System.Windows.Forms.Button
    Friend WithEvents PathSelectButton As System.Windows.Forms.Button
    Friend WithEvents HourText As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents MinText As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents SecText As System.Windows.Forms.TextBox
    Friend WithEvents SaveButton As System.Windows.Forms.Button
    Friend WithEvents CloseButton As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents FolderBrowserDialog As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents OpenFileDialog As System.Windows.Forms.OpenFileDialog
End Class
