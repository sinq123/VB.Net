Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Me.TextBox1.Text = "你好，世界！" '按下按钮显示'
        'Me.TextBox1.ForeColor = Color.Blue
        'Me.Button1.BackColor = Color.Gold '背景色'
        'Me.Button1.ForeColor = Color.Blue '前景色'

        ''mod->取余， + - * /'
        'Me.TextBox1.Text = 100 Mod 20
        '声明变量
        'Dim 局部变量
        'Const 常量
        Const testConst As String = "常量"

        Dim testVar As Integer
        testVar = 100
        ''判断语句
        'If testVar = 1000 Then
        '    Me.TextBox1.Text = "真"
        'Else
        '    Me.TextBox1.Text = "假"
        'End If

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
