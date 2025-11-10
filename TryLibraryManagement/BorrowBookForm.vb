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
End Class