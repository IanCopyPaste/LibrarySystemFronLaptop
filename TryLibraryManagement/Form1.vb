
Imports MySql.Data.MySqlClient
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles LogInButton.Click
        If txtUsernameLog.Text = "" Or txtPasswordLog.Text = "" Then
            MsgBox("PLEASE ENTER CREDENTIALS", vbInformation, "INPUTS")
            clear()
        Else
            Try
                dbConOpen()
                Dim query As String = "SELECT *
                                       FROM users u 
                                       INNER JOIN namess n ON n.nameID = u.nameID
                                       WHERE u.username = @user AND u.password = @pass"
                Dim verify As New MySqlCommand(query, con)
                verify.Parameters.AddWithValue("@user", txtUsernameLog.Text)
                verify.Parameters.AddWithValue("@pass", txtPasswordLog.Text)
                Dim count As MySqlDataReader = verify.ExecuteReader
                If count.HasRows Then
                    While count.Read
                        FetchAnything.name = count.GetString("fname")
                        FetchAnything.accNum = count.GetValue("userID")
                        If count.GetString("role") = "admin" Then
                            MsgBox("LOG IN SUCCESS TO ADMIN", vbInformation, "SUCCESS")
                            count.Close()
                            close_clear()
                            MainDashboard.Show()
                            Exit While
                        ElseIf count.GetString("role") = "user" Then
                            MsgBox("LOG IN SUCCESS TO USER", vbInformation, "SUCCESS")
                            count.Close()
                            close_clear()
                            UserDashboard.Show()
                            Exit While
                        End If
                    End While
                Else
                    MsgBox("INCORRECT USERNAME OR PASSWORD", vbCritical, "ERROR")
                    count.Close()
                End If
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "CONNECTION ERROR")
            Finally
                GC.Collect()
                dbConClose()
                clear()
            End Try
        End If
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles toSignUp.Click
        SignUp.Show()
        Me.Hide()
    End Sub

    Sub close_clear()
        clear()
        Me.Hide()
    End Sub

    Sub clear()
        For Each obj In Panel1.Controls
            If TypeOf obj Is TextBox Then
                obj.clear()
            End If
        Next
    End Sub
End Class