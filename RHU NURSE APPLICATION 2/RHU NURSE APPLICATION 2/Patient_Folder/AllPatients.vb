Public Class AllPatients
    Private Sub AllPatients_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPatients()
    End Sub

    Private Sub LoadPatients()
        Try
            Dim patientsTable As DataTable = GetAllPatients()

            If patientsTable IsNot Nothing Then
                dataGridViewPatients.DataSource = patientsTable
            Else
                MessageBox.Show("Error retrieving patients.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ComboBoxSearchOptions_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxSearchOptions.SelectedIndexChanged
        Try
            Dim selectedOption As String = If(ComboBoxSearchOptions.SelectedItem IsNot Nothing, ComboBoxSearchOptions.SelectedItem.ToString(), String.Empty)

            Select Case selectedOption
                Case "Full Name Search"
                    Dim fullName As String = InputBox("Enter full name to search:", "Search Patients")


                    If Not String.IsNullOrEmpty(fullName) Then
                        DisplayPatientsByFullName(fullName)
                    End If

                Case "Date Search"
                    Dim dateString As String = InputBox("Enter date (format: yyyy-MM-dd) to search:", "Search Patients")


                    If Not String.IsNullOrEmpty(dateString) Then

                        If DateTime.TryParse(dateString, Nothing) Then
                            DisplayPatientsByDate(dateString)
                        Else
                            MessageBox.Show("Invalid date format. Please enter a valid date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            DisplayAllPatients()
                        End If
                    End If

                Case "General Search"
                    Dim searchValue As String = InputBox("Enter search term:", "Search Patients")


                    If Not String.IsNullOrEmpty(searchValue) Then
                        DisplayPatientsByGeneralSearch(searchValue)
                    End If

                Case "Display All"
                    DisplayAllPatients()
            End Select

            ComboBoxSearchOptions.SelectedIndex = -1

        Catch ex As Exception
            MessageBox.Show($"Error performing search: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub DisplayPatientsByFullName(fullName As String)
        Dim searchResult As DataTable = GetPatientsByFullName(fullName)
        dataGridViewPatients.DataSource = Nothing
        dataGridViewPatients.DataSource = searchResult
    End Sub

    Private Sub DisplayPatientsByDate(dateString As String)
        Dim searchResult As DataTable = SearchPatientsByDate(dateString)
        dataGridViewPatients.DataSource = Nothing
        dataGridViewPatients.DataSource = searchResult
    End Sub

    Private Sub DisplayPatientsByGeneralSearch(searchValue As String)
        Dim searchResult As DataTable = GeneralSearchPatients2(searchValue)
        dataGridViewPatients.DataSource = Nothing
        dataGridViewPatients.DataSource = searchResult
    End Sub

    Private Sub DisplayAllPatients()
        Dim allPatients As DataTable = GetAllPatients()
        dataGridViewPatients.DataSource = Nothing
        dataGridViewPatients.DataSource = allPatients
    End Sub


    Private Sub PrintToPDF_Click(sender As Object, e As EventArgs) Handles PrintToPDF.Click
        PrintDocumentPatient.DefaultPageSettings.Landscape = True
        PrintPreviewPatient.WindowState = FormWindowState.Maximized
        PrintPreviewPatient.Document = PrintDocumentPatient
        PrintPreviewPatient.PrintPreviewControl.AutoZoom = 1
        PrintPreviewPatient.ShowDialog()
    End Sub


    Private mRow As Integer = 0
    Private newPage As Boolean = True
    Private Const SmallFontSize As Single = 10.0F

    Private Sub PrintDocumentPatient_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocumentPatient.PrintPage
        Try
            dataGridViewPatients.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)

            e.PageSettings.PaperSize = PrintDocumentPatient.DefaultPageSettings.PaperSize

            Dim logoImage As Image = My.Resources.logoCYN
            Dim format As New StringFormat
            format.Alignment = StringAlignment.Center

            e.Graphics.DrawImage(logoImage, 50, 40, 100, 100)
            e.Graphics.DrawString($"List Of All Patient Of RHU Cauayan City ", New Font("century gothic", SmallFontSize, FontStyle.Bold),
                                  Brushes.Black, New Point(555, 70), format)
            e.Graphics.DrawString($"Date Printed: {DateTime.Now}", New Font("century gothic", SmallFontSize, FontStyle.Bold),
                                  Brushes.Black, New Point(555, 111), format)
            e.Graphics.DrawString($"PRINTED BY: {NursePanel.NurseNameLBL.Text}", New Font("century gothic", SmallFontSize, FontStyle.Bold),
                                  Brushes.Black, New Point(555, 130), format)

            Dim fnt As StringFormat = New StringFormat(StringFormatFlags.LineLimit)
            fnt.LineAlignment = StringAlignment.Center
            fnt.Trimming = StringTrimming.EllipsisCharacter
            Dim y As Integer = 180
            Dim x As Integer = 10
            Dim h As Integer = 25
            Dim rc As Rectangle
            Dim row As DataGridViewRow

            If newPage Then
                row = dataGridViewPatients.Rows(mRow)
                x = 60
                For Each cell As DataGridViewCell In row.Cells
                    If cell.Visible Then
                        rc = New Rectangle(x, y, cell.Size.Width, cell.Size.Height)

                        e.Graphics.FillRectangle(Brushes.White, rc)
                        e.Graphics.DrawRectangle(Pens.Black, rc)
                        e.Graphics.DrawString(dataGridViewPatients.Columns(cell.ColumnIndex).HeaderText,
                                              New Font("century gothic", SmallFontSize), Brushes.Black, rc, fnt)

                        x += rc.Width
                        h = Math.Max(h, rc.Height)
                    End If
                Next
                y += h
            End If

            newPage = False
            Dim displayNow As Integer

            For displayNow = mRow To dataGridViewPatients.RowCount - 1
                row = dataGridViewPatients.Rows(displayNow)
                x = 60
                h = 0

                For Each cell As DataGridViewCell In row.Cells
                    If cell.Visible Then
                        rc = New Rectangle(x, y, cell.Size.Width, cell.Size.Height)
                        e.Graphics.DrawRectangle(Pens.Black, rc)
                        fnt.Alignment = StringAlignment.Near
                        rc.Offset(1, 0)

                        e.Graphics.DrawString(cell.FormattedValue.ToString(),
                            New Font("century gothic", SmallFontSize), Brushes.Black, rc, fnt)

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



End Class