Imports MySql.Data.MySqlClient
Public Class HAS_PatientList
    Private Sub HAS_PatientList_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LoadTreatmentData()
        Try
            If txtSearchHIVStatus.SelectedIndex <> -1 Then
                Dim selectedHIVStatus As String = txtSearchHIVStatus.SelectedItem.ToString()

                Dim selectQuery As String = "SELECT DoctorName, CONCAT(P.FirstName, ' ', P.LastName) AS PatientName, " &
                                    "HIV_AIDS_Status, STI_Status, DateRecorded " &
                                    "FROM treatmentrecordhas T " &
                                    "INNER JOIN Patients P ON T.PatientID = P.PatientID " &
                                    "WHERE HIV_AIDS_Status = @SearchStatus OR STI_Status = @SearchStatus"

                Dim searchValue As String = txtSearchHIVStatus.Text

                Dim parameters As New List(Of MySqlParameter) From {
                    New MySqlParameter("@SearchStatus", searchValue)
                }

                Dim dataTable As DataTable = ExecuteQuery(selectQuery, parameters)

                PatientDataInformation.DataSource = dataTable
            Else
                MessageBox.Show("Please select a condition type from the searchbox.", " Type Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            Console.WriteLine($"Error loading treatment data: {ex.Message}")
        End Try
    End Sub

    Private Sub LoadTreatmentDataByDateRange(startDate As DateTime, endDate As DateTime)
        Try
            If txtSearchHIVStatus.SelectedIndex <> -1 Then
                Dim selectedHIVStatus As String = txtSearchHIVStatus.SelectedItem.ToString()

                Dim selectQuery As String = "SELECT DoctorName, CONCAT(P.FirstName, ' ', P.LastName) AS PatientName, " &
                                        "HIV_AIDS_Status, STI_Status, DateRecorded " &
                                        "FROM treatmentrecordhas T " &
                                        "INNER JOIN Patients P ON T.PatientID = P.PatientID " &
                                        "WHERE (HIV_AIDS_Status = @SearchStatus OR STI_Status = @SearchStatus) " &
                                        "AND DateRecorded BETWEEN @StartDate AND @EndDate"

                Dim searchValue As String = txtSearchHIVStatus.Text

                Dim parameters As New List(Of MySqlParameter) From {
                    New MySqlParameter("@SearchStatus", searchValue),
                    New MySqlParameter("@StartDate", startDate),
                    New MySqlParameter("@EndDate", endDate)
                }

                Dim dataTable As DataTable = ExecuteQuery(selectQuery, parameters)

                PatientDataInformation.DataSource = dataTable
                DisplayRowCount()
            Else
                MessageBox.Show("Please select a condition type from the searchbox.", " Type Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            Console.WriteLine($"Error loading treatment data: {ex.Message}")
        End Try
    End Sub

    Private Sub SearchPatientTest_Click(sender As Object, e As EventArgs) Handles SearchPatientTest.Click
        LoadTreatmentData()
        DisplayRowCount()
    End Sub

    Private Sub SearchWithDate_Click(sender As Object, e As EventArgs) Handles SearchWithDate.Click
        If datePickerStart.Checked AndAlso datePickerEnd.Checked Then
            Dim startDate As DateTime = datePickerStart.Value
            Dim endDate As DateTime = datePickerEnd.Value

            If startDate <= endDate Then
                LoadTreatmentDataByDateRange(startDate, endDate)
                DisplayRowCount()
            Else
                MessageBox.Show("End date must be equal to or after the start date.", "Invalid Date Range", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            MessageBox.Show("Please select both start and end dates.", "Date Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Public ReadOnly Property StartDate As Date
        Get
            Return datePickerStart.Value
        End Get
    End Property

    Public ReadOnly Property EndDate As Date
        Get
            Return datePickerEnd.Value
        End Get
    End Property

    Private Sub DisplayRowCount()
        Dim rowCount As Integer = PatientDataInformation.RowCount

        LabelRowCount.Text = $"Number of Rows: {rowCount}"
    End Sub


End Class