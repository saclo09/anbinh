<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Tintuc.aspx.cs" Inherits="AnBinhFarm.Tintuc" %>
<%@ Register src="WEBUSC/ArticleByGroup.ascx" tagname="ArticleByGroup" tagprefix="uc1" %>
<%@ Register src="WEBUSC/HotArticle.ascx" tagname="HotArticle" tagprefix="uc2" %>
<%@ Register src="WEBUSC/SanphamBanChay.ascx" tagname="SanphamBanChay" tagprefix="uc3" %>
<asp:Content ID="Content4" ContentPlaceHolderID="title" runat="server">
<%= strTittle %>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
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
                        <div class="title">Rau sạch An Bình</div>
                        <div class="noidung">
                            Chúng tôi đã lắp đặt camera tại ruộng rau, nhà sơ chế,
                        điểm bán để bạn có thể theo dõi mọi hoạt động để tạo ra mớ rau từ khi gieo
                        hạt cho đến lúc mớ rau đến
                        </div>
                    </div>
                   <%-- <div class="row padding-tb20">
                        <uc1:GroupProduct runat="server" ID="GroupProduct" />
                    </div>--%>

                    <div class="row padding-tb20">
                         <uc1:ArticleByGroup ID="ArticleByGroup1" runat="server" />
                    </div>
                </div>
            </div>
        </div>
    </section>
   
</asp:Content>


