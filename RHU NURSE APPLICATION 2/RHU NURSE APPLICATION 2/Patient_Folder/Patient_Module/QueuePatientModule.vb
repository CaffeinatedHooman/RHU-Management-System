Imports MySql.Data.MySqlClient
Imports System.Globalization

Module QueuePatientModule
    Public Function QueuePatient(patientID As String, doctorID As String, clinicName As String) As String
        Try
            If String.IsNullOrEmpty(doctorID) Then
                Console.WriteLine("Error queuing patient: DoctorID is empty.")
                Return "Error Queuing Patient"
            End If

            Dim currentDate As String = DateTime.Now.ToString("yyyyMMdd")


            Dim sql As String = "SELECT MAX(QueueNumber) FROM Queue WHERE DoctorID = @DoctorID AND QueueDate = @QueueDate"
            Dim parameters As New List(Of MySqlParameter) From {
                New MySqlParameter("@DoctorID", doctorID),
                New MySqlParameter("@QueueDate", currentDate)
            }

            Dim lastQueueNumber As Object = ExecuteScalar(sql, parameters)

            Dim counter As Integer


            If lastQueueNumber Is Nothing OrElse DBNull.Value.Equals(lastQueueNumber) Then
                counter = 1
            Else

                counter = CType(lastQueueNumber, Integer) + 1
            End If


            sql = "INSERT INTO Queue (PatientID, DoctorID, QueueNumber, QueueDate, Clinic, QueueStatus, QueueTime) VALUES (@PatientID, @DoctorID, @QueueNumber, @QueueDate, @Clinic, 'Waiting', CURRENT_TIMESTAMP)"
            Dim insertParameters As New List(Of MySqlParameter) From {
                New MySqlParameter("@PatientID", patientID),
                New MySqlParameter("@DoctorID", doctorID),
                New MySqlParameter("@QueueNumber", counter),
                New MySqlParameter("@QueueDate", currentDate),
                New MySqlParameter("@Clinic", clinicName)
            }

            ExecuteNonQuery(sql, insertParameters)


            Return $"{counter}"
        Catch ex As Exception
            Console.WriteLine($"Error queuing patient: {ex.Message}")
            Return "Error Queuing Patient"
        End Try
    End Function


End Module
