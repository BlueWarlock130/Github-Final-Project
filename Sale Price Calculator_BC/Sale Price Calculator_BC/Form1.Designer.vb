<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtOriginalPrice = New System.Windows.Forms.TextBox()
        Me.txtDiscountPercentage = New System.Windows.Forms.TextBox()
        Me.lblSalePrice = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter the item's original price:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(151, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Enter the item's discount price:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(106, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Sale Price:"
        '
        'txtOriginalPrice
        '
        Me.txtOriginalPrice.Location = New System.Drawing.Point(172, 15)
        Me.txtOriginalPrice.Name = "txtOriginalPrice"
        Me.txtOriginalPrice.Size = New System.Drawing.Size(100, 20)
        Me.txtOriginalPrice.TabIndex = 3
        '
        'txtDiscountPercentage
        '
        Me.txtDiscountPercentage.Location = New System.Drawing.Point(172, 46)
        Me.txtDiscountPercentage.Name = "txtDiscountPercentage"
        Me.txtDiscountPercentage.Size = New System.Drawing.Size(100, 20)
        Me.txtDiscountPercentage.TabIndex = 4
        '
        'lblSalePrice
        '
        Me.lblSalePrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSalePrice.Location = New System.Drawing.Point(172, 77)
        Me.lblSalePrice.Name = "lblSalePrice"
        Me.lblSalePrice.Size = New System.Drawing.Size(100, 21)
        Me.lblSalePrice.TabIndex = 5
        Me.lblSalePrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(53, 124)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(80, 34)
        Me.btnCalculate.TabIndex = 6
        Me.btnCalculate.Text = "Calculate Sale Price"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(156, 124)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(80, 34)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 181)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblSalePrice)
        Me.Controls.Add(Me.txtDiscountPercentage)
        Me.Controls.Add(Me.txtOriginalPrice)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Sale Price Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtOriginalPrice As TextBox
    Friend WithEvents txtDiscountPercentage As TextBox
    Friend WithEvents lblSalePrice As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnExit As Button
End Class
