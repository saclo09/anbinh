<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="bvKM.ascx.cs" Inherits="AnBinhFarm.WEBUSC.bvKM" %>
<%@ Import Namespace="HP_BLL" %>
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
<div style="position:relative; width:100%; float:left; top: 0px; left: 0px;">
<h1 class="boxtittlexanh" >Các khuyến mãi khác</h1>
    <asp:DataList ID="Dsbv" runat="server" Width="100%" RepeatColumns="2">
        <ItemTemplate>
            <div>
               <div style="position:relative;float:left; width:35%">
               <asp:Image ID="Image1" runat="server"  Width="119px" Height="119px" style="position:relative;padding:5px; border:1px solid #555555" ImageUrl='<%#(Eval("ArticleImage")==null)? "~/Images/LOGO21.PNG": "~/Hinhbv/"+Eval("ArticleImage") %>' />
               </div> 
               <div style="position:relative;float:left; width:65% ">
                <h2 class="tieudeSPnho" >                        
                    <asp:HyperLink class="atieude" style="padding:5px;" ID="HyperLink1" NavigateUrl='<%# "~/bv/"+ Eval("ArticleID")+"/"+BLL.convertURL(Eval("ArticleName").ToString())+".aspx" %>' ToolTip='<%# Eval("ArticleName") %>' Text='<%# Eval("ArticleName") %>' runat="server"></asp:HyperLink>
                </h2>
                
                  <!--  <asp:Label ID="Label2" runat="server" Text='<%# (Eval("ArticleContent").ToString().Length > 112) ? Eval("ArticleContent").ToString().Substring(0, 111)+"..." : Eval("ArticleContent").ToString() %>'></asp:Label></h4>-->
                
                

            </div>
        </ItemTemplate>
    </asp:DataList>
</div>

