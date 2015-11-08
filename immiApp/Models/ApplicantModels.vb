Public Class ApplicantModels
    Inherits PeoplesModels
    Private _applicanttype As String
    Public Property ApplicentType() As String
        Get
            Return _applicanttype
        End Get
        Set(ByVal value As String)
            _applicanttype = value
        End Set
    End Property
End Class
