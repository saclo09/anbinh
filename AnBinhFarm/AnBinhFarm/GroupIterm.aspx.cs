using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HP_BLL;
using System.Configuration;

namespace AnBinhFarm.chitiet
{
    public partial class GroupIterm : System.Web.UI.Page
    {
        public string Tennhom = "";
        public string strTittle = "";
        public string Des="";
        public string KeyW="";
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
                msp = (string.IsNullOrEmpty(Request.QueryString["sp"])) ? int.MinValue : int.Parse(Request.QueryString["sp"].ToString());
            }
            catch
            {
                msp = -1;
            }
            try
            {
                if (msp < 0)
                    Mnh = (string.IsNullOrEmpty(Request.QueryString["loai"])) ? int.MinValue : int.Parse(Request.QueryString["loai"].ToString());
                else
                    Mnh = ProductBLL.getProductById(msp).GroupIterm;
            }
            catch { Mnh = 1; }
            string tennhom="";
            try { tennhom = GroupItermBLL.getGroupItermByID(Mnh).NameGroup; }
            catch { tennhom = " Sản phẩm tốt"; }
            strTittle =  tennhom +" - "+ ConfigurationManager.AppSettings["title"].ToString();
            KeyW = tennhom;
            Des = tennhom;
            Tennhom = tennhom;
        }
    }
}