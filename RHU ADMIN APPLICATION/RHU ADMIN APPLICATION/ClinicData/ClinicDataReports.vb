
Imports System.IO
Imports System.Windows.Forms.DataVisualization.Charting
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports MySql.Data.MySqlClient
Public Class ClinicDataReports
    Private Sub ClinicDataReports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateIllnessChart()
        UpdateReactiveChart()
        UpdateTBTestChart()
        UpdatePregnancyTestChart()
    End Sub

    Public Function GetIllnessCounts(ByVal year As Integer) As Dictionary(Of String, Integer)
        Dim illnessCounts As New Dictionary(Of String, Integer)()

        Try
            Dim sql As String = "SELECT I.IllnessName, COUNT(T.PatientIllnessID) AS IllnessCount " &
                        "FROM Treatment T " &
                        "INNER JOIN Illnesses I ON T.PatientIllnessID = I.IllnessID " &
                        $"WHERE YEAR(T.DateRecorded) = {year} " &
                        "GROUP BY I.IllnessName"

            Dim resultTable As DataTable = ExecuteQuery(sql, Nothing)

            For Each row As DataRow In resultTable.Rows
                Dim illnessName As String = row("IllnessName").ToString()
                Dim illnessCount As Integer = Convert.ToInt32(row("IllnessCount"))
                illnessCounts.Add(illnessName, illnessCount)
            Next
        Catch ex As Exception
            Console.WriteLine($"Error retrieving illness counts: {ex.Message}")
        End Try

        Return illnessCounts
    End Function

    Public Function GetReactiveCounts(ByVal year As Integer) As Dictionary(Of String, Integer)
        Dim reactiveCounts As New Dictionary(Of String, Integer)()

        Try
            Dim sql As String = "SELECT 'HIV_AIDS' AS StatusType, COUNT(*) AS Count " &
                            "FROM treatmentrecordhas " &
                            $"WHERE YEAR(DateRecorded) = {year} AND HIV_AIDS_Status = 'REACTIVE' " &
                            "UNION ALL " &
                            "SELECT 'STI' AS StatusType, COUNT(*) AS Count " &
                            "FROM treatmentrecordhas " &
                            $"WHERE YEAR(DateRecorded) = {year} AND STI_Status = 'REACTIVE'"

            Dim resultTable As DataTable = ExecuteQuery(sql, Nothing)

            For Each row As DataRow In resultTable.Rows
                Dim statusType As String = row("StatusType").ToString()
                Dim count As Integer = Convert.ToInt32(row("Count"))
                reactiveCounts.Add(statusType, count)
            Next
        Catch ex As Exception
            Console.WriteLine($"Error retrieving reactive counts: {ex.Message}")
        End Try

        Return reactiveCounts
    End Function

    Public Function GetTBTestCounts(ByVal year As Integer) As Dictionary(Of String, Integer)
        Dim tbTestCounts As New Dictionary(Of String, Integer)()

        Try
            Dim sql As String = "SELECT TBTest, COUNT(*) AS Count " &
                            "FROM treatment_tb " &
                            "WHERE YEAR(DateRecorded) = @Year AND TBTest IN ('positive', 'negative') " &
                            "GROUP BY TBTest"

            Dim parameters As New List(Of MySqlParameter)()
            parameters.Add(New MySqlParameter("@Year", year))

            Dim resultTable As DataTable = ExecuteQuery(sql, parameters)

            For Each row As DataRow In resultTable.Rows
                Dim testResult As String = row("TBTest").ToString()
                Dim count As Integer = Convert.ToInt32(row("Count"))
                tbTestCounts.Add(testResult, count)
            Next
        Catch ex As Exception
            Console.WriteLine($"Error retrieving TB test counts: {ex.Message}")
        End Try

        Return tbTestCounts
    End Function

    Public Function GetPregnancyTestCounts(ByVal year As Integer) As Dictionary(Of String, Integer)
        Dim pregnancyTestCounts As New Dictionary(Of String, Integer)()

        Try
            Dim sql As String = "SELECT PregnancyTest, COUNT(*) AS Count " &
                            "FROM treatment_motherhood " &
                            "WHERE YEAR(DateRecorded) = @Year AND PregnancyTest IN ('positive', 'negative') " &
                            "GROUP BY PregnancyTest"

            Dim parameters As New List(Of MySqlParameter)()
            parameters.Add(New MySqlParameter("@Year", year))

            Dim resultTable As DataTable = ExecuteQuery(sql, parameters)

            For Each row As DataRow In resultTable.Rows
                Dim testResult As String = row("PregnancyTest").ToString()
                Dim count As Integer = Convert.ToInt32(row("Count"))
                pregnancyTestCounts.Add(testResult, count)
            Next
        Catch ex As Exception
            Console.WriteLine($"Error retrieving PregnancyTest counts: {ex.Message}")
        End Try

        Return pregnancyTestCounts
    End Function




    Private Sub UpdateTBTestChart()
        Dim currentYear As Integer = DateTime.Now.Year
        Dim tbTestCounts As Dictionary(Of String, Integer) = GetTBTestCounts(currentYear)

        Chart3.Series.Clear()
        Chart3.ChartAreas.Clear()
        Chart3.ChartAreas.Add("ChartArea3")

        Chart3.Titles.Add($"TB Test Distribution Chart - {currentYear}")

        Dim series As New Series("TBTestCounts")
        series.ChartType = SeriesChartType.Pie

        For Each kvp As KeyValuePair(Of String, Integer) In tbTestCounts
            Dim label As String = $"{kvp.Key} ({kvp.Value})"
            series.Points.AddXY(label, kvp.Value)
        Next

        Chart3.Series.Add(series)
    End Sub


    Private Sub UpdateIllnessChart()
        Dim currentYear As Integer = DateTime.Now.Year
        Dim illnessCounts As Dictionary(Of String, Integer) = GetIllnessCounts(currentYear)

        Chart1.Series.Clear()
        Chart1.ChartAreas.Clear()
        Chart1.ChartAreas.Add("ChartArea1")

        Chart1.Titles.Add($"Illness Distribution Chart - {currentYear}")

        Dim series As New Series("IllnessCounts")
        series.ChartType = SeriesChartType.Pie

        For Each kvp As KeyValuePair(Of String, Integer) In illnessCounts
            Dim label As String = $"{kvp.Key} ({kvp.Value})"
            series.Points.AddXY(label, kvp.Value)
        Next

        Chart1.Series.Add(series)
    End Sub

    Private Sub UpdateReactiveChart()
        Dim currentYear As Integer = DateTime.Now.Year
        Dim reactiveCounts As Dictionary(Of String, Integer) = GetReactiveCounts(currentYear)

        Chart2.Series.Clear()
        Chart2.ChartAreas.Clear()
        Chart2.ChartAreas.Add("ChartArea2")

        Chart2.Titles.Add($"Reactive HIV/AIDS and STI Status Chart - {currentYear}")

        Dim series As New Series("ReactiveCounts")
        series.ChartType = SeriesChartType.Pie

        For Each kvp As KeyValuePair(Of String, Integer) In reactiveCounts
            Dim label As String = $"{kvp.Key} ({kvp.Value})"
            series.Points.AddXY(label, kvp.Value)
        Next

        Chart2.Series.Add(series)
    End Sub


    Private Sub UpdatePregnancyTestChart()
        Dim currentYear As Integer = DateTime.Now.Year
        Dim pregnancyTestCounts As Dictionary(Of String, Integer) = GetPregnancyTestCounts(currentYear)

        Chart4.Series.Clear()
        Chart4.ChartAreas.Clear()
        Chart4.ChartAreas.Add("ChartArea4")

        Chart4.Titles.Add($"Pregnancy Test Distribution Chart - {currentYear}")

        Dim series As New Series("PregnancyTestCounts")
        series.ChartType = SeriesChartType.Pie

        For Each kvp As KeyValuePair(Of String, Integer) In pregnancyTestCounts
            Dim label As String = $"{kvp.Key} ({kvp.Value})"
            series.Points.AddXY(label, kvp.Value)
        Next

        Chart4.Series.Add(series)
    End Sub

    Private Function ConvertBitmapToByteArray(bitmap As Bitmap) As Byte()
        Dim stream As New MemoryStream()
        bitmap.Save(stream, System.Drawing.Imaging.ImageFormat.Png)
        Return stream.ToArray()
    End Function

    Private Sub PrintChartToPDF(chart As Chart)
        Dim doc As New Document(PageSize.A6)

        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Filter = "PDF Files|*.pdf"
        saveFileDialog.Title = "Save PDF File"
        saveFileDialog.FileName = "chart_output.pdf"

        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            Dim outputFile As String = saveFileDialog.FileName

            Dim memStream As New MemoryStream()
            Dim writer As PdfWriter = PdfWriter.GetInstance(doc, New FileStream(outputFile, FileMode.Create))

            doc.Open()

            Dim chartImage As Bitmap = New Bitmap(chart.Width, chart.Height)
            Dim chartBounds As System.Drawing.Rectangle = New System.Drawing.Rectangle(0, 0, chart.Width, chart.Height)
            chart.DrawToBitmap(chartImage, chartBounds)

            Dim chartBytes As Byte() = ConvertBitmapToByteArray(chartImage)

            Dim image As iTextSharp.text.Image = iTextSharp.text.Image.GetInstance(chartBytes)

            image.ScaleToFit(doc.PageSize.Width - doc.LeftMargin - doc.RightMargin, doc.PageSize.Height - doc.TopMargin - doc.BottomMargin)

            image.Alignment = iTextSharp.text.Image.ALIGN_CENTER

            doc.Add(image)

            doc.Close()
            writer.Close()
            memStream.Dispose()

            MessageBox.Show("Chart printed to PDF successfully.", "Print Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub



    Private Sub btnPrintChart_Click(sender As Object, e As EventArgs) Handles btnPrintChart.Click
        PrintChartToPDF(Chart1)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PrintChartToPDF(Chart2)
    End Sub

End Class