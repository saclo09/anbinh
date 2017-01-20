<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="AnBinhFarm.Home2" %>
<%@ Register src="WEBUSC/Lhome.ascx" tagname="Lhome" tagprefix="uc1" %>
<%@ Register src="WEBUSC/DEAL.ascx" tagname="DEAL" tagprefix="uc2" %>
<%@ Register src="WEBUSC/NdChinh.ascx" tagname="NdChinh" tagprefix="uc3" %>
<%@ Register src="WEBUSC/NewAllArticle.ascx" tagname="NewAllArticle" tagprefix="uc4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    <%= title %>
</asp:Content>
    
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
    <meta name="Description" content='' />
    <meta name="Keywords" content='' />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="leftChua" runat="server">
    <uc1:Lhome ID="Lhome1" runat="server" />
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="CHUAHit" runat="server">
    <uc2:DEAL ID="DEAL1" runat="server" />
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="ND" runat="server">
    <uc3:NdChinh ID="NdChinh1" runat="server" />
    <uc4:NewAllArticle ID="NewAllArticle1" runat="server" />
</asp:Content>
