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
    public partial class DealDetail : System.Web.UI.UserControl
    {
        public static string tensp = "", matensp = "", hinhsp = "";
        public static int masp;
        public static float giasp;
       public static string chitietsp;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                loaddl();
            }
        }
        
        void loaddl()
        {
            Deal dealActive = DealBLL.getDealActiving();
            Product sp = ProductBLL.getProductById(dealActive.ProductId);
            //=========================
            tensp = sp.NameProduct;
            masp = sp.IdProduct;
            matensp = sp.IDNameProduct;
            giasp = dealActive.NewPrice;
            hinhsp = sp.Images;
            chitietsp = sp.Description;
            //======================
            lblTenDeal.Text = tensp;
            lblMa.Text = matensp;
            Image1.ImageUrl = "~/Hinhsp/" + hinhsp;
            lblGiaCu.Text = sp.Price.ToString("0.000 VND");
            lblGiaDeal.Text = dealActive.NewPrice.ToString("0.000 VND");
            lblHetHan.Text = dealActive.StopDate.ToString("dd/MM/yyyy h:mm tt");
            if (DateTime.Now > dealActive.StopDate)
            { btnMua.Visible = false; heTAH.Visible = true; }

        }

        
        protected void btnMua_Click(object sender, EventArgs e)
        {
            double Tongtien = System.Convert.ToInt64(Session["So_tien"]);
            Tongtien += giasp;
            Session["So_tien"] = Tongtien;

            #region Xu ly gio hang
            MAT_HANG Hang = new MAT_HANG();
            Hang.Ten_sp = tensp;
            Hang.MaTen = matensp;
            Hang.Image = hinhsp;
            Hang.IsDeal = true;
            Hang.Ms = masp;
            Hang.Don_gia = giasp;
            #region xu ly
            ArrayList Giohang = (ArrayList)Session["Gio_hang"];
            //Kiem tra đa chọn sách chưa? 
            int n = Kiemtra_tontai(Hang.Ms);
            //Thêm vào giỏ hàng nếu chưa có
            if (n < 0)
            {
                Hang.So_luong = 1;
                Giohang.Add(Hang);
            }
            //Đã có rồi thì tăng So_luong lên 1
            else
            {

                ((MAT_HANG)Giohang[n]).So_luong++;
            }
            #endregion
            #endregion
            Session["Gio_hang"] = Giohang;
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
    }
}