Imports MySql.Data.MySqlClient
Public Class InfoPharmacist
    Private Sub InfoPharmacist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayAllPharmacistNames()
    End Sub

    Private Sub DisplayAllPharmacistNames()
        Try
            ListBoxPharmacistNames.Items.Clear()

            Dim allPharmacistNamesTable As DataTable = GetAllPharmacistNames()

            If allPharmacistNamesTable IsNot Nothing AndAlso allPharmacistNamesTable.Rows.Count > 0 Then
                For Each row As DataRow In allPharmacistNamesTable.Rows
                    Dim pharmacistID As String = row("ID").ToString()
                    Dim fullName As String = $"{pharmacistID} - {row("FullName")}"
                    ListBoxPharmacistNames.Items.Add(fullName)
                Next
            Else
                ListBoxPharmacistNames.Items.Add("No pharmacists found.")
            End If
        Catch ex As Exception
            Console.WriteLine($"Error displaying all pharmacist names: {ex.Message}")
        End Try
    End Sub

    Private Function GetAllPharmacistNames() As DataTable
        Dim dataTable As New DataTable()

        Try
            Dim sql As String = "SELECT ID, CONCAT(FirstName, ' ', LastName) AS FullName FROM Pharmacist"
            dataTable = ExecuteQuery(sql, Nothing)
        Catch ex As Exception
            Console.WriteLine($"Error retrieving pharmacist names: {ex.Message}")
        End Try

        Return dataTable
    End Function

    Private Sub ListBoxPharmacistNames_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxPharmacistNames.SelectedIndexChanged
        Try
            If ListBoxPharmacistNames.SelectedIndex <> -1 Then
                Dim selectedFullName As String = ListBoxPharmacistNames.SelectedItem.ToString()
                Dim pharmacistID As String = selectedFullName.Split("-"c).FirstOrDefault().Trim()

                Dim pharmacistDetailsRow As DataRow = GetPharmacistDetailsByID(pharmacistID)
                DisplayPharmacistDetails(pharmacistDetailsRow)
            End If
        Catch ex As Exception
            Console.WriteLine($"Error handling pharmacist name selection: {ex.Message}")
        End Try
    End Sub

    Private Sub DisplayPharmacistDetails(pharmacistDetailsRow As DataRow)
        Try
            If pharmacistDetailsRow IsNot Nothing Then
                txtPharmacistID.Text = pharmacistDetailsRow("ID").ToString()
                txtFirstName.Text = pharmacistDetailsRow("FirstName").ToString()
                txtLastName.Text = pharmacistDetailsRow("LastName").ToString()
                cboGender.Text = pharmacistDetailsRow("Gender").ToString()
                txtContactNumber.Text = pharmacistDetailsRow("ContactNumber").ToString()
                txtAddress.Text = pharmacistDetailsRow("Address").ToString()
                txtPosition.Text = pharmacistDetailsRow("Position").ToString()
                txtUsername.Text = pharmacistDetailsRow("Username").ToString()
                txtPassword.Text = pharmacistDetailsRow("Password").ToString()
            Else
                MessageBox.Show("No details found for the selected pharmacist.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            Console.WriteLine($"Error displaying pharmacist details: {ex.Message}")
        End Try
    End Sub





    Private Function GetPharmacistDetailsByID(ID As String) As DataRow
        Dim pharmacistDetailsRow As DataRow = Nothing

        Try
            Dim sql As String = "SELECT * FROM Pharmacist WHERE ID = @ID"
            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@ID", ID)
        }

            Dim resultTable As DataTable = ExecuteQuery(sql, parameters)

            If resultTable IsNot Nothing AndAlso resultTable.Rows.Count > 0 Then
                pharmacistDetailsRow = resultTable.Rows(0)
            End If
        Catch ex As Exception
            Console.WriteLine($"Error retrieving pharmacist details by ID: {ex.Message}")
        End Try

        Return pharmacistDetailsRow
    End Function

    Private Sub ClearPharmacistDetails()
        txtPharmacistID.Text = ""
        txtFirstName.Clear()
        txtLastName.Clear()
        cboGender.SelectedIndex = -1
        txtContactNumber.Clear()
        txtAddress.Clear()
        txtPosition.Clear()
        txtUsername.Clear()
        txtPassword.Clear()
    End Sub


    Private Sub UpdatePharmacistDetails()
        Try
            Dim pharmacistID As String = txtPharmacistID.Text.Trim()
            Dim firstName As String = txtFirstName.Text.Trim()
            Dim lastName As String = txtLastName.Text.Trim()
            Dim gender As String = cboGender.Text.Trim()
            Dim contactNumber As String = txtContactNumber.Text.Trim()
            Dim address As String = txtAddress.Text.Trim()
            Dim position As String = txtPosition.Text.Trim()
            Dim username As String = txtUsername.Text.Trim()
            Dim password As String = txtPassword.Text

            Dim sql As String = "UPDATE Pharmacist SET FirstName = @FirstName, LastName = @LastName, Gender = @Gender, ContactNumber = @ContactNumber, Address = @Address, Position = @Position, Username = @Username, Password = @Password WHERE ID = @PharmacistID"

            Dim parameters As New List(Of MySqlParameter) From {
                New MySqlParameter("@FirstName", firstName),
                New MySqlParameter("@LastName", lastName),
                New MySqlParameter("@Gender", gender),
                New MySqlParameter("@ContactNumber", contactNumber),
                New MySqlParameter("@Address", address),
                New MySqlParameter("@Position", position),
                New MySqlParameter("@Username", username),
                New MySqlParameter("@Password", password),
                New MySqlParameter("@PharmacistID", pharmacistID)
            }

            Dim rowsAffected As Integer = ExecuteNonQuery(sql, parameters)

            If rowsAffected > 0 Then
                MessageBox.Show("Pharmacist details updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ClearPharmacistDetails()
            Else
                MessageBox.Show("Failed to update pharmacist details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ClearPharmacistDetails()
            End If
        Catch ex As Exception
            Console.WriteLine($"Error updating pharmacist details: {ex.Message}")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        UpdatePharmacistDetails()
    End Sub
End Class