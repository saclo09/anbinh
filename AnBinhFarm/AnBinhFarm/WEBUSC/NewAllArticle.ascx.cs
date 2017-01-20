using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HP_BLL;
using  HP_DAL;

namespace AnBinhFarm.WEBUSC
{
    public partial class NewAllArticle : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                load_dl();

        }
        void load_dl()
        {
            List<Article> dsbv = new List<Article>();
            List<Article> dsbvmoi = ArticleBLL.getListArticle();
            int i = 0;
            foreach (Article bv in dsbvmoi)
            {
                dsbv.Add(bv);
                i++;
                if (i == 10) break;
            }
            Dsbv.DataSource = dsbv;
            Dsbv.DataBind();

        }
    }
}