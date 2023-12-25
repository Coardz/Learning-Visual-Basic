Public Class infoform

    Dim tpram = My.Computer.Info.TotalPhysicalMemory
    Dim tvram = My.Computer.Info.TotalVirtualMemory
    Dim osfm = My.Computer.Info.OSFullName
    Dim osp = My.Computer.Info.OSPlatform
    Dim osv = My.Computer.Info.OSVersion

    Private Sub infoform_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label1.Text = tpram
        Label2.Text = tvram
        Label3.Text = osfm
        Label4.Text = osp
        Label5.Text = osv
    End Sub
End Class