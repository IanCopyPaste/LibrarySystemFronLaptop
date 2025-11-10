<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InsertBooks
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InsertBooks))
        TopPanel = New Panel()
        Label1 = New Label()
        TimeLabel = New Label()
        SidePanel = New Panel()
        BookHistoryBtn = New Button()
        bookDashBtn = New Button()
        SignOutBtn = New Button()
        InsertBooksBtn = New Button()
        userPageBtn = New Button()
        MainPanel = New Panel()
        Label8 = New Label()
        txtStatus = New ComboBox()
        refreshBtn = New Button()
        UpdateBtn = New Button()
        Label7 = New Label()
        btnUpdatePhoto = New Button()
        txtSearchList = New TextBox()
        Label6 = New Label()
        txtBookID = New TextBox()
        Label5 = New Label()
        txtPubDate = New DateTimePicker()
        Label4 = New Label()
        txtCategory = New ComboBox()
        Label3 = New Label()
        Label2 = New Label()
        txtAuthor = New TextBox()
        txtTitle = New TextBox()
        btnNewBook = New Button()
        bookPhotoBox = New PictureBox()
        BookTable = New DataGridView()
        BookID = New DataGridViewTextBoxColumn()
        Title = New DataGridViewTextBoxColumn()
        Author = New DataGridViewTextBoxColumn()
        PublishDate = New DataGridViewTextBoxColumn()
        Category = New DataGridViewTextBoxColumn()
        status = New DataGridViewTextBoxColumn()
        Edit = New DataGridViewImageColumn()
        delete = New DataGridViewImageColumn()
        upPic1 = New OpenFileDialog()
        Timer1 = New Timer(components)
        TopPanel.SuspendLayout()
        SidePanel.SuspendLayout()
        MainPanel.SuspendLayout()
        CType(bookPhotoBox, ComponentModel.ISupportInitialize).BeginInit()
        CType(BookTable, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TopPanel
        ' 
        TopPanel.BackColor = SystemColors.ActiveCaption
        TopPanel.Controls.Add(Label1)
        TopPanel.Dock = DockStyle.Top
        TopPanel.Location = New Point(0, 0)
        TopPanel.Name = "TopPanel"
        TopPanel.Size = New Size(1266, 74)
        TopPanel.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.AutoSize = True
        Label1.Font = New Font("Sitka Banner", 27.75F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(3, 7)
        Label1.Name = "Label1"
        Label1.Size = New Size(762, 53)
        Label1.TabIndex = 0
        Label1.Text = "Simpol Library Management System - Manage Books"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TimeLabel
        ' 
        TimeLabel.AutoSize = True
        TimeLabel.Font = New Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TimeLabel.ForeColor = SystemColors.ActiveCaptionText
        TimeLabel.Location = New Point(502, 20)
        TimeLabel.Name = "TimeLabel"
        TimeLabel.Size = New Size(131, 25)
        TimeLabel.TabIndex = 2
        TimeLabel.Text = "Time Now: "
        ' 
        ' SidePanel
        ' 
        SidePanel.BackColor = SystemColors.Highlight
        SidePanel.Controls.Add(BookHistoryBtn)
        SidePanel.Controls.Add(bookDashBtn)
        SidePanel.Controls.Add(SignOutBtn)
        SidePanel.Controls.Add(InsertBooksBtn)
        SidePanel.Controls.Add(userPageBtn)
        SidePanel.Dock = DockStyle.Left
        SidePanel.Location = New Point(0, 74)
        SidePanel.Name = "SidePanel"
        SidePanel.Size = New Size(105, 563)
        SidePanel.TabIndex = 2
        ' 
        ' BookHistoryBtn
        ' 
        BookHistoryBtn.BackColor = SystemColors.HotTrack
        BookHistoryBtn.FlatAppearance.BorderSize = 0
        BookHistoryBtn.FlatStyle = FlatStyle.Flat
        BookHistoryBtn.Font = New Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BookHistoryBtn.ForeColor = SystemColors.ControlLightLight
        BookHistoryBtn.Location = New Point(0, 243)
        BookHistoryBtn.Name = "BookHistoryBtn"
        BookHistoryBtn.Size = New Size(103, 60)
        BookHistoryBtn.TabIndex = 8
        BookHistoryBtn.Text = "Borrow History"
        BookHistoryBtn.UseVisualStyleBackColor = False
        ' 
        ' bookDashBtn
        ' 
        bookDashBtn.BackColor = SystemColors.HotTrack
        bookDashBtn.FlatAppearance.BorderSize = 0
        bookDashBtn.FlatStyle = FlatStyle.Flat
        bookDashBtn.Font = New Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        bookDashBtn.ForeColor = SystemColors.ControlLightLight
        bookDashBtn.Location = New Point(0, 320)
        bookDashBtn.Name = "bookDashBtn"
        bookDashBtn.Size = New Size(103, 60)
        bookDashBtn.TabIndex = 7
        bookDashBtn.Text = "Book Dashboard"
        bookDashBtn.UseVisualStyleBackColor = False
        ' 
        ' SignOutBtn
        ' 
        SignOutBtn.BackColor = SystemColors.HotTrack
        SignOutBtn.FlatAppearance.BorderSize = 0
        SignOutBtn.FlatStyle = FlatStyle.Flat
        SignOutBtn.Font = New Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SignOutBtn.ForeColor = SystemColors.ControlLightLight
        SignOutBtn.Location = New Point(-3, 454)
        SignOutBtn.Name = "SignOutBtn"
        SignOutBtn.Size = New Size(108, 60)
        SignOutBtn.TabIndex = 2
        SignOutBtn.Text = "Sign Out"
        SignOutBtn.UseVisualStyleBackColor = False
        ' 
        ' InsertBooksBtn
        ' 
        InsertBooksBtn.BackColor = SystemColors.HotTrack
        InsertBooksBtn.FlatAppearance.BorderSize = 0
        InsertBooksBtn.FlatStyle = FlatStyle.Flat
        InsertBooksBtn.Font = New Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        InsertBooksBtn.ForeColor = SystemColors.ControlLightLight
        InsertBooksBtn.Location = New Point(2, 163)
        InsertBooksBtn.Name = "InsertBooksBtn"
        InsertBooksBtn.Size = New Size(103, 60)
        InsertBooksBtn.TabIndex = 1
        InsertBooksBtn.Text = "Manage Books"
        InsertBooksBtn.UseVisualStyleBackColor = False
        ' 
        ' userPageBtn
        ' 
        userPageBtn.BackColor = SystemColors.HotTrack
        userPageBtn.FlatAppearance.BorderSize = 0
        userPageBtn.FlatStyle = FlatStyle.Flat
        userPageBtn.Font = New Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        userPageBtn.ForeColor = SystemColors.ControlLightLight
        userPageBtn.Location = New Point(0, 82)
        userPageBtn.Name = "userPageBtn"
        userPageBtn.Size = New Size(105, 60)
        userPageBtn.TabIndex = 0
        userPageBtn.Text = "Home"
        userPageBtn.UseVisualStyleBackColor = False
        ' 
        ' MainPanel
        ' 
        MainPanel.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        MainPanel.Controls.Add(Label8)
        MainPanel.Controls.Add(txtStatus)
        MainPanel.Controls.Add(refreshBtn)
        MainPanel.Controls.Add(TimeLabel)
        MainPanel.Controls.Add(UpdateBtn)
        MainPanel.Controls.Add(Label7)
        MainPanel.Controls.Add(btnUpdatePhoto)
        MainPanel.Controls.Add(txtSearchList)
        MainPanel.Controls.Add(Label6)
        MainPanel.Controls.Add(txtBookID)
        MainPanel.Controls.Add(Label5)
        MainPanel.Controls.Add(txtPubDate)
        MainPanel.Controls.Add(Label4)
        MainPanel.Controls.Add(txtCategory)
        MainPanel.Controls.Add(Label3)
        MainPanel.Controls.Add(Label2)
        MainPanel.Controls.Add(txtAuthor)
        MainPanel.Controls.Add(txtTitle)
        MainPanel.Controls.Add(btnNewBook)
        MainPanel.Controls.Add(bookPhotoBox)
        MainPanel.Controls.Add(BookTable)
        MainPanel.Dock = DockStyle.Fill
        MainPanel.Location = New Point(105, 74)
        MainPanel.Name = "MainPanel"
        MainPanel.Size = New Size(1161, 563)
        MainPanel.TabIndex = 3
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(174, 472)
        Label8.Name = "Label8"
        Label8.Size = New Size(72, 20)
        Label8.TabIndex = 30
        Label8.Text = "Category"
        ' 
        ' txtStatus
        ' 
        txtStatus.Enabled = False
        txtStatus.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtStatus.FormattingEnabled = True
        txtStatus.Items.AddRange(New Object() {"Available", "Not Available"})
        txtStatus.Location = New Point(119, 444)
        txtStatus.Name = "txtStatus"
        txtStatus.Size = New Size(178, 25)
        txtStatus.TabIndex = 29
        ' 
        ' refreshBtn
        ' 
        refreshBtn.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        refreshBtn.Location = New Point(18, 10)
        refreshBtn.Name = "refreshBtn"
        refreshBtn.Size = New Size(75, 31)
        refreshBtn.TabIndex = 28
        refreshBtn.Text = "Refresh"
        refreshBtn.UseVisualStyleBackColor = True
        ' 
        ' UpdateBtn
        ' 
        UpdateBtn.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(255))
        UpdateBtn.FlatAppearance.BorderSize = 0
        UpdateBtn.FlatStyle = FlatStyle.Flat
        UpdateBtn.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        UpdateBtn.Location = New Point(107, 505)
        UpdateBtn.Name = "UpdateBtn"
        UpdateBtn.Size = New Size(209, 31)
        UpdateBtn.TabIndex = 27
        UpdateBtn.Text = "Update"
        UpdateBtn.UseVisualStyleBackColor = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(830, 21)
        Label7.Name = "Label7"
        Label7.Size = New Size(56, 20)
        Label7.TabIndex = 26
        Label7.Text = "Search"
        ' 
        ' btnUpdatePhoto
        ' 
        btnUpdatePhoto.Location = New Point(166, 16)
        btnUpdatePhoto.Name = "btnUpdatePhoto"
        btnUpdatePhoto.Size = New Size(88, 31)
        btnUpdatePhoto.TabIndex = 25
        btnUpdatePhoto.Text = "Update Photo"
        btnUpdatePhoto.UseVisualStyleBackColor = True
        ' 
        ' txtSearchList
        ' 
        txtSearchList.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtSearchList.Location = New Point(892, 20)
        txtSearchList.Name = "txtSearchList"
        txtSearchList.PlaceholderText = "Search List"
        txtSearchList.Size = New Size(257, 25)
        txtSearchList.TabIndex = 23
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(183, 262)
        Label6.Name = "Label6"
        Label6.Size = New Size(59, 20)
        Label6.TabIndex = 22
        Label6.Text = "BookID"
        ' 
        ' txtBookID
        ' 
        txtBookID.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtBookID.Location = New Point(135, 234)
        txtBookID.Name = "txtBookID"
        txtBookID.ReadOnly = True
        txtBookID.Size = New Size(150, 25)
        txtBookID.TabIndex = 21
        txtBookID.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(53, 403)
        Label5.Name = "Label5"
        Label5.Size = New Size(112, 20)
        Label5.TabIndex = 20
        Label5.Text = "Date Published"
        ' 
        ' txtPubDate
        ' 
        txtPubDate.Enabled = False
        txtPubDate.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtPubDate.Location = New Point(18, 375)
        txtPubDate.Name = "txtPubDate"
        txtPubDate.Size = New Size(178, 25)
        txtPubDate.TabIndex = 19
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(284, 403)
        Label4.Name = "Label4"
        Label4.Size = New Size(72, 20)
        Label4.TabIndex = 18
        Label4.Text = "Category"
        ' 
        ' txtCategory
        ' 
        txtCategory.Enabled = False
        txtCategory.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtCategory.FormattingEnabled = True
        txtCategory.Items.AddRange(New Object() {"Adult", "Horror", "Science Fiction", "Romance", "Poetry", "Lifestyle", "Action", "History"})
        txtCategory.Location = New Point(229, 375)
        txtCategory.Name = "txtCategory"
        txtCategory.Size = New Size(178, 25)
        txtCategory.TabIndex = 17
        txtCategory.Text = "Adult"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(269, 331)
        Label3.Name = "Label3"
        Label3.Size = New Size(96, 20)
        Label3.TabIndex = 16
        Label3.Text = "Book Author"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(69, 331)
        Label2.Name = "Label2"
        Label2.Size = New Size(77, 20)
        Label2.TabIndex = 15
        Label2.Text = "Book Title"
        ' 
        ' txtAuthor
        ' 
        txtAuthor.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtAuthor.Location = New Point(229, 303)
        txtAuthor.Name = "txtAuthor"
        txtAuthor.ReadOnly = True
        txtAuthor.Size = New Size(178, 25)
        txtAuthor.TabIndex = 14
        ' 
        ' txtTitle
        ' 
        txtTitle.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtTitle.Location = New Point(18, 303)
        txtTitle.Name = "txtTitle"
        txtTitle.ReadOnly = True
        txtTitle.Size = New Size(178, 25)
        txtTitle.TabIndex = 13
        ' 
        ' btnNewBook
        ' 
        btnNewBook.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnNewBook.Location = New Point(416, 20)
        btnNewBook.Name = "btnNewBook"
        btnNewBook.Size = New Size(80, 26)
        btnNewBook.TabIndex = 2
        btnNewBook.Text = "New..."
        btnNewBook.UseVisualStyleBackColor = True
        ' 
        ' bookPhotoBox
        ' 
        bookPhotoBox.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        bookPhotoBox.Location = New Point(118, 53)
        bookPhotoBox.Name = "bookPhotoBox"
        bookPhotoBox.Size = New Size(179, 169)
        bookPhotoBox.SizeMode = PictureBoxSizeMode.StretchImage
        bookPhotoBox.TabIndex = 1
        bookPhotoBox.TabStop = False
        ' 
        ' BookTable
        ' 
        BookTable.AllowUserToAddRows = False
        BookTable.AllowUserToDeleteRows = False
        BookTable.BackgroundColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        BookTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        BookTable.Columns.AddRange(New DataGridViewColumn() {BookID, Title, Author, PublishDate, Category, status, Edit, delete})
        BookTable.Location = New Point(416, 53)
        BookTable.Name = "BookTable"
        BookTable.ReadOnly = True
        BookTable.Size = New Size(733, 483)
        BookTable.TabIndex = 0
        ' 
        ' BookID
        ' 
        BookID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        BookID.DataPropertyName = "bookID"
        BookID.HeaderText = "BookID"
        BookID.Name = "BookID"
        BookID.ReadOnly = True
        ' 
        ' Title
        ' 
        Title.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Title.DataPropertyName = "title"
        Title.HeaderText = "Title"
        Title.Name = "Title"
        Title.ReadOnly = True
        ' 
        ' Author
        ' 
        Author.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Author.DataPropertyName = "author"
        Author.HeaderText = "Author"
        Author.Name = "Author"
        Author.ReadOnly = True
        ' 
        ' PublishDate
        ' 
        PublishDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        PublishDate.DataPropertyName = "publishDate"
        PublishDate.HeaderText = "Date Published"
        PublishDate.Name = "PublishDate"
        PublishDate.ReadOnly = True
        ' 
        ' Category
        ' 
        Category.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Category.DataPropertyName = "category"
        Category.HeaderText = "Category"
        Category.Name = "Category"
        Category.ReadOnly = True
        ' 
        ' status
        ' 
        status.DataPropertyName = "stat"
        status.HeaderText = "Status"
        status.Name = "status"
        status.ReadOnly = True
        ' 
        ' Edit
        ' 
        Edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Edit.HeaderText = "Edit"
        Edit.Image = CType(resources.GetObject("Edit.Image"), Image)
        Edit.Name = "Edit"
        Edit.ReadOnly = True
        Edit.Resizable = DataGridViewTriState.True
        Edit.Width = 33
        ' 
        ' delete
        ' 
        delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        delete.HeaderText = "Delete"
        delete.Image = CType(resources.GetObject("delete.Image"), Image)
        delete.Name = "delete"
        delete.ReadOnly = True
        delete.Resizable = DataGridViewTriState.True
        delete.Width = 46
        ' 
        ' upPic1
        ' 
        upPic1.FileName = "OpenFileDialog1"
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        ' 
        ' InsertBooks
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1266, 637)
        Controls.Add(MainPanel)
        Controls.Add(SidePanel)
        Controls.Add(TopPanel)
        Name = "InsertBooks"
        StartPosition = FormStartPosition.CenterScreen
        Text = "InsertBooks"
        TopPanel.ResumeLayout(False)
        TopPanel.PerformLayout()
        SidePanel.ResumeLayout(False)
        MainPanel.ResumeLayout(False)
        MainPanel.PerformLayout()
        CType(bookPhotoBox, ComponentModel.ISupportInitialize).EndInit()
        CType(BookTable, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TopPanel As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents SidePanel As Panel
    Friend WithEvents SignOutBtn As Button
    Friend WithEvents InsertBooksBtn As Button
    Friend WithEvents userPageBtn As Button
    Friend WithEvents MainPanel As Panel
    Friend WithEvents upPic1 As OpenFileDialog
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents bookDashBtn As Button
    Friend WithEvents BookHistoryBtn As Button
    Friend WithEvents bookPhotoBox As PictureBox
    Friend WithEvents BookTable As DataGridView
    Friend WithEvents InsertBooksToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BorrowHistoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AllotedBooksToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnNewBook As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPubDate As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCategory As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtAuthor As TextBox
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtBookID As TextBox
    Friend WithEvents txtSearchList As TextBox
    Friend WithEvents TimeLabel As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnUpdatePhoto As Button
    Friend WithEvents UpdateBtn As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents refreshBtn As Button
    Friend WithEvents BookID As DataGridViewTextBoxColumn
    Friend WithEvents Title As DataGridViewTextBoxColumn
    Friend WithEvents Author As DataGridViewTextBoxColumn
    Friend WithEvents PublishDate As DataGridViewTextBoxColumn
    Friend WithEvents Category As DataGridViewTextBoxColumn
    Friend WithEvents status As DataGridViewTextBoxColumn
    Friend WithEvents Edit As DataGridViewImageColumn
    Friend WithEvents delete As DataGridViewImageColumn
    Friend WithEvents Label8 As Label
    Friend WithEvents txtStatus As ComboBox
End Class
