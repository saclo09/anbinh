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
    public partial class DealManager : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                loadDealActive();
                loadGRV();
            }
        }

        void loadDealActive()
        {
            Deal D_AT = DealBLL.getDealActiving();
            lblTEDEAL.Text = ProductBLL.getProductById(D_AT.ProductId).NameProduct;
            lblMa.Text = ProductBLL.getProductById(D_AT.ProductId).IDNameProduct;
            lblGiacuu.Text = ProductBLL.getProductById(D_AT.ProductId).Price.ToString("0.000VNĐ");
            lblGiamoi.Text = D_AT.NewPrice.ToString("0.000VNĐ");
            imghinh.ImageUrl = "../../Hinhsp/" + ProductBLL.getProductById(D_AT.ProductId).Images;
            lblPhantram.Text = D_AT.GiamPT.ToString();
            lblThoigaibd.Text = D_AT.StartDate.ToString("dd/MM/yyyy hh:mm tt");
            lblThoigaikt.Text = D_AT.StopDate.ToString("dd/MM/yyyy hh:mm tt");
        }
        void loadGRV()
        {
            List<Deal> dssdeal = DealBLL.getListDeal();
            List<deal> dsdealct=new List<deal>();
            foreach (Deal temp in dssdeal)
            {
                deal tt = new deal();
                tt.Tendeal = ProductBLL.getProductById(temp.ProductId).NameProduct;
                tt.Giacu = ProductBLL.getProductById(temp.ProductId).Price;
                tt.Hinh = ProductBLL.getProductById(temp.ProductId).Images;
                tt.Giamoi = temp.NewPrice;
                tt.Pt = temp.GiamPT;
                tt.Tgbatdau = temp.StartDate;
                tt.TgKetthuc = temp.StopDate;
                tt.Madeal = temp.DealId;
                tt.Masp = temp.ProductId;
                dsdealct.Add(tt);
                
            }
            grvDEAl.DataSource = dsdealct;
            grvDEAl.DataBind();

        }
        class deal
        {
            int madeal;
            public int Madeal
            {
                get
                {
                    return madeal;
                }
                set
                {
                    if (madeal == value)
                        return;
                    madeal = value;
                }
            }
            int masp;
            public int Masp
            {
                get
                {
                    return masp;
                }
                set
                {
                    if (masp == value)
                        return;
                    masp = value;
                }
            }
            string tendeal;
            public string Tendeal
            {
                get
                {
                    return tendeal;
                }
                set
                {
                    if (tendeal == value)
                        return;
                    tendeal = value;
                }
            }
            float giamoi;
            public float Giamoi
            {
                get
                {
                    return giamoi;
                }
                set
                {
                    if (giamoi == value)
                        return;
                    giamoi = value;
                }
            }
            float giacu;
            public float Giacu
            {
                get
                {
                    return giacu;
                }
                set
                {
                    if (giacu == value)
                        return;
                    giacu = value;
                }
            }
            string hinh;
            public string Hinh
            {
                get
                {
                    return hinh;
                }
                set
                {
                    if (hinh == value)
                        return;
                    hinh = value;
                }
            }
            int pt;
            public int Pt
            {
                get
                {
                    return pt;
                }
                set
                {
                    if (pt == value)
                        return;
                    pt = value;
                }
            }
            DateTime tgbatdau;
            public DateTime Tgbatdau
            {
                get
                {
                    return tgbatdau;
                }
                set
                {
                    if (tgbatdau == value)
                        return;
                    tgbatdau = value;
                }
            }
            DateTime tgKetthuc;
            public DateTime TgKetthuc
            {
                get
                {
                    return tgKetthuc;
                }
                set
                {
                    if (tgKetthuc == value)
                        return;
                    tgKetthuc = value;
                }
            }
        }
        protected void btnthemmoi_Click(object sender, EventArgs e)
        {
            Response.Redirect("NewDeal.aspx");
        }

        protected void grvDEAl_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grvDEAl.PageIndex = e.NewPageIndex;
            loadGRV();
        }

  
    }
}