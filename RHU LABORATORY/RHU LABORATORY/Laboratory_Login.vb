Public Class Laboratory_Login
    Private Sub LabLoginVTN_Click(sender As Object, e As EventArgs) Handles LabLoginVTN.Click
        LabPersonnelLogin()
    End Sub

    Private Sub Laboratory_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub AccessCodeCheck_CheckedChanged(sender As Object, e As EventArgs) Handles AccessCodeCheck.CheckedChanged
        If AccessCodeCheck.Checked Then
            AcesscodeLogin.PasswordChar = ControlChars.NullChar
        Else
            AcesscodeLogin.PasswordChar = "⨷"
        End If
    End Sub
End Class