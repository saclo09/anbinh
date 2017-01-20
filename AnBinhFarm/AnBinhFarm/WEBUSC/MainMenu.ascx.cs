using HP_BLL;
using HP_DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AnBinhFarm.WEBUSC
{
    public partial class MainMenu : System.Web.UI.UserControl
    {
         protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                load_DL();

        }
        void load_DL()
        {
            rptMenu.DataSource = LinkBLL.getListLinkMainMenu(0);
            rptMenu.DataBind();
                      
        }
        protected void ItemBound(object sender, RepeaterItemEventArgs args)
        {
           if (args.Item.ItemType == ListItemType.Item || args.Item.ItemType == ListItemType.AlternatingItem)
            {
                Repeater childRepeater = (Repeater)args.Item.FindControl("ChildRepeater");
                int parentid = ((Link)args.Item.DataItem).LinkID;
                childRepeater.DataSource= LinkBLL.getListLinkMainMenu(parentid);
                childRepeater.DataBind();
            }
        }
    }
}