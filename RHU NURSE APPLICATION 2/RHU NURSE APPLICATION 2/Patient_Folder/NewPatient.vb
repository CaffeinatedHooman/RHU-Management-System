Public Class NewPatient

    Private Sub NewPatient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PatientIDLabelGen.Text = GeneratePatientID()
        DisplayAllMaritalStatusesOnComboBox()
        LoadDoctorsIntoComboBox()
    End Sub

    Private Sub dtpDOB_ValueChanged(sender As Object, e As EventArgs) Handles dtpDOB.ValueChanged
        Dim now As DateTime = Date.Now
        Dim bday As DateTime = dtpDOB.Value
        Dim age As Integer = now.Year - bday.Year

        If now.Month < bday.Month Or (now.Month = bday.Month And now.Day < bday.Day) Then
            age -= 1
        End If

        txtAge.Text = age.ToString()
    End Sub

    Private Sub btnCreatePatient_Click(sender As Object, e As EventArgs) Handles btnCreatePatient.Click

        Try
            Dim firstName As String = txtFirstName.Text
            Dim middleName As String = txtMiddleName.Text
            Dim lastName As String = txtLastName.Text
            Dim gender As String = If(cboGender.SelectedItem IsNot Nothing, cboGender.SelectedItem.ToString(), String.Empty)
            Dim dob As String = dtpDOB.Value.ToString("yyyy-MM-dd")
            Dim age As Integer

            If String.IsNullOrEmpty(firstName) Then
                MessageBox.Show("Please enter a valid first name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            If String.IsNullOrEmpty(lastName) Then
                MessageBox.Show("Please enter a valid last name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            If Not Integer.TryParse(txtAge.Text, age) Then
                MessageBox.Show("Please enter a valid age.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim maritalStatus As String = If(cboMaritalStatus.SelectedItem IsNot Nothing, cboMaritalStatus.SelectedItem.ToString(), String.Empty)
            Dim citizenship As String = txtCitizenship.Text
            Dim religion As String = txtReligion.Text
            Dim address As String = txtAddress.Text
            Dim contactNumber As String = txtContactNumber.Text
            Dim philhealthID As String = txtPhilhealthID.Text

            If String.IsNullOrEmpty(gender) OrElse String.IsNullOrEmpty(maritalStatus) Then
                MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            CreatePatient(firstName, middleName, lastName, gender, dob, age, maritalStatus, citizenship, religion, address, contactNumber, philhealthID)
            MessageBox.Show("Patient record created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            GroupBoxVital.Visible = True
        Catch ex As Exception
            MessageBox.Show($"Error creating patient record: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ClearTextBoxes()
        PatientIDLabelGen.Text = GeneratePatientID()
        txtFirstName.Text = ""
        txtMiddleName.Text = ""
        txtLastName.Text = ""
        cboGender.SelectedItem = Nothing
        dtpDOB.Value = DateTime.Now
        txtAge.Text = ""
        cboMaritalStatus.SelectedItem = Nothing
        txtCitizenship.Text = ""
        txtReligion.Text = ""
        txtAddress.Text = ""
        txtContactNumber.Text = ""
        txtPhilhealthID.Text = ""
    End Sub



    Private Sub DisplayAllMaritalStatusesOnComboBox()
        Try
            cboMaritalStatus.Items.Clear()
            Dim maritalStatusesTable As DataTable = GetAllMaritalStatuses()

            If maritalStatusesTable IsNot Nothing AndAlso maritalStatusesTable.Rows.Count > 0 Then
                For Each row As DataRow In maritalStatusesTable.Rows
                    cboMaritalStatus.Items.Add(row("MaritalStatusName").ToString())
                Next
            Else
                cboMaritalStatus.Items.Add("No Marital Statuses found.")
            End If
        Catch ex As Exception
            Console.WriteLine($"Error displaying all marital statuses on ComboBox: {ex.Message}")
        End Try
    End Sub

    Private Sub btnClearPatient_Click(sender As Object, e As EventArgs) Handles btnClearPatient.Click
        ClearTextBoxes()
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
            Dim patientID As String = PatientIDLabelGen.Text
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

    Private Sub SaveVitals_Click(sender As Object, e As EventArgs) Handles SaveVitals.Click
        Try
            Dim patientID As String = PatientIDLabelGen.Text
            Dim bodyTemp As String = txtBodyTemp.Text
            Dim bloodPressure As String = txtBloodPressure.Text
            Dim respirationRate As String = txtRespirationRate.Text
            Dim pulseRate As String = txtPulseRate.Text
            Dim weight As String = txtWeight.Text
            Dim height As String = txtHeight.Text
            Dim diagnosis As String = txtDiagnosis.Text

            ValidateInput(bodyTemp, "Body Temperature")
            ValidateInput(bloodPressure, "Blood Pressure")
            ValidateInput(respirationRate, "Respiration Rate")
            ValidateInput(pulseRate, "Pulse Rate")
            ValidateInput(weight, "Weight")
            ValidateInput(height, "Height")
            ValidateInput(diagnosis, "Diagnosis")

            If CreatePatientVitalRecord(patientID, bodyTemp, bloodPressure, respirationRate, pulseRate, weight, height, diagnosis) Then
                'MessageBox.Show("Patient vital record created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                EnqueuePatient()

                CLEARVITALS()
                ClearTextBoxes()
                GroupBoxVital.Visible = False
                ClearSelectedDoctorAndClinic()

            Else
                MessageBox.Show("Failed to create patient vital record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
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

End Class