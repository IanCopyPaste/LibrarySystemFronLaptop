Imports System.Net
Imports System.Net.Mail
Imports System.Security.Cryptography.X509Certificates
Imports MySql.Data.MySqlClient
Module FetchAnything
    Public name As String
    Public accNum As String
    Public nameID As Integer
    Public pathTocreate As String

    'variable para sa borrow booko form
    Public getID3 As Integer

    'app password for the sender of the message
    Private app_pass As String = "iqpv kbbd dniy akom"


    'CreateActualBookForm

    'main process
    Public Function checkIfBookTitleisUnique(HELLO As String)
        Try
            con.Open()
            Dim query As String = "SELECT title FROM books WHERE title = @tite"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@tite", HELLO)
            Dim read As MySqlDataReader = cmd.ExecuteReader
            If read.HasRows Then
                Return True
            Else
                Return False
            End If
        Catch ex As MySqlException
            MsgBox(ex.Message, vbCritical, "OH NO!")
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "GAGU")
        Finally
            GC.Collect()
            con.Close()
        End Try
    End Function


    'main process

    'methods
    Public Sub createPath(path As String)
        Dim path2 As String = ""
        For Each e As String In path
            If e = "\" Then
                e = "\\"
            End If
            path2 += e
        Next
        pathTocreate = path2
    End Sub
    'methods

    'CreateActualBookForm

    'API CALLS FOR SIGN UP
    Public otp As String

    Public Function generateCode()
        Dim rand As New Random
        Dim code As String = rand.Next(100000, 1000000).ToString("D6")
        Return code
    End Function

    Public fname As String
    Public lname As String
    Public mname As String
    Public suffix As String
    Public username As String
    Public email As String
    Public password As String

    Public Sub SendEmail()
        Try
            otp = generateCode()
            Dim mail As New MailMessage()
            mail.From = New MailAddress("bobbycuen@gmail.com", "FROM: LIBRARY MANAGEMENT SYSTEM by Ian")
            mail.To.Add(email)
            mail.Subject = "Your Verification Code: " & otp
            mail.Body = "Your one-time password for verification is " & otp & ". Please use this code to complete your login within five minutes. 
                        Do not share this code with anyone to keep your account secure. 
                        If you did not request this verification, please ignore this message."

            Dim smtp As New SmtpClient("smtp.gmail.com")
            smtp.Port = 587
            smtp.Credentials = New NetworkCredential("bobbycuen@gmail.com", app_pass)
            smtp.EnableSsl = True

            smtp.Send(mail)

            MessageBox.Show("Your Verification Code was sent to your Email", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Public Sub insertInfo()
        Try
            DBcon.dbConOpen()
            Dim queryVer As String = "SELECT * FROM users WHERE username = @user"
            Dim cmd2 As New MySqlCommand(queryVer, con)
            cmd2.Parameters.AddWithValue("@user", username)
            Dim ver As MySqlDataReader = cmd2.ExecuteReader
            If ver.HasRows Then
                MsgBox("USERNAME ALREARY EXIST!", vbInformation, "USERNAME DUPLICATION")
                ver.Close()
            Else
                ver.Close()
                Dim query As String = "INSERT INTO namess (fname,lname,mname,suffix) VALUES (UCASE(@fname),UCASE(@lname),UCASE(@mname),UCASE(@suffix))"
                Dim cmd As New MySqlCommand(query, con)
                cmd.Parameters.AddWithValue("@fname", fname)
                cmd.Parameters.AddWithValue("@lname", lname)
                cmd.Parameters.AddWithValue("@mname", mname)
                cmd.Parameters.AddWithValue("@suffix", suffix)
                cmd.ExecuteNonQuery()
                Dim lastID As Long = cmd.LastInsertedId

                Dim query1 As String = "INSERT INTO users (nameID, username, password,email, role) VALUES (@lastID, @user, @pass, @email, 'user')"
                Dim cmd1 As New MySqlCommand(query1, con)
                cmd1.Parameters.AddWithValue("@lastID", lastID)
                cmd1.Parameters.AddWithValue("@user", username)
                cmd1.Parameters.AddWithValue("@pass", password)
                cmd1.Parameters.AddWithValue("@email", email)
                cmd1.ExecuteNonQuery()

                MsgBox("USER REGISTERED SUCESSFULLY!", vbInformation, "YEHEY!")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "ERROR OCCURED")
        Finally
            GC.Collect()
            DBcon.dbConClose()
        End Try
    End Sub
    'API CALLS FOR SIGN UP

    'API CALLS FOR BORROW HISTORY
    Public Sub NotifyReturnees(emails As String, misij As String)
        Try
            Dim mail As New MailMessage()
            mail.From = New MailAddress("bobbycuen@gmail.com", "FROM: LIBRARY MANAGEMENT SYSTEM by Ian")
            mail.To.Add(emails)
            mail.Subject = "KINDLY RETURN THE BOOK!"
            mail.Body = misij

            Dim smtp As New SmtpClient("smtp.gmail.com")
            smtp.Port = 587
            smtp.Credentials = New NetworkCredential("bobbycuen@gmail.com", app_pass)
            smtp.EnableSsl = True

            smtp.Send(mail)

            MessageBox.Show("Your Verification Code was sent to your Email", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    'API CALLS FOR BORROW HISTORY
End Module
