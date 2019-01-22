Public Class frmLab5
    Dim decTotal, decDiscount, decNet, decCredit As Decimal

    Private Sub redOther_CheckedChanged(sender As Object, e As EventArgs) Handles radOther.CheckedChanged
        lblDiscount.Text = ""
        lblPaid.Text = ""
        lblCredit.Text = ""
        gbPaid.Enabled = False
        radPaid.Checked = True

    End Sub

    Private Sub radPaid_CheckedChanged(sender As Object, e As EventArgs) Handles radPaid.CheckedChanged
        lblDiscount.Text = ""
        lblPaid.Text = ""
        lblCredit.Text = ""

    End Sub

    Private Sub radCredit_CheckedChanged(sender As Object, e As EventArgs) Handles radCredit.CheckedChanged
        lblDiscount.Text = ""
        lblPaid.Text = ""
        lblCredit.Text = ""
    End Sub

    Private Sub radMember_CheckedChanged(sender As Object, e As EventArgs) Handles radMember.CheckedChanged
        lblDiscount.Text = ""
        lblPaid.Text = ""
        lblCredit.Text = ""
        gbPaid.Enabled = True

    End Sub

    Private Sub txtUnit_TextChanged(sender As Object, e As EventArgs) Handles txtUnit.TextChanged
        lblTotal.Text = txtPrice.Text * txtUnit.Text
        decTotal = lblTotal.Text
    End Sub



    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim L1 As String = txtProduct.Text
        Dim L2 As Integer = Val(txtPrice.Text)
        Dim L3 As Integer = Val(txtUnit.Text)
        decDiscount = 0
        lblTotal.Text = txtPrice.Text * txtUnit.Text
        If L1 = "" Or L2 <= 0 Or L3 <= 0 Then
            MessageBox.Show(“ป้อนขอ้มูลไม่สมบูรณ์”)
        Else
            If radMember.Checked = True And radPaid.Checked = True Then
                If decTotal < 1000 Then
                    decDiscount = 0
                ElseIf decTotal < 5000 Then
                    decDiscount = decTotal * 0.05
                ElseIf decTotal < 10000 Then
                    decDiscount = decTotal * 0.1
                Else
                    decDiscount = decTotal * 0.15
                End If



            Else

                If radCredit.Checked Then
                    decCredit = decTotal
                    decNet = decTotal
                Else
                    decCredit = 0

                End If
                decNet = decTotal - decDiscount
            End If


        End If

        lblDiscount.Text = decDiscount
        lblPaid.Text = decNet
        lblCredit.Text = decCredit

    End Sub
End Class
