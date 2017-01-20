<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="GroupitermNew.aspx.cs" Inherits="AnBinhFarm.Admin.GroupitermNew" %>
<%@ Register src="usc/Groupnew.ascx" tagname="Groupnew" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
Sửa và thêm mới nhóm sản phẩm
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:Groupnew ID="Groupnew1" runat="server" />
</asp:Content>
