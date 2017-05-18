<%@ Page Title="Contact Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Contact.aspx.cs" Inherits="Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Contact me</h3>
    <address>
        1015 E University Drive<br />
        Tempe, AZ 85281<br />
        <abbr title="Phone">P:</abbr>
        (512)-413-1744
    </address>

    <address>
        <strong>Mail:</strong>   <a href="mailto:dmisra2@asu.edu">dmisra2@asu.edu</a><br />
    </address>
</asp:Content>
