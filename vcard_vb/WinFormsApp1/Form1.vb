Imports QRCoder
Imports System.Drawing
Imports System.Drawing.Imaging

Public Class Form1
    Private Sub btnGenerateQRCode_Click(sender As Object, e As EventArgs) Handles btnGenerateQRCode.Click
        Try

            Dim vCard = "BEGIN:VCARD" & vbCrLf &
                       "VERSION:3.0" & vbCrLf &
                       "FN:CC Hng" & vbCrLf &
                       "N:Hng; Ching;;;" & vbCrLf &
                       "ORG:Company Name" & vbCrLf &
                       "TITLE:Software Engineer" & vbCrLf &
                       "TEL:+6016-1234567" & vbCrLf &
                       "EMAIL:abc@gmail.com" & vbCrLf &
                       "END:VCARD"

            Dim qrGenerator As New QRCodeGenerator
            Dim qrCodeData = qrGenerator.CreateQrCode(vCard, QRCodeGenerator.ECCLevel.Q)
            Dim qrCode As New QRCode(qrCodeData)
            Dim qrCodeBitmap = qrCode.GetGraphic(10)

            pictureBoxQRCode.Image = qrCodeBitmap

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            ' Create a vCard string
            Dim vCard As String = "BEGIN:VCARD" & vbCrLf &
                                   "VERSION:3.0" & vbCrLf &
                                   "FN:CC Hng" & vbCrLf &
                                   "N:Hng;Ching;;;" & vbCrLf &
                                   "ORG:Company Name" & vbCrLf &
                                   "TITLE:Software Engineer" & vbCrLf &
                                   "TEL:+016-1234567" & vbCrLf &
                                   "EMAIL:abc@gmail.com" & vbCrLf &
                                   "END:VCARD"

            ' Generate the QR code
            Dim qrGenerator As New QRCodeGenerator()
            Dim qrCodeData As QRCodeData = qrGenerator.CreateQrCode(vCard, QRCodeGenerator.ECCLevel.Q)
            Dim qrCode As New QRCode(qrCodeData)
            Dim qrCodeBitmap As Bitmap = qrCode.GetGraphic(10)

            ' Load the icon image
            Dim iconImage As Bitmap = New Bitmap("D:\vb\apple.png") ' Replace with your icon path

            ' Resize the icon to fit in the center of the QR code
            Dim iconSize As Integer = qrCodeBitmap.Width \ 5 ' Adjust size as needed
            Dim resizedIcon As New Bitmap(iconImage, New Size(iconSize, iconSize))

            ' Create a graphics object to draw the QR code and the icon
            Using graphics As Graphics = Graphics.FromImage(qrCodeBitmap)
                ' Calculate position to center the icon
                Dim x As Integer = (qrCodeBitmap.Width - resizedIcon.Width) \ 2
                Dim y As Integer = (qrCodeBitmap.Height - resizedIcon.Height) \ 2

                ' Draw the icon onto the QR code
                graphics.DrawImage(resizedIcon, x, y, resizedIcon.Width, resizedIcon.Height)
            End Using

            ' Display the QR code with icon in the PictureBox
            pictureBoxQRCode.Image = qrCodeBitmap

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub Button1_ContextMenuStripChanged(sender As Object, e As EventArgs) Handles Button1.ContextMenuStripChanged

    End Sub
End Class
