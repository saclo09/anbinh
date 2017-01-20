<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AnBinhFarm._Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    <%= title %>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
     <section class="">
            <div class="container">
                <div id="mainCarousel" class="carousel slide" data-ride="carousel">
                    <!-- Indicators -->
                    <ol class="carousel-indicators">
                        <li data-target="#mainCarousel" data-slide-to="0" class="active"></li>
                        <li data-target="#mainCarousel" data-slide-to="1"></li>
                        <li data-target="#mainCarousel" data-slide-to="2"></li>
                        <li data-target="#mainCarousel" data-slide-to="3"></li>
                    </ol>

                    <!-- Wrapper for slides -->
                    <div class="carousel-inner" role="listbox">
                        <div class="item active">
                            <img src="Uploads\images\rau-sach-1.jpg" alt="Rau sạch">
                        </div>

                        <div class="item">

                            <img src="Uploads\images\rau-sach-2.jpg" alt="Rau sạch">
                        </div>

                        <div class="item">
                            <img src="Uploads\images\rau-sach-3.jpg" alt="Rau sạch">
                        </div>

                        <div class="item">
                            <img src="Uploads\images\rau-sach-4.jpg" alt="Rau sạch">
                        </div>
                    </div>

                    <!-- Left and right controls -->
                    <a class="left carousel-control" href="#mainCarousel" role="button" data-slide="prev">
                        <span class="glyphicon glyphicon-chevron-left" aria-hidden="true"></span>
                        <span class="sr-only">Previous</span>
                    </a>
                    <a class="right carousel-control" href="#mainCarousel" role="button" data-slide="next">
                        <span class="glyphicon glyphicon-chevron-right" aria-hidden="true"></span>
                        <span class="sr-only">Next</span>
                    </a>
                </div>
            </div>
        </section>
        <section class="">
            <div class="container">
                <div class="row">

                    <div class="col-md-7 panel-ct">
                        <div class="img-title">
                            <img src="Uploads/images/bua-an-title.jpg" width="100%" /></div>
                        <div class="row">
                            <div class="col-md-6">
                                <img src="Uploads/images/bua-an.jpg" width="100%" />
                            </div>
                            <div class="col-md-6">
                                Bạn sẽ có một bữa cơm ngon với những đĩa rau sạch  ngon, giòn và ngọt,
                        cùng một cảm giác thoải mái vô cùng trong việc
                        thưởng thức những bữa cơm gia đình.
                            </div>
                        </div>

                    </div>

                    <div class="col-md-5">

                        <div class="quytrinh-ct panel-ct">
                            <div class="title">Rau sạch An Bình</div>
                            <div class="noidung">
                                Chúng tôi đã lắp đặt camera tại ruộng rau, nhà sơ chế,
                        điểm bán để bạn có thể theo dõi mọi hoạt động để tạo ra mớ rau từ khi gieo
                        hạt cho đến lúc mớ rau đến
                            </div>
                        </div>
                        <div class="thitruong-ct">
                            <div class="title">Thông tin thị trường</div>
                            <div class="noidung">
                                Hướng dẫn cách trồng rau sạch tại nhà bằng thùng
                        xốp chậu nhựa thủy canh trên ban công hoặc sân thượng.
                            </div>
                        </div>

                    </div>
                </div>


            </div>
        </section>

</asp:Content>
