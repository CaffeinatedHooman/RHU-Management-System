Public Class UserLogs
    Private filteredData As DataTable
    Private mRow As Integer = 0
    Private Const RowsPerPage As Integer = 25
    Private Const ColumnsPerPage As Integer = 5
    Private newPage As Boolean = True

    Private Sub UserLogs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayLogs()
    End Sub

    Private Sub DisplayLogs()
        If filteredData Is Nothing Then
            Dim logsTable As DataTable = GetLogs()
            If logsTable IsNot Nothing Then
                datagridviewLogs.DataSource = logsTable
            End If
        Else
            datagridviewLogs.AutoGenerateColumns = True
            datagridviewLogs.DataSource = filteredData
        End If
    End Sub

    Private Sub DisplaySearchResults(searchResult As DataTable)
        If searchResult IsNot Nothing AndAlso searchResult.Rows.Count > 0 Then
            datagridviewLogs.AutoGenerateColumns = True
            datagridviewLogs.DataSource = searchResult
            If filteredData IsNot Nothing Then
                filteredData.Clear()
                filteredData.Merge(searchResult, False, MissingSchemaAction.Add)
            Else
                filteredData = searchResult.Copy()
            End If
        Else
            MessageBox.Show("No matching records found.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub




    Private Sub PrintToPDF_Click(sender As Object, e As EventArgs) Handles PrintToPDF.Click
        PrintDocumentLogs.DefaultPageSettings.Landscape = True
        PrintPreviewLogs.WindowState = FormWindowState.Maximized
        PrintPreviewLogs.Document = PrintDocumentLogs
        PrintPreviewLogs.PrintPreviewControl.AutoZoom = 1

        If filteredData IsNot Nothing Then
            datagridviewLogs.DataSource = filteredData
        Else
            datagridviewLogs.DataSource = DirectCast(datagridviewLogs.DataSource, DataTable)
        End If

        PrintPreviewLogs.ShowDialog()
    End Sub


    Private Sub ComboBoxSearchOptions_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxSearchOptions.SelectedIndexChanged
        Try
            Dim selectedOption As String = If(ComboBoxSearchOptions.SelectedItem IsNot Nothing, ComboBoxSearchOptions.SelectedItem.ToString(), String.Empty)

            Select Case selectedOption
                Case "Full Name Search"
                    Dim fullName As String = InputBox("Enter full name to search:", "Search Patients")
                    If Not String.IsNullOrEmpty(fullName) Then
                        Dim searchResult As DataTable = GetLogsByFullName(fullName)
                        DisplaySearchResults(searchResult)
                    Else
                        MessageBox.Show("No Name Found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        DisplayLogs()
                    End If

                Case "Date Search"
                    Dim dateString As String = InputBox("Enter date (format: YYYY/mm/dd) to search:", "Search Patients")
                    If Not String.IsNullOrEmpty(dateString) AndAlso DateTime.TryParse(dateString, Nothing) Then
                        Dim searchResult As DataTable = SearchPatientsByDate(dateString)
                        DisplaySearchResults(searchResult)
                    Else
                        MessageBox.Show("Invalid date format or empty date. Please enter a valid date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        DisplayLogs()
                    End If
            End Select

            ComboBoxSearchOptions.SelectedIndex = -1

        Catch ex As Exception
            MessageBox.Show($"Error performing search: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private currentPage As Integer = 0

    Private Sub PrintDocumentLogs_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocumentLogs.PrintPage
        Try
            Dim logoImage As Image = My.Resources.logoCYN
            Dim format As New StringFormat
            format.Alignment = StringAlignment.Center

            e.Graphics.DrawImage(logoImage, 50, 40, 100, 100)
            e.Graphics.DrawString($"Data Logs Report For TimeIn & TimeOut ", New Font("century gothic", 10, FontStyle.Bold),
                              Brushes.Black, New Point(555, 70), format)
            e.Graphics.DrawString($"Date Printed: {DateTime.Now}", New Font("century gothic", 10, FontStyle.Bold),
                              Brushes.Black, New Point(555, 111), format)
            e.Graphics.DrawString($"PRINTED BY: {AdminPanel.AdminUser.Text}", New Font("century gothic", 10, FontStyle.Bold),
                              Brushes.Black, New Point(555, 130), format)

            Dim fnt As StringFormat = New StringFormat(StringFormatFlags.LineLimit)
            fnt.LineAlignment = StringAlignment.Center
            fnt.Trimming = StringTrimming.EllipsisCharacter
            Dim y As Integer = 180
            Dim x As Integer = 60
            Dim h As Integer = 25
            Dim rc As Rectangle

            If currentPage = 0 Then
                For Each column As DataGridViewColumn In datagridviewLogs.Columns
                    If column.Visible Then
                        rc = New Rectangle(x, y, column.Width, h)
                        e.Graphics.FillRectangle(Brushes.White, rc)
                        e.Graphics.DrawRectangle(Pens.Black, rc)
                        e.Graphics.DrawString(column.HeaderText, datagridviewLogs.Font, Brushes.Black, rc, fnt)
                        x += rc.Width
                    End If
                Next
                y += h
                currentPage += 1
            End If

            For rowIndex As Integer = mRow To datagridviewLogs.Rows.Count - 1
                Dim row As DataGridViewRow = datagridviewLogs.Rows(rowIndex)
                x = 60

                For Each cell As DataGridViewCell In row.Cells
                    If cell.Visible Then
                        rc = New Rectangle(x, y, cell.Size.Width, cell.Size.Height)
                        e.Graphics.FillRectangle(Brushes.White, rc)
                        e.Graphics.DrawRectangle(Pens.Black, rc)
                        e.Graphics.DrawString(cell.FormattedValue.ToString(), datagridviewLogs.Font, Brushes.Black, rc, fnt)

                        x += rc.Width
                        h = Math.Max(h, rc.Height)
                    End If
                Next

                y += h

                If y + h > e.MarginBounds.Bottom Then
                    e.HasMorePages = True
                    mRow = rowIndex + 1
                    Exit Sub
                End If
            Next


            e.HasMorePages = False
            mRow = 0
            currentPage = 0
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub



    Private Sub RefreshVTN_Click(sender As Object, e As EventArgs) Handles RefreshVTN.Click
        Try

            Dim logsTable As DataTable = GetLogs()


            If logsTable IsNot Nothing Then
                datagridviewLogs.DataSource = logsTable
                filteredData = logsTable.Copy()
            Else
                MessageBox.Show("No data found in the timelogs table.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show($"Error refreshing data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class
