<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    
    <p>
        <br />
        Pollution Index Service - Returns the Air Pollution Index for the provided city where the property is located</p>
    <p>
        &nbsp;</p>
    <p>
        URL: <a href="http://localhost:55108/Service1.svc?wsdl">http://localhost:55108/Service1.svc?wsdl</a></p>
    <p>
        &nbsp;</p>
    <p>
        Method - string getPollution(string city);</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        City Name:
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </p>
    <p>
        &nbsp;</p>
    <p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Check Pollution" />
    </p>
    <p>
        &nbsp;</p>
    <p>
        Pollution: <asp:Label ID="Label1" runat="server"></asp:Label>
    </p>
</asp:Content>
