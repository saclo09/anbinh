using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HP_BLL;

namespace AnBinhFarm.Admin
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["user"] = null;
            Session["dnh"] = false;
            Session["loai"] = -1;
        }

        protected void btnDangNhap_Click(object sender, EventArgs e)
        {
           string tendn= txtUserName.Text;
            string pasx=txtPassWord.Text;
            if (AccountBLL.dangnhap(tendn, pasx))
            {
                Session["user"] = tendn;
                Session["dnh"] = true;
                Session["loai"] = AccountBLL.getAcountbyIdUserName(tendn).GroupId;
                Response.Redirect("MyAccount.aspx");
            }
            else
            {
                lblThongbao.Text = "tên đăng nhập hoặc mật khẩu không chinh xác!";
            }
        }
    }
}