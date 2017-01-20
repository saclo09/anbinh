using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using HP_DAL;
using HP_BLL;

namespace AnBinhFarm.WEBUSC
{
    public partial class QKtimKiem : System.Web.UI.UserControl
    {
        static PagedDataSource p = new PagedDataSource();
        public static int intSTT;
        public static int trang_thu = 0;
        public static int tongtrang;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                load_DL();

        }
        void load_DL()
        {
           int Mnh = (string.IsNullOrEmpty(Request.QueryString["loai"])) ? int.MinValue : int.Parse(Request.QueryString["loai"]);
           string tukhoa = (string.IsNullOrEmpty(Request.QueryString["tk"])) ? "" : Request.QueryString["tk"];
            p.DataSource = ProductBLL.timkiemProduct(Mnh,tukhoa);
            p.PageSize = 24;
            p.CurrentPageIndex = trang_thu;
            p.AllowPaging = true;
            tongtrang = p.PageCount;

            if (trang_thu > tongtrang)
            {
                trang_thu = 0;
                load_DL();
            }

            //=======liên kết nguồn vào GRV=========
            dsSP.DataSource = p;
            dsSP.DataKeyField = "IdProduct";
            dsSP.DataBind();
            //================            
            hiennut();
        }
        void hiennut()
        {
            lblTrang1.Text = (trang_thu + 1).ToString() + "/" + tongtrang.ToString();

            btdau.Enabled = true; btnTruoc.Enabled = true; btnSau.Enabled = true; btnCuoi.Enabled = true;

            if (p.IsFirstPage == true)//neu la dau.
            {
                btdau.Enabled = false;
                btnTruoc.Enabled = false;

            }

            if (p.IsLastPage == true)//neu la cuoi
            {
                btnSau.Enabled = false;
                btnCuoi.Enabled = false;
            }
        }

        protected void btdau_Click(object sender, EventArgs e)
        {
            trang_thu = 0;
            load_DL();
        }

        protected void btnTruoc_Click(object sender, EventArgs e)
        {
            trang_thu--;
            load_DL();
        }

        protected void btnSau_Click(object sender, EventArgs e)
        {
            trang_thu++;
            load_DL();
        }

        protected void btnCuoi_Click(object sender, EventArgs e)
        {
            trang_thu = p.PageCount - 1;
            load_DL();
        }

        protected void dsSP_ItemCommand(object source, DataListCommandEventArgs e)
        {
            if (e.CommandName == "Mua")
            {
                //Tính số tiền 
                double Tongtien = System.Convert.ToInt64(Session["So_tien"]);
                Label Dgia = (Label)e.Item.FindControl("lblGia");
                Tongtien += float.Parse(Dgia.Text);
                Session["So_tien"] = Tongtien;

                #region Xu ly gio hang
                MAT_HANG Hang = new MAT_HANG();
                Hang.Ten_sp = ((Label)e.Item.FindControl("TenSP")).Text;
                Hang.MaTen = ((Label)e.Item.FindControl("maTenSp")).Text;
                Hang.Ms = (int)dsSP.DataKeys[e.Item.ItemIndex];
                Hang.Don_gia = float.Parse(Dgia.Text);
                Hang.Image = ((Label)e.Item.FindControl("tenhinh")).Text;
                Hang.IsDeal = false;
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
                Session["Gio_hang"] = Giohang;
                #endregion

            }
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