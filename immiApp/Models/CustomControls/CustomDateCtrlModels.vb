Public Class CustomDateCtrlModels
    Inherits CustomCtrlMoedels
    Private _id As String

    Class DefaulDateValue
        Private _day As Integer
        Public Property day() As Integer
            Get
                Return _day
            End Get
            Set(ByVal value As Integer)
                _day = value
            End Set
        End Property
        Private _month As Integer
        Public Property month() As Integer
            Get
                Return _month
            End Get
            Set(ByVal value As Integer)
                _month = value
            End Set
        End Property
        Private _year As Integer
        Public Property year() As Integer
            Get
                Return _year
            End Get
            Set(ByVal value As Integer)
                _year = value
            End Set
        End Property
    End Class
End Class
