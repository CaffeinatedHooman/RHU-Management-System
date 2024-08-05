Public Class NurseProfile
    Private Sub NurseProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayAllNurseNames()
        LoadNurseSpecializations()
        LoadClinicNames()
    End Sub
    Private Sub DisplayAllNurseNames()
        Try
            ListBoxNurseNames.Items.Clear()

            Dim allNurseNamesTable As DataTable = GetAllNurseNames()

            If allNurseNamesTable IsNot Nothing AndAlso allNurseNamesTable.Rows.Count > 0 Then
                For Each row As DataRow In allNurseNamesTable.Rows
                    Dim nurseID As String = row("NurseID").ToString()
                    Dim fullName As String = $"{nurseID} - {row("NurseName")}"
                    ListBoxNurseNames.Items.Add(fullName)
                Next
            Else
                ListBoxNurseNames.Items.Add("No nurses found.")
            End If
        Catch ex As Exception
            Console.WriteLine($"Error displaying all nurse names: {ex.Message}")
        End Try
    End Sub



    Private Sub ListBoxNurseNames_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxNurseNames.SelectedIndexChanged
        Try
            If ListBoxNurseNames.SelectedIndex <> -1 Then
                Dim selectedNurseInfo As String = ListBoxNurseNames.SelectedItem.ToString()

                Dim parts As String() = selectedNurseInfo.Split("-"c)
                Dim selectedNurseID As String = parts(0).Trim()

                Dim nurseDetails As DataTable = GetNurseDetailsByID(selectedNurseID)
                DisplayNurseDetails(nurseDetails)
            End If
        Catch ex As Exception
            Console.WriteLine($"Error handling nurse ID selection: {ex.Message}")
        End Try
    End Sub




    Private Sub DisplayNurseDetails(nurseDetails As DataTable)
        If nurseDetails IsNot Nothing AndAlso nurseDetails.Rows.Count > 0 Then

            lblNurseID.Text = nurseDetails.Rows(0)("NurseID").ToString()
            lblNurseFirstname.Text = nurseDetails.Rows(0)("FirstName").ToString()
            lblNurseLastname.Text = nurseDetails.Rows(0)("LastName").ToString()
            lblNurseGender.Text = nurseDetails.Rows(0)("Gender").ToString()
            lblNurseContactNumber.Text = nurseDetails.Rows(0)("ContactNumber").ToString()
            lblNurseAddress.Text = nurseDetails.Rows(0)("Address").ToString()
            lblNurseSpecialization.Text = nurseDetails.Rows(0)("Specialization").ToString()
            lblNurseUsername.Text = nurseDetails.Rows(0)("Username").ToString()
            lblClinicAssigned.Text = nurseDetails.Rows(0)("Clinic").ToString()
            lblNurseAccessCode.Text = nurseDetails.Rows(0)("AccessCode").ToString()

            txtNewFirstName.Text = nurseDetails.Rows(0)("FirstName").ToString()
            txtNewLastName.Text = nurseDetails.Rows(0)("LastName").ToString()
            txtNewContactNumber.Text = nurseDetails.Rows(0)("ContactNumber").ToString()
            txtNewAddress.Text = nurseDetails.Rows(0)("Address").ToString()
            txtNewUsername.Text = nurseDetails.Rows(0)("Username").ToString()
        Else
            MessageBox.Show("No details found for the selected nurse.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub ClearNurseDetails()
        lblNurseID.Text = "NURSEID"
        lblNurseFirstname.Text = "="
        lblNurseLastname.Text = "="
        lblNurseGender.Text = "="
        lblNurseContactNumber.Text = "="
        lblNurseAddress.Text = "="
        lblNurseSpecialization.Text = "="
        lblNurseUsername.Text = "="
        lblClinicAssigned.Text = "="
        lblNurseAccessCode.Text = "="
    End Sub




    Private Sub btnUpdateNurse_Click(sender As Object, e As EventArgs) Handles btnUpdateNurse.Click
        Try
            Dim nurseID As String = lblNurseID.Text

            If String.IsNullOrWhiteSpace(txtNewFirstName.Text) OrElse String.IsNullOrWhiteSpace(txtNewLastName.Text) Then
                MessageBox.Show("Please enter both first name and last name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If cmbNewGender.SelectedItem Is Nothing Then
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


            If cmbNewSpecialization.SelectedItem Is Nothing Then
                MessageBox.Show("Please select a specialization.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If


            If String.IsNullOrWhiteSpace(txtNewUsername.Text) Then
                MessageBox.Show("Please enter a username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If cmbNewClinic.SelectedItem Is Nothing Then
                MessageBox.Show("Please select a clinic.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If String.IsNullOrWhiteSpace(txtNewAccessCode.Text) Then
                MessageBox.Show("Please enter an access code.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Dim resultMessage As String = UpdateNurse(nurseID, txtNewFirstName.Text, txtNewLastName.Text, cmbNewGender.SelectedItem.ToString(), txtNewContactNumber.Text, txtNewAddress.Text, cmbNewSpecialization.SelectedItem.ToString(), txtNewUsername.Text, cmbNewClinic.SelectedItem.ToString(), txtNewAccessCode.Text)

            MessageBox.Show(resultMessage, "Result", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ClearNurseDetails()
            UpdatePanelField.Visible = False
            btnUpdateNurse.Visible = False
        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub ShowPanelUpdate_Click(sender As Object, e As EventArgs) Handles ShowPanelUpdate.Click
        UpdatePanelField.Visible = True
        btnUpdateNurse.Visible = True
    End Sub














    Private Sub LoadNurseSpecializations()
        Try
            cmbNewSpecialization.Items.Clear()

            Dim nurseSpecializationsTable As DataTable = GetAllNurseSpecializations()

            If nurseSpecializationsTable IsNot Nothing AndAlso nurseSpecializationsTable.Rows.Count > 0 Then
                For Each row As DataRow In nurseSpecializationsTable.Rows
                    cmbNewSpecialization.Items.Add(row("Specialization").ToString())
                Next
            Else
                cmbNewSpecialization.Items.Add("No nurse specializations found.")
            End If
        Catch ex As Exception
            Console.WriteLine($"Error loading nurse specializations: {ex.Message}")
        End Try
    End Sub



    Private Sub LoadClinicNames()
        Try
            cmbNewClinic.Items.Clear()

            Dim clinicsTable As DataTable = GetAllClinics()

            If clinicsTable IsNot Nothing AndAlso clinicsTable.Rows.Count > 0 Then
                For Each row As DataRow In clinicsTable.Rows
                    cmbNewClinic.Items.Add(row("ClinicName").ToString())
                Next
            Else
                cmbNewClinic.Items.Add("No clinics found.")
            End If
        Catch ex As Exception
            Console.WriteLine($"Error loading clinic names: {ex.Message}")
        End Try
    End Sub

    Private Sub cmbNewClinic_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbNewClinic.SelectedIndexChanged
        Try
            If cmbNewClinic.SelectedIndex <> -1 Then
                Dim selectedClinicName As String = cmbNewClinic.SelectedItem.ToString()

                Dim accessCode As String = GetAccessCodeByClinicName(selectedClinicName)

                txtNewAccessCode.Text = accessCode
            End If
        Catch ex As Exception
            Console.WriteLine($"Error handling clinic selection: {ex.Message}")
        End Try
    End Sub
End Class

