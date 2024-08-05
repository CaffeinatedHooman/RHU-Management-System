Public Class HIVLoginsetup
    Private Sub HIVLoginsetup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
    End Sub


    Private Sub AccessCodeCheck_CheckedChanged(sender As Object, e As EventArgs) Handles AccessCodeCheck.CheckedChanged
        If AccessCodeCheck.Checked Then
            AcesscodeLogin.PasswordChar = ControlChars.NullChar
        Else
            AcesscodeLogin.PasswordChar = "⫸"
        End If
    End Sub

    Private Sub HIVLoginsetup_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.F12 Then

            Dim newForm As New HAS_ClinicSetup()
            newForm.ShowDialog()
        End If
    End Sub

    Private Sub DocLoginVTB_Click(sender As Object, e As EventArgs) Handles DocLoginVTB.Click
        HASLoginPage()
    End Sub
End Class