<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AccountManager.ascx.cs" Inherits="AnBinhFarm.Admin.usc.AccountManager" %>
<style type="text/css">
   
    .styler
    {
        font-size: large;
    }
    
</style>
<div>
    <asp:GridView ID="grvAccount" runat="server" AutoGenerateColumns="False" 
        onrowcommand="grvAccount_RowCommand" 
        >
        <Columns>
            <asp:BoundField DataField="IdAccount" HeaderText="#" ReadOnly="True" />
            <asp:BoundField HeaderText="Tên đăng nhập" DataField="Username" 
                ReadOnly="True" />
            <asp:BoundField HeaderText="Họ tên đầy đủ" DataField="fullname" />
            <asp:BoundField HeaderText="Email" DataField="Email" />
            <asp:BoundField HeaderText="Số điện thoại" DataField="Phone" />
            <asp:BoundField HeaderText="Ngày tạo" DataField="CreateDate" 
                ReadOnly="True" />
            <asp:BoundField HeaderText="Người tạo" DataField="CreateUser" 
                ReadOnly="True" />
            <asp:BoundField HeaderText="Đã xóa" DataField="isdelete" ReadOnly="True" />
            <asp:ButtonField ButtonType="Button" Text="Sửa" CommandName="SUA" />
        </Columns>
    </asp:GridView>
</div>
<table width="690" >
    <tr align="center">
        <td colspan="2" class="styler">
            <strong><asp:Label ID="lbltieuDe" runat="server" Text="Thêm người dùng mới"></asp:Label>
            </strong></td>
    </tr>
    <tr>
        <td class="style4">
            Tên đăng nhập :</td>
        <td class="style3">
            <asp:TextBox ID="txtUsername" runat="server" Width="143px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="style5">
            Mật khẩu</td>
        <td>
            <asp:TextBox ID="txtPass" runat="server" TextMode="Password" Width="160px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="style5">
            Nhập lại mật khẩu:</td>
        <td>
            <asp:TextBox ID="txtPassConfilm" runat="server" TextMode="Password" 
                Width="156px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="style5">
            Họ và tên :</td>
        <td>
            <asp:TextBox ID="txtFullName" runat="server" Width="246px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="style5">
            Email:</td>
        <td>
            <asp:TextBox ID="txtEmail" runat="server" Width="260px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="style5">
            Điện thoại :</td>
        <td>
            <asp:TextBox ID="txtSdt" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="style5">
            Quyền quản trị :</td>
        <td>
            <asp:RadioButton ID="rdo1" Checked="true" GroupName="quantri" Text="Quản trị viên" runat="server" />
            <asp:RadioButton ID="rdo2" GroupName="quantri" Text="Hệ thống"  runat="server" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:CheckBox ID="ckbDelete" runat="server" Text="User vô hiệu hóa" 
                Visible="False" />
        </td>
    </tr>
    <tr>
        <td colspan="2">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" Text="Thêm người dùng" 
                onclick="Button1_Click" />
            <asp:Button ID="btnSua" runat="server" onclick="btnSua_Click" 
                Text="Sửa người dùng" Visible="False" />
        </td>
    </tr>
</table>
