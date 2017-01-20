<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="NewDeal.ascx.cs" Inherits="AnBinhFarm.Admin.usc.NewDeal" %>
   
<div>
<br />
    <table width="100%">
    <tr align="center"><td colspan="2" style="background-color: #0066FF ; color: #FFFFFF; " > 
        <strong>TẠO DEAL MỚI</strong></td></tr>
        <tr align="center"><td colspan="2" style=" color:Red" > 
        <strong>Chú ý :Trước hết muốn tạo deal mới, bạn phải kéo xuống và chọn sản phẩm để làm DEAL </strong></td></tr>
        <tr>
            <td>
                Tên sp DEAL</td>
            <td>
                <asp:Label ID="lblTen" runat="server" Text="lblTen"></asp:Label>
                <asp:Label ID="lblMAspso" runat="server" Visible="False"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                Mã sản phẩm</td>
            <td>
                <asp:Label ID="lblMa" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                Hình Deal:</td>
            <td>               <b>
                <asp:Image ID="imghinh" runat="server" Height="161px" Width="170px" />
                </b>
            </td></tr>
        <tr>
            <td>
                Giá củ</td>
            <td>
                <asp:Label ID="lblGiacu" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
         <tr>
            <td>
                Giá mới 
                (GIÁ DEAL)</td>
            <td>
                <asp:TextBox ID="txtGiaMoi" runat="server" style="text-align: right"></asp:TextBox>
            &nbsp;000VND&nbsp;&nbsp;&nbsp;&nbsp; Giảm
                <asp:TextBox ID="txtPT" runat="server" Width="56px"></asp:TextBox>
                %</td>
        </tr>
        <tr>
            <td>
                Thời gian bắt đầu:</td>
            <td>
                <asp:TextBox ID="txtNgay" runat="server" Width="213px"></asp:TextBox>
                <asp:ImageButton ID="ImageButton1" runat="server" Height="22px" 
                    ImageUrl="~/Admin/images/calendar.png" onclick="ImageButton1_Click" 
                    Width="26px" />
&nbsp;<asp:Calendar ID="Calendar1" runat="server" BackColor="#FFFFCC" 
                    BorderColor="#FFCC66" BorderWidth="1px" DayNameFormat="Shortest" 
                    Font-Names="Verdana" Font-Size="8pt" ForeColor="#663399" Height="200px" 
                    onselectionchanged="Calendar1_SelectionChanged" ShowGridLines="True" 
                    Visible="False" Width="220px">
                    <DayHeaderStyle BackColor="#FFCC66" Font-Bold="True" Height="1px" />
                    <NextPrevStyle Font-Size="9pt" ForeColor="#FFFFCC" />
                    <OtherMonthDayStyle ForeColor="#CC9966" />
                    <SelectedDayStyle BackColor="#CCCCFF" Font-Bold="True" />
                    <SelectorStyle BackColor="#FFCC66" />
                    <TitleStyle BackColor="#990000" Font-Bold="True" Font-Size="9pt" 
                        ForeColor="#FFFFCC" />
                    <TodayDayStyle BackColor="#FFCC66" ForeColor="White" />
                </asp:Calendar>
            </td>
        </tr>
        <tr>
            <td>
                Thời gian kết thúc:</td>
            <td>
                <asp:TextBox ID="txtNgay0" runat="server" Width="213px"></asp:TextBox>
                <asp:ImageButton ID="ImageButton2" runat="server" Height="21px" 
                    ImageUrl="~/Admin/images/calendar.png" onclick="ImageButton2_Click" 
                    Width="27px" />
&nbsp;<asp:Calendar ID="Calendar2" runat="server" BackColor="#FFFFCC" 
                    BorderColor="#FFCC66" BorderWidth="1px" DayNameFormat="Shortest" 
                    Font-Names="Verdana" Font-Size="8pt" ForeColor="#663399" Height="200px" 
                    onselectionchanged="Calendar2_SelectionChanged" ShowGridLines="True" 
                    Visible="False" Width="220px">
                    <DayHeaderStyle BackColor="#FFCC66" Font-Bold="True" Height="1px" />
                    <NextPrevStyle Font-Size="9pt" ForeColor="#FFFFCC" />
                    <OtherMonthDayStyle ForeColor="#CC9966" />
                    <SelectedDayStyle BackColor="#CCCCFF" Font-Bold="True" />
                    <SelectorStyle BackColor="#FFCC66" />
                    <TitleStyle BackColor="#990000" Font-Bold="True" Font-Size="9pt" 
                        ForeColor="#FFFFCC" />
                    <TodayDayStyle BackColor="#FFCC66" ForeColor="White" />
                </asp:Calendar>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                <asp:Button ID="btnTHEM" runat="server" onclick="btnTHEM_Click" 
                    Text="THÊM DEAL" BackColor="Lime" ForeColor="Red" />
            </td>
        </tr>
        <tr><td colspan="2" style="background-color: #0066FF"></td></tr>
    </table>
<div>
    Chọn nhóm:&nbsp;<asp:DropDownList ID="cboNhomSp" runat="server" Height="30px" 
        onselectedindexchanged="DropDownList1_SelectedIndexChanged" Width="162px" 
        AutoPostBack="True">
    </asp:DropDownList>
    <br />
    <br />
    <asp:GridView ID="grvSp" runat="server" AutoGenerateColumns="False" 
        Width="693px"      onrowcommand="grvSp_RowCommand" 
        AllowPaging="True" 
        onpageindexchanging="grvSp_PageIndexChanging" CellPadding="4" 
        ForeColor="#333333" GridLines="Horizontal" PageSize="12">
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
            <asp:ButtonField ButtonType="Button" CommandName="CHON" Text="Chọn làm DEAL" />
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
    
    <br />
</div>

</div>