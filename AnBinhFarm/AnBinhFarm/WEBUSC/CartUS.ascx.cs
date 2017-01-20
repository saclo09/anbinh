using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using HP_BLL;
using HP_DAL;
namespace AnBinhFarm.WEBUSC
{
    public partial class CartUS : System.Web.UI.UserControl
    {
        #region "Thu tuc xu ly"
        private void Lien_ket_du_lieu()
        {
            Luoi_gio_hang.DataSource = (ArrayList)Session["Gio_hang"];
            Luoi_gio_hang.DataBind();
            //cap nhat Tien va So 
            Tong_tien.Text = Tongtien().ToString()+".000 VND";
            Tong_so.Text = System.Convert.ToString(((ArrayList)Session["Gio_hang"]).Count) + "món hàng";
        }
        private double Tongtien()
        {
            double Tong = 0;
            //Duyệt qua Giohang tính tổng
            ArrayList Giohang = new ArrayList((ArrayList)Session["Gio_hang"]);
            MAT_HANG Tam;
            for (short i = 0; i < Giohang.Count; i++)
            {
                Tam = (MAT_HANG)Giohang[i];
                Tong += Tam.Thanh_tien;
            }
            Session["Tong_tien"] = Tong;
            return Tong;

        }
        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) Lien_ket_du_lieu();
        }

        protected void Luoi_gio_hang_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Xoa")
            {
                ArrayList Giohang = (ArrayList)Session["Gio_hang"];
                for (int i = 0; i < Giohang.Count; i++)
                {
                    CheckBox chk = (CheckBox)Luoi_gio_hang.Rows[i].FindControl("Chk_xoa");
                    if (chk.Checked)
                        Giohang.RemoveAt(i);
                }

                Session["Gio_hang"] = Giohang;
                Lien_ket_du_lieu();
            }

        }
        protected void Luoi_gio_hang_RowEditing(object sender, GridViewEditEventArgs e)
        {
            Luoi_gio_hang.EditIndex = e.NewEditIndex;
            Lien_ket_du_lieu();
        }
        protected void Luoi_gio_hang_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int Sl = System.Convert.ToInt32(((TextBox)Luoi_gio_hang.Rows[e.RowIndex].Cells[3].Controls[0]).Text);
            ArrayList Giohang = (ArrayList)Session["Gio_hang"];
            MAT_HANG hang = (MAT_HANG)Giohang[e.RowIndex];
            hang.So_luong = Sl;

            Session["Gio_hang"] = Giohang;
            Luoi_gio_hang.EditIndex = -1;
            Lien_ket_du_lieu();
        }

      
        protected void btnMua_Click1(object sender, EventArgs e)
        {

            Cart gh = new Cart();
            if (rdoTienmat.Checked == true)
                gh.PTThanhToan = "tiền mặt";
            else if (rdoChuyenKhoan.Checked == true)
                gh.PTThanhToan = "Chuyển khoản";
            else if (rdoBuuDien.Checked == true)
                gh.PTThanhToan = "Qua bưu điện";
            else
                gh.PTThanhToan = "Tiền mặt";

            if ((!string.IsNullOrEmpty(txtHoten.Text)) &&!string.IsNullOrEmpty(txtDiaChi.Text) && !string.IsNullOrEmpty(txtNote.Text) && !string.IsNullOrEmpty(txtSodienthoai.Text) && !string.IsNullOrEmpty(txtEmail.Text))
            {
                gh.NameKhach = txtHoten.Text;
                gh.Note = txtNote.Text;
                gh.Address = txtDiaChi.Text;
                gh.Phone = txtSodienthoai.Text;
                gh.Email = txtEmail.Text;
                gh.TotalMoney = float.Parse(Tongtien().ToString());
               if(CartBLL.InsertCart(gh.NameKhach, gh.Phone, gh.Address, gh.Note, gh.Email, gh.TotalMoney,gh.PTThanhToan)==1)
               {  
                   int idscart=CartBLL.getCartNew(gh.Phone).IdCart;
               
                    ArrayList Giohang = (ArrayList)Session["Gio_Hang"];
                    for (Int16 i = 0; i < Giohang.Count; i++)
                    {
                        MAT_HANG sp = (MAT_HANG)Giohang[i];
                        CartDetailBLL.insertCartDetail(idscart, sp.Ms, sp.So_luong, sp.Don_gia, sp.IsDeal);
                    }
                    Response.Redirect("Gio-hang-cua-ban.aspx?khach="+idscart+"&Ten="+gh.NameKhach) ;
               }
              
            }
            else
                MessageBox.Show("Thông tin bạn vừa nhập không đầy đủ!\nHãy nhập lại dùm chúng tôi nhé!");
        }
     
    }
}