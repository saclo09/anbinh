<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SanPham.ascx.cs" Inherits="AnBinhFarm.Admin.usc.SanPham" %>
<%@ Register assembly="FredCK.FCKeditorV2" namespace="FredCK.FCKeditorV2" tagprefix="FCKeditorV2" %>
<style type="text/css">
    
    .style2
    {
        width: 162px;
    }
    .style3
    {
        background-color: #CCCCCC;
    }
    .style4
    {
        width: 162px;
        background-color: #CCCCCC;
    }
</style>
 <script>
     function disp_confirm() {
         var r = confirm("Bạn có chắc là xóa không ?");
         if (r == true) {
             return true;
         }
         else {
             return false;
         }
     }
    </script>
<div>

    <table width="718">
        <tr>
            <td class="style2">
                Tên sản phẩm</td>
            <td>
                <asp:TextBox ID="txtTensp" runat="server" Width="520px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style2">
                Mã sản phẩm:</td>
            <td>
                <asp:TextBox ID="txtMaten" runat="server"></asp:TextBox>
            </td>
        </tr>
        
        <tr>
            <td class="style2">
                Chọn loại sp:</td>
            <td>
                <asp:DropDownList ID="cboLoai" runat="server" Height="20px" Width="206px" 
                    AutoPostBack="True" onselectedindexchanged="cboLoai_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="style2">
                Hình ảnh</td>
            <td>
                <asp:FileUpload ID="fuloadhinhanh" runat="server" Width="217px" />
                <asp:Image ID="hinhssp" runat="server" Height="69px" Width="93px" />
            </td>
        </tr>
        <tr>
            <td class="style2">
                Mô tả sản phẩm</td>
            <td>
                <FCKeditorV2:FCKeditor ID="txtNoidung" BasePath="~/Admin/fckeditor/" Height="400" runat="server">
                </FCKeditorV2:FCKeditor>
            </td>
        </tr>
        
         <tr>
            <td class="style2">
                Màu sắc</td>
            <td>
                <asp:TextBox ID="txtMausac" runat="server"></asp:TextBox>
            </td>
         </tr>
         <tr>
            <td class="style2">
                Chất liệu</td>
            <td>
                <asp:TextBox ID="txtChatlieu" runat="server"  
                    Width="316px" style="text-align: left"></asp:TextBox>
                </td>
        </tr>
        <tr>
            <td class="style2">
                Giá</td>
            <td>
                <asp:TextBox ID="txtGia" runat="server"  
                    Width="115px" style="text-align: right"></asp:TextBox>
                .000VNĐ</td>
        </tr>
        <tr>
            <td class="style2">
                Giá thị trường( &gt; giá bán )</td>
            <td>
                <asp:TextBox ID="txtGianote" runat="server" Width="117px" 
                    style="text-align: right"></asp:TextBox>
                .000VND</td>
        </tr>
        <tr>
            <td class="style2">
                Số lượng :</td>
            <td>
                <asp:TextBox ID="txtSoluong" runat="server"></asp:TextBox>
            &nbsp;Mặc định là 1 bạn không cần nhập cũng được.</td>
        </tr>
        <tr>
            <td class="style2">
                Mô tả cho cùng sản phẩm Giá khác( sản phẩm nhiều giá)</td>
            <td>
                <asp:TextBox ID="txtMutiprice" runat="server"  
                    Width="470px" style="text-align: left" Height="96px" TextMode="MultiLine"></asp:TextBox>
                </td>
        </tr>
        <tr>
            <td class="style2">
                Đặc tính :</td>
            <td>
                <asp:CheckBox ID="chkNew" runat="server" Text="Sp mới" />
&nbsp;<asp:CheckBox ID="checkHot" runat="server" Text="Sp Hot" />
            </td>
        </tr>
        <tr>
            <td class="style2">
                Khuyến mãi 
                :</td>
            <td style="margin-left: 80px">
                <asp:CheckBox ID="chkbKhuyenmai" runat="server" Text="Khuyến mãi" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; % Khuyến 
                mãi: <asp:TextBox ID="txtKhaiPT" runat="server" Width="60px"></asp:TextBox>
            &nbsp; <strong>%</strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; (vd: 5 )</td>
        </tr>
        <tr>
            <td class="style4">
                <strong>SEO</strong></td>
            <td class="style3">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                Keyword</td>
            <td>
                <asp:TextBox ID="txtkeyword" runat="server" style="text-align: left" 
                    Width="612px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style2">
                Description</td>
            <td>
                <asp:TextBox ID="txtDescription" runat="server" Width="607px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td </td>
            <td>
                
                <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
                    Text="Cập nhật " />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="Hủy" />
                
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnXoa" runat="server"  OnClientClick="return disp_confirm()" onclick="btnXoa_Click" 
                    Text="Xóa sản phẩm" />
                
            </td>
        </tr>
    </table>

</div>
