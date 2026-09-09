<%@ Page Title="Data Grid" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="DataPage.aspx.cs" Inherits="DataPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:SqlDataSource ID="SqlDataSource1" runat="server"
        ConnectionString="<%$ ConnectionStrings:SurveyDB %>"
        SelectCommand="SELECT * FROM [UserInfo]">
    </asp:SqlDataSource>

    <asp:GridView ID="GridView1" runat="server"
        DataSourceID="SqlDataSource1"
        AllowPaging="True" AllowSorting="True" CellPadding="4" ForeColor="#333333" GridLines="None" Width="535px" AutoGenerateColumns="False" DataKeyNames="UserID">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:BoundField DataField="UserID" HeaderText="UserID" InsertVisible="False" ReadOnly="True" SortExpression="UserID" />
            <asp:BoundField DataField="FirstName" HeaderText="FirstName" SortExpression="FirstName" />
            <asp:BoundField DataField="FavoriteNumber" HeaderText="FavoriteNumber" SortExpression="FavoriteNumber" />
        </Columns>
        <EditRowStyle BackColor="#2461BF" />
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#EFF3FB" />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F5F7FB" />
        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
        <SortedDescendingCellStyle BackColor="#E9EBEF" />
        <SortedDescendingHeaderStyle BackColor="#4870BE" />
    </asp:GridView>
    <br/>
    <asp:Button ID="btnClickForDataReader" runat="server" Text="Data Reader Example - Debug Mode" OnClick="btnClickForDataReader_Click"></asp:Button>
    <br />
    <br/>
    <asp:Button ID="btnDeleteLastRecord" runat="server" Text="Execute NonQuery Example - Delete Last Record" OnClick="btnDeleteLastRecord_Click"></asp:Button>
</asp:Content>