<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        pictureBoxQRCode = New PictureBox()
        btnGenerateQRCode = New Button()
        Button1 = New Button()
        CType(pictureBoxQRCode, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pictureBoxQRCode
        ' 
        pictureBoxQRCode.Location = New Point(12, 12)
        pictureBoxQRCode.Name = "pictureBoxQRCode"
        pictureBoxQRCode.Size = New Size(938, 823)
        pictureBoxQRCode.TabIndex = 0
        pictureBoxQRCode.TabStop = False
        ' 
        ' btnGenerateQRCode
        ' 
        btnGenerateQRCode.Location = New Point(756, 865)
        btnGenerateQRCode.Name = "btnGenerateQRCode"
        btnGenerateQRCode.Size = New Size(94, 29)
        btnGenerateQRCode.TabIndex = 1
        btnGenerateQRCode.Text = "Generate"
        btnGenerateQRCode.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(856, 865)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 2
        Button1.Text = "Image"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(985, 906)
        Controls.Add(Button1)
        Controls.Add(btnGenerateQRCode)
        Controls.Add(pictureBoxQRCode)
        Name = "Form1"
        Text = "Form1"
        CType(pictureBoxQRCode, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pictureBoxQRCode As PictureBox
    Friend WithEvents btnGenerateQRCode As Button
    Friend WithEvents Button1 As Button

End Class
