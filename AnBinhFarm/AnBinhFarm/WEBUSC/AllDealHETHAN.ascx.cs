using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HP_BLL;
using HP_DAL;

namespace AnBinhFarm.WEBUSC
{
    public partial class AllDealHETHAN : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                loaddl();
            }

        }
        void loaddl()
        {
            List<Deal> dsdeal= DealBLL.getListDealHH();
            List<CTDEAL> dsCTdealhh = new List<CTDEAL>();
            int i = 0;
            foreach (Deal de in dsdeal)
            {
                Product a = ProductBLL.getProductById(de.ProductId);

                CTDEAL temp = new CTDEAL(de.ProductId,de.DealId,a.NameProduct,a.Images,a.IDNameProduct,a.Price,de.NewPrice,de.StopDate.ToString("dd/MM/yyyy"));
                dsCTdealhh.Add(temp);
                i++;
                if (i == 8)
                    break;
            }

            dsDeal.DataSource = dsCTdealhh;
            dsDeal.DataBind();
        }
        class CTDEAL
        {
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
            string maten;
            public string Maten
            {
                get
                {
                    return maten;
                }
                set
                {
                    if (maten == value)
                        return;
                    maten = value;
                }
            }
            float giagoc;
            public float Giagoc
            {
                get
                {
                    return giagoc;
                }
                set
                {
                    if (giagoc == value)
                        return;
                    giagoc = value;
                }
            }
             float giadeal;
             public float Giadeal
             {
                 get
                 {
                     return giadeal;
                 }
                 set
                 {
                     if (giadeal == value)
                         return;
                     giadeal = value;
                 }
             }
             string ngayhethan;
             public string Ngayhethan
             {
                 get
                 {
                     return ngayhethan;
                 }
                 set
                 {
                     if (ngayhethan == value)
                         return;
                     ngayhethan = value;
                 }
             }

            public CTDEAL(int pma,int pmadeal, string pten, string phinh, string pmaten, float pgiagoc, float pgiadeal, string pngayhethan)
            {
                Masp = pma;
                Madeal = pmadeal;
                Ten = pten;
                Maten = pmaten;
                Hinh = phinh;
                Giagoc = pgiagoc;
                Giadeal = pgiadeal;
                Ngayhethan = pngayhethan;
            }
        }
    }
}