<%@ Page Title="" Language="C#" MasterPageFile="~/In.Master" AutoEventWireup="true" CodeBehind="Search.aspx.cs" Inherits="HPSHOP.Search" %>
<%@ Register src="WEBUSC/QKtimKiem.ascx" tagname="QKtimKiem" tagprefix="uc1" %>
<%@ Register src="WEBUSC/ThongtinCART.ascx" tagname="ThongtinCART" tagprefix="uc2" %>
<%@ Register src="WEBUSC/Lhome.ascx" tagname="Lhome" tagprefix="uc3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ND" runat="server">
    <uc1:QKtimKiem ID="QKtimKiem1" runat="server" />
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="leftChua" runat="server">
    
    <uc3:Lhome ID="Lhome1" runat="server" />
    
</asp:Content>
