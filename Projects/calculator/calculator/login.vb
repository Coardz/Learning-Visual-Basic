Public Class login

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "coardz" And TextBox2.Text = "aj212132" Then
            TextBox1.Text = ""
            TextBox2.Text = ""
            Me.Hide()
            MessageBox.Show("Login Successfully!", "Notification")
            index.Show()
        Else
            MessageBox.Show("Login Failed!", "Notification")
            TextBox1.Text = ""
            TextBox2.Text = ""
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
