using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HP_BLL;

namespace AnBinhFarm.WEBUSC
{
    public partial class Mappath : System.Web.UI.UserControl
    {
        public string path;
        protected void Page_Load(object sender, EventArgs e)
        {
            int msp;
            int Mnh;
            try
            {
                try
                {
                    msp = (string.IsNullOrEmpty(Request.QueryString["sp"])) ? int.MinValue : int.Parse(Request.QueryString["sp"]);
                }
                catch
                {
                    msp = -1;
                }
                try
                {
                    if (msp < 0)
                        Mnh = (string.IsNullOrEmpty(Request.QueryString["loai"])) ? int.MinValue : int.Parse(Request.QueryString["loai"]);
                    else
                        Mnh = ProductBLL.getProductById(msp).GroupIterm;
                }
                catch { Mnh = -1; }
                if (Mnh > 0)
                    path = "<a title='"+ GroupItermBLL.getGroupItermByID(Mnh).NameGroup +"' href='/sp-list/" + Mnh + "/" +BLL.convertURL( GroupItermBLL.getGroupItermByID(Mnh).NameGroup) + ".aspx'>" + GroupItermBLL.getGroupItermByID(Mnh).NameGroup + "</a>";
                if (msp > 0)
                {
                    path = "<a title='" + GroupItermBLL.getGroupItermByID(Mnh).NameGroup + "' href='/sp-list/" + Mnh + "/" + BLL.convertURL(GroupItermBLL.getGroupItermByID(Mnh).NameGroup) + ".aspx'>" + GroupItermBLL.getGroupItermByID(Mnh).NameGroup + "</a>";
                    path+= " >>  "+ ProductBLL.getProductById(msp).NameProduct;
                }
            }
            catch
            {
            }
        }
    }
}