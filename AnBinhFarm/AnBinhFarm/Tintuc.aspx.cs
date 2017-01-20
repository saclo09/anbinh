using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HP_BLL;
using HP_DAL;
using System.Configuration;

namespace AnBinhFarm
{
    public partial class Tintuc : System.Web.UI.Page
    {
        public string strTittle = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                lamtieude();
        }
        public void lamtieude()
        {
            int Mnh = 0;
            int msp = 0;
            try
            {
                msp = (string.IsNullOrEmpty(Request.QueryString["bv"])) ? int.MinValue : int.Parse(Request.QueryString["bv"]);
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
            catch { Mnh = 1; }
            string tennhom = "";
            try { tennhom = GroupItermBLL.getGroupItermByID(Mnh).NameGroup; }
            catch { tennhom = " Sản phẩm tốt"; }
            strTittle =tennhom +  " - " + ConfigurationManager.AppSettings["title"].ToString();
        }
    }
}