<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="GroupProduct.ascx.cs" Inherits="AnBinhFarm.WEBUSC.GroupProduct" %>
<%@ Import Namespace="HP_BLL" %>
<link href="../App_Themes/default/style.css" rel="stylesheet" type="text/css" />
<div style="float: left; position: relative; width: 100%;">
    <asp:Repeater ID="dsSP" runat="server">
        <ItemTemplate>
            <div class="khungsp" data-tooltip="<%#"sticky"+Eval("IdProduct").ToString()%>">
                <div class="text-center">
                    <asp:Label ID="TenSP" ForeColor="Blue" Font-Bold="true" runat="server" Visible="false" Text='<%# Eval("NameProduct") %>'></asp:Label>
                    <div style='width: 100%; position: relative; height: 12px; float: left'></div>
                    <a href="/Sp/<%# Eval("IdProduct") +"/"+BLL.convertURL(Eval("NameProduct").ToString())+".aspx"%>">
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
                            Text='<%# (float.Parse(Eval("Price").ToString())<=0)? "LIÊN HỆ": Eval("Price")+".000Đ" %>'></asp:Label>
                        <br />
                        <asp:Label ID="lblGia2" runat="server" Visible="false"
                            Text='<%#(float.Parse(Eval("Price").ToString())<=0)? "0": Eval("Price") %>'></asp:Label>
                    </div>
                </div>
                <div class="text-center">
                    <asp:Button ID="btnMua" runat="server" CommandName="Mua" Text="CHỌN MUA" />
                </div>
                <div style='width: 100%; position: relative; height: 5px; float: left'></div>
            </div>
        </ItemTemplate>
    </asp:Repeater>

    <div id='mystickytooltip' class='stickytooltip'>
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <div id="<%#"sticky"+Eval("IdProduct").ToString()%>" class="atip">
                    <div class="tieudeboxshow2">
                        <center> Nội dung sản phẩm </center>
                    </div>
                    <div class="ndboxshow2">
                        <center><asp:Label ID="lblTen" ForeColor="Blue" Font-Bold="true" runat="server" Text='<%# Eval("NameProduct") %>'></asp:Label></center>
                        <img alt='' src='/Images/Lixanh.png' height='15' width='15' />Mã sản phẩm:
                        <asp:Label ID="lblMasp" Font-Bold="true" runat="server" Text='<%# Eval("IDNameProduct") %>'></asp:Label><br />
                        <img alt='' src='/Images/Lixanh.png' height='15' width='15' />Kích thước:
                        <asp:Label ID="lblMausac" Font-Bold="true" runat="server" Text='<%# Eval("Color") %>'></asp:Label><br />
                        <img alt='' src='/Images/Lixanh.png' height='15' width='15' />Đơn vị tính:
                        <asp:Label ID="Label2" Font-Bold="true" runat="server" Text='<%# Eval("Material") %>'></asp:Label><br />
                        <img alt='' src='/Images/Lixanh.png' height='15' width='15' />Xuất xứ:
                        <asp:Label ID="lblXuatxu" Font-Bold="true" runat="server" Text='<%# (int.Parse(Eval("Manufacturer").ToString())>0)?  ManufacturerBLL.getManufacturerBYId((int)Eval("Manufacturer")).ManufacturerName :"" %>'></asp:Label><br />
                        <img alt='' src='/Images/Lixanh.png' height='15' width='15' />Tình trạng:
                        <asp:Label ID="lblTinhtrag" Font-Bold="true" runat="server" Text='<%# (int.Parse(Eval("Soluong").ToString())>0)?"Còn hàng":"Hết hàng" %>'></asp:Label><br />
                        <img alt='' src='/Images/Lixanh.png' height='15' width='15' />Khuyến mãi:
                        <asp:Label ID="Label3" Font-Bold="true" runat="server" Text='<%# (bool.Parse(Eval("IsGiamGiaPt").ToString())==true)? "Đang khuyến mãi":"Không" %>'></asp:Label><br />
                        <img alt='' src='/Images/Lixanh.png' height='15' width='15' /><strong style="color: Red"> Giá :<asp:Label ID="lblGias" runat="server" Text='<%# (float.Parse(Eval("Price").ToString())>0)? Eval("Price")+".000VNĐ":"Liên hệ" %>'></asp:Label></strong><br />
                    </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>
        <div class='stickystatus'></div>
    </div>
</div>
