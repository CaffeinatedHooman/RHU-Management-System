<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TB_SETUP
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
        Me.lblSelectedAccessCodeTB = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSaveAccessCode = New System.Windows.Forms.Button()
        Me.cmbClinics = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.SuspendLayout()
        '
        'lblSelectedAccessCodeTB
        '
        Me.lblSelectedAccessCodeTB.AutoSize = True
        Me.lblSelectedAccessCodeTB.Location = New System.Drawing.Point(134, 358)
        Me.lblSelectedAccessCodeTB.Name = "lblSelectedAccessCodeTB"
        Me.lblSelectedAccessCodeTB.Size = New System.Drawing.Size(125, 18)
        Me.lblSelectedAccessCodeTB.TabIndex = 9
        Me.lblSelectedAccessCodeTB.Text = "ACCESS CODE"
        Me.lblSelectedAccessCodeTB.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(120, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 18)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "TB DOTS SETUP"
        '
        'btnSaveAccessCode
        '
        Me.btnSaveAccessCode.Location = New System.Drawing.Point(74, 379)
        Me.btnSaveAccessCode.Name = "btnSaveAccessCode"
        Me.btnSaveAccessCode.Size = New System.Drawing.Size(239, 35)
        Me.btnSaveAccessCode.TabIndex = 7
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
        Me.cmbClinics.Location = New System.Drawing.Point(74, 106)
        Me.cmbClinics.Name = "cmbClinics"
        Me.cmbClinics.Size = New System.Drawing.Size(239, 36)
        Me.cmbClinics.TabIndex = 6
        '
        'TB_SETUP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 461)
        Me.Controls.Add(Me.lblSelectedAccessCodeTB)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSaveAccessCode)
        Me.Controls.Add(Me.cmbClinics)
        Me.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.MaximizeBox = False
        Me.Name = "TB_SETUP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TB_SETUP"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSelectedAccessCodeTB As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSaveAccessCode As Button
    Friend WithEvents cmbClinics As Guna.UI2.WinForms.Guna2ComboBox
End Class
