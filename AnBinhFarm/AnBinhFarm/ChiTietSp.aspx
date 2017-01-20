<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ChiTietSp.aspx.cs" Inherits="AnBinhFarm.ChiTietSp" %>
<%@ Register src="WEBUSC/ChitietSP.ascx" tagname="ChitietSP" tagprefix="uc1" %>
<%@ Register src="WEBUSC/ND.ascx" tagname="ND" tagprefix="uc2" %>
<%@ Register src="WEBUSC/DetailSP.ascx" tagname="DetailSP" tagprefix="uc3" %>
<%@ Register src="WEBUSC/ThongtinCART.ascx" tagname="ThongtinCART" tagprefix="uc4" %>
<%@ Register src="WEBUSC/HotArticle.ascx" tagname="HotArticle" tagprefix="uc5" %>
<%@ Register src="WEBUSC/SanphamBanChay.ascx" tagname="SanphamBanChay" tagprefix="uc6" %>
<%@ Register src="WEBUSC/GroupProduct.ascx" tagname="GroupProduct" tagprefix="uc7" %>
<%@ Register src="WEBUSC/NDSP.ascx" tagname="NDSP" tagprefix="uc8" %>
<%@ Register src="WEBUSC/Mappath.ascx" tagname="Mappath" tagprefix="uc9" %>
<asp:Content ID="Content3" ContentPlaceHolderID="title" runat="server">
<%= tieude %> 
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<meta name="Description" content='<%=Des %> ' />
<meta name="Keywords" content='<%=KeyW %> ' />
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="MainContent" runat="server">
    <section class="">
        <div class="container">
            <div class="row">

                <div class="col-md-4 ">
                    <div>
                        <h4 class="title text-center">Rau sạch An Bình</h4>
                    </div>
                    <div class=" panel-ct blue-border-top">
                        <div class="title text-center">SẢN PHẨM</div>
                        <div class="">
                        </div>
                    </div>
                </div>

                <div class="col-md-8">

                    <div class="clearfix">
                        <ol class="breadcrumb pull-right">
                            <li class="breadcrumb-item"><a href="#">Home</a></li>
                            <li class="breadcrumb-item"><a href="#">Library</a></li>
                            <li class="breadcrumb-item active">Data</li>
                        </ol>
                    </div>
                    <div class=" panel-ct blue-border-top">
                        <uc8:NDSP ID="NDSP1" runat="server" />
                    </div>
                </div>
            </div>
        </div>
    </section>

</asp:Content>

