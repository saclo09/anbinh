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
    public partial class NewDeal : System.Web.UI.UserControl
    {
        public static int mnhom = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                load_dl();
                Load_GRV(0);
            }
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Calendar1.Visible = !Calendar1.Visible;
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            txtNgay.Text = Calendar1.SelectedDate.ToString();
            Calendar1.Visible = !Calendar1.Visible;
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            Calendar2.Visible = !Calendar2.Visible;
        }

        protected void Calendar2_SelectionChanged(object sender, EventArgs e)
        {
            txtNgay0.Text = Calendar2.SelectedDate.ToString();
            Calendar2.Visible = !Calendar2.Visible;
        }
        void loadDealmoi(int masp)
        {
            lblMAspso.Text = masp.ToString();
            lblTen.Text = ProductBLL.getProductById(masp).NameProduct;
            lblMa.Text = ProductBLL.getProductById(masp).IDNameProduct;
            lblGiacu.Text = ProductBLL.getProductById(masp).Price.ToString("0.000Đ");
            imghinh.ImageUrl = "../../Hinhsp/" + ProductBLL.getProductById(masp).Images;
            
        }
        protected void btnTHEM_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lblMAspso.Text) && !string.IsNullOrEmpty(txtPT.Text) && !string.IsNullOrEmpty(txtNgay.Text) && !string.IsNullOrEmpty(txtNgay0.Text) && !string.IsNullOrEmpty(txtGiaMoi.Text))
            {
                int msp = int.Parse(lblMAspso.Text);
                float giamoi = float.Parse(txtGiaMoi.Text);
                int pt = int.Parse(txtPT.Text);
                 DateTime ngaybd ;
                 DateTime ngaykt;
               // ngaybd.GetDateTimeFormats(IFormatProvider
                try
                {
                    ngaybd =DateTime.Parse(txtNgay.Text);
                    ngaykt = DateTime.Parse(txtNgay0.Text);
                }
                catch
                {
                    ngaybd = DateTime.Now;
                    ngaykt = DateTime.Now;
                }
                int i = DealBLL.insertDeal(msp, giamoi, pt, ngaybd, ngaykt, Session["user"].ToString());
                if (i == 1)
                {
                    Response.Redirect("Dealmanager.aspx");
                }
            }
            else
            {
                MessageBox.Show("Phải chọn Sản phẩm và nhập đầy đủ thông tin !");
            }
        }

        protected void grvSp_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName.ToUpper() == "CHON")
            {

                int magh = int.Parse(grvSp.Rows[int.Parse(e.CommandArgument.ToString())].Cells[0].Text);
                loadDealmoi(magh);

            }
        }

        protected void grvSp_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grvSp.PageIndex = e.NewPageIndex;
            Load_GRV(mnhom);
        }
        void load_dl()
        {
            List<nhom> dsloai = new List<nhom>();
            dsloai.Add(new nhom(0, "(--Tất cả--)"));
            List<GroupIterm> ds = GroupItermBLL.getListGroupItermMain();
            foreach (GroupIterm b in ds)
            {
                nhom temp = new nhom(b.IDGroup, b.NameGroup);
                dsloai.Add(temp);
                List<GroupIterm> dsCon = GroupItermBLL.getListGroupItermChilDren(b.IDGroup);
                foreach (GroupIterm con in dsCon)
                {
                    nhom temp2 = new nhom(con.IDGroup, "->" + con.NameGroup);
                    dsloai.Add(temp2);

                }
            }
            cboNhomSp.DataSource = dsloai;
            cboNhomSp.DataTextField = "Ten";
            cboNhomSp.DataValueField = "Ma";
            cboNhomSp.DataBind();
        }
        void Load_GRV(int snhom)
        {
            if (snhom <= 0)
            {
                List<Product> dssp = ProductBLL.getListProduct();
                grvSp.DataSource = dssp;
                grvSp.DataKeyNames = new string[] { "IdProduct" };
                grvSp.DataBind();

            }
            else
            {
                List<Product> dssp = ProductBLL.getListProductByGroupAndRoot(snhom);
                grvSp.DataSource = dssp;
                grvSp.DataKeyNames = new string[] { "IdProduct" };
                grvSp.DataBind();
            }
        }
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            mnhom = int.Parse(cboNhomSp.SelectedValue);
            Load_GRV(mnhom);
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