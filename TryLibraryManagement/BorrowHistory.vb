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
End Class