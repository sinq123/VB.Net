Imports System
'If的使用
Public Class Greeting
    'Run the application
    Shared Sub Main()
        Dim dtCurrent As System.DateTime
        Dim iHour As Integer

        dtCurrent = Date.Now()
        iHour = dtCurrent.Hour

        If (iHour < 12) Then
            Console.WriteLine("Good Morning!")
        ElseIf (iHour >= 12) And (iHour < 18) Then
            Console.WriteLine("GOood Afternoon!")
        Else
            Console.WriteLine("GOood Evening!")
        End If
    End Sub
End Class
'Like 的使用
Public Class PatternMathcher
    Shared Sub Main()
        Dim strTnput As String
        Dim strPattern As String
        Dim strMatct As String

        System.Console.Write("Please Enter A Pattern;")
        strTnput = System.Console.ReadLine()
        strPattern = strTnput

        System.Console.Write("Please Enter A String To Compare Against:")
        strTnput = System.Console.ReadLine()
        strMatct = strTnput

        If strMatct Like strPattern Then
            System.Console.WriteLine("strMatct & 'Matct with' & strPattern")
        Else
            System.Console.WriteLine("strMatct & 'did not Matct with' & strPattern")
        End If

    End Sub
End Class
'Select Case And For Next 语句
Public Class SelectCase
    Shared Sub Main()
        Dim sDayName As String
        Dim iFir As Integer
        Dim iLast As Integer
        Dim iCurr As Integer

        iFir = 2
        iLast = 6
        For iCurr = iFir To iLast
            System.Console.WriteLine(WeekdayName(iCurr))
        Next iCurr
    End Sub

    Shared Function WeekdayName(ByVal iDayNameNUmber As Integer) As String
        Dim strWeekDayName As String
        Select Case iDayNameNUmber
            Case 1
                strWeekDayName = "Sunnday"
            Case 2
                strWeekDayName = "Monday"
            Case 3
                strWeekDayName = "Tuesday"
            Case 4
                strWeekDayName = "Wecnesday"
            Case 5
                strWeekDayName = "Thuray"
            Case 6
                strWeekDayName = "Friday"
            Case 7
                strWeekDayName = "saturday"
            Case Else
                strWeekDayName = "Invalid Day Number"
        End Select

        Return strWeekDayName
    End Function
End Class
'定时器Step
Public Class ForExample
    Shared Sub main()
        Dim iCou As Integer
        Dim iFir As Integer
        Dim iLast As Integer
        Dim iIncrement As Integer

        iFir = 10
        iLast = 0
        iIncrement = 1
        For iCou = iFir To iLast Step iIncrement
            System.Console.WriteLine(iCou)
        Next iCou

    End Sub
End Class
'