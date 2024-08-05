Imports System.IO
Imports MySql.Data.MySqlClient
Imports System.Data
Public Class DownloadFilesTB
    Private Sub DownloadFilesTB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayDoctorRequestFiles()
    End Sub

    Private Sub DisplayDoctorRequestFiles()
        Try
            Dim doctorID As String = DocumentsPanelTB.DoctorIDLBL.Text
            Dim doctorRequestFilesTable As DataTable = GetDoctorRequestFiles(doctorID)

            If doctorRequestFilesTable IsNot Nothing AndAlso doctorRequestFilesTable.Rows.Count > 0 Then
                DataGridView1.DataSource = doctorRequestFilesTable
            Else
                MessageBox.Show("No doctor request files found.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show($"Error displaying doctor request files: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Function GetDoctorRequestFiles(ByVal doctorID As String) As DataTable
        Try
            Dim sql As String = "SELECT DR.RequestID, CONCAT(DR1.Firstname, ' ', DR1.Lastname) AS SenderOfRequest, CONCAT(DR2.Firstname, ' ', DR2.Lastname) AS ReceiverOfRequest, DRF.FileID, DRF.FileName, DRF.UploadDate " &
                            "FROM doctorrequestfiles DRF " &
                            "INNER JOIN doctorrequests DR ON DRF.RequestID = DR.RequestID " &
                            "INNER JOIN Doctors DR1 ON DR.SenderDoctorID = DR1.DoctorID " &
                            "INNER JOIN Doctors DR2 ON DR.ReceiverDoctorID = DR2.DoctorID " &
                            "WHERE DR.SenderDoctorID = @DoctorID OR DR.ReceiverDoctorID = @DoctorID"

            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@DoctorID", doctorID)
        }

            Return ExecuteQuery(sql, parameters)
        Catch ex As Exception
            Console.WriteLine($"Error retrieving doctor request files: {ex.Message}")
            Return Nothing
        End Try
    End Function


    Private Function DownloadFileFromDatabase(fileId As Integer, fileName As String) As Boolean
        Try
            Dim sql As String = "SELECT FileContent FROM doctorrequestfiles WHERE FileID = @FileID"
            Dim parameters As New List(Of MySqlParameter) From {New MySqlParameter("@FileID", fileId)}

            Dim fileContent As Byte() = CType(ExecuteScalar(sql, parameters), Byte())
            If fileContent IsNot Nothing AndAlso fileContent.Length > 0 Then
                Dim saveFileDialog As New SaveFileDialog()
                saveFileDialog.FileName = fileName
                saveFileDialog.Filter = "All Files|*.*"

                If saveFileDialog.ShowDialog() = DialogResult.OK Then
                    Dim filePath As String = saveFileDialog.FileName
                    System.IO.File.WriteAllBytes(filePath, fileContent)
                    Return True
                Else
                    MessageBox.Show("Download canceled.", "Download Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If

            Return False
        Catch ex As Exception
            MessageBox.Show($"Error downloading file: {ex.Message}", "Download Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            DataGridView1.Rows(e.RowIndex).Selected = True ' Select the entire row
            Dim fileId As Integer = Convert.ToInt32(DataGridView1.Rows(e.RowIndex).Cells("FileID").Value)
            Dim fileName As String = DataGridView1.Rows(e.RowIndex).Cells("FileName").Value.ToString()

            If DownloadFileFromDatabase(fileId, fileName) Then
                MessageBox.Show($"File '{fileName}' downloaded successfully.", "Download Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show($"Error downloading file '{fileName}'.", "Download Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub
End Class