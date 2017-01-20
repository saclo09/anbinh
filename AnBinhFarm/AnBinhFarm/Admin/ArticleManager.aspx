<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="ArticleManager.aspx.cs" Inherits="AnBinhFarm.Admin.ArticleManager" %>
<%@ Register src="usc/ManagerArticle.ascx" tagname="ManagerArticle" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
Quản lý bài viết
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:ManagerArticle ID="ManagerArticle1" runat="server" />
</asp:Content>
