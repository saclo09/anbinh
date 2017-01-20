<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="AnBinhFarm.Admin.login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
    <head id="Head1" runat="server">
        <title>Trang đăng nhập</title>    
    <style type="text/css">
       
        .bogoc
        {   
            -moz-border-radius-topleft:10px; 
            -webkit-border-top-left-radius:10px;
            -moz-border-radius-topright:10px;
            -webkit-border-top-right-radius:10px;
            width:392px;
            margin:auto;
            background-color:Green;
            height: 38px;
           
        }
        #top
        {
            background-image:url('images/nenlogin.jpg');
            height: 59px;
        }
        #bottom
        {
            height:60px;
            bottom:0px;
            border-top:1px solid #accaac;
            border:1px solid #accaac;
            position:fixed;
            width:100%;
            
        }
        body
        {
            width:100%;
            height:100%;
            margin:0 0 0 0;
            padding:0 0 0 0;
        }
         #Form1
        {
           
           position:absolute;
           width:100%;
           height:700px;
        }
        .style1
        {
            width: 162px;
        }
        .style2
        {
            height: 25px;
        }
        .styleeee
        {
            width: 87px;
            height: 114px;
            padding:10px 0px 0px 30px;
        }
        .style3
        {
            height: 7px;
        }
        .style4
        {
            height: 29px;
        }
        #styles
        {
            font-size:large;
            padding:7px 0px 0px 10px;
            position:relative;
            width:340px;
            float:left;
            font-weight:bold;
            color:White;
        }
        .style5
        {
            height: 17px;
        }
        .style6
        {
            height: 37px;
        }
    </style>
    
</head>
<body>
<form id="Form2" runat="server">  
    <div id="top">
    <div style="width:100px;padding:10px 0px 0px 10px;color:White;font-size:x-large">ADMINISTRTION</div>
    </div>  
   <div style="height:100px;"></div>
        <div class="bogoc" > 
            <img style=" padding:10px 0px 0px 10px; width:25px; float:left;" src="images/lockscreen.png" />
           <div id="styles"> Hãy điền tên đăng nhập và mật khẩu</div>
         </div>

        <table align="center" 
            style="width: 392px;border:1px solid gray; height: 225px;">
            <tr>
                <td class="style1" rowspan="5">                    
                    <img alt="" class="styleeee" src="images/login.png" /></td>
                <td >
                    
                </td>
            </tr>
            <tr >
                
                <td class="style5">Tên đăng nhập :
                </td>
            </tr>
            <tr>
                <td class="style4">
                    <asp:TextBox ID="txtUserName" runat="server" Height="24px" Width="201px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style3">
                    Mật khẩu :
                </td>
            </tr>
            <tr>
                <td class="style6">
                    <asp:TextBox ID="txtPassWord" runat="server" Height="20px" TextMode="Password" 
                        Width="199px"></asp:TextBox>
                </td>
            </tr>
            <tr align="center">
                <td colspan="2">
                    <asp:Button ID="btnDangNhap" runat="server" Text="Đăng Nhập" OnClick="btnDangNhap_Click" />
                </td>
            </tr>
            <tr align="center">
                <td colspan="2" class="style2">
                    <asp:Label ID="lblThongbao" runat="server" ForeColor="Red"></asp:Label>
                </td>
            </tr>
        </table>
        
    <div id="bottom">
    <center>
    <span class="st">© Copyright 2013 by Bien Pham</span>
    
    </center>
    </div>
    
    </form>
</body>
</html>
