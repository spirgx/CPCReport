Imports System.Text.RegularExpressions

Public Class FormSetting

    'Dim FileCheckBoxArray() As CheckBox
    'Dim FileNameTextArray() As TextBox
    Dim reg As Regex


    Private Sub FormSetting_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        FormMain.Show()
    End Sub

    Private Sub FormSetting_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'FileCheckBoxArray = New CheckBox() {File01CheckBox, File02CheckBox, File03CheckBox, File04CheckBox, File05CheckBox, _
        '                                    File06CheckBox, File07CheckBox, File08CheckBox, File09CheckBox, File10CheckBox}

        'FileNameTextArray = New TextBox() {File01Name, File02Name, File03Name, File04Name, File05Name, _
        '                                   File06Name, File07Name, File08Name, File09Name, File10Name}

        File01CheckBox.Checked = My.Settings.File01Check
        File02CheckBox.Checked = My.Settings.File02Check
        File03CheckBox.Checked = My.Settings.File03Check
        File04CheckBox.Checked = My.Settings.File04Check
        File05CheckBox.Checked = My.Settings.File05Check
        File06CheckBox.Checked = My.Settings.File06Check
        File07CheckBox.Checked = My.Settings.File07Check
        File08CheckBox.Checked = My.Settings.File08Check
        File09CheckBox.Checked = My.Settings.File09Check
        File10CheckBox.Checked = My.Settings.File10Check

        File01Name.Enabled = My.Settings.File01Check
        File02Name.Enabled = My.Settings.File02Check
        File03Name.Enabled = My.Settings.File03Check
        File04Name.Enabled = My.Settings.File04Check
        File05Name.Enabled = My.Settings.File05Check
        File06Name.Enabled = My.Settings.File06Check
        File07Name.Enabled = My.Settings.File07Check
        File08Name.Enabled = My.Settings.File08Check
        File09Name.Enabled = My.Settings.File09Check
        File10Name.Enabled = My.Settings.File10Check

        HourText.Text = My.Settings.DayReportHour.ToString
        MinText.Text = My.Settings.DayReportMin.ToString
        SecText.Text = My.Settings.DayReportSec.ToString

        DayReportTemplet.Text = My.Settings.DayReportTemplet.ToString
        DayReportPath.Text = My.Settings.DayReportPath.ToString

        File01Name.Text = My.Settings.File01Name
        File02Name.Text = My.Settings.File02Name
        File03Name.Text = My.Settings.File03Name
        File04Name.Text = My.Settings.File04Name
        File05Name.Text = My.Settings.File05Name
        File06Name.Text = My.Settings.File06Name
        File07Name.Text = My.Settings.File07Name
        File08Name.Text = My.Settings.File08Name
        File09Name.Text = My.Settings.File09Name
        File10Name.Text = My.Settings.File10Name

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles File01CheckBox.CheckedChanged
        File01Name.Enabled = File01CheckBox.Checked
    End Sub

    Private Sub File02CheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles File02CheckBox.CheckedChanged
        File02Name.Enabled = File02CheckBox.Checked
    End Sub

    Private Sub File03CheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles File03CheckBox.CheckedChanged
        File03Name.Enabled = File03CheckBox.Checked
    End Sub

    Private Sub File04CheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles File04CheckBox.CheckedChanged
        File04Name.Enabled = File04CheckBox.Checked
    End Sub

    Private Sub File05CheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles File05CheckBox.CheckedChanged
        File05Name.Enabled = File05CheckBox.Checked
    End Sub

    Private Sub File06CheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles File06CheckBox.CheckedChanged
        File06Name.Enabled = File06CheckBox.Checked
    End Sub

    Private Sub File07CheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles File07CheckBox.CheckedChanged
        File07Name.Enabled = File07CheckBox.Checked
    End Sub

    Private Sub File08CheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles File08CheckBox.CheckedChanged
        File08Name.Enabled = File08CheckBox.Checked
    End Sub

    Private Sub File09CheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles File09CheckBox.CheckedChanged
        File09Name.Enabled = File09CheckBox.Checked
    End Sub

    Private Sub File10CheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles File10CheckBox.CheckedChanged
        File10Name.Enabled = File10CheckBox.Checked
    End Sub

    Private Sub CloseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseButton.Click

        Me.Hide()
        FormMain.Show()

    End Sub

    Private Sub SaveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveButton.Click

        My.Settings.DayReportHour = HourText.Text
        My.Settings.DayReportMin = MinText.Text
        My.Settings.DayReportSec = SecText.Text

        My.Settings.DayReportTemplet = DayReportTemplet.Text
        My.Settings.DayReportPath = DayReportPath.Text

        My.Settings.File01Check = File01CheckBox.CheckState
        My.Settings.File02Check = File02CheckBox.CheckState
        My.Settings.File03Check = File03CheckBox.CheckState
        My.Settings.File04Check = File04CheckBox.CheckState
        My.Settings.File05Check = File05CheckBox.CheckState
        My.Settings.File06Check = File06CheckBox.CheckState
        My.Settings.File07Check = File07CheckBox.CheckState
        My.Settings.File08Check = File08CheckBox.CheckState
        My.Settings.File09Check = File09CheckBox.CheckState
        My.Settings.File10Check = File10CheckBox.CheckState

        My.Settings.File01Name = File01Name.Text
        My.Settings.File02Name = File02Name.Text
        My.Settings.File03Name = File03Name.Text
        My.Settings.File04Name = File04Name.Text
        My.Settings.File05Name = File05Name.Text
        My.Settings.File06Name = File06Name.Text
        My.Settings.File07Name = File07Name.Text
        My.Settings.File08Name = File08Name.Text
        My.Settings.File09Name = File09Name.Text
        My.Settings.File10Name = File10Name.Text

        My.Settings.Save()
        Me.Hide()
        FormMain.Show()

    End Sub


    Private Sub TempletSelectButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TempletSelectButton.Click

        If Not (OpenFileDialog.ShowDialog() = Windows.Forms.DialogResult.Cancel) Then
            DayReportTemplet.Text = OpenFileDialog.FileName
        End If

    End Sub

    Private Sub PathSelectButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PathSelectButton.Click

        If Not (FolderBrowserDialog.ShowDialog() = Windows.Forms.DialogResult.Cancel) Then
            DayReportPath.Text = FolderBrowserDialog.SelectedPath
        End If

    End Sub

    Private Sub HourText_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HourText.TextChanged

        reg = New Regex("^(2[0-3]|1[0-9]|[0-9])$")

        If Not (reg.IsMatch(HourText.Text) Or HourText.Text = "") Then
            MessageBox.Show("格式錯誤,請重新輸入", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error)
            HourText.Text = ""
        End If

    End Sub

    Private Sub MinText_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MinText.TextChanged

        reg = New Regex("^(60|[1-5][0-9]|[0-9])$")

        If Not (reg.IsMatch(MinText.Text) Or MinText.Text = "") Then
            MessageBox.Show("格式錯誤,請重新輸入", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error)
            MinText.Text = ""
        End If

    End Sub

    Private Sub SecText_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SecText.TextChanged

        reg = New Regex("^(60|[1-5][0-9]|[0-9])$")

        If Not (reg.IsMatch(SecText.Text) Or SecText.Text = "") Then
            MessageBox.Show("格式錯誤,請重新輸入", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error)
            SecText.Text = ""
        End If

    End Sub
End Class