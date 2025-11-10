Imports System.Data.Common
Imports System.IO
Imports Microsoft.VisualBasic.ApplicationServices
Imports MySql.Data.MySqlClient
Public Class MainDashboard
    'long process starts
    Private Sub MainDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fromFetchDesign()
        loadTable()
        checkIfNullProfile()
        ProfileBoxMain.SizeMode = PictureBoxSizeMode.StretchImage
        ProfileBoxUpper.SizeMode = PictureBoxSizeMode.Zoom
    End Sub

    Private Sub ewanTable_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ewanTable.CellContentClick
        Try
            Dim userID As Integer = ewanTable.Rows(e.RowIndex).Cells(2).Value
            displayAllIntxtBox(userID)
            If e.RowIndex >= 0 Then
                Dim col = ewanTable.Columns(e.ColumnIndex)
                If col.Name = "Delete" Then
                    If MsgBox("ARE YOU SURE YOU WANT TO DELETE user: " & userID, vbYesNo + vbQuestion, "CONFIRMATION") = MsgBoxResult.Yes Then
                        exeQueryAndDisplay("DELETE FROM users WHERE userID = @?", userID)
                    End If
                ElseIf col.Name = "Edit" Then
                    UpdateCredentialsVisibility(False)
                    txtFname.Focus()
                Else
                    UpdateCredentialsVisibility(True)
                End If
            Else
                MsgBox("PLEASE CLICK A VALID ROW!", vbInformation, "PLEASE FIX YOUR ASS UP")
            End If
        Catch ex As Exception
            MsgBox("Please Select a Valid Row", vbCritical, "Invalid Row")
        End Try
    End Sub
    Private Sub updateBtn_Click(sender As Object, e As EventArgs) Handles updateBtn.Click
        If MsgBox("Are you sure you want to update user: " & txtUserID.Text, vbYesNo + vbQuestion, "Update User") = MsgBoxResult.Yes Then
            UpdateCredentials()
        End If
        UpdateCredentialsVisibility(True)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles profileBtn.Click
        uploadPhotoDialog.Filter = "Image Files (*.png;*.jpg)|*.png;*.jpg"
        If uploadPhotoDialog.ShowDialog() = DialogResult.OK Then
            Dim path As String = uploadPhotoDialog.FileName
            insertProfile(path)
            refresh()
        End If
    End Sub
    Private Sub updateProfileBtn_Click(sender As Object, e As EventArgs) Handles updateProfileBtn.Click
        uploadPhotoDialog.Filter = "Image Files (*.png;*.jpg)|*.png;*.jpg"
        If uploadPhotoDialog.ShowDialog() = DialogResult.OK Then
            Dim path As String = uploadPhotoDialog.FileName
            insertProfile(path)
            refresh()
        End If
    End Sub

    'long process ends


    'short btn starts

    Private Sub TimeForTimer_Tick(sender As Object, e As EventArgs) Handles TimeForTimer.Tick
        TimeLabel.Text = "Time Now: " & "  " & Date.Now
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles searchBox.TextChanged
        searchUser()
    End Sub

    Private Sub addBtn_Click(sender As Object, e As EventArgs) Handles refreshBtn.Click
        refresh()
    End Sub
    Private Sub InsertBooksBtn_Click(sender As Object, e As EventArgs) Handles InsertBooksBtn.Click
        InsertBooks.Show
        Close
    End Sub

    Private Sub SignOutBtn_Click(sender As Object, e As EventArgs) Handles SignOutBtn.Click
        Form1.Show()
        Me.Close()
    End Sub
    'short btn ends


    'methods starts
    Sub fromFetchDesign()
        txtWelcome.Text = "Welcome! " & FetchAnything.name
        userIDlbl.Text = "UserID: " & FetchAnything.accNum
    End Sub

    Sub loadTable()
        Try
            DBcon.dbConOpen()
            Dim query As String = "SELECT u.userID AS USER_ID, CONCAT_WS(' ', n.fname, n.mname, n.lname, n.suffix) AS FULLNAME,
                                   u.username AS USERNAME, u.email AS EMAIL, u.role AS ACCESS FROM users u
                                   INNER JOIN namess n ON n.nameID = u.nameID;"
            Dim da As New MySqlDataAdapter(query, con)
            Dim dt As New DataTable
            da.Fill(dt)
            ewanTable.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "ERROR OCCURED")
        Finally
            GC.Collect()
            DBcon.dbConOpen()
        End Try
    End Sub

    Public Sub exeQueryAndDisplay(RawQuery As String, param As String)
        Try
            DBcon.dbConOpen()
            Dim query As String = RawQuery
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@?", param)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "ERROR")
        Finally
            DBcon.dbConClose()
            loadTable()
        End Try
    End Sub

    Sub insertProfile(path As String)
        Dim path2 As String = ""
        For Each e As String In path
            If e = "/" Then
                e = "//"
            End If
            path2 += e
        Next
        Try
            dbConOpen()
            Dim query As String = "UPDATE users 
                                   SET profile_image = LOAD_FILE(@path) 
                                   WHERE userID = @userID"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@path", path2)
            cmd.Parameters.AddWithValue("@userID", FetchAnything.accNum)
            Dim close As MySqlDataReader = cmd.ExecuteReader()
            close.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "ERROR OCCURED2")
        Finally
            GC.Collect()
            dbConClose()
        End Try
    End Sub

    Function checkIfNullProfile()
        Try
            dbConOpen()
            Dim query As String = "SELECT profile_image
                                   FROM users
                                   WHERE userID = @userID"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@userID", FetchAnything.accNum)
            Dim result As Object = cmd.ExecuteScalar
            If IsDBNull(result) Then
                profileBtnVisibility(True)
                Return True
                Exit Function
            Else
                Dim imageBytes() As Byte = DirectCast(result, Byte())
                Dim ms As New MemoryStream(imageBytes)
                profileBtnVisibility(False)
                ProfileBoxUpper.Image = Image.FromStream(ms)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "ERROR OCCURED1")
        Finally
            GC.Collect()
            dbConClose()
        End Try
        Return False
    End Function

    Sub searchUser()
        Try
            DBcon.dbConOpen()
            Dim query As String = "SELECT u.userID as USER_ID, CONCAT(n.fname,' ',n.mname,' ',n.lname,' ',n.suffix) AS FULLNAME,
            u.username AS USERNAME, u.password AS PASS, u.role AS ACCESS
            FROM users u
            JOIN namess n ON n.nameID = u.nameID
            WHERE u.userID = @search
            OR n.fname LIKE CONCAT('%', @search, '%')
            OR n.lname LIKE CONCAT('%', @search, '%')
            OR u.username LIKE CONCAT('%', @search, '%')
            OR u.role LIKE CONCAT('%', @search, '%')"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@search", searchBox.Text)
            Dim da As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)
            ewanTable.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "ERROR OCCURED")
        Finally
            GC.Collect()
            DBcon.dbConClose()
        End Try
    End Sub

    Sub displayAllIntxtBox(id As Integer)
        Try
            DBcon.dbConOpen()
            Dim query As String = "SELECT *
            FROM users u
            JOIN namess n ON n.nameID = u.nameID
            WHERE u.userID = @userID"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@userID", id)
            Dim read As MySqlDataReader = cmd.ExecuteReader
            While read.Read
                txtFname.Text = If(IsDBNull(read("fname")), "", read("fname").ToString())
                txtLname.Text = If(IsDBNull(read("lname")), "", read("lname").ToString())
                txtMname.Text = If(IsDBNull(read("mname")), "", read("mname").ToString())
                txtSuffix.Text = If(IsDBNull(read("suffix")), "", read("suffix").ToString())
                txtUsername.Text = If(IsDBNull(read("username")), "", read("username").ToString())
                txtEmail.Text = If(IsDBNull(read("email")), "", read("email").ToString())
                comboAccess.Text = If(IsDBNull(read("role")), "", read("role").ToString())
                FetchAnything.nameID = If(IsDBNull(read("nameID")), 0, read.GetInt32("nameID"))
            End While
            txtUserID.Text = id.ToString
            read.Close()
            checkForProfile(id)
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "ERROR OCCURED")
        Finally
            GC.Collect()
            DBcon.dbConClose()
        End Try
    End Sub

    Sub checkForProfile(id As Integer)
        Try
            dbConOpen()
            Dim query As String = "SELECT profile_image FROM users WHERE userID = @userID"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@userID", id)
            Dim result As Object = cmd.ExecuteScalar
            If IsDBNull(result) Then
                ProfileBoxMain.ImageLocation = "C:\Users\CLIENT\Downloads\sdsdsds.jpg"
            Else
                Dim imageBytes() As Byte = DirectCast(result, Byte())
                Dim ms As New MemoryStream(imageBytes)
                ProfileBoxMain.Image = Image.FromStream(ms)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Sub UpdateCredentials()
        Try
            dbConOpen()
            Dim query1 As String = "UPDATE namess
                                   SET fname = @fname, lname = @lname, mname = @mname, suffix = @suffix
                                   WHERE nameID = @nameID;"
            Dim query2 As String = "UPDATE users
                                   SET username = @user, role = @role, email = @email
                                   WHERE userID = @userID;"
            Dim cmd1 As New MySqlCommand(query1, con)
            Dim cmd2 As New MySqlCommand(query2, con)
            cmd1.Parameters.AddWithValue("@nameID", FetchAnything.nameID)
            cmd1.Parameters.AddWithValue("@fname", txtFname.Text)
            cmd1.Parameters.AddWithValue("@lname", txtLname.Text)
            cmd1.Parameters.AddWithValue("@mname", txtMname.Text)
            cmd1.Parameters.AddWithValue("@suffix", txtSuffix.Text)

            cmd2.Parameters.AddWithValue("@userID", txtUserID.Text)
            cmd2.Parameters.AddWithValue("@user", txtUsername.Text)
            cmd2.Parameters.AddWithValue("@email", txtEmail.Text)
            cmd2.Parameters.AddWithValue("@role", comboAccess.Text)
            cmd1.ExecuteNonQuery()
            cmd2.ExecuteNonQuery()
            MsgBox("User Updated Successfully!", vbInformation, "Update Successfull")
            loadTable()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "ERROR OCCURED")
        Finally
            GC.Collect()
            dbConClose()
        End Try
    End Sub

    Sub UpdateCredentialsVisibility(ok As Boolean)
        txtFname.ReadOnly = ok
        txtLname.ReadOnly = ok
        txtMname.ReadOnly = ok
        txtSuffix.ReadOnly = ok
        txtUsername.ReadOnly = ok
        txtEmail.ReadOnly = ok
        updateBtn.Enabled = Not ok
    End Sub
    Sub profileBtnVisibility(open As Boolean)
        profileBtn.Enabled = open
        profileBtn.Visible = open
        updateProfileBtn.Enabled = Not open
        updateProfileBtn.Visible = Not open
    End Sub

    Sub refresh()
        Me.Close()
        Dim main As New MainDashboard
        main.Show()
    End Sub

    Private Sub userPageBtn_Click(sender As Object, e As EventArgs) Handles userPageBtn.Click
        Dim main As New MainDashboard
        Me.Dispose()
        main.Show()
    End Sub

    Private Sub BookHistoryBtn_Click(sender As Object, e As EventArgs) Handles BookHistoryBtn.Click
        BorrowHistory.Show()
        Me.Dispose()
    End Sub
    'methods ends
End Class