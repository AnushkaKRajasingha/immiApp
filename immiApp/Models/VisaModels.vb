Imports System.ComponentModel.DataAnnotations
Imports System.Runtime.Serialization
Imports System.Xml.Serialization

Public Class Relationships
    Private _sameasthesponsor As Integer
    Private _marriedsnb4visaceased As Integer
    Private _marriedafter1starrinaus As Integer
    Private _stillinrelationship As Integer
    Private _enddate As DateTime
    Private _violencebyspon As String
    Private _sponisdeceased As String
    Private _guidlocal As Guid
    <Key>
    Public Property Guid() As Guid
        Get
            Return _guidlocal
        End Get
        Set(ByVal value As Guid)
            _guidlocal = value
        End Set
    End Property
    Public Sub New()
        Me.Guid = Guid.NewGuid
    End Sub
    ''' <summary>
    ''' Sponsor is deceased
    ''' </summary>
    ''' <returns></returns>
    Public Property SponIsDeceased() As String
        Get
            Return _sponisdeceased
        End Get
        Set(ByVal value As String)
            _sponisdeceased = value
        End Set
    End Property
    ''' <summary>
    ''' Applicant suffered family violence by the sponsor
    ''' </summary>
    ''' <returns></returns>
    Public Property ViolenceBySpon() As String
        Get
            Return _violencebyspon
        End Get
        Set(ByVal value As String)
            _violencebyspon = value
        End Set
    End Property
    ''' <summary>
    ''' Date relationship ended
    ''' </summary>
    ''' <returns></returns>
    Public Property EndDate() As DateTime
        Get
            Return _enddate
        End Get
        Set(ByVal value As DateTime)
            _enddate = value
        End Set
    End Property
    ''' <summary>
    ''' Is the applicant still in a relationship with the sponsor
    ''' </summary>
    ''' <returns></returns>
    Public Property StillInRelationship() As Integer
        Get
            Return _stillinrelationship
        End Get
        Set(ByVal value As Integer)
            _stillinrelationship = value
        End Set
    End Property
    ''' <summary>
    ''' The applicant marry the sponsor after the applicant's first arrival in Australia
    ''' </summary>
    ''' <returns></returns>
    Public Property MarriedAfter1StArrinAus() As Integer
        Get
            Return _marriedafter1starrinaus
        End Get
        Set(ByVal value As Integer)
            _marriedafter1starrinaus = value
        End Set
    End Property
    ''' <summary>
    ''' Did the applicant marry the sponsor before the visa ceased
    ''' </summary>
    ''' <returns></returns>
    Public Property MarriedSB4VisaCeased() As Integer
        Get
            Return _marriedsnb4visaceased
        End Get
        Set(ByVal value As Integer)
            _marriedsnb4visaceased = value
        End Set
    End Property
    ''' <summary>
    ''' Is the sponsor listed on this application the same as the sponsor for 
    ''' </summary>
    ''' <returns></returns>
    Public Property SameAsTheSponsor() As Integer
        Get
            Return _sameasthesponsor
        End Get
        Set(ByVal value As Integer)
            _sameasthesponsor = value
        End Set
    End Property
End Class
Public MustInherit Class VisaModels
    Private _isapplyingforavisa As Integer
    Private _isCurrentlyholding As Integer
    Private _isarriveinauson As Integer
    Private _refnumbertype As String
    Private _transrefnumber As String
    Private _ausvisalblnumber As String
    Private _applicationid As String
    Private _relationships As Relationships
    Private _hasceased As Integer
    Private _guidlocal As Guid
    <Key>
    Public Property Guid() As Guid
        Get
            Return _guidlocal
        End Get
        Set(ByVal value As Guid)
            _guidlocal = value
        End Set
    End Property
    Public Sub New()
        Me.Guid = Guid.NewGuid
    End Sub
    ''' <summary>
    ''' Has the applicant's visa ceased
    ''' </summary>
    ''' <returns></returns>
    Public Property HasCeased() As Integer
        Get
            Return _hasceased
        End Get
        Set(ByVal value As Integer)
            _hasceased = value
        End Set
    End Property
    Public Property Relationship() As Relationships
        Get
            Return _relationships
        End Get
        Set(ByVal value As Relationships)
            _relationships = value
        End Set
    End Property

    ''' <summary>
    ''' Application ID
    ''' </summary>
    ''' <returns></returns>
    Public Property ApplicationId() As String
        Get
            Return _applicationid
        End Get
        Set(ByVal value As String)
            _applicationid = value
        End Set
    End Property
    ''' <summary>
    ''' Australian visa label number
    ''' </summary>
    ''' <returns></returns>
    Public Property AusVisaLblNumber() As String
        Get
            Return _ausvisalblnumber
        End Get
        Set(ByVal value As String)
            _ausvisalblnumber = value
        End Set
    End Property
    ''' <summary>
    ''' Transaction Reference Number (TRN)
    ''' </summary>
    ''' <returns></returns>
    Public Property TransRefNumber() As String
        Get
            Return _transrefnumber
        End Get
        Set(ByVal value As String)
            _transrefnumber = value
        End Set
    End Property
    ''' <summary>
    ''' Did the applicant arrive in Australia on
    ''' </summary>
    ''' <returns></returns>
    Public Property IsArriveinAusOn() As Integer
        Get
            Return _isarriveinauson
        End Get
        Set(ByVal value As Integer)
            _isarriveinauson = value
        End Set
    End Property
    ''' <summary>
    ''' Is the applicant currently holding
    ''' </summary>
    ''' <returns></returns>
    Public Property IsCurrentlyHolding() As Integer
        Get
            Return _isCurrentlyholding
        End Get
        Set(ByVal value As Integer)
            _isCurrentlyholding = value
        End Set
    End Property

    ''' <summary>
    ''' Reference number type
    ''' </summary>
    ''' <returns></returns>
    Public Property RefNumberType() As String
        Get
            Return _refnumbertype
        End Get
        Set(ByVal value As String)
            _refnumbertype = value
        End Set
    End Property
    ''' <summary>
    ''' Is the applicant applying for a xxxxxx visa
    ''' </summary>
    ''' <returns></returns>
    Public Property IsApplyingForaVisa() As Integer
        Get
            Return _isapplyingforavisa
        End Get
        Set(ByVal value As Integer)
            _isapplyingforavisa = value
        End Set
    End Property
End Class
Public Class ProspectiveMarriagevisas
    Inherits VisaModels


End Class
Public Class SubstantiveVisas
    Inherits VisaModels
    Private _compellingreasons As String
    ''' <summary>
    ''' Demonstrate compelling reasons exist for the grant of their partner visa
    ''' </summary>
    ''' <returns></returns>
    Public Property CompellingReasons() As String
        Get
            Return _compellingreasons
        End Get
        Set(ByVal value As String)
            _compellingreasons = value
        End Set
    End Property
End Class
