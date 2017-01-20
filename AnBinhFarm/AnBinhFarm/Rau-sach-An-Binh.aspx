<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Rau-sach-An-Binh.aspx.cs" Inherits="AnBinhFarm.Rau_sach_An_Binh" %>

<%@ Register Src="~/WEBUSC/GroupProduct.ascx" TagPrefix="uc1" TagName="GroupProduct" %>
<%@ Register Src="~/WEBUSC/ProductList.ascx" TagPrefix="uc2" TagName="ProductList" %>


<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    <%=strTittle %>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="head" runat="server">
    <link href="Content/tooltip/stickytooltip.css" rel="stylesheet" />
    <script src="Content/tooltip/stickytooltip.js"></script>
    <meta name="Description" content='<%=Des %> | Rau sạch An Bình' />
    <meta name="Keywords" content='<%=KeyW %>  | Rau sạch An Bình' />
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
                        <uc2:ProductList runat="server" id="ProductList" />
                    </div>
                </div>
            </div>
        </div>
    </section>
</asp:Content>
