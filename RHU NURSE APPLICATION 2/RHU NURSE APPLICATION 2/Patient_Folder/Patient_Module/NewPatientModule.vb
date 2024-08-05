Imports MySql.Data.MySqlClient
Module NewPatientModule
    Public Function CreatePatient(firstName As String, middleName As String, lastName As String, gender As String, dob As Date, age As Integer, maritalStatus As String, citizenship As String, religion As String, address As String, contactNumber As String, philhealthID As String) As Boolean
        Try
            Dim patientID As String = GeneratePatientID()
            Dim sql As String = "INSERT INTO Patients (PatientID, FirstName, MiddleName, LastName, Gender, DOB, Age, MaritalStatus, Citizenship, Religion, Address, ContactNumber, PhilhealthID) VALUES (@PatientID, @FirstName, @MiddleName, @LastName, @Gender, @DOB, @Age, @MaritalStatus, @Citizenship, @Religion, @Address, @ContactNumber, @PhilhealthID)"

            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@PatientID", patientID),
            New MySqlParameter("@FirstName", firstName),
            New MySqlParameter("@MiddleName", middleName),
            New MySqlParameter("@LastName", lastName),
            New MySqlParameter("@Gender", gender),
            New MySqlParameter("@DOB", dob),
            New MySqlParameter("@Age", age),
            New MySqlParameter("@MaritalStatus", maritalStatus),
            New MySqlParameter("@Citizenship", citizenship),
            New MySqlParameter("@Religion", religion),
            New MySqlParameter("@Address", address),
            New MySqlParameter("@ContactNumber", contactNumber),
            New MySqlParameter("@PhilhealthID", philhealthID)
        }

            ExecuteNonQuery(sql, parameters)

            Return True
        Catch ex As Exception
            MessageBox.Show($"Error creating patient record: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Return False
        End Try
    End Function

    Public Function GetAllMaritalStatuses() As DataTable
        Try
            Dim sql As String = "SELECT * FROM maritalstatus"
            Return ExecuteQuery(sql, Nothing)
        Catch ex As Exception
            Console.WriteLine($"Error getting all marital statuses: {ex.Message}")
            Return Nothing
        End Try
    End Function
End Module
