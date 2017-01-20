<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CartUS.ascx.cs" Inherits="AnBinhFarm.WEBUSC.CartUS" %>
    <style type="text/css">
       
        
        .style3
        {
            width: 225px;
        }
        .style4
        {
            width: 253px;
        }
        .style5
        {
            width: 164px;
        }
        .style6
        {
            width: 242px;
        }
       
        .style7
        {
            height: 26px;
        }
       
    </style>
    <script language="javascript" type="text/javascript">
        function Chon_tatca(Chk) {
            var xState = Chk.checked;
            var theBox = Chk;
            elm = theBox.form.elements;
            for (i = 0; i < elm.length; i++)
                if (elm[i].type == "checkbox" && elm[i].id != theBox.id) {
                    if (elm[i].checked != xState)
                        elm[i].click();
                }

        }

        function Chon_all(Chk) {
            tinh_trang = Chk.checked;
            elm = document.form1.elements;

            for (i = 0; i < elm.length; i++) {
                if (elm[i].type == "checkbox" && elm[i].id != Chk.id) {
                    //ktra chck phai la dieu khien chon xoa 
                    chuoi = elm[i].id
                    if (chuoi.search(eval("/Chk_xoa/")) > 0) {
                        if (elm[i].checked != tinh_trang)
                            elm[i].click();
                    }
                }
            }
        }

	</script>


        <div style="width:800px; margin:auto;">
        <table align="center" style="border-right: #336699 1px solid; border-top: #336699 1px solid;
            border-left: #336699 1px solid; border-bottom: #336699 1px solid" width="800">
            <tr>
                <td align="center" colspan="2" style="font-weight: bold; font-size: 14pt; color: #996600;
                    background-color: #f3edbb" valign="middle">
                    <asp:Image ID="Image1" runat="server" ImageAlign="AbsMiddle" ImageUrl="~/Images/Giohang.gif" />Giỏ
                    hàng của bạn</td>
            </tr>
            <tr>
                <td align="center" colspan="2" valign="top">
                    <asp:GridView ID="Luoi_gio_hang" runat="server" AutoGenerateColumns="False" BackColor="White"
                        BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" OnRowCommand="Luoi_gio_hang_RowCommand"
                        OnRowEditing="Luoi_gio_hang_RowEditing" OnRowUpdating="Luoi_gio_hang_RowUpdating"
                        ShowFooter="True" Width="100%">
                        <FooterStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                        <Columns>
                            <asp:BoundField DataField="Ten_sp" HeaderText="Tên sản phẩm" ReadOnly="True">
                                <ItemStyle Width="200px" />
                            </asp:BoundField>
                            <asp:BoundField DataField="MaTen" HeaderText="Mã Sp" ReadOnly="True" />
                            <asp:ImageField DataAlternateTextField="Image" DataImageUrlField="Image" 
                                DataImageUrlFormatString="~/Hinhsp/{0}"       HeaderText="Hình Ảnh" 
                                ReadOnly="True">
                                <ControlStyle Height="50px" Width="50px" />
                                <ItemStyle Width="100px" />
                            </asp:ImageField>
                            <asp:BoundField DataField="So_luong" HeaderText="Số lượng" />
                            <asp:CheckBoxField DataField="isDeal" HeaderText="IsDeal"  ReadOnly="True"/>
                            <asp:BoundField DataField="Don_gia" DataFormatString="{0}.000" HeaderText="Đơn g&#237;a"
                                HtmlEncode="False" ReadOnly="True" />
                            <asp:BoundField DataField="Thanh_tien" DataFormatString="{0}.000" HeaderText="Th&#224;nh tiền"
                                HtmlEncode="False" ReadOnly="True" />
                            <asp:CommandField CancelText="Kh&#244;ng" EditText="Sửa số lượng" ShowEditButton="True" UpdateText="Sửa" ButtonType="Button" />

                            <asp:TemplateField>
                                <HeaderTemplate>
                                    <asp:Button ID="Xoa" runat="server" CommandName="Xoa" Font-Bold="True" ForeColor="Teal"
                                        Text="Xóa" Width="40px" /><br />
                                    <asp:CheckBox ID="ChkAll" runat="server" OnClick="Chon_all(this);" Visible="True" />
                                </HeaderTemplate>

                                <ItemTemplate>
                                    <asp:CheckBox ID="Chk_xoa" runat="server" />
                                </ItemTemplate>

                                <FooterTemplate>
                                    <asp:Button ID="Xoa" runat="server" CommandName="Xoa" Font-Bold="True" ForeColor="Teal"
                                        Text="Xóa" Visible="False" Width="40px" />
                                </FooterTemplate>
                            </asp:TemplateField>

                        </Columns>
                        <RowStyle ForeColor="#000066" />
                        <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                        <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                    </asp:GridView>
                </td>
            </tr>
            <tr>
                <td align="right" style="border-top: #336699 1px solid; font-weight: bold; width: 50%;
                    color: #006699" valign="top">
                    Tổng số tiền: &nbsp;<br />
                    Tổng số mặt hàng chọn mua: &nbsp;</td>
                <td align="left" style="border-top: #336699 1px solid; width: 50%" valign="top">
                    &nbsp;<asp:Label ID="Tong_tien" runat="server" ForeColor="Red" Text="Label" ></asp:Label>
                    <br />
                    &nbsp;<asp:Label ID="Tong_so" runat="server" ForeColor="Red" Text="Label" ></asp:Label> </td>
            </tr>
        </table>
    
   <div class="boxclear"></div>
    <div class="boxtittlexanh">Chọn phương thức thanh toán</div> 
<table style="width:100%" cellpadding="3" cellspacing="3" >
    <tr>
        <td class="style5">
            <asp:RadioButton ID="rdoTienmat" Text="Tiền mặt" Checked="true" GroupName="phuongthuc"  runat="server" />
        </td>
        <td class="style3">
            <asp:RadioButton ID="rdoChuyenKhoan" Text="Chuyển khoản" runat="server" GroupName="phuongthuc"/>
        </td>
        <td class="style4">
            <asp:RadioButton ID="rdoBuuDien" Text="Bưu điện" runat="server" GroupName="phuongthuc" />
        </td>
        <td class="style6">
            <asp:RadioButton ID="rdo" Text="Trực tuyến" runat="server" GroupName="phuongthuc" />
        </td>
    </tr>
    <tr>
        <td class="style5">
           
                
                <b style="font-weight: bold;">Bạn e ngại về việc thanh toán qua thẻ?</b>
           
                
                Hãy chọn giải pháp trả tiền mặt cho nhân viên
                giao hàng của  khi bạn nhận được hàng!</div>
                <br />
                <br />
                <br />
                <br />
        </td>
        <td class="style3">
            <span style="color: rgb(51, 51, 51); font-family: 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 13px; font-style: normal; font-variant: normal; font-weight: bold; letter-spacing: normal; line-height: 18px; orphans: auto; text-align: left; text-indent: 0px; text-transform: none; white-space: normal; widows: auto; word-spacing: 0px; -webkit-text-size-adjust: auto; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); display: inline !important; float: none;">
            Chuyển khoản qua ngân hàng VIETCOMBANK cho chúng tôi theo thông tin:</span><ul 
                style="padding: 0px; margin: 0px 0px 9px 16px; list-style: disc; border: 0px; font-family: Arial, Helvetica, sans-serif; font-size: 12px; outline: 0px; vertical-align: baseline; font-weight: normal; color: rgb(51, 51, 51); font-style: normal; font-variant: normal; letter-spacing: normal; line-height: 18px; orphans: auto; text-align: left; text-indent: 0px; text-transform: none; white-space: normal; widows: auto; word-spacing: 0px; -webkit-text-size-adjust: auto; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255);">
                <li style="line-height: 18px; border: 0px; font-family: Arial, Helvetica, sans-serif; font-size: 12px; outline: 0px; padding: 0px; vertical-align: baseline; list-style: square;">
                    <span style="font-weight: bold;">Tên NH:</span><span 
                        class="Apple-converted-space">&nbsp;</span></li>
                <li style="line-height: 18px; border: 0px; font-family: Arial, Helvetica, sans-serif; font-size: 12px; outline: 0px; padding: 0px; vertical-align: baseline; list-style: square;">
                    <span style="font-weight: bold;">Chủ tài khoản:</span></li>
                <li style="line-height: 18px; border: 0px; font-family: Arial, Helvetica, sans-serif; font-size: 12px; outline: 0px; padding: 0px; vertical-align: baseline; list-style: square;">
                    <span style="font-weight: bold;">Số tài khoản:</span><span 
                        class="Apple-converted-space">&nbsp;</span></li>
                <li style="line-height: 18px; border: 0px; font-family: Arial, Helvetica, sans-serif; font-size: 12px; outline: 0px; padding: 0px; vertical-align: baseline; list-style: square;">
                    <span style="font-weight: bold;">Nội dung:</span><span 
                        class="Apple-converted-space">&nbsp;</span>Mua-Tên khách hàng-Tên sản phẩm</li>
            </ul>

            <br />

        </td>
        <td class="style4">
            <span style="color: rgb(51, 51, 51); font-family: 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 13px; font-style: normal; font-variant: normal; font-weight: bold; letter-spacing: normal; line-height: 18px; orphans: auto; text-align: left; text-indent: 0px; text-transform: none; white-space: normal; widows: auto; word-spacing: 0px; -webkit-text-size-adjust: auto; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); display: inline !important; float: none;">
            Quý khách vui lòng gửi tiền trực tiếp về VP công ty chúng tồi qua đường bưu điện 
            theo địa chỉ:</span><br 
                style="color: rgb(51, 51, 51); font-family: 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 13px; font-style: normal; font-variant: normal; font-weight: bold; letter-spacing: normal; line-height: 18px; orphans: auto; text-align: left; text-indent: 0px; text-transform: none; white-space: normal; widows: auto; word-spacing: 0px; -webkit-text-size-adjust: auto; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255);" />
            <span style="color: rgb(51, 51, 51); font-family: 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 13px; font-style: normal; font-variant: normal; font-weight: bold; letter-spacing: normal; line-height: 18px; orphans: auto; text-align: left; text-indent: 0px; text-transform: none; white-space: normal; widows: auto; word-spacing: 0px; -webkit-text-size-adjust: auto; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); display: inline !important; float: none;">
            Miền Nam:</span><p 
                style="margin: 0px 0px 9px 16px; font-family: 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 13px; line-height: 18px; font-weight: normal; color: rgb(51, 51, 51); font-style: normal; font-variant: normal; letter-spacing: normal; orphans: auto; text-align: left; text-indent: 0px; text-transform: none; white-space: normal; widows: auto; word-spacing: 0px; -webkit-text-size-adjust: auto; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255);">
                &nbsp;</p>
            <span style="color: rgb(51, 51, 51); font-family: 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 13px; font-style: normal; font-variant: normal; font-weight: bold; letter-spacing: normal; line-height: 18px; orphans: auto; text-align: left; text-indent: 0px; text-transform: none; white-space: normal; widows: auto; word-spacing: 0px; -webkit-text-size-adjust: auto; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); display: inline !important; float: none;">
            Miền Trung:</span><p 
                style="margin: 0px 0px 9px 16px; font-family: 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 13px; line-height: 18px; font-weight: normal; color: rgb(51, 51, 51); font-style: normal; font-variant: normal; letter-spacing: normal; orphans: auto; text-align: left; text-indent: 0px; text-transform: none; white-space: normal; widows: auto; word-spacing: 0px; -webkit-text-size-adjust: auto; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255);">
                &nbsp;</p>
            <span style="color: rgb(51, 51, 51); font-family: 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 13px; font-style: normal; font-variant: normal; font-weight: bold; letter-spacing: normal; line-height: 18px; orphans: auto; text-align: left; text-indent: 0px; text-transform: none; white-space: normal; widows: auto; word-spacing: 0px; -webkit-text-size-adjust: auto; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); display: inline !important; float: none;">
            Miền Bắc:</span><p 
                style="margin: 0px 0px 9px 16px; font-family: 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 13px; line-height: 18px; font-weight: normal; color: rgb(51, 51, 51); font-style: normal; font-variant: normal; letter-spacing: normal; orphans: auto; text-align: left; text-indent: 0px; text-transform: none; white-space: normal; widows: auto; word-spacing: 0px; -webkit-text-size-adjust: auto; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255);">
                &nbsp;</p>
        </td>
        <td class="style6">
            <ul style=" margin: 0px 0px 9px 16px; list-style: disc;  font-family: Arial, Helvetica, sans-serif; font-size: 12px; outline: 0px; vertical-align: baseline; font-weight: normal; color: rgb(51, 51, 51); font-style: normal; font-variant: normal; letter-spacing: normal; line-height: 18px; orphans: auto; text-align: left; text-indent: 0px; text-transform: none; white-space: normal; widows: auto; word-spacing: 0px; -webkit-text-size-adjust: auto; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255);">
                <li style="line-height: 18px; border: 0px; font-family: Arial, Helvetica, sans-serif; font-size: 12px; outline: 0px; padding: 0px; vertical-align: baseline; list-style: square;">
                   &nbsp;Không mất phí thanh toán</li>
                <li style="line-height: 18px; border: 0px; font-family: Arial, Helvetica, sans-serif; font-size: 12px; outline: 0px; padding: 0px; vertical-align: baseline; list-style: square;">
                    Thẻ của Quý khách phải được kích hoạt chức năng thanh toán trực tuyến hoặc đã 
                    đăng ký Internet Banking</li>
                <li style="line-height: 18px; border: 0px; font-family: Arial, Helvetica, sans-serif; font-size: 12px; outline: 0px; padding: 0px; vertical-align: baseline; list-style: square;">
                    Thanh toán nhanh gọn và có thể sử dụng ngay sau khi thanh toán</li>

            </ul>
            <br />
            <br />
        </td>
    </tr>    
</table>
<div class="boxtittlexanh"> Thông tin người mua</div>
<table class="style1">
    <tr>
        <td class="style7">
            Họ và tên</td>
        <td class="style7">
            <asp:TextBox ID="txtHoten" runat="server" Width="311px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            Số điện thoại</td>
        <td>
            <asp:TextBox ID="txtSodienthoai" runat="server" Width="158px"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                ControlToValidate="txtSodienthoai" ErrorMessage="Số điện thoại không đúng" 
                ValidationExpression="^\d+$" ValidationGroup="check" ForeColor="Red"></asp:RegularExpressionValidator>
        </td>
    </tr>
    <tr>
        <td>
            Địa chỉ</td>
        <td>
            <asp:TextBox ID="txtDiaChi" runat="server" Width="453px" Height="48px" 
                TextMode="MultiLine"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            Email
        </td>
        <td>
            <asp:TextBox ID="txtEmail" runat="server" Width="338px"></asp:TextBox>
            <asp:RegularExpressionValidator ID="regEmail" ControlToValidate="txtEmail" Text="Địa chỉ email không đúng."
            ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
                runat="server" ForeColor="Red" />
        </td>
    </tr>
    <tr>
        <td>
            Nội dung cần nhắn gửi</td>
        <td>
            <asp:TextBox ID="txtNote" runat="server" Height="60px" TextMode="MultiLine" 
                Width="473px"></asp:TextBox>
        </td>
    </tr>
     <tr>
        <td colspan="2">
            <asp:CheckBox ID="ckbOk"  runat="server" />Bạn chắc chắn đã đồng ý với phương thức <a href="/phuong-thuc-thanh-toan.aspx" target="_blank">thanh toán</a>,
            <a href="/chi-phi-van-chuyen.aspx" target="_blank"> vận chuyển</a> và <a href="/quy-dinh-doi-va-tra-hang.aspx" target="_blank">đổi trả hàng</a> của chúng tôi
         </td>
    </tr>
     <tr>
        <td colspan="2">
            <asp:Button ID="btnMua" runat="server" Text="Mua giỏ hàng" BackColor="Lime" 
                Font-Bold="True" ForeColor="Red" onclick="btnMua_Click1" />
         </td>
    </tr>
   
    </table>
    
 </div>


   






   

