<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UsersList.aspx.cs" Inherits="RegistrationProject.UsersList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="Content/mydatagrid.css" rel="stylesheet" type="text/css" />
    <h1>Registered  Users</h1>
    <asp:GridView ID="GV_UsersList" runat="server" CssClass="mydatagrid" PagerStyle-CssClass="pager" HeaderStyle-CssClass="header" RowStyle-CssClass="rows">
    </asp:GridView>  
</asp:Content>
