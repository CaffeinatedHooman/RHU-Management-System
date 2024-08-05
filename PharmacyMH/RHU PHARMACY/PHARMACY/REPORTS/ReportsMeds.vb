Imports MySql.Data.MySqlClient
Imports Excel = Microsoft.Office.Interop.Excel
Public Class ReportsMeds
    Private Sub ReportsMeds_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateMedicineOutGrid()
    End Sub
    Private Function GetMedicineOutDetails() As DataTable
        Dim medicineOutDetailsTable As New DataTable()

        Try
            ' Construct the SQL query with an inner join between medicineoutdetails and medicine tables
            Dim sql As String = "SELECT mo.TransactionID, m.MedicineName, mo.Quantity, CONCAT(p.firstname, ' ', p.lastname) AS FULLNAME, mo2.TransactionDate " &
                                "FROM medicineoutdetails mo " &
                                "INNER JOIN medicine m ON mo.MedicineID = m.MedicineID " &
                                "INNER JOIN medicineout mo2 ON mo.TransactionID = mo2.TransactionID " &
                                "INNER JOIN patients p ON mo2.PatientID = p.PatientID"

            Dim resultTable As DataTable = ExecuteQuery(sql, Nothing)

            ' Check if the result table is not empty
            If resultTable IsNot Nothing AndAlso resultTable.Rows.Count > 0 Then
                medicineOutDetailsTable = resultTable
            End If
        Catch ex As Exception
            Console.WriteLine($"Error retrieving medicine out details: {ex.Message}")
        End Try

        Return medicineOutDetailsTable
    End Function



    Private Sub PopulateMedicineOutGrid()
        Try
            Dim medicineOutDetailsTable As DataTable = GetMedicineOutDetails()
            DataGridViewMedicineOut.DataSource = medicineOutDetailsTable
        Catch ex As Exception
            Console.WriteLine($"Error populating medicine out grid: {ex.Message}")
        End Try
    End Sub

    Public Function SearchByDate(selectedDate As Date) As DataTable
        Dim formattedDate As String = selectedDate.ToString("yyyy-MM-dd")

        ' You may need to adjust the date format depending on how dates are stored in your database
        Dim sql As String = "SELECT mo.TransactionID, m.MedicineName, mo.Quantity, CONCAT(p.firstname, ' ', p.lastname) AS FULLNAME, mo2.TransactionDate " &
                        "FROM medicineoutdetails mo " &
                        "INNER JOIN medicine m ON mo.MedicineID = m.MedicineID " &
                        "INNER JOIN medicineout mo2 ON mo.TransactionID = mo2.TransactionID " &
                        "INNER JOIN patients p ON mo2.PatientID = p.PatientID " &
                        "WHERE mo2.TransactionDate LIKE @SelectedDate"

        Dim parameters As New List(Of MySqlParameter)()
        parameters.Add(New MySqlParameter("@SelectedDate", "%" & formattedDate & "%"))

        Try
            Return ExecuteQuery(sql, parameters)
        Catch ex As Exception
            Throw New Exception("Error searching by date.", ex)
        End Try
    End Function


    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Dim selectedDate As DateTime = DateTimePicker1.Value
        Dim filteredTable As DataTable = SearchByDate(selectedDate)
        DataGridViewMedicineOut.DataSource = filteredTable
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
        saveDialog.FileName = $"MedicineOut_{selectedDate.ToString("yyyy-MM-dd")}.xlsx" ' Set default file name with the selected date

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



    Private Sub btnExportToExcel_Click(sender As Object, e As EventArgs) Handles btnExportToExcel.Click
        ExportToExcel(DataGridViewMedicineOut, DateTimePicker1.Value.Date)
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


End Class