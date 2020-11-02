Imports ConsoleApplication1.Greeting
Imports ConsoleApplication1.PatternMathcher
Imports ConsoleApplication1.SelectCase
Imports ConsoleApplication1.ForExample
'Imports ConsoleApplication1.ClaCar


Module Module1

    Sub Main()
        ''System.Console.WriteLine("This is where the OS Version Info will go !")
        ''获取系统版本信息
        'System.Console.WriteLine(System.Environment.OSVersion.ToString())
        'System.Console.ReadLine() '停留屏幕
        'Greeting.Main()
        'PatternMathcher.Main()
        'SelectCase.Main()
        'ForExample.main()
        '建立对象的实例
        'Dim objCar As ClaCar
        'objCar = New ClaCar()
        'objCar.Color = "Red"
        'objCar.Make = "Ford"
        'objCar.Model = "Escort"

        'Dim sCarDesc As String
        'sCarDesc = objCar.Color & " " & objCar.Make & " " & objCar.Model
        ''System.Console.WriteLine(sCarDesc)
        'objCar.Manufactured = #1/30/2000#
        'System.Console.WriteLine(objCar.GetAge().ToString())
        Dim objVCar As Car
        objVCar = New Car()
        System.Console.ReadLine() '停留屏幕

    End Sub

End Module
