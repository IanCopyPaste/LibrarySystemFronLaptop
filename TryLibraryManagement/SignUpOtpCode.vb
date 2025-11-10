Public Class SignUpOtpCode
    Private Sub btnSendCode_Click(sender As Object, e As EventArgs) Handles btnSendCode.Click
        If txtOtpCode.Text = otp Then
            insertInfo()
            MsgBox("WELCOME TO LIBRARY! YOU MAY NOW LOG IN YOUR ACCOUNT!", vbInformation, "YEHEY!")
            clear()
            SignUp.Close()
            Form1.Show()
            Me.Dispose()
        Else
            MsgBox("OTP NOT MATCHED!")
        End If
    End Sub

    Private Sub btnResendCode_Click(sender As Object, e As EventArgs) Handles btnResendCode.Click
        SendEmail()
    End Sub

    Public Sub clear()
        fname = Nothing
        lname = Nothing
        mname = Nothing
        suffix = Nothing
        username = Nothing
        password = Nothing
        email = Nothing
        otp = Nothing
    End Sub
End Class