Imports MySql.Data.MySqlClient

Module DoctorFunctions

    Public Function AddDoctor(firstName As String, lastName As String, gender As String, contactNumber As String, address As String, specialization As String, username As String, clinic As String, accessCode As String) As Boolean
        Try
            If IsUsernameExists(username) Then
                MessageBox.Show("Username already exists. Please choose a different username.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            End If

            If IsDoctorExists(firstName, lastName) Then
                MessageBox.Show("Doctor with the same first name and last name already exists.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            End If

            Dim doctorID As String = GenerateDoctorID()
            Dim sql As String = "INSERT INTO Doctors (DoctorID, FirstName, LastName, Gender, ContactNumber, Address, Specialization, Username, Clinic, AccessCode) VALUES (@DoctorID, @FirstName, @LastName, @Gender, @ContactNumber, @Address, @Specialization, @Username, @Clinic, @AccessCode)"
            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@DoctorID", doctorID),
            New MySqlParameter("@FirstName", firstName),
            New MySqlParameter("@LastName", lastName),
            New MySqlParameter("@Gender", gender),
            New MySqlParameter("@ContactNumber", contactNumber),
            New MySqlParameter("@Address", address),
            New MySqlParameter("@Specialization", specialization),
            New MySqlParameter("@Username", username),
            New MySqlParameter("@Clinic", clinic),
            New MySqlParameter("@AccessCode", accessCode)
        }

            ExecuteNonQuery(sql, parameters)

            Return True
        Catch ex As Exception
            Console.WriteLine($"Error adding doctor record: {ex.Message}")
            MessageBox.Show("An error occurred while adding the doctor record. Please contact support.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function IsDoctorNameExists(firstName As String, lastName As String) As Boolean
        Try
            Dim sql As String = "SELECT COUNT(*) FROM Doctors WHERE FirstName = @FirstName AND LastName = @LastName"
            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@FirstName", firstName),
            New MySqlParameter("@LastName", lastName)
        }

            Dim result As Object = ExecuteScalar(sql, parameters)
            Dim count As Integer = If(result IsNot Nothing AndAlso Not IsDBNull(result), Convert.ToInt32(result), 0)

            Return count > 0
        Catch ex As Exception
            Console.WriteLine($"Error checking if doctor name exists: {ex.Message}")
            Return False
        End Try
    End Function


    Private Function IsDoctorExists(firstName As String, lastName As String) As Boolean
        Dim sql As String = "SELECT COUNT(*) FROM Doctors WHERE FirstName = @FirstName AND LastName = @LastName"
        Dim parameters As New List(Of MySqlParameter) From {
        New MySqlParameter("@FirstName", firstName),
        New MySqlParameter("@LastName", lastName)
    }

        Dim count As Integer = ExecuteScalar(sql, parameters)

        Return count > 0
    End Function


    Public Function IsUsernameExists(username As String) As Boolean
        Dim sql As String = "SELECT COUNT(*) FROM Doctors WHERE Username = @Username"
        Dim parameters As New List(Of MySqlParameter) From {
        New MySqlParameter("@Username", username)
    }

        Dim count As Integer = Convert.ToInt32(ExecuteScalar(sql, parameters))

        Return count > 0
    End Function

    Private Function IsUsernameExists(username As String, currentDoctorID As String) As Boolean
        Dim sql As String = "SELECT COUNT(*) FROM Doctors WHERE Username = @Username AND DoctorID <> @CurrentDoctorID"
        Dim parameters As New List(Of MySqlParameter) From {
    New MySqlParameter("@Username", username),
    New MySqlParameter("@CurrentDoctorID", currentDoctorID)
}

        Dim count As Integer = Convert.ToInt32(ExecuteScalar(sql, parameters))

        Return count > 0
    End Function


    Public Function UpdateDoctor(doctorID As String, firstName As String, lastName As String, gender As String, contactNumber As String, address As String, specialization As String, username As String, clinic As String, accessCode As String) As String
        Try
            If IsUsernameExists(username, doctorID) Then
                Return "Username already exists. Please choose a different username."
            End If

            Dim sql As String = "UPDATE Doctors SET FirstName = @FirstName, LastName = @LastName, Gender = @Gender, ContactNumber = @ContactNumber, " &
                        "Address = @Address, Specialization = @Specialization, Username = @Username, Clinic = @Clinic, AccessCode = @AccessCode " &
                        "WHERE DoctorID = @DoctorID"

            Dim parameters As New List(Of MySqlParameter) From {
        New MySqlParameter("@DoctorID", doctorID),
        New MySqlParameter("@FirstName", firstName),
        New MySqlParameter("@LastName", lastName),
        New MySqlParameter("@Gender", gender),
        New MySqlParameter("@ContactNumber", contactNumber),
        New MySqlParameter("@Address", address),
        New MySqlParameter("@Specialization", specialization),
        New MySqlParameter("@Username", username),
        New MySqlParameter("@Clinic", clinic),
        New MySqlParameter("@AccessCode", accessCode)
    }

            ExecuteNonQuery(sql, parameters)

            Return "Doctor updated successfully!"
        Catch ex As Exception
            Console.WriteLine($"Error updating doctor record: {ex.Message}")
            Return $"An error occurred while updating the doctor record. Please contact support. {ex.Message}"
        End Try
    End Function



    Public Function SearchDoctor(doctorID As String) As DataTable
        Try
            Dim sql As String = "SELECT * FROM Doctors WHERE DoctorID = @DoctorID"

            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@DoctorID", doctorID)
        }

            Return ExecuteQuery(sql, parameters)
        Catch ex As Exception
            Console.WriteLine($"Error searching for doctor: {ex.Message}")
            MessageBox.Show("An error occurred while searching for the doctor. Please contact support.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function

    Public Function GenerateDoctorID() As String
        Dim sql As String = "SELECT MAX(id) FROM doctors"
        Dim maxID As Object = ExecuteScalar(sql)

        Dim counter As Integer = 1
        If maxID IsNot Nothing AndAlso Not DBNull.Value.Equals(maxID) Then
            counter = Convert.ToInt32(maxID) + 1
        End If

        Dim formattedID As String = "DOC" & counter.ToString("D2")
        Return formattedID
    End Function



    Public Function GetClinicAccessCode(clinicName As String) As String
        Try
            Dim sql As String = "SELECT AccessCode FROM Clinic WHERE ClinicName = @ClinicName"
            Dim parameters As New List(Of MySqlParameter) From {
                New MySqlParameter("@ClinicName", clinicName)
            }

            Dim result As Object = ExecuteScalar(sql, parameters)

            If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                Return result.ToString()
            Else
                Return "Access code not found."
            End If
        Catch ex As Exception
            Console.WriteLine($"Error retrieving clinic access code: {ex.Message}")
            MessageBox.Show("An error occurred while retrieving clinic access code. Please contact support.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return "Error retrieving access code."
        End Try
    End Function








    Public Function GetDoctorDetailsByName(firstName As String, lastName As String) As DataTable
        Try
            Dim sql As String = "SELECT DoctorID, FirstName, LastName, Gender, ContactNumber, Address, Specialization, Username, Clinic, AccessCode " &
                        "FROM Doctors " &
                        "WHERE FirstName = @FirstName AND LastName = @LastName"

            Dim parameters As New List(Of MySqlParameter) From {
        New MySqlParameter("@FirstName", firstName),
        New MySqlParameter("@LastName", lastName)
    }

            Return ExecuteQuery(sql, parameters)
        Catch ex As Exception
            Console.WriteLine($"Error getting doctor details by name: {ex.Message}")
            Return Nothing
        End Try
    End Function

    Public Function GetAllDoctorNames() As DataTable
        Try
            Dim sql As String = "SELECT DoctorID, CONCAT(FirstName, ' ', LastName) AS DoctorName FROM Doctors"
            Return ExecuteQuery(sql, Nothing)
        Catch ex As Exception
            Console.WriteLine($"Error getting all doctor names: {ex.Message}")
            Return Nothing
        End Try
    End Function


    Public Function GetDoctorDetailsByID(doctorID As String) As DataTable
        Try
            Dim sql As String = "SELECT * FROM Doctors WHERE DoctorID = @DoctorID"
            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@DoctorID", doctorID)
        }

            Return ExecuteQuery(sql, parameters)
        Catch ex As Exception
            Console.WriteLine($"Error getting doctor details by ID: {ex.Message}")
            Return Nothing
        End Try
    End Function





End Module
