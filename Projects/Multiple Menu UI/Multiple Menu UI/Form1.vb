Public Enum PanelList
    Example1
    Example2
    Example3
    Example4
    Example5
    Example6
    Example7
    Example8
End Enum

Public Class Form1
#Region "Panel Switch"
    Private Sub ShowPanel(ByVal panel As PanelList)
        Select Case panel
            Case PanelList.Example1
                Example1.Visible = True
                Example2.Visible = False
                Example3.Visible = False
                Example4.Visible = False
                Example5.Visible = False
                Example6.Visible = False
                Example7.Visible = False
                Example8.Visible = False
            Case PanelList.Example2
                Example1.Visible = False
                Example2.Visible = True
                Example3.Visible = False
                Example4.Visible = False
                Example5.Visible = False
                Example6.Visible = False
                Example7.Visible = False
                Example8.Visible = False
            Case PanelList.Example3
                Example1.Visible = False
                Example2.Visible = False
                Example3.Visible = True
                Example4.Visible = False
                Example5.Visible = False
                Example6.Visible = False
                Example7.Visible = False
                Example8.Visible = False
            Case PanelList.Example4
                Example1.Visible = False
                Example2.Visible = False
                Example3.Visible = False
                Example4.Visible = True
                Example5.Visible = False
                Example6.Visible = False
                Example7.Visible = False
                Example8.Visible = False
            Case PanelList.Example5
                Example1.Visible = False
                Example2.Visible = False
                Example3.Visible = False
                Example4.Visible = False
                Example5.Visible = True
                Example6.Visible = False
                Example7.Visible = False
                Example8.Visible = False
            Case PanelList.Example6
                Example1.Visible = False
                Example2.Visible = False
                Example3.Visible = False
                Example4.Visible = False
                Example5.Visible = False
                Example6.Visible = True
                Example7.Visible = False
                Example8.Visible = False
            Case PanelList.Example7
                Example1.Visible = False
                Example2.Visible = False
                Example3.Visible = False
                Example4.Visible = False
                Example5.Visible = False
                Example6.Visible = False
                Example7.Visible = True
                Example8.Visible = False
            Case PanelList.Example8
                Example1.Visible = False
                Example2.Visible = False
                Example3.Visible = False
                Example4.Visible = False
                Example5.Visible = False
                Example6.Visible = False
                Example7.Visible = False
                Example8.Visible = True
        End Select
    End Sub
#End Region


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ShowPanel(PanelList.Example1)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ShowPanel(PanelList.Example2)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ShowPanel(PanelList.Example3)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        ShowPanel(PanelList.Example4)
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        ShowPanel(PanelList.Example5)
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        ShowPanel(PanelList.Example6)
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        ShowPanel(PanelList.Example7)
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        ShowPanel(PanelList.Example8)
    End Sub
End Class
