<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ND.ascx.cs" Inherits="AnBinhFarm.WEBUSC.ND" %>

<style type="text/css">
    
    .boxCTtrensp
    {
        position:relative;
        float:left;
        width:100%;
    }
    .boxCTHinh
    {
        position:relative;
        float:left;
        width:45%;
    }
    .boxCTND
    {
        position:relative;
        float:right;
        width:55%;
    }
</style>
<div>  
   <div class="boxtittlexanh">CHI TIẾT SẢN PHẨM :</div>
   <div class="boxCTtrensp">
                <div class="boxCTHinh">
                        <asp:Image ID="Image1" CssClass="hinhND" runat="server" Height="311px" Width="319px" /><br />
                        <asp:Label ID="lblMaSp" runat="server" Visible="false" >
                        </asp:Label><asp:Label ID="lblTenSp" runat="server" Visible="false" ></asp:Label>
                </div>
                <div class="boxCTND">
                        <h1 class="tieudeSPlon">Tên sản phẩm : <%= NameProduct %></h1>                    
                        <strong>Mã: <asp:Label ID="lblIdNAme" runat="server" Text='<%# Eval("IdNameProduct") %>'></asp:Label><br />
                        Tình trạng: <asp:Label ID="lblTinhtrang" runat="server" Text='<%# ((int)Eval("Soluong")<0)?"Hết hàng":"Còn hàng" %>'></asp:Label><br />
                        Màu sắc: <asp:Label ID="lblMauSac" runat="server" Text='<%# Eval("Color") %>'></asp:Label>
                        <br />
                        Xuất xứ:
                        <asp:Label ID="lblXuatxu" runat="server"></asp:Label>
                        <br />
                        Giá củ: </strong> <del><strong><asp:Label ID="lblGiaCu" runat="server" ></asp:Label>
                        </strong></del><strong><br />
                        </strong>
                        <strong style="color:Red">
                        Giá bán</strong><strong>: <asp:Label ID="lblGIAHT" runat="server" 
                            Font-Bold="True" Text="Label" ForeColor="Red"></asp:Label>
                        </strong>&nbsp;<b><strong><asp:Label ID="lblGia" runat="server" Visible="False" ></asp:Label>  
                            <asp:Label ID="lblTenhinh" Visible="false" runat="server" ></asp:Label>
                        </strong>
                        <br />
                        </b>                 
                        <br />
                        <asp:Button ID="btnMua" runat="server" BackColor="#3366FF" CommandName="Mua" 
                            Font-Bold="True" ForeColor="White" Text="CHỌN MUA" 
                            onclick="btnMua_Click" />
                        <br />
                       
                    
                 </div>
   </div>
      <div style="padding:5px">                  
          <br />
        <strong>Mô tả sản phẩm :</strong>
         <br /><%= noidungSp %>
                        
      </div>
      <div style="padding:5px">
                       <b> Bình luận:</b> <%= binhluan %>
       </div>
      <div style="padding:5px">
                 <table style="background-color:#fafafa;width:80%; float:left" >
                            <tr>
                                <td>
                                    Họ và tên</td>
                                <td>
                                    <asp:TextBox ID="txtHovaTen" runat="server" Width="358px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Email:</td>
                                <td>
                                    <asp:TextBox ID="txtEmail" runat="server" Width="366px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Nội dung bình luận </td>
                                <td>
                                    <asp:TextBox ID="txtNoidung" runat="server" Width="418px" Height="87px" 
                                        TextMode="MultiLine"></asp:TextBox>
                                </td>
                            </tr>
                            <tr align="center">
                                
                                <td colspan="2">
                                    <asp:Button ID="btnGuibinhLuan" runat="server" Text="Gửi bình luận" 
                                        onclick="btnGuibinhLuan_Click" />
                                </td>
                            </tr>
                        </table>
                </div>
                       
</div>
