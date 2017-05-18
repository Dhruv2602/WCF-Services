<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <asp:Panel ID="Panel1" runat="server" BackColor="Silver">
    <p>
        &nbsp;</p>
    
    
        <p>
            Nearby Services - Finds Gas Stations, Post Offices and Shopping Malls near the provided Zip Code.</p>
        <p>
            URL: <a href="http://localhost:59319/Service1.svc?wsdl">http://localhost:59319/Service1.svc?wsdl</a></p>
        <p>
            Methods - string nearbyGasStations(string latitude, string longitude)</p>
        <p>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; string nearbyPostOffices(string latitude, string longitude)</p>
        <p>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; string nearbyShoppingMalls(string latitude, string longitude)&nbsp;</p>
        <p>
            &nbsp;</p>
    
    
        <p>
            Enter Latitude:
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </p>
    
    
        <p>
            Enter Longitude:
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </p>
    
    
    <p>
        &nbsp;</p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Get Services" />
    </p>
    <p>
        &nbsp;</p>
    <p>
        Gas Stations Nearby:
        <asp:Label ID="Label1" runat="server"></asp:Label>
    </p>
    <p>
        :
    </p>
    <p>
        Post Offices Nearby:
        <asp:Label ID="Label2" runat="server"></asp:Label>
    </p>
    <p>
        &nbsp;</p>
    <p>
        Shopping Malls Nearby:
        <asp:Label ID="Label3" runat="server"></asp:Label>
    </p>
    
        </asp:Panel>
</asp:Content>
