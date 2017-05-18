<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="store">
        <asp:Panel ID="Panel2" runat="server" BackColor="LightCyan">
    

    <p>
        Nearest Store Service - Finds the required store nearest to the given zip code</p>
    <p>
        URL: <a href="http://localhost:57822/Service1.svc?wsdl">http://localhost:57822/Service1.svc?wsdl</a></p>
    <p>
        Method - string findNearestStore(string zipcode, string storeName);</p>
    <p>
        Zip code:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    </p>
    <p>
        Store Name:&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    </p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Find Nearest Store" />
    </p>
    <p>
        &nbsp;</p>
    <p>
        Address:&nbsp;&nbsp;
        <asp:Label ID="Label2" runat="server"></asp:Label>
    </p>
        </asp:Panel>
        </div>

    <div class="news">
        <asp:Panel ID="Panel1" runat="server" BackColor="LightYellow">
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
            <p>
        News Focus Service - Finds the top news articles about the required topic</p>
    <p>
        URL:
        <a href="http://localhost:51273/Service1.svc?wsdl">http://localhost:51273/Service1.svc?wsdl</a></p>
    <p>
        Method - string[] NewsFocus(string[] topics)</p>
    <p>
        Enter topics separated by comma:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server" style="margin-bottom: 0px" Width="535px"></asp:TextBox>
    </p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Text="Get Topics" OnClick="Button1_Click"/>
    </p>
    <p>
        &nbsp;</p>
            
<p>
    News Topics returned:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label1" runat="server"></asp:Label>
</p>
        </asp:Panel>
        </div>
    
    
    
</asp:Content>

