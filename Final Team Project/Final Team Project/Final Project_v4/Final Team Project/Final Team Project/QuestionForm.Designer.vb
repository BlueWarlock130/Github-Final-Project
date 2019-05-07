<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QuestionForm
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
        Me.txtQuestion = New System.Windows.Forms.TextBox()
        Me.txtCorrect = New System.Windows.Forms.TextBox()
        Me.txtWrong1 = New System.Windows.Forms.TextBox()
        Me.txtWrong2 = New System.Windows.Forms.TextBox()
        Me.txtWrong3 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbQuestion1 = New System.Windows.Forms.TabControl()
        Me.tbQuestionMultiple = New System.Windows.Forms.TabPage()
        Me.tbQuestionShort = New System.Windows.Forms.TabPage()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtAnswer = New System.Windows.Forms.TextBox()
        Me.txtQuestion1 = New System.Windows.Forms.TextBox()
        Me.tbQuestion1.SuspendLayout()
        Me.tbQuestionMultiple.SuspendLayout()
        Me.tbQuestionShort.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtQuestion
        '
        Me.txtQuestion.Location = New System.Drawing.Point(121, 39)
        Me.txtQuestion.Name = "txtQuestion"
        Me.txtQuestion.Size = New System.Drawing.Size(241, 20)
        Me.txtQuestion.TabIndex = 0
        '
        'txtCorrect
        '
        Me.txtCorrect.Location = New System.Drawing.Point(121, 104)
        Me.txtCorrect.Name = "txtCorrect"
        Me.txtCorrect.Size = New System.Drawing.Size(241, 20)
        Me.txtCorrect.TabIndex = 1
        '
        'txtWrong1
        '
        Me.txtWrong1.Location = New System.Drawing.Point(121, 152)
        Me.txtWrong1.Name = "txtWrong1"
        Me.txtWrong1.Size = New System.Drawing.Size(241, 20)
        Me.txtWrong1.TabIndex = 2
        '
        'txtWrong2
        '
        Me.txtWrong2.Location = New System.Drawing.Point(121, 189)
        Me.txtWrong2.Name = "txtWrong2"
        Me.txtWrong2.Size = New System.Drawing.Size(241, 20)
        Me.txtWrong2.TabIndex = 3
        '
        'txtWrong3
        '
        Me.txtWrong3.Location = New System.Drawing.Point(121, 218)
        Me.txtWrong3.Name = "txtWrong3"
        Me.txtWrong3.Size = New System.Drawing.Size(241, 20)
        Me.txtWrong3.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(48, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Question"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Correct Answer"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Wrong Answer"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(38, 192)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Wrong Answer"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(38, 225)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Wrong Answer"
        '
        'tbQuestion1
        '
        Me.tbQuestion1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbQuestion1.Controls.Add(Me.tbQuestionMultiple)
        Me.tbQuestion1.Controls.Add(Me.tbQuestionShort)
        Me.tbQuestion1.Location = New System.Drawing.Point(12, 12)
        Me.tbQuestion1.Name = "tbQuestion1"
        Me.tbQuestion1.SelectedIndex = 0
        Me.tbQuestion1.Size = New System.Drawing.Size(412, 392)
        Me.tbQuestion1.TabIndex = 10
        '
        'tbQuestionMultiple
        '
        Me.tbQuestionMultiple.Controls.Add(Me.txtQuestion)
        Me.tbQuestionMultiple.Controls.Add(Me.Label5)
        Me.tbQuestionMultiple.Controls.Add(Me.txtCorrect)
        Me.tbQuestionMultiple.Controls.Add(Me.Label4)
        Me.tbQuestionMultiple.Controls.Add(Me.txtWrong1)
        Me.tbQuestionMultiple.Controls.Add(Me.Label3)
        Me.tbQuestionMultiple.Controls.Add(Me.txtWrong2)
        Me.tbQuestionMultiple.Controls.Add(Me.Label2)
        Me.tbQuestionMultiple.Controls.Add(Me.txtWrong3)
        Me.tbQuestionMultiple.Controls.Add(Me.Label1)
        Me.tbQuestionMultiple.Location = New System.Drawing.Point(4, 22)
        Me.tbQuestionMultiple.Name = "tbQuestionMultiple"
        Me.tbQuestionMultiple.Padding = New System.Windows.Forms.Padding(3)
        Me.tbQuestionMultiple.Size = New System.Drawing.Size(404, 366)
        Me.tbQuestionMultiple.TabIndex = 0
        Me.tbQuestionMultiple.Text = "Multiple Choice"
        Me.tbQuestionMultiple.UseVisualStyleBackColor = True
        '
        'tbQuestionShort
        '
        Me.tbQuestionShort.Controls.Add(Me.Label7)
        Me.tbQuestionShort.Controls.Add(Me.Label6)
        Me.tbQuestionShort.Controls.Add(Me.txtAnswer)
        Me.tbQuestionShort.Controls.Add(Me.txtQuestion1)
        Me.tbQuestionShort.Location = New System.Drawing.Point(4, 22)
        Me.tbQuestionShort.Name = "tbQuestionShort"
        Me.tbQuestionShort.Padding = New System.Windows.Forms.Padding(3)
        Me.tbQuestionShort.Size = New System.Drawing.Size(404, 366)
        Me.tbQuestionShort.TabIndex = 1
        Me.tbQuestionShort.Text = "Short Answer"
        Me.tbQuestionShort.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(20, 74)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Correct Answer"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(41, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Question"
        '
        'txtAnswer
        '
        Me.txtAnswer.Location = New System.Drawing.Point(105, 52)
        Me.txtAnswer.Multiline = True
        Me.txtAnswer.Name = "txtAnswer"
        Me.txtAnswer.Size = New System.Drawing.Size(269, 103)
        Me.txtAnswer.TabIndex = 1
        '
        'txtQuestion1
        '
        Me.txtQuestion1.Location = New System.Drawing.Point(105, 15)
        Me.txtQuestion1.Name = "txtQuestion1"
        Me.txtQuestion1.Size = New System.Drawing.Size(269, 20)
        Me.txtQuestion1.TabIndex = 0
        '
        'QuestionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(436, 416)
        Me.Controls.Add(Me.tbQuestion1)
        Me.Name = "QuestionForm"
        Me.Text = "Question Form"
        Me.tbQuestion1.ResumeLayout(False)
        Me.tbQuestionMultiple.ResumeLayout(False)
        Me.tbQuestionMultiple.PerformLayout()
        Me.tbQuestionShort.ResumeLayout(False)
        Me.tbQuestionShort.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtQuestion As TextBox
    Friend WithEvents txtCorrect As TextBox
    Friend WithEvents txtWrong1 As TextBox
    Friend WithEvents txtWrong2 As TextBox
    Friend WithEvents txtWrong3 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents tbQuestion1 As TabControl
    Friend WithEvents tbQuestionMultiple As TabPage
    Friend WithEvents tbQuestionShort As TabPage
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtAnswer As TextBox
    Friend WithEvents txtQuestion1 As TextBox
End Class
