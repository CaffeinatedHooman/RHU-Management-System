Public Class DocumentsPanelHIV
    Private Sub DocumentsPanelHIV_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DoctorIDLBL.Text = HAS_CLINIC.DoctorIDLBL.Text
        DoctorNameLBL.Text = HAS_CLINIC.DoctorNameLBL.Text
    End Sub

    Private Sub Guna2ImageButton1_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton1.Click
        PatientRecordFilesHAS.ShowDialog()
    End Sub

    Private Sub Guna2ImageButton2_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton2.Click
        ExportPatientRecordHAS.ShowDialog()
    End Sub

    Private Sub Guna2ImageButton3_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton3.Click
        DownloadFilesHAS.ShowDialog()
    End Sub

    Private Sub Guna2ImageButton4_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton4.Click
        UploadRecordHAS.ShowDialog()
    End Sub
End Class