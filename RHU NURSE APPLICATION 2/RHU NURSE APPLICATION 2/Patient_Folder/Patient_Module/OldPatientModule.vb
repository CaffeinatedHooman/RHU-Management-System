Imports MySql.Data.MySqlClient
Module OldPatientModule
    Public Function SearchPatient(patientID As String) As DataTable
        Try
            Dim sql As String = "SELECT * FROM Patients WHERE PatientID = @PatientID"

            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@PatientID", patientID)
        }

            Return ExecuteQuery(sql, parameters)
        Catch ex As Exception
            MessageBox.Show($"Error searching for patient record: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function

    Public Function GetPatientDetailsByID(patientID As String) As DataTable
        Try
            Dim sql As String = "SELECT * FROM Patients WHERE PatientID = @PatientID"

            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@PatientID", patientID)
        }

            Return ExecuteQuery(sql, parameters)
        Catch ex As Exception
            MessageBox.Show($"Error retrieving patient details by ID: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function

    Public Function SearchPatientsByFirstName(firstName As String) As DataTable
        Try
            Dim sql As String = "SELECT PatientID, FirstName, LastName FROM Patients WHERE FirstName LIKE @FirstName"

            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@FirstName", $"%{firstName}%")
        }

            Return ExecuteQuery(sql, parameters)
        Catch ex As Exception
            MessageBox.Show($"Error searching for patients by first name: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function

    Public Function SearchPatientsByLastName(lastName As String) As DataTable
        Try
            Dim sql As String = "SELECT PatientID, FirstName, LastName FROM Patients WHERE LastName LIKE @LastName"

            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@LastName", $"%{lastName}%")
        }

            Return ExecuteQuery(sql, parameters)
        Catch ex As Exception
            MessageBox.Show($"Error searching for patients by last name: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function


    Public Function GetPatientDetailsByName(firstName As String, lastName As String) As DataTable
        Try
            Dim sql As String = "SELECT * FROM Patients WHERE FirstName = @FirstName AND LastName = @LastName"

            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@FirstName", firstName),
            New MySqlParameter("@LastName", lastName)
        }

            Return ExecuteQuery(sql, parameters)
        Catch ex As Exception
            MessageBox.Show($"Error retrieving patient details by name: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function

    Public Function CreatePatientVitalRecord(patientID As String, bodyTemp As String, bloodPressure As String, respirationRate As String, pulseRate As String, weight As String, height As String, diagnosis As String) As Boolean
        Try
            If Not Double.TryParse(bodyTemp, Nothing) Then
                MessageBox.Show("Please enter a valid body temperature.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If
            Dim parsedBodyTemp As Double = Convert.ToDouble(bodyTemp)

            Dim sql As String = "INSERT INTO vitalsigns (PatientID, BodyTemp, BloodPressure, RespirationRate, PulseRate, Weight, Height, Diagnosis) VALUES (@PatientID, @BodyTemp, @BloodPressure, @RespirationRate, @PulseRate, @Weight, @Height, @Diagnosis)"

            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@PatientID", patientID),
            New MySqlParameter("@BodyTemp", parsedBodyTemp),
            New MySqlParameter("@BloodPressure", bloodPressure),
            New MySqlParameter("@RespirationRate", respirationRate),
            New MySqlParameter("@PulseRate", pulseRate),
            New MySqlParameter("@Weight", weight),
            New MySqlParameter("@Height", height),
            New MySqlParameter("@Diagnosis", diagnosis)
        }

            ExecuteNonQuery(sql, parameters)

            Return True
        Catch ex As Exception
            MessageBox.Show($"Error creating patient record: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function


    Public Function GetClinicName(doctorID As String) As String
        Dim sql As String = "SELECT Clinic FROM doctors WHERE DoctorID = @DoctorID"
        Dim parameters As New List(Of MySqlParameter) From {
        New MySqlParameter("@DoctorID", doctorID)
    }

        Dim clinicName As Object = ExecuteScalar(sql, parameters)

        If clinicName IsNot Nothing AndAlso Not DBNull.Value.Equals(clinicName) Then
            Return clinicName.ToString()
        Else
            Return "Clinic Not Found"
        End If
    End Function
End Module
