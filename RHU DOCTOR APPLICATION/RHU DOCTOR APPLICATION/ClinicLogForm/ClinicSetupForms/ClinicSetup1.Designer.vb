<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClinicSetup1
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
        Me.LbLSelectedAccessCodeClinic1 = New System.Windows.Forms.Label()
        Me.btnSaveAccessCode = New System.Windows.Forms.Button()
        Me.cmbClinics = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.ClininNameSet = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LbLSelectedAccessCodeClinic1
        '
        Me.LbLSelectedAccessCodeClinic1.AutoSize = True
        Me.LbLSelectedAccessCodeClinic1.Location = New System.Drawing.Point(133, 328)
        Me.LbLSelectedAccessCodeClinic1.Name = "LbLSelectedAccessCodeClinic1"
        Me.LbLSelectedAccessCodeClinic1.Size = New System.Drawing.Size(117, 17)
        Me.LbLSelectedAccessCodeClinic1.TabIndex = 12
        Me.LbLSelectedAccessCodeClinic1.Text = "ACCESS CODE"
        Me.LbLSelectedAccessCodeClinic1.Visible = False
        '
        'btnSaveAccessCode
        '
        Me.btnSaveAccessCode.Location = New System.Drawing.Point(73, 349)
        Me.btnSaveAccessCode.Name = "btnSaveAccessCode"
        Me.btnSaveAccessCode.Size = New System.Drawing.Size(239, 35)
        Me.btnSaveAccessCode.TabIndex = 11
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
        Me.cmbClinics.Location = New System.Drawing.Point(73, 76)
        Me.cmbClinics.Name = "cmbClinics"
        Me.cmbClinics.Size = New System.Drawing.Size(239, 36)
        Me.cmbClinics.TabIndex = 10
        '
        'ClininNameSet
        '
        Me.ClininNameSet.AutoSize = True
        Me.ClininNameSet.Location = New System.Drawing.Point(126, 45)
        Me.ClininNameSet.Name = "ClininNameSet"
        Me.ClininNameSet.Size = New System.Drawing.Size(133, 17)
        Me.ClininNameSet.TabIndex = 14
        Me.ClininNameSet.Text = "Clinic One Setup"
        '
        'ClinicSetup1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 461)
        Me.Controls.Add(Me.ClininNameSet)
        Me.Controls.Add(Me.LbLSelectedAccessCodeClinic1)
        Me.Controls.Add(Me.btnSaveAccessCode)
        Me.Controls.Add(Me.cmbClinics)
        Me.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ClinicSetup1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ClinicSetup1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LbLSelectedAccessCodeClinic1 As Label
    Friend WithEvents btnSaveAccessCode As Button
    Friend WithEvents cmbClinics As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents ClininNameSet As Label
End Class
