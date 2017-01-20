using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;

namespace AnBinhFarm.WEBUSC
{
    public partial class ThongtinCART : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            float Sotien = float.Parse(Session["So_tien"].ToString());
            lblSoLuong.Text = System.Convert.ToString(((ArrayList)Session["Gio_hang"]).Count);
            
        }
        protected void Page_PreRender(object sender, EventArgs e)
        {
            float Sotien = float.Parse(Session["So_tien"].ToString());
            lblSoLuong.Text = System.Convert.ToString(((ArrayList)Session["Gio_hang"]).Count);
            
        }
    }
}