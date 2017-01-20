<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UploadDataToExcel.aspx.cs" Inherits="AnBinhFarm.Admin.UploadDataToExcel" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
    <asp:FileUpload ID="FileUpload1" runat="server" />
    <br />
&nbsp;&nbsp;&nbsp;
    <asp:Label ID="lblthongbao" runat="server"></asp:Label>
    <br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnupload" runat="server" Text="Import" 
        onclick="btnupload_Click" Height="25px" />
    </form>
</body>
</html>
