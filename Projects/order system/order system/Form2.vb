Public Class Form2

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        drinksmenu1.Visible = True
        notespanel.Visible = False
        mealsmenu1.Visible = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        drinksmenu1.Visible = False
        notespanel.Visible = False
        mealsmenu1.Visible = True
    End Sub
End Class