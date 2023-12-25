Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub

    Dim winnerlabel As String = "Winner"
    Dim loserlabel As String = "Loser"

    Private Sub winnerMessage()
        MessageBox.Show("Congratulations you won iphone 14 pro max!!!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub loserMessage()
        MessageBox.Show("You lose better try next time", "notification", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        Call winnerMessage()
        Label1.Text = "Result: " & winnerlabel
        Label1.ForeColor = Color.Green
        CheckBox2.Enabled = False
        CheckBox3.Enabled = False
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        Call loserMessage()
        Label1.Text = "Result: " & loserlabel
        Label1.ForeColor = Color.Red
        CheckBox1.Enabled = False
        CheckBox3.Enabled = False
    End Sub


    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged
        Call loserMessage()
        Label1.Text = "Result: " & loserlabel
        Label1.ForeColor = Color.Red
        CheckBox1.Enabled = False
        CheckBox2.Enabled = False
    End Sub
End Class
