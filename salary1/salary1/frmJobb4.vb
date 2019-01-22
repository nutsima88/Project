Public Class frmJobb4
    Dim decR_BONUS As Decimal = 0.2, decR_ALLOW As Decimal = 0.01, decR_TAX As Decimal = 0.07
    Dim datNowDate As Date = Date.Now
    Dim dblYearSalary, dblBonus, dblAllIncome, dblAllowance, dblTax As Double

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub radLongDate_CheckedChanged(sender As Object, e As EventArgs) Handles radLongDate.CheckedChanged
        lblDate.Text = datNowDate.ToLongDateString
    End Sub

    Private Sub radGenneralDate_CheckedChanged(sender As Object, e As EventArgs) Handles radGenneralDate.CheckedChanged
        lblDate.Text = datNowDate
    End Sub

    Private Sub radShortDate_CheckedChanged(sender As Object, e As EventArgs) Handles radShortDate.CheckedChanged
        lblDate.Text = datNowDate.ToShortDateString
    End Sub

    Private Sub btnCalTax_Click(sender As Object, e As EventArgs) Handles btnCalTax.Click



        dblYearSalary = txtSalary.Text * 12
        dblBonus = txtSale.Text * decR_BONUS
        dblAllIncome = dblYearSalary + dblBonus
        dblAllowance = dblAllIncome * decR_ALLOW
        dblTax = (dblAllIncome - dblAllowance) * decR_TAX


        lblYearSalary.Text = FormatNumber(dblYearSalary)
        lblBonus.Text = FormatNumber(dblBonus)
        lblAllIncome.Text = FormatNumber(dblAllIncome)
        lblAllowance.Text = FormatNumber(dblAllowance)
        lblTax.Text = FormatNumber(dblTax)




    End Sub

    Private Sub frmJobb4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblDate.Text = datNowDate

    End Sub
End Class