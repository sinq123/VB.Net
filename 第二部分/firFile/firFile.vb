Imports System.IO

Public Class firFile
    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    '复制文件
    Private Sub btnCopy_Click(sender As Object, e As EventArgs) Handles btnCopy.Click
        Dim strSource As String
        Dim strDestiation As String
        strSource = txtSource.Text()
        strDestiation = txtDestination.Text()
        '复制
        Try
            File.Copy(strSource, strDestiation)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "1111")
        End Try
    End Sub
    '一个按钮多个处理事件
    Private Sub Copy_Click(sender As Object, e As EventArgs) Handles btnCopy.Click
        MessageBox.Show("另一个处理事件", "1111")
    End Sub
    '移动文件
    Private Sub btnMove_Click(sender As Object, e As EventArgs) Handles btnMove.Click
        Dim strSource As String
        Dim strDestiation As String
        strSource = txtSource.Text()
        strDestiation = txtDestination.Text()
        File.Move(strSource, strDestiation)
    End Sub

    '删除文件
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        'Dim strSource As String
        'strSource = txtSource.Text()
        'File.Delete(strSource)

        Select Case (MessageBox.Show("你好", "111", MessageBoxButtons.YesNoCancel))
            Case DialogResult.Yes
                MessageBox.Show("yes", "12", MessageBoxButtons.OK)
            Case DialogResult.No
            Case DialogResult.Cancel
            Case DialogResult.Abort
            Case DialogResult.Retry

        End Select
    End Sub

    '增加登录验证
    Private Sub firFile_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim frmLogin As New LoginForm1()
        Dim bLoginSuccessful As Boolean = False
        Dim strFailurcMessage As String
        'show() 非模态,不用等显示的对话框完成执行后续的代码
        'showDiaLog 模态,等对话框完成后才执行后续的代码
        If frmLogin.ShowDialog() = DialogResult.OK Then
            Dim strUerName As String = frmLogin.Username.Text
            Dim strpassword As String = frmLogin.Password.Text
            bLoginSuccessful = True

        End If

        If Not bLoginSuccessful Then
            Me.Close()

        End If
    End Sub

    'Private Sub OpenDiglog_Click(sender As Object, e As EventArgs) Handles OpenDiglog.Click
    '    Dim strNewFile As String
    '    Dim trNewFile As System.IO.TextReader
    '    Dim strCurrertFile As String = Nothing
    '    If MessageBox.Show("Overwrite connont contents?", "open New file",
    '                        MessageBoxButtons.YesNo, MessageBoxIcon.Question,
    '                        MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
    '        With dlgOpen
    '            .Filter = "Text files (*.txt) *.txt"
    '            .addExtension = True
    '            .CheckFileExists = True
    '            .CheckPathExists = True
    '            .InitialDirectory = IO.Path.GetDirectoryName(strCurrertFile)
    '            .Multiselect = False

    '            If .ShowDialog() = DialogResult.OK Then
    '                strNewFile = .FileName
    '                If IO.File.Exists(strNewFile) Then
    '                    trNewFile = New IO.StreamReader(strNewFile)
    '                    trNewFile.ReadToEnd()
    '                    strCurrertFile = strNewFile
    '                End If
    '            End If
    '        End With
    '    End If
    'End Sub
End Class
