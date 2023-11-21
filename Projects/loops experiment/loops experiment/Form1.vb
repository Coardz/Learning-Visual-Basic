Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim age As Integer = 18

        For age = 18 To 20
            Select Case age
                Case 18
                    MessageBox.Show("Welcome 18 Year's Old")
                Case 19
                    MessageBox.Show("Welcome 19 Year's Old")
                Case 20
                    MessageBox.Show("Welcome 20 Year's Old")
            End Select
        Next
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        'this me pooron no money
        Dim Cash As Integer = 0

        'this the max since we only have 5 days on school
        Do While Cash <= 250
            '            MessageBox.Show("You're balance is :" & Cash)

            'this the code that give cash
            Cash = Cash + 50

            'This the messagebox that message
            Select Case Cash
                Case 50
                    MessageBox.Show("You're balance is :" & Cash, "Monday")
                Case 100
                    MessageBox.Show("You're balance is :" & Cash, "Tuesday")
                Case 150
                    MessageBox.Show("You're balance is :" & Cash, "Wednesday")
                Case 200
                    MessageBox.Show("You're balance is :" & Cash, "Thursday")
                Case 250
                    MessageBox.Show("You're balance is :" & Cash, "Friday")
            End Select
        Loop


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim alphabet() As String = {"A", "B", "C"}

        For Each character As Char In alphabet
            MessageBox.Show(character)
        Next
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

    End Sub
End Class
