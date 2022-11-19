Public Class Start
    Private Sub BS_Click(sender As Object, e As EventArgs) Handles BS.Click
        Dim num_back As Long = 0
        Try
            num_back = CLng(TB.Text)
        Catch ex As Exception
            MessageBox.Show("数字を入力して下さい。", "ワーキングメモリートレーニング", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try
        If num_back < 1 Then
            MessageBox.Show("1以上の数字を入力して下さい。", "ワーキングメモリートレーニング", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        Hide()
        Dim formTraining As New Training
        formTraining.curLev = num_back
        formTraining.T.Start()
        formTraining.ShowDialog()
        formTraining.Dispose()
        Show()
    End Sub

    Private Sub TB_KeyDown(sender As Object, e As KeyEventArgs) Handles TB.KeyDown
        If e.KeyCode = Keys.Enter Then
            BS.PerformClick()
        End If
    End Sub

    Private Sub TB_Enter(sender As Object, e As EventArgs) Handles TB.Enter
        TB.SelectAll()
    End Sub
End Class