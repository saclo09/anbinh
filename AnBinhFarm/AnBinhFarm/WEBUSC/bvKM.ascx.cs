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
    public partial class bvKM : System.Web.UI.UserControl
    {
        static PagedDataSource p = new PagedDataSource();
        public static int intSTT;
        public static int trang_thu = 0;
        public static int tongtrang;
         public int mbv = 1;
        public static  Article bvmoi = new Article();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadDL();
                loadgrv();
            }
        }
        void LoadDL()
        {
            try
            {
                bvmoi = ArticleBLL.getArticleKMNew();
                Image1.ImageUrl = "../Hinhbv/" + bvmoi.ArticleImage;
                Image1.ToolTip = bvmoi.ArticleName;
                lblNgaydang.Text = " Đăng ngày:" + bvmoi.Date.ToString("dd/MM/yyyy hh:mm");
                lblTieude.ToolTip = bvmoi.ArticleName;
                lblTieude.Text = bvmoi.ArticleName;
            }
            catch
            {
            }
        }
       void loadgrv()
        {
             p.DataSource = ArticleBLL.getListArticleByGroup(-2);
            p.PageSize = 18;
            p.CurrentPageIndex = trang_thu;
            p.AllowPaging = true;
            tongtrang = p.PageCount;

            if (trang_thu > tongtrang)
            {
                trang_thu = 0;
                loadgrv();
            }

            //=======liên kết nguồn vào GRV=========
          Dsbv.DataSource = p;          
          Dsbv.DataBind();
        }
    }
}