Imports MySql.Data.MySqlClient
Imports System.Globalization
Imports System.IO
Public Class UploadRecordTB
    Private Sub UploadRecordTB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayDoctorRequestsInGrid()
    End Sub

    Private Sub DisplayDoctorRequestsInGrid()
        Try
            Dim receiverDoctorID As String = DocumentsPanelTB.DoctorIDLBL.Text

            Dim doctorRequestsTable As DataTable = GetAllDoctorRequests(receiverDoctorID)
            If doctorRequestsTable IsNot Nothing AndAlso doctorRequestsTable.Rows.Count > 0 Then
                Guna2DataGridView1.DataSource = doctorRequestsTable
            Else
                MessageBox.Show("No doctor requests found.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show($"Error displaying doctor requests: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Public Function GetAllDoctorRequests(ByVal receiverDoctorID As String) As DataTable
        Try
            Dim sql As String = "SELECT DR.RequestID, " &
                            "CONCAT(D1.Firstname, ' ', D1.Lastname) AS SenderDoctorName, " &
                            "CONCAT(D2.Firstname, ' ', D2.Lastname) AS ReceiverDoctorName, " &
                            "P.PatientID, CONCAT(P.Firstname, ' ', P.Lastname) AS PatientName, " &
                            "DR.RequestMessage, DR.RequestDate, DR.Status " &
                            "FROM DoctorRequests DR " &
                            "INNER JOIN Doctors D1 ON DR.SenderDoctorID = D1.DoctorID " &
                            "INNER JOIN Doctors D2 ON DR.ReceiverDoctorID = D2.DoctorID " &
                            "INNER JOIN Patients P ON DR.PatientID = P.PatientID " &
                            "WHERE DR.ReceiverDoctorID = @ReceiverDoctorID"

            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@ReceiverDoctorID", receiverDoctorID)
        }

            Return ExecuteQuery(sql, parameters)
        Catch ex As Exception
            Console.WriteLine($"Error retrieving all doctor requests: {ex.Message}")
            Return Nothing
        End Try
    End Function

    Private Sub Guna2DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DataGridView1.CellContentClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = Guna2DataGridView1.Rows(e.RowIndex)
            Dim status As String = selectedRow.Cells("Status").Value.ToString()

            If status.Equals("Pending", StringComparison.OrdinalIgnoreCase) Then
                Dim requestID As Integer = Convert.ToInt32(selectedRow.Cells("RequestID").Value)
                UploadFileToDoctorRequestFiles(requestID)
            Else
                MessageBox.Show("This request has already been done.", "Request Already Done", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub UpdateRequestStatus(requestID As Integer)
        Try
            Dim sql As String = "UPDATE DoctorRequests SET Status = 'Done' WHERE RequestID = @RequestID"
            Dim parameters As New List(Of MySqlParameter) From {
                New MySqlParameter("@RequestID", requestID)
            }
            ExecuteNonQuery(sql, parameters)
        Catch ex As Exception
            MessageBox.Show($"Error updating request status: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub UploadFileToDoctorRequestFiles(requestID As Integer)
        Try
            Dim openFileDialog As New OpenFileDialog()
            openFileDialog.Title = "Select File to Upload"
            openFileDialog.Filter = "Excel files (*.xlsx; *.xls)|*.xlsx;*.xls"

            If openFileDialog.ShowDialog() = DialogResult.OK Then
                Dim fileName As String = Path.GetFileName(openFileDialog.FileName)
                Dim fileContent As Byte() = File.ReadAllBytes(openFileDialog.FileName)
                Dim uploadDate As String = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture)

                Dim sql As String = "INSERT INTO DoctorRequestFiles (RequestID, FileName, FileContent, UploadDate) VALUES (@RequestID, @FileName, @FileContent, @UploadDate)"
                Dim parameters As New List(Of MySqlParameter) From {
                    New MySqlParameter("@RequestID", requestID),
                    New MySqlParameter("@FileName", fileName),
                    New MySqlParameter("@FileContent", fileContent),
                    New MySqlParameter("@UploadDate", uploadDate)
                }
                ExecuteNonQuery(sql, parameters)

                MessageBox.Show("File uploaded successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                UpdateRequestStatus(requestID) ' Update request status after successful file upload
            Else
                MessageBox.Show("File selection canceled. Upload aborted.", "Upload Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show($"Error uploading file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class