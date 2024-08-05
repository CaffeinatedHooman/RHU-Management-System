<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LabUserInfo
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ShowPanelUpdate = New System.Windows.Forms.Button()
        Me.btnUpdateUser = New System.Windows.Forms.Button()
        Me.UpdateUserPanelField = New System.Windows.Forms.Panel()
        Me.txtNewAccessCode = New System.Windows.Forms.Label()
        Me.cmbNewUserClinic = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txtNewLastName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtNewUsername = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtNewFirstName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cmbNewUserGender = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txtNewContactNumber = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtNewAddress = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblFirstNameValue = New System.Windows.Forms.Label()
        Me.lblContactNumberValue = New System.Windows.Forms.Label()
        Me.lblLastNameValue = New System.Windows.Forms.Label()
        Me.lblAddressValue = New System.Windows.Forms.Label()
        Me.lblGenderValue = New System.Windows.Forms.Label()
        Me.lblUsernameValue = New System.Windows.Forms.Label()
        Me.lblPositionValue = New System.Windows.Forms.Label()
        Me.lblLaboratoryValue = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblAccessCodeValue = New System.Windows.Forms.Label()
        Me.lblUserIDValue = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.ListBoxLabUsers = New System.Windows.Forms.ListBox()
        Me.cmbNewUserSpecialization = New Guna.UI2.WinForms.Guna2TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.UpdateUserPanelField.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.ShowPanelUpdate)
        Me.GroupBox1.Controls.Add(Me.btnUpdateUser)
        Me.GroupBox1.Controls.Add(Me.UpdateUserPanelField)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.ListBoxLabUsers)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1384, 761)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Labaratory User Profile"
        '
        'ShowPanelUpdate
        '
        Me.ShowPanelUpdate.Location = New System.Drawing.Point(912, 22)
        Me.ShowPanelUpdate.Name = "ShowPanelUpdate"
        Me.ShowPanelUpdate.Size = New System.Drawing.Size(157, 45)
        Me.ShowPanelUpdate.TabIndex = 126
        Me.ShowPanelUpdate.Text = "UPDATE INFORMATION?"
        Me.ShowPanelUpdate.UseVisualStyleBackColor = True
        '
        'btnUpdateUser
        '
        Me.btnUpdateUser.Location = New System.Drawing.Point(912, 73)
        Me.btnUpdateUser.Name = "btnUpdateUser"
        Me.btnUpdateUser.Size = New System.Drawing.Size(157, 45)
        Me.btnUpdateUser.TabIndex = 127
        Me.btnUpdateUser.Text = "UPADATE USER INFO"
        Me.btnUpdateUser.UseVisualStyleBackColor = True
        Me.btnUpdateUser.Visible = False
        '
        'UpdateUserPanelField
        '
        Me.UpdateUserPanelField.Controls.Add(Me.txtNewAccessCode)
        Me.UpdateUserPanelField.Controls.Add(Me.cmbNewUserClinic)
        Me.UpdateUserPanelField.Controls.Add(Me.cmbNewUserSpecialization)
        Me.UpdateUserPanelField.Controls.Add(Me.txtNewLastName)
        Me.UpdateUserPanelField.Controls.Add(Me.txtNewUsername)
        Me.UpdateUserPanelField.Controls.Add(Me.txtNewFirstName)
        Me.UpdateUserPanelField.Controls.Add(Me.cmbNewUserGender)
        Me.UpdateUserPanelField.Controls.Add(Me.txtNewContactNumber)
        Me.UpdateUserPanelField.Controls.Add(Me.txtNewAddress)
        Me.UpdateUserPanelField.Controls.Add(Me.Label9)
        Me.UpdateUserPanelField.Controls.Add(Me.Label10)
        Me.UpdateUserPanelField.Controls.Add(Me.Label11)
        Me.UpdateUserPanelField.Controls.Add(Me.Label12)
        Me.UpdateUserPanelField.Controls.Add(Me.Label22)
        Me.UpdateUserPanelField.Controls.Add(Me.Label23)
        Me.UpdateUserPanelField.Controls.Add(Me.Label24)
        Me.UpdateUserPanelField.Controls.Add(Me.Label25)
        Me.UpdateUserPanelField.Location = New System.Drawing.Point(6, 388)
        Me.UpdateUserPanelField.Name = "UpdateUserPanelField"
        Me.UpdateUserPanelField.Size = New System.Drawing.Size(900, 300)
        Me.UpdateUserPanelField.TabIndex = 125
        Me.UpdateUserPanelField.Visible = False
        '
        'txtNewAccessCode
        '
        Me.txtNewAccessCode.AutoSize = True
        Me.txtNewAccessCode.Location = New System.Drawing.Point(642, 257)
        Me.txtNewAccessCode.Name = "txtNewAccessCode"
        Me.txtNewAccessCode.Size = New System.Drawing.Size(18, 18)
        Me.txtNewAccessCode.TabIndex = 148
        Me.txtNewAccessCode.Text = "="
        '
        'cmbNewUserClinic
        '
        Me.cmbNewUserClinic.BackColor = System.Drawing.Color.Transparent
        Me.cmbNewUserClinic.BorderColor = System.Drawing.Color.Black
        Me.cmbNewUserClinic.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbNewUserClinic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNewUserClinic.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbNewUserClinic.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbNewUserClinic.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbNewUserClinic.ForeColor = System.Drawing.Color.Black
        Me.cmbNewUserClinic.ItemHeight = 30
        Me.cmbNewUserClinic.Location = New System.Drawing.Point(645, 218)
        Me.cmbNewUserClinic.Name = "cmbNewUserClinic"
        Me.cmbNewUserClinic.Size = New System.Drawing.Size(220, 36)
        Me.cmbNewUserClinic.TabIndex = 146
        '
        'txtNewLastName
        '
        Me.txtNewLastName.BorderColor = System.Drawing.Color.Black
        Me.txtNewLastName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNewLastName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNewLastName.DefaultText = ""
        Me.txtNewLastName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtNewLastName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtNewLastName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNewLastName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNewLastName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNewLastName.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewLastName.ForeColor = System.Drawing.Color.Black
        Me.txtNewLastName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNewLastName.Location = New System.Drawing.Point(191, 90)
        Me.txtNewLastName.MaxLength = 30
        Me.txtNewLastName.Name = "txtNewLastName"
        Me.txtNewLastName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNewLastName.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtNewLastName.PlaceholderText = ""
        Me.txtNewLastName.SelectedText = ""
        Me.txtNewLastName.Size = New System.Drawing.Size(220, 36)
        Me.txtNewLastName.TabIndex = 140
        '
        'txtNewUsername
        '
        Me.txtNewUsername.BorderColor = System.Drawing.Color.Black
        Me.txtNewUsername.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNewUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNewUsername.DefaultText = ""
        Me.txtNewUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtNewUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtNewUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNewUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNewUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNewUsername.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewUsername.ForeColor = System.Drawing.Color.Black
        Me.txtNewUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNewUsername.Location = New System.Drawing.Point(645, 154)
        Me.txtNewUsername.MaxLength = 30
        Me.txtNewUsername.Name = "txtNewUsername"
        Me.txtNewUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNewUsername.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtNewUsername.PlaceholderText = ""
        Me.txtNewUsername.SelectedText = ""
        Me.txtNewUsername.Size = New System.Drawing.Size(220, 36)
        Me.txtNewUsername.TabIndex = 141
        '
        'txtNewFirstName
        '
        Me.txtNewFirstName.BorderColor = System.Drawing.Color.Black
        Me.txtNewFirstName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNewFirstName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNewFirstName.DefaultText = ""
        Me.txtNewFirstName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtNewFirstName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtNewFirstName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNewFirstName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNewFirstName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNewFirstName.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewFirstName.ForeColor = System.Drawing.Color.Black
        Me.txtNewFirstName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNewFirstName.Location = New System.Drawing.Point(191, 26)
        Me.txtNewFirstName.MaxLength = 30
        Me.txtNewFirstName.Name = "txtNewFirstName"
        Me.txtNewFirstName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNewFirstName.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtNewFirstName.PlaceholderText = ""
        Me.txtNewFirstName.SelectedText = ""
        Me.txtNewFirstName.Size = New System.Drawing.Size(220, 36)
        Me.txtNewFirstName.TabIndex = 142
        '
        'cmbNewUserGender
        '
        Me.cmbNewUserGender.BackColor = System.Drawing.Color.Transparent
        Me.cmbNewUserGender.BorderColor = System.Drawing.Color.Black
        Me.cmbNewUserGender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbNewUserGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNewUserGender.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbNewUserGender.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbNewUserGender.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.cmbNewUserGender.ForeColor = System.Drawing.Color.Black
        Me.cmbNewUserGender.ItemHeight = 30
        Me.cmbNewUserGender.Items.AddRange(New Object() {"MALE", "FEMALE"})
        Me.cmbNewUserGender.Location = New System.Drawing.Point(191, 154)
        Me.cmbNewUserGender.Name = "cmbNewUserGender"
        Me.cmbNewUserGender.Size = New System.Drawing.Size(220, 36)
        Me.cmbNewUserGender.TabIndex = 147
        '
        'txtNewContactNumber
        '
        Me.txtNewContactNumber.BorderColor = System.Drawing.Color.Black
        Me.txtNewContactNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNewContactNumber.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNewContactNumber.DefaultText = ""
        Me.txtNewContactNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtNewContactNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtNewContactNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNewContactNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNewContactNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNewContactNumber.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewContactNumber.ForeColor = System.Drawing.Color.Black
        Me.txtNewContactNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNewContactNumber.Location = New System.Drawing.Point(645, 26)
        Me.txtNewContactNumber.MaxLength = 30
        Me.txtNewContactNumber.Name = "txtNewContactNumber"
        Me.txtNewContactNumber.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNewContactNumber.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtNewContactNumber.PlaceholderText = ""
        Me.txtNewContactNumber.SelectedText = ""
        Me.txtNewContactNumber.Size = New System.Drawing.Size(220, 36)
        Me.txtNewContactNumber.TabIndex = 143
        '
        'txtNewAddress
        '
        Me.txtNewAddress.BorderColor = System.Drawing.Color.Black
        Me.txtNewAddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNewAddress.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNewAddress.DefaultText = ""
        Me.txtNewAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtNewAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtNewAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNewAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNewAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNewAddress.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewAddress.ForeColor = System.Drawing.Color.Black
        Me.txtNewAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNewAddress.Location = New System.Drawing.Point(645, 90)
        Me.txtNewAddress.MaxLength = 30
        Me.txtNewAddress.Name = "txtNewAddress"
        Me.txtNewAddress.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNewAddress.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtNewAddress.PlaceholderText = ""
        Me.txtNewAddress.SelectedText = ""
        Me.txtNewAddress.Size = New System.Drawing.Size(220, 36)
        Me.txtNewAddress.TabIndex = 144
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(468, 236)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(160, 18)
        Me.Label9.TabIndex = 139
        Me.Label9.Text = "ASSIGN TO CLINIC"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(468, 172)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(105, 18)
        Me.Label10.TabIndex = 138
        Me.Label10.Text = "USERNAME"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(36, 236)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(89, 18)
        Me.Label11.TabIndex = 134
        Me.Label11.Text = "POSITION"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(468, 108)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(88, 18)
        Me.Label12.TabIndex = 137
        Me.Label12.Text = "ADDRESS"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(36, 44)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(111, 18)
        Me.Label22.TabIndex = 132
        Me.Label22.Text = "FIRST NAME"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(468, 44)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(168, 18)
        Me.Label23.TabIndex = 136
        Me.Label23.Text = "CONTACT NUMBER"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(36, 108)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(105, 18)
        Me.Label24.TabIndex = 135
        Me.Label24.Text = "LAST NAME"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(36, 172)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(80, 18)
        Me.Label25.TabIndex = 133
        Me.Label25.Text = "GENDER"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblFirstNameValue)
        Me.Panel1.Controls.Add(Me.lblContactNumberValue)
        Me.Panel1.Controls.Add(Me.lblLastNameValue)
        Me.Panel1.Controls.Add(Me.lblAddressValue)
        Me.Panel1.Controls.Add(Me.lblGenderValue)
        Me.Panel1.Controls.Add(Me.lblUsernameValue)
        Me.Panel1.Controls.Add(Me.lblPositionValue)
        Me.Panel1.Controls.Add(Me.lblLaboratoryValue)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.lblAccessCodeValue)
        Me.Panel1.Controls.Add(Me.lblUserIDValue)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.Label19)
        Me.Panel1.Controls.Add(Me.Label20)
        Me.Panel1.Controls.Add(Me.Label21)
        Me.Panel1.Location = New System.Drawing.Point(6, 22)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(900, 360)
        Me.Panel1.TabIndex = 2
        '
        'lblFirstNameValue
        '
        Me.lblFirstNameValue.AutoSize = True
        Me.lblFirstNameValue.Location = New System.Drawing.Point(213, 92)
        Me.lblFirstNameValue.MaximumSize = New System.Drawing.Size(220, 0)
        Me.lblFirstNameValue.Name = "lblFirstNameValue"
        Me.lblFirstNameValue.Size = New System.Drawing.Size(18, 18)
        Me.lblFirstNameValue.TabIndex = 144
        Me.lblFirstNameValue.Text = "="
        '
        'lblContactNumberValue
        '
        Me.lblContactNumberValue.AutoSize = True
        Me.lblContactNumberValue.Location = New System.Drawing.Point(666, 92)
        Me.lblContactNumberValue.MaximumSize = New System.Drawing.Size(220, 0)
        Me.lblContactNumberValue.Name = "lblContactNumberValue"
        Me.lblContactNumberValue.Size = New System.Drawing.Size(18, 18)
        Me.lblContactNumberValue.TabIndex = 144
        Me.lblContactNumberValue.Text = "="
        '
        'lblLastNameValue
        '
        Me.lblLastNameValue.AutoSize = True
        Me.lblLastNameValue.Location = New System.Drawing.Point(213, 154)
        Me.lblLastNameValue.MaximumSize = New System.Drawing.Size(220, 0)
        Me.lblLastNameValue.Name = "lblLastNameValue"
        Me.lblLastNameValue.Size = New System.Drawing.Size(18, 18)
        Me.lblLastNameValue.TabIndex = 145
        Me.lblLastNameValue.Text = "="
        '
        'lblAddressValue
        '
        Me.lblAddressValue.AutoSize = True
        Me.lblAddressValue.Location = New System.Drawing.Point(666, 154)
        Me.lblAddressValue.MaximumSize = New System.Drawing.Size(220, 0)
        Me.lblAddressValue.Name = "lblAddressValue"
        Me.lblAddressValue.Size = New System.Drawing.Size(18, 18)
        Me.lblAddressValue.TabIndex = 145
        Me.lblAddressValue.Text = "="
        '
        'lblGenderValue
        '
        Me.lblGenderValue.AutoSize = True
        Me.lblGenderValue.Location = New System.Drawing.Point(213, 216)
        Me.lblGenderValue.MaximumSize = New System.Drawing.Size(220, 0)
        Me.lblGenderValue.Name = "lblGenderValue"
        Me.lblGenderValue.Size = New System.Drawing.Size(18, 18)
        Me.lblGenderValue.TabIndex = 146
        Me.lblGenderValue.Text = "="
        '
        'lblUsernameValue
        '
        Me.lblUsernameValue.AutoSize = True
        Me.lblUsernameValue.Location = New System.Drawing.Point(666, 216)
        Me.lblUsernameValue.MaximumSize = New System.Drawing.Size(220, 0)
        Me.lblUsernameValue.Name = "lblUsernameValue"
        Me.lblUsernameValue.Size = New System.Drawing.Size(18, 18)
        Me.lblUsernameValue.TabIndex = 146
        Me.lblUsernameValue.Text = "="
        '
        'lblPositionValue
        '
        Me.lblPositionValue.AutoSize = True
        Me.lblPositionValue.Location = New System.Drawing.Point(217, 282)
        Me.lblPositionValue.MaximumSize = New System.Drawing.Size(220, 0)
        Me.lblPositionValue.Name = "lblPositionValue"
        Me.lblPositionValue.Size = New System.Drawing.Size(18, 18)
        Me.lblPositionValue.TabIndex = 147
        Me.lblPositionValue.Text = "="
        '
        'lblLaboratoryValue
        '
        Me.lblLaboratoryValue.AutoSize = True
        Me.lblLaboratoryValue.Location = New System.Drawing.Point(670, 282)
        Me.lblLaboratoryValue.MaximumSize = New System.Drawing.Size(220, 0)
        Me.lblLaboratoryValue.Name = "lblLaboratoryValue"
        Me.lblLaboratoryValue.Size = New System.Drawing.Size(18, 18)
        Me.lblLaboratoryValue.TabIndex = 147
        Me.lblLaboratoryValue.Text = "="
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(499, 278)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(160, 18)
        Me.Label14.TabIndex = 143
        Me.Label14.Text = "ASSIGN TO CLINIC"
        '
        'lblAccessCodeValue
        '
        Me.lblAccessCodeValue.AutoSize = True
        Me.lblAccessCodeValue.Location = New System.Drawing.Point(670, 313)
        Me.lblAccessCodeValue.Name = "lblAccessCodeValue"
        Me.lblAccessCodeValue.Size = New System.Drawing.Size(18, 18)
        Me.lblAccessCodeValue.TabIndex = 142
        Me.lblAccessCodeValue.Text = "="
        '
        'lblUserIDValue
        '
        Me.lblUserIDValue.AutoSize = True
        Me.lblUserIDValue.Location = New System.Drawing.Point(186, 30)
        Me.lblUserIDValue.Name = "lblUserIDValue"
        Me.lblUserIDValue.Size = New System.Drawing.Size(60, 18)
        Me.lblUserIDValue.TabIndex = 141
        Me.lblUserIDValue.Text = "LAB99"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(65, 30)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(115, 18)
        Me.Label13.TabIndex = 140
        Me.Label13.Text = "LAB USER ID"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(499, 216)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(105, 18)
        Me.Label15.TabIndex = 138
        Me.Label15.Text = "USERNAME"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(65, 278)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(89, 18)
        Me.Label16.TabIndex = 137
        Me.Label16.Text = "POSITION"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(499, 154)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(88, 18)
        Me.Label17.TabIndex = 136
        Me.Label17.Text = "ADDRESS"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(65, 216)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(80, 18)
        Me.Label18.TabIndex = 135
        Me.Label18.Text = "GENDER"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(499, 92)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(168, 18)
        Me.Label19.TabIndex = 134
        Me.Label19.Text = "CONTACT NUMBER"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(65, 154)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(105, 18)
        Me.Label20.TabIndex = 139
        Me.Label20.Text = "LAST NAME"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(65, 92)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(111, 18)
        Me.Label21.TabIndex = 133
        Me.Label21.Text = "FIRST NAME"
        '
        'ListBoxLabUsers
        '
        Me.ListBoxLabUsers.Dock = System.Windows.Forms.DockStyle.Right
        Me.ListBoxLabUsers.FormattingEnabled = True
        Me.ListBoxLabUsers.ItemHeight = 18
        Me.ListBoxLabUsers.Location = New System.Drawing.Point(1081, 22)
        Me.ListBoxLabUsers.MultiColumn = True
        Me.ListBoxLabUsers.Name = "ListBoxLabUsers"
        Me.ListBoxLabUsers.ScrollAlwaysVisible = True
        Me.ListBoxLabUsers.Size = New System.Drawing.Size(300, 736)
        Me.ListBoxLabUsers.TabIndex = 1
        '
        'cmbNewUserSpecialization
        '
        Me.cmbNewUserSpecialization.BorderColor = System.Drawing.Color.Black
        Me.cmbNewUserSpecialization.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cmbNewUserSpecialization.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.cmbNewUserSpecialization.DefaultText = ""
        Me.cmbNewUserSpecialization.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.cmbNewUserSpecialization.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.cmbNewUserSpecialization.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.cmbNewUserSpecialization.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.cmbNewUserSpecialization.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbNewUserSpecialization.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbNewUserSpecialization.ForeColor = System.Drawing.Color.Black
        Me.cmbNewUserSpecialization.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbNewUserSpecialization.Location = New System.Drawing.Point(189, 218)
        Me.cmbNewUserSpecialization.MaxLength = 30
        Me.cmbNewUserSpecialization.Name = "cmbNewUserSpecialization"
        Me.cmbNewUserSpecialization.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.cmbNewUserSpecialization.PlaceholderForeColor = System.Drawing.Color.Black
        Me.cmbNewUserSpecialization.PlaceholderText = ""
        Me.cmbNewUserSpecialization.SelectedText = ""
        Me.cmbNewUserSpecialization.Size = New System.Drawing.Size(220, 36)
        Me.cmbNewUserSpecialization.TabIndex = 140
        '
        'LabUserInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1384, 761)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "LabUserInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LabUserInfo"
        Me.GroupBox1.ResumeLayout(False)
        Me.UpdateUserPanelField.ResumeLayout(False)
        Me.UpdateUserPanelField.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ShowPanelUpdate As Button
    Friend WithEvents btnUpdateUser As Button
    Friend WithEvents UpdateUserPanelField As Panel
    Friend WithEvents txtNewAccessCode As Label
    Friend WithEvents cmbNewUserClinic As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents txtNewLastName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtNewUsername As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtNewFirstName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cmbNewUserGender As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents txtNewContactNumber As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtNewAddress As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblFirstNameValue As Label
    Friend WithEvents lblContactNumberValue As Label
    Friend WithEvents lblLastNameValue As Label
    Friend WithEvents lblAddressValue As Label
    Friend WithEvents lblGenderValue As Label
    Friend WithEvents lblUsernameValue As Label
    Friend WithEvents lblPositionValue As Label
    Friend WithEvents lblLaboratoryValue As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents lblAccessCodeValue As Label
    Friend WithEvents lblUserIDValue As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents ListBoxLabUsers As ListBox
    Friend WithEvents cmbNewUserSpecialization As Guna.UI2.WinForms.Guna2TextBox
End Class
