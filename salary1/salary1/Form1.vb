Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btncal.Click

        lblsalary.Text = txtsalary.Text * 12
        lblvat.Text = lblsalary.Text * 0.05
        lblTotalsalary.Text = lblsalary.Text - lblvat.Text








    End Sub
End Class
