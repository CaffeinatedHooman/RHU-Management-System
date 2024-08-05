<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GeneralDoctorPanel
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GeneralDoctorPanel))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgvPatientQueue = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.IllnessRedirectVTN = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.ClinicNameLBL = New System.Windows.Forms.Label()
        Me.DoctorIDLBL = New System.Windows.Forms.Label()
        Me.DoctorNameLBL = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.refreshTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Guna2ImageButton1 = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.RECORDARC = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PatientrecordVTN = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.OncallDoctorVTN = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.RequestCountLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvPatientQueue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.dgvPatientQueue)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 414)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1086, 500)
        Me.Panel1.TabIndex = 6
        '
        'dgvPatientQueue
        '
        Me.dgvPatientQueue.AllowUserToAddRows = False
        Me.dgvPatientQueue.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgvPatientQueue.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(237, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPatientQueue.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvPatientQueue.ColumnHeadersHeight = 25
        Me.dgvPatientQueue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPatientQueue.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvPatientQueue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvPatientQueue.GridColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.dgvPatientQueue.Location = New System.Drawing.Point(0, 50)
        Me.dgvPatientQueue.Name = "dgvPatientQueue"
        Me.dgvPatientQueue.ReadOnly = True
        Me.dgvPatientQueue.RowHeadersVisible = False
        Me.dgvPatientQueue.Size = New System.Drawing.Size(1086, 450)
        Me.dgvPatientQueue.TabIndex = 1
        Me.dgvPatientQueue.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightGrid
        Me.dgvPatientQueue.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvPatientQueue.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvPatientQueue.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvPatientQueue.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvPatientQueue.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvPatientQueue.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvPatientQueue.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.dgvPatientQueue.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.dgvPatientQueue.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvPatientQueue.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvPatientQueue.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvPatientQueue.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvPatientQueue.ThemeStyle.HeaderStyle.Height = 25
        Me.dgvPatientQueue.ThemeStyle.ReadOnly = True
        Me.dgvPatientQueue.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvPatientQueue.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvPatientQueue.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvPatientQueue.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvPatientQueue.ThemeStyle.RowsStyle.Height = 22
        Me.dgvPatientQueue.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.dgvPatientQueue.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.IllnessRedirectVTN)
        Me.Panel3.Controls.Add(Me.ClinicNameLBL)
        Me.Panel3.Controls.Add(Me.DoctorIDLBL)
        Me.Panel3.Controls.Add(Me.DoctorNameLBL)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1086, 50)
        Me.Panel3.TabIndex = 0
        '
        'IllnessRedirectVTN
        '
        Me.IllnessRedirectVTN.BackColor = System.Drawing.Color.Transparent
        Me.IllnessRedirectVTN.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.IllnessRedirectVTN.HoverState.ImageSize = New System.Drawing.Size(50, 50)
        Me.IllnessRedirectVTN.Image = Global.RHU_DOCTOR_APPLICATION.My.Resources.Resources.critical
        Me.IllnessRedirectVTN.ImageOffset = New System.Drawing.Point(0, 0)
        Me.IllnessRedirectVTN.ImageRotate = 0!
        Me.IllnessRedirectVTN.ImageSize = New System.Drawing.Size(40, 40)
        Me.IllnessRedirectVTN.IndicateFocus = True
        Me.IllnessRedirectVTN.Location = New System.Drawing.Point(1034, 6)
        Me.IllnessRedirectVTN.Name = "IllnessRedirectVTN"
        Me.IllnessRedirectVTN.PressedState.ImageSize = New System.Drawing.Size(50, 50)
        Me.IllnessRedirectVTN.Size = New System.Drawing.Size(40, 40)
        Me.IllnessRedirectVTN.TabIndex = 40
        Me.IllnessRedirectVTN.UseTransparentBackground = True
        '
        'ClinicNameLBL
        '
        Me.ClinicNameLBL.AutoSize = True
        Me.ClinicNameLBL.Font = New System.Drawing.Font("Lucida Sans", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClinicNameLBL.Location = New System.Drawing.Point(455, 6)
        Me.ClinicNameLBL.Name = "ClinicNameLBL"
        Me.ClinicNameLBL.Size = New System.Drawing.Size(77, 37)
        Me.ClinicNameLBL.TabIndex = 32
        Me.ClinicNameLBL.Text = "==="
        Me.ClinicNameLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ClinicNameLBL.Visible = False
        '
        'DoctorIDLBL
        '
        Me.DoctorIDLBL.AutoSize = True
        Me.DoctorIDLBL.Location = New System.Drawing.Point(12, 21)
        Me.DoctorIDLBL.Name = "DoctorIDLBL"
        Me.DoctorIDLBL.Size = New System.Drawing.Size(12, 18)
        Me.DoctorIDLBL.TabIndex = 30
        Me.DoctorIDLBL.Text = "-"
        '
        'DoctorNameLBL
        '
        Me.DoctorNameLBL.AutoSize = True
        Me.DoctorNameLBL.Location = New System.Drawing.Point(141, 3)
        Me.DoctorNameLBL.Name = "DoctorNameLBL"
        Me.DoctorNameLBL.Size = New System.Drawing.Size(12, 18)
        Me.DoctorNameLBL.TabIndex = 29
        Me.DoctorNameLBL.Text = "-"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 18)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "WELCOME DR"
        '
        'refreshTimer
        '
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = Global.RHU_DOCTOR_APPLICATION.My.Resources.Resources._7283494
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.Guna2ImageButton1)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.RECORDARC)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.PatientrecordVTN)
        Me.Panel2.Controls.Add(Me.OncallDoctorVTN)
        Me.Panel2.Controls.Add(Me.RequestCountLabel)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1086, 414)
        Me.Panel2.TabIndex = 5
        '
        'Guna2ImageButton1
        '
        Me.Guna2ImageButton1.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.Guna2ImageButton1.HoverState.ImageSize = New System.Drawing.Size(64, 64)
        Me.Guna2ImageButton1.Image = CType(resources.GetObject("Guna2ImageButton1.Image"), System.Drawing.Image)
        Me.Guna2ImageButton1.ImageOffset = New System.Drawing.Point(0, 0)
        Me.Guna2ImageButton1.ImageRotate = 0!
        Me.Guna2ImageButton1.Location = New System.Drawing.Point(-23, -46)
        Me.Guna2ImageButton1.Name = "Guna2ImageButton1"
        Me.Guna2ImageButton1.PressedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.Guna2ImageButton1.Size = New System.Drawing.Size(64, 54)
        Me.Guna2ImageButton1.TabIndex = 39
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(392, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(303, 39)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "DOCTOR PANEL"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(617, 250)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(161, 18)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "RECORD ARCHIVE"
        '
        'RECORDARC
        '
        Me.RECORDARC.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.RECORDARC.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.RECORDARC.HoverState.ImageSize = New System.Drawing.Size(64, 64)
        Me.RECORDARC.Image = Global.RHU_DOCTOR_APPLICATION.My.Resources.Resources.folder_1_
        Me.RECORDARC.ImageOffset = New System.Drawing.Point(0, 0)
        Me.RECORDARC.ImageRotate = 0!
        Me.RECORDARC.ImageSize = New System.Drawing.Size(100, 100)
        Me.RECORDARC.Location = New System.Drawing.Point(648, 146)
        Me.RECORDARC.Name = "RECORDARC"
        Me.RECORDARC.PressedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.RECORDARC.Size = New System.Drawing.Size(100, 100)
        Me.RECORDARC.TabIndex = 36
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(467, 250)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 18)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "PATIENTS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(284, 250)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 18)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "ON CALL"
        '
        'PatientrecordVTN
        '
        Me.PatientrecordVTN.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PatientrecordVTN.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.PatientrecordVTN.HoverState.ImageSize = New System.Drawing.Size(64, 64)
        Me.PatientrecordVTN.Image = Global.RHU_DOCTOR_APPLICATION.My.Resources.Resources.crowd
        Me.PatientrecordVTN.ImageOffset = New System.Drawing.Point(0, 0)
        Me.PatientrecordVTN.ImageRotate = 0!
        Me.PatientrecordVTN.ImageSize = New System.Drawing.Size(100, 100)
        Me.PatientrecordVTN.Location = New System.Drawing.Point(461, 146)
        Me.PatientrecordVTN.Name = "PatientrecordVTN"
        Me.PatientrecordVTN.PressedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.PatientrecordVTN.Size = New System.Drawing.Size(100, 100)
        Me.PatientrecordVTN.TabIndex = 32
        '
        'OncallDoctorVTN
        '
        Me.OncallDoctorVTN.BackColor = System.Drawing.Color.WhiteSmoke
        Me.OncallDoctorVTN.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.OncallDoctorVTN.HoverState.ImageSize = New System.Drawing.Size(64, 64)
        Me.OncallDoctorVTN.Image = Global.RHU_DOCTOR_APPLICATION.My.Resources.Resources.cardiogram
        Me.OncallDoctorVTN.ImageOffset = New System.Drawing.Point(0, 0)
        Me.OncallDoctorVTN.ImageRotate = 0!
        Me.OncallDoctorVTN.ImageSize = New System.Drawing.Size(100, 100)
        Me.OncallDoctorVTN.Location = New System.Drawing.Point(274, 146)
        Me.OncallDoctorVTN.Name = "OncallDoctorVTN"
        Me.OncallDoctorVTN.PressedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.OncallDoctorVTN.Size = New System.Drawing.Size(100, 100)
        Me.OncallDoctorVTN.TabIndex = 33
        '
        'RequestCountLabel
        '
        Me.RequestCountLabel.AutoSize = True
        Me.RequestCountLabel.BackColor = System.Drawing.Color.Transparent
        Me.RequestCountLabel.Font = New System.Drawing.Font("Lucida Sans", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RequestCountLabel.Location = New System.Drawing.Point(20, 350)
        Me.RequestCountLabel.Name = "RequestCountLabel"
        Me.RequestCountLabel.Size = New System.Drawing.Size(42, 42)
        Me.RequestCountLabel.TabIndex = 29
        Me.RequestCountLabel.Text = "0"
        '
        'GeneralDoctorPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1103, 761)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.MaximizeBox = False
        Me.Name = "GeneralDoctorPanel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DoctorPanel"
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgvPatientQueue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dgvPatientQueue As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents DoctorIDLBL As Label
    Friend WithEvents DoctorNameLBL As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ClinicNameLBL As Label
    Friend WithEvents refreshTimer As Timer
    Friend WithEvents RequestCountLabel As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents RECORDARC As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PatientrecordVTN As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents OncallDoctorVTN As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents Label1 As Label
    Friend WithEvents IllnessRedirectVTN As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents Guna2ImageButton1 As Guna.UI2.WinForms.Guna2ImageButton
End Class
