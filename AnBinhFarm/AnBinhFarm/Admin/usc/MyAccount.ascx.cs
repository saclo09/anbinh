using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HP_DAL;
using HP_BLL;

namespace AnBinhFarm.Admin.usc
{
    public partial class MyAccount : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Account my = AccountBLL.getAcountbyIdUserName("Admin");//AccountBLL.getAcountbyIdUserName(Session["user"].ToString());
                txtUs.Text = my.Username;
                txtDienthoai.Text = my.Phone;
                txtEmail.Text = my.Email;
                txtTen.Text = my.FullName;
            }
        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtMKC.Visible = CheckBox1.Checked;
            txtMkhmoi.Visible = CheckBox1.Checked;
            txtMKmoiCF.Visible = CheckBox1.Checked;
            Button1.Visible = CheckBox1.Checked;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (AccountBLL.dangnhap(Session["user"].ToString(), txtMKC.Text))
            {
                if (txtMkhmoi.Text == txtMKmoiCF.Text && txtMKmoiCF.Text.Length >= 3)
                {
                    Account tk = AccountBLL.getAcountbyIdUserName(Session["user"].ToString());
                    int i = AccountBLL.MyupDateAccountPass(tk.IdAccount, txtMkhmoi.Text, tk.FullName, tk.Phone, tk.Email);
                    if (i == 1)
                    {
                        MessageBox.Show("Đã thay đổi mật khẩu thành công");
                    }
                }
            }
        }

        protected void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDienthoai.Text) || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtTen.Text))
            {
            }
            else
            {

                Account tk = AccountBLL.getAcountbyIdUserName(Session["user"].ToString());
                int i = AccountBLL.MyupDateAccount(tk.IdAccount, tk.Password, txtTen.Text, txtDienthoai.Text, txtEmail.Text);
                if (i == 1)
                {
                    MessageBox.Show("Đã thay đổi thông tin thành công thành công");
                }
            }
        }
    }
}