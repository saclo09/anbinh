using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HP_BLL;
using HP_DAL;
using System.Collections;

namespace AnBinhFarm.WEBUSC
{
    public partial class NDSP : System.Web.UI.UserControl
    {
        public string NameProduct = "";
        public static int masp = 0;
        public static string binhluan = "";
        public string noidungSp = "";
        public string noidungMota = "";
        public static string giakhac = "";
        public static string Hinhto = "";
        Product SP = new Product();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                loadDL();
                loadCBBsoluong();
            }
        }
        void loadCBBsoluong()
        {
            for (int i = 1; i < 100; i++)
            {
                ddlSoluong.Items.Add(i.ToString());
            }
        }
        void loadDL()
        {
            int MaSP = Page.RouteData.Values["productID"]!=null?int.Parse(Page.RouteData.Values["productID"].ToString()):0;
            SP = ProductBLL.getProductById(MaSP);
            if(SP==null)
            {
                return;
            }
            masp = MaSP;
            ProductBLL.tangluotxem(MaSP);//tăng lượt người xem sản phẩm này;
            noidungSp = SP.Description;
            noidungMota = GroupItermBLL.getGroupItermByID(SP.GroupIterm).Description;
            NameProduct = SP.NameProduct;
            lblTenSp.Text = SP.NameProduct;
            lblTenSanP.Text = SP.NameProduct;
            Hinhto = "/../Hinhsp/"+SP.Images;
            if (SP.Manufacturer > 0)
                lblXuatxu.Text = ManufacturerBLL.getManufacturerBYId(SP.Manufacturer).ManufacturerName;
            else
                lblXuatxu.Text = "chưa cập nhật";
            lblMaSp.Text = SP.IdProduct.ToString();
            lblIdNAme.Text = SP.IDNameProduct;
            if (SP.PriceNote > 0)
                lblGiaCu.Text = SP.PriceNote.ToString("0.000 VND");
            else lblGiaCu.Text = "Chưa cập nhật";
            if (SP.Price > 0) lblGIAHT.Text = SP.Price.ToString("0.000VND");
            else lblGIAHT.Text = "Liên hệ";
            lblGia.Text = SP.Price.ToString();
            lblMauSac.Text = SP.Color;
            lblKhuyenmai.Text = "Không";
            if (SP.IsGiamGiaPt == true)
                lblKhuyenmai.Text = SP.GiamGiaPT.ToString() + " %";
            lblTinhtrang.Text = (SP.Soluong < 0) ? "Hết hàng" : "Còn hàng";
            lblGia.Text = SP.Price.ToString();
            lblTenhinh.Text = SP.Images;
            Image1.AlternateText = NameProduct;
            Image1.ImageUrl = "~/Hinhsp/" + SP.Images;
            Image1.ToolTip = NameProduct;
            lblChatlieu.Text = SP.Material;
            giakhac = SP.MultiPrice;
            binhluan = loadBinhluan(SP.IdProduct);


        }

        string loadBinhluan(int sp)
        {
            string result = "";
            List<Comment> dsbinhluan = CommentBLL.getListCommentByProduct(sp);
            foreach (Comment bl in dsbinhluan)
            {
                result += "<div style='padding:0px 5px 0px 5px;'><b>" + bl.Name + " </b>(" + bl.Email + ")";
                result += "<br> " + bl.ContentComment + ".</div>";
            }
            return result;
        }
        protected void btnMua_Click(object sender, EventArgs e)
        {
            int soluong = 1;
            try { soluong = int.Parse(ddlSoluong.SelectedItem.ToString()); }
            catch { }
            double Tongtien = System.Convert.ToInt64(Session["So_tien"]);
            Tongtien += float.Parse(lblGia.Text);
            Session["So_tien"] = Tongtien;

            #region Xu ly gio hang
            MAT_HANG Hang = new MAT_HANG();
            Hang.Ten_sp = lblTenSp.Text;
            Hang.MaTen = lblIdNAme.Text;
            Hang.Image = lblTenhinh.Text;
            Hang.IsDeal = false;
            Hang.Ms = int.Parse(lblMaSp.Text);
            Hang.Don_gia = float.Parse(lblGia.Text);
            #region xu ly
            ArrayList Giohang = (ArrayList)Session["Gio_hang"];
            //Kiem tra đa chọn sách chưa? 
            int n = Kiemtra_tontai(Hang.Ms);
            //Thêm vào giỏ hàng nếu chưa có
            if (n < 0)
            {
                Hang.So_luong = soluong;
                Giohang.Add(Hang);
            }
            //Đã có rồi thì tăng So_luong lên 1
            else
            {

                ((MAT_HANG)Giohang[n]).So_luong+=soluong ;
            }

            #endregion
            Session["Gio_hang"] = Giohang;
            #endregion
        }

        private Int16 Kiemtra_tontai(int pMs)
        {

            ArrayList Giohang = (ArrayList)Session["Gio_Hang"];
            for (Int16 i = 0; i < Giohang.Count; i++)
            {
                MAT_HANG Sach = (MAT_HANG)Giohang[i];
                if (Sach.Ms == pMs) return i;
            }
            return -1;
        }

        protected void btnGuibinhLuan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtHovaTen.Text) || string.IsNullOrEmpty(txtNoidung.Text))
                MessageBox.Show("Bạn hảy điền đầy đủ thông tin !");
            else if (!(txtEmail.Text.Contains('@')))
                MessageBox.Show("Email của bạn không chính xác !");
            else
            {
                CommentBLL.insertComment(masp, txtHovaTen.Text, txtEmail.Text, txtNoidung.Text);
                MessageBox.Show("Cảm ơn bạn đã gửi bình luận về sản phẩm cho chúng tôi");
                txtEmail.Text = "";
                txtHovaTen.Text = "";
                txtNoidung.Text = "";
            }
        }
    }
}