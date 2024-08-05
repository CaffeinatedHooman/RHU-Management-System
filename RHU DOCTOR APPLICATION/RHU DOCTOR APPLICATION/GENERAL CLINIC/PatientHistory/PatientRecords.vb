Imports MySql.Data.MySqlClient
Imports System.IO
Public Class PatientRecords

    Private Sub ComboBoxSearchOptions_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxSearchOptions.SelectedIndexChanged
        Try

            Dim selectedOption As String = If(ComboBoxSearchOptions.SelectedItem IsNot Nothing, ComboBoxSearchOptions.SelectedItem.ToString(), String.Empty)

            Select Case selectedOption
                Case "Last Name Search"

                    Dim lastName As String = InputBox("Enter last name to search:", "Search Patients")
                    If Not String.IsNullOrEmpty(lastName) Then
                        Dim searchResult As DataTable = SearchPatientsByLastName(lastName)
                        DisplaySearchResults(searchResult)
                    End If

                Case "First Name Search"

                    Dim firstName As String = InputBox("Enter first name to search:", "Search Patients")
                    If Not String.IsNullOrEmpty(firstName) Then
                        Dim searchResult As DataTable = SearchPatientsByFirstName(firstName)
                        DisplaySearchResults(searchResult)
                    End If

            End Select

            ComboBoxSearchOptions.SelectedIndex = -1

        Catch ex As Exception
            MessageBox.Show($"Error performing search: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DisplayPatientDetails(patientDetails As DataTable)
        If patientDetails IsNot Nothing AndAlso patientDetails.Rows.Count > 0 Then

            lblPatientID.Text = patientDetails.Rows(0)("PatientID").ToString()
            lblFirstname.Text = patientDetails.Rows(0)("FirstName").ToString()
            lblMiddlename.Text = patientDetails.Rows(0)("MiddleName").ToString()
            lblLastname.Text = patientDetails.Rows(0)("LastName").ToString()
            lblGender.Text = patientDetails.Rows(0)("Gender").ToString()
            Dim dobValue As Object = patientDetails.Rows(0)("DOB")
            If dobValue IsNot DBNull.Value Then
                Dim dobDate As Date = CDate(dobValue)
                lblDOB.Text = dobDate.ToString("yyyy-MM-dd")
            Else
                lblDOB.Text = "No DOB available"
            End If
            lblAge.Text = patientDetails.Rows(0)("Age").ToString()
            lblMS.Text = patientDetails.Rows(0)("MaritalStatus").ToString()
            lblMN.Text = patientDetails.Rows(0)("ContactNumber").ToString()
            lblPhilhealthID.Text = patientDetails.Rows(0)("PhilhealthID").ToString()

            PopulateDateListBox()
            PopulateTreatmentDateListBox()
            PopulateLabResultDateListBox()
        Else
            MessageBox.Show("No details found for the selected patient.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ClearPatientDetails()
        End If
    End Sub

    Private Sub ClearPatientDetails()
        PatientSeachList.Items.Clear()
        lblPatientID.Text = "RHU-PATIENT"
        lblFirstname.Text = "="
        lblMiddlename.Text = "="
        lblLastname.Text = "="
        lblGender.Text = "="
        lblDOB.Text = "="
        lblAge.Text = "="
        lblMS.Text = "="
        lblMN.Text = "="
        lblPhilhealthID.Text = "="

    End Sub
    Private Sub DisplaySearchResults(searchResult As DataTable)
        PatientSeachList.Items.Clear()

        If searchResult IsNot Nothing AndAlso searchResult.Rows.Count > 0 Then
            For Each row As DataRow In searchResult.Rows
                Dim patientID As String = (row("PatientID"))
                Dim fullName As String = $"{patientID} - {row("FirstName")} {row("LastName")}"
                PatientSeachList.Items.Add(fullName)
            Next
        Else
            MessageBox.Show("No matching patients found.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub


    Private Sub PatientSeachList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PatientSeachList.SelectedIndexChanged
        If PatientSeachList.SelectedIndex <> -1 Then
            Dim selectedFullName As String = PatientSeachList.SelectedItem.ToString()


            Dim parts() As String = selectedFullName.Split("-")


            If parts.Length >= 2 Then

                Dim patientID As String = parts(0).Trim()


                Dim fullName As String = parts(1).Trim()


                Dim spaceIndex As Integer = fullName.LastIndexOf(" ")
                If spaceIndex > 0 Then
                    lblFirstname.Text = fullName.Substring(0, spaceIndex)
                    lblLastname.Text = fullName.Substring(spaceIndex + 1)
                Else
                    lblFirstname.Text = fullName
                    lblLastname.Text = ""
                End If


                Dim patientDetails As DataTable = GetPatientDetailsByID(patientID)
                DisplayPatientDetails(patientDetails)
            End If
        End If
    End Sub

    '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    Public Function SearchPatientsByFirstName(firstName As String) As DataTable
        Try
            Dim sql As String = "SELECT * FROM Patients WHERE FirstName LIKE @FirstName"

            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@FirstName", $"%{firstName}%")
        }

            Return ExecuteQuery(sql, parameters)
        Catch ex As Exception
            MessageBox.Show($"Error searching for patients by first name: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function

    Public Function SearchPatientsByLastName(lastName As String) As DataTable
        Try
            Dim sql As String = "SELECT * FROM Patients WHERE LastName LIKE @LastName"

            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@LastName", $"%{lastName}%")
        }

            Return ExecuteQuery(sql, parameters)
        Catch ex As Exception
            MessageBox.Show($"Error searching for patients by last name: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function

    Public Function GetPatientDetailsByName(firstName As String, lastName As String) As DataTable
        Try
            Dim sql As String = "SELECT * FROM Patients WHERE FirstName = @FirstName AND LastName = @LastName"

            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@FirstName", firstName),
            New MySqlParameter("@LastName", lastName)
        }

            Return ExecuteQuery(sql, parameters)
        Catch ex As Exception
            MessageBox.Show($"Error retrieving patient details by name: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function

    '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    Private Sub PopulateDateListBox()
        Dim patientID As String = lblPatientID.Text
        Dim distinctDates As List(Of DateTime) = GetDistinctVitalSignDates(patientID)
        VitalHistory.DataSource = Nothing
        VitalHistory.Items.Clear()
        VitalHistory.DataSource = distinctDates
        VitalHistory.DisplayMember = "ToString"
    End Sub

    Private Sub PopulateTreatmentDateListBox()
        Dim patientID As String = lblPatientID.Text
        Dim distinctDates As List(Of DateTime) = GetDistinctTreatmentDates(patientID)
        ListBoxTreatment.DataSource = Nothing
        ListBoxTreatment.Items.Clear()
        ListBoxTreatment.DataSource = distinctDates
        ListBoxTreatment.DisplayMember = "ToString"
    End Sub

    Private Sub DisplayVitalsHistory(selectedDate As DateTime)
        Dim patientID As String = lblPatientID.Text
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

    Private Sub VitalHistory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles VitalHistory.SelectedIndexChanged
        Dim selectedDate As DateTime = Convert.ToDateTime(VitalHistory.SelectedItem)
        DisplayVitalsHistory(selectedDate)
    End Sub

    Private Sub ListBoxTreatment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxTreatment.SelectedIndexChanged
        Dim selectedDate As DateTime = Convert.ToDateTime(ListBoxTreatment.SelectedItem)
        DisplayTreatmentDetails(selectedDate)
    End Sub

    Private Sub DisplayTreatmentDetails(selectedDate As DateTime)
        Dim patientID As String = lblPatientID.Text
        Dim treatmentTable As DataTable = GetTreatmentRecordsByDate(patientID, selectedDate)

        If treatmentTable IsNot Nothing AndAlso treatmentTable.Rows.Count > 0 Then
            Dim treatmentRow As DataRow = treatmentTable.Rows(0)

            Dim doctorName As String = Convert.ToString(treatmentRow("DoctorName"))
            Dim findings As String = Convert.ToString(treatmentRow("Findings"))
            Dim prescription As String = Convert.ToString(treatmentRow("Prescription"))
            Dim dateRecorded As DateTime = Convert.ToDateTime(treatmentRow("DateRecorded"))
            Dim illnessID As Integer = Convert.ToInt32(treatmentRow("PatientIllnessID"))

            Dim illnessName As String = GetIllnessNameByID(illnessID)

            txtDoctorNamePast.Text = doctorName
            txtFindingsPast.Text = findings
            txtPrescriptionPast.Text = prescription
            txtDateRecordedPast.Text = dateRecorded.ToString("yyyy-MM-dd HH:mm:ss")
            txtIllnessLabel.Text = illnessName
        Else
            ClearTreatmentDetails()
        End If
    End Sub

    Private Sub ClearTreatmentDetails()
        txtDoctorNamePast.Text = "="
        txtFindingsPast.Text = "="
        txtPrescriptionPast.Text = "="
        txtDateRecordedPast.Text = "="
        txtIllnessLabel.Text = "="
    End Sub

    Private Sub ClearVitalSignsDetails()
        txtBodyTempPast.Text = "="
        txtBloodPressurePast.Text = "="
        txtRespirationRatePast.Text = "="
        txtPulseRatePast.Text = "="
        txtWeightPast.Text = "="
        txtHeightPast.Text = "="
        txtDiagnosisPast.Text = "="
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

    Private Sub PatientRecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class