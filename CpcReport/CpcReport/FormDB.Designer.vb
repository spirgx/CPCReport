<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDB
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormDB))
        Me.ServerName = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.UserID = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.UserPassword = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.DataBaseName = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.SaveDB = New System.Windows.Forms.Button
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog
        Me.SuspendLayout()
        '
        'ServerName
        '
        Me.ServerName.Location = New System.Drawing.Point(163, 8)
        Me.ServerName.Name = "ServerName"
        Me.ServerName.Size = New System.Drawing.Size(200, 33)
        Me.ServerName.TabIndex = 32
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 12)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 24)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "伺服器位址："
        '
        'UserID
        '
        Me.UserID.Location = New System.Drawing.Point(163, 47)
        Me.UserID.Name = "UserID"
        Me.UserID.Size = New System.Drawing.Size(200, 33)
        Me.UserID.TabIndex = 35
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 54)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 24)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "使用者名稱："
        '
        'UserPassword
        '
        Me.UserPassword.Location = New System.Drawing.Point(163, 87)
        Me.UserPassword.Name = "UserPassword"
        Me.UserPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.UserPassword.Size = New System.Drawing.Size(200, 33)
        Me.UserPassword.TabIndex = 37
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 92)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 24)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "使用者密碼："
        '
        'DataBaseName
        '
        Me.DataBaseName.Location = New System.Drawing.Point(163, 126)
        Me.DataBaseName.Name = "DataBaseName"
        Me.DataBaseName.Size = New System.Drawing.Size(200, 33)
        Me.DataBaseName.TabIndex = 39
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 130)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(124, 24)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "資料庫位址："
        '
        'SaveDB
        '
        Me.SaveDB.Location = New System.Drawing.Point(274, 164)
        Me.SaveDB.Name = "SaveDB"
        Me.SaveDB.Size = New System.Drawing.Size(88, 33)
        Me.SaveDB.TabIndex = 42
        Me.SaveDB.Text = "設定"
        Me.SaveDB.UseVisualStyleBackColor = True
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.Filter = "資料庫(*.mdf)|*.mdf"
        '
        'FormDB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(379, 202)
        Me.Controls.Add(Me.SaveDB)
        Me.Controls.Add(Me.DataBaseName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.UserPassword)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.UserID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ServerName)
        Me.Controls.Add(Me.Label3)
        Me.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormDB"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "資料庫設定"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ServerName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents UserID As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents UserPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DataBaseName As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents SaveDB As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog As System.Windows.Forms.OpenFileDialog
End Class
