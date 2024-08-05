Public Class LabPanel
    Private Sub Guna2ImageButton1_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton1.Click
        NEW_LABARATORY.Show()
    End Sub

    Private Sub Guna2ImageButton2_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton2.Click
        LABORATORY_INFO.Show()
    End Sub

    Private Sub Guna2ImageButton3_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton3.Click
        NEW_LAB_USER.ShowDialog()
    End Sub

    Private Sub Guna2ImageButton4_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton4.Click
        LabUserInfo.ShowDialog()
    End Sub

    Private Sub Guna2ImageButton5_Click(sender As Object, e As EventArgs) Handles LabReportsVtn.Click
        ReportsLab.Show()
    End Sub
End Class