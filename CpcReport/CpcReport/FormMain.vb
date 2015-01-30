Public Class FormMain



    Protected Overrides Sub OnFormClosing(ByVal e As FormClosingEventArgs)

        If e.CloseReason = CloseReason.WindowsShutDown Then
            End
        End If

        e.Cancel = True
        NotifyIcon.Visible = True
        NotifyIcon.BalloonTipText = Me.Text
        NotifyIcon.ShowBalloonTip(1000)
        Me.Visible = False

        MessageBox.Show("程式將縮小至工作列", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub SettingTSMI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SettingTSMI.Click

        FormSetting.Show()
        Me.Hide()

    End Sub

    Private Sub ExitTSMI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitTSMI.Click

        If MessageBox.Show("關閉程式將無法產生報表，確定要離開嗎？", "訊息", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then

            NotifyIcon.Visible = False
            End

        End If

    End Sub

    Private Sub NotifyIcon_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon.MouseDoubleClick

        NotifyIcon.Visible = False
        Me.Show()

    End Sub


    Private Sub MachineSelectComInit()

        Dim list As New DataTable()
        Dim i As Integer

        list.Columns.Add(New DataColumn("Display", System.Type.GetType("System.String")))
        list.Columns.Add(New DataColumn("Value", System.Type.GetType("System.String")))

        For i = 1 To 10
            list.Rows.Add(list.NewRow())
        Next

        list.Rows(0)(0) = "機台一"
        list.Rows(0)(1) = "Day01"
        list.Rows(1)(0) = "機台二"
        list.Rows(1)(1) = "Day02"
        list.Rows(2)(0) = "機台三"
        list.Rows(2)(1) = "Day03"
        list.Rows(3)(0) = "機台四"
        list.Rows(3)(1) = "Day04"
        list.Rows(4)(0) = "機台五"
        list.Rows(4)(1) = "Day05"
        list.Rows(5)(0) = "機台六"
        list.Rows(5)(1) = "Day06"
        list.Rows(6)(0) = "機台七"
        list.Rows(6)(1) = "Day07"
        list.Rows(7)(0) = "機台八"
        list.Rows(7)(1) = "Day08"
        list.Rows(8)(0) = "機台九"
        list.Rows(8)(1) = "Day09"
        list.Rows(9)(0) = "機台十"
        list.Rows(9)(1) = "Day10"

        MachineSelect.DataSource = list
        MachineSelect.DisplayMember = "Display"
        MachineSelect.ValueMember = "Value"
        MachineSelect.SelectedIndex = 0


    End Sub

    Private Sub CheckExcelIsInstall()

        On Error Resume Next

        xlApp = GetObject(, "Excel.Application")
        If Err.Number() <> 0 Then
            Err.Clear()
            '#執行一個新的Excel Application            
            xlApp = CreateObject("Excel.Application")
            If Err.Number() <> 0 Then
                MsgBox("電腦沒有安裝Excel")
                Exit Sub
            End If
        End If

        xlApp.Quit()

    End Sub


    Private Sub FormMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load



        CheckExcelIsInstall()
        NotifyIcon.Visible = False

        '******************************************************************
        'SettingPassword當天日期YYYYMMDD，更改後可設定資料庫及檔案名稱等。*
        '******************************************************************
        Today = Now.Year.ToString("0000").ToString + Now.Month.ToString("00").ToString + Now.Day.ToString("00").ToString

        If String.Compare(Today, My.Settings.SettingPassword) Then
            MenuStrip.Enabled = False
        Else
            MenuStrip.Enabled = True
        End If

        MachineSelectComInit()

        Timer.Start()

    End Sub

    Private Sub DbTSMI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DbTSMI.Click

        FormDB.Show()
        Me.Hide()

    End Sub

    Private Sub SearchButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchButton.Click

        Dim StartDate As String
        Dim StartTime As String
        Dim EndDate As String
        Dim EndTime As String
        Dim StartDateTime As String
        Dim EndDateTime As String

        StartDate = Format(StartDatePicker.Value, "yyyy/MM/dd")
        StartTime = Format(StartTimePicker.Value, "HH:mm:ss")
        StartDateTime = StartDate & " " & StartTime

        EndDate = Format(EndDatePicker.Value, "yyyy/MM/dd")
        EndTime = Format(EndTimePicker.Value, "HH:mm:ss")
        EndDateTime = EndDate & " " & EndTime

        ConnectToDatabase()

        QueryStr = "SELECT * FROM " + MachineSelect.SelectedValue.ToString + " WHERE DATETIME BETWEEN @StartDate AND @EndDate"

        QueryAdapt = New System.Data.SqlClient.SqlDataAdapter(QueryStr, gDBConn)

        QueryAdapt.SelectCommand.Parameters.Add("@StartDate", SqlDbType.Char).Value = StartDateTime.Trim
        QueryAdapt.SelectCommand.Parameters.Add("@EndDate", SqlDbType.Char).Value = EndDateTime.Trim

        QuerySet = New System.Data.DataSet
        QueryAdapt.Fill(QuerySet, "Data")

        DataView.DataSource = QuerySet.Tables("Data")

        DisconnectFromDatabase()

    End Sub

    Private Sub Timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer.Tick

        SettingTime = String.Format("{0:00}", Val(My.Settings.DayReportHour)) + _
                        String.Format("{0:00}", Val(My.Settings.DayReportMin)) + _
                            String.Format("{0:00}", Val(My.Settings.DayReportSec))
        NowTime = Now.Hour.ToString("00") + Now.Minute.ToString("00") + Now.Second.ToString("00")


        If String.Compare(SettingTime, NowTime) Then
        Else
            CheckReport()
        End If

    End Sub

    Private Sub CheckReport()

        CheckExcelIsInstall()

        Dim FileCheckBoxArray() As Boolean = {My.Settings.File01Check, My.Settings.File02Check, My.Settings.File03Check, My.Settings.File04Check, My.Settings.File05Check, _
                                              My.Settings.File06Check, My.Settings.File07Check, My.Settings.File08Check, My.Settings.File09Check, My.Settings.File10Check}

        Dim FileNameTextArray() As String = {My.Settings.File01Name.Trim, My.Settings.File02Name.Trim, My.Settings.File03Name.Trim, My.Settings.File04Name.Trim, My.Settings.File05Name.Trim, _
                                             My.Settings.File06Name.Trim, My.Settings.File07Name.Trim, My.Settings.File08Name.Trim, My.Settings.File09Name.Trim, My.Settings.File10Name.Trim}

        Dim i As Integer

        For i = 0 To 9
            If FileCheckBoxArray(i) Then

                CreatReport(FileNameTextArray(i), "Day" + String.Format("{0:00}", i + 1))

            End If
        Next

    End Sub

    Private Sub CreatReport(ByVal FileName As String, ByVal Table As String)

        Dim i, j As Integer

        If My.Settings.DayReportTemplet.Trim <> "" Then
            xlBook = xlApp.Workbooks.Open(My.Settings.DayReportTemplet)
        End If

        xlApp.DisplayAlerts = False
        xlApp.Visible = False
        xlBook.Activate()
        xlBook.Parent.Windows(1).Visible = True

        xlSheet = xlBook.Worksheets(1)
        xlSheet.Activate()

        ConnectToDatabase()

        QueryStr = "SELECT * FROM " + Table + " WHERE [DATETIME] Between " + _
                    " ( CONVERT(varchar(10),getDate(),120) + ' 00:00:00.000 ' ) And ( CONVERT(varchar(10),getDate(),120) + ' 23:59:59.999 ' ) "


        QueryAdapt = New System.Data.SqlClient.SqlDataAdapter(QueryStr, gDBConn)
        QuerySet = New System.Data.DataSet
        QueryAdapt.Fill(QuerySet, "Data")

        For i = 0 To QuerySet.Tables("Data").Rows.Count - 1
            For j = 0 To QuerySet.Tables("Data").Columns.Count - 1

                xlSheet.Range(Chr(65 + j).ToString + (i + 1).ToString).Value = QuerySet.Tables("Data").Rows(i).Item(j).ToString

            Next
        Next

        If IO.File.Exists(My.Settings.DayReportPath & FileName & Today & ".xlsx") Then
            IO.File.Delete(My.Settings.DayReportPath & FileName & Today & ".xlsx")
        End If

        xlBook.SaveAs(My.Settings.DayReportPath & FileName & Today & ".xlsx")
        xlBook.Close()
        xlApp.Quit()

        DisconnectFromDatabase()

    End Sub


End Class
