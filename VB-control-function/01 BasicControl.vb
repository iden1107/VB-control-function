Public Class Form1
    '1-1 ラベル
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

    '1-2 ラベル
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start("https://www.google.co.jp/")
        LinkLabel1.LinkVisited = True

        'System.Diagnostics.Process.Start()メソッド
        'System.Diagnostics.Process.Start( アプリ名 , ファイル名orURL)で実行される
        '実際はtry-catchで例外処理を行うとよい

        '例）
        'Try
        '    System.Diagnostics.Process.Start("https://www.google.co.jp/")
        'Catch ex As Exception
        '    MsgBox("エラーが発生しました")
        'End Try

    End Sub

    '1-3 ボタン
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MsgBox("Alt + Aで実行")
    End Sub

    'アクセプトとキャンセルは1つのフォームに1つずつ配置できる
    Private Sub Accept_Click(sender As Object, e As EventArgs) Handles Accept.Click
        MsgBox("Enterで実行")
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        MsgBox("Escで実行")
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        If TextBox2.Text = "" Then
            Button5.Enabled = False
        Else
            Button5.Enabled = True
        End If
    End Sub
End Class













