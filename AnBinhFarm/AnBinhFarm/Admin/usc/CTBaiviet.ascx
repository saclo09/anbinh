<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CTBaiviet.ascx.cs" Inherits="AnBinhFarm.Admin.usc.CTBaiviet" %>

<%@ Register assembly="FredCK.FCKeditorV2" namespace="FredCK.FCKeditorV2" tagprefix="FCKeditorV2" %>

<style type="text/css">

    
    .style2
    {
        width: 162px;
    }
    .style4
    {
        width: 162px;
        background-color: #CCCCCC;
    }
    .style3
    {
        background-color: #CCCCCC;
    }
    </style>
<div>

    <table width="718">
        <tr>
            <td class="style2">
                Tên bài viết</td>
            <td>
                <asp:TextBox ID="txtTensp" runat="server" Width="520px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style2">
                Chọn nhóm tư vấn</td>
            <td>
                <asp:DropDownList ID="cboLoai" runat="server" Height="20px" Width="206px" 
                    AutoPostBack="True" onselectedindexchanged="cboLoai_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="style2">
                Hình ảnh</td>
            <td>
                <asp:FileUpload ID="fuloadhinhanh" runat="server" Width="217px" />
                <asp:Image ID="hinhssp" runat="server" Height="69px" Width="93px" />
            </td>
        </tr>
        <tr>
            <td class="style2">
                Ghi chú hình ảnh</td>
            <td>
                <asp:TextBox ID="txtNotehinh" runat="server" Height="22px" Width="531px"></asp:TextBox>
            </td>
        </tr>         
        <tr>
            <td class="style2">
                Nội dung</td>
            <td>
                <FCKeditorV2:FCKeditor ID="txtNoidung" BasePath="~/Admin/fckeditor/" Height="400" runat="server">
                </FCKeditorV2:FCKeditor>
            </td>
        </tr>
        
         
        <tr>
            <td class="style4">
                <strong>SEO</strong></td>
            <td class="style3">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                Tóm tăt</td>
            <td>
                <asp:TextBox ID="txtDescription" TextMode="MultiLine" runat="server" Width="607px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style2">
                KeyWords</td>
            <td>
                <asp:TextBox ID="txtkeyword" TextMode="MultiLine" runat="server" style="text-align: left" 
                    Width="612px"></asp:TextBox>
            </td>
        </tr>        
        <tr>
            <td> </td>
            <td>
                
                <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
                    Text="Cập nhật " />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="Hủy" />
                
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button3" runat="server" onclick="Button3_Click" 
                    Text="Xóa bài viết" />
                
            </td>
        </tr>
        <tr>
            <td </td>
                &nbsp;<td>
                
                &nbsp;</td>
        </tr>
    </table>

</div>
