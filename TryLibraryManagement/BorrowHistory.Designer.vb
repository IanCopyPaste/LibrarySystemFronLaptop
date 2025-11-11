<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BorrowHistory
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
        TopPanel = New Panel()
        Label1 = New Label()
        SidePanel = New Panel()
        BookHistoryBtn = New Button()
        Button1 = New Button()
        SignOutBtn = New Button()
        InsertBooksBtn = New Button()
        userPageBtn = New Button()
        MainPanel = New Panel()
        txtEmail = New TextBox()
        Label3 = New Label()
        BorrowTable = New DataGridView()
        BorrowID = New DataGridViewTextBoxColumn()
        UserID = New DataGridViewTextBoxColumn()
        Email = New DataGridViewTextBoxColumn()
        BookBorrowed = New DataGridViewTextBoxColumn()
        BorrowDate = New DataGridViewTextBoxColumn()
        DueDate = New DataGridViewTextBoxColumn()
        Status = New DataGridViewTextBoxColumn()
        Refresh = New Button()
        btnSend = New Button()
        Label2 = New Label()
        RichTextBox1 = New RichTextBox()
        searchBox = New TextBox()
        TimeLabel = New Label()
        Timer1 = New Timer(components)
        TopPanel.SuspendLayout()
        SidePanel.SuspendLayout()
        MainPanel.SuspendLayout()
        CType(BorrowTable, ComponentModel.ISupportInitialize).BeginInit()
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
        Label1.Location = New Point(12, 7)
        Label1.Name = "Label1"
        Label1.Size = New Size(782, 53)
        Label1.TabIndex = 0
        Label1.Text = "Simpol Library Management System - Borrow History"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' SidePanel
        ' 
        SidePanel.BackColor = SystemColors.Highlight
        SidePanel.Controls.Add(BookHistoryBtn)
        SidePanel.Controls.Add(Button1)
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
        BookHistoryBtn.Location = New Point(2, 244)
        BookHistoryBtn.Name = "BookHistoryBtn"
        BookHistoryBtn.Size = New Size(103, 60)
        BookHistoryBtn.TabIndex = 9
        BookHistoryBtn.Text = "Borrow History"
        BookHistoryBtn.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.HotTrack
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.ControlLightLight
        Button1.Location = New Point(2, 324)
        Button1.Name = "Button1"
        Button1.Size = New Size(103, 60)
        Button1.TabIndex = 7
        Button1.Text = "Book Dashboard"
        Button1.UseVisualStyleBackColor = False
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
        InsertBooksBtn.Location = New Point(2, 161)
        InsertBooksBtn.Name = "InsertBooksBtn"
        InsertBooksBtn.Size = New Size(103, 60)
        InsertBooksBtn.TabIndex = 1
        InsertBooksBtn.Text = "Manage" & vbCrLf & "Books" & vbCrLf
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
        userPageBtn.Text = "Manage Users"
        userPageBtn.UseVisualStyleBackColor = False
        ' 
        ' MainPanel
        ' 
        MainPanel.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        MainPanel.Controls.Add(txtEmail)
        MainPanel.Controls.Add(Label3)
        MainPanel.Controls.Add(BorrowTable)
        MainPanel.Controls.Add(Refresh)
        MainPanel.Controls.Add(btnSend)
        MainPanel.Controls.Add(Label2)
        MainPanel.Controls.Add(RichTextBox1)
        MainPanel.Controls.Add(searchBox)
        MainPanel.Controls.Add(TimeLabel)
        MainPanel.Dock = DockStyle.Fill
        MainPanel.Location = New Point(105, 74)
        MainPanel.Name = "MainPanel"
        MainPanel.Size = New Size(1161, 563)
        MainPanel.TabIndex = 3
        ' 
        ' txtEmail
        ' 
        txtEmail.BackColor = Color.White
        txtEmail.BorderStyle = BorderStyle.None
        txtEmail.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtEmail.Location = New Point(19, 366)
        txtEmail.Name = "txtEmail"
        txtEmail.PlaceholderText = "name@gmail.com"
        txtEmail.Size = New Size(296, 20)
        txtEmail.TabIndex = 11
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ActiveCaptionText
        Label3.Location = New Point(19, 345)
        Label3.Name = "Label3"
        Label3.Size = New Size(35, 18)
        Label3.TabIndex = 10
        Label3.Text = "To :"
        ' 
        ' BorrowTable
        ' 
        BorrowTable.AllowUserToAddRows = False
        BorrowTable.AllowUserToDeleteRows = False
        BorrowTable.BackgroundColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        BorrowTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        BorrowTable.Columns.AddRange(New DataGridViewColumn() {BorrowID, UserID, Email, BookBorrowed, BorrowDate, DueDate, Status})
        BorrowTable.Location = New Point(334, 62)
        BorrowTable.Name = "BorrowTable"
        BorrowTable.ReadOnly = True
        BorrowTable.Size = New Size(802, 472)
        BorrowTable.TabIndex = 9
        ' 
        ' BorrowID
        ' 
        BorrowID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        BorrowID.DataPropertyName = "BorrowID"
        BorrowID.HeaderText = "BorrowID"
        BorrowID.Name = "BorrowID"
        BorrowID.ReadOnly = True
        ' 
        ' UserID
        ' 
        UserID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        UserID.DataPropertyName = "UserID"
        UserID.HeaderText = "UserID"
        UserID.Name = "UserID"
        UserID.ReadOnly = True
        ' 
        ' Email
        ' 
        Email.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Email.DataPropertyName = "Email"
        Email.HeaderText = "Email"
        Email.Name = "Email"
        Email.ReadOnly = True
        ' 
        ' BookBorrowed
        ' 
        BookBorrowed.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        BookBorrowed.DataPropertyName = "Book_Borrowed"
        BookBorrowed.HeaderText = "Book Borrowed"
        BookBorrowed.Name = "BookBorrowed"
        BookBorrowed.ReadOnly = True
        ' 
        ' BorrowDate
        ' 
        BorrowDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        BorrowDate.DataPropertyName = "Borrowed_On"
        BorrowDate.HeaderText = "BorrowDate"
        BorrowDate.Name = "BorrowDate"
        BorrowDate.ReadOnly = True
        ' 
        ' DueDate
        ' 
        DueDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DueDate.DataPropertyName = "Due_Date"
        DueDate.HeaderText = "DueDate"
        DueDate.Name = "DueDate"
        DueDate.ReadOnly = True
        ' 
        ' Status
        ' 
        Status.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Status.DataPropertyName = "Statuss"
        Status.HeaderText = "Status"
        Status.Name = "Status"
        Status.ReadOnly = True
        ' 
        ' Refresh
        ' 
        Refresh.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Refresh.Location = New Point(6, 6)
        Refresh.Name = "Refresh"
        Refresh.Size = New Size(72, 28)
        Refresh.TabIndex = 8
        Refresh.Text = "Refresh"
        Refresh.UseVisualStyleBackColor = True
        ' 
        ' btnSend
        ' 
        btnSend.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSend.Location = New Point(77, 409)
        btnSend.Name = "btnSend"
        btnSend.Size = New Size(184, 28)
        btnSend.TabIndex = 7
        btnSend.Text = "Send"
        btnSend.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ActiveCaptionText
        Label2.Location = New Point(19, 82)
        Label2.Name = "Label2"
        Label2.Size = New Size(159, 18)
        Label2.TabIndex = 6
        Label2.Text = "Message returnees :"
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        RichTextBox1.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RichTextBox1.Location = New Point(19, 105)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(296, 224)
        RichTextBox1.TabIndex = 5
        RichTextBox1.Text = "Type you message here....."
        ' 
        ' searchBox
        ' 
        searchBox.Location = New Point(757, 21)
        searchBox.Name = "searchBox"
        searchBox.PlaceholderText = "Search User"
        searchBox.Size = New Size(379, 23)
        searchBox.TabIndex = 3
        ' 
        ' TimeLabel
        ' 
        TimeLabel.AutoSize = True
        TimeLabel.Font = New Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TimeLabel.ForeColor = SystemColors.ActiveCaptionText
        TimeLabel.Location = New Point(334, 21)
        TimeLabel.Name = "TimeLabel"
        TimeLabel.Size = New Size(131, 25)
        TimeLabel.TabIndex = 1
        TimeLabel.Text = "Time Now: "
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        ' 
        ' BorrowHistory
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1266, 637)
        Controls.Add(MainPanel)
        Controls.Add(SidePanel)
        Controls.Add(TopPanel)
        Name = "BorrowHistory"
        StartPosition = FormStartPosition.CenterScreen
        Text = "BorrowHistory"
        TopPanel.ResumeLayout(False)
        TopPanel.PerformLayout()
        SidePanel.ResumeLayout(False)
        MainPanel.ResumeLayout(False)
        MainPanel.PerformLayout()
        CType(BorrowTable, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TopPanel As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents SidePanel As Panel
    Friend WithEvents BookHistoryBtn As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents SignOutBtn As Button
    Friend WithEvents InsertBooksBtn As Button
    Friend WithEvents userPageBtn As Button
    Friend WithEvents MainPanel As Panel
    Friend WithEvents searchBox As TextBox
    Friend WithEvents TimeLabel As Label
    Friend WithEvents btnSend As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Refresh As Button
    Friend WithEvents BorrowTable As DataGridView
    Friend WithEvents BorrowID As DataGridViewTextBoxColumn
    Friend WithEvents UserID As DataGridViewTextBoxColumn
    Friend WithEvents Email As DataGridViewTextBoxColumn
    Friend WithEvents BookBorrowed As DataGridViewTextBoxColumn
    Friend WithEvents BorrowDate As DataGridViewTextBoxColumn
    Friend WithEvents DueDate As DataGridViewTextBoxColumn
    Friend WithEvents Status As DataGridViewTextBoxColumn
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label3 As Label
End Class
