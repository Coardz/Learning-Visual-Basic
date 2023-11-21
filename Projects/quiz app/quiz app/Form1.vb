Public Class Form1


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        question1.Visible = False
        btnAnswer.Visible = False
        ProgressBar1.Visible = False
    End Sub

    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        question1.Visible = True
        btnStart.Visible = False
        btnAnswer.Visible = True
        ProgressBar1.Visible = True
    End Sub


    Private Sub btnAnswer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnswer.Click
        'progressbar tracker
        ProgressBar1.Value = ProgressBar1.Value + 20

        'answer color revealer
        RadioButton1.ForeColor = Color.Green
        RadioButton2.ForeColor = Color.Red
        RadioButton3.ForeColor = Color.Red
        RadioButton4.ForeColor = Color.Red

        'answer revealer
        If RadioButton1.Checked = True Then
            MessageBox.Show("You're Correct", "Notification")
            RadioButton2.Enabled = False
            RadioButton3.Enabled = False
            RadioButton4.Enabled = False
        ElseIf RadioButton2.Checked = True Then
            MessageBox.Show("You're Wrong", "Notification")
            RadioButton1.Enabled = False
            RadioButton3.Enabled = False
            RadioButton4.Enabled = False
        ElseIf RadioButton3.Checked = True Then
            MessageBox.Show("You're Wrong", "Notification")
            RadioButton1.Enabled = False
            RadioButton2.Enabled = False
            RadioButton4.Enabled = False
        ElseIf RadioButton4.Checked = True Then
            MessageBox.Show("You're Wrong", "Notification")
            RadioButton1.Enabled = False
            RadioButton2.Enabled = False
            RadioButton3.Enabled = False
        End If
    End Sub
End Class
