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
    public partial class HotArticle : System.Web.UI.UserControl
    {
    
       public  static String strHot="";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                load_DL();
        }
        void load_DL()
        {
            int mnh = 0;
            int mbv, msp;
            try
            {
                mnh = (string.IsNullOrEmpty(Request.QueryString["loai"])) ? int.MinValue : int.Parse(Request.QueryString["loai"]);
            }
            catch { }
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
            catch{}

            List<Article> dsbv = ArticleBLL.getListArticleByGroup(mnh);
            strHot = "";
            int i=0;
            foreach (Article bvtemp in dsbv)
            {
                strHot += "<img src='/Images/icon.gif' height='10' width='10' />  <a class='chuchay' href='/bv/"+bvtemp.ArticleID+"/"+BLL.convertURL(bvtemp.ArticleName)+".aspx'>"+bvtemp.ArticleName+"</a>. <br/>\n";
                i++;
                if(i==8)break;               
            }
        }
    }
}