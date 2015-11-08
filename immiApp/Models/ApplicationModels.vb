Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
Imports Microsoft.AspNet.Identity

Public Class ApplicationModels
    Inherits ApplicationDbContext

    Private _currentlocation As Locations
    Private _prospectivemarriagevisa As ProspectiveMarriagevisas
    Private _substantivevisa As SubstantiveVisas
    Private _primaryapplicent As ApplicantModels
    Private _uniqueidlocal As String
    Private _appstatus As Integer
    Private _lastupdate As DateTime
    Private _userid As String
    Public Property UserID() As String
        Get
            Return _userid
        End Get
        Set(ByVal value As String)
            _userid = value
        End Set
    End Property
    <DisplayName("Last Update")>
    Public Property LastUpdate() As DateTime
        Get
            Return _lastupdate
        End Get
        Set(ByVal value As DateTime)
            _lastupdate = value
        End Set
    End Property
    <DisplayName("Status")>
    Public Property Status() As Integer
        Get
            Return _appstatus
        End Get
        Set(ByVal value As Integer)
            _appstatus = value
        End Set
    End Property
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
        Me.Status = 0
        Me.UserID = HttpContext.Current.User.Identity.GetUserId()
        Me.LastUpdate = DateTime.Now
        Me.UniqueID = DateTime.Now.Ticks.ToString("X")
    End Sub
    <DisplayName("Reference no")>
    Public Property UniqueID() As String
        Get
            '_uniqueidlocal = DateTime.Now.Ticks.ToString("X")
            Return _uniqueidlocal
        End Get
        Set(ByVal value As String)
            _uniqueidlocal = value
        End Set
    End Property

    ''' <summary>
    ''' Primary applicant
    ''' </summary>
    ''' <returns></returns>
    Public Property PrimaryApplicent() As ApplicantModels
        Get
            Return _primaryapplicent
        End Get
        Set(ByVal value As ApplicantModels)
            _primaryapplicent = value
        End Set
    End Property
    Public Property SubstantiveVisa() As SubstantiveVisas
        Get
            Return _substantivevisa
        End Get
        Set(ByVal value As SubstantiveVisas)
            _substantivevisa = value
        End Set
    End Property
    Public Property ProspectiveMarriageVisa() As ProspectiveMarriagevisas
        Get
            Return _prospectivemarriagevisa
        End Get
        Set(ByVal value As ProspectiveMarriagevisas)
            _prospectivemarriagevisa = value
        End Set
    End Property
    Public Property CurrentLocation() As Locations
        Get
            Return _currentlocation
        End Get
        Set(ByVal value As Locations)
            _currentlocation = value
        End Set
    End Property

    Public Property ApplicantModels As System.Data.Entity.DbSet(Of ApplicantModels)

    Public Function GetAllApplications() As IEnumerable(Of ApplicationModels)
        Dim _db As New immiAppDbContext
        Dim _apps = _db.ApplicationCollectio.Include("PrimaryApplicent").Include("ProspectiveMarriageVisa").Include("CurrentLocation").Include("SubstantiveVisa").Include("ProspectiveMarriageVisa.Relationship").Where(Function(x) x.Status > 0).ToList()
        Return _apps
    End Function

    Public Function GetApplication(strGuit As String, Optional _db As immiAppDbContext = Nothing) As ApplicationModels
        If _db Is Nothing Then
            _db = New immiAppDbContext()
        End If
        Return (From _app In _db.ApplicationCollectio.
                                        Include("ProspectiveMarriageVisa").
                                        Include("CurrentLocation").
                                        Include("SubstantiveVisa").
                                        Include("ProspectiveMarriageVisa.Relationship").
                                        Include("PrimaryApplicent").
                                        Include("PrimaryApplicent.Passport").
                                        Include("PrimaryApplicent.PlaceofBirth").
                                        Include("PrimaryApplicent.Citizenship").
                                        Include("PrimaryApplicent.HealthExamination").
                                        Include("PrimaryApplicent.Citizenship").
                                        Include("PrimaryApplicent.OtherNames").
                                        Include("PrimaryApplicent.OtherPassports").
                                        Include("PrimaryApplicent.NationalIDs")
                Where String.Equals(_app.Guid.ToString(), strGuit)
                Select _app).First()
    End Function

End Class
Public Class Locations
    Private _outsideaus As Integer
    Private _location As String
    Private _leagastatus As String
    Private _towncity As String
    Private _stateprovince As String
    Private _country As String
    Private _guidlocal As Guid
    Private _reason As String
    Public Property Reason() As String
        Get
            Return _reason
        End Get
        Set(ByVal value As String)
            _reason = value
        End Set
    End Property
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
        Me._country = "1"
    End Sub
    ''' <summary>
    ''' Country
    ''' </summary>
    ''' <returns></returns>
    Public Property Country() As String
        Get
            Return _country
        End Get
        Set(ByVal value As String)
            _country = value
        End Set
    End Property
    ''' <summary>
    ''' State / Province
    ''' </summary>
    ''' <returns></returns>
    Public Property StateProvince() As String
        Get
            Return _stateprovince
        End Get
        Set(ByVal value As String)
            _stateprovince = value
        End Set
    End Property
    ''' <summary>
    ''' Town / City
    ''' </summary>
    ''' <returns></returns>
    Public Property TownCity() As String
        Get
            Return _towncity
        End Get
        Set(ByVal value As String)
            _towncity = value
        End Set
    End Property
    ''' <summary>
    ''' Is the applicant currently outside Australia
    ''' </summary>
    Public Property OutSideAus() As Integer
        Get
            Return _outsideaus
        End Get
        Set(ByVal value As Integer)
            _outsideaus = value
        End Set
    End Property
    ''' <summary>
    ''' Legal status
    ''' </summary>
    ''' <returns></returns>
    Public Property LeagalStatus() As String
        Get
            Return _leagastatus
        End Get
        Set(ByVal value As String)
            _leagastatus = value
        End Set
    End Property
    ''' <summary>
    ''' Current location
    ''' </summary> 
    Public Property Location() As String
        Get
            Return _location
        End Get
        Set(ByVal value As String)
            _location = value
        End Set
    End Property

    Public Function GetCountryName() As String
        Dim _contryctrl = New CustomCtrlCountry()
        Return _contryctrl.Countries.Where(Function(x) x.Key = Me.Country).First().Value.ToString()
    End Function
End Class