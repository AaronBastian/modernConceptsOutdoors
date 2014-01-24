Imports System.Net
Imports System.Web.Http
Imports Newtonsoft.Json.Linq

Public Class ContactController
    Inherits ApiController

    ' POST api/contact
    Public Function PostValue(ByVal value As JObject) As ApiResult
        Dim theResult As New ApiResult
        Dim emailBody As New Email
        Dim emailResult As String
        With emailBody
            .name = value("name").ToString()
            .street = value("streetNumber").ToString()
            .City = value("city").ToString()
            .state = value("state").ToString()
            .zip = value("zip").ToString()
            .phone = value("phone").ToString()
            .message = value("message").ToString()
            .email = value("email").ToString()
        End With
        emailResult = Email.SendEmail(emailBody)
        If String.IsNullOrEmpty(emailResult) Then
            theResult.Success = True
            theResult.Model = "Email is sent"
        Else
            theResult.Success = False
            theResult.Errors.Add(emailResult)
        End If

        Return theResult
    End Function

End Class
