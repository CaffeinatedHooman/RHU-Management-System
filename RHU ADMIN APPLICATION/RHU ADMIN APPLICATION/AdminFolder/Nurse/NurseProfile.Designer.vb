<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NurseProfile
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
        Me.ListBoxNurseNames = New System.Windows.Forms.ListBox()
        Me.VisibleBTN = New System.Windows.Forms.GroupBox()
        Me.UpdatePanelField = New System.Windows.Forms.Panel()
        Me.txtNewAccessCode = New System.Windows.Forms.Label()
        Me.cmbNewSpecialization = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cmbNewClinic = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txtNewLastName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtNewUsername = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtNewFirstName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cmbNewGender = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txtNewContactNumber = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtNewAddress = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ShowPanelUpdate = New System.Windows.Forms.Button()
        Me.btnUpdateNurse = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblNurseContactNumber = New System.Windows.Forms.Label()
        Me.lblNurseAddress = New System.Windows.Forms.Label()
        Me.lblNurseUsername = New System.Windows.Forms.Label()
        Me.lblNurseAccessCode = New System.Windows.Forms.Label()
        Me.lblClinicAssigned = New System.Windows.Forms.Label()
        Me.lblNurseFirstname = New System.Windows.Forms.Label()
        Me.lblNurseLastname = New System.Windows.Forms.Label()
        Me.lblNurseGender = New System.Windows.Forms.Label()
        Me.lblNurseSpecialization = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.lblNurseID = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.VisibleBTN.SuspendLayout()
        Me.UpdatePanelField.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListBoxNurseNames
        '
        Me.ListBoxNurseNames.Dock = System.Windows.Forms.DockStyle.Right
        Me.ListBoxNurseNames.FormattingEnabled = True
        Me.ListBoxNurseNames.ItemHeight = 18
        Me.ListBoxNurseNames.Location = New System.Drawing.Point(1075, 22)
        Me.ListBoxNurseNames.Name = "ListBoxNurseNames"
        Me.ListBoxNurseNames.Size = New System.Drawing.Size(300, 730)
        Me.ListBoxNurseNames.TabIndex = 71
        '
        'VisibleBTN
        '
        Me.VisibleBTN.BackColor = System.Drawing.Color.White
        Me.VisibleBTN.Controls.Add(Me.UpdatePanelField)
        Me.VisibleBTN.Controls.Add(Me.ShowPanelUpdate)
        Me.VisibleBTN.Controls.Add(Me.btnUpdateNurse)
        Me.VisibleBTN.Controls.Add(Me.Panel1)
        Me.VisibleBTN.Controls.Add(Me.ListBoxNurseNames)
        Me.VisibleBTN.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VisibleBTN.Location = New System.Drawing.Point(3, 3)
        Me.VisibleBTN.Name = "VisibleBTN"
        Me.VisibleBTN.Size = New System.Drawing.Size(1378, 755)
        Me.VisibleBTN.TabIndex = 0
        Me.VisibleBTN.TabStop = False
        Me.VisibleBTN.Text = "NurseProfile"
        '
        'UpdatePanelField
        '
        Me.UpdatePanelField.Controls.Add(Me.txtNewAccessCode)
        Me.UpdatePanelField.Controls.Add(Me.cmbNewSpecialization)
        Me.UpdatePanelField.Controls.Add(Me.cmbNewClinic)
        Me.UpdatePanelField.Controls.Add(Me.txtNewLastName)
        Me.UpdatePanelField.Controls.Add(Me.txtNewUsername)
        Me.UpdatePanelField.Controls.Add(Me.txtNewFirstName)
        Me.UpdatePanelField.Controls.Add(Me.cmbNewGender)
        Me.UpdatePanelField.Controls.Add(Me.txtNewContactNumber)
        Me.UpdatePanelField.Controls.Add(Me.txtNewAddress)
        Me.UpdatePanelField.Controls.Add(Me.Label8)
        Me.UpdatePanelField.Controls.Add(Me.Label7)
        Me.UpdatePanelField.Controls.Add(Me.Label4)
        Me.UpdatePanelField.Controls.Add(Me.Label6)
        Me.UpdatePanelField.Controls.Add(Me.Label1)
        Me.UpdatePanelField.Controls.Add(Me.Label5)
        Me.UpdatePanelField.Controls.Add(Me.Label2)
        Me.UpdatePanelField.Controls.Add(Me.Label3)
        Me.UpdatePanelField.Location = New System.Drawing.Point(6, 391)
        Me.UpdatePanelField.Name = "UpdatePanelField"
        Me.UpdatePanelField.Size = New System.Drawing.Size(900, 300)
        Me.UpdatePanelField.TabIndex = 124
        Me.UpdatePanelField.Visible = False
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
        'cmbNewSpecialization
        '
        Me.cmbNewSpecialization.BackColor = System.Drawing.Color.Transparent
        Me.cmbNewSpecialization.BorderColor = System.Drawing.Color.Black
        Me.cmbNewSpecialization.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbNewSpecialization.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNewSpecialization.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbNewSpecialization.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbNewSpecialization.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbNewSpecialization.ForeColor = System.Drawing.Color.Black
        Me.cmbNewSpecialization.ItemHeight = 30
        Me.cmbNewSpecialization.Location = New System.Drawing.Point(191, 218)
        Me.cmbNewSpecialization.Name = "cmbNewSpecialization"
        Me.cmbNewSpecialization.Size = New System.Drawing.Size(220, 36)
        Me.cmbNewSpecialization.TabIndex = 145
        '
        'cmbNewClinic
        '
        Me.cmbNewClinic.BackColor = System.Drawing.Color.Transparent
        Me.cmbNewClinic.BorderColor = System.Drawing.Color.Black
        Me.cmbNewClinic.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbNewClinic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNewClinic.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbNewClinic.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbNewClinic.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbNewClinic.ForeColor = System.Drawing.Color.Black
        Me.cmbNewClinic.ItemHeight = 30
        Me.cmbNewClinic.Location = New System.Drawing.Point(645, 218)
        Me.cmbNewClinic.Name = "cmbNewClinic"
        Me.cmbNewClinic.Size = New System.Drawing.Size(220, 36)
        Me.cmbNewClinic.TabIndex = 146
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
        'cmbNewGender
        '
        Me.cmbNewGender.BackColor = System.Drawing.Color.Transparent
        Me.cmbNewGender.BorderColor = System.Drawing.Color.Black
        Me.cmbNewGender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbNewGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNewGender.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbNewGender.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbNewGender.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.cmbNewGender.ForeColor = System.Drawing.Color.Black
        Me.cmbNewGender.ItemHeight = 30
        Me.cmbNewGender.Items.AddRange(New Object() {"MALE", "FEMALE"})
        Me.cmbNewGender.Location = New System.Drawing.Point(191, 154)
        Me.cmbNewGender.Name = "cmbNewGender"
        Me.cmbNewGender.Size = New System.Drawing.Size(220, 36)
        Me.cmbNewGender.TabIndex = 147
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
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(468, 236)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(160, 18)
        Me.Label8.TabIndex = 139
        Me.Label8.Text = "ASSIGN TO CLINIC"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(468, 172)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(105, 18)
        Me.Label7.TabIndex = 138
        Me.Label7.Text = "USERNAME"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(36, 236)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 18)
        Me.Label4.TabIndex = 134
        Me.Label4.Text = "POSITION"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(468, 108)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 18)
        Me.Label6.TabIndex = 137
        Me.Label6.Text = "ADDRESS"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 18)
        Me.Label1.TabIndex = 132
        Me.Label1.Text = "FIRST NAME"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(468, 44)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(168, 18)
        Me.Label5.TabIndex = 136
        Me.Label5.Text = "CONTACT NUMBER"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 18)
        Me.Label2.TabIndex = 135
        Me.Label2.Text = "LAST NAME"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 172)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 18)
        Me.Label3.TabIndex = 133
        Me.Label3.Text = "GENDER"
        '
        'ShowPanelUpdate
        '
        Me.ShowPanelUpdate.Location = New System.Drawing.Point(912, 25)
        Me.ShowPanelUpdate.Name = "ShowPanelUpdate"
        Me.ShowPanelUpdate.Size = New System.Drawing.Size(157, 45)
        Me.ShowPanelUpdate.TabIndex = 123
        Me.ShowPanelUpdate.Text = "UPDATE INFORMATION?"
        Me.ShowPanelUpdate.UseVisualStyleBackColor = True
        '
        'btnUpdateNurse
        '
        Me.btnUpdateNurse.Location = New System.Drawing.Point(912, 76)
        Me.btnUpdateNurse.Name = "btnUpdateNurse"
        Me.btnUpdateNurse.Size = New System.Drawing.Size(157, 45)
        Me.btnUpdateNurse.TabIndex = 123
        Me.btnUpdateNurse.Text = "UPADATE NURSE"
        Me.btnUpdateNurse.UseVisualStyleBackColor = True
        Me.btnUpdateNurse.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblNurseContactNumber)
        Me.Panel1.Controls.Add(Me.lblNurseAddress)
        Me.Panel1.Controls.Add(Me.lblNurseUsername)
        Me.Panel1.Controls.Add(Me.lblNurseAccessCode)
        Me.Panel1.Controls.Add(Me.lblClinicAssigned)
        Me.Panel1.Controls.Add(Me.lblNurseFirstname)
        Me.Panel1.Controls.Add(Me.lblNurseLastname)
        Me.Panel1.Controls.Add(Me.lblNurseGender)
        Me.Panel1.Controls.Add(Me.lblNurseSpecialization)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.Label19)
        Me.Panel1.Controls.Add(Me.lblNurseID)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.Label20)
        Me.Panel1.Controls.Add(Me.Label21)
        Me.Panel1.Location = New System.Drawing.Point(6, 25)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(900, 360)
        Me.Panel1.TabIndex = 75
        '
        'lblNurseContactNumber
        '
        Me.lblNurseContactNumber.AutoSize = True
        Me.lblNurseContactNumber.Location = New System.Drawing.Point(665, 92)
        Me.lblNurseContactNumber.MaximumSize = New System.Drawing.Size(220, 0)
        Me.lblNurseContactNumber.Name = "lblNurseContactNumber"
        Me.lblNurseContactNumber.Size = New System.Drawing.Size(12, 18)
        Me.lblNurseContactNumber.TabIndex = 120
        Me.lblNurseContactNumber.Text = "-"
        '
        'lblNurseAddress
        '
        Me.lblNurseAddress.AutoSize = True
        Me.lblNurseAddress.Location = New System.Drawing.Point(665, 156)
        Me.lblNurseAddress.MaximumSize = New System.Drawing.Size(220, 0)
        Me.lblNurseAddress.Name = "lblNurseAddress"
        Me.lblNurseAddress.Size = New System.Drawing.Size(12, 18)
        Me.lblNurseAddress.TabIndex = 120
        Me.lblNurseAddress.Text = "-"
        '
        'lblNurseUsername
        '
        Me.lblNurseUsername.AutoSize = True
        Me.lblNurseUsername.Location = New System.Drawing.Point(665, 220)
        Me.lblNurseUsername.MaximumSize = New System.Drawing.Size(220, 0)
        Me.lblNurseUsername.Name = "lblNurseUsername"
        Me.lblNurseUsername.Size = New System.Drawing.Size(12, 18)
        Me.lblNurseUsername.TabIndex = 120
        Me.lblNurseUsername.Text = "-"
        '
        'lblNurseAccessCode
        '
        Me.lblNurseAccessCode.AutoSize = True
        Me.lblNurseAccessCode.Location = New System.Drawing.Point(665, 302)
        Me.lblNurseAccessCode.MaximumSize = New System.Drawing.Size(220, 0)
        Me.lblNurseAccessCode.Name = "lblNurseAccessCode"
        Me.lblNurseAccessCode.Size = New System.Drawing.Size(12, 18)
        Me.lblNurseAccessCode.TabIndex = 120
        Me.lblNurseAccessCode.Text = "-"
        '
        'lblClinicAssigned
        '
        Me.lblClinicAssigned.AutoSize = True
        Me.lblClinicAssigned.Location = New System.Drawing.Point(665, 284)
        Me.lblClinicAssigned.MaximumSize = New System.Drawing.Size(220, 0)
        Me.lblClinicAssigned.Name = "lblClinicAssigned"
        Me.lblClinicAssigned.Size = New System.Drawing.Size(12, 18)
        Me.lblClinicAssigned.TabIndex = 120
        Me.lblClinicAssigned.Text = "-"
        '
        'lblNurseFirstname
        '
        Me.lblNurseFirstname.AutoSize = True
        Me.lblNurseFirstname.Location = New System.Drawing.Point(211, 92)
        Me.lblNurseFirstname.MaximumSize = New System.Drawing.Size(220, 0)
        Me.lblNurseFirstname.Name = "lblNurseFirstname"
        Me.lblNurseFirstname.Size = New System.Drawing.Size(12, 18)
        Me.lblNurseFirstname.TabIndex = 120
        Me.lblNurseFirstname.Text = "-"
        '
        'lblNurseLastname
        '
        Me.lblNurseLastname.AutoSize = True
        Me.lblNurseLastname.Location = New System.Drawing.Point(211, 156)
        Me.lblNurseLastname.MaximumSize = New System.Drawing.Size(220, 0)
        Me.lblNurseLastname.Name = "lblNurseLastname"
        Me.lblNurseLastname.Size = New System.Drawing.Size(12, 18)
        Me.lblNurseLastname.TabIndex = 120
        Me.lblNurseLastname.Text = "-"
        '
        'lblNurseGender
        '
        Me.lblNurseGender.AutoSize = True
        Me.lblNurseGender.Location = New System.Drawing.Point(211, 220)
        Me.lblNurseGender.MaximumSize = New System.Drawing.Size(220, 0)
        Me.lblNurseGender.Name = "lblNurseGender"
        Me.lblNurseGender.Size = New System.Drawing.Size(12, 18)
        Me.lblNurseGender.TabIndex = 120
        Me.lblNurseGender.Text = "-"
        '
        'lblNurseSpecialization
        '
        Me.lblNurseSpecialization.AutoSize = True
        Me.lblNurseSpecialization.Location = New System.Drawing.Point(211, 284)
        Me.lblNurseSpecialization.MaximumSize = New System.Drawing.Size(220, 0)
        Me.lblNurseSpecialization.Name = "lblNurseSpecialization"
        Me.lblNurseSpecialization.Size = New System.Drawing.Size(12, 18)
        Me.lblNurseSpecialization.TabIndex = 120
        Me.lblNurseSpecialization.Text = "-"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(491, 284)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(160, 18)
        Me.Label14.TabIndex = 119
        Me.Label14.Text = "ASSIGN TO CLINIC"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(491, 220)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(105, 18)
        Me.Label15.TabIndex = 118
        Me.Label15.Text = "USERNAME"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(491, 156)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(88, 18)
        Me.Label17.TabIndex = 117
        Me.Label17.Text = "ADDRESS"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(491, 92)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(168, 18)
        Me.Label19.TabIndex = 116
        Me.Label19.Text = "CONTACT NUMBER"
        '
        'lblNurseID
        '
        Me.lblNurseID.AutoSize = True
        Me.lblNurseID.Location = New System.Drawing.Point(171, 19)
        Me.lblNurseID.Name = "lblNurseID"
        Me.lblNurseID.Size = New System.Drawing.Size(76, 18)
        Me.lblNurseID.TabIndex = 115
        Me.lblNurseID.Text = "NUR123"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(59, 19)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(91, 18)
        Me.Label13.TabIndex = 114
        Me.Label13.Text = "NURSE ID"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(59, 284)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(89, 18)
        Me.Label16.TabIndex = 112
        Me.Label16.Text = "POSITION"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(59, 220)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(80, 18)
        Me.Label18.TabIndex = 111
        Me.Label18.Text = "GENDER"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(59, 156)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(105, 18)
        Me.Label20.TabIndex = 113
        Me.Label20.Text = "LAST NAME"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(59, 92)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(111, 18)
        Me.Label21.TabIndex = 110
        Me.Label21.Text = "FIRST NAME"
        '
        'NurseProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1384, 761)
        Me.Controls.Add(Me.VisibleBTN)
        Me.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "NurseProfile"
        Me.Padding = New System.Windows.Forms.Padding(3)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nurse Information"
        Me.VisibleBTN.ResumeLayout(False)
        Me.UpdatePanelField.ResumeLayout(False)
        Me.UpdatePanelField.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListBoxNurseNames As ListBox
    Friend WithEvents VisibleBTN As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents lblNurseID As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents lblNurseContactNumber As Label
    Friend WithEvents lblNurseAddress As Label
    Friend WithEvents lblNurseUsername As Label
    Friend WithEvents lblClinicAssigned As Label
    Friend WithEvents lblNurseFirstname As Label
    Friend WithEvents lblNurseLastname As Label
    Friend WithEvents lblNurseGender As Label
    Friend WithEvents lblNurseSpecialization As Label
    Friend WithEvents lblNurseAccessCode As Label
    Friend WithEvents btnUpdateNurse As Button
    Friend WithEvents ShowPanelUpdate As Button
    Friend WithEvents UpdatePanelField As Panel
    Friend WithEvents txtNewAccessCode As Label
    Friend WithEvents cmbNewSpecialization As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cmbNewClinic As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents txtNewLastName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtNewUsername As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtNewFirstName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cmbNewGender As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents txtNewContactNumber As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtNewAddress As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
