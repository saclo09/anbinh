<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Manufacturer.ascx.cs" Inherits="AnBinhFarm.Admin.usc.Manufacturer" %>
<div>

    Chọn nhóm:&nbsp;<asp:DropDownList ID="cboNhomSp" runat="server" Height="30px" 
        onselectedindexchanged="DropDownList1_SelectedIndexChanged" Width="162px" 
        AutoPostBack="True">
    </asp:DropDownList>

</div>
<asp:GridView ID="grvnhom" runat="server" AutoGenerateColumns="False" 
    CellPadding="4" ForeColor="#333333" Width="582px">
    <AlternatingRowStyle BackColor="White" />
    <Columns>
        <asp:BoundField HeaderText="#"  DataField="ManufacturerId"/>
        <asp:BoundField HeaderText="Tên nhóm" DataField="ManufacturerName" />
        <asp:BoundField HeaderText="Mô tả" DataField="DesCription" />
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

<table width="100%">
    <tr align="center">
        <td colspan="2" style="color: #FFFFFF; background-color: #0066FF">
            <strong>THÊM HẢNG MỚI</strong></td>
    </tr>
    <tr>
        <td>
            Tên hảng:</td>
        <td>
            <asp:TextBox ID="txtTennhom" runat="server" Width="273px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            Mô tả:</td>
        <td>
            <asp:TextBox ID="txtmota" runat="server" Width="422px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            Chọn nhóm để thêm :</td>
        <td>
            <asp:DropDownList ID="cboNhomSp0" runat="server" Height="30px" 
         Width="162px" >
    </asp:DropDownList>

        </td>
    </tr>
    <tr><td></td><td><asp:Button ID="btnThem" runat="server" Text="Thêm nhóm mới" 
            onclick="btnThem_Click" /></td></tr>
</table>
