<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Timkiem.ascx.cs" Inherits="AnBinhFarm.WEBUSC.Timkiem" %>
<div >&nbsp;&nbsp;&nbsp;&nbsp;
<asp:DropDownList ID="cboNhomSp" runat="server" Width="160px">
</asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;
<asp:TextBox ID="txtTukhoa" runat="server" Width="266px"></asp:TextBox>
&nbsp;&nbsp;
<b><asp:Button ID="btnTimkiem" runat="server" Text="Tìm kiếm" 
    onclick="btnTimkiem_Click" /> </b>
</div>

