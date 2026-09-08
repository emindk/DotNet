<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="PreserverMembers.aspx.cs" Inherits="Counter.PreserverMembers" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <div style="text-align: center; padding-top: 50px;">
            <asp:TextBox ID="txtValue" runat="server" TextMode="MultiLine" Columns="40" Rows="8" Text="This is a test of the PreserverMembers.aspx page" />
            <br />
            <asp:Button ID="btnSaveContents" runat="server" Text="Save Contents" OnClick="btnSaveContents_Click" />
            <asp:Button ID="btnLoadContents" runat="server" Text="Load Contents" OnClick="btnLoadContents_Click" />
        </div>
    </main>

</asp:Content>
