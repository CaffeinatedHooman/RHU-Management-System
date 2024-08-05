Imports MySql.Data.MySqlClient
Public Class NursePanel
    Private Sub NursePanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadQueueData()
        Me.KeyPreview = True
        InitializeAutoRefreshTimer()
        ClinicViewSetup.LoadLabelText()
        ClinicViewSetup.LoadLabelText2()
        ClinicViewSetup.LoadLabelText3()
        ClinicViewSetup.LoadLabelText4()
        ClinicViewSetup.LoadLabelText5()
        ClinicViewSetup.LoadLabelText6()
        ClinicViewSetup.LoadLabelText7()

    End Sub



    Private Sub InitializeAutoRefreshTimer()

        TimerViewAllClinic.Interval = 7777

        TimerViewAllClinic.Enabled = True
    End Sub

    Private Sub TimerViewAllClinic_Tick(sender As Object, e As EventArgs) Handles TimerViewAllClinic.Tick
        LoadQueueData()
        ClinicViewSetup.ReloadClinicQueue()
    End Sub

    Private Sub LoadQueueData()
        Try
            Dim selectQuery As String = "SELECT CONCAT(D.FirstName, ' ', D.LastName) AS DoctorName, " &
                    "CONCAT(P.FirstName, ' ', P.LastName) AS PatientName, " &
                    "Q.QueueNumber, Q.QueueStatus, Q.Clinic, Q.QueueDate " &
                    "FROM queue Q " &
                    "INNER JOIN doctors D ON Q.DoctorID = D.DoctorID " &
                    "INNER JOIN patients P ON Q.PatientID = P.PatientID " &
                    "WHERE Q.QueueStatus = 'Waiting'"

            Dim dataTable As DataTable = ExecuteQuery(selectQuery)

            AllClinicViewQueue.DataSource = dataTable
        Catch ex As Exception
            Console.WriteLine($"Error loading queue data: {ex.Message}")
        End Try
    End Sub


    Private Sub ResetLabelText()
        ClinicLabelLoad1.Text = String.Empty
        ClinicLabelLoad2.Text = String.Empty
        ClinicLabelLoad3.Text = String.Empty
        ClinicLabelLoad4.Text = String.Empty
        ClinicLabelLoad5.Text = String.Empty
        ClinicLabelLoad6.Text = String.Empty
        ClinicLabelLoad7.Text = String.Empty


        My.Settings.ClinicLabelLoad1 = String.Empty
        My.Settings.ClinicLabelLoad2 = String.Empty
        My.Settings.ClinicLabelLoad3 = String.Empty
        My.Settings.ClinicLabelLoad4 = String.Empty
        My.Settings.ClinicLabelLoad5 = String.Empty
        My.Settings.ClinicLabelLoad6 = String.Empty
        My.Settings.ClinicLabelLoad7 = String.Empty

        My.Settings.Save()

        MessageBox.Show("Changes applied. Please restart the application for the changes to take effect.", "Restart Required", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub RESETCLINICVIEW_Click(sender As Object, e As EventArgs) Handles RESETCLINICVIEW.Click
        ResetLabelText()
    End Sub

    Private Sub View_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.Alt AndAlso e.KeyCode = Keys.Home Then
            ResetLabelText()
        End If
    End Sub


    Private Sub DailyRecordVTN_Click(sender As Object, e As EventArgs) Handles DailyRecordVTN.Click
        DailyReportPatient.ShowDialog()
    End Sub

    Private Sub NursePanel_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.F1 Then

            Dim newForm As New ClinicViewSetup()
            newForm.Show()
        End If
    End Sub

    Private Sub NursePanel_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Logout()
        Application.Exit()
    End Sub

    Private Sub OldPatientVTN_Click(sender As Object, e As EventArgs) Handles OldPatientVTN.Click
        OldPatient.ShowDialog()
    End Sub

    Private Sub NewPatientVTN_Click(sender As Object, e As EventArgs) Handles NewPatientVTN.Click
        NewPatient.ShowDialog()
    End Sub

    Private Sub Guna2ImageButton4_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton4.Click
        AllPatients.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        LoadQueueData()
    End Sub

End Class