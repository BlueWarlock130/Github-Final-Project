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
        Me.tbQuestions = New System.Windows.Forms.TabControl()
        Me.tbQuestionMultiple = New System.Windows.Forms.TabPage()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtWrong3 = New System.Windows.Forms.TextBox()
        Me.txtWrong2 = New System.Windows.Forms.TextBox()
        Me.txtWrong1 = New System.Windows.Forms.TextBox()
        Me.txtCorrect = New System.Windows.Forms.TextBox()
        Me.txtQuestion = New System.Windows.Forms.TextBox()
        Me.tbQuestionShort = New System.Windows.Forms.TabPage()
        Me.txtAnswer = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtShortQuestion = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblQuestionNumber = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.tbQuestions.SuspendLayout()
        Me.tbQuestionMultiple.SuspendLayout()
        Me.tbQuestionShort.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbQuestions
        '
        Me.tbQuestions.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbQuestions.Controls.Add(Me.tbQuestionMultiple)
        Me.tbQuestions.Controls.Add(Me.tbQuestionShort)
        Me.tbQuestions.Location = New System.Drawing.Point(12, 39)
        Me.tbQuestions.Name = "tbQuestions"
        Me.tbQuestions.SelectedIndex = 0
        Me.tbQuestions.Size = New System.Drawing.Size(386, 269)
        Me.tbQuestions.TabIndex = 10
        '
        'tbQuestionMultiple
        '
        Me.tbQuestionMultiple.Controls.Add(Me.Label5)
        Me.tbQuestionMultiple.Controls.Add(Me.Label4)
        Me.tbQuestionMultiple.Controls.Add(Me.Label3)
        Me.tbQuestionMultiple.Controls.Add(Me.Label2)
        Me.tbQuestionMultiple.Controls.Add(Me.Label1)
        Me.tbQuestionMultiple.Controls.Add(Me.txtWrong3)
        Me.tbQuestionMultiple.Controls.Add(Me.txtWrong2)
        Me.tbQuestionMultiple.Controls.Add(Me.txtWrong1)
        Me.tbQuestionMultiple.Controls.Add(Me.txtCorrect)
        Me.tbQuestionMultiple.Controls.Add(Me.txtQuestion)
        Me.tbQuestionMultiple.Location = New System.Drawing.Point(4, 22)
        Me.tbQuestionMultiple.Name = "tbQuestionMultiple"
        Me.tbQuestionMultiple.Padding = New System.Windows.Forms.Padding(3)
        Me.tbQuestionMultiple.Size = New System.Drawing.Size(378, 243)
        Me.tbQuestionMultiple.TabIndex = 0
        Me.tbQuestionMultiple.Text = "Multiple Choice"
        Me.tbQuestionMultiple.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 201)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Wrong Answer"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 168)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Wrong Answer"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Wrong Answer"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Correct Answer"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Question"
        '
        'txtWrong3
        '
        Me.txtWrong3.Location = New System.Drawing.Point(95, 194)
        Me.txtWrong3.Name = "txtWrong3"
        Me.txtWrong3.Size = New System.Drawing.Size(241, 20)
        Me.txtWrong3.TabIndex = 14
        '
        'txtWrong2
        '
        Me.txtWrong2.Location = New System.Drawing.Point(95, 165)
        Me.txtWrong2.Name = "txtWrong2"
        Me.txtWrong2.Size = New System.Drawing.Size(241, 20)
        Me.txtWrong2.TabIndex = 13
        '
        'txtWrong1
        '
        Me.txtWrong1.Location = New System.Drawing.Point(95, 128)
        Me.txtWrong1.Name = "txtWrong1"
        Me.txtWrong1.Size = New System.Drawing.Size(241, 20)
        Me.txtWrong1.TabIndex = 12
        '
        'txtCorrect
        '
        Me.txtCorrect.Location = New System.Drawing.Point(95, 80)
        Me.txtCorrect.Name = "txtCorrect"
        Me.txtCorrect.Size = New System.Drawing.Size(241, 20)
        Me.txtCorrect.TabIndex = 11
        '
        'txtQuestion
        '
        Me.txtQuestion.Location = New System.Drawing.Point(95, 15)
        Me.txtQuestion.Name = "txtQuestion"
        Me.txtQuestion.Size = New System.Drawing.Size(241, 20)
        Me.txtQuestion.TabIndex = 10
        '
        'tbQuestionShort
        '
        Me.tbQuestionShort.Controls.Add(Me.txtAnswer)
        Me.tbQuestionShort.Controls.Add(Me.Label7)
        Me.tbQuestionShort.Controls.Add(Me.txtShortQuestion)
        Me.tbQuestionShort.Controls.Add(Me.Label6)
        Me.tbQuestionShort.Location = New System.Drawing.Point(4, 22)
        Me.tbQuestionShort.Name = "tbQuestionShort"
        Me.tbQuestionShort.Padding = New System.Windows.Forms.Padding(3)
        Me.tbQuestionShort.Size = New System.Drawing.Size(378, 243)
        Me.tbQuestionShort.TabIndex = 1
        Me.tbQuestionShort.Text = "Short Answer"
        Me.tbQuestionShort.UseVisualStyleBackColor = True
        '
        'txtAnswer
        '
        Me.txtAnswer.Location = New System.Drawing.Point(73, 65)
        Me.txtAnswer.Multiline = True
        Me.txtAnswer.Name = "txtAnswer"
        Me.txtAnswer.Size = New System.Drawing.Size(288, 140)
        Me.txtAnswer.TabIndex = 19
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(25, 65)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Answer"
        '
        'txtShortQuestion
        '
        Me.txtShortQuestion.Location = New System.Drawing.Point(73, 14)
        Me.txtShortQuestion.Name = "txtShortQuestion"
        Me.txtShortQuestion.Size = New System.Drawing.Size(288, 20)
        Me.txtShortQuestion.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Question"
        '
        'lblQuestionNumber
        '
        Me.lblQuestionNumber.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblQuestionNumber.Location = New System.Drawing.Point(361, 9)
        Me.lblQuestionNumber.Name = "lblQuestionNumber"
        Me.lblQuestionNumber.Size = New System.Drawing.Size(24, 23)
        Me.lblQuestionNumber.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(263, 13)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(92, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Question Number:"
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(12, 11)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(94, 22)
        Me.btnNext.TabIndex = 13
        Me.btnNext.Text = "Next Question"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(111, 11)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(91, 22)
        Me.btnSave.TabIndex = 14
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'QuestionForm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(410, 320)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblQuestionNumber)
        Me.Controls.Add(Me.tbQuestions)
        Me.Name = "QuestionForm1"
        Me.Text = "Question Form"
        Me.tbQuestions.ResumeLayout(False)
        Me.tbQuestionMultiple.ResumeLayout(False)
        Me.tbQuestionMultiple.PerformLayout()
        Me.tbQuestionShort.ResumeLayout(False)
        Me.tbQuestionShort.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbQuestions As TabControl
    Friend WithEvents tbQuestionMultiple As TabPage
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtWrong3 As TextBox
    Friend WithEvents txtWrong2 As TextBox
    Friend WithEvents txtWrong1 As TextBox
    Friend WithEvents txtCorrect As TextBox
    Friend WithEvents txtQuestion As TextBox
    Friend WithEvents tbQuestionShort As TabPage
    Friend WithEvents Label6 As Label
    Friend WithEvents txtAnswer As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtShortQuestion As TextBox
    Friend WithEvents lblQuestionNumber As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents btnNext As Button
    Friend WithEvents btnSave As Button
End Class
