using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HP_DAL;
using HP_BLL;
using System.Collections;

namespace AnBinhFarm.WEBUSC
{
    public partial class DEAL : System.Web.UI.UserControl
    {
        protected string remaingTime = String.Empty;
        public static string hinhsp="",tensp="",matensp="";
        public static int masp; public static float giasp;


        protected void Page_Load(object sender, EventArgs e)
        {
           // var expiredDate = new DateTime(2013, 03, 16, 00, 21, 0);
            // var timeLeft = expiredDate.Subtract(TimeZoneInfo.ConvertTimeBySystemTimeZoneId(DateTime.Now, "SE Asia Standard Time"));
            //remaingTime = timeLeft.TotalSeconds.ToString();
            Deal dealActive = DealBLL.getDealActiving();
            Product sp = ProductBLL.getProductById(dealActive.ProductId);
            //=========================
            tensp=sp.NameProduct;
            masp=sp.IdProduct;
            matensp=sp.IDNameProduct;
            giasp=dealActive.NewPrice;
            hinhsp=sp.Images;

            //=========================
            Image1.ImageUrl = "../Hinhsp/" + sp.Images;
            hplTenSp.Text = sp.NameProduct;
            lblGiaDeal.Text = dealActive.NewPrice.ToString("#.##0") + " VND";
            Giacu.Text = sp.Price.ToString("#.##0");
            lblPT.Text = dealActive.GiamPT.ToString() + "%";
            DateTime star = dealActive.StartDate;
            if (star < DateTime.Now)
            {
                DateTime stop = dealActive.StopDate;
                if (stop < DateTime.Now)
                {
                    btnMua.Visible = false;
                    lblhethan.Visible = true;
                }
                else
                {
                    var timeStop = new DateTime(stop.Year, stop.Month, stop.Day, stop.Hour, stop.Minute, stop.Second);
                    var timeConlai = timeStop.Subtract(TimeZoneInfo.ConvertTimeBySystemTimeZoneId(DateTime.Now, "SE Asia Standard Time"));
                    if (timeConlai.TotalSeconds > 0)
                    {
                        remaingTime =timeConlai.TotalSeconds.ToString();
                    }
                }
            }
            
        }

        protected void btnMua_Click(object sender, EventArgs e)
        {
             double Tongtien = System.Convert.ToInt64(Session["So_tien"]);
             Tongtien += giasp;
            Session["So_tien"] = Tongtien;

            #region Xu ly gio hang
            MAT_HANG Hang = new MAT_HANG();
            Hang.Ten_sp =tensp;
            Hang.MaTen =matensp;
            Hang.Image = hinhsp;
            Hang.IsDeal = true;
            Hang.Ms = masp;
            Hang.Don_gia =giasp;
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
