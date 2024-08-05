Public Class LabUserInfo
    Private Sub LabUserInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayAllLaboratoryNamesForUsers()
        LoadLaboratoryNames()
    End Sub
    Private Sub DisplayAllLaboratoryNamesForUsers()
        Try
            ListBoxLabUsers.Items.Clear()

            Dim labUsersTable As DataTable = GetAllLaboratoryUserNames()

            If labUsersTable IsNot Nothing AndAlso labUsersTable.Rows.Count > 0 Then
                For Each row As DataRow In labUsersTable.Rows
                    Dim userId As String = row("LaboratoryUserID").ToString()
                    Dim fullName As String = $"{userId} - {row("FullName").ToString()}"
                    ListBoxLabUsers.Items.Add(fullName)
                Next
            Else
                ListBoxLabUsers.Items.Add("No laboratory users found.")
            End If
        Catch ex As Exception
            Console.WriteLine($"Error displaying all laboratory user names: {ex.Message}")
        End Try
    End Sub


    Private Sub ListBoxLabUsers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxLabUsers.SelectedIndexChanged
        Try
            If ListBoxLabUsers.SelectedIndex <> -1 Then
                Dim selectedFullName As String = ListBoxLabUsers.SelectedItem.ToString()

                Dim labUserID As String = selectedFullName.Split("-"c).FirstOrDefault().Trim()

                Dim labUserDetails As DataTable = GetLabUserDetailsByID(labUserID)
                DisplayLabUserDetails(labUserDetails)
            End If
        Catch ex As Exception
            Console.WriteLine($"Error handling laboratory user name selection: {ex.Message}")
        End Try
    End Sub

    Private Sub DisplayLabUserDetails(labUserDetails As DataTable)
        If labUserDetails IsNot Nothing AndAlso labUserDetails.Rows.Count > 0 Then
            Dim userID As String = labUserDetails.Rows(0)("LaboratoryUserID").ToString()
            Dim firstName As String = labUserDetails.Rows(0)("FirstName").ToString()
            Dim lastName As String = labUserDetails.Rows(0)("LastName").ToString()
            Dim gender As String = labUserDetails.Rows(0)("Gender").ToString()
            Dim contactNumber As String = labUserDetails.Rows(0)("ContactNumber").ToString()
            Dim address As String = labUserDetails.Rows(0)("Address").ToString()
            Dim position As String = labUserDetails.Rows(0)("Position").ToString()
            Dim username As String = labUserDetails.Rows(0)("Username").ToString()
            Dim laboratory As String = labUserDetails.Rows(0)("Laboratory").ToString()
            Dim accessCode As String = labUserDetails.Rows(0)("AccessCode").ToString()

            lblUserIDValue.Text = userID
            lblFirstNameValue.Text = firstName
            lblLastNameValue.Text = lastName
            lblGenderValue.Text = gender
            lblContactNumberValue.Text = contactNumber
            lblAddressValue.Text = address
            lblPositionValue.Text = position
            lblUsernameValue.Text = username
            lblLaboratoryValue.Text = laboratory
            lblAccessCodeValue.Text = accessCode

            txtNewFirstName.Text = firstName
            txtNewLastName.Text = lastName
            cmbNewUserSpecialization.Text = position
            txtNewContactNumber.Text = contactNumber
            txtNewAddress.Text = address
            txtNewUsername.Text = username


        Else
            MessageBox.Show("No details found for the selected laboratory user.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub ShowPanelUpdate_Click(sender As Object, e As EventArgs) Handles ShowPanelUpdate.Click
        UpdateUserPanelField.Visible = True
        btnUpdateUser.Visible = True
    End Sub

    Private Sub btnUpdateDoctor_Click(sender As Object, e As EventArgs) Handles btnUpdateUser.Click
        UpdateLabUser()
        DisplayAllLaboratoryNamesForUsers()
    End Sub

    Private Sub UpdateLabUser()
        Try
            Dim labUserID As String = lblUserIDValue.Text ' Assuming you have a label for displaying the laboratory user ID

            If String.IsNullOrWhiteSpace(txtNewFirstName.Text) OrElse String.IsNullOrWhiteSpace(txtNewLastName.Text) Then
                MessageBox.Show("Please enter both first name and last name for the laboratory user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If cmbNewUserGender.SelectedItem Is Nothing Then
                MessageBox.Show("Please select a gender for the laboratory user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If String.IsNullOrWhiteSpace(txtNewContactNumber.Text) Then
                MessageBox.Show("Please enter a contact number for the laboratory user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If String.IsNullOrWhiteSpace(txtNewAddress.Text) Then
                MessageBox.Show("Please enter an address for the laboratory user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If String.IsNullOrWhiteSpace(cmbNewUserSpecialization.Text) Then
                MessageBox.Show("Please select a specialization for the laboratory user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If String.IsNullOrWhiteSpace(txtNewUsername.Text) Then
                MessageBox.Show("Please enter a username for the laboratory user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If cmbNewUserClinic.SelectedItem Is Nothing Then
                MessageBox.Show("Please select a clinic for the laboratory user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If String.IsNullOrWhiteSpace(txtNewAccessCode.Text) Then
                MessageBox.Show("Please enter an access code for the laboratory user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Dim resultMessage As String = UpdateLaboratoryUser(labUserID, txtNewFirstName.Text, txtNewLastName.Text, cmbNewUserGender.SelectedItem.ToString(), txtNewContactNumber.Text, txtNewAddress.Text, txtNewUsername.Text, txtNewAccessCode.Text)

            MessageBox.Show(resultMessage, "Result", MessageBoxButtons.OK, MessageBoxIcon.Information)

            UpdateUserPanelField.Visible = False
            btnUpdateUser.Visible = False
            ClearUserDetails()
            ClearLabelsUserDetails()
        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ClearLabelsUserDetails()
        lblUserIDValue.Text = String.Empty
        lblFirstNameValue.Text = String.Empty
        lblLastNameValue.Text = String.Empty
        lblGenderValue.Text = String.Empty
        lblContactNumberValue.Text = String.Empty
        lblAddressValue.Text = String.Empty
        lblPositionValue.Text = String.Empty
        lblUsernameValue.Text = String.Empty
        lblLaboratoryValue.Text = String.Empty
        lblAccessCodeValue.Text = String.Empty
    End Sub

    Private Sub ClearUserDetails()
        txtNewFirstName.Clear()
        txtNewLastName.Clear()
        txtNewContactNumber.Clear()
        txtNewAddress.Clear()
        txtNewUsername.Clear()
        txtNewAccessCode.Text = ""
        cmbNewUserGender.SelectedItem = Nothing
        cmbNewUserSpecialization.Text = ""
        cmbNewUserClinic.SelectedItem = Nothing
    End Sub


    Private Sub LoadLaboratoryNames()
        Try
            cmbNewUserClinic.Items.Clear()

            Dim laboratoryNames As DataTable = GetAllLaboratories()

            If laboratoryNames IsNot Nothing AndAlso laboratoryNames.Rows.Count > 0 Then
                For Each row As DataRow In laboratoryNames.Rows
                    Dim laboratoryName As String = row("LaboratoryName").ToString()

                    cmbNewUserClinic.Items.Add(laboratoryName)
                Next
            Else
                cmbNewUserClinic.Items.Add("No laboratories found.")
            End If
        Catch ex As Exception
            Console.WriteLine($"Error loading laboratory names: {ex.Message}")
        End Try
    End Sub

    Private Sub cmbNewUserClinic_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbNewUserClinic.SelectedIndexChanged
        Try
            If cmbNewUserClinic.SelectedIndex <> -1 Then
                Dim selectedLaboratoryName As String = cmbNewUserClinic.SelectedItem.ToString()

                Dim accessCode As String = GetLaboratoryAccessCodeByLaboratoryName(selectedLaboratoryName)

                txtNewAccessCode.Text = accessCode
            End If
        Catch ex As Exception
            Console.WriteLine($"Error handling laboratory selection: {ex.Message}")
        End Try
    End Sub


End Class