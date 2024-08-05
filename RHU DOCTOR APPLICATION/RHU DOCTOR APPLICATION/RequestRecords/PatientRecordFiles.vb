Imports MySql.Data.MySqlClient
Public Class PatientRecordFiles
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
            btnSaveRequest.Enabled = True

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

        Else
            MessageBox.Show("No details found for the selected patient.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Information)
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

    End Sub




    Private Function SearchPatientsByFirstName(firstName As String) As DataTable
        Try
            Dim sql As String = "SELECT PatientID, FirstName, LastName FROM Patients WHERE FirstName LIKE @FirstName"

            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@FirstName", $"%{firstName}%")
        }

            Return ExecuteQuery(sql, parameters)
        Catch ex As Exception
            MessageBox.Show($"Error searching for patients by first name: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function

    Private Function SearchPatientsByLastName(lastName As String) As DataTable
        Try
            Dim sql As String = "SELECT PatientID, FirstName, LastName FROM Patients WHERE LastName LIKE @LastName"

            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@LastName", $"%{lastName}%")
        }

            Return ExecuteQuery(sql, parameters)
        Catch ex As Exception
            MessageBox.Show($"Error searching for patients by last name: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function


    Private Function GetPatientDetailsByName(firstName As String, lastName As String) As DataTable
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

    Private Sub ClearInfoExisting_Click(sender As Object, e As EventArgs) Handles ClearInfoExisting.Click
        ClearPatientDetails()
    End Sub



    Private Sub LoadDoctorsIntoComboBox()
        Try
            Dim sql As String = "SELECT DoctorID, CONCAT(FirstName, ' ', LastName) AS DoctorName FROM doctors"
            Dim doctorsDataTable As DataTable = ExecuteQuery(sql)

            If doctorsDataTable.Rows.Count > 0 Then
                Dim currentDoctorName As String = DocumentsPanel.DoctorNameLBL.Text

                Dim filteredDoctorsDataTable As New DataTable()
                filteredDoctorsDataTable = doctorsDataTable.Clone()
                For Each row As DataRow In doctorsDataTable.Rows
                    Dim doctorName As String = row("DoctorName").ToString()
                    If doctorName <> currentDoctorName Then
                        filteredDoctorsDataTable.ImportRow(row)
                    End If
                Next

                cmbDoctors.DataSource = filteredDoctorsDataTable
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
            Else
                lblClinicName.Text = ""
            End If
        End If
    End Sub
    Private Sub ClearSelectedDoctorAndClinic()
        RemoveHandler cmbDoctors.SelectedIndexChanged, AddressOf cmbDoctors_SelectedIndexChanged

        LoadDoctorsIntoComboBox()

        AddHandler cmbDoctors.SelectedIndexChanged, AddressOf cmbDoctors_SelectedIndexChanged

        lblSelectedDoctorID.Text = ""
        lblClinicName.Text = ""
        cmbDoctors.Refresh()
    End Sub

    Public Function GetClinicName(doctorID As String) As String
        Dim sql As String = "SELECT Clinic FROM doctors WHERE DoctorID = @DoctorID"
        Dim parameters As New List(Of MySqlParameter) From {
        New MySqlParameter("@DoctorID", doctorID)
    }

        Dim clinicName As Object = ExecuteScalar(sql, parameters)

        If clinicName IsNot Nothing AndAlso Not DBNull.Value.Equals(clinicName) Then
            Return clinicName.ToString()
        Else
            Return "Clinic Not Found"
        End If
    End Function

    Private Sub PatientRecordFiles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDoctorsIntoComboBox()
    End Sub

    Private Sub btnSaveRequest_Click(sender As Object, e As EventArgs) Handles btnSaveRequest.Click
        Try
            Dim senderDoctorID As String = DocumentsPanel.DoctorIDLBL.Text
            Dim receiverDoctorID As String = lblSelectedDoctorID.Text
            Dim patientID As String = lblPatientID.Text
            Dim requestMessage As String = txtRequestMessage.Text
            Dim requestDate As Date = DateTime.Now
            Dim status As String = "Pending"


            If String.IsNullOrWhiteSpace(requestMessage) Then
                MessageBox.Show("Please enter a request message.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If


            Dim confirmationResult As DialogResult = MessageBox.Show("Do you want to save the request?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If confirmationResult = DialogResult.Yes Then

                If Not RequestExists(senderDoctorID, receiverDoctorID, patientID, requestMessage, status) Then

                    AddRequestToDatabase(senderDoctorID, receiverDoctorID, patientID, requestMessage, requestDate, status)
                    MessageBox.Show("Request saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    btnSaveRequest.Enabled = False
                Else
                    MessageBox.Show("An existing pending request with the same details already exists. Please wait for the response.", "Request Exists", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    btnSaveRequest.Enabled = False
                End If
            Else
                MessageBox.Show("Request canceled.", "Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



End Class