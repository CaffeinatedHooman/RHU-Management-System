<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Laboratory_Panel
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblPersonInCharge = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.EnterLabVTN = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.lblLaboratoryName = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.lblLaboratoryName)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lblPersonInCharge)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(984, 100)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(286, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(413, 42)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "LABORATORY PANEL"
        '
        'lblPersonInCharge
        '
        Me.lblPersonInCharge.AutoSize = True
        Me.lblPersonInCharge.Location = New System.Drawing.Point(129, 75)
        Me.lblPersonInCharge.Name = "lblPersonInCharge"
        Me.lblPersonInCharge.Size = New System.Drawing.Size(18, 17)
        Me.lblPersonInCharge.TabIndex = 5
        Me.lblPersonInCharge.Text = "="
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 661)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(984, 100)
        Me.Panel2.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.EnterLabVTN)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 100)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(984, 561)
        Me.Panel3.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(442, 331)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Laboratory"
        '
        'EnterLabVTN
        '
        Me.EnterLabVTN.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.EnterLabVTN.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.EnterLabVTN.HoverState.ImageSize = New System.Drawing.Size(64, 64)
        Me.EnterLabVTN.Image = Global.RHU_LABORATORY.My.Resources.Resources.laboratory
        Me.EnterLabVTN.ImageOffset = New System.Drawing.Point(0, 0)
        Me.EnterLabVTN.ImageRotate = 0!
        Me.EnterLabVTN.ImageSize = New System.Drawing.Size(100, 100)
        Me.EnterLabVTN.Location = New System.Drawing.Point(430, 208)
        Me.EnterLabVTN.Name = "EnterLabVTN"
        Me.EnterLabVTN.PressedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.EnterLabVTN.Size = New System.Drawing.Size(120, 120)
        Me.EnterLabVTN.TabIndex = 5
        '
        'lblLaboratoryName
        '
        Me.lblLaboratoryName.AutoSize = True
        Me.lblLaboratoryName.Location = New System.Drawing.Point(129, 8)
        Me.lblLaboratoryName.Name = "lblLaboratoryName"
        Me.lblLaboratoryName.Size = New System.Drawing.Size(18, 17)
        Me.lblLaboratoryName.TabIndex = 7
        Me.lblLaboratoryName.Text = "="
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "WELCOME "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "LABORATORY"
        '
        'Laboratory_Panel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(984, 761)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(500, 500)
        Me.Name = "Laboratory_Panel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Laboratory_Panel"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblPersonInCharge As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents EnterLabVTN As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents lblLaboratoryName As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
End Class
