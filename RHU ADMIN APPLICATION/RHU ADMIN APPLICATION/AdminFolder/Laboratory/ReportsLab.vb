Imports MySql.Data.MySqlClient
Imports Excel = Microsoft.Office.Interop.Excel
Public Class ReportsLab
    Private Sub ReportsLab_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateLabResultsGrid()
        PopulateLaboratoryComboBox()
    End Sub

    Private Function GetLabResults() As DataTable
        Dim labResultsTable As New DataTable()

        Try
            Dim sql As String = "SELECT lr.LabResultID, CONCAT(p.Firstname, ' ', p.Lastname) AS Fullname, lr.RecordDate, lr.InChargePerson, lr.LaboratoryName " &
                    "FROM laboratoryresults lr " &
                    "INNER JOIN patients p ON lr.PatientID = p.PatientID"



            ' Execute the query to fetch the data
            labResultsTable = ExecuteQuery(sql)
        Catch ex As Exception
            Console.WriteLine($"Error retrieving laboratory results: {ex.Message}")
        End Try

        Return labResultsTable
    End Function


    Private Sub PopulateLabResultsGrid()
        Try
            Dim labResultsTable As DataTable = GetLabResults()

            ' Check if the retrieved data is not empty
            If labResultsTable IsNot Nothing AndAlso labResultsTable.Rows.Count > 0 Then
                ' Display the data in DataGridView (assuming you have a DataGridView named DataGridViewLabResults)
                DataGridViewLabResults.DataSource = labResultsTable
            Else
                MessageBox.Show("No laboratory results found.", "Empty Results", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show($"Error populating laboratory results grid: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub PopulateLaboratoryComboBox()
        ComboBoxLaboratory.Items.Clear()

        Try
            Dim sql As String = "SELECT DISTINCT LaboratoryName FROM laboratoryresults"

            Dim labNamesTable As DataTable = ExecuteQuery(sql)
            If labNamesTable IsNot Nothing AndAlso labNamesTable.Rows.Count > 0 Then
                For Each row As DataRow In labNamesTable.Rows
                    ComboBoxLaboratory.Items.Add(row("LaboratoryName").ToString())
                Next
                ComboBoxLaboratory.SelectedIndex = -1
            Else
                MessageBox.Show("No laboratory names found.", "Empty Results", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show($"Error populating laboratory names ComboBox: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SearchLabResultsByLabName()
        If ComboBoxLaboratory.SelectedIndex = -1 Then
            MessageBox.Show("Please select a laboratory name from the list.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim selectedLabName As String = ComboBoxLaboratory.SelectedItem.ToString()

        SearchLabResultsByLabName(selectedLabName)
    End Sub

    Private Sub SearchLabResultsByLabName2()
        ' Check if an item is selected in the ComboBoxLaboratory
        If ComboBoxLaboratory.SelectedIndex = -1 Then
            MessageBox.Show("Please select a laboratory name from the list.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return ' Exit the subroutine if no item is selected
        End If

        ' Get the selected laboratory name from the ComboBox
        Dim selectedLabName As String = ComboBoxLaboratory.SelectedItem.ToString()

        ' Check if the DateTimePickerRecordDate has been interacted with (value changed or checked)
        If DateTimePickerRecordDate.Focused OrElse DateTimePickerRecordDate.Checked Then
            ' Get the selected date from the DateTimePicker
            Dim selectedDate As Date = DateTimePickerRecordDate.Value.Date

            ' Call the new SearchLabResultsByLabNameAndDate with the selectedLabName and selectedDate parameters
            SearchLabResultsByLabNameAndDate(selectedLabName, selectedDate)
        Else
            ' If the DateTimePickerRecordDate hasn't been interacted with, call the existing SearchLabResultsByLabName with only the selectedLabName parameter
            SearchLabResultsByLabName(selectedLabName)
        End If
    End Sub

    Private Sub SearchLabResultsByLabName(ByVal labName As String)
        ' Clear any existing data in the DataGridViewLabResults
        DataGridViewLabResults.DataSource = Nothing

        Try
            ' Construct the SQL query to search for laboratory results by LaboratoryName
            Dim sql As String = "SELECT lr.LabResultID, CONCAT(p.FirstName, ' ', p.LastName) AS Fullname, " &
                    "lr.InChargePerson, lr.RecordDate " &
                    "FROM laboratoryresults lr " &
                    "INNER JOIN patients p ON lr.PatientID = p.PatientID " &
                    "WHERE lr.LaboratoryName = @LaboratoryName"


            ' Create parameters for the query
            Dim parameters As New List(Of MySqlParameter)()
            parameters.Add(New MySqlParameter("@LaboratoryName", labName))

            ' Execute the query to fetch the data
            Dim labResultsTable As DataTable = ExecuteQuery(sql, parameters)

            ' Check if data was retrieved successfully
            If labResultsTable IsNot Nothing AndAlso labResultsTable.Rows.Count > 0 Then
                ' Display the data in DataGridViewLabResults
                DataGridViewLabResults.DataSource = labResultsTable
            Else
                ' Clear the DataGridView if no data is found for the selected clinic
                DataGridViewLabResults.DataSource = Nothing
                MessageBox.Show("No results found for the selected clinic.", "Empty Results", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            ' Display an error message if an exception occurs during data retrieval
            MessageBox.Show($"Error searching for laboratory results: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub VTNsearchLab_Click(sender As Object, e As EventArgs) Handles VTNsearchLab.Click
        SearchLabResultsByLabName()
    End Sub


    Private Sub SearchLabResultsByLabNameAndDate(ByVal labName As String, ByVal recordDate As Date)
        ' Clear any existing data in the DataGridViewLabResults
        DataGridViewLabResults.DataSource = Nothing

        Try
            ' Construct the SQL query to search for laboratory results by LaboratoryName and RecordDate
            Dim sql As String = "SELECT LabResultID, PatientID, ResultDescription, InChargePerson, RecordDate " &
                            "FROM laboratoryresults " &
                            "WHERE LaboratoryName = @LaboratoryName AND RecordDate = @RecordDate"

            ' Create parameters for the query
            Dim parameters As New List(Of MySqlParameter)()
            parameters.Add(New MySqlParameter("@LaboratoryName", labName))
            parameters.Add(New MySqlParameter("@RecordDate", recordDate))

            ' Execute the query to fetch the data
            Dim labResultsTable As DataTable = ExecuteQuery(sql, parameters)

            ' Check if data was retrieved successfully
            If labResultsTable IsNot Nothing AndAlso labResultsTable.Rows.Count > 0 Then
                ' Display the data in DataGridViewLabResults
                DataGridViewLabResults.DataSource = labResultsTable
            Else
                ' Clear the DataGridView if no data is found for the selected criteria
                DataGridViewLabResults.DataSource = Nothing
                MessageBox.Show("No results found for the selected criteria.", "Empty Results", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            ' Display an error message if an exception occurs during data retrieval
            MessageBox.Show($"Error searching for laboratory results: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SearchLabResultsByLabName2()
    End Sub

    Private Sub ExportToExcel(ByVal dataGridView As DataGridView, ByVal selectedDate As Date)
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

        excelWorksheet.Cells.Font.Size = 16
        excelWorksheet.Columns("A:Z").ColumnWidth = 50
        excelWorksheet.Rows("1:1000").RowHeight = 30

        Dim saveDialog As New SaveFileDialog()
        saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*"
        saveDialog.FilterIndex = 1
        saveDialog.RestoreDirectory = True
        saveDialog.FileName = $"LABORATORY_{ComboBoxLaboratory.Text}_{DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss")}.xlsx"

        If saveDialog.ShowDialog() = DialogResult.OK Then
            Dim fileName As String = saveDialog.FileName
            excelWorkbook.SaveAs(fileName)
            excelWorkbook.Close()
            excelApp.Quit()
            ReleaseObject(excelWorksheet)
            ReleaseObject(excelWorkbook)
            ReleaseObject(excelApp)
            MessageBox.Show("Data exported successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
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

    Private Sub btnExportToExcel_Click(sender As Object, e As EventArgs) Handles btnExportToExcel.Click
        ExportToExcel(DataGridViewLabResults, DateTimePickerRecordDate.Value.Date)
    End Sub
End Class