Public Class DoctorsPanel

    Private Sub ClinicVTN4_Click(sender As Object, e As EventArgs) Handles ClinicVTN4.Click
        Clinic2Login.ShowDialog()
    End Sub
    Private Sub ClinicVTN5_Click(sender As Object, e As EventArgs) Handles ClinicVTN5.Click
        Clinic3Login.ShowDialog()
    End Sub

    Private Sub ClinicVTN6_Click(sender As Object, e As EventArgs) Handles ClinicVTN6.Click
        Clinic4Login.ShowDialog()
    End Sub

    Private Sub ClinicVTN1_Click(sender As Object, e As EventArgs) Handles ClinicVTN1.Click
        MotherHoodLogin.ShowDialog()
    End Sub

    Private Sub ClinicVTN2_Click(sender As Object, e As EventArgs) Handles ClinicVTN2.Click
        TB_LoginForm.ShowDialog()
    End Sub

    Private Sub ClinicVTN3_Click(sender As Object, e As EventArgs) Handles ClinicVTN3.Click
        HIVLoginsetup.ShowDialog()
    End Sub

    Private Sub GeneralClinic_Click(sender As Object, e As EventArgs) Handles GeneralClinic.Click
        Clinic6Login.ShowDialog()
    End Sub

    Private Sub ClinicVTN8_Click(sender As Object, e As EventArgs) Handles ClinicVTN8.Click
        Clinic5Login.ShowDialog()
    End Sub

    Private Sub DoctorsPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        ClinicVTN7.Text = My.Settings.ClinicButtonName1
        ClinicVTN4.Text = My.Settings.ClinicButtonName2
        ClinicVTN5.Text = My.Settings.ClinicButtonName3
        ClinicVTN6.Text = My.Settings.ClinicButtonName4
        ClinicVTN8.Text = My.Settings.ClinicButtonName5
        GeneralClinic.Text = My.Settings.ClinicButtonName6
    End Sub

    Private Sub ClinicVTN7_Click(sender As Object, e As EventArgs) Handles ClinicVTN7.Click
        Clinic1Login.Show()
    End Sub

    Private Sub DoctorsPanel_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.F1 Then
            Dim form1 As New ClinicSetup1()
            ClinicSetup1.ShowDialog()
        End If


        If e.Control AndAlso e.KeyCode = Keys.F2 Then
            Dim form2 As New ClinicSetup2()
            ClinicSetup2.ShowDialog()
        End If


        If e.Control AndAlso e.KeyCode = Keys.F3 Then
            Dim form3 As New ClinicSetup3()
            ClinicSetup3.ShowDialog()
        End If


        If e.Control AndAlso e.KeyCode = Keys.F4 Then
            Dim form4 As New ClinicSetup4()
            ClinicSetup4.ShowDialog()
        End If


        If e.Control AndAlso e.KeyCode = Keys.F5 Then
            Dim form5 As New ClinicSetup5()
            ClinicSetup5.ShowDialog()
        End If
        If e.Control AndAlso e.KeyCode = Keys.F6 Then
            Dim form6 As New ClinicSetup6()
            ClinicSetup6.ShowDialog()
        End If
    End Sub



    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.Alt AndAlso e.KeyCode = Keys.End Then
            My.Settings.ClinicButtonName1 = String.Empty
            My.Settings.ClinicButtonName2 = String.Empty
            My.Settings.ClinicButtonName3 = String.Empty
            My.Settings.ClinicButtonName4 = String.Empty
            My.Settings.ClinicButtonName5 = String.Empty
            My.Settings.ClinicButtonName6 = String.Empty

            My.Settings.SelectedAccessCodeClinic1 = Nothing
            My.Settings.SelectedAccessCodeClinic2 = Nothing
            My.Settings.SelectedAccessCodeClinic3 = Nothing
            My.Settings.SelectedAccessCodeClinic4 = Nothing
            My.Settings.SelectedAccessCodeClinic5 = Nothing
            My.Settings.SelectedAccessCodeClinic6 = Nothing
            My.Settings.SelectedAccessCode = Nothing
            My.Settings.SelectedAccessCodeTB = Nothing
            My.Settings.SelectedAccessCodeHAS = Nothing


            My.Settings.Save()

            MessageBox.Show("Changes applied. Please restart the application for the changes to take effect.", "Restart Required", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub HelpVTN_Click(sender As Object, e As EventArgs) Handles HelpVTN.Click
        MessageBox.Show("This is a socialized clinic. For clinic setup and access, please contact the admin.", "Clinic Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub
End Class