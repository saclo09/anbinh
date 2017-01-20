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
    public partial class Manufacturer : System.Web.UI.UserControl
    {
        public static int manhom = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                loadnhom();
                loadGRV(manhom);
            }
        }

        void loadnhom()
        {
            List<GroupIterm> dsnhomcha = GroupItermBLL.getListGroupItermMain();
         
            cboNhomSp.DataSource = dsnhomcha;
            cboNhomSp.DataTextField="NameGroup";
            cboNhomSp.DataValueField = "IDGroup";
            cboNhomSp.DataBind();
            cboNhomSp0.DataSource = dsnhomcha;
            cboNhomSp0.DataTextField = "NameGroup";
            cboNhomSp0.DataValueField = "IDGroup";
            cboNhomSp0.DataBind();
            cboNhomSp.SelectedIndex = 0;
            cboNhomSp0.SelectedIndex = 0;
        }
        void loadGRV(int nhom)
        {
            List<HP_DAL.Manufacturer> dshang = new List<HP_DAL.Manufacturer>();
           if(nhom==0)
               dshang = ManufacturerBLL.getListManufacturerIs();
           else
           {
             dshang = ManufacturerBLL.getListManufacturerBYGroup(nhom);
            }
            grvnhom.DataSource=dshang;
            grvnhom.DataBind();
        }
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            manhom = int.Parse(cboNhomSp.SelectedValue);
            loadGRV(manhom);
            cboNhomSp0.SelectedValue = manhom.ToString();
        }

        protected void btnThem_Click(object sender, EventArgs e)
        {
             
            if (!string.IsNullOrEmpty(txtTennhom.Text))
            {
              int i=  ManufacturerBLL.insertManufacturer(txtTennhom.Text, int.Parse(cboNhomSp0.SelectedValue), txtmota.Text, "hang.jpg");
                if(i==1)
                {
                    txtmota.Text="";
                    txtTennhom.Text="";
                }
            }
            
        }
    }
}