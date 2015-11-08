Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
Public Class PassportModels
    Private _passportnumber As String
    Private _country As Integer
    Private _nationality As Integer
    Private _dateofissue As DateTime
    Private _dateofexpiry As DateTime
    Private _placeofisse As String
    Private _familyname As String
    Private _givennames As String
    Private _sex As Integer
    Private _dateofbirth As DateTime

    Private _guidlocal As Guid
    ''' <summary>
    ''' Date of Birth
    ''' </summary>
    ''' <returns></returns>
    <DisplayName("Date of birth"), DisplayFormat(ApplyFormatInEditMode:=True, DataFormatString:="{0:dd-MMM-yyyy}")>
    Public Property Dateofbirth() As DateTime
        Get
            Return _dateofbirth
        End Get
        Set(ByVal value As DateTime)
            _dateofbirth = value
        End Set
    End Property
    ''' <summary>
    ''' Sex
    ''' </summary>
    ''' <returns></returns>
    Public Property Sex() As Integer
        Get
            Return _sex
        End Get
        Set(ByVal value As Integer)
            _sex = value
        End Set
    End Property
    ''' <summary>
    ''' Given Names
    ''' </summary>
    ''' <returns></returns>
    <DisplayName("Given Name")>
    Public Property GivenName() As String
        Get
            Return _givennames
        End Get
        Set(ByVal value As String)
            _givennames = value
        End Set
    End Property
    ''' <summary>
    ''' Family name
    ''' </summary>
    ''' <returns></returns>
    <DisplayName("Family Name")>
    Public Property FamilyName() As String
        Get
            Return _familyname
        End Get
        Set(ByVal value As String)
            _familyname = value
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
        Me._dateofissue = DateTime.Now
        Me._dateofbirth = DateTime.Now
        Me._dateofexpiry = DateTime.Now
    End Sub
    Public Property PlaceofIssue() As String
        Get
            Return _placeofisse
        End Get
        Set(ByVal value As String)
            _placeofisse = value
        End Set
    End Property
    ''' <summary>
    ''' Date of expiry
    ''' </summary>
    ''' <returns></returns>
    Public Property DateofExpiry() As DateTime
        Get
            Return _dateofexpiry
        End Get
        Set(ByVal value As DateTime)
            _dateofexpiry = value
        End Set
    End Property
    ''' <summary>
    ''' Date of issue
    ''' </summary>
    ''' <returns></returns>
    Public Property DateofIssue() As DateTime
        Get
            Return _dateofissue
        End Get
        Set(ByVal value As DateTime)
            _dateofissue = value
        End Set
    End Property
    ''' <summary>
    ''' Nationality of passport holder
    ''' </summary>
    ''' <returns></returns>
    Public Property Nationality() As Integer
        Get
            Return _nationality
        End Get
        Set(ByVal value As Integer)
            _nationality = value
        End Set
    End Property
    ''' <summary>
    ''' Country of Passport
    ''' </summary>
    ''' <returns></returns>
    Public Property Country() As Integer
        Get
            Return _country
        End Get
        Set(ByVal value As Integer)
            _country = value
        End Set
    End Property
    ''' <summary>
    ''' PassportNumber
    ''' </summary>
    ''' <returns></returns>
    Public Property PassportNumber() As String
        Get
            Return _passportnumber
        End Get
        Set(ByVal value As String)
            _passportnumber = value
        End Set
    End Property

    Public Function GetCountryName() As String
        Try
            Dim _contryctrl = New CustomCtrlPassportCountry()
            Return _contryctrl.Countries.Where(Function(x) x.Key = Me.Country).First().Value.ToString()
        Catch ex As Exception
            Return "Not Selected"
        End Try
    End Function


    Public ReadOnly Property CountryName() As String
        Get
            Dim _contryctrl = New CustomCtrlPassportCountry()
            Return _contryctrl.Countries.Where(Function(x) x.Key = Me.Country).First().Value.ToString()
        End Get
    End Property
End Class
