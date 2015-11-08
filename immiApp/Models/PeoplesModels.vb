Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
Public MustInherit Class PeoplesModels
    Private _familyname As String
    Private _givennames As String
    Private _sex As Integer
    Private _dateofbirth As DateTime
    Private _passport As PassportModels
    Private _placeofbirth As Locations
    Private _relationshipstatus As Maritalstatus
    Private _othernames As List(Of OtherName)
    Private _citizenship As Citizenships
    Private _otherpassports As List(Of PassportModels)
    Private _isanynids As Integer
    Private _nids As List(Of NationalIDs)
    Private _isanyhelthexamination As Integer
    Private _healthexamination As HealtExaminations
    Private _guidlocal As Guid
    Private _hasanyname As Integer
    Private _hasotherpassports As Integer
    ''' <summary>
    ''' Does this applicant have other current passports
    ''' </summary>
    ''' <returns></returns>
    Public Property hasOtherPassports() As Integer
        Get
            Return _hasotherpassports
        End Get
        Set(ByVal value As Integer)
            _hasotherpassports = value
        End Set
    End Property
    Public Property hasAnyOtherNames() As Integer
        Get
            Return _hasanyname
        End Get
        Set(ByVal value As Integer)
            _hasanyname = value
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
        Me._dateofbirth = DateTime.Now
        Me._relationshipstatus = New Maritalstatus()
        Me._passport = New PassportModels()
        Me._citizenship = New Citizenships()
        Me._placeofbirth = New Locations()
        Me._hasanyname = 2
        Me._hasotherpassports = 2
        Me._isanyhelthexamination = 2
        Me._isanynids = 2
    End Sub
    Public Property HealthExamination() As HealtExaminations
        Get
            Return _healthexamination
        End Get
        Set(ByVal value As HealtExaminations)
            _healthexamination = value
        End Set
    End Property
    ''' <summary>
    ''' Has this applicant undertaken a health examination for an Australian visa in the last 12 months
    ''' </summary>
    ''' <returns></returns>
    Public Property IsAnyHealthExamination() As Integer
        Get
            Return _isanyhelthexamination
        End Get
        Set(ByVal value As Integer)
            _isanyhelthexamination = value
        End Set
    End Property
    ''' <summary>
    ''' National identity documents
    ''' </summary>
    ''' <returns></returns>
    Public Property NationalIDs() As List(Of NationalIDs)
        Get
            Return _nids
        End Get
        Set(ByVal value As List(Of NationalIDs))
            _nids = value
        End Set
    End Property
    ''' <summary>
    ''' Does this applicant have national identity documents
    ''' </summary>
    ''' <returns></returns>
    Public Property IsAnyNIDs() As Integer
        Get
            Return _isanynids
        End Get
        Set(ByVal value As Integer)
            _isanynids = value
        End Set
    End Property
    ''' <summary>
    ''' Other passports
    ''' </summary>
    ''' <returns></returns>
    Public Property OtherPassports() As List(Of PassportModels)
        Get
            Return _otherpassports
        End Get
        Set(ByVal value As List(Of PassportModels))
            _otherpassports = value
        End Set
    End Property
    ''' <summary>
    ''' Citizenship
    ''' </summary>
    ''' <returns></returns>
    Public Property Citizenship() As Citizenships
        Get
            Return _citizenship
        End Get
        Set(ByVal value As Citizenships)
            _citizenship = value
        End Set
    End Property
    Public Property OtherNames() As List(Of OtherName)
        Get
            Return _othernames
        End Get
        Set(ByVal value As List(Of OtherName))
            _othernames = value
        End Set
    End Property
    ''' <summary>
    ''' Relationship status
    ''' </summary>
    ''' <returns></returns>
    Public Property RelationsipStatus() As Maritalstatus
        Get
            Return _relationshipstatus
        End Get
        Set(ByVal value As Maritalstatus)
            _relationshipstatus = value
        End Set
    End Property
    Public Property PlaceofBirth() As Locations
        Get
            Return _placeofbirth
        End Get
        Set(ByVal value As Locations)
            _placeofbirth = value
        End Set
    End Property

    ''' <summary>
    ''' Passporr Details
    ''' </summary>
    ''' <returns></returns>
    Public Property Passport() As PassportModels
        Get
            Return _passport
        End Get
        Set(ByVal value As PassportModels)
            _passport = value
        End Set
    End Property
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
            Return If(Not String.IsNullOrEmpty(_familyname), _familyname, "Unknown")
        End Get
        Set(ByVal value As String)
            _familyname = value
        End Set
    End Property

End Class
Public Class Maritalstatus
    Private _relationshipstatus As String
    Private _dateofmarriage As DateTime
    Private _dateofintmarriage As DateTime
    Private _daterelbegan As DateTime

    Public Sub New()
        Me._dateofintmarriage = DateTime.Now
        Me._dateofmarriage = DateTime.Now
        Me._daterelbegan = DateTime.Now
    End Sub

    ''' <summary>
    ''' Date relationship began
    ''' </summary>
    ''' <returns></returns>
    Public Property DateRelBegan() As DateTime
        Get
            Return _daterelbegan
        End Get
        Set(ByVal value As DateTime)
            _daterelbegan = value
        End Set
    End Property
    ''' <summary>
    ''' Date of intended marriage
    ''' </summary>
    ''' <returns></returns>
    Public Property DateofIntMarriage() As DateTime
        Get
            Return _dateofintmarriage
        End Get
        Set(ByVal value As DateTime)
            _dateofintmarriage = value
        End Set
    End Property
    ''' <summary>
    ''' Date of marriage
    ''' </summary>
    ''' <returns></returns>
    Public Property DateofMarriage() As DateTime
        Get
            Return _dateofmarriage
        End Get
        Set(ByVal value As DateTime)
            _dateofmarriage = value
        End Set
    End Property
    ''' <summary>
    ''' Relationship status
    ''' </summary>
    ''' <returns></returns>
    Public Property RelationshipStatus() As String
        Get
            Return _relationshipstatus
        End Get
        Set(ByVal value As String)
            _relationshipstatus = value
        End Set
    End Property
End Class
Public Class OtherName
    Private _familyname As String
    Private _givenname As String
    Private _reason As Integer
    Private _guidlocal As Guid
    Private _details As String
    Public Property Details() As String
        Get
            Return _details
        End Get
        Set(ByVal value As String)
            _details = value
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
    End Sub
    ''' <summary>
    ''' Reason - Other Name
    ''' </summary>
    ''' <returns></returns>
    Public Property Reasone() As Integer
        Get
            Return _reason
        End Get
        Set(ByVal value As Integer)
            _reason = value
        End Set
    End Property
    ''' <summary>
    ''' Given Name  - Other Name
    ''' </summary>
    ''' <returns></returns>
    Public Property GivenName() As String
        Get
            Return _givenname
        End Get
        Set(ByVal value As String)
            _givenname = value
        End Set
    End Property
    ''' <summary>
    ''' Family Name  - Other Name 
    ''' </summary>
    ''' <returns></returns>
    Public Property FamilyName() As String
        Get
            Return _familyname
        End Get
        Set(ByVal value As String)
            _familyname = value
        End Set
    End Property
    Private _strreason As String
    Public ReadOnly Property strReason() As String
        Get
            Select Case _reason
                Case 1
                    _strreason = "Not Selected"
                Case 2
                    _strreason = "Deed Poll"
                Case 3
                    _strreason = "Marriage"
                Case 4
                    _strreason = "Other"
                Case Else
                    _strreason = "N/A"
            End Select
            Return _strreason
        End Get
    End Property
End Class
Public Class Citizenships
    Private _iscitizenofcountryofpp As Integer
    Private _iscitizenofany As Integer
    Private _countries As List(Of Integer)
    Private _strcountries As String
    Public Property strCountries() As String
        Get
            Return _strcountries
        End Get
        Set(ByVal value As String)
            _strcountries = value
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
        Me._iscitizenofany = 2
        Me._iscitizenofcountryofpp = 2
    End Sub
    Public ReadOnly Property Countries() As List(Of Integer)
        Get
            If Not String.IsNullOrEmpty(Me._strcountries) Then
                Dim _citiCountries = Me._strcountries.Split(",")
                Dim value As Int32
                Me._countries = Array.ConvertAll(_citiCountries,
                                            Function(str) New With {
                                                .IsInt = Int32.TryParse(str, value),
                                                .Value = value
                                            }).Where(Function(result) result.IsInt).
                                    Select(Function(result) result.Value).ToList()
            End If
            Return _countries
        End Get

    End Property
    ''' <summary>
    ''' Is this applicant a citizen of any other country
    ''' </summary>
    ''' <returns></returns>
    Public Property IsCitizenofAny() As Integer
        Get
            Return _iscitizenofany
        End Get
        Set(ByVal value As Integer)
            _iscitizenofany = value
        End Set
    End Property
    ''' <summary>
    ''' Is this applicant a citizen of the country of passport
    ''' </summary>
    ''' <returns></returns>
    Public Property IsCitizenofCountryofPp() As Integer
        Get
            Return _iscitizenofcountryofpp
        End Get
        Set(ByVal value As Integer)
            _iscitizenofcountryofpp = value
        End Set
    End Property
End Class
Public Class NationalIDs
    Private _familyname As String
    Private _givenname As String
    Private _typeofdoc As Integer
    Private _countryissues As Integer
    Private _guidlocal As Guid
    Private _idnumber As String

    Public Sub New()
        Me.Guid = Guid.NewGuid
    End Sub

    Public Property IdNumber() As String
        Get
            Return _idnumber
        End Get
        Set(ByVal value As String)
            _idnumber = value
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
    ''' <summary>
    ''' Country of Issue
    ''' </summary>
    ''' <returns></returns>
    Public Property CountryofIssue() As Integer
        Get
            Return _countryissues
        End Get
        Set(ByVal value As Integer)
            _countryissues = value
        End Set
    End Property
    ''' <summary>
    ''' Type of Document - NID
    ''' </summary>
    ''' <returns></returns>
    Public Property TypeOfDocument() As Integer
        Get
            Return _typeofdoc
        End Get
        Set(ByVal value As Integer)
            _typeofdoc = value
        End Set
    End Property
    ''' <summary>
    ''' Given Name - NID
    ''' </summary>
    ''' <returns></returns>
    Public Property GivenName() As String
        Get
            Return _givenname
        End Get
        Set(ByVal value As String)
            _givenname = value
        End Set
    End Property
    ''' <summary>
    ''' Family Name - NID
    ''' </summary>
    ''' <returns></returns>
    Public Property FamilyName() As String
        Get
            Return _familyname
        End Get
        Set(ByVal value As String)
            _familyname = value
        End Set
    End Property
    Public ReadOnly Property strTypeOfDocument() As String
        Get
            Dim _doctypes = New NidTypes()
            Return _doctypes.DocTypes.Where(Function(_doc) _doc.Key = Me.TypeOfDocument).First().Value
        End Get
    End Property
    Public ReadOnly Property strCountryName() As String
        Get
            Dim _countries = New Countries()
            Return _countries.GetSystemCountries().Where(Function(c) c.Key = Me.CountryofIssue).First().Value
        End Get
    End Property


End Class

Public Class NidTypes
    Private _doctypes As SortedDictionary(Of Integer, String)
    Public Property DocTypes() As SortedDictionary(Of Integer, String)
        Get
            Return _doctypes
        End Get
        Set(ByVal value As SortedDictionary(Of Integer, String))
            _doctypes = value
        End Set
    End Property
    Public Sub New()
        _doctypes = New SortedDictionary(Of Integer, String)
        _doctypes.Add(1, "Not Selected")
        _doctypes.Add(2, "Birth certificate")
        _doctypes.Add(3, "Drivers licence")
        _doctypes.Add(4, "Marriage certificate")
        _doctypes.Add(5, "National identity document")
        _doctypes.Add(6, "Other")
    End Sub
End Class
Public Class HealtExaminations
    Private _details As String
    Private _hapid As String
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
    ''' HAP ID 
    ''' </summary>
    ''' <returns></returns>
    Public Property HAPID() As String
        Get
            Return _hapid
        End Get
        Set(ByVal value As String)
            _hapid = value
        End Set
    End Property
    ''' <summary>
    ''' Details
    ''' </summary>
    ''' <returns></returns>
    Public Property Details() As String
        Get
            Return _details
        End Get
        Set(ByVal value As String)
            _details = value
        End Set
    End Property
End Class