<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="NDSP.ascx.cs" Inherits="AnBinhFarm.WEBUSC.NDSP" %>
 <script src="/../Scripts/tab1.js" language="javascript"></script>
 <script src="/../Scripts/tab2.js"/></script>
<script>
    $(document).ready(function () {
        $("#tabs").tabs();
    });
</script>
<link rel="stylesheet" href="/../Scripts/cssfortab.css" type="text/css" />
<!--code tool tip phong hinh cho sp chính -->
<script type="text/javascript" src="/../Scripts/wz_tooltip.js"></script>
<style type="text/css">
    .style3
    {
        height: 5px;
    }
    .style4
    {
        font-size: 17px;
    }
    .style5
    {
        height: 7px;
    }
    
.boxlike
{
    
         width:235px;
         height:35px;
         position:absolute;
         top:10px;
         right:5px;
         z-index :1;
}

</style>
   <div class="boxtittlexanh">CHI TIẾT SẢN PHẨM :</div>
<div class="boxCTtrensp">
    <div class="boxCTHinh" onmouseover="Tip('<img id=hinhto src=<%=Hinhto%>>',HEIGHT,550, PADDING, 6, BGCOLOR, '#ffffff')"
        onmouseout="UnTip()">
        <asp:Image ID="Image1" CssClass="hinhND" runat="server" Height="341px" Width="310px" /><br />
        <asp:Label ID="lblMaSp" runat="server" Visible="false">
        </asp:Label><asp:Label ID="lblTenSp" runat="server" Visible="false"></asp:Label>
    </div>
    <div class="boxCTND">
        
        <div style='width: 50%; position: relative; float: left; color: #333333;'>
        <i><h1 class="tieudeSPlon">
            &nbsp;&nbsp;
            <asp:Label ID="lblTenSanP" runat="server" Text="Label"></asp:Label>
        </h1></i>
          <img src='/images/muiten.gif' />  Mã: <strong><i>
                <asp:Label ID="lblIdNAme" runat="server"></asp:Label> </i> </strong><br />
             <!--   Tình trạng:
                <asp:Label ID="lblTinhtrang" runat="server"></asp:Label><br /> -->
                <img src='/images/muiten.gif' /> Kích thước: <strong><i>
                <asp:Label ID="lblMauSac" runat="server"></asp:Label> </i> </strong>
                <br />
               <img src='/images/muiten.gif' /> Đơn vị tính: <strong><i>
                <asp:Label ID="lblChatlieu" runat="server"></asp:Label> </i> </strong>
                <br />
                <img src='/images/muiten.gif' /> Xuất xứ: <strong><i>
                <asp:Label ID="lblXuatxu" runat="server"></asp:Label> </i> </strong>
                <br />
                 <img src='/images/muiten.gif' /> Khuyến mãi: <strong><i>
                <asp:Label ID="lblKhuyenmai" runat="server"></asp:Label> </i> </strong>
                <br />
                <img src='/images/muiten.gif' /> Bảo hành: <strong><i> 12 tháng </i> </strong> <br />
                
                <img src='/images/muiten.gif' /> Giá bán: </strong><del><strong>
                    <asp:Label ID="lblGiaCu" runat="server"></asp:Label>
                </strong></del><strong>
                    <br /> </strong>
                <img src='/images/muiten.gif' /> <strong style="color: Red">Giá khuyến mãi</strong><strong>:
                    <asp:Label ID="lblGIAHT" runat="server" Font-Bold="True" Text="Label" ForeColor="Red"></asp:Label>
                </strong>&nbsp;<b><strong><asp:Label ID="lblGia" runat="server" Visible="False"></asp:Label>
                    <asp:Label ID="lblTenhinh" Visible="false" runat="server"></asp:Label>
                </strong>
                    <br />
                </b>
            <asp:Button ID="btnMua" runat="server" BackColor="#3366FF" CommandName="Mua" Font-Bold="True"
                ForeColor="White" Text="CHỌN MUA" OnClick="btnMua_Click" />
            <asp:DropDownList ID="ddlSoluong" runat="server" Height="22px" Width="42px">
            </asp:DropDownList>
            Sản phẩm<br />
<img src='/images/muiten.gif' /> Ghi chú: <strong>Giá trên chưa bao gồm VAT và Phí vận chuyển </strong> <br />
<img src='/images/hot.gif' /> <b><a href='#'> KHUYẾN MÃI LỚN </a> </b>
        </div>
        <div class="traind">
            <div style="position: relative; width: 100%; float: left; height: 270px;">
                <table width="180px" style="padding-left: 5px; height: 162px;">
                    <tr>
                        <td colspan="2">
                            <img src='/images/lien-he.jpg' style="width: 214px; " />
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2" class="style4">
                            <strong>Kinh doanh: </strong>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2" class="style5">
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <strong>Ms. Thủy Tiên - 0903798246 </strong>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <a href="ymsgr:sendIM?hoaphatsaigon2">
                                <img alt="" src="http://opi.yahoo.com/online?u=hoaphatsaigon2&m=g&t=1" /></a>
                        </td>
                        <td>
                            <a href="skype:hoaphatsaigon2?chat">
                                <img src="http://download.skype.com/share/skypebuttons/buttons/chat_blue_transparent_97x23.png"
                                    style="border: none;" width="97" height="23" alt="Chat with me" /></a>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2" class="style3">
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <strong>Ms. Trần Loan - 0903798247</strong>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <a href="ymsgr:sendIM?hoaphatsaigon3">
                                <img alt="" src="http://opi.yahoo.com/online?u=hoaphatsaigon3&m=g&t=1" /></a>
                        </td>
                        <td>
                            <a href="skype:hoaphatsaigon3?chat">
                                <img src="http://download.skype.com/share/skypebuttons/buttons/chat_blue_transparent_97x23.png"
                                    style="border: none;" width="97" height="23" alt="Chat with me" /></a>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2" class="style3">
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <strong>Ms. Trần Tính - 0903798248 </strong>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <a href="ymsgr:sendIM?hoaphatsaigon7">
                                <img alt="" src="http://opi.yahoo.com/online?u=hoaphatsaigon7&m=g&t=1" /></a>
                        </td>
                        <td>
                            <a href="skype:hoaphatsaigon7?chat">
                                <img src="http://download.skype.com/share/skypebuttons/buttons/chat_blue_transparent_97x23.png"
                                    style="border: none;" width="97" height="23" alt="Chat with me" /></a>
                        </td>
                    </tr>
                </table>
            </div>
        </div>
       
    </div>
</div>
<div style="position: relative; float: left; width: 100%">
   <div class="boxlike">
   <div style="position:relative;width :50%; float:left; height:35px;margin-top:4px;" >
                <a class="addthis_button_facebook_like" id="like-button"></a>
                </div>
   <div style="position:relative;width :50%;float:left;height:35px;" ><script type="text/javascript" src="https://apis.google.com/js/plusone.js"></script>
<g:plusone></g:plusone></div>
   <script type="text/javascript">
       e = document.getElementByID('like-button');
       e.createAttribute('fb:like:send', 'true');
            </script>
   <script type="text/javascript" src="http://s7.addthis.com/js/250/addthis_widget.js"></script>
   </div>
    <div id="tabs">
        <ul>
            <li><a href="#tabs-1">Mô tả sp</a></li>
            <li><a href="#tabs-4">Tư vấn</a></li>
            <li><a href="#tabs-2">Giá khác</a></li>
            <li><a href="#tabs-3">Bình luận</a></li>
        </ul>
        <div id="tabs-1">
            <strong>Mô tả sản phẩm :</strong>
            <br />
            <%= noidungSp %>
        </div>
        <div id="tabs-4">
            <strong>Tư vấn:</strong>
            <br />
            <%= noidungMota %>
        </div>
        <div id="tabs-2">
            <strong>Sản phẩm nhiều giá :</strong>
            <br />
            <%= giakhac%>
        </div>
        <div id="tabs-3">
            <div style="padding: 5px">
                <b>Bình luận:</b><br />
                <%= binhluan %>
            </div>
            <div style="padding: 5px">
                <table style="background-color: #fafafa; width: 80%; float: left; position: relative;">
                    <tr>
                        <td>
                            Họ và tên
                        </td>
                        <td>
                            <asp:TextBox ID="txtHovaTen" runat="server" Width="358px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            Email:
                        </td>
                        <td>
                            <asp:TextBox ID="txtEmail" runat="server" Width="366px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            Nội dung bình luận
                        </td>
                        <td>
                            <asp:TextBox ID="txtNoidung" runat="server" Width="418px" Height="87px" TextMode="MultiLine"></asp:TextBox>
                        </td>
                    </tr>
                    <tr align="center">
                        <td colspan="2">
                            <asp:Button ID="btnGuibinhLuan" runat="server" Text="Gửi bình luận" OnClick="btnGuibinhLuan_Click" />
                        </td>
                    </tr>
                </table>
            </div>
        </div>
    </div>
</div>
