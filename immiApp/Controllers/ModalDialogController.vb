Imports System.Web.Mvc

Namespace Controllers
    Public Class ModalDialogController
        Inherits Controller

        ' GET: ModelDialog
        Function Index() As ActionResult
            Return View()
        End Function

        Function LoadModal() As ActionResult
            If Request.QueryString("modalid") <> Nothing Then
                Dim _modalid = Request.QueryString("modalid")
                Select Case _modalid
                    Case _modalid
                        Return View(_modalid)
                    Case Else
                        Return View("Empty")
                End Select
            End If
            Return View("Empty")
        End Function
    End Class
End Namespace