
Public Class NewClinic

    Private Sub NewClinic_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayAllClinics()
    End Sub
    Private Sub DisplayAllClinics()
        Try
            ListBoxClinics.Items.Clear()
            ClinicListBoxUpdate.Items.Clear()
            ClinicListDelete.Items.Clear()
            Dim clinicsTable As DataTable = GetAllClinics()

            If clinicsTable IsNot Nothing AndAlso clinicsTable.Rows.Count > 0 Then
                For Each row As DataRow In clinicsTable.Rows
                    ListBoxClinics.Items.Add(row("ClinicName").ToString())
                    ClinicListBoxUpdate.Items.Add(row("ClinicName").ToString())
                    ClinicListDelete.Items.Add(row("ClinicName").ToString())
                Next
            Else
                ListBoxClinics.Items.Add("No clinics found.")
                ClinicListBoxUpdate.Items.Add("No clinics found.")
                ClinicListDelete.Items.Add("No clinics found.")
            End If
        Catch ex As Exception
            Console.WriteLine($"Error displaying all clinics: {ex.Message}")
        End Try
    End Sub
    Private Sub btnAddClinic_Click(sender As Object, e As EventArgs) Handles btnAddClinic.Click
        Try
            Dim clinicName As String = txtClinicName.Text.Trim()
            Dim accessCode As String = txtAccessCode.Text.Trim()

            If clinicName.Length < 5 Then
                MessageBox.Show("Clinic name must be at least 5 characters long.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If accessCode.Length < 5 Then
                MessageBox.Show("Access code must be at least 5 characters long.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If IsClinicExists(clinicName) Then
                MessageBox.Show("A clinic with the same name already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If Not IsAccessCodeUnique(accessCode) Then
                MessageBox.Show("Access code must be unique.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Dim resultMessage As String = AddClinic(clinicName, accessCode)
            MessageBox.Show(resultMessage, "Result", MessageBoxButtons.OK, MessageBoxIcon.Information)

            txtClinicName.Clear()
            txtAccessCode.Clear()

            DisplayAllClinics()

        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub






    Private Sub btnUpdateClinic_Click(sender As Object, e As EventArgs) Handles btnUpdateClinic.Click
        Try
            If ClinicListBoxUpdate.SelectedIndex <> -1 Then
                Dim oldClinicName As String = ClinicListBoxUpdate.SelectedItem.ToString()
                Dim newClinicName As String = txtNewClinicName.Text
                Dim newAccessCode As String = txtNewAccessCode.Text

                If String.IsNullOrEmpty(newClinicName) Or String.IsNullOrEmpty(newAccessCode) Then
                    MessageBox.Show("Please enter both clinic name and access code.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If

                ' Check if the new clinic name already exists
                If IsClinicExists(newClinicName) Then
                    MessageBox.Show("The new clinic name already exists. Please choose a different clinic name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If

                lblOldClinicName.Text = $"Old Clinic Name: {oldClinicName}"
                lblOldAccessCode.Text = $"Old Access Code: {GetAccessCode(oldClinicName)}"

                If Not IsAccessCodeUnique(newAccessCode) Then
                    MessageBox.Show("The new access code is not unique. Please choose a different access code.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If

                Dim confirmationResult As DialogResult = MessageBox.Show($"Are you sure you want to update clinic '{oldClinicName}' with access code '{GetAccessCode(oldClinicName)}'?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If confirmationResult = DialogResult.Yes Then

                    Dim resultMessage As String = UpdateClinic(oldClinicName, newClinicName, newAccessCode, GetAccessCode(oldClinicName))
                    MessageBox.Show(resultMessage, "Result", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    DisplayAllClinics()

                    txtNewClinicName.Clear()
                    txtNewAccessCode.Clear()

                    lblOldClinicName.Text = "Old Clinic Name:"
                    lblOldAccessCode.Text = "Old Access Code:"
                End If
            End If
        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub ClinicListBoxUpdate_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ClinicListBoxUpdate.SelectedIndexChanged
        Try
            If ClinicListBoxUpdate.SelectedIndices.Count > 0 Then
                Dim selectedIndex As Integer = ClinicListBoxUpdate.SelectedIndices(0)
                lblOldClinicName.Text = ClinicListBoxUpdate.Items(selectedIndex).ToString()

                Dim oldAccessCode As String = GetAccessCode(lblOldClinicName.Text)
                lblOldAccessCode.Text = oldAccessCode
            End If
        Catch ex As Exception
            Console.WriteLine($"Error handling clinic selection: {ex.Message}")
        End Try
    End Sub

    Private Sub ClinicListDelete_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ClinicListDelete.SelectedIndexChanged
        Try
            If ClinicListDelete.SelectedIndices.Count > 0 Then
                Dim selectedIndex As Integer = ClinicListDelete.SelectedIndices(0)
                Dim selectedClinicName As String = ClinicListDelete.Items(selectedIndex).ToString()

                lblDeleteClinicName.Text = $"Clinic Name: {selectedClinicName}"
                lblDeleteAccessCode.Text = $"Access Code: {GetAccessCode(selectedClinicName)}"

            End If
        Catch ex As Exception
            Console.WriteLine($"Error handling clinic selection for deletion: {ex.Message}")
        End Try
    End Sub

    Private Sub btnDeleteClinic_Click(sender As Object, e As EventArgs) Handles btnDeleteClinic.Click
        Try
            Dim selectedClinicName As String = lblDeleteClinicName.Text.Replace("Clinic Name: ", "")

            If Not String.IsNullOrEmpty(selectedClinicName) Then
                Dim confirmationResult As DialogResult = MessageBox.Show($"Are you sure you want to delete clinic '{selectedClinicName}'?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If confirmationResult = DialogResult.Yes Then
                    Dim deletionResult As String = DeleteClinic(selectedClinicName)
                    MessageBox.Show(deletionResult, "Deletion Result", MessageBoxButtons.OK, MessageBoxIcon.Information)


                    DisplayAllClinics()


                    lblDeleteClinicName.Text = "Clinic Name:"
                    lblDeleteAccessCode.Text = "Access Code:"
                End If
            Else
                MessageBox.Show("Please select a clinic to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            Console.WriteLine($"Error deleting clinic: {ex.Message}")
        End Try
    End Sub


End Class