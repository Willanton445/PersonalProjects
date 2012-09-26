using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Net;
using System.Net.Mail;

// clsBusinessLayer
// This class handle the business logic of the application
public class clsBusinessLayer
{


	// SendMail method used to send mail from this application
	// Parameter names explain purpose of parameters
    public void SendEmail(string emailFrom, string emailTo, string emailSubject, string emailBody)
    {
 
        // Create mail object that will send mail
        SmtpClient mailObj = new SmtpClient();

		// This need to change based on your email Host
		// Many host will also need a username/password before
		// Permiting an application to send mail
		mailObj.Host = "localhost";

        
        // Send the message we were asked to send
        mailObj.Send(emailFrom, emailTo, emailSubject, emailBody);

        return;

    } // end SendEmail
}
