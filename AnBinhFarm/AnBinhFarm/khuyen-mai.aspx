<%@ Page Title="" Language="C#" MasterPageFile="~/In.Master" AutoEventWireup="true" CodeBehind="khuyen-mai.aspx.cs" Inherits="HPSHOP.khuyen_mai" %>
<%@ Register src="WEBUSC/SanphamBanChay.ascx" tagname="SanphamBanChay" tagprefix="uc1" %>
<%@ Register src="WEBUSC/bvKM.ascx" tagname="bvKM" tagprefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
khuyến mãi mới nhất
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="leftChua" runat="server">
    <div class="boxtittlexanh">Sản phẩm bán chạy</div>
    <uc1:SanphamBanChay ID="SanphamBanChay1" runat="server" />
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ND" runat="server">
    <uc2:bvKM ID="bvKM1" runat="server" />

</asp:Content>
