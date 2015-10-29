Imports System.Web.Mvc

Namespace Controllers
    Public Class ApplicationController
        Inherits Controller

        ' GET: Application
        Function Index() As ActionResult
            Return View()
        End Function

        Function GetformSteps() As ActionResult
            'Return View("step25")
            If Request.Form("step_number") <> Nothing Then
                Dim _pageIndex = Convert.ToInt16(Request.Form("step_number"))
                Return View("step" & _pageIndex)
            End If
            Return View("Empty")
        End Function
    End Class
End Namespace