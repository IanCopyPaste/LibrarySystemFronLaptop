Imports System.IO
Imports MySql.Data.MySqlClient

Public Class ReturnBookForm
    Private Sub ReturnBookForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtBookID.Text = getID3
        Try
            dbConOpen()
            Dim query As String = "UPDATE borrow SET stat = 'Returned' WHERE userID = @userID"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@userID", accNum)
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
End Class