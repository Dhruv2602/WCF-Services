<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    
    <asp:Panel ID="Panel1" runat="server" BackColor="#ffff99" >
        <br />
        Gas Prices Service - Finds the cheapest gas price around the provided Zip Code<br />
        <br />
        URL: <a href="http://localhost:60272/Service1.svc?wsdl">http://localhost:60272/Service1.svc?wsdl</a> <br />
        <br />
        Method - string gasPrices(string latitude, string longitude)<br />
        <br />
        <br />
        Latitude:&nbsp;
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        Longitude:
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Get Cheapest Gas Price" />
        <br />
        <br />
        <br />
        Gas Price:&nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server"></asp:Label>
        <br />
        <br />

    </asp:Panel>

    
</asp:Content>
