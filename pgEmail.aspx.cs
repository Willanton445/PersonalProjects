using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class pgEmail : System.Web.UI.Page
{
	
	// We do not need this default method in this project,
	// so you can delete it if you want
    protected void Page_Load(object sender, EventArgs e)
    {
      //  Page.Form.DefaultButton = btnSend.UniqueID;
    }

    protected void btnSend_Click(object sender, EventArgs e)
    {  
   		// Because the SendMail method can through an exception, 
		// we should place it in a try/catch block
       try
        {
            // Create our clsBusinessLayer object that will
            // send the message for us
            clsBusinessLayer sendObj = new clsBusinessLayer();

			// Send the email using data from the form
            sendObj.SendEmail(txtFrom.Text, txtTo.Text, txtSubject.Text, txtMessage.Text);

            // Successful send - tell user
            lblSts.Text = "Status: The message was sent successfully to: " + txtFrom.Text;
        }
        catch (Exception ex)
        {
            // Error when sending - tell user
            lblSts.Text = "Status: An error has happened sending the email, " + ex.Message;
        }
        return;
    } // end btnSend_Click
}
