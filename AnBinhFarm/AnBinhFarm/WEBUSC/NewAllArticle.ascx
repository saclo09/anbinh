<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="NewAllArticle.ascx.cs" Inherits="AnBinhFarm.WEBUSC.NewAllArticle" %>
<div style="position:relative; float:left; width:100%; top: 0px; left: 0px;">
<div class='boxtittle'><img src='Images/Icon_Cam.gif' alt="" style='float:left; padding-top:7px;padding-left:5px; '/><h1 class='chuvua'>Bài viết mới</h1></div>
    <asp:DataList ID="Dsbv" runat="server" Width="100%" RepeatColumns="2">
        <ItemTemplate>
           
               <div style="position:relative;float:left; width:130px">
               <asp:Image ID="Image1" runat="server"  Width="119px" Height="90px" style="position:relative;padding:5px; border:1px solid #afafaf" ImageUrl='<%#(Eval("ArticleImage")==null)? "~/Images/LOGO21.PNG": "~/Hinhbv/"+Eval("ArticleImage") %>' />
               </div> 
               <div style="position:relative;float:right; width:260px ">
                <h2 class="tieudeSPnho" >                        
                    <asp:HyperLink class="atieude" style="padding:5px;" ID="HyperLink1" NavigateUrl='<%# "~/Chitietbv.aspx?bv="+ Eval("ArticleID") %>' ToolTip='<%# Eval("ArticleName") %>' Text='<%# Eval("ArticleName") %>' runat="server"></asp:HyperLink>
                </h2>
                
                    <asp:Label ID="Label2" runat="server" Text='<%# (Eval("NoteImage").ToString().Length > 255) ? Eval("NoteImage").ToString().Substring(0, 255)+"..." : Eval("NoteImage").ToString() %>'></asp:Label></h4>
               </div>
        </ItemTemplate>
    </asp:DataList>
</div>
