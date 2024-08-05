Imports MySql.Data.MySqlClient
Public Class ClinicViewSetup
    Private Sub ClinicViewSetup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadClinicNames()
    End Sub

    Private Sub ComboBoxClinics1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxClinics1.SelectedIndexChanged
        Try
            Console.WriteLine($"Selected Clinic: {ComboBoxClinics1.SelectedItem}")

            NursePanel.ClinicLabelLoad1.Text = ComboBoxClinics1.SelectedItem.ToString()

            LoadQueueDataClinic1()
        Catch ex As Exception
            Console.WriteLine($"Error in ComboBoxClinics1_SelectedIndexChanged: {ex.Message}")
        End Try
    End Sub

    Public Sub LoadQueueDataClinic1()
        Try
            Dim selectedClinic As String = NursePanel.ClinicLabelLoad1.Text

            Dim selectQuery As String = "SELECT CONCAT(D.FirstName, ' ', D.LastName) AS DoctorName, " &
                    "CONCAT(P.FirstName, ' ', P.LastName) AS PatientName, " &
                    "Q.QueueNumber, Q.QueueStatus, Q.Clinic, Q.QueueDate " &
                    "FROM queue Q " &
                    "INNER JOIN doctors D ON Q.DoctorID = D.DoctorID " &
                    "INNER JOIN patients P ON Q.PatientID = P.PatientID " &
                    "WHERE Q.QueueStatus = 'Waiting' AND Q.Clinic LIKE @Clinic"

            Dim parameters As New List(Of MySqlParameter) From {
                New MySqlParameter("@Clinic", $"%{selectedClinic}%")
            }

            Dim dataTable As DataTable = ExecuteQuery(selectQuery, parameters)

            NursePanel.ClinicViewQueue1.DataSource = dataTable
        Catch ex As Exception
            Console.WriteLine($"Error loading queue data: {ex.Message}")
        End Try

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If ComboBoxClinics1.SelectedItem IsNot Nothing Then
            Dim selectedClinic As String = ComboBoxClinics1.SelectedItem.ToString()

            Dim confirmationResult As DialogResult = MessageBox.Show($"Do you want to save the selected clinic to : {selectedClinic}?", "Confirmation", MessageBoxButtons.YesNo)

            If confirmationResult = DialogResult.Yes Then
                NursePanel.ClinicLabelLoad1.Text = selectedClinic
                SaveLabelText()
                UpdateTabPageText()
            End If
        Else
            MessageBox.Show("Please select a clinic from the ComboBox.")
        End If
    End Sub


    Public Sub LoadLabelText()
        If My.Settings.ClinicLabelLoad1 IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(My.Settings.ClinicLabelLoad1) Then
            NursePanel.ClinicLabelLoad1.Text = My.Settings.ClinicLabelLoad1
            LoadQueueDataClinic1()
            UpdateTabPageText()
        Else
            NursePanel.ClinicLabelLoad1.Text = "Default Clinic 1"
        End If
    End Sub

    Private Sub SaveLabelText()
        My.Settings.ClinicLabelLoad1 = NursePanel.ClinicLabelLoad1.Text
        My.Settings.Save()
    End Sub

    Private Sub UpdateTabPageText()
        Dim tabPage2 As TabPage = NursePanel.Guna2TabControl1.TabPages("TabPage2")

        If tabPage2 IsNot Nothing Then
            tabPage2.Text = NursePanel.ClinicLabelLoad1.Text
        End If
    End Sub
    '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////'

    Private Sub LoadQueueDataClinic2()
        Try
            Dim selectedClinic As String = NursePanel.ClinicLabelLoad2.Text

            Dim selectQuery As String = "SELECT CONCAT(D.FirstName, ' ', D.LastName) AS DoctorName, " &
                            "CONCAT(P.FirstName, ' ', P.LastName) AS PatientName, " &
                            "Q.QueueNumber, Q.QueueStatus, Q.Clinic, Q.QueueDate " &
                            "FROM queue Q " &
                            "INNER JOIN doctors D ON Q.DoctorID = D.DoctorID " &
                            "INNER JOIN patients P ON Q.PatientID = P.PatientID " &
                            "WHERE Q.QueueStatus = 'Waiting' AND Q.Clinic LIKE @Clinic"


            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@Clinic", $"%{selectedClinic}%")
        }

            Dim dataTable As DataTable = ExecuteQuery(selectQuery, parameters)

            NursePanel.ClinicViewQueue2.DataSource = dataTable
        Catch ex As Exception
            Console.WriteLine($"Error loading queue data: {ex.Message}")
        End Try
    End Sub

    Private Sub ComboBoxClinics2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxClinics2.SelectedIndexChanged
        Try
            Console.WriteLine($"Selected Clinic: {ComboBoxClinics2.SelectedItem}")

            NursePanel.ClinicLabelLoad2.Text = ComboBoxClinics2.SelectedItem.ToString()

            LoadQueueDataClinic2()
        Catch ex As Exception
            Console.WriteLine($"Error in ComboBoxClinics1_SelectedIndexChanged: {ex.Message}")
        End Try
    End Sub
    Private Sub btnSave2_Click(sender As Object, e As EventArgs) Handles btnSave2.Click
        If ComboBoxClinics2.SelectedItem IsNot Nothing Then
            Dim selectedClinic As String = ComboBoxClinics2.SelectedItem.ToString()

            Dim confirmationResult As DialogResult = MessageBox.Show($"Do you want to save the selected clinic: {selectedClinic}?", "Confirmation", MessageBoxButtons.YesNo)

            If confirmationResult = DialogResult.Yes Then
                NursePanel.ClinicLabelLoad2.Text = selectedClinic
                SaveLabelText2()
                UpdateTabPageText2()
            End If
        Else
            MessageBox.Show("Please select a clinic from the ComboBox.")
        End If
    End Sub




    Public Sub LoadLabelText2()
        If My.Settings.ClinicLabelLoad2 IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(My.Settings.ClinicLabelLoad2) Then
            NursePanel.ClinicLabelLoad2.Text = My.Settings.ClinicLabelLoad2
            LoadQueueDataClinic2()
            UpdateTabPageText2()
        Else
            NursePanel.ClinicLabelLoad2.Text = "Default Clinic 2"
        End If
    End Sub


    Private Sub SaveLabelText2()
        My.Settings.ClinicLabelLoad2 = NursePanel.ClinicLabelLoad2.Text
        My.Settings.Save()
    End Sub

    Private Sub UpdateTabPageText2()
        Dim tabPage As TabPage = NursePanel.Guna2TabControl1.TabPages("TabPage3")

        If tabPage IsNot Nothing Then
            tabPage.Text = NursePanel.ClinicLabelLoad2.Text
        End If
    End Sub





    Public Sub LoadQueueDataClinic3()
        Try
            Dim selectedClinic As String = NursePanel.ClinicLabelLoad3.Text

            Dim selectQuery As String = "SELECT CONCAT(D.FirstName, ' ', D.LastName) AS DoctorName, " &
                            "CONCAT(P.FirstName, ' ', P.LastName) AS PatientName, " &
                            "Q.QueueNumber, Q.QueueStatus, Q.Clinic, Q.QueueDate " &
                            "FROM queue Q " &
                            "INNER JOIN doctors D ON Q.DoctorID = D.DoctorID " &
                            "INNER JOIN patients P ON Q.PatientID = P.PatientID " &
                            "WHERE Q.QueueStatus = 'Waiting' AND Q.Clinic LIKE @Clinic"


            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@Clinic", $"%{selectedClinic}%")
        }

            Dim dataTable As DataTable = ExecuteQuery(selectQuery, parameters)

            NursePanel.ClinicViewQueue3.DataSource = dataTable
        Catch ex As Exception
            Console.WriteLine($"Error loading queue data: {ex.Message}")
        End Try
    End Sub

    Private Sub ComboBoxClinics3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxClinics3.SelectedIndexChanged
        Try
            Console.WriteLine($"Selected Clinic: {ComboBoxClinics3.SelectedItem}")

            NursePanel.ClinicLabelLoad3.Text = ComboBoxClinics3.SelectedItem.ToString()

            LoadQueueDataClinic3()
        Catch ex As Exception
            Console.WriteLine($"Error in ComboBoxClinics3_SelectedIndexChanged: {ex.Message}")
        End Try
    End Sub

    Private Sub btnSave3_Click(sender As Object, e As EventArgs) Handles btnSave3.Click
        If ComboBoxClinics3.SelectedItem IsNot Nothing Then
            Dim selectedClinic As String = ComboBoxClinics3.SelectedItem.ToString()

            Dim confirmationResult As DialogResult = MessageBox.Show($"Do you want to save the selected clinic: {selectedClinic}?", "Confirmation", MessageBoxButtons.YesNo)

            If confirmationResult = DialogResult.Yes Then
                NursePanel.ClinicLabelLoad3.Text = selectedClinic
                SaveLabelText3()
                UpdateTabPageText3()
            End If
        Else
            MessageBox.Show("Please select a clinic from ComboBoxClinics3.")
        End If
    End Sub


    Public Sub LoadLabelText3()
        If My.Settings.ClinicLabelLoad3 IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(My.Settings.ClinicLabelLoad3) Then
            NursePanel.ClinicLabelLoad3.Text = My.Settings.ClinicLabelLoad3
            LoadQueueDataClinic3()
            UpdateTabPageText3()
        Else
            NursePanel.ClinicLabelLoad3.Text = "Default Clinic 3"
        End If
    End Sub


    Private Sub SaveLabelText3()
        My.Settings.ClinicLabelLoad3 = NursePanel.ClinicLabelLoad3.Text
        My.Settings.Save()
    End Sub

    Private Sub UpdateTabPageText3()
        Dim tabPage As TabPage = NursePanel.Guna2TabControl1.TabPages("TabPage4")

        If tabPage IsNot Nothing Then
            tabPage.Text = NursePanel.ClinicLabelLoad3.Text
        End If
    End Sub

    Private Sub LoadQueueDataClinic4()
        Try
            Dim selectedClinic As String = NursePanel.ClinicLabelLoad4.Text

            Dim selectQuery As String = "SELECT CONCAT(D.FirstName, ' ', D.LastName) AS DoctorName, " &
                            "CONCAT(P.FirstName, ' ', P.LastName) AS PatientName, " &
                            "Q.QueueNumber, Q.QueueStatus, Q.Clinic, Q.QueueDate " &
                            "FROM queue Q " &
                            "INNER JOIN doctors D ON Q.DoctorID = D.DoctorID " &
                            "INNER JOIN patients P ON Q.PatientID = P.PatientID " &
                            "WHERE Q.QueueStatus = 'Waiting' AND Q.Clinic LIKE @Clinic"


            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@Clinic", $"%{selectedClinic}%")
        }

            Dim dataTable As DataTable = ExecuteQuery(selectQuery, parameters)

            NursePanel.ClinicViewQueue4.DataSource = dataTable
        Catch ex As Exception
            Console.WriteLine($"Error loading queue data: {ex.Message}")
        End Try
    End Sub

    Private Sub ComboBoxClinics4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxClinics4.SelectedIndexChanged
        Try
            Console.WriteLine($"Selected Clinic: {ComboBoxClinics4.SelectedItem}")

            NursePanel.ClinicLabelLoad4.Text = ComboBoxClinics4.SelectedItem.ToString()

            LoadQueueDataClinic4()
        Catch ex As Exception
            Console.WriteLine($"Error in ComboBoxClinics4_SelectedIndexChanged: {ex.Message}")
        End Try
    End Sub

    Private Sub btnSave4_Click(sender As Object, e As EventArgs) Handles btnSave4.Click
        If ComboBoxClinics4.SelectedItem IsNot Nothing Then
            Dim selectedClinic As String = ComboBoxClinics4.SelectedItem.ToString()

            Dim confirmationResult As DialogResult = MessageBox.Show($"Do you want to save the selected clinic: {selectedClinic}?", "Confirmation", MessageBoxButtons.YesNo)

            If confirmationResult = DialogResult.Yes Then
                NursePanel.ClinicLabelLoad4.Text = selectedClinic
                SaveLabelText4()
                UpdateTabPageText4()
            End If
        Else
            MessageBox.Show("Please select a clinic from ComboBoxClinics4.")
        End If
    End Sub


    Public Sub LoadLabelText4()
        If My.Settings.ClinicLabelLoad4 IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(My.Settings.ClinicLabelLoad4) Then
            NursePanel.ClinicLabelLoad4.Text = My.Settings.ClinicLabelLoad4
            LoadQueueDataClinic4()
            UpdateTabPageText4()
        Else
            NursePanel.ClinicLabelLoad4.Text = "Default Clinic 4"
        End If
    End Sub


    Private Sub SaveLabelText4()
        My.Settings.ClinicLabelLoad4 = NursePanel.ClinicLabelLoad4.Text
        My.Settings.Save()
    End Sub

    Private Sub UpdateTabPageText4()
        Dim tabPage As TabPage = NursePanel.Guna2TabControl1.TabPages("TabPage5")

        If tabPage IsNot Nothing Then
            tabPage.Text = NursePanel.ClinicLabelLoad4.Text
        End If
    End Sub
    '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////'
    Private Sub LoadQueueDataClinic5()
        Try
            Dim selectedClinic As String = NursePanel.ClinicLabelLoad5.Text

            Dim selectQuery As String = "SELECT CONCAT(D.FirstName, ' ', D.LastName) AS DoctorName, " &
                            "CONCAT(P.FirstName, ' ', P.LastName) AS PatientName, " &
                            "Q.QueueNumber, Q.QueueStatus, Q.Clinic, Q.QueueDate " &
                            "FROM queue Q " &
                            "INNER JOIN doctors D ON Q.DoctorID = D.DoctorID " &
                            "INNER JOIN patients P ON Q.PatientID = P.PatientID " &
                            "WHERE Q.QueueStatus = 'Waiting' AND Q.Clinic LIKE @Clinic"


            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@Clinic", $"%{selectedClinic}%")
        }

            Dim dataTable As DataTable = ExecuteQuery(selectQuery, parameters)

            NursePanel.ClinicViewQueue5.DataSource = dataTable
        Catch ex As Exception
            Console.WriteLine($"Error loading queue data: {ex.Message}")
        End Try
    End Sub

    Private Sub ComboBoxClinics5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxClinics5.SelectedIndexChanged
        Try
            Console.WriteLine($"Selected Clinic: {ComboBoxClinics5.SelectedItem}")

            NursePanel.ClinicLabelLoad5.Text = ComboBoxClinics5.SelectedItem.ToString()

            LoadQueueDataClinic5()
        Catch ex As Exception
            Console.WriteLine($"Error in ComboBoxClinics5_SelectedIndexChanged: {ex.Message}")
        End Try
    End Sub

    Private Sub btnSave5_Click(sender As Object, e As EventArgs) Handles btnSave5.Click
        If ComboBoxClinics5.SelectedItem IsNot Nothing Then
            Dim selectedClinic As String = ComboBoxClinics5.SelectedItem.ToString()

            Dim confirmationResult As DialogResult = MessageBox.Show($"Do you want to save the selected clinic: {selectedClinic}?", "Confirmation", MessageBoxButtons.YesNo)

            If confirmationResult = DialogResult.Yes Then
                NursePanel.ClinicLabelLoad5.Text = selectedClinic
                SaveLabelText5()
                UpdateTabPageText5()
            End If
        Else
            MessageBox.Show("Please select a clinic from ComboBoxClinics5.")
        End If
    End Sub


    Public Sub LoadLabelText5()
        If My.Settings.ClinicLabelLoad5 IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(My.Settings.ClinicLabelLoad5) Then
            NursePanel.ClinicLabelLoad5.Text = My.Settings.ClinicLabelLoad5
            LoadQueueDataClinic5()
            UpdateTabPageText5()
        Else
            NursePanel.ClinicLabelLoad5.Text = "Default Clinic 5"
        End If
    End Sub


    Private Sub SaveLabelText5()
        My.Settings.ClinicLabelLoad5 = NursePanel.ClinicLabelLoad5.Text
        My.Settings.Save()
    End Sub

    Private Sub UpdateTabPageText5()
        Dim tabPage As TabPage = NursePanel.Guna2TabControl1.TabPages("TabPage6")

        If tabPage IsNot Nothing Then
            tabPage.Text = NursePanel.ClinicLabelLoad5.Text
        End If
    End Sub

    Private Sub LoadQueueDataClinic6()
        Try
            Dim selectedClinic As String = NursePanel.ClinicLabelLoad6.Text

            Dim selectQuery As String = "SELECT CONCAT(D.FirstName, ' ', D.LastName) AS DoctorName, " &
                            "CONCAT(P.FirstName, ' ', P.LastName) AS PatientName, " &
                            "Q.QueueNumber, Q.QueueStatus, Q.Clinic, Q.QueueDate " &
                            "FROM queue Q " &
                            "INNER JOIN doctors D ON Q.DoctorID = D.DoctorID " &
                            "INNER JOIN patients P ON Q.PatientID = P.PatientID " &
                            "WHERE Q.QueueStatus = 'Waiting' AND Q.Clinic LIKE @Clinic"


            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@Clinic", $"%{selectedClinic}%")
        }

            Dim dataTable As DataTable = ExecuteQuery(selectQuery, parameters)

            NursePanel.ClinicViewQueue6.DataSource = dataTable
        Catch ex As Exception
            Console.WriteLine($"Error loading queue data: {ex.Message}")
        End Try
    End Sub

    Private Sub ComboBoxClinics6_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxClinics6.SelectedIndexChanged
        Try
            Console.WriteLine($"Selected Clinic: {ComboBoxClinics6.SelectedItem}")

            NursePanel.ClinicLabelLoad6.Text = ComboBoxClinics6.SelectedItem.ToString()

            LoadQueueDataClinic6()
        Catch ex As Exception
            Console.WriteLine($"Error in ComboBoxClinics6_SelectedIndexChanged: {ex.Message}")
        End Try
    End Sub

    Private Sub btnSave6_Click(sender As Object, e As EventArgs) Handles btnSave6.Click
        If ComboBoxClinics6.SelectedItem IsNot Nothing Then
            Dim selectedClinic As String = ComboBoxClinics6.SelectedItem.ToString()

            Dim confirmationResult As DialogResult = MessageBox.Show($"Do you want to save the selected clinic: {selectedClinic}?", "Confirmation", MessageBoxButtons.YesNo)

            If confirmationResult = DialogResult.Yes Then
                NursePanel.ClinicLabelLoad6.Text = selectedClinic
                SaveLabelText6()
                UpdateTabPageText6()
            End If
        Else
            MessageBox.Show("Please select a clinic from ComboBoxClinics6.")
        End If
    End Sub



    Public Sub LoadLabelText6()
        If My.Settings.ClinicLabelLoad6 IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(My.Settings.ClinicLabelLoad6) Then
            NursePanel.ClinicLabelLoad6.Text = My.Settings.ClinicLabelLoad6
            LoadQueueDataClinic6()
            UpdateTabPageText6()
        Else
            NursePanel.ClinicLabelLoad6.Text = "Default Clinic 6"
        End If
    End Sub


    Private Sub SaveLabelText6()
        My.Settings.ClinicLabelLoad6 = NursePanel.ClinicLabelLoad6.Text
        My.Settings.Save()
    End Sub

    Private Sub UpdateTabPageText6()
        Dim tabPage As TabPage = NursePanel.Guna2TabControl1.TabPages("TabPage7")

        If tabPage IsNot Nothing Then
            tabPage.Text = NursePanel.ClinicLabelLoad6.Text
        End If
    End Sub


    Private Sub LoadQueueDataClinic7()
        Try
            Dim selectedClinic As String = NursePanel.ClinicLabelLoad7.Text

            Dim selectQuery As String = "SELECT CONCAT(D.FirstName, ' ', D.LastName) AS DoctorName, " &
                            "CONCAT(P.FirstName, ' ', P.LastName) AS PatientName, " &
                            "Q.QueueNumber, Q.QueueStatus, Q.Clinic, Q.QueueDate " &
                            "FROM queue Q " &
                            "INNER JOIN doctors D ON Q.DoctorID = D.DoctorID " &
                            "INNER JOIN patients P ON Q.PatientID = P.PatientID " &
                            "WHERE Q.QueueStatus = 'Waiting' AND Q.Clinic LIKE @Clinic"


            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@Clinic", $"%{selectedClinic}%")
        }

            Dim dataTable As DataTable = ExecuteQuery(selectQuery, parameters)

            NursePanel.ClinicViewQueue7.DataSource = dataTable
        Catch ex As Exception
            Console.WriteLine($"Error loading queue data: {ex.Message}")
        End Try
    End Sub

    Private Sub ComboBoxClinics7_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxClinics7.SelectedIndexChanged
        Try
            Console.WriteLine($"Selected Clinic: {ComboBoxClinics7.SelectedItem}")

            NursePanel.ClinicLabelLoad7.Text = ComboBoxClinics7.SelectedItem.ToString()

            LoadQueueDataClinic7()
        Catch ex As Exception
            Console.WriteLine($"Error in ComboBoxClinics6_SelectedIndexChanged: {ex.Message}")
        End Try
    End Sub

    Private Sub btnSave7_Click(sender As Object, e As EventArgs) Handles btnSave7.Click
        If ComboBoxClinics7.SelectedItem IsNot Nothing Then
            Dim selectedClinic As String = ComboBoxClinics7.SelectedItem.ToString()

            Dim confirmationResult As DialogResult = MessageBox.Show($"Do you want to save the selected clinic: {selectedClinic}?", "Confirmation", MessageBoxButtons.YesNo)

            If confirmationResult = DialogResult.Yes Then
                NursePanel.ClinicLabelLoad7.Text = selectedClinic
                SaveLabelText7()
                UpdateTabPageText7()
            End If
        Else
            MessageBox.Show("Please select a clinic from ComboBoxClinics6.")
        End If
    End Sub



    Public Sub LoadLabelText7()
        If My.Settings.ClinicLabelLoad7 IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(My.Settings.ClinicLabelLoad7) Then
            NursePanel.ClinicLabelLoad7.Text = My.Settings.ClinicLabelLoad7
            LoadQueueDataClinic7()
            UpdateTabPageText7()
        Else
            NursePanel.ClinicLabelLoad7.Text = "Default Clinic 7"
        End If
    End Sub


    Private Sub SaveLabelText7()
        My.Settings.ClinicLabelLoad7 = NursePanel.ClinicLabelLoad7.Text
        My.Settings.Save()
    End Sub

    Private Sub UpdateTabPageText7()
        Dim tabPage As TabPage = NursePanel.Guna2TabControl1.TabPages("TabPage8")

        If tabPage IsNot Nothing Then
            tabPage.Text = NursePanel.ClinicLabelLoad7.Text
        End If
    End Sub



    Private Sub LoadClinicNames()
        Try
            Dim selectClinicsQuery As String = "SELECT DISTINCT ClinicName FROM Clinic"
            Dim clinicDataTable As DataTable = ExecuteQuery(selectClinicsQuery)

            ComboBoxClinics1.Items.Clear()
            ComboBoxClinics2.Items.Clear()
            ComboBoxClinics3.Items.Clear()
            ComboBoxClinics4.Items.Clear()
            ComboBoxClinics5.Items.Clear()
            ComboBoxClinics6.Items.Clear()
            ComboBoxClinics7.Items.Clear()
            For Each row As DataRow In clinicDataTable.Rows
                ComboBoxClinics1.Items.Add(row("ClinicName").ToString())
                ComboBoxClinics2.Items.Add(row("ClinicName").ToString())
                ComboBoxClinics3.Items.Add(row("ClinicName").ToString())
                ComboBoxClinics4.Items.Add(row("ClinicName").ToString())
                ComboBoxClinics5.Items.Add(row("ClinicName").ToString())
                ComboBoxClinics6.Items.Add(row("ClinicName").ToString())
                ComboBoxClinics7.Items.Add(row("ClinicName").ToString())
            Next
        Catch ex As Exception
            Console.WriteLine($"Error loading clinic names: {ex.Message}")
        End Try
    End Sub

    Public Sub ReloadClinicQueue()
        LoadQueueDataClinic1()
        LoadQueueDataClinic2()
        LoadQueueDataClinic3()
        LoadQueueDataClinic4()
        LoadQueueDataClinic5()
        LoadQueueDataClinic6()
        LoadQueueDataClinic7()
    End Sub

End Class