<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SpMoi.ascx.cs" Inherits="AnBinhFarm.WEBUSC.SpMoi" %>
<%@ Import Namespace="HP_BLL" %>
<div class="noidungSpbanchay" style="background-color:#f6f6f6">
    <asp:DataList ID="DsMOI" runat="server">
        <ItemTemplate>
            <div style="padding:5px;"><center>
                <asp:HyperLink ID="hplTenSp" ToolTip='<%# Eval("NameProduct") %>' 
                    runat="server" ForeColor="#0000CC" 
                        NavigateUrl='<%# "~/sp/"+Eval("IdProduct") +"/"+BLL.convertURL(Eval("NameProduct").ToString())+".aspx" %>' 
                        Text='<%# Eval("NameProduct") %>' Font-Bold="True"></asp:HyperLink><br />
                <asp:Label ID="Label1" runat="server" Text='<%# Eval("IdNameProduct")%>' 
                    Font-Bold="True" ></asp:Label><br />
                <a runat="server" href='<%# "~/sp/"+Eval("IdProduct") +"/"+BLL.convertURL(Eval("NameProduct").ToString())+".aspx"%>' id="linkHinh">
                    <asp:Image ID="imgHinhSp" runat="server" Height="165px" Width="150px" 
                    ToolTip='<%# Eval("NameProduct") %>'
                        ImageUrl='<%# "~/Hinhsp/"+Eval("Images") %>' />
                </a><br />
                <asp:Label ID="lblGiaSp" runat="server" Text='<%#(float.Parse(Eval("Price").ToString())<=0)?"Liên hệ": Eval("Price")+".000 Đ" %>' 
                    Font-Bold="True" ForeColor="Red">
                </asp:Label><br />
            </center>
            </div>
        </ItemTemplate>
    </asp:DataList>
</div>
