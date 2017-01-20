<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="Sanpham.aspx.cs" Inherits="AnBinhFarm.Admin.Sanpham" %>
<%@ Register src="usc/SanPham.ascx" tagname="SanPham" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
thêm mới và sửa sản phẩm
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:SanPham ID="SanPham1" runat="server" />
</asp:Content>
