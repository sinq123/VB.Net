Public Class Form1
    
    Private Sub BTNADD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNADD.Click
        'MessageBox.Show("The Button been clicked")
        'Me.TextResult.Text = (CInt(TextFirValue.Text) -
        'CInt(TextSecValue.Text)).ToString
        'Dim n() As Integer = {100, 20, 10}
        'Me.TextResult.Text = n(0).ToString
        'Me.TextFirValue.Text = n(1).ToString
        'Me.TextSecValue.Text = n(2).ToString
        'SubRoutineName("自己创建的函数")
        Dim strTemp As String
        strTemp = Volume(3, 4, 5).ToString()
        MessageBox.Show(strTemp)
    End Sub

    Private Sub TextResult_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextResult.TextChanged
        Dim FirVal = Me.TextFirValue.Text
        Dim SecVal = Me.TextSecValue.Text


        If FirVal <> "" And SecVal <> "" Then
            Me.TextResult.Text = (CInt(TextFirValue.Text) - CInt(TextSecValue.Text)).ToString

        End If
    End Sub
    '无返回值函数创建
    Sub SubRoutineName(Byval Message As String)
        MessageBox.Show(Message)
    End Sub
    '有返回值函数创建
    Function Volume(ByVal Length As Integer,
                    ByVal width As Integer, ByVal heigh As Integer) As Integer
        Return Length * width * heigh
    End Function
End Class
