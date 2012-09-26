' Import necessary libraries
Imports Microsoft.VisualBasic
Imports System.Net.Mail

Public Class clsBusinessLayer

	' SendMail method used to send mail from this application
	' Parameter names explain purpose of parameters
    Public Sub SendEmail(ByVal emailFrom As String, _
            ByVal emailTo As String, ByVal emailSubject As String, _
            ByVal emailBody As String)

		' Create mail object that will send mail
        Dim mailObj As New System.Net.Mail.SmtpClient

		' This need to change based on your email Host
		' Many host will also need a username/password before
		' Permiting an application to send mail
        mailObj.Host = "localhost"
        
        ' Send the message we were asked to send
        mailObj.Send(emailFrom, emailTo, emailSubject, emailBody)

    End Sub
End Class

