using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HP_BLL;
using System.Configuration;

namespace AnBinhFarm
{
    public partial class Chitietbv : System.Web.UI.Page
    {
        public static string strtitle;
        public string Des;
        public string KeyW;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                loadtd();

        }
        void loadtd()
        {
            int idbv;
            string tieude;
            string tenbv;
            try
            {
               idbv = (int.Parse(Request.QueryString["bv"]));
               tieude = ConfigurationManager.AppSettings["title"].ToString();
               tenbv=ArticleBLL.getArticleByID(idbv).ArticleName;
            }
            catch
            {
                idbv = 1;
                tieude = "noi that";
                tenbv = "bài viết";
            }


            strtitle = tenbv + " - " + tieude;
            Des = tenbv;
            KeyW = tenbv;

        }
    }
}