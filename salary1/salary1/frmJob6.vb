Public Class frmJob6

    Dim price, total, add1, add2, add3, add4, free1, free2, free3 As Double

    Private Sub chkFree2_Click(sender As Object, e As EventArgs) Handles chkFree2.Click
        If chkFree2.Checked Then
            total = total - free2
        Else
            total = total + free2
        End If
        lblPaidPrice.Text = total
    End Sub

    Private Sub chkCarForMe_Click(sender As Object, e As EventArgs) Handles chkCarForMe.Click
        GroupBox1.Enabled = True
        GroupBox2.Enabled = True


        If chkCarForMe.Checked Then
            total = price + free1 + free2 + free3
            lblPaidPrice.Text = total
        Else

            If MessageBox.Show("ต้องการลบข้อมูลหรือไม่?", "ยืนยันการลบข้อมูล", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then

                chkFree1.Checked = False
                chkFree2.Checked = False
                chkFree3.Checked = False
                chkItemsAdd1.Checked = False
                chkItemsAdd2.Checked = False
                chkItemsAdd3.Checked = False
                chkItemsAdd4.Checked = False


                GroupBox1.Enabled = False
                GroupBox2.Enabled = False
                lblPaidPrice.Text = ""
            Else
                chkCarForMe.Checked = True

                Exit Sub
            End If
        End If

    End Sub

    Private Sub chkFree3_Click(sender As Object, e As EventArgs) Handles chkFree3.Click
        If chkFree3.Checked Then
            total = total - free3
        Else
            total = total + free3
        End If
        lblPaidPrice.Text = total
    End Sub

    Private Sub chkFree1_Click(sender As Object, e As EventArgs) Handles chkFree1.Click
        If chkFree1.Checked Then
            total = total - free1
        Else
            total = total + free1
        End If
        lblPaidPrice.Text = total

    End Sub

    Private Sub frmJob6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        price = Val(lblStartPrice.Text)
        add1 = Val(lblItemsPrice1.Text)
        add2 = Val(lblItemsPrice2.Text)
        add3 = Val(lblItemsPrice3.Text)
        add4 = Val(lblItemsPrice4.Text)
        free1 = Val(lblFree1.Text)
        free2 = Val(lblFree2.Text)
        free3 = Val(lblFree3.Text)


    End Sub

    Private Sub chkItemsAdd1_CheckedChanged(sender As Object, e As EventArgs) Handles chkItemsAdd1.CheckedChanged

    End Sub


    Private Sub chkItemsAdd1_Click(sender As Object, e As EventArgs) Handles chkItemsAdd1.Click
        If chkItemsAdd1.Checked Then
            total = total + add1
        Else
            total = total - add1
        End If
        lblPaidPrice.Text = total
    End Sub

    Private Sub chkItemsAdd2_Click(sender As Object, e As EventArgs) Handles chkItemsAdd2.Click
        If chkItemsAdd2.Checked Then
            total = total + add2
        Else
            total = total - add2
        End If
        lblPaidPrice.Text = total
    End Sub

    Private Sub chkItemsAdd3_Click(sender As Object, e As EventArgs) Handles chkItemsAdd3.Click
        If chkItemsAdd3.Checked Then
            total = total + add3
        Else
            total = total - add3
        End If
        lblPaidPrice.Text = total
    End Sub

    Private Sub chkItemsAdd4_Click(sender As Object, e As EventArgs) Handles chkItemsAdd4.Click
        If chkItemsAdd4.Checked Then
            total = total + add4
        Else
            total = total - add4
        End If
        lblPaidPrice.Text = total
    End Sub
End Class