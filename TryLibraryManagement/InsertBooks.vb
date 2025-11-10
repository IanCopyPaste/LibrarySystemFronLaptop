Imports System.IO
Imports System.Security.Cryptography
Imports Microsoft.VisualBasic.ApplicationServices
Imports MySql.Data.MySqlClient

Public Class InsertBooks
    Private Sub userPageBtn_Click(sender As Object, e As EventArgs) Handles userPageBtn.Click
        MainDashboard.Show()
        Me.Dispose()
    End Sub
    Private Sub InsertBooksBtn_Click(sender As Object, e As EventArgs) Handles InsertBooksBtn.Click
        Dim ins As New InsertBooks
        Dispose()
        ins.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnNewBook.Click
        CreateActualBook.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TimeLabel.Text = "Date Now: " & Date.Now.ToString("yyyy-mm-dd")
    End Sub

    'main process
    Public id As Integer
    Private Sub InsertBooks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        displayAllBooks()
    End Sub
    Private Sub btnInsert_Click(sender As Object, e As EventArgs)
        Dim pic As New PictureBox
        pic.SizeMode = PictureBoxSizeMode.StretchImage
        If upPic1.ShowDialog = DialogResult.OK Then
            pic.Image = Image.FromFile(upPic1.FileName)
        End If
    End Sub

    Private Sub BookTable_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles BookTable.CellClick
        Try
            id = CInt(BookTable.Rows(e.RowIndex).Cells(2).Value)
            checkForProfile(id)
            displayBooksCredential(id)
            If e.RowIndex >= 0 Then
                Dim col = BookTable.Columns(e.ColumnIndex)
                If col.Name = "Edit" Then
                    enableForUpdate(True)
                    txtTitle.Focus()
                ElseIf col.Name = "delete" Then
                    If MsgBox("ARE YOU SURE YOU WANT TO DELETE bookID: " & id, vbYesNo + vbQuestion, "CONFIRMATION") = MsgBoxResult.Yes Then
                        DeleteRowRecord(id)
                    End If
                Else
                    enableForUpdate(False)
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub UpdateBtn_Click(sender As Object, e As EventArgs) Handles UpdateBtn.Click
        If MsgBox("ARE YOU SURE YOU WANT TO UDPATE THIS?", vbYesNo + vbQuestion, "UPDATE CONFIRMATION") = MsgBoxResult.Yes Then
            Try
                dbConOpen()
                Dim query As String = "UPDATE books SET title = @title, author = @auth, category = @cat, publishDate = @pub,stat = @stat, profile = LOAD_FILE(@path) WHERE bookID = @id"
                Dim cmd As New MySqlCommand(query, con)
                cmd.Parameters.AddWithValue("@id", id)
                cmd.Parameters.AddWithValue("@title", txtTitle.Text.Trim)
                cmd.Parameters.AddWithValue("@auth", txtAuthor.Text.Trim)
                cmd.Parameters.AddWithValue("@cat", txtCategory.Text.Trim)
                cmd.Parameters.AddWithValue("@pub", txtPubDate.Value.ToString("yyyy-MM-dd"))
                cmd.Parameters.AddWithValue("@path", pathTocreate)
                cmd.Parameters.AddWithValue("@stat", txtStatus.Text.Trim)
                cmd.ExecuteNonQuery()
                MsgBox("Book Update Successfully!", vbInformation, "Update Success!")
            Catch ex As MySqlException
                MsgBox(ex.Message, vbCritical, "Update Error!(0)")
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Update Error(1)!")
            Finally
                dbConClose()
                displayAllBooks()
            End Try
        Else
        End If
    End Sub
    Private Sub btnUpdatePhoto_Click(sender As Object, e As EventArgs) Handles btnUpdatePhoto.Click
        If upPic1.ShowDialog = DialogResult.OK Then
            bookPhotoBox.ImageLocation = upPic1.FileName
            createPath(upPic1.FileName)
        End If
    End Sub

    Private Sub refreshBtn_Click(sender As Object, e As EventArgs) Handles refreshBtn.Click
        refresh()
    End Sub

    Private Sub txtSearchList_TextChanged(sender As Object, e As EventArgs) Handles txtSearchList.TextChanged
        searchUser()
        If txtSearchList.Text = "" Then
            displayAllBooks()
        End If
    End Sub
    'main process

    'methods
    Public Sub displayBooksCredential(id As Integer)
        Try
            con.Open()
            Dim query As String = "SELECT bookID, title, author, category, profile FROM books WHERE bookID = @id"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@id", id)
            Dim read As MySqlDataReader = cmd.ExecuteReader
            While read.Read
                txtTitle.Text = read.GetString("title").ToString
                txtAuthor.Text = read.GetString("author")
                txtCategory.Text = read.GetString("category")
            End While
            txtBookID.Text = id
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Someting Wong")
        Finally
            GC.Collect()
            con.Close()
        End Try
    End Sub
    Sub checkForProfile(id As Integer)
        Try
            dbConOpen()
            Dim query As String = "SELECT profile FROM books WHERE bookID = @userID"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@userID", id)
            Dim result As Object = cmd.ExecuteScalar
            If IsDBNull(result) Then
                bookPhotoBox.ImageLocation = "C:\Users\CLIENT\Downloads\sdsdsds.jpg"
            Else
                Dim imageBytes() As Byte = DirectCast(result, Byte())
                Dim ms As New MemoryStream(imageBytes)
                bookPhotoBox.Image = Image.FromStream(ms)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Check Profile Error!")
        Finally
            dbConClose()
        End Try
    End Sub

    Public Sub DeleteRowRecord(id As Integer)
        Try
            dbConOpen()
            Dim query As String = "DELETE FROM books WHERE bookID = @id"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@id", id)
            cmd.ExecuteNonQuery()
        Catch ex As MySqlException
            MsgBox(ex.Message, vbCritical, "Delete Row Record Error!(0)")
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Delete Row Record Error!(1)")
        Finally
            dbConClose()
            displayAllBooks()
        End Try
    End Sub

    Public Sub enableForUpdate(ok As Boolean)
        btnUpdatePhoto.Enabled = ok
        txtTitle.ReadOnly = Not ok
        txtAuthor.ReadOnly = Not ok
        txtCategory.Enabled = ok
        txtStatus.Enabled = ok
        txtPubDate.Enabled = ok
    End Sub
    Public Sub refresh()
        Dim ib1 As New InsertBooks
        ib1.Show()
        Me.Dispose()
    End Sub

    Sub searchUser()
        Try
            dbConOpen()
            Dim query As String = "SELECT bookID, title, author, publishDate, category FROM books " &
                              "WHERE bookID LIKE @search " &
                              "OR title LIKE @search " &
                              "OR author LIKE @search " &
                              "OR publishDate LIKE @search " &
                              "OR category LIKE @search;"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@search", "%" & txtSearchList.Text & "%") ' ← add wildcards here
            Dim da As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)
            BookTable.DataSource = dt
        Catch ex As MySqlException
            MsgBox(ex.Message, vbCritical, "Search Error(0)")
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Search Error(1)")
        Finally
            GC.Collect()
            dbConClose()
        End Try
    End Sub


    Public Sub displayAllBooks()
        Try
            DBcon.dbConOpen()
            Dim query As String = "SELECT bookID, title, author, publishDate, category,stat FROM books"
            Dim dasd As New MySqlDataAdapter(query, con)
            Dim dt As New DataTable
            dasd.Fill(dt)
            BookTable.DataSource = dt
        Catch ex As MySqlException
            MsgBox(ex.Message, vbCritical, "Book Table Error 1")
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Book Table Error 2")
        Finally
            DBcon.dbConClose()
        End Try
    End Sub

    Private Sub BookHistoryBtn_Click(sender As Object, e As EventArgs) Handles BookHistoryBtn.Click
        BorrowHistory.Show()
        Me.Dispose()
    End Sub
    'methods
End Class