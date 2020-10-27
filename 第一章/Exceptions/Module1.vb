Module Module1

    Sub Main()
        'Dim dDivnded As Decimal = 5
        'Dim dDivison As Decimal = 0
        'Dim dResult As Decimal = 0
        ''异常处理函数Try->有可能出现异常的代码
        ''catch->异常出现后的处理
        ''Finally->不管有没有发生异常情况，都会操作的代码
        ''End Try->结束有可能引起异常的代码
        ''Throw New InvalidCastException(“自定义异常”)
        'Try
        '    dResult = dDivnded / dDivison
        '    System.Console.WriteLine(dResult.ToString())
        'Catch Ex As Exception
        '    System.Console.WriteLine("发生错误")
        '    System.Console.WriteLine("{0} / {1}异常", dDivnded, dDivison)
        '    System.Console.ReadLine()
        'Finally
        'End Try

        Dim oCust As Customer = New Customer("Bob", "Sjerunkl")
        Dim oemp As Employee = New Employee("Phil", "Barr")
        Dim oSomething As Object
        oSomething = oemp
        If TypeOf oSomething Is Customer Then
            oCust = oSomething
        Else
            Throw New InvalidCastException("Cannot assign an Enployee to a Customer")

        End If
        System.Console.ReadLine() '停留屏幕
    End Sub

End Module
