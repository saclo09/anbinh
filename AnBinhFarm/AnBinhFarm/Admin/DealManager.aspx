<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="DealManager.aspx.cs" Inherits="AnBinhFarm.Admin.DealManager" %>
<%@ Register src="usc/DealManager.ascx" tagname="DealManager" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
Quản lý deal giảm giá
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:DealManager ID="DealManager1" runat="server" />
</asp:Content>
