Imports MySql.Data.MySqlClient

Public Class DailyReportPatient
    Private Sub DailyReportPatient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadQueueData()
        LoadClinicNamesToComboBox()
    End Sub

    Public Sub LoadQueueData()
        Try
            Dim sql As String = "SELECT CONCAT(D.FirstName, ' ', D.LastName) AS DoctorName, " &
                            "CONCAT(P.FirstName, ' ', P.LastName) AS PatientName, " &
                            "Q.QueueStatus, Q.QueueDate, Q.Clinic " &
                            "FROM queue Q " &
                            "INNER JOIN doctors D ON Q.DoctorID = D.DoctorID " &
                            "INNER JOIN patients P ON Q.PatientID = P.PatientID"

            Dim doctorQueueDataTable As DataTable = ExecuteQuery(sql)

            If doctorQueueDataTable.Rows.Count > 0 Then
                dgvQueueDetailsDay.DataSource = doctorQueueDataTable
            Else
                dgvQueueDetailsDay.DataSource = Nothing
                'MessageBox.Show("No records found in the doctor queue.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show($"An error occurred while loading doctor queue data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub LoadQueueDataByDate(selectedDate As Date)
        Try
            Dim formattedDate As String = selectedDate.ToString("yyyy-MM-dd")

            Dim sql As String = "SELECT CONCAT(D.FirstName, ' ', D.LastName) AS DoctorName, " &
                            "CONCAT(P.FirstName, ' ', P.LastName) AS PatientName, " &
                            "Q.QueueStatus, Q.QueueDate, Q.Clinic " &
                            "FROM queue Q " &
                            "INNER JOIN doctors D ON Q.DoctorID = D.DoctorID " &
                            "INNER JOIN patients P ON Q.PatientID = P.PatientID " &
                            "WHERE DATE(Q.QueueDate) = @SelectedDate"

            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@SelectedDate", formattedDate)
        }

            Dim doctorQueueDataTable As DataTable = ExecuteQuery(sql, parameters)

            If doctorQueueDataTable.Rows.Count > 0 Then
                dgvQueueDetailsDay.DataSource = doctorQueueDataTable
            Else
                dgvQueueDetailsDay.DataSource = Nothing
                MessageBox.Show("No records found in the queue for the selected date.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show($"An error occurred while loading doctor queue data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub RefreshDateVTN_Click(sender As Object, e As EventArgs) Handles RefreshDateVTN.Click
        LoadQueueData()
        ComboBoxClinic.SelectedIndex = -1
    End Sub

    Private Sub SearchDateVTN_Click(sender As Object, e As EventArgs) Handles SearchDateVTN.Click
        Try
            LoadQueueDataByDate(DateTimePicker1.Value)
        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub SearchByClinicName(clinicName As String)
        Try
            Dim sql As String = "SELECT CONCAT(D.FirstName, ' ', D.LastName) AS DoctorName, " &
                            "CONCAT(P.FirstName, ' ', P.LastName) AS PatientName, " &
                            "Q.QueueStatus, Q.QueueDate, Q.Clinic " &
                            "FROM queue Q " &
                            "INNER JOIN doctors D ON Q.DoctorID = D.DoctorID " &
                            "INNER JOIN patients P ON Q.PatientID = P.PatientID " &
                            "WHERE Q.Clinic = @ClinicName"

            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@ClinicName", clinicName)
        }

            Dim doctorQueueDataTable As DataTable = ExecuteQuery(sql, parameters)

            If doctorQueueDataTable.Rows.Count > 0 Then
                dgvQueueDetailsDay.DataSource = doctorQueueDataTable
            Else
                dgvQueueDetailsDay.DataSource = Nothing
                MessageBox.Show($"No records found for clinic '{clinicName}'.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show($"An error occurred while searching for clinic data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Public Function GetDistinctClinicNames() As List(Of String)
        Dim clinicNames As New List(Of String)

        Try
            Dim sql As String = "SELECT DISTINCT Clinic FROM queue WHERE QueueStatus = 'Waiting'"
            Dim clinicDataTable As DataTable = ExecuteQuery(sql)

            For Each row As DataRow In clinicDataTable.Rows
                clinicNames.Add(row("Clinic").ToString())
            Next
        Catch ex As Exception
            MessageBox.Show($"Error loading clinic names: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return clinicNames
    End Function


    Private Sub LoadClinicNamesToComboBox()
        Try
            Dim clinicNames As List(Of String) = GetDistinctClinicNames()

            ComboBoxClinic.Items.Clear()
            ComboBoxClinic.Items.AddRange(clinicNames.ToArray())
        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub ComboBoxClinic_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxClinic.SelectedIndexChanged
        Try
            If ComboBoxClinic.SelectedItem IsNot Nothing Then
                Dim selectedClinic As String = ComboBoxClinic.SelectedItem.ToString()
                SearchByClinicName(selectedClinic)
            End If
        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Public Sub SearchByClinicAndDate(clinicName As String, selectedDate As Date)
        Try
            Dim formattedDate As String = selectedDate.ToString("yyyy-MM-dd")

            Dim sql As String = "SELECT CONCAT(D.FirstName, ' ', D.LastName) AS DoctorName, " &
                            "CONCAT(P.FirstName, ' ', P.LastName) AS PatientName, " &
                            "Q.QueueStatus, Q.QueueDate, Q.Clinic " &
                            "FROM queue Q " &
                            "INNER JOIN doctors D ON Q.DoctorID = D.DoctorID " &
                            "INNER JOIN patients P ON Q.PatientID = P.PatientID " &
                            "WHERE Q.Clinic = @ClinicName AND DATE(Q.QueueDate) = @SelectedDate"

            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@ClinicName", clinicName),
            New MySqlParameter("@SelectedDate", formattedDate)
        }

            Dim doctorQueueDataTable As DataTable = ExecuteQuery(sql, parameters)

            If doctorQueueDataTable.Rows.Count > 0 Then
                dgvQueueDetailsDay.DataSource = doctorQueueDataTable
            Else
                dgvQueueDetailsDay.DataSource = Nothing
                MessageBox.Show($"No records found for clinic '{clinicName}' on {selectedDate.ToShortDateString()}.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show($"An error occurred while searching for clinic data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ClinicAndDateSearchVTN_Click(sender As Object, e As EventArgs) Handles ClinicAndDateSearchVTN.Click
        Try
            If ComboBoxClinic.SelectedItem IsNot Nothing Then
                Dim selectedClinic As String = ComboBoxClinic.SelectedItem.ToString()

                If DateTimePicker1.Value.Date <= Date.Today Then
                    Dim selectedDate As Date = DateTimePicker1.Value
                    SearchByClinicAndDate(selectedClinic, selectedDate)
                Else
                    MessageBox.Show("Please select a date that is not in the future.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show("Please select a clinic from the ComboBox.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



















    Private Sub DisplaySearchResults(searchResult As DataTable)
        dgvQueueDetailsDay.AutoGenerateColumns = True
        dgvQueueDetailsDay.DataSource = searchResult
    End Sub

    Private Sub ClearLogs()
        dgvQueueDetailsDay.DataSource = Nothing
        dgvQueueDetailsDay.Rows.Clear()
        dgvQueueDetailsDay.Columns.Clear()
    End Sub
    Private bitmap As Bitmap
    Private mRow As Integer = 0
    Private newPage As Boolean = True

    Private Sub PrintDocumentDetailsDay_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocumentDetailsDay.PrintPage
        Try
            e.PageSettings.PaperSize = PrintDocumentDetailsDay.DefaultPageSettings.PaperSize

            ' Auto-resize columns based on content
            dgvQueueDetailsDay.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)

            Dim logoImage As Image = My.Resources.logoCYN
            Dim format As New StringFormat
            format.Alignment = StringAlignment.Center

            e.Graphics.DrawImage(logoImage, 50, 40, 100, 100)
            e.Graphics.DrawString($"Data Logs Report For Daily Patients ", New Font("century gothic", 10, FontStyle.Bold),
                              Brushes.Black, New Point(555, 70), format)
            e.Graphics.DrawString($"Date Printed: {DateTime.Now}", New Font("century gothic", 10, FontStyle.Bold),
                              Brushes.Black, New Point(555, 111), format)
            e.Graphics.DrawString($"PRINTED BY: {NursePanel.NurseNameLBL.Text}", New Font("century gothic", 10, FontStyle.Bold),
                              Brushes.Black, New Point(555, 130), format)

            Dim fnt As StringFormat = New StringFormat(StringFormatFlags.LineLimit)
            fnt.LineAlignment = StringAlignment.Center
            fnt.Trimming = StringTrimming.EllipsisCharacter
            Dim y As Integer = 180
            Dim x As Integer = 30
            Dim h As Integer = 20
            Dim rc As Rectangle
            Dim row As DataGridViewRow

            If newPage Then
                rc = New Rectangle(x, y, 50, h)
                e.Graphics.FillRectangle(Brushes.White, rc)
                e.Graphics.DrawRectangle(Pens.Black, rc)
                e.Graphics.DrawString("#", New Font("century gothic", 10, FontStyle.Regular), Brushes.Black, rc, fnt)
                x += rc.Width

                For Each column As DataGridViewColumn In dgvQueueDetailsDay.Columns
                    If column.Visible Then
                        rc = New Rectangle(x, y, column.Width, h)

                        e.Graphics.FillRectangle(Brushes.White, rc)
                        e.Graphics.DrawRectangle(Pens.Black, rc)
                        e.Graphics.DrawString(column.HeaderText, New Font("century gothic", 10, FontStyle.Regular), Brushes.Black, rc, fnt)

                        x += rc.Width
                    End If
                Next
                y += h
            End If

            newPage = False
            Dim displayNow As Integer

            For displayNow = mRow To dgvQueueDetailsDay.RowCount - 1
                row = dgvQueueDetailsDay.Rows(displayNow)
                x = 30
                h = 0

                ' Add row number
                rc = New Rectangle(x, y, 50, row.Height)
                e.Graphics.DrawRectangle(Pens.Black, rc)
                fnt.Alignment = StringAlignment.Near
                rc.Offset(1, 0)
                e.Graphics.DrawString((displayNow + 1).ToString(), New Font("century gothic", 10, FontStyle.Regular), Brushes.Black, rc, fnt)
                x += rc.Width

                For Each column As DataGridViewColumn In dgvQueueDetailsDay.Columns
                    If column.Visible Then
                        rc = New Rectangle(x, y, column.Width, row.Height)
                        e.Graphics.DrawRectangle(Pens.Black, rc)
                        fnt.Alignment = StringAlignment.Near
                        rc.Offset(1, 0)

                        e.Graphics.DrawString(row.Cells(column.Index).FormattedValue.ToString(),
                New Font("century gothic", 10, FontStyle.Regular), Brushes.Black, rc, fnt)

                        x += rc.Width
                        h = Math.Max(h, rc.Height)
                    End If
                Next

                y += h

                If y + h > e.MarginBounds.Bottom Then
                    ' New page needed
                    e.HasMorePages = True
                    newPage = True
                    mRow = displayNow + 1
                    Exit Sub
                End If
            Next

            ' No more rows to print
            e.HasMorePages = False
            newPage = True
            mRow = 0

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub














    Private Sub PrintToPDF_Click(sender As Object, e As EventArgs) Handles PrintToPDF.Click
        PrintDocumentDetailsDay.DefaultPageSettings.Landscape = True
        PrintPreviewDetailsDay.WindowState = FormWindowState.Maximized
        PrintPreviewDetailsDay.Document = PrintDocumentDetailsDay
        PrintPreviewDetailsDay.PrintPreviewControl.AutoZoom = 1
        PrintPreviewDetailsDay.ShowDialog()
    End Sub
End Class
