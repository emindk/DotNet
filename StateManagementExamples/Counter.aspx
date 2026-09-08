<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Counter.aspx.cs" Inherits="Counter.Counter" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <div style="text-align: center; padding-top: 50px;">
            <asp:Label ID="lblCounter" runat="server" Font-Size="X-Large" Text="0"></asp:Label><br /><br />
            <asp:Button ID="btnIncrement" runat="server" Text="Click Me!" OnClick="btnIncrement_Click" />
        </div>
    </main>

</asp:Content>
