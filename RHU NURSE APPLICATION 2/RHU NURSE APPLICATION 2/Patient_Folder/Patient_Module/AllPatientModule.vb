Imports MySql.Data.MySqlClient
Module AllPatientModule
    Public Function GetAllPatients() As DataTable
        Try
            Dim sql As String = "SELECT FirstName, LastName, Gender, DOB, Age, ContactNumber, PhilhealthID FROM Patients"
            Return ExecuteQuery(sql, Nothing)
        Catch ex As Exception
            Console.WriteLine($"Error retrieving patients: {ex.Message}")
            Return Nothing
        End Try
    End Function
    Public Function GetPatientsByFilter(filterValue As String) As DataTable
        Try
            Dim sql As String = "SELECT FirstName, LastName, Gender, DOB, Age, MaritalStatus, ContactNumber, PhilhealthID FROM Patients"

            If Not String.IsNullOrEmpty(filterValue) Then
                sql &= $" WHERE MaritalStatus = '{filterValue}'"
            End If

            Return ExecuteQuery(sql, Nothing)
        Catch ex As Exception
            Console.WriteLine($"Error retrieving patients: {ex.Message}")
            Return Nothing
        End Try
    End Function
    Public Function GeneralSearchPatients(searchValue As String) As DataTable
        Try
            Dim sql As String = "SELECT FirstName, LastName, Gender, DOB, Age, MaritalStatus FROM Patients WHERE CONCAT(PatientID, FirstName, MiddleName, LastName, Gender, DOB, Age, MaritalStatus, Citizenship, Religion) LIKE @SearchValue"
            Dim parameters As New List(Of MySqlParameter) From {
                New MySqlParameter("@SearchValue", $"%{searchValue}%")
            }
            Return ExecuteQuery(sql, parameters)
        Catch ex As Exception
            Console.WriteLine($"Error performing general search: {ex.Message}")
            Return Nothing
        End Try
    End Function
    Public Function GetPatientsByFullName(fullName As String) As DataTable
        Try
            Dim sql As String = "SELECT  FirstName, MiddleName, LastName, Gender, DOB, Age, MaritalStatus, Citizenship, Religion FROM Patients WHERE CONCAT(FirstName, ' ', MiddleName, ' ', LastName) LIKE @FullName"
            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@FullName", $"%{fullName}%")
        }
            Return ExecuteQuery(sql, parameters)
        Catch ex As Exception
            Console.WriteLine($"Error retrieving patients by full name: {ex.Message}")
            Return Nothing
        End Try
    End Function
    Public Function SearchPatientsByDate(dateString As String) As DataTable
        Try
            Dim sql As String = "SELECT  FirstName, MiddleName, LastName, Gender, DOB, Age, MaritalStatus, Citizenship, Religion FROM Patients WHERE DOB = @DOB"
            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@DOB", DateTime.Parse(dateString).ToString("yyyy-MM-dd"))
        }
            Return ExecuteQuery(sql, parameters)
        Catch ex As Exception
            Console.WriteLine($"Error retrieving patients by date: {ex.Message}")
            Return Nothing
        End Try
    End Function
    Public Function GeneralSearchPatients2(searchValue As String) As DataTable
        Try
            Dim sql As String = "SELECT PatientID, CONCAT(FirstName, ' ', MiddleName, ' ', LastName) AS FullName, Gender, DOB, Age, MaritalStatus FROM Patients WHERE " &
                    "PatientID LIKE @SearchValue OR " &
                    "CONCAT(FirstName, ' ', MiddleName, ' ', LastName) LIKE @SearchValue OR " &
                    "(Gender = @GenderValue AND Gender LIKE @SearchValue) OR " &
                    "(Age = @AgeValue AND Age LIKE @SearchValue) OR " &
                    "DOB LIKE @SearchValue OR " &
                    "MaritalStatus LIKE @SearchValue OR " &
                    "Citizenship LIKE @SearchValue OR " &
                    "Religion LIKE @SearchValue"

            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@SearchValue", $"%{searchValue}%"),
            New MySqlParameter("@GenderValue", searchValue), ' Exact value for Gender
            New MySqlParameter("@AgeValue", searchValue) ' Exact value for Age
            }


            Return ExecuteQuery(sql, parameters)
        Catch ex As Exception
            Console.WriteLine($"Error performing general search: {ex.Message}")
            Return Nothing
        End Try
    End Function

End Module
