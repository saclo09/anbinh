<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="CommenManager.aspx.cs" Inherits="AnBinhFarm.Admin.CommenManager" %>
<%@ Register src="usc/ManagerComment.ascx" tagname="ManagerComment" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
Quản lý bình luận
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:ManagerComment ID="ManagerComment1" runat="server" />
</asp:Content>
