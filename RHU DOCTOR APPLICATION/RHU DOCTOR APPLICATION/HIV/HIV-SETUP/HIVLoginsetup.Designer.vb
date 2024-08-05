<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HIVLoginsetup
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.AccessCodeCheck = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AcesscodeLogin = New Guna.UI2.WinForms.Guna2TextBox()
        Me.UsernameLogin = New Guna.UI2.WinForms.Guna2TextBox()
        Me.DocLoginVTB = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.SuspendLayout()
        '
        'AccessCodeCheck
        '
        Me.AccessCodeCheck.AutoSize = True
        Me.AccessCodeCheck.Location = New System.Drawing.Point(193, 335)
        Me.AccessCodeCheck.Name = "AccessCodeCheck"
        Me.AccessCodeCheck.Size = New System.Drawing.Size(175, 22)
        Me.AccessCodeCheck.TabIndex = 29
        Me.AccessCodeCheck.Text = "Show AccessCode"
        Me.AccessCodeCheck.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(174, 209)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 18)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "DOCTOR LOGIN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(62, 311)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 18)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "ACCESS CODE"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(62, 269)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 18)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "USERNAME"
        '
        'AcesscodeLogin
        '
        Me.AcesscodeLogin.BorderColor = System.Drawing.Color.Black
        Me.AcesscodeLogin.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.AcesscodeLogin.DefaultText = ""
        Me.AcesscodeLogin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.AcesscodeLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.AcesscodeLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.AcesscodeLogin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.AcesscodeLogin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AcesscodeLogin.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold)
        Me.AcesscodeLogin.ForeColor = System.Drawing.Color.Black
        Me.AcesscodeLogin.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AcesscodeLogin.Location = New System.Drawing.Point(193, 293)
        Me.AcesscodeLogin.Name = "AcesscodeLogin"
        Me.AcesscodeLogin.PasswordChar = Global.Microsoft.VisualBasic.ChrW(11000)
        Me.AcesscodeLogin.PlaceholderForeColor = System.Drawing.Color.Black
        Me.AcesscodeLogin.PlaceholderText = ""
        Me.AcesscodeLogin.SelectedText = ""
        Me.AcesscodeLogin.Size = New System.Drawing.Size(229, 36)
        Me.AcesscodeLogin.TabIndex = 24
        '
        'UsernameLogin
        '
        Me.UsernameLogin.BorderColor = System.Drawing.Color.Black
        Me.UsernameLogin.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.UsernameLogin.DefaultText = ""
        Me.UsernameLogin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.UsernameLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.UsernameLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.UsernameLogin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.UsernameLogin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UsernameLogin.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameLogin.ForeColor = System.Drawing.Color.Black
        Me.UsernameLogin.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UsernameLogin.Location = New System.Drawing.Point(193, 251)
        Me.UsernameLogin.Name = "UsernameLogin"
        Me.UsernameLogin.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.UsernameLogin.PlaceholderForeColor = System.Drawing.Color.Black
        Me.UsernameLogin.PlaceholderText = ""
        Me.UsernameLogin.SelectedText = ""
        Me.UsernameLogin.Size = New System.Drawing.Size(229, 36)
        Me.UsernameLogin.TabIndex = 25
        '
        'DocLoginVTB
        '
        Me.DocLoginVTB.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.DocLoginVTB.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.DocLoginVTB.HoverState.ImageSize = New System.Drawing.Size(64, 64)
        Me.DocLoginVTB.Image = Global.RHU_DOCTOR_APPLICATION.My.Resources.Resources.doctor_1_
        Me.DocLoginVTB.ImageOffset = New System.Drawing.Point(0, 0)
        Me.DocLoginVTB.ImageRotate = 0!
        Me.DocLoginVTB.ImageSize = New System.Drawing.Size(100, 100)
        Me.DocLoginVTB.Location = New System.Drawing.Point(193, 104)
        Me.DocLoginVTB.Name = "DocLoginVTB"
        Me.DocLoginVTB.PressedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.DocLoginVTB.Size = New System.Drawing.Size(100, 100)
        Me.DocLoginVTB.TabIndex = 23
        '
        'HIVLoginsetup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 461)
        Me.Controls.Add(Me.AccessCodeCheck)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AcesscodeLogin)
        Me.Controls.Add(Me.UsernameLogin)
        Me.Controls.Add(Me.DocLoginVTB)
        Me.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "HIVLoginsetup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HIVLoginsetup"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AccessCodeCheck As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents AcesscodeLogin As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents UsernameLogin As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents DocLoginVTB As Guna.UI2.WinForms.Guna2ImageButton
End Class
