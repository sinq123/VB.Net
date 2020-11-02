Public Class ClaCar
    Dim m_sColor As String
    Dim m_sMake As String
    Dim m_sModel As String
    '读写属性
    Public Property Color() As String
        Get
            Return m_sColor
        End Get
        Set(ByVal Value As String)
            Select Case Value.ToUpper()
                Case "RED"
                    m_sColor = Value
                Case "YELLOW"
                    m_sColor = Value
                Case "BLUE"
                    m_sColor = Value
                Case Else
                    Dim objException As System.Exception
                    objException = New System.ArgumentOutOfRangeException()
                    Throw objException
            End Select
        End Set
    End Property

    Public Property Make() As String
        Get
            Return m_sMake
        End Get
        Set(ByVal Value As String)
            m_sMake = Value
        End Set
    End Property
    Public Property Model() As String
        Get
            Return m_sModel
        End Get
        Set(ByVal Value As String)
            m_sModel = Value
        End Set
    End Property

    '只读属性

    Public ReadOnly Property Description() As String
        Get
            Return m_sColor & " " & m_sMake & " " & m_sModel
        End Get
    End Property

    '只写属性
    Dim m_sPassword As String
    Public WriteOnly Property Password() As String
        Set(ByVal Value As String)
            m_sPassword = Value
        End Set
    End Property

    Dim m_dtManufactured As Date

    Public Property Manufactured() As Date
        Get
            Return m_dtManufactured
        End Get
        Set(value As Date)
            m_dtManufactured = value
        End Set
    End Property
    '重载
    Public Overloads Function GetAge() As Long
        Dim lngDays As Long
        Dim dtCurrent As Date
        dtCurrent = System.DateTime.Today
        lngDays = dtCurrent.Subtract(m_dtManufactured).Days
        Return lngDays
    End Function

    Public Overloads Function GetAge(ByVal dtPointInTime As Date) As Long
        Dim lngDays As Long
        lngDays = dtPointInTime.Subtract(m_dtManufactured).Days
        Return lngDays
    End Function

    Public Overloads Function GetAge(ByVal sUnit As String) As Long
        Dim lngUnits As Long
        Dim dtCurrent As Date
        Dim tsDifference As System.TimeSpan
        dtCurrent = System.DateTime.Today
        tsDifference = dtCurrent.Subtract(m_dtManufactured)
        Select Case sUnit
            Case "Hours"
                lngUnits = tsDifference.Hours
            Case "Days"
                lngUnits = tsDifference.Days
            Case "MInutes"
                lngUnits = tsDifference.Minutes
            Case "Years"
                lngUnits = tsDifference.Days \ 365
        End Select
        Return lngUnits
    End Function

    Public Sub StartEngine()
        System.Console.WriteLine("Vroom, Vroom...!!!")
    End Sub
End Class
