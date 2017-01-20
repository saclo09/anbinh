<%@ Page Title="" Language="C#" MasterPageFile="~/Empty.Master" AutoEventWireup="true" CodeBehind="Gio-hang-cua-ban.aspx.cs" Inherits="HPSHOP.Gio_hang_cua_ban" %>
<%@ Register src="WEBUSC/BOOKCART.ascx" tagname="BOOKCART" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
Thông tin đặt hàng
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ND" runat="server">
    <div class="boxclear"></div>
    <uc1:BOOKCART ID="BOOKCART1" runat="server" />
    <div class="boxclear"></div>
</asp:Content>
