Imports System.Windows

Public Class Form1
    '1-1 ���x��
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label1.Text = "bbbbbbbbbbb"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label1.BackColor = Color.RoyalBlue
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        '�t�H���g����̒��ӓ_
        '�u�t�H���g���v�u�T�C�Y�v�͕K�{
        'New Font(�t�H���g��,�T�C�Y,�X�^�C��)�̌`���ɂ��邱��
        Label5.Font = New Font("MS P�S�V�b�N", 20)
    End Sub

    '1-2 ���x��
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start("https://www.google.co.jp/")
        LinkLabel1.LinkVisited = True

        'System.Diagnostics.Process.Start()���\�b�h
        'System.Diagnostics.Process.Start( �A�v���� , �t�@�C����orURL)�Ŏ��s�����
        '���ۂ�try-catch�ŗ�O�������s���Ƃ悢

        '��j
        'Try
        '    System.Diagnostics.Process.Start("https://www.google.co.jp/")
        'Catch ex As Exception
        '    MsgBox("�G���[���������܂���")
        'End Try

    End Sub

    '1-3 �{�^��
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MsgBox("Alt + A�Ŏ��s")
    End Sub

    '�A�N�Z�v�g�ƃL�����Z����1�̃t�H�[����1���z�u�ł���
    Private Sub Accept_Click(sender As Object, e As EventArgs) Handles Accept.Click
        MsgBox("Enter�Ŏ��s")
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        MsgBox("Esc�Ŏ��s")
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        If TextBox2.Text = "" Then
            Button5.Enabled = False
        Else
            Button5.Enabled = True
        End If
    End Sub

    '1-5 �^�C�}�[
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label15.Text = Now
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label15.Text = Now
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Timer1.Start()
        Else
            Timer1.Stop()
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim f = New _02_InputControl
        f.Show()
    End Sub
End Class













