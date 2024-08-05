<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PharmacyPanel
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Guna2ImageButton1 = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.Guna2ImageButton4 = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(89, 202)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 18)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "NEW PHAMACIST"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(247, 202)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(153, 18)
        Me.Label2.TabIndex = 63
        Me.Label2.Text = "PHAMACIST INFO"
        '
        'Guna2ImageButton1
        '
        Me.Guna2ImageButton1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Guna2ImageButton1.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.Guna2ImageButton1.HoverState.ImageSize = New System.Drawing.Size(64, 64)
        Me.Guna2ImageButton1.Image = Global.RHU_ADMIN_APPLICATION.My.Resources.Resources.pharmacy
        Me.Guna2ImageButton1.ImageOffset = New System.Drawing.Point(0, 0)
        Me.Guna2ImageButton1.ImageRotate = 0!
        Me.Guna2ImageButton1.ImageSize = New System.Drawing.Size(100, 100)
        Me.Guna2ImageButton1.IndicateFocus = True
        Me.Guna2ImageButton1.Location = New System.Drawing.Point(273, 99)
        Me.Guna2ImageButton1.Name = "Guna2ImageButton1"
        Me.Guna2ImageButton1.PressedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.Guna2ImageButton1.Size = New System.Drawing.Size(100, 100)
        Me.Guna2ImageButton1.TabIndex = 60
        '
        'Guna2ImageButton4
        '
        Me.Guna2ImageButton4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Guna2ImageButton4.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.Guna2ImageButton4.HoverState.ImageSize = New System.Drawing.Size(64, 64)
        Me.Guna2ImageButton4.Image = Global.RHU_ADMIN_APPLICATION.My.Resources.Resources.dispensary
        Me.Guna2ImageButton4.ImageOffset = New System.Drawing.Point(0, 0)
        Me.Guna2ImageButton4.ImageRotate = 0!
        Me.Guna2ImageButton4.ImageSize = New System.Drawing.Size(100, 100)
        Me.Guna2ImageButton4.IndicateFocus = True
        Me.Guna2ImageButton4.Location = New System.Drawing.Point(111, 99)
        Me.Guna2ImageButton4.Name = "Guna2ImageButton4"
        Me.Guna2ImageButton4.PressedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.Guna2ImageButton4.Size = New System.Drawing.Size(100, 100)
        Me.Guna2ImageButton4.TabIndex = 61
        '
        'PharmacyPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(484, 461)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Guna2ImageButton1)
        Me.Controls.Add(Me.Guna2ImageButton4)
        Me.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "PharmacyPanel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PharmacyPanel"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Guna2ImageButton1 As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents Guna2ImageButton4 As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
