<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="DealManager.ascx.cs" Inherits="AnBinhFarm.Admin.usc.DealManager" %>
<style type="text/css">
   
    .style2
    {
        width: 123px;
    }
   
    .style3
    {
        width: 521px;
    }
   
    .style4
    {
        color: #FF3300;
    }
    .style5
    {
        color: #660066;
    }
   
    .style6
    {
        color: #FFFFFF;
    }
   
</style>
<div>
    <br />
    <asp:Button ID="btnthemmoi" runat="server" 
        Text="Thêm mới DEal" onclick="btnthemmoi_Click" />
    <br />
    <br />
    <table style="height: 353px;  width: 95%" border="1px solid black" >
        <tr>
            <td class="style2">
                <b>Tên deal</b></td>
            <td class="style3">
                <b>
                <asp:Label ID="lblTEDEAL" runat="server" Text="Label" style="color: #3366FF"></asp:Label>
                </b></td>
        </tr>
        <tr>
            <td class="style2">
                <b>Mã sản phẩm</b></td>
            <td class="style3">
                <b>
                <asp:Label ID="lblMa" runat="server" Text="Label"></asp:Label>
                </b></td>
        </tr>
        <tr>
            <td class="style2">
                <b>Giá mới</b></td>
            <td class="style3">
                <asp:Label ID="lblGiamoi" runat="server"  Text="Label" CssClass="style4"></asp:Label>
                </td>
        </tr>
        <tr>
            <td class="style2">
                <b>Giá củ</b></td>
            <td class="style3">
                <asp:Label ID="lblGiacuu" runat="server"  Text="Label" CssClass="style4"></asp:Label>
                 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <b>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                </b><strong>Giảm 
                <asp:Label ID="lblPhantram" runat="server" Text="Label" CssClass="style5"></asp:Label>
                </strong><b>%</b></td>
        </tr>
        <tr>
            <td class="style2">
                <b></b></td>
            <td class="style3">
                <b>
                <asp:Image ID="imghinh" runat="server" Height="161px" Width="170px" />
                </b>
            </td>
        </tr>
        <tr>
            <td class="style2">
                <b>Thời gian bắt đầu</b></td>
            <td class="style3">
                <asp:Label ID="lblThoigaibd" runat="server"  Text="Label" 
                    style="color: #FF0000"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style2">
                <b>Thời gian kết thúc</b></td>
            <td class="style3">
                <asp:Label ID="lblThoigaikt" runat="server"  Text="Label" 
                    style="color: #FF0000"></asp:Label>
            </td>
        </tr>
         <tr align="center"><td colspan="2" style="background-color: #0066FF" class="style1"> 
        <strong><span class="style6">DANH SÁCH CÁC DEAL CỦ</span> </strong></td></tr>
    </table>
    <br />
    <asp:GridView ID="grvDEAl" runat="server" AutoGenerateColumns="False" 
        Height="262px" Width="643px" AllowPaging="True" CellPadding="4" 
        ForeColor="#333333" GridLines="Horizontal" 
        onpageindexchanging="grvDEAl_PageIndexChanging" >
             <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:BoundField HeaderText="#" DataField="Madeal" />
            <asp:BoundField HeaderText="TênspDEAL"  DataField="Tendeal"/>
            <asp:BoundField HeaderText="Giá DEAL"  DataField="Giamoi" />
            <asp:BoundField HeaderText="Giá Cũ" DataField="Giacu" />
            <asp:ImageField DataImageUrlField="Hinh" DataImageUrlFormatString="~/Hinhsp/{0}"  HeaderText="hình ảnh">
                <ControlStyle Height="50px" Width="50px" />
            </asp:ImageField>
            <asp:BoundField HeaderText="% Giảm giá"  DataField="Pt" />
            <asp:BoundField HeaderText="thời gian bắt đầu" DataField="Tgbatdau" >
            <ControlStyle ForeColor="Red" />
            <ItemStyle ForeColor="#FF3300" />
            </asp:BoundField>
            <asp:BoundField HeaderText="thời gian kết thúc"  DataField="Tgketthuc"/>
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

