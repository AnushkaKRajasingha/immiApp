Public Class CustomCtrlLeagalStatus
    Inherits CustomCtrlMoedels
    Private _leagalStatus As SortedDictionary(Of Integer, String)
    Public Property LeagalStatus() As SortedDictionary(Of Integer, String)
        Get
            Return _leagalStatus
        End Get
        Set(ByVal value As SortedDictionary(Of Integer, String))
            _leagalStatus = value
        End Set
    End Property
    Public Sub New()
        Me._leagalStatus = New SortedDictionary(Of Integer, String)
        Me._leagalStatus.Add(1, "")
        Me._leagalStatus.Add(2, "Citizen")
        Me._leagalStatus.Add(3, "Permanent Resident")
        Me._leagalStatus.Add(4, "Visitor")
        Me._leagalStatus.Add(5, "Student")
        Me._leagalStatus.Add(6, "Work Visa")
        Me._leagalStatus.Add(7, "No Legal Status")
        Me._leagalStatus.Add(8, "Other")
    End Sub
End Class
