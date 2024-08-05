Imports MySql.Data.MySqlClient
Public Class GeneralDoctorPanel

    Private Function CountDoctorRequests() As Integer
        Try
            Dim doctorID As String = DoctorIDLBL.Text

            Dim sql As String = "SELECT COUNT(*) FROM DoctorRequests WHERE ReceiverDoctorID = @DoctorID AND Status != 'Done'"
            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@DoctorID", doctorID)
        }
            Dim result As Object = ExecuteScalar(sql, parameters)

            If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                Return Convert.ToInt32(result)
            Else
                Return 0
            End If
        Catch ex As Exception
            Console.WriteLine($"Error counting doctor requests: {ex.Message}")
            Return -1
        End Try
    End Function

    Public Sub UpdateRequestCountLabel()
        Try
            Dim count As Integer = CountDoctorRequests()
            RequestCountLabel.Text = $"DOCTOR'S REQUEST: {count}"
        Catch ex As Exception
            Console.WriteLine($"Error updating request count label: {ex.Message}")
            RequestCountLabel.Text = "Error retrieving request count."
        End Try
    End Sub

    Private Sub OncallDoctorVTN_Click(sender As Object, e As EventArgs) Handles OncallDoctorVTN.Click
        GeneralClinic.ShowDialog()
    End Sub

    Private Sub GeneralDoctorPanel_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        DoctorLogout()
        Application.Exit()
    End Sub

    Private Sub GeneralDoctorPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refreshTimer.Interval = 15000
        refreshTimer.Start()

        DisplayPatientsInQueue()
        UpdateRequestCountLabel()
    End Sub

    Private Sub DisplayPatientsInQueue()
        Try
            Dim doctorID As String = DoctorIDLBL.Text

            Dim selectQuery As String = "SELECT CONCAT(P.FirstName, ' ', P.LastName) AS PatientName, " &
        "Q.QueueNumber, Q.QueueStatus, Q.Clinic, Q.QueueTime " &
        "FROM queue Q " &
        "INNER JOIN doctors D ON Q.DoctorID = D.DoctorID " &
        "INNER JOIN patients P ON Q.PatientID = P.PatientID " &
        "WHERE Q.QueueStatus = 'Waiting' AND Q.DoctorID = @DoctorID"

            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@DoctorID", doctorID)
        }

            Dim dataTable As DataTable = ExecuteQuery(selectQuery, parameters)
            dgvPatientQueue.DataSource = dataTable
        Catch ex As Exception
            Console.WriteLine($"Error loading queue data: {ex.Message}")
        End Try
    End Sub

    Private Sub refreshTimer_Tick(sender As Object, e As EventArgs) Handles refreshTimer.Tick
        DisplayPatientsInQueue()
    End Sub

    Private Sub PatientrecordVTN_Click(sender As Object, e As EventArgs) Handles PatientrecordVTN.Click
        PatientRecords.Show()
    End Sub

    Private Sub RECORDARC_Click(sender As Object, e As EventArgs) Handles RECORDARC.Click
        DocumentsPanel.Show()
    End Sub

    Private Sub IllnessRedirectVTN_Click(sender As Object, e As EventArgs) Handles IllnessRedirectVTN.Click
        IllnessRecord.ShowDialog()
    End Sub
End Class
