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
                Dim _actionname = Request.QueryString("actionname")
                Dim _controllername = Request.QueryString("controllername")
                Dim _dialogModel = Nothing ' New DialogModels()
                If Request.QueryString("actionname") IsNot Nothing And Request.QueryString("controllername") IsNot Nothing Then
                    _dialogModel = New DialogModels()
                    _dialogModel.ActionName = Request.QueryString("actionname")
                    _dialogModel.ControllerName = Request.QueryString("controllername")
                End If

                If _controllername IsNot Nothing And _actionname IsNot Nothing Then
                    If Request.QueryString("guid") IsNot Nothing Then
                        Return RedirectToAction(_actionname, _controllername, New With {.id = Request.QueryString("guid")})
                    Else
                        Return RedirectToAction(_actionname, _controllername)
                    End If
                    'Return View("~/Views/" + _controllername + "/" + _actionname + ".vbhtml")
                End If

                Select Case _modalid
                    Case _modalid
                        If _dialogModel IsNot Nothing Then
                            Return View(_modalid, _dialogModel)
                        Else
                            Return View(_modalid)
                        End If

                    Case Else
                        Return View("Empty")
                End Select
            End If
            Return View("Empty")
        End Function
    End Class
End Namespace