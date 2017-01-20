<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="NDhead.ascx.cs" Inherits="AnBinhFarm.WEBUSC.NDhead" %>
<style type="text/css">
   .bb
   {color: #666666;
    text-decoration:none;
    font-size:13px;
   }  
    
    
    
    
</style>

<div class="ndhead">
<table width= "581px">
    <tr>
        <td >
            <strong>
            <asp:Image ID="Image1" ImageUrl="~/Images/DT.png" runat="server"  Height="29px" Width="36px" />
            </strong>
           
            </td><td  width="83px" > <strong>
            <span > <a class="bb" href="/huong-dan-mua-hang.aspx" title="Hướng dẫn mua hàng">
            CÁCH THỨC<br />
           &nbsp; MUA HÀNG</a></span></strong></td>
        <td >
            <strong>
            <asp:Image ID="Image2" ImageUrl="~/Images/tien.png" runat="server"   Height="31px" Width="39px" /></strong></td>
            <td width="109px" >
                <a class="bb"  href="/phuong-thuc-thanh-toan.aspx" title="Phương thức thanh toán"><strong><span >PHƯƠNG THỨC
            </span>
                <br  />
                <span >THANH TOÁN</span></strong></a></td>
        <td  >
            <strong>
            <asp:Image ID="Image3" ImageUrl="~/Images/Xe.png" runat="server" Height="34px" Width="40px"   /></strong></td>
        <td width="104px">
           <a class="bb"  href="/chi-phi-van-chuyen.aspx" title="Giao hàng"> <strong><span >PHƯƠNG THỨC</span><br  />
            <span >&nbsp;GIAO HÀNG</span></strong></a></td>
        <td >
            <strong>
            <asp:Image ID="Image4" ImageUrl="~/Images/tra.png" runat="server" 
                CssClass="style8" Height="33px" Width="38px" /></strong></td><td>
            <a class="bb"  href="/quy-dinh-doi-va-tra-hang.aspx" title="Đổi trả hàng"><strong><span >ĐỔI VÀ TRẢ </span>
            <br  />
            <span >SẢN PHẨM</span></strong></a></td>
    </tr>
</table>
</div>
