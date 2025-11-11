Imports System.Globalization
Imports System.IO
Imports MySql.Data.MySqlClient

Public Class ReturnBookForm
    Private Sub ReturnBookForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtBookID.Text = getID3
        Try
            dbConOpen()
            Dim query As String = "SELECT bk.title AS title, bk.author AS author, bk.publishDate AS publishDate,
                                   bk.category AS category, bk.profile AS profile, br.stat AS stat
                                   FROM borrow br JOIN books bk ON bk.bookID = bk.bookID
                                   WHERE bk.bookID = @id AND br.stat = 'Borrowed'"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@id", getID3)
            Dim read As MySqlDataReader = cmd.ExecuteReader
            While read.Read
                txtTitle.Text = read.GetString("title")
                txtAuth.Text = read.GetString("author")
                txtDate.Text = read.GetDateTime("publishDate")
                txtGenre.Text = read.GetString("category")
                txtStatus.Text = read.GetString("stat")
                Dim imageByte() As Byte = CType(read("profile"), Byte())
                Dim ms As New MemoryStream(imageByte)
                Dim img As Image = Image.FromStream(ms)
                borrowPic.Image = img
            End While
        Catch ex As MySqlException
            MsgBox(ex.Message, vbCritical, "BORROW ERROR(0)")
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "BORROW ERROR(1)")
        Finally
            dbConClose()
            If txtStatus.Text = "Borrowed" Then
                txtStatus.Text = "You Borrowed it Nigga"
            End If
        End Try
    End Sub

    Private Sub btnBorrow_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        If MsgBox("ARE YOU SURE YOU WANT TO RETURN BOOK ID: " & getID3, vbYesNo + vbQuestion, "ARE YOU SURE?") = MsgBoxResult.Yes Then
            Try
                dbConOpen()
                Dim query0 As String = "UPDATE books SET stat = 'Available' WHERE bookID = @bookID"
                Dim cmd0 As New MySqlCommand(query0, con)
                cmd0.Parameters.AddWithValue("@bookID", getID3)
                cmd0.ExecuteNonQuery()

                Dim query1 As String = "UPDATE borrow SET stat = 'Returned' WHERE userID = @userID AND bookID = @bookID1"
                Dim cmd1 As New MySqlCommand(query1, con)
                cmd1.Parameters.AddWithValue("@userID", accNum)
                cmd1.Parameters.AddWithValue("@bookID1", getID3)
                cmd1.ExecuteNonQuery()
                MsgBox("BOOK RETURNED SUCESSFULLY", vbInformation, "BOOK RETURNED!")
            Catch ex As MySqlException
                MsgBox(ex.Message, vbCritical, "BORROW ERROR(2)")
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "BORROW ERROR(3)")
            Finally
                dbConClose()
            End Try
        End If
    End Sub
End Class