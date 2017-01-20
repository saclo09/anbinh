using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HP_DAL;
using HP_BLL;

namespace AnBinhFarm.WEBUSC
{
    public partial class SanphamBanChay : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Load_DL();
            }
        }
        void Load_DL()
        {
            int mnh = 0;
            int mbv, msp;
            try
            {
                mnh = (string.IsNullOrEmpty(Request.QueryString["loai"])) ? int.MinValue : int.Parse(Request.QueryString["loai"]);
            }
            catch {mnh=0; }
            try
            {
                mbv = (string.IsNullOrEmpty(Request.QueryString["bv"])) ? int.MinValue : int.Parse(Request.QueryString["bv"]);
                mnh = ArticleBLL.getArticleByID(mbv).GroupIterm;
            }
            catch { }
            try
            {
                msp = (string.IsNullOrEmpty(Request.QueryString["sp"])) ? int.MinValue : int.Parse(Request.QueryString["sp"]);
                mnh = ProductBLL.getProductById(msp).GroupIterm;
            }
            catch { }
            if (mnh <= 0)
            {
                List<Product> dssp = ProductBLL.getListProductSaleGood();
                List<Product> ds5sp = new List<Product>();
                int i = 0;
                foreach (Product sp in dssp) 
                {
                    ds5sp.Add(sp);
                    i++;
                    if (i == 5)
                        break;
                }
                DsBanChay.DataSource = ds5sp;
                DsBanChay.DataBind();
            }
            else
            {
                List<Product> dssp = ProductBLL.getListProductByGroupSaleGood(mnh);
                List<Product> ds5sp = new List<Product>();
                int i = 0;
                foreach (Product sp in dssp) 
                {
                    ds5sp.Add(sp);
                    i++;
                    if (i == 5)
                        break;
                    
                }
                DsBanChay.DataSource = ds5sp;
                DsBanChay.DataBind();
            }
        }
    }
}