Imports MySql.Data.MySqlClient
Imports System.Globalization

Module RequestRecieved
    Public Function AddRequestToDatabase(senderDoctorID As String, receiverDoctorID As String, patientID As String, requestMessage As String, requestDate As DateTime, status As String) As Boolean
        Try
            Dim sql As String = "INSERT INTO DoctorRequests (SenderDoctorID, ReceiverDoctorID, PatientID, RequestMessage, RequestDate, Status) VALUES (@SenderDoctorID, @ReceiverDoctorID, @PatientID, @RequestMessage, @RequestDate, @Status)"
            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@SenderDoctorID", senderDoctorID),
            New MySqlParameter("@ReceiverDoctorID", receiverDoctorID),
            New MySqlParameter("@PatientID", patientID),
            New MySqlParameter("@RequestMessage", requestMessage),
            New MySqlParameter("@RequestDate", requestDate),
            New MySqlParameter("@Status", status)
        }

            ExecuteNonQuery(sql, parameters)

            MessageBox.Show("Request has been sent to the doctor. Please wait for the response.", "Request Sent", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Return True
        Catch ex As Exception
            MessageBox.Show($"Error adding request to the database: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function RequestExists(senderDoctorID As String, receiverDoctorID As String, patientID As String, requestMessage As String, status As String) As Boolean
        Try
            Dim sql As String = "SELECT COUNT(*) FROM DoctorRequests WHERE SenderDoctorID = @SenderDoctorID AND ReceiverDoctorID = @ReceiverDoctorID AND PatientID = @PatientID AND RequestMessage = @RequestMessage AND Status = @Status"
            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@SenderDoctorID", senderDoctorID),
            New MySqlParameter("@ReceiverDoctorID", receiverDoctorID),
            New MySqlParameter("@PatientID", patientID),
            New MySqlParameter("@RequestMessage", requestMessage),
            New MySqlParameter("@Status", status)
        }

            Dim result As Object = ExecuteScalar(sql, parameters)
            Return Convert.ToInt32(result) > 0
        Catch ex As Exception
            MessageBox.Show($"Error checking request existence: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function


    Public Function AddFileToDatabase(requestID As Integer, fileName As String, fileData As Byte(), fileType As String) As Boolean
        Try
            Dim sql As String = "INSERT INTO Files (RequestID, FileName, FileData, FileType) VALUES (@RequestID, @FileName, @FileData, @FileType)"
            Dim parameters As New List(Of MySqlParameter) From {
                New MySqlParameter("@RequestID", requestID),
                New MySqlParameter("@FileName", fileName),
                New MySqlParameter("@FileData", fileData),
                New MySqlParameter("@FileType", fileType)
            }
            ExecuteNonQuery(sql, parameters)

            Return True
        Catch ex As Exception
            MessageBox.Show($"Error adding file to the database: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function



End Module
