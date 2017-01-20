using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HP_DAL;
using HP_BLL;
using System.IO;

namespace AnBinhFarm.Admin.usc
{
    public partial class SanPham : System.Web.UI.UserControl
    {
        public static int msp;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                load_Cbo();
                Load_dL();
            }

        }
        void load_Cbo()
        {
           List<nhom> dsloai = new List<nhom>();
            List<GroupIterm> ds = GroupItermBLL.getListGroupItermMain();
            foreach (GroupIterm b in ds)
            {
                nhom temp = new nhom(b.IDGroup, b.NameGroup);
                dsloai.Add(temp);
               List<GroupIterm> dsCon =GroupItermBLL.getListGroupItermChilDren(b.IDGroup);
               foreach (GroupIterm con in dsCon)
               {
                   nhom temp2 = new nhom(con.IDGroup, "->"+con.NameGroup);
                   dsloai.Add(temp2);

               }
            }
            cboLoai.DataSource = dsloai;
            cboLoai.DataTextField = "Ten";
            cboLoai.DataValueField = "Ma";
            cboLoai.DataBind();
        }
        void Load_dL()
        {
            msp = 0;
            try
            {

                msp = int.Parse(Request.QueryString["sp"]);
            }
            catch { msp =0; }
            if (msp != 0)
            {
                Product sp = ProductBLL.getProductById(msp);
                txtTensp.Text = sp.NameProduct;
                txtMaten.Text = sp.IDNameProduct;
                txtNoidung.Value = sp.Description;
                txtGia.Text = sp.Price.ToString();
                txtGianote.Text = sp.PriceNote.ToString() ;
                cboLoai.SelectedValue = sp.GroupIterm.ToString();
                txtDescription.Text = sp.MetaTitile;
                txtkeyword.Text = sp.KeyWord;                
                txtSoluong.Text = sp.Soluong.ToString();
                hinhssp.ImageUrl = "~/Hinhsp/" + sp.Images;
                txtMausac.Text = sp.Color;
                checkHot.Checked = sp.IsHot;
                chkNew.Checked = sp.IsNew;
                chkbKhuyenmai.Checked = sp.IsGiamGiaPt;
                txtKhaiPT.Text = sp.GiamGiaPT.ToString();
                txtChatlieu.Text = sp.Material;
                txtMutiprice.Text = sp.MultiPrice;


            }
        }

        protected void cboLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            int manhom=int.Parse(cboLoai.SelectedValue);
            txtDescription.Text = GroupItermBLL.getGroupItermByID(manhom).Tittle;
            txtkeyword.Text = GroupItermBLL.getGroupItermByID(manhom).Keyword;
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

        protected string Upload(string tensp)
        {
            if (fuloadhinhanh.HasFile) //FileUpload có tập tin
            {
                string ext = Path.GetExtension(fuloadhinhanh.PostedFile.FileName); //lấy phần mở rộng của tập tin
                tensp = BLL.convertURL(tensp);
                tensp = tensp + ext; //lấy tên tập tin sẽ lưu
                fuloadhinhanh.SaveAs(Server.MapPath("~/Hinhsp/") + tensp);
                return tensp;

            }
            else return "kodc";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string ten=string.IsNullOrEmpty(txtTensp.Text)?"":txtTensp.Text; 
            string maten=string.IsNullOrEmpty(txtMaten.Text)?"":txtMaten.Text;
            string hinh="";
            //dùng mã sản phẩm để thay tên cho hình ảnh sả phẩm
            if (Upload(maten) == "kodc") hinh = "LOGO21.PNG"; else hinh=Upload(maten);

            string mausac=string.IsNullOrEmpty(txtMausac.Text) ?"":txtMausac.Text;
            string ndsp=txtNoidung.Value;
            float gia=string.IsNullOrEmpty(txtGia.Text) ?0:float.Parse(txtGia.Text);
            float gianote=string.IsNullOrEmpty(txtGianote.Text) ?0:float.Parse(txtGianote.Text);
            bool ishot=  checkHot.Checked;
            bool  isnew=chkNew.Checked;
            bool km=chkbKhuyenmai.Checked;
            int kmpt=string.IsNullOrEmpty(txtKhaiPT.Text) ?0:int.Parse(txtKhaiPT.Text);
            int nhom=int.Parse(cboLoai.SelectedValue);
            int soluong=string.IsNullOrEmpty(txtSoluong.Text) ?1:int.Parse(txtSoluong.Text);
            string userUD=Session["user"].ToString();
            string mota=string.IsNullOrEmpty(txtDescription.Text) ?"":txtDescription.Text;
            string keywword=string.IsNullOrEmpty(txtkeyword.Text) ?"":txtkeyword.Text;
            string chatlieu = string.IsNullOrEmpty(txtkeyword.Text) ? "" : txtChatlieu.Text;
            string nhieugia = string.IsNullOrEmpty(txtkeyword.Text) ? "" : txtMutiprice.Text;

            if (ten != "" && maten != "")
            {
                if (msp > 0)
                {
                    Product temp = ProductBLL.getProductById(msp);
                    if (hinh == "LOGO21.PNG") hinh = temp.Images;
                    int kq = ProductBLL.updateProduct(msp, maten, ten, hinh, mausac, nhom, ndsp, gia, gianote, chatlieu, nhieugia, soluong, isnew, ishot, km, kmpt, userUD, keywword, mota);
                    if (kq == 1) { MessageBox.Show("update thành công!"); Response.Redirect("ProductManager.aspx"); }
                    else MessageBox.Show("update không thành công!");
                }
                else
                {
                    int kq = ProductBLL.insertProdcut(maten, ten, hinh, mausac, nhom, ndsp, gia, gianote, chatlieu, nhieugia, soluong, isnew, ishot, km, kmpt, userUD, mota, keywword);
                    if (kq == 1) { MessageBox.Show("thêm thành công!"); Response.Redirect("ProductManager.aspx"); }
                    else MessageBox.Show(" thêm không thành công!");
                }
            }
            else
                MessageBox.Show("Hãy nhập đầy đủ thông tin tên và mã sản phẩm!");
        }
        
        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("ProductManager.aspx");
        }

        protected void btnXoa_Click(object sender, EventArgs e)
        {
          int i= ProductBLL.deleteProduct(msp, Session["user"].ToString());
          if (i == 1)
          {
              MessageBox.Show("Xóa thành công!");
              Response.Redirect("ProductManager.aspx");
          }
          MessageBox.Show("Server đang bận nên bạn làm lại sau nhe!");
        }
    }
}