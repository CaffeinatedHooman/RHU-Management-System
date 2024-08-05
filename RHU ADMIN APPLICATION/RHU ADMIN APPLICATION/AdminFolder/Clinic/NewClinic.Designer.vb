<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NewClinic
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
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Guna2TabControl1 = New Guna.UI2.WinForms.Guna2TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ListBoxClinics = New System.Windows.Forms.ListBox()
        Me.txtClinicName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtAccessCode = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAddClinic = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblOldAccessCode = New System.Windows.Forms.Label()
        Me.lblOldClinicName = New System.Windows.Forms.Label()
        Me.txtNewClinicName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtNewAccessCode = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnUpdateClinic = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ClinicListBoxUpdate = New System.Windows.Forms.ListBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblDeleteAccessCode = New System.Windows.Forms.Label()
        Me.lblDeleteClinicName = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnDeleteClinic = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ClinicListDelete = New System.Windows.Forms.ListBox()
        Me.Guna2TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'Guna2TabControl1
        '
        Me.Guna2TabControl1.Controls.Add(Me.TabPage1)
        Me.Guna2TabControl1.Controls.Add(Me.TabPage2)
        Me.Guna2TabControl1.Controls.Add(Me.TabPage3)
        Me.Guna2TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2TabControl1.ItemSize = New System.Drawing.Size(180, 40)
        Me.Guna2TabControl1.Location = New System.Drawing.Point(3, 3)
        Me.Guna2TabControl1.Name = "Guna2TabControl1"
        Me.Guna2TabControl1.SelectedIndex = 0
        Me.Guna2TabControl1.Size = New System.Drawing.Size(778, 455)
        Me.Guna2TabControl1.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty
        Me.Guna2TabControl1.TabButtonHoverState.FillColor = System.Drawing.Color.White
        Me.Guna2TabControl1.TabButtonHoverState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Guna2TabControl1.TabButtonHoverState.ForeColor = System.Drawing.Color.Black
        Me.Guna2TabControl1.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Guna2TabControl1.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty
        Me.Guna2TabControl1.TabButtonIdleState.FillColor = System.Drawing.Color.White
        Me.Guna2TabControl1.TabButtonIdleState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Guna2TabControl1.TabButtonIdleState.ForeColor = System.Drawing.Color.Black
        Me.Guna2TabControl1.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Guna2TabControl1.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty
        Me.Guna2TabControl1.TabButtonSelectedState.FillColor = System.Drawing.Color.White
        Me.Guna2TabControl1.TabButtonSelectedState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Guna2TabControl1.TabButtonSelectedState.ForeColor = System.Drawing.Color.Black
        Me.Guna2TabControl1.TabButtonSelectedState.InnerColor = System.Drawing.Color.Red
        Me.Guna2TabControl1.TabButtonSize = New System.Drawing.Size(180, 40)
        Me.Guna2TabControl1.TabIndex = 0
        Me.Guna2TabControl1.TabMenuBackColor = System.Drawing.Color.White
        Me.Guna2TabControl1.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 44)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(770, 407)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "NEW CLINIC"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ListBoxClinics)
        Me.GroupBox1.Controls.Add(Me.txtClinicName)
        Me.GroupBox1.Controls.Add(Me.txtAccessCode)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnAddClinic)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(764, 401)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "NEW CLINIC"
        '
        'ListBoxClinics
        '
        Me.ListBoxClinics.Dock = System.Windows.Forms.DockStyle.Right
        Me.ListBoxClinics.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxClinics.FormattingEnabled = True
        Me.ListBoxClinics.ItemHeight = 15
        Me.ListBoxClinics.Location = New System.Drawing.Point(461, 22)
        Me.ListBoxClinics.Name = "ListBoxClinics"
        Me.ListBoxClinics.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.ListBoxClinics.Size = New System.Drawing.Size(300, 376)
        Me.ListBoxClinics.TabIndex = 13
        '
        'txtClinicName
        '
        Me.txtClinicName.Animated = True
        Me.txtClinicName.BorderColor = System.Drawing.Color.Black
        Me.txtClinicName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtClinicName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtClinicName.DefaultText = ""
        Me.txtClinicName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtClinicName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtClinicName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtClinicName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtClinicName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtClinicName.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtClinicName.ForeColor = System.Drawing.Color.Black
        Me.txtClinicName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtClinicName.Location = New System.Drawing.Point(178, 80)
        Me.txtClinicName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtClinicName.MaxLength = 50
        Me.txtClinicName.Name = "txtClinicName"
        Me.txtClinicName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtClinicName.PlaceholderText = ""
        Me.txtClinicName.SelectedText = ""
        Me.txtClinicName.Size = New System.Drawing.Size(200, 38)
        Me.txtClinicName.TabIndex = 11
        '
        'txtAccessCode
        '
        Me.txtAccessCode.Animated = True
        Me.txtAccessCode.BorderColor = System.Drawing.Color.Black
        Me.txtAccessCode.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAccessCode.DefaultText = ""
        Me.txtAccessCode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtAccessCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtAccessCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAccessCode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAccessCode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAccessCode.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtAccessCode.ForeColor = System.Drawing.Color.Black
        Me.txtAccessCode.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAccessCode.Location = New System.Drawing.Point(178, 152)
        Me.txtAccessCode.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtAccessCode.Name = "txtAccessCode"
        Me.txtAccessCode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAccessCode.PlaceholderText = ""
        Me.txtAccessCode.SelectedText = ""
        Me.txtAccessCode.Size = New System.Drawing.Size(200, 38)
        Me.txtAccessCode.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(50, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 18)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "CLINIC NAME"
        '
        'btnAddClinic
        '
        Me.btnAddClinic.Location = New System.Drawing.Point(178, 223)
        Me.btnAddClinic.Name = "btnAddClinic"
        Me.btnAddClinic.Size = New System.Drawing.Size(200, 35)
        Me.btnAddClinic.TabIndex = 10
        Me.btnAddClinic.Text = "ADD CLINIC"
        Me.btnAddClinic.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(46, 172)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 18)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "ACCESS CODE"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 44)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(770, 407)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "UPDATE CLINIC"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblOldAccessCode)
        Me.GroupBox2.Controls.Add(Me.lblOldClinicName)
        Me.GroupBox2.Controls.Add(Me.txtNewClinicName)
        Me.GroupBox2.Controls.Add(Me.txtNewAccessCode)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.btnUpdateClinic)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.ClinicListBoxUpdate)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(764, 401)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "UPDATE CLINIC"
        '
        'lblOldAccessCode
        '
        Me.lblOldAccessCode.AutoSize = True
        Me.lblOldAccessCode.Location = New System.Drawing.Point(40, 172)
        Me.lblOldAccessCode.Name = "lblOldAccessCode"
        Me.lblOldAccessCode.Size = New System.Drawing.Size(44, 18)
        Me.lblOldAccessCode.TabIndex = 24
        Me.lblOldAccessCode.Text = "OLD"
        '
        'lblOldClinicName
        '
        Me.lblOldClinicName.AutoSize = True
        Me.lblOldClinicName.Location = New System.Drawing.Point(40, 100)
        Me.lblOldClinicName.Name = "lblOldClinicName"
        Me.lblOldClinicName.Size = New System.Drawing.Size(44, 18)
        Me.lblOldClinicName.TabIndex = 24
        Me.lblOldClinicName.Text = "OLD"
        '
        'txtNewClinicName
        '
        Me.txtNewClinicName.Animated = True
        Me.txtNewClinicName.BorderColor = System.Drawing.Color.Black
        Me.txtNewClinicName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNewClinicName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNewClinicName.DefaultText = ""
        Me.txtNewClinicName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtNewClinicName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtNewClinicName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNewClinicName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNewClinicName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNewClinicName.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtNewClinicName.ForeColor = System.Drawing.Color.Black
        Me.txtNewClinicName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNewClinicName.Location = New System.Drawing.Point(220, 80)
        Me.txtNewClinicName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNewClinicName.Name = "txtNewClinicName"
        Me.txtNewClinicName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNewClinicName.PlaceholderText = ""
        Me.txtNewClinicName.SelectedText = ""
        Me.txtNewClinicName.Size = New System.Drawing.Size(200, 38)
        Me.txtNewClinicName.TabIndex = 22
        '
        'txtNewAccessCode
        '
        Me.txtNewAccessCode.Animated = True
        Me.txtNewAccessCode.BorderColor = System.Drawing.Color.Black
        Me.txtNewAccessCode.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNewAccessCode.DefaultText = ""
        Me.txtNewAccessCode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtNewAccessCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtNewAccessCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNewAccessCode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNewAccessCode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNewAccessCode.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtNewAccessCode.ForeColor = System.Drawing.Color.Black
        Me.txtNewAccessCode.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNewAccessCode.Location = New System.Drawing.Point(220, 152)
        Me.txtNewAccessCode.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNewAccessCode.Name = "txtNewAccessCode"
        Me.txtNewAccessCode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNewAccessCode.PlaceholderText = ""
        Me.txtNewAccessCode.SelectedText = ""
        Me.txtNewAccessCode.Size = New System.Drawing.Size(200, 38)
        Me.txtNewAccessCode.TabIndex = 23
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(40, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(163, 18)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "CLINIC NAME NEW"
        '
        'btnUpdateClinic
        '
        Me.btnUpdateClinic.Location = New System.Drawing.Point(220, 223)
        Me.btnUpdateClinic.Name = "btnUpdateClinic"
        Me.btnUpdateClinic.Size = New System.Drawing.Size(200, 35)
        Me.btnUpdateClinic.TabIndex = 21
        Me.btnUpdateClinic.Text = "UPDATE CLINIC"
        Me.btnUpdateClinic.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(40, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(167, 18)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "NEW ACCESS CODE"
        '
        'ClinicListBoxUpdate
        '
        Me.ClinicListBoxUpdate.Dock = System.Windows.Forms.DockStyle.Right
        Me.ClinicListBoxUpdate.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClinicListBoxUpdate.FormattingEnabled = True
        Me.ClinicListBoxUpdate.ItemHeight = 15
        Me.ClinicListBoxUpdate.Location = New System.Drawing.Point(461, 22)
        Me.ClinicListBoxUpdate.Name = "ClinicListBoxUpdate"
        Me.ClinicListBoxUpdate.ScrollAlwaysVisible = True
        Me.ClinicListBoxUpdate.Size = New System.Drawing.Size(300, 376)
        Me.ClinicListBoxUpdate.TabIndex = 13
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.GroupBox3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 44)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(770, 407)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "DELETE CLINIC"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblDeleteAccessCode)
        Me.GroupBox3.Controls.Add(Me.lblDeleteClinicName)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.btnDeleteClinic)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.ClinicListDelete)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(764, 401)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "DELETE CLINIC"
        '
        'lblDeleteAccessCode
        '
        Me.lblDeleteAccessCode.AutoSize = True
        Me.lblDeleteAccessCode.Location = New System.Drawing.Point(40, 172)
        Me.lblDeleteAccessCode.Name = "lblDeleteAccessCode"
        Me.lblDeleteAccessCode.Size = New System.Drawing.Size(18, 18)
        Me.lblDeleteAccessCode.TabIndex = 24
        Me.lblDeleteAccessCode.Text = "="
        '
        'lblDeleteClinicName
        '
        Me.lblDeleteClinicName.AutoSize = True
        Me.lblDeleteClinicName.Location = New System.Drawing.Point(40, 100)
        Me.lblDeleteClinicName.Name = "lblDeleteClinicName"
        Me.lblDeleteClinicName.Size = New System.Drawing.Size(18, 18)
        Me.lblDeleteClinicName.TabIndex = 24
        Me.lblDeleteClinicName.Text = "="
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(40, 80)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(121, 18)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "CLINIC NAME"
        '
        'btnDeleteClinic
        '
        Me.btnDeleteClinic.Location = New System.Drawing.Point(220, 223)
        Me.btnDeleteClinic.Name = "btnDeleteClinic"
        Me.btnDeleteClinic.Size = New System.Drawing.Size(200, 35)
        Me.btnDeleteClinic.TabIndex = 21
        Me.btnDeleteClinic.Text = "DELETE CLINIC"
        Me.btnDeleteClinic.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(40, 152)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(125, 18)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "ACCESS CODE"
        '
        'ClinicListDelete
        '
        Me.ClinicListDelete.Dock = System.Windows.Forms.DockStyle.Right
        Me.ClinicListDelete.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClinicListDelete.FormattingEnabled = True
        Me.ClinicListDelete.ItemHeight = 15
        Me.ClinicListDelete.Location = New System.Drawing.Point(461, 22)
        Me.ClinicListDelete.Name = "ClinicListDelete"
        Me.ClinicListDelete.ScrollAlwaysVisible = True
        Me.ClinicListDelete.Size = New System.Drawing.Size(300, 376)
        Me.ClinicListDelete.TabIndex = 13
        '
        'NewClinic
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 461)
        Me.Controls.Add(Me.Guna2TabControl1)
        Me.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "NewClinic"
        Me.Padding = New System.Windows.Forms.Padding(3)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SETUP CLINIC"
        Me.Guna2TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents Guna2TabControl1 As Guna.UI2.WinForms.Guna2TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtClinicName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtAccessCode As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAddClinic As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents ListBoxClinics As ListBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ClinicListBoxUpdate As ListBox
    Friend WithEvents txtNewClinicName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtNewAccessCode As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnUpdateClinic As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents lblOldAccessCode As Label
    Friend WithEvents lblOldClinicName As Label
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lblDeleteAccessCode As Label
    Friend WithEvents lblDeleteClinicName As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnDeleteClinic As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents ClinicListDelete As ListBox
End Class
