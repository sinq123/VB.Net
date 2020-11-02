Public Class Vehicle
    Dim m_dtManufactured As Date
    Dim m_sColor As String
    '构造器 用于初始化参数 多个构造器可以同时存在
    Public Sub New()
        m_dtManufactured = System.DateTime.Today
    End Sub

    Public Sub New(ByVal sColor As String)
        m_dtManufactured = System.DateTime.Today
        m_sColor = sColor
    End Sub

    Public Sub New(ByVal dtManufaceured As Date,
                   ByVal sColor As String)
        m_dtManufactured = dtManufaceured
        m_sColor = sColor
    End Sub

    Public Property MaxSpeed() As Long
        Get

        End Get
        Set(value As Long)

        End Set
    End Property

    Public Property NumberOfPassengers() As Long
        Get

        End Get
        Set(value As Long)

        End Set
    End Property

    Public Property Color() As String
        Get

        End Get
        Set(value As String)

        End Set
    End Property
    'Overridable 用于子类可覆盖操作
    Public Overridable Function Description() As String

        Return "This is my generic vehicle description!"
    End Function
End Class
