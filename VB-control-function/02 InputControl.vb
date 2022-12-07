Public Class _02_InputControl
    '●2-1 リッチテキスト

    '太文字にする処理
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '文字はそのままにしておく
        RichTextBox1.SelectionFont = New Font(RichTextBox1.SelectionFont.Name, 9, FontStyle.Bold)
        'スタイルを追加していく場合はorを使用する
        'RichTextBox1.SelectionFont = New Font(RichTextBox1.SelectionFont, RichTextBox1.SelectionFont.Style Or FontStyle.Bold)
    End Sub
    '赤文字にする処理
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        RichTextBox1.SelectionColor = Color.Red
    End Sub
    '下線を引く処理
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'RichTextBox1.SelectionFont = New Font(RichTextBox1.SelectionFont, FontStyle.Underline)
        'スタイルを追加していく場合はorを使用する
        RichTextBox1.SelectionFont = New Font(RichTextBox1.SelectionFont.Name, 9, RichTextBox1.SelectionFont.Style Or FontStyle.Underline)
    End Sub
    'ファイルを保存する処理
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        RichTextBox1.SaveFile("C:\Users\user\Downloads\sample.rtf", RichTextBoxStreamType.RichText)
        RichTextBox1.Clear()
    End Sub
    'ファイルを読み込む処理
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        RichTextBox1.LoadFile("C:\Users\user\Downloads\sample.rtf", RichTextBoxStreamType.RichText)
    End Sub
End Class