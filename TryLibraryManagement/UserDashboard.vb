Imports System.Drawing.Drawing2D
Imports System.IO
Imports System.Security.Cryptography.X509Certificates
Imports MySql.Data.MySqlClient

Public Class UserDashboard
    Private Sub SignOutBtn_Click(sender As Object, e As EventArgs) Handles SignOutBtn.Click
        Form1.Show()
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub UserDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        flowPanelRecords.Controls.Clear() ' clear existing controls

        Try
            Dim query As String = "SELECT bookID, profile, category,title FROM books"
            Dim cmd As New MySqlCommand(query, con)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                ' Get data
                Dim title As String = reader.GetString("title")
                Dim imgBytes() As Byte = CType(reader("profile"), Byte())
                Dim cat As String = reader.GetString("category")
                Dim getID2 As Integer = reader.GetValue("bookID")

                ' Convert bytes to image
                Using ms As New MemoryStream(imgBytes)
                    Dim img As Image = Image.FromStream(ms)

                    ' Create outer card panel (for shadow effect)
                    Dim cardShadow As New Panel With {
                .Width = 180,
                .Height = 300,
                .Margin = New Padding(15),
                .BackColor = Color.FromArgb(200, 200, 200),
                .Padding = New Padding(0, 3, 3, 3)
            }

                    ' Create main card panel
                    Dim card As New Panel With {
                .Width = 177,
                .Height = 277,
                .BackColor = Color.White,
                .Dock = DockStyle.Fill,
                .Cursor = Cursors.Hand
            }

                    ' Image container with rounded effect
                    Dim imgContainer As New Panel With {
                .Width = 160,
                .Height = 200,
                .Location = New Point(9, 9),
                .BackColor = Color.FromArgb(245, 245, 245)
            }

                    ' Create PictureBox
                    Dim pic As New PictureBox With {
                .Image = img,
                .SizeMode = PictureBoxSizeMode.StretchImage,
                .Width = 160,
                .Height = 200,
                .Location = New Point(0, 0),
                .BackColor = Color.Transparent
            }

                    ' Create title label
                    Dim lblTitle As New Label With {
                .Text = title,
                .ForeColor = Color.FromArgb(33, 33, 33),
                .Font = New Font("Segoe UI Semibold", 10.5F, FontStyle.Bold),
                .AutoSize = True,
                .MaximumSize = New Size(160, 0),
                .Location = New Point(9, 212),
                .TextAlign = ContentAlignment.TopLeft
            }
                    ' Create title label
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

                    ' Add hover effects
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

                    ' Click event
                    AddHandler card.Click, Sub(sender1, e1)
                                               FetchAnything.getID3 = getID2
                                               MsgBox(getID2)
                                               BorrowBookForm.Show()
                                           End Sub

                    ' Make child controls also trigger parent events
                    For Each ctrl As Control In {pic, imgContainer, lblTitle}
                        ctrl.Cursor = Cursors.Hand
                        AddHandler ctrl.Click, Sub(sender2, e2)
                                                   FetchAnything.getID3 = getID2
                                                   MsgBox(getID2)
                                                   BorrowBookForm.Show()
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
                    ' Build the card
                    imgContainer.Controls.Add(pic)
                    card.Controls.Add(imgContainer)
                    card.Controls.Add(lblTitle)
                    card.Controls.Add(lblBookID)
                    card.Controls.Add(lblGenre)
                    cardShadow.Controls.Add(card)

                    ' Add to flow layout
                    flowPanelRecords.Controls.Add(cardShadow)
                End Using
            End While

            reader.Close()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub

    Private Sub FlowLayoutPanel1_Click(sender As Object, e As EventArgs) Handles flowPanelRecords.Click

    End Sub
End Class