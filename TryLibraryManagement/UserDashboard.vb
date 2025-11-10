Imports System.IO
Imports MySql.Data.MySqlClient

Public Class UserDashboard
    Private Sub SignOutBtn_Click(sender As Object, e As EventArgs) Handles SignOutBtn.Click
        Form1.Show()
        Me.Dispose()
    End Sub

    Private Sub UserDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FlowLayoutPanel1.Controls.Clear() ' clear existing controls

        Try
            Dim query As String = "SELECT profile FROM books"
            Dim cmd As New MySqlCommand(query, con)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                ' Get blob data
                Dim imgBytes() As Byte = CType(reader("profile"), Byte())

                ' Convert bytes to image
                Dim ms As New MemoryStream(imgBytes)
                Dim img As Image = Image.FromStream(ms)

                ' Create PictureBox
                Dim pic As New PictureBox
                pic.Image = img
                pic.SizeMode = PictureBoxSizeMode.Zoom
                pic.Width = 120
                pic.Height = 120
                pic.Margin = New Padding(5)

                ' Add to flow layout
                FlowLayoutPanel1.Controls.Add(pic)
            End While

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub FlowLayoutPanel1_Click(sender As Object, e As EventArgs) Handles FlowLayoutPanel1.Click

    End Sub
End Class