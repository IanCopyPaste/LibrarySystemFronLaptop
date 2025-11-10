<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BorrowBookForm
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
        PictureBox1 = New PictureBox()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        TextBox6 = New TextBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        PictureBox1.Location = New Point(367, 56)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(317, 378)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(57, 92)
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "Title"
        TextBox1.Size = New Size(258, 23)
        TextBox1.TabIndex = 1
        TextBox1.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(57, 158)
        TextBox2.Name = "TextBox2"
        TextBox2.PlaceholderText = "Author"
        TextBox2.Size = New Size(258, 23)
        TextBox2.TabIndex = 2
        TextBox2.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(57, 226)
        TextBox3.Name = "TextBox3"
        TextBox3.PlaceholderText = "Publish Date"
        TextBox3.Size = New Size(258, 23)
        TextBox3.TabIndex = 3
        TextBox3.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(57, 296)
        TextBox4.Name = "TextBox4"
        TextBox4.PlaceholderText = "Category"
        TextBox4.Size = New Size(258, 23)
        TextBox4.TabIndex = 4
        TextBox4.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(427, 27)
        TextBox5.Name = "TextBox5"
        TextBox5.PlaceholderText = "Book ID"
        TextBox5.Size = New Size(181, 23)
        TextBox5.TabIndex = 5
        TextBox5.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(57, 358)
        TextBox6.Name = "TextBox6"
        TextBox6.PlaceholderText = "Status"
        TextBox6.Size = New Size(258, 23)
        TextBox6.TabIndex = 6
        TextBox6.TextAlign = HorizontalAlignment.Center
        ' 
        ' BorrowBookForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        ClientSize = New Size(721, 485)
        Controls.Add(TextBox6)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(PictureBox1)
        Name = "BorrowBookForm"
        Text = "BorrowBookForm"
        TopMost = True
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
End Class
