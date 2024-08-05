
Public Class OldPatient

    Private Sub OldPatient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDoctorsIntoComboBox()
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
                GroupBoxVital.Enabled = True
            End If
        End If
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
            lblCitizenship.Text = patientDetails.Rows(0)("Citizenship").ToString()
            lblReligon.Text = patientDetails.Rows(0)("Religion").ToString()
            lblAddress.Text = patientDetails.Rows(0)("Address").ToString()
            lblMN.Text = patientDetails.Rows(0)("ContactNumber").ToString()
            lblPhilhealthID.Text = patientDetails.Rows(0)("PhilhealthID").ToString()

            SaveVitals.Visible = True
        Else
            MessageBox.Show("No details found for the selected patient.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Information)
            SaveVitals.Visible = False
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
        lblCitizenship.Text = "="
        lblReligon.Text = "="
        lblAddress.Text = "="
        lblMN.Text = "="
        lblPhilhealthID.Text = "="
        lblClinicName.Text = ""
        cmbDoctors.SelectedIndex = -1

    End Sub

    Private Sub ClearInfoExisting_Click(sender As Object, e As EventArgs) Handles ClearInfoExisting.Click
        ClearPatientDetails()
        ClearSelectedDoctorAndClinic()
        GroupBoxVital.Enabled = False

    End Sub

    Private Sub CLEARVITALS()
        txtBodyTemp.Clear()
        txtBloodPressure.Clear()
        txtRespirationRate.Clear()
        txtPulseRate.Clear()
        txtWeight.Clear()
        txtHeight.Clear()
        txtDiagnosis.Clear()
    End Sub

    Private Sub ValidateInput(value As String, fieldName As String)
        If String.IsNullOrEmpty(value) Then
            MessageBox.Show($"Please enter the {fieldName}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Throw New ArgumentException($"{fieldName} is required.")
        End If
    End Sub


    Private Sub SaveVitals_Click(sender As Object, e As EventArgs) Handles SaveVitals.Click
        Try
            Dim patientid As String = lblPatientID.Text
            Dim bodytemp As String = txtBodyTemp.Text
            Dim bloodpressure As String = txtBloodPressure.Text
            Dim respirationrate As String = txtRespirationRate.Text
            Dim pulserate As String = txtPulseRate.Text
            Dim weight As String = txtWeight.Text
            Dim height As String = txtHeight.Text
            Dim diagnosis As String = txtDiagnosis.Text

            ValidateInput(bodytemp, "body temperature")
            ValidateInput(bloodpressure, "blood pressure")
            ValidateInput(respirationrate, "respiration rate")
            ValidateInput(pulserate, "pulse rate")
            ValidateInput(weight, "weight")
            ValidateInput(height, "height")
            ValidateInput(diagnosis, "diagnosis")

            If CreatePatientVitalRecord(patientid, bodytemp, bloodpressure, respirationrate, pulserate, weight, height, diagnosis) Then
                'messagebox.show("patient vital record created successfully.", "success", messageboxbuttons.ok, messageboxicon.information)
                EnqueuePatient()

                CLEARVITALS()

                ClearPatientDetails()
                ClearSelectedDoctorAndClinic()

            Else
                MessageBox.Show("failed to create patient vital record.", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show($"error: {ex.Message}", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadDoctorsIntoComboBox()
        Try
            Dim sql As String = "SELECT DoctorID, CONCAT(FirstName, ' ', LastName) AS DoctorName FROM doctors"
            Dim doctorsDataTable As DataTable = ExecuteQuery(sql)

            If doctorsDataTable.Rows.Count > 0 Then
                cmbDoctors.DataSource = doctorsDataTable
                cmbDoctors.DisplayMember = "DoctorName"
                cmbDoctors.ValueMember = "DoctorID"

                AddHandler cmbDoctors.SelectedIndexChanged, AddressOf cmbDoctors_SelectedIndexChanged

                cmbDoctors.SelectedIndex = -1
            Else
                MessageBox.Show("No doctors found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show($"An error occurred while loading doctors: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbDoctors_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDoctors.SelectedIndexChanged
        If cmbDoctors.SelectedIndex <> -1 Then
            Dim selectedDoctorID As String = cmbDoctors.SelectedValue.ToString()
            lblSelectedDoctorID.Text = selectedDoctorID
            Dim clinicName As String = GetClinicName(selectedDoctorID)

            If clinicName <> "Clinic Not Found" Then
                lblClinicName.Text = clinicName
                SaveVitals.Enabled = True
            Else
                lblClinicName.Text = ""
                SaveVitals.Enabled = False
            End If
        End If
    End Sub
    Private Sub ClearSelectedDoctorAndClinic()
        RemoveHandler cmbDoctors.SelectedIndexChanged, AddressOf cmbDoctors_SelectedIndexChanged

        LoadDoctorsIntoComboBox()

        AddHandler cmbDoctors.SelectedIndexChanged, AddressOf cmbDoctors_SelectedIndexChanged

        lblSelectedDoctorID.Text = ""
        lblClinicName.Text = ""
        SaveVitals.Enabled = False
        cmbDoctors.Refresh()
    End Sub

    Private Sub EnqueuePatient()
        Try
            Dim patientID As String = lblPatientID.Text
            Dim doctorID As String = lblSelectedDoctorID.Text
            Dim clinicName As String = lblClinicName.Text

            If String.IsNullOrEmpty(doctorID) OrElse String.IsNullOrEmpty(patientID) Then
                MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Dim queueNumber As String = QueuePatient(patientID, doctorID, clinicName)

            MessageBox.Show($"Patient added to the queue successfully! Queue Number: {queueNumber}", "Queue Result", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show($"An error occurred while queuing patient: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub OldPatient_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        ClearPatientDetails()
        ClearSelectedDoctorAndClinic()
        GroupBoxVital.Enabled = False
        Me.Close()
    End Sub

End Class