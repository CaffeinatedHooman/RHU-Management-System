Public Class Laboratory_Panel
    Private Sub EnterLabVTN_Click(sender As Object, e As EventArgs) Handles EnterLabVTN.Click
        LAB_PATIENT.Show()
    End Sub

    Private Sub Laboratory_Panel_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        LabPersonnelLogout()
        Application.Exit()
    End Sub
End Class