Public Class Car
    '继承父类Vehicle
    Inherits Vehicle

    Public Property NumberOfTires() As Integer
        Get

        End Get
        Set(value As Integer)

        End Set
    End Property

    Public Property NumberOfDoors() As Integer
        Get

        End Get
        Set(value As Integer)

        End Set
    End Property
    'Overrides 覆盖父类重写的参数
    Public Overrides Function Description() As String

        Return "This is my Car description!"
    End Function
End Class
