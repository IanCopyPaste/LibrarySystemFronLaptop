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
        TopPanel = New Panel()
        Label1 = New Label()
        SidePanel = New Panel()
        BookHistoryBtn = New Button()
        Button1 = New Button()
        SignOutBtn = New Button()
        InsertBooksBtn = New Button()
        userPageBtn = New Button()
        MainPanel = New Panel()
        searchBox = New TextBox()
        TimeLabel = New Label()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        TopPanel.SuspendLayout()
        SidePanel.SuspendLayout()
        MainPanel.SuspendLayout()
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
        userPageBtn.Text = "Home"
        userPageBtn.UseVisualStyleBackColor = False
        ' 
        ' MainPanel
        ' 
        MainPanel.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        MainPanel.Controls.Add(FlowLayoutPanel1)
        MainPanel.Controls.Add(searchBox)
        MainPanel.Controls.Add(TimeLabel)
        MainPanel.Dock = DockStyle.Fill
        MainPanel.Location = New Point(105, 74)
        MainPanel.Name = "MainPanel"
        MainPanel.Size = New Size(1161, 563)
        MainPanel.TabIndex = 3
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
        TimeLabel.Location = New Point(37, 17)
        TimeLabel.Name = "TimeLabel"
        TimeLabel.Size = New Size(131, 25)
        TimeLabel.TabIndex = 1
        TimeLabel.Text = "Time Now: "
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        FlowLayoutPanel1.Location = New Point(37, 60)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(1099, 467)
        FlowLayoutPanel1.TabIndex = 4
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
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
End Class
