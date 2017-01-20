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
    public partial class ManagerCart : System.Web.UI.UserControl
    {
        public static int mghdlv;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                load_dl();
           

        }
         void load_dl()
         {
             List<Cart> ds = CartBLL.getListCart();
             foreach (Cart Ca in ds)
             {
                 if (Ca.IsXem != true)
                 {
                     Ca.NameKhach = "<b>" + Ca.NameKhach + "</b>";
                     Ca.PTThanhToan = "<b>" + Ca.PTThanhToan + "</b>";
                 }
             }
             grvGioHang.DataSource = ds;
             grvGioHang.DataKeyNames = new string[]{"IdCart"};
             grvGioHang.DataBind();
         }

         protected void grvGioHang_RowCommand(object sender, GridViewCommandEventArgs e)
         {
             if (e.CommandName.ToUpper() == "CHITIET")
             {

                 int magh =int.Parse( grvGioHang.Rows[int.Parse(e.CommandArgument.ToString())].Cells[0].Text);
                 if (!CartBLL.getCarByID(magh).IsXem) CartBLL.xemCart(magh, Session["user"].ToString());
                 lienketchitiet(magh);
                 mghdlv = magh;
                 load_dl();
             }
         }
         void lienketchitiet(int CartID)
         {
             Cart crt = CartBLL.getCarByID(CartID);
             lblDiaChi.Text = crt.Address;
             lblGichu.Text = crt.Note;
             lblTenkh.Text = crt.NameKhach;
             lblNguoicheck.Text = crt.AccountCheck;
             lblNgay.Text = crt.Date.ToString("dd/MM/yyyy h:mm tt");
             lblTongtien.Text = crt.TotalMoney.ToString("0.000 VND");
             lblEmail.Text = crt.Email;
             lblDienthoai.Text = crt.Phone;           
             List<CartDetail> dsctgh = CartDetailBLL.getListCartDetailByCart(CartID);
             List<Giohang> dsGH = new List<Giohang>();
             foreach (CartDetail GH in dsctgh)
             {
                 Giohang temp = new Giohang();
                 temp.Magh = CartID;
                 temp.Masp = GH.IdProduct;
                 temp.Matensp = ProductBLL.getProductById(GH.IdProduct).IDNameProduct;
                 temp.Tensp = ProductBLL.getProductById(GH.IdProduct).NameProduct;
                 temp.Soluong = GH.AMount;
                 temp.Dongiasp = GH.PriceSaled;
                 temp.Deal = GH.IsDeal;
                 temp.Thanhtien = GH.AMount * GH.PriceSaled;
                 dsGH.Add(temp);
             }
             grvChitiet.DataSource = dsGH;
             grvChitiet.DataKeyNames = new string[] { "Masp" };
             grvChitiet.DataBind();
         }

         protected void btnXoa_Click(object sender, EventArgs e)
         {
             try
             {
                 CartBLL.deleteCart(mghdlv, Session["user"].ToString());
                 MessageBox.Show("Bạn đã xóa thành công giỏ hàng");
             }
             catch
             {
                 MessageBox.Show("Bạn không thể xóa giỏ hàng");
             }
         }

         protected void btnGiao_Click(object sender, EventArgs e)
         {
             try
             {
                 CartBLL.GiaoCart(mghdlv, Session["user"].ToString());
                 MessageBox.Show("Giỏ hàng đã được cập nhật");
                 load_dl();
             }
             catch
             {
                 MessageBox.Show("Giỏ hàng chưa được cập nhật !");
             }
         }




         protected void grvGioHang_PageIndexChanging(object sender, GridViewPageEventArgs e)
         {
             grvGioHang.PageIndex = e.NewPageIndex;
             load_dl();
         }
         class Giohang
         {
             int masp;

             public int Masp
             {
                 get { return masp; }
                 set { masp = value; }
             }
             int magh;

             public int Magh
             {
                 get { return magh; }
                 set { magh = value; }
             }
             string tensp;

             public string Tensp
             {
                 get { return tensp; }
                 set { tensp = value; }
             }
             string matensp;

             public string Matensp
             {
                 get { return matensp; }
                 set { matensp = value; }
             }
             float dongiasp;

             public float Dongiasp
             {
                 get { return dongiasp; }
                 set { dongiasp = value; }
             }
             int soluong;

             bool deal;

             public bool Deal
             {
                 get { return deal; }
                 set { deal = value; }
             }
             public int Soluong
             {
                 get { return soluong; }
                 set { soluong = value; }
             }
             float thanhtien;

             public float Thanhtien
             {
                 get { return thanhtien; }
                 set { thanhtien = value; }
             }
             public Giohang()
             {
             }
         }

      
         
    }
}