Partial Class pgEmail
    Inherits System.Web.UI.Page

	' We do not need this default method in this project,
	' so you can delete it if you want
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    End Sub

	' This is the method that our button calls
	' in order to send the message
    Protected Sub btnSend_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSend.Click

		' Because the SendMail method can through an exception, 
		' we should place it in a try/catch block
        Try
            ' Create our clsBusinessLayer object that will
            ' send the message for us
            Dim sendObj As New clsBusinessLayer

			' Send the email using data from the form
            sendObj.SendEmail(txtFrom.Text, txtTo.Text, txtSubject.Text, txtMessage.Text)

            ' Successful send - tell user
            Me.lblSts.Text = "Status: The message was sent successfully to: " & Me.txtTo.Text

        Catch ex As Exception
            ' Error when sending - tell user
            Me.lblSts.Text = "Status: An error has happened sending the email, " + ex.Message

        End Try

    End Sub
End Class
