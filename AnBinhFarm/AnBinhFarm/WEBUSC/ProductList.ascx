<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ProductList.ascx.cs" Inherits="AnBinhFarm.WEBUSC.ProductList" %>
<%@ Import Namespace="HP_BLL" %>
<%@ Import Namespace="System.Web.Routing" %>
<link href="../App_Themes/default/style.css" rel="stylesheet" />
<div style="float: left; position: relative; width: 100%;">
    <asp:Repeater ID="dsSP" runat="server">
        <ItemTemplate>
            <div class="khungsp" data-tooltip="<%#"sticky"+Eval("IdProduct").ToString()%>">
                <div class="text-center">
                    <asp:Label ID="TenSP" ForeColor="Blue" Font-Bold="true" runat="server" Visible="false" Text='<%# Eval("NameProduct") %>'></asp:Label>
                    <div style='width: 100%; position: relative; height: 12px; float: left'></div>
                    <%--<a href="/Sp/<%# Eval("IdProduct") +"/"+BLL.convertURL(Eval("NameProduct").ToString())+".aspx"%>">--%>
                    <a href="<%#: GetRouteUrl("ProductByNameRoute", new {productName =BLL.convertURL(Eval("NameProduct").ToString()),productID=Eval("IdProduct")}) %>">
                        <asp:Image class="hinhSPnho" ID="ImageNHom" runat="server"
                            ToolTip='<%# Eval("NameProduct")%>'
                            AlternateText='<%# Eval("NameProduct")%>'
                            ImageUrl='<%#(Eval("Images")==null)?"~/Images/noimage.jpg": "~/Hinhsp/"+Eval("Images") %>' />
                    </a>
                    <asp:Label ID="tenhinh" runat="server" Text='<%# Eval("Images")%>' Visible="False"></asp:Label>
                </div>
                <div style="position: relative; width: 100%; float: left; clear: both;">
                    <div class="Ma">
                        <asp:Label ID="maTenSp" runat="server" Text='<%# Eval("IdNameProduct") %>'></asp:Label>
                    </div>
                    <div class="Gia">
                        <asp:Label ID="lblGia" runat="server"
                            Text='<%# (float.Parse(Eval("Price").ToString())<=0)? "LIÊN HỆ": Eval("Price")+".000Đ" %>'
                            Font-Bold="True" ForeColor="Red"></asp:Label>
                        <br />
                        <asp:Label ID="lblGia2" runat="server" Visible="false"
                            Text='<%#(float.Parse(Eval("Price").ToString())<=0)? "0": Eval("Price") %>'></asp:Label>
                    </div>
                </div>
                <div style='width: 100%; position: relative; height: 5px; float: left'></div>
            </div>
        </ItemTemplate>
    </asp:Repeater>

    <div id='mystickytooltip' class='stickytooltip'>
        <asp:Repeater ID="rptProductDetail" runat="server" OnItemDataBound="rptProductDetail_ItemDataBound">
            <ItemTemplate>
                <div id="<%#"sticky"+Eval("IdProduct").ToString()%>" class="atip">
                    <div class="tieudeboxshow2">
                        <center> Nội dung sản phẩm </center>
                    </div>
                    <div class="ndboxshow2">
                        <span class="text-center">
                            <asp:Label ID="lblTen" ForeColor="Blue" Font-Bold="true" runat="server" Text='<%# Eval("NameProduct") %>'></asp:Label></span>
                        <asp:Repeater ID="rptHarvestList" runat="server">
                            <ItemTemplate>
                                <div class="row">
                                    <div class="col-xs-3"><%#Eval("HarvestDate")%></div>
                                    <div class="col-xs-9"></div>
                                </div>
                            </ItemTemplate>
                        </asp:Repeater>

                        <img alt='' src='/Images/Lixanh.png' height='15' width='15' /><strong style="color: Red"> Giá :<asp:Label ID="lblGias" runat="server" Text='<%# (float.Parse(Eval("Price").ToString())>0)? Eval("Price")+".000VNĐ":"Liên hệ" %>'></asp:Label></strong><br />
                    </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>
        <div class='stickystatus'></div>
    </div>
</div>
