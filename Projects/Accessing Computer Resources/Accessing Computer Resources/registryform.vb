Public Class registryform



    Sub regOptimizer()
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Optimizer",
          "settings1", "False")
        MessageBox.Show("Registry Successf")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim readrobloxVersion As Object
        readrobloxVersion = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\ROBLOX Corporation\Environments\roblox-player", "version", Nothing)
        MessageBox.Show("Your Current Version is:  " & CStr(readrobloxVersion))
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Call regOptimizer()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles readBtn.Click
        Dim readData As Object
        Dim readkeyPath As String
        Dim readvalueName As String

        readkeyPath = readkeyBox.Text
        readvalueName = readValueBox.Text

        If readkeyPath.StartsWith("Computer\") Then
            MessageBox.Show("Invalid key. Please enter a valid key without 'Computer\' prefix.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        readData = My.Computer.Registry.GetValue(readkeyPath, readvalueName, Nothing)

        If readData IsNot Nothing Then
            readdataHolder.Text = "Data: " & CStr(readData)
        Else
            readdataHolder.Text = "Data not found for the specified key and value."
        End If
    End Sub

    Private Sub editbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles editbtn.Click
        Dim editData As String
        Dim editValueName As String
        Dim editkeyPath As String

        editkeyPath = editkeyBox.Text
        editValueName = editvalueBox.Text
        editData = editdataBox.Text

        If editkeyPath.StartsWith("Computer\") Then
            MessageBox.Show("Invalid key. Please enter a valid key without 'Computer\' prefix.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        My.Computer.Registry.SetValue(editkeyPath, editValueName, editData)
        editdataholder.Text = "You set the value: " & editData
    End Sub
End Class
