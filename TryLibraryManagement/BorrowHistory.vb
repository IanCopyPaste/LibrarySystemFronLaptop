Imports MySql.Data.MySqlClient

Public Class BorrowHistory
    Private Sub InsertBooksBtn_Click(sender As Object, e As EventArgs) Handles InsertBooksBtn.Click
        InsertBooks.Show()
        Me.Dispose()
    End Sub
    Private Sub userPageBtn_Click(sender As Object, e As EventArgs) Handles userPageBtn.Click
        MainDashboard.Show()
        Me.Dispose()
    End Sub

    Private Sub BookHistoryBtn_Click(sender As Object, e As EventArgs) Handles BookHistoryBtn.Click
        Dim b1 As New BorrowHistory
        b1.Show()
        Me.Dispose()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TimeLabel.Text = "Date Now: " & Date.Now
    End Sub

    Private Sub SignOutBtn_Click(sender As Object, e As EventArgs) Handles SignOutBtn.Click
        SignUp.Show()
        Me.Dispose()
    End Sub

    Private Sub Refresh_Click(sender As Object, e As EventArgs) Handles Refresh.Click
        Dim bh1 As New BorrowHistory
        bh1.Show()
        Me.Close()
    End Sub

    Private Sub BorrowHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            dbConOpen()
            Dim query As String = "SELECT br.borrowID AS BorrowID, u.userID AS UserID, u.email AS Email, bk.title AS Book_Borrowed, br.borrowDate AS Borrowed_On, br.dueDate AS Due_Date, br.stat AS Statuss
                                   FROM borrow br JOIN users u ON u.userID = br.userID
                                   JOIN books bk ON bk.bookID = br.bookID"
            Dim dasd As New MySqlDataAdapter(query, con)
            Dim dt As New DataTable
            dasd.Fill(dt)
            BorrowTable.DataSource = dt
        Catch ex As MySqlException
            MsgBox(ex.Message, vbCritical, "ERROR BORROW HISTORY(0)")
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "ERROR BORROW HISTORY(1)")
        Finally
            dbConClose()
        End Try
    End Sub

    Private Sub BorrowTable_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles BorrowTable.CellClick
        Dim id As Integer = BorrowTable.Rows(e.RowIndex).Cells(1).Value
        MsgBox(id)
        Try
            dbConOpen()
            Dim query As String = "SELECT u.email As Email
                                   FROM borrow br JOIN users u ON u.userID = br.userID
                                   WHERE u.userID = @id"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@id", id)
            Dim read As MySqlDataReader = cmd.ExecuteReader
            While read.Read
                txtEmail.Text = read.GetString("Email")
            End While
        Catch ex As MySqlException
            MsgBox(ex.Message, vbCritical, "ERROR BORROW HISTORY(0)")
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "ERROR BORROW HISTORY(1)")
        Finally
            dbConClose()
        End Try
    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        NotifyReturnees(txtEmail.Text, RichTextBox1.Text)
    End Sub
End Class