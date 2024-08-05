Imports WIA

Public Class ImageViewerForm
    Private ReadOnly originalImage As Image
    Private zoomFactor As Double = 1.0

    Public Sub New(image As Image)
        InitializeComponent()
        originalImage = image
        PictureBoxLargerView.Image = originalImage
    End Sub

    Private Sub ImageViewerForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Z Then
            ZoomIn()
        End If
        If e.KeyCode = Keys.X Then
            ZoomOut()
        End If
        If e.Control AndAlso e.KeyCode = Keys.D0 Then
            ResetZoom()
        End If
    End Sub

    Private Sub ZoomIn()
        zoomFactor *= 1.1
        ApplyZoom()
    End Sub

    Private Sub ZoomOut()
        zoomFactor /= 1.1
        ApplyZoom()
    End Sub

    Private Sub ResetZoom()
        zoomFactor = 1.0
        ApplyZoom()
    End Sub

    Private Sub ApplyZoom()
        Dim aspectRatio As Double = CDbl(originalImage.Width) / CDbl(originalImage.Height)
        Dim newWidth As Integer
        Dim newHeight As Integer

        If aspectRatio > CDbl(PictureBoxLargerView.Width) / CDbl(PictureBoxLargerView.Height) Then
            newWidth = PictureBoxLargerView.Width
            newHeight = CInt(newWidth / aspectRatio)
        Else
            newHeight = PictureBoxLargerView.Height
            newWidth = CInt(newHeight * aspectRatio)
        End If

        Dim zoomedBitmap As New Bitmap(originalImage, newWidth, newHeight)

        Dim offsetX As Integer = (PictureBoxLargerView.Width - zoomedBitmap.Width) \ 2
        Dim offsetY As Integer = (PictureBoxLargerView.Height - zoomedBitmap.Height) \ 2

        Dim centeredBitmap As New Bitmap(PictureBoxLargerView.Width, PictureBoxLargerView.Height)
        Using g As Graphics = Graphics.FromImage(centeredBitmap)
            g.Clear(Color.White)
            g.DrawImage(zoomedBitmap, offsetX, offsetY)
        End Using

        PictureBoxLargerView.Image = centeredBitmap
    End Sub

    Private Sub ImageViewerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
