<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImageViewerForm
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
        Me.PictureBoxLargerView = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBoxLargerView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBoxLargerView
        '
        Me.PictureBoxLargerView.BackColor = System.Drawing.Color.White
        Me.PictureBoxLargerView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBoxLargerView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBoxLargerView.Location = New System.Drawing.Point(0, 0)
        Me.PictureBoxLargerView.Name = "PictureBoxLargerView"
        Me.PictureBoxLargerView.Size = New System.Drawing.Size(784, 761)
        Me.PictureBoxLargerView.TabIndex = 0
        Me.PictureBoxLargerView.TabStop = False
        '
        'ImageViewerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(784, 761)
        Me.Controls.Add(Me.PictureBoxLargerView)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "ImageViewerForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ImageViewerForm"
        CType(Me.PictureBoxLargerView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBoxLargerView As PictureBox
End Class
