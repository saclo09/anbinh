<%@ Page Title="" Language="C#" MasterPageFile="~/Empty.Master" AutoEventWireup="true" CodeBehind="giohang.aspx.cs" Inherits="HPSHOP.giohang" %>
<%@ Register src="WEBUSC/CartUS.ascx" tagname="CartUS" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
Giỏ hàng của bạn
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ND" runat="server">
    <uc1:CartUS ID="CartUS1" runat="server" />
</asp:Content>
