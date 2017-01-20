<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ManagerCart.ascx.cs" Inherits="AnBinhFarm.Admin.usc.ManagerCart" %>
<style type="text/css">
    
   
   
   
</style>
<div>
    <asp:GridView ID="grvGioHang" runat="server" AutoGenerateColumns="False" 
        BackColor="White" BorderColor="#3333FF" BorderStyle="None" BorderWidth="1px" 
        CellPadding="4" Width="708px" onrowcommand="grvGioHang_RowCommand" 
        AllowPaging="True" onpageindexchanging="grvGioHang_PageIndexChanging" 
         >
        <Columns>
            <asp:BoundField HeaderText="Mã GH" DataField="IdCart" >
            <ControlStyle Width="30px" />
            <ItemStyle Width="30px" />
            </asp:BoundField>
            <asp:BoundField HeaderText="Tên khách hàng" DataField="NameKhach" 
                HtmlEncode="False" HtmlEncodeFormatString="False" />
            <asp:BoundField HeaderText="Ngày đặt" DataField="Date" />
            <asp:BoundField HeaderText="Tổng tiền" HtmlEncode="False" DataField="TotalMoney" 
                DataFormatString="{0}.000VND" />
            <asp:BoundField DataField="PTThanhToan" HtmlEncode="False" HeaderText="Thanh toán" />
            <asp:CheckBoxField HeaderText="Đã xem" DataField="Isxem" />
            <asp:CheckBoxField HeaderText="Đã giao" DataField="isGiao" />
            <asp:ButtonField Text="chi tiết&gt;&gt;" CommandName="CHITIET" />
        </Columns>
        <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
        <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
        <RowStyle BackColor="White" ForeColor="#003399" />
        <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
        <SortedAscendingCellStyle BackColor="#EDF6F6" />
        <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
        <SortedDescendingCellStyle BackColor="#D6DFDF" />
        <SortedDescendingHeaderStyle BackColor="#002876" />
    </asp:GridView>
</div>
<br />
<div>

   <br />
    <table width="700px">
    <tr style="background-color: #6666FF;" align="center"> <td colspan="2" >  <strong><span >Thông tin chi tiết giỏ hàng     
        </span></strong>     </td></tr>
        <tr>
            <td>

    <strong>Họ tên khách hàng: <asp:Label ID="lblTenkh" runat="server" 
        ></asp:Label>
    </strong>
            </td>
            <td>
                Tổng tiền:&nbsp;
    <asp:Label    ID="lblTongtien" runat="server"></asp:Label>
                </td>
        </tr>
        <tr>
            <td>
    Ngày đặt :<asp:Label ID="lblNgay"
        runat="server" ></asp:Label>
            &nbsp;</td>
            <td>
                Người check:&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lblNguoicheck" runat="server" ></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                Emai:<asp:Label ID="lblEmail"
        runat="server" ></asp:Label>
            &nbsp;</td>
            <td>
                <asp:Button ID="btnGiao" runat="server" onclick="btnGiao_Click" 
                    Text="Giỏ hàng này đã được giao" />
            </td>
        </tr>
         <tr>
            <td>
                Điện thoại:<asp:Label ID="lblDienthoai"
        runat="server" ></asp:Label>
            &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="2" >
                Địa chỉ:
    <asp:Label ID="lblDiaChi" Width="600" runat="server" ></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="2" >
    Nội dung ghi chú:
    <asp:Label ID="lblGichu" Width="684px" runat="server" ></asp:Label>
            </td>
        </tr>
    </table>
  
    
    <br />
  
    
    <center> 
        <asp:GridView ID="grvChitiet" runat="server" AutoGenerateColumns="False" Height="91px" 
            Width="711px">
        <Columns>
            <asp:BoundField DataField="Masp" />
            <asp:BoundField HeaderText="Tên Sản phẩm" DataField="Tensp" />
            <asp:BoundField HeaderText="Mã " DataField="Matensp" />
            <asp:CheckBoxField HeaderText="Deal" DataField="Deal" />
            <asp:BoundField HeaderText="Số lượng" DataField="Soluong" />
            <asp:BoundField HeaderText="Đơn giá" DataField="Dongiasp" />
            <asp:BoundField DataField="Thanhtien" HeaderText="Thành tiền" />
        </Columns>
    </asp:GridView>
        <br />
        <asp:Button ID="btnXoa" runat="server" onclick="btnXoa_Click" 
            Text="Xóa giỏ hàng này" />
        <br />
    </center>
</div>
