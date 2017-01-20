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
    public partial class AccountManager : System.Web.UI.UserControl
    {
        public static int Accsua;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (int.Parse(Session["loai"].ToString()) != 1)
            {
                Response.Redirect("~/Admin/MyAccount.aspx");
            }
            if (!IsPostBack)
                loadDL();
        }

        void loadDL()
        {
            List<Account> dsac = AccountBLL.getListAcountActive();
            grvAccount.DataSource = dsac;
            grvAccount.DataKeyNames = new string[] { "IdAccount" };
            grvAccount.DataBind();
        }
        protected void Button1_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(txtUsername.Text) || (txtPass.Text != txtPassConfilm.Text) || string.IsNullOrEmpty(txtPass.Text))
            {
                MessageBox.Show("bạn nhập chưa đầy đủ hoặc chưa đúng!");
            }
            else
            {
                string tendn = txtUsername.Text;
                string pass = txtPass.Text;
                string hoten = string.IsNullOrEmpty(txtFullName.Text) ? "chua nhap" : txtFullName.Text;
                string dienthoai = string.IsNullOrEmpty(txtSdt.Text) ? "chua nhap" : txtSdt.Text;
                string email = string.IsNullOrEmpty(txtEmail.Text) ? "chua nhap" : txtEmail.Text;
                int group = 1;
                if (rdo1.Checked == true) group = 0;
                string nguoitao = Session["user"].ToString();

                int a = AccountBLL.insertAccount(tendn, pass, hoten, dienthoai, email, group, nguoitao);
                if (a == 1)
                {
                    MessageBox.Show("Bạn đã tạo thành công!");
                    txtUsername.Text = "";
                    txtPass.Text = "";
                    txtPassConfilm.Text = "";
                    txtFullName.Text = "";
                    txtEmail.Text = "";
                    loadDL();
                }
                else
                {
                    MessageBox.Show("Bạn đã tạo không thành công!");
                }
            }


        }

        protected void btnSua_Click(object sender, EventArgs e)
        {
            int gr = 0;
            if (rdo2.Checked == true) gr = 1;
            bool delete = false;
            if (ckbDelete.Checked == true) delete = true;
            string ten = Session["user"].ToString();
            if (AccountBLL.upDateAccount(Accsua, txtFullName.Text, txtSdt.Text, txtEmail.Text, gr, delete, ten) == 1)
            {
                MessageBox.Show("sửa thành công!");
            }
            else
            {
                MessageBox.Show("Sửa ko thành công!");
            }
            Button1.Visible = !false;
            btnSua.Visible = !true;
            ckbDelete.Visible = !true;
            lbltieuDe.Text = "Thêm mới người dùng";
            txtUsername.Text = "";
            txtUsername.ReadOnly = !true;
            txtPass.ReadOnly = !true;
            txtPassConfilm.ReadOnly = !true;
            txtFullName.Text = "";
            txtSdt.Text = "";
            txtEmail.Text = "";

        }

        protected void grvAccount_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName.ToUpper() == "SUA")
            {

                Accsua = int.Parse(grvAccount.Rows[int.Parse(e.CommandArgument.ToString())].Cells[0].Text);
                Button1.Visible = false;
                btnSua.Visible = true;
                ckbDelete.Visible = true;
                lbltieuDe.Text = "Sửa người dùng";
                Account a = AccountBLL.getAcountbyId(Accsua);
                txtUsername.Text = a.Username;
                txtUsername.ReadOnly = true;
                txtPass.ReadOnly = true;
                txtPassConfilm.ReadOnly = true;
                txtFullName.Text = a.FullName;
                txtSdt.Text = a.Phone;
                txtEmail.Text = a.Email;
                if (a.GroupId == 1) rdo2.Checked = true; else rdo1.Checked = true;
                ckbDelete.Checked = a.IsDelete;

            }
        }

    }
}