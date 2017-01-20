<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="ManufactureManager.aspx.cs" Inherits="AnBinhFarm.Admin.ManufactureManager" %>
<%@ Register src="usc/Manufacturer.ascx" tagname="Manufacturer" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
Quản lý hảng sản xuất
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:Manufacturer ID="Manufacturer1" runat="server" />
</asp:Content>
