Public Class DocumentsPanelMH
    Private Sub DocumentsPanelMH_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DoctorIDLBL.Text = MotherHoodClinic.DoctorIDLBL.Text
        DoctorNameLBL.Text = MotherHoodClinic.DoctorNameLBL.Text
    End Sub

    Private Sub Guna2ImageButton1_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton1.Click
        PatientRecordFilesMH.Show()
    End Sub

    Private Sub Guna2ImageButton2_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton2.Click
        ExportPatientRecordMH.Show()
    End Sub

    Private Sub Guna2ImageButton3_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton3.Click
        DownloadFilesMH.Show()
    End Sub

    Private Sub Guna2ImageButton4_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton4.Click
        UploadRecordMH.Show()
    End Sub
End Class