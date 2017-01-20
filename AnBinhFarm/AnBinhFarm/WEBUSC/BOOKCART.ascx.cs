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
    public partial class BOOKCART : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int magh=0;
            try
            {

                magh = (string.IsNullOrEmpty(Request.QueryString["khach"])) ? 0 : int.Parse(Request.QueryString["khach"]);
            }
            catch
            {
                magh = 0;
            }
            Cart cr = CartBLL.getCarByID(magh);
            lblTen.Text = cr.NameKhach;
            lblTongtien.Text = cr.TotalMoney.ToString()+".000 VND";
            lblDiachi.Text = cr.Address;
            lblEmail.Text = cr.Email;
            lblSDT.Text = cr.Phone;
            lblGhichu.Text = cr.Note;
            lblPTTT.Text = cr.PTThanhToan;
            loadGRV(magh);
            MessageBox.Show("Cảm ơn " + cr.NameKhach + "đã đặt hàng của chúng tôi!  Chúng tôi sẽ liên hệ với bạn sớm nhất.");
        }
        void loadGRV(int magh)
        {
            List<CartDetail> dsGH = CartDetailBLL.getListCartDetailByCart(magh);
            List<MAT_HANG> dshang=new List<MAT_HANG>();
            foreach (CartDetail ca in dsGH)
            {
                MAT_HANG temp = new MAT_HANG();
                temp.Ms = ca.IdProduct;
                Product sp = ProductBLL.getProductById(ca.IdProduct);
                temp.MaTen = sp.IDNameProduct;
                temp.Ten_sp = sp.NameProduct;
                temp.Image = sp.Images;
                temp.So_luong = ca.AMount;
                temp.IsDeal = ca.IsDeal;
                temp.Don_gia = ca.PriceSaled;
                dshang.Add(temp);
            }
            GridView1.DataSource = dshang;
            GridView1.DataBind();
        }
    }
}