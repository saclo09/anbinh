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
    public partial class ArticleByGroup : System.Web.UI.UserControl
    {
        static PagedDataSource p = new PagedDataSource();
        public static int intSTT;
        public static int trang_thu = 0;
        public static int tongtrang;
        public static string tennhom = ""; 
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                loadDL();

        }
        void loadDL()
        {
            int Mnh = 5;//Tin tuc
            p.DataSource = ArticleBLL.getListArticleByGroup(Mnh);
            p.PageSize = 18;
            p.CurrentPageIndex = trang_thu;
            p.AllowPaging = true;
            tongtrang = p.PageCount;

            if (trang_thu > tongtrang)
            {
                trang_thu = 0;
                loadDL();
            }

            //=======liên kết nguồn vào GRV=========
          Dsbv.DataSource = p;          
          Dsbv.DataBind();
            
       
        }
    }
}