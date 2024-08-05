Imports System.IO
Imports Excel = Microsoft.Office.Interop.Excel
Imports MySql.Data.MySqlClient
Public Class recordgridpatienttoexel
    Private Sub ExportToExcel(ByVal dataGridView As DataGridView)
        Dim excelApp As New Excel.Application
        Dim excelWorkbook As Excel.Workbook = excelApp.Workbooks.Add()
        Dim excelWorksheet As Excel.Worksheet = excelWorkbook.Sheets(1)
        Dim columnsCount As Integer = dataGridView.Columns.Count
        Dim rowsCount As Integer = dataGridView.Rows.Count

        For col As Integer = 0 To columnsCount - 1
            excelWorksheet.Cells(1, col + 1) = dataGridView.Columns(col).HeaderText
        Next

        For i As Integer = 0 To rowsCount - 1
            For j As Integer = 0 To columnsCount - 1
                excelWorksheet.Cells(i + 2, j + 1) = dataGridView.Rows(i).Cells(j).Value.ToString()
            Next
        Next

        excelWorksheet.Columns.AutoFit()

        Dim password As String = "YourPassword"
        excelWorksheet.Protect(password)

        Dim saveDialog As New SaveFileDialog()
        saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*"
        saveDialog.FilterIndex = 1
        saveDialog.RestoreDirectory = True

        If saveDialog.ShowDialog() = DialogResult.OK Then
            Dim fileName As String = saveDialog.FileName
            excelWorkbook.SaveAs(fileName)
            excelWorkbook.Close()
            excelApp.Quit()
            ReleaseObject(excelWorksheet)
            ReleaseObject(excelWorkbook)
            ReleaseObject(excelApp)
            MessageBox.Show("Data exported successfully and Excel file is locked with a password!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub



    Public Sub ReleaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        ExportToExcel(dataGridView1)
    End Sub


    Public Function GetVitalSignsByPatientID(patientID As String) As DataTable
        Try
            Dim sql As String = "
            SELECT CONCAT(P.FirstName, ' ', P.LastName) AS FullName, VS.*
            FROM VitalSigns AS VS
            INNER JOIN Patients AS P ON VS.PatientID = P.PatientID
            WHERE VS.PatientID = @PatientID
        "

            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@PatientID", patientID)
        }

            Return ExecuteQuery(sql, parameters)
        Catch ex As Exception
            MessageBox.Show($"Error retrieving vital signs by patient ID: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function



    Private Sub btnSearch_Click_1(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim patientID As String = txtPatientID.Text
        If Not String.IsNullOrEmpty(patientID) Then
            Dim vitalSignsData As DataTable = GetVitalSignsByPatientID(patientID)

            If vitalSignsData IsNot Nothing AndAlso vitalSignsData.Rows.Count > 0 Then
                DataGridView1.DataSource = vitalSignsData
            Else
                MessageBox.Show("No vital signs data found for the specified patient ID.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Please enter a patient ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub recordgridpatienttoexel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
