<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignUp
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
        Label1 = New Label()
        Label2 = New Label()
        fnameBox = New TextBox()
        lnameBox = New TextBox()
        mnameBox = New TextBox()
        suffBox = New TextBox()
        usernamBox = New TextBox()
        passwordBox = New TextBox()
        CpasswordBox = New TextBox()
        SignUpbtn = New Button()
        LinkLabel1 = New LinkLabel()
        toLogIn = New Label()
        Panel1 = New Panel()
        Button1 = New Button()
        confirmLbl = New Label()
        Label10 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label5 = New Label()
        emailBox = New TextBox()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(94, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(249, 23)
        Label1.TabIndex = 4
        Label1.Text = "Library Management System"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(386, 24)
        Label2.Name = "Label2"
        Label2.Size = New Size(82, 23)
        Label2.TabIndex = 5
        Label2.Text = "SIGN UP"
        ' 
        ' fnameBox
        ' 
        fnameBox.Location = New Point(106, 101)
        fnameBox.Name = "fnameBox"
        fnameBox.PlaceholderText = "Enter firstname"
        fnameBox.Size = New Size(165, 27)
        fnameBox.TabIndex = 6
        ' 
        ' lnameBox
        ' 
        lnameBox.Location = New Point(106, 182)
        lnameBox.Name = "lnameBox"
        lnameBox.PlaceholderText = "Enter lastname"
        lnameBox.Size = New Size(165, 27)
        lnameBox.TabIndex = 7
        ' 
        ' mnameBox
        ' 
        mnameBox.Location = New Point(304, 101)
        mnameBox.Name = "mnameBox"
        mnameBox.PlaceholderText = "Enter middlename"
        mnameBox.Size = New Size(165, 27)
        mnameBox.TabIndex = 8
        ' 
        ' suffBox
        ' 
        suffBox.Location = New Point(304, 182)
        suffBox.Name = "suffBox"
        suffBox.PlaceholderText = "Enter suffix"
        suffBox.Size = New Size(165, 27)
        suffBox.TabIndex = 9
        ' 
        ' usernamBox
        ' 
        usernamBox.Location = New Point(39, 267)
        usernamBox.Name = "usernamBox"
        usernamBox.PlaceholderText = "Create username"
        usernamBox.Size = New Size(232, 27)
        usernamBox.TabIndex = 12
        ' 
        ' passwordBox
        ' 
        passwordBox.Location = New Point(314, 267)
        passwordBox.Name = "passwordBox"
        passwordBox.PlaceholderText = "Create password"
        passwordBox.Size = New Size(232, 27)
        passwordBox.TabIndex = 13
        passwordBox.UseSystemPasswordChar = True
        ' 
        ' CpasswordBox
        ' 
        CpasswordBox.Location = New Point(314, 333)
        CpasswordBox.Name = "CpasswordBox"
        CpasswordBox.PlaceholderText = "Confirm password"
        CpasswordBox.Size = New Size(232, 27)
        CpasswordBox.TabIndex = 14
        CpasswordBox.UseSystemPasswordChar = True
        ' 
        ' SignUpbtn
        ' 
        SignUpbtn.Font = New Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SignUpbtn.Location = New Point(179, 423)
        SignUpbtn.Name = "SignUpbtn"
        SignUpbtn.Size = New Size(239, 28)
        SignUpbtn.TabIndex = 15
        SignUpbtn.Text = "SignUp"
        SignUpbtn.UseVisualStyleBackColor = True
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Font = New Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LinkLabel1.Location = New Point(94, 409)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(0, 16)
        LinkLabel1.TabIndex = 16
        ' 
        ' toLogIn
        ' 
        toLogIn.AutoSize = True
        toLogIn.Font = New Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        toLogIn.ForeColor = SystemColors.MenuHighlight
        toLogIn.Location = New Point(191, 467)
        toLogIn.Name = "toLogIn"
        toLogIn.Size = New Size(210, 16)
        toLogIn.TabIndex = 17
        toLogIn.Text = "already have an account? click here"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(confirmLbl)
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(emailBox)
        Panel1.Controls.Add(usernamBox)
        Panel1.Controls.Add(passwordBox)
        Panel1.Controls.Add(CpasswordBox)
        Panel1.Controls.Add(SignUpbtn)
        Panel1.Controls.Add(LinkLabel1)
        Panel1.Controls.Add(toLogIn)
        Panel1.Controls.Add(suffBox)
        Panel1.Controls.Add(mnameBox)
        Panel1.Controls.Add(lnameBox)
        Panel1.Controls.Add(fnameBox)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(606, 505)
        Panel1.TabIndex = 18
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(552, 271)
        Button1.Name = "Button1"
        Button1.Size = New Size(37, 23)
        Button1.TabIndex = 28
        Button1.Text = "S"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' confirmLbl
        ' 
        confirmLbl.AutoSize = True
        confirmLbl.FlatStyle = FlatStyle.System
        confirmLbl.Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        confirmLbl.Location = New Point(357, 394)
        confirmLbl.Name = "confirmLbl"
        confirmLbl.Size = New Size(146, 14)
        confirmLbl.TabIndex = 27
        confirmLbl.Text = "Password Do Not Match!!"
        confirmLbl.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.FlatStyle = FlatStyle.System
        Label10.Font = New Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(369, 363)
        Label10.Name = "Label10"
        Label10.Size = New Size(132, 18)
        Label10.TabIndex = 26
        Label10.Text = "Confirm Password*"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.FlatStyle = FlatStyle.System
        Label9.Font = New Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(399, 297)
        Label9.Name = "Label9"
        Label9.Size = New Size(77, 18)
        Label9.TabIndex = 25
        Label9.Text = "Password*"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.FlatStyle = FlatStyle.System
        Label8.Font = New Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(134, 363)
        Label8.Name = "Label8"
        Label8.Size = New Size(49, 18)
        Label8.TabIndex = 24
        Label8.Text = "Email*"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.FlatStyle = FlatStyle.System
        Label7.Font = New Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(120, 297)
        Label7.Name = "Label7"
        Label7.Size = New Size(83, 18)
        Label7.TabIndex = 23
        Label7.Text = "Username*"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.FlatStyle = FlatStyle.System
        Label6.Font = New Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(357, 212)
        Label6.Name = "Label6"
        Label6.Size = New Size(44, 18)
        Label6.TabIndex = 22
        Label6.Text = "Suffix"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.FlatStyle = FlatStyle.System
        Label4.Font = New Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(342, 131)
        Label4.Name = "Label4"
        Label4.Size = New Size(85, 18)
        Label4.TabIndex = 21
        Label4.Text = "Middlename"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.FlatStyle = FlatStyle.System
        Label3.Font = New Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(149, 212)
        Label3.Name = "Label3"
        Label3.Size = New Size(80, 18)
        Label3.TabIndex = 20
        Label3.Text = "Lastname*"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.FlatStyle = FlatStyle.System
        Label5.Font = New Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(149, 131)
        Label5.Name = "Label5"
        Label5.Size = New Size(80, 18)
        Label5.TabIndex = 19
        Label5.Text = "Firstname*"
        ' 
        ' emailBox
        ' 
        emailBox.Location = New Point(39, 333)
        emailBox.Name = "emailBox"
        emailBox.PlaceholderText = "Enter Email Address"
        emailBox.Size = New Size(232, 27)
        emailBox.TabIndex = 18
        ' 
        ' SignUp
        ' 
        AutoScaleDimensions = New SizeF(9F, 19F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(606, 505)
        Controls.Add(Panel1)
        Font = New Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(4)
        Name = "SignUp"
        StartPosition = FormStartPosition.CenterScreen
        Text = "SignUp"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents fnameBox As TextBox
    Friend WithEvents lnameBox As TextBox
    Friend WithEvents mnameBox As TextBox
    Friend WithEvents suffBox As TextBox
    Friend WithEvents usernamBox As TextBox
    Friend WithEvents passwordBox As TextBox
    Friend WithEvents CpasswordBox As TextBox
    Friend WithEvents SignUpbtn As Button
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents toLogIn As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents emailBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents confirmLbl As Label
    Friend WithEvents Button1 As Button
End Class
