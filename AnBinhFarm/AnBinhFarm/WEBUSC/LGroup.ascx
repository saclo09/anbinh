<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="LGroup.ascx.cs" Inherits="AnBinhFarm.WEBUSC.LGroup" %>
<%@ Import Namespace="HP_BLL" %>
<style type="text/css">
    .chilGroup
    {
        width:190px;
       float:left;
       position:relative;
    }
    .boxnho1
    {

       background-color:#f2f2f2;
       width:190px;
       float:left;
       position:relative;
    }
    .boxnho2
    {
        height:240px;
        background-color:#f2f2f2;
        float:left;
        width:190px;
    }
    .aamn{
   	    color:#0694db;
   	    text-decoration:none;
   	    position:relative;
   	    /*?border-top:1px solid white;*/
   		background-color: #ffffff;
   		font-family:Times New Roman;
   		padding-left:10px;
   		padding-top:3px;
   		padding-bottom:3px;
   	}
   	.aamn:hover{
   	    background-color:#CCFF99;
   	}
    
</style>
<div class="chilGroup">
    <div class="boxnho1">
    <center>
    <div class="boxtittlexanh"><strong>Nhóm thuộc danh mục</strong></div>
        
    <asp:DataList ID="dsnhomCON" runat="server" style="float:left;position:relative;width:100%">
        <ItemTemplate><img src='/images/muiten.gif' />
            <asp:HyperLink ID="HyperLink1" runat="server"  CssClass="aamn" Width="180" Font-Size="14px" Font-Bold="true"
                Text='<%# Eval("NameGroup") %>' 
                NavigateUrl='<%# "~/sp-list/"+Eval("IDGroup")+"/"+BLL.convertURL(Eval("NameGroup").ToString())+".aspx" %>'>
            </asp:HyperLink>
        </ItemTemplate>
        </asp:DataList>
       </center>
    </div>    
    <div class="boxnho2">
        <center>
           <div  class="boxtittlexanh"><strong>Tìm kiếm theo giá</strong></div>
            <br />
        Từ giá:<br />
&nbsp;<asp:DropDownList ID="cbbTuGia" runat="server" Height="22px" Width="116px">
            <asp:ListItem Value="1">1.000 VND</asp:ListItem>
            <asp:ListItem Value="100">100.000 VND</asp:ListItem>
            <asp:ListItem Value="200">200.000 VND</asp:ListItem>
            <asp:ListItem Value="500">500.000 VND</asp:ListItem>
            <asp:ListItem Value="1000">1000.000 VND</asp:ListItem>
            <asp:ListItem Value="5000">5000.000 VND</asp:ListItem>
      </asp:DropDownList>
        <br />
        Đến giá:<br />
&nbsp;<asp:DropDownList ID="cbbDenGia" runat="server" Height="22px" Width="124px">
            <asp:ListItem Value="100">100.000 VND</asp:ListItem>
            <asp:ListItem Value="200">200.000 VND</asp:ListItem>
            <asp:ListItem Value="500">500.000 VND</asp:ListItem>
            <asp:ListItem Value="1000">1000.000 VND</asp:ListItem>
            <asp:ListItem Value="5000">5000.000 VND</asp:ListItem>
            <asp:ListItem Selected Value="10000">10.000.000 VND</asp:ListItem>
      </asp:DropDownList>
        <br />Nhà sản xuất
            <br />
&nbsp;<asp:DropDownList ID="cbbHang" runat="server" Height="22px" Width="124px">
            <asp:ListItem Value="0">-(Tất cả nhà sx)-</asp:ListItem>
        </asp:DropDownList>
            <br />
        <br />
        <asp:Button ID="btnTimkiem" runat="server" Text="Tìm kiếm" 
            onclick="btnTimkiem_Click" Font-Bold="True" />
            <br />
        <br />
     </center>
    </div>
    
</div>
