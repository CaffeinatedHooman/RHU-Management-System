Imports MySql.Data.MySqlClient

Module ClinicFunction

    Public Function AddClinic(clinicName As String, accessCode As String) As String
        Try

            If IsAccessCodeUnique(accessCode) Then
                Dim sql As String = "INSERT INTO Clinic (ClinicName, AccessCode) VALUES (@ClinicName, @AccessCode)"
                Dim parameters As New List(Of MySqlParameter) From {
                New MySqlParameter("@ClinicName", clinicName),
                New MySqlParameter("@AccessCode", accessCode)
            }
                ExecuteNonQuery(sql, parameters)
                Return "Clinic added successfully!"
            Else
                Return "Access code is already in use. Please choose a different one."
            End If
        Catch ex As Exception
            Console.WriteLine($"Error adding clinic: {ex.Message}")
            Return $"An error occurred: {ex.Message}"
        End Try
    End Function

    Public Function IsAccessCodeUnique(accessCode As String) As Boolean
        Try
            Dim sql As String = "SELECT COUNT(*) FROM Clinic WHERE AccessCode = @AccessCode"
            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@AccessCode", accessCode)
        }
            Dim count As Integer = Convert.ToInt32(ExecuteScalar(sql, parameters))
            Return count = 0
        Catch ex As Exception
            Console.WriteLine($"Error checking access code uniqueness: {ex.Message}")
            Return False
        End Try
    End Function

    Public Function GetAllClinics() As DataTable
        Try
            Dim sql As String = "SELECT ClinicName FROM Clinic"
            Return ExecuteQuery(sql, Nothing)
        Catch ex As Exception
            Console.WriteLine($"Error getting all clinics: {ex.Message}")
            Return Nothing
        End Try
    End Function


    Public Function UpdateClinic(oldClinicName As String, newClinicName As String, newAccessCode As String, oldAccessCode As String) As String
        Try
            Dim sql As String = "UPDATE Clinic SET ClinicName = @NewClinicName, AccessCode = @NewAccessCode WHERE ClinicName = @OldClinicName AND AccessCode = @OldAccessCode"
            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@NewClinicName", newClinicName),
            New MySqlParameter("@NewAccessCode", newAccessCode),
            New MySqlParameter("@OldClinicName", oldClinicName),
            New MySqlParameter("@OldAccessCode", oldAccessCode)
        }

            ExecuteNonQuery(sql, parameters)

            Return "Clinic updated successfully!"
        Catch ex As Exception
            Console.WriteLine($"Error updating clinic: {ex.Message}")
            Return $"An error occurred: {ex.Message}"
        End Try
    End Function



    Public Function GetClinicInfo(clinicName As String) As DataTable
        Try
            Dim sql As String = "SELECT * FROM Clinic WHERE ClinicName = @ClinicName"
            Dim parameters As New List(Of MySqlParameter) From {
                New MySqlParameter("@ClinicName", clinicName)
            }
            Return ExecuteQuery(sql, parameters)
        Catch ex As Exception
            Console.WriteLine($"Error getting clinic information: {ex.Message}")
            Return Nothing
        End Try
    End Function

    Public Function GetAccessCode(clinicName As String) As String
        Try
            Dim sql As String = "SELECT AccessCode FROM Clinic WHERE ClinicName = @ClinicName"
            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@ClinicName", clinicName)
        }

            Dim accessCode As Object = ExecuteScalar(sql, parameters)

            If accessCode IsNot Nothing AndAlso Not DBNull.Value.Equals(accessCode) Then
                Return accessCode.ToString()
            Else
                Return String.Empty
            End If
        Catch ex As Exception
            Console.WriteLine($"Error getting access code: {ex.Message}")
            Return String.Empty
        End Try
    End Function

    Public Function DeleteClinic(clinicName As String) As String
        Try
            If Not IsClinicExists(clinicName) Then
                Return "Clinic does not exist."
            End If

            Dim sql As String = "DELETE FROM Clinic WHERE ClinicName = @ClinicName"
            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@ClinicName", clinicName)
        }

            ExecuteNonQuery(sql, parameters)

            Return "Clinic deleted successfully!"
        Catch ex As Exception
            Console.WriteLine($"Error deleting clinic: {ex.Message}")
            Return $"An error occurred: {ex.Message}"
        End Try
    End Function

    Public Function IsClinicExists(clinicName As String) As Boolean
        Try
            Dim sql As String = "SELECT COUNT(*) FROM Clinic WHERE ClinicName = @ClinicName"
            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@ClinicName", clinicName)
        }

            Dim count As Integer = Convert.ToInt32(ExecuteScalar(sql, parameters))

            Return count > 0
        Catch ex As Exception
            Console.WriteLine($"Error checking if clinic exists: {ex.Message}")
            Return False
        End Try
    End Function

    Public Function IsClinicNameUnique(clinicName As String) As Boolean
        Try
            Dim sql As String = "SELECT COUNT(*) FROM Clinics WHERE ClinicName = @ClinicName"
            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@ClinicName", clinicName)
        }
            Dim count As Integer = Convert.ToInt32(ExecuteScalar(sql, parameters))

            Return count = 0
        Catch ex As Exception
            MessageBox.Show($"Error checking clinic name uniqueness: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function


End Module
