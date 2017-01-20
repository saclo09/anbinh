<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ArticleDetail.ascx.cs" Inherits="AnBinhFarm.WEBUSC.ArticleDetail" %>
<style type="text/css">
    .boxChitietBV
    {
        position:relative;
        width:100%;
        float:left;
    }
     .hinhCTbv
    {
        position:relative;
        width:30%;
        float:left;
    }
    .titileCTbv
    {
         position:relative;
         width:70%;
        float:left;
    }
    .ndCTBv
    {
         position:relative;
         width:97%;
         padding-left:3%;
        float:left;
        background-color:#f6f6f6;
    }
    .hinhbvLon
    {
        position:relative;
        padding:5px;
        width:80%;
        border:1px solid #aabbcc;
    }
    .headChitietBv
    {
        padding:5px;
    }
   
</style>
<div class="boxChitietBV">
    <div class="headChitietBv">
        <div class="hinhCTbv">
            <asp:Image ID="Image1" CssClass="hinhbvLon" runat="server"  />
        <br /><center>
                <asp:Label ID="lblghichuhinh" runat="server" Font-Italic="True" Font-Size="Small"></asp:Label>
            </center>
        </div>

        <div class="titileCTbv"><h1 class="h1chulon">
            <asp:Label ID="lblTieude" runat="server" Text="Label"></asp:Label>
            </h1>
        
            <asp:Label style="padding-left:40px" ID="lblNgaydang" runat="server" 
                Font-Italic="True" Font-Size="Small"></asp:Label>
        </div>
    </div>
    <br /><b style="position:relative;float:left;width:100%"> NỘI DUNG BÀI VIẾT </b>
    <div class="ndCTBv"><%= bvmoi.ArticleContent %></div>

</div>
<br />
<br />
