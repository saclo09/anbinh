using HP_BLL;
using HP_DAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AnBinhFarm.WEBUSC
{
    public partial class ProductList : System.Web.UI.UserControl
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


            //=======================================
            p.DataSource = ProductBLL.GetListProductAndHarvest();
            p.PageSize = 28;
            p.CurrentPageIndex = trang_thu;
            p.AllowPaging = true;
            tongtrang = p.PageCount;

            if (trang_thu >= tongtrang)
            {
                trang_thu = 0;
                load_DL();
            }

            //=======liên kết nguồn vào GRV=========
            dsSP.DataSource = p;
            rptProductDetail.DataSource = p;
            dsSP.DataMember = "IdProduct";
            dsSP.DataBind();
            rptProductDetail.DataBind();
            //================            

        }




        protected void dsSP_ItemCommand(object source, DataListCommandEventArgs e)
        {
            if (e.CommandName == "Mua")
            {
                //Tính số tiền 
                double Tongtien = System.Convert.ToInt64(Session["So_tien"]);
                Label Dgia = (Label)e.Item.FindControl("lblGia2");
                float dongia = 0;
                try
                {

                    dongia = float.Parse(Dgia.Text);
                }
                catch { }
                Tongtien += dongia;
                Session["So_tien"] = Tongtien;

                #region Xu ly gio hang
                MAT_HANG Hang = new MAT_HANG();
                Hang.Ms = (int)dsSP.DataMember[e.Item.ItemIndex];
                Hang.Ten_sp = ((Label)e.Item.FindControl("TenSP")).Text;
                Hang.MaTen = ((Label)e.Item.FindControl("maTenSp")).Text;
                Hang.Don_gia = dongia;
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
        protected void rptProductDetail_ItemDataBound(object sender, RepeaterItemEventArgs args)
        {
            if (args.Item.ItemType == ListItemType.Item || args.Item.ItemType == ListItemType.AlternatingItem)
            {
                Repeater childRepeater = (Repeater)args.Item.FindControl("rptHarvestList");
                List<Harvest> HarvestList = ((Product)args.Item.DataItem).HarvestList;
                childRepeater.DataSource = HarvestList;
                childRepeater.DataBind();
            }
        }

        
    }
}