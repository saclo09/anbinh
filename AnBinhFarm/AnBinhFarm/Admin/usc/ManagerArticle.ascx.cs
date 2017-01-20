using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HP_BLL;
using HP_DAL;

namespace AnBinhFarm.Admin.usc
{
    public partial class ManagerArticle : System.Web.UI.UserControl
    {
        public static int mnh=-10;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                load_dl();
                Load_GRV(mnh);
            }
        }
        void load_dl()
        {
            List<nhom> dsloai = new List<nhom>();
            dsloai.Add(new nhom(-10, "(--Tất cả--)"));
            //dsloai.Add(new nhom(-2, "Khuyến mãi"));
            dsloai.Add(new nhom(7, "Tin tức"));
            //dsloai.Add(new nhom(0, "Quan trọng"));
            //List<GroupIterm> ds = GroupItermBLL.getListGroupItermMain();
            List<Link> ds = LinkBLL.getListLinkMainMenu(0);
            foreach (Link b in ds)
            {
                nhom temp = new nhom(b.LinkID, b.Name);
                dsloai.Add(temp);
                //List<Link> dsCon = LinkBLL.getListLinkMainMenu(b.LinkID);
                //foreach (Link con in dsCon)
                //{
                //    nhom temp2 = new nhom(con.LinkID, "->" + con.Name);
                //    dsloai.Add(temp2);

                //}
            }
            cboNhomSp.DataSource = dsloai;
            cboNhomSp.DataTextField = "Ten";
            cboNhomSp.DataValueField = "Ma";
            cboNhomSp.DataBind();
        }
       
          void Load_GRV(int snhom)
        {
            if (snhom <= -10)
            {
                List<Article> dssp = ArticleBLL.getListArticle();
                Article a=new Article();
               

                grvSp.DataSource = dssp;
                grvSp.DataKeyNames = new string[] { "ArticleID" };
                grvSp.DataBind();

            }
            else
            {
                List<Article> dssp = ArticleBLL.getListArticleByGroup(snhom);
                grvSp.DataSource = dssp;
                grvSp.DataKeyNames = new string[] { "ArticleID" };
                grvSp.DataBind();
            }
        }
         protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            mnh = int.Parse(cboNhomSp.SelectedValue);
            Load_GRV(mnh);
        }

        protected void grvSp_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName.ToUpper() == "SUA")
            {

                int magh = int.Parse(grvSp.Rows[int.Parse(e.CommandArgument.ToString())].Cells[0].Text);
                Response.Redirect("baiviet.aspx?bv=" + magh);

            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("baiviet.aspx");
        }
        protected void grvSp_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grvSp.PageIndex = e.NewPageIndex;
            Load_GRV(mnh);
           
        }
        class nhom
        {
            int ma;
            public int Ma
            {
                get
                {
                    return ma;
                }
                set
                {
                    if (ma == value)
                        return;
                    ma = value;
                }
            }
            string ten;
            public string Ten
            {
                get
                {
                    return ten;
                }
                set
                {
                    if (ten == value)
                        return;
                    ten = value;
                }
            }
            public nhom() { }
            public nhom(int pma, string pten)
            {
                this.Ten = pten;
                this.Ma = pma;
            }
        }

        
    }
}