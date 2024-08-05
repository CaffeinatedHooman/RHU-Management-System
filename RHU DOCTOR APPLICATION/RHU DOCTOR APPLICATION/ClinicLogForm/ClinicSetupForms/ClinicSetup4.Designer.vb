<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClinicSetup4
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LbLSelectedAccessCodeClinic4 = New System.Windows.Forms.Label()
        Me.btnSaveAccessCode = New System.Windows.Forms.Button()
        Me.cmbClinics = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(126, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 17)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Clinic Four Setup"
        '
        'LbLSelectedAccessCodeClinic4
        '
        Me.LbLSelectedAccessCodeClinic4.AutoSize = True
        Me.LbLSelectedAccessCodeClinic4.Location = New System.Drawing.Point(133, 344)
        Me.LbLSelectedAccessCodeClinic4.Name = "LbLSelectedAccessCodeClinic4"
        Me.LbLSelectedAccessCodeClinic4.Size = New System.Drawing.Size(117, 17)
        Me.LbLSelectedAccessCodeClinic4.TabIndex = 17
        Me.LbLSelectedAccessCodeClinic4.Text = "ACCESS CODE"
        Me.LbLSelectedAccessCodeClinic4.Visible = False
        '
        'btnSaveAccessCode
        '
        Me.btnSaveAccessCode.Location = New System.Drawing.Point(73, 365)
        Me.btnSaveAccessCode.Name = "btnSaveAccessCode"
        Me.btnSaveAccessCode.Size = New System.Drawing.Size(239, 35)
        Me.btnSaveAccessCode.TabIndex = 16
        Me.btnSaveAccessCode.Text = "SAVE CLINIC ACCESS"
        Me.btnSaveAccessCode.UseVisualStyleBackColor = True
        '
        'cmbClinics
        '
        Me.cmbClinics.BackColor = System.Drawing.Color.Transparent
        Me.cmbClinics.BorderColor = System.Drawing.Color.Black
        Me.cmbClinics.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbClinics.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbClinics.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbClinics.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbClinics.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbClinics.ForeColor = System.Drawing.Color.Black
        Me.cmbClinics.ItemHeight = 30
        Me.cmbClinics.Location = New System.Drawing.Point(73, 92)
        Me.cmbClinics.Name = "cmbClinics"
        Me.cmbClinics.Size = New System.Drawing.Size(239, 36)
        Me.cmbClinics.TabIndex = 15
        '
        'ClinicSetup4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 461)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LbLSelectedAccessCodeClinic4)
        Me.Controls.Add(Me.btnSaveAccessCode)
        Me.Controls.Add(Me.cmbClinics)
        Me.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ClinicSetup4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ClinicSetup4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents LbLSelectedAccessCodeClinic4 As Label
    Friend WithEvents btnSaveAccessCode As Button
    Friend WithEvents cmbClinics As Guna.UI2.WinForms.Guna2ComboBox
End Class
