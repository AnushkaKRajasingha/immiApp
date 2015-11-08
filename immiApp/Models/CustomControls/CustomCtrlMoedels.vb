Public MustInherit Class CustomCtrlMoedels
    Private _id As String
    Public Property Id() As String
        Get
            Return _id
        End Get
        Set(ByVal value As String)
            _id = value
        End Set
    End Property
    Private _className As String
    Public Property ClassName() As String
        Get
            Return _className
        End Get
        Set(ByVal value As String)
            _className = value
        End Set
    End Property
    Private _defaultvalue As Object
    Public Property DefaultValue() As Object
        Get
            Return _defaultvalue
        End Get
        Set(ByVal value As Object)
            _defaultvalue = value
        End Set
    End Property

End Class
