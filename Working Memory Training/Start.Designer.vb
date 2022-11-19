<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Start
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LQ = New System.Windows.Forms.Label()
        Me.TB = New System.Windows.Forms.TextBox()
        Me.LB = New System.Windows.Forms.Label()
        Me.BS = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LQ
        '
        Me.LQ.AutoSize = True
        Me.LQ.Font = New System.Drawing.Font("MS UI Gothic", 20.0!)
        Me.LQ.Location = New System.Drawing.Point(12, 12)
        Me.LQ.Margin = New System.Windows.Forms.Padding(3)
        Me.LQ.Name = "LQ"
        Me.LQ.Size = New System.Drawing.Size(279, 27)
        Me.LQ.TabIndex = 0
        Me.LQ.Text = "何バックから始めますか？"
        '
        'TB
        '
        Me.TB.Font = New System.Drawing.Font("MS UI Gothic", 20.0!)
        Me.TB.Location = New System.Drawing.Point(13, 46)
        Me.TB.Name = "TB"
        Me.TB.Size = New System.Drawing.Size(202, 34)
        Me.TB.TabIndex = 1
        Me.TB.Text = "1"
        Me.TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LB
        '
        Me.LB.AutoSize = True
        Me.LB.Font = New System.Drawing.Font("MS UI Gothic", 20.0!)
        Me.LB.Location = New System.Drawing.Point(221, 49)
        Me.LB.Margin = New System.Windows.Forms.Padding(3)
        Me.LB.Name = "LB"
        Me.LB.Size = New System.Drawing.Size(70, 27)
        Me.LB.TabIndex = 2
        Me.LB.Text = "バック"
        '
        'BS
        '
        Me.BS.Font = New System.Drawing.Font("MS UI Gothic", 20.0!)
        Me.BS.Location = New System.Drawing.Point(13, 87)
        Me.BS.Margin = New System.Windows.Forms.Padding(3, 3, 12, 12)
        Me.BS.Name = "BS"
        Me.BS.Size = New System.Drawing.Size(278, 50)
        Me.BS.TabIndex = 3
        Me.BS.Text = "スタート"
        Me.BS.UseVisualStyleBackColor = True
        '
        'Start
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(307, 149)
        Me.Controls.Add(Me.BS)
        Me.Controls.Add(Me.LB)
        Me.Controls.Add(Me.TB)
        Me.Controls.Add(Me.LQ)
        Me.MaximizeBox = False
        Me.Name = "Start"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "開始バック数指定"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LQ As Label
    Friend WithEvents TB As TextBox
    Friend WithEvents LB As Label
    Friend WithEvents BS As Button
End Class
