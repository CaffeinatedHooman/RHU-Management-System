Imports MySql.Data.MySqlClient
Imports System.Speech.Synthesis
Imports System.IO
Public Class TB_ONCALL
    Private Sub TB_ONCALL_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayPatientsInQueue()
        AutoRefreshTimer.Interval = 15000
        AutoRefreshTimer.Start()
    End Sub

    Private Sub AutoRefreshTimer_Tick(sender As Object, e As EventArgs) Handles AutoRefreshTimer.Tick
        DisplayPatientsInQueue()
    End Sub
    Private Sub DisplayPatientsInQueue()
        Try
            PatientQueueList.Items.Clear()

            Dim doctorID As String = TB_CLINIC.DoctorIDLBL.Text

            Dim patientsInQueueDataTable As DataTable = GetPatientsInQueue(doctorID)

            If patientsInQueueDataTable IsNot Nothing AndAlso patientsInQueueDataTable.Rows.Count > 0 Then
                For Each row As DataRow In patientsInQueueDataTable.Rows
                    Dim patientID As String = row("PatientID").ToString()
                    Dim patientName As String = GetPatientNameByID(patientID)
                    Dim displayText As String = $"{patientID} - {patientName}"
                    PatientQueueList.Items.Add(displayText)
                Next
            Else
                'MessageBox.Show("No patients in the queue.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show($"An error occurred while displaying patients in the queue: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub PatientQueueList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PatientQueueList.SelectedIndexChanged
        Try
            ClearPatientDetailsLabels()
            ClearVitalSignsLabels()
            ClearTreatmentDetails()
            ClearLabResultDetails()

            If PatientQueueList.SelectedIndex >= 0 Then
                Dim selectedPatientInfo As String = PatientQueueList.SelectedItem.ToString()
                SaveDoctorDiagnosis.Enabled = True
                Dim parts As String() = selectedPatientInfo.Split("-"c)
                Dim selectedPatientID As String = parts(0).Trim()

                Dim patientDetailsDataTable As DataTable = GetPatientDetailsByID(selectedPatientID)

                If patientDetailsDataTable.Rows.Count > 0 Then
                    lblPatientID.Text = patientDetailsDataTable.Rows(0)("PatientID").ToString()
                    lblFirstname.Text = patientDetailsDataTable.Rows(0)("FirstName").ToString()
                    lblMiddlename.Text = patientDetailsDataTable.Rows(0)("MiddleName").ToString()
                    lblLastname.Text = patientDetailsDataTable.Rows(0)("LastName").ToString()
                    lblGender.Text = patientDetailsDataTable.Rows(0)("Gender").ToString()

                    lblDOB.Text = If(patientDetailsDataTable.Rows(0)("DOB") IsNot DBNull.Value,
                                  Convert.ToDateTime(patientDetailsDataTable.Rows(0)("DOB")).ToString("yyyy-MM-dd"),
                                  String.Empty)

                    lblAge.Text = patientDetailsDataTable.Rows(0)("Age").ToString()
                    lblMaritalStatus.Text = patientDetailsDataTable.Rows(0)("MaritalStatus").ToString()
                    lblContactNumber.Text = patientDetailsDataTable.Rows(0)("ContactNumber").ToString()
                    lblPhilhealthID.Text = patientDetailsDataTable.Rows(0)("PhilhealthID").ToString()

                    LoadLatestVitalSignsForSelectedPatient()
                    PopulateTreatmentDateListBox()
                    PopulateDateListBox()
                    PopulateLabResultDateListBox()
                Else
                    MessageBox.Show("Patient details not found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    SaveDoctorDiagnosis.Enabled = False
                End If
            End If
        Catch ex As Exception
            MessageBox.Show($"An error occurred while fetching patient details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub




    Private Sub ClearPatientDetailsLabels()
        lblPatientID.Text = ""
        lblFirstname.Text = ""
        lblMiddlename.Text = ""
        lblLastname.Text = ""
        lblGender.Text = ""
        lblDOB.Text = ""
        lblAge.Text = ""
        lblMaritalStatus.Text = ""
        lblContactNumber.Text = ""
        lblPhilhealthID.Text = ""
    End Sub


    Private Sub ClearVitalSignsLabels()
        lblBodyTemp.Text = String.Empty
        lblBloodPressure.Text = String.Empty
        lblRespirationRate.Text = String.Empty
        lblPulseRate.Text = String.Empty
        lblWeight.Text = String.Empty
        lblHeight.Text = String.Empty
        lblDiagnosis.Text = String.Empty
    End Sub






    Private Sub LoadLatestVitalSignsForSelectedPatient()
        Try
            Dim vitalSignsDataTable As DataTable = GetLatestVitalSigns(lblPatientID.Text)

            If vitalSignsDataTable.Rows.Count > 0 Then
                lblBodyTemp.Text = vitalSignsDataTable.Rows(0)("BodyTemp").ToString()
                lblBloodPressure.Text = vitalSignsDataTable.Rows(0)("BloodPressure").ToString()
                lblRespirationRate.Text = vitalSignsDataTable.Rows(0)("RespirationRate").ToString()
                lblPulseRate.Text = vitalSignsDataTable.Rows(0)("PulseRate").ToString()
                lblWeight.Text = vitalSignsDataTable.Rows(0)("Weight").ToString()
                lblHeight.Text = vitalSignsDataTable.Rows(0)("Height").ToString()
                lblDiagnosis.Text = vitalSignsDataTable.Rows(0)("Diagnosis").ToString()


            Else
                ClearVitalSignsLabels()
                MessageBox.Show("No vital signs found for the selected patient.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show($"An error occurred while loading vital signs: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub SaveDoctorDiagnosis_Click(sender As Object, e As EventArgs) Handles SaveDoctorDiagnosis.Click
        Try
            ' Validate that required fields have values
            If String.IsNullOrWhiteSpace(TB_CLINIC.DoctorNameLBL.Text) OrElse
           String.IsNullOrWhiteSpace(lblPatientID.Text) OrElse
           String.IsNullOrWhiteSpace(txtTBTest.Text) OrElse
           String.IsNullOrWhiteSpace(txtPatientHistory.Text) OrElse
           String.IsNullOrWhiteSpace(txtPatientComplains.Text) OrElse
           String.IsNullOrWhiteSpace(txtMedicalHistory.Text) OrElse
           String.IsNullOrWhiteSpace(txtMedications.Text) Then

                MessageBox.Show("Please fill in all required fields.", "Incomplete Data", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return ' Exit the method without proceeding
            End If

            ' All required fields have values, proceed with saving treatment information
            Dim doctorName As String = TB_CLINIC.DoctorNameLBL.Text
            Dim patientID As String = lblPatientID.Text
            Dim tbTest As String = txtTBTest.Text
            Dim patientHistory As String = txtPatientHistory.Text
            Dim patientComplains As String = txtPatientComplains.Text
            Dim medicalHistory As String = txtMedicalHistory.Text
            Dim medications As String = txtMedications.Text

            Dim result As String = AddTreatmentTB(doctorName, patientID, tbTest, patientHistory, patientComplains, medicalHistory, medications)

            MessageBox.Show(result, "Result")

            DequeuPatient()
            SaveDoctorDiagnosis.Enabled = False
            ClearPatientDetailsLabels()
            ClearVitalSignsLabels()
            ClearTreatmentDetails()
            ClearVitalSignsDetails()
            ClearLabResultDetails()
        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            SaveDoctorDiagnosis.Enabled = False
        End Try
    End Sub



    Private Sub DequeuPatient()

        Dim doctorID As String = TB_CLINIC.DoctorIDLBL.Text
        Dim patientID As String = lblPatientID.Text
        Dim newStatus As String = "Done"


        If UpdateQueueStatus(doctorID, patientID, newStatus) Then

            MessageBox.Show("Queue status updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            DisplayPatientsInQueue()
        Else

            MessageBox.Show("Failed to update queue status.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Function UpdateQueueStatus(doctorID As String, patientID As String, newStatus As String) As Boolean
        Try
            Dim sql As String = "UPDATE queue SET QueueStatus = @NewStatus WHERE PatientID = @PatientID AND DoctorID = @DoctorID"


            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@DoctorID", doctorID),
            New MySqlParameter("@PatientID", patientID),
            New MySqlParameter("@NewStatus", newStatus)
        }

            Dim rowsAffected As Integer = ExecuteNonQuery(sql, parameters)

            If rowsAffected > 0 Then
                Return True
            Else
                MessageBox.Show("Failed to update queue status.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show($"Error updating queue status: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function




    Private Sub PopulateDateListBox()
        Dim patientID As String = lblPatientID.Text
        Dim distinctDates As List(Of DateTime) = GetDistinctVitalSignDates(patientID)

        VitalHistory.DataSource = Nothing
        VitalHistory.Items.Clear()
        VitalHistory.DataSource = distinctDates
        VitalHistory.DisplayMember = "ToString"

        VitalHistory.FormatString = "yyyy-MM-dd HH:mm:ss"
    End Sub


    Private Sub VitalHistory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles VitalHistory.SelectedIndexChanged

        Dim patientID As String = lblPatientID.Text

        Dim selectedDate As DateTime = Convert.ToDateTime(VitalHistory.SelectedItem)


        Dim vitalSignsTable As DataTable = GetVitalSignsByDate(patientID, selectedDate)


        If vitalSignsTable IsNot Nothing AndAlso vitalSignsTable.Rows.Count > 0 Then

            Dim vitalSignsRow As DataRow = vitalSignsTable.Rows(0)

            Dim bodyTemp As String = Convert.ToString(vitalSignsRow("BodyTemp"))
            Dim bloodPressure As String = Convert.ToString(vitalSignsRow("BloodPressure"))
            Dim respirationRate As String = Convert.ToString(vitalSignsRow("RespirationRate"))
            Dim pulseRate As String = Convert.ToString(vitalSignsRow("PulseRate"))
            Dim weight As String = Convert.ToString(vitalSignsRow("Weight"))
            Dim height As String = Convert.ToString(vitalSignsRow("Height"))
            Dim diagnosis As String = Convert.ToString(vitalSignsRow("Diagnosis"))


            txtBodyTempPast.Text = bodyTemp
            txtBloodPressurePast.Text = bloodPressure
            txtRespirationRatePast.Text = respirationRate
            txtPulseRatePast.Text = pulseRate
            txtWeightPast.Text = weight
            txtHeightPast.Text = height
            txtDiagnosisPast.Text = diagnosis



        Else
            'MessageBox.Show("No vital signs records found for the specified date.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ClearVitalSignsDetails()
        End If
    End Sub

    Private Sub ClearVitalSignsDetails()
        VitalHistory.DataSource = Nothing

        txtBodyTempPast.Text = "="
        txtBloodPressurePast.Text = "="
        txtRespirationRatePast.Text = "="
        txtPulseRatePast.Text = "="
        txtWeightPast.Text = "="
        txtHeightPast.Text = "="
        txtDiagnosisPast.Text = "="
    End Sub


    Private Sub PopulateTreatmentDateListBox()
        Dim patientID As String = lblPatientID.Text
        Dim distinctDates As List(Of DateTime) = GetDistinctTreatmentTBDates(patientID)
        ListBoxTreatment.DataSource = Nothing
        ListBoxTreatment.Items.Clear()
        ListBoxTreatment.DataSource = distinctDates
        ListBoxTreatment.DisplayMember = "ToString"


        ListBoxTreatment.FormatString = "yyyy-MM-dd HH:mm:ss"
    End Sub

    Private Sub ListBoxTreatment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxTreatment.SelectedIndexChanged
        Dim selectedDate As DateTime = Convert.ToDateTime(ListBoxTreatment.SelectedItem)
        DisplayTreatmentDetails(selectedDate)
    End Sub

    Private Sub DisplayTreatmentDetails(selectedDate As DateTime)
        Dim patientID As String = lblPatientID.Text
        Dim treatmentTable As DataTable = GetTreatmentTBRecordsByDate(patientID, selectedDate)

        If treatmentTable IsNot Nothing AndAlso treatmentTable.Rows.Count > 0 Then
            Dim treatmentRow As DataRow = treatmentTable.Rows(0)

            Dim doctorName As String = Convert.ToString(treatmentRow("DoctorName"))
            Dim tbTest As String = Convert.ToString(treatmentRow("TBTest"))
            Dim patientHistory As String = Convert.ToString(treatmentRow("PatientHistory"))
            Dim patientComplains As String = Convert.ToString(treatmentRow("PatientComplains"))
            Dim medicalHistory As String = Convert.ToString(treatmentRow("MedicalHistory"))
            Dim medications As String = Convert.ToString(treatmentRow("Medications"))
            Dim dateRecorded As DateTime = Convert.ToDateTime(treatmentRow("DateRecorded"))

            txtDoctorNamePast.Text = doctorName
            txtTBTestPast.Text = tbTest
            txtPatientHistoryPast.Text = patientHistory
            txtPatientComplainsPast.Text = patientComplains
            txtMedicalHistoryPast.Text = medicalHistory
            txtMedicationsPast.Text = medications
            txtDateRecordedPast.Text = dateRecorded.ToString("yyyy-MM-dd HH:mm:ss")
        Else
            ClearTreatmentDetails()
        End If
    End Sub


    Private Sub ClearTreatmentDetails()

        txtTBTest.Text = ""
        txtPatientHistory.Text = ""
        txtPatientComplains.Text = ""
        txtMedicalHistory.Text = ""
        For Each itemIndex As Integer In txtMedications.CheckedIndices
            txtMedications.SetItemChecked(itemIndex, False)
        Next

        For Each itemIndex As Integer In txtTBTest.CheckedIndices
            txtTBTest.SetItemChecked(itemIndex, False)
        Next


        txtDoctorNamePast.Text = ""
        txtTBTestPast.Text = ""
        txtPatientHistoryPast.Text = ""
        txtPatientComplainsPast.Text = ""
        txtMedicalHistoryPast.Text = ""
        txtMedicationsPast.Text = ""
        txtDateRecordedPast.Text = ""
    End Sub

    Dim synth As New SpeechSynthesizer()

    Private Sub CallPatientVTN_Click(sender As Object, e As EventArgs) Handles CallPatientVTN.Click
        If PatientQueueList.SelectedItem IsNot Nothing Then

            Dim preText As String = "Calling. "
            Dim postText As String = "To the clinic.  Doctor" & TB_CLINIC.DoctorNameLBL.Text
            synth.SpeakAsync(preText & PatientQueueList.SelectedItem.ToString() & " " & postText)
        Else
            MessageBox.Show("Please select a Patient on the list to Call.")
        End If
    End Sub

    Private Sub PopulateLabResultDateListBox()
        Dim patientID As String = lblPatientID.Text
        Dim distinctDates As List(Of DateTime) = GetDistinctLabResultDates(patientID)
        ListBoxLabResult.DataSource = Nothing
        ListBoxLabResult.Items.Clear()
        ListBoxLabResult.DataSource = distinctDates
        ListBoxLabResult.DisplayMember = "ToString"
        ListBoxLabResult.FormatString = "yyyy-MM-dd HH:mm:ss"
    End Sub

    Private Sub ListBoxLabResult_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxLabResult.SelectedIndexChanged
        Dim selectedDate As DateTime = Convert.ToDateTime(ListBoxLabResult.SelectedItem)
        DisplayLabResultDetails(selectedDate)
    End Sub
    Private Sub DisplayLabResultDetails(selectedDate As DateTime)
        Try
            Dim patientID As String = lblPatientID.Text
            Dim labResultTable As DataTable = GetLabResultsByDate(patientID, selectedDate)

            If labResultTable IsNot Nothing AndAlso labResultTable.Rows.Count > 0 Then
                Dim labResultRow As DataRow = labResultTable.Rows(0)

                Dim resultDescription As String = Convert.ToString(labResultRow("ResultDescription"))
                Dim labResultImage As Byte() = DirectCast(labResultRow("LabResultImage"), Byte())
                Dim inChargePerson As String = Convert.ToString(labResultRow("InChargePerson"))
                Dim laboratoryName As String = Convert.ToString(labResultRow("LaboratoryName"))

                txtResultDescription.Text = resultDescription
                lblInChargePerson.Text = $"In Charge Person: {inChargePerson}"
                lblLaboratoryName.Text = $"Laboratory Name: {laboratoryName}"

                If labResultImage IsNot Nothing AndAlso labResultImage.Length > 0 Then
                    picLabResult.Image = Image.FromStream(New MemoryStream(labResultImage))
                    picLabResult.SizeMode = PictureBoxSizeMode.Zoom
                Else
                    picLabResult.Image = Nothing
                End If

            Else
                ClearLabResultDetails()
            End If
        Catch ex As Exception
            MessageBox.Show($"An error occurred while displaying lab result details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub ClearLabResultDetails()
        ListBoxLabResult.DataSource = Nothing
        picLabResult.Image = Nothing
        txtResultDescription.Clear()
        lblInChargePerson.Text = ""
        lblLaboratoryName.Text = ""
    End Sub

    Private Sub picLabResult_Click(sender As Object, e As EventArgs) Handles picLabResult.Click
        If picLabResult.Image IsNot Nothing Then
            Dim imageViewerForm As New ImageViewerForm(picLabResult.Image)
            imageViewerForm.ShowDialog()
        End If
    End Sub

End Class