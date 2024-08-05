Imports MySql.Data.MySqlClient
Imports System.Text

Public Class DistributionMedicine
    Private Sub DistributionMedicine_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateTransactionIDLabel()
    End Sub

    Private Sub btnSearchMeds_Click(sender As Object, e As EventArgs) Handles btnSearchMeds.Click
        Dim medicineName As String = MedicineNameTextBox.Text.Trim()
        Dim searchResults As DataTable = SearchMedicineByNameLike(medicineName)

        If searchResults IsNot Nothing AndAlso searchResults.Rows.Count > 0 Then
            Dim startIndex As Integer = DataGridViewMedicine.Rows.Count

            For Each searchRow As DataRow In searchResults.Rows
                DataGridViewMedicine.Rows.Add(searchRow.ItemArray)
            Next

            DataGridViewMedicine.FirstDisplayedScrollingRowIndex = startIndex
        Else
            MessageBox.Show("No matching medicines found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub


    Private Sub DataGridViewMedicine_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewMedicine.CellClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim selectedMedicineID As Integer = Convert.ToInt32(DataGridViewMedicine.Rows(e.RowIndex).Cells("MedicineID").Value)
            Dim selectedMedicineName As String = DataGridViewMedicine.Rows(e.RowIndex).Cells("MedicineName").Value.ToString()
            Dim selectedDosage As String = DataGridViewMedicine.Rows(e.RowIndex).Cells("Dosage").Value.ToString()
            Dim stockQuantity As Integer = Convert.ToInt32(DataGridViewMedicine.Rows(e.RowIndex).Cells("StockQuantity").Value)

            Dim quantityInput As String = InputBox($"Enter the quantity of {selectedMedicineName} ({selectedDosage}):", "Enter Quantity", "1")

            If Not String.IsNullOrEmpty(quantityInput) Then
                Dim quantity As Integer
                If Integer.TryParse(quantityInput, quantity) AndAlso quantity > 0 Then
                    If quantity <= stockQuantity Then
                        Dim newRow As DataGridViewRow = New DataGridViewRow()
                        newRow.CreateCells(DataGridViewSelectedMeds)
                        newRow.SetValues(selectedMedicineID, selectedMedicineName, selectedDosage, quantity)
                        DataGridViewSelectedMeds.Rows.Add(newRow)
                    Else
                        MessageBox.Show("Quantity exceeds available stock. Please enter a valid quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    MessageBox.Show("Invalid quantity. Please enter a valid number greater than zero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Input canceled. No quantity entered.", "Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Function GetNextTransactionID() As Integer
        Dim sql As String = "SELECT MAX(TransactionID) FROM medicineout"
        Dim maxID As Object = ExecuteScalar(sql)

        Dim counter As Integer = 1
        If maxID IsNot Nothing AndAlso Not DBNull.Value.Equals(maxID) Then
            counter = Convert.ToInt32(maxID) + 1
        End If

        Return counter
    End Function

    Private Sub UpdateTransactionIDLabel()
        Dim currentTransactionID As Integer = GetNextTransactionID()
        lblTransactionID.Text = currentTransactionID.ToString()
    End Sub

    Private Sub SaveMedicineOutDetailsFromDataGridView(transactionID As Integer, dataGridView As DataGridView)
        Dim errorMessages As New StringBuilder()
        Dim hasError As Boolean = False

        ' Check if the DataGridView has at least one row
        If dataGridView.Rows.Count = 0 OrElse dataGridView.Rows(0).IsNewRow Then
            errorMessages.AppendLine("No data to save. Please add medicine details.")
            hasError = True
        Else
            For Each row As DataGridViewRow In dataGridView.Rows
                If Not row.IsNewRow Then
                    Dim medicineID As Integer
                    Dim quantity As Integer

                    If Not Integer.TryParse(row.Cells("selectedMedicineID").Value.ToString(), medicineID) OrElse
                   Not Integer.TryParse(row.Cells("Quantity").Value.ToString(), quantity) OrElse
                   quantity <= 0 Then
                        errorMessages.AppendLine($"Invalid data in row {row.Index + 1}. Please make sure to select a medicine and enter a valid quantity greater than zero.")
                        hasError = True
                    Else
                        Try
                            SaveMedicineOutDetailsData(transactionID, medicineID, quantity)
                        Catch ex As Exception
                            errorMessages.AppendLine($"Error saving medicine ID {medicineID}: {ex.Message}")
                            hasError = True
                        End Try
                    End If
                End If
            Next
        End If

        If hasError Then
            MessageBox.Show($"Errors occurred while saving medicine details:{Environment.NewLine}{errorMessages.ToString()}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            MessageBox.Show("Medicine details saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub



    Private Sub ClearSelectedItems(dataGridView As DataGridView)
        If dataGridView.SelectedRows.Count > 0 Then
            For Each selectedRow As DataGridViewRow In dataGridView.SelectedRows
                dataGridView.Rows.Remove(selectedRow)
            Next
        End If
    End Sub

    Private Sub ClearAllRows(dataGridView As DataGridView)
        dataGridView.Rows.Clear()
        UpdateTransactionIDLabel()
    End Sub


    Private Sub ClearDataGridViews()
        ' Clear DataGridViewMedicine
        DataGridViewMedicine.DataSource = Nothing
        DataGridViewMedicine.Rows.Clear()
        DataGridViewMedicine.Columns.Clear()

        ' Clear DataGridViewSelectedMeds
        DataGridViewSelectedMeds.DataSource = Nothing
        DataGridViewSelectedMeds.Rows.Clear()
        DataGridViewSelectedMeds.Columns.Clear()
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
            lblMN.Text = patientDetails.Rows(0)("ContactNumber").ToString()
            lblPhilhealthID.Text = patientDetails.Rows(0)("PhilhealthID").ToString()

            PopulateTreatmentDateListBox()
        Else
            MessageBox.Show("No details found for the selected patient.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ClearPatientDetails()
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
        lblMN.Text = "="
        lblPhilhealthID.Text = "="

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
            End If
        End If
    End Sub


    Private Sub ListBoxTreatmentDates_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxTreatment.SelectedIndexChanged
        Dim selectedDate As DateTime = Convert.ToDateTime(ListBoxTreatment.SelectedItem)
        TreatmentDetailsHAS(selectedDate)
    End Sub

    Private Sub TreatmentDetailsHAS(selectedDate As DateTime)
        Dim patientID As String = lblPatientID.Text
        Dim treatmentTable As DataTable = GetTreatmentRecordsByDateHAS(patientID, selectedDate)

        If treatmentTable IsNot Nothing AndAlso treatmentTable.Rows.Count > 0 Then
            Dim treatmentRow As DataRow = treatmentTable.Rows(0)

            Dim doctorName As String = Convert.ToString(treatmentRow("DoctorName"))
            Dim hivStatus As String = Convert.ToString(treatmentRow("HIV_AIDS_Status"))
            Dim stiStatus As String = Convert.ToString(treatmentRow("STI_Status"))
            Dim hivMedication As String = Convert.ToString(treatmentRow("HIV_AIDS_Medication"))
            Dim stiMedication As String = Convert.ToString(treatmentRow("STI_Medication"))
            Dim healthStatus As String = Convert.ToString(treatmentRow("HealthStatus"))
            Dim dateRecorded As DateTime = Convert.ToDateTime(treatmentRow("DateRecorded"))

            txtDoctorNamePast.Text = doctorName
            PasttxtHIVStatus.Text = hivStatus
            PasttxtSTIStatus.Text = stiStatus
            PasttxtHIVMedication.Text = hivMedication
            PasttxtSTIMedication.Text = stiMedication
            PasttxthealthStatus.Text = healthStatus
            txtDateRecordedPast.Text = dateRecorded.ToString("yyyy-MM-dd HH:mm:ss")
        Else
            ClearTreatmentDetails()
        End If
    End Sub

    Private Sub ClearTreatmentDetails()

        ListBoxTreatment.DataSource = Nothing
        txtDoctorNamePast.Text = ""
        PasttxtHIVStatus.Text = ""
        PasttxtSTIStatus.Text = ""
        PasttxtHIVMedication.Text = ""
        PasttxtSTIMedication.Text = ""
        PasttxthealthStatus.Text = ""
        txtDateRecordedPast.Text = ""

    End Sub

    Private Sub PopulateTreatmentDateListBox()
        Dim patientID As String = lblPatientID.Text
        Dim distinctDates As List(Of DateTime) = GetDistinctTreatmentDatesHAS(patientID)
        ListBoxTreatment.DataSource = Nothing
        ListBoxTreatment.Items.Clear()
        ListBoxTreatment.DataSource = distinctDates
        ListBoxTreatment.DisplayMember = "ToString"


        ListBoxTreatment.FormatString = "yyyy-MM-dd HH:mm:ss"
    End Sub






    Private Sub btnSaveData_Click(sender As Object, e As EventArgs) Handles btnSaveData.Click
        Dim transactionID As Integer = Integer.Parse(lblTransactionID.Text)
        Dim patientID As String = lblPatientID.Text
        Dim transactionDate As DateTime = DateTime.Now

        If DataGridViewSelectedMeds.Rows.Count = 0 OrElse DataGridViewSelectedMeds.Rows(0).IsNewRow Then
            MessageBox.Show("No data to save. Please add medicine details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return ' Exit the event handler if validation fails
        End If

        ' Ask for confirmation before saving
        Dim confirmResult As DialogResult = MessageBox.Show("Are you sure you want to save the data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If confirmResult = DialogResult.Yes Then
            Try
                SaveMedicineOutData(transactionID, transactionDate, patientID)
                SaveMedicineOutDetailsFromDataGridView(transactionID, DataGridViewSelectedMeds)

                MessageBox.Show("Data saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ClearDataGridViews()
                UpdateTransactionIDLabel()
            Catch ex As Exception
                MessageBox.Show("Error saving data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            ' User clicked No, do nothing or handle accordingly
        End If
    End Sub



End Class