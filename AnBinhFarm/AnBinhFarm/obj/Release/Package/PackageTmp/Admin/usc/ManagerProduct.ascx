<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ManagerProduct.ascx.cs" Inherits="AnBinhFarm.Admin.usc.ManagerProduct" %>
<div>
    Chọn nhóm:&nbsp;<asp:DropDownList ID="cboNhomSp" runat="server" Height="30px" 
        onselectedindexchanged="DropDownList1_SelectedIndexChanged" Width="162px" 
        AutoPostBack="True">
    </asp:DropDownList>
    <br />
    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
        Text="Thêm SP mới" />
    <br />
    <asp:GridView ID="grvSp" runat="server" AutoGenerateColumns="False" 
        Width="693px"      onrowcommand="grvSp_RowCommand" 
        AllowPaging="True" 
        onpageindexchanging="grvSp_PageIndexChanging" CellPadding="4" 
        ForeColor="#333333" GridLines="Horizontal" PageSize="15">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:BoundField HeaderText="#" DataField="IdProduct" />
            <asp:BoundField HeaderText="Tên Sản phẩm" DataField="NameProduct" />
            <asp:BoundField HeaderText="Mã SP"  DataField="IDNameProduct" />
            <asp:ImageField  HeaderText="Hình SP" DataImageUrlField="Images" 
                DataImageUrlFormatString="~/Hinhsp/{0}"  >
                 <ControlStyle Height="50px" Width="50px" />
            </asp:ImageField>
            <asp:BoundField HeaderText="Giá Sản Phẩm"  DataField="Price"/>
            <asp:BoundField HeaderText="Màu sắc"  DataField="Color" />
            <asp:BoundField HeaderText="Lượt xem"  DataField="LuotXem"/>
            <asp:ButtonField ButtonType="Button" CommandName="SUA" Text="Sửa Sp" />
        </Columns>
        <EditRowStyle BackColor="#2461BF" />
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" 
            Wrap="False" />
        <RowStyle BackColor="#EFF3FB" />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F5F7FB" />
        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
        <SortedDescendingCellStyle BackColor="#E9EBEF" />
        <SortedDescendingHeaderStyle BackColor="#4870BE" />
    </asp:GridView>
    <br /><br />
</div>
 