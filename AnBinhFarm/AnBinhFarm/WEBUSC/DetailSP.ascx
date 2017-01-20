<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="DetailSP.ascx.cs" Inherits="AnBinhFarm.WEBUSC.DetailSP" %>
<%@ Register src="ND.ascx" tagname="ND" tagprefix="uc1" %>
<%@ Register src="GroupProduct.ascx" tagname="GroupProduct" tagprefix="uc2" %>
<div>
    
    <uc1:ND ID="ND1" runat="server" />
    <br />
     <uc2:GroupProduct ID="GroupProduct1" runat="server" />
   

</div>