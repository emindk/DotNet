<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Counter._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <div style="text-align: center; padding-top: 50px;">
            <asp:Button ID="btnCounter" runat="server" Text="Counter Example" OnClick="btnCounter_Click" /><br /><br />
            <asp:Button ID="btnMemberVariable" runat="server" Text="Member Variables Example" OnClick="btnMemberVariable_Click" /><br /><br />
            <asp:Button ID="btnQueryString" runat="server" Text="Query String Example" OnClick="btnQeuryString_Click" /><br /><br />
            <asp:Button ID="btnCookie" runat="server" Text="Cookie Example" OnClick="btnCookie_Click" /><br /><br />

        </div>
    </main>

</asp:Content>
