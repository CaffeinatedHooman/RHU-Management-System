Imports MySql.Data.MySqlClient

Module NurseFunctions
    Public Function AddNurse(firstName As String, lastName As String, gender As String, contactNumber As String, address As String, specialist As String, username As String, clinic As String, accessCode As String) As String
        Try
            If IsNurseNameExists(firstName, lastName) Then
                Return "Nurse with the same name already exists."
            End If

            If IsUsernameExistsNurse(username) Then
                Return "Username already exists. Please choose a different username."
            End If

            Dim nurseID As String = GenerateNurseID()
            Dim sql As String = "INSERT INTO Nurses (NurseID, FirstName, LastName, Gender, ContactNumber, Address, Specialization, Username, Clinic, AccessCode) VALUES (@NurseID, @FirstName, @LastName, @Gender, @ContactNumber, @Address, @Specialization, @Username, @Clinic, @AccessCode)"

            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@NurseID", nurseID),
            New MySqlParameter("@FirstName", firstName),
            New MySqlParameter("@LastName", lastName),
            New MySqlParameter("@Gender", gender),
            New MySqlParameter("@ContactNumber", contactNumber),
            New MySqlParameter("@Address", address),
            New MySqlParameter("@Specialization", specialist),
            New MySqlParameter("@Username", username),
            New MySqlParameter("@Clinic", clinic),
            New MySqlParameter("@AccessCode", accessCode)
        }

            ExecuteNonQuery(sql, parameters)

            Return "Nurse added successfully!"
        Catch ex As Exception
            Console.WriteLine($"Error adding nurse record: {ex.Message}")
            Return $"An error occurred while adding the nurse record. Please contact support. {ex.Message}"
        End Try
    End Function


    Public Function IsNurseNameExists(firstName As String, lastName As String) As Boolean
        Try
            Dim sql As String = "SELECT COUNT(*) FROM Nurses WHERE FirstName = @FirstName AND LastName = @LastName"
            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@FirstName", firstName),
            New MySqlParameter("@LastName", lastName)
        }

            Dim result As Object = ExecuteScalar(sql, parameters)
            Dim count As Integer = If(result IsNot Nothing AndAlso Not IsDBNull(result), Convert.ToInt32(result), 0)

            Return count > 0
        Catch ex As Exception
            Console.WriteLine($"Error checking if nurse name exists: {ex.Message}")
            Return False
        End Try
    End Function


    Public Function IsUsernameExistsNurse(username As String) As Boolean
        Dim sql As String = "SELECT COUNT(*) FROM Nurses WHERE Username = @Username"
        Dim parameters As New List(Of MySqlParameter) From {
        New MySqlParameter("@Username", username)
    }

        Dim count As Integer = Convert.ToInt32(ExecuteScalar(sql, parameters))

        Return count > 0
    End Function

    Public Function UpdateNurse(nurseID As String, firstName As String, lastName As String, gender As String, contactNumber As String, address As String, specialist As String, username As String, clinic As String, accessCode As String) As String
        Try
            If IsUsernameExistsForUpdate(username, nurseID) Then
                Return "Username already exists. Please choose a different username."
            End If

            Dim sql As String = "UPDATE Nurses SET FirstName = @FirstName, LastName = @LastName, Gender = @Gender, ContactNumber = @ContactNumber, " &
                            "Address = @Address, Specialization = @Specialization, Username = @Username, Clinic = @Clinic, AccessCode = @AccessCode " &
                            "WHERE NurseID = @NurseID"

            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@NurseID", nurseID),
            New MySqlParameter("@FirstName", firstName),
            New MySqlParameter("@LastName", lastName),
            New MySqlParameter("@Gender", gender),
            New MySqlParameter("@ContactNumber", contactNumber),
            New MySqlParameter("@Address", address),
            New MySqlParameter("@Specialization", specialist),
            New MySqlParameter("@Username", username),
            New MySqlParameter("@Clinic", clinic),
            New MySqlParameter("@AccessCode", accessCode)
        }

            ExecuteNonQuery(sql, parameters)

            Return "Nurse updated successfully!"
        Catch ex As Exception
            Console.WriteLine($"Error updating nurse record: {ex.Message}")
            Return $"An error occurred while updating the nurse record. Please contact support. {ex.Message}"
        End Try
    End Function




    Public Function GetNurseByID(nurseID As String) As DataTable
        Try
            Dim sql As String = "SELECT * FROM Nurses WHERE NurseID = @NurseID"

            Dim parameters As New List(Of MySqlParameter) From {
                New MySqlParameter("@NurseID", nurseID)
            }

            Return ExecuteReader(sql, parameters)
        Catch ex As Exception
            Console.WriteLine($"Error retrieving nurse record: {ex.Message}")
            MessageBox.Show("An error occurred while retrieving the nurse record. Please contact support.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return New DataTable()
        End Try
    End Function

    Public Function GenerateNurseID() As String
        Dim sql As String = "SELECT MAX(id) FROM nurses"
        Dim maxID As Object = ExecuteScalar(sql)

        Dim counter As Integer = 1
        If maxID IsNot Nothing AndAlso Not DBNull.Value.Equals(maxID) Then
            counter = Convert.ToInt32(maxID) + 1
        End If

        Dim formattedID As String = "NRS" & counter.ToString("D2")
        Return formattedID
    End Function


    Public Function GetNurseDetailsByName(firstName As String, lastName As String) As DataTable
        Try
            Dim sql As String = "SELECT NurseID, FirstName, LastName, Gender, ContactNumber, Address, Specialization, Username, Clinic, AccessCode " &
                            "FROM Nurses " &
                            "WHERE FirstName = @FirstName AND LastName = @LastName"

            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@FirstName", firstName),
            New MySqlParameter("@LastName", lastName)
        }

            Return ExecuteQuery(sql, parameters)
        Catch ex As Exception
            Console.WriteLine($"Error getting nurse details by name: {ex.Message}")
            Return Nothing
        End Try
    End Function

    Public Function GetAllNurseNames() As DataTable
        Try
            Dim sql As String = "SELECT NurseID, CONCAT(FirstName, ' ', LastName) AS NurseName FROM Nurses"
            Return ExecuteQuery(sql, Nothing)
        Catch ex As Exception
            Console.WriteLine($"Error getting all nurse names: {ex.Message}")
            Return Nothing
        End Try
    End Function


    Private Function IsUsernameExistsForUpdate(username As String, nurseID As String) As Boolean
        Try
            Dim sql As String = "SELECT COUNT(*) FROM Nurses WHERE Username = @Username AND NurseID <> @NurseID"
            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@Username", username),
            New MySqlParameter("@NurseID", nurseID)
        }

            Dim count As Integer = Convert.ToInt32(ExecuteScalar(sql, parameters))

            Return count > 0
        Catch ex As Exception
            Console.WriteLine($"Error checking username existence for update: {ex.Message}")
            Return True
        End Try
    End Function


    Public Function GetNurseDetailsByID(nurseID As String) As DataTable
        Try
            Dim sql As String = "SELECT * FROM Nurses WHERE NurseID = @NurseID"
            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@NurseID", nurseID)
        }

            Return ExecuteQuery(sql, parameters)
        Catch ex As Exception
            Console.WriteLine($"Error getting nurse details by ID: {ex.Message}")
            Return Nothing
        End Try
    End Function


End Module
