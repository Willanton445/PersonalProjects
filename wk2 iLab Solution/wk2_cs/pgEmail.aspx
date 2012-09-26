<%@ Page Language="C#" AutoEventWireup="true" CodeFile="pgEmail.aspx.cs" Inherits="pgEmail" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>WEB460 Week 2 iLab Solution</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
<asp:Label ID="lblSts" runat="server" Text="Current Status: Ready to send."></asp:Label>
<br /><br />  <asp:Label ID="lblFrom" runat="server" Text="From"></asp:Label>
        &nbsp; &nbsp;
        <asp:TextBox ID="txtFrom" runat="server" Font-Bold="True" Text="myEmail@devry.edu" Width="151px"></asp:TextBox><br />
        <asp:Label ID="lblTo" runat="server" Text="To"></asp:Label>
        &nbsp; &nbsp; &nbsp;&nbsp;
        <asp:TextBox ID="txtTo" runat="server"></asp:TextBox><br />
        <asp:Label ID="lblSub" runat="server" Text="Subject"></asp:Label>
        <asp:TextBox ID="txtSubject" runat="server"></asp:TextBox><br />
        <asp:Label ID="lblMessage" runat="server" Text="Message"></asp:Label>
        <br />
        <asp:TextBox ID="txtMessage" runat="server" Height="202px" TextMode="MultiLine" Width="442px"></asp:TextBox>
        <br />
        <asp:Button ID="btnSend" runat="server"  OnClick="btnSend_Click"  Text="Send" /></div>
    </form>
</body>
</html>
