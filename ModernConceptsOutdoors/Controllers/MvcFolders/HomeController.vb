Public Class HomeController
    Inherits System.Web.Mvc.Controller

    '
    ' GET: /Home

    Function Index() As ActionResult
        Return View()
    End Function

    Function Blog() As ActionResult
        Return View()
    End Function

    Function OriginalSpiritLift() As ActionResult
        Return View()
    End Function

    Function SpiritLift2() As ActionResult
        Return View()
    End Function

    Function PhotosAndVideos() As ActionResult
        Return View()
    End Function

    Function ContactUs() As ActionResult
        Dim apiUri As String = Url.HttpRouteUrl("DefaultApi", New With {.controller = "Contact"})
        ViewBag.ApiUri = New Uri(Request.Url, apiUri).AbsoluteUri.ToString()
        Return View()
    End Function
End Class