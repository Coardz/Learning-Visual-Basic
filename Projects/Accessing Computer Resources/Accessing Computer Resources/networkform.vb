Public Class networkform

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        My.Computer.Network.DownloadFile(
            "https://drive.usercontent.google.com/download?id=1dLK9X4M8hdoJXsspTNQ7l_3n8vA_mxA6&export=download&authuser=0&confirm=t&uuid=fc96c5b1-4fcf-40bc-92d2-e0d704e53f4b&at=APZUnTWVScHxXkhRTkij28C1aaPj:1702288226270", "C:\Users\coardz\Pictures\poster.jpg", "Anonymous", "")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If My.Computer.Network.IsAvailable Then
            Label1.Text = "internet available"
        Else
            Label1.Text = "internet unavailable"
        End If

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
    End Sub
End Class
