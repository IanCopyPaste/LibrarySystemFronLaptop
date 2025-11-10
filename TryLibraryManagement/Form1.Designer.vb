<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        txtUsernameLog = New TextBox()
        txtPasswordLog = New TextBox()
        LogInButton = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        LinkLabel1 = New LinkLabel()
        toSignUp = New Label()
        Panel1 = New Panel()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtUsernameLog
        ' 
        txtUsernameLog.Location = New Point(95, 199)
        txtUsernameLog.Name = "txtUsernameLog"
        txtUsernameLog.PlaceholderText = "Enter username"
        txtUsernameLog.Size = New Size(207, 27)
        txtUsernameLog.TabIndex = 0
        ' 
        ' txtPasswordLog
        ' 
        txtPasswordLog.Location = New Point(95, 262)
        txtPasswordLog.Name = "txtPasswordLog"
        txtPasswordLog.PlaceholderText = "Enter password"
        txtPasswordLog.Size = New Size(207, 27)
        txtPasswordLog.TabIndex = 1
        txtPasswordLog.UseSystemPasswordChar = True
        ' 
        ' LogInButton
        ' 
        LogInButton.Font = New Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LogInButton.Location = New Point(158, 320)
        LogInButton.Name = "LogInButton"
        LogInButton.Size = New Size(75, 28)
        LogInButton.TabIndex = 2
        LogInButton.Text = "Log In"
        LogInButton.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(76, 30)
        Label1.Name = "Label1"
        Label1.Size = New Size(249, 23)
        Label1.TabIndex = 3
        Label1.Text = "Library Management System"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(162, 135)
        Label2.Name = "Label2"
        Label2.Size = New Size(71, 23)
        Label2.TabIndex = 4
        Label2.Text = "LOG IN"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(162, 382)
        Label3.Name = "Label3"
        Label3.Size = New Size(0, 23)
        Label3.TabIndex = 5
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Font = New Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LinkLabel1.Location = New Point(132, 382)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(0, 16)
        LinkLabel1.TabIndex = 6
        ' 
        ' toSignUp
        ' 
        toSignUp.AutoSize = True
        toSignUp.Font = New Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        toSignUp.ForeColor = SystemColors.MenuHighlight
        toSignUp.Location = New Point(132, 382)
        toSignUp.Name = "toSignUp"
        toSignUp.Size = New Size(121, 16)
        toSignUp.TabIndex = 7
        toSignUp.Text = "click here to sign up"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(toSignUp)
        Panel1.Controls.Add(LinkLabel1)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(LogInButton)
        Panel1.Controls.Add(txtPasswordLog)
        Panel1.Controls.Add(txtUsernameLog)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(398, 434)
        Panel1.TabIndex = 8
        ' 
        ' Form1
        ' 
        AutoScaleMode = AutoScaleMode.None
        ClientSize = New Size(398, 434)
        Controls.Add(Panel1)
        Font = New Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "LoginForm"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents txtUsernameLog As TextBox
    Friend WithEvents txtPasswordLog As TextBox
    Friend WithEvents LogInButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents toSignUp As Label
    Friend WithEvents Panel1 As Panel

End Class
