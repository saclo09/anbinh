using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using HP_BLL;
using HP_DAL;

namespace AnBinhFarm.WEBUSC
{
    public partial class LMenu : System.Web.UI.UserControl
    {
       
            public StringBuilder str = new StringBuilder();
          
       
        protected void Page_Load(object sender, EventArgs e)
        {
            
            List<GroupIterm> ds = GroupItermBLL.getListGroupItermMain();
            foreach (GroupIterm nhom in ds)
            {
                str.Append("<li><h3 class='h3menu'><a href='/sp-list/" + nhom.IDGroup + "/" + BLL.convertURL(nhom.NameGroup) + ".aspx'>" + nhom.NameGroup + "</a></h3>");
                List<GroupIterm> dsCon = GroupItermBLL.getListGroupItermChilDren(nhom.IDGroup);
                if (dsCon.Count > 0)
                {
                    str.Append("<ul>");
                    foreach (GroupIterm nhomCon in dsCon)
                    {
                        str.Append("<li><h3 class='h3menu'><a href='/sp-list/" + nhomCon.IDGroup + "/" + BLL.convertURL(nhomCon.NameGroup) + ".aspx'>" + nhomCon.NameGroup + "</a></h3>");
                        // str.Append("<li><a href='Loai/" + nhomCon.IDGroup + " /" + nhomCon.NameGroup + ".aspx'>" + nhomCon.NameGroup + "</a></li>");
                        List<GroupIterm> dsConc = GroupItermBLL.getListGroupItermChilDren(nhomCon.IDGroup);
                        if (dsConc.Count > 0)
                        {
                            str.Append("<ul>");
                            foreach (GroupIterm nhomConc in dsConc)
                            {
                                str.Append("<li><h3 class='h3menu'><a href='/sp-list/" + nhomConc.IDGroup + "/" + BLL.convertURL(nhomConc.NameGroup) + ".aspx'>" + nhomConc.NameGroup + "</a></h3></li>");
                                // str.Append("<li><a href='Loai/" + nhomCon.IDGroup + " /" + nhomCon.NameGroup + ".aspx'>" + nhomCon.NameGroup + "</a></li>");

                            }
                            str.Append("</ul>");
                        }
                        str.Append("</li>");
                    }
                    str.Append("</ul>");
                }
                str.Append("</li>\n");
            }
        }
    }
}