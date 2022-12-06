Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label1.Text = "bbbbbbbbbbb"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label1.BackColor = Color.RoyalBlue
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'フォント操作の注意点
        'New Font("xxx",xx)の形式にすること
        Label5.Font = New Font("MS Pゴシック", 20)
    End Sub
End Class













