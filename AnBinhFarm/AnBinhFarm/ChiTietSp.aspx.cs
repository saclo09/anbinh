using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HP_BLL;
using System.Configuration;
using System.Web.Routing;

namespace AnBinhFarm
{
    public partial class ChiTietSp : System.Web.UI.Page
    {
        public static string  tieude="";
        public string Des;
        public string KeyW;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                load_DL();
        }
        void load_DL()
        {
            int MasP=1;
           try{ 
               //MasP= (string.IsNullOrEmpty(Request.QueryString["sp"])) ? int.MinValue : int.Parse(Request.QueryString["sp"]);
                MasP = int.Parse(Page.RouteData.Values["productID"].ToString());
              
               tieude = ProductBLL.getProductById(MasP).NameProduct +" - "+ ConfigurationManager.AppSettings["title"].ToString();
           }
           catch { MasP = 1; }
           KeyW = ProductBLL.getProductById(MasP).KeyWord;
           Des = ProductBLL.getProductById(MasP).MetaTitile;
        }
    }
}