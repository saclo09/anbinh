<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MyAccount.ascx.cs" Inherits="AnBinhFarm.Admin.usc.MyAccount" %>
<div width= "650px" >
    <table >
        <tr>
            <td>
                Tên đăng nhập
            </td>
            <td>
                <asp:TextBox ID="txtUs" runat="server" ReadOnly="True" Width="136px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Họ và tên</td>
            <td>
                <asp:TextBox ID="txtTen" runat="server" Width="349px" 
                    ></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Email</td>
            <td>
                <asp:TextBox ID="txtEmail" runat="server" Width="332px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Điện thoại:</td>
            <td>
                <asp:TextBox ID="txtDienthoai" runat="server" Width="203px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                <asp:Button ID="btnSua" runat="server" Text="sửa" Width="133px" 
                    onclick="btnSua_Click" />
            </td>
        </tr>
         <tr>
            <td>
                Thay đổi mật khẩu</td>
            <td>
                <asp:CheckBox ID="CheckBox1" runat="server" AutoPostBack="True" 
                    oncheckedchanged="CheckBox1_CheckedChanged" Text="Đổi mật khẩu" />
             </td>
        </tr>
        <tr>
            <td>
                Mật khẩu củ</td>
            <td>
                <asp:TextBox ID="txtMKC" runat="server" Width="245px" TextMode="Password" 
                    Visible="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Mật khẩu mới</td>
            <td>
                <asp:TextBox ID="txtMkhmoi" runat="server" Width="244px" 
                    TextMode="Password" Visible="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Nhập lại mật khẩu mới</td>
            <td>
                <asp:TextBox ID="txtMKmoiCF" runat="server" Width="243px" TextMode="Password" 
                    Visible="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                </td>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Đổi mật khẩu" 
                    onclick="Button1_Click" Visible="False" />
               </td>
        </tr>
    </table>
</div>

