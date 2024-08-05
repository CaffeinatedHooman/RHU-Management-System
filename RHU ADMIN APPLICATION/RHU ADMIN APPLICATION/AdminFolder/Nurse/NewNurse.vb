Public Class NewNurse
    Private Sub NewNurse_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNurseID.Text = GenerateNurseID()
        LoadClinicNames()
        LoadNurseSpecializations()
    End Sub
    Private Sub btnAddNurse_Click(sender As Object, e As EventArgs) Handles btnAddNurse.Click
        Try
            Dim firstName As String = txtNurseFirstName.Text
            Dim lastName As String = txtNurseLastName.Text
            Dim gender As String = If(cboNurseGender.SelectedItem IsNot Nothing, cboNurseGender.SelectedItem.ToString(), String.Empty)
            Dim contactNumber As String = txtNurseContactNumber.Text
            Dim address As String = txtNurseAddress.Text
            Dim specialist As String = If(cmbNurseSpecializations.SelectedItem IsNot Nothing, cmbNurseSpecializations.SelectedItem.ToString(), String.Empty)
            Dim username As String = txtNurseUsername.Text
            Dim clinic As String = If(ComboBoxClinicNames.SelectedItem IsNot Nothing, ComboBoxClinicNames.SelectedItem.ToString(), String.Empty)
            Dim accessCode As String = BoxAccessCode.Text

            ' Check if any required field is empty or access code is less than 4 characters
            If String.IsNullOrWhiteSpace(firstName) OrElse String.IsNullOrWhiteSpace(lastName) OrElse
           String.IsNullOrWhiteSpace(gender) OrElse String.IsNullOrWhiteSpace(contactNumber) OrElse
           String.IsNullOrWhiteSpace(address) OrElse String.IsNullOrWhiteSpace(specialist) OrElse
           String.IsNullOrWhiteSpace(username) OrElse String.IsNullOrWhiteSpace(accessCode) OrElse
           accessCode.Length < 4 Then
                MessageBox.Show("Please fill in all required fields and ensure the access code is at least 4 characters long.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Check if a nurse with the same name already exists
            If IsNurseNameExists(firstName, lastName) Then
                MessageBox.Show("A Nurse Account already exists. Please check the input.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Check if the username already exists
            If IsUsernameExistsNurse(username) Then
                MessageBox.Show("Username already exists. Please choose a different username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Dim resultMessage As String = AddNurse(firstName, lastName, gender, contactNumber, address, specialist, username, clinic, accessCode)
            ClearNurseFormFields()

            If resultMessage.StartsWith("An error occurred") Then
                MessageBox.Show(resultMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("Nurse added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ClearNurseFormFields()
            End If
        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub





    Private Sub ClearNurseFormFields()
        txtNurseID.Text = GenerateNurseID()
        txtNurseFirstName.Clear()
        txtNurseLastName.Clear()
        cboNurseGender.SelectedIndex = -1
        txtNurseContactNumber.Clear()
        txtNurseAddress.Clear()
        cmbNurseSpecializations.SelectedIndex = -1
        txtNurseUsername.Clear()
        BoxAccessCode.Text = ""
        ComboBoxClinicNames.SelectedIndex = -1
    End Sub





    Private Sub LoadNurseSpecializations()
        Try
            cmbNurseSpecializations.Items.Clear()

            Dim nurseSpecializationsTable As DataTable = GetAllNurseSpecializations()

            If nurseSpecializationsTable IsNot Nothing AndAlso nurseSpecializationsTable.Rows.Count > 0 Then
                For Each row As DataRow In nurseSpecializationsTable.Rows
                    cmbNurseSpecializations.Items.Add(row("Specialization").ToString())
                Next
            Else
                cmbNurseSpecializations.Items.Add("No nurse specializations found.")
            End If
        Catch ex As Exception
            Console.WriteLine($"Error loading nurse specializations: {ex.Message}")
        End Try
    End Sub



    Private Sub LoadClinicNames()
        Try
            ComboBoxClinicNames.Items.Clear()

            Dim clinicsTable As DataTable = GetAllClinics()

            If clinicsTable IsNot Nothing AndAlso clinicsTable.Rows.Count > 0 Then
                For Each row As DataRow In clinicsTable.Rows
                    ComboBoxClinicNames.Items.Add(row("ClinicName").ToString())
                Next
            Else
                ComboBoxClinicNames.Items.Add("No clinics found.")
            End If
        Catch ex As Exception
            Console.WriteLine($"Error loading clinic names: {ex.Message}")
        End Try
    End Sub

    Private Sub ComboBoxClinicNames_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxClinicNames.SelectedIndexChanged
        Try
            If ComboBoxClinicNames.SelectedIndex <> -1 Then
                Dim selectedClinicName As String = ComboBoxClinicNames.SelectedItem.ToString()

                Dim accessCode As String = GetAccessCodeByClinicName(selectedClinicName)

                BoxAccessCode.Text = accessCode
            End If
        Catch ex As Exception
            Console.WriteLine($"Error handling clinic selection: {ex.Message}")
        End Try
    End Sub

End Class