<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateActualBook
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        txtTitle = New TextBox()
        InsertBtn = New Button()
        bookPic = New PictureBox()
        txtAuthor = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        txtCategory = New ComboBox()
        Label4 = New Label()
        txtPubDate = New DateTimePicker()
        Label5 = New Label()
        btnUploadPhoto = New Button()
        UploadPhotoDialoag = New OpenFileDialog()
        btnBack = New Button()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        CType(bookPic, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtTitle
        ' 
        txtTitle.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtTitle.Location = New Point(58, 98)
        txtTitle.Name = "txtTitle"
        txtTitle.Size = New Size(213, 25)
        txtTitle.TabIndex = 0
        ' 
        ' InsertBtn
        ' 
        InsertBtn.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        InsertBtn.Location = New Point(163, 381)
        InsertBtn.Name = "InsertBtn"
        InsertBtn.Size = New Size(285, 29)
        InsertBtn.TabIndex = 1
        InsertBtn.Text = "Insert"
        InsertBtn.UseVisualStyleBackColor = True
        ' 
        ' bookPic
        ' 
        bookPic.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        bookPic.Location = New Point(318, 79)
        bookPic.Name = "bookPic"
        bookPic.Size = New Size(264, 258)
        bookPic.SizeMode = PictureBoxSizeMode.StretchImage
        bookPic.TabIndex = 2
        bookPic.TabStop = False
        ' 
        ' txtAuthor
        ' 
        txtAuthor.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtAuthor.Location = New Point(58, 163)
        txtAuthor.Name = "txtAuthor"
        txtAuthor.Size = New Size(213, 25)
        txtAuthor.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(128, 126)
        Label2.Name = "Label2"
        Label2.Size = New Size(77, 20)
        Label2.TabIndex = 6
        Label2.Text = "Book Title"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(119, 191)
        Label3.Name = "Label3"
        Label3.Size = New Size(96, 20)
        Label3.TabIndex = 7
        Label3.Text = "Book Author"
        ' 
        ' txtCategory
        ' 
        txtCategory.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtCategory.FormattingEnabled = True
        txtCategory.Items.AddRange(New Object() {"Adult", "Horror", "Science Fiction", "Romance", "Poetry", "Lifestyle", "Action", "History"})
        txtCategory.Location = New Point(58, 230)
        txtCategory.Name = "txtCategory"
        txtCategory.Size = New Size(213, 25)
        txtCategory.TabIndex = 9
        txtCategory.Text = "Adult"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(133, 258)
        Label4.Name = "Label4"
        Label4.Size = New Size(72, 20)
        Label4.TabIndex = 10
        Label4.Text = "Category"
        ' 
        ' txtPubDate
        ' 
        txtPubDate.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtPubDate.Location = New Point(58, 296)
        txtPubDate.Name = "txtPubDate"
        txtPubDate.Size = New Size(213, 25)
        txtPubDate.TabIndex = 11
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(119, 324)
        Label5.Name = "Label5"
        Label5.Size = New Size(112, 20)
        Label5.TabIndex = 12
        Label5.Text = "Date Published"
        ' 
        ' btnUploadPhoto
        ' 
        btnUploadPhoto.Location = New Point(359, 191)
        btnUploadPhoto.Name = "btnUploadPhoto"
        btnUploadPhoto.Size = New Size(184, 39)
        btnUploadPhoto.TabIndex = 13
        btnUploadPhoto.Text = "Upload Photo"
        btnUploadPhoto.UseVisualStyleBackColor = True
        ' 
        ' UploadPhotoDialoag
        ' 
        UploadPhotoDialoag.FileName = "OpenFileDialog1"
        ' 
        ' btnBack
        ' 
        btnBack.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBack.Location = New Point(12, 12)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(141, 29)
        btnBack.TabIndex = 14
        btnBack.Text = "Back To Dashboard"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' CreateActualBook
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        ClientSize = New Size(623, 459)
        Controls.Add(btnBack)
        Controls.Add(btnUploadPhoto)
        Controls.Add(Label5)
        Controls.Add(txtPubDate)
        Controls.Add(Label4)
        Controls.Add(txtCategory)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(txtAuthor)
        Controls.Add(bookPic)
        Controls.Add(InsertBtn)
        Controls.Add(txtTitle)
        Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(4)
        Name = "CreateActualBook"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Insert a Book"
        TopMost = True
        CType(bookPic, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtTitle As TextBox
    Friend WithEvents InsertBtn As Button
    Friend WithEvents bookPic As PictureBox
    Friend WithEvents txtAuthor As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCategory As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPubDate As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents btnUploadPhoto As Button
    Friend WithEvents UploadPhotoDialoag As OpenFileDialog
    Friend WithEvents btnBack As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
