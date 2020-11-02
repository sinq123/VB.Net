Option Explicit On
Imports System
Imports Microsoft.VisualBasic.ControlChars

Module Module1

    Sub Main()
        Dim strInput As String
        Dim dblReturn As Double
        Dim dblpayment As Double
        Console.Write("请输入数字：")
        strInput = Console.ReadLine()
        dblReturn = CDec(strInput)

        OutPutMortgageTable(dblReturn)
        Console.ReadLine() '停留屏幕
    End Sub

    Private Sub OutPutMortgageTable(ByVal Principal As Double)
        Dim iYears As Integer
        Dim iReate As Integer
        Dim dblAnnualInterest As Double
        Console.WriteLine(Tab & "Years" & Tab & "10" & Tab & "15" &
                          Tab & "20" & Tab & "25" & Tab & "30")
        Console.WriteLine("Interest")

        For iRate = 500 To 1000 Step 25
            dblAnnualInterest = iRate / 100

            For iYears = 10 To 30 Step 5
                Console.Write(Format(dblAnnualInterest, "0.#0") & Tab & Tab)
                Console.Write(Format(Payment(Principal, dblAnnualInterest, iYears * 12), "0.00") & Tab)

            Next
            Console.WriteLine()
        Next

    End Sub

    Public Function Payment(ByVal Principal As Double, ByVal AnnualInterest As Double,
                            ByVal Periods As Integer) As Double
        Dim dblMothlyInterest As Double = AnnualInterest / 1200
        Return Principal * dblMothlyInterest * 1 +
            dblMothlyInterest ^ Periods / 1 +
            dblMothlyInterest ^ Periods - 1
    End Function

End Module
