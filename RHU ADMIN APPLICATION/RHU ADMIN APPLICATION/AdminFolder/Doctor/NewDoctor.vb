Public Class NewDoctor

    Private Sub NewDoctor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtDocID.Text = GenerateDoctorID()
        LoadDoctorSpecializations()
        LoadClinicNames()
    End Sub
    Private Sub btnAddDoctor_Click(sender As Object, e As EventArgs) Handles btnAddDoctor.Click
        Try
            Dim firstName As String = txtFirstName.Text
            Dim lastName As String = txtLastName.Text
            Dim gender As String = If(cboGender.SelectedItem IsNot Nothing, cboGender.SelectedItem.ToString(), String.Empty)
            Dim contactNumber As String = txtContactNumber.Text
            Dim address As String = txtAddress.Text
            Dim specialization As String = If(cmbDoctorSpecializations.SelectedItem IsNot Nothing, cmbDoctorSpecializations.SelectedItem.ToString(), String.Empty)
            Dim username As String = txtUsername.Text
            Dim clinic As String = If(cmbDoctorClinics.SelectedItem IsNot Nothing, cmbDoctorClinics.SelectedItem.ToString(), String.Empty)
            Dim accessCode As String = BoxAccessCode.Text

            If String.IsNullOrWhiteSpace(firstName) OrElse String.IsNullOrWhiteSpace(lastName) OrElse
           String.IsNullOrWhiteSpace(gender) OrElse String.IsNullOrWhiteSpace(contactNumber) OrElse
           String.IsNullOrWhiteSpace(address) OrElse String.IsNullOrWhiteSpace(specialization) OrElse
           String.IsNullOrWhiteSpace(username) OrElse String.IsNullOrWhiteSpace(clinic) OrElse
           String.IsNullOrWhiteSpace(accessCode) Then
                MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If IsUsernameExists(username) Then
                MessageBox.Show("Username already exists. Please choose a different username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If IsDoctorNameExists(firstName, lastName) Then
                MessageBox.Show("Doctor Account already exists. Please ensure uniqueness.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If accessCode.Length < 4 Then
                MessageBox.Show("Access code must be at least 5 characters long.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Dim resultMessage As String = AddDoctor(firstName, lastName, gender, contactNumber, address, specialization, username, clinic, accessCode)
            ClearNewDocFields()

            If resultMessage.StartsWith("An error occurred") Then
                MessageBox.Show(resultMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("Doctor added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ClearFormFields()
            End If

        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ClearNewDocFields()
        txtDocID.Text = GenerateDoctorID()
        txtFirstName.Clear()
        txtLastName.Clear()
        cboGender.SelectedIndex = -1
        txtContactNumber.Clear()
        txtAddress.Clear()
        cmbDoctorSpecializations.SelectedIndex = -1
        txtUsername.Clear()
        cmbDoctorClinics.SelectedIndex = -1
    End Sub

    Private Sub LoadDoctorSpecializations()
        Try
            cmbDoctorSpecializations.Items.Clear()

            Dim doctorSpecializationsTable As DataTable = GetAllDoctorSpecializations()

            If doctorSpecializationsTable IsNot Nothing AndAlso doctorSpecializationsTable.Rows.Count > 0 Then
                For Each row As DataRow In doctorSpecializationsTable.Rows
                    cmbDoctorSpecializations.Items.Add(row("Specialization").ToString())
                Next
            Else
                cmbDoctorSpecializations.Items.Add("No doctor specializations found.")
            End If
        Catch ex As Exception
            Console.WriteLine($"Error loading doctor specializations: {ex.Message}")
        End Try
    End Sub

    Private Sub LoadClinicNames()
        Try
            cmbDoctorClinics.Items.Clear()

            Dim clinicsTable As DataTable = GetAllClinics()

            If clinicsTable IsNot Nothing AndAlso clinicsTable.Rows.Count > 0 Then
                For Each row As DataRow In clinicsTable.Rows
                    cmbDoctorClinics.Items.Add(row("ClinicName").ToString())
                Next
            Else
                cmbDoctorClinics.Items.Add("No clinics found.")
            End If
        Catch ex As Exception
            Console.WriteLine($"Error loading clinic names: {ex.Message}")
        End Try
    End Sub

    Private Sub ComboBoxClinicNames_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDoctorClinics.SelectedIndexChanged
        Try
            If cmbDoctorClinics.SelectedIndex <> -1 Then
                Dim selectedClinicName As String = cmbDoctorClinics.SelectedItem.ToString()

                Dim accessCode As String = GetAccessCodeByClinicName(selectedClinicName)

                BoxAccessCode.Text = accessCode
            End If
        Catch ex As Exception
            Console.WriteLine($"Error handling clinic selection: {ex.Message}")
        End Try
    End Sub

    Private Sub ClearFormFields()
        txtFirstName.Clear()
        txtLastName.Clear()
        txtContactNumber.Clear()
        txtAddress.Clear()
        txtUsername.Clear()
        BoxAccessCode.Text = ""
        cmbDoctorClinics.SelectedIndex = -1
        cboGender.SelectedIndex = -1
        cmbDoctorSpecializations.SelectedIndex = -1
    End Sub

End Class