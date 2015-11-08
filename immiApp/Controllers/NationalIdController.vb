Imports System.Web.Mvc

Namespace Controllers
    Public Class NationalIdController
        Inherits Controller

        ' GET: NationalId
        Function Index() As ActionResult
            Return View()
        End Function

        ' GET: NationalId/Details/5
        Function Details(ByVal id As Integer) As ActionResult
            Return View()
        End Function

        ' GET: NationalId/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: NationalId/Create
        <HttpPost()>
        Function Create(ByVal collection As FormCollection) As ActionResult
            Try
                ' TODO: Add insert logic here

                Return RedirectToAction("Index")
            Catch
                Return View()
            End Try
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
                                         Include("PrimaryApplicent.NationalIDs")
                                     Where String.Equals(_app.Guid.ToString(), _guidStr)
                                     Select _app).First()
                    _appModel.Status = _pageIndex
                    Dim _niddoc = New NationalIDs() With {
                    .FamilyName = Request.Form("_2a0b0a0a0a4a0a0c0bf3d-dlg-_0b0bj0a0a0d0a1a0").ToString(),
                    .GivenName = Request.Form("_2a0b0a0a0a4a0a0c0bf3d-dlg-_0b0bj0a0a0d1a1a0").ToString(),
                     .TypeOfDocument = Convert.ToInt32(Request.Form("_2a0b0a0a0a4a0a0c0bf3d-dlg-_0b0bj0a0a0e0b0")),
                     .IdNumber = Request.Form("_2a0b0a0a0a4a0a0c0bf3d-dlg-_0b0bj0a0a0f0b0"),
                     .CountryofIssue = Convert.ToInt32(Request.Form("_2a0b0a0a0a4a0a0c0bf3d-dlg-_0b0bj0a0a0g0b0"))
                    }
                    _appModel.PrimaryApplicent.NationalIDs.Add(_niddoc)
                    _db.SaveChanges()

                    _returnjson = Json(_niddoc, JsonRequestBehavior.AllowGet)
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
                    Dim _niddoc = (From _on In _db.NationalIDs
                                   Where String.Equals(_on.Guid.ToString(), id)).First()
                    _db.NationalIDs.Remove(_niddoc)
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
            Dim _nicdoc = (From _on In New immiAppDbContext().NationalIDs
                           Where String.Equals(_on.Guid.ToString(), id)).First()
            Return View("Edit", _nicdoc)
        End Function
        <HttpPost>
        Function Edit(ByVal id As String) As ActionResult
            Try
                Dim _returnjson As JsonResult
                Dim _nicdoc = New NationalIDs()
                Using _db As New immiAppDbContext
                    _nicdoc = (From _on In _db.NationalIDs
                               Where String.Equals(_on.Guid.ToString(), id)).First()
                    _nicdoc.FamilyName = Request.Form("_2a0b0a0a0a4a0a0c0bf3d-dlg-_0b0bj0a0a0d0a1a0").ToString()
                    _nicdoc.GivenName = Request.Form("_2a0b0a0a0a4a0a0c0bf3d-dlg-_0b0bj0a0a0d1a1a0").ToString()
                    _nicdoc.TypeOfDocument = Request.Form("_2a0b0a0a0a4a0a0c0bf3d-dlg-_0b0bj0a0a0e0b0")
                    _nicdoc.IdNumber = Request.Form("_2a0b0a0a0a4a0a0c0bf3d-dlg-_0b0bj0a0a0f0b0")
                    _nicdoc.CountryofIssue = Request.Form("_2a0b0a0a0a4a0a0c0bf3d-dlg-_0b0bj0a0a0g0b0")
                    _db.SaveChanges()
                    _returnjson = Json(_nicdoc, JsonRequestBehavior.AllowGet)
                End Using
                Return _returnjson
            Catch ex As Exception
                Return Json(New With {.message = "error : " + ex.Message}, JsonRequestBehavior.AllowGet)
            End Try
        End Function
    End Class
End Namespace