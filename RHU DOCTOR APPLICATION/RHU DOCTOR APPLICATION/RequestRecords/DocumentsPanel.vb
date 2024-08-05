Public Class DocumentsPanel
    Private Sub Guna2ImageButton1_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton1.Click
        PatientRecordFiles.Show()
    End Sub

    Private Sub Guna2ImageButton2_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton2.Click
        ExportPatientRecord.Show()
    End Sub

    Private Sub Guna2ImageButton3_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton3.Click
        DownloadFiles.Show()
    End Sub

    Private Sub Guna2ImageButton4_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton4.Click
        UploadRecord.Show()
    End Sub

    Private Sub DocumentsPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DoctorIDLBL.Text = GeneralDoctorPanel.DoctorIDLBL.Text
        DoctorNameLBL.Text = GeneralDoctorPanel.DoctorNameLBL.Text
    End Sub

    'Private Sub documentspanel_formclosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
    '    doctorlogout2()
    '    Application.Exit()
    'End Sub
    'Private Sub doctorlogout2()
    '    Try
    '        If Not String.IsNullOrEmpty(DoctorNameLBL.Text) Then
    '            TimeOut(DoctorNameLBL.Text)
    '        Else
    '            MessageBox.Show("full name not available. unable to logout.", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show("an error occurred during logout: " & ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub
End Class