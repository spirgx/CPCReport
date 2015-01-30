Public Class FormDB



    Private Sub FormDB_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        FormMain.Show()
    End Sub

    Private Sub FormDB_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ServerName.Text = My.Settings.SQLServerLocation
        UserID.Text = My.Settings.SQLUserID
        UserPassword.Text = My.Settings.SQLUserPassword
        DataBaseName.Text = My.Settings.DatabaseName

    End Sub

    Private Sub SaveDB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveDB.Click

        My.Settings.SQLServerLocation = ServerName.Text
        My.Settings.SQLUserID = UserID.Text
        My.Settings.SQLUserPassword = UserPassword.Text
        My.Settings.DatabaseName = DataBaseName.Text

        My.Settings.Save()

        Me.Hide()
        FormMain.Show()

    End Sub

    Private Sub CreatDB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        ConnectToDatabase()
        DisconnectFromDatabase()

    End Sub

    Private Sub DataBaseName_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataBaseName.Click

        If Not (OpenFileDialog.ShowDialog() = Windows.Forms.DialogResult.Cancel) Then
            DataBaseName.Text = OpenFileDialog.FileName
        End If

    End Sub

    
End Class