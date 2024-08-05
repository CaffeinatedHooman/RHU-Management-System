Public Class PRC_Login
    Private Sub Guna2ImageButton1_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton1.Click
        PharmacistLogin()
    End Sub
    Private Sub AccessCodeCheck_CheckedChanged(sender As Object, e As EventArgs) Handles AccessCodeCheck.CheckedChanged
        If AccessCodeCheck.Checked Then
            AcesscodeLogin.PasswordChar = ControlChars.NullChar
        Else
            AcesscodeLogin.PasswordChar = "⫸"
        End If
    End Sub

End Class