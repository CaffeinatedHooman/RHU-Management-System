Public Class Clinic2Login
    Private Sub Clinic2Login_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.F12 Then

            Dim newForm As New ClinicSetup2()
            newForm.ShowDialog()
        End If
    End Sub

    Private Sub Clinic2Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
    End Sub

    Private Sub AccessCodeCheck_CheckedChanged(sender As Object, e As EventArgs) Handles AccessCodeCheck.CheckedChanged
        If AccessCodeCheck.Checked Then
            AcesscodeLogin.PasswordChar = ControlChars.NullChar
        Else
            AcesscodeLogin.PasswordChar = "⫸"
        End If
    End Sub

    Private Sub DocLoginVTB_Click(sender As Object, e As EventArgs) Handles DocLoginVTB.Click
        Clinic2LoginPage()
    End Sub
End Class