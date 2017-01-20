<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="QKtimKiem.ascx.cs" Inherits="AnBinhFarm.WEBUSC.QKtimKiem" %>
<%@ Import Namespace="HP_BLL" %>
<style type="text/css">
    .ZZ
    {
        color: #FF0000;
    }
</style>
<div class="boxtittlexanh"> Kết quả tìm kiếm : </div>
 <asp:DataList ID="dsSP" runat="server" RepeatColumns="4" Width="100%" 
        onitemcommand="dsSP_ItemCommand">
        <ItemTemplate >
          <div class="khungsp">
              <center>
             <div style="height:32px"> <h1 class="tieudeSPnho">
              <asp:Label ID="TenSP" runat="server" Text='<%# Eval("NameProduct") %>'></asp:Label>
               <!--<%# Eval("NameProduct")%> -->
               </h1></div>
              <h2 class="maSPnho" >Mã :
              <asp:Label ID="maTenSp" runat="server" Text='<%# Eval("IdNameProduct") %>'></asp:Label>
               <!--Mã : <%# Eval("IdNameProduct")%> -->
               </h2>         
              <a href="/Sp/<%# Eval("IdProduct") +"/"+BLL.convertURL(Eval("NameProduct").ToString())+".aspx"%>">           
              <asp:Image class="hinhSPnho" ID="ImageNHom" runat="server"  
              ToolTip='<%# Eval("NameProduct")%>'
              AlternateText='<%# Eval("NameProduct")%>'
               ImageUrl='<%#(Eval("Images")==null)?"~/Images/noimage.jpg": "~/Hinhsp/"+Eval("Images") %>' />
               </a>
                  
                 <br />
                  <asp:Label ID="tenhinh" runat="server" Visible="false" Text='<%#Eval("Images") %>'></asp:Label>
                <br /><span class="ZZ"><strong>Giá:</strong></span><strong> <asp:Label 
                      ID="lblGia" runat="server" CssClass="ZZ" Text='<%# Eval("Price") %>'></asp:Label>
                  </strong><span class="ZZ"><strong>.000 VNĐ </strong></span><strong>
                  <br class="style1" />
                  </strong>
                  <asp:Button ID="Button1" runat="server" BackColor="#3366FF" CommandName="Mua" Font-Bold="True"
                                    ForeColor="White" Text="Chọn mua" Height="28px" 
                      Width="96px" />
                  <br />
                </center>
           </div>
        </ItemTemplate> 
    </asp:DataList>
    <div align="center" style="background-color: White; width: 100%; position: relative">
    <asp:Button ID="btdau" runat="server" Text="Đầu" OnClick="btdau_Click" />
    <asp:Button ID="btnTruoc" runat="server" Text="Trước" OnClick="btnTruoc_Click" />
    <span class="styleuu">Trang
     <asp:Label ID="lblTrang1" runat="server" Text=""></asp:Label>   
    </span>
    <asp:Button ID="btnSau" runat="server" Text="Sau" OnClick="btnSau_Click" />
    <asp:Button ID="btnCuoi" runat="server" Text="Cuối" OnClick="btnCuoi_Click" />
</div>