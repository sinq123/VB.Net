Imports System
Imports System.IO

Public Class ConsoleTest
    Private Const ITEM_COUNT As Integer = 10

    Shared Sub Main()
        Dim I As Integer
        Dim strItems(ITEM_COUNT) As String
        Dim oFile As TextWriter = File.CreateText("Output.txt")
        Dim oOut As TextWriter = Console.Out
        Console.WriteLine("Please enter {0} items. Press ENTER between items.", ITEM_COUNT)
        For I = 0 To ITEM_COUNT - 1
            strItems(I) = Console.ReadLine
        Next
        Console.WriteLine()
        '定义输出位置到文本
        Console.SetOut(oFile)
        Console.WriteLine("items in reversr order:")
        For I = ITEM_COUNT - 1 To 0 Step -1
            Console.WriteLine(strItems(I))
        Next
        oFile.Close()
        '定义输出到控制台
        Console.SetOut(oOut)
        Console.WriteLine("Done")

        Console.ReadLine()

    End Sub
End Class
