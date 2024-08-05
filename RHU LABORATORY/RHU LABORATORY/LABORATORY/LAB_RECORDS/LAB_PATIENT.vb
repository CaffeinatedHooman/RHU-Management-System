Imports WIA
Imports System.IO

Public Class LAB_PATIENT

    Private Sub btnOpenImage_Click(sender As Object, e As EventArgs) Handles btnOpenImage.Click
        Dim openFileDialog As New OpenFileDialog()

        openFileDialog.Filter = "JPEG Files|*.jpg;*.jpeg|PNG Files|*.png|All Files|*.*"


        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Dim imagePath As String = openFileDialog.FileName
            DisplayImage(imagePath)
        End If
    End Sub


    Private Sub DisplayImage(imagePath As String)

        If System.IO.File.Exists(imagePath) Then

            picLabResultImage.Image = Image.FromFile(imagePath)

            picLabResultImage.SizeMode = PictureBoxSizeMode.Zoom
        Else
            MessageBox.Show("The selected file does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles picLabResultImage.Click
        If picLabResultImage.Image IsNot Nothing Then
            Dim imageViewerForm As New ImageViewerForm(picLabResultImage.Image)
            imageViewerForm.ShowDialog()
        End If
    End Sub





    Private Sub btnSaveLaboratoryResult_Click(sender As Object, e As EventArgs) Handles btnSaveLaboratoryResult.Click
        If picLabResultImage.Image IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(txtResultFindings.Text) Then
            If txtResultFindings.Text.Length < 10 Then
                MessageBox.Show("Result findings must be at least 10 characters long.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Dim patientID As String = lblPatientID.Text
            Dim patientName As String = PatientSeachList.SelectedItem.ToString()

            Dim confirmationMessage As String = $"Are you sure you want to save the record for Name: {patientName}?"
            Dim confirmationResult As DialogResult = MessageBox.Show(confirmationMessage, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If confirmationResult = DialogResult.Yes Then
                Dim resultDescription As String = txtResultFindings.Text
                Dim labResultImage As Byte() = GetImageBytesFromPictureBox(picLabResultImage)
                Dim inChargePerson As String = Laboratory_Panel.lblPersonInCharge.Text
                Dim recordDate As DateTime = DateTime.Now
                Dim laboratoryName As String = Laboratory_Panel.lblLaboratoryName.Text

                Dim resultMessage As String = AddLaboratoryResult(patientID, resultDescription, labResultImage, inChargePerson, recordDate, laboratoryName)

                MessageBox.Show(resultMessage, "Laboratory Result Status", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else

            End If
        ElseIf picLabResultImage.Image Is Nothing Then
            MessageBox.Show("No image loaded. Please select an image.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf String.IsNullOrWhiteSpace(txtResultFindings.Text) Then
            MessageBox.Show("Result findings cannot be empty. Please enter findings.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


    Private Sub ClearLabContent()
        picLabResultImage.Image = Nothing
        txtResultFindings.Clear()

        btnOpenImage.Enabled = False
        btnSaveLaboratoryResult.Enabled = False
    End Sub



    Private Function GetImageBytesFromPictureBox(pictureBox As PictureBox) As Byte()
        Try
            If pictureBox.Image IsNot Nothing Then
                Using stream As New IO.MemoryStream()
                    pictureBox.Image.Save(stream, Imaging.ImageFormat.Jpeg)
                    Return stream.ToArray()
                End Using
            Else
                Console.WriteLine("Error: PictureBox.Image is null.")
                Return New Byte() {}
            End If
        Catch ex As Exception
            Console.WriteLine($"Error converting image: {ex.ToString()}")
            Return Nothing
        End Try
    End Function



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
                btnOpenImage.Enabled = True
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
        ClearLabContent()
    End Sub

    Private Sub ClearInfoExisting_Click(sender As Object, e As EventArgs) Handles ClearInfoExisting.Click
        ClearPatientDetails()
    End Sub

    Private Sub txtResultFindings_TextChanged(sender As Object, e As EventArgs) Handles txtResultFindings.TextChanged
        btnSaveLaboratoryResult.Enabled = (txtResultFindings.Text.Length >= 10)
    End Sub

    Private Sub LAB_PATIENT_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class