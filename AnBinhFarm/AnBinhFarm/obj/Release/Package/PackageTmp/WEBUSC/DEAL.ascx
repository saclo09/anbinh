<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="DEAL.ascx.cs" Inherits="AnBinhFarm.WEBUSC.DEAL" %>
<script type="text/javascript" src="http://hideal.vn/resource/admin/js/jquery-1.7.1.min.js"></script> 
<script>
    $(
    function () {
        // duyệt toàn bộ các div có class là smart_deal 
        $(".smart_deal").each(function () { CountDown($(this).attr('id')); });
    }
    );

    function CountDown(id) {
        $id = id.replace('smart_deal_', '');
        $totalSecond = $("#deal-timeleft-" + $id).attr('curtime');
        $totalMin = $totalSecond / 60;
        $hour = parseInt($totalMin / 60);
        $min = parseInt($totalMin % 60);
        $second = parseInt($totalSecond - ($hour * 3600) - ($min * 60));

        $("#deal-timeleft-" + $id).attr('curtime', --$totalSecond);

        // GAN THOI GIAN VAO LABEL 

        $("#counterlist-" + $id).html("" + $hour + " : " + $min + " : " + $second + "");//hiển thị ở dòng này

        $(".hour_" + $id).html($hour);
        $(".minu_" + $id).html($min);
        $(".seco_" + $id).html($second);
        if ($totalSecond > -1)
            setTimeout("CountDown('" + id + "')", 1000);
        else {
            $("#smart_deal_" + id).fadeOut('slow'); //Ẩn deal khi hết thời gian 
        }
    } 
</script> 
<div class="deal">
    <div class="tieudeDeal">
        <div class="hotlogo"><center><br />
            <div style="position:relative;padding-bottom:3px;"><asp:Label ID="lblPT" runat="server"  Font-Bold="true" Font-Size="13px" Text="20%" ForeColor="Red"></asp:Label></div>
        </center></div> 
    </div>
   <div class="ndDeal"><center>
   <div>
      
      <div style="position:relative;margin:auto;padding:0px 5px 0px 5px;"> <asp:HyperLink ID="hplTenSp" ToolTip="Xem chi tiết DEAL" NavigateUrl="~/Chi-tiet-gio-deal.aspx" runat="server" Font-Bold="True" ForeColor="#3333FF">[hplTenSp]</asp:HyperLink></div>
        
         <a href="Chi-tiet-gio-deal.aspx" title="Xem chi tiết DEAL">
            <asp:Image ID="Image1" runat="server" Height="89px" Width="82px" /><br />       
            <asp:Label ID="lblGiaDeal" runat="server" Font-Bold="True" Font-Size="15px" 
            ForeColor="#FF0066" ></asp:Label>
        </a>
       <br />
       <asp:Label ID="Giacu" runat="server" Font-Bold="True" Font-Size="12px" 
           style="color: #666666" Font-Overline="False" Font-Strikeout="True"></asp:Label>
    </div>
    <div class="smart_deal" id="smart_deal_404"> 
        <div class="deal-timeleft1" id="deal-timeleft-404" curtime='<%=remaingTime%>' > <!--curtime: tong so giay cua deal--> 
            <div id="counterlist-404" style="font-size:14px; color:Black; font-weight:bold;"> </div> 
        </div> 
    </div>
    <asp:Button ID="btnMua" runat="server" BackColor="#FF9933" Font-Size="13px" CommandName="Mua" 
                            Font-Bold="True" ForeColor="White" Text="MUA NGAY" 
                            onclick="btnMua_Click"  />
       <asp:Label ID="lblhethan" runat="server" BackColor="#FF9933" Font-Bold="True" 
           ForeColor="Red" Text="Hết hạn mua" Visible="False"></asp:Label>
   
    </center>
    </div>
</div>
