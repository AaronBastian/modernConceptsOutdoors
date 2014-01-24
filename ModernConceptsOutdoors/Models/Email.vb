Imports System.Net.Mail

Public Class Email

    Property name As String
    Property street As String
    Property City As String
    Property state As String
    Property zip As String
    Property phone As String
    Property message As String
    Property email As String

    Shared Function SendEmail(messageData As Email) As String
        Dim theReturnValue As String = String.Empty
        Dim emailFrom As String
        If String.IsNullOrEmpty(messageData.email) Then
            emailFrom = "neversole.mco@gmail.com"
        Else
            emailFrom = messageData.email
        End If
        Dim mail As New System.Net.Mail.MailMessage
        With mail
            .To.Add("neversole.mco@gmail.com")
            .Body = "Name: " & messageData.name & vbCrLf
            .Body &= "Street Address: " & messageData.street & vbCrLf
            .Body &= "City: " & messageData.City & vbCrLf
            .Body &= "State: " & messageData.state & vbCrLf
            .Body &= "Zip: " & messageData.zip & vbCrLf
            .Body &= "Phone Number: " & messageData.phone & vbCrLf
            .Body &= "Email Address: " & messageData.email & vbCrLf
            .Body &= "Message: " & messageData.message & vbCrLf

            .From = New Net.Mail.MailAddress(emailFrom)
            .Sender = New Net.Mail.MailAddress("neversole.mco@gmail.com")
            .Subject = "Modern Concepts Outdoors Website"
        End With
        Dim mailSend As New System.Net.Mail.SmtpClient("smtp.gmail.com")
        With mailSend
            .EnableSsl = True
            .Port = 587
            .DeliveryMethod = SmtpDeliveryMethod.Network
            .UseDefaultCredentials = False
            .Credentials = New System.Net.NetworkCredential("neversole.mco", "Engineers3")
            Try
                .Send(mail)
            Catch ex As Exception
                theReturnValue = ex.ToString
            End Try
        End With
        Return theReturnValue
    End Function
End Class
