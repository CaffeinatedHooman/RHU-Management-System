Imports MySql.Data.MySqlClient
Imports Excel = Microsoft.Office.Interop.Excel
Public Class ExportPatientRecordTB
    Private Sub ExportPatientRecordTB_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub DisplaySearchResults(searchResult As DataTable)
        PatientSeachList.Items.Clear()

        If searchResult IsNot Nothing AndAlso searchResult.Rows.Count > 0 Then
            For Each row As DataRow In searchResult.Rows
                Dim patientID As String = (row("PatientID"))
                Dim fullName As String = $"{patientID} - {row("FirstName")} {row("LastName")}"
                PatientSeachList.Items.Add(fullName)
            Next
        Else
            MessageBox.Show("No matching patients found.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub


    Private Sub ComboBoxSearchOptions_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxSearchOptions.SelectedIndexChanged
        Try

            Dim selectedOption As String = If(ComboBoxSearchOptions.SelectedItem IsNot Nothing, ComboBoxSearchOptions.SelectedItem.ToString(), String.Empty)

            Select Case selectedOption
                Case "Last Name Search"

                    Dim lastName As String = InputBox("Enter last name to search:", "Search Patients")
                    If Not String.IsNullOrEmpty(lastName) Then
                        Dim searchResult As DataTable = SearchPatientsByLastName(lastName)
                        DisplaySearchResults(searchResult)
                    End If

                Case "First Name Search"

                    Dim firstName As String = InputBox("Enter first name to search:", "Search Patients")
                    If Not String.IsNullOrEmpty(firstName) Then
                        Dim searchResult As DataTable = SearchPatientsByFirstName(firstName)
                        DisplaySearchResults(searchResult)
                    End If

            End Select

            ComboBoxSearchOptions.SelectedIndex = -1

        Catch ex As Exception
            MessageBox.Show($"Error performing search: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub PatientSeachList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PatientSeachList.SelectedIndexChanged
        If PatientSeachList.SelectedIndex <> -1 Then
            Dim selectedFullName As String = PatientSeachList.SelectedItem.ToString()
            Dim parts() As String = selectedFullName.Split("-")

            If parts.Length >= 2 Then
                Dim patientID As String = parts(0).Trim()
                Dim fullName As String = parts(1).Trim()
                Dim spaceIndex As Integer = fullName.LastIndexOf(" ")

                If spaceIndex > 0 Then
                    lblFirstname.Text = fullName.Substring(0, spaceIndex)
                    lblLastname.Text = fullName.Substring(spaceIndex + 1)
                Else
                    lblFirstname.Text = fullName
                    lblLastname.Text = ""
                End If

                Dim patientDetails As DataTable = GetPatientDetailsByID(patientID)
                DisplayPatientDetails(patientDetails)

                Dim patientRecords As DataTable = GetRecordPatient(patientID)
                PatientExportData.DataSource = patientRecords
            End If
        End If
    End Sub


    Private Sub DisplayPatientDetails(patientDetails As DataTable)
        If patientDetails IsNot Nothing AndAlso patientDetails.Rows.Count > 0 Then
            lblPatientID.Text = patientDetails.Rows(0)("PatientID").ToString()
            lblFirstname.Text = patientDetails.Rows(0)("FirstName").ToString()
            lblMiddlename.Text = patientDetails.Rows(0)("MiddleName").ToString()
            lblLastname.Text = patientDetails.Rows(0)("LastName").ToString()
            lblGender.Text = patientDetails.Rows(0)("Gender").ToString()

            Dim dobValue As Object = patientDetails.Rows(0)("DOB")
            If dobValue IsNot DBNull.Value Then
                Dim dobDate As Date = CDate(dobValue)
                lblDOB.Text = dobDate.ToString("yyyy-MM-dd")
            Else
                lblDOB.Text = "No DOB available"
            End If

            lblAge.Text = patientDetails.Rows(0)("Age").ToString()
            lblMS.Text = patientDetails.Rows(0)("MaritalStatus").ToString()
            lblCitizenship.Text = patientDetails.Rows(0)("Citizenship").ToString()
            lblReligon.Text = patientDetails.Rows(0)("Religion").ToString()
            lblAddress.Text = patientDetails.Rows(0)("Address").ToString()
            lblMN.Text = patientDetails.Rows(0)("ContactNumber").ToString()
            lblPhilhealthID.Text = patientDetails.Rows(0)("PhilhealthID").ToString()

        Else
            MessageBox.Show("No details found for the selected patient.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub


    Private Sub ClearPatientDetails()
        PatientSeachList.Items.Clear()
        lblPatientID.Text = "RHU-PATIENT"
        lblFirstname.Text = "="
        lblMiddlename.Text = "="
        lblLastname.Text = "="
        lblGender.Text = "="
        lblDOB.Text = "="
        lblAge.Text = "="
        lblMS.Text = "="
        lblCitizenship.Text = "="
        lblReligon.Text = "="
        lblAddress.Text = "="
        lblMN.Text = "="
        lblPhilhealthID.Text = "="

    End Sub




    Private Function SearchPatientsByFirstName(firstName As String) As DataTable
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

    Private Function SearchPatientsByLastName(lastName As String) As DataTable
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


    Private Function GetPatientDetailsByName(firstName As String, lastName As String) As DataTable
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

    Private Sub ClearInfoExisting_Click(sender As Object, e As EventArgs) Handles ClearInfoExisting.Click
        ClearPatientDetails()
    End Sub



    Private Sub ExportRecordVTN_Click(sender As Object, e As EventArgs) Handles ExportRecordVTN.Click
        If PatientExportData.Rows.Count > 0 Then
            ExportToExcel(PatientExportData, lblPatientID.Text, lblFirstname.Text, lblLastname.Text)
        Else
            MessageBox.Show("No data available to export.", "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub


    Private Sub ExportToExcel(ByVal dataGridView As DataGridView, ByVal patientID As String, ByVal firstName As String, ByVal lastName As String)
        Dim excelApp As New Excel.Application
        Dim excelWorkbook As Excel.Workbook = excelApp.Workbooks.Add()
        Dim excelWorksheet As Excel.Worksheet = excelWorkbook.Sheets(1)
        Dim columnsCount As Integer = dataGridView.Columns.Count
        Dim rowsCount As Integer = dataGridView.Rows.Count

        For col As Integer = 0 To columnsCount - 1
            excelWorksheet.Cells(1, col + 1) = dataGridView.Columns(col).HeaderText
            ' Set column width to 50
            excelWorksheet.Columns(col + 1).ColumnWidth = 50
        Next

        For i As Integer = 0 To rowsCount - 1
            For j As Integer = 0 To columnsCount - 1
                excelWorksheet.Cells(i + 2, j + 1) = dataGridView.Rows(i).Cells(j).Value.ToString()
            Next
            ' Set row height to 50
            excelWorksheet.Rows(i + 2).RowHeight = 50
        Next

        Dim saveDialog As New SaveFileDialog()
        saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*"
        saveDialog.FilterIndex = 1
        saveDialog.RestoreDirectory = True
        saveDialog.FileName = $"{firstName}_{lastName}_PatientID_{patientID}_Record.xlsx" ' Set default file name

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

    Private Function GetRecordPatient(patientID As String) As DataTable
        Try
            Dim sql As String = "
                                SELECT 
                                    CONCAT(P.FirstName, ' ', P.LastName) AS FullName,
                                    VS.TreatmentID, 
                                    VS.DoctorName, 
                                    VS.TBTest, 
                                    VS.PatientHistory, 
                                    VS.PatientComplains, 
                                    VS.MedicalHistory, 
                                    VS.Medications, 
                                    VS.DateRecorded                 
                                FROM 
                                    treatment_tb AS VS
                                INNER JOIN 
                                    Patients AS P ON VS.PatientID = P.PatientID
                                WHERE 
                                    VS.PatientID = @PatientID
 "

            Dim parameters As New List(Of MySqlParameter) From {
                New MySqlParameter("@PatientID", patientID)
            }

            Dim result As DataTable = ExecuteQuery(sql, parameters)

            If result IsNot Nothing AndAlso result.Rows.Count > 0 Then
                Return result
            Else
                MessageBox.Show("No records found for the patient.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return Nothing
            End If
        Catch ex As Exception
            MessageBox.Show($"Error retrieving patient records: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function
End Class