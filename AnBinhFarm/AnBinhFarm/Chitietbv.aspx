<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Chitietbv.aspx.cs" Inherits="AnBinhFarm.Chitietbv" %>
<%@ Register src="WEBUSC/ArticleDetail.ascx" tagname="ArticleDetail" tagprefix="uc1" %>
<%@ Register src="WEBUSC/HotArticle.ascx" tagname="HotArticle" tagprefix="uc2" %>
<%@ Register src="WEBUSC/SpMoi.ascx" tagname="SpMoi" tagprefix="uc3" %>
<%@ Register src="WEBUSC/ArticleByGroup.ascx" tagname="ArticleByGroup" tagprefix="uc4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
<%=strtitle %>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
    <meta name="Description" content='<%=Des %> ' />
    <meta name="Keywords" content='<%=KeyW %>  ' />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
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
                        <
                    </div>
                   

                    <div class="row padding-tb20">
                        <uc1:ArticleDetail ID="ArticleDetail1" runat="server" />
                        <uc4:ArticleByGroup ID="ArticleByGroup1" runat="server" />
                    </div>
                </div>
            </div>
        </div>
    </section>
</asp:Content>

