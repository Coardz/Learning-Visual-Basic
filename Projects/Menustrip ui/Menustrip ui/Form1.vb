Public Class Form1

    Private Sub HelpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpToolStripMenuItem.Click
        MessageBox.Show("Contact Administrator", "Help")
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub DarkModeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DarkModeToolStripMenuItem.Click
        If DarkModeToolStripMenuItem.Checked Then
            ' Enable Dark Mode
            EnableDarkMode()
        Else
            ' Disable Dark Mode
            DisableDarkMode()
        End If
    End Sub

    Private Sub EnableDarkMode()
        Me.BackColor = Color.Black
        Me.ForeColor = Color.White ' Set text color to white
        ' Set the back color for other controls if needed
        ' For example:
        ' Label1.BackColor = Color.Black
        ' TextBox1.BackColor = Color.Gray
        ' ...
        Label1.Text = "Bye"
        Label1.ForeColor = Color.White
    End Sub

    Private Sub DisableDarkMode()
        ' Reset to the default colors
        Me.BackColor = SystemColors.Control
        Me.ForeColor = SystemColors.ControlText ' Reset text 
        ' Reset the back color for other controls if needed
        ' For example:
        ' Label1.BackColor = SystemColors.Control
        ' TextBox1.BackColor = SystemColors.Window
        ' ...

        Label1.Text = "Hello"
        Label1.ForeColor = Color.Black
    End Sub
End Class
