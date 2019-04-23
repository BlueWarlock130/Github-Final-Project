<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnQuestions = New System.Windows.Forms.Button()
        Me.btnDescription = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MV Boli", 21.75!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(362, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "The Best ""Bored"" Game"
        '
        'btnQuestions
        '
        Me.btnQuestions.BackColor = System.Drawing.Color.Lime
        Me.btnQuestions.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuestions.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnQuestions.Location = New System.Drawing.Point(115, 74)
        Me.btnQuestions.Name = "btnQuestions"
        Me.btnQuestions.Size = New System.Drawing.Size(153, 58)
        Me.btnQuestions.TabIndex = 1
        Me.btnQuestions.Text = "Add Questions"
        Me.btnQuestions.UseVisualStyleBackColor = False
        '
        'btnDescription
        '
        Me.btnDescription.BackColor = System.Drawing.Color.Lime
        Me.btnDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDescription.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnDescription.Location = New System.Drawing.Point(115, 175)
        Me.btnDescription.Name = "btnDescription"
        Me.btnDescription.Size = New System.Drawing.Size(153, 58)
        Me.btnDescription.TabIndex = 2
        Me.btnDescription.Text = "Description"
        Me.btnDescription.UseVisualStyleBackColor = False
        '
        'MenuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Red
        Me.ClientSize = New System.Drawing.Size(385, 281)
        Me.Controls.Add(Me.btnDescription)
        Me.Controls.Add(Me.btnQuestions)
        Me.Controls.Add(Me.Label1)
        Me.Name = "MenuForm"
        Me.Text = "The Best ""Bored"" Game"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnQuestions As Button
    Friend WithEvents btnDescription As Button
End Class
