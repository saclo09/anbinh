<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="NewDeal.aspx.cs" Inherits="AnBinhFarm.Admin.NewDeal" %>
<%@ Register src="usc/NewDeal.ascx" tagname="NewDeal" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:NewDeal ID="NewDeal1" runat="server" />
</asp:Content>
