Public Class NewClass

    '文件读取
    Shared Sub ReadFile()

        Dim strFileName As String
        Dim strFileReader As System.IO.StreamReader
        Dim strInputLine As String

        strFileName = "MySampeFile.txt"
        strFileReader = System.IO.File.OpenText(strFileName)

        strInputLine = "something"
        Do Until strInputLine Is Nothing
            strInputLine = strFileReader.ReadLine()
            System.Console.WriteLine(strInputLine)
        Loop


    End Sub

End Class
