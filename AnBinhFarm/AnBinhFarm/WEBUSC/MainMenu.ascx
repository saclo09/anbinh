<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MainMenu.ascx.cs" Inherits="AnBinhFarm.WEBUSC.MainMenu" %>
<%@ Import Namespace="HP_BLL" %>
<%@ Import Namespace="System.Web.Routing" %>
<nav class="navbar navbar-ab">
            <div class="container-fluid">
                <div class="navbar-header">
                    <button type="button" class="navbar-toggle" data-toggle="collapse" data-target="#mainNavbar">
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                    </button>
                    <a class="navbar-brand" href="#"></a>
                </div>
                <div class="collapse navbar-collapse" id="mainNavbar">
                    <asp:Repeater ID="rptMenu" runat="server" OnItemDataBound="ItemBound" > 
                        <HeaderTemplate>
                           <ul class="nav navbar-nav main-menu">
                        </HeaderTemplate>
                        <ItemTemplate >
                             <li class="dropdown">
                                 
                                <a 
                                    <%#(bool)Eval("HasChild")
                                ?"class='dropdown-toggle' data-toggle='dropdown'"
                                :"" %>   href="<%#:((bool)(Eval("IsArticle")) ? GetRouteUrl("ArticlePathRoute", new {path =Eval("LinkString")}) : Eval("LinkString")) %>">
                                    <%# Eval("Name") %> 
                                    <%#(bool)Eval("HasChild")?"<span class='caret'></span>":"" %></a>

                                 <asp:Repeater ID="ChildRepeater" runat="server"  > 
                                    <HeaderTemplate>
                                         <ul class="dropdown-menu">
                                    </HeaderTemplate>
                                    <ItemTemplate >
                                         <li>
                                            <a  href="<%#:(bool)(Eval("IsArticle"))?GetRouteUrl("ArticlePathRoute", new {path =Eval("LinkString")}) :Eval("LinkString") %>"><%# Eval("Name") %></a>
                                             </li>
                                    </ItemTemplate>
                                    <FooterTemplate>
                                        </ul>
                                    </FooterTemplate>
                                 </asp:Repeater>
                             </li>
                        </ItemTemplate>
                        <FooterTemplate>
                            </ul>
                        </FooterTemplate>
                    </asp:Repeater>
                    

                    <%--<ul class="nav navbar-nav main-menu">
                        <li class="active"><a href="Home.html">Trang chủ</a></li>
                        <li class="dropdown">
                            <a class="dropdown-toggle" data-toggle="dropdown" href="#">Khám phá <span class="caret"></span></a>
                            <ul class="dropdown-menu">
                                <li><a href="#">Page 1-1</a></li>
                                <li><a href="#">Page 1-2</a></li>
                                <li><a href="#">Page 1-3</a></li>
                            </ul>
                        </li>
                        <li class="dropdown">
                            <a class="dropdown-toggle" data-toggle="dropdown" href="sanpham-ds.html">Sản phẩm <span class="caret"></span></a>
                            <ul class="dropdown-menu">
                                <li><a href="sanpham-ds.html">Rau sạch An Bình</a></li>
                                <li><a href="">Quy trình sản xuất</a></li>
                                <li><a href="#">Tiêu chuẩn kiểm định</a></li>
                                <li><a href="#">Kênh phân phối</a></li>
                                <li><a href="#">An Bình Store</a></li>

                            </ul>
                        </li>
                        <li><a href="#">Cửa hàng</a></li>
                        <li><a href="#">Liên hệ</a></li>
                    </ul>--%>
                    <ul class="nav navbar-nav navbar-right action-menu">
                        <li><a href="#"><span class="glyphicon glyphicon-user"></span>Sign Up</a></li>
                        <li><a href="#"><span class="glyphicon glyphicon-log-in"></span>Login</a></li>
                    </ul>
                </div>
            </div>
        </nav>