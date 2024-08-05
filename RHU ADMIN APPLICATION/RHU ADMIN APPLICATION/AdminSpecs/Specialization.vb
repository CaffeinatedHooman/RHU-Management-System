Public Class Specialization
    Private Sub DoctorControl_Click(sender As Object, e As EventArgs) Handles DoctorControl.Click
        DoctorPosition.ShowDialog()
    End Sub

    Private Sub NurseControl_Click(sender As Object, e As EventArgs) Handles NurseControl.Click
        NursePosition.ShowDialog()
    End Sub

    Private Sub MaritalControl_Click(sender As Object, e As EventArgs) Handles MaritalControl.Click
        MaritalStatus.ShowDialog()
    End Sub
End Class