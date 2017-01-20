using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HP_BLL;
using HP_DAL;

namespace AnBinhFarm.WEBUSC
{
    public partial class ArticleDetail : System.Web.UI.UserControl
    {
        public int mbv = 1;
        public static  Article bvmoi = new Article();
        Dictionary<string, int> Links = new Dictionary<string, int>{
            {"lien-he",7},
           {"gioi-thieu-an-binh",3},
           {"tu-lieu-anh",8},
           {"tu-lieu-video",9},
           {"lien-ket",10},
           {"tuyen-dung",11},
           {"quy-trinh-san-xuat",12},
           {"kiem-dinh",13},
           {"kenh-phan-phoi",14},
           {"huong-dan-mua-hang",15},
           {"chinh-sach-ban-hang",16},
        };
         
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                LoadDL();
        }
        void LoadDL()
        {


            if (Page.RouteData.Values["articleID"] != null)
            {
                mbv = int.Parse(Page.RouteData.Values["articleID"].ToString());
            }
            else
            {
                if (Page.RouteData.Values["path"] != null)
                {
                    string strLink = Page.RouteData.Values["path"].ToString();
                    mbv = Links[strLink.ToLower()];
                }
            }
          
            bvmoi = ArticleBLL.getArticleByID(mbv);
            if(bvmoi==null)return;
            Image1.ImageUrl = "/../Hinhbv/" + bvmoi.ArticleImage;
            Image1.ToolTip = bvmoi.ArticleName;
           lblNgaydang.Text= " Đăng ngày:" + bvmoi.Date.ToString("dd/MM/yyyy hh:mm");
           lblTieude.ToolTip = bvmoi.ArticleName;
           lblTieude.Text = bvmoi.ArticleName;
            
        }
    }
   public class ArticleLink
    {
        string _Link;
        public string Link
        {
        get { return _Link; }
        set { _Link = value; }
        }
        int _ID;

        public int ID
        {
        get { return _ID; }
        set { _ID = value; }
        }
        public ArticleLink()
        {

        }
       public ArticleLink(string link, int id)
       {
           this.Link=link;
           this.ID=id;
       }
    }
}