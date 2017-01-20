<%@ Page Title="" Language="C#" MasterPageFile="~/In.Master" AutoEventWireup="true" CodeBehind="ctsp.aspx.cs" Inherits="HPSHOP.ctsp" %>
<%@ Register src="WEBUSC/NDSP.ascx" tagname="NDSP" tagprefix="uc1" %>
<%@ Register src="WEBUSC/SanphamBanChay.ascx" tagname="SanphamBanChay" tagprefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
<meta name="Description" content='<%=Des %> | Nội thất hòa phát | nội thất văn phòng' />
<meta name="Keywords" content='<%=KeyW %>  | Nội thất hòa phát | nội thất văn phòng' />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="leftChua" runat="server">
    <uc2:SanphamBanChay ID="SanphamBanChay1" runat="server" />
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ND" runat="server">
    <uc1:NDSP ID="NDSP1" runat="server" />
</asp:Content>
