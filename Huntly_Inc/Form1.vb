Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        'Closes the application:
        Me.Close()

    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click

        'Declares the variables:
        Dim dblGrossProfitRatio As Double
        Dim dblGrossProfit As Double
        Dim dblNetSales As Double

        Dim dblGrossSales As Double
        Dim dblSalesReturns As Double
        Dim dblCostOfGoodsSold As Double

        'Assigns variables to text boxes:
        Double.TryParse(txtCostOfGoodsSold.Text, dblCostOfGoodsSold)
        Double.TryParse(txtGrossSales.Text, dblGrossSales)
        Double.TryParse(txtSalesReturns.Text, dblSalesReturns)

        'Calculates:
        dblNetSales = dblGrossSales - dblSalesReturns
        dblGrossProfit = dblNetSales - dblCostOfGoodsSold
        dblGrossProfitRatio = dblGrossProfit / dblNetSales

        'Displays Gross Profit Ratio:

    End Sub
End Class
