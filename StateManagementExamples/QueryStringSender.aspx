<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="QueryStringSender.aspx.cs" Inherits="Counter.QueryStringSender" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main>
        <div style="text-align: center; padding-top: 50px;">
            <asp:ListBox ID="lstItems" runat="server" Height="180px">
                <asp:ListItem>Econo Sofa</asp:ListItem>
                <asp:ListItem>Supreme Leather Drapery</asp:ListItem>
                <asp:ListItem>Threadbare Carpet</asp:ListItem>
                <asp:ListItem>Antique Lamp</asp:ListItem>
                <asp:ListItem>Retro-Finish Jacuzzi</asp:ListItem>
            </asp:ListBox>
            <br />
            <asp:CheckBox ID="chkDetails" runat="server" Text="Show Full Details" /><br />
            <asp:Button ID="btnSaveContents" runat="server" Text="View Information" OnClick="cmdGo_Click" /><br />
            <asp:Label ID="lblError" runat="server"></asp:Label><br />
        </div>
    </main>
</asp:Content>
