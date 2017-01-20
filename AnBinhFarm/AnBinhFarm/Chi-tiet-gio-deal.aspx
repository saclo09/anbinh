<%@ Page Title="" Language="C#" MasterPageFile="~/In.Master" AutoEventWireup="true" CodeBehind="Chi-tiet-gio-deal.aspx.cs" Inherits="HPSHOP.Chi_tiet_gio_hang" %>
<%@ Register src="WEBUSC/DealDetail.ascx" tagname="DealDetail" tagprefix="uc1" %>
<%@ Register src="WEBUSC/SanphamBanChay.ascx" tagname="SanphamBanChay" tagprefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
DEal giảm giá sản phẩm
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="leftChua" runat="server">
    <div class="boxtittlexanh">Sản phẩm bán chạy</div>
    <uc2:SanphamBanChay ID="SanphamBanChay1" runat="server" />
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ND" runat="server">
    <uc1:DealDetail ID="DealDetail1" runat="server" />
</asp:Content>
