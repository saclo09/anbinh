<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Lhome.ascx.cs" Inherits="AnBinhFarm.WEBUSC.Lhome" %>
<%@ Register src="SanphamBanChay.ascx" tagname="SanphamBanChay" tagprefix="uc1" %>
<%@ Register src="SpMoi.ascx" tagname="SpMoi" tagprefix="uc2" %>
<div class="boxtittlexanh">&nbsp;&nbsp;&nbsp; SẢN PHẨM MỚI</div>
<uc2:SpMoi ID="SpMoi1" runat="server" />
<div class="boxtittlexanh">&nbsp;&nbsp; SẢN PHẨM BÁN CHẠY</div>
<uc1:SanphamBanChay ID="SanphamBanChay1" runat="server" />
