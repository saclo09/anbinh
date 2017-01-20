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
    public partial class HomeNoiDung : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
                LoadDL();
        }
        void LoadDL()
        {

            Article bvmoi = ArticleBLL.getArticleByID(3);
            if (bvmoi!=null)
            {
                imgTitle.ImageUrl = "/../Hinhbv/" + bvmoi.NoteImage;
                imgNd.ImageUrl = "/../Hinhbv/" + bvmoi.ArticleImage;
                txtNd.Text = bvmoi.ArticleContent;
            }
        }
    }
}