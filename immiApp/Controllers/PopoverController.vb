Imports System.Web.Mvc

Namespace Controllers
    Public Class PopoverController
        Inherits Controller

        ' GET: Popover
        Function Index() As ActionResult
            If Request.QueryString("popoverid") <> Nothing Then
                Dim _popovermodel = New PopoverViewModels(Request.QueryString("popoverid"))
                Return View(_popovermodel)
            End If
            Return View()
        End Function
    End Class
End Namespace