<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="DealDetail.ascx.cs" Inherits="AnBinhFarm.WEBUSC.DealDetail" %>
<%@ Register src="AllDealHETHAN.ascx" tagname="AllDealHETHAN" tagprefix="uc1" %>
<style type="text/css">
    .style1
    {
        color: #3333FF;
        font-size: 18px;
    }
    .style2
    {
        color: #FF0066;
        font-size: 18px;
    }
    .style3
    {
        color: #660033;
    }
    </style>
<div>
<div class="boxtittlexanh">Thông tin chi tiết deal</div>
    <div style="position:relative;float:left; width:45%; top: 0px; left: 0px; height: 239px;" >
    <asp:Image  style="position:relative;margin:auto; padding:4px; margin-top:5px;margin-left:5px; width: 310px; height: 341px;border:1px solid #aabbcc" 
        ID="Image1" runat="server" />
    </div>
    <div style="position:relative;float:left; width:55%; top: 0px; left: 0px; height: 360px;">
        <span class="style1"><strong>
        <br />
        </strong></span><strong> 
        <asp:Label ID="lblTenDeal" 
            runat="server" Text="Label" CssClass="style1"></asp:Label>
        &nbsp;</strong><br />
        <strong>Mã sản phẩm:&nbsp;
&nbsp;<asp:Label ID="lblMa" runat="server" Text="Label"></asp:Label>
        </strong>
        <br />
        Giá bán thường:
        &nbsp;<asp:Label ID="lblGiaCu" runat="server" Text="Label"></asp:Label>
        <br />
        <strong><span class="style2">Giá Deal:&nbsp;</span><asp:Label ID="lblGiaDeal" 
            runat="server" Text="Label" 
            CssClass="style2" Font-Size="18px"></asp:Label>
        <br />
        </strong><span class="style3"><strong>Thời gian hết hạn:&nbsp;
        </strong></span><strong><asp:Label 
            ID="lblHetHan" runat="server" Text="Label" CssClass="style3"></asp:Label>
        <br />
        </strong>
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnMua" runat="server" Text="MUA NGAY" BackColor="#FF9933" 
            ForeColor="White" onclick="btnMua_Click" Font-Bold="True" Height="32px" Width="99px" 
             />
        <asp:Label ID="heTAH" runat="server" BackColor="#FF9933" Font-Bold="True" 
            ForeColor="White" Text="Hết thời gian mua" Visible="False"></asp:Label>
    </div>
    <div style="position:relative;float:left; width:100%" ><strong>Chi tiết sản phẩm :</strong><br />
      <div style="padding:5px;">  <%= chitietsp %></div>

      

    </div>
    <div class="boxclear"></div>
    <div class="boxtittlexanh">Các deal đã hết hạn</div>
    <div style="position:relative; float:left;">
        <uc1:AllDealHETHAN ID="AllDealHETHAN1" runat="server" />
    </div>
    <div class="boxclear"></div>
 </div>
