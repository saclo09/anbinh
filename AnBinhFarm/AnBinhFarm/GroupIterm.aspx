<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="GroupIterm.aspx.cs" Inherits="AnBinhFarm.chitiet.GroupIterm" %>
<%@ Register src="WEBUSC/GroupProduct.ascx" tagname="GroupProduct" tagprefix="uc1" %>
<%@ Register src="WEBUSC/ThongtinCART.ascx" tagname="ThongtinCART" tagprefix="uc2" %>

<%@ Register src="WEBUSC/GroupProductAndArticle.ascx" tagname="GroupProductAndArticle" tagprefix="uc3" %>

<%@ Register src="WEBUSC/HotArticle.ascx" tagname="HotArticle" tagprefix="uc4" %>

<%@ Register src="WEBUSC/SanphamBanChay.ascx" tagname="SanphamBanChay" tagprefix="uc5" %>
<%@ Register src="WEBUSC/LGroup.ascx" tagname="LGroup" tagprefix="uc6" %>

<%@ Register src="WEBUSC/ArticleByGroup.ascx" tagname="ArticleByGroup" tagprefix="uc7" %>

<%@ Register src="WEBUSC/Mappath.ascx" tagname="Mappath" tagprefix="uc8" %>

<asp:Content ID="Content3" ContentPlaceHolderID="title" runat="server">
<%= strTittle %>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<meta name="Description" content='<%=Des %> | Nội thất hòa phát | nội thất văn phòng' />
<meta name="Keywords" content='<%=KeyW %>  | Nội thất hòa phát | nội thất văn phòng' />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ND" runat="server">
    <uc8:Mappath ID="Mappath1" runat="server" />
    <div class="boxtittlexanh"><%=Tennhom %></div>
    <uc1:GroupProduct ID="GroupProduct1" runat="server" />
    <uc7:ArticleByGroup ID="ArticleByGroup1" runat="server" />

    

</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="CHUAHit" runat="server">
    <uc4:HotArticle ID="HotArticle1" runat="server" />
    
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="leftChua" runat="server">
    <uc6:LGroup ID="LGroup1" runat="server" />
    <div class="boxtittlexanh">Sản phẩm bán chạy</div>
    <uc5:SanphamBanChay ID="SanphamBanChay1" runat="server" />
</asp:Content>
    

  