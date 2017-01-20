<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SlideKMM.ascx.cs" Inherits="AnBinhFarm.WEBUSC.SlideKMM" %>
 <link rel="stylesheet" href="/Scripts/bjqs.css">
    <script src="/Scripts/slide_jquery-1.7.1.min.js"></script>
    <script src="/Scripts/bjqs-1.3.min.js"></script>
    <script class="secret-source">
        jQuery(document).ready(function ($) {

            $('#banner-slide').bjqs({
                animtype: 'slide',
                height: 220,
                width: 420,
                responsive: true,
                randomstart: true
            });

        });
      </script>
  
  
  <div style="position:relative;float:left; width:100%;">
    <div id="banner-slide" style="margin:auto;">        
        <ul class="bjqs">
          <li><a href="/khuyen-mai.aspx" target="_blank"><img src="/KhuyenMai/hinh-khuyenmai30-4.jpg" alt="khuyến mãi" title="KM 30/4 và 1/5" ></a></li>
          <li><a href="/khuyen-mai.aspx" target="_blank"><img src="/KhuyenMai/khuyenmaigiamgia.jpg" alt="khuyến mãi" ></a></li>
          <li><a href="/bv/12/KHUYEN-MAI-30-4-.aspx" target="_blank"><img src="/KhuyenMai/bannerKM.png" alt="khuyến mãi" ></a></li>
        </ul>
    </div>
 </div>
   
