Public Class RegisteAdmin
    Private Sub btnAddAdmin_Click(sender As Object, e As EventArgs) Handles btnAddAdmin.Click
        Try
            Dim adminID As String = GenerateAdminID()

            If String.IsNullOrWhiteSpace(adminID) Then
                MessageBox.Show("Error generating Admin ID. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            Dim firstName As String = txtFirstName.Text
            Dim lastName As String = txtLastName.Text
            Dim gender As String = txtGender.Text
            Dim address As String = txtAddress.Text
            Dim username As String = txtUsername.Text
            Dim password As String = txtPassword.Text

            If String.IsNullOrWhiteSpace(firstName) OrElse String.IsNullOrWhiteSpace(lastName) _
                OrElse String.IsNullOrWhiteSpace(gender) OrElse String.IsNullOrWhiteSpace(address) _
                OrElse String.IsNullOrWhiteSpace(username) OrElse String.IsNullOrWhiteSpace(password) Then

                MessageBox.Show("Please fill in all fields.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            If RegisterAdmin(adminID, firstName, lastName, gender, address, username, password) Then
                MessageBox.Show("Admin registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Admin registration failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred during admin registration: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class