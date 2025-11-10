Imports System.Runtime.Versioning
Imports MySql.Data.MySqlClient

Public Class CreateActualBook
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles InsertBtn.Click
        Try
            If checkIfBookTitleisUnique(txtTitle.Text.Trim) Then
                MsgBox("THE TITLE IS ALREADY ON THE DATABASE")
            Else
                con.Open()
                Dim query As String = "INSERT INTO books (title, author, category, publishDate, profile) VALUES (@title, @auth, @cat, @pubDate, LOAD_FILE(@path))"
                Dim cmd As New MySqlCommand(query, con)
                cmd.Parameters.AddWithValue("@title", txtTitle.Text.Trim)
                cmd.Parameters.AddWithValue("@auth", txtAuthor.Text.Trim)
                cmd.Parameters.AddWithValue("@cat", txtCategory.Text.Trim)
                cmd.Parameters.AddWithValue("@pubDate", txtPubDate.Value.ToString("yyyy/MM/dd"))
                cmd.Parameters.AddWithValue("@path", pathTocreate)
                cmd.ExecuteNonQuery()
                MsgBox("Book is Inserted!", vbInformation, "Title Inserted!")
            End If
        Catch ex As MySqlException
            MsgBox(ex.Message, vbCritical, "fine")
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "shii")
        Finally
            GC.Collect()
            con.Close()
            clearAny()
            pathTocreate = Nothing
        End Try
    End Sub

    Private Sub btnUploadPhoto_Click(sender As Object, e As EventArgs) Handles btnUploadPhoto.Click
        If UploadPhotoDialoag.ShowDialog = DialogResult.OK Then
            Dim path As String = UploadPhotoDialoag.FileName
            createPath(path)
            btnUploadPhoto.Visible = False
            bookPic.Image = Image.FromFile(UploadPhotoDialoag.FileName)
        End If
    End Sub

    Public Sub clearAny()
        For Each e As Object In Me.Controls
            If TypeOf e Is TextBox Then
                Dim a As TextBox = DirectCast(e, TextBox)
                a.Clear()
            End If
        Next
        bookPic.Image = Nothing
        btnUploadPhoto.Visible = True
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        InsertBooks.Show()
        Me.Dispose()
    End Sub
End Class