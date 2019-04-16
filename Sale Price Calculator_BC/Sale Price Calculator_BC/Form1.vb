Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim decOriginalPrice As Decimal = 0        ' Origional price
        Dim decDiscountPercentage As Decimal = 0    ' Dsicount perecentage
        Dim decDiscountAmount As Decimal = 0        ' Amount of discount
        Dim decSalePrice As Decimal = 0             ' Sale Price

        ' Get the item's original price.
        decOriginalPrice = CDec(txtOriginalPrice.Text)

        ' Get the discount percentage.
        decDiscountPercentage = CDec(txtDiscountPercentage.Text)

        ' Move the percentage's decimal point to the left 2 spaces.
        decDiscountPercentage = decDiscountPercentage / 100

        ' Calculate the amountf the discount.
        decDiscountAmount = decOriginalPrice * decDiscountPercentage

        ' Calculate the sale price.
        decSalePrice = decOriginalPrice - decDiscountAmount

        ' Display the sale price.
        lblSalePrice.Text = decSalePrice.ToString("c")


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
