Imports MySql.Data.MySqlClient
Module LabaratoryFunctions
    Public Function AddLaboratoryUser(firstName As String, lastName As String, gender As String, contactNumber As String, address As String, position As String, username As String, laboratory As String, accessCode As String) As Boolean
        Try
            Dim sql As String = "INSERT INTO LaboratoryUsers (FirstName, LastName, Gender, ContactNumber, Address, Position, Username, AccessCode, Laboratory) " &
                           "VALUES (@FirstName, @LastName, @Gender, @ContactNumber, @Address, @Position, @Username, @AccessCode, @Laboratory)"
            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@FirstName", firstName),
            New MySqlParameter("@LastName", lastName),
            New MySqlParameter("@Gender", gender),
            New MySqlParameter("@ContactNumber", contactNumber),
            New MySqlParameter("@Address", address),
            New MySqlParameter("@Position", position),
            New MySqlParameter("@Username", username),
            New MySqlParameter("@AccessCode", accessCode),
            New MySqlParameter("@Laboratory", laboratory)
        }

            ExecuteNonQuery(sql, parameters)

            Return True
        Catch ex As Exception
            Console.WriteLine($"Error adding laboratory user record: {ex.Message}")
            MessageBox.Show("An error occurred while adding the laboratory user record. Please contact support.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function




    Public Function IsLabUserExists(firstName As String, lastName As String) As Boolean
        Try
            Dim sql As String = "SELECT COUNT(*) FROM LaboratoryUsers WHERE FirstName = @FirstName AND LastName = @LastName"
            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@FirstName", firstName),
            New MySqlParameter("@LastName", lastName)
        }

            Dim result As Object = ExecuteScalar(sql, parameters)
            Dim count As Integer = If(result IsNot Nothing AndAlso Not IsDBNull(result), Convert.ToInt32(result), 0)

            Return count > 0
        Catch ex As Exception
            Console.WriteLine($"Error checking if laboratory user exists: {ex.Message}")
            Return False
        End Try
    End Function

    Public Function IsLaboratoryUserNameExists(firstName As String, lastName As String) As Boolean
        Try
            Dim sql As String = "SELECT COUNT(*) FROM LaboratoryUsers WHERE FirstName = @FirstName AND LastName = @LastName"
            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@FirstName", firstName),
            New MySqlParameter("@LastName", lastName)
        }

            Dim result As Object = ExecuteScalar(sql, parameters)
            Dim count As Integer = If(result IsNot Nothing AndAlso Not IsDBNull(result), Convert.ToInt32(result), 0)

            Return count > 0
        Catch ex As Exception
            Console.WriteLine($"Error checking if laboratory user name exists: {ex.Message}")
            Return False
        End Try
    End Function

    Private Function IsLaboratoryUserExists(firstName As String, lastName As String) As Boolean
        Dim sql As String = "SELECT COUNT(*) FROM LaboratoryUsers WHERE FirstName = @FirstName AND LastName = @LastName"
        Dim parameters As New List(Of MySqlParameter) From {
        New MySqlParameter("@FirstName", firstName),
        New MySqlParameter("@LastName", lastName)
    }

        Dim count As Integer = ExecuteScalar(sql, parameters)

        Return count > 0
    End Function

    Public Function IsUsernameExistsLAB(username As String) As Boolean
        Dim sql As String = "SELECT COUNT(*) FROM LaboratoryUsers WHERE Username = @Username"
        Dim parameters As New List(Of MySqlParameter) From {
        New MySqlParameter("@Username", username)
    }

        Dim count As Integer = Convert.ToInt32(ExecuteScalar(sql, parameters))

        Return count > 0
    End Function

    Private Function IsUsernameExists(username As String, currentLaboratoryUserID As String) As Boolean
        Dim sql As String = "SELECT COUNT(*) FROM LaboratoryUsers WHERE Username = @Username AND LaboratoryUserID <> @CurrentLaboratoryUserID"
        Dim parameters As New List(Of MySqlParameter) From {
        New MySqlParameter("@Username", username),
        New MySqlParameter("@CurrentLaboratoryUserID", currentLaboratoryUserID)
    }

        Dim count As Integer = Convert.ToInt32(ExecuteScalar(sql, parameters))

        Return count > 0
    End Function


    Public Function UpdateLaboratoryUser(laboratoryUserID As String, firstName As String, lastName As String, gender As String, contactNumber As String, address As String, username As String, accessCode As String) As String
        Try
            If IsUsernameExists(username, laboratoryUserID) Then
                Return "Username already exists. Please choose a different username."
            End If

            Dim sql As String = "UPDATE LaboratoryUsers SET FirstName = @FirstName, LastName = @LastName, Gender = @Gender, ContactNumber = @ContactNumber, " &
                    "Address = @Address, Username = @Username, AccessCode = @AccessCode " &
                    "WHERE LaboratoryUserID = @LaboratoryUserID"

            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@LaboratoryUserID", laboratoryUserID),
            New MySqlParameter("@FirstName", firstName),
            New MySqlParameter("@LastName", lastName),
            New MySqlParameter("@Gender", gender),
            New MySqlParameter("@ContactNumber", contactNumber),
            New MySqlParameter("@Address", address),
            New MySqlParameter("@Username", username),
            New MySqlParameter("@AccessCode", accessCode)
        }

            ExecuteNonQuery(sql, parameters)

            Return "Laboratory user updated successfully!"
        Catch ex As Exception
            Console.WriteLine($"Error updating laboratory user record: {ex.Message}")
            Return $"An error occurred while updating the laboratory user record. Please contact support. {ex.Message}"
        End Try
    End Function

    Public Function SearchLaboratoryUser(laboratoryUserID As String) As DataTable
        Try
            Dim sql As String = "SELECT * FROM LaboratoryUsers WHERE LaboratoryUserID = @LaboratoryUserID"

            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@LaboratoryUserID", laboratoryUserID)
        }

            Return ExecuteQuery(sql, parameters)
        Catch ex As Exception
            Console.WriteLine($"Error searching for laboratory user: {ex.Message}")
            MessageBox.Show("An error occurred while searching for the laboratory user. Please contact support.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function


    Public Function GetLaboratoryAccessCode(laboratoryName As String) As String
        Try
            Dim sql As String = "SELECT AccessCode FROM Laboratories WHERE LaboratoryName = @LaboratoryName"
            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@LaboratoryName", laboratoryName)
        }

            Dim result As Object = ExecuteScalar(sql, parameters)

            If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                Return result.ToString()
            Else
                Return "Access code not found."
            End If
        Catch ex As Exception
            Console.WriteLine($"Error retrieving laboratory access code: {ex.Message}")
            MessageBox.Show("An error occurred while retrieving laboratory access code. Please contact support.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return "Error retrieving access code."
        End Try
    End Function

    Public Function GetLaboratoryUserDetailsByName(firstName As String, lastName As String) As DataTable
        Try
            Dim sql As String = "SELECT LaboratoryUserID, FirstName, LastName, Gender, ContactNumber, Address, Username, AccessCode " &
                    "FROM LaboratoryUsers " &
                    "WHERE FirstName = @FirstName AND LastName = @LastName"

            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@FirstName", firstName),
            New MySqlParameter("@LastName", lastName)
        }

            Return ExecuteQuery(sql, parameters)
        Catch ex As Exception
            Console.WriteLine($"Error getting laboratory user details by name: {ex.Message}")
            Return Nothing
        End Try
    End Function

    Public Function GetAllLaboratoryUserNames() As DataTable
        Try
            Dim sql As String = "SELECT LaboratoryUserID, CONCAT(FirstName, ' ', LastName) AS FullName FROM LaboratoryUsers"
            Return ExecuteQuery(sql, Nothing)
        Catch ex As Exception
            Console.WriteLine($"Error getting all laboratory user names: {ex.Message}")
            Return Nothing
        End Try
    End Function

    Public Function GetLaboratoryUserDetailsByID(laboratoryUserID As String) As DataTable
        Try
            Dim sql As String = "SELECT * FROM LaboratoryUsers WHERE LaboratoryUserID = @LaboratoryUserID"
            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@LaboratoryUserID", laboratoryUserID)
        }

            Return ExecuteQuery(sql, parameters)
        Catch ex As Exception
            Console.WriteLine($"Error getting laboratory user details by ID: {ex.Message}")
            Return Nothing
        End Try
    End Function

    Public Function GetAllLaboratories() As DataTable
        Try
            Dim sql As String = "SELECT * FROM Laboratories"
            Return ExecuteQuery(sql, Nothing)
        Catch ex As Exception
            Console.WriteLine($"Error retrieving all laboratories: {ex.Message}")
            Return Nothing
        End Try
    End Function

    Public Function AddLaboratory(laboratoryName As String, accessCode As String) As String
        Try
            ' Check if the laboratory name already exists
            If IsLaboratoryNameExists(laboratoryName) Then
                Return "Laboratory with the same name already exists."
            End If

            ' Insert the new laboratory into the database
            Dim sql As String = "INSERT INTO Laboratories (LaboratoryName, AccessCode) VALUES (@LaboratoryName, @AccessCode)"
            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@LaboratoryName", laboratoryName),
            New MySqlParameter("@AccessCode", accessCode)
        }
            ExecuteNonQuery(sql, parameters)

            Return "Laboratory added successfully!"
        Catch ex As Exception
            Console.WriteLine($"Error adding laboratory: {ex.Message}")
            Return $"An error occurred while adding the laboratory: {ex.Message}"
        End Try
    End Function

    Public Function IsLaboratoryNameExists(laboratoryName As String) As Boolean
        Try
            Dim sql As String = "SELECT COUNT(*) FROM Laboratories WHERE LaboratoryName = @LaboratoryName"
            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@LaboratoryName", laboratoryName)
        }
            Dim count As Integer = Convert.ToInt32(ExecuteScalar(sql, parameters))
            Return count > 0
        Catch ex As Exception
            Console.WriteLine($"Error checking if laboratory name exists: {ex.Message}")
            Return False
        End Try
    End Function

    Public Function DeleteLaboratory(laboratoryName As String) As String
        Try
            If Not IsLaboratoryNameExists(laboratoryName) Then
                Return $"Laboratory '{laboratoryName}' does not exist."
            End If

            Dim sql As String = "DELETE FROM Laboratories WHERE LaboratoryName = @LaboratoryName"
            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@LaboratoryName", laboratoryName)
        }

            ExecuteNonQuery(sql, parameters)

            Return $"Laboratory '{laboratoryName}' deleted successfully!"
        Catch ex As Exception
            Console.WriteLine($"Error deleting laboratory: {ex.Message}")
            Return $"An error occurred while deleting the laboratory. Please contact support. {ex.Message}"
        End Try
    End Function

    Public Function IsLaboratoryAccessCodeUnique(accessCode As String) As Boolean
        Try
            Dim sql As String = "SELECT COUNT(*) FROM Laboratories WHERE AccessCode = @AccessCode"
            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@AccessCode", accessCode)
        }
            Dim count As Integer = Convert.ToInt32(ExecuteScalar(sql, parameters))

            Return count = 0
        Catch ex As Exception
            Console.WriteLine($"Error checking laboratory access code uniqueness: {ex.Message}")
            Return False
        End Try
    End Function

    Public Function UpdateLaboratory(oldLaboratoryName As String, newLaboratoryName As String, newAccessCode As String) As String
        Try
            If Not IsLaboratoryNameExists(oldLaboratoryName) Then
                Return $"Laboratory '{oldLaboratoryName}' does not exist."
            End If

            If IsLaboratoryNameExists(newLaboratoryName) AndAlso newLaboratoryName <> oldLaboratoryName Then
                Return $"Laboratory name '{newLaboratoryName}' already exists. Please choose a different name."
            End If

            Dim sql As String = "UPDATE Laboratories SET LaboratoryName = @NewLaboratoryName, AccessCode = @NewAccessCode WHERE LaboratoryName = @OldLaboratoryName"
            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@NewLaboratoryName", newLaboratoryName),
            New MySqlParameter("@NewAccessCode", newAccessCode),
            New MySqlParameter("@OldLaboratoryName", oldLaboratoryName)
        }

            ExecuteNonQuery(sql, parameters)

            Return "Laboratory updated successfully!"
        Catch ex As Exception
            Console.WriteLine($"Error updating laboratory: {ex.Message}")
            Return $"An error occurred while updating the laboratory. Please contact support. {ex.Message}"
        End Try
    End Function

    Public Function GetLaboratoryAccessCodeByLaboratoryName(laboratoryName As String) As String
        Try
            Dim accessCode As String = String.Empty
            Dim sql As String = "SELECT AccessCode FROM Laboratories WHERE LaboratoryName = @LaboratoryName"
            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@LaboratoryName", laboratoryName)
        }

            Dim result As Object = ExecuteScalar(sql, parameters)

            If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                accessCode = result.ToString()
            End If

            Return accessCode
        Catch ex As Exception
            Console.WriteLine($"Error retrieving access code for laboratory '{laboratoryName}': {ex.Message}")
            Return String.Empty
        End Try
    End Function

    Public Function GetLabUserDetailsByID(labUserID As String) As DataTable
        Try
            Dim sql As String = "SELECT * FROM LaboratoryUsers WHERE LaboratoryUserID = @LabUserID"
            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@LabUserID", labUserID)
        }

            Return ExecuteQuery(sql, parameters)
        Catch ex As Exception
            Console.WriteLine($"Error getting laboratory user details by ID: {ex.Message}")
            Return Nothing
        End Try
    End Function



End Module
