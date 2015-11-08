Imports System.Globalization
Imports System.Web.Mvc

Namespace Controllers
    Public Class ApplicationController
        Inherits Controller

        ' GET: Application
        <Authorize>
        Function Index() As ActionResult
            Dim _apps = New ApplicationModels()
            Return View("ListApps", _apps.GetAllApplications())
        End Function
        <Authorize>
        Function Create() As ActionResult
            Return View("Index")
        End Function
        <Authorize>
        Function Delete() As ActionResult
            Dim _appModel = Nothing
            If RouteData.Values("id") <> Nothing Then
                Dim _db As New immiAppDbContext
                Dim _guidStr = RouteData.Values("id").ToString()

                Try
                    _appModel = (From _app In _db.ApplicationCollectio
                                 Where String.Equals(_app.Guid.ToString(), _guidStr)
                                 Select _app).First()
                    _appModel.Status = 0
                    _db.SaveChanges()

                Catch ex As ArgumentException
                    Debug.Write(ex.Message)
                End Try
            End If
            Return RedirectToAction("ListApps")
        End Function

        Function GetformSteps() As ActionResult
            'Return View("step25")
            If Request.Form("step_number") <> Nothing Then
                Dim _pageIndex = Convert.ToInt16(Request.Form("step_number"))
                Dim _appModel = Nothing
                If Request.Form("_appGuid") <> Nothing Then
                    Dim _db As New immiAppDbContext
                    Dim _guidStr = Request.Form("_appGuid").ToString()
                    Try
                        _appModel = New ApplicationModels().GetApplication(_guidStr)
                        _appModel.Status = _pageIndex
                        _db.SaveChanges()

                    Catch ex As ArgumentException
                        Debug.Write(ex.Message)
                    End Try
                End If
                If _appModel IsNot Nothing Then
                    Return View("step" & _pageIndex, _appModel)
                Else
                    Return View("step" & _pageIndex)
                End If

            End If
            Return View("Empty")
        End Function
        <Authorize>
        Function ListApps() As ActionResult
            'Dim _db As New immiAppDbContext()
            Dim _apps = New ApplicationModels()
            Return View(_apps.GetAllApplications())
        End Function
        Function Details() As ActionResult
            Dim _appModel = Nothing
            If RouteData.Values("id") <> Nothing Then
                Dim _db As New immiAppDbContext
                Dim _guidStr = RouteData.Values("id").ToString()

                Try
                    _appModel = New ApplicationModels().GetApplication(_guidStr)
                Catch ex As ArgumentException
                    Debug.Write(ex.Message)
                End Try
            End If

            Return View("Index", _appModel)
        End Function

        Function save() As ActionResult

            Using _db As New immiAppDbContext
                Dim _appModels
                If Request.Form("_appGuid") <> "" Then
                    Dim _guidStr = Request.Form("_appGuid").ToString()
                    _appModels = New ApplicationModels().GetApplication(_guidStr, _db)
                Else
                    _appModels = New ApplicationModels()
                    _db.ApplicationCollectio.Add(_appModels)
                End If


                If (Request.Form("_stepNumber") > 1) Then
                    _appModels.Status = 1
                    _appModels.CurrentLocation = New Locations() With {.OutSideAus = Request.Form("_2a0b0a0a0a4a0a0b0b1b1a"), .Location = Request.Form("_2a0b0a0a0a4a0a0b0b3c0b0"), .LeagalStatus = Request.Form("_2a0b0a0a0a4a0a0b0b3d0b0"), .Reason = Request.Form("_2a0b0a0a0a4a0a0b0b3f1b0")}
                    _appModels.ProspectiveMarriageVisa = New ProspectiveMarriagevisas() With {
                        .IsApplyingForaVisa = Request.Form("_2a0b0a0a0a4a0a0b0d1b1a0"),
                        .IsArriveinAusOn = Request.Form("_2a0b0a0a0a4a0a0b0d2b1a0"),
                        .RefNumberType = Request.Form("_2a0b0a0a0a4a0a0b0e3a1a"),
                        .TransRefNumber = Request.Form("_2a0b0a0a0a4a0a0b0e4a1a"),
                        .AusVisaLblNumber = Request.Form("_2a0b0a0a0a4a0a0b0e6a1a"),
                        .ApplicationId = Request.Form("_2a0b0a0a0a4a0a0b0e7a1a"),
                        .Relationship = New Relationships() With {
                            .SameAsTheSponsor = Request.Form("_2a0b0a0a0a4a0a0b0f1b1a0"),
                            .MarriedSB4VisaCeased = Request.Form("_2a0b0a0a0a4a0a0b0f2b1a0"),
                            .MarriedAfter1StArrinAus = Request.Form("_2a0b0a0a0a4a0a0b0f3b1a0"),
                            .StillInRelationship = Request.Form("_2a0b0a0a0a4a0a0b0f5b1a0"),
                            .EndDate = New DateTime(
                            Convert.ToInt32(Request.Form("_2a0b0a0a0a4a0a0b0f6a1a_year")),
                            DateTime.ParseExact(Request.Form("_2a0b0a0a0a4a0a0b0f6a1a_month"), "MMM", CultureInfo.CurrentCulture).Month,
                            Convert.ToInt32(Request.Form("_2a0b0a0a0a4a0a0b0f6a1a_day"))
                            ),
                            .ViolenceBySpon = Request.Form("_2a0b0a0a0a4a0a0b0f8a1a"),
                            .SponIsDeceased = Request.Form("_2a0b0a0a0a4a0a0b0f9a1a")
                        },
                        .HasCeased = Request.Form("_2a0b0a0a0a4a0a0b0f4b1a0")
                    }
                    _appModels.SubstantiveVisa = New SubstantiveVisas() With {.IsCurrentlyHolding = Request.Form("_2a0b0a0a0a4a0a0b0c1b1a0"), .CompellingReasons = Request.Form("_2a0b0a0a0a4a0a0b0c5b1a")}

                    If _appModels.PrimaryApplicent Is Nothing Then
                        _appModels.PrimaryApplicent = New ApplicantModels()
                    End If

                    If (Request.Form("_stepNumber") > 2) Then
                        ' Everytime initiate new applicent :(

                        ' _appModels.PrimaryApplicent = New ApplicantModels() With {
                        _appModels.PrimaryApplicent.ApplicentType = "primary"
                        _appModels.PrimaryApplicent.FamilyName = Request.Form("_2a0b0a0a0a4a0a0c0g0a0b0a")
                        _appModels.PrimaryApplicent.GivenName = Request.Form("_2a0b0a0a0a4a0a0c0g0b0b0a")
                        _appModels.PrimaryApplicent.Sex = Request.Form("_2a0b0a0a0a4a0a0c0g1a1a")
                        _appModels.PrimaryApplicent.Dateofbirth = New DateTime(
                            Convert.ToInt32(Request.Form("_2a0b0a0a0a4a0a0c0g2a1a_year")),
                            DateTime.ParseExact(Request.Form("_2a0b0a0a0a4a0a0c0g2a1a_month"), "MMM", CultureInfo.CurrentCulture).Month,
                            Convert.ToInt32(Request.Form("_2a0b0a0a0a4a0a0c0g2a1a_day"))
                            )
                        _appModels.PrimaryApplicent.Passport = New PassportModels() With {
                                .PassportNumber = Request.Form("_2a0b0a0a0a4a0a0c0h0a1a"),
                                .Country = Request.Form("_2a0b0a0a0a4a0a0c0h1a1a"),
                                .Nationality = Request.Form("_2a0b0a0a0a4a0a0c0h2a1a"),
                                .DateofIssue = New DateTime(
                                    Convert.ToInt32(Request.Form("_2a0b0a0a0a4a0a0c0h3a1a_year")),
                                    DateTime.ParseExact(Request.Form("_2a0b0a0a0a4a0a0c0h3a1a_month"), "MMM", CultureInfo.CurrentCulture).Month,
                                    Convert.ToInt32(Request.Form("_2a0b0a0a0a4a0a0c0h3a1a_day"))
                                    ),
                                .DateofExpiry = New DateTime(
                                    Convert.ToInt32(Request.Form("_2a0b0a0a0a4a0a0c0h4a1a_year")),
                                    DateTime.ParseExact(Request.Form("_2a0b0a0a0a4a0a0c0h4a1a_month"), "MMM", CultureInfo.CurrentCulture).Month,
                                    Convert.ToInt32(Request.Form("_2a0b0a0a0a4a0a0c0h4a1a_day"))
                                    ),
                                .PlaceofIssue = Request.Form("_2a0b0a0a0a4a0a0c0h5a1a")
                            }
                        _appModels.PrimaryApplicent.PlaceofBirth = New Locations() With {
                                .TownCity = Request.Form("_2a0b0a0a0a4a0a0c0j1a1a"),
                                .StateProvince = Request.Form("_2a0b0a0a0a4a0a0c0j2a1a"),
                                .Country = Request.Form("_2a0b0a0a0a4a0a0c0j3a1a0")
                            }
                        _appModels.PrimaryApplicent.RelationsipStatus = New Maritalstatus() With {
                                .RelationshipStatus = Request.Form("_2a0b0a0a0a4a0a0c0bb1a1a0"),
                                .DateofMarriage = New DateTime(
                                    Convert.ToInt32(Request.Form("_2a0b0a0a0a4a0a0c0ba2a1a_year")),
                                    DateTime.ParseExact(Request.Form("_2a0b0a0a0a4a0a0c0ba2a1a_month"), "MMM", CultureInfo.CurrentCulture).Month,
                                    Convert.ToInt32(Request.Form("_2a0b0a0a0a4a0a0c0ba2a1a_day"))
                                    ),
                                .DateofIntMarriage = New DateTime(
                                    Convert.ToInt32(Request.Form("_2a0b0a0a0a4a0a0c0ba3a1a_year")),
                                    DateTime.ParseExact(Request.Form("_2a0b0a0a0a4a0a0c0ba3a1a_month"), "MMM", CultureInfo.CurrentCulture).Month,
                                    Convert.ToInt32(Request.Form("_2a0b0a0a0a4a0a0c0ba3a1a_day"))
                                    ),
                                .DateRelBegan = New DateTime(
                                    Convert.ToInt32(Request.Form("_2a0b0a0a0a4a0a0c0ba4a1a_year")),
                                    DateTime.ParseExact(Request.Form("_2a0b0a0a0a4a0a0c0ba4a1a_month"), "MMM", CultureInfo.CurrentCulture).Month,
                                    Convert.ToInt32(Request.Form("_2a0b0a0a0a4a0a0c0ba4a1a_day"))
                                    )
                            }
                        _appModels.PrimaryApplicent.hasAnyOtherNames = Request.Form("_2a0b0a0a0a4a0a0c0bc1b1a0")
                        _appModels.PrimaryApplicent.Citizenship = New Citizenships() With {
                            .IsCitizenofCountryofPp = Request.Form("_2a0b0a0a0a4a0a0c0bd1b1a"),
                            .IsCitizenofAny = Request.Form("_2a0b0a0a0a4a0a0c0bd2b1a"),
                            .strCountries = Request.Form("_2a0b0a0a0a4a0a0c0bd5a1a0")
                            }
                        _appModels.PrimaryApplicent.hasOtherPassports = Request.Form("_2a0b0a0a0a4a0a0c0be1b1a")
                        _appModels.PrimaryApplicent.IsAnyNIDs = Request.Form("_2a0b0a0a0a4a0a0c0bf1b1a0")
                        _appModels.PrimaryApplicent.IsAnyHealthExamination = Request.Form("_2a0b0a0a0a4a0a0c0bh1b1a0")
                        _appModels.PrimaryApplicent.HealthExamination = New HealtExaminations() With {
                                .Details = Request.Form("_2a0b0a0a0a4a0a0c0bh2a1a"),
                                .HAPID = Request.Form("_2a0b0a0a0a4a0a0c0bh3a1a0")
                            }

                        '}

                    End If
                End If

                _db.SaveChanges()
                Return Json(_appModels.Guid)
            End Using

        End Function
    End Class
End Namespace