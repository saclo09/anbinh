<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ManagerComment.ascx.cs" Inherits="AnBinhFarm.Admin.usc.ManagerComment" %>
<style type="text/css">
    .styleddd
    {
        width: 165px;
    }
</style>
<div>
<div>

    <asp:GridView ID="grvComment" runat="server" AutoGenerateColumns="False" 
        AllowPaging="True" onpageindexchanging="grvComment_PageIndexChanging" 
        onrowcommand="grvComment_RowCommand" Width="710px" CellPadding="4" 
        ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:BoundField HeaderText="#" DataField="Mabl" HtmlEncode="False" />
            <asp:BoundField HeaderText="Người đăng" DataField="Hoten" HtmlEncode="False" />
            <asp:BoundField HeaderText="Email" HtmlEncode="False" DataField="Email"/>
            <asp:BoundField HeaderText="Ngày" DataField="Ngay"/>
            <asp:BoundField HeaderText="Sản phẩm " HtmlEncode="False" DataField="Tensp" />
            <asp:CheckBoxField HeaderText="Duyệt" DataField="IsCheck" />
            <asp:CheckBoxField HeaderText="Đã Xóa" DataField="Isdelete" />
            <asp:ButtonField CommandName="CHITIET" HeaderText="Chi tiết " 
                Text="Chi tiết &gt;&gt;" />
        </Columns>


        <EditRowStyle BackColor="#2461BF" />
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#EFF3FB" />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F5F7FB" />
        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
        <SortedDescendingCellStyle BackColor="#E9EBEF" />
        <SortedDescendingHeaderStyle BackColor="#4870BE" />


    </asp:GridView>

</div>

<table width="100%">
<tr>
        <td colspan="2" align="center" style="background-color:Blue; color:White ; font-size:18px"> Chi tiết bình luận
       </td>
 </tr>
    <tr>
        <td class="styleddd">
            Họ tên người BL:</td>
        <td>
            <asp:TextBox ID="txthoten" runat="server" Width="326px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="styleddd">
            Email:</td>
        <td>
            <asp:TextBox ID="txtEmail" runat="server" Width="321px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="styleddd">
            Nội dung bình luân :</td>
        <td>
            <asp:TextBox ID="txtnoidung" runat="server" Height="96px" ReadOnly="True" 
                TextMode="MultiLine" Width="475px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="styleddd">
            Sản phẩm được bình luân</td>
        <td>
            <asp:HyperLink ID="hblSp" runat="server" Target="_blank" ForeColor="Blue">HyperLink</asp:HyperLink>
        </td>
    </tr>
    <tr>
        <td class="styleddd">
            Thời gian bình luân:</td>
        <td>
            <asp:Label ID="txtThoigian" runat="server" Text="Label"></asp:Label>
        </td>
    </tr>
    <tr>
        <td class="styleddd">
            Trạng thái :</td>
        <td>
            <asp:CheckBox ID="chbDuyet" runat="server" 
                Text="Bình luận đã được duyệt" />
        &nbsp;<asp:Button ID="btnDuyeetu" runat="server" Text="Duyệt bình luận" 
                onclick="btnDuyeetu_Click" />
        </td>
    </tr>
    <tr>
        <td class="styleddd">
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="styleddd">
            &nbsp;</td>
        <td>
            &nbsp;<asp:Button ID="btnSua" runat="server" Text="Sửa bình luận" 
                onclick="btnSua_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnXoa" runat="server" Text="Xóa bình luân này" 
                Width="112px" />
        </td>
    </tr>
</table>
</div>

