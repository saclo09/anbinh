<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="BOOKCART.ascx.cs" Inherits="AnBinhFarm.WEBUSC.BOOKCART" %>
<style type="text/css">
   
    .style2
    {
        width: 106px;
    }
    .style3
    {
    }
    .style4
    {
        width: 180px;
    }
</style>
<div >

    <table style="width: 685px" align="center" >
    <tr align="center">
            
            <td  colspan="4">
                <strong>THÔNG TIN ĐẶT HÀNG</strong></td>
        </tr>
        <tr>
            <td class="style2">
                Tên khách hàng:</td>
            <td class="style3">
                <asp:Label ID="lblTen" runat="server" Text="lblTen" Font-Bold="True"></asp:Label>
            </td>
            <td class="style4">
                Ngày đặt</td>
            <td>
                <asp:Label ID="lblNgaydat" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style2">
                Số điện thoại:</td>
            <td class="style3">
                <asp:Label ID="lblSDT" runat="server" Text="Label"></asp:Label>
            </td>
            <td class="style4">
                Phương thức thanh toán</td>
            <td>
                <asp:Label ID="lblPTTT" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style2">
                Email:</td>
            <td class="style3">
                <asp:Label ID="lblEmail" runat="server" Text="Label"></asp:Label>
            </td>
            <td class="style4">
                Tổng tiền</td>
            <td>
                <asp:Label ID="lblTongtien" runat="server" Text="Label" Font-Bold="True"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style2">
                Đia chị:</td>
            <td class="style3">
                <asp:Label ID="lblDiachi" runat="server" Text="Label"></asp:Label>
            </td>
            <td class="style4">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                Ghi chú thêm:</td>
            <td class="style3" colspan="3">
                <asp:Label ID="lblGhichu" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
    </table>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False"  align="center"
     Width="660px">
    <Columns>
        <asp:BoundField HeaderText="Mã SP" DataField="MaTen" />
        <asp:BoundField HeaderText="Tên SP" DataField="Ten_sp"/>
        <asp:ImageField HeaderText="Hình" DataImageUrlField="Image" 
            DataImageUrlFormatString="~/HinhSp/{0}" >
            <ControlStyle Width="50px" Height="50px" />
        </asp:ImageField>
        <asp:CheckBoxField HeaderText="Là DEAL" DataField="IsDeal"/>
        <asp:BoundField HeaderText="Số lượng" DataField="So_luong" />
        <asp:BoundField HeaderText="Đơn giá" DataField="Don_gia" DataFormatString="{0}.000VND" />
        <asp:BoundField HeaderText="Thành tiền" DataField="Thanh_tien" DataFormatString="{0}.000VND" />
    </Columns>
</asp:GridView>
</div>


