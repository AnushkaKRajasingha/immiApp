Public Class CustomCtrlRelationshipStatus
    Inherits CustomCtrlMoedels
    Private _dataToggleprefix As String
    Public Property DataTogglePrefix() As String
        Get
            Return _dataToggleprefix
        End Get
        Set(ByVal value As String)
            _dataToggleprefix = value
        End Set
    End Property
    Private _dataToggleClass As String
    Public Property DataToggleClass() As String
        Get
            Return _dataToggleClass
        End Get
        Set(ByVal value As String)
            _dataToggleClass = value
        End Set
    End Property
End Class
