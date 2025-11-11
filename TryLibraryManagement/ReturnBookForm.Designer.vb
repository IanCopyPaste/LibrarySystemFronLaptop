<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReturnBookForm
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
        lblNotVail = New Label()
        Button1 = New Button()
        Label3 = New Label()
        txtBookID = New TextBox()
        btnBorrow = New Button()
        Label6 = New Label()
        txtStatus = New TextBox()
        Label5 = New Label()
        txtGenre = New TextBox()
        Label4 = New Label()
        txtDate = New TextBox()
        Label2 = New Label()
        txtAuth = New TextBox()
        Label1 = New Label()
        txtTitle = New TextBox()
        borrowPic = New PictureBox()
        CType(borrowPic, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblNotVail
        ' 
        lblNotVail.AutoSize = True
        lblNotVail.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblNotVail.ForeColor = Color.Red
        lblNotVail.Location = New Point(232, 361)
        lblNotVail.Name = "lblNotVail"
        lblNotVail.Size = New Size(185, 17)
        lblNotVail.TabIndex = 34
        lblNotVail.Text = "*Sorry Book is not Avaialble*"
        lblNotVail.Visible = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.White
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(8, 12)
        Button1.Name = "Button1"
        Button1.Size = New Size(93, 24)
        Button1.TabIndex = 33
        Button1.Text = "Go Back"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(387, 45)
        Label3.Name = "Label3"
        Label3.Size = New Size(61, 17)
        Label3.TabIndex = 32
        Label3.Text = "BOOK ID"
        ' 
        ' txtBookID
        ' 
        txtBookID.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtBookID.Location = New Point(387, 65)
        txtBookID.Name = "txtBookID"
        txtBookID.PlaceholderText = "BookID"
        txtBookID.Size = New Size(165, 27)
        txtBookID.TabIndex = 31
        txtBookID.TextAlign = HorizontalAlignment.Center
        ' 
        ' btnBorrow
        ' 
        btnBorrow.BackColor = Color.White
        btnBorrow.FlatAppearance.BorderSize = 0
        btnBorrow.FlatStyle = FlatStyle.Flat
        btnBorrow.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBorrow.Location = New Point(186, 381)
        btnBorrow.Name = "btnBorrow"
        btnBorrow.Size = New Size(282, 31)
        btnBorrow.TabIndex = 30
        btnBorrow.Text = "Borrow Book"
        btnBorrow.UseVisualStyleBackColor = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(49, 306)
        Label6.Name = "Label6"
        Label6.Size = New Size(52, 17)
        Label6.TabIndex = 29
        Label6.Text = "STATUS"
        ' 
        ' txtStatus
        ' 
        txtStatus.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtStatus.Location = New Point(49, 326)
        txtStatus.Name = "txtStatus"
        txtStatus.PlaceholderText = "STATUS"
        txtStatus.ReadOnly = True
        txtStatus.Size = New Size(258, 27)
        txtStatus.TabIndex = 28
        txtStatus.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(49, 245)
        Label5.Name = "Label5"
        Label5.Size = New Size(49, 17)
        Label5.TabIndex = 27
        Label5.Text = "GENRE"
        ' 
        ' txtGenre
        ' 
        txtGenre.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtGenre.Location = New Point(49, 265)
        txtGenre.Name = "txtGenre"
        txtGenre.PlaceholderText = "GENRE"
        txtGenre.ReadOnly = True
        txtGenre.Size = New Size(258, 27)
        txtGenre.TabIndex = 26
        txtGenre.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(49, 177)
        Label4.Name = "Label4"
        Label4.Size = New Size(111, 17)
        Label4.TabIndex = 25
        Label4.Text = "DATE PUBLISHED"
        ' 
        ' txtDate
        ' 
        txtDate.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtDate.Location = New Point(49, 197)
        txtDate.Name = "txtDate"
        txtDate.PlaceholderText = "PUBLICATION DATE"
        txtDate.ReadOnly = True
        txtDate.Size = New Size(258, 27)
        txtDate.TabIndex = 24
        txtDate.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(49, 111)
        Label2.Name = "Label2"
        Label2.Size = New Size(61, 17)
        Label2.TabIndex = 23
        Label2.Text = "AUTHOR"
        ' 
        ' txtAuth
        ' 
        txtAuth.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtAuth.Location = New Point(49, 131)
        txtAuth.Name = "txtAuth"
        txtAuth.PlaceholderText = "Author"
        txtAuth.ReadOnly = True
        txtAuth.Size = New Size(258, 27)
        txtAuth.TabIndex = 22
        txtAuth.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(49, 46)
        Label1.Name = "Label1"
        Label1.Size = New Size(39, 17)
        Label1.TabIndex = 21
        Label1.Text = "TITLE"
        ' 
        ' txtTitle
        ' 
        txtTitle.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtTitle.Location = New Point(49, 65)
        txtTitle.Name = "txtTitle"
        txtTitle.PlaceholderText = "Title"
        txtTitle.ReadOnly = True
        txtTitle.Size = New Size(258, 27)
        txtTitle.TabIndex = 20
        txtTitle.TextAlign = HorizontalAlignment.Center
        ' 
        ' borrowPic
        ' 
        borrowPic.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        borrowPic.Location = New Point(370, 98)
        borrowPic.Name = "borrowPic"
        borrowPic.Size = New Size(198, 215)
        borrowPic.SizeMode = PictureBoxSizeMode.StretchImage
        borrowPic.TabIndex = 19
        borrowPic.TabStop = False
        ' 
        ' ReturnBookForm
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        ClientSize = New Size(584, 418)
        Controls.Add(lblNotVail)
        Controls.Add(Button1)
        Controls.Add(Label3)
        Controls.Add(txtBookID)
        Controls.Add(btnBorrow)
        Controls.Add(Label6)
        Controls.Add(txtStatus)
        Controls.Add(Label5)
        Controls.Add(txtGenre)
        Controls.Add(Label4)
        Controls.Add(txtDate)
        Controls.Add(Label2)
        Controls.Add(txtAuth)
        Controls.Add(Label1)
        Controls.Add(txtTitle)
        Controls.Add(borrowPic)
        Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(4, 4, 4, 4)
        Name = "ReturnBookForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ReturnBookForm"
        CType(borrowPic, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblNotVail As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtBookID As TextBox
    Friend WithEvents btnBorrow As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txtStatus As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtGenre As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtDate As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtAuth As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents borrowPic As PictureBox
End Class
