<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="ProductManager.aspx.cs" Inherits="AnBinhFarm.Admin.ProductManager" %>
<%@ Register src="usc/ManagerProduct.ascx" tagname="ManagerProduct" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
Trang quản lý sản phấm
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:ManagerProduct ID="ManagerProduct1" runat="server" />
</asp:Content>
