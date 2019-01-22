Public Class frmLab7



    Private Sub txtAdd_TextChanged(sender As Object, e As EventArgs) Handles txtAdd.TextChanged
        If txtAdd.TextLength Then
            btnAdd.Enabled = True
        Else
            btnAdd.Enabled = False
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        lstAdd.Items.Add(txtAdd.Text)
        txtAdd.Clear()
        lstAdd.SelectedIndex = lstAdd.Items.Count - 1


    End Sub

    Private Sub btnMove_Click(sender As Object, e As EventArgs) Handles btnMove.Click
        Dim a As Integer = lstAdd.SelectedIndex
        Dim n As Integer

        If lstAdd.Items.Count = 0 Then
            MessageBox.Show("ไม่มีข้อมูล")

            Exit Sub

        End If

        cboOutput.Items.Add(lstAdd.SelectedItem)
        n = cboOutput.Items.Count
        cboOutput.SelectedIndex = n - 1
        lstAdd.Items.RemoveAt(a)

        If lstAdd.Items.Count <> 0 Then
            If lstAdd.Items.Count <= a Then
                lstAdd.SelectedIndex = lstAdd.Items.Count - 1
            Else
                lstAdd.SelectedIndex = a
            End If


        End If


    End Sub

    Private Sub btnMoveAll_Click(sender As Object, e As EventArgs) Handles btnMoveAll.Click
        Dim i As Integer
        If lstAdd.Items.Count = 0 Then
            MessageBox.Show("ไม่มีข้อมูล")

            Exit Sub

        End If
        For i = 0 To lstAdd.Items.Count - 1
            cboOutput.Items.Add(lstAdd.Items(i))

        Next i
        lstAdd.Items.Clear()

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim a As Integer = cboOutput.SelectedIndex
        Dim n As Integer

        If cboOutput.Items.Count = 0 Then
            MessageBox.Show("ไม่มีข้อมูล")

            Exit Sub

        End If

        lstAdd.Items.Add(cboOutput.SelectedItem)
        n = lstAdd.Items.Count
        lstAdd.SelectedIndex = n - 1
        cboOutput.Items.RemoveAt(a)

        If cboOutput.Items.Count <> 0 Then
            If cboOutput.Items.Count <= a Then
                cboOutput.SelectedIndex = cboOutput.Items.Count - 1
            Else
                cboOutput.SelectedIndex = a
            End If


        End If
    End Sub

    Private Sub btnBackAll_Click(sender As Object, e As EventArgs) Handles btnBackAll.Click
        Dim i As Integer
        If cboOutput.Items.Count = 0 Then
            MessageBox.Show("ไม่มีข้อมูล")

            Exit Sub

        End If
        For i = 0 To cboOutput.Items.Count - 1
            lstAdd.Items.Add(cboOutput.Items(i))

        Next i
        cboOutput.Items.Clear()
    End Sub

    Private Sub cboOutput_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboOutput.SelectedIndexChanged
        lblOutput.Text = cboOutput.Text

    End Sub

    Private Sub btExit_Click(sender As Object, e As EventArgs) Handles btExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lstAdd.Items.Clear()
        cboOutput.Items.Clear()
        cboOutput.Text = ""

        lblOutput.Text = ""

    End Sub
End Class