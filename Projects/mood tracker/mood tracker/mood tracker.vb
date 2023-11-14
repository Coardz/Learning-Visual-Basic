Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "happy" Then
            Label1.Text = "Good to hear :)"
            ListBox1.Items.Add(TextBox1.Text)
            MessageBox.Show("Saved", "Mood Tracker")
        ElseIf TextBox1.Text = "sad" Then
            Label1.Text = "Sad to hear :("
            ListBox1.Items.Add(TextBox1.Text)
            MessageBox.Show("Saved", "Mood Tracker")
        Else
            Label1.Text = "Ask a friend"
            MessageBox.Show("Try again", "Mood Tracker")
        End If

    End Sub
End Class
