using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using HP_DAL;
using HP_BLL;

namespace AnBinhFarm.Admin.usc
{
    public partial class CTBaiviet : System.Web.UI.UserControl
    {
        public static int mbv;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                load_combo();
                Load_dL();
            }
        }
        
  
            void load_combo()
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
           
           
            cboLoai.DataSource = dsloai;
            cboLoai.DataTextField = "Ten";
            cboLoai.DataValueField = "Ma";
            cboLoai.DataBind();
        }
        void Load_dL()
        {
            mbv = 0;
            try
            {

                mbv = int.Parse(Request.QueryString["bv"]);
            }
            catch { mbv = 0; }
            if (mbv != 0)
            {
                Article bv = ArticleBLL.getArticleByID(mbv);
                txtTensp.Text = bv.ArticleName;
                txtNoidung.Value = bv.ArticleContent;
                cboLoai.SelectedValue = bv.GroupIterm.ToString();
                txtDescription.Text = bv.ArticleSummary;
                txtkeyword.Text = bv.ArticleKeyWords;
                hinhssp.ImageUrl = "~/Hinhbv/" + bv.ArticleImage;
                txtNotehinh.Text = bv.NoteImage;
            }
        }

        protected string Upload(string tensp)
        {
            if (fuloadhinhanh.HasFile) //FileUpload có tập tin
            {
                string ext = Path.GetExtension(fuloadhinhanh.PostedFile.FileName); //lấy phần mở rộng của tập tin
                tensp = BLL.convertURL(tensp);
                tensp = tensp + ext; //lấy tên tập tin sẽ lưu
                fuloadhinhanh.SaveAs(Server.MapPath("~/Hinhbv/") + tensp);
                return tensp;

            }
            else return "LOGO21.PNG";
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            string tenbv = txtTensp.Text;
            string noidung = txtNoidung.Value;
            string ghichuhinh = txtNotehinh.Text;
            string tomtat= txtNotehinh.Text;
            string keywords = txtNotehinh.Text;
            int nhom = int.Parse(cboLoai.SelectedValue);
            string hinh = Upload(tenbv);
            if (mbv > 0)
            {
                Article temp = ArticleBLL.getArticleByID(mbv);
                if (hinh == "LOGO21.PNG") hinh = temp.ArticleImage;

                int kq = ArticleBLL.upDateArticle(mbv, tenbv, hinh, ghichuhinh, noidung,tomtat,keywords, nhom);

                if (kq == 1) { MessageBox.Show("update thành công!"); Response.Redirect("ArticleManager.aspx"); }
                else MessageBox.Show("update không thành công!");
            }
            else
            {
                string nguoi = Session["user"].ToString();

                int kq = ArticleBLL.InsertArticle(tenbv, hinh, ghichuhinh, noidung, tomtat, keywords, nhom, nguoi);

                if (kq == 1) { MessageBox.Show("thêm thành công!"); Response.Redirect("ArticleManager.aspx"); }
                else MessageBox.Show(" thêm không thành công!");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("ArticleManager.aspx");
        }

        protected void cboLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            int manhom = int.Parse(cboLoai.SelectedValue);
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

        protected void Button3_Click(object sender, EventArgs e)
        {
           int i= ArticleBLL.deleteArticle(mbv);
           Response.Redirect("ArticleManager.aspx");
        }
    }
}