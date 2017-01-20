<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="GroupItermManager.aspx.cs" Inherits="AnBinhFarm.Admin.GroupItermManager" %>
<%@ Register src="usc/ManagerGroupIterm.ascx" tagname="ManagerGroupIterm" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
Quản lý nhóm sản phẩm.
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:ManagerGroupIterm ID="ManagerGroupIterm1" runat="server" />
</asp:Content>
