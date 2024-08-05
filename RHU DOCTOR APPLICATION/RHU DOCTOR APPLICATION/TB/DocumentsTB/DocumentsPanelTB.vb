Public Class DocumentsPanelTB
    Private Sub DocumentsPanelTB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DoctorIDLBL.Text = TB_CLINIC.DoctorIDLBL.Text
        DoctorNameLBL.Text = TB_CLINIC.DoctorNameLBL.Text
    End Sub

    Private Sub Guna2ImageButton3_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton3.Click
        DownloadFilesTB.ShowDialog()
    End Sub

    Private Sub Guna2ImageButton2_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton2.Click
        ExportPatientRecordTB.ShowDialog()
    End Sub

    Private Sub Guna2ImageButton4_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton4.Click
        UploadRecordTB.ShowDialog()
    End Sub

    Private Sub Guna2ImageButton1_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton1.Click
        PatientRecordFilesTB.ShowDialog()
    End Sub
End Class