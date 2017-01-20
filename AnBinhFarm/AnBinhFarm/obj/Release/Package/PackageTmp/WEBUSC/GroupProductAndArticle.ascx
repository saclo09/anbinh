<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="GroupProductAndArticle.ascx.cs" Inherits="AnBinhFarm.WEBUSC.GroupProductAndArticle" %>
<%@ Register src="LGroup.ascx" tagname="LGroup" tagprefix="uc1" %>
<%@ Register src="GroupProduct.ascx" tagname="GroupProduct" tagprefix="uc2" %>

<style type="text/css">
    .vungtrai
    {
        position:relative;
        float:left;
        width:180px;
    }
      .vungphai
    {
        position:relative;
        float:left;
        width:607px;
    }  
    
</style>

<div class="sps" >
    <div class="vungtrai">
        <uc1:LGroup ID="LGroup1" runat="server" />
    </div>
    <div class="vungphai">
        <uc2:GroupProduct ID="GroupProduct1" runat="server" />
    </div>    
</div>

