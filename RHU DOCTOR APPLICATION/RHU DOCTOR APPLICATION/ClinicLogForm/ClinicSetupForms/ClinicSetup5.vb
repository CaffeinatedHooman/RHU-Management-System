Public Class ClinicSetup5
    Private Sub ClinicSetup5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadClinicNames()

        Dim LocalClinicName As String = My.Settings.ClinicButtonName5

        If String.IsNullOrEmpty(LocalClinicName) Then
            LocalClinicName = "SetupClinicName"
        End If

        Label1.Text = LocalClinicName

        Dim savedAccessCode As String = My.Settings.SelectedAccessCodeClinic5

        If String.IsNullOrEmpty(savedAccessCode) Then
            savedAccessCode = "DefaultAccessCode"
        End If

        LbLSelectedAccessCodeClinic5.Text = savedAccessCode
    End Sub

    Private Sub LoadClinicNames()
        Try
            cmbClinics.Items.Clear()

            Dim clinicsTable As DataTable = GetAllClinics()

            If clinicsTable IsNot Nothing AndAlso clinicsTable.Rows.Count > 0 Then
                For Each row As DataRow In clinicsTable.Rows
                    cmbClinics.Items.Add(row("ClinicName").ToString())
                Next
            Else
                cmbClinics.Items.Add("No clinics found.")
            End If
        Catch ex As Exception
            Console.WriteLine($"Error loading clinic names: {ex.Message}")
        End Try
    End Sub

    Private Sub cmbClinics_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbClinics.SelectedIndexChanged
        Try
            If cmbClinics.SelectedIndex <> -1 Then
                Dim selectedClinicName As String = cmbClinics.SelectedItem.ToString()

                Dim accessCode As String = GetAccessCodeByClinicName(selectedClinicName)

                LbLSelectedAccessCodeClinic5.Text = accessCode
            End If
        Catch ex As Exception
            Console.WriteLine($"Error handling clinic selection: {ex.Message}")
        End Try
    End Sub

    Private Sub btnSaveAccessCode_Click(sender As Object, e As EventArgs) Handles btnSaveAccessCode.Click
        Try
            If cmbClinics.SelectedIndex <> -1 Then
                Dim selectedClinicName As String = cmbClinics.SelectedItem.ToString()

                Dim accessCode As String = GetAccessCodeByClinicName(selectedClinicName)

                My.Settings.SelectedAccessCodeClinic5 = accessCode
                My.Settings.ClinicButtonName5 = cmbClinics.SelectedItem
                DoctorsPanel.ClinicVTN8.Text = My.Settings.ClinicButtonName5
                My.Settings.Save()

                LbLSelectedAccessCodeClinic5.Text = accessCode
                Label1.Text = My.Settings.ClinicButtonName5

                MessageBox.Show($"Access code for {selectedClinicName} is saved.{Environment.NewLine}Access Code: {accessCode}", "Access Code Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            Console.WriteLine($"Error handling clinic selection: {ex.Message}")
        End Try
    End Sub
End Class