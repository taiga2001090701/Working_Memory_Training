<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Training
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.PBM = New System.Windows.Forms.PictureBox()
        Me.LS = New System.Windows.Forms.Label()
        Me.LM = New System.Windows.Forms.Label()
        Me.PBS1 = New System.Windows.Forms.PictureBox()
        Me.PBS2 = New System.Windows.Forms.PictureBox()
        Me.PBS3 = New System.Windows.Forms.PictureBox()
        Me.BM = New System.Windows.Forms.Button()
        Me.T = New System.Windows.Forms.Timer(Me.components)
        Me.LCW1 = New System.Windows.Forms.Label()
        Me.LCW2 = New System.Windows.Forms.Label()
        Me.LCW3 = New System.Windows.Forms.Label()
        Me.LR1 = New System.Windows.Forms.Label()
        Me.LR2 = New System.Windows.Forms.Label()
        Me.LR3 = New System.Windows.Forms.Label()
        Me.LR4 = New System.Windows.Forms.Label()
        Me.LR5 = New System.Windows.Forms.Label()
        Me.BC = New System.Windows.Forms.Button()
        Me.BE = New System.Windows.Forms.Button()
        Me.LT = New System.Windows.Forms.Label()
        CType(Me.PBM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBS1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBS2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBS3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PBM
        '
        Me.PBM.Location = New System.Drawing.Point(12, 50)
        Me.PBM.Name = "PBM"
        Me.PBM.Size = New System.Drawing.Size(300, 450)
        Me.PBM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PBM.TabIndex = 0
        Me.PBM.TabStop = False
        '
        'LS
        '
        Me.LS.Font = New System.Drawing.Font("MS UI Gothic", 16.0!)
        Me.LS.ForeColor = System.Drawing.Color.White
        Me.LS.Location = New System.Drawing.Point(318, 256)
        Me.LS.Name = "LS"
        Me.LS.Size = New System.Drawing.Size(190, 23)
        Me.LS.TabIndex = 1
        Me.LS.Text = "X/X"
        Me.LS.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LM
        '
        Me.LM.Font = New System.Drawing.Font("MS UI Gothic", 20.0!)
        Me.LM.ForeColor = System.Drawing.Color.White
        Me.LM.Location = New System.Drawing.Point(12, 523)
        Me.LM.Margin = New System.Windows.Forms.Padding(3, 20, 3, 3)
        Me.LM.Name = "LM"
        Me.LM.Size = New System.Drawing.Size(496, 30)
        Me.LM.TabIndex = 2
        Me.LM.Text = "X番目のカードを選択してください"
        Me.LM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PBS1
        '
        Me.PBS1.Location = New System.Drawing.Point(12, 595)
        Me.PBS1.Margin = New System.Windows.Forms.Padding(3, 3, 3, 12)
        Me.PBS1.Name = "PBS1"
        Me.PBS1.Size = New System.Drawing.Size(150, 225)
        Me.PBS1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PBS1.TabIndex = 3
        Me.PBS1.TabStop = False
        '
        'PBS2
        '
        Me.PBS2.Location = New System.Drawing.Point(185, 595)
        Me.PBS2.Margin = New System.Windows.Forms.Padding(20, 3, 20, 12)
        Me.PBS2.Name = "PBS2"
        Me.PBS2.Size = New System.Drawing.Size(150, 225)
        Me.PBS2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PBS2.TabIndex = 4
        Me.PBS2.TabStop = False
        '
        'PBS3
        '
        Me.PBS3.Location = New System.Drawing.Point(358, 595)
        Me.PBS3.Margin = New System.Windows.Forms.Padding(3, 3, 12, 12)
        Me.PBS3.Name = "PBS3"
        Me.PBS3.Size = New System.Drawing.Size(150, 225)
        Me.PBS3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PBS3.TabIndex = 5
        Me.PBS3.TabStop = False
        '
        'BM
        '
        Me.BM.BackColor = System.Drawing.Color.Black
        Me.BM.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BM.FlatAppearance.BorderSize = 3
        Me.BM.Font = New System.Drawing.Font("MS UI Gothic", 20.0!)
        Me.BM.ForeColor = System.Drawing.Color.White
        Me.BM.Location = New System.Drawing.Point(12, 523)
        Me.BM.Margin = New System.Windows.Forms.Padding(3, 20, 12, 12)
        Me.BM.Name = "BM"
        Me.BM.Size = New System.Drawing.Size(496, 50)
        Me.BM.TabIndex = 6
        Me.BM.Text = "覚えました"
        Me.BM.UseVisualStyleBackColor = False
        '
        'T
        '
        '
        'LCW1
        '
        Me.LCW1.Font = New System.Drawing.Font("MS UI Gothic", 20.0!)
        Me.LCW1.ForeColor = System.Drawing.Color.Red
        Me.LCW1.Location = New System.Drawing.Point(12, 559)
        Me.LCW1.Margin = New System.Windows.Forms.Padding(3)
        Me.LCW1.Name = "LCW1"
        Me.LCW1.Size = New System.Drawing.Size(150, 30)
        Me.LCW1.TabIndex = 7
        Me.LCW1.Text = "X"
        Me.LCW1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LCW2
        '
        Me.LCW2.Font = New System.Drawing.Font("MS UI Gothic", 20.0!)
        Me.LCW2.ForeColor = System.Drawing.Color.Red
        Me.LCW2.Location = New System.Drawing.Point(185, 559)
        Me.LCW2.Name = "LCW2"
        Me.LCW2.Size = New System.Drawing.Size(150, 30)
        Me.LCW2.TabIndex = 8
        Me.LCW2.Text = "X"
        Me.LCW2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LCW3
        '
        Me.LCW3.Font = New System.Drawing.Font("MS UI Gothic", 20.0!)
        Me.LCW3.ForeColor = System.Drawing.Color.Red
        Me.LCW3.Location = New System.Drawing.Point(358, 559)
        Me.LCW3.Name = "LCW3"
        Me.LCW3.Size = New System.Drawing.Size(150, 30)
        Me.LCW3.TabIndex = 9
        Me.LCW3.Text = "X"
        Me.LCW3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LR1
        '
        Me.LR1.Font = New System.Drawing.Font("MS UI Gothic", 16.0!)
        Me.LR1.ForeColor = System.Drawing.Color.White
        Me.LR1.Location = New System.Drawing.Point(12, 50)
        Me.LR1.Margin = New System.Windows.Forms.Padding(3, 3, 12, 3)
        Me.LR1.Name = "LR1"
        Me.LR1.Size = New System.Drawing.Size(496, 25)
        Me.LR1.TabIndex = 10
        Me.LR1.Text = "正答数 X/X"
        Me.LR1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LR2
        '
        Me.LR2.Font = New System.Drawing.Font("MS UI Gothic", 20.0!)
        Me.LR2.ForeColor = System.Drawing.Color.White
        Me.LR2.Location = New System.Drawing.Point(12, 81)
        Me.LR2.Margin = New System.Windows.Forms.Padding(3, 3, 12, 3)
        Me.LR2.Name = "LR2"
        Me.LR2.Size = New System.Drawing.Size(496, 30)
        Me.LR2.TabIndex = 11
        Me.LR2.Text = "正答率 XX%"
        Me.LR2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LR3
        '
        Me.LR3.Font = New System.Drawing.Font("MS UI Gothic", 16.0!)
        Me.LR3.ForeColor = System.Drawing.Color.White
        Me.LR3.Location = New System.Drawing.Point(12, 117)
        Me.LR3.Margin = New System.Windows.Forms.Padding(3, 3, 12, 3)
        Me.LR3.Name = "LR3"
        Me.LR3.Size = New System.Drawing.Size(496, 25)
        Me.LR3.TabIndex = 12
        Me.LR3.Text = "XXXXのため"
        Me.LR3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LR4
        '
        Me.LR4.Font = New System.Drawing.Font("MS UI Gothic", 20.0!)
        Me.LR4.ForeColor = System.Drawing.Color.White
        Me.LR4.Location = New System.Drawing.Point(12, 148)
        Me.LR4.Margin = New System.Windows.Forms.Padding(3, 3, 12, 3)
        Me.LR4.Name = "LR4"
        Me.LR4.Size = New System.Drawing.Size(496, 30)
        Me.LR4.TabIndex = 13
        Me.LR4.Text = "レベルXXXX"
        Me.LR4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LR5
        '
        Me.LR5.Font = New System.Drawing.Font("MS UI Gothic", 24.0!)
        Me.LR5.ForeColor = System.Drawing.Color.White
        Me.LR5.Location = New System.Drawing.Point(12, 184)
        Me.LR5.Margin = New System.Windows.Forms.Padding(3, 3, 12, 3)
        Me.LR5.Name = "LR5"
        Me.LR5.Size = New System.Drawing.Size(496, 35)
        Me.LR5.TabIndex = 14
        Me.LR5.Text = "Xバック ⇒ Xバック"
        Me.LR5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BC
        '
        Me.BC.BackColor = System.Drawing.Color.Black
        Me.BC.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BC.FlatAppearance.BorderSize = 3
        Me.BC.Font = New System.Drawing.Font("MS UI Gothic", 20.0!)
        Me.BC.ForeColor = System.Drawing.Color.White
        Me.BC.Location = New System.Drawing.Point(97, 225)
        Me.BC.Margin = New System.Windows.Forms.Padding(3, 3, 3, 12)
        Me.BC.Name = "BC"
        Me.BC.Size = New System.Drawing.Size(150, 50)
        Me.BC.TabIndex = 15
        Me.BC.Text = "続ける"
        Me.BC.UseVisualStyleBackColor = False
        '
        'BE
        '
        Me.BE.BackColor = System.Drawing.Color.Black
        Me.BE.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BE.FlatAppearance.BorderSize = 3
        Me.BE.Font = New System.Drawing.Font("MS UI Gothic", 20.0!)
        Me.BE.ForeColor = System.Drawing.Color.White
        Me.BE.Location = New System.Drawing.Point(273, 225)
        Me.BE.Margin = New System.Windows.Forms.Padding(3, 3, 3, 12)
        Me.BE.Name = "BE"
        Me.BE.Size = New System.Drawing.Size(150, 50)
        Me.BE.TabIndex = 16
        Me.BE.Text = "終わる"
        Me.BE.UseVisualStyleBackColor = False
        '
        'LT
        '
        Me.LT.Font = New System.Drawing.Font("MS UI Gothic", 24.0!)
        Me.LT.ForeColor = System.Drawing.Color.White
        Me.LT.Location = New System.Drawing.Point(12, 9)
        Me.LT.Margin = New System.Windows.Forms.Padding(3)
        Me.LT.Name = "LT"
        Me.LT.Size = New System.Drawing.Size(496, 35)
        Me.LT.TabIndex = 17
        Me.LT.Text = "Xバック"
        Me.LT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Training
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(522, 831)
        Me.Controls.Add(Me.BE)
        Me.Controls.Add(Me.BC)
        Me.Controls.Add(Me.LR5)
        Me.Controls.Add(Me.LR4)
        Me.Controls.Add(Me.LR3)
        Me.Controls.Add(Me.LR2)
        Me.Controls.Add(Me.LR1)
        Me.Controls.Add(Me.LCW3)
        Me.Controls.Add(Me.LCW2)
        Me.Controls.Add(Me.LCW1)
        Me.Controls.Add(Me.BM)
        Me.Controls.Add(Me.PBS3)
        Me.Controls.Add(Me.PBS2)
        Me.Controls.Add(Me.PBS1)
        Me.Controls.Add(Me.LM)
        Me.Controls.Add(Me.LS)
        Me.Controls.Add(Me.PBM)
        Me.Controls.Add(Me.LT)
        Me.MaximizeBox = False
        Me.Name = "Training"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "トレーニング"
        CType(Me.PBM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBS1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBS2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBS3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PBM As PictureBox
    Friend WithEvents LS As Label
    Friend WithEvents LM As Label
    Friend WithEvents PBS1 As PictureBox
    Friend WithEvents PBS2 As PictureBox
    Friend WithEvents PBS3 As PictureBox
    Friend WithEvents BM As Button
    Friend WithEvents T As Timer
    Friend WithEvents LCW1 As Label
    Friend WithEvents LCW2 As Label
    Friend WithEvents LCW3 As Label
    Friend WithEvents LR1 As Label
    Friend WithEvents LR2 As Label
    Friend WithEvents LR3 As Label
    Friend WithEvents LR4 As Label
    Friend WithEvents LR5 As Label
    Friend WithEvents BC As Button
    Friend WithEvents BE As Button
    Friend WithEvents LT As Label
End Class
