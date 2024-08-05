Public Class DoctorLoginForm
    Private Sub DocLoginVTB_Click(sender As Object, e As EventArgs) Handles DocLoginVTB.Click
        DoctorLogin()
    End Sub

    Private Sub AccessCodeCheck_CheckedChanged(sender As Object, e As EventArgs) Handles AccessCodeCheck.CheckedChanged
        If AccessCodeCheck.Checked Then
            AcesscodeLogin.PasswordChar = ControlChars.NullChar
        Else
            AcesscodeLogin.PasswordChar = "⫸"
        End If
    End Sub

    Private Sub DoctorLoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class