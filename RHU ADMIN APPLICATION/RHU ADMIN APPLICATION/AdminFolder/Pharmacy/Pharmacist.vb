Imports MySql.Data.MySqlClient
Public Class Pharmacist
    Private Sub Pharmacist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayNextPharmacistID()
    End Sub

    Public Sub AddPharmacist(firstName As String, lastName As String, gender As String, contactNumber As String, address As String, position As String, username As String, password As String)
        ' Check if the pharmacist already exists based on first name, last name, and username
        If PharmacistExists(firstName, lastName, username) Then
            MessageBox.Show("Pharmacist with the same first name, last name, and username already exists.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return ' Exit the method without proceeding
        End If

        Dim sql As String = "INSERT INTO Pharmacist (FirstName, LastName, Gender, ContactNumber, Address, Position, Username, Password) " &
                        "VALUES (@FirstName, @LastName, @Gender, @ContactNumber, @Address, @Position, @Username, @Password)"

        Dim parameters As New List(Of MySqlParameter) From {
        New MySqlParameter("@FirstName", firstName),
        New MySqlParameter("@LastName", lastName),
        New MySqlParameter("@Gender", gender),
        New MySqlParameter("@ContactNumber", contactNumber),
        New MySqlParameter("@Address", address),
        New MySqlParameter("@Position", position),
        New MySqlParameter("@Username", username),
        New MySqlParameter("@Password", password)
    }

        Try
            ExecuteNonQuery(sql, parameters)
            MessageBox.Show("Pharmacist added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Console.WriteLine("Pharmacist added successfully.")
        Catch ex As Exception
            Console.WriteLine($"Error adding pharmacist: {ex.Message}")
        End Try
    End Sub

    Private Function PharmacistExists(firstName As String, lastName As String, username As String) As Boolean
        Dim sql As String = "SELECT COUNT(*) FROM Pharmacist WHERE FirstName = @FirstName AND LastName = @LastName AND Username = @Username"
        Dim parameters As New List(Of MySqlParameter) From {
        New MySqlParameter("@FirstName", firstName),
        New MySqlParameter("@LastName", lastName),
        New MySqlParameter("@Username", username)
    }

        Try
            Dim count As Integer = Convert.ToInt32(ExecuteScalar(sql, parameters))
            Return count > 0 ' Return true if count is greater than 0, indicating that the pharmacist exists
        Catch ex As Exception
            Console.WriteLine($"Error checking pharmacist existence: {ex.Message}")
            Return False ' Return false in case of an error or if pharmacist doesn't exist
        End Try
    End Function


    Private Sub btnAddPharmacist_Click(sender As Object, e As EventArgs) Handles btnAddPharmacist.Click
        ' Check if any required fields are empty
        If String.IsNullOrWhiteSpace(txtFirstName.Text) OrElse
           String.IsNullOrWhiteSpace(txtLastName.Text) OrElse
           String.IsNullOrWhiteSpace(cboGender.Text) OrElse
           String.IsNullOrWhiteSpace(txtContactNumber.Text) OrElse
           String.IsNullOrWhiteSpace(txtAddress.Text) OrElse
           String.IsNullOrWhiteSpace(txtPosition.Text) OrElse
           String.IsNullOrWhiteSpace(txtUsername.Text) OrElse
           String.IsNullOrEmpty(txtPassword.Text) Then

            MessageBox.Show("Please fill in all required fields.", "Incomplete Data", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return ' Exit the method without proceeding
        End If

        ' All required fields are filled, proceed with adding the pharmacist
        Dim firstName As String = txtFirstName.Text.Trim()
        Dim lastName As String = txtLastName.Text.Trim()
        Dim gender As String = cboGender.Text.Trim()
        Dim contactNumber As String = txtContactNumber.Text.Trim()
        Dim address As String = txtAddress.Text.Trim()
        Dim position As String = txtPosition.Text.Trim()
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text

        AddPharmacist(firstName, lastName, gender, contactNumber, address, position, username, password)

        ClearTextBoxes()
    End Sub


    Private Sub ClearTextBoxes()
        txtFirstName.Clear()
        txtLastName.Clear()
        cboGender.SelectedIndex = -1
        txtContactNumber.Clear()
        txtAddress.Clear()
        txtPosition.Clear()
        txtUsername.Clear()
        txtPassword.Clear()
    End Sub

    Private Function GetNextPharmacistID() As Integer
        Dim nextID As Integer = -1

        Try
            Dim sqlMaxID As String = "SELECT MAX(ID) FROM pharmacist"
            Dim maxIDResult As Object = ExecuteScalar(sqlMaxID)

            If maxIDResult IsNot Nothing AndAlso Not IsDBNull(maxIDResult) Then
                Dim maxID As Integer = Convert.ToInt32(maxIDResult)
                nextID = maxID + 1
            End If
        Catch ex As Exception
            Console.WriteLine($"Error retrieving next Pharmacist ID: {ex.Message}")
        End Try

        Return nextID
    End Function

    Private Sub DisplayNextPharmacistID()
        Dim nextID As Integer = GetNextPharmacistID()

        If nextID <> -1 Then
            txtPRCID.Text = nextID.ToString()
        Else
            txtPRCID.Text = "Error"
        End If
    End Sub


End Class