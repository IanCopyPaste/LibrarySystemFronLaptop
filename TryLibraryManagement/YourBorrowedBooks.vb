Imports System.IO
Imports MySql.Data.MySqlClient

Public Class YourBorrowedBooks
    Private Sub YourBorrowedBooks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ewanFLow.Controls.Clear()
        Try
            dbConOpen()
            Dim query As String = "SELECT bk.title as title, bk.bookID AS bookid, bk.profile AS pic, bk.category AS cat 
                                   FROM borrow br JOIN users u ON u.userID = br.userID
                                   JOIN books bk ON bk.bookID = br.bookID
                                   WHERE u.userID = @id AND br.stat = 'Borrowed'"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@id", accNum)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                Dim title As String = reader.GetString("title")
                Dim imgBytes() As Byte = CType(reader("pic"), Byte())
                Dim cat As String = reader.GetString("cat")
                Dim getID2 As Integer = reader.GetValue("bookid")

                Using ms As New MemoryStream(imgBytes)
                    Dim img As Image = Image.FromStream(ms)

                    Dim cardShadow As New Panel With {
                .Width = 180,
                .Height = 300,
                .Margin = New Padding(15),
                .BackColor = Color.FromArgb(200, 200, 200),
                .Padding = New Padding(0, 3, 3, 3)
            }

                    Dim card As New Panel With {
                .Width = 177,
                .Height = 277,
                .BackColor = Color.White,
                .Dock = DockStyle.Fill,
                .Cursor = Cursors.Hand
            }

                    Dim imgContainer As New Panel With {
                .Width = 160,
                .Height = 200,
                .Location = New Point(9, 9),
                .BackColor = Color.FromArgb(245, 245, 245)
            }


                    Dim pic As New PictureBox With {
                .Image = img,
                .SizeMode = PictureBoxSizeMode.StretchImage,
                .Width = 160,
                .Height = 200,
                .Location = New Point(0, 0),
                .BackColor = Color.Transparent
            }

                    Dim lblTitle As New Label With {
                .Text = title,
                .ForeColor = Color.FromArgb(33, 33, 33),
                .Font = New Font("Segoe UI Semibold", 10.5F, FontStyle.Bold),
                .AutoSize = True,
                .MaximumSize = New Size(160, 0),
                .Location = New Point(9, 212),
                .TextAlign = ContentAlignment.TopLeft
            }
                    Dim lblBookID As New Label With {
                .Text = "ID: " & getID2,
                .ForeColor = Color.FromArgb(33, 33, 33),
                .Font = New Font("Segoe UI Semibold", 10.5F, FontStyle.Bold),
                .AutoSize = True,
                .MaximumSize = New Size(160, 0),
                .Location = New Point(9, 235),
                .TextAlign = ContentAlignment.TopLeft
            }
                    Dim lblGenre As New Label With {
                .Text = "Genre: " & cat,
                .ForeColor = Color.FromArgb(33, 33, 33),
                .Font = New Font("Segoe UI Semibold", 10.5F, FontStyle.Bold),
                .AutoSize = True,
                .MaximumSize = New Size(160, 0),
                .Location = New Point(9, 258),
                .TextAlign = ContentAlignment.TopLeft
            }
                    AddHandler card.MouseEnter, Sub(sender1, e1)
                                                    card.BackColor = Color.FromArgb(250, 250, 250)
                                                    cardShadow.BackColor = Color.FromArgb(150, 150, 150)
                                                    cardShadow.Padding = New Padding(0, 5, 5, 5)
                                                End Sub

                    AddHandler card.MouseLeave, Sub(sender1, e1)
                                                    card.BackColor = Color.White
                                                    cardShadow.BackColor = Color.FromArgb(200, 200, 200)
                                                    cardShadow.Padding = New Padding(0, 3, 3, 3)
                                                End Sub

                    AddHandler card.Click, Sub(sender1, e1)
                                               FetchAnything.getID3 = getID2
                                               MsgBox(getID2)
                                               ReturnBookForm.Show()
                                           End Sub

                    For Each ctrl As Control In {pic, imgContainer, lblTitle}
                        ctrl.Cursor = Cursors.Hand
                        AddHandler ctrl.Click, Sub(sender2, e2)
                                                   FetchAnything.getID3 = getID2
                                                   MsgBox(getID2)
                                                   ReturnBookForm.Show()
                                               End Sub
                        AddHandler ctrl.MouseEnter, Sub(sender2, e2)
                                                        card.BackColor = Color.FromArgb(250, 250, 250)
                                                        cardShadow.BackColor = Color.FromArgb(150, 150, 150)
                                                        cardShadow.Padding = New Padding(0, 5, 5, 5)
                                                    End Sub
                        AddHandler ctrl.MouseLeave, Sub(sender2, e2)
                                                        card.BackColor = Color.White
                                                        cardShadow.BackColor = Color.FromArgb(200, 200, 200)
                                                        cardShadow.Padding = New Padding(0, 3, 3, 3)
                                                    End Sub
                    Next
                    'gawin ang card
                    imgContainer.Controls.Add(pic)
                    card.Controls.Add(imgContainer)
                    card.Controls.Add(lblTitle)
                    card.Controls.Add(lblBookID)
                    card.Controls.Add(lblGenre)
                    cardShadow.Controls.Add(card)

                    ewanFLow.Controls.Add(cardShadow)
                End Using
            End While

            reader.Close()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            dbConClose()
        End Try
    End Sub

    Private Sub SignOutBtn_Click(sender As Object, e As EventArgs) Handles SignOutBtn.Click
        Form1.Show()
        Me.Dispose()
    End Sub

    Private Sub userPageBtn_Click(sender As Object, e As EventArgs) Handles userPageBtn.Click
        UserDashboard.Show()
        Me.Dispose()
    End Sub
End Class