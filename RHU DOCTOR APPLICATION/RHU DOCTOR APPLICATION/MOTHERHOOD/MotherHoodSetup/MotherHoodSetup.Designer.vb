﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MotherHoodSetup
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
        Me.cmbClinics = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.btnSaveAccessCode = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblSelectedAccessCode = New System.Windows.Forms.Label()
        Me.SuspendLayout()
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
        Me.cmbClinics.Location = New System.Drawing.Point(74, 110)
        Me.cmbClinics.Name = "cmbClinics"
        Me.cmbClinics.Size = New System.Drawing.Size(239, 36)
        Me.cmbClinics.TabIndex = 0
        '
        'btnSaveAccessCode
        '
        Me.btnSaveAccessCode.Location = New System.Drawing.Point(74, 383)
        Me.btnSaveAccessCode.Name = "btnSaveAccessCode"
        Me.btnSaveAccessCode.Size = New System.Drawing.Size(239, 35)
        Me.btnSaveAccessCode.TabIndex = 2
        Me.btnSaveAccessCode.Text = "SAVE CLINIC ACCESS"
        Me.btnSaveAccessCode.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(71, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(242, 18)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "SAFE MOTHERHOOD SETUP"
        '
        'lblSelectedAccessCode
        '
        Me.lblSelectedAccessCode.AutoSize = True
        Me.lblSelectedAccessCode.Location = New System.Drawing.Point(134, 362)
        Me.lblSelectedAccessCode.Name = "lblSelectedAccessCode"
        Me.lblSelectedAccessCode.Size = New System.Drawing.Size(125, 18)
        Me.lblSelectedAccessCode.TabIndex = 5
        Me.lblSelectedAccessCode.Text = "ACCESS CODE"
        Me.lblSelectedAccessCode.Visible = False
        '
        'MotherHoodSetup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 461)
        Me.Controls.Add(Me.lblSelectedAccessCode)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSaveAccessCode)
        Me.Controls.Add(Me.cmbClinics)
        Me.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "MotherHoodSetup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MotherHoodSetup"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbClinics As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents btnSaveAccessCode As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblSelectedAccessCode As Label
End Class
