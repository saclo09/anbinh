<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ManagerArticle.ascx.cs" Inherits="AnBinhFarm.Admin.usc.ManagerArticle" %>
<div>
    Chọn nhóm:&nbsp;<asp:DropDownList ID="cboNhomSp" runat="server" Height="30px" 
        onselectedindexchanged="DropDownList1_SelectedIndexChanged" Width="162px" 
        AutoPostBack="True">
    </asp:DropDownList>
    <br />
    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
        Text="Thêm bv mới" />
    <br />
    <asp:GridView ID="grvSp" runat="server" AutoGenerateColumns="False" 
        Width="693px"      onrowcommand="grvSp_RowCommand" 
        AllowPaging="True"   PageSize="15" 
        onpageindexchanging="grvSp_PageIndexChanging" CellPadding="4" 
        ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:BoundField HeaderText="#" DataField="ArticleID" />
            <asp:BoundField HeaderText="Tên bv" DataField="ArticleName" />
            <asp:ImageField  HeaderText="Hình bv" DataImageUrlField="ArticleImage" 
                DataImageUrlFormatString="~/Hinhbv/{0}"  >
                 <ControlStyle Height="50px" Width="50px" />
            </asp:ImageField>
          
            <asp:BoundField HeaderText="Tạo bởi"  DataField="CreateBy"/>
            <asp:ButtonField ButtonType="Button" CommandName="SUA" Text="Sửabv" />
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
 