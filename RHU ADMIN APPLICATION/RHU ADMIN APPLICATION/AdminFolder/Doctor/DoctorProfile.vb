Public Class DoctorProfile
    Private Sub DoctorProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadClinicNames()
        LoadDoctorpecializations()
        DisplayAllDoctorNames()
    End Sub

    Private Sub DisplayAllDoctorNames()
        Try
            ListBoxDoctorNames.Items.Clear()

            Dim allDoctorNamesTable As DataTable = GetAllDoctorNames()

            If allDoctorNamesTable IsNot Nothing AndAlso allDoctorNamesTable.Rows.Count > 0 Then
                For Each row As DataRow In allDoctorNamesTable.Rows
                    Dim doctorID As String = row("DoctorID").ToString()
                    Dim fullName As String = $"{doctorID} - {row("DoctorName")}"
                    ListBoxDoctorNames.Items.Add(fullName)
                Next
            Else
                ListBoxDoctorNames.Items.Add("No doctors found.")
            End If
        Catch ex As Exception
            Console.WriteLine($"Error displaying all doctor names: {ex.Message}")
        End Try
    End Sub


    Private Sub ListBoxDoctorNames_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxDoctorNames.SelectedIndexChanged
        Try
            If ListBoxDoctorNames.SelectedIndex <> -1 Then
                Dim selectedFullName As String = ListBoxDoctorNames.SelectedItem.ToString()

                Dim doctorID As String = selectedFullName.Split("-"c).FirstOrDefault().Trim()

                Dim doctorDetails As DataTable = GetDoctorDetailsByID(doctorID)
                DisplayDoctorDetails(doctorDetails)
            End If
        Catch ex As Exception
            Console.WriteLine($"Error handling doctor name selection: {ex.Message}")
        End Try
    End Sub




    Private Sub DisplayDoctorDetails(doctorDetails As DataTable)
        If doctorDetails IsNot Nothing AndAlso doctorDetails.Rows.Count > 0 Then
            lblDoctorID.Text = doctorDetails.Rows(0)("DoctorID").ToString()
            lblDoctorFirstName.Text = doctorDetails.Rows(0)("FirstName").ToString()
            lblDoctorLastName.Text = doctorDetails.Rows(0)("LastName").ToString()
            lblDoctorGender.Text = doctorDetails.Rows(0)("Gender").ToString()
            lblDoctorContactNumber.Text = doctorDetails.Rows(0)("ContactNumber").ToString()
            lblDoctorAddress.Text = doctorDetails.Rows(0)("Address").ToString()
            lblDoctorSpecialization.Text = doctorDetails.Rows(0)("Specialization").ToString()
            lblDoctorUsername.Text = doctorDetails.Rows(0)("Username").ToString()
            lblDoctorClinic.text = doctorDetails.Rows(0)("Clinic").ToString()
            lblDoctorAccessCode.Text = doctorDetails.Rows(0)("AccessCode").ToString()

            txtNewFirstName.Text = doctorDetails.Rows(0)("FirstName").ToString()
            txtNewLastName.Text = doctorDetails.Rows(0)("LastName").ToString()
            txtNewContactNumber.Text = doctorDetails.Rows(0)("ContactNumber").ToString()
            txtNewAddress.Text = doctorDetails.Rows(0)("Address").ToString()
            txtNewUsername.Text = doctorDetails.Rows(0)("Username").ToString()
        Else
            MessageBox.Show("No details found for the selected doctor.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub ClearDoctorDetails()
        lblDoctorID.Text = "DOCTORID"
        lblDoctorFirstName.Text = "="
        lblDoctorLastName.Text = "="
        lblDoctorGender.Text = "="
        lblDoctorContactNumber.Text = "="
        lblDoctorAddress.Text = "="
        lblDoctorSpecialization.Text = "="
        lblDoctorUsername.Text = "="
        lblDoctorClinic.Text = "="
        lblDoctorAccessCode.Text = "="
    End Sub





    Private Sub btnUpdateDoctor_Click(sender As Object, e As EventArgs) Handles btnUpdateDoctor.Click
        Try
            Dim doctorID As String = lblDoctorID.Text

            If String.IsNullOrWhiteSpace(txtNewFirstName.Text) OrElse String.IsNullOrWhiteSpace(txtNewLastName.Text) Then
                MessageBox.Show("Please enter both first name and last name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If cmbNewDoctorGender.SelectedItem Is Nothing Then
                MessageBox.Show("Please select a gender.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If String.IsNullOrWhiteSpace(txtNewContactNumber.Text) Then
                MessageBox.Show("Please enter a contact number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If String.IsNullOrWhiteSpace(txtNewAddress.Text) Then
                MessageBox.Show("Please enter an address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If cmbNewDoctorSpecialization.SelectedItem Is Nothing Then
                MessageBox.Show("Please select a specialization.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If String.IsNullOrWhiteSpace(txtNewUsername.Text) Then
                MessageBox.Show("Please enter a username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If cmbNewDoctorClinic.SelectedItem Is Nothing Then
                MessageBox.Show("Please select a clinic.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If String.IsNullOrWhiteSpace(txtNewAccessCode.Text) Then
                MessageBox.Show("Please enter an access code.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Dim resultMessage As String = UpdateDoctor(doctorID, txtNewFirstName.Text, txtNewLastName.Text, cmbNewDoctorGender.SelectedItem.ToString(), txtNewContactNumber.Text, txtNewAddress.Text, cmbNewDoctorSpecialization.SelectedItem.ToString(), txtNewUsername.Text, cmbNewDoctorClinic.SelectedItem.ToString(), txtNewAccessCode.Text)

            MessageBox.Show(resultMessage, "Result", MessageBoxButtons.OK, MessageBoxIcon.Information)

            UpdateDoctorPanelField.Visible = False
            btnUpdateDoctor.Visible = False
            ClearDoctorDetails()
        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ShowPanelUpdate_Click(sender As Object, e As EventArgs) Handles ShowPanelUpdate.Click
        UpdateDoctorPanelField.Visible = True
        btnUpdateDoctor.Visible = True
    End Sub


    Private Sub LoadDoctorpecializations()
        Try
            cmbNewDoctorSpecialization.Items.Clear()

            Dim nurseSpecializationsTable As DataTable = GetAllDoctorSpecializations()

            If nurseSpecializationsTable IsNot Nothing AndAlso nurseSpecializationsTable.Rows.Count > 0 Then
                For Each row As DataRow In nurseSpecializationsTable.Rows
                    cmbNewDoctorSpecialization.Items.Add(row("Specialization").ToString())
                Next
            Else
                cmbNewDoctorSpecialization.Items.Add("No nurse specializations found.")
            End If
        Catch ex As Exception
            Console.WriteLine($"Error loading nurse specializations: {ex.Message}")
        End Try
    End Sub


    Private Sub LoadClinicNames()
        Try
            cmbNewDoctorClinic.Items.Clear()

            Dim clinicsTable As DataTable = GetAllClinics()

            If clinicsTable IsNot Nothing AndAlso clinicsTable.Rows.Count > 0 Then
                For Each row As DataRow In clinicsTable.Rows
                    cmbNewDoctorClinic.Items.Add(row("ClinicName").ToString())
                Next
            Else
                cmbNewDoctorClinic.Items.Add("No clinics found.")
            End If
        Catch ex As Exception
            Console.WriteLine($"Error loading clinic names: {ex.Message}")
        End Try
    End Sub

    Private Sub cmbNewDoctorClinic_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbNewDoctorClinic.SelectedIndexChanged
        Try
            If cmbNewDoctorClinic.SelectedIndex <> -1 Then
                Dim selectedClinicName As String = cmbNewDoctorClinic.SelectedItem.ToString()

                Dim accessCode As String = GetAccessCodeByClinicName(selectedClinicName)

                txtNewAccessCode.Text = accessCode
            End If
        Catch ex As Exception
            Console.WriteLine($"Error handling clinic selection: {ex.Message}")
        End Try
    End Sub

End Class