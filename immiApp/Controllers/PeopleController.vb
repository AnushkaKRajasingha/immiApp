Imports System.Web.Mvc

Namespace Controllers
    Public Class PeopleController
        Inherits Controller

        ' GET: People
        Function Index() As ActionResult
            'Return Json(New With {.message = "Test"}, JsonRequestBehavior.AllowGet)
            Return View()
        End Function


        ' GET: People/Details/5
        Function Details(ByVal id As Integer) As ActionResult
            Return View()
        End Function

        ' GET: People/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: People/Create
        <HttpPost()>
        Function Create(ByVal collection As FormCollection) As ActionResult
            Try
                ' TODO: Add insert logic here

                Return RedirectToAction("Index")
            Catch
                Return View()
            End Try
        End Function

        ' GET: People/Edit/5
        Function Edit(ByVal id As Integer) As ActionResult
            Return View()
        End Function

        ' POST: People/Edit/5
        <HttpPost()>
        Function Edit(ByVal id As Integer, ByVal collection As FormCollection) As ActionResult
            Try
                ' TODO: Add update logic here

                Return RedirectToAction("Index")
            Catch
                Return View()
            End Try
        End Function

        ' GET: People/Delete/5
        Function Delete(ByVal id As Integer) As ActionResult
            Return View()
        End Function

        ' POST: People/Delete/5
        <HttpPost()>
        Function Delete(ByVal id As Integer, ByVal collection As FormCollection) As ActionResult
            Try
                ' TODO: Add delete logic here

                Return RedirectToAction("Index")
            Catch
                Return View()
            End Try
        End Function
        <HttpPost()>
        Function addothernames() As ActionResult
            Return Json(New With {.message = "This action has been depricated"}, JsonRequestBehavior.AllowGet)
        End Function
    End Class
End Namespace