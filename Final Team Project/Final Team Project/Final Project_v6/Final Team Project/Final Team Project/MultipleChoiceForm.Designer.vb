<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MultipleChoiceForm
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
        Me.components = New System.ComponentModel.Container()
        Me.lblQuestion = New System.Windows.Forms.Label()
        Me.radAnswer1 = New System.Windows.Forms.RadioButton()
        Me.radAnswer2 = New System.Windows.Forms.RadioButton()
        Me.radAnswer3 = New System.Windows.Forms.RadioButton()
        Me.radAnswer4 = New System.Windows.Forms.RadioButton()
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.tmrQTImer2 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'lblQuestion
        '
        Me.lblQuestion.AutoSize = True
        Me.lblQuestion.Location = New System.Drawing.Point(26, 24)
        Me.lblQuestion.Name = "lblQuestion"
        Me.lblQuestion.Size = New System.Drawing.Size(39, 13)
        Me.lblQuestion.TabIndex = 0
        Me.lblQuestion.Text = "Label1"
        '
        'radAnswer1
        '
        Me.radAnswer1.AutoSize = True
        Me.radAnswer1.Location = New System.Drawing.Point(72, 56)
        Me.radAnswer1.Name = "radAnswer1"
        Me.radAnswer1.Size = New System.Drawing.Size(90, 17)
        Me.radAnswer1.TabIndex = 1
        Me.radAnswer1.TabStop = True
        Me.radAnswer1.Text = "RadioButton1"
        Me.radAnswer1.UseVisualStyleBackColor = True
        '
        'radAnswer2
        '
        Me.radAnswer2.AutoSize = True
        Me.radAnswer2.Location = New System.Drawing.Point(72, 79)
        Me.radAnswer2.Name = "radAnswer2"
        Me.radAnswer2.Size = New System.Drawing.Size(90, 17)
        Me.radAnswer2.TabIndex = 2
        Me.radAnswer2.TabStop = True
        Me.radAnswer2.Text = "RadioButton2"
        Me.radAnswer2.UseVisualStyleBackColor = True
        '
        'radAnswer3
        '
        Me.radAnswer3.AutoSize = True
        Me.radAnswer3.Location = New System.Drawing.Point(72, 102)
        Me.radAnswer3.Name = "radAnswer3"
        Me.radAnswer3.Size = New System.Drawing.Size(90, 17)
        Me.radAnswer3.TabIndex = 3
        Me.radAnswer3.TabStop = True
        Me.radAnswer3.Text = "RadioButton3"
        Me.radAnswer3.UseVisualStyleBackColor = True
        '
        'radAnswer4
        '
        Me.radAnswer4.AutoSize = True
        Me.radAnswer4.Location = New System.Drawing.Point(72, 125)
        Me.radAnswer4.Name = "radAnswer4"
        Me.radAnswer4.Size = New System.Drawing.Size(90, 17)
        Me.radAnswer4.TabIndex = 4
        Me.radAnswer4.TabStop = True
        Me.radAnswer4.Text = "RadioButton4"
        Me.radAnswer4.UseVisualStyleBackColor = True
        '
        'btnCheck
        '
        Me.btnCheck.Location = New System.Drawing.Point(29, 160)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(95, 23)
        Me.btnCheck.TabIndex = 5
        Me.btnCheck.Text = "Check Answer"
        Me.btnCheck.UseVisualStyleBackColor = True
        '
        'tmrQTImer2
        '
        '
        'MultipleChoiceForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(243, 195)
        Me.Controls.Add(Me.btnCheck)
        Me.Controls.Add(Me.radAnswer4)
        Me.Controls.Add(Me.radAnswer3)
        Me.Controls.Add(Me.radAnswer2)
        Me.Controls.Add(Me.radAnswer1)
        Me.Controls.Add(Me.lblQuestion)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MultipleChoiceForm"
        Me.Text = "The Best ""Bored"" Game"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblQuestion As Label
    Friend WithEvents radAnswer1 As RadioButton
    Friend WithEvents radAnswer2 As RadioButton
    Friend WithEvents radAnswer3 As RadioButton
    Friend WithEvents radAnswer4 As RadioButton
    Friend WithEvents btnCheck As Button
    Friend WithEvents tmrQTImer2 As Timer
End Class
