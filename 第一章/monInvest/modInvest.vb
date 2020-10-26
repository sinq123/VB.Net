Module modInvest
    Private dbLAnnualInterest As Double = 0
    Private iYears As Integer = 0
    Private decStartingBalance As Double = 0
    Private decMonthlyDeposit As Double = 0

    Sub Main()
        Dim decResult As Double
        'get input valuse
        GetInputValuse()
        'calculate()
        decResult = CalculateFV(dbLAnnualInterest, iYears, decMonthlyDeposit, decStartingBalance)
        'output(result)
        DisplayResults(decResult)
        System.Console.ReadLine() '停留屏幕
    End Sub

    Private Sub GetInputValuse()
        Console.WriteLine()
        decStartingBalance = CDec(GetValue("Initial Balance:"))
        dbLAnnualInterest = CDec(GetValue("Annual Interest (e.g. for 5%, enter5):"))
        decMonthlyDeposit = CDec(GetValue("Month deposit:"))
        iYears = CInt(GetValue("Years of investment :"))
        Console.WriteLine()
    End Sub

    Private Function GetValue(ByVal prompt As String) As String
        Console.Write(prompt)
        Return Console.ReadLine
    End Function

    Private Sub DisplayResults(ByVal Result As Double)
        Console.WriteLine()
        Console.WriteLine("If you start with {0:c},", decStartingBalance)
        Console.WriteLine(" and invest {0:c} per month", decMonthlyDeposit)
        Console.WriteLine("for {0} years", iYears)
        Console.WriteLine("at {0}% interest.", dbLAnnualInterest)
        Console.WriteLine()
        Console.WriteLine("Your final balance would oe: {0:c}", Result)
    End Sub

    Private Function CalculateFV(ByVal AnnualInterest As Double,
                                 ByVal years As Integer,
                                 ByVal MonthlyDeposit As Double,
                                 ByVal StartingBalance As Double) As Double
        'divide by 1200 to make it percent and per month
        Dim decMonthlyInterest As Double = CDec(AnnualInterest / 1200)
        Dim iMonths As Integer = years * 12
        Dim decTemp As Double
        Dim decReturn As Double
        'we'll need this value in a couple of places
        decTemp = CDec((1 + decMonthlyInterest) ^ iMonths)
        decReturn = CDec((MonthlyDeposit *
                          ((decTemp - 1) / decMonthlyInterest) *
                          (StartingBalance * decTemp))
            )
        Return decReturn
    End Function
End Module
