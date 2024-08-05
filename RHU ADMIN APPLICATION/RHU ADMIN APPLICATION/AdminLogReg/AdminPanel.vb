Public Class AdminPanel
    Private Sub NewNurseVTN_Click(sender As Object, e As EventArgs) Handles NewNurseVTN.Click
        NewNurse.ShowDialog()
    End Sub

    Private Sub NewDoctorVTN_Click(sender As Object, e As EventArgs) Handles NewDoctorVTN.Click
        NewDoctor.ShowDialog()
    End Sub

    Private Sub AdminControlVTN_Click(sender As Object, e As EventArgs) Handles AdminControlVTN.Click
        Specialization.ShowDialog()
    End Sub

    Private Sub NewClinicVTN_Click(sender As Object, e As EventArgs) Handles NewClinicVTN.Click
        NewClinic.ShowDialog()
    End Sub

    Private Sub Guna2ImageButton2_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton2.Click
        NurseProfile.ShowDialog()
    End Sub

    Private Sub Guna2ImageButton5_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton5.Click
        DoctorProfile.ShowDialog()
    End Sub

    Private Sub AdminPanel_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        LogoutAdmin()
        Application.Exit()
    End Sub

    Private Sub Guna2ImageButton3_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton3.Click
        UserLogs.ShowDialog()
    End Sub

    Private Sub Guna2ImageButton1_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton1.Click
        LabPanel.ShowDialog()
    End Sub

    Private Sub Guna2ImageButton7_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton7.Click
        ClinicDataReports.Show()
    End Sub

    Private Sub Guna2ImageButton4_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton4.Click
        PharmacyPanel.Show()
    End Sub
End Class