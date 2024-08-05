Public Class MotherHoodLogin
    Private Sub MotherHoodLogin_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.F10 Then

            Dim newForm As New MotherHoodSetup()
            newForm.Show()
        End If
    End Sub

    Private Sub MotherHoodLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
    End Sub

    Private Sub DocLoginVTB_Click(sender As Object, e As EventArgs) Handles DocLoginVTB.Click
        MotherHoodLoginPage()
    End Sub

    Private Sub AccessCodeCheck_CheckedChanged(sender As Object, e As EventArgs) Handles AccessCodeCheck.CheckedChanged
        If AccessCodeCheck.Checked Then
            AcesscodeLogin.PasswordChar = ControlChars.NullChar
        Else
            AcesscodeLogin.PasswordChar = "⫸"
        End If
    End Sub
End Class