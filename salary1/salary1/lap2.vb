Public Class lap2
    Private Sub btnCal_Click(sender As Object, e As EventArgs) Handles btnCal.Click
        Dim Computer As Double
        Dim Printer As Double
        Dim SumSale As Double
        Dim CommisCom As Double
        Dim CommisPrinter As Double
        Dim SumCommission As Double

        Computer = txtSaleAcer.Text
        Printer = txtSaleHP.Text
        SumSale = Computer + Printer
        CommisCom = Computer * 0.05
        CommisPrinter = Printer * 0.1
        SumCommission = CommisCom + CommisPrinter


        lblTotalCom.Text = SumCommission
        lblTotalSale.Text = SumSale
        lblComAcer.Text = CommisCom
        lblComHP.Text = CommisPrinter
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class