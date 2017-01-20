<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ManagerGroupIterm.ascx.cs" Inherits="AnBinhFarm.Admin.usc.ManagerGroupIterm" %>


<div>

    <table style="width:100%">
        <tr align="center" style="background-color:Blue;color:White;font-size:18">
            <td colspan="4">
            QUẢN LÝ NHÓM SẢN PHẨM             
           
               </td>
        </tr>
        <tr>
            <td  >
                Chọn nhóm sản phẩm:
            </td>
            <td colspan="3">
                <asp:DropDownList ID="cbo" runat="server" Height="37px" Width="236px" 
                    onselectedindexchanged="cbo_SelectedIndexChanged" AutoPostBack="True">
                </asp:DropDownList>&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
            </td>
            
        </tr>
         <tr align="center" style="background-color:Blue;color:White;font-size:18">
         <td colspan="4"  >
                <asp:Label ID="lbltieude" runat="server" Text="CHI TIẾT NHÓM SẢN PHẨM"></asp:Label>
                </td>
        </tr>
        <tr>
            <td  >
                Tên nhóm</td>
            <td  >
                <asp:Label ID="txtTennhom" runat="server" Font-Bold="True"></asp:Label>
            </td>
            <td  >
                Mã nhóm :</td>
            <td>
                <asp:Label ID="lblMAnhom" runat="server" Font-Bold="True"></asp:Label>
            </td>
        </tr>
        <tr>
            <td  >
                Thuộc nhóm :</td>
            <td  >
                <asp:Label ID="lblNhomcha" runat="server" Font-Bold="True"></asp:Label>
            </td>
            <td  >
                <asp:CheckBox ID="chbHot" runat="server" Text="Hiện sp nhóm lên trang chủ" 
                    Checked="True" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td  >
                Mô tả 
                nhóm :<br />
            </td>
            <td  >
                <asp:Label ID="txtmota" runat="server" Font-Bold="True"></asp:Label>
            </td>
            <td  3">
                <br />
                Người tạo :</td>
            <td>
                <asp:Label ID="lblnguoitao" runat="server" Font-Bold="True"></asp:Label>
            </td>
        </tr>
        <tr>
            <td  >
                Keyword</td>
            <td  >
                <asp:Label ID="txtkeywword" runat="server" Font-Bold="True"></asp:Label>
            </td>
            <td  >
                Ngày tạo :</td>
            <td>
                <asp:Label ID="lblNgaytao" runat="server" Font-Bold="True"></asp:Label>
            </td>
        </tr>
        <tr>
            <td  >
                Tittle:</td>
            <td  >
                <asp:Label ID="txtmetatitile" runat="server" Font-Bold="True"></asp:Label>
            </td>
            <td  >
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td  ></td>
            <td  >
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnSua" runat="server" Text="Sửa nhóm" onclick="btnSua_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnthemmoi" runat="server" onclick="btnthemmoi_Click" 
                    Text="Thêm nhóm mới" />
            </td>
            <td>&nbsp;</td>
            <td></td>
        </tr>
        
    </table>

</div>