Public Class PharmacyPanel
    Private Sub INVENTORYvtn_Click(sender As Object, e As EventArgs) Handles INVENTORYvtn.Click
        INVENTORY.Show()
    End Sub

    Private Sub Guna2ImageButton4_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton4.Click
        ReportsMeds.Show()
    End Sub

    Private Sub Guna2ImageButton1_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton1.Click
        DistributionMedicine.Show()
    End Sub

    Private Sub PharmacyPanel_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Logout()
        Application.Exit()
    End Sub

    Private Sub PharmacyPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ClockTime.Start()
    End Sub

    Private Sub ClockTime_Tick(sender As Object, e As EventArgs) Handles ClockTime.Tick
        lblClock.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
    End Sub
End Class
