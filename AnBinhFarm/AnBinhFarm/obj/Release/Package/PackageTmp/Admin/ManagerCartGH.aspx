<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="ManagerCartGH.aspx.cs" Inherits="AnBinhFarm.Admin.ManagerCartGH" %>
<%@ Register src="usc/ManagerCart.ascx" tagname="ManagerCart" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
Quản lý giỏ hàng khách hàng đặt
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="tieudeAdmin"><center>Quản lý GIỎ HÀNG</center></div>
    <uc1:ManagerCart ID="ManagerCart1" runat="server" />
</asp:Content>
