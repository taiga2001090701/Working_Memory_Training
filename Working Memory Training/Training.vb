Public Class Training
    Public curLev As Long
    Dim curSte, curMem, totSte As Long
    Dim c_cor As Long
    Dim c_mem As New Queue()
    Dim r As New Random()
    Dim c_sel(2) As Byte
    Dim c_ans As Byte

    Private Sub Training_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LCW1.Hide()
        LCW2.Hide()
        LCW3.Hide()
    End Sub

    Private Sub T_Tick(sender As Object, e As EventArgs) Handles T.Tick
        T.Stop()
        curSte = 0
        curMem = 0
        c_cor = 0
        totSte = 20 + curLev * 2
        LT.Text = curLev & "バック"
        ResultView(False)
        NextCard()
    End Sub

    Private Sub BM_Click(sender As Object, e As EventArgs) Handles BM.Click
        NextCard()
    End Sub

    Private Sub PBS1_Click(sender As Object, e As EventArgs) Handles PBS1.Click
        If c_ans = 1 Then
            c_cor += 1
            LCW1.Text = "○"
            LCW1.Show()
            Refresh()
            Threading.Thread.Sleep(500)
            LCW1.Hide()
        Else
            LCW1.Text = "×"
            If c_ans = 2 Then
                LCW2.Text = "○"
                LCW1.Show()
                LCW2.Show()
                Refresh()
                Threading.Thread.Sleep(500)
                LCW1.Hide()
                LCW2.Hide()
            Else
                LCW3.Text = "○"
                LCW1.Show()
                LCW3.Show()
                Refresh()
                Threading.Thread.Sleep(500)
                LCW1.Hide()
                LCW3.Hide()
            End If
        End If
        NextCard()
    End Sub

    Private Sub PBS2_Click(sender As Object, e As EventArgs) Handles PBS2.Click
        If c_ans = 2 Then
            c_cor += 1
            LCW2.Text = "○"
            LCW2.Show()
            Refresh()
            Threading.Thread.Sleep(500)
            LCW2.Hide()
        Else
            LCW2.Text = "×"
            If c_ans = 1 Then
                LCW1.Text = "○"
                LCW2.Show()
                LCW1.Show()
                Refresh()
                Threading.Thread.Sleep(500)
                LCW2.Hide()
                LCW1.Hide()
            Else
                LCW3.Text = "○"
                LCW2.Show()
                LCW3.Show()
                Refresh()
                Threading.Thread.Sleep(500)
                LCW2.Hide()
                LCW3.Hide()
            End If
        End If
        NextCard()
    End Sub

    Private Sub PBS3_Click(sender As Object, e As EventArgs) Handles PBS3.Click
        If c_ans = 3 Then
            c_cor += 1
            LCW3.Text = "○"
            LCW3.Show()
            Refresh()
            Threading.Thread.Sleep(500)
            LCW3.Hide()
        Else
            LCW3.Text = "×"
            If c_ans = 2 Then
                LCW2.Text = "○"
                LCW3.Show()
                LCW2.Show()
                Refresh()
                Threading.Thread.Sleep(500)
                LCW3.Hide()
                LCW2.Hide()
            Else
                LCW1.Text = "○"
                LCW3.Show()
                LCW1.Show()
                Refresh()
                Threading.Thread.Sleep(500)
                LCW3.Hide()
                LCW1.Hide()
            End If
        End If
        NextCard()
    End Sub

    Private Sub BC_Click(sender As Object, e As EventArgs) Handles BC.Click
        T.Start()
    End Sub

    Private Sub BE_Click(sender As Object, e As EventArgs) Handles BE.Click
        Close()
    End Sub

    Sub NextCard()
        Select Case curSte
            Case 0
                ChangeView(1)
            Case curLev
                ChangeView(2)
            Case totSte
                ChangeView(3)
        End Select
        If curMem = totSte Then
            ChangeView(4)
            Dim ap As Long = Math.Round(c_cor / totSte * 100)
            LR1.Text = "正答数 " & c_cor & "/" & totSte
            LR2.Text = "正答率 " & ap & "%"
            If curLev = 1 Then
                If ap < 85 Then
                    LR3.Text = "84%以下のため"
                    LR4.Text = "レベルすえおき"
                    LR5.Text = curLev & "バック ⇒ " & curLev & "バック"
                Else
                    LR3.Text = "85%以上のため"
                    LR4.Text = "レベルアップ"
                    LR5.Text = curLev & "バック ⇒ " & curLev + 1 & "バック"
                    curLev += 1
                End If
            Else
                If ap < 65 Then
                    LR3.Text = "64%以下のため"
                    LR4.Text = "レベルダウン"
                    LR5.Text = curLev & "バック ⇒ " & curLev - 1 & "バック"
                    curLev -= 1
                ElseIf ap < 85 Then
                    LR3.Text = "65～84%のため"
                    LR4.Text = "レベルすえおき"
                    LR5.Text = curLev & "バック ⇒ " & curLev & "バック"
                Else
                    LR3.Text = "85%以上のため"
                    LR4.Text = "レベルアップ"
                    LR5.Text = curLev & "バック ⇒ " & curLev + 1 & "バック"
                    curLev += 1
                End If
            End If
            LR1.Show()
            Refresh()
            Threading.Thread.Sleep(1000)
            LR2.Show()
            Refresh()
            Threading.Thread.Sleep(1000)
            LR3.Show()
            Refresh()
            Threading.Thread.Sleep(1000)
            LR4.Show()
            Refresh()
            Threading.Thread.Sleep(1000)
            LR5.Show()
            Refresh()
            Threading.Thread.Sleep(1000)
            BC.Show()
            BE.Show()
            Exit Sub
        End If
        If curSte < totSte Then
            curSte += 1
            Dim rt As Byte = r.Next(1, 7)
            c_mem.Enqueue(rt)
            PBM.Image = GetCardFromNum(rt)
        End If
        If curSte > curLev Then
            curMem += 1
            Dim ct1 As Byte = c_mem.Dequeue
            Dim ct2 As Byte
            Do
                ct2 = r.Next(1, 7)
                If ct2 <> ct1 Then
                    Exit Do
                End If
            Loop
            Dim ct3 As Byte
            Do
                ct3 = r.Next(1, 7)
                If ct3 <> ct1 AndAlso ct3 <> ct2 Then
                    Exit Do
                End If
            Loop
            Select Case r.Next(1, 4)
                Case 1
                    PBS1.Image = GetCardFromNum(ct1)
                    PBS2.Image = GetCardFromNum(ct2)
                    PBS3.Image = GetCardFromNum(ct3)
                    c_ans = 1
                Case 2
                    PBS2.Image = GetCardFromNum(ct1)
                    PBS1.Image = GetCardFromNum(ct2)
                    PBS3.Image = GetCardFromNum(ct3)
                    c_ans = 2
                Case 3
                    PBS3.Image = GetCardFromNum(ct1)
                    PBS1.Image = GetCardFromNum(ct2)
                    PBS2.Image = GetCardFromNum(ct3)
                    c_ans = 3
            End Select
        End If
        ChangeStep()
    End Sub

    Function GetCardFromNum(n As Byte) As Bitmap
        Select Case n
            Case 1
                Return My.Resources.Card1
            Case 2
                Return My.Resources.Card2
            Case 3
                Return My.Resources.Card3
            Case 4
                Return My.Resources.Card4
            Case 5
                Return My.Resources.Card5
            Case 6
                Return My.Resources.Card6
            Case Else
                Return Nothing
        End Select
    End Function

    Sub ChangeStep()
        LS.Text = curSte & "/" & totSte
        LM.Text = curMem & "番目のカードを選択して下さい"
    End Sub

    Sub ChangeView(s As Byte)
        Select Case s
            Case 1
                PBM.Show()
                LS.Show()
                LM.Hide()
                PBS1.Hide()
                PBS2.Hide()
                PBS3.Hide()
                BM.Show()
            Case 2
                PBM.Show()
                LS.Show()
                LM.Show()
                PBS1.Show()
                PBS2.Show()
                PBS3.Show()
                BM.Hide()
            Case 3
                PBM.Hide()
                LS.Hide()
                LM.Show()
                PBS1.Show()
                PBS2.Show()
                PBS3.Show()
                BM.Hide()
            Case 4
                PBM.Hide()
                LS.Hide()
                LM.Hide()
                PBS1.Hide()
                PBS2.Hide()
                PBS3.Hide()
                BM.Hide()
        End Select
    End Sub

    Sub ResultView(s As Boolean)
        LR1.Visible = s
        LR2.Visible = s
        LR3.Visible = s
        LR4.Visible = s
        LR5.Visible = s
        BC.Visible = s
        BE.Visible = s
    End Sub
End Class