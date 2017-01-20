<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="HotArticle.ascx.cs" Inherits="AnBinhFarm.WEBUSC.HotArticle" %>
<div style=" height:230px;background-color:#f6f6f6 ">
<center class="boxtittlexanh">Bài viết nỗi bật</center>
<marquee  direction="up" scrolldelay="20" scrollamount="1" height="190" onmousemove="this.stop()" onmouseout="this.start()" style="padding:5px;">
<%= strHot %>
</marquee>

</div>
