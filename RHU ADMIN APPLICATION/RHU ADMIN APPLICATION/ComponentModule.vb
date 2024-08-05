Imports MySql.Data.MySqlClient
Module ComponentModule
    Public Function SearchNurseSpecialization(specialization As String) As DataTable
        Try
            Dim sql As String = "SELECT * FROM NurseSpecializations WHERE Specialization = @Specialization"
            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@Specialization", specialization)
        }

            Return ExecuteQuery(sql, parameters)
        Catch ex As Exception
            Console.WriteLine($"Error searching nurse specialization: {ex.Message}")
            Return Nothing
        End Try
    End Function

    Public Function SearchDoctorSpecialization(specialization As String) As DataTable
        Try
            Dim sql As String = "SELECT * FROM DoctorSpecializations WHERE Specialization = @Specialization"
            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@Specialization", specialization)
        }

            Return ExecuteQuery(sql, parameters)
        Catch ex As Exception
            Console.WriteLine($"Error searching doctor specialization: {ex.Message}")
            Return Nothing
        End Try
    End Function

    Public Function SearchMaritalStatus(MaritalStatusName As String) As DataTable
        Try
            Dim sql As String = "SELECT * FROM MaritalStatus WHERE MaritalStatusName = @MaritalStatusName"
            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@MaritalStatusName", MaritalStatusName)
        }

            Return ExecuteQuery(sql, parameters)
        Catch ex As Exception
            Console.WriteLine($"Error searching marital status: {ex.Message}")
            Return Nothing
        End Try
    End Function
    Public Function GetAllNurseSpecializations() As DataTable
        Try
            Dim sql As String = "SELECT * FROM NurseSpecializations"
            Return ExecuteQuery(sql, Nothing)
        Catch ex As Exception
            Console.WriteLine($"Error retrieving nurse specializations: {ex.Message}")
            Return Nothing
        End Try
    End Function
    Public Function GetAllDoctorSpecializations() As DataTable
        Try
            Dim sql As String = "SELECT * FROM DoctorSpecializations"
            Return ExecuteQuery(sql, Nothing)
        Catch ex As Exception
            Console.WriteLine($"Error getting all doctor specializations: {ex.Message}")
            Return Nothing
        End Try
    End Function

    Public Function GetAllMaritalStatuses() As DataTable
        Try
            Dim sql As String = "SELECT * FROM MaritalStatus"
            Return ExecuteQuery(sql, Nothing)
        Catch ex As Exception
            Console.WriteLine($"Error getting all marital statuses: {ex.Message}")
            Return Nothing
        End Try
    End Function







    Private Function IsSpecializationUnique(specialization As String, tableName As String) As Boolean

        Dim sql As String = $"SELECT COUNT(*) FROM {tableName} WHERE Specialization = @Specialization"
        Dim parameters As New List(Of MySqlParameter) From {
        New MySqlParameter("@Specialization", specialization)
    }

        Dim count As Integer = Convert.ToInt32(ExecuteScalar(sql, parameters))


        Return count = 0
    End Function

    Private Function IsValueUnique(value As String, tableName As String, columnName As String) As Boolean

        Dim sql As String = $"SELECT COUNT(*) FROM {tableName} WHERE {columnName} = @{columnName}"
        Dim parameters As New List(Of MySqlParameter) From {
        New MySqlParameter($"@{columnName}", value)
    }

        Dim count As Integer = Convert.ToInt32(ExecuteScalar(sql, parameters))


        Return count = 0
    End Function











    Public Function GetClinicAccessCode(clinicName As String) As String
        Try
            Dim sql As String = "SELECT AccessCode FROM Clinic WHERE ClinicName = @ClinicName"
            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@ClinicName", clinicName)
        }

            Dim resultTable As DataTable = ExecuteQuery(sql, parameters)

            If resultTable IsNot Nothing AndAlso resultTable.Rows.Count > 0 Then
                Return resultTable.Rows(0)("AccessCode").ToString()
            Else
                Return "Access code not found."
            End If
        Catch ex As Exception
            Console.WriteLine($"Error getting clinic access code: {ex.Message}")
            Return $"An error occurred: {ex.Message}"
        End Try
    End Function

    Public Function GetAccessCodeByClinicName(clinicName As String) As String
        Try
            Dim sql As String = "SELECT AccessCode FROM Clinic WHERE ClinicName = @ClinicName"
            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@ClinicName", clinicName)
        }

            Dim resultTable As DataTable = ExecuteQuery(sql, parameters)

            If resultTable IsNot Nothing AndAlso resultTable.Rows.Count > 0 Then
                Return resultTable.Rows(0)("AccessCode").ToString()
            Else
                Return "Access code not found"
            End If
        Catch ex As Exception
            Console.WriteLine($"Error getting access code by clinic name: {ex.Message}")
            Return $"An error occurred: {ex.Message}"
        End Try
    End Function

    Public Function GetClinicNameByAccessCode(accessCode As String) As String
        Try
            Dim sql As String = "SELECT ClinicName FROM Clinic WHERE AccessCode = @AccessCode"
            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@AccessCode", accessCode)
        }

            Dim result As Object = ExecuteScalar(sql, parameters)

            If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                Return result.ToString()
            Else
                Return "Clinic not found"
            End If
        Catch ex As Exception
            Console.WriteLine($"Error getting clinic name by access code: {ex.Message}")
            Return $"An error occurred while getting the clinic name. Please contact support. {ex.Message}"
        End Try
    End Function




End Module
