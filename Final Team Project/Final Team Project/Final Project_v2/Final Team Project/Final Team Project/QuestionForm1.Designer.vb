<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QuestionForm1
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txtCorrect = New System.Windows.Forms.TextBox()
        Me.txtWrong1 = New System.Windows.Forms.TextBox()
        Me.txtWrong2 = New System.Windows.Forms.TextBox()
        Me.txtWrong3 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(128, 75)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(241, 20)
        Me.TextBox1.TabIndex = 0
        '
        'txtCorrect
        '
        Me.txtCorrect.Location = New System.Drawing.Point(128, 140)
        Me.txtCorrect.Name = "txtCorrect"
        Me.txtCorrect.Size = New System.Drawing.Size(241, 20)
        Me.txtCorrect.TabIndex = 1
        '
        'txtWrong1
        '
        Me.txtWrong1.Location = New System.Drawing.Point(128, 188)
        Me.txtWrong1.Name = "txtWrong1"
        Me.txtWrong1.Size = New System.Drawing.Size(241, 20)
        Me.txtWrong1.TabIndex = 2
        '
        'txtWrong2
        '
        Me.txtWrong2.Location = New System.Drawing.Point(128, 225)
        Me.txtWrong2.Name = "txtWrong2"
        Me.txtWrong2.Size = New System.Drawing.Size(241, 20)
        Me.txtWrong2.TabIndex = 3
        '
        'txtWrong3
        '
        Me.txtWrong3.Location = New System.Drawing.Point(128, 254)
        Me.txtWrong3.Name = "txtWrong3"
        Me.txtWrong3.Size = New System.Drawing.Size(241, 20)
        Me.txtWrong3.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(55, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Question"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(43, 143)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Correct Answer"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(45, 191)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Wrong Answer"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(45, 228)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Wrong Answer"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(45, 261)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Wrong Answer"
        '
        'QuestionForm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(436, 416)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtWrong3)
        Me.Controls.Add(Me.txtWrong2)
        Me.Controls.Add(Me.txtWrong1)
        Me.Controls.Add(Me.txtCorrect)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "QuestionForm1"
        Me.Text = "Question Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents txtCorrect As TextBox
    Friend WithEvents txtWrong1 As TextBox
    Friend WithEvents txtWrong2 As TextBox
    Friend WithEvents txtWrong3 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
