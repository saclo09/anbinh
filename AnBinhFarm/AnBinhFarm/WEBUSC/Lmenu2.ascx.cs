using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HP_BLL;
using HP_DAL;
using System.Text;

namespace AnBinhFarm.WEBUSC
{
    public partial class Lmenu2 : System.Web.UI.UserControl
    {
        
            public StringBuilder str = new StringBuilder();
          
       
        protected void Page_Load(object sender, EventArgs e)
        {
            
            List<GroupIterm> ds = GroupItermBLL.getListGroupItermMain();
            foreach (GroupIterm nhom in ds)
            {
                str.Append("<li class='li_me'> <a href='GroupIterm.aspx?loai=" + nhom.IDGroup + "&i=" + BLL.convertURL(nhom.NameGroup) + "'>" + nhom.NameGroup + "</a>");
                List<GroupIterm> dsCon = GroupItermBLL.getListGroupItermChilDren(nhom.IDGroup);
                if (dsCon.Count > 0) str.Append("<ul class='con'>");
                foreach (GroupIterm nhomCon in dsCon)
                {
                    str.Append("<li class='li_con'> <img src='Images/muitendo.gif' />  <a href='GroupIterm.aspx?loai=" + nhomCon.IDGroup + "&i=" + BLL.convertURL(nhomCon.NameGroup) + "'>" + nhomCon.NameGroup + "</a></li>");
                   // str.Append("<li><a href='Loai/" + nhomCon.IDGroup + " /" + nhomCon.NameGroup + ".aspx'>" + nhomCon.NameGroup + "</a></li>");
                    
                }
                if (dsCon.Count > 0) str.Append("</ul>");
                str.Append("<img class='hinhiconmenu' src='Images/icon_arrow-tim.png'/> </li>\n");
            }
        }
    }
}