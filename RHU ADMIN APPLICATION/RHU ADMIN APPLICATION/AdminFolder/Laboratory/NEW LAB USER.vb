Public Class NEW_LAB_USER
    Private Sub NEW_LAB_USER_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadLaboratoryNames()
    End Sub

    Private Sub btnAddLabUser_Click(sender As Object, e As EventArgs) Handles btnAddLabUser.Click
        Try
            Dim firstName As String = txtLabUserFirstName.Text
            Dim lastName As String = txtLabUserLastName.Text
            Dim gender As String = If(cboLabUserGender.SelectedItem IsNot Nothing, cboLabUserGender.SelectedItem.ToString(), String.Empty)
            Dim contactNumber As String = txtLabUserContactNumber.Text
            Dim address As String = txtLabUserAddress.Text
            Dim position As String = LabUserPosition.Text
            Dim username As String = txtLabUserUsername.Text
            Dim accessCode As String = If(LaboratoryComboBox.SelectedItem IsNot Nothing, LaboratoryComboBox.SelectedItem.ToString(), String.Empty)
            Dim laboratory As String = txtLabUseraccessCodeLab.Text

            If String.IsNullOrWhiteSpace(firstName) OrElse String.IsNullOrWhiteSpace(lastName) OrElse
           String.IsNullOrWhiteSpace(gender) OrElse String.IsNullOrWhiteSpace(contactNumber) OrElse
           String.IsNullOrWhiteSpace(address) OrElse String.IsNullOrWhiteSpace(position) OrElse
           String.IsNullOrWhiteSpace(accessCode) OrElse String.IsNullOrWhiteSpace(laboratory) Then
                MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If IsLabUserExists(firstName, lastName) Then
                MessageBox.Show("Laboratory user already exists. Please ensure uniqueness.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If IsUsernameExists(username) Then
                MessageBox.Show("Username already exists. Please choose a different username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If AddLaboratoryUser(firstName, lastName, gender, contactNumber, address, position, username, accessCode, laboratory) Then
                MessageBox.Show("Lab user added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ClearLabUserFields()
            Else
                MessageBox.Show("Failed to add lab user. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub




    Private Sub ClearLabUserFields()
        txtLabUserFirstName.Clear()
        txtLabUserLastName.Clear()
        cboLabUserGender.SelectedIndex = -1
        txtLabUserContactNumber.Clear()
        txtLabUserAddress.Clear()
        LabUserPosition.Clear()
        txtLabUserUsername.Clear()
        LaboratoryComboBox.SelectedIndex = -1
        txtLabUseraccessCodeLab.Text = ""
    End Sub

    Private Sub LoadLaboratoryNames()
        Try
            LaboratoryComboBox.Items.Clear()

            Dim laboratoryNames As DataTable = GetAllLaboratories()

            If laboratoryNames IsNot Nothing AndAlso laboratoryNames.Rows.Count > 0 Then
                For Each row As DataRow In laboratoryNames.Rows
                    Dim laboratoryName As String = row("LaboratoryName").ToString()

                    LaboratoryComboBox.Items.Add(laboratoryName)
                Next
            Else
                LaboratoryComboBox.Items.Add("No laboratories found.")
            End If
        Catch ex As Exception
            Console.WriteLine($"Error loading laboratory names: {ex.Message}")
        End Try
    End Sub

    Private Sub LaboratoryComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LaboratoryComboBox.SelectedIndexChanged
        Try
            If LaboratoryComboBox.SelectedIndex <> -1 Then
                Dim selectedLaboratoryName As String = LaboratoryComboBox.SelectedItem.ToString()

                Dim accessCode As String = GetLaboratoryAccessCodeByLaboratoryName(selectedLaboratoryName)

                txtLabUseraccessCodeLab.Text = accessCode
            End If
        Catch ex As Exception
            Console.WriteLine($"Error handling laboratory selection: {ex.Message}")
        End Try
    End Sub


End Class