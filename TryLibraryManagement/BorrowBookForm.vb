Imports System.IO
Imports MySql.Data.MySqlClient

Public Class BorrowBookForm
    Private Sub BorrowBookForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtBookID.Text = getID3
        Try
            dbConOpen()
            Dim query As String = "SELECT * FROM books WHERE bookID = @id"
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
            If txtStatus.Text = "Not Available" Then
                btnBorrow.Enabled = False
                lblNotVail.Visible = True
            End If
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        UserDashboard.Show()
        Me.Dispose()
    End Sub

    Private Sub btnBorrow_Click(sender As Object, e As EventArgs) Handles btnBorrow.Click
        If MsgBox("ARE YOU SURE YOU WANT TO BORROW BOOK ID: " & getID3, vbYesNo + vbQuestion, "SURE KANA BA?") = MsgBoxResult.Yes Then
            Try
                dbConOpen()
                Dim query0 As String = "INSERT INTO borrow(userID,bookID,borrowDate,dueDate) 
                                   VALUES (@userID,@bookID,@borrow,@due)"
                Dim cmd0 As New MySqlCommand(query0, con)
                cmd0.Parameters.AddWithValue("@userID", accNum)
                cmd0.Parameters.AddWithValue("@bookID", getID3)
                cmd0.Parameters.AddWithValue("@borrow", Date.Now.ToString("yyyy-MM-dd"))
                cmd0.Parameters.AddWithValue("@due", Date.Now.AddDays(3).ToString("yyyy-MM-dd"))
                cmd0.ExecuteNonQuery()

                Dim query1 As String = "UPDATE books SET stat = 'Not Available' WHERE bookID = @bookID"
                Dim cmd1 As New MySqlCommand(query1, con)
                cmd1.Parameters.AddWithValue("@bookID", getID3)
                cmd1.ExecuteNonQuery()
            Catch ex As MysqlException
                MsgBox(ex.Message, vbCritical, "ERROR BORROW BOOK(0)")
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "ERROR BORROW BOOK(1)")
            Finally
                dbConClose()
            End Try
        End If
    End Sub
End Class