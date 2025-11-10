<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignUpOtpCode
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
        Label1 = New Label()
        txtOtpCode = New TextBox()
        Label2 = New Label()
        btnSendCode = New Button()
        btnResendCode = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(32, 43)
        Label1.Name = "Label1"
        Label1.Size = New Size(293, 21)
        Label1.TabIndex = 0
        Label1.Text = "Your Verification Code is Sent To Email!"
        ' 
        ' txtOtpCode
        ' 
        txtOtpCode.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtOtpCode.Location = New Point(32, 106)
        txtOtpCode.Name = "txtOtpCode"
        txtOtpCode.PlaceholderText = "6 Digit Code"
        txtOtpCode.Size = New Size(196, 27)
        txtOtpCode.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(32, 136)
        Label2.Name = "Label2"
        Label2.Size = New Size(73, 17)
        Label2.TabIndex = 2
        Label2.Text = "Enter Code"
        ' 
        ' btnSendCode
        ' 
        btnSendCode.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSendCode.Location = New Point(138, 168)
        btnSendCode.Name = "btnSendCode"
        btnSendCode.Size = New Size(75, 23)
        btnSendCode.TabIndex = 3
        btnSendCode.Text = "Enter"
        btnSendCode.UseVisualStyleBackColor = True
        ' 
        ' btnResendCode
        ' 
        btnResendCode.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnResendCode.Location = New Point(234, 108)
        btnResendCode.Name = "btnResendCode"
        btnResendCode.Size = New Size(99, 23)
        btnResendCode.TabIndex = 4
        btnResendCode.Text = "Resend Code"
        btnResendCode.UseVisualStyleBackColor = True
        ' 
        ' SignUpOtpCode
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(345, 203)
        Controls.Add(btnResendCode)
        Controls.Add(btnSendCode)
        Controls.Add(Label2)
        Controls.Add(txtOtpCode)
        Controls.Add(Label1)
        Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(4)
        Name = "SignUpOtpCode"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Enter OTP Code"
        TopMost = True
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtOtpCode As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSendCode As Button
    Friend WithEvents btnResendCode As Button
End Class
