<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AllDealHETHAN.ascx.cs" Inherits="AnBinhFarm.WEBUSC.AllDealHETHAN" %>

<div>
    <asp:DataList ID="dsDeal" runat="server" RepeatColumns="4" >
        <ItemTemplate>
            <div class="dealcon"  style="background-color:#f5f5f5; width: 200px;">
              <center>
                  Tên sản phẩm:<br />
                <asp:Label ID="lblTen" runat="server" Text='<%# Eval("Ten") %>' 
                      style="font-weight: 700; color: #3333FF"></asp:Label><br />
                <asp:Label ID="lblMa" runat="server" Text='<%# Eval("Maten") %>'></asp:Label><br />
                <asp:Image ID="hinha" runat="server" Height="90px" 
                      ImageUrl='<%# "~/Hinhsp/"+Eval("Hinh") %>' />
                  <br />
                  Giá Deal<br />                
                <asp:Label ID="lblGiaDeal" runat="server" Text='<%# Eval("Giadeal")+".000VND" %>' 
                      style="font-weight: 700; color: #FF0000"></asp:Label>
                  <br />
                  Giá cũ:<br />
                <asp:Label ID="lblGiaCu" runat="server" Text='<%# Eval("Giagoc")+".000VND" %>'></asp:Label>
                  <br />
                  Ngày hết hạn<br />
                <asp:Label ID="lblNgayhet" runat="server" Text='<%# Eval("Ngayhethan") %>' 
                      style="color: #CC3300"  ></asp:Label>
              </center>
            </div>
        </ItemTemplate>
    </asp:DataList>
</div>
