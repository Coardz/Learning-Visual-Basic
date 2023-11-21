'Public Class Form1

'Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
'Dim Balance As Integer = 0
'Dim addBalance As Integer
'addBalance = Textbox1.Text
'Label1.Text = addBalance + Balance
'Label1.Text = ("$" & Textbox1.Text)
'End Sub
'End Class

Public Class Form1
    Private Balance As Integer = 0

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim addBalance As Integer
        If Integer.TryParse(Textbox1.Text, addBalance) Then
            Balance += addBalance
            Label1.Text = Balance.ToString()
        Else
            MessageBox.Show("Please enter a valid number.")
        End If
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim subtractBalance As Integer
        If Integer.TryParse(TextBox2.Text, subtractBalance) Then
            Balance -= subtractBalance
            Label1.Text = Balance.ToString
        End If
    End Sub
End Class
