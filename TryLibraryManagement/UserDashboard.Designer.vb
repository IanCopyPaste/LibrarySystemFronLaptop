<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserDashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserDashboard))
        TopPanel = New Panel()
        updateProfileBtn = New Button()
        Label1 = New Label()
        profileBtn = New Button()
        txtWelcome = New TextBox()
        userIDlbl = New Label()
        ProfileBoxUpper = New PictureBox()
        SidePanel = New Panel()
        btnYourBooks = New Button()
        Button1 = New Button()
        SignOutBtn = New Button()
        MainPanel = New Panel()
        flowPanelRecords = New FlowLayoutPanel()
        searchBox = New TextBox()
        TimeLabel = New Label()
        TopPanel.SuspendLayout()
        CType(ProfileBoxUpper, ComponentModel.ISupportInitialize).BeginInit()
        SidePanel.SuspendLayout()
        MainPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' TopPanel
        ' 
        TopPanel.BackColor = SystemColors.ActiveCaption
        TopPanel.Controls.Add(updateProfileBtn)
        TopPanel.Controls.Add(Label1)
        TopPanel.Controls.Add(profileBtn)
        TopPanel.Controls.Add(txtWelcome)
        TopPanel.Controls.Add(userIDlbl)
        TopPanel.Controls.Add(ProfileBoxUpper)
        TopPanel.Dock = DockStyle.Top
        TopPanel.Location = New Point(0, 0)
        TopPanel.Name = "TopPanel"
        TopPanel.Size = New Size(1266, 74)
        TopPanel.TabIndex = 2
        ' 
        ' updateProfileBtn
        ' 
        updateProfileBtn.Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        updateProfileBtn.Location = New Point(1113, 9)
        updateProfileBtn.Name = "updateProfileBtn"
        updateProfileBtn.Size = New Size(60, 46)
        updateProfileBtn.TabIndex = 13
        updateProfileBtn.Text = "Update" & vbCrLf & " Profile"
        updateProfileBtn.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.AutoSize = True
        Label1.Font = New Font("Sitka Banner", 27.75F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(12, 7)
        Label1.Name = "Label1"
        Label1.Size = New Size(532, 53)
        Label1.TabIndex = 0
        Label1.Text = "Simpol Library Management System"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' profileBtn
        ' 
        profileBtn.Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        profileBtn.Location = New Point(1188, 12)
        profileBtn.Name = "profileBtn"
        profileBtn.Size = New Size(64, 42)
        profileBtn.TabIndex = 12
        profileBtn.Text = "  Upload " & vbCrLf & " Profile"
        profileBtn.UseVisualStyleBackColor = True
        ' 
        ' txtWelcome
        ' 
        txtWelcome.BackColor = Color.White
        txtWelcome.BorderStyle = BorderStyle.None
        txtWelcome.Font = New Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtWelcome.Location = New Point(847, 21)
        txtWelcome.Name = "txtWelcome"
        txtWelcome.ReadOnly = True
        txtWelcome.Size = New Size(237, 23)
        txtWelcome.TabIndex = 10
        txtWelcome.Text = "Welcome, "
        txtWelcome.TextAlign = HorizontalAlignment.Center
        ' 
        ' userIDlbl
        ' 
        userIDlbl.AutoSize = True
        userIDlbl.Location = New Point(847, 47)
        userIDlbl.Name = "userIDlbl"
        userIDlbl.Size = New Size(67, 21)
        userIDlbl.TabIndex = 11
        userIDlbl.Text = "UserID: "
        ' 
        ' ProfileBoxUpper
        ' 
        ProfileBoxUpper.ErrorImage = CType(resources.GetObject("ProfileBoxUpper.ErrorImage"), Image)
        ProfileBoxUpper.Location = New Point(1179, 6)
        ProfileBoxUpper.Name = "ProfileBoxUpper"
        ProfileBoxUpper.Size = New Size(73, 56)
        ProfileBoxUpper.TabIndex = 9
        ProfileBoxUpper.TabStop = False
        ' 
        ' SidePanel
        ' 
        SidePanel.BackColor = SystemColors.Highlight
        SidePanel.Controls.Add(btnYourBooks)
        SidePanel.Controls.Add(Button1)
        SidePanel.Controls.Add(SignOutBtn)
        SidePanel.Dock = DockStyle.Left
        SidePanel.Location = New Point(0, 74)
        SidePanel.Name = "SidePanel"
        SidePanel.Size = New Size(105, 563)
        SidePanel.TabIndex = 3
        ' 
        ' btnYourBooks
        ' 
        btnYourBooks.BackColor = SystemColors.HotTrack
        btnYourBooks.FlatAppearance.BorderSize = 0
        btnYourBooks.FlatStyle = FlatStyle.Flat
        btnYourBooks.Font = New Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnYourBooks.ForeColor = SystemColors.ControlLightLight
        btnYourBooks.Location = New Point(0, 173)
        btnYourBooks.Name = "btnYourBooks"
        btnYourBooks.Size = New Size(103, 60)
        btnYourBooks.TabIndex = 8
        btnYourBooks.Text = "Your Books"
        btnYourBooks.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.HotTrack
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.ControlLightLight
        Button1.Location = New Point(0, 68)
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
        ' MainPanel
        ' 
        MainPanel.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        MainPanel.Controls.Add(flowPanelRecords)
        MainPanel.Controls.Add(searchBox)
        MainPanel.Controls.Add(TimeLabel)
        MainPanel.Dock = DockStyle.Fill
        MainPanel.Location = New Point(105, 74)
        MainPanel.Name = "MainPanel"
        MainPanel.Size = New Size(1161, 563)
        MainPanel.TabIndex = 4
        ' 
        ' flowPanelRecords
        ' 
        flowPanelRecords.AutoScroll = True
        flowPanelRecords.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        flowPanelRecords.Location = New Point(37, 56)
        flowPanelRecords.Name = "flowPanelRecords"
        flowPanelRecords.Size = New Size(1087, 465)
        flowPanelRecords.TabIndex = 4
        ' 
        ' searchBox
        ' 
        searchBox.Location = New Point(757, 21)
        searchBox.Name = "searchBox"
        searchBox.PlaceholderText = "Search User"
        searchBox.Size = New Size(379, 29)
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
        ' UserDashboard
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1266, 637)
        Controls.Add(MainPanel)
        Controls.Add(SidePanel)
        Controls.Add(TopPanel)
        Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(4)
        Name = "UserDashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "UserDashboard"
        TopPanel.ResumeLayout(False)
        TopPanel.PerformLayout()
        CType(ProfileBoxUpper, ComponentModel.ISupportInitialize).EndInit()
        SidePanel.ResumeLayout(False)
        MainPanel.ResumeLayout(False)
        MainPanel.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TopPanel As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents updateProfileBtn As Button
    Friend WithEvents profileBtn As Button
    Friend WithEvents txtWelcome As TextBox
    Friend WithEvents userIDlbl As Label
    Friend WithEvents ProfileBoxUpper As PictureBox
    Friend WithEvents SidePanel As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents SignOutBtn As Button
    Friend WithEvents btnYourBooks As Button
    Friend WithEvents MainPanel As Panel
    Friend WithEvents searchBox As TextBox
    Friend WithEvents TimeLabel As Label
    Friend WithEvents flowPanelRecords As FlowLayoutPanel
End Class
