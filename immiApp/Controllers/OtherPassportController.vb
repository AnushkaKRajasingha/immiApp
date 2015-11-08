Imports System.Globalization
Imports System.Web.Mvc

Namespace Controllers
    Public Class OtherPassportController
        Inherits Controller

        ' GET: OtherPassport
        Function Index() As ActionResult
            Return View()
        End Function

        ' GET: OtherPassport/Details/5
        Function Details(ByVal id As Integer) As ActionResult
            Return View()
        End Function

        ' GET: OtherPassport/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: OtherPassport/Create
        <HttpPost()>
        Function Create(ByVal collection As FormCollection) As ActionResult
            Try
                ' TODO: Add insert logic here

                Return RedirectToAction("Index")
            Catch
                Return View()
            End Try
        End Function

        ' GET: OtherPassport/Edit/5
        Function Edit(ByVal id As Integer) As ActionResult
            Return View()
        End Function
        <HttpGet>
        Function Add() As ActionResult
            Return View("Add")
        End Function

        <HttpPost>
        Function Add(ByVal id As String) As ActionResult
            Try
                Dim _returnjson As JsonResult
                If Request.Form("_appGuid") Is Nothing Then
                    Return Json(New With {.message = "error : invalid application id"}, JsonRequestBehavior.AllowGet)
                End If
                Dim _guidStr = Request.Form("_appGuid").ToString()
                Dim _pageIndex = Convert.ToInt16(Request.Form("_stepNumber"))

                Using _db As New immiAppDbContext
                    Dim _appModel = (From _app In _db.ApplicationCollectio.
                                         Include("PrimaryApplicent").
                                         Include("PrimaryApplicent.OtherPassports")
                                     Where String.Equals(_app.Guid.ToString(), _guidStr)
                                     Select _app).First()
                    _appModel.Status = _pageIndex
                    Dim _otherPassport = New PassportModels() With {
                    .FamilyName = Request.Form("_2a0b0a0a0a4a0a0c0be4d-dlg-_0b0bj0a0a0d0a0b0a").ToString(),
                    .GivenName = Request.Form("_2a0b0a0a0a4a0a0c0be4d-dlg-_0b0bj0a0a0d0b0b0a").ToString(),
                    .Sex = Request.Form("_2a0b0a0a0a4a0a0c0be4d-dlg-_0b0bj0a0a0d1a1a"),
                    .Dateofbirth = New DateTime(
                            Convert.ToInt32(Request.Form("_2a0b0a0a0a4a0a0c0be4d-dlg-_0b0bj0a0a0d2a1a_year")),
                            DateTime.ParseExact(Request.Form("_2a0b0a0a0a4a0a0c0be4d-dlg-_0b0bj0a0a0d2a1a_month"), "MMM", CultureInfo.CurrentCulture).Month,
                            Convert.ToInt32(Request.Form("_2a0b0a0a0a4a0a0c0be4d-dlg-_0b0bj0a0a0d2a1a_day"))
                            ),
                     .PassportNumber = Request.Form("_2a0b0a0a0a4a0a0c0be4d-dlg-_0b0bj0a0a0e0a1a"),
                     .Country = Request.Form("_2a0b0a0a0a4a0a0c0be4d-dlg-_0b0bj0a0a0e1a1a"),
                     .Nationality = Request.Form("_2a0b0a0a0a4a0a0c0be4d-dlg-_0b0bj0a0a0e2a1a"),
                     .DateofIssue = New DateTime(
                            Convert.ToInt32(Request.Form("_2a0b0a0a0a4a0a0c0be4d-dlg-_0b0bj0a0a0e3a1a_year")),
                            DateTime.ParseExact(Request.Form("_2a0b0a0a0a4a0a0c0be4d-dlg-_0b0bj0a0a0e3a1a_month"), "MMM", CultureInfo.CurrentCulture).Month,
                            Convert.ToInt32(Request.Form("_2a0b0a0a0a4a0a0c0be4d-dlg-_0b0bj0a0a0e3a1a_day"))
                            ),
                     .DateofExpiry = New DateTime(
                            Convert.ToInt32(Request.Form("_2a0b0a0a0a4a0a0c0be4d-dlg-_0b0bj0a0a0e4a1a_year")),
                            DateTime.ParseExact(Request.Form("_2a0b0a0a0a4a0a0c0be4d-dlg-_0b0bj0a0a0e4a1a_month"), "MMM", CultureInfo.CurrentCulture).Month,
                            Convert.ToInt32(Request.Form("_2a0b0a0a0a4a0a0c0be4d-dlg-_0b0bj0a0a0e4a1a_day"))
                            ),
                      .PlaceofIssue = Request.Form("_2a0b0a0a0a4a0a0c0be4d-dlg-_0b0bj0a0a0e5a1a")
                    }
                    _appModel.PrimaryApplicent.OtherPassports.Add(_otherPassport)
                    _db.SaveChanges()

                    _returnjson = Json(_otherPassport, JsonRequestBehavior.AllowGet)
                End Using
                Return _returnjson
            Catch ex As Exception
                Return Json(New With {.message = "error : " + ex.Message}, JsonRequestBehavior.AllowGet)
            End Try
        End Function

        <HttpGet>
        Function Delete() As ActionResult
            Return View("Delete")
        End Function
        <HttpPost>
        Function Delete(ByVal id As String) As ActionResult
            Try
                Using _db As New immiAppDbContext
                    Dim _otherpp = (From _on In _db.PassportModels
                                    Where String.Equals(_on.Guid.ToString(), id)).First()
                    _db.PassportModels.Remove(_otherpp)
                    _db.SaveChanges()
                End Using
                Return Json(New With {.Guid = id}, JsonRequestBehavior.AllowGet)
            Catch ex As Exception
                Return Json(New With {.error = "Error : " + ex.Message}, JsonRequestBehavior.AllowGet)
            End Try
        End Function

        <HttpGet> <ActionName("Edit")>
        Function EditPage(ByVal id As String) As ActionResult
            'Return Json(New With {.message = "guid :" + id}, JsonRequestBehavior.AllowGet)
            Dim _otherpp = (From _on In New immiAppDbContext().PassportModels
                            Where String.Equals(_on.Guid.ToString(), id)).First()
            Return View("Edit", _otherpp)
        End Function
        <HttpPost>
        Function Edit(ByVal id As String) As ActionResult
            Try
                Dim _returnjson As JsonResult
                Dim _otherpp = New PassportModels()
                Using _db As New immiAppDbContext
                    _otherpp = (From _on In _db.PassportModels
                                Where String.Equals(_on.Guid.ToString(), id)).First()

                    _otherpp.FamilyName = Request.Form("_2a0b0a0a0a4a0a0c0be4d-dlg-_0b0bj0a0a0d0a0b0a").ToString()
                    _otherpp.GivenName = Request.Form("_2a0b0a0a0a4a0a0c0be4d-dlg-_0b0bj0a0a0d0b0b0a").ToString()
                    _otherpp.Sex = Request.Form("_2a0b0a0a0a4a0a0c0be4d-dlg-_0b0bj0a0a0d1a1a")
                    _otherpp.Dateofbirth = New DateTime(
                            Convert.ToInt32(Request.Form("_2a0b0a0a0a4a0a0c0be4d-dlg-_0b0bj0a0a0d2a1a_year")),
                            DateTime.ParseExact(Request.Form("_2a0b0a0a0a4a0a0c0be4d-dlg-_0b0bj0a0a0d2a1a_month"), "MMM", CultureInfo.CurrentCulture).Month,
                            Convert.ToInt32(Request.Form("_2a0b0a0a0a4a0a0c0be4d-dlg-_0b0bj0a0a0d2a1a_day"))
                            )
                    _otherpp.PassportNumber = Request.Form("_2a0b0a0a0a4a0a0c0be4d-dlg-_0b0bj0a0a0e0a1a")
                    _otherpp.Country = Request.Form("_2a0b0a0a0a4a0a0c0be4d-dlg-_0b0bj0a0a0e1a1a")
                    _otherpp.Nationality = Request.Form("_2a0b0a0a0a4a0a0c0be4d-dlg-_0b0bj0a0a0e2a1a")
                    _otherpp.DateofIssue = New DateTime(
                            Convert.ToInt32(Request.Form("_2a0b0a0a0a4a0a0c0be4d-dlg-_0b0bj0a0a0e3a1a_year")),
                            DateTime.ParseExact(Request.Form("_2a0b0a0a0a4a0a0c0be4d-dlg-_0b0bj0a0a0e3a1a_month"), "MMM", CultureInfo.CurrentCulture).Month,
                            Convert.ToInt32(Request.Form("_2a0b0a0a0a4a0a0c0be4d-dlg-_0b0bj0a0a0e3a1a_day"))
                            )
                    _otherpp.DateofExpiry = New DateTime(
                            Convert.ToInt32(Request.Form("_2a0b0a0a0a4a0a0c0be4d-dlg-_0b0bj0a0a0e4a1a_year")),
                            DateTime.ParseExact(Request.Form("_2a0b0a0a0a4a0a0c0be4d-dlg-_0b0bj0a0a0e4a1a_month"), "MMM", CultureInfo.CurrentCulture).Month,
                            Convert.ToInt32(Request.Form("_2a0b0a0a0a4a0a0c0be4d-dlg-_0b0bj0a0a0e4a1a_day"))
                            )
                    _otherpp.PlaceofIssue = Request.Form("_2a0b0a0a0a4a0a0c0be4d-dlg-_0b0bj0a0a0e5a1a")

                    _db.SaveChanges()
                    _returnjson = Json(_otherpp, JsonRequestBehavior.AllowGet)
                End Using
                Return _returnjson
            Catch ex As Exception
                Return Json(New With {.message = "error : " + ex.Message}, JsonRequestBehavior.AllowGet)
            End Try
        End Function
    End Class
End Namespace