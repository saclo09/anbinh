<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="ManagerAcountP.aspx.cs" Inherits="AnBinhFarm.Admin.ManagerAcountP" %>
<%@ Register src="usc/AccountManager.ascx" tagname="AccountManager" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:AccountManager ID="AccountManager1" runat="server" />
</asp:Content>
