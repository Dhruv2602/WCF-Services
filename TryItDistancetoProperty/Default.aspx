<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    
    <p>
        <br />
    </p>
    <asp:Panel ID="Panel1" runat="server" BackColor="Tan">
        Distance to Property Service - Gets the distance between the property and given location<br />
        <br />
        URL: <a href="http://localhost:51316/Service1.svc?wsdl">http://localhost:51316/Service1.svc?wsdl</a>
        <br />
        <br />
        Method - string getDistance(string origin, string dest)<br />
        <br />
        <br />
        Property Zipcode:
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        Location Zipcode:
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Get Distance" />
        <br />
        <br />
        <br />
        Distance:
        <asp:Label ID="Label1" runat="server"></asp:Label>

    </asp:Panel>

    
</asp:Content>
