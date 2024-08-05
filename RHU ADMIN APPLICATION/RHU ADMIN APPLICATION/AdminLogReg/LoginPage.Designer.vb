<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginPageAdmin
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
        Me.LoginAdminRead = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.AdminPasswordLogin = New Guna.UI2.WinForms.Guna2TextBox()
        Me.AdminUsernameLogin = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AccessCodeCheck = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'LoginAdminRead
        '
        Me.LoginAdminRead.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.LoginAdminRead.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.LoginAdminRead.HoverState.ImageSize = New System.Drawing.Size(64, 64)
        Me.LoginAdminRead.Image = Global.RHU_ADMIN_APPLICATION.My.Resources.Resources.admin
        Me.LoginAdminRead.ImageOffset = New System.Drawing.Point(0, 0)
        Me.LoginAdminRead.ImageRotate = 0!
        Me.LoginAdminRead.ImageSize = New System.Drawing.Size(100, 100)
        Me.LoginAdminRead.Location = New System.Drawing.Point(180, 151)
        Me.LoginAdminRead.Name = "LoginAdminRead"
        Me.LoginAdminRead.PressedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.LoginAdminRead.Size = New System.Drawing.Size(120, 120)
        Me.LoginAdminRead.TabIndex = 63
        '
        'AdminPasswordLogin
        '
        Me.AdminPasswordLogin.BorderColor = System.Drawing.Color.Black
        Me.AdminPasswordLogin.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.AdminPasswordLogin.DefaultText = ""
        Me.AdminPasswordLogin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.AdminPasswordLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.AdminPasswordLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.AdminPasswordLogin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.AdminPasswordLogin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AdminPasswordLogin.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminPasswordLogin.ForeColor = System.Drawing.Color.Black
        Me.AdminPasswordLogin.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AdminPasswordLogin.Location = New System.Drawing.Point(186, 353)
        Me.AdminPasswordLogin.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.AdminPasswordLogin.Name = "AdminPasswordLogin"
        Me.AdminPasswordLogin.PasswordChar = Global.Microsoft.VisualBasic.ChrW(11000)
        Me.AdminPasswordLogin.PlaceholderText = ""
        Me.AdminPasswordLogin.SelectedText = ""
        Me.AdminPasswordLogin.Size = New System.Drawing.Size(200, 36)
        Me.AdminPasswordLogin.TabIndex = 61
        '
        'AdminUsernameLogin
        '
        Me.AdminUsernameLogin.BorderColor = System.Drawing.Color.Black
        Me.AdminUsernameLogin.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.AdminUsernameLogin.DefaultText = ""
        Me.AdminUsernameLogin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.AdminUsernameLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.AdminUsernameLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.AdminUsernameLogin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.AdminUsernameLogin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AdminUsernameLogin.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold)
        Me.AdminUsernameLogin.ForeColor = System.Drawing.Color.Black
        Me.AdminUsernameLogin.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AdminUsernameLogin.Location = New System.Drawing.Point(186, 311)
        Me.AdminUsernameLogin.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.AdminUsernameLogin.Name = "AdminUsernameLogin"
        Me.AdminUsernameLogin.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.AdminUsernameLogin.PlaceholderText = ""
        Me.AdminUsernameLogin.SelectedText = ""
        Me.AdminUsernameLogin.Size = New System.Drawing.Size(200, 36)
        Me.AdminUsernameLogin.TabIndex = 62
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(75, 371)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 18)
        Me.Label4.TabIndex = 59
        Me.Label4.Text = "PASSWORD"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(75, 329)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 18)
        Me.Label2.TabIndex = 60
        Me.Label2.Text = "USERNAME"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Sans", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(98, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(312, 31)
        Me.Label3.TabIndex = 58
        Me.Label3.Text = "ADMIN LOG-IN PAGE "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(207, 274)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 18)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "ADMIN"
        '
        'AccessCodeCheck
        '
        Me.AccessCodeCheck.AutoSize = True
        Me.AccessCodeCheck.Location = New System.Drawing.Point(186, 396)
        Me.AccessCodeCheck.Name = "AccessCodeCheck"
        Me.AccessCodeCheck.Size = New System.Drawing.Size(175, 22)
        Me.AccessCodeCheck.TabIndex = 64
        Me.AccessCodeCheck.Text = "Show AccessCode"
        Me.AccessCodeCheck.UseVisualStyleBackColor = True
        '
        'LoginPageAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(484, 461)
        Me.Controls.Add(Me.AccessCodeCheck)
        Me.Controls.Add(Me.LoginAdminRead)
        Me.Controls.Add(Me.AdminPasswordLogin)
        Me.Controls.Add(Me.AdminUsernameLogin)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "LoginPageAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LOGIN FOR ADMIN"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LoginAdminRead As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents AdminPasswordLogin As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents AdminUsernameLogin As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents AccessCodeCheck As CheckBox
End Class
