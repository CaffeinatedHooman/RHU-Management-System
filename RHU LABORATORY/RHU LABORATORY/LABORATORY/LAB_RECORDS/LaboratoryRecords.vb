Imports System.IO
Imports MySql.Data.MySqlClient
Public Class LaboratoryRecords
    Private Sub LaboratoryRecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

            PopulateLabResultDateListBox()
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
        ClearLabResultDetails()
    End Sub





    Private Sub PopulateLabResultDateListBox()
        Dim patientID As String = lblPatientID.Text
        Dim distinctDates As List(Of DateTime) = GetDistinctLabResultDates(patientID)
        ListBoxLabResult.DataSource = Nothing
        ListBoxLabResult.Items.Clear()
        ListBoxLabResult.DataSource = distinctDates
        ListBoxLabResult.DisplayMember = "ToString"
        ListBoxLabResult.FormatString = "yyyy-MM-dd HH:mm:ss"
    End Sub

    Private Sub ListBoxLabResult_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxLabResult.SelectedIndexChanged
        Dim selectedDate As DateTime = Convert.ToDateTime(ListBoxLabResult.SelectedItem)
        DisplayLabResultDetails(selectedDate)
    End Sub
    Private Sub DisplayLabResultDetails(selectedDate As DateTime)
        Try
            Dim patientID As String = lblPatientID.Text
            Dim labResultTable As DataTable = GetLabResultsByDate(patientID, selectedDate)

            If labResultTable IsNot Nothing AndAlso labResultTable.Rows.Count > 0 Then
                Dim labResultRow As DataRow = labResultTable.Rows(0)

                Dim resultDescription As String = Convert.ToString(labResultRow("ResultDescription"))
                Dim labResultImage As Byte() = DirectCast(labResultRow("LabResultImage"), Byte())
                Dim inChargePerson As String = Convert.ToString(labResultRow("InChargePerson"))
                Dim laboratoryName As String = Convert.ToString(labResultRow("LaboratoryName"))

                txtResultDescription.Text = resultDescription
                lblInChargePerson.Text = $"In Charge Person: {inChargePerson}"
                lblLaboratoryName.Text = $"Laboratory Name: {laboratoryName}"

                If labResultImage IsNot Nothing AndAlso labResultImage.Length > 0 Then
                    picLabResult.Image = Image.FromStream(New MemoryStream(labResultImage))
                    picLabResult.SizeMode = PictureBoxSizeMode.Zoom
                Else
                    picLabResult.Image = Nothing
                End If

            Else
                ClearLabResultDetails()
            End If
        Catch ex As Exception
            MessageBox.Show($"An error occurred while displaying lab result details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub ClearLabResultDetails()
        picLabResult.Image = Nothing
        txtResultDescription.Clear()
    End Sub


End Class