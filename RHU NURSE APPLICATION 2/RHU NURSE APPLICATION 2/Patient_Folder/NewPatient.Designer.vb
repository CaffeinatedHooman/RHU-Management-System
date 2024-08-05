<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewPatient
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
        Me.btnClearPatient = New System.Windows.Forms.Button()
        Me.PatientIDLabelGen = New System.Windows.Forms.Label()
        Me.dtpDOB = New System.Windows.Forms.DateTimePicker()
        Me.LabelSex = New System.Windows.Forms.Label()
        Me.LabelReligion = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LabelPHLID = New System.Windows.Forms.Label()
        Me.LabelPC = New System.Windows.Forms.Label()
        Me.txtAddress = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtPhilhealthID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtContactNumber = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cboMaritalStatus = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cboGender = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.LabelCitizen = New System.Windows.Forms.Label()
        Me.LabelAge = New System.Windows.Forms.Label()
        Me.LabelDOB = New System.Windows.Forms.Label()
        Me.LabelLastname = New System.Windows.Forms.Label()
        Me.LabelMIddlename = New System.Windows.Forms.Label()
        Me.LabelFirstname = New System.Windows.Forms.Label()
        Me.txtAge = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtLastName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtReligion = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtCitizenship = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtMiddleName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtFirstName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.LabelPateintId = New System.Windows.Forms.Label()
        Me.btnCreatePatient = New System.Windows.Forms.Button()
        Me.GroupBoxVital = New System.Windows.Forms.GroupBox()
        Me.SaveVitals = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbDoctors = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblClinicName = New System.Windows.Forms.Label()
        Me.lblSelectedDoctorID = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDiagnosis = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtHeight = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtPulseRate = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtWeight = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtRespirationRate = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtBloodPressure = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtBodyTemp = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBoxVital.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.btnClearPatient)
        Me.GroupBox1.Controls.Add(Me.PatientIDLabelGen)
        Me.GroupBox1.Controls.Add(Me.dtpDOB)
        Me.GroupBox1.Controls.Add(Me.LabelSex)
        Me.GroupBox1.Controls.Add(Me.LabelReligion)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.LabelPHLID)
        Me.GroupBox1.Controls.Add(Me.LabelPC)
        Me.GroupBox1.Controls.Add(Me.txtAddress)
        Me.GroupBox1.Controls.Add(Me.txtPhilhealthID)
        Me.GroupBox1.Controls.Add(Me.txtContactNumber)
        Me.GroupBox1.Controls.Add(Me.cboMaritalStatus)
        Me.GroupBox1.Controls.Add(Me.cboGender)
        Me.GroupBox1.Controls.Add(Me.Label37)
        Me.GroupBox1.Controls.Add(Me.LabelCitizen)
        Me.GroupBox1.Controls.Add(Me.LabelAge)
        Me.GroupBox1.Controls.Add(Me.LabelDOB)
        Me.GroupBox1.Controls.Add(Me.LabelLastname)
        Me.GroupBox1.Controls.Add(Me.LabelMIddlename)
        Me.GroupBox1.Controls.Add(Me.LabelFirstname)
        Me.GroupBox1.Controls.Add(Me.txtAge)
        Me.GroupBox1.Controls.Add(Me.txtLastName)
        Me.GroupBox1.Controls.Add(Me.txtReligion)
        Me.GroupBox1.Controls.Add(Me.txtCitizenship)
        Me.GroupBox1.Controls.Add(Me.txtMiddleName)
        Me.GroupBox1.Controls.Add(Me.txtFirstName)
        Me.GroupBox1.Controls.Add(Me.LabelPateintId)
        Me.GroupBox1.Controls.Add(Me.btnCreatePatient)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1218, 480)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "PATIENT INFORMATION"
        '
        'btnClearPatient
        '
        Me.btnClearPatient.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnClearPatient.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearPatient.Location = New System.Drawing.Point(972, 410)
        Me.btnClearPatient.Name = "btnClearPatient"
        Me.btnClearPatient.Size = New System.Drawing.Size(100, 40)
        Me.btnClearPatient.TabIndex = 936
        Me.btnClearPatient.Text = "CLEAR"
        Me.btnClearPatient.UseVisualStyleBackColor = True
        '
        'PatientIDLabelGen
        '
        Me.PatientIDLabelGen.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PatientIDLabelGen.AutoSize = True
        Me.PatientIDLabelGen.BackColor = System.Drawing.Color.White
        Me.PatientIDLabelGen.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PatientIDLabelGen.Location = New System.Drawing.Point(197, 77)
        Me.PatientIDLabelGen.Name = "PatientIDLabelGen"
        Me.PatientIDLabelGen.Size = New System.Drawing.Size(122, 18)
        Me.PatientIDLabelGen.TabIndex = 935
        Me.PatientIDLabelGen.Text = "RHU-PATIENT"
        '
        'dtpDOB
        '
        Me.dtpDOB.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.dtpDOB.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDOB.Location = New System.Drawing.Point(596, 213)
        Me.dtpDOB.MinimumSize = New System.Drawing.Size(200, 35)
        Me.dtpDOB.Name = "dtpDOB"
        Me.dtpDOB.Size = New System.Drawing.Size(200, 35)
        Me.dtpDOB.TabIndex = 934
        Me.dtpDOB.Value = New Date(2023, 12, 28, 0, 0, 0, 0)
        '
        'LabelSex
        '
        Me.LabelSex.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelSex.AutoSize = True
        Me.LabelSex.BackColor = System.Drawing.Color.White
        Me.LabelSex.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSex.Location = New System.Drawing.Point(42, 217)
        Me.LabelSex.Name = "LabelSex"
        Me.LabelSex.Size = New System.Drawing.Size(80, 18)
        Me.LabelSex.TabIndex = 933
        Me.LabelSex.Text = "GENDER"
        '
        'LabelReligion
        '
        Me.LabelReligion.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelReligion.AutoSize = True
        Me.LabelReligion.BackColor = System.Drawing.Color.White
        Me.LabelReligion.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelReligion.Location = New System.Drawing.Point(42, 349)
        Me.LabelReligion.Name = "LabelReligion"
        Me.LabelReligion.Size = New System.Drawing.Size(88, 18)
        Me.LabelReligion.TabIndex = 930
        Me.LabelReligion.Text = "ADDRESS"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(42, 285)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(153, 18)
        Me.Label3.TabIndex = 931
        Me.Label3.Text = "MARITAL STATUS"
        '
        'LabelPHLID
        '
        Me.LabelPHLID.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelPHLID.AutoSize = True
        Me.LabelPHLID.BackColor = System.Drawing.Color.White
        Me.LabelPHLID.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPHLID.Location = New System.Drawing.Point(829, 349)
        Me.LabelPHLID.Name = "LabelPHLID"
        Me.LabelPHLID.Size = New System.Drawing.Size(142, 18)
        Me.LabelPHLID.TabIndex = 932
        Me.LabelPHLID.Text = "PHILHEALTH ID"
        '
        'LabelPC
        '
        Me.LabelPC.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelPC.AutoSize = True
        Me.LabelPC.BackColor = System.Drawing.Color.White
        Me.LabelPC.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPC.Location = New System.Drawing.Point(433, 349)
        Me.LabelPC.Name = "LabelPC"
        Me.LabelPC.Size = New System.Drawing.Size(156, 18)
        Me.LabelPC.TabIndex = 929
        Me.LabelPC.Text = "MOBILE NUMBER"
        '
        'txtAddress
        '
        Me.txtAddress.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtAddress.Animated = True
        Me.txtAddress.AutoCompleteCustomSource.AddRange(New String() {"CAUAYAN CITY"})
        Me.txtAddress.BorderColor = System.Drawing.Color.Black
        Me.txtAddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAddress.DefaultText = ""
        Me.txtAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAddress.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.ForeColor = System.Drawing.Color.Black
        Me.txtAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAddress.Location = New System.Drawing.Point(201, 340)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtAddress.MaxLength = 100
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAddress.PlaceholderText = ""
        Me.txtAddress.SelectedText = ""
        Me.txtAddress.Size = New System.Drawing.Size(200, 80)
        Me.txtAddress.TabIndex = 926
        '
        'txtPhilhealthID
        '
        Me.txtPhilhealthID.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtPhilhealthID.Animated = True
        Me.txtPhilhealthID.BorderColor = System.Drawing.Color.Black
        Me.txtPhilhealthID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPhilhealthID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPhilhealthID.DefaultText = ""
        Me.txtPhilhealthID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPhilhealthID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPhilhealthID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPhilhealthID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPhilhealthID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPhilhealthID.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhilhealthID.ForeColor = System.Drawing.Color.Black
        Me.txtPhilhealthID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPhilhealthID.Location = New System.Drawing.Point(978, 340)
        Me.txtPhilhealthID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPhilhealthID.MaxLength = 15
        Me.txtPhilhealthID.Name = "txtPhilhealthID"
        Me.txtPhilhealthID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPhilhealthID.PlaceholderText = ""
        Me.txtPhilhealthID.SelectedText = ""
        Me.txtPhilhealthID.Size = New System.Drawing.Size(200, 35)
        Me.txtPhilhealthID.TabIndex = 927
        '
        'txtContactNumber
        '
        Me.txtContactNumber.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtContactNumber.Animated = True
        Me.txtContactNumber.BorderColor = System.Drawing.Color.Black
        Me.txtContactNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtContactNumber.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtContactNumber.DefaultText = ""
        Me.txtContactNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtContactNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtContactNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtContactNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtContactNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtContactNumber.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContactNumber.ForeColor = System.Drawing.Color.Black
        Me.txtContactNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtContactNumber.Location = New System.Drawing.Point(596, 340)
        Me.txtContactNumber.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtContactNumber.MaxLength = 15
        Me.txtContactNumber.Name = "txtContactNumber"
        Me.txtContactNumber.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtContactNumber.PlaceholderText = ""
        Me.txtContactNumber.SelectedText = ""
        Me.txtContactNumber.Size = New System.Drawing.Size(200, 35)
        Me.txtContactNumber.TabIndex = 928
        '
        'cboMaritalStatus
        '
        Me.cboMaritalStatus.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cboMaritalStatus.BackColor = System.Drawing.Color.Transparent
        Me.cboMaritalStatus.BorderColor = System.Drawing.Color.Black
        Me.cboMaritalStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboMaritalStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMaritalStatus.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboMaritalStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboMaritalStatus.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold)
        Me.cboMaritalStatus.ForeColor = System.Drawing.Color.Black
        Me.cboMaritalStatus.ItemHeight = 30
        Me.cboMaritalStatus.Location = New System.Drawing.Point(201, 275)
        Me.cboMaritalStatus.Name = "cboMaritalStatus"
        Me.cboMaritalStatus.Size = New System.Drawing.Size(200, 36)
        Me.cboMaritalStatus.TabIndex = 924
        '
        'cboGender
        '
        Me.cboGender.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cboGender.BackColor = System.Drawing.Color.Transparent
        Me.cboGender.BorderColor = System.Drawing.Color.Black
        Me.cboGender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGender.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboGender.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboGender.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboGender.ForeColor = System.Drawing.Color.Black
        Me.cboGender.ItemHeight = 30
        Me.cboGender.Items.AddRange(New Object() {"MALE", "FEMALE"})
        Me.cboGender.Location = New System.Drawing.Point(201, 212)
        Me.cboGender.Name = "cboGender"
        Me.cboGender.Size = New System.Drawing.Size(200, 36)
        Me.cboGender.TabIndex = 925
        '
        'Label37
        '
        Me.Label37.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label37.AutoSize = True
        Me.Label37.BackColor = System.Drawing.Color.White
        Me.Label37.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(829, 285)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(91, 18)
        Me.Label37.TabIndex = 920
        Me.Label37.Text = "RELIGION"
        '
        'LabelCitizen
        '
        Me.LabelCitizen.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelCitizen.AutoSize = True
        Me.LabelCitizen.BackColor = System.Drawing.Color.White
        Me.LabelCitizen.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCitizen.Location = New System.Drawing.Point(433, 285)
        Me.LabelCitizen.Name = "LabelCitizen"
        Me.LabelCitizen.Size = New System.Drawing.Size(115, 18)
        Me.LabelCitizen.TabIndex = 921
        Me.LabelCitizen.Text = "CITIZENSHIP"
        '
        'LabelAge
        '
        Me.LabelAge.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelAge.AutoSize = True
        Me.LabelAge.BackColor = System.Drawing.Color.White
        Me.LabelAge.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAge.Location = New System.Drawing.Point(829, 217)
        Me.LabelAge.Name = "LabelAge"
        Me.LabelAge.Size = New System.Drawing.Size(42, 18)
        Me.LabelAge.TabIndex = 922
        Me.LabelAge.Text = "AGE"
        '
        'LabelDOB
        '
        Me.LabelDOB.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelDOB.AutoSize = True
        Me.LabelDOB.BackColor = System.Drawing.Color.White
        Me.LabelDOB.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDOB.Location = New System.Drawing.Point(433, 217)
        Me.LabelDOB.Name = "LabelDOB"
        Me.LabelDOB.Size = New System.Drawing.Size(138, 18)
        Me.LabelDOB.TabIndex = 923
        Me.LabelDOB.Text = "DATE OF BIRTH"
        '
        'LabelLastname
        '
        Me.LabelLastname.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelLastname.AutoSize = True
        Me.LabelLastname.BackColor = System.Drawing.Color.White
        Me.LabelLastname.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLastname.Location = New System.Drawing.Point(829, 149)
        Me.LabelLastname.Name = "LabelLastname"
        Me.LabelLastname.Size = New System.Drawing.Size(105, 18)
        Me.LabelLastname.TabIndex = 917
        Me.LabelLastname.Text = "LAST NAME"
        '
        'LabelMIddlename
        '
        Me.LabelMIddlename.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelMIddlename.AutoSize = True
        Me.LabelMIddlename.BackColor = System.Drawing.Color.White
        Me.LabelMIddlename.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMIddlename.Location = New System.Drawing.Point(433, 149)
        Me.LabelMIddlename.Name = "LabelMIddlename"
        Me.LabelMIddlename.Size = New System.Drawing.Size(133, 18)
        Me.LabelMIddlename.TabIndex = 919
        Me.LabelMIddlename.Text = "MIDDLE NAME"
        '
        'LabelFirstname
        '
        Me.LabelFirstname.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelFirstname.AutoSize = True
        Me.LabelFirstname.BackColor = System.Drawing.Color.White
        Me.LabelFirstname.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFirstname.Location = New System.Drawing.Point(42, 149)
        Me.LabelFirstname.Name = "LabelFirstname"
        Me.LabelFirstname.Size = New System.Drawing.Size(111, 18)
        Me.LabelFirstname.TabIndex = 918
        Me.LabelFirstname.Text = "FIRST NAME"
        '
        'txtAge
        '
        Me.txtAge.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtAge.Animated = True
        Me.txtAge.BorderColor = System.Drawing.Color.Black
        Me.txtAge.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAge.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAge.DefaultText = ""
        Me.txtAge.DisabledState.BorderColor = System.Drawing.Color.Black
        Me.txtAge.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtAge.DisabledState.ForeColor = System.Drawing.Color.Black
        Me.txtAge.DisabledState.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtAge.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAge.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAge.ForeColor = System.Drawing.Color.Black
        Me.txtAge.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAge.Location = New System.Drawing.Point(978, 212)
        Me.txtAge.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAge.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtAge.PlaceholderText = ""
        Me.txtAge.ReadOnly = True
        Me.txtAge.SelectedText = ""
        Me.txtAge.Size = New System.Drawing.Size(200, 35)
        Me.txtAge.TabIndex = 914
        '
        'txtLastName
        '
        Me.txtLastName.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtLastName.Animated = True
        Me.txtLastName.BorderColor = System.Drawing.Color.Black
        Me.txtLastName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLastName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLastName.DefaultText = ""
        Me.txtLastName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtLastName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtLastName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtLastName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtLastName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtLastName.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.ForeColor = System.Drawing.Color.Black
        Me.txtLastName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtLastName.Location = New System.Drawing.Point(978, 149)
        Me.txtLastName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtLastName.MaxLength = 30
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLastName.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtLastName.PlaceholderText = ""
        Me.txtLastName.SelectedText = ""
        Me.txtLastName.Size = New System.Drawing.Size(200, 35)
        Me.txtLastName.TabIndex = 915
        '
        'txtReligion
        '
        Me.txtReligion.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtReligion.Animated = True
        Me.txtReligion.BorderColor = System.Drawing.Color.Black
        Me.txtReligion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtReligion.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtReligion.DefaultText = ""
        Me.txtReligion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtReligion.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtReligion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtReligion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtReligion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtReligion.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReligion.ForeColor = System.Drawing.Color.Black
        Me.txtReligion.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtReligion.Location = New System.Drawing.Point(978, 276)
        Me.txtReligion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtReligion.MaxLength = 30
        Me.txtReligion.Name = "txtReligion"
        Me.txtReligion.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtReligion.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtReligion.PlaceholderText = ""
        Me.txtReligion.SelectedText = ""
        Me.txtReligion.Size = New System.Drawing.Size(200, 35)
        Me.txtReligion.TabIndex = 916
        '
        'txtCitizenship
        '
        Me.txtCitizenship.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtCitizenship.Animated = True
        Me.txtCitizenship.BorderColor = System.Drawing.Color.Black
        Me.txtCitizenship.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCitizenship.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCitizenship.DefaultText = ""
        Me.txtCitizenship.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCitizenship.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCitizenship.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCitizenship.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCitizenship.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCitizenship.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCitizenship.ForeColor = System.Drawing.Color.Black
        Me.txtCitizenship.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCitizenship.Location = New System.Drawing.Point(596, 276)
        Me.txtCitizenship.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCitizenship.MaxLength = 30
        Me.txtCitizenship.Name = "txtCitizenship"
        Me.txtCitizenship.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCitizenship.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtCitizenship.PlaceholderText = ""
        Me.txtCitizenship.SelectedText = ""
        Me.txtCitizenship.Size = New System.Drawing.Size(200, 35)
        Me.txtCitizenship.TabIndex = 916
        '
        'txtMiddleName
        '
        Me.txtMiddleName.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtMiddleName.Animated = True
        Me.txtMiddleName.BorderColor = System.Drawing.Color.Black
        Me.txtMiddleName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMiddleName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMiddleName.DefaultText = ""
        Me.txtMiddleName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtMiddleName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtMiddleName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtMiddleName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtMiddleName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMiddleName.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMiddleName.ForeColor = System.Drawing.Color.Black
        Me.txtMiddleName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMiddleName.Location = New System.Drawing.Point(596, 149)
        Me.txtMiddleName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtMiddleName.MaxLength = 30
        Me.txtMiddleName.Name = "txtMiddleName"
        Me.txtMiddleName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMiddleName.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtMiddleName.PlaceholderText = ""
        Me.txtMiddleName.SelectedText = ""
        Me.txtMiddleName.Size = New System.Drawing.Size(200, 35)
        Me.txtMiddleName.TabIndex = 916
        '
        'txtFirstName
        '
        Me.txtFirstName.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtFirstName.Animated = True
        Me.txtFirstName.BorderColor = System.Drawing.Color.Black
        Me.txtFirstName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFirstName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFirstName.DefaultText = ""
        Me.txtFirstName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtFirstName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtFirstName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFirstName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFirstName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFirstName.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.ForeColor = System.Drawing.Color.Black
        Me.txtFirstName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFirstName.Location = New System.Drawing.Point(201, 149)
        Me.txtFirstName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtFirstName.MaxLength = 50
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFirstName.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtFirstName.PlaceholderText = ""
        Me.txtFirstName.SelectedText = ""
        Me.txtFirstName.Size = New System.Drawing.Size(200, 35)
        Me.txtFirstName.TabIndex = 911
        '
        'LabelPateintId
        '
        Me.LabelPateintId.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelPateintId.AutoSize = True
        Me.LabelPateintId.BackColor = System.Drawing.Color.White
        Me.LabelPateintId.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPateintId.Location = New System.Drawing.Point(41, 77)
        Me.LabelPateintId.Name = "LabelPateintId"
        Me.LabelPateintId.Size = New System.Drawing.Size(102, 18)
        Me.LabelPateintId.TabIndex = 910
        Me.LabelPateintId.Text = "PATIENT-ID"
        '
        'btnCreatePatient
        '
        Me.btnCreatePatient.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnCreatePatient.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreatePatient.Location = New System.Drawing.Point(1078, 410)
        Me.btnCreatePatient.Name = "btnCreatePatient"
        Me.btnCreatePatient.Size = New System.Drawing.Size(100, 40)
        Me.btnCreatePatient.TabIndex = 909
        Me.btnCreatePatient.Text = "SAVE"
        Me.btnCreatePatient.UseVisualStyleBackColor = True
        '
        'GroupBoxVital
        '
        Me.GroupBoxVital.BackColor = System.Drawing.Color.White
        Me.GroupBoxVital.Controls.Add(Me.SaveVitals)
        Me.GroupBoxVital.Controls.Add(Me.Label1)
        Me.GroupBoxVital.Controls.Add(Me.cmbDoctors)
        Me.GroupBoxVital.Controls.Add(Me.Label16)
        Me.GroupBoxVital.Controls.Add(Me.lblClinicName)
        Me.GroupBoxVital.Controls.Add(Me.lblSelectedDoctorID)
        Me.GroupBoxVital.Controls.Add(Me.Label2)
        Me.GroupBoxVital.Controls.Add(Me.txtDiagnosis)
        Me.GroupBoxVital.Controls.Add(Me.Label4)
        Me.GroupBoxVital.Controls.Add(Me.txtHeight)
        Me.GroupBoxVital.Controls.Add(Me.txtPulseRate)
        Me.GroupBoxVital.Controls.Add(Me.txtWeight)
        Me.GroupBoxVital.Controls.Add(Me.txtRespirationRate)
        Me.GroupBoxVital.Controls.Add(Me.txtBloodPressure)
        Me.GroupBoxVital.Controls.Add(Me.txtBodyTemp)
        Me.GroupBoxVital.Controls.Add(Me.Label5)
        Me.GroupBoxVital.Controls.Add(Me.Label6)
        Me.GroupBoxVital.Controls.Add(Me.Label7)
        Me.GroupBoxVital.Controls.Add(Me.Label15)
        Me.GroupBoxVital.Controls.Add(Me.Label17)
        Me.GroupBoxVital.Controls.Add(Me.Label18)
        Me.GroupBoxVital.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBoxVital.Location = New System.Drawing.Point(0, 480)
        Me.GroupBoxVital.Name = "GroupBoxVital"
        Me.GroupBoxVital.Size = New System.Drawing.Size(1218, 410)
        Me.GroupBoxVital.TabIndex = 7
        Me.GroupBoxVital.TabStop = False
        Me.GroupBoxVital.Text = "VITAL SIGNS"
        Me.GroupBoxVital.Visible = False
        '
        'SaveVitals
        '
        Me.SaveVitals.Enabled = False
        Me.SaveVitals.Location = New System.Drawing.Point(905, 333)
        Me.SaveVitals.Name = "SaveVitals"
        Me.SaveVitals.Size = New System.Drawing.Size(200, 40)
        Me.SaveVitals.TabIndex = 527
        Me.SaveVitals.Text = "SEND TO DOCTOR"
        Me.SaveVitals.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(813, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(339, 18)
        Me.Label1.TabIndex = 526
        Me.Label1.Text = "SELECT DOCTOR TO CHECKUP PATIENT"
        '
        'cmbDoctors
        '
        Me.cmbDoctors.BackColor = System.Drawing.Color.Transparent
        Me.cmbDoctors.BorderColor = System.Drawing.Color.Black
        Me.cmbDoctors.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbDoctors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDoctors.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbDoctors.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbDoctors.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDoctors.ForeColor = System.Drawing.Color.Black
        Me.cmbDoctors.ItemHeight = 30
        Me.cmbDoctors.Location = New System.Drawing.Point(851, 58)
        Me.cmbDoctors.Name = "cmbDoctors"
        Me.cmbDoctors.Size = New System.Drawing.Size(250, 36)
        Me.cmbDoctors.TabIndex = 525
        '
        'Label16
        '
        Me.Label16.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(228, 229)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(90, 12)
        Me.Label16.TabIndex = 524
        Me.Label16.Text = "WEIGHT BY KG"
        '
        'lblClinicName
        '
        Me.lblClinicName.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblClinicName.AutoSize = True
        Me.lblClinicName.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClinicName.Location = New System.Drawing.Point(943, 20)
        Me.lblClinicName.Name = "lblClinicName"
        Me.lblClinicName.Size = New System.Drawing.Size(65, 18)
        Me.lblClinicName.TabIndex = 523
        Me.lblClinicName.Text = "CLINIC"
        '
        'lblSelectedDoctorID
        '
        Me.lblSelectedDoctorID.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblSelectedDoctorID.AutoSize = True
        Me.lblSelectedDoctorID.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectedDoctorID.Location = New System.Drawing.Point(902, 376)
        Me.lblSelectedDoctorID.Name = "lblSelectedDoctorID"
        Me.lblSelectedDoctorID.Size = New System.Drawing.Size(46, 15)
        Me.lblSelectedDoctorID.TabIndex = 523
        Me.lblSelectedDoctorID.Text = "docid"
        Me.lblSelectedDoctorID.Visible = False
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(583, 229)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 12)
        Me.Label2.TabIndex = 522
        Me.Label2.Text = "HEIGHT BY CM"
        '
        'txtDiagnosis
        '
        Me.txtDiagnosis.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtDiagnosis.Animated = True
        Me.txtDiagnosis.BorderColor = System.Drawing.Color.Black
        Me.txtDiagnosis.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDiagnosis.DefaultText = ""
        Me.txtDiagnosis.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtDiagnosis.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtDiagnosis.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDiagnosis.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDiagnosis.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDiagnosis.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiagnosis.ForeColor = System.Drawing.Color.Black
        Me.txtDiagnosis.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDiagnosis.Location = New System.Drawing.Point(230, 264)
        Me.txtDiagnosis.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtDiagnosis.MaxLength = 500
        Me.txtDiagnosis.Multiline = True
        Me.txtDiagnosis.Name = "txtDiagnosis"
        Me.txtDiagnosis.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDiagnosis.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtDiagnosis.PlaceholderText = ""
        Me.txtDiagnosis.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtDiagnosis.SelectedText = ""
        Me.txtDiagnosis.Size = New System.Drawing.Size(505, 111)
        Me.txtDiagnosis.TabIndex = 521
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(36, 306)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(190, 18)
        Me.Label4.TabIndex = 520
        Me.Label4.Text = "PATIENT SYSMTOPMS"
        '
        'txtHeight
        '
        Me.txtHeight.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtHeight.Animated = True
        Me.txtHeight.BorderColor = System.Drawing.Color.Black
        Me.txtHeight.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHeight.DefaultText = ""
        Me.txtHeight.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtHeight.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtHeight.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtHeight.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtHeight.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtHeight.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtHeight.ForeColor = System.Drawing.Color.Black
        Me.txtHeight.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtHeight.Location = New System.Drawing.Point(585, 191)
        Me.txtHeight.MaxLength = 10
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtHeight.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtHeight.PlaceholderText = ""
        Me.txtHeight.SelectedText = ""
        Me.txtHeight.Size = New System.Drawing.Size(150, 35)
        Me.txtHeight.TabIndex = 517
        '
        'txtPulseRate
        '
        Me.txtPulseRate.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtPulseRate.Animated = True
        Me.txtPulseRate.BorderColor = System.Drawing.Color.Black
        Me.txtPulseRate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPulseRate.DefaultText = ""
        Me.txtPulseRate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPulseRate.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPulseRate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPulseRate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPulseRate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPulseRate.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtPulseRate.ForeColor = System.Drawing.Color.Black
        Me.txtPulseRate.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPulseRate.Location = New System.Drawing.Point(585, 124)
        Me.txtPulseRate.MaxLength = 10
        Me.txtPulseRate.Name = "txtPulseRate"
        Me.txtPulseRate.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPulseRate.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtPulseRate.PlaceholderText = ""
        Me.txtPulseRate.SelectedText = ""
        Me.txtPulseRate.Size = New System.Drawing.Size(150, 35)
        Me.txtPulseRate.TabIndex = 518
        '
        'txtWeight
        '
        Me.txtWeight.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtWeight.Animated = True
        Me.txtWeight.BorderColor = System.Drawing.Color.Black
        Me.txtWeight.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtWeight.DefaultText = ""
        Me.txtWeight.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtWeight.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtWeight.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtWeight.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtWeight.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtWeight.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtWeight.ForeColor = System.Drawing.Color.Black
        Me.txtWeight.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtWeight.Location = New System.Drawing.Point(230, 191)
        Me.txtWeight.MaxLength = 10
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtWeight.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtWeight.PlaceholderText = ""
        Me.txtWeight.SelectedText = ""
        Me.txtWeight.Size = New System.Drawing.Size(150, 35)
        Me.txtWeight.TabIndex = 515
        '
        'txtRespirationRate
        '
        Me.txtRespirationRate.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtRespirationRate.Animated = True
        Me.txtRespirationRate.BorderColor = System.Drawing.Color.Black
        Me.txtRespirationRate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtRespirationRate.DefaultText = ""
        Me.txtRespirationRate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtRespirationRate.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtRespirationRate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtRespirationRate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtRespirationRate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtRespirationRate.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtRespirationRate.ForeColor = System.Drawing.Color.Black
        Me.txtRespirationRate.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtRespirationRate.Location = New System.Drawing.Point(230, 124)
        Me.txtRespirationRate.MaxLength = 10
        Me.txtRespirationRate.Name = "txtRespirationRate"
        Me.txtRespirationRate.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRespirationRate.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtRespirationRate.PlaceholderText = ""
        Me.txtRespirationRate.SelectedText = ""
        Me.txtRespirationRate.Size = New System.Drawing.Size(150, 35)
        Me.txtRespirationRate.TabIndex = 516
        '
        'txtBloodPressure
        '
        Me.txtBloodPressure.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtBloodPressure.Animated = True
        Me.txtBloodPressure.BorderColor = System.Drawing.Color.Black
        Me.txtBloodPressure.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBloodPressure.DefaultText = ""
        Me.txtBloodPressure.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtBloodPressure.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtBloodPressure.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBloodPressure.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBloodPressure.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBloodPressure.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtBloodPressure.ForeColor = System.Drawing.Color.Black
        Me.txtBloodPressure.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBloodPressure.Location = New System.Drawing.Point(585, 58)
        Me.txtBloodPressure.MaxLength = 10
        Me.txtBloodPressure.Name = "txtBloodPressure"
        Me.txtBloodPressure.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBloodPressure.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtBloodPressure.PlaceholderText = ""
        Me.txtBloodPressure.SelectedText = ""
        Me.txtBloodPressure.Size = New System.Drawing.Size(150, 35)
        Me.txtBloodPressure.TabIndex = 519
        '
        'txtBodyTemp
        '
        Me.txtBodyTemp.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtBodyTemp.Animated = True
        Me.txtBodyTemp.BorderColor = System.Drawing.Color.Black
        Me.txtBodyTemp.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBodyTemp.DefaultText = ""
        Me.txtBodyTemp.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtBodyTemp.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtBodyTemp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBodyTemp.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBodyTemp.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBodyTemp.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtBodyTemp.ForeColor = System.Drawing.Color.Black
        Me.txtBodyTemp.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBodyTemp.Location = New System.Drawing.Point(230, 57)
        Me.txtBodyTemp.MaxLength = 10
        Me.txtBodyTemp.Name = "txtBodyTemp"
        Me.txtBodyTemp.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBodyTemp.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtBodyTemp.PlaceholderText = ""
        Me.txtBodyTemp.SelectedText = ""
        Me.txtBodyTemp.Size = New System.Drawing.Size(150, 35)
        Me.txtBodyTemp.TabIndex = 514
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(404, 191)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 18)
        Me.Label5.TabIndex = 511
        Me.Label5.Text = "HEIGHT"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(404, 58)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(175, 18)
        Me.Label6.TabIndex = 512
        Me.Label6.Text = "BLOOOD PRESSURE"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(36, 191)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 18)
        Me.Label7.TabIndex = 509
        Me.Label7.Text = "WEIGHT"
        '
        'Label15
        '
        Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(36, 123)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(171, 18)
        Me.Label15.TabIndex = 510
        Me.Label15.Text = "RESPIRATION RATE"
        '
        'Label17
        '
        Me.Label17.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(404, 123)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(111, 18)
        Me.Label17.TabIndex = 508
        Me.Label17.Text = "PULSE RATE"
        '
        'Label18
        '
        Me.Label18.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(36, 58)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(188, 18)
        Me.Label18.TabIndex = 513
        Me.Label18.Text = "BODY TEMPERATURE"
        '
        'NewPatient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1235, 561)
        Me.Controls.Add(Me.GroupBoxVital)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "NewPatient"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NewPatient"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBoxVital.ResumeLayout(False)
        Me.GroupBoxVital.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnClearPatient As Button
    Friend WithEvents PatientIDLabelGen As Label
    Friend WithEvents dtpDOB As DateTimePicker
    Friend WithEvents LabelSex As Label
    Friend WithEvents LabelReligion As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LabelPHLID As Label
    Friend WithEvents LabelPC As Label
    Friend WithEvents txtAddress As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtPhilhealthID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtContactNumber As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cboMaritalStatus As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cboGender As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label37 As Label
    Friend WithEvents LabelCitizen As Label
    Friend WithEvents LabelAge As Label
    Friend WithEvents LabelDOB As Label
    Friend WithEvents LabelLastname As Label
    Friend WithEvents LabelMIddlename As Label
    Friend WithEvents LabelFirstname As Label
    Friend WithEvents txtAge As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtLastName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtReligion As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtCitizenship As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtMiddleName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtFirstName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents LabelPateintId As Label
    Friend WithEvents btnCreatePatient As Button
    Friend WithEvents GroupBoxVital As GroupBox
    Friend WithEvents SaveVitals As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbDoctors As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents lblClinicName As Label
    Friend WithEvents lblSelectedDoctorID As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDiagnosis As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtHeight As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtPulseRate As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtWeight As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtRespirationRate As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtBloodPressure As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtBodyTemp As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
End Class
