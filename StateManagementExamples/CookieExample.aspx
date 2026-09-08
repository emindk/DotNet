<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="CookieExample.aspx.cs" Inherits="Counter.CookieExample" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <div style="text-align: center; padding-top: 50px;">
            <asp:Label ID="lblMessage" runat="server"></asp:Label>
            <br />
            <br />
            Your name:
            <asp:TextBox ID="tbUsername" runat="server"></asp:TextBox>
            <asp:Button ID="btnCreateCookie" runat="server" OnClick="btnCreateCookie_Click" Text="Create Cookie" />
            <asp:Button ID="btnDeleteCookie" runat="server" OnClick="btnDeleteCookie_Click" Text="Delete Cookie" />
        </div>
    </main>

</asp:Content>
