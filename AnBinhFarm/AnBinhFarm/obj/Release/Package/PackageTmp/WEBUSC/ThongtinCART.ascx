<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ThongtinCART.ascx.cs" Inherits="AnBinhFarm.WEBUSC.ThongtinCART" %>
<style type="text/css">
    .cssgh
    {
        height:55px;
        width:90px;
        background-color:#FFCC33;
        -moz-border-radius-topleft:10px; 
        -webkit-border-top-left-radius:10px;
     -moz-border-radius-topright:10px;
     -webkit-border-top-right-radius:10px;
    -moz-border-radius-bottomleft:10px; 
    -webkit-border-bottom-left-radius:10px;
    -moz-border-radius-bottomright:10px;
    -webkit-border-bottom-right-radius:10px;
    }
</style>
   
           <ul><li class="cssgh">
           <asp:HyperLink ID="Gio_hang" Height="34px" Width="30px" runat="server" ToolTip="Xem thông tin giỏ hàng" ImageUrl="~/Images/Giohang.gif" 
    CssClass="gio_hang" NavigateUrl="~/GioHang.aspx"></asp:HyperLink>
    <a style="text-decoration:none;" href="/GioHang.aspx" title="Xem thông tin giỏ hàng"  >
            <asp:Label ID="lblSoLuong" runat="server"  Font-Size="13px" Width="7px" ForeColor="#CC0000" 
    Font-Bold="True" ></asp:Label>
      <br />               <center>                        
               <asp:Label ID="Label1" Font-Size="13px" Font-Bold="true" runat="server" Text="GIỎ HÀNG"></asp:Label></center></a>
            </li></ul>
        
            