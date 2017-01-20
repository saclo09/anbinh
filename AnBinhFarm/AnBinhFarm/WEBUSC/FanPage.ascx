<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="FanPage.ascx.cs" Inherits="AnBinhFarm.WEBUSC.FanPage" %>
<div style="position:relative;float:left;width:100%">
<div id="fb-root"></div>
<script>    (function (d, s, id) {
        var js, fjs = d.getElementsByTagName(s)[0];
        if (d.getElementById(id)) return;
        js = d.createElement(s); js.id = id;
        js.src = "//connect.facebook.net/vi_VN/all.js#xfbml=1&appId=374631889294427";
        fjs.parentNode.insertBefore(js, fjs);
    } (document, 'script', 'facebook-jssdk'));
</script>
<div class="fb-like-box" data-href="http://www.facebook.com/noithathopphat" data-width="188" data-height="265" data-show-faces="true" data-stream="false" data-header="true"></div>
</div>