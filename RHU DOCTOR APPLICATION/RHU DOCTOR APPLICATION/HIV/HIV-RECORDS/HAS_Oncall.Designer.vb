<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HAS_Oncall
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ClinicGeneralTab = New Guna.UI2.WinForms.Guna2TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.CallPatientVTN = New System.Windows.Forms.Button()
        Me.txthealthStatus = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtSTIMedication = New System.Windows.Forms.CheckedListBox()
        Me.txtSTIStatus = New System.Windows.Forms.CheckedListBox()
        Me.txtHIVMedication = New System.Windows.Forms.CheckedListBox()
        Me.txtHIVStatus = New System.Windows.Forms.CheckedListBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SaveDoctorDiagnosis = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblDiagnosis = New System.Windows.Forms.Label()
        Me.lblHeight = New System.Windows.Forms.Label()
        Me.lblWeight = New System.Windows.Forms.Label()
        Me.lblPulseRate = New System.Windows.Forms.Label()
        Me.lblRespirationRate = New System.Windows.Forms.Label()
        Me.lblBloodPressure = New System.Windows.Forms.Label()
        Me.lblBodyTemp = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblContactNumber = New System.Windows.Forms.Label()
        Me.lblPhilhealthID = New System.Windows.Forms.Label()
        Me.lblDOB = New System.Windows.Forms.Label()
        Me.lblMiddlename = New System.Windows.Forms.Label()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.lblLastname = New System.Windows.Forms.Label()
        Me.lblMaritalStatus = New System.Windows.Forms.Label()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.lblFirstname = New System.Windows.Forms.Label()
        Me.lblPatientID = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PatientQueueList = New System.Windows.Forms.ListBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.PasttxtSTIMedication = New System.Windows.Forms.Label()
        Me.PasttxthealthStatus = New System.Windows.Forms.Label()
        Me.PasttxtSTIStatus = New System.Windows.Forms.Label()
        Me.PasttxtHIVMedication = New System.Windows.Forms.Label()
        Me.PasttxtHIVStatus = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ListBoxTreatment = New System.Windows.Forms.ListBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.txtDateRecordedPast = New System.Windows.Forms.Label()
        Me.txtDoctorNamePast = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.VitalHistory = New System.Windows.Forms.ListBox()
        Me.txtDiagnosisPast = New System.Windows.Forms.Label()
        Me.txtHeightPast = New System.Windows.Forms.Label()
        Me.txtWeightPast = New System.Windows.Forms.Label()
        Me.txtPulseRatePast = New System.Windows.Forms.Label()
        Me.txtRespirationRatePast = New System.Windows.Forms.Label()
        Me.txtBloodPressurePast = New System.Windows.Forms.Label()
        Me.txtBodyTempPast = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.AutoRefreshTimer = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.lblLaboratoryName = New System.Windows.Forms.Label()
        Me.lblInChargePerson = New System.Windows.Forms.Label()
        Me.ListBoxLabResult = New System.Windows.Forms.ListBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtResultDescription = New Guna.UI2.WinForms.Guna2TextBox()
        Me.picLabResult = New System.Windows.Forms.PictureBox()
        Me.ClinicGeneralTab.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.picLabResult, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ClinicGeneralTab
        '
        Me.ClinicGeneralTab.Controls.Add(Me.TabPage1)
        Me.ClinicGeneralTab.Controls.Add(Me.TabPage2)
        Me.ClinicGeneralTab.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ClinicGeneralTab.ItemSize = New System.Drawing.Size(180, 40)
        Me.ClinicGeneralTab.Location = New System.Drawing.Point(0, 0)
        Me.ClinicGeneralTab.Name = "ClinicGeneralTab"
        Me.ClinicGeneralTab.SelectedIndex = 0
        Me.ClinicGeneralTab.Size = New System.Drawing.Size(1484, 761)
        Me.ClinicGeneralTab.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty
        Me.ClinicGeneralTab.TabButtonHoverState.FillColor = System.Drawing.Color.White
        Me.ClinicGeneralTab.TabButtonHoverState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.ClinicGeneralTab.TabButtonHoverState.ForeColor = System.Drawing.Color.Black
        Me.ClinicGeneralTab.TabButtonHoverState.InnerColor = System.Drawing.Color.Yellow
        Me.ClinicGeneralTab.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty
        Me.ClinicGeneralTab.TabButtonIdleState.FillColor = System.Drawing.Color.White
        Me.ClinicGeneralTab.TabButtonIdleState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.ClinicGeneralTab.TabButtonIdleState.ForeColor = System.Drawing.Color.Black
        Me.ClinicGeneralTab.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClinicGeneralTab.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty
        Me.ClinicGeneralTab.TabButtonSelectedState.FillColor = System.Drawing.Color.White
        Me.ClinicGeneralTab.TabButtonSelectedState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.ClinicGeneralTab.TabButtonSelectedState.ForeColor = System.Drawing.Color.Black
        Me.ClinicGeneralTab.TabButtonSelectedState.InnerColor = System.Drawing.Color.Red
        Me.ClinicGeneralTab.TabButtonSize = New System.Drawing.Size(180, 40)
        Me.ClinicGeneralTab.TabIndex = 3
        Me.ClinicGeneralTab.TabMenuBackColor = System.Drawing.Color.White
        Me.ClinicGeneralTab.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.Controls.Add(Me.Panel2)
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 44)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1476, 713)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "DOCTOR ON CALL"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.AutoScroll = True
        Me.Panel2.Controls.Add(Me.GroupBox3)
        Me.Panel2.Controls.Add(Me.GroupBox2)
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1137, 707)
        Me.Panel2.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.White
        Me.GroupBox3.Controls.Add(Me.CallPatientVTN)
        Me.GroupBox3.Controls.Add(Me.txthealthStatus)
        Me.GroupBox3.Controls.Add(Me.txtSTIMedication)
        Me.GroupBox3.Controls.Add(Me.txtSTIStatus)
        Me.GroupBox3.Controls.Add(Me.txtHIVMedication)
        Me.GroupBox3.Controls.Add(Me.txtHIVStatus)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.SaveDoctorDiagnosis)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox3.Location = New System.Drawing.Point(0, 600)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1120, 500)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "DOCTORS DIAGNOSIS"
        '
        'CallPatientVTN
        '
        Me.CallPatientVTN.Location = New System.Drawing.Point(930, 364)
        Me.CallPatientVTN.Name = "CallPatientVTN"
        Me.CallPatientVTN.Size = New System.Drawing.Size(150, 50)
        Me.CallPatientVTN.TabIndex = 15
        Me.CallPatientVTN.Text = "CALL PATIENT"
        Me.CallPatientVTN.UseVisualStyleBackColor = True
        '
        'txthealthStatus
        '
        Me.txthealthStatus.BorderColor = System.Drawing.Color.Black
        Me.txthealthStatus.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txthealthStatus.DefaultText = ""
        Me.txthealthStatus.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txthealthStatus.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txthealthStatus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txthealthStatus.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txthealthStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txthealthStatus.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txthealthStatus.ForeColor = System.Drawing.Color.Black
        Me.txthealthStatus.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txthealthStatus.Location = New System.Drawing.Point(795, 81)
        Me.txthealthStatus.Multiline = True
        Me.txthealthStatus.Name = "txthealthStatus"
        Me.txthealthStatus.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txthealthStatus.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txthealthStatus.PlaceholderText = ""
        Me.txthealthStatus.SelectedText = ""
        Me.txthealthStatus.Size = New System.Drawing.Size(300, 100)
        Me.txthealthStatus.TabIndex = 14
        '
        'txtSTIMedication
        '
        Me.txtSTIMedication.FormattingEnabled = True
        Me.txtSTIMedication.Items.AddRange(New Object() {"Azithromycin", "Doxycycline", "Ceftriaxone ", "Acyclovir", "Valacyclovir", "Famciclovir", "Tenofovir", "Entecavir"})
        Me.txtSTIMedication.Location = New System.Drawing.Point(422, 231)
        Me.txtSTIMedication.Name = "txtSTIMedication"
        Me.txtSTIMedication.Size = New System.Drawing.Size(200, 130)
        Me.txtSTIMedication.TabIndex = 13
        '
        'txtSTIStatus
        '
        Me.txtSTIStatus.FormattingEnabled = True
        Me.txtSTIStatus.Items.AddRange(New Object() {"NON-REACTIVE", "REACTIVE"})
        Me.txtSTIStatus.Location = New System.Drawing.Point(422, 81)
        Me.txtSTIStatus.Name = "txtSTIStatus"
        Me.txtSTIStatus.Size = New System.Drawing.Size(200, 88)
        Me.txtSTIStatus.TabIndex = 13
        '
        'txtHIVMedication
        '
        Me.txtHIVMedication.FormattingEnabled = True
        Me.txtHIVMedication.Items.AddRange(New Object() {"Antiretroviral Therapy (ART)", "Pre-exposure Prophylaxis (PrEP)", "Post-exposure Prophylaxis (PEP)"})
        Me.txtHIVMedication.Location = New System.Drawing.Point(54, 231)
        Me.txtHIVMedication.Name = "txtHIVMedication"
        Me.txtHIVMedication.Size = New System.Drawing.Size(300, 109)
        Me.txtHIVMedication.TabIndex = 11
        '
        'txtHIVStatus
        '
        Me.txtHIVStatus.FormattingEnabled = True
        Me.txtHIVStatus.Items.AddRange(New Object() {"NON-REACTIVE", "REACTIVE"})
        Me.txtHIVStatus.Location = New System.Drawing.Point(54, 81)
        Me.txtHIVStatus.Name = "txtHIVStatus"
        Me.txtHIVStatus.Size = New System.Drawing.Size(200, 88)
        Me.txtHIVStatus.TabIndex = 11
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(419, 210)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(149, 18)
        Me.Label16.TabIndex = 8
        Me.Label16.Text = "STI MEDICATION"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(419, 60)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 18)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "STI TEST"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(790, 60)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(148, 18)
        Me.Label20.TabIndex = 3
        Me.Label20.Text = "PATIENT STATUS"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(53, 210)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(154, 18)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "HIV MEDICATION"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(51, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 18)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "HIV/AIDS TEST"
        '
        'SaveDoctorDiagnosis
        '
        Me.SaveDoctorDiagnosis.Enabled = False
        Me.SaveDoctorDiagnosis.Location = New System.Drawing.Point(930, 420)
        Me.SaveDoctorDiagnosis.Name = "SaveDoctorDiagnosis"
        Me.SaveDoctorDiagnosis.Size = New System.Drawing.Size(150, 50)
        Me.SaveDoctorDiagnosis.TabIndex = 2
        Me.SaveDoctorDiagnosis.Text = "SAVE PATIENT RECORD"
        Me.SaveDoctorDiagnosis.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.lblDiagnosis)
        Me.GroupBox2.Controls.Add(Me.lblHeight)
        Me.GroupBox2.Controls.Add(Me.lblWeight)
        Me.GroupBox2.Controls.Add(Me.lblPulseRate)
        Me.GroupBox2.Controls.Add(Me.lblRespirationRate)
        Me.GroupBox2.Controls.Add(Me.lblBloodPressure)
        Me.GroupBox2.Controls.Add(Me.lblBodyTemp)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox2.Location = New System.Drawing.Point(0, 300)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1120, 300)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "PATIENT VITALS"
        '
        'lblDiagnosis
        '
        Me.lblDiagnosis.AutoSize = True
        Me.lblDiagnosis.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiagnosis.Location = New System.Drawing.Point(790, 120)
        Me.lblDiagnosis.MaximumSize = New System.Drawing.Size(300, 155)
        Me.lblDiagnosis.Name = "lblDiagnosis"
        Me.lblDiagnosis.Size = New System.Drawing.Size(18, 18)
        Me.lblDiagnosis.TabIndex = 506
        Me.lblDiagnosis.Text = "="
        '
        'lblHeight
        '
        Me.lblHeight.AutoSize = True
        Me.lblHeight.Location = New System.Drawing.Point(600, 218)
        Me.lblHeight.MaximumSize = New System.Drawing.Size(220, 0)
        Me.lblHeight.Name = "lblHeight"
        Me.lblHeight.Size = New System.Drawing.Size(18, 18)
        Me.lblHeight.TabIndex = 506
        Me.lblHeight.Text = "="
        '
        'lblWeight
        '
        Me.lblWeight.AutoSize = True
        Me.lblWeight.Location = New System.Drawing.Point(246, 218)
        Me.lblWeight.MaximumSize = New System.Drawing.Size(220, 0)
        Me.lblWeight.Name = "lblWeight"
        Me.lblWeight.Size = New System.Drawing.Size(18, 18)
        Me.lblWeight.TabIndex = 506
        Me.lblWeight.Text = "="
        '
        'lblPulseRate
        '
        Me.lblPulseRate.AutoSize = True
        Me.lblPulseRate.Location = New System.Drawing.Point(600, 150)
        Me.lblPulseRate.MaximumSize = New System.Drawing.Size(220, 0)
        Me.lblPulseRate.Name = "lblPulseRate"
        Me.lblPulseRate.Size = New System.Drawing.Size(18, 18)
        Me.lblPulseRate.TabIndex = 506
        Me.lblPulseRate.Text = "="
        '
        'lblRespirationRate
        '
        Me.lblRespirationRate.AutoSize = True
        Me.lblRespirationRate.Location = New System.Drawing.Point(246, 150)
        Me.lblRespirationRate.MaximumSize = New System.Drawing.Size(220, 0)
        Me.lblRespirationRate.Name = "lblRespirationRate"
        Me.lblRespirationRate.Size = New System.Drawing.Size(18, 18)
        Me.lblRespirationRate.TabIndex = 506
        Me.lblRespirationRate.Text = "="
        '
        'lblBloodPressure
        '
        Me.lblBloodPressure.AutoSize = True
        Me.lblBloodPressure.Location = New System.Drawing.Point(600, 85)
        Me.lblBloodPressure.MaximumSize = New System.Drawing.Size(220, 0)
        Me.lblBloodPressure.Name = "lblBloodPressure"
        Me.lblBloodPressure.Size = New System.Drawing.Size(18, 18)
        Me.lblBloodPressure.TabIndex = 506
        Me.lblBloodPressure.Text = "="
        '
        'lblBodyTemp
        '
        Me.lblBodyTemp.AutoSize = True
        Me.lblBodyTemp.Location = New System.Drawing.Point(246, 85)
        Me.lblBodyTemp.MaximumSize = New System.Drawing.Size(220, 0)
        Me.lblBodyTemp.Name = "lblBodyTemp"
        Me.lblBodyTemp.Size = New System.Drawing.Size(18, 18)
        Me.lblBodyTemp.TabIndex = 506
        Me.lblBodyTemp.Text = "="
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(419, 218)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 18)
        Me.Label5.TabIndex = 504
        Me.Label5.Text = "HEIGHT"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(419, 85)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(175, 18)
        Me.Label6.TabIndex = 505
        Me.Label6.Text = "BLOOOD PRESSURE"
        '
        'Label17
        '
        Me.Label17.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(419, 150)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(111, 18)
        Me.Label17.TabIndex = 503
        Me.Label17.Text = "PULSE RATE"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(790, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(190, 18)
        Me.Label2.TabIndex = 502
        Me.Label2.Text = "PATIENT SYSMTOPMS"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(51, 218)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 18)
        Me.Label7.TabIndex = 499
        Me.Label7.Text = "WEIGHT"
        '
        'Label15
        '
        Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(51, 150)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(171, 18)
        Me.Label15.TabIndex = 500
        Me.Label15.Text = "RESPIRATION RATE"
        '
        'Label18
        '
        Me.Label18.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(51, 85)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(188, 18)
        Me.Label18.TabIndex = 501
        Me.Label18.Text = "BODY TEMPERATURE"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.lblContactNumber)
        Me.GroupBox1.Controls.Add(Me.lblPhilhealthID)
        Me.GroupBox1.Controls.Add(Me.lblDOB)
        Me.GroupBox1.Controls.Add(Me.lblMiddlename)
        Me.GroupBox1.Controls.Add(Me.lblAge)
        Me.GroupBox1.Controls.Add(Me.lblLastname)
        Me.GroupBox1.Controls.Add(Me.lblMaritalStatus)
        Me.GroupBox1.Controls.Add(Me.lblGender)
        Me.GroupBox1.Controls.Add(Me.lblFirstname)
        Me.GroupBox1.Controls.Add(Me.lblPatientID)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.Label26)
        Me.GroupBox1.Controls.Add(Me.Label27)
        Me.GroupBox1.Controls.Add(Me.Label28)
        Me.GroupBox1.Controls.Add(Me.Label29)
        Me.GroupBox1.Controls.Add(Me.Label30)
        Me.GroupBox1.Controls.Add(Me.Label31)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1120, 300)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "PATIENT INFORMATION"
        '
        'lblContactNumber
        '
        Me.lblContactNumber.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblContactNumber.AutoSize = True
        Me.lblContactNumber.BackColor = System.Drawing.Color.White
        Me.lblContactNumber.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContactNumber.Location = New System.Drawing.Point(581, 230)
        Me.lblContactNumber.MaximumSize = New System.Drawing.Size(200, 200)
        Me.lblContactNumber.Name = "lblContactNumber"
        Me.lblContactNumber.Size = New System.Drawing.Size(18, 18)
        Me.lblContactNumber.TabIndex = 856
        Me.lblContactNumber.Text = "="
        '
        'lblPhilhealthID
        '
        Me.lblPhilhealthID.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblPhilhealthID.AutoSize = True
        Me.lblPhilhealthID.BackColor = System.Drawing.Color.White
        Me.lblPhilhealthID.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhilhealthID.Location = New System.Drawing.Point(938, 231)
        Me.lblPhilhealthID.MaximumSize = New System.Drawing.Size(200, 200)
        Me.lblPhilhealthID.Name = "lblPhilhealthID"
        Me.lblPhilhealthID.Size = New System.Drawing.Size(18, 18)
        Me.lblPhilhealthID.TabIndex = 855
        Me.lblPhilhealthID.Text = "="
        '
        'lblDOB
        '
        Me.lblDOB.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblDOB.AutoSize = True
        Me.lblDOB.BackColor = System.Drawing.Color.White
        Me.lblDOB.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDOB.Location = New System.Drawing.Point(581, 187)
        Me.lblDOB.MaximumSize = New System.Drawing.Size(200, 200)
        Me.lblDOB.Name = "lblDOB"
        Me.lblDOB.Size = New System.Drawing.Size(18, 18)
        Me.lblDOB.TabIndex = 854
        Me.lblDOB.Text = "="
        '
        'lblMiddlename
        '
        Me.lblMiddlename.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblMiddlename.AutoSize = True
        Me.lblMiddlename.BackColor = System.Drawing.Color.White
        Me.lblMiddlename.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMiddlename.Location = New System.Drawing.Point(581, 143)
        Me.lblMiddlename.MaximumSize = New System.Drawing.Size(200, 200)
        Me.lblMiddlename.Name = "lblMiddlename"
        Me.lblMiddlename.Size = New System.Drawing.Size(18, 18)
        Me.lblMiddlename.TabIndex = 853
        Me.lblMiddlename.Text = "="
        '
        'lblAge
        '
        Me.lblAge.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblAge.AutoSize = True
        Me.lblAge.BackColor = System.Drawing.Color.White
        Me.lblAge.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAge.Location = New System.Drawing.Point(938, 188)
        Me.lblAge.MaximumSize = New System.Drawing.Size(200, 200)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(18, 18)
        Me.lblAge.TabIndex = 852
        Me.lblAge.Text = "="
        '
        'lblLastname
        '
        Me.lblLastname.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblLastname.AutoSize = True
        Me.lblLastname.BackColor = System.Drawing.Color.White
        Me.lblLastname.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastname.Location = New System.Drawing.Point(938, 143)
        Me.lblLastname.MaximumSize = New System.Drawing.Size(200, 200)
        Me.lblLastname.Name = "lblLastname"
        Me.lblLastname.Size = New System.Drawing.Size(18, 18)
        Me.lblLastname.TabIndex = 857
        Me.lblLastname.Text = "="
        '
        'lblMaritalStatus
        '
        Me.lblMaritalStatus.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblMaritalStatus.AutoSize = True
        Me.lblMaritalStatus.BackColor = System.Drawing.Color.White
        Me.lblMaritalStatus.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaritalStatus.Location = New System.Drawing.Point(210, 231)
        Me.lblMaritalStatus.MaximumSize = New System.Drawing.Size(200, 200)
        Me.lblMaritalStatus.Name = "lblMaritalStatus"
        Me.lblMaritalStatus.Size = New System.Drawing.Size(18, 18)
        Me.lblMaritalStatus.TabIndex = 851
        Me.lblMaritalStatus.Text = "="
        '
        'lblGender
        '
        Me.lblGender.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblGender.AutoSize = True
        Me.lblGender.BackColor = System.Drawing.Color.White
        Me.lblGender.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGender.Location = New System.Drawing.Point(210, 187)
        Me.lblGender.MaximumSize = New System.Drawing.Size(200, 200)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(18, 18)
        Me.lblGender.TabIndex = 850
        Me.lblGender.Text = "="
        '
        'lblFirstname
        '
        Me.lblFirstname.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblFirstname.AutoSize = True
        Me.lblFirstname.BackColor = System.Drawing.Color.White
        Me.lblFirstname.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstname.Location = New System.Drawing.Point(210, 143)
        Me.lblFirstname.MaximumSize = New System.Drawing.Size(200, 200)
        Me.lblFirstname.Name = "lblFirstname"
        Me.lblFirstname.Size = New System.Drawing.Size(18, 18)
        Me.lblFirstname.TabIndex = 849
        Me.lblFirstname.Text = "="
        '
        'lblPatientID
        '
        Me.lblPatientID.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblPatientID.AutoSize = True
        Me.lblPatientID.BackColor = System.Drawing.Color.White
        Me.lblPatientID.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPatientID.Location = New System.Drawing.Point(179, 53)
        Me.lblPatientID.Name = "lblPatientID"
        Me.lblPatientID.Size = New System.Drawing.Size(114, 18)
        Me.lblPatientID.TabIndex = 848
        Me.lblPatientID.Text = "RHU-PATIENT"
        '
        'Label19
        '
        Me.Label19.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(51, 187)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(80, 18)
        Me.Label19.TabIndex = 847
        Me.Label19.Text = "GENDER"
        '
        'Label21
        '
        Me.Label21.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.White
        Me.Label21.Location = New System.Drawing.Point(51, 231)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(153, 18)
        Me.Label21.TabIndex = 845
        Me.Label21.Text = "MARITAL STATUS"
        '
        'Label22
        '
        Me.Label22.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.White
        Me.Label22.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(790, 231)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(142, 18)
        Me.Label22.TabIndex = 846
        Me.Label22.Text = "PHILHEALTH ID"
        '
        'Label23
        '
        Me.Label23.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.White
        Me.Label23.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(419, 230)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(156, 18)
        Me.Label23.TabIndex = 844
        Me.Label23.Text = "MOBILE NUMBER"
        '
        'Label26
        '
        Me.Label26.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.Color.White
        Me.Label26.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(790, 188)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(42, 18)
        Me.Label26.TabIndex = 842
        Me.Label26.Text = "AGE"
        '
        'Label27
        '
        Me.Label27.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.Color.White
        Me.Label27.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(419, 187)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(138, 18)
        Me.Label27.TabIndex = 843
        Me.Label27.Text = "DATE OF BIRTH"
        '
        'Label28
        '
        Me.Label28.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label28.AutoSize = True
        Me.Label28.BackColor = System.Drawing.Color.White
        Me.Label28.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(790, 143)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(105, 18)
        Me.Label28.TabIndex = 839
        Me.Label28.Text = "LAST NAME"
        '
        'Label29
        '
        Me.Label29.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label29.AutoSize = True
        Me.Label29.BackColor = System.Drawing.Color.White
        Me.Label29.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(419, 143)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(133, 18)
        Me.Label29.TabIndex = 841
        Me.Label29.Text = "MIDDLE NAME"
        '
        'Label30
        '
        Me.Label30.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label30.AutoSize = True
        Me.Label30.BackColor = System.Drawing.Color.White
        Me.Label30.Location = New System.Drawing.Point(51, 143)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(111, 18)
        Me.Label30.TabIndex = 840
        Me.Label30.Text = "FIRST NAME"
        '
        'Label31
        '
        Me.Label31.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label31.AutoSize = True
        Me.Label31.BackColor = System.Drawing.Color.White
        Me.Label31.Font = New System.Drawing.Font("Lucida Sans", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(50, 50)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(123, 22)
        Me.Label31.TabIndex = 838
        Me.Label31.Text = "PATIENT-ID"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PatientQueueList)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(1140, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(333, 707)
        Me.Panel1.TabIndex = 0
        '
        'PatientQueueList
        '
        Me.PatientQueueList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PatientQueueList.FormattingEnabled = True
        Me.PatientQueueList.HorizontalScrollbar = True
        Me.PatientQueueList.ItemHeight = 18
        Me.PatientQueueList.Location = New System.Drawing.Point(0, 0)
        Me.PatientQueueList.Name = "PatientQueueList"
        Me.PatientQueueList.Size = New System.Drawing.Size(333, 707)
        Me.PatientQueueList.TabIndex = 1
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.Controls.Add(Me.GroupBox6)
        Me.TabPage2.Controls.Add(Me.GroupBox5)
        Me.TabPage2.Controls.Add(Me.GroupBox4)
        Me.TabPage2.Location = New System.Drawing.Point(4, 44)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3, 3, 5, 5)
        Me.TabPage2.Size = New System.Drawing.Size(1476, 713)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "PATIENT HISTORY"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.White
        Me.GroupBox5.Controls.Add(Me.PasttxtSTIMedication)
        Me.GroupBox5.Controls.Add(Me.PasttxthealthStatus)
        Me.GroupBox5.Controls.Add(Me.PasttxtSTIStatus)
        Me.GroupBox5.Controls.Add(Me.PasttxtHIVMedication)
        Me.GroupBox5.Controls.Add(Me.PasttxtHIVStatus)
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Controls.Add(Me.Label10)
        Me.GroupBox5.Controls.Add(Me.Label11)
        Me.GroupBox5.Controls.Add(Me.Label12)
        Me.GroupBox5.Controls.Add(Me.ListBoxTreatment)
        Me.GroupBox5.Controls.Add(Me.Label24)
        Me.GroupBox5.Controls.Add(Me.Label45)
        Me.GroupBox5.Controls.Add(Me.txtDateRecordedPast)
        Me.GroupBox5.Controls.Add(Me.txtDoctorNamePast)
        Me.GroupBox5.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox5.Location = New System.Drawing.Point(3, 303)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(1451, 500)
        Me.GroupBox5.TabIndex = 7
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "DOCTORS DIAGNOSIS"
        '
        'PasttxtSTIMedication
        '
        Me.PasttxtSTIMedication.AutoSize = True
        Me.PasttxtSTIMedication.Location = New System.Drawing.Point(418, 232)
        Me.PasttxtSTIMedication.MaximumSize = New System.Drawing.Size(220, 100)
        Me.PasttxtSTIMedication.Name = "PasttxtSTIMedication"
        Me.PasttxtSTIMedication.Size = New System.Drawing.Size(18, 18)
        Me.PasttxtSTIMedication.TabIndex = 527
        Me.PasttxtSTIMedication.Text = "="
        '
        'PasttxthealthStatus
        '
        Me.PasttxthealthStatus.AutoSize = True
        Me.PasttxthealthStatus.Location = New System.Drawing.Point(789, 82)
        Me.PasttxthealthStatus.MaximumSize = New System.Drawing.Size(220, 100)
        Me.PasttxthealthStatus.Name = "PasttxthealthStatus"
        Me.PasttxthealthStatus.Size = New System.Drawing.Size(18, 18)
        Me.PasttxthealthStatus.TabIndex = 528
        Me.PasttxthealthStatus.Text = "="
        '
        'PasttxtSTIStatus
        '
        Me.PasttxtSTIStatus.AutoSize = True
        Me.PasttxtSTIStatus.Location = New System.Drawing.Point(418, 82)
        Me.PasttxtSTIStatus.MaximumSize = New System.Drawing.Size(220, 100)
        Me.PasttxtSTIStatus.Name = "PasttxtSTIStatus"
        Me.PasttxtSTIStatus.Size = New System.Drawing.Size(18, 18)
        Me.PasttxtSTIStatus.TabIndex = 529
        Me.PasttxtSTIStatus.Text = "="
        '
        'PasttxtHIVMedication
        '
        Me.PasttxtHIVMedication.AutoSize = True
        Me.PasttxtHIVMedication.Location = New System.Drawing.Point(52, 232)
        Me.PasttxtHIVMedication.MaximumSize = New System.Drawing.Size(220, 100)
        Me.PasttxtHIVMedication.Name = "PasttxtHIVMedication"
        Me.PasttxtHIVMedication.Size = New System.Drawing.Size(18, 18)
        Me.PasttxtHIVMedication.TabIndex = 530
        Me.PasttxtHIVMedication.Text = "="
        '
        'PasttxtHIVStatus
        '
        Me.PasttxtHIVStatus.AutoSize = True
        Me.PasttxtHIVStatus.Location = New System.Drawing.Point(52, 82)
        Me.PasttxtHIVStatus.MaximumSize = New System.Drawing.Size(220, 100)
        Me.PasttxtHIVStatus.Name = "PasttxtHIVStatus"
        Me.PasttxtHIVStatus.Size = New System.Drawing.Size(18, 18)
        Me.PasttxtHIVStatus.TabIndex = 531
        Me.PasttxtHIVStatus.Text = "="
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(418, 214)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(149, 18)
        Me.Label4.TabIndex = 525
        Me.Label4.Text = "STI MEDICATION"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(418, 64)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 18)
        Me.Label9.TabIndex = 526
        Me.Label9.Text = "STI TEST"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(789, 64)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(148, 18)
        Me.Label10.TabIndex = 522
        Me.Label10.Text = "PATIENT STATUS"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(52, 214)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(154, 18)
        Me.Label11.TabIndex = 523
        Me.Label11.Text = "HIV MEDICATION"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(50, 64)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(133, 18)
        Me.Label12.TabIndex = 524
        Me.Label12.Text = "HIV/AIDS TEST"
        '
        'ListBoxTreatment
        '
        Me.ListBoxTreatment.Dock = System.Windows.Forms.DockStyle.Right
        Me.ListBoxTreatment.FormattingEnabled = True
        Me.ListBoxTreatment.HorizontalScrollbar = True
        Me.ListBoxTreatment.ItemHeight = 18
        Me.ListBoxTreatment.Location = New System.Drawing.Point(1148, 22)
        Me.ListBoxTreatment.Name = "ListBoxTreatment"
        Me.ListBoxTreatment.Size = New System.Drawing.Size(300, 475)
        Me.ListBoxTreatment.TabIndex = 515
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(789, 460)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(167, 18)
        Me.Label24.TabIndex = 513
        Me.Label24.Text = "DATE OF CHECKUP"
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Location = New System.Drawing.Point(50, 460)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(175, 18)
        Me.Label45.TabIndex = 512
        Me.Label45.Text = "DOCTOR INCHARGE"
        '
        'txtDateRecordedPast
        '
        Me.txtDateRecordedPast.AutoSize = True
        Me.txtDateRecordedPast.Location = New System.Drawing.Point(962, 460)
        Me.txtDateRecordedPast.MaximumSize = New System.Drawing.Size(300, 200)
        Me.txtDateRecordedPast.Name = "txtDateRecordedPast"
        Me.txtDateRecordedPast.Size = New System.Drawing.Size(18, 18)
        Me.txtDateRecordedPast.TabIndex = 509
        Me.txtDateRecordedPast.Text = "="
        '
        'txtDoctorNamePast
        '
        Me.txtDoctorNamePast.AutoSize = True
        Me.txtDoctorNamePast.Location = New System.Drawing.Point(231, 460)
        Me.txtDoctorNamePast.MaximumSize = New System.Drawing.Size(300, 200)
        Me.txtDoctorNamePast.Name = "txtDoctorNamePast"
        Me.txtDoctorNamePast.Size = New System.Drawing.Size(18, 18)
        Me.txtDoctorNamePast.TabIndex = 509
        Me.txtDoctorNamePast.Text = "="
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.White
        Me.GroupBox4.Controls.Add(Me.VitalHistory)
        Me.GroupBox4.Controls.Add(Me.txtDiagnosisPast)
        Me.GroupBox4.Controls.Add(Me.txtHeightPast)
        Me.GroupBox4.Controls.Add(Me.txtWeightPast)
        Me.GroupBox4.Controls.Add(Me.txtPulseRatePast)
        Me.GroupBox4.Controls.Add(Me.txtRespirationRatePast)
        Me.GroupBox4.Controls.Add(Me.txtBloodPressurePast)
        Me.GroupBox4.Controls.Add(Me.txtBodyTempPast)
        Me.GroupBox4.Controls.Add(Me.Label34)
        Me.GroupBox4.Controls.Add(Me.Label35)
        Me.GroupBox4.Controls.Add(Me.Label36)
        Me.GroupBox4.Controls.Add(Me.Label37)
        Me.GroupBox4.Controls.Add(Me.Label38)
        Me.GroupBox4.Controls.Add(Me.Label39)
        Me.GroupBox4.Controls.Add(Me.Label40)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox4.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1451, 300)
        Me.GroupBox4.TabIndex = 5
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "PATIENT VITALS HISTORY"
        '
        'VitalHistory
        '
        Me.VitalHistory.Dock = System.Windows.Forms.DockStyle.Right
        Me.VitalHistory.FormattingEnabled = True
        Me.VitalHistory.HorizontalScrollbar = True
        Me.VitalHistory.ItemHeight = 18
        Me.VitalHistory.Location = New System.Drawing.Point(1148, 22)
        Me.VitalHistory.Name = "VitalHistory"
        Me.VitalHistory.Size = New System.Drawing.Size(300, 275)
        Me.VitalHistory.TabIndex = 507
        '
        'txtDiagnosisPast
        '
        Me.txtDiagnosisPast.AutoSize = True
        Me.txtDiagnosisPast.Location = New System.Drawing.Point(790, 105)
        Me.txtDiagnosisPast.MaximumSize = New System.Drawing.Size(300, 155)
        Me.txtDiagnosisPast.Name = "txtDiagnosisPast"
        Me.txtDiagnosisPast.Size = New System.Drawing.Size(18, 18)
        Me.txtDiagnosisPast.TabIndex = 506
        Me.txtDiagnosisPast.Text = "="
        '
        'txtHeightPast
        '
        Me.txtHeightPast.AutoSize = True
        Me.txtHeightPast.Location = New System.Drawing.Point(600, 218)
        Me.txtHeightPast.MaximumSize = New System.Drawing.Size(220, 0)
        Me.txtHeightPast.Name = "txtHeightPast"
        Me.txtHeightPast.Size = New System.Drawing.Size(18, 18)
        Me.txtHeightPast.TabIndex = 506
        Me.txtHeightPast.Text = "="
        '
        'txtWeightPast
        '
        Me.txtWeightPast.AutoSize = True
        Me.txtWeightPast.Location = New System.Drawing.Point(246, 218)
        Me.txtWeightPast.MaximumSize = New System.Drawing.Size(220, 0)
        Me.txtWeightPast.Name = "txtWeightPast"
        Me.txtWeightPast.Size = New System.Drawing.Size(18, 18)
        Me.txtWeightPast.TabIndex = 506
        Me.txtWeightPast.Text = "="
        '
        'txtPulseRatePast
        '
        Me.txtPulseRatePast.AutoSize = True
        Me.txtPulseRatePast.Location = New System.Drawing.Point(600, 150)
        Me.txtPulseRatePast.MaximumSize = New System.Drawing.Size(220, 0)
        Me.txtPulseRatePast.Name = "txtPulseRatePast"
        Me.txtPulseRatePast.Size = New System.Drawing.Size(18, 18)
        Me.txtPulseRatePast.TabIndex = 506
        Me.txtPulseRatePast.Text = "="
        '
        'txtRespirationRatePast
        '
        Me.txtRespirationRatePast.AutoSize = True
        Me.txtRespirationRatePast.Location = New System.Drawing.Point(246, 150)
        Me.txtRespirationRatePast.MaximumSize = New System.Drawing.Size(220, 0)
        Me.txtRespirationRatePast.Name = "txtRespirationRatePast"
        Me.txtRespirationRatePast.Size = New System.Drawing.Size(18, 18)
        Me.txtRespirationRatePast.TabIndex = 506
        Me.txtRespirationRatePast.Text = "="
        '
        'txtBloodPressurePast
        '
        Me.txtBloodPressurePast.AutoSize = True
        Me.txtBloodPressurePast.Location = New System.Drawing.Point(600, 85)
        Me.txtBloodPressurePast.MaximumSize = New System.Drawing.Size(220, 0)
        Me.txtBloodPressurePast.Name = "txtBloodPressurePast"
        Me.txtBloodPressurePast.Size = New System.Drawing.Size(18, 18)
        Me.txtBloodPressurePast.TabIndex = 506
        Me.txtBloodPressurePast.Text = "="
        '
        'txtBodyTempPast
        '
        Me.txtBodyTempPast.AutoSize = True
        Me.txtBodyTempPast.Location = New System.Drawing.Point(246, 85)
        Me.txtBodyTempPast.MaximumSize = New System.Drawing.Size(220, 0)
        Me.txtBodyTempPast.Name = "txtBodyTempPast"
        Me.txtBodyTempPast.Size = New System.Drawing.Size(18, 18)
        Me.txtBodyTempPast.TabIndex = 506
        Me.txtBodyTempPast.Text = "="
        '
        'Label34
        '
        Me.Label34.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(419, 218)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(75, 18)
        Me.Label34.TabIndex = 504
        Me.Label34.Text = "HEIGHT"
        '
        'Label35
        '
        Me.Label35.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(419, 85)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(175, 18)
        Me.Label35.TabIndex = 505
        Me.Label35.Text = "BLOOOD PRESSURE"
        '
        'Label36
        '
        Me.Label36.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(419, 150)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(111, 18)
        Me.Label36.TabIndex = 503
        Me.Label36.Text = "PULSE RATE"
        '
        'Label37
        '
        Me.Label37.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(790, 85)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(190, 18)
        Me.Label37.TabIndex = 502
        Me.Label37.Text = "PATIENT SYSMTOPMS"
        '
        'Label38
        '
        Me.Label38.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(51, 218)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(74, 18)
        Me.Label38.TabIndex = 499
        Me.Label38.Text = "WEIGHT"
        '
        'Label39
        '
        Me.Label39.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(51, 150)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(171, 18)
        Me.Label39.TabIndex = 500
        Me.Label39.Text = "RESPIRATION RATE"
        '
        'Label40
        '
        Me.Label40.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(51, 85)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(188, 18)
        Me.Label40.TabIndex = 501
        Me.Label40.Text = "BODY TEMPERATURE"
        '
        'AutoRefreshTimer
        '
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.White
        Me.GroupBox6.Controls.Add(Me.lblLaboratoryName)
        Me.GroupBox6.Controls.Add(Me.lblInChargePerson)
        Me.GroupBox6.Controls.Add(Me.ListBoxLabResult)
        Me.GroupBox6.Controls.Add(Me.Label13)
        Me.GroupBox6.Controls.Add(Me.Label14)
        Me.GroupBox6.Controls.Add(Me.txtResultDescription)
        Me.GroupBox6.Controls.Add(Me.picLabResult)
        Me.GroupBox6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox6.Location = New System.Drawing.Point(3, 798)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(1451, 411)
        Me.GroupBox6.TabIndex = 11
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "PATIENT LABORATORY RESULT"
        '
        'lblLaboratoryName
        '
        Me.lblLaboratoryName.AutoSize = True
        Me.lblLaboratoryName.Location = New System.Drawing.Point(746, 75)
        Me.lblLaboratoryName.Name = "lblLaboratoryName"
        Me.lblLaboratoryName.Size = New System.Drawing.Size(18, 18)
        Me.lblLaboratoryName.TabIndex = 814
        Me.lblLaboratoryName.Text = "="
        '
        'lblInChargePerson
        '
        Me.lblInChargePerson.AutoSize = True
        Me.lblInChargePerson.Location = New System.Drawing.Point(746, 53)
        Me.lblInChargePerson.Name = "lblInChargePerson"
        Me.lblInChargePerson.Size = New System.Drawing.Size(18, 18)
        Me.lblInChargePerson.TabIndex = 813
        Me.lblInChargePerson.Text = "="
        '
        'ListBoxLabResult
        '
        Me.ListBoxLabResult.Dock = System.Windows.Forms.DockStyle.Right
        Me.ListBoxLabResult.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxLabResult.ForeColor = System.Drawing.Color.Black
        Me.ListBoxLabResult.FormattingEnabled = True
        Me.ListBoxLabResult.HorizontalScrollbar = True
        Me.ListBoxLabResult.ItemHeight = 17
        Me.ListBoxLabResult.Location = New System.Drawing.Point(1163, 22)
        Me.ListBoxLabResult.Name = "ListBoxLabResult"
        Me.ListBoxLabResult.Size = New System.Drawing.Size(285, 386)
        Me.ListBoxLabResult.Sorted = True
        Me.ListBoxLabResult.TabIndex = 812
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(36, 33)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(172, 18)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "LAB RESULT IMAGE"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(404, 33)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(198, 18)
        Me.Label14.TabIndex = 3
        Me.Label14.Text = "LAB RESULT FINDINGS"
        '
        'txtResultDescription
        '
        Me.txtResultDescription.BorderColor = System.Drawing.Color.Black
        Me.txtResultDescription.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtResultDescription.DefaultText = ""
        Me.txtResultDescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtResultDescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtResultDescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtResultDescription.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtResultDescription.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtResultDescription.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtResultDescription.ForeColor = System.Drawing.Color.Black
        Me.txtResultDescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtResultDescription.Location = New System.Drawing.Point(407, 53)
        Me.txtResultDescription.MaxLength = 5555
        Me.txtResultDescription.Multiline = True
        Me.txtResultDescription.Name = "txtResultDescription"
        Me.txtResultDescription.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtResultDescription.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtResultDescription.PlaceholderText = ""
        Me.txtResultDescription.ReadOnly = True
        Me.txtResultDescription.SelectedText = ""
        Me.txtResultDescription.Size = New System.Drawing.Size(300, 300)
        Me.txtResultDescription.TabIndex = 2
        '
        'picLabResult
        '
        Me.picLabResult.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picLabResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLabResult.InitialImage = Nothing
        Me.picLabResult.Location = New System.Drawing.Point(39, 53)
        Me.picLabResult.Name = "picLabResult"
        Me.picLabResult.Size = New System.Drawing.Size(300, 300)
        Me.picLabResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picLabResult.TabIndex = 1
        Me.picLabResult.TabStop = False
        '
        'HAS_Oncall
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1484, 761)
        Me.Controls.Add(Me.ClinicGeneralTab)
        Me.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "HAS_Oncall"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HAS_Oncall"
        Me.ClinicGeneralTab.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.picLabResult, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ClinicGeneralTab As Guna.UI2.WinForms.Guna2TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents SaveDoctorDiagnosis As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblDiagnosis As Label
    Friend WithEvents lblHeight As Label
    Friend WithEvents lblWeight As Label
    Friend WithEvents lblPulseRate As Label
    Friend WithEvents lblRespirationRate As Label
    Friend WithEvents lblBloodPressure As Label
    Friend WithEvents lblBodyTemp As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblContactNumber As Label
    Friend WithEvents lblPhilhealthID As Label
    Friend WithEvents lblDOB As Label
    Friend WithEvents lblMiddlename As Label
    Friend WithEvents lblAge As Label
    Friend WithEvents lblLastname As Label
    Friend WithEvents lblMaritalStatus As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents lblFirstname As Label
    Friend WithEvents lblPatientID As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PatientQueueList As ListBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents VitalHistory As ListBox
    Friend WithEvents txtDiagnosisPast As Label
    Friend WithEvents txtHeightPast As Label
    Friend WithEvents txtWeightPast As Label
    Friend WithEvents txtPulseRatePast As Label
    Friend WithEvents txtRespirationRatePast As Label
    Friend WithEvents txtBloodPressurePast As Label
    Friend WithEvents txtBodyTempPast As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents Label39 As Label
    Friend WithEvents Label40 As Label
    Friend WithEvents AutoRefreshTimer As Timer
    Friend WithEvents txtSTIStatus As CheckedListBox
    Friend WithEvents txtHIVStatus As CheckedListBox
    Friend WithEvents txtSTIMedication As CheckedListBox
    Friend WithEvents txtHIVMedication As CheckedListBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txthealthStatus As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents ListBoxTreatment As ListBox
    Friend WithEvents Label24 As Label
    Friend WithEvents Label45 As Label
    Friend WithEvents txtDateRecordedPast As Label
    Friend WithEvents txtDoctorNamePast As Label
    Friend WithEvents PasttxtSTIMedication As Label
    Friend WithEvents PasttxthealthStatus As Label
    Friend WithEvents PasttxtSTIStatus As Label
    Friend WithEvents PasttxtHIVMedication As Label
    Friend WithEvents PasttxtHIVStatus As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents CallPatientVTN As Button
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents lblLaboratoryName As Label
    Friend WithEvents lblInChargePerson As Label
    Friend WithEvents ListBoxLabResult As ListBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txtResultDescription As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents picLabResult As PictureBox
End Class
